/*	Project		:	FTPExplorer
 *  Version		:	2.0
 *	File Name	:	FTPClient.cs
 *	Purpose		:	Class to handle FTP Control and Data Connections
 *	Author		:	K.Niranjan Kumar
 *	Date		:	July 08,2001
 *	Company		:	Cognizant Technology Solutions.
 *	e-Mail		:	KNiranja@chn.cognizant.com
 */
namespace FTPExplorer
{
    using System;
	using System.Net.Sockets;
	using System.IO;
	using System.Net;
	using System.Text;

	enum g_enumConnStat { NOTCONN = 0 ,CONNECTED = 1, UNKNOWN = 2 };


    /// <summary>
    ///    Summary description for FTPClient.
    /// </summary>
    public class FTPClient
    {
		/*	Socket members for Command Connection */
		private Socket m_ClientSocket;
		private IPEndPoint m_IPServer;
		private IPAddress m_hostAddress;
		
		private int m_iSendTimeout;
		private int m_iRecvTimeout;

		public string m_strCommands;
		public string m_strServerType;
		public string m_strSystemStatus;

		private string m_strFTPAddress,m_strUser,m_strPassword;
		private int m_iFTPPort;

		private string m_strErrorMessage;
		private g_enumConnStat m_eConnStat = 0;
		private int m_iServerOS;
		
		public string m_strList;

		private FileList m_FileList;

		private string m_strRootDir;		/*	Root Directory	*/
		private string m_strCurrentWorkingDir;		/*	Current working directory	*/
		private int m_iDataPort;			/*	Generates Port No for data connection */
		private char m_chDataTransferMode;
		private	ExplorerDlg m_ParentWindow;			/*	Handle to parent window	*/

		public ExplorerDlg ParentWindow {
			set {
				m_ParentWindow = value;
			}
		}

        public FTPClient()
        {
            //
            // TODO: Add Constructor Logic here
            //
			m_ClientSocket = null;
			m_strFTPAddress = "";
			m_strUser = "";
			m_strPassword = "";
			m_strErrorMessage = "";
			m_eConnStat = g_enumConnStat.NOTCONN;

			m_iSendTimeout = 1000;		/*	Timeout for Send() 1000 ms	*/
			m_iRecvTimeout = 3000;		/*	Timeout for Receive() 300 ms	*/
			m_strSystemStatus = "";
			/*	Default FTP Port */
			m_iFTPPort = 21;

			m_strList = "";
			
			/*	Unknown OS */
			m_iServerOS = 0;

			m_FileList = new FileList();

			m_strRootDir = "";
			m_strCurrentWorkingDir = "";

			m_iDataPort = 13000;	/*	Start with 10000 */
			m_chDataTransferMode = 'A';		/*	Default mode of Data Transfer	*/
		}

		/*	Property Name	:	DataTransferMode 
		 *	Purpose			:	Determines mode of data transfer for RETR and STOR commands
		 *	Possible Values	:	'A' for ASCII, 'B' for Binary
		 * */
		public char DataTransferMode {
			set {
				m_chDataTransferMode = value;
			}
			get {
				return m_chDataTransferMode;
			}
		}

		private void CloseConnection(){
			if ( m_ClientSocket != null ) {
				m_ClientSocket.Shutdown(SocketShutdown.SdBoth);
				m_ClientSocket.Close();
				m_ClientSocket = null;
			}
			return;
		}
		
		public int Connect(){
			return Connect(m_strFTPAddress,m_strUser,m_strPassword);
		}

		public int Connect(string l_strFTPAddress,string l_strUser,string l_strPassword){
			m_strFTPAddress = l_strFTPAddress;
			m_strUser = l_strUser;
			m_strPassword = l_strPassword;
			if ( m_strFTPAddress.Length == 0 ) {
				m_strErrorMessage = "Error : FTP Server Address is empty";
				return 0;
			}
			if ( m_strUser.Length == 0 ) {
				m_strErrorMessage = "Error : FTP User ID is empty";
				return 0;
			}
			if ( m_strPassword.Length == 0 ) {
				m_strErrorMessage = "Error : FTP Password is empty";
				return 0;
			}

			try {

				/*	Create Socket here */
				m_ClientSocket = new Socket(AddressFamily.AfINet,SocketType.SockStream,ProtocolType.ProtTCP);

				/*	Resolve IP address here */
				m_hostAddress = DNS.Resolve(m_strFTPAddress);
				m_IPServer = new IPEndPoint(m_hostAddress,21);

				m_ClientSocket.SetSockOpt(SocketOption.SolSocket,SocketOption.SoRcvTimeo,m_iRecvTimeout);
				m_ClientSocket.SetSockOpt(SocketOption.SolSocket,SocketOption.SoSndTimeo,m_iSendTimeout);
				
				/*	Connect to FTP Server */
				if ( m_ClientSocket.Connect(m_IPServer) != 0 ) {
					m_strErrorMessage = "Error : Unable to connect to host on specified port";
					m_eConnStat = g_enumConnStat.NOTCONN;
					return 0;
				}

				Byte[] l_bRecvData = new Byte[255];

				int l_iRetval = 0;
				string l_strResponseData = "";
				/*	Get Response data */
				l_iRetval = m_ClientSocket.Receive(l_bRecvData,254,0);
				if ( l_iRetval == 0 ) {
					m_strErrorMessage = "Error : Error while connecting to FTP Server, Connection closed";
					return l_iRetval;
				}
				else if ( l_iRetval == -1 ) {
					m_strErrorMessage = "Error : Error while connecting to FTP Server, Invalid Socket";
					return 0;
				}
				else {
					l_strResponseData = Encoding.ASCII.GetString(l_bRecvData,0,l_iRetval);
				}

				string l_strResponseCode = l_strResponseData.Substring(0,3);
				l_iRetval = ParseResponseCode("CONNECT",l_strResponseCode);
				/*	Check for status of FTP server */
				if ( l_iRetval == 1 ) {

					/*	Login to FTP Server*/
					if ( Login() == 1 ){
						/*	Successfully connected */
						m_eConnStat = g_enumConnStat.CONNECTED;
					}
					else {
						//m_strErrorMessage = "1Error : " + l_strResponseData;
						m_eConnStat = g_enumConnStat.NOTCONN;
						return 0;
					}
				}
				else {
					m_strErrorMessage = "Error : " + l_strResponseData;
					m_eConnStat = g_enumConnStat.NOTCONN;
					return 0;
				}
			}
			catch ( SocketException e) {
				m_strErrorMessage = "Error : " + e;
				m_eConnStat = g_enumConnStat.NOTCONN;
				return 0;
			}
			finally {
				/*	If error in connection, then close the socket */
				if ( m_eConnStat != g_enumConnStat.CONNECTED ) {
					CloseConnection();
				}
			}
			return 1;
		}

		/*	Logon to FTP Server, Set the root directory to m_strRootDir
		 * */
		private int Login(){

			if ( m_ClientSocket == null ) {
				m_strErrorMessage = "Error : Sockets not initialised";
				return 0;
			}

			string l_strCommand = "";
			string l_strOutput = "";
			int l_iRetval = 0;

			m_strErrorMessage = "";

			/*	USER command */
			l_strCommand = "USER " + m_strUser + "\r\n";
			l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			if ( l_iRetval == 0 ) {
				CloseConnection();
				return l_iRetval;	
			}
			/*	Set Message in the parent window */
			m_ParentWindow.SetStausMessage("Verifying Password...");

			m_strErrorMessage = "";
			/*	PASS command */
			l_strOutput = "";
			l_strCommand = "PASS " + m_strPassword + "\r\n";
			l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			if ( l_iRetval == 0 ) {
				CloseConnection();
				return 0;	
			}
			/*	Set Message in the parent window */
			m_ParentWindow.SetStausMessage("Analysing Server Operating System...");

			m_strErrorMessage = "";
			/*	SYST */
			l_strOutput = "";
			l_strCommand = "SYST\r\n";
			l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			if ( l_iRetval == 0 ) {
				CloseConnection();
				return l_iRetval;
			}

			m_strServerType = l_strOutput;
			if ( l_strOutput == null || l_strOutput.Length == 0 ) {
				m_strErrorMessage = "Error in response for SYST command";
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
				m_strErrorMessage = "FTP Explorer Beta 1 supports browsing only on Windows and Unix based FTP Services. FTP browsing on other FTP services will be enabled in future versions.";
				CloseConnection();
				return 0;
			}

			m_strServerType = lstr_temp1;
			/*	Set Message in the parent window */
			m_ParentWindow.SetStausMessage("Querying for working directory...");
			
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
			m_strSystemStatus = l_strOutput;

			/*	Set Message in the parent window */
			m_ParentWindow.SetStausMessage("Setting to Stream Mode...");

			/*	MODE command, Set Mode = Stream */
			l_strOutput = "";
			l_strCommand = "MODE S\r\n";
			l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			if ( l_iRetval == 0 ) {
				return 0;
			}

			/*	Set Message in the parent window */
			m_ParentWindow.SetStausMessage("Setting to Ascii Type...");

			/*	TYPE command, Set Type = ASCII */
			l_strCommand = "TYPE A\r\n";
			l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			if ( l_iRetval == 0 ) {
				return 0;
			}
			return l_iRetval;
		}

		public int Disconnect(){
			if ( m_ClientSocket == null ) {
				m_strErrorMessage = "Error : Sockets not initialised";
				return 0;
			}

			string l_strCommand = "QUIT\r\n";
			string l_strOutput = "";
			
			int l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
/*			currently don't bother about Quit command response
 * 			string l_strResponseCode = l_strOutput.Substring(0,3);
			l_iRetval = ParseResponseCode("QUIT",l_strResponseCode);
			if ( l_iRetval == 0 ) {
				return 0;
			}
*/
			/*	Close socket handle here */
			CloseConnection();
			m_ClientSocket = null;
			return 1;
		}

		public void SetFTPServerAddress(string l_strServerAddress){
			m_strFTPAddress = l_strServerAddress;
		}

		public string GetFTPServerAddress(){
			return m_strFTPAddress;
		}

		public void SetFTPUser(string l_strFTPUser){
			m_strUser = l_strFTPUser;
		}

		public string GetFTPUser(){
			return m_strUser;
		}

		public void SetFTPPassword(string l_strPassword){
			m_strPassword = l_strPassword;
		}

		public string GetFTPPassword(){
			return m_strPassword;
		}
		public void SetFTPPort(int l_iPort){
			m_iFTPPort = l_iPort;
		}

		public int GetFTPPort(){
			return m_iFTPPort;
		}

		public void SetTimeOuts(int l_iSendTimeOut,int l_iRecvTimeOut ){
			m_iSendTimeout = l_iSendTimeOut;
			m_iRecvTimeout = l_iRecvTimeOut;
			return ;
		}

		public void GetTimeOuts(out int l_outiSendTimeOut,out int l_outiRecvTimeOut ){
			l_outiSendTimeOut = m_iSendTimeout;
			l_outiRecvTimeOut = m_iRecvTimeout;
			return ;
		}

		public int GetFTPStatus(){
			int l_iRetVal = 0;
			switch(m_eConnStat) {
				case g_enumConnStat.NOTCONN :
					l_iRetVal = 0;
					break;
				case g_enumConnStat.CONNECTED :
					l_iRetVal = 1;
					break;
				case g_enumConnStat.UNKNOWN :
					l_iRetVal = 2;
					break;
				default:
					l_iRetVal = 2;
					break;
			}
			return l_iRetVal;
		}

		private int ExecuteCommand(string l_strCommand,ref string l_refstrOutput){
			int l_iRetval = 0;
			/*	Check for Status of FTP client socket here */
			if ( m_ClientSocket == null ) {
				m_strErrorMessage = "Error : Sockets not initialised";
				return l_iRetval;
			}

			/*	Proceed with issuing command */
			Byte[] l_bSendData = new Byte[512];
			Byte[] l_bRecvData = new Byte[512];
			string l_strOutput = "",l_strTemp = "";
			
			l_bSendData = Encoding.ASCII.GetBytes(l_strCommand);
			l_iRetval = m_ClientSocket.Send(l_bSendData,l_bSendData.Length,0);
			if ( l_iRetval != l_bSendData.Length ) {
				m_strErrorMessage = "Error : Error in sending data";
				return 0;
			}

			l_bRecvData.Initialize();
			l_strTemp = "";
			l_strOutput = "";

			for ( ; ( l_iRetval = m_ClientSocket.Receive(l_bRecvData,511,0)) > 0 ;  ) {
				l_strTemp = Encoding.ASCII.GetString(l_bRecvData,0,l_iRetval);
				l_strOutput += l_strTemp;
			}

			l_refstrOutput = l_strOutput;
			m_strErrorMessage = "";

			/*	Call ParseResponseCode() here */
			if ( l_strOutput.Length > 3 ) {
				l_iRetval = ParseResponseCode(l_strCommand.Substring(0,4),l_strOutput.Substring(0,3));
			}
			return l_iRetval;
		}

		public string GetLastError(){
			return m_strErrorMessage;
		}

		/*	LIST command implementation */
		public int GetList(){
			//FTPDataConn conn = new FTPDataConn();
			string l_strCommand = "";
			int l_iRetval = 0;

			string l_strFileList = "";
			l_strCommand = "LIST\r\n";
			l_iRetval = ExecuteDataCommand(l_strCommand,out l_strFileList); 
			if ( l_iRetval != 1 ) {
				return l_iRetval;
			}

			/*	Set Message in the parent window */
			m_ParentWindow.SetStausMessage("Listing Folders and Files");

/*			{
				*	Write to a file here *
				File f = new File(@"C:\Temp\b.txt");
				Stream s = f.OpenWrite();
				Byte[] l_bData = new Byte[l_strFileList.Length + 1];
				l_bData.Initialize();
				l_bData = Encoding.ASCII.GetBytes(l_strFileList);
				s.Write(l_bData,0,l_bData.Length);
				s.Close();
				f.Refresh();
				*	end of file handling *

			}
*/
			string[] l_strarrFiles = l_strFileList.Split("\n".ToCharArray());
			int l_iCount = 0;
			switch (m_iServerOS) {
				case 1 :	/*	Unix	*/
					l_iCount = ParseStringArrayForUnix(l_strarrFiles);
					break;
				case 2 :	/*	Windows	*/
					l_iCount = ParseStringArrayForWind(l_strarrFiles);
					break;
				default:
					break;
			}

			/*	Set Message in the parent window */
			string l_strText = l_iCount + " objects found";
			m_ParentWindow.SetStausMessage(l_strText);

			m_strErrorMessage = "";
			return 1;
		}

		/*	Called for Windows Servers, Parses the array and fills
		 *	the m_FileList object with list of files in each node
		 * */
		private int ParseStringArrayForWind(string[] l_arrFiles){
			m_FileList.RemoveAll();

			string l_strcurFile = "";
			int l_iFileCount = 0;
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
				FileInfo l_FileInfo = GetFileInfoForWindows(l_strarrFields);
				if ( l_FileInfo != null ) {
					/*	Add it to list Object */
					m_FileList.Add(l_FileInfo);
				}
				l_iFileCount++;
			}
			return l_iFileCount;
		}

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

			//l_strarrOut = l_strTemp.Split(l_arrchSep);
			return l_strarrOut;
		}

		private FileInfo GetFileInfoForWindows(string[] l_strarrFields){
			FileInfo l_FileInfo = new FileInfo();
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

			/*	If error occured while parsing return null and ignore this element */
			/*if (l_iErrFlag == 1 ) {
				return null;
			}
			*/
			l_strFilePath = m_strCurrentWorkingDir + "/" + l_strFileName;
			l_FileInfo.SetFileInfo(l_iFileType,l_strFileName,l_strFilePath,l_strDateCreated,l_iFileSize,"","",l_strTimeCreated);
			return l_FileInfo;
		}

		/*	Called for Unix Servers,Parses the array and fills the  
		 *	m_FileList object with list of files in each node
		 * */
		private int ParseStringArrayForUnix(string[] l_arrFiles){
			m_FileList.RemoveAll();

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
					string[] l_strTemp = l_strcurFile.Split(l_arrchSep);
					try {
						string l_strLen = l_strTemp[1];
						l_strLen.Trim();
						m_FileList.TotalLength = l_strLen.ToInt32();
					}
					catch ( FormatException e ) {
						m_FileList.TotalLength = 0;
					}
					catch(Exception e) {
						m_FileList.TotalLength = 0;
					}
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
					FileInfo l_FileInfo = GetFileInfoForUnix(l_strarrFields);
					if ( l_FileInfo != null ) {
						/*	Add it to list Object */
						m_FileList.Add(l_FileInfo);
					}
				}
				l_iLineCount++;
			}
			return l_iLineCount;
		}

		private FileInfo GetFileInfoForUnix(string[] l_strarrFields){
			FileInfo l_FileInfo = new FileInfo();
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
				return null;
			}

			l_strFilePath = m_strCurrentWorkingDir + "/" + l_strFileName;
			l_FileInfo.SetFileInfo(l_iFileType,l_strFileName,l_strFilePath,l_strDateCreated,l_iFileSize,l_strFileOwner,l_strFileGroup,"");
			return l_FileInfo;
		}


		/*	This function takes a string and squeezes more than
		 *	one space characters into one character and 
		 *	then splits into array and returns back to the caller
		 * */
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

		/*	Generate Port Number for Data communication */
		private int GetPort(){
			if ( m_iDataPort > 30000 ) {
				m_iDataPort = 10000;
			}
			return m_iDataPort++;
		}

		/*	Executes a data connection command */
		private int ExecuteDataCommand(string l_strCommand,out string l_strOutputData){
			TCPListener l_FTPListener = null;
			Socket l_ClientDataSocket = null;
			int l_iRetval = 0, l_iDataPort = 0;
			try {
				l_strOutputData = "";
				l_iDataPort = GetPort();
				l_FTPListener = new TCPListener(l_iDataPort);
				l_FTPListener.Start();
				string l_strOutput = "";
				string l_strPortParams = GetPortParameters(l_iDataPort);

				/*	PORT command */
				string l_strPortCommand = "PORT " + l_strPortParams + "\r\n";
				l_iRetval = ExecuteCommand(l_strPortCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					return l_iRetval;
				}

				/*	Execute the actual command here */
				l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					return l_iRetval;
				}

				/*	Accept Client connection here */
				l_ClientDataSocket = l_FTPListener.Accept();
				
				l_ClientDataSocket.SetSockOpt(SocketOption.SolSocket,SocketOption.SoRcvTimeo,m_iRecvTimeout);
				
				//Byte[] l_bSendData = new Byte[1024];
				Byte[] l_bRecvData = new Byte[1024];
				l_strOutput = "";
				string l_strTemp = "";

				l_iRetval = 0;

				/*	Loop through and Receive all the data */
				//for ( ; (l_iRetval = l_ClientDataSocket.Receive(l_bRecvData,511,0)) > 0  ; ) {

				for ( ;  l_ClientDataSocket.Available > 0  ; ) {
					l_iRetval = l_ClientDataSocket.Receive(l_bRecvData,1023,0);
					l_strTemp = Encoding.ASCII.GetString(l_bRecvData,0,l_iRetval);
					l_strOutput += l_strTemp;
				}

				l_ClientDataSocket.Shutdown(SocketShutdown.SdBoth);
				l_ClientDataSocket.Close();
				l_ClientDataSocket = null;
				m_strList = l_strOutput;
				l_strOutputData = l_strOutput;
				l_iRetval = 1;
			}
			catch ( Exception e ) {
				m_strErrorMessage = "Error : " + e;
				l_strOutputData = "";
				return 0;
			}
			finally{
				if ( l_FTPListener != null ) {
					l_FTPListener.Stop();
					l_FTPListener = null;
				}
				if ( l_ClientDataSocket != null ) {
					l_ClientDataSocket.Shutdown(SocketShutdown.SdBoth);
					l_ClientDataSocket.Close();
					l_ClientDataSocket = null;
				}
			}
			return l_iRetval;
		}

		/*	Get Port parameters */
		private string GetPortParameters(int l_iPort){
			string l_strLocalMachine = DNS.GetHostName();
			IPAddress l_IPAddress = DNS.Resolve(l_strLocalMachine);
			string l_strIPAddress = l_IPAddress.ToString();
			l_strIPAddress = l_strIPAddress.Replace('.',',');
			int l_iParam1 = ( 0xff00 & l_iPort ) >> 8;
			int l_iParam2 = ( 0xff & l_iPort ) ;

			string l_strPortParam = l_strIPAddress + "," + l_iParam1 + "," + l_iParam2;
			return l_strPortParam;
		}

		public FileList GetFileList(){
			return m_FileList;
		}

		public string GetRootDirectory(){
			return m_strRootDir;
		}

		public string GetWorkingDirectory(){
			return m_strCurrentWorkingDir;
		}

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

		/*	This function parses the response code for the command passed
		 *	Returns 1 for successfull response codes.
		 *	Returns 0 for error response code, also fills the message into m_strErrorMessage variable
		*/
		private int ParseResponseCode(string l_strCommand,string l_strResponseCode){
			
			int l_iResponseCode = 0, l_iRetval = 0;
			try {
				
				if ( l_strResponseCode.Length > 0 ) {
					l_iResponseCode = l_strResponseCode.ToInt32();
				}
			}
			catch ( FormatException e ) {
				m_strErrorMessage = "Error : Unrecognized Response code from Server" ;
				string err = "err" + e;
				return 0;
			}

			/*	421 Error is trapped as a common error */
			if ( l_iResponseCode == 421 ) {
				m_strErrorMessage = "Error : Service not available, closing control connection. Please try after some time" ;
				return 0;
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
						m_strErrorMessage = "Error : You don't have account for logging in";
						l_iRetval = 0;
						break;
					case 500 : 
						m_strErrorMessage = "Error : <USER> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <USER> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 530 :
						m_strErrorMessage = "Error : User not logged on. Check your User id and password";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in USER command. Response code :" +  l_iResponseCode;
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
						m_strErrorMessage = "Error : You don't have account for logging in";
						l_iRetval = 0;
						break;
					case 500 : 
						m_strErrorMessage = "Error : <PASS> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <PASS> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 503 :
						m_strErrorMessage = "Error : <PASS> command. Bad sequence of commands";
						l_iRetval = 0;
						break;
					case 530 :
						m_strErrorMessage = "Error : User not logged on. Check your User id and password";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in PASS command. Response code :" +  l_iResponseCode;
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
						m_strErrorMessage = "Error : <SYST> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <SYST> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strErrorMessage = "Error : <SYST> command. Command not implemented";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in SYST command. Response code :" +  l_iResponseCode;
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
						m_strErrorMessage = "Error : <PWD> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <PWD> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strErrorMessage = "Error : <PWD> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 550 :
						m_strErrorMessage = "Error : <PWD> command. Requested action not taken or access denied";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in PWD command. Response code :" +  l_iResponseCode;
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
						m_strErrorMessage = "Error : <MODE> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <MODE> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 504 :
						m_strErrorMessage = "Error : <MODE> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strErrorMessage = "Error : <MODE> command. User not logged on";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in MODE command. Response code :" +  l_iResponseCode;
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
						m_strErrorMessage = "Error : <TYPE> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <TYPE> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 504 :
						m_strErrorMessage = "Error : <TYPE> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strErrorMessage = "Error : <TYPE> command. User not logged on";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in TYPE command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("PORT") ) {
				/*	200,226	(success) */
				/*	500,501,530 (syntax error) */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 200 : case 226 :
						l_iRetval = 1;
						break;
					case 500 : 
						m_strErrorMessage = "Error : <PORT> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <PORT> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 530 :
						m_strErrorMessage = "Error : <PORT> command. User not logged on";
						l_iRetval = 0;
						break;
					case 426 :
						m_strErrorMessage = "Error : <PORT> command. Connection closed transfer aborted";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in PORT command. Response code :" +  l_iResponseCode;
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
						m_strErrorMessage = "Error : <LIST> command. Can't open data connection";
						l_iRetval = 0;
						break;
					case 426 :
						m_strErrorMessage = "Error : <LIST> command. Connection closed; transfer aborted";
						l_iRetval = 0;
						break;
					case 451 :
						m_strErrorMessage = "Error : <LIST> command. Requested action aborted: Local error in processing";
						l_iRetval = 0;
						break;
					case 450 :
						m_strErrorMessage = "Error : <LIST> command. Requested file action not taken.File unavailable (e.g., file busy)";
						l_iRetval = 0;
						break;
					case 500 : 
						m_strErrorMessage = "Error : <LIST> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <LIST> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strErrorMessage = "Error : <LIST> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strErrorMessage = "Error : <LIST> command. User not logged on";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in LIST command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.StartsWith("CWD") ) {
				/*	250,150 (success) */
				/*	500,501,502,530,550 (syntax error) */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 250 : case 150 :
						l_iRetval = 1;
						break;
					case 500 : 
						m_strErrorMessage = "Error : <CWD> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <CWD> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strErrorMessage = "Error : <CWD> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strErrorMessage = "Error : <CWD> command. User not logged on";
						l_iRetval = 0;
						break;
					case 550 :
						m_strErrorMessage = "Error : <CWD> command. Requested action not taken.File unavailable (e.g., file not found, no access).";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in CWD command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("RETR") ) {
				/*	125,150,110,250,226 (success) */
				/*	226,425,426,451,450,500,501,502,530 (syntax error) */
				/*	421	(service not available) */
				switch( l_iResponseCode ) {
					case 125 : case 150 : case 110 : case 250 : case 226 :
						l_iRetval = 1;
						break;
					case 425 :
						m_strErrorMessage = "Error : <RETR> command. Can't open data connection";
						l_iRetval = 0;
						break;
					case 426 :
						m_strErrorMessage = "Error : <RETR> command. Connection closed; transfer aborted";
						l_iRetval = 0;
						break;
					case 451 :
						m_strErrorMessage = "Error : <RETR> command. Requested action aborted: Local error in processing";
						l_iRetval = 0;
						break;
					case 450 :
						m_strErrorMessage = "Error : <RETR> command. Requested file action not taken.File unavailable (e.g., file busy)";
						l_iRetval = 0;
						break;
					case 500 : 
						m_strErrorMessage = "Error : <RETR> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <RETR> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strErrorMessage = "Error : <RETR> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strErrorMessage = "Error : <RETR> command. User not logged on";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in RETR command. Response code :" +  l_iResponseCode;
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
						m_strErrorMessage = "Error : <STOR> command. Can't open data connection";
						l_iRetval = 0;
						break;
					case 426 :
						m_strErrorMessage = "Error : <STOR> command. Connection closed; transfer aborted";
						l_iRetval = 0;
						break;
					case 451 :
						m_strErrorMessage = "Error : <STOR> command. Requested action aborted: Local error in processing";
						l_iRetval = 0;
						break;
					case 550 :
						m_strErrorMessage = "Error : <STOR> command. Requested action not taken. File unavailable (e.g., file not found, no access)";
						l_iRetval = 0;
						break;
					case 551 :
						m_strErrorMessage = "Error : <STOR> command. Requested action aborted: Page type unknown";
						l_iRetval = 0;
						break;
					case 552 :
						m_strErrorMessage = "Error : <STOR> command. Requested action aborted: Exceeded storage allocation (for current directory or dataset)";
						l_iRetval = 0;
						break;
					case 532 :
						m_strErrorMessage = "Error : <STOR> command. Need account for storing files";
						l_iRetval = 0;
						break;
					case 450 :
						m_strErrorMessage = "Error : <STOR> command. Requested file action not taken. File unavailable (e.g., file busy)";
						l_iRetval = 0;
						break;
					case 452 :
						m_strErrorMessage = "Error : <STOR> command. Requested file action not taken. Insufficient storage space in system";
						l_iRetval = 0;
						break;
					case 553 :
						m_strErrorMessage = "Error : <STOR> command. Requested action not taken. Filename not allowed";
						l_iRetval = 0;
						break;
					case 500 : 
						m_strErrorMessage = "Error : <STOR> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <STOR> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 530 :
						m_strErrorMessage = "Error : <STOR> command. User not logged on";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in STOR command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}			
			else if ( l_strCommand.StartsWith("MKD") ) {
				/*	257 (success) */
				/*	500,501,502,530,550 (syntax error) */
				/*	421	(service not available) */
				switch ( l_iResponseCode ) {
					case 257 :
						l_iRetval = 1;
						break;
					case 500 : 
						m_strErrorMessage = "Error : <MKD> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <MKD> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strErrorMessage = "Error : <MKD> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strErrorMessage = "Error : <MKD> command. User not logged on";
						l_iRetval = 0;
						break;
					case 550 :
						m_strErrorMessage = "Error : <MKD> command. Requested action not taken. File unavailable (e.g., file not found, no access)";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in MKD command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.StartsWith("RMD") ) {
				/*	250 (success) */
				/*	500,501,502,530,550 (syntax error) */
				/*	421	(service not available) */
				switch ( l_iResponseCode ) {
					case 250 :
						l_iRetval = 1;
						break;
					case 500 : 
						m_strErrorMessage = "Error : <RMD> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <RMD> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strErrorMessage = "Error : <RMD> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strErrorMessage = "Error : <RMD> command. User not logged on";
						l_iRetval = 0;
						break;
					case 550 :
						m_strErrorMessage = "Error : <RMD> command. Requested action not taken. File unavailable (e.g., file not found, no access)";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in RMD command. Response code :" +  l_iResponseCode;
						l_iRetval = 0;
						break;
				}
			}
			else if ( l_strCommand.Equals("DELE") ) {
				/*	250 (success) */
				/*	450,550,500,501,502,530 (syntax error) */
				/*	421	(service not available) */
				switch ( l_iResponseCode ) {
					case 250 :
						l_iRetval = 1;
						break;
					case 450 :
						m_strErrorMessage = "Error : <DELE> command. Requested action not taken. File unavailable (e.g., file not found, no access)";
						l_iRetval = 0;
						break;
					case 550 :
						m_strErrorMessage = "Error : <DELE> command. Requested action not taken. File unavailable (e.g., file not found, no access)";
						l_iRetval = 0;
						break;
					case 500 : 
						m_strErrorMessage = "Error : <DELE> command. Syntax Error Command Unrecognized";
						l_iRetval = 0;
						break;
					case 501 :
						m_strErrorMessage = "Error : <DELE> command. Syntax error in parameters or arguments";
						l_iRetval = 0;
						break;
					case 502 :
						m_strErrorMessage = "Error : <DELE> command. Command not implemented";
						l_iRetval = 0;
						break;
					case 530 :
						m_strErrorMessage = "Error : <DELE> command. User not logged on";
						l_iRetval = 0;
						break;
					default:
						m_strErrorMessage = "Error : Unknown error in DELE command. Response code :" +  l_iResponseCode;
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
						m_strErrorMessage = "Error : Syntax error, command unrecognized";
						l_iRetval = 1;
						break;
					default :
						m_strErrorMessage = "Error : Unknown error in QUIT command. Response code :" +  l_iResponseCode;
						l_iRetval = 1;
						break;
				}
			}
			return l_iRetval;
		}

		public int ChangeWorkingDirectory(string l_strDirectory){
			/*	CWD command */
			string l_strCommand = "";
			string l_strOutput = "";
			int l_iRetval = 0;

			m_strErrorMessage = "";

			/*	USER command */
			l_strCommand = "CWD " + l_strDirectory + "\r\n";
			l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			if ( l_iRetval == 0 ) {
				return l_iRetval;
			}

			m_strCurrentWorkingDir = l_strDirectory;
			return 1;
		}

		/*	Get Current Working Directory on the Server */
		public string GetCurrentWorkingDirectory(){
			return m_strCurrentWorkingDir;
		}

		public int GetServerOS(){
			return m_iServerOS;			
		}

		/*	Set Transfer type
		 *	'A' for ASCII
		 *	'B' for Binary
		 * */
		public int SetTransferType(char l_chType){
			/*	TYPE command, Set Type = ASCII */
			m_strErrorMessage = "";
			if ( l_chType != 'A' && l_chType != 'B' ) {
				m_strErrorMessage = "Invalid Transfer type passed '" + l_chType +"'";
				return 0;
			}
			string l_strMessage = "",l_strCommand = "", l_strOutput = "";
			/*	Set Message in the parent window */
			if ( l_chType == 'A' ) {
				l_strMessage = "Setting to Ascii Type...";
			}
			else if (l_chType == 'B' ) {
				l_strMessage = "Setting to Binary Type...";
			}

			m_ParentWindow.SetStausMessage(l_strMessage);

			l_strCommand = "TYPE " + l_chType + "\r\n";
			int l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			if ( l_iRetval == 0 ) {
				return 0;
			}
			return 1;
		}

		/* Upload file to FTP Server */
		public int UploadFile(string l_strFullPath,string l_strFileName,char l_chTransferType,int l_iUploadSize){

			int l_iRetval = 0,l_iDataPort = 0,l_iBytesSent = 0;
			int l_iBufferLimit = l_iUploadSize;
			
			Byte[] l_bData = new Byte[l_iUploadSize+1];
			TCPListener l_DataListener = null;
			Socket l_ClientDataSocket = null;
			bool l_bAcceptFailed = false;
			

			/*	Local file handle for stream mode */
			FileStream l_fsInFile = null;

			try {

				l_iDataPort = GetPort();
				l_DataListener = new TCPListener(l_iDataPort);
				l_DataListener.Start();
				string l_strOutput = "",l_strCommand = "";
				string l_strPortParams = GetPortParameters(l_iDataPort);

				m_strErrorMessage = "";

				/*	Open Files here */
				if ( l_chTransferType == 'A' ) {
					/*	Open ASCII stream */
					l_fsInFile = new FileStream(l_strFullPath,FileMode.Open,FileAccess.Read);
				}

				/*	PORT command */
				string l_strPortCommand = "PORT " + l_strPortParams + "\r\n";
				l_iRetval = ExecuteCommand(l_strPortCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					return l_iRetval;
				}

				l_strCommand = "STOR " + l_strFileName + "\r\n";
				/*	Execute the actual command here */
				l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					return l_iRetval;
				}
				
				
				/*	Accept Client connection here,
				 *	only if there is a pending connection
				 *  */
				if ( l_DataListener.Pending() ) {
					l_ClientDataSocket = l_DataListener.Accept();
				}
				else {
					/*	Else return from the upload function with error */
					l_bAcceptFailed = true;
					m_strErrorMessage = "Error : No connection from Server. Aborting the process. Try later";
					return 0;
				}

				/* Set Socket options */
				l_ClientDataSocket.SetSockOpt(SocketOption.SolSocket,SocketOption.SoSndTimeo,m_iSendTimeout);
				
				l_bData.Initialize();
				l_strOutput = "";
				l_iRetval = 0;

				/*	Read file and send all data */
				
				int l_iTimes = 1;
				for ( ; (l_iRetval = l_fsInFile.Read(l_bData,0,l_iUploadSize)) != 0 ; ) {

					/* Write to socket here and check for return value */
					l_iRetval = l_ClientDataSocket.Send(l_bData,l_iRetval + 1,0);
					if ( l_iRetval == 0 ) {
						/*	If Connection closed by FTP server,
						 *	then close the connection
						 */
						l_iRetval = 0;
						m_strErrorMessage = "Error : Connection closed by FTP Server. Aborting the upload process.";
						return l_iRetval;
					}
					else if ( l_iRetval == -1 ) {
						/*	If Timeout occured then the FTP Server process
						 *	didn't respond in a timely fashion
						 */
						l_iRetval = 0;
						m_strErrorMessage = "Error : Timeout occured. FTP Server process did not respond in a timely fashion. Try increasing Send timeout property in Configure dialog";
						return l_iRetval;
					}

					l_bData.Initialize();

					/*	Update the Progress bar control */
					l_iBytesSent += l_iRetval;
					if ( l_iBytesSent <= ( l_iBufferLimit * l_iTimes) ) {
						m_ParentWindow.m_progressBarFileStatus.PerformStep();
						m_ParentWindow.m_progressBarFileStatus.Refresh();
						/*	Once in a while refresh main window */
						if ( l_iTimes % 10 == 0 ) {
							m_ParentWindow.Refresh();
						}
						l_iTimes++;
					}
					
				}	/* end of for() */

				if ( l_iRetval == 0 ) {
					/*	End of File is reached and 
					 *	the file transfer is complete
					 * */
					l_iRetval = 1;
				}

				/*	Close Data Connection here */
				if ( l_ClientDataSocket != null ) {
					l_ClientDataSocket.Shutdown(SocketShutdown.SdBoth);
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
				if ( m_strErrorMessage.Length > 0 ) {
					l_strTemp = m_strErrorMessage;
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
						m_strErrorMessage += l_strTemp;
					}
					l_iRetval = 0;
				}
				return l_iRetval ;
			}
			catch ( Exception e) {
				m_strErrorMessage = "Error in uploading file :" + e.Message;
				l_iRetval = 0;
			}
			finally {
				if ( l_DataListener != null ) {
					l_DataListener.Stop();
					l_DataListener = null;
				}
				if ( l_ClientDataSocket != null ) {
					l_ClientDataSocket.Shutdown(SocketShutdown.SdBoth);
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

		/*	Download file from FTP Server */
		public int DownLoadFile(DownloadFileData l_FileObject,char l_chTransferType){

			/*	Read 5 K at a time	*/
			Byte[] l_bRecvData = new Byte[5120];
			TCPListener l_FTPListener = null;
			Socket l_ClientDataSocket = null;
			bool l_bAcceptFailed = false;

			/*	Local file handle for stream mode */
			FileStream l_fsOutFile = null;

			/*	File handle for Binary files */
			BinaryWriter l_fbOutFile = null;

			int l_iRetval = 0, l_iDataPort = 0;
			string l_strServerFileName = l_FileObject.ServerFileName ;
			string l_strLocalFileName = l_FileObject.LocalFileName;
			int l_iFileSize = l_FileObject.FileSize;
			int l_iBytesRevd = 0, l_iBufferLimit = 5119;

			try {
				l_iDataPort = GetPort();
				l_FTPListener = new TCPListener(l_iDataPort);
				l_FTPListener.Start();
				string l_strOutput = "",l_strCommand = "";
				string l_strPortParams = GetPortParameters(l_iDataPort);

				/*	Open Files here */
				if ( l_chTransferType == 'A' ) {
					/*	Open ASCII stream */
					l_fsOutFile = new FileStream(l_strLocalFileName,FileMode.Create,FileAccess.Write);
				}

				/*	PORT command */
				string l_strPortCommand = "PORT " + l_strPortParams + "\r\n";
				l_iRetval = ExecuteCommand(l_strPortCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					return l_iRetval;
				}

				l_strCommand = "RETR " + l_strServerFileName + "\r\n";
				/*	Execute the actual command here */
				l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
				if ( l_iRetval == 0 ) {
					return l_iRetval;
				}

				/*	Accept Client connection here,
				 *	only if there is a pending connection
				 *  */
				if ( l_FTPListener.Pending() ) {
					l_ClientDataSocket = l_FTPListener.Accept();
				}
				else {
					/*	Else return from the download function with error */
					l_bAcceptFailed = true;
					m_strErrorMessage = "Error : No connection from Server. Aborting the process. Try later";
					return 0;
				}
				
				l_ClientDataSocket.SetSockOpt(SocketOption.SolSocket,SocketOption.SoRcvTimeo,m_iRecvTimeout);
				
				l_bRecvData.Initialize();
				l_strOutput = "";
				l_iRetval = 0;

				/*	Loop through and Receive all the data */
				
				int l_iTimes = 1;
				//for ( ;  l_ClientDataSocket.Available > 0  ; ) {
				for ( ; (l_iRetval = l_ClientDataSocket.Receive(l_bRecvData,l_iBufferLimit,0)) > 0  ; ) {
					l_bRecvData.Initialize();
					//l_iRetval = l_ClientDataSocket.Receive(l_bRecvData,l_iBufferLimit,0);
					/*	Write to Local file here */
					l_fsOutFile.Write(l_bRecvData,0,l_iRetval);
					l_fsOutFile.Flush();

					/*	Update the Progress bar control */
					l_iBytesRevd += l_iRetval;
					if ( l_iBytesRevd <= ( l_iBufferLimit * l_iTimes) ) {
						m_ParentWindow.m_progressBarFileStatus.PerformStep();
						m_ParentWindow.m_progressBarFileStatus.Refresh();
						/*	Once in a while refresh main window */
						if ( l_iTimes % 10 == 0 ) {
							m_ParentWindow.Refresh();
						}
						l_iTimes++;
					}
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
					m_strErrorMessage = "Error : Timeout occured. FTP Server process did not respond in a timely fashion. Try increasing Receive timeout property in Configure dialog";
				}

				/*	Close Data Connection here */
				if ( l_ClientDataSocket != null ) {
					l_ClientDataSocket.Shutdown(SocketShutdown.SdBoth);
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
				if ( m_strErrorMessage.Length > 0 ) {
					l_strTemp = m_strErrorMessage;
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
						m_strErrorMessage += l_strTemp;
					}
					l_iRetval = 0;
				}
				return l_iRetval;
			}
			catch ( Exception e ) {
				m_strErrorMessage = "Error : " + e;
				return 0;
			}
			finally{
				if ( l_FTPListener != null ) {
					l_FTPListener.Stop();
					l_FTPListener = null;
				}
				if ( l_ClientDataSocket != null ) {
					l_ClientDataSocket.Shutdown(SocketShutdown.SdBoth);
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

		/* Create Directory on FTP server */
		public int CreateDirectory(string l_strFolder){
			int l_iRetval = 0;
			string l_strCommand = "",l_strOutput = "";
			l_strCommand = "MKD " + l_strFolder + "\r\n";
			
			/*	Execute the actual command here */
			l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			return l_iRetval;
		}

		/* Remove Directory from FTP server */
		public int RemoveDirectory(string l_strFolder){
			int l_iRetval = 0;
			string l_strCommand = "",l_strOutput = "";
			l_strCommand = "RMD " + l_strFolder + "\r\n";
			
			/*	Execute the actual command here */
			l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			return l_iRetval;
		}
		/* Remove File from FTP server */
		public int RemoveFile(string l_strFile){
			int l_iRetval = 0;
			string l_strCommand = "",l_strOutput = "";
			l_strCommand = "DELE " + l_strFile + "\r\n";
			
			/*	Execute the actual command here */
			l_iRetval = ExecuteCommand(l_strCommand,ref l_strOutput);
			return l_iRetval;
		}

	}
}

