using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NiranjanFTP;

namespace FTPExplorer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FTPExplorerDlg : System.Windows.Forms.Form {
		#region Declarations.
		private System.Windows.Forms.MainMenu m_MainMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.ImageList m_iLToolBar;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.ImageList m_iLTreeView;
		private System.Windows.Forms.TreeView m_tVFolders;
		private System.Windows.Forms.ListView m_lVFiles;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private System.Windows.Forms.ToolBarButton toolBarButton14;
		private System.Windows.Forms.ToolBarButton toolBarButton15;
		private System.Windows.Forms.ToolBarButton toolBarButton17;
		private System.Windows.Forms.StatusBar m_sbStatus;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.ComponentModel.IContainer components;
		#endregion Declarations.
		private FTPClient m_FtpClient;
		private System.Windows.Forms.DataGrid m_dGFiles;
		private TreeNode m_tnRootNode;
		private System.Windows.Forms.StatusBarPanel statusBarPanel3;
		private string m_strLocalFolder;
		private bool m_bNewNodeFlag;
		private int m_iFolderCount, m_iFileCount;

		public FTPProperties m_FTPProperties;

		public FTPExplorerDlg(FTPMainMdiForm l_formParent) {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			MdiParent = l_formParent;
			m_FTPProperties = new FTPProperties();
			m_tnRootNode = null;
			EnableToolBarButtons(false);
			toolBarButton3.Enabled = true;
			toolBarButton17.Enabled = true;
			m_strLocalFolder = "C:\\";
			m_bNewNodeFlag = false;
			InitControls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FTPExplorerDlg));
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.m_iLToolBar = new System.Windows.Forms.ImageList(this.components);
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.m_MainMenu = new System.Windows.Forms.MainMenu();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton15 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton17 = new System.Windows.Forms.ToolBarButton();
			this.m_sbStatus = new System.Windows.Forms.StatusBar();
			this.m_dGFiles = new System.Windows.Forms.DataGrid();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.m_lVFiles = new System.Windows.Forms.ListView();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.m_tVFolders = new System.Windows.Forms.TreeView();
			this.m_iLTreeView = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_dGFiles)).BeginInit();
			this.SuspendLayout();
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 2;
			this.toolBarButton3.ToolTipText = "Configure FTP connection";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			this.toolBarButton2.ToolTipText = "Disconnect from FTP server";
			// 
			// statusBarPanel3
			// 
			this.statusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel3.Width = 10;
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.ImageIndex = 6;
			this.toolBarButton9.ToolTipText = "Upload File to Remote Server";
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.ImageIndex = 5;
			this.toolBarButton8.ToolTipText = "Refresh folders and files";
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.Width = 250;
			// 
			// m_iLToolBar
			// 
			this.m_iLToolBar.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
			this.m_iLToolBar.ImageSize = new System.Drawing.Size(22, 22);
			this.m_iLToolBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_iLToolBar.ImageStream")));
			this.m_iLToolBar.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 3;
			this.menuItem8.Text = "Co&nfigure";
			this.menuItem8.Click += new System.EventHandler(this.OnClickServerConfigure);
			// 
			// statusBarPanel2
			// 
			this.statusBarPanel2.Width = 250;
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "-";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 5;
			this.menuItem5.Text = "C&lose";
			this.menuItem5.Click += new System.EventHandler(this.OnClickClose);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem8,
																					  this.menuItem9,
																					  this.menuItem5});
			this.menuItem1.Text = "&Server";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "&Connect";
			this.menuItem2.Click += new System.EventHandler(this.OnClickServerConnect);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "&Disconnect";
			this.menuItem3.Click += new System.EventHandler(this.OnClickServerDisconnect);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 4;
			this.menuItem9.Text = "-";
			// 
			// m_MainMenu
			// 
			this.m_MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem1,
																					   this.menuItem10});
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 1;
			this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem11,
																					   this.menuItem12,
																					   this.menuItem13,
																					   this.menuItem14,
																					   this.menuItem15,
																					   this.menuItem16,
																					   this.menuItem18,
																					   this.menuItem19,
																					   this.menuItem20,
																					   this.menuItem17});
			this.menuItem10.Text = "&Options";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 0;
			this.menuItem11.Text = "&Create Folder";
			this.menuItem11.Click += new System.EventHandler(this.OnClickOptionsCreateFolder);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 1;
			this.menuItem12.Text = "&Delete Folder";
			this.menuItem12.Click += new System.EventHandler(this.OnClickOptionsDeleteFolder);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 2;
			this.menuItem13.Text = "-";
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 3;
			this.menuItem14.Text = "&Refresh";
			this.menuItem14.Click += new System.EventHandler(this.OnClickOptionsRefresh);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 4;
			this.menuItem15.Text = "&Upload File";
			this.menuItem15.Click += new System.EventHandler(this.OnClickOptionsUploadFile);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 5;
			this.menuItem16.Text = "Dow&nload File";
			this.menuItem16.Click += new System.EventHandler(this.OnClickOptionsDownloadFile);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 6;
			this.menuItem18.Text = "-";
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 7;
			this.menuItem19.Text = "Delete &File";
			this.menuItem19.Click += new System.EventHandler(this.OnClickOptionsDeleteFile);
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 8;
			this.menuItem20.Text = "-";
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 9;
			this.menuItem17.Text = "Set &Local Folder";
			this.menuItem17.Click += new System.EventHandler(this.OnClickOptionsSetLWD);
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3,
																						this.toolBarButton4,
																						this.toolBarButton5,
																						this.toolBarButton6,
																						this.toolBarButton7,
																						this.toolBarButton8,
																						this.toolBarButton9,
																						this.toolBarButton10,
																						this.toolBarButton11,
																						this.toolBarButton12,
																						this.toolBarButton13,
																						this.toolBarButton14,
																						this.toolBarButton15,
																						this.toolBarButton17});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.m_iLToolBar;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(427, 31);
			this.toolBar1.TabIndex = 1;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.OnButtonClickToolBar);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			this.toolBarButton1.ToolTipText = "Connect to FTP server";
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.ImageIndex = 3;
			this.toolBarButton5.ToolTipText = "Create Folder in Remote Server";
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 4;
			this.toolBarButton6.ToolTipText = "Delete a folder in Remote Server";
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton10
			// 
			this.toolBarButton10.ImageIndex = 7;
			this.toolBarButton10.ToolTipText = "Download file from Remote Server";
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton12
			// 
			this.toolBarButton12.ImageIndex = 8;
			this.toolBarButton12.ToolTipText = "Delete a file in Remote server";
			// 
			// toolBarButton13
			// 
			this.toolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton14
			// 
			this.toolBarButton14.ImageIndex = 9;
			this.toolBarButton14.ToolTipText = "Set Local folder";
			// 
			// toolBarButton15
			// 
			this.toolBarButton15.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton17
			// 
			this.toolBarButton17.ImageIndex = 10;
			this.toolBarButton17.ToolTipText = "Close this window";
			// 
			// m_sbStatus
			// 
			this.m_sbStatus.Location = new System.Drawing.Point(0, 267);
			this.m_sbStatus.Name = "m_sbStatus";
			this.m_sbStatus.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2,
																						  this.statusBarPanel3});
			this.m_sbStatus.ShowPanels = true;
			this.m_sbStatus.Size = new System.Drawing.Size(427, 20);
			this.m_sbStatus.TabIndex = 0;
			this.m_sbStatus.Text = "statusBar1";
			// 
			// m_dGFiles
			// 
			this.m_dGFiles.CaptionVisible = false;
			this.m_dGFiles.DataMember = "";
			this.m_dGFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_dGFiles.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.m_dGFiles.Location = new System.Drawing.Point(263, 31);
			this.m_dGFiles.Name = "m_dGFiles";
			this.m_dGFiles.ReadOnly = true;
			this.m_dGFiles.Size = new System.Drawing.Size(164, 236);
			this.m_dGFiles.TabIndex = 5;
			this.toolTip1.SetToolTip(this.m_dGFiles, "Displays files in the FTP Server");
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(260, 31);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 236);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// m_lVFiles
			// 
			this.m_lVFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_lVFiles.Location = new System.Drawing.Point(260, 31);
			this.m_lVFiles.Name = "m_lVFiles";
			this.m_lVFiles.Size = new System.Drawing.Size(167, 236);
			this.m_lVFiles.TabIndex = 3;
			this.toolTip1.SetToolTip(this.m_lVFiles, "Displays Files in FTP Server");
			this.m_lVFiles.Visible = false;
			// 
			// m_tVFolders
			// 
			this.m_tVFolders.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_tVFolders.ImageList = this.m_iLTreeView;
			this.m_tVFolders.Location = new System.Drawing.Point(0, 31);
			this.m_tVFolders.Name = "m_tVFolders";
			this.m_tVFolders.Size = new System.Drawing.Size(260, 236);
			this.m_tVFolders.TabIndex = 2;
			this.toolTip1.SetToolTip(this.m_tVFolders, "Displays Folders in FTP Server");
			this.m_tVFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnAfterSelectFolderView);
			// 
			// m_iLTreeView
			// 
			this.m_iLTreeView.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
			this.m_iLTreeView.ImageSize = new System.Drawing.Size(16, 16);
			this.m_iLTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_iLTreeView.ImageStream")));
			this.m_iLTreeView.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// FTPExplorerDlg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(427, 287);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.m_dGFiles,
																		  this.splitter1,
																		  this.m_lVFiles,
																		  this.m_tVFolders,
																		  this.toolBar1,
																		  this.m_sbStatus});
			this.Name = "FTPExplorerDlg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FTP Explorer - Not connected";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.OnFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_dGFiles)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void OnClickServerConnect(object sender, System.EventArgs e) {
			FTPConnectDlg connectDlg = new FTPConnectDlg(m_FTPProperties);
			if ( connectDlg.ShowDialog() == DialogResult.OK){
				SetStatusMessage("Connecting to server. Please wait...","","NONE");

				Cursor = Cursors.WaitCursor;
				m_FTPProperties = connectDlg.m_FTPProperties;
				m_FTPProperties.FTPServer = connectDlg.FTPServer;
				m_FTPProperties.UserID = connectDlg.UserID;
				m_FTPProperties.Password = connectDlg.Password;
				if ( m_FtpClient == null ){
					m_FtpClient = new FTPClient(m_FTPProperties.FTPServer,m_FTPProperties.UserID,m_FTPProperties.Password,m_FTPProperties.Port,m_FTPProperties.SendTimeOut,m_FTPProperties.RecvTimeOut);
				}
				else {
					m_FtpClient.FTPServer = m_FTPProperties.FTPServer;
					m_FtpClient.UserID = m_FTPProperties.UserID;
					m_FtpClient.Password = m_FTPProperties.Password;
					m_FtpClient.Port = m_FTPProperties.Port;
					m_FtpClient.SendTimeOut = m_FTPProperties.SendTimeOut;
					m_FtpClient.RecvTimeOut = m_FTPProperties.RecvTimeOut;
				}

				int l_iRetval = m_FtpClient.Connect();
				if ( l_iRetval == 0 ){
					Cursor = Cursors.Arrow;
					MessageBox.Show(m_FtpClient.ErrorMessage,"FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return ;
				}
				EnableToolBarButtons(true);
				string l_strTemp = m_FTPProperties.UserID + "@" + m_FTPProperties.FTPServer;
				SetStatusMessage("Connected to " + l_strTemp,"Listing foldes and files. Please wait...","NONE");

				/* Proceed with Listing files */
				DataTable l_dtFileList = m_FtpClient.GetList(null);
				if ( l_dtFileList != null && l_dtFileList.Rows.Count > 0 ){

					m_tnRootNode = new TreeNode(m_FtpClient.RootDirectory,0,0);
					m_tVFolders.Nodes.Add(m_tnRootNode);

					PopulateFolders(m_tnRootNode,l_dtFileList);
					PopulateFiles(l_dtFileList);
				}
				else {
					Cursor = Cursors.Arrow;
					/* If error then disconnect */
					MessageBox.Show(m_FtpClient.ErrorMessage,"FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					OnClickServerDisconnect(sender,e);
					return;
				}
				this.Text = l_strTemp;
				Cursor = Cursors.Arrow;
			}
		}

		private void OnClickServerDisconnect(object sender, System.EventArgs e) {
			m_FtpClient.Disconnect();
			m_tVFolders.Nodes.Clear();
			m_dGFiles.DataSource = null;
			m_dGFiles.DataBindings.Clear();
			m_dGFiles.Refresh();
			EnableToolBarButtons(false);
			SetStatusMessage("Not Connected","",m_strLocalFolder);
			this.Text = "Not connected";
		}

		private void OnClickServerConfigure(object sender, System.EventArgs e) {
			FTPConfigureDlg configureDlg = new FTPConfigureDlg(false,m_FTPProperties);
			if ( configureDlg.ShowDialog() == DialogResult.OK){
				m_FTPProperties = configureDlg.m_FTPProperties;
			}
		}

		private void OnButtonClickToolBar(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e) {
			int l_iImageIndex = e.Button.ImageIndex;
			switch (l_iImageIndex){
				case 0 :
					OnClickServerConnect(sender,e);
					break;
				case 1:
					OnClickServerDisconnect(sender,e);
					break;
				case 2:
					OnClickServerConfigure(sender,e);
					break;
				case 3:
					OnClickOptionsCreateFolder(sender,e);
					break;
				case 4:
					OnClickOptionsDeleteFolder(sender,e);
					break;
				case 5 :
					OnClickOptionsRefresh(sender,e);
					break;
				case 6 :
					OnClickOptionsUploadFile(sender,e);
					break;
				case 7 :
					OnClickOptionsDownloadFile(sender,e);
					break;
				case 8 :
					OnClickOptionsDeleteFile(sender,e);
					break;
				case 9 :
					OnClickOptionsSetLWD(sender,e);
					break;
				case 10 :
					OnClickClose(sender,e);
					break;
				default :
					break;
			}
		}

		private void InitControls(){
			m_tVFolders.Nodes.Clear();
			m_lVFiles.Items.Clear();
			m_iFolderCount = m_iFileCount = 0;
			SetStatusMessage("Not Connected","",m_strLocalFolder);
			return;
		}

		private void OnClickOptionsCreateFolder(object sender, System.EventArgs e) {
			string l_strNewFolder = "";

			FTPNewFolderDlg newFolderDlg = new FTPNewFolderDlg();
			if ( newFolderDlg.ShowDialog() == DialogResult.OK){
				this.Cursor = Cursors.WaitCursor;
				l_strNewFolder = newFolderDlg.NewFolder;
				int l_iRetval = m_FtpClient.CreateFolder(l_strNewFolder);
				if ( l_iRetval == 0 ) {
					this.Cursor = Cursors.Arrow;
					string l_strError = m_FtpClient.ErrorMessage;
					MessageBox.Show(l_strError,"FTP Explorer",MessageBoxButtons.OK,MessageBoxIcon.Stop);
					return;
				}
				else {
					
					/* Add the node to tree view control */
					TreeNode l_tnCurrNode = m_tVFolders.SelectedNode;
					TreeNodeCollection l_tcNodes = l_tnCurrNode.Nodes;
					TreeNode l_tnChildNode = new TreeNode(l_strNewFolder,1,2);
					l_tcNodes.Add(l_tnChildNode);
					m_tVFolders.Refresh();
					

					/* Select the current node */
					m_bNewNodeFlag = true;
					m_tVFolders.SelectedNode = l_tnChildNode;
					/* Clear the File View */
					m_dGFiles.DataSource = null;
					m_dGFiles.DataBindings.Clear();
					SetStatusMessage("NONE","Folder(s) :0, File(s) :0","NONE");

					this.Cursor = Cursors.Arrow;
					//MessageBox.Show("Folder '" + l_strNewFolder + "' Successfully created","FTP Explorer",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
		}

		private void OnClickOptionsDeleteFolder(object sender, System.EventArgs e) {
			TreeNode l_tnCurrNode = m_tVFolders.SelectedNode;
		
			if ( m_tVFolders.ContainsFocus == false ) {
				MessageBox.Show("Select a folder to be deleted and select this option","FTP Explorer",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			if ( l_tnCurrNode == null ) {
				MessageBox.Show("Select a folder other than root node to delete","FTP Explorer",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
		
			if ( l_tnCurrNode == m_tnRootNode ) {
				MessageBox.Show("Cannot remove root node","FTP Explorer",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			string l_strFolder = l_tnCurrNode.FullPath;
			l_strFolder = l_strFolder.Replace('\\','/');
			string l_strMessage = "Are you sure to delete '" + l_strFolder + "' folder ?";

			if ( MessageBox.Show(l_strMessage,"FTP Explorer",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != DialogResult.OK ) {
				return;
			}

			statusBarPanel2.Text = "Deleting selected folder. Please wait...";
			m_sbStatus.Refresh();

			this.Cursor = Cursors.WaitCursor;

			TreeNode l_tnParentNode = l_tnCurrNode.Parent;
			if ( l_tnParentNode == null ) {
				l_tnParentNode = m_tnRootNode;
			}
					
			/* Go to parent folder and then delete the current folder */
			string l_strParentFolder = l_tnParentNode.FullPath;
			l_strParentFolder = l_strParentFolder.Replace('\\','/');
			int l_iRetval = m_FtpClient.ChangeWorkingFolder(l_strParentFolder);
			if (l_iRetval == 0 ) {
				this.Cursor = Cursors.Arrow;
				string l_strErr = m_FtpClient.ErrorMessage;
				MessageBox.Show(l_strErr,"FTP Explorer",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return ;
			}

			/* Now Remove Folder from FTP Server */
			if ( m_FtpClient.RemoveFolder(l_strFolder) == 0 ) {
				this.Cursor = Cursors.Arrow;
				string l_strError = m_FtpClient.ErrorMessage;
				MessageBox.Show(l_strError,"FTP Explorer",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return;
			}

			this.Cursor = Cursors.WaitCursor;
		
			/* Refresh File views for the Parent folder */
			string l_strParentDir = l_tnParentNode.Text;
			m_tVFolders.SelectedNode = l_tnParentNode;
		
			/* Clear all child nodes *
			l_tnParentNode.Nodes.Clear();
			RefreshFolderView(l_strParentFolder,l_strParentDir,l_tnParentNode);
			*/

			this.Cursor = Cursors.Arrow;
			return;
		}

		private void OnClickOptionsRefresh(object sender, System.EventArgs e) {
			Cursor = Cursors.WaitCursor;
			DataTable l_dtFileList = m_FtpClient.GetList(null);
			if ( l_dtFileList != null && l_dtFileList.Rows.Count > 0 ){
				/* Clear the root node */
				m_tVFolders.Nodes.Clear();

				m_tnRootNode = new TreeNode(m_FtpClient.RootDirectory,0,0);
				m_tVFolders.Nodes.Add(m_tnRootNode);

				PopulateFolders(m_tnRootNode,l_dtFileList);
				PopulateFiles(l_dtFileList);
			}
			else {
				Cursor = Cursors.Arrow;
				MessageBox.Show("No folders or files found");
				return;
			}
			Cursor = Cursors.Arrow;
		}

		private void OnClickOptionsUploadFile(object sender, System.EventArgs e) {
			OpenFileDialog l_openFileDialog = new OpenFileDialog();
			l_openFileDialog.CheckFileExists = true;
			l_openFileDialog.InitialDirectory = "C:\\";
			l_openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			l_openFileDialog.Title = "Select file to upload";

			if ( l_openFileDialog.ShowDialog() == DialogResult.OK ){
				string l_strLocalFileFullName = l_openFileDialog.FileName;
				int l_iLen = l_strLocalFileFullName.Length;
				int l_iCtr = l_iLen;
				for ( l_iCtr-- ; l_iCtr > 0 ; l_iCtr-- ){
					char ch = l_strLocalFileFullName[l_iCtr];
					if ( ch == '\\' ){
						break;
					}
				}

				string l_strLocalFileName = l_strLocalFileFullName.Substring(l_iCtr+1);
				l_strLocalFileName.Trim();
				if ( l_strLocalFileName.Length == 0 ){
					MessageBox.Show("Select a valid file and click upload option","FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}

				SetStatusMessage("Uploading file. Please wait...","NONE","NONE");
				Cursor = Cursors.WaitCursor;
				string l_strRemoteFile = m_FtpClient.CurrentDirectory + "/" + l_strLocalFileName;
				int l_iRetval = m_FtpClient.UploadFile(l_strLocalFileFullName,l_strRemoteFile);
				Cursor = Cursors.Arrow;
				if ( l_iRetval == 0 ){
					MessageBox.Show(m_FtpClient.ErrorMessage,"FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				else {
					try {
						DataView l_dvFile = (DataView) m_dGFiles.DataSource;
						DataTable l_dtFileList = l_dvFile.Table;
						DataRow l_drNewRow = l_dtFileList.NewRow();
						if ( m_FtpClient.ServerOS == 1 ){
							/* Unix */
							l_drNewRow[0] = l_strLocalFileName;
							l_drNewRow[1] = DateTime.Today.ToShortDateString();
							l_drNewRow[2] = l_iRetval+1;
							l_drNewRow[3] = "unknown";
							l_drNewRow[4] = "unknown";
						}
						else if (m_FtpClient.ServerOS == 2) {
							/* Windows */
							l_drNewRow[0] = l_strLocalFileName;
							l_drNewRow[1] = DateTime.Today.ToShortDateString();
							l_drNewRow[2] = l_iRetval+1;
						}

						m_iFileCount++;
						l_dtFileList.Rows.Add(l_drNewRow);
						//m_dGFiles.DataSource = l_dtFileList.DefaultView;
					}
					catch ( Exception e1){
					}
				}
				string l_strTemp = "Connected to " + m_FTPProperties.UserID + "@" + m_FTPProperties.FTPServer;
				SetStatusMessage(l_strTemp,"LIST","NONE");
			}
			//return;
		}

		private void OnClickOptionsDownloadFile(object sender, System.EventArgs e) {
			if ( m_dGFiles.Focused == false ){
				MessageBox.Show("Select the entire row click download option","FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			int l_iCurrRow = m_dGFiles.CurrentRowIndex;
			string l_strFileName = (string) m_dGFiles[l_iCurrRow,0];
			l_strFileName.Trim();
			if ( l_strFileName.Length == 0 ){
				MessageBox.Show("Select a valid file and click download option","FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			SetStatusMessage("Downloading file. Please wait...","NONE","NONE");
			Cursor = Cursors.WaitCursor;
			string l_strLocalFile = m_strLocalFolder + "\\" + l_strFileName;
			int l_iRetval = m_FtpClient.DownLoadFile(l_strFileName,l_strLocalFile);
			Cursor = Cursors.Arrow;
			if ( l_iRetval == 0 ){
				MessageBox.Show(m_FtpClient.ErrorMessage,"FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			string l_strTemp = "Connected to " + m_FTPProperties.UserID + "@" + m_FTPProperties.FTPServer;
			SetStatusMessage(l_strTemp,"LIST","NONE");
			return;
		}

		private void OnClickOptionsDeleteFile(object sender, System.EventArgs e) {
			DataGridCell l_dgcCurrent = m_dGFiles.CurrentCell;
			int l_iCurrentRow = m_dGFiles.CurrentCell.RowNumber;
			string l_strFileName = (string) m_dGFiles[l_dgcCurrent];
			l_strFileName.Trim();
			if ( l_strFileName.Length == 0 ){
				MessageBox.Show("Select a valid file and click delete option","FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			int l_iRetval = m_FtpClient.RemoveFile(l_strFileName);
			if ( l_iRetval == 1 ){
				try {
					m_iFileCount--;
					DataView l_dvFile = (DataView) m_dGFiles.DataSource;
					DataTable l_dtFileList = l_dvFile.Table;
					l_dtFileList.Rows.RemoveAt(l_iCurrentRow);
					m_dGFiles.DataSource = l_dtFileList.DefaultView;
					SetStatusMessage("NONE","LIST","NONE");
				}
				catch ( Exception e1){
				}
			}
		}

		private void OnClickOptionsSetLWD(object sender, System.EventArgs e) {
			FTPLocalFolderDlg localFolderdlg = new FTPLocalFolderDlg(m_strLocalFolder);
			if ( localFolderdlg.ShowDialog() == DialogResult.OK){
				m_strLocalFolder = localFolderdlg.LocalFolder;
			}
			SetStatusMessage("NONE","NONE",m_strLocalFolder);
		}

		private void OnClickClose(object sender, System.EventArgs e) {
			Close();
		}

		private void PopulateFolders(TreeNode l_tnCurrNode,DataTable l_dtFileList){
			int l_iFileType = 0;
			int l_iFolderCtr = 0;
			string l_strFileName = "";
			TreeNodeCollection l_tnCollection = l_tnCurrNode.Nodes;
			foreach(object obj in l_dtFileList.Rows){
				DataRow l_drRow = (DataRow) obj;
				l_iFileType = (int) l_drRow[0];
				l_strFileName = (string) l_drRow[1];

				/* Add only folders */
				if ( l_iFileType == 2 ){
					l_tnCollection.Add(new TreeNode(l_strFileName,1,2));
					l_iFolderCtr++;
				}
			}
			m_iFolderCount = l_iFolderCtr;
			SetStatusMessage("NONE","LIST","NONE");
			m_tVFolders.ExpandAll();
		}

		private void PopulateFiles(DataTable l_dtFileList){
			try {
				int l_iFileType = 0;
				int l_iFileCtr = 0;
				DataTable l_dtFiles = new DataTable("FileList");
				
				if ( m_FtpClient.ServerOS == 1 ){
					DataColumn l_dc1 = new DataColumn("File Name",typeof(string));
					DataColumn l_dc2 = new DataColumn("Created Date",typeof(string));
					DataColumn l_dc3 = new DataColumn("File Size",typeof(int));
					DataColumn l_dc4 = new DataColumn("File Owner",typeof(string));
					DataColumn l_dc5 = new DataColumn("File Group",typeof(string));

					l_dtFiles.Columns.Add(l_dc1);
					l_dtFiles.Columns.Add(l_dc2);
					l_dtFiles.Columns.Add(l_dc3);
					l_dtFiles.Columns.Add(l_dc4);
					l_dtFiles.Columns.Add(l_dc5);
				}
				else if (m_FtpClient.ServerOS == 2) {
					DataColumn l_dc1 = new DataColumn("File Name",typeof(string));
					DataColumn l_dc2 = new DataColumn("Created Date",typeof(string));
					DataColumn l_dc3 = new DataColumn("File Size",typeof(int));

					l_dtFiles.Columns.Add(l_dc1);
					l_dtFiles.Columns.Add(l_dc2);
					l_dtFiles.Columns.Add(l_dc3);
				}

				foreach(DataRow l_drRow in l_dtFileList.Rows){
					l_iFileType = (int) l_drRow[0];

					/* Add only files */
					if ( l_iFileType == 1 ){
						DataRow l_newRow = l_dtFiles.NewRow();
						if ( m_FtpClient.ServerOS == 1 ){
							/* Unix */
							l_newRow[0] = l_drRow[1];
							l_newRow[1] = l_drRow[3];
							l_newRow[2] = l_drRow[4];
							l_newRow[3] = l_drRow[5];
							l_newRow[4] = l_drRow[6];
						}
						else if (m_FtpClient.ServerOS == 2) {
							/* Windows */
							l_newRow[0] = l_drRow[1];
							l_newRow[1] = l_drRow[3];
							l_newRow[2] = l_drRow[4];
						}
						l_dtFiles.Rows.Add(l_newRow);
						l_iFileCtr++;
					}
				}
				m_dGFiles.DataSource = l_dtFiles.DefaultView;
				m_iFileCount = l_iFileCtr;
				SetStatusMessage("NONE","LIST","NONE");
			}
			catch ( Exception e){
				return ;
			}
		}

		private void OnAfterSelectFolderView(object sender, System.Windows.Forms.TreeViewEventArgs e) {
			try {
				if ( m_bNewNodeFlag == true ){
					m_bNewNodeFlag = false;
					return;
				}
				this.Cursor = Cursors.WaitCursor;
				/* Clear the File view contents */
				m_dGFiles.DataBindings.Clear();
				TreeNode l_tempNode = e.Node;
				if ( l_tempNode == m_tnRootNode ) {
					/*	If root node is clicked do not do anything */
					this.Cursor = Cursors.Arrow;
					return ;
				}
				
				/*	Clear all child nodes first */
				TreeNodeCollection l_tnCollection = l_tempNode.Nodes;
				if ( l_tnCollection != null ){
					l_tnCollection.Clear();
				}

				/*	Populate Folder view */
				string l_strCurDir = l_tempNode.Text;
				string l_strFullPath = l_tempNode.FullPath;
				l_strFullPath = l_strFullPath.Replace('\\','/');

				string l_strTemp = m_FTPProperties.UserID + "@" + m_FTPProperties.FTPServer;
				SetStatusMessage("Connected to " + l_strTemp,"Listing foldes and files. Please wait...","NONE");

				/*	Change to corresponding directory */
				int l_iRetval = m_FtpClient.ChangeWorkingFolder(l_strFullPath);
				if (l_iRetval == 0 ) {
					string l_strErr = m_FtpClient.ErrorMessage;
					this.Cursor = Cursors.Arrow;
					MessageBox.Show(l_strErr,"FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return ;
				}

				/* Get the file contents */
				DataTable l_dtFileList = m_FtpClient.GetList(l_strFullPath);
				if ( l_dtFileList != null ){
					PopulateFolders(l_tempNode,l_dtFileList);
					PopulateFiles(l_dtFileList);
				}
				this.Cursor = Cursors.Arrow;
				return;
			}
			catch ( Exception e1){
				this.Cursor = Cursors.Arrow;
				MessageBox.Show(e1.Message,"FTP Explorer - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void OnFormClosing(object sender, System.ComponentModel.CancelEventArgs e) {
			if ( m_FtpClient != null ){
				m_FtpClient.Disconnect();
			}
			m_tVFolders.Nodes.Clear();
			m_dGFiles.DataBindings.Clear();
			EnableToolBarButtons(false);
		}

		private void EnableToolBarButtons(bool l_bStatus){
			toolBarButton1.Enabled = !l_bStatus;
			toolBarButton2.Enabled = l_bStatus;
			toolBarButton5.Enabled = l_bStatus;
			toolBarButton6.Enabled = l_bStatus;
			toolBarButton8.Enabled = l_bStatus;
			toolBarButton9.Enabled = l_bStatus;
			toolBarButton10.Enabled = l_bStatus;
			toolBarButton12.Enabled = l_bStatus;
			toolBarButton14.Enabled = l_bStatus;
		}
		
		private void SetStatusMessage(string l_strMessage1,string l_strMessage2,string l_strMessage3){
			if ( l_strMessage1.Equals("NONE") == false ){
				statusBarPanel1.Text = l_strMessage1;
			}
			
			if ( l_strMessage2.Equals("LIST") == true ){
				string l_strText = "Folder(s) :" + m_iFolderCount + ", File(s) :" + m_iFileCount;
				statusBarPanel2.Text = l_strText;
			}
			else if ( l_strMessage2.Equals("NONE") == false ){
				statusBarPanel2.Text = l_strMessage2;
			}
			
			if ( l_strMessage3.Equals("NONE") == false ){
				statusBarPanel3.Text = l_strMessage3;
			}
			m_sbStatus.Refresh();
		}
	}
}
