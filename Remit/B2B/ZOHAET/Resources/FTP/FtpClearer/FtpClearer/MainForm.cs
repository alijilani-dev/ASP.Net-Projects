//TODO: * Add additional criteria - size of file, empty directory, date of directory
//TODO: * Images not working on treeView - done
//TODO: * Time before now criteria not working on some ftp sites - done
//TODO: * add multithreading so that UI responds while search is on and allows cancel.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using com.enterprisedt.net.ftp;
using System.Xml;
using System.Xml.XPath;
using System.Threading;

namespace FtpClearer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FTPClearer : System.Windows.Forms.Form
	{
		#region Declarations.
        private System.Windows.Forms.TreeView ftpDirTreeView;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button deleteButton;
        private System.ComponentModel.IContainer components;

        private FTPClient ftpClient;
        private System.Windows.Forms.ComboBox predefinedComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown daysNumericUpDown;
        private System.Windows.Forms.NumericUpDown minutesNumericUpDown;
        private System.Windows.Forms.NumericUpDown hoursNumericUpDown;
        private System.Windows.Forms.NumericUpDown secondsNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        //private bool isUnixFtpSite = true;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button cancelScanButton;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ignoreTextBox;
        private Hashtable ftpConfigList = new Hashtable();
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.CheckBox checkDirectoriesCheckbox;
        private string[] ignoreSubstrings = null;
        private ToolTip toolTip = new ToolTip();
        private TreeNode rootNode = null;
        private System.Windows.Forms.ContextMenu treeViewContextMenu;
        private System.Windows.Forms.MenuItem checkAllMenuItem;
        private System.Windows.Forms.MenuItem UncheckAllMenuItem;
    
        private enum FtpServerType {Dunno, Unix, Windows};
        private FtpServerType ftpServerType = FtpServerType.Dunno;
		#endregion Declarations.
        public class ServerFileData
        {
            public bool    isDirectory;
            public string  fileName;
            public int     size;
            public string  type;
            public string  date;
            public string  permission;
            public string  owner;
            public string  group;

            public ServerFileData()
            {
            }
        }

        public class FtpConfig
        {
            public string Server = "";
            public string User = "";
            public string Password = "";
        }

		public FTPClearer()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
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
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FTPClearer));
			this.ftpDirTreeView = new System.Windows.Forms.TreeView();
			this.treeViewContextMenu = new System.Windows.Forms.ContextMenu();
			this.checkAllMenuItem = new System.Windows.Forms.MenuItem();
			this.UncheckAllMenuItem = new System.Windows.Forms.MenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.serverTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.userNameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.scanButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.predefinedComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.daysNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.minutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.hoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.secondsNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cancelScanButton = new System.Windows.Forms.Button();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.label9 = new System.Windows.Forms.Label();
			this.ignoreTextBox = new System.Windows.Forms.TextBox();
			this.aboutButton = new System.Windows.Forms.Button();
			this.checkDirectoriesCheckbox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.secondsNumericUpDown)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ftpDirTreeView
			// 
			this.ftpDirTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.ftpDirTreeView.CheckBoxes = true;
			this.ftpDirTreeView.ContextMenu = this.treeViewContextMenu;
			this.ftpDirTreeView.ImageList = this.imageList1;
			this.ftpDirTreeView.Location = new System.Drawing.Point(8, 184);
			this.ftpDirTreeView.Name = "ftpDirTreeView";
			this.ftpDirTreeView.PathSeparator = "/";
			this.ftpDirTreeView.Size = new System.Drawing.Size(528, 208);
			this.ftpDirTreeView.TabIndex = 18;
			this.ftpDirTreeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ftpDirTreeView_MouseMove);
			// 
			// treeViewContextMenu
			// 
			this.treeViewContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																								this.checkAllMenuItem,
																								this.UncheckAllMenuItem});
			// 
			// checkAllMenuItem
			// 
			this.checkAllMenuItem.Index = 0;
			this.checkAllMenuItem.Text = "&Check all";
			this.checkAllMenuItem.Click += new System.EventHandler(this.checkAllMenuItem_Click);
			// 
			// UncheckAllMenuItem
			// 
			this.UncheckAllMenuItem.Index = 1;
			this.UncheckAllMenuItem.Text = "&Uncheck all";
			this.UncheckAllMenuItem.Click += new System.EventHandler(this.UncheckAllMenuItem_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// serverTextBox
			// 
			this.serverTextBox.Location = new System.Drawing.Point(80, 48);
			this.serverTextBox.Name = "serverTextBox";
			this.serverTextBox.Size = new System.Drawing.Size(160, 20);
			this.serverTextBox.TabIndex = 3;
			this.serverTextBox.Text = "65.223.147.201";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Se&rver:";
			// 
			// userNameTextBox
			// 
			this.userNameTextBox.Location = new System.Drawing.Point(80, 80);
			this.userNameTextBox.Name = "userNameTextBox";
			this.userNameTextBox.Size = new System.Drawing.Size(160, 20);
			this.userNameTextBox.TabIndex = 5;
			this.userNameTextBox.Text = "SpeedRemit";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "&User:";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(80, 112);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(160, 20);
			this.passwordTextBox.TabIndex = 7;
			this.passwordTextBox.Text = "zohaindia";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "P&assword:";
			// 
			// scanButton
			// 
			this.scanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.scanButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.scanButton.Location = new System.Drawing.Point(368, 400);
			this.scanButton.Name = "scanButton";
			this.scanButton.Size = new System.Drawing.Size(80, 24);
			this.scanButton.TabIndex = 19;
			this.scanButton.Text = "S&can";
			this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.deleteButton.Location = new System.Drawing.Point(456, 400);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(80, 24);
			this.deleteButton.TabIndex = 20;
			this.deleteButton.Text = "De&lete";
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// predefinedComboBox
			// 
			this.predefinedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.predefinedComboBox.Location = new System.Drawing.Point(80, 16);
			this.predefinedComboBox.Name = "predefinedComboBox";
			this.predefinedComboBox.Size = new System.Drawing.Size(160, 21);
			this.predefinedComboBox.TabIndex = 1;
			this.predefinedComboBox.SelectedIndexChanged += new System.EventHandler(this.predefinedComboBox_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "&Predefined:";
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 144);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "FTP Server";
			// 
			// daysNumericUpDown
			// 
			this.daysNumericUpDown.Location = new System.Drawing.Point(328, 32);
			this.daysNumericUpDown.Name = "daysNumericUpDown";
			this.daysNumericUpDown.Size = new System.Drawing.Size(48, 20);
			this.daysNumericUpDown.TabIndex = 11;
			this.daysNumericUpDown.Value = new System.Decimal(new int[] {
																			3,
																			0,
																			0,
																			0});
			// 
			// minutesNumericUpDown
			// 
			this.minutesNumericUpDown.Location = new System.Drawing.Point(328, 80);
			this.minutesNumericUpDown.Maximum = new System.Decimal(new int[] {
																				 60,
																				 0,
																				 0,
																				 0});
			this.minutesNumericUpDown.Name = "minutesNumericUpDown";
			this.minutesNumericUpDown.Size = new System.Drawing.Size(48, 20);
			this.minutesNumericUpDown.TabIndex = 15;
			// 
			// hoursNumericUpDown
			// 
			this.hoursNumericUpDown.Location = new System.Drawing.Point(328, 56);
			this.hoursNumericUpDown.Maximum = new System.Decimal(new int[] {
																			   24,
																			   0,
																			   0,
																			   0});
			this.hoursNumericUpDown.Name = "hoursNumericUpDown";
			this.hoursNumericUpDown.Size = new System.Drawing.Size(48, 20);
			this.hoursNumericUpDown.TabIndex = 13;
			// 
			// secondsNumericUpDown
			// 
			this.secondsNumericUpDown.Location = new System.Drawing.Point(328, 104);
			this.secondsNumericUpDown.Maximum = new System.Decimal(new int[] {
																				 60,
																				 0,
																				 0,
																				 0});
			this.secondsNumericUpDown.Name = "secondsNumericUpDown";
			this.secondsNumericUpDown.Size = new System.Drawing.Size(48, 20);
			this.secondsNumericUpDown.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(280, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 24);
			this.label5.TabIndex = 10;
			this.label5.Text = "&Days:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(280, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 24);
			this.label6.TabIndex = 12;
			this.label6.Text = "&Hours:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(280, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 24);
			this.label7.TabIndex = 14;
			this.label7.Text = "&Mins:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(280, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 24);
			this.label8.TabIndex = 16;
			this.label8.Text = "&Secs";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Location = new System.Drawing.Point(256, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(280, 144);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Check Criteria";
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(8, 16);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(120, 120);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Time before now";
			// 
			// cancelScanButton
			// 
			this.cancelScanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelScanButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cancelScanButton.Location = new System.Drawing.Point(280, 400);
			this.cancelScanButton.Name = "cancelScanButton";
			this.cancelScanButton.Size = new System.Drawing.Size(80, 24);
			this.cancelScanButton.TabIndex = 3;
			this.cancelScanButton.Text = "Cancel";
			this.cancelScanButton.Visible = false;
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 432);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(544, 22);
			this.statusBar1.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 152);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(136, 24);
			this.label9.TabIndex = 8;
			this.label9.Text = "I&gnore Dirs with substring:";
			// 
			// ignoreTextBox
			// 
			this.ignoreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.ignoreTextBox.Location = new System.Drawing.Point(136, 152);
			this.ignoreTextBox.Name = "ignoreTextBox";
			this.ignoreTextBox.Size = new System.Drawing.Size(280, 20);
			this.ignoreTextBox.TabIndex = 9;
			this.ignoreTextBox.Text = "";
			// 
			// aboutButton
			// 
			this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.aboutButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.aboutButton.Location = new System.Drawing.Point(8, 400);
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(48, 24);
			this.aboutButton.TabIndex = 21;
			this.aboutButton.Text = "a&bout...";
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// checkDirectoriesCheckbox
			// 
			this.checkDirectoriesCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkDirectoriesCheckbox.Location = new System.Drawing.Point(424, 152);
			this.checkDirectoriesCheckbox.Name = "checkDirectoriesCheckbox";
			this.checkDirectoriesCheckbox.Size = new System.Drawing.Size(120, 24);
			this.checkDirectoriesCheckbox.TabIndex = 10;
			this.checkDirectoriesCheckbox.Text = "Chec&k directories";
			// 
			// FTPClearer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(544, 454);
			this.Controls.Add(this.checkDirectoriesCheckbox);
			this.Controls.Add(this.ignoreTextBox);
			this.Controls.Add(this.serverTextBox);
			this.Controls.Add(this.userNameTextBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.daysNumericUpDown);
			this.Controls.Add(this.predefinedComboBox);
			this.Controls.Add(this.scanButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ftpDirTreeView);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.minutesNumericUpDown);
			this.Controls.Add(this.hoursNumericUpDown);
			this.Controls.Add(this.secondsNumericUpDown);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.cancelScanButton);
			this.Controls.Add(this.aboutButton);
			this.MinimumSize = new System.Drawing.Size(552, 300);
			this.Name = "FTPClearer";
			this.Text = "Ftp Clearer";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.secondsNumericUpDown)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
            Application.DoEvents();
			Application.Run(new FTPClearer());
		}

        private void scanButton_Click(object sender, System.EventArgs e)
        {
            this.ftpDirTreeView.Nodes.Clear();
            this.Cursor = Cursors.WaitCursor;
            try
            {
                SetStatusBarText("Connecting to ftp server...");
                ftpClient = new FTPClient(this.serverTextBox.Text.Trim(),
                    21);
                ftpClient.Login(this.userNameTextBox.Text.Trim(),
                    this.passwordTextBox.Text.Trim());
            }
            catch(Exception except)
            {
                MessageBox.Show(this, "Error! "+except.Message+"\r\n"+except.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                return;
            }

            SetStatusBarText("Connected to ftp server");

            SetStatusBarText("Reading ftp root ...");
            string[] rootFiles;
            try
            {
                rootFiles = this.ftpClient.Dir(".", true);
            }
            catch(Exception except)
            {
                MessageBox.Show(this, "Error! "+except.Message+"\r\n"+except.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                return;
            }
            SetStatusBarText("Finished reading ftp root");
            if (rootFiles.Length == 0)
            {
                return;
            }
            /*if (rootFiles[0].ToUpper().IndexOf("<DIR>") >= 0)
            {
                this.isUnixFtpSite = false;
            }
            */
            ftpServerType = FtpServerType.Dunno;
            
            if (this.ignoreTextBox.Text.Trim().Length > 0)
            {
                this.ignoreSubstrings = this.ignoreTextBox.Text.Split(new char[]{',', ';'});
            }
            else
            {
                this.ignoreSubstrings = null;
            }

            rootNode = new TreeNode(this.serverTextBox.Text.Trim());
            rootNode.ImageIndex = rootNode.SelectedImageIndex = 2;
            this.ftpDirTreeView.Click += new EventHandler(ftpDirTreeView_Click);
            
            this.ftpDirTreeView.Nodes.Add(rootNode);
            try
            {
                ScanDirs(rootFiles, rootNode);
            }
            catch(Exception except)
            {
                //MessageBox.Show(this, "Error! "+except.Message+"\r\n"+except.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ScanningError(except);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.ftpDirTreeView.ExpandAll();
                //this.ftpClient.Quit();
                this.ftpClient = null;
            }
        }

        private void ScanDirs(string[] files, TreeNode currentNode)
        {
            SetStatusBarText("Scanning directory "+currentNode.FullPath);
            foreach(string oneFile in files)
            {
                ServerFileData sfd = null;

                //
                if (this.ftpServerType == FtpServerType.Dunno)
                {
                    sfd = ParseUnixDirLine(oneFile);
                    if (sfd != null)
                    {
                        this.ftpServerType = FtpServerType.Unix;
                    }
                    else
                    {
                        sfd = ParseDosDirLine(oneFile);
                        if (sfd != null)
                        {
                            this.ftpServerType = FtpServerType.Windows;
                        }
                        else
                        {
                            MessageBox.Show(this, "Unable to define the ftp server type!!", "Unknown server type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else if (this.ftpServerType == FtpServerType.Unix)
                {
                    sfd = ParseUnixDirLine(oneFile);
                }
                else if (this.ftpServerType == FtpServerType.Windows)
                {
                    sfd = ParseDosDirLine(oneFile);
                }

                //

                /*if (isUnixFtpSite)
                {
                    sfd = ParseUnixDirLine(oneFile);
                }
                else
                {
                    sfd = ParseDosDirLine(oneFile);
                }
                */
                if (sfd == null)
                {
                    continue;
                }
                if (!sfd.isDirectory)
                {
                    TreeNode fileNode = new TreeNode(sfd.fileName); // +" ["+sfd.size+","+sfd.date+"]");
                    fileNode.ImageIndex = fileNode.SelectedImageIndex = 0;
                    fileNode.Tag = sfd;
                    
                    currentNode.Nodes.Add(fileNode);
                    DateTime fileDate = ParseDateTime(sfd.date); 

                    if (fileDate.CompareTo(DateTime.Now.Subtract(new TimeSpan((int)this.daysNumericUpDown.Value, (int)this.hoursNumericUpDown.Value, (int)this.minutesNumericUpDown.Value, (int)this.secondsNumericUpDown.Value))) < 0)
                    {
                        fileNode.Checked = true;

                        //Trial code
                        TimeSpan ts = DateTime.Now - fileDate;
                        if (ts.TotalDays < 5)
                        {
                            fileNode.ForeColor = Color.YellowGreen;
                        }
                        else if (ts.TotalDays < 8)
                        {
                            fileNode.ForeColor = Color.Orange;
                        }
                        else
                        {
                            fileNode.ForeColor = Color.Red;
                        }
                    
                        //Trial code
                    }
                }
                else
                {
                    TreeNode dirNode = new TreeNode(sfd.fileName); //  +" ["+sfd.size+","+sfd.date+"]");
                    if (this.checkDirectoriesCheckbox.Checked)
                    {
                        DateTime dirDate = ParseDateTime(sfd.date);;//DateTime.Parse(sfd.date);
                        if (dirDate.CompareTo(DateTime.Now.Subtract(new TimeSpan((int)this.daysNumericUpDown.Value, (int)this.hoursNumericUpDown.Value, (int)this.minutesNumericUpDown.Value, (int)this.secondsNumericUpDown.Value))) < 0)
                        {
                            dirNode.Checked = true;

                            TimeSpan ts = DateTime.Now - dirDate;
                            if (ts.TotalDays < 5)
                            {
                                dirNode.ForeColor = Color.YellowGreen;
                            }
                            else if (ts.TotalDays < 8)
                            {
                                dirNode.ForeColor = Color.Orange;
                            }
                            else
                            {
                                dirNode.ForeColor = Color.Red;
                            }
                        }
                    }
                    //dirNode.Tag = "dir";
                    dirNode.Tag = sfd;
                    dirNode.SelectedImageIndex = dirNode.ImageIndex = 1;
                    currentNode.Nodes.Add(dirNode);
                    
                    bool shouldIgnore = false;
                    if (this.ignoreSubstrings != null)
                    {
                        foreach(string s in this.ignoreSubstrings)
                        {
                            if (sfd.fileName.ToUpper().IndexOf(s.Trim().ToUpper()) >= 0)
                            {
                                shouldIgnore = true;
                                break;
                            }
                        }
                    }
                    if (!shouldIgnore)
                    {
                        this.ftpClient.Chdir(sfd.fileName);
                        ScanDirs(this.ftpClient.Dir(".", true), dirNode);
                        this.ftpClient.Chdir("..");
                    }
                }
                this.ftpDirTreeView.ExpandAll();
                this.ftpDirTreeView.Update();
            }
            SetStatusBarText("Finished scanning directory "+currentNode.FullPath);
        }

        private void ScanningError(Exception except)
        {
            DialogResult result = MessageBox.Show(this, "Error! "+except.Message+"\r\n"+except.StackTrace+"\r\n\r\nDo you want to scan again?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                this.scanButton_Click(null, null);
            }
            else
            {
                return;
            }
        }

        private ServerFileData ParseDosDirLine(string line)
        {
            ServerFileData sfd = new ServerFileData();

            try 
            {
                string[] parsed = new string[3];
                int index = 0;
                int position = 0;

                position  = line.IndexOf(' ');
                while (index<parsed.Length) 
                {
                    parsed[index] = line.Substring(0, position);
                    line = line.Substring(position);
                    line = line.Trim();
                    index++;
                    position  = line.IndexOf(' ');
                }
                sfd.fileName   = line;  
          
                if (parsed[2] != "<DIR>")
                    sfd.size       = Convert.ToInt32(parsed[2]);

                sfd.date       = parsed[0]+ ' ' + parsed[1];
                sfd.isDirectory = parsed[2] == "<DIR>";
            }
            catch 
            {
                sfd  = null;
            }
            
            return sfd;
        }

        private ServerFileData ParseUnixDirLine(string line)
        {
            ServerFileData  sfd = new ServerFileData();

            try 
            {
                string[] parsed = new string [8];
                int index = 0;
                int position;
        
                // Parse out the elements
                position  = line.IndexOf(' ');
                while (index<parsed.Length) 
                {
                    parsed[index] = line.Substring(0, position);
                    line = line.Substring(position);
                    line = line.Trim();
                    index++;
                    position  = line.IndexOf(' ');
                }
                sfd.fileName   = line;  
          
                sfd.permission = parsed[0];
                sfd.owner      = parsed[2];
                sfd.group      = parsed[3];
                sfd.size       = Convert.ToInt32(parsed[4]);
                sfd.date       = parsed[5]+ ' ' + parsed[6] + ' ' + parsed[7];
                sfd.isDirectory = sfd.permission[0] == 'd';
            }
            catch 
            {
                sfd  = null;
            }
            return sfd;
        }

        private void ReadOptions()
        {
            this.ftpConfigList.Clear();
            XPathDocument xpDoc = new XPathDocument(Application.StartupPath + "\\options.xml");
            XPathNavigator nav = xpDoc.CreateNavigator();
            XPathNodeIterator iterator = nav.Select("options/ftpConfig");
            while (iterator.MoveNext())
            {
                FtpConfig ftpConfig = new FtpConfig();
                string name = "";
                XPathNodeIterator nameIterator = iterator.Current.Select("name");
                if (!nameIterator.MoveNext())
                {
                    continue;
                }
                name = nameIterator.Current.Value;

                XPathNodeIterator serverIterator = iterator.Current.Select("server");
                if (!serverIterator.MoveNext())
                {
                    continue;
                }
                ftpConfig.Server = serverIterator.Current.Value;

                XPathNodeIterator userIterator = iterator.Current.Select("user");
                if (!userIterator.MoveNext())
                {
                    continue;
                }
                ftpConfig.User = userIterator.Current.Value;

                XPathNodeIterator passwordIterator = iterator.Current.Select("password");
                if (passwordIterator.MoveNext())
                {
                    ftpConfig.Password = passwordIterator.Current.Value;                  }
                
                this.ftpConfigList.Add(name, ftpConfig);
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            try
            {
                this.ReadOptions();
            }
            catch(Exception except)
            {
                MessageBox.Show("Error reading options.\r\n"+except.Message);
            }
            if (this.ftpConfigList.Keys.Count == 0)
            {
                this.predefinedComboBox.Enabled = false;
                return;
            }
            string[] ftpConfigs = new string[this.ftpConfigList.Keys.Count];
            this.ftpConfigList.Keys.CopyTo(ftpConfigs, 0);
            this.predefinedComboBox.Items.AddRange(ftpConfigs);
            this.predefinedComboBox.SelectedIndex = 0;
        }

        private void predefinedComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            FtpConfig ftpConfig = (FtpConfig)this.ftpConfigList[this.predefinedComboBox.Text];
            this.serverTextBox.Text = ftpConfig.Server;
            this.userNameTextBox.Text = ftpConfig.User;
            this.passwordTextBox.Text = ftpConfig.Password;
        }

        /*public void AddTreeNode(TreeNode parentNode, TreeNode childNode)
        {
            this.ftpDirTreeView.Update();
        }*/

        public void SetStatusBarText(string text)
        {
            this.statusBar1.Text = text;
            this.statusBar1.Update();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                SetStatusBarText("Connecting to ftp server...");
                ftpClient = new FTPClient(this.serverTextBox.Text.Trim(),
                    21);
                ftpClient.Login(this.userNameTextBox.Text.Trim(),
                    this.passwordTextBox.Text.Trim());
            }
            catch(Exception except)
            {
                MessageBox.Show(this, "Error! "+except.Message+"\r\n"+except.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                return;
            }

            SetStatusBarText("Connected to ftp server");

            try
            {
                DeleteNodes(this.ftpDirTreeView.Nodes);
            }
            catch(Exception except)
            {
                MessageBox.Show(this, "Error! "+except.Message+"\r\n"+except.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                return;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            
        }

        private void DeleteNodes(TreeNodeCollection nodes)
        {
            foreach(TreeNode oneNode in nodes)
            {
                if (oneNode.Checked)
                {
                    //if (oneNode.Tag!=null && oneNode.Tag.ToString().ToLower().Equals("dir"))
                    if (oneNode.Tag!=null && ((ServerFileData)oneNode.Tag).isDirectory)
                    {
                        //this.ftpClient.Rmdir(oneNode.FullPath.Remove(0, (this.serverTextBox.Text.Trim()+"/").Length));
                        RemoveDir(oneNode.FullPath.Remove(0, (this.serverTextBox.Text.Trim()+"/").Length));
                    }
                    else
                    {
                        this.ftpClient.Delete(oneNode.FullPath.Remove(0, (this.serverTextBox.Text.Trim()+"/").Length));
                    }
                    oneNode.Nodes.Clear();
                    //oneNode.Remove();      
                }
                else
                {
                    if (oneNode.Nodes.Count > 0)
                    {
                        DeleteNodes(oneNode.Nodes);
                    }
                }
            }
            if (nodes.Count > 0)
            {
                for (int i=nodes.Count-1; i>=0; i--)
                {
                    if (nodes[i].Checked)
                    {
                        nodes[i].Remove();
                    }
                }
            }
            
        }

        private void RemoveDir(string dirPath)
        {
            string[] filesInDir = this.ftpClient.Dir(dirPath, true);
            foreach(string oneFile in filesInDir)
            {
                ServerFileData sfd = null;
                /*if (isUnixFtpSite)
                {
                    sfd = ParseUnixDirLine(oneFile);
                }
                else
                {
                    sfd = ParseDosDirLine(oneFile);
                }
                */
                if (this.ftpServerType == FtpServerType.Unix)
                {
                    sfd = ParseUnixDirLine(oneFile);
                }
                else if (this.ftpServerType == FtpServerType.Windows)
                {
                    sfd = ParseDosDirLine(oneFile);
                }

                if (sfd == null)
                {
                    continue;
                }
                if (!sfd.isDirectory)
                {
                    this.ftpClient.Delete(dirPath+"/"+sfd.fileName);
                }
                else
                {
                    RemoveDir(dirPath+"/"+sfd.fileName);
                }
            }
            this.ftpClient.Rmdir(dirPath);
        }

        private void aboutButton_Click(object sender, System.EventArgs e)
        {
            AboutDialog ad = new AboutDialog();
            ad.ShowDialog();
        }

        private DateTime ParseDateTime(string dateString)
        {
            //dateString = "2004 "+dateString;
            //if (this.isUnixFtpSite)
            if (this.ftpServerType == FtpServerType.Unix)
            {
                //DateTime.Par  May 20  5:08
                string[] dateParts = dateString.Split(new char[]{' '});
                if (dateParts[1].Length == 1)
                {
                    dateParts[1] = "0"+dateParts[1];
                }
                if (dateParts[2].Length == 4)
                {
                    dateParts[2] = "0"+dateParts[2];
                }
                string fullDate = "";
                foreach(string s in dateParts)
                {
                    fullDate += s;
                }
                return DateTime.ParseExact(fullDate, "MMMddHH:mm", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            }
            else
            {
                return DateTime.Parse(dateString);
            }
        }

        private void ftpDirTreeView_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            TreeNode hoverNode = this.ftpDirTreeView.GetNodeAt(e.X, e.Y);

            if (hoverNode == null || hoverNode.Tag == null || !(hoverNode.Tag is ServerFileData))
            {
                this.toolTip.SetToolTip(this.ftpDirTreeView, "");                
                return;
            }
            
            ServerFileData sfd = (ServerFileData)hoverNode.Tag;
            string toolTipText = "Date = "+sfd.date+"\r\n"+"Size = "+ sfd.size.ToString("###,###,###,###,##0");
            this.toolTip.SetToolTip(this.ftpDirTreeView, toolTipText);
        }
        private void ftpDirTreeView_Click(Object sender, EventArgs e)
        {
            //do not allow user to check the server node
            if (this.rootNode.Checked)
            {
                this.rootNode.Checked = false;
            }
        }

        private void checkAllMenuItem_Click(object sender, System.EventArgs e)
        {
            CheckTreeNodes(this.rootNode.Nodes, true);
        }

        private void UncheckAllMenuItem_Click(object sender, System.EventArgs e)
        {
            CheckTreeNodes(this.rootNode.Nodes, false);
        }

        private void CheckTreeNodes(TreeNodeCollection treeNodes, bool check)
        {
            foreach(TreeNode node in treeNodes)
            {
                node.Checked = check;
                if (node.Nodes.Count > 0)
                {
                    CheckTreeNodes(node.Nodes, check);
                }
            }
        }
	}
}
