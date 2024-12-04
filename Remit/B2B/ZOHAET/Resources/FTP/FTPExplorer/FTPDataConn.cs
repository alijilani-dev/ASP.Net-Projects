namespace FTPExplorer
{
    using System;
	using System.Net.Sockets;
	using System.Net;
	using System.IO;
	using System.Text;

    /// <summary>
    ///    Summary description for FTPListener.
    /// </summary>
    public class FTPDataConn
    {
		private TCPListener m_FTPDataListener;
		private Socket m_ClientSocket;
		private int m_iDataPort;
		private string m_strErrorMessage;
		private int m_iRecvTimeout,m_iSendTimeout;

        public FTPDataConn()
        {
            //
            // TODO: Add Constructor Logic here
            //
			m_FTPDataListener = null;
			m_ClientSocket = null;

			/*	2133 is hard coded for time being */
			m_iDataPort = 2133;
			m_strErrorMessage = "";

			m_iRecvTimeout = 5000;
			m_iSendTimeout = 3000;
		}

		/*	Implments the LIST command */
		public int GetList(){
			/*	Start the Listener */
			if ( StartDataListener() == 0 ) {
				return 0;
			}

			//m_ClientSocket = new Socket(AddressFamily.AfINet,SocketType.SockStream,ProtocolType.ProtTCP);

			/*	Wait for client connection */
			
			m_ClientSocket = m_FTPDataListener.Accept();

			/*	Set Socket Options */
			m_ClientSocket.SetSockOpt(SocketOption.SolSocket,SocketOption.SoRcvTimeo,m_iRecvTimeout);
			m_ClientSocket.SetSockOpt(SocketOption.SolSocket,SocketOption.SoSndTimeo,m_iSendTimeout);
			
			/*	Get the data from client */
			Byte[] l_bSendData = new Byte[512];
			Byte[] l_bRecvData = new Byte[512];
			string l_strOutput = "",l_strTemp = "";
			int l_iRetval = 0;

			for ( ; ( l_iRetval = m_ClientSocket.Receive(l_bRecvData,511,0)) > 0 ;  ) {
				l_strTemp = Encoding.ASCII.GetString(l_bRecvData,0,l_iRetval);
				l_strOutput += l_strTemp;
			}
			return 1;	
		}

		private int StartDataListener() {
			try {
				m_FTPDataListener = new TCPListener(m_iDataPort);
				m_FTPDataListener.Start();
			}
			catch (SocketException e ) {
				m_strErrorMessage = "Error :" + e;
				return 0;
			}
			return 1;
		}

		public int GetDataPort(){
			return m_iDataPort;
		}

		public void SetDataPort(int l_iPort){
			m_iDataPort = l_iPort;
		}

		public string GetLastError(){
			return m_strErrorMessage;
		}
    }
}
