/*	Project		:	FTPExplorer
 *  Version		:	2.0
 *	File Name	:	ConnectDlg.cs
 *	Purpose		:	FTP Connection dialog
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
    ///    Summary description for ConnectDlg.
    /// </summary>
    public class ConnectDlg : System.WinForms.Form
    {
        /// <summary>
        ///    Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components;
		private System.WinForms.ToolTip m_toolTip;
		private System.WinForms.Button m_bnCancel;
		private System.WinForms.Button m_bnOK;
		private System.WinForms.PictureBox pictureBox1;
		private System.WinForms.TextBox m_ebPassword;
		private System.WinForms.TextBox m_ebUserID;
		private System.WinForms.TextBox m_ebFTPServer;
		private System.WinForms.Label label3;
		private System.WinForms.Label label2;
		private System.WinForms.Label label1;

		public string m_strFTPServer,m_strFTPUserID,m_strFTPPassword;
		public int m_iDataFlag;

		public ConnectDlg()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
			m_strFTPServer = "";
			m_strFTPUserID = "";
			m_strFTPPassword = "";
			m_iDataFlag = 0;
        }

		public ConnectDlg(string l_strFTPServer,string l_strFTPUser,string l_strFTPPassword)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
			m_strFTPServer = l_strFTPServer;
			m_strFTPUserID = l_strFTPUser;
			m_strFTPPassword = l_strFTPPassword;
			m_iDataFlag = 0;

			m_ebFTPServer.Text = m_strFTPServer;
			m_ebUserID.Text = m_strFTPUserID;
			m_ebPassword.Text = m_strFTPPassword;
			m_ebFTPServer.Focus();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager (typeof(ConnectDlg));
			this.components = new System.ComponentModel.Container ();
			this.m_bnCancel = new System.WinForms.Button ();
			this.pictureBox1 = new System.WinForms.PictureBox ();
			this.label1 = new System.WinForms.Label ();
			this.label3 = new System.WinForms.Label ();
			this.label2 = new System.WinForms.Label ();
			this.m_ebFTPServer = new System.WinForms.TextBox ();
			this.m_toolTip = new System.WinForms.ToolTip (this.components);
			this.m_bnOK = new System.WinForms.Button ();
			this.m_ebUserID = new System.WinForms.TextBox ();
			this.m_ebPassword = new System.WinForms.TextBox ();
			//@this.TrayHeight = 90;
			//@this.TrayLargeIcon = false;
			//@this.TrayAutoArrange = true;
			m_bnCancel.Location = new System.Drawing.Point (182, 104);
			m_toolTip.SetToolTip (m_bnCancel, "Cancel Connect Operation and close this window");
			m_bnCancel.Size = new System.Drawing.Size (75, 23);
			m_bnCancel.TabIndex = 8;
			m_bnCancel.Text = "&Cancel";
			m_bnCancel.Click += new System.EventHandler (this.OnClickCancel);
			pictureBox1.Location = new System.Drawing.Point (17, 42);
			pictureBox1.Size = new System.Drawing.Size (49, 49);
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			pictureBox1.Image = (System.Drawing.Image) resources.GetObject ("pictureBox1.Image");
			label1.Location = new System.Drawing.Point (68, 26);
			label1.Text = "FTP Server :";
			label1.Size = new System.Drawing.Size (77, 17);
			label1.TabIndex = 0;
			label1.TextAlign = System.WinForms.HorizontalAlignment.Right;
			label3.Location = new System.Drawing.Point (51, 78);
			label3.Text = "Password :";
			label3.Size = new System.Drawing.Size (94, 17);
			label3.TabIndex = 2;
			label3.TextAlign = System.WinForms.HorizontalAlignment.Right;
			label2.Location = new System.Drawing.Point (65, 53);
			label2.Text = "User ID :";
			label2.Size = new System.Drawing.Size (80, 15);
			label2.TabIndex = 1;
			label2.TextAlign = System.WinForms.HorizontalAlignment.Right;
			m_ebFTPServer.Location = new System.Drawing.Point (151, 23);
			m_toolTip.SetToolTip (m_ebFTPServer, "Enter FTP Server Name or IP Address");
			m_ebFTPServer.TabIndex = 3;
			m_ebFTPServer.Size = new System.Drawing.Size (188, 20);
			//@m_toolTip.SetLocation (new System.Drawing.Point (7, 7));
			m_toolTip.Active = true;
			m_bnOK.Location = new System.Drawing.Point (264, 104);
			m_toolTip.SetToolTip (m_bnOK, "Connect to FTP Server and close this window");
			m_bnOK.Size = new System.Drawing.Size (75, 23);
			m_bnOK.TabIndex = 7;
			m_bnOK.Text = "O&K";
			m_bnOK.Click += new System.EventHandler (this.OnClickOK);
			m_ebUserID.Location = new System.Drawing.Point (151, 50);
			m_toolTip.SetToolTip (m_ebUserID, "Enter FTP User ID");
			m_ebUserID.TabIndex = 4;
			m_ebUserID.Size = new System.Drawing.Size (120, 20);
			m_ebPassword.Location = new System.Drawing.Point (151, 77);
			m_ebPassword.PasswordChar = '*';
			m_toolTip.SetToolTip (m_ebPassword, "Enter FTP Password");
			m_ebPassword.TabIndex = 5;
			m_ebPassword.Size = new System.Drawing.Size (100, 20);
			this.Text = "Connect to FTP Server";
			this.MaximizeBox = false;
			this.StartPosition = System.WinForms.FormStartPosition.CenterScreen;
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.BorderStyle = System.WinForms.FormBorderStyle.FixedDialog;
			this.ShowInTaskbar = false;
			this.Icon = (System.Drawing.Icon) resources.GetObject ("$this.Icon");
			this.MinimizeBox = false;
			this.ClientSize = new System.Drawing.Size (347, 134);
			this.Controls.Add (this.m_bnCancel);
			this.Controls.Add (this.m_bnOK);
			this.Controls.Add (this.pictureBox1);
			this.Controls.Add (this.m_ebPassword);
			this.Controls.Add (this.m_ebUserID);
			this.Controls.Add (this.m_ebFTPServer);
			this.Controls.Add (this.label3);
			this.Controls.Add (this.label2);
			this.Controls.Add (this.label1);
		}

		protected void OnClickCancel (object sender, System.EventArgs e)
		{
			m_strFTPServer = "";
			m_strFTPUserID = "";
			m_strFTPPassword = "";
			m_iDataFlag = 0;
			this.Close();
		}

		protected void OnClickOK (object sender, System.EventArgs e)
		{
			m_strFTPServer = m_ebFTPServer.Text;
			if ( m_strFTPServer.Length == 0 ) {
				MessageBox.Show("FTP Server Address cannot be empty !!!","FTP Explorer - Connect",MessageBox.IconInformation);
				m_ebFTPServer.Focus();
				m_iDataFlag = 0;
				return;
			}
			m_strFTPUserID = m_ebUserID.Text; 
			if (m_strFTPUserID.Length == 0 ) {
				MessageBox.Show("FTP User ID cannot be empty !!!","FTP Explorer - Connect",MessageBox.IconInformation);
				m_ebUserID.Focus();
				m_strFTPServer = "";
				m_iDataFlag = 0;
				return;
			}
			m_strFTPPassword = m_ebPassword.Text;
			if ( m_strFTPPassword.Length == 0 ) {
				MessageBox.Show("Password cannot be empty !!!","FTP Explorer - Connect",MessageBox.IconInformation);
				m_ebPassword.Focus();
				m_strFTPServer = "";
				m_strFTPUserID = "";
				m_iDataFlag = 0;
				return;
			}
			m_iDataFlag = 1;
			this.Close();
		}
    }
}
