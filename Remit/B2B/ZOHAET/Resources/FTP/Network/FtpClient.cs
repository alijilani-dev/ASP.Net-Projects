using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Network
{
	/// <summary>
	/// Transfer mode for files
	/// </summary>
	public enum TransferMode
	{
		/// <summary>
		/// ASCII transfer mode
		/// </summary>
		Ascii,
		/// <summary>
		/// Binary transfer mode 
		/// </summary>
		Binary
	}
	/// <summary>
	/// FtpClient class performs the actions of a simple ftp client
	/// </summary>
	public class FtpClient
	{
		private bool bConnectionOpen = false;
		private bool bStreamReady = false;
		private string m_sUsername = "";
		private string m_sPassword = "";
		private string m_sHost = "";
		private int m_iPort = 21;

		private TcpClient m_tcpClient = null;
		private NetworkStream m_commandStream = null;
		private StreamReader m_comRead = null;

		/// <summary>
		/// Initializes the ftp client
		/// </summary>
		/// <param name="sHost">Hostname of the remote machine</param>
		/// <param name="sUser">User name of the remote machine account</param>
		/// <param name="sPassword">Password of the remote machine account</param>
		public FtpClient(string sHost, string sUser, string sPassword)
		{
			m_sHost = sHost;
			m_sUsername = sUser;
			m_sPassword = sPassword;
		}
		/// <summary>
		/// Initializes the ftp client
		/// </summary>
		/// <param name="sHost">Hostname of the remote machine</param>
		public FtpClient(string sHost)
		{
			m_sHost = sHost;
		}

		/// <summary>
		/// Initializes the ftp client
		/// </summary>
		/// <param name="sHost">Hostname of the remote machine</param>
		/// <param name="iPort">Port of the remote machine</param>
		public FtpClient(string sHost, int iPort)
		{
			m_sHost = sHost;
			m_iPort = iPort;
		}

		/// <summary>
		/// Username of the remote machine account
		/// </summary>
		public string Username
		{
			get
			{
				return m_sUsername;
			}
			set
			{
				m_sUsername = value;
			}
		}

		/// <summary>
		/// Password of the remote machine account
		/// </summary>
		public string Password
		{
			get
			{
				return m_sPassword;
			}
			set
			{
				m_sPassword = value;
			}
		}

		/// <summary>
		/// Hostname of the remote machine
		/// </summary>
		public string Host
		{
			get
			{
				return m_sHost;
			}
			set
			{
				m_sHost = value;
			}
		}

		/// <summary>
		/// FTP port of the remote machine. This property is set to 21 by default
		/// </summary>
		public int Port
		{
			get
			{
				return m_iPort;
			}
			set
			{
				m_iPort = value;
			}
		}

		/// <summary>
		/// Opens the connection to the remote machine
		/// </summary>
		public void Open()
		{
			if (bConnectionOpen)
			{
				throw new FtpClientException(1,"Connection already open");
			}

			try 
			{
				m_tcpClient = new TcpClient(m_sHost, m_iPort);
				m_tcpClient.ReceiveBufferSize = 4096; // alocate a 4kb buffer (for extra large MOTDs)
			} 
			catch (SocketException e) 
			{
				throw new FtpClientException(e.ErrorCode,"FtpClient cannot establish a connection");
			}

			m_commandStream = m_tcpClient.GetStream();      // get the command stream
			m_comRead = new StreamReader(m_commandStream);  // now we can read the stream
			//m_comWrite = new StreamWriter(m_commandStream,System.Text.Encoding.ASCII); // and write to it(hmmm .. in beta 2 that is
			// we just successfully connected so the server welcomes us with a 220 response
			string sOut = m_comRead.ReadLine();
			if (sOut.Substring(0,3) != "220") { throw new FtpClientException(3, "Unrecognized response on connect"); }
			WriteToStream("USER " + m_sUsername); // send our user name
			// the server must reply with 331
			sOut = m_comRead.ReadLine();
			if (sOut.Substring(0,3) != "331") { throw new FtpClientException(4, "User does not exist on the remote machine, or anonymous access is blocked"); }
			WriteToStream("PASS " + m_sPassword); // send our password
			sOut = m_comRead.ReadLine();
			// the server must reply with 230, which is a successful login
			// after that the server's MOTD/disclaimer might follow, so we
			// will async-read the stream to the end after we get the first response line
			// to the end of it, this is needed for really slow connections(this still happens:)
			// because we can't issue commands to the server until it sends us everything
			if (sOut.Substring(0,3) != "230") { throw new FtpClientException(5, "Password is incorrect for this user"); }
			if (m_commandStream.DataAvailable) 
			{
				m_commandStream.BeginRead(new byte[4096],0,4096,new AsyncCallback(ReadEnd),null);
			} 
			else 
			{
				bStreamReady = true;
			}
			bConnectionOpen = true;
		}

		/// <summary>
		/// Sets the current remote directory
		/// </summary>
		/// <param name="sDirectory">Directory name</param>
		public void SetCurrentDirectory(string sDirectory)
		{
			if (!bConnectionOpen)
			{
				throw new FtpClientException(6,"Connection not open");
			}
			while (!bStreamReady)
			{
				// wait for the server to become ready for more commands
				System.Threading.Thread.Sleep(200);
			}
			WriteToStream("CWD " + sDirectory); // send the command to change directory
			string sOut = m_comRead.ReadLine();
			// server must reply with 250, else the directory does not exist
			if (sOut.Substring(0,3) != "250") { throw new FtpClientException(7, "Remote directory does not exist"); }
		}

		/// <summary>
		/// Gets a file from the ftp server, if sRemoteFilename contains a mask only the
		/// first file matching the mask is received.
		/// </summary>
		/// <param name="sLocalFilename">Full filename of the local file [Path+Name]</param>
		/// <param name="sRemoteFilename">Remote file name</param>
		/// <param name="mode">Transfer mode constant</param>
		public void ReceiveFile(string sLocalFilename, string sRemoteFilename, TransferMode mode)
		{
			// create a new file
			FileStream fStream = new FileStream(sLocalFilename,FileMode.Create,FileAccess.ReadWrite,FileShare.Read,1024,false);
			string sOut = null;
			// set mode
			switch (mode)
			{
				case TransferMode.Ascii:
				{
					WriteToStream("TYPE A");
					sOut = m_comRead.ReadLine(); // consume the return message
					break;
				}
				case TransferMode.Binary:
				{
					WriteToStream("TYPE I");
					sOut = m_comRead.ReadLine(); // consume the return message
					break;
				}
			}

			// get a list of IP addresses for this machine
			IPHostEntry ipThis = Dns.GetHostByName(Dns.GetHostName());
			Random r = new Random();
			int port = 0;
			bool bIPFound = false;
			// we will try all IP addresses assigned to this machine
			// the first one that the remote machine likes will be chosen
			for(int i=0;i<ipThis.AddressList.Length;i++)
			{
				string ip = ipThis.AddressList[i].ToString().Replace(".",",");
				int p1 = r.Next(100);
				int p2 = r.Next(100);
				port = 256*p1+p2;
				string sPortCom = "PORT " + ip + "," + p1.ToString() + "," + p2.ToString();
				// Port command now looks like PORT 61,45,6,34,xx,yy where
				// first 4 values is your IP address and xx and yy are random numbers
				// 256*xx+yy will be the port number where the remote machine will connect
				// and send data
				WriteToStream(sPortCom);
				sOut = m_comRead.ReadLine();
				if (sOut.Substring(0,3) == "200")
				{
					// PORT command accepted
					bIPFound = true;
					break;
				}
			}

			if (!bIPFound) { throw new FtpClientException(8,"Could not find suitable IP address"); }

			// now we are ready for transfer
			// set up a listener and start listening
			TcpListener conn = new TcpListener(port);
			conn.Start();
			// issue the download command
			WriteToStream("RETR " + sRemoteFilename);
			sOut = m_comRead.ReadLine();
			// we will get either a confirmation of the download(150) or that file does not exist(550)
			if (sOut.Substring(0,3) == "550") { throw new FtpClientException(9,"Could not find remote file"); }

			// start the download
			byte [] bData = new byte[1024];
			int bytesRead = 0;
			Socket xfer = null;
			try 
			{
				xfer = conn.AcceptSocket();
				bytesRead = xfer.Receive(bData,0,1024,SocketFlags.None);
				fStream.Write(bData,0,bytesRead);
				while(bytesRead>0)
				{
					bytesRead = xfer.Receive(bData,0,1024,SocketFlags.None);
					fStream.Write(bData,0,bytesRead);
				}
				fStream.Close();
				xfer.Shutdown(SocketShutdown.Both);
				xfer.Close();
				conn.Stop();
				conn = null;
				xfer = null;
				fStream = null;
				sOut = m_comRead.ReadLine(); // consume the "226 Transfer Complete" response
			} 
			catch (Exception e) 
			{
				throw e; // propagate the exception
			}
		}

		/// <summary>
		/// Puts a file to the ftp server, if sRemoteFilename contains a mask only the
		/// first file matching the mask is received.
		/// </summary>
		/// <param name="sLocalFilename">Full filename of the local file [Path+Name]</param>
		/// <param name="sRemoteFilename">Remote file name</param>
		/// <param name="mode">Transfer mode constant</param>
		public void SendFile(string sLocalFilename, string sRemoteFilename, TransferMode mode)
		{
			// create a new file
			FileStream fStream = new FileStream(sLocalFilename,FileMode.Open,FileAccess.Read,FileShare.Read,1024,false);
			string sOut = null;
			// set mode
			switch (mode)
			{
				case TransferMode.Ascii:
				{
					WriteToStream("TYPE A");
					sOut = m_comRead.ReadLine(); // consume the return message
					break;
				}
				case TransferMode.Binary:
				{
					WriteToStream("TYPE I");
					sOut = m_comRead.ReadLine(); // consume the return message
					break;
				}
			}

			// get a list of IP addresses for this machine
			IPHostEntry ipThis = Dns.GetHostByName(Dns.GetHostName());
			Random r = new Random();
			int port = 0;
			bool bIPFound = false;
			// we will try all IP addresses assigned to this machine
			// the first one that the remote machine likes will be chosen
			for(int i=0;i<ipThis.AddressList.Length;i++)
			{
				string ip = ipThis.AddressList[i].ToString().Replace(".",",");
				int p1 = r.Next(100);
				int p2 = r.Next(100);
				port = 256*p1+p2;
				string sPortCom = "PORT " + ip + "," + p1.ToString() + "," + p2.ToString();
				// Port command now looks like PORT 61,45,6,34,xx,yy where
				// first 4 values is your IP address and xx and yy are random numbers
				// 256*xx+yy will be the port number where the remote machine will connect
				// and receive
				WriteToStream(sPortCom);
				sOut = m_comRead.ReadLine();
				if (sOut.Substring(0,3) == "200")
				{
					// PORT command accepted
					bIPFound = true;
					break;
				}
			}

			if (!bIPFound) { throw new FtpClientException(8,"Could not find suitable IP address"); }

			// now we are ready for transfer
			// set up a listener and start listening
			TcpListener conn = new TcpListener(port);
			conn.Start();
			// issue the upload command
			WriteToStream("STOR " + Path.GetFileName(sLocalFilename));
			sOut = m_comRead.ReadLine();
			// we will get either a confirmation of the download(150) or an error message
			if (sOut.Substring(0,3) == "550") { throw new FtpClientException(9,"Could not find remote file"); }

			// start the download
			byte [] bData = new byte[1024];
			int bytesRead = 0;
			Socket xfer = null;
			try 
			{
				xfer = conn.AcceptSocket();
				bytesRead = fStream.Read(bData,0,1024);
				xfer.Send(bData,0,bytesRead,SocketFlags.None);
				while(bytesRead>0)
				{
					bytesRead = fStream.Read(bData,0,1024);
					xfer.Send(bData,0,bytesRead,SocketFlags.None);
				}
				fStream.Close();
				xfer.Shutdown(SocketShutdown.Both);
				xfer.Close();
				conn.Stop();
				conn = null;
				xfer = null;
				fStream = null;
				sOut = m_comRead.ReadLine(); // consume the "226 Transfer Complete" response
			} 
			catch (Exception e) 
			{
				throw e; // propagate the exception
			}
		}
		/// <summary>
		/// Closes the connection to remote host
		/// </summary>
		public void Close()
		{
			m_comRead.Close();
			m_commandStream.Close();
			m_tcpClient.Close();
			bConnectionOpen = false;
			bStreamReady = false;
		}

		private void WriteToStream(string command)
		{
			// this is interesting, in Beta 2 of .NET I was able to use the
			// StreamWriter to write to the stream. Now I am not, the stream becomes
			// blocked, so this method writes a byte array directly to the stream
			m_commandStream.Write(System.Text.Encoding.ASCII.GetBytes(command+"\n"),0,command.Length+1);
		}

		private void ReadEnd(IAsyncResult ar)
		{
			bStreamReady = true;
		}
	}
}
