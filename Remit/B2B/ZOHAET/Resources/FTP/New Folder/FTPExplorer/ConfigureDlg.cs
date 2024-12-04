/*	Project		:	FTPExplorer
 *  Version		:	2.0 
 *	File Name	:	ConfigureDlg.cs
 *	Purpose		:	Server and Client configuration dialog
 *	Author		:	K.Niranjan Kumar
 *	Date		:	July 08,2001
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

    /// <summary>
    ///    Summary description for ConfigureDlg.
    /// </summary>
    public class ConfigureDlg : System.WinForms.Form
    {
        /// <summary>
        ///    Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components;
		private System.WinForms.TextBox m_ebNewPath;
		private System.WinForms.Label label8;
		private System.WinForms.Label label7;
		private System.WinForms.Label label6;
		private System.WinForms.Label m_labelNewPath;
		private System.WinForms.OpenFileDialog m_openFileDialog;
		private System.WinForms.Button m_bnBrowse;
		private System.WinForms.Label m_labelCurrentPath;
		private System.WinForms.Label label5;
		private System.WinForms.Label label4;
		private System.WinForms.ImageList m_imageListConfigure;
		private System.WinForms.ComboBox m_cbMode;
		private System.WinForms.Button m_bnCancel;
		private System.WinForms.Button m_bnOK;
		private System.WinForms.NumericUpDown m_spnRecv;
		private System.WinForms.Label label3;
		private System.WinForms.NumericUpDown m_spnSend;
		private System.WinForms.Label label2;
		private System.WinForms.GroupBox groupBox1;
		private System.WinForms.Label label1;
		private System.WinForms.TabPage m_tabPageClient;
		private System.WinForms.ToolTip m_toolTip;
		private System.WinForms.TabPage m_tabPageServer;
		private System.WinForms.TabControl tabControl1;

		/*	Server Properties */
		public char m_chTransferMode;
		public int m_iSendTimeout;
		public int m_iRecvTimeout;
		
		/*	Client Properties */
		public string m_strClientPath;

        public ConfigureDlg()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
			m_chTransferMode = 'A';
			m_iSendTimeout = 1000;
			m_iRecvTimeout = 3000;
			m_cbMode.Items.Clear();
			m_cbMode.Items.Insert(0,"Ascii");
			/*	Binary mode of transfer not supported currently	*/
			//m_cbMode.Items.Insert(1,"Binary");

			/*	By default Select Ascii	*/
			m_cbMode.SelectedIndex = 0;
			InitSpinControls();
			m_strClientPath = "";
		}

		/*	Overloaded constructor */
		public ConfigureDlg(char l_iTransferMode,int l_iSendTimeout,int l_iRecvTimeout,string l_strLocalPath)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
			m_chTransferMode = l_iTransferMode;
			m_iSendTimeout = l_iSendTimeout;
			m_iRecvTimeout = l_iRecvTimeout;
			m_cbMode.Items.Clear();
			m_cbMode.Items.Insert(0,"Ascii");
			m_cbMode.Items.Insert(1,"Binary");

			/*	Select the appropriate Option */
			if ( l_iTransferMode == 'A' ) {
				m_cbMode.SelectedIndex = 0;
			}
			else {
				m_cbMode.SelectedIndex = 1;
			}

			InitSpinControls();
			m_strClientPath = l_strLocalPath;
			m_labelCurrentPath.Text = m_strClientPath;
			m_ebNewPath.Text = m_strClientPath;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager (typeof(ConfigureDlg));
			this.components = new System.ComponentModel.Container ();
			this.m_ebNewPath = new System.WinForms.TextBox ();
			this.m_cbMode = new System.WinForms.ComboBox ();
			this.m_tabPageServer = new System.WinForms.TabPage ();
			this.m_labelCurrentPath = new System.WinForms.Label ();
			this.groupBox1 = new System.WinForms.GroupBox ();
			this.label4 = new System.WinForms.Label ();
			this.m_labelNewPath = new System.WinForms.Label ();
			this.m_bnCancel = new System.WinForms.Button ();
			this.m_toolTip = new System.WinForms.ToolTip (this.components);
			this.tabControl1 = new System.WinForms.TabControl ();
			this.m_openFileDialog = new System.WinForms.OpenFileDialog ();
			this.m_bnBrowse = new System.WinForms.Button ();
			this.label6 = new System.WinForms.Label ();
			this.label7 = new System.WinForms.Label ();
			this.label1 = new System.WinForms.Label ();
			this.label8 = new System.WinForms.Label ();
			this.m_tabPageClient = new System.WinForms.TabPage ();
			this.label5 = new System.WinForms.Label ();
			this.m_spnRecv = new System.WinForms.NumericUpDown ();
			this.m_spnSend = new System.WinForms.NumericUpDown ();
			this.label3 = new System.WinForms.Label ();
			this.label2 = new System.WinForms.Label ();
			this.m_imageListConfigure = new System.WinForms.ImageList ();
			this.m_bnOK = new System.WinForms.Button ();
			m_spnRecv.BeginInit ();
			m_spnSend.BeginInit ();
			//@this.TrayHeight = 90;
			//@this.TrayLargeIcon = false;
			//@this.TrayAutoArrange = true;
			m_ebNewPath.Location = new System.Drawing.Point (101, 85);
			m_toolTip.SetToolTip (m_ebNewPath, "Enter a valid exising path of your local machine");
			m_ebNewPath.TabIndex = 1;
			m_ebNewPath.Size = new System.Drawing.Size (189, 20);
			m_cbMode.Location = new System.Drawing.Point (127, 14);
			m_cbMode.Size = new System.Drawing.Size (99, 21);
			m_cbMode.Style = System.WinForms.ComboBoxStyle.DropDownList;
			m_toolTip.SetToolTip (m_cbMode, "Specify mode of data transfer, default is Ascii");
			m_cbMode.TabIndex = 1;
			m_tabPageServer.Text = "Server";
			m_tabPageServer.Size = new System.Drawing.Size (300, 155);
			m_tabPageServer.ImageIndex = 0;
			m_tabPageServer.TabIndex = 0;
			m_labelCurrentPath.Location = new System.Drawing.Point (101, 51);
			m_labelCurrentPath.Size = new System.Drawing.Size (191, 19);
			m_labelCurrentPath.BorderStyle = System.WinForms.BorderStyle.Fixed3D;
			m_labelCurrentPath.TabIndex = 2;
			groupBox1.Location = new System.Drawing.Point (13, 48);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Time Out";
			groupBox1.Size = new System.Drawing.Size (273, 84);
			label4.Location = new System.Drawing.Point (10, 16);
			label4.Text = "Select Local folder for file transfers";
			label4.Size = new System.Drawing.Size (178, 15);
			label4.TabIndex = 0;
			m_labelNewPath.Location = new System.Drawing.Point (97, 124);
			m_labelNewPath.Size = new System.Drawing.Size (191, 21);
			m_labelNewPath.BorderStyle = System.WinForms.BorderStyle.Fixed3D;
			m_labelNewPath.TabIndex = 4;
			m_labelNewPath.Visible = false;
			m_bnCancel.Location = new System.Drawing.Point (165, 212);
			m_toolTip.SetToolTip (m_bnCancel, "Discards your changes and closes this window");
			m_bnCancel.DialogResult = System.WinForms.DialogResult.Cancel;
			m_bnCancel.Size = new System.Drawing.Size (75, 23);
			m_bnCancel.TabIndex = 2;
			m_bnCancel.Text = "&Cancel";
			m_bnCancel.Click += new System.EventHandler (this.OnClickCancel);
			//@m_toolTip.SetLocation (new System.Drawing.Point (7, 7));
			m_toolTip.Active = true;
			tabControl1.Location = new System.Drawing.Point (10, 20);
			tabControl1.Size = new System.Drawing.Size (308, 182);
			tabControl1.SelectedIndex = 0;
			tabControl1.ImageList = this.m_imageListConfigure;
			tabControl1.TabIndex = 0;
			//@m_openFileDialog.SetLocation (new System.Drawing.Point (243, 7));
			m_openFileDialog.Title = "Select Local Path";
			m_openFileDialog.RestoreDirectory = true;
			m_bnBrowse.Visible = false;
			m_bnBrowse.Location = new System.Drawing.Point (12, 123);
			m_bnBrowse.Size = new System.Drawing.Size (77, 23);
			m_bnBrowse.TabIndex = 3;
			m_bnBrowse.Text = "&Select Path";
			m_bnBrowse.Click += new System.EventHandler (this.OnClickSelectPath);
			label6.Location = new System.Drawing.Point (179, 22);
			label6.Text = "in milli secs";
			label6.Size = new System.Drawing.Size (59, 17);
			label6.TabIndex = 3;
			label7.Location = new System.Drawing.Point (179, 53);
			label7.Text = "in milli secs";
			label7.Size = new System.Drawing.Size (62, 14);
			label7.TabIndex = 5;
			label1.Location = new System.Drawing.Point (32, 17);
			label1.Text = "Transfer Mode :";
			label1.Size = new System.Drawing.Size (86, 16);
			label1.TabIndex = 0;
			label1.TextAlign = System.WinForms.HorizontalAlignment.Right;
			label8.Location = new System.Drawing.Point (19, 88);
			label8.Text = "Enter Path :";
			label8.Size = new System.Drawing.Size (78, 16);
			label8.TabIndex = 5;
			label8.TextAlign = System.WinForms.HorizontalAlignment.Right;
			m_tabPageClient.Text = "Client";
			m_tabPageClient.Size = new System.Drawing.Size (300, 155);
			m_tabPageClient.ImageIndex = 1;
			m_tabPageClient.TabIndex = 1;
			label5.Location = new System.Drawing.Point (20, 52);
			label5.Text = "Current Path :";
			label5.Size = new System.Drawing.Size (77, 17);
			label5.TabIndex = 1;
			label5.TextAlign = System.WinForms.HorizontalAlignment.Right;
			m_spnRecv.Location = new System.Drawing.Point (101, 51);
			m_spnRecv.Size = new System.Drawing.Size (71, 20);
			m_toolTip.SetToolTip (m_spnRecv, "Specify data receive timeout in milli seconds");
			m_spnRecv.TabIndex = 1;
			m_spnSend.Location = new System.Drawing.Point (101, 20);
			m_spnSend.Size = new System.Drawing.Size (71, 20);
			m_toolTip.SetToolTip (m_spnSend, "Specify data send timeout in milli seconds");
			m_spnSend.TabIndex = 0;
			label3.Location = new System.Drawing.Point (13, 52);
			label3.Text = "Receive :";
			label3.Size = new System.Drawing.Size (74, 16);
			label3.TabIndex = 3;
			label3.TextAlign = System.WinForms.HorizontalAlignment.Right;
			label2.Location = new System.Drawing.Point (28, 22);
			label2.Text = "Send :";
			label2.Size = new System.Drawing.Size (60, 16);
			label2.TabIndex = 1;
			label2.TextAlign = System.WinForms.HorizontalAlignment.Right;
			//@m_imageListConfigure.SetLocation (new System.Drawing.Point (95, 7));
			m_imageListConfigure.ImageSize = new System.Drawing.Size (16, 16);
			m_imageListConfigure.ImageStream = (System.WinForms.ImageListStreamer) resources.GetObject ("m_imageListConfigure.ImageStream");
			m_imageListConfigure.ColorDepth = System.WinForms.ColorDepth.Depth8Bit;
			m_imageListConfigure.TransparentColor = System.Drawing.Color.Transparent;
			m_bnOK.Location = new System.Drawing.Point (245, 212);
			m_toolTip.SetToolTip (m_bnOK, "Saves any changes you have made and closes this window");
			m_bnOK.DialogResult = System.WinForms.DialogResult.OK;
			m_bnOK.Size = new System.Drawing.Size (75, 23);
			m_bnOK.TabIndex = 1;
			m_bnOK.Text = "&OK";
			m_bnOK.Click += new System.EventHandler (this.OnClickOK);
			this.Text = "Configure";
			this.MaximizeBox = false;
			this.StartPosition = System.WinForms.FormStartPosition.CenterScreen;
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.BorderStyle = System.WinForms.FormBorderStyle.FixedDialog;
			this.ShowInTaskbar = false;
			this.Icon = (System.Drawing.Icon) resources.GetObject ("$this.Icon");
			this.MinimizeBox = false;
			this.ClientSize = new System.Drawing.Size (334, 244);
			m_tabPageClient.Controls.Add (this.m_ebNewPath);
			m_tabPageClient.Controls.Add (this.label8);
			m_tabPageClient.Controls.Add (this.m_labelNewPath);
			m_tabPageClient.Controls.Add (this.m_bnBrowse);
			m_tabPageClient.Controls.Add (this.m_labelCurrentPath);
			m_tabPageClient.Controls.Add (this.label5);
			m_tabPageClient.Controls.Add (this.label4);
			this.Controls.Add (this.m_bnCancel);
			this.Controls.Add (this.m_bnOK);
			this.Controls.Add (this.tabControl1);
			groupBox1.Controls.Add (this.label7);
			groupBox1.Controls.Add (this.label6);
			groupBox1.Controls.Add (this.m_spnRecv);
			groupBox1.Controls.Add (this.label3);
			groupBox1.Controls.Add (this.m_spnSend);
			groupBox1.Controls.Add (this.label2);
			m_tabPageServer.Controls.Add (this.m_cbMode);
			m_tabPageServer.Controls.Add (this.label1);
			m_tabPageServer.Controls.Add (this.groupBox1);
			tabControl1.Controls.Add (this.m_tabPageServer);
			tabControl1.Controls.Add (this.m_tabPageClient);
			m_spnRecv.EndInit ();
			m_spnSend.EndInit ();
		}

		protected void OnClickSelectPath (object sender, System.EventArgs e)
		{
			m_openFileDialog.InitialDirectory = m_strClientPath;
			if ( m_openFileDialog.ShowDialog() == DialogResult.OK ){
			}
		}

		protected void OnClickCancel (object sender, System.EventArgs e)
		{
			this.Close();
		}

		protected void OnClickOK (object sender, System.EventArgs e)
		{
			int l_iSelectedMode = m_cbMode.SelectedIndex;
			if ( l_iSelectedMode == 0 ) {
				m_chTransferMode = 'A';
			}
			else {
				m_chTransferMode = 'B';
			}
			string l_strTemp = m_ebNewPath.Text;
			if ( l_strTemp != m_strClientPath ) {
				m_strClientPath = l_strTemp;
			}

			m_iSendTimeout = (int) m_spnSend.Value;
			m_iRecvTimeout = (int) m_spnRecv.Value;
		}

		private void InitSpinControls(){
			/*	Set Send Properties */
			m_spnSend.Minimum = 500;
			m_spnSend.Maximum = 10000;
			m_spnSend.Increment = 100;
			m_spnSend.Value = m_iSendTimeout;

			/*	Set Receive Properties */
			m_spnRecv.Minimum = 500;
			m_spnRecv.Maximum = 30000;
			m_spnRecv.Increment = 100;
			m_spnRecv.Value = m_iRecvTimeout;
		}

    }
}
