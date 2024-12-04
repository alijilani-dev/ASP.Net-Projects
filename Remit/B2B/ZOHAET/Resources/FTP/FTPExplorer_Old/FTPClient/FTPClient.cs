using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;
using System.Data;
using System.Diagnostics;

namespace NiranjanFTP
{
	/// <summary>
	/// Summary description for FTPClient.
	/// </summary>
	public class FTPClient
	{
		private string m_strFTPServer;
		private string m_strUserID;
		private string m_strPassword;
		private string m_strError;
		private int m_iPort;
		private int m_iRecvTimeOut;
		private int m_iSendTimeOut;
		private string m_strServerType;
		private int m_iServerOS;
		private string m_strRootDir;
		private string m_strCurrentWorkingDir;
		private string m_strLocalWorkingDir;
		private int m_iDataPort;
		private char m_chTransferType;
		private Socket m_ClientSocket;
		public string ErrorMessage {
			get {
				string l_strTemp = "Error : " + m_strError;
				return  l_strTemp; 
			}
		}

		public int ServerOS {
			get { return m_iServerOS;}
		}

		/// <summary>
		/// No argument constructor
		/// </summary>
		public FTPClient()
		{
			//
			// TODO: Add constructor logic here
			//
			m_strFTPServer = "";
			m_strUserID = "";
			m_strPassword = "";
			m_iPort = 21;
			m_iSendTimeOut = 1000;
			m_iRecvTimeOut = 3000;
			
			m_strServerType = "";
			m_iServerOS = 0;
			m_iDataPort = 12000;
			m_strRootDir = "";
			m_strCurrentWorkingDir = "";
			m_strLocalWorkingDir = "";
			m_chTransferType = 'A';
		}

		/// <summary>
		/// Overloaded constructor that initializes all parameters of a socket connection
		/// </summary>
		/// <param name="l_strFTPServer">FTP Server Name or IP address</param>
		/// <param name="l_strUserID">FTP User Id</param>
		/// <param name="l_strPassword">Password</param>
		/// <param name="l_iPort">FTP Port</param>
		/// <param name="l_iSendTimeOut">Send timeout in milli seconds</param>
		/// <param name="l_iRecvTimeOut">Recv timeout in milli seconds</param>
		public FTPClient(string l_strFTPServer,string l_strUserID, string l_strPassword,int l_iPort,int l_iSendTimeOut,int l_iRecvTimeOut){
			m_strError = "";
			m_strFTPServer = l_strFTPServer;
			m_strUserID = l_strUserID;
			m_strPassword = l_strPassword;
			m_iPort = l_iPort;
			m_iSendTimeOut = l_iSendTimeOut;
			m_iRecvTimeOut = l_iRecvTimeOut;
			m_strServerType = "";
			m_iServerOS = 0;
			m_iDataPort = 12000;
			m_strRootDir = "";
			m_strCurrentWorkingDir = "";
			m_strLocalWorkingDir = "";
			m_chTransferType = 'A';
		}

		public string FTPServer {
			get { return m_strFTPServer;}
			set { m_strFTPServer = value;}
		}

		public string UserID {
			get { return m_strUserID;}
			set { m_strUserID = value;}
		}

		public string Password {
			get { return m_strPassword;}
			set { m_strPassword = value;}
		}
		
		public int Port {
			get { return m_iPort;}
			set { m_iPort = value;}
		}

		public int SendTimeOut {
			get { return m_iSendTimeOut;}
			set { m_iSendTimeOut = value;}
		}
		
		public int RecvTimeOut {
			get { return m_iRecvTimeOut;}
			set { m_iRecvTimeOut = value;}
		}

		/// <summary>
		/// Root directory of FTP Server
		/// </summary>
		public string RootDirectory {
			get { return m_strRootDir;}
		}

		/// <summary>
		/// Current Working directory in FTP Server
		/// </summary>
		public string CurrentDirectory {
			get { return m_strCurrentWorkingDir;}
		}

		/// <summary>
		/// Transfer mode
		/// </summary>
		public char TransferMode {
			get { return m_chTransferType;}
			set { m_chTransferType = value;}
		}

		/// <summary>
		/// Current Local Working directory
		/// </summary>
		public string LocalWorkingDirectory {
			get { return m_strLocalWorkingDir;}
			set { m_strLocalWorkingDir = value;}
		}

		/// <summary>
		/// Connects to FTP Server and authenticates the user
		/// </summary>
		/// <returns>1 if success, else 0</returns>
		public int Connect(){
			if ( m_strFTPServer == ""){
				m_strError = "FTP Server is empty";
				return 0;
			}
			if ( m_strUserID == ""){
				m_strError = "User ID is empty";
				return 0;
			}
			if ( m_strPassword == ""){
				m_strError = "Password is empty";
				return 0;
			}

			try {
				/*	Resolve IP address here */
				IPEndPoint l_IPServer;
				IPHostEntry l_hostAddress;

				l_hostAddress = Dns.Resolve(m_strFTPServer);
				IPAddress l_IPAddress = l_hostAddress.AddressList[0];
				l_IPServer = new IPEndPoint(l_IPAddress,m_iPort);

				/* Create the Socket */
				m_ClientSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
				
				/* Set Socket Options */
				m_ClientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout,m_iRecvTimeOut);
				m_ClientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout,m_iSendTimeOut);

				/* Connect to FTP Server */
				m_ClientSocket.Connect(l_IPServer);

				/* Receive acknowledgement message */
				string l_strResponseData = "";
				Byte[] l_bRecvData = new Byte[256];
				l_bRecvData.Initialize();

				/*	Get Response data */
				int l_iRetval = m_ClientSocket.Receive(l_bRecvData);
				if ( l_iRetval == 0 ) {
					m_strError = "Error while connecting to FTP Server, Connection closed by remote host";
					return 0;
				}
				else if ( l_iRetval == -1 ) {
					m_strError = "Error while connecting to FTP Server, Invalid Socket";
					return 0;
				}
				else {
					l_strResponseData = Encoding.ASCII.GetString(l_bRecvData,0,l_iRetval);
				}
				
				/* Check for Server Response */
				string l_strResponseCode = l_strResponseData.Substring(0,3);
				l_iRetval = ParseResponseCode("CONNECT",l_strResponseCode);
				if ( l_iRetval == 0 ){
					m_strError = "Error while connecting to FTP Server : " + l_strResponseData.Substring(4,l_iRetval);
					return 0;
				}

				string l_strCommand = "";
				string l_strOutput = "";
				l_iRetval = 0;

				/* USER Command */
				l_strCommand = "USER " + m_strUserID + "\r\n";
				l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					m_strError = "Error while validating User ID :" + l_strOutput.Substring(4);
					return 0;	
				}

				/*	PASS command */
				l_strOutput = "";
				l_strCommand = "PASS " + m_strPassword + "\r\n";
				l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					m_strError = "Error while authenticating your password :" + l_strOutput.Substring(4);
					return 0;	
				}

				/*	SYST command */
				l_strOutput = "";
				l_strCommand = "SYST\r\n";
				l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					CloseConnection();
					return 0;
				}
				
				m_strServerType = l_strOutput;
				if ( l_strOutput == null || l_strOutput.Length == 0 ) {
					m_strError = "Error in response for SYST command";
					return 0;
				}

				string lstr_temp1 = m_strServerType.Remove(0,4);
				string lstr_temp = lstr_temp1.Substring(0,4);
				if ( lstr_temp == "UNIX" ) {
					m_iServerOS = 1;
				}
				else if ( lstr_temp == "Wind" ) {
					m_iServerOS = 2;
				}
				else {
					m_iServerOS = 3;
					/*	Currently not supported */
					m_strError = "This version of FTP Explorer supports browsing only on Windows and Unix based FTP Services. FTP browsing on other FTP services will be enabled in future versions.";
					CloseConnection();
					return 0;
				}

				/*	Get the current working directory */
				/*	PWD */
				l_strOutput = "";
				l_strCommand = "PWD\r\n";
				l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					CloseConnection();
					return l_iRetval;	
				}
				string l_strRootDir = ParseForPWD(l_strOutput);
				m_strCurrentWorkingDir = m_strRootDir = l_strRootDir;

				/*	MODE command, Set Mode = Stream */
				l_strOutput = "";
				l_strCommand = "MODE S\r\n";
				l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					return 0;
				}

				/*	TYPE command, Set Type = ASCII */
				l_strCommand = "TYPE A\r\n";
				l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					return 0;
				}

				return 1;
			}
			catch ( Exception e){
				m_strError = e.Message;
				return 0;
			}
		}

		/// <summary>
		/// Parses the output of PWD command
		/// </summary>
		/// <param name="l_strInput">Output string from PWD Command </param>
		/// <returns>The current Directory</returns>
		private string ParseForPWD(string l_strInput){
			int l_iCount = 0;
			int l_iLen = l_strInput.Length;
			string l_strOutput = "";
			for ( ; l_iCount < l_iLen ; l_iCount++) {
				if ( l_strInput[l_iCount] == '"' ){
					for ( l_iCount++ ; l_iCount < l_iLen && l_strInput[l_iCount] != '"' ; l_iCount++) {
						l_strOutput += l_strInput[l_iCount];
					}
				}
			}
			return l_strOutput;
		}

		/// <summary>
		/// Parses output code
		/// </summary>
		/// <param name="l_strResponseData">Response data </param>
		/// <returns>1 if success, else 0</returns>
		private int ParseResponseCode(string l_strCommand,string l_strResponseCode){
			
			int l_iResponseCode = 0, l_iRetval = 0;
			try {
				
				if ( l_strResponseCode.Length > 0 ) {
					l_iResponseCode = int.Parse(l_strResponseCode);
				}
			}
			catch ( FormatException e ) {
				m_strError = "Unrecognized Response code from Server" ;
				return 0;
			}

			/*	421 Error is trapped as a common error */
			if ( l_iResponseCode == 421 ) {
				m_strError = "Service not available, closing control connection. Please try after some time" ;
				return 0;
			}

			if ( l_iResponseCode == 200 || l_iResponseCode == 226 ) {
				return 1;
			}

			/*	If connect Command */
			if ( l_strCommand.Equals("CONNECT") ) {
				/*	120,220 (success)
				 *	421 (service not available)
				*/
				switch ( l_iResponseCode ) {
					case 120 :
					case 220 :
						l_iRetval = 1;
						break;
					default:
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("USER") ) {
				/*	220,230,530,331	(success) */
				/*	332,530,500,501,530	(syntax error) */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 220 : case 230 : case 331 : 
						l_iRetval = 1;
						break;
					case 332 :
						m_strError = "You don't have account for logging in";
						l_iRetval = 0;
						break;
					case 500 : 
						m_strError = "<USER> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<USER> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 530 :
						m_strError = "User not logged on. Check your User id and password";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in USER command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("PASS") ) {
				/*	220,230,530,331	(success) */
				/*	332,500,501	(syntax error) */
				/*	530 not logged on */
				/*	332 not logged on */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 230 : case 202 : case 331:
						l_iRetval = 1;
						break;
					case 332 :
						m_strError = "You don't have account for logging in";
						l_iRetval = 0;
						break;
					case 500 : 
						m_strError = "<PASS> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<PASS> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 503 :
						m_strError = "<PASS> command. Bad sequence of commands";
						l_iRetval = 0;
						break;
					case 530 :
						m_strError = "User not logged on. Check your User id and password";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in PASS command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("SYST") ) {
				/*	215	(success) */
				/*	500,501,502 (syntax error) */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 215 :
						l_iRetval = 1;
						break;
					case 500 : 
						m_strError = "<SYST> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<SYST> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strError = "<SYST> command. Command not implemented";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in SYST command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.StartsWith("PWD") ) {
				/*	257	(success) */
				/*	500,501,502,550 (syntax error) */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 257 :
						l_iRetval = 1;
						break;
					case 500 : 
						m_strError = "<PWD> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<PWD> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strError = "<PWD> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 550 :
						m_strError = "<PWD> command. Requested action not taken or access denied";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in PWD command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("MODE") ) {
				/*	200	(success) */
				/*	500,501,504,530 (syntax error) */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 200 :
						l_iRetval = 1;
						break;
					case 500 : 
						m_strError = "<MODE> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<MODE> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 504 :
						m_strError = "<MODE> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strError = "<MODE> command. User not logged on";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in MODE command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("TYPE") ) {
				/*	200	(success) */
				/*	500,501,504,530 (syntax error) */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 200 :
						l_iRetval = 1;
						break;
					case 500 : 
						m_strError = "<TYPE> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<TYPE> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 504 :
						m_strError = "<TYPE> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strError = "<TYPE> command. User not logged on";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in TYPE command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("PORT") ) {
				/*	200,226,150	(success) */
				/*	500,501,530 (syntax error) */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 200 : case 226 : case 150 : case 250 :
						l_iRetval = 1;
						break;
					case 500 : 
						m_strError = "<PORT> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<PORT> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 530 :
						m_strError = "<PORT> command. User not logged on";
						l_iRetval = 0;
						break;
					case 426 :
						m_strError = "<PORT> command. Connection closed transfer aborted";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in PORT command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("LIST") ) {
				/*	125,150,250,226 (success) */
				/*	425,426,451,450,500,501,502,530 (syntax error) */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 125 : case 150 : case 250 : case 226 :
						l_iRetval = 1;
						break;
					case 425 :
						m_strError = "<LIST> command. Can't open data connection";
						l_iRetval = 0;
						break;
					case 426 :
						m_strError = "<LIST> command. Connection closed; transfer aborted";
						l_iRetval = 0;
						break;
					case 451 :
						m_strError = "<LIST> command. Requested action aborted: Local error in processing";
						l_iRetval = 0;
						break;
					case 450 :
						m_strError = "<LIST> command. Requested file action not taken.File unavailable (e.g., file busy)";
						l_iRetval = 0;
						break;
					case 500 : 
						m_strError = "<LIST> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<LIST> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strError = "<LIST> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strError = "<LIST> command. User not logged on";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in LIST command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.StartsWith("CWD") ) {
				/*	250,150 (success) */
				/*	500,501,502,530,550 (syntax error) */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 250 : case 150 : case 226: case 200 : case 257 :
						l_iRetval = 1;
						break;
					case 500 : 
						m_strError = "<CWD> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<CWD> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strError = "<CWD> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strError = "<CWD> command. User not logged on";
						l_iRetval = 0;
						break;
					case 550 :
						m_strError = "<CWD> command. Requested action not taken.File unavailable (e.g., file not found, no access).";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in CWD command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("RETR") ) {
				/*	125,150,110,250,226 (success) */
				/*	226,425,426,451,450,500,501,502,530 (syntax error) */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 125 : case 150 : case 110 : case 250 : case 226 : case 200 :
						l_iRetval = 1;
						break;
					case 425 :
						m_strError = "<RETR> command. Can't open data connection";
						l_iRetval = 0;
						break;
					case 426 :
						m_strError = "<RETR> command. Connection closed; transfer aborted";
						l_iRetval = 0;
						break;
					case 451 :
						m_strError = "<RETR> command. Requested action aborted: Local error in processing";
						l_iRetval = 0;
						break;
					case 450 :
						m_strError = "<RETR> command. Requested file action not taken.File unavailable (e.g., file busy)";
						l_iRetval = 0;
						break;
					case 500 : 
						m_strError = "<RETR> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<RETR> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strError = "<RETR> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strError = "<RETR> command. User not logged on";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in RETR command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("STOR") ) {
				/*	125,150,110,250,226 (success) */
				/*	425,426,451,551,552,532,450,452,533,500,501,530 (syntax error) */
				/*	550 (Access denied) */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 125 : case 150 : case 110 : case 250 : case 226 :
						l_iRetval = 1;
						break;
					case 425 :
						m_strError = "<STOR> command. Can't open data connection";
						l_iRetval = 0;
						break;
					case 426 :
						m_strError = "<STOR> command. Connection closed; transfer aborted";
						l_iRetval = 0;
						break;
					case 451 :
						m_strError = "<STOR> command. Requested action aborted: Local error in processing";
						l_iRetval = 0;
						break;
					case 550 :
						m_strError = "<STOR> command. Requested action not taken. File unavailable (e.g., file not found, no access)";
						l_iRetval = 0;
						break;
					case 551 :
						m_strError = "<STOR> command. Requested action aborted: Page type unknown";
						l_iRetval = 0;
						break;
					case 552 :
						m_strError = "<STOR> command. Requested action aborted: Exceeded storage allocation (for current directory or dataset)";
						l_iRetval = 0;
						break;
					case 532 :
						m_strError = "<STOR> command. Need account for storing files";
						l_iRetval = 0;
						break;
					case 450 :
						m_strError = "<STOR> command. Requested file action not taken. File unavailable (e.g., file busy)";
						l_iRetval = 0;
						break;
					case 452 :
						m_strError = "<STOR> command. Requested file action not taken. Insufficient storage space in system";
						l_iRetval = 0;
						break;
					case 553 :
						m_strError = "<STOR> command. Requested action not taken. Filename not allowed";
						l_iRetval = 0;
						break;
					case 500 : 
						m_strError = "<STOR> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<STOR> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 530 :
						m_strError = "<STOR> command. User not logged on";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in STOR command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.StartsWith("MKD") ) {
				/*	257,150 (success) */
				/*	500,501,502,530,550 (syntax error) */
				/*	421	(service not available) */
				switch ( l_iResponseCode ) {
					case 257 : case 150 :
						l_iRetval = 1;
						break;
					case 500 : 
						m_strError = "<MKD> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<MKD> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strError = "<MKD> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strError = "<MKD> command. User not logged on";
						l_iRetval = 0;
						break;
					case 550 :
						m_strError = "<MKD> command. Requested action not taken. File unavailable (e.g., file not found, no access)";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in MKD command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.StartsWith("RMD") ) {
				/*	250 ,150 (success) */
				/*	500,501,502,530,550 (syntax error) */
				/*	421	(service not available) */
				switch ( l_iResponseCode ) {
					case 250 : case 150 :
						l_iRetval = 1;
						break;
					case 500 : 
						m_strError = "<RMD> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<RMD> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strError = "<RMD> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strError = "<RMD> command. User not logged on";
						l_iRetval = 0;
						break;
					case 550 :
						m_strError = "<RMD> command. Requested action not taken. File unavailable (e.g., file not found, no access)";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in RMD command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("DELE") ) {
				/*	250 (success) */
				/*	450,550,500,501,502,530 (syntax error) */
				/*	421	(service not available) */
				switch ( l_iResponseCode ) {
					case 250 : case 226 :
						l_iRetval = 1;
						break;
					case 450 :
						m_strError = "<DELE> command. Requested action not taken. File unavailable (e.g., file not found, no access)";
						l_iRetval = 0;
						break;
					case 550 :
						m_strError = "<DELE> command. Requested action not taken. File unavailable (e.g., file not found, no access)";
						l_iRetval = 0;
						break;
					case 500 : 
						m_strError = "<DELE> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strError = "<DELE> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strError = "<DELE> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strError = "<DELE> command. User not logged on";
						l_iRetval = 0;
						break;
					default:
						m_strError = "Unknown error in DELE command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("QUIT") ) {
				/*	221	(success) */
				/*	500 */
				switch( l_iResponseCode ) {
					case 221 :
						l_iRetval = 1;
						break;
					case 500 :
						m_strError = "Syntax error, command unrecognized";
						l_iRetval = 1;
						break;
					default :
						m_strError = "Unknown error in QUIT command. Response code :" +  l_iResponseCode;
						l_iRetval = 1;
						break;
				}
			}
			return l_iRetval;
		}

		/// <summary>
		/// Executes commmand on a Ftp server 
		/// </summary>
		/// <param name="l_strCommand">Command string</param>
		/// <param name="l_refstrOutput">Output string from Ftp server </param>
		/// <returns>1 if success, else 0</returns>
		private int ExecuteCommand(string l_strCommand,ref string l_refstrOutput){
			int l_iRetval = 0;
			/*	Check for Status of FTP client socket here */
			if ( m_ClientSocket == null ) {
				m_strError = "Sockets not Initialized";
				return l_iRetval;
			}

			/*	Proceed with issuing command */
			Byte[] l_bSendData = new Byte[512];
			Byte[] l_bRecvData = new Byte[1024];
			string l_strOutput = "",l_strTemp = "";
			
			l_bSendData = Encoding.ASCII.GetBytes(l_strCommand);

			/* Send the command */
			l_iRetval = m_ClientSocket.Send(l_bSendData);
			if ( l_iRetval != l_bSendData.Length ) {
				m_strError = "Error in sending data";
				return 0;
			}

			l_bRecvData.Initialize();
			l_strTemp = "";
			l_strOutput = "";

			/* Receive data in a loop until the FTP server sends it */
			for ( ; ( l_iRetval = m_ClientSocket.Receive(l_bRecvData)) > 0 ;  ) {
				l_strTemp = Encoding.ASCII.GetString(l_bRecvData,0,l_iRetval);
				l_strOutput += l_strTemp;
				if ( m_ClientSocket.Available == 0 ){
					break;
				}
			}
			l_refstrOutput = l_strOutput;

			/*	Call ParseResponseCode() here */
			if ( l_strOutput.Length > 3 ) {
				l_iRetval = ParseResponseCode(l_strCommand.Substring(0,4),l_strOutput.Substring(0,3));
			}
			return l_iRetval;
		}

		/// <summary>
		/// LIST command implementation
		/// </summary>
		/// <returns></returns>
		public DataTable GetList(string l_strCurrDir){
			string l_strCommand = "";
			int l_iRetval = 0;

			if ( l_strCurrDir == null  ){
				/* if null is passed, populate root folder */
				l_strCurrDir = m_strRootDir;
			}
			l_strCurrDir.Trim();

			string l_strFileList = "";
			l_strCommand = "LIST " + l_strCurrDir + "\r\n";
			l_iRetval = ExecuteDataCommand(l_strCommand,out l_strFileList); 
			if ( l_iRetval != 1 ) {
				return null;
			}

			string[] l_strarrFiles = l_strFileList.Split("\n".ToCharArray());
			DataTable l_dtFileList = null;
			switch ( m_iServerOS) {
				case 1 :	/*	Unix	*/
					l_dtFileList = ParseStringArrayForUnix(l_strarrFiles);
					m_strError = "";
					break;
				case 2 :	/*	Windows	*/
					l_dtFileList = ParseStringArrayForWindows(l_strarrFiles);
					break;
				default:
					m_strError = "Sorry !!! server type '" + m_strServerType + "' is not recognized by FTP Explorer" ;
					break;
			}
			return l_dtFileList;
		}

		/// <summary>
		/// Executes a Ftp Data Command
		/// </summary>
		/// <param name="l_strCommand">Command string</param>
		/// <param name="l_strOutputData">Output string</param>
		/// <returns>1 if success, else 0</returns>
		private int ExecuteDataCommand(string l_strCommand,out string l_strOutputData){
			TcpListener l_FTPListener = null;
			Socket l_ClientDataSocket = null;
			int l_iRetval = 0, l_iDataPort = 0;
			try {
				l_strOutputData = "";
				l_FTPListener = new TcpListener(0);
Trace.WriteLine("Inside ExecuteDataCommand()");
				l_FTPListener.Start();
				IPEndPoint pt = (IPEndPoint) l_FTPListener.LocalEndpoint;
				l_iDataPort = pt.Port;
Trace.WriteLine("Port Number :" + l_iDataPort);
				string l_strOutput = "";
				string l_strPortParams = GetPortParameters(l_iDataPort);

				/*	PORT command */
				string l_strPortCommand = "PORT " + l_strPortParams + "\r\n";
				l_iRetval = ExecuteCommand(l_strPortCommand,ref l_strOutput);
Trace.WriteLine("Port Command :" + l_iRetval + ":" + l_strOutput);
				if ( l_iRetval == 0 ) {
					return l_iRetval;
				}

				
				/*	Execute the actual command here */
				l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
Trace.WriteLine("LIST Command :" + l_iRetval + ":" + l_strOutput);
				/*if ( l_iRetval == 0 ) {
					return l_iRetval;
				}*/

Trace.WriteLine("Before Accept Socket()");
				/*	Accept Client connection here */
				l_ClientDataSocket = l_FTPListener.AcceptSocket();
				/*IPEndPoint ep = (IPEndPoint) l_FTPListener.LocalEndpoint;
				int iiiiiii = ep.Port;*/
Trace.WriteLine("After Accept Socket()");
				l_ClientDataSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout,m_iSendTimeOut);
				l_ClientDataSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout,m_iRecvTimeOut);
				
				Byte[] l_bRecvData = new Byte[1024];
				l_strOutput = "";
				string l_strTemp = "";

				l_iRetval = 0;

				/*	Loop through and Receive all the data */
				//for ( ; (l_iRetval = l_ClientDataSocket.Receive(l_bRecvData,5119,0)) > 0  ; ) {

Trace.WriteLine("Before for()");
				Thread.Sleep(1000);
Trace.WriteLine("Before for()1");
				for ( ;  l_ClientDataSocket.Available > 0  ; ) {
					l_iRetval = l_ClientDataSocket.Receive(l_bRecvData,1023,0);
Trace.WriteLine("Inside for() :" + l_iRetval);
					l_strTemp = Encoding.ASCII.GetString(l_bRecvData,0,l_iRetval);
					l_strOutput += l_strTemp;
				}
Trace.WriteLine("After for()");

				l_ClientDataSocket.Shutdown(SocketShutdown.Both);
				l_ClientDataSocket.Close();
				l_ClientDataSocket = null;

				l_strOutputData = l_strOutput;
				l_iRetval = 1;
			}
			catch ( SocketException e1){
Trace.WriteLine("Inside Exception1" + e1.Message);
				m_strError = e1.Message;
				l_strOutputData = "";
				return 0;
			}
			catch ( Exception e ) {
Trace.WriteLine("Inside Exception2" + e.Message);
				m_strError = e.Message;
				l_strOutputData = "";
				return 0;
			}
			finally{
				Trace.WriteLine("Inside Finally");

				if ( l_FTPListener != null ) {
					l_FTPListener.Stop();
					l_FTPListener = null;
				}
				if ( l_ClientDataSocket != null ) {
					l_ClientDataSocket.Shutdown(SocketShutdown.Both);
					l_ClientDataSocket.Close();
					l_ClientDataSocket = null;
				}
			}
			return l_iRetval;
		}

		/// <summary>
		/// Generate Port number
		/// </summary>
		/// <returns>Returns newly generated port number</returns>
		private int GetPort(){
			if ( m_iDataPort > 30000 ) {
				m_iDataPort = 10000;
			}
			return m_iDataPort++;
		}

		/// <summary>
		/// Get PORT parameters
		/// </summary>
		/// <param name="l_iPort">Input Port number</param>
		/// <returns>Output string</returns>
		private string GetPortParameters(int l_iPort){
			string l_strLocalMachine = Dns.GetHostName();
			IPEndPoint l_IPServer;
			IPHostEntry l_localHost = Dns.Resolve(l_strLocalMachine);
			IPAddress l_IPAddress = l_localHost.AddressList[0];
			l_IPServer = new IPEndPoint(l_IPAddress,l_iPort);

			string l_strIPAddress = l_IPAddress.ToString();
			l_strIPAddress = l_strIPAddress.Replace('.',',');
			int l_iParam1 = ( 0xff00 & l_iPort ) >> 8;
			int l_iParam2 = ( 0xff & l_iPort ) ;

			string l_strPortParam = l_strIPAddress + "," + l_iParam1 + "," + l_iParam2;
			return l_strPortParam;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="l_arrFiles"></param>
		/// <returns></returns>
		private DataTable ParseStringArrayForUnix(string[] l_arrFiles){

			DataTable l_dtFileList = new DataTable(m_strCurrentWorkingDir);
			l_dtFileList.Columns.Add(new DataColumn("FileType",typeof(int)));
			l_dtFileList.Columns.Add(new DataColumn("FileName",typeof(string)));
			l_dtFileList.Columns.Add(new DataColumn("FilePath",typeof(string)));
			l_dtFileList.Columns.Add(new DataColumn("CreatedDate",typeof(string)));
			l_dtFileList.Columns.Add(new DataColumn("FileSize",typeof(int)));
			l_dtFileList.Columns.Add(new DataColumn("FileOwner",typeof(string)));
			l_dtFileList.Columns.Add(new DataColumn("FileGroup",typeof(string)));

			string l_strcurFile = "";
			int l_iFileCount = l_arrFiles.Length;
			int l_iLineCount = 0;
			char[] l_arrchSep = new char[2];
			l_arrchSep[0] = ' ';
			l_arrchSep[1] = '\0';

			foreach(object obj in l_arrFiles) {
				l_strcurFile = (string) obj;

				/*	If first line then parse for length */
				if ( l_iLineCount == 0 ) {
					l_iLineCount++;
					continue;
				}
				else {
					/*	Parse for file info */
					string[] l_strarrFields = SplitStringForUnix(l_strcurFile);
					if (l_strarrFields.Length == 1 || l_strarrFields[0].Length <= 0 ) {
						/*	If the element is empty, do not attempt to parse it */
						l_iLineCount++;
						continue;
					}

					/*	Each field is now in l_strarrFields */
					DataRow l_drNew = l_dtFileList.NewRow();
					if ( GetFileInfoForUnix(l_strarrFields,ref l_drNew) == 1 ){
						if ( l_drNew != null ) {
							l_dtFileList.Rows.Add(l_drNew);
						}
					}
				}
				l_iLineCount++;
			}
			return l_dtFileList;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="l_strarrFields"></param>
		/// <param name="l_drNew"></param>
		/// <returns></returns>
		private int GetFileInfoForUnix(string[] l_strarrFields,ref DataRow l_drNew){
			string l_strField = "";
			string l_strFileName = "" ,l_strFilePath = "" ,l_strDateCreated = "";
			string l_strFileOwner = "",l_strFileGroup = "";
			int l_iFileType = 0,l_iFileSize = 0;
			int l_iCount = 0,l_iErrFlag = 0;
			char l_chTemp = '\0';

			foreach(object obj in l_strarrFields) {
				l_strField = (string) obj;
				if (l_strField.Length <= 0 ) {
					l_iErrFlag = 1;
					break;
				}
				switch( l_iCount) {
					case 0:		/*	File Type */
						l_chTemp = l_strField[0];
						if ( l_chTemp == '-' ) {
							/*	Normal File */
							l_iFileType = 1;
						}
						else if ( l_chTemp == 'd') {
							/*	Directory */
							l_iFileType = 2;
						}
						else if ( l_chTemp == 'c' ) {
							/*	System file */
							l_iFileType = 3;
						}
						else {
							/*	Unknown file type */
							l_iFileType = 0;
						}
						break;
					case 1 :	/*	File Links */
						break;
					case 2 :	/*	File Owner */
						l_strFileOwner = l_strField;
						break;
					case 3 :	/*	File group */
						l_strFileGroup = l_strField;
						break;
					case 4 :	/*	File size in bytes */
						l_iFileSize = int.Parse(l_strField);
						break;
					case 5 :	/*	Date created ( contains month in mmm format ) */
						l_strDateCreated = l_strField;
						break;
					case 6 :	/*	Date created ( contains day in dd format ) */
						l_strDateCreated += " " + l_strField;
						break;
					case 7 :	/*	Date created ( contains time in HH:SS or year in YYYY format ) */
						l_strDateCreated += " " + l_strField;
						break;
					case 8 :	/*	File name */
						l_strFileName = l_strField;
						l_strFileName = l_strFileName.Trim();
						if (l_strFileName.Length == 0 ) {
							l_strFileName = "<unknown>";
						}
						break;
					case 9 :
						break;
				}	/*	End of switch statement */
				l_iCount++;
			}	/*	End of for */

			/*	If error occured while parsing return null and ignore this element */
			if (l_iErrFlag == 1 ) {
				return 0;
			}

			if ( l_strFileName == "." || l_strFileName == ".." ){
				l_drNew = null;
				return 0;
			}

			if ( m_strCurrentWorkingDir.EndsWith("/") == true ){
				l_strFilePath = m_strCurrentWorkingDir + l_strFileName;
			}
			else {
				l_strFilePath = m_strCurrentWorkingDir + "/" + l_strFileName;
			}

			l_drNew[0] = l_iFileType;
			l_drNew[1] = l_strFileName;
			l_drNew[2] = l_strFilePath;
			l_drNew[3] = l_strDateCreated;
			l_drNew[4] = l_iFileSize;
			l_drNew[5] = l_strFileOwner;
			l_drNew[6] = l_strFileGroup;

			return 1;
		}

		/// <summary>
		/// This function takes a string and squeezes more than
		/// one space characters into one character and
		/// then splits into array and returns back to the caller
		/// </summary>
		/// <param name="l_strInString">Input String</param>
		/// <returns>Output string in an array</returns>
		private string[] SplitStringForUnix(string l_strInString){
			string[] l_strarrOut = new string[9];
			string l_strTemp = "";
			char[] l_arrchSep = new char[2];
			l_arrchSep[0] = ' ';
			l_arrchSep[1] = '\0';

			/*	Squeeze more spaces into single space character	*/
			int l_iCount = 0,l_iLen = l_strInString.Length;
			for ( ; l_iCount < l_iLen ; l_iCount++ ) {
				if ( l_strInString[l_iCount] == ' ' ) {
					l_strTemp += l_strInString[l_iCount];
					if ( l_strInString[l_iCount + 1] == ' ' ) {
						for ( l_iCount++ ;  l_strInString[l_iCount] == ' '; l_iCount++ ) ;
						l_strTemp += l_strInString[l_iCount];
					}
				}
				else {
					l_strTemp += l_strInString[l_iCount];
				}
			}
			l_strarrOut = l_strTemp.Split(l_arrchSep);
			return l_strarrOut;
		}

		/// <summary>
		/// Disconnect from FTP server
		/// </summary>
		/// <returns>1 if success, else 0</returns>
		public int Disconnect(){
			if ( m_ClientSocket == null ) {
				m_strError = "Sockets not Initialized";
				return 0;
			}

			string l_strCommand = "QUIT\r\n";
			string l_strOutput = "";
			
			int l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			
			/*	Close socket handle here */
			CloseConnection();
			m_ClientSocket = null;
			return 1;
		}

		/// <summary>
		/// Creates a folder in the remote server
		/// </summary>
		/// <param name="l_strFolder">Name of the folder to be created</param>
		/// <returns>1 if success, else 0</returns>
		public int CreateFolder(string l_strFolder){
			int l_iRetval = 0;
			string l_strCommand = "",l_strOutput = "";
			l_strCommand = "MKD " + l_strFolder + "\r\n";
			
			/*	Execute the actual command here */
			l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			return l_iRetval;
		}

		/// <summary>
		/// Removes a folder from the server
		/// </summary>
		/// <param name="l_strFolder">Name of the folder to be deleted</param>
		/// <returns>1 if success, else 0</returns>
		public int RemoveFolder(string l_strFolder){
			int l_iRetval = 0;
			string l_strCommand = "",l_strOutput = "";
			l_strCommand = "RMD " + l_strFolder + "\r\n";
			
			/*	Execute the actual command here */
			l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			return l_iRetval;
		}

		/// <summary>
		/// Download a file from FTP server
		/// </summary>
		/// <param name="l_strServerFileName">Remote File full path</param>
		/// <param name="l_strLocalFileName">Local File full path</param>
		/// <returns>non zero value if success,else 0</returns>
		public int DownLoadFile(string l_strServerFileName,string l_strLocalFileName){

			/*	Read 5 K at a time	*/
			Byte[] l_bRecvData = new Byte[5120];
			TcpListener l_FTPListener = null;
			Socket l_ClientDataSocket = null;
			bool l_bAcceptFailed = false;

			/*	Local file handle for stream mode */
			FileStream l_fsOutFile = null;

			/*	File handle for Binary files */
			BinaryWriter l_fbOutFile = null;

			int l_iRetval = 0, l_iDataPort = 0;
			int l_iBufferLimit = 5119;

			try {

				l_FTPListener = new TcpListener(0);
				l_FTPListener.Start();
				IPEndPoint pt = (IPEndPoint) l_FTPListener.LocalEndpoint;
				l_iDataPort = pt.Port;

				string l_strOutput = "";
				string l_strPortParams = GetPortParameters(l_iDataPort);

				/*	Open Files here */
				if ( m_chTransferType == 'A' ) {
					/*	Open ASCII stream */
					l_fsOutFile = new FileStream(l_strLocalFileName,FileMode.Create,FileAccess.Write);
				}

				/*	PORT command */
				string l_strPortCommand = "PORT " + l_strPortParams + "\r\n";
				l_iRetval = ExecuteCommand(l_strPortCommand,ref l_strOutput);
				Trace.WriteLine("Port Command :" + l_iRetval + ":" + l_strOutput);
				if ( l_iRetval == 0 ) {
					return l_iRetval;
				}

				string l_strCommand = "RETR " + l_strServerFileName + "\r\n";
				/*	Execute the actual command here */
				l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					return l_iRetval;
				}

				/*	Accept Client connection here,
				 *	only if there is a pending connection
				 *  */
				Thread.Sleep(500);
				if ( l_FTPListener.Pending()) {
					l_ClientDataSocket = l_FTPListener.AcceptSocket();
				}
				else {
					/*	Else return from the download function with error */
					l_bAcceptFailed = true;
					m_strError = "No connection from Server. Aborting the process. Try later";
					return 0;
				}
				
				l_ClientDataSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout,m_iRecvTimeOut);
				l_ClientDataSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout,m_iSendTimeOut);
				
				l_bRecvData.Initialize();
				l_strOutput = "";
				l_iRetval = 0;

				/*	Loop through and Receive all the data */
				Thread.Sleep(1000);
				for ( ;  l_ClientDataSocket.Available > 0  ; ) {
					l_bRecvData.Initialize();
					l_iRetval = l_ClientDataSocket.Receive(l_bRecvData,l_iBufferLimit,0);

					/*	Write to Local file here */
					l_fsOutFile.Write(l_bRecvData,0,l_iRetval);
					l_fsOutFile.Flush();
					Thread.Sleep(100);
				}

				if ( l_iRetval == 0 ) {
					/*	Connection closed by FTP Server process 
					 *	then the file transfer is complete
					 * */
					l_iRetval = 1;
				}
				else if ( l_iRetval == -1 ) {
					/*	If Timeout occured then the FTP Server process
					 *	didn't respond in a timely fashion
					 */
					l_iRetval = 0;
					m_strError = "Timeout occured. FTP Server process did not respond in a timely fashion. Try increasing Receive timeout property in Configure dialog";
				}

				/*	Close Data Connection here */
				if ( l_ClientDataSocket != null ) {
					l_ClientDataSocket.Shutdown(SocketShutdown.Both);
					l_ClientDataSocket.Close();
					l_ClientDataSocket = null;
				}

				/*	Code to receive the response code 226 for 
				 *	RETR command from command socket
				 * */
				Byte[] l_bRecvCommData = new Byte[512];
				l_bRecvCommData.Initialize();
				string l_strTemp = "";

				l_strOutput = "";
				int l_iRetval1 = 1;
				if ( m_strError.Length > 0 ) {
					l_strTemp = m_strError;
				}

				for ( ; m_ClientSocket.Available > 0 ; ) {
					l_iRetval1 = m_ClientSocket.Receive(l_bRecvCommData,511,0);
					l_strTemp = Encoding.ASCII.GetString(l_bRecvCommData,0,l_iRetval1);
					l_strOutput += l_strTemp;
				}

				/*	Parse the output string */
				if ( l_strOutput.Length > 3 ) {
					l_iRetval1 = ParseResponseCode("RETR",l_strOutput.Substring(0,3));
				}
				if ( l_iRetval1 == 0 ) {
					if ( l_strTemp.Length > 0 ) {
						m_strError = l_strTemp;
					}
					l_iRetval = 0;
				}
				return l_iRetval;
			}
			catch ( Exception e ) {
				m_strError = e.Message;
				return 0;
			}
			finally{
				if ( l_FTPListener != null ) {
					l_FTPListener.Stop();
					l_FTPListener = null;
				}
				if ( l_ClientDataSocket != null ) {
					l_ClientDataSocket.Shutdown(SocketShutdown.Both);
					l_ClientDataSocket.Close();
					l_ClientDataSocket = null;
				}
				if ( l_fsOutFile != null ) {
					l_fsOutFile.Close();
				}
				if ( l_fbOutFile != null ) {
					l_fbOutFile.Close();
				}

				/*	If Accept() failed, then receive the data from
				 *	command connection and ignore it.
				 * */
				if ( l_bAcceptFailed == true ) {
					Byte[] l_bRecvCommData = new Byte[512];
					l_bRecvCommData.Initialize();

					/*	Get all data and do not do anything with the data.
					 *	This is just to clear the command connection data
					 */
					for ( ; m_ClientSocket.Available > 0 ; ) {
						m_ClientSocket.Receive(l_bRecvCommData,511,0);
					}
				}
			}	/*	End of finally */
		}	/*	End of download file */

		/// <summary>
		/// Uploads file to FTP Server
		/// </summary>
		/// <param name="l_strLocalFile">Local file full path</param>
		/// <param name="l_strRemoteFile">Remote file full path</param>
		/// <returns>non zero value if success, else 0</returns>
		public int UploadFile(string l_strLocalFile,string l_strRemoteFile){

			int l_iRetval = 0,l_iDataPort = 0;

			/* Send 5k at a time */
			Byte[] l_bData = new Byte[5120];

			TcpListener l_FTPListener = null;
			Socket l_ClientDataSocket = null;
			bool l_bAcceptFailed = false;
			
			/*	Local file handle for stream mode */
			FileStream l_fsInFile = null;

			try {

				l_FTPListener = new TcpListener(0);
				l_FTPListener.Start();
				IPEndPoint pt = (IPEndPoint) l_FTPListener.LocalEndpoint;
				l_iDataPort = pt.Port;

				string l_strOutput = "",l_strCommand = "";
				string l_strPortParams = GetPortParameters(l_iDataPort);

				m_strError = "";

				/*	Open Files here */
				if ( m_chTransferType == 'A' ) {
					/*	Open ASCII stream */
					l_fsInFile = new FileStream(l_strLocalFile,FileMode.Open,FileAccess.Read);
				}

				/*	PORT command */
				string l_strPortCommand = "PORT " + l_strPortParams + "\r\n";
				l_iRetval = ExecuteCommand(l_strPortCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					return l_iRetval;
				}

				l_strCommand = "STOR " + l_strRemoteFile + "\r\n";
				/*	Execute the actual command here */
				l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					return l_iRetval;
				}
				
				/*	Accept Client connection here,
				 *	only if there is a pending connection
				 *  */
				Thread.Sleep(500);
				if ( l_FTPListener.Pending() ) {
					l_ClientDataSocket = l_FTPListener.AcceptSocket();
				}
				else {
					/*	Else return from the upload function with error */
					l_bAcceptFailed = true;
					m_strError = "No connection from Server. Aborting the process. Try later";
					return 0;
				}

				/* Set Socket options */
				l_ClientDataSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout,m_iRecvTimeOut);
				l_ClientDataSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout,m_iSendTimeOut);
				
				l_bData.Initialize();
				l_strOutput = "";
				l_iRetval = 0;

				/*	Loop through and Receive all the data */
				Thread.Sleep(1000);
				for ( ; (l_iRetval = l_fsInFile.Read(l_bData,0,5119)) != 0 ; ) {

					/* Write to socket here and check for return value */
					l_iRetval = l_ClientDataSocket.Send(l_bData,l_iRetval + 1,0);
					if ( l_iRetval == 0 ) {
						/*	If Connection closed by FTP server,
						 *	then close the connection
						 */
						l_iRetval = 0;
						m_strError = "Connection closed by FTP Server. Aborting the upload process.";
						return l_iRetval;
					}
					else if ( l_iRetval == -1 ) {
						/*	If Timeout occured then the FTP Server process
						 *	didn't respond in a timely fashion
						 */
						l_iRetval = 0;
						m_strError = "Timeout occured. FTP Server process did not respond in a timely fashion. Try increasing Send timeout property in Configure dialog";
						return l_iRetval;
					}
					l_bData.Initialize();
				}	/* end of for() */

				if ( l_iRetval == 0 ) {
					/*	End of File is reached and 
					 *	the file transfer is complete
					 * */
					l_iRetval = 1;
				}

				/*	Close Data Connection here */
				if ( l_ClientDataSocket != null ) {
					l_ClientDataSocket.Shutdown(SocketShutdown.Both);
					l_ClientDataSocket.Close();
					l_ClientDataSocket = null;
				}

				/*	Code to receive the response code 226 for 
				 *	STOR command from command socket
				 * */
				Byte[] l_bRecvCommData = new Byte[512];
				l_bRecvCommData.Initialize();
				string l_strTemp = "";

				l_strOutput = "";
				int l_iRetval1 = 1;
				if ( m_strError.Length > 0 ) {
					l_strTemp = m_strError;
				}

				for ( ; m_ClientSocket.Available > 0 ; ) {
					l_iRetval1 = m_ClientSocket.Receive(l_bRecvCommData,511,0);
					l_strTemp = Encoding.ASCII.GetString(l_bRecvCommData,0,l_iRetval1);
					l_strOutput += l_strTemp;
				}

				/*	Parse the output string */
				if ( l_strOutput.Length > 3 ) {
					l_iRetval1 = ParseResponseCode("STOR",l_strOutput.Substring(0,3));
				}
				if ( l_iRetval1 == 0 ) {
					if ( l_strTemp.Length > 0 ) {
						m_strError = l_strTemp;
					}
					l_iRetval = 0;
				}
				return l_iRetval ;
			}
			catch ( Exception e) {
				m_strError = e.Message;
				l_iRetval = 0;
			}
			finally {
				if ( l_FTPListener != null ) {
					l_FTPListener.Stop();
					l_FTPListener = null;
				}
				if ( l_ClientDataSocket != null ) {
					l_ClientDataSocket.Shutdown(SocketShutdown.Both);
					l_ClientDataSocket.Close();
					l_ClientDataSocket = null;
				}
				if ( l_fsInFile != null ) {
					l_fsInFile.Close();
				}

				/*	If Accept() failed, then receive the data from
				 *	command connection and ignore it.
				 * */
				if ( l_bAcceptFailed == true ) {
					Byte[] l_bRecvCommData = new Byte[512];
					l_bRecvCommData.Initialize();

					/*	Get all data and do not do anything with the data.
					 *	This is just to clear the command connection data
					 */
					for ( ; m_ClientSocket.Available > 0 ; ) {
						m_ClientSocket.Receive(l_bRecvCommData,511,0);
					}
				}
			}
			return l_iRetval;
		}

		/// <summary>
		/// Remove a file from the remote server
		/// </summary>
		/// <param name="l_strFile">File to be removed</param>
		/// <returns>1 if success, else 0</returns>
		public int RemoveFile(string l_strFile){
			int l_iRetval = 0;
			string l_strCommand = "",l_strOutput = "";
			l_strCommand = "DELE " + l_strFile + "\r\n";
			
			/*	Execute the actual command here */
			l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			return l_iRetval;
		}

		/// <summary>
		/// Changes the current working folder
		/// </summary>
		/// <param name="l_strDirectory">Folder name to be set as current working folder</param>
		/// <returns>1 if success, else 0</returns>
		public int ChangeWorkingFolder(string l_strDirectory){
			/*	CWD command */
			string l_strCommand = "";
			string l_strOutput = "";
			int l_iRetval = 0;

			m_strError = "";

			/*	USER command */
			l_strCommand = "CWD " + l_strDirectory + "\r\n";
			l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			if ( l_iRetval == 0 ) {
				return l_iRetval;
			}

			m_strCurrentWorkingDir = l_strDirectory;
			return 1;
		}

		/// <summary>
		/// To Parse the output of LIST command from Windows FTP services
		/// </summary>
		/// <param name="l_arrFiles">Input string read from socket connection</param>
		/// <returns>DataTable if success, else null</returns>
		private DataTable ParseStringArrayForWindows(string[] l_arrFiles){

			DataTable l_dtFileList = new DataTable(m_strCurrentWorkingDir);
			
			l_dtFileList.Columns.Add(new DataColumn("FileType",typeof(int)));
			l_dtFileList.Columns.Add(new DataColumn("FileName",typeof(string)));
			l_dtFileList.Columns.Add(new DataColumn("FilePath",typeof(string)));
			l_dtFileList.Columns.Add(new DataColumn("CreatedDate",typeof(string)));
			l_dtFileList.Columns.Add(new DataColumn("FileSize",typeof(int)));

			string l_strcurFile = "";
			char[] l_arrchSep = new char[2];
			l_arrchSep[0] = ' ';
			l_arrchSep[1] = '\0';
			string[] l_strarrFields = new string[5];

			foreach(object obj in l_arrFiles) {
				l_strcurFile = (string) obj;
				l_strcurFile.Trim();
				
				if (l_strcurFile == null || l_strcurFile.Length == 0 ) {
					break;
				}

				l_strarrFields = SplitStringForWindows(l_strcurFile);
				if ( l_strarrFields.Length == 1 || l_strarrFields.Length <= 0 ) {
					/*	If the element is empty, do not attempt to parse it */
					continue;
				}

				/*	Each field is now in l_strarrFields */
				DataRow l_drNew = l_dtFileList.NewRow();
				/*	Each field is now in l_strarrFields */
				if ( GetFileInfoForWindows(l_strarrFields,ref l_drNew) == 1 ){
					if ( l_drNew != null ) {
						l_dtFileList.Rows.Add(l_drNew);
					}
				}
			}
			return l_dtFileList;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="l_strInString"></param>
		/// <returns></returns>
		private string[] SplitStringForWindows(string l_strInString){
			string[] l_strarrOut = new string[5];
			string l_strTemp = "";
			char[] l_arrchSep = new char[2];
			l_arrchSep[0] = ' ';
			l_arrchSep[1] = '\0';
			int l_iFieldCount = 0;

			/*	Squeeze more spaces into single space character	*/
			int l_iCount = 0,l_iLen = l_strInString.Length;
			for ( ; l_iCount < l_iLen ; l_iCount++ ) {
				if ( l_strInString[l_iCount] == ' ' ) {
					if ( l_iFieldCount <= 1 ) {
						l_strarrOut[l_iFieldCount] = l_strTemp;
						l_iFieldCount++;
						l_strTemp = "";
						if ( l_strInString[l_iCount + 1] == ' ' ) {
							for ( l_iCount++ ;  l_strInString[l_iCount] == ' '; l_iCount++ ) ;
							/*	Postion the counter back to previous character	*/
							l_iCount--;
						}
					}
					else if ( l_iFieldCount == 2 ) {
						/*	Check for first digit here 
						 * if '<' then it is a directory
						 * else it is a file
						 * */
						if ( l_strTemp[0] == '<' ) {
							/*	Directory Flag	*/
							l_strarrOut[l_iFieldCount] = "D";
							l_iFieldCount++;

							/*	size of directory is not known	*/
							l_strarrOut[l_iFieldCount] = "0";
							l_iFieldCount++;
							/*	Skip the rest of characters */
							for ( l_iCount++ ;  l_strInString[l_iCount] != ' '; l_iCount++ ) ;
						}
						else {
							/*	Normal File	*/
							l_strarrOut[l_iFieldCount] = "N";
							l_iFieldCount++;
							l_strarrOut[l_iFieldCount] = l_strTemp;
							l_iFieldCount++;
						}
					}
				}
				else {
					if ( l_iFieldCount == 4 ) {
						/*	File name */
						l_strTemp = "";
						for ( ; l_iCount < l_strInString.Length ; l_iCount++ ){
							l_strTemp += l_strInString[l_iCount];
						}
						/*	remove \r\n character */
						l_strTemp = l_strTemp.Substring(0,l_strTemp.Length - 1);
						l_strarrOut[l_iFieldCount] = l_strTemp;
					}
					else {
						l_strTemp += l_strInString[l_iCount];
					}
				}
			}
			return l_strarrOut;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="l_strarrFields"></param>
		/// <param name="l_drNew"></param>
		/// <returns></returns>
		private int GetFileInfoForWindows(string[] l_strarrFields,ref DataRow l_drNew){

			string l_strField = "";
			string l_strFileName = "" ,l_strFilePath = "" ,l_strDateCreated = "";
			string l_strTimeCreated = "";
			int l_iFileType = 0,l_iFileSize = 0;
			int l_iCount = 0;

			foreach(object obj in l_strarrFields) {
				l_strField = (string) obj;
				if (l_strField == null ) {
					break;
				}
				switch( l_iCount) {
					case 0:		/*	Date */
						l_strDateCreated = l_strField;
						break;
					case 1 :	/*	Time */
						l_strTimeCreated = l_strField;
						break;
					case 2 :	/*	File Type  N - normal file, D - directory	*/
						if ( l_strField.Equals("N") ) {
							l_iFileType = 1;
						}
						else if ( l_strField.Equals("D") ) {
							l_iFileType = 2;
						}
						break;
					case 3 :	/*	File size in bytes */
						try {
							l_iFileSize = int.Parse(l_strField);
						}
						catch ( FormatException e ) {
							l_iFileSize = 0;
						}
						break;
					case 4 :	/*	Name of the file */
						l_strFileName = l_strField;
						break;
				}	/*	End of switch statement */
				l_iCount++;
			}	/*	End of for */

			/* If current or parent directory */
			if ( l_strFileName == "." || l_strFileName == ".." ){
				l_drNew = null;
				return 0;
			}

			if ( m_strCurrentWorkingDir.EndsWith("/") == true ){
				l_strFilePath = m_strCurrentWorkingDir + l_strFileName;
			}
			else {
				l_strFilePath = m_strCurrentWorkingDir + "/" + l_strFileName;
			}

			l_drNew[0] = l_iFileType;
			l_drNew[1] = l_strFileName;
			l_drNew[2] = l_strFilePath;
			l_drNew[3] = l_strDateCreated;
			l_drNew[4] = l_iFileSize;
			return 1;
		}

		/// <summary>
		/// Closes the socket connection
		/// </summary>
		private void CloseConnection(){
			if ( m_ClientSocket != null ) {
				m_ClientSocket.Shutdown(SocketShutdown.Both);
				m_ClientSocket.Close();
				m_ClientSocket = null;
			}
			return;
		}

	}
}
