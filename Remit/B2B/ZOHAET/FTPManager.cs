using System;
using System.Data;
using System.Text;

namespace ARYETP
{
	/// <summary>
	/// FTP Management Utility.
	/// </summary>
	public class FTPManager
	{
		private FTPClient m_FtpClient;
		public FTPProperties m_FTPProperties;
		public int m_iFileCount, m_iFolderCount;
		string strFolders, strFiles, strStatusMessage;
		public FTPManager()
		{
			m_FTPProperties = new FTPProperties(); 
		}

		public bool OnClickServerConnect()
		{
			SetStatusMessage("Connecting to server. Please wait...","","NONE");

			//Cursor = Cursors.WaitCursor;
			
			//m_FtpClient = new FTPClient();//m_FTPProperties);
			//if ( m_FtpClient == null )
			//{
			m_FtpClient = new FTPClient(m_FTPProperties.FTPServer,m_FTPProperties.UserID,m_FTPProperties.Password,m_FTPProperties.Port,m_FTPProperties.SendTimeOut,m_FTPProperties.RecvTimeOut);
			//}
			//else 
			
			m_FtpClient.FTPServer = m_FTPProperties.FTPServer;
			m_FtpClient.UserID = m_FTPProperties.UserID;
			m_FtpClient.Password = m_FTPProperties.Password;
			m_FtpClient.Port = m_FTPProperties.Port;
			m_FtpClient.SendTimeOut = m_FTPProperties.SendTimeOut;
			m_FtpClient.RecvTimeOut = m_FTPProperties.RecvTimeOut;

			int l_iRetval = m_FtpClient.Connect();
			// Error Occurred!
			if ( l_iRetval == 0 )
			{
				//Cursor = Cursors.Arrow;
				//MessageBox.Show(m_FtpClient.ErrorMessage,"FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				//SetStatusMessage("Error Occurred!",m_FtpClient.ErrorMessage,"FTP Explorer - Error");
				return false;
			}
			else
			{
				//MessageBox.Show("Connected..");
			}
			//EnableToolBarButtons(true);
			string l_strTemp = m_FTPProperties.UserID + "@" + m_FTPProperties.FTPServer;
			SetStatusMessage("Connected to " + l_strTemp,"Listing foldes and files. Please wait...","NONE");
			return true;
			/* Proceed with Listing files *
			DataTable l_dtFileList = m_FtpClient.GetList(null);
			if ( l_dtFileList != null && l_dtFileList.Rows.Count > 0 )
			{

				lblFolders.Text += m_FtpClient.RootDirectory;
				lblFolders.Text += "\n";
				//PopulateFolders(m_tnRootNode,l_dtFileList);
				PopulateFolders(m_FtpClient.RootDirectory,l_dtFileList);
				PopulateFiles(l_dtFileList);
			}
			else 
			{
				//Cursor = Cursors.Arrow;
				/* If error then disconnect *
				MessageBox.Show(m_FtpClient.ErrorMessage,"FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				OnClickServerDisconnect();
				return;
			}
			//this.Text = l_strTemp;
			//Cursor = Cursors.Arrow;*/
		}
		private void OnClickServerDisconnect() 
		{
			//m_strLocalFolder = "C:\\";
			m_FtpClient.Disconnect();
			strFolders = string.Empty;
			strFiles = string.Empty;
			//EnableToolBarButtons(false);
			//SetStatusMessage("Not Connected","",m_strLocalFolder);
			//this.Text = "Not connected";
		}

		private void InitControls()
		{
			m_iFolderCount = m_iFileCount = 0;
			//SetStatusMessage("Not Connected","",m_strLocalFolder);
			return;
		}

		private void OnClickOptionsCreateFolder() 
		{
			string l_strNewFolder = "";

			//FTPNewFolderDlg newFolderDlg = new FTPNewFolderDlg();
			//if ( newFolderDlg.ShowDialog() == DialogResult.OK)		{
			//this.Cursor = Cursors.WaitCursor;
			l_strNewFolder = "newfolder";//newFolderDlg.NewFolder;
			int l_iRetval = m_FtpClient.CreateFolder(l_strNewFolder);
			if ( l_iRetval == 0 ) 
			{
				//this.Cursor = Cursors.Arrow;
				string l_strError = m_FtpClient.ErrorMessage;
				//MessageBox.Show(l_strError,"FTP Explorer",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				SetStatusMessage("Error Occured","","NONE");
				return;
			}
			else 
			{
				/* Add the node to tree view control */
					
				/* Select the current node */
				SetStatusMessage("NONE","Folder(s) :0, File(s) :0","NONE");

				//this.Cursor = Cursors.Arrow;
				//MessageBox.Show("Folder '" + l_strNewFolder + "' Successfully created","FTP Explorer",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			//}
		}

		/*private void OnClickOptionsDeleteFolder() 
		{
			string l_strFolder = "\\newfolder";
			l_strFolder = l_strFolder.Replace('\\','/');
			string l_strMessage = "Are you sure to delete '" + l_strFolder + "' folder ?";

			SetStatusMessage("Deleting selected folder. Please wait...","","NONE");
			m_sbStatus.Refresh();

			this.Cursor = Cursors.WaitCursor;

			TreeNode l_tnParentNode = l_tnCurrNode.Parent;
			if ( l_tnParentNode == null ) 
			{
				l_tnParentNode = m_tnRootNode;
			}
					
			/* Go to parent folder and then delete the current folder *
			string l_strParentFolder = l_tnParentNode.FullPath;
			l_strParentFolder = l_strParentFolder.Replace('\\','/');
			int l_iRetval = m_FtpClient.ChangeWorkingFolder(l_strParentFolder);
			if (l_iRetval == 0 ) 
			{
				this.Cursor = Cursors.Arrow;
				string l_strErr = m_FtpClient.ErrorMessage;
				MessageBox.Show(l_strErr,"FTP Explorer",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return ;
			}

			/* Now Remove Folder from FTP Server *
			if ( m_FtpClient.RemoveFolder(l_strFolder) == 0 ) 
			{
				this.Cursor = Cursors.Arrow;
				string l_strError = m_FtpClient.ErrorMessage;
				MessageBox.Show(l_strError,"FTP Explorer",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return;
			}

			this.Cursor = Cursors.WaitCursor;
		
			/* Refresh File views for the Parent folder *
			string l_strParentDir = l_tnParentNode.Text;
			m_tVFolders.SelectedNode = l_tnParentNode;
		
			/* Clear all child nodes *
			l_tnParentNode.Nodes.Clear();
			RefreshFolderView(l_strParentFolder,l_strParentDir,l_tnParentNode);
			*

			this.Cursor = Cursors.Arrow;
			return;
		}*/

		public DataTable OnClickOptionsRefresh() 
		{
			StringBuilder strDirectoryListing = new StringBuilder(String.Empty);
		
			DataTable l_dtFileList = m_FtpClient.GetList(null);
			if ( l_dtFileList != null && l_dtFileList.Rows.Count > 0 )
			{
				/* Clear the root node */

				strDirectoryListing.Append(m_FtpClient.RootDirectory.ToString()+ "\n");
				//strDirectoryListing.Append( + "\n");

				//strDirectoryListing.Append(PopulateFiles(l_dtFileList)+ "\n\nFolders:\n\n");
				//strDirectoryListing.Append(PopulateFolders(l_dtFileList));
				//return strDirectoryListing.ToString();
				return l_dtFileList;
			}
			else 
			{
				//strDirectoryListing.Append("No folders or files found" + "\n");
				//return strDirectoryListing.ToString();
				return null;
			}
		}

		public void OnClickOptionsUploadFile(String strPath) 
		{
			string l_strLocalFileFullName = strPath;
			int l_iLen = l_strLocalFileFullName.Length;
			int l_iCtr = l_iLen;
			for ( l_iCtr-- ; l_iCtr > 0 ; l_iCtr-- )
			{
				char ch = l_strLocalFileFullName[l_iCtr];
				if ( ch == '\\' )
				{
					break;
				}
			}
			string l_strLocalFileName = l_strLocalFileFullName.Substring(l_iCtr+1);
			l_strLocalFileName.Trim();
			if ( l_strLocalFileName.Length == 0 )
			{
				SetStatusMessage("Select a valid file and click upload option","FTP Explorer - Error","NONE");
				return;
			}
			String strUploadDir = (String) System.Configuration.ConfigurationSettings.AppSettings.GetValues("ZOHAET.UploadDirectory").GetValue(0);
			string l_strRemoteFile = m_FtpClient.CurrentDirectory + strUploadDir + "/" + l_strLocalFileName;
			//int iFileSize = 5120;
			//int l_iRetval = m_FtpClient.UploadFile(l_strLocalFileFullName ,l_strLocalFileName, 'A', iFileSize);
			int l_iRetval = m_FtpClient.UploadFile(l_strLocalFileFullName,l_strRemoteFile);
			
			if ( l_iRetval == 0 )
			{
				//MessageBox.Show(m_FtpClient.ErrorMessage,"ZohaET - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				SetStatusMessage(m_FtpClient.ErrorMessage,"LIST","NONE");
			}

			string l_strTemp = "Connected to " + m_FTPProperties.UserID + "@" + m_FTPProperties.FTPServer;
			SetStatusMessage(l_strTemp,"LIST","NONE");
		}

		public void OnClickOptionsDownloadFile(String strFileName) 
		{
			//string l_strFileName = m_FtpClient.CurrentDirectory + "Output/" + strFileName;
			string l_strFileName = m_FtpClient.CurrentDirectory + "TestFiles/" + strFileName;
			l_strFileName.Trim();
			if ( l_strFileName.Length == 0 )
			{
				//MessageBox.Show("Invalid filename","FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			string l_strLocalFile = @"C:\\ARYSRET\\Zoha\\downloaded\\" + strFileName;
			int l_iRetval = m_FtpClient.DownLoadFile(l_strFileName,l_strLocalFile);
			
			if ( l_iRetval == 0 )
			{
				//MessageBox.Show(m_FtpClient.ErrorMessage,"FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			//string l_strTemp = "Connected to " + m_FTPProperties.UserID + "@" + m_FTPProperties.FTPServer;
			//SetStatusMessage(l_strTemp,"LIST","NONE");
			return;
		}

		public void OnClickOptionsDeleteFile(String strFileName) 
		{
			//DataGridCell l_dgcCurrent = m_dGFiles.CurrentCell;
			//int l_iCurrentRow = m_dGFiles.CurrentCell.RowNumber;
			string l_strFileName = m_FtpClient.CurrentDirectory + "Output/" + strFileName;//(string) m_dGFiles[l_dgcCurrent];
			l_strFileName.Trim();
			if ( l_strFileName.Length == 0 )
			{
				//MessageBox.Show("Select a valid file and click delete option","FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			int l_iRetval = m_FtpClient.RemoveFile(l_strFileName);
			if ( l_iRetval == 1 )
			{
				try 
				{
					//m_iFileCount--;
					//DataView l_dvFile = (DataView) m_dGFiles.DataSource;
					//DataTable l_dtFileList = l_dvFile.Table;
					//l_dtFileList.Rows.RemoveAt(l_iCurrentRow);
					//m_dGFiles.DataSource = l_dtFileList.DefaultView;
					SetStatusMessage("NONE","LIST","NONE");
				}
				catch /*( Exception e1)*/
				{
				}
			}
		}

		private void OnClickOptionsSetLWD(object sender, System.EventArgs e) 
		{
			/*FTPLocalFolderDlg localFolderdlg = new FTPLocalFolderDlg(m_strLocalFolder);
			if ( localFolderdlg.ShowDialog() == DialogResult.OK)
			{
				m_strLocalFolder = localFolderdlg.LocalFolder;
			}
			SetStatusMessage("NONE","NONE",m_strLocalFolder);*/
		}

		private String PopulateFolders(DataTable l_dtFileList)
		{
			int l_iFileType = 0;
			int l_iFolderCtr = 0;
			string l_strFileName = "";
			String l_strFileListing = String.Empty;
			//TreeNodeCollection l_tnCollection = l_tnCurrNode.Nodes;
			foreach(object obj in l_dtFileList.Rows)
			{
				DataRow l_drRow = (DataRow) obj;
				l_iFileType = (int) l_drRow[0];
				l_strFileName = (string) l_drRow[1];

				/* Add only folders */
				if ( l_iFileType == 2 )
				{
					//lblFolders += l_strFileName + "\n";//l_tnCollection.Add(new TreeNode(l_strFileName,1,2));
					 l_strFileListing += l_strFileName + "\n";
					l_iFolderCtr++;
				}
			}
			return l_strFileListing.ToString();
		}

		private DataTable PopulateFiles(DataTable l_dtFileList)
		{
			String strFiles			= String.Empty;
			DataTable dt_Files		= new DataTable("Files");
			DataColumn dc_Name		= new DataColumn("FileName", typeof(String));
			DataColumn dc_Created	= new DataColumn("CreatedDate", typeof(String));
			DataColumn dc_Size		= new DataColumn("FileSize", typeof(String));
			DataColumn dc_Owner		= new DataColumn("FileOwner", typeof(String));
			DataColumn dc_Group		= new DataColumn("FileGroup", typeof(String));
			dt_Files.Columns.Add(dc_Name);
			dt_Files.Columns.Add(dc_Created);
			dt_Files.Columns.Add(dc_Size);
			try 
			{
				int l_iFileType = 0;
				int l_iFileCtr = 0;
				
				if ( m_FtpClient.ServerOS == 1 )
				{
					// Unix.
					dt_Files.Columns.Add(dc_Owner);
					dt_Files.Columns.Add(dc_Group);
					strFiles += "File name \t\t" + "Created Date \t\t" + "File Size \t\t" + "File Owner \t\t" + "File Group \n";
				}
				else if (m_FtpClient.ServerOS == 2) 
				{
					// Windows.
					strFiles += "File name \t\t" + "Created Date \t\t" + "File Size \n";
				}

				foreach(DataRow l_drRow in l_dtFileList.Rows)
				{
					l_iFileType = (int) l_drRow[0];
					DataRow dr_Files = dt_Files.NewRow();

					/* Add only files */
					if ( l_iFileType == 1 )
					{
						//DataRow l_newRow = l_dtFiles.NewRow();
						if ( m_FtpClient.ServerOS == 1 )    /*Unix*/
						{
							dr_Files["dc_Name"]		= l_drRow[1];
							dr_Files["dc_Created"]	= l_drRow[3];
							dr_Files["dc_Size"]		= l_drRow[4];
							dr_Files["dc_Owner"]	= l_drRow[5];
							dr_Files["dc_Group"]	= l_drRow[6];
							strFiles += l_drRow[1]	+ "\t\t";
							strFiles += l_drRow[3]	+ "\t\t";
							strFiles += l_drRow[4]	+ "\t\t";
							strFiles += l_drRow[5]	+ "\n";
							strFiles += l_drRow[6];
							dt_Files.Rows.Add(dr_Files);
						}
						else if (m_FtpClient.ServerOS == 2) /*Windows*/
						{
							/* Windows */
							dr_Files["dc_Name"]		= l_drRow[1];
							dr_Files["dc_Created"]	= l_drRow[3];
							dr_Files["dc_Size"]		= l_drRow[4];
							strFiles += l_drRow[1]	+ "\t\t";
							strFiles += l_drRow[3]	+ "\t\t";
							strFiles += l_drRow[4]	+ "\n";
							dt_Files.Rows.Add(dr_Files);
						}
						//l_dtFiles.Rows.Add(l_newRow);
						l_iFileCtr++;
					}
				}
				m_iFileCount = l_iFileCtr;
				//SetStatusMessage("NONE","LIST","NONE");
			}
			catch /*( Exception e)*/
			{
				//return String.Empty;
				return null;
			}
			//return strFiles;
			return dt_Files;
		}

		private void SetStatusMessage(string l_strMessage1,string l_strMessage2,string l_strMessage3)
		{
			strStatusMessage = string.Empty;
			if ( l_strMessage1.Equals("NONE") == false )
			{
				strStatusMessage += "Info: " + l_strMessage1 + "\n";
			}
			
			if ( l_strMessage2.Equals("LIST") == true )
			{
				string l_strText = "Folder(s) :" + m_iFolderCount + ", File(s) :" + m_iFileCount;
				strStatusMessage += l_strText;
			}
			else if ( l_strMessage2.Equals("NONE") == false )
			{
				strStatusMessage += l_strMessage2;
			}
			
			if ( l_strMessage3.Equals("NONE") == false )
			{
				strStatusMessage += l_strMessage3;
			}
			//m_sbStatus.Refresh();
		}
	}
}