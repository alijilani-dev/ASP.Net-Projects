using System;

namespace ARYETP
{
	/// <summary>
	/// Summary description for FTPProperties.
	/// </summary>
	public class FTPProperties
	{
		private string m_strFTPServer;
		private string m_strUserID;
		private string m_strPassword;
		private string m_strServerType;
		private int m_iFTPPort;
		private int m_iSendTimeOut;
		private int m_iRecvTimeOut;
		private char m_chTransferMode;

		public FTPProperties(){
			m_iFTPPort = 21;
			m_iSendTimeOut = 1000;
			m_iRecvTimeOut = 4000;
			m_chTransferMode = 'A';
			m_strFTPServer = "65.223.147.201";
			//m_strFTPServer = "64.202.167.3";
			m_strUserID = "speedremit";
			//m_strPassword = "speedremit";
			m_strPassword = "zohaindia";
			m_strServerType = "Unix";
		}

		public string FTPServer {
			set { m_strFTPServer = value;}
			get { return m_strFTPServer;}
		}

		public string UserID {
			set { m_strUserID = value;}
			get { return m_strUserID;}
		}

		public string Password {
			set { m_strPassword = value;}
			get { return m_strPassword;}
		}

		public string ServerType {
			set { m_strServerType = value;}
			get { return m_strServerType;}
		}

		public int ServerTypeIndex {
			get {
				if ( m_strServerType == "Windows"){
					return 0;
				}
				else if ( m_strServerType == "Unix" ){
					return 1;
				}
				else {
					return 2;
				}
			}
		}

		public int Port {
			set { m_iFTPPort = value;}
			get { return m_iFTPPort;}
		}

		public int SendTimeOut {
			set { m_iSendTimeOut = value;}
			get { return m_iSendTimeOut;}
		}

		public int RecvTimeOut {
			set { m_iRecvTimeOut = value;}
			get { return m_iRecvTimeOut;}
		}

		public char TransferMode {
			set { m_chTransferMode = value;}
			get { return m_chTransferMode;}
		}

	}
}