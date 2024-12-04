using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FTPExplorer
{
	/// <summary>
	/// Summary description for FTPConnectDlg.
	/// </summary>
	public class FTPConnectDlg : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox m_tbFTPServer;
		private System.Windows.Forms.TextBox m_tbUserID;
		private System.Windows.Forms.TextBox m_tbPassword;
		private System.Windows.Forms.Button m_bnOK;
		private System.Windows.Forms.Button m_bnCancel;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components;

		public FTPProperties m_FTPProperties;

		public string FTPServer {
			get { return m_tbFTPServer.Text; }
		}

		public string UserID {
			get { return m_tbUserID.Text; }
		}

		public string Password {
			get { return m_tbPassword.Text; }
		}
		
		public FTPConnectDlg(FTPProperties l_ftpProperties)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			m_FTPProperties = l_ftpProperties;
			m_tbFTPServer.Text = m_FTPProperties.FTPServer;
			m_tbUserID.Text = m_FTPProperties.UserID;
			m_tbPassword.Text = m_FTPProperties.Password;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.m_bnOK = new System.Windows.Forms.Button();
			this.m_tbPassword = new System.Windows.Forms.TextBox();
			this.m_bnCancel = new System.Windows.Forms.Button();
			this.m_tbFTPServer = new System.Windows.Forms.TextBox();
			this.m_tbUserID = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_bnOK
			// 
			this.m_bnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_bnOK.Location = new System.Drawing.Point(209, 101);
			this.m_bnOK.Name = "m_bnOK";
			this.m_bnOK.TabIndex = 3;
			this.m_bnOK.Text = "&OK";
			this.toolTip1.SetToolTip(this.m_bnOK, "Closes this window and saves changes that you have made");
			this.m_bnOK.Click += new System.EventHandler(this.OnClickOK);
			// 
			// m_tbPassword
			// 
			this.m_tbPassword.Location = new System.Drawing.Point(122, 71);
			this.m_tbPassword.MaxLength = 30;
			this.m_tbPassword.Name = "m_tbPassword";
			this.m_tbPassword.PasswordChar = '*';
			this.m_tbPassword.Size = new System.Drawing.Size(107, 20);
			this.m_tbPassword.TabIndex = 2;
			this.m_tbPassword.Text = "";
			this.toolTip1.SetToolTip(this.m_tbPassword, "Enter FTP Password");
			// 
			// m_bnCancel
			// 
			this.m_bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_bnCancel.Location = new System.Drawing.Point(47, 101);
			this.m_bnCancel.Name = "m_bnCancel";
			this.m_bnCancel.TabIndex = 5;
			this.m_bnCancel.Text = "&Cancel";
			this.toolTip1.SetToolTip(this.m_bnCancel, "Closes this window and discards any changes that you have made");
			this.m_bnCancel.Click += new System.EventHandler(this.OnClickCancel);
			// 
			// m_tbFTPServer
			// 
			this.m_tbFTPServer.Location = new System.Drawing.Point(122, 20);
			this.m_tbFTPServer.MaxLength = 50;
			this.m_tbFTPServer.Name = "m_tbFTPServer";
			this.m_tbFTPServer.Size = new System.Drawing.Size(160, 20);
			this.m_tbFTPServer.TabIndex = 0;
			this.m_tbFTPServer.Text = "";
			this.toolTip1.SetToolTip(this.m_tbFTPServer, "Enter FTP Server IP Address or Name");
			// 
			// m_tbUserID
			// 
			this.m_tbUserID.Location = new System.Drawing.Point(122, 45);
			this.m_tbUserID.MaxLength = 30;
			this.m_tbUserID.Name = "m_tbUserID";
			this.m_tbUserID.Size = new System.Drawing.Size(108, 20);
			this.m_tbUserID.TabIndex = 1;
			this.m_tbUserID.Text = "";
			this.toolTip1.SetToolTip(this.m_tbUserID, "Enter FTP User ID");
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(129, 101);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "Co&nfigure";
			this.toolTip1.SetToolTip(this.button1, "Click here to configure advanced options");
			this.button1.Click += new System.EventHandler(this.OnClickConfigure);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "User ID : ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(21, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "Password : ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "FTP Server : ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FTPConnectDlg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(295, 132);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.m_bnCancel,
																		  this.m_bnOK,
																		  this.m_tbPassword,
																		  this.m_tbUserID,
																		  this.m_tbFTPServer,
																		  this.label3,
																		  this.label2,
																		  this.label1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FTPConnectDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FTP Explorer - Connect";
			this.ResumeLayout(false);

		}
		#endregion

		private void OnClickOK(object sender, System.EventArgs e) {
			string l_strServer = m_tbFTPServer.Text;
			l_strServer.Trim();
			if (l_strServer.Length == 0 ){
				m_tbFTPServer.Focus();
				return;
			}

			string l_strUserID = m_tbUserID.Text;
			l_strUserID.Trim();
			if ( l_strUserID.Length == 0 ){
				m_tbUserID.Focus();
				return;
			}

			string l_strPassword = m_tbPassword.Text;
			if ( l_strPassword.Length == 0 ){
				m_tbPassword.Focus();
				return;
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void OnClickCancel(object sender, System.EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void OnClickConfigure(object sender, System.EventArgs e) {
			FTPConfigureDlg configureDlg = new FTPConfigureDlg(true,m_FTPProperties);
			configureDlg.ShowDialog();
		}
	}
}
