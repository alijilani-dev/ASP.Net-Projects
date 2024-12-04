/*	Project		:	FTPExplorer
 *  Version		:	2.0
 *	File Name	:	ExplorerDlg.cs
 *	Purpose		:	FTP Explorer Main Window
 *	Author		:	K.Niranjan Kumar
 *	Date		:	July 08, 2001
 *	Company		:	Cognizant Technology Solutions.
 *	e-Mail		:	KNiranja@chn.cognizant.com
 */

namespace FTPExplorer
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.WinForms;
    using System.Data;
	using System.IO;
	using System.Globalization;

    /// <summary>
    ///    Summary description for Form1.
    /// </summary>
    public class ExplorerDlg : System.WinForms.Form
    {
        /// <summary>
        ///    Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components;
		private System.WinForms.ToolBarButton toolBarButton15;
		private System.WinForms.ToolBarButton toolBarButton14;
		private System.WinForms.ToolBarButton toolBarButton13;
		private System.WinForms.MenuItem menuItem12;
		private System.WinForms.MenuItem menuItem7;
		private System.WinForms.MenuItem menuItem6;
		private System.WinForms.OpenFileDialog m_openFileDialog;
		private System.WinForms.MenuItem m_menuMRU4;
		private System.WinForms.MenuItem m_menuMRU3;
		private System.WinForms.MenuItem m_menuMRU2;
		private System.WinForms.MenuItem m_menuMRUSep;
		private System.WinForms.MenuItem m_menuMRU1;
		public System.WinForms.ProgressBar m_progressBarFileStatus;
		private System.WinForms.StatusBarPanel statusBarPanel3;
		private System.WinForms.ToolBarButton toolBarButton12;
		private System.WinForms.MenuItem menuItem18;
		private System.WinForms.MenuItem menuItem16;
		private System.WinForms.ToolTip m_toolTip;
		private System.WinForms.ImageList m_imageListTreeView;
		private System.WinForms.GroupBox groupBox1;
		private System.WinForms.Label m_labelListView;
		private System.WinForms.Label m_labelTreeView;
		private System.WinForms.ToolBarButton toolBarButton11;
		private System.WinForms.ToolBarButton toolBarButton10;
		private System.WinForms.ToolBarButton toolBarButton9;
		private System.WinForms.ToolBarButton toolBarButton8;
		private System.WinForms.ImageList m_imageListToolBar;
		private System.WinForms.StatusBarPanel statusBarPanel2;
		private System.WinForms.StatusBarPanel statusBarPanel1;
		private System.WinForms.StatusBar m_statusBar;
		private System.WinForms.ListView m_lvFileView;
		private System.WinForms.TreeView m_tvFolderView;
		private System.WinForms.ToolBarButton toolBarButton7;
		private System.WinForms.ToolBarButton toolBarButton6;
		private System.WinForms.ToolBarButton toolBarButton5;
		private System.WinForms.ToolBarButton toolBarButton4;
		private System.WinForms.ToolBarButton toolBarButton3;
		private System.WinForms.ToolBarButton toolBarButton2;
		private System.WinForms.ToolBarButton toolBarButton1;
		private System.WinForms.ToolBar m_toolBar;
		private System.WinForms.MenuItem menuItem15;
		private System.WinForms.MenuItem menuItem11;
		private System.WinForms.MenuItem menuItem5;
		private System.WinForms.MenuItem menuItem14;
		private System.WinForms.MenuItem menuItem13;
		private System.WinForms.MenuItem menuItem10;
		private System.WinForms.MenuItem menuItem9;
		private System.WinForms.MenuItem menuItem8;
		private System.WinForms.MenuItem menuItem4;
		private System.WinForms.MenuItem menuItem3;
		private System.WinForms.MenuItem menuItem2;
		private System.WinForms.MenuItem menuItem1;
		private System.WinForms.MainMenu m_mainMenu;


		/*	Our members */
		private FTPClient m_FTPClient;
		private bool m_bConnectedFlag ;
		private TreeNode m_tnRootNode;
		private string m_strFTPAddress;
		private string m_strFTPUser;
		private string m_strFTPPassword;
		private string m_strLocalDirectory;

		private int m_iTotalFiles = 0,m_iTotalFolders = 0;
		private long m_lTotalSize;

		private MRUConnections[] m_arrMRUConn;
		private int m_iMRUCount;

        public ExplorerDlg()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
			
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
			m_FTPClient = new FTPClient();
			m_bConnectedFlag = false;
			m_strFTPAddress = "";
			m_strFTPUser = "";
			m_strFTPPassword = "";
			ToggleMenuItems(0);
			InitControls();
			m_tnRootNode = null;
			m_strLocalDirectory = "C:\\";		/*	C:\ is the default Local directory	*/
			m_FTPClient.ParentWindow = this;
			m_arrMRUConn = new MRUConnections[4];
			m_iMRUCount = 0;
			/*	Fill in the arrays */
			m_arrMRUConn[0] = new MRUConnections();
			m_arrMRUConn[1] = new MRUConnections();
			m_arrMRUConn[2] = new MRUConnections();
			m_arrMRUConn[3] = new MRUConnections();
		}

		private void InitControls(){
			m_labelTreeView.Text = "No folders to display";
			m_labelListView.Text = "No files to display";
			statusBarPanel1.Text = "Not Connected";
			statusBarPanel2.Text = "";
			statusBarPanel3.Text = m_strLocalDirectory;
		}

		private void UpdateListViewLabel(){
			string l_strStatusMessage = "";
			l_strStatusMessage = "Folder(s) : " + m_iTotalFolders + ", File(s) : " + m_iTotalFiles + ", Total Size : " + m_lTotalSize.ToString();
			m_labelListView.Text = l_strStatusMessage;
			m_labelListView.Refresh();
		}

        /// <summary>
        ///    Clean up any resources being used.
        /// </summary>
        public override void Dispose()
        {
            base.Dispose();
            components.Dispose();
        }

        /// <summary>
        ///    Required method for Designer support - do not modify
        ///    the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager (typeof(ExplorerDlg));
			this.components = new System.ComponentModel.Container ();
			this.m_menuMRUSep = new System.WinForms.MenuItem ();
			this.m_labelTreeView = new System.WinForms.Label ();
			this.m_toolTip = new System.WinForms.ToolTip (this.components);
			this.m_labelListView = new System.WinForms.Label ();
			this.m_toolBar = new System.WinForms.ToolBar ();
			this.m_menuMRU3 = new System.WinForms.MenuItem ();
			this.toolBarButton13 = new System.WinForms.ToolBarButton ();
			this.m_statusBar = new System.WinForms.StatusBar ();
			this.toolBarButton15 = new System.WinForms.ToolBarButton ();
			this.toolBarButton14 = new System.WinForms.ToolBarButton ();
			this.toolBarButton12 = new System.WinForms.ToolBarButton ();
			this.toolBarButton11 = new System.WinForms.ToolBarButton ();
			this.toolBarButton10 = new System.WinForms.ToolBarButton ();
			this.menuItem18 = new System.WinForms.MenuItem ();
			this.toolBarButton4 = new System.WinForms.ToolBarButton ();
			this.toolBarButton5 = new System.WinForms.ToolBarButton ();
			this.m_menuMRU4 = new System.WinForms.MenuItem ();
			this.toolBarButton1 = new System.WinForms.ToolBarButton ();
			this.toolBarButton6 = new System.WinForms.ToolBarButton ();
			this.toolBarButton7 = new System.WinForms.ToolBarButton ();
			this.m_menuMRU2 = new System.WinForms.MenuItem ();
			this.menuItem16 = new System.WinForms.MenuItem ();
			this.menuItem14 = new System.WinForms.MenuItem ();
			this.menuItem15 = new System.WinForms.MenuItem ();
			this.m_tvFolderView = new System.WinForms.TreeView ();
			this.m_progressBarFileStatus = new System.WinForms.ProgressBar ();
			this.m_menuMRU1 = new System.WinForms.MenuItem ();
			this.menuItem8 = new System.WinForms.MenuItem ();
			this.statusBarPanel1 = new System.WinForms.StatusBarPanel ();
			this.toolBarButton8 = new System.WinForms.ToolBarButton ();
			this.menuItem5 = new System.WinForms.MenuItem ();
			this.menuItem4 = new System.WinForms.MenuItem ();
			this.statusBarPanel2 = new System.WinForms.StatusBarPanel ();
			this.toolBarButton9 = new System.WinForms.ToolBarButton ();
			this.menuItem13 = new System.WinForms.MenuItem ();
			this.menuItem10 = new System.WinForms.MenuItem ();
			this.menuItem11 = new System.WinForms.MenuItem ();
			this.m_imageListTreeView = new System.WinForms.ImageList ();
			this.statusBarPanel3 = new System.WinForms.StatusBarPanel ();
			this.menuItem12 = new System.WinForms.MenuItem ();
			this.menuItem6 = new System.WinForms.MenuItem ();
			this.toolBarButton3 = new System.WinForms.ToolBarButton ();
			this.m_lvFileView = new System.WinForms.ListView ();
			this.m_imageListToolBar = new System.WinForms.ImageList ();
			this.menuItem9 = new System.WinForms.MenuItem ();
			this.m_openFileDialog = new System.WinForms.OpenFileDialog ();
			this.toolBarButton2 = new System.WinForms.ToolBarButton ();
			this.menuItem2 = new System.WinForms.MenuItem ();
			this.m_mainMenu = new System.WinForms.MainMenu ();
			this.menuItem7 = new System.WinForms.MenuItem ();
			this.menuItem1 = new System.WinForms.MenuItem ();
			this.groupBox1 = new System.WinForms.GroupBox ();
			this.menuItem3 = new System.WinForms.MenuItem ();
			statusBarPanel1.BeginInit ();
			statusBarPanel2.BeginInit ();
			statusBarPanel3.BeginInit ();
			//@this.TrayHeight = 90;
			//@this.TrayLargeIcon = false;
			//@this.TrayAutoArrange = true;
			m_menuMRUSep.Visible = false;
			m_menuMRUSep.Text = "-";
			m_menuMRUSep.Index = 9;
			m_labelTreeView.Location = new System.Drawing.Point (8, 38);
			m_labelTreeView.Size = new System.Drawing.Size (246, 18);
			m_labelTreeView.BorderStyle = System.WinForms.BorderStyle.Fixed3D;
			m_toolTip.SetToolTip (m_labelTreeView, "Shows current working directory on FTP server");
			m_labelTreeView.TabIndex = 4;
			//@m_toolTip.SetLocation (new System.Drawing.Point (153, 34));
			m_toolTip.Active = true;
			m_labelListView.Location = new System.Drawing.Point (259, 38);
			m_labelListView.Size = new System.Drawing.Size (438, 18);
			m_labelListView.BorderStyle = System.WinForms.BorderStyle.Fixed3D;
			m_toolTip.SetToolTip (m_labelListView, "Shows Folder(s),File(s) and Total Size in bytes under current working folder");
			m_labelListView.TabIndex = 5;
			m_toolBar.ImageList = this.m_imageListToolBar;
			m_toolBar.Size = new System.Drawing.Size (702, 32);
			m_toolBar.ButtonSize = new System.Drawing.Size (25, 25);
			m_toolBar.DropDownArrows = true;
			m_toolBar.Appearance = System.WinForms.ToolBarAppearance.Flat;
			m_toolBar.TabIndex = 0;
			m_toolBar.ShowToolTips = true;
			m_toolBar.ButtonClick += new System.WinForms.ToolBarButtonClickEventHandler (this.OnClickToolBar);
			m_toolBar.Buttons.All = new System.WinForms.ToolBarButton[15] {this.toolBarButton1, this.toolBarButton2, this.toolBarButton12, this.toolBarButton6, this.toolBarButton13, this.toolBarButton14, this.toolBarButton15, this.toolBarButton3, this.toolBarButton4, this.toolBarButton11, this.toolBarButton8, this.toolBarButton9, this.toolBarButton10, this.toolBarButton7, this.toolBarButton5};
			m_menuMRU3.Visible = false;
			m_menuMRU3.Text = "MRU3";
			m_menuMRU3.Index = 7;
			m_menuMRU3.Click += new System.EventHandler (this.OnClickMenuMRU3);
			toolBarButton13.ImageIndex = 3;
			toolBarButton13.ToolTipText = "Create Folder in FTP Server";
			m_statusBar.BackColor = System.Drawing.SystemColors.Control;
			m_statusBar.SizingGrip = false;
			m_statusBar.Location = new System.Drawing.Point (0, 444);
			m_statusBar.Size = new System.Drawing.Size (702, 20);
			m_statusBar.TabIndex = 3;
			m_statusBar.ShowPanels = true;
			m_statusBar.Panels.All = new System.WinForms.StatusBarPanel[3] {this.statusBarPanel1, this.statusBarPanel2, this.statusBarPanel3};
			toolBarButton15.ImageIndex = 5;
			toolBarButton15.ToolTipText = "Delete File(s) from FTP Server";
			toolBarButton14.ImageIndex = 4;
			toolBarButton14.ToolTipText = "Delete Folder from FTP";
			toolBarButton12.ImageIndex = 2;
			toolBarButton12.ToolTipText = "Configure Server and Client Properties";
			toolBarButton11.ImageIndex = 8;
			toolBarButton11.ToolTipText = "Refresh Folder and File Views at Root Level";
			toolBarButton10.ImageIndex = 10;
			toolBarButton10.ToolTipText = "About FTP Explorer";
			menuItem18.Text = "-";
			menuItem18.Index = 4;
			toolBarButton4.ImageIndex = 7;
			toolBarButton4.ToolTipText = "Download file from FTP server";
			toolBarButton5.ImageIndex = 11;
			toolBarButton5.ToolTipText = "Close FTP Explorer";
			m_menuMRU4.Visible = false;
			m_menuMRU4.Text = "MRU4";
			m_menuMRU4.Index = 8;
			m_menuMRU4.Click += new System.EventHandler (this.OnClickMenuMRU4);
			toolBarButton1.ImageIndex = 0;
			toolBarButton1.ToolTipText = "Connect to FTP Server";
			toolBarButton6.Style = System.WinForms.ToolBarButtonStyle.Separator;
			toolBarButton7.Style = System.WinForms.ToolBarButtonStyle.Separator;
			m_menuMRU2.Visible = false;
			m_menuMRU2.Text = "MRU2";
			m_menuMRU2.Index = 6;
			m_menuMRU2.Click += new System.EventHandler (this.OnClickMenuMRU2);
			menuItem16.Text = "&Configure";
			menuItem16.Index = 3;
			menuItem16.Click += new System.EventHandler (this.OnClickConfigure);
			menuItem14.Text = "&File";
			menuItem14.Index = 1;
			menuItem14.MenuItems.All = new System.WinForms.MenuItem[6] {this.menuItem7, this.menuItem12, this.menuItem6, this.menuItem5, this.menuItem11, this.menuItem15};
			menuItem15.Text = "&Refresh";
			menuItem15.Index = 5;
			menuItem15.Click += new System.EventHandler (this.OnClickRefresh);
			m_tvFolderView.ImageList = this.m_imageListTreeView;
			m_tvFolderView.Location = new System.Drawing.Point (6, 61);
			m_tvFolderView.Size = new System.Drawing.Size (248, 382);
			m_toolTip.SetToolTip (m_tvFolderView, "Shows accessible folder(s) on the FTP Server");
			m_tvFolderView.TabIndex = 1;
			m_tvFolderView.KeyDown += new System.WinForms.KeyEventHandler (this.OnKeyDownTreeView);
			m_tvFolderView.AfterSelect += new System.WinForms.TreeViewEventHandler (this.OnAfterSelectFolderView);
			m_progressBarFileStatus.Visible = false;
			m_toolTip.SetToolTip (m_progressBarFileStatus, "Shows file transfer progress");
			m_progressBarFileStatus.Location = new System.Drawing.Point (507, 446);
			m_progressBarFileStatus.TabIndex = 7;
			m_progressBarFileStatus.Size = new System.Drawing.Size (195, 18);
			m_progressBarFileStatus.Step = 2;
			m_menuMRU1.Visible = false;
			m_menuMRU1.Text = "MRU1";
			m_menuMRU1.Index = 5;
			m_menuMRU1.Click += new System.EventHandler (this.OnClickMenuMRU1);
			menuItem8.Text = "&Help";
			menuItem8.Index = 2;
			menuItem8.MenuItems.All = new System.WinForms.MenuItem[2] {this.menuItem9, this.menuItem10};
			//@statusBarPanel1.SetLocation (new System.Drawing.Point (112, 7));
			statusBarPanel1.ToolTipText = "Displays connection status";
			statusBarPanel1.Width = 255;
			toolBarButton8.Style = System.WinForms.ToolBarButtonStyle.Separator;
			menuItem5.Text = "&Upload";
			menuItem5.Index = 3;
			menuItem5.Click += new System.EventHandler (this.OnClickUploadFile);
			menuItem4.Text = "-";
			menuItem4.Index = 2;
			//@statusBarPanel2.SetLocation (new System.Drawing.Point (230, 7));
			statusBarPanel2.ToolTipText = "Displays progress status of FTP connection";
			statusBarPanel2.Width = 250;
			toolBarButton9.ImageIndex = 9;
			toolBarButton9.ToolTipText = "Displays System Information";
			menuItem13.Text = "&Exit";
			menuItem13.Index = 10;
			menuItem13.Click += new System.EventHandler (this.OnClickExit);
			menuItem10.Text = "&About";
			menuItem10.Index = 1;
			menuItem10.Click += new System.EventHandler (this.OnClickAbout);
			menuItem11.Text = "&Download";
			menuItem11.Index = 4;
			menuItem11.Click += new System.EventHandler (this.OnClickDownloadFile);
			//@m_imageListTreeView.SetLocation (new System.Drawing.Point (7, 34));
			m_imageListTreeView.ImageSize = new System.Drawing.Size (16, 16);
			m_imageListTreeView.ImageStream = (System.WinForms.ImageListStreamer) resources.GetObject ("m_imageListTreeView.ImageStream");
			m_imageListTreeView.ColorDepth = System.WinForms.ColorDepth.Depth8Bit;
			m_imageListTreeView.TransparentColor = System.Drawing.Color.Transparent;
			//@statusBarPanel3.SetLocation (new System.Drawing.Point (241, 34));
			statusBarPanel3.ToolTipText = "Displays Local working directory";
			statusBarPanel3.Width = 200;
			menuItem12.Text = "R&emove Folder";
			menuItem12.Index = 1;
			menuItem12.Click += new System.EventHandler (this.OnClickRemoveFolder);
			menuItem6.Text = "-";
			menuItem6.Index = 2;
			toolBarButton3.ImageIndex = 6;
			toolBarButton3.ToolTipText = "Upload File to FTP server";
			m_lvFileView.Location = new System.Drawing.Point (258, 61);
			m_lvFileView.Size = new System.Drawing.Size (439, 382);
			m_lvFileView.FullRowSelect = true;
			m_lvFileView.View = System.WinForms.View.Report;
			m_lvFileView.ForeColor = System.Drawing.SystemColors.WindowText;
			m_toolTip.SetToolTip (m_lvFileView, "Shows File(s) on the selected folder");
			m_lvFileView.TabIndex = 2;
			m_lvFileView.KeyDown += new System.WinForms.KeyEventHandler (this.OnKeyDownFileView);
			//@m_imageListToolBar.SetLocation (new System.Drawing.Point (348, 7));
			m_imageListToolBar.ImageSize = new System.Drawing.Size (22, 22);
			m_imageListToolBar.ImageStream = (System.WinForms.ImageListStreamer) resources.GetObject ("m_imageListToolBar.ImageStream");
			m_imageListToolBar.ColorDepth = System.WinForms.ColorDepth.Depth8Bit;
			m_imageListToolBar.TransparentColor = System.Drawing.Color.Transparent;
			menuItem9.Text = "&System Info";
			menuItem9.Index = 0;
			menuItem9.Click += new System.EventHandler (this.OnClickSystemInfo);
			//@m_openFileDialog.SetLocation (new System.Drawing.Point (359, 34));
			toolBarButton2.ImageIndex = 1;
			toolBarButton2.ToolTipText = "Disconnect current session";
			menuItem2.Text = "&Connect";
			menuItem2.Index = 0;
			menuItem2.Click += new System.EventHandler (this.OnClickConnect);
			//@m_mainMenu.SetLocation (new System.Drawing.Point (7, 7));
			m_mainMenu.MenuItems.All = new System.WinForms.MenuItem[3] {this.menuItem1, this.menuItem14, this.menuItem8};
			menuItem7.Text = "&Create Folder";
			menuItem7.Index = 0;
			menuItem7.Click += new System.EventHandler (this.OnClickCreateFolder);
			menuItem1.Text = "&Server";
			menuItem1.Index = 0;
			menuItem1.MenuItems.All = new System.WinForms.MenuItem[11] {this.menuItem2, this.menuItem3, this.menuItem4, this.menuItem16, this.menuItem18, this.m_menuMRU1, this.m_menuMRU2, this.m_menuMRU3, this.m_menuMRU4, this.m_menuMRUSep, this.menuItem13};
			groupBox1.Location = new System.Drawing.Point (2, 32);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Size = new System.Drawing.Size (702, 4);
			menuItem3.Text = "&Disconnect";
			menuItem3.Index = 1;
			menuItem3.Click += new System.EventHandler (this.OnClickDisconnect);
			this.Text = "FTP Explorer Version 2.0";
			this.MaximizeBox = false;
			this.StartPosition = System.WinForms.FormStartPosition.CenterScreen;
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.BorderStyle = System.WinForms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon) resources.GetObject ("$this.Icon");
			this.Menu = this.m_mainMenu;
			this.ClientSize = new System.Drawing.Size (702, 464);
			this.Controls.Add (this.m_progressBarFileStatus);
			this.Controls.Add (this.groupBox1);
			this.Controls.Add (this.m_labelListView);
			this.Controls.Add (this.m_labelTreeView);
			this.Controls.Add (this.m_statusBar);
			this.Controls.Add (this.m_lvFileView);
			this.Controls.Add (this.m_tvFolderView);
			this.Controls.Add (this.m_toolBar);
			statusBarPanel1.EndInit ();
			statusBarPanel2.EndInit ();
			statusBarPanel3.EndInit ();
		}

		/* Delete file from FTP server and then delete from List view control */
		private void DeleteFiles(){
			int l_iSelectedCount = m_lvFileView.SelectedItems.Count;
			if ( l_iSelectedCount == 0 ) {
				MessageBox.Show("Select files and click Delete File option","FTP Explorer",MessageBox.IconInformation);
				return;
			}

			/* Confirm deletion of files */
			if ( MessageBox.Show("Are you sure to delete the selected file(s) ?","FTP Explorer",MessageBox.IconInformation|MessageBox.OKCancel|MessageBox.DefaultButton2) != DialogResult.OK ) {
				return;
			}

			int l_iErrCount = 0;
			ListItem l_iItem = null;
			int l_iFileSize = 0;
			string l_strFile = "";

			this.Cursor = Cursors.WaitCursor;
			/* Till there are selected items loop through */
			for ( ;  l_iSelectedCount > 0  ; l_iSelectedCount = m_lvFileView.SelectedItems.Count ) {
				l_iItem = m_lvFileView.SelectedItems[0];
				l_strFile = l_iItem.Text;

				/* Get File size */
				try {
					l_iFileSize = l_iItem.GetSubItem(0).ToInt32();
				}
				catch ( Exception e1 ) {
					l_iFileSize = 0;
				}

				statusBarPanel2.Text = "Deleting '" + l_strFile + "' file.";
				m_statusBar.Refresh();

				/*	Delete File from FTP server */
				if ( m_FTPClient.RemoveFile(l_strFile) == 1 ) {
					/* Delete the item from List view control */
					l_iItem.Remove();
					m_iTotalFiles--;
					m_lTotalSize -= l_iFileSize;
				}
				else {
					l_iErrCount++;
				}
			}

			this.Cursor = Cursors.Arrow;
			if ( l_iErrCount > 0 ) {
				string l_strMessage = "Unable to remove " + l_iErrCount + " file(s)";
				MessageBox.Show(l_strMessage,"FTP Explorer",MessageBox.IconInformation);
			}
			m_lvFileView.Refresh();
			m_lvFileView.Focus();

			/* Update the List View label message */
			UpdateListViewLabel();
			return;
		}

		protected void OnKeyDownFileView (object sender, System.WinForms.KeyEventArgs e)
		{
 			int l_iKey = e.KeyData.ToInt32();
			/*	If DEL key is pressed, then the record is deleted from List view and database */
			if ( l_iKey == 46 ) {
				DeleteFiles();
			}
			return;
		}

		protected void OnKeyDownTreeView (object sender, System.WinForms.KeyEventArgs e)
		{
 			int l_iKey = e.KeyData.ToInt32();
			/* If DEL is pressed then delete the folder */
			if ( l_iKey == 46 ) {
				RemoveFolder();
			}
			return;
		}

		protected void OnClickRemoveFolder (object sender, System.EventArgs e)
		{
			RemoveFolder();
			return;
		}

		/* To Remove a folder */
		private void RemoveFolder(){
			TreeNode l_tnCurrNode = m_tvFolderView.SelectedNode;
			
			if ( m_tvFolderView.ContainsFocus == false ) {
				MessageBox.Show("Select a folder to be deleted and select this option","FTP Explorer",MessageBox.IconExclamation);
				return;
			}

			if ( l_tnCurrNode == null ) {
				MessageBox.Show("Select a folder other than root node to delete","FTP Explorer",MessageBox.IconInformation);
				return;
			}
			
			if ( l_tnCurrNode == m_tnRootNode ) {
				MessageBox.Show("Cannot remove root node","FTP Explorer",MessageBox.IconInformation);
				return;
			}

			string l_strFolder = l_tnCurrNode.FullPath;
			l_strFolder = l_strFolder.Replace('\\','/');
			string l_strMessage = "Are you sure to delete '" + l_strFolder + "' folder ?";

			if ( MessageBox.Show(l_strMessage,"FTP Explorer",MessageBox.IconError|MessageBox.OKCancel|MessageBox.DefaultButton2) != DialogResult.OK ) {
				return;
			}

			statusBarPanel2.Text = "Deleting selected folder. Please wait...";
			m_statusBar.Refresh();

			this.Cursor = Cursors.WaitCursor;

			TreeNode l_tnParentNode = l_tnCurrNode.Parent;
			if ( l_tnParentNode == null ) {
				l_tnParentNode = m_tnRootNode;
			}
						
			/* Go to parent folder and then delete the current folder */
			string l_strParentFolder = l_tnParentNode.FullPath;
			l_strParentFolder = l_strParentFolder.Replace('\\','/');
			int l_iRetval = m_FTPClient.ChangeWorkingDirectory(l_strParentFolder);
			if (l_iRetval == 0 ) {
				this.Cursor = Cursors.Arrow;
				string l_strErr = m_FTPClient.GetLastError();
				statusBarPanel2.Text = "Logged in as " + m_strFTPUser ;
				MessageBox.Show(l_strErr,"FTP Explorer",MessageBox.IconError);
				return ;
			}

			/* Now Remove Folder from FTP Server */
			if ( m_FTPClient.RemoveDirectory(l_strFolder) == 0 ) {
				this.Cursor = Cursors.Arrow;
				string l_strError = m_FTPClient.GetLastError();
				statusBarPanel2.Text = "Logged in as " + m_strFTPUser ;
				MessageBox.Show(l_strError,"FTP Explorer",MessageBox.IconStop);
				return;
			}

			this.Cursor = Cursors.WaitCursor;
			
			/* Refresh File views for the Parent folder */
			string l_strParentDir = l_tnParentNode.Text;
			m_tvFolderView.SelectedNode = l_tnParentNode;
			
			/* Clear all child nodes */
			l_tnParentNode.Nodes.Clear();
			RefreshFolderView(l_strParentFolder,l_strParentDir,l_tnParentNode);

			this.Cursor = Cursors.Arrow;
			return;
		}

		protected void OnClickCreateFolder (object sender, System.EventArgs e)
		{
			TreeNode l_tnCurrNode = m_tvFolderView.SelectedNode;
			if ( l_tnCurrNode == null ) {
				MessageBox.Show("Select a parent folder and click Create Folder Button","FTP Explorer",MessageBox.IconInformation);
				return;
			}

			CreateFolderDlg dlg = new CreateFolderDlg();
			dlg.ShowDialog(this);
			string l_strFolder = dlg.m_strFolderName;
			if ( l_strFolder.Length == 0 ) {
				return;
			}

			this.Cursor = Cursors.WaitCursor;
			if ( m_FTPClient.CreateDirectory(l_strFolder) == 0 ) {
				this.Cursor = Cursors.Arrow;
				string l_strError = m_FTPClient.GetLastError();
				MessageBox.Show(l_strError,"FTP Explorer",MessageBox.IconStop);
				return;
			}
			else {
				this.Cursor = Cursors.Arrow;
				MessageBox.Show("Folder '" + l_strFolder + "' Successfully created","FTP Explorer",MessageBox.IconInformation);
			}

			/* Add the node to tree view control */
			TreeNodeCollection l_tcNodes = l_tnCurrNode.Nodes;
			TreeNode l_tnChildNode = new TreeNode(l_strFolder,1,2);
			l_tcNodes.Add(l_tnChildNode);
			m_tvFolderView.Refresh();

			m_iTotalFolders++;

			/* Update the List View label message */
			UpdateListViewLabel();

			return;
		}

		protected void OnClickMenuMRU4 (object sender, System.EventArgs e)
		{
			string l_strFTPServer = m_arrMRUConn[3].FTPServer ;
			string l_strFTPUser = m_arrMRUConn[3].FTPUser;
			ConnectToFTPServer(l_strFTPServer,l_strFTPUser);
		}

		protected void OnClickMenuMRU3 (object sender, System.EventArgs e)
		{
			string l_strFTPServer = m_arrMRUConn[2].FTPServer ;
			string l_strFTPUser = m_arrMRUConn[2].FTPUser;
			ConnectToFTPServer(l_strFTPServer,l_strFTPUser);
		}

		protected void OnClickMenuMRU2 (object sender, System.EventArgs e)
		{
			string l_strFTPServer = m_arrMRUConn[1].FTPServer ;
			string l_strFTPUser = m_arrMRUConn[1].FTPUser;
			ConnectToFTPServer(l_strFTPServer,l_strFTPUser);
		}

		protected void OnClickMenuMRU1 (object sender, System.EventArgs e)
		{
			string l_strFTPServer = m_arrMRUConn[0].FTPServer ;
			string l_strFTPUser = m_arrMRUConn[0].FTPUser;
			ConnectToFTPServer(l_strFTPServer,l_strFTPUser);
		}

		/*	Called from MRU List */
		private void ConnectToFTPServer(string l_strFTPServer,string l_strFTPUser){
			ConnectDlg dlg = new ConnectDlg(l_strFTPServer,l_strFTPUser,"");
			dlg.ShowDialog();
			if ( dlg.m_iDataFlag == 1 ) {
				/*	If OK is pressed then connect to FTP server */
				this.Cursor = Cursors.WaitCursor;
				m_strFTPAddress = dlg.m_strFTPServer;
				m_strFTPUser = dlg.m_strFTPUserID;
				m_strFTPPassword = dlg.m_strFTPPassword;
				m_labelTreeView.Text = "No Folders to display";
				m_labelTreeView.Refresh();
				statusBarPanel1.Text = "Connecting to " + m_strFTPAddress + ". Please wait...";
				m_statusBar.Refresh();
				int l_iRetval = m_FTPClient.Connect(m_strFTPAddress,m_strFTPUser,m_strFTPPassword);
				if ( l_iRetval == 0 ){
					string l_strError = m_FTPClient.GetLastError();
					this.Cursor = Cursors.Arrow;
					MessageBox.Show(l_strError,"FTP Explorer - Error",MessageBox.IconStop);
					m_bConnectedFlag = false;
					ToggleMenuItems(0);
					m_labelTreeView.Text = "Not connected";
					m_labelListView.Text = "";
					statusBarPanel1.Text = "";
					statusBarPanel2.Text = "";
					return ;
				}
				m_bConnectedFlag = true;
				ToggleMenuItems(1);
				statusBarPanel1.Text = "Connected to " + m_strFTPAddress;
				m_statusBar.Refresh();

				RefreshFolderView("ROOT","",m_tnRootNode);
				string l_strFile = m_FTPClient.m_strList;

				m_FTPClient.m_strList = "";
				
				/*	Disable all MRU Menu Items	*/
				EnableMRUList(false);
				this.Cursor = Cursors.Arrow;
			}
		}

		protected void OnClickConfigure (object sender, System.EventArgs e)
		{
			int l_iSend = 0 ,l_iRecv = 0;
			m_FTPClient.GetTimeOuts(out l_iSend,out l_iRecv);
			char l_chDataTransfer = m_FTPClient.DataTransferMode;
			ConfigureDlg dlg = new ConfigureDlg(l_chDataTransfer,l_iSend,l_iRecv,m_strLocalDirectory);
			if ( dlg.ShowDialog() == DialogResult.OK ) {
				l_chDataTransfer = dlg.m_chTransferMode;
				int l_iSendTimeOut = dlg.m_iSendTimeout;
				int l_iRecvTimeOut = dlg.m_iRecvTimeout;
				m_FTPClient.SetTimeOuts(l_iSendTimeOut,l_iRecvTimeOut);
				m_FTPClient.DataTransferMode = l_chDataTransfer;
				/*	TO BE REMOVED FROM PRODUCT	*/
				if ( l_chDataTransfer == 'B' ) {
					m_FTPClient.DataTransferMode = 'A';
					MessageBox.Show("Binary Mode data transfer is not supported in Version 2.0","FTP Explorer",MessageBox.IconInformation);
				}
				m_strLocalDirectory = dlg.m_strClientPath;
				statusBarPanel3.Text = m_strLocalDirectory;
			}
		}

		protected void OnAfterSelectFolderView (object sender, System.WinForms.TreeViewEventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			//e.node.Nodes;
			TreeNode l_tempNode = e.node;
			if ( l_tempNode == m_tnRootNode ) {
				/*	If root node is clicked do not do anything */
				this.Cursor = Cursors.Arrow;
				return ;
			}
			/*	Clear all child nodes first */
			e.node.Nodes.Clear();

			/*	Populate Folder view */
			string l_strCurDir = l_tempNode.Text;
			string l_strFullPath = l_tempNode.FullPath;
			l_strFullPath = l_strFullPath.Replace('\\','/');
			RefreshFolderView(l_strFullPath,l_strCurDir,l_tempNode);
			this.Cursor = Cursors.Arrow;
			return;
		}

		protected void OnClickToolBar (object sender, System.WinForms.ToolBarButtonClickEventArgs e)
		{
			int l_iImageIndex = e.button.ImageIndex;
			switch ( l_iImageIndex ) {
				case 0 :
					OnClickConnect(sender,e);
					break;
				case 1 :
					OnClickDisconnect(sender,e);
					break;
				case 2 :
					OnClickConfigure(sender,e);
					break;
				case 3 :
					OnClickCreateFolder(sender,e);
					break;
				case 4 :
					OnClickRemoveFolder(sender,e);
					break;
				case 5 :
					DeleteFiles();
					break;
				case 6 :
					OnClickUploadFile(sender,e);
					break;
				case 7 :
					OnClickDownloadFile(sender,e);
					break;
				case 8 :
					OnClickRefresh(sender,e);
					break;
				case 9 :
					OnClickSystemInfo(sender,e);
					break;
				case 10 :
					OnClickAbout(sender,e);
					break;
				case 11 :
					OnClickExit(sender,e);
					break;
				default:
					break;
			}
		}

		protected void OnClickAbout (object sender, System.EventArgs e)
		{
			AboutDlg dlg = new AboutDlg();
			dlg.ShowDialog(this);
			return;
		}

		protected void OnClickSystemInfo (object sender, System.EventArgs e)
		{
			string l_strServerInfo = "";
			if ( m_bConnectedFlag == false ) {
				l_strServerInfo = "Not connected to any FTP Service";
			}
			else {
				int l_iOS = m_FTPClient.GetServerOS();
				if ( l_iOS == 0 ) {
					l_strServerInfo = "Unknown OS";
				}
				else if ( l_iOS == 1) {
					l_strServerInfo = "Connected to FTP Service on \n";
					l_strServerInfo += m_FTPClient.m_strServerType;
				}
				else if ( l_iOS == 2 ) {
					l_strServerInfo = "Connected to FTP Service on \n";
					l_strServerInfo += m_FTPClient.m_strServerType;
				}
				else if ( l_iOS == 3 ) {
					l_strServerInfo = "Unknown OS";
				}
			}
			SystemInfoDlg dlg = new SystemInfoDlg(l_strServerInfo);
			dlg.ShowDialog(this);
		}

		protected void OnClickRefresh (object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			/*	When refresh is clicked the populate the entire structure */
			RefreshFolderView("ROOT","",m_tnRootNode);
			this.Cursor = Cursors.Arrow;
		}

		protected void OnClickDownloadFile (object sender, System.EventArgs e)
		{
			
			bool l_bFocused = m_lvFileView.ContainsFocus;
			ListView.SelectedListItemCollection l_SelectedItemList = m_lvFileView.SelectedItems;

			/*	If Listview control is not in focus or nothing is selected */
			if ( l_bFocused == false || l_SelectedItemList.Count == 0 ) {
				MessageBox.Show("Select one or more files and then click download button","FTP Explorer",MessageBox.IconInformation);
				return;
			}

			/*	Get all items */
			ListItem[] l_ListItemArray = l_SelectedItemList.All;
			ListItem l_ListItemTemp = null;
			DownloadFileData[] l_FileList = new DownloadFileData[l_SelectedItemList.Count];
			
			string l_strSize = "";
			int l_iSize = 0;
			int l_iCount = 0;
			foreach(object obj in l_ListItemArray) {
				l_ListItemTemp = (ListItem) obj;
				/*	Get the File size */
				/*	Item 0 contains the size of the file */
				l_strSize = l_ListItemTemp.GetSubItem(0);
				try {
					if ( l_strSize.Length > 0 ) {
						l_iSize = int.Parse(l_strSize);
					}
					else {
						l_iSize = 0;
					}
				}
				catch ( FormatException e1 ) {
					l_iSize = 0;
				}
				l_FileList[l_iCount] = new DownloadFileData();
				l_FileList[l_iCount].FileSize = l_iSize;
				l_FileList[l_iCount].LocalFileName = m_strLocalDirectory + l_ListItemTemp.Text;
				l_FileList[l_iCount].ServerFileName = l_ListItemTemp.Text;
				l_iCount++;
			}

			/*	Check whether the same file exist in the current local directory */
			string l_strMessage = "";
			DownloadFileData l_TempObject;
			l_iCount = 0;
			foreach(object obj in l_FileList) {
				l_TempObject = (DownloadFileData) obj;
				/*	Check whether the file exist or not */
				File l_FileObj = new File(l_TempObject.LocalFileName );
				if ( l_FileObj.Exists == true ) {
					l_strMessage = "File " + l_TempObject.LocalFileName + " already exists in the local machine. Do you wish to overwrite ?";
					if ( MessageBox.Show(l_strMessage,"FTP Explorer",MessageBox.OKCancel | MessageBox.IconQuestion ) == DialogResult.Cancel ) {
						return;
					}
				}
				l_iCount++;
			}
		
			this.Cursor = Cursors.WaitCursor;

			/*	Set the corresponding type here */
			char l_CurrentMode = 'A';
			char l_WantedMode = m_FTPClient.DataTransferMode;
			int l_iRetval = 0;
			if ( l_CurrentMode != l_WantedMode ) {
				statusBarPanel2.Text = "Setting to Binary Transfer type...";
				m_statusBar.Refresh();
				l_iRetval = m_FTPClient.SetTransferType(l_WantedMode);
				if (l_iRetval == 0 ) {
					string l_strError = m_FTPClient.GetLastError();
					this.Cursor = Cursors.Arrow;
					MessageBox.Show(l_strError,"FTP Explorer",MessageBox.IconStop);
					return;
				}
			}

			m_progressBarFileStatus.Visible = true;

			int l_iDownloadSize = 5120;	/*	5K at a time */
			int l_iFileSize = 0;
			int l_iSkippedCount = 0;
			int l_iDownloadCount = 0;

			/*	Download file here */
			//	Pass this array l_strarrFinalArray
			foreach(object obj in l_FileList) {
				l_TempObject = (DownloadFileData) obj;
				l_iFileSize = l_TempObject.FileSize;

				if (l_iFileSize == 0 ) {
					l_iSkippedCount++;
					continue;
				}
				
				/*	Reset the Progress Bar Properties	*/
 				m_progressBarFileStatus.Minimum = 0;
				m_progressBarFileStatus.Maximum = 0;
				m_progressBarFileStatus.PerformStep();

				/*	Set Progress Bar properties */
				m_progressBarFileStatus.Minimum = 0;
				m_progressBarFileStatus.Maximum = l_iFileSize / l_iDownloadSize;
				m_progressBarFileStatus.Step = 1;

				statusBarPanel2.Text = "Now downloading '" + l_TempObject.ServerFileName + "' . Please wait...";
				m_statusBar.Refresh();

				/*	Do the First Step here */
				m_progressBarFileStatus.PerformStep();
				m_progressBarFileStatus.Refresh();

				/*	Download file here */
				l_iRetval = m_FTPClient.DownLoadFile(l_TempObject,l_WantedMode);
				if ( l_iRetval == 0 ) {
					string l_strErrorMessage = m_FTPClient.GetLastError();
					l_strErrorMessage += ". Aborting the rest of process";
					this.Cursor = Cursors.Arrow;
					MessageBox.Show(l_strErrorMessage,"FTP Explorer",MessageBox.IconError);
					/*	Hide the Progress bar */
					m_progressBarFileStatus.Visible = false;

					/*	Reset to 'A' type */
					if ( l_CurrentMode != l_WantedMode ) {
						this.Cursor = Cursors.WaitCursor;
						statusBarPanel2.Text = "Setting to Ascii transfer type...";
						m_statusBar.Refresh();
						l_iRetval = m_FTPClient.SetTransferType(l_CurrentMode);
						this.Cursor = Cursors.Arrow;
					}
					statusBarPanel2.Text = "Logged in as " + m_strFTPUser ;
					return;
				}

				/*	Do the Last Step here *
				m_progressBarFileStatus.PerformStep();
				m_progressBarFileStatus.Refresh();
				*/
				l_iDownloadCount++;
			}

			/*	Set back to ASCII mode. ASCII mode is 
			 *	the default for LIST command
			 * */
			if ( l_CurrentMode != l_WantedMode ) {
				statusBarPanel2.Text = "Setting to Ascii transfer type...";
				m_statusBar.Refresh();
				l_iRetval = m_FTPClient.SetTransferType(l_CurrentMode);
			}

			l_strMessage = "";
			if ( l_iSkippedCount > 0 ) {
				l_strMessage = l_iDownloadCount + " file(s) downloaded successfully. " + l_iSkippedCount + " file(s) skipped due to zero length";
			}
			else {
				l_strMessage = l_iDownloadCount + " file(s) downloaded successfully";
			}
			
			MessageBox.Show(l_strMessage,"FTP Explorer",MessageBox.IconInformation);
			
			/*	Hide the status bar */
			m_progressBarFileStatus.Visible = false;

			statusBarPanel2.Text = "Logged in as " + m_strFTPUser ;
			m_statusBar.Refresh();
			this.Cursor = Cursors.Arrow;
			return;
		}

		protected void OnClickUploadFile(object sender, System.EventArgs e)
		{
			// Only one file is allowed to be uploaded in this version
			//m_openFileDialog.Multiselect = true;

			m_openFileDialog.Title = "Upload File(s) to FTP server";
			m_openFileDialog.Filter = "All Files (*.*)|*.*";
			if( m_openFileDialog.ShowDialog() == DialogResult.OK ) {
				string[] l_strarrFiles = m_openFileDialog.FileNames;

				if (l_strarrFiles.Length == 0 ) {
					return;
				}
				
				this.Cursor = Cursors.WaitCursor;

				/*	Set the corresponding type here */
				char l_CurrentMode = 'A';
				char l_WantedMode = m_FTPClient.DataTransferMode;
				int l_iRetval = 0;
				if ( l_CurrentMode != l_WantedMode ) {
					statusBarPanel2.Text = "Setting to Binary Transfer type...";
					m_statusBar.Refresh();
					l_iRetval = m_FTPClient.SetTransferType(l_WantedMode);
					if (l_iRetval == 0 ) {
						string l_strError = m_FTPClient.GetLastError();
						this.Cursor = Cursors.Arrow;
						MessageBox.Show(l_strError,"FTP Explorer",MessageBox.IconStop);
						return;
					}
				}

				m_progressBarFileStatus.Visible = true;
		
				int l_iUploadSize = 512;	/*	512 bytes at a time */
				int l_iFileSize = 0;
				int l_iSkippedCount = 0;
				int l_iUploadCount = 0;
				string l_strName = "";

				this.Cursor = Cursors.WaitCursor;
				foreach ( string l_strFilePath in l_strarrFiles ) {
					l_iFileSize = 0;
					try {
						File l_fileObj = new File(l_strFilePath);
						l_strName = l_fileObj.Name;
						l_iFileSize = (int) l_fileObj.Length;

						if (l_iFileSize == 0 ) {
							l_iSkippedCount++;
							continue;
						}
					}
					catch ( Exception e1 ) {
						this.Cursor = Cursors.Arrow;
						string l_strErrorMessage = "Error :" + e1.Message;
						MessageBox.Show(l_strErrorMessage,"Error",MessageBox.IconStop);
						return;
					}
					
					/*	Reset the Progress Bar Properties	*/
 					m_progressBarFileStatus.Minimum = 0;
					m_progressBarFileStatus.Maximum = 0;
					m_progressBarFileStatus.PerformStep();

					/*	Set Progress Bar properties */
					m_progressBarFileStatus.Minimum = 0;
					m_progressBarFileStatus.Maximum = l_iFileSize / l_iUploadSize;
					m_progressBarFileStatus.Step = 1;

					statusBarPanel2.Text = "Now uploading '" + l_strName + "' . Please wait...";
					m_statusBar.Refresh();

					/*	Do the First Step here */
					m_progressBarFileStatus.PerformStep();
					m_progressBarFileStatus.Refresh();
					
					l_iRetval = m_FTPClient.UploadFile(l_strFilePath,l_strName,l_WantedMode,l_iUploadSize);
					if ( l_iRetval == 0 ) {
						string l_strErrorMessage = m_FTPClient.GetLastError();
						l_strErrorMessage += ". Aborting the rest of process";
						this.Cursor = Cursors.Arrow;
						MessageBox.Show(l_strErrorMessage,"FTP Explorer",MessageBox.IconError);
						/*	Hide the Progress bar */
						m_progressBarFileStatus.Visible = false;

						/*	Reset to 'A' type */
						if ( l_CurrentMode != l_WantedMode ) {
							this.Cursor = Cursors.WaitCursor;
							statusBarPanel2.Text = "Setting to Ascii transfer type...";
							m_statusBar.Refresh();
							l_iRetval = m_FTPClient.SetTransferType(l_CurrentMode);
							this.Cursor = Cursors.Arrow;
						}
						statusBarPanel2.Text = "Logged in as " + m_strFTPUser ;
						return;
					}
					else {	/* If successfully transfered add to Listview control */

						DateTime l_dtToday = DateTime.Today;
						string[] l_strsubItems = new string[3];
						string l_strDate = "";
						m_iTotalFiles++;
						m_lTotalSize += l_iFileSize;
						l_strsubItems[0] = l_iFileSize.ToString();

						char[] l_arrTemp = new char[20];
						string l_strTemp = l_dtToday.Format("M",DateTimeFormatInfo.InvariantInfo);
						
						l_arrTemp[0] = l_strTemp[0];
						l_arrTemp[1] = l_strTemp[1];
						l_arrTemp[2] = l_strTemp[2];
						l_arrTemp[3] = ' ';
						l_arrTemp[4] = l_strTemp[l_strTemp.Length-2];
						l_arrTemp[5] = l_strTemp[l_strTemp.Length-1];
						l_arrTemp[6] = ' ';
						l_arrTemp[7] = '\0';
						
						string l_strTemp1 = new string(l_arrTemp);
						l_strTemp1 = l_strTemp1.Remove(7,13);

						l_dtToday = DateTime.Now;
						switch ( m_FTPClient.GetServerOS()) {
							case 0 :	/*	If unknown	*/
								l_strDate = l_strTemp1 + l_dtToday.Format("t",DateTimeFormatInfo.InvariantInfo);
								l_strsubItems[1] = l_strDate;
								l_strsubItems[2] = m_strFTPUser;
								break;
							case 1 :	/*	If Unix	*/
								l_strDate = l_strTemp1 + l_dtToday.Format("t",DateTimeFormatInfo.InvariantInfo);
								l_strsubItems[1] = l_strDate;
								l_strsubItems[2] = m_strFTPUser;
								break;
							case 2 :	/*	If Windows */
								/* Store Date */
								l_strsubItems[1] = l_dtToday.Format("dd-MM-yy",DateTimeFormatInfo.InvariantInfo);;
								/* Store Time */
								l_strsubItems[2] = l_dtToday.Format("t",DateTimeFormatInfo.InvariantInfo);;
								break;
							default :
								l_strDate = l_strTemp1 + l_dtToday.Format("t",DateTimeFormatInfo.InvariantInfo);
								l_strsubItems[2] = m_strFTPUser;
								l_strsubItems[1] = l_strDate;
								break;
						}
						
						
						/* Add to list view */
						ListItem l_liFileData = new ListItem(l_strName,0,l_strsubItems);
						m_lvFileView.InsertItem(m_iTotalFiles,l_liFileData);
						m_lvFileView.Refresh();

						/* Update Status bar and static text */
						UpdateListViewLabel();

					}/* end of else */

					/*	Do the Last Step here 
					m_progressBarFileStatus.PerformStep();
					m_progressBarFileStatus.Refresh();
					*/
					l_iUploadCount++;
				}

				/*	Set back to ASCII mode. ASCII mode is 
				 *	the default for LIST command
				 * */
				if ( l_CurrentMode != l_WantedMode ) {
					statusBarPanel2.Text = "Setting to Ascii transfer type...";
					m_statusBar.Refresh();
					l_iRetval = m_FTPClient.SetTransferType(l_CurrentMode);
				}

				string l_strMessage = "";
				if ( l_iSkippedCount > 0 ) {
					l_strMessage = l_iUploadCount + " file(s) uploaded successfully. " + l_iSkippedCount + " file(s) skipped due to zero length";
				}
				else {
					l_strMessage = l_iUploadCount + " file(s) uploaded successfully";
				}
				
				this.Cursor = Cursors.Arrow;

				MessageBox.Show(l_strMessage,"FTP Explorer",MessageBox.IconInformation);
				
				/*	Hide the status bar */
				m_progressBarFileStatus.Visible = false;
				statusBarPanel2.Text = "Logged in as " + m_strFTPUser ;
				m_statusBar.Refresh();
			}
			return;
		}

		protected void OnClickExit (object sender, System.EventArgs e)
		{
			if ( m_bConnectedFlag == true ) {
				if ( MessageBox.Show("Do you wish to close the current session ?","FTP Explorer",MessageBox.IconStop | MessageBox.OKCancel | MessageBox.DefaultButton2) == DialogResult.OK ) {
					statusBarPanel1.Text = "Closing connection. Please wait...";
					m_statusBar.Refresh();
					OnClickDisconnect(sender,e);
					this.Close();
				}
			}
			else {
				this.Close();
			}
		}

		protected void OnClickDisconnect (object sender, System.EventArgs e)
		{
			if ( m_bConnectedFlag == true ) {
				this.Cursor = Cursors.WaitCursor;
				if (m_FTPClient.Disconnect() == 0) {
					this.Cursor = Cursors.Arrow;
					MessageBox.Show(m_FTPClient.GetLastError(),"FTP Explorer - Error",MessageBox.IconStop);
					return;
				}
				m_tvFolderView.Nodes.Clear();
				m_lvFileView.Clear();
				ToggleMenuItems(0);
				this.Cursor = Cursors.Arrow;
				m_bConnectedFlag = false;

				/*	Enable all MRU list */
				EnableMRUList(true);
			}
			InitControls();
		}

		private void EnableMRUList(bool l_bFlag){
			if ( m_iMRUCount == 1  ) {
				m_menuMRU1.Enabled = l_bFlag;
			}
			else if ( m_iMRUCount == 2  ) {
				m_menuMRU1.Enabled = l_bFlag;
				m_menuMRU2.Enabled = l_bFlag;
			}
			else if ( m_iMRUCount == 3  ) {
				m_menuMRU1.Enabled = l_bFlag;
				m_menuMRU2.Enabled = l_bFlag;
				m_menuMRU3.Enabled = l_bFlag;
			}
			else if ( m_iMRUCount == 4  ) {
				m_menuMRU1.Enabled = l_bFlag;
				m_menuMRU2.Enabled = l_bFlag;
				m_menuMRU3.Enabled = l_bFlag;
				m_menuMRU4.Enabled = l_bFlag;
			}
		}

		/*	Connects to FTP Server */
		protected void OnClickConnect (object sender, System.EventArgs e)
		{
			ConnectDlg dlg = new ConnectDlg(m_strFTPAddress,m_strFTPUser,"");
			dlg.ShowDialog();
			if ( dlg.m_iDataFlag == 1 ) {
				/*	If OK is pressed then connect to FTP server */
				this.Cursor = Cursors.WaitCursor;
				m_strFTPAddress = dlg.m_strFTPServer;
				m_strFTPUser = dlg.m_strFTPUserID;
				m_strFTPPassword = dlg.m_strFTPPassword;
				m_labelTreeView.Text = "No Folders to display";
				m_labelTreeView.Refresh();
				statusBarPanel1.Text = "Connecting to " + m_strFTPAddress + ". Please wait...";
				m_statusBar.Refresh();
				int l_iRetval = m_FTPClient.Connect(m_strFTPAddress,m_strFTPUser,m_strFTPPassword);
				if ( l_iRetval == 0 ){
					string l_strError = m_FTPClient.GetLastError();
					this.Cursor = Cursors.Arrow;
					MessageBox.Show(l_strError,"FTP Explorer - Error",MessageBox.IconStop);
					m_bConnectedFlag = false;
					ToggleMenuItems(0);
					m_labelTreeView.Text = "Not connected";
					m_labelListView.Text = "";
					statusBarPanel1.Text = "";
					statusBarPanel2.Text = "";
					return ;
				}
				m_bConnectedFlag = true;
				ToggleMenuItems(1);
				statusBarPanel1.Text = "Connected to " + m_strFTPAddress;
				m_statusBar.Refresh();

				RefreshFolderView("ROOT","",m_tnRootNode);
				string l_strFile = m_FTPClient.m_strList;

				m_FTPClient.m_strList = "";
				this.Cursor = Cursors.Arrow;

				/*	Add to MRU List */
				AddToMRUList(m_strFTPAddress,m_strFTPUser);

				/*	Disable MRU List */
				EnableMRUList(false);
			}
			return;
		}

		/*	Add the current menu item to Most Recent Used List */
		private void AddToMRUList(string l_strFTPServer,string l_strFTPUser){

			/*	If the element is already existing 
			 *	do not add to the list
			 * */
			foreach(object obj in m_arrMRUConn ) {
				MRUConnections l_conn = (MRUConnections) obj;
				if (l_conn.FTPServer.Equals(l_strFTPServer) && l_conn.FTPUser.Equals(l_strFTPUser) ) {
					/*	do not add and skip the rest */
					return;
				}
			}

			if ( m_iMRUCount <= 3 ) {
				m_arrMRUConn[m_iMRUCount].FTPServer = l_strFTPServer;
				m_arrMRUConn[m_iMRUCount].FTPUser = l_strFTPUser;
				if ( m_iMRUCount == 0 ) {
					m_menuMRU1.Text = l_strFTPServer + "," + l_strFTPUser; 
					m_menuMRU1.Visible = true;
					m_menuMRU1.Enabled = false;
				}
				if ( m_iMRUCount == 1 ) {
					m_menuMRU2.Text = l_strFTPServer + "," + l_strFTPUser; 
					m_menuMRU2.Visible = true;
					m_menuMRU2.Enabled = false;
				}
				if ( m_iMRUCount == 2 ) {
					m_menuMRU3.Text = l_strFTPServer + "," + l_strFTPUser; 
					m_menuMRU3.Visible = true;
					m_menuMRU3.Enabled = false;
				}
				if ( m_iMRUCount == 3 ) {
					m_menuMRU4.Text = l_strFTPServer + "," + l_strFTPUser; 
					m_menuMRU4.Visible = true;
					m_menuMRU4.Enabled = false;
				}

				m_menuMRUSep.Visible = true;
				m_iMRUCount++;
				/*	Reset back to 0, so that the next item can be added */
				if ( m_iMRUCount == 4 ) {
					m_iMRUCount = 0;
				}
			}
			return;
		}

		/*	Calls LIST command and Populates Treeview and Listview control */
		private int RefreshFolderView(string l_strFullPath,string l_strCurDir,TreeNode l_tnCurNode){
			statusBarPanel2.Text = "Retreiving Folders and Files. Please wait...";
			m_statusBar.Refresh();

			string l_strTemp = "";
			
			/*	If ROOT is passed then get the Root directory */
			if ( l_strFullPath.Equals("ROOT" ) ) {
				l_strTemp = m_FTPClient.GetRootDirectory();
			}
			else {
				l_strTemp = l_strFullPath;
			}

			/*	Change to corresponding directory */
			int l_iRetval = m_FTPClient.ChangeWorkingDirectory(l_strTemp);
			if (l_iRetval == 0 ) {
				statusBarPanel1.Text = "Connected to " + m_strFTPAddress;
				statusBarPanel2.Text =  "No files or directory found";
				string l_strErr = m_FTPClient.GetLastError();
				MessageBox.Show(l_strErr,"FTP Explorer",MessageBox.IconError);
				return l_iRetval;
			}

			/*	Get the file list in the current directory */
			int l_iFileCount = m_FTPClient.GetList();
			if (l_iFileCount == 0 ) {
				string l_strError = "No files or directory found or Connection lost. Please try again.";
				statusBarPanel1.Text = "Connected to " + m_strFTPAddress;
				statusBarPanel2.Text =  "No files or directory found";
				MessageBox.Show(l_strError,"FTP Explorer",MessageBox.IconError);
				return l_iRetval;
			}

			statusBarPanel2.Text = "Refresing Folder and File views with data";
			FileList l_FileListObj = m_FTPClient.GetFileList();

			/*	Populate TreeView Control */
			PopulateTreeListView(l_FileListObj,l_strFullPath,l_tnCurNode);
			if ( l_strFullPath.Equals("ROOT") ) {
				statusBarPanel3.Text = m_FTPClient.GetCurrentWorkingDirectory();
			}
			else {
				statusBarPanel3.Text = l_strFullPath;
			}
			
			m_labelTreeView.Text = l_strTemp;		/*	Display current directory */
			statusBarPanel3.Text = m_strLocalDirectory;
			statusBarPanel1.Text = "Connected to " + m_strFTPAddress;
			statusBarPanel2.Text = "Logged in as " + m_strFTPUser ;
			return 1;
		}

		/*
		 *	Function that populates Folder and File views
		*/
		private void PopulateTreeListView(FileList l_FileListObj,string l_strRootFlag,TreeNode l_tnNode){
			TreeNode l_tnCurrNode ;
			InitListControl();
			long l_lTotalSize = 0;
			m_lvFileView.Refresh();
			if ( l_strRootFlag.Equals("ROOT" ) ) {
				m_tvFolderView.Nodes.Clear();
				m_tnRootNode = new TreeNode(m_FTPClient.GetRootDirectory(),0,0);
				m_tvFolderView.Nodes.Add(m_tnRootNode);
				l_tnCurrNode = m_tnRootNode;
			}
			else {
				l_tnCurrNode = l_tnNode;
			}

			TreeNodeCollection l_tcFolderCollection = l_tnCurrNode.Nodes;
			FileInfo l_FileInfo = null; 
			int l_iNoOfFiles = l_FileListObj.GetCount();
			int l_iCount = 0;
			
			string l_strFileName = "",l_strDateCreated = "",l_strTimeCreated = "";
			string l_strFilePath = "",l_strFileOwner = "",l_strFileGroup = "";
			int l_iFileType = 0,l_iFileSize = 0;
			string[] l_strsubItems = new string[3];
			int l_iTreeIndex = 0,l_iListIndex = 0;

			for ( ; l_iCount < l_iNoOfFiles ; l_iCount++ ) {
				l_FileInfo = l_FileListObj.GetFileInfo(l_iCount);
				if (l_FileInfo != null ) {
					l_FileInfo.GetFileInfo(out l_iFileType,out l_strFileName,out l_strFilePath,out l_strDateCreated,out l_iFileSize,out l_strFileOwner,out l_strFileGroup,out l_strTimeCreated);
					if ( l_iFileType == 2 ) {
						if ( l_strFileName.Equals(".") || l_strFileName.Equals("..") ) {
							/*	If current or parent directory, then do not add to treeview 
							 *	and skip to next record
							 */
							continue;
						}
						/*	If folder then add to tree view */
						TreeNode l_tnFolderNode = new TreeNode(l_strFileName,1,2);
						l_tcFolderCollection.Add(l_iTreeIndex,l_tnFolderNode);
						l_iTreeIndex++;
					}
					else {
						/*	Add to List view */
						l_lTotalSize += l_iFileSize;
						l_strsubItems[0] = l_iFileSize.ToString();
						l_strsubItems[1] = l_strDateCreated;
						switch ( m_FTPClient.GetServerOS()) {
							case 0 :	/*	If unknown	*/
								l_strsubItems[2] = l_strFileOwner;
								break;
							case 1 :	/*	If Unix	*/
								l_strsubItems[2] = l_strFileOwner;
								break;
							case 2 :	/*	If Windows */
								l_strsubItems[2] = l_strTimeCreated;
								break;
							default :
								l_strsubItems[2] = l_strFileOwner;
								break;
						}
						ListItem l_liFileData = new ListItem(l_strFileName,0,l_strsubItems);
						m_lvFileView.InsertItem(l_iListIndex,l_liFileData);
						l_iListIndex++;
					}
				}
			}

			/* Update member variables */
			m_lTotalSize =  l_lTotalSize;
			m_iTotalFiles = l_iListIndex;
			m_iTotalFolders = l_iTreeIndex;

			/* Update the List View label message */
			UpdateListViewLabel();
			
			/* Set Focus to List view control */
			m_lvFileView.Focus();
			return;
		}
		
		private void InitListControl(){
			m_lvFileView.Clear();
			m_lvFileView.InsertColumn(0,"Name",150,HorizontalAlignment.Left );
			m_lvFileView.InsertColumn(1,"Size",70,HorizontalAlignment.Right );
			m_lvFileView.InsertColumn(2,"Created",100,HorizontalAlignment.Left );
			switch ( m_FTPClient.GetServerOS()) {
				case 0 :	/*	If unknown	*/
					m_lvFileView.InsertColumn(3,"Owner",100,HorizontalAlignment.Left );
					break;
				case 1 :	/*	If unix	*/
					m_lvFileView.InsertColumn(3,"Owner",100,HorizontalAlignment.Left );
					break;
				case 2 :	/*	If Windows	*/
					m_lvFileView.InsertColumn(3,"Time",100,HorizontalAlignment.Left );
					break;
				default :
					m_lvFileView.InsertColumn(3,"Owner",100,HorizontalAlignment.Left );
					break;
			}
			return ;
		}

		private void ToggleMenuItems(int l_iConnFlag){
			/*	If connected */
			if ( l_iConnFlag == 1 ) {
				menuItem2.Enabled = false;
				menuItem3.Enabled = true;
				menuItem5.Enabled = true;
				menuItem11.Enabled = true;
				menuItem15.Enabled = true;
				menuItem12.Enabled = true;
				menuItem7.Enabled = true;
				
				toolBarButton1.Enabled = false;
				toolBarButton2.Enabled = true;
				toolBarButton3.Enabled = true;
				toolBarButton4.Enabled  = true;
				toolBarButton11.Enabled  = true;
				toolBarButton13.Enabled = true;
				toolBarButton14.Enabled = true;
				toolBarButton15.Enabled = true;
			}
			else {
				menuItem2.Enabled = true;
				menuItem3.Enabled = false;
				menuItem5.Enabled = false;
				menuItem11.Enabled = false;
				menuItem15.Enabled = false;
				menuItem12.Enabled = false;
				menuItem7.Enabled = false;

				toolBarButton1.Enabled = true;
				toolBarButton2.Enabled = false;
				toolBarButton3.Enabled = false;
				toolBarButton4.Enabled  = false;
				toolBarButton11.Enabled  = false;
				toolBarButton13.Enabled = false;
				toolBarButton14.Enabled = false;
				toolBarButton15.Enabled = false;
			}
			return ;
		}

		/*	Set Message to status bar */
		public void SetStausMessage(string l_strMessage2){
			if ( l_strMessage2 != null ) {
				statusBarPanel2.Text = l_strMessage2;
			}
			m_statusBar.Refresh();
		}

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static void Main(string[] args) 
        {
            Application.Run(new ExplorerDlg());
        }

    }	/* End of ExplorerDlg.cs */

	class MRUConnections {
		private string m_strFTPServer;
		private string m_strUserID;
		
		public MRUConnections(){
			m_strFTPServer = "";
			m_strUserID = "";
		}

		public string FTPServer {
			get {
				return m_strFTPServer;
			}
			set {
				m_strFTPServer = value;
			}
		}

		public string FTPUser {
			get {
				return m_strUserID;
			}
			set {
				m_strUserID = value;
			}
		}
	} /* End of MRUConnections class */
}
