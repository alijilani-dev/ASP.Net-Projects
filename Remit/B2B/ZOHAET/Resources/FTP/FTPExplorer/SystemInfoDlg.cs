/*	Project		:	FTPExplorer
 *  Version		:	2.0
 *	File Name	:	SystemInfoDlg.cs
 *	Purpose		:	Shows Local System Information Dialog
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
	using System.Net;

    /// <summary>
    ///    Summary description for SystemInfo.
    /// </summary>
    public class SystemInfoDlg : System.WinForms.Form
    {
        /// <summary>
        ///    Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components;
		private System.WinForms.Label m_labelServerInfo;
		private System.WinForms.GroupBox groupBox2;
		private System.WinForms.GroupBox groupBox1;
		private System.WinForms.PictureBox pictureBox1;
		private System.WinForms.Label m_labelIPAddress;
		private System.WinForms.Label label7;
		private System.WinForms.Label m_labelMachineName;
		private System.WinForms.Label label5;
		private System.WinForms.Button m_bnClose;
		private System.WinForms.Label m_labelDomain;
		private System.WinForms.Label label3;
		private System.WinForms.Label m_labelUserID;
		private System.WinForms.Label label1;

		public string m_strServerInfo;
        public SystemInfoDlg(string l_strServerInfo)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
			m_strServerInfo = l_strServerInfo;
			PopulateSystemInfo();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager (typeof(SystemInfoDlg));
			this.components = new System.ComponentModel.Container ();
			this.label7 = new System.WinForms.Label ();
			this.m_bnClose = new System.WinForms.Button ();
			this.label5 = new System.WinForms.Label ();
			this.groupBox1 = new System.WinForms.GroupBox ();
			this.label3 = new System.WinForms.Label ();
			this.m_labelMachineName = new System.WinForms.Label ();
			this.label1 = new System.WinForms.Label ();
			this.m_labelIPAddress = new System.WinForms.Label ();
			this.m_labelServerInfo = new System.WinForms.Label ();
			this.groupBox2 = new System.WinForms.GroupBox ();
			this.m_labelDomain = new System.WinForms.Label ();
			this.pictureBox1 = new System.WinForms.PictureBox ();
			this.m_labelUserID = new System.WinForms.Label ();
			//@this.TrayHeight = 0;
			//@this.TrayLargeIcon = false;
			//@this.TrayAutoArrange = true;
			label7.Location = new System.Drawing.Point (53, 101);
			label7.Text = "Local IP Address :";
			label7.Size = new System.Drawing.Size (97, 16);
			label7.TabIndex = 7;
			label7.TextAlign = System.WinForms.HorizontalAlignment.Right;
			m_bnClose.Location = new System.Drawing.Point (216, 218);
			m_bnClose.Size = new System.Drawing.Size (75, 23);
			m_bnClose.TabIndex = 4;
			m_bnClose.Text = "&Close";
			m_bnClose.Click += new System.EventHandler (this.OnClickClose);
			label5.Location = new System.Drawing.Point (35, 77);
			label5.Text = "Local Machine Name :";
			label5.Size = new System.Drawing.Size (116, 16);
			label5.TabIndex = 5;
			label5.TextAlign = System.WinForms.HorizontalAlignment.Right;
			groupBox1.Location = new System.Drawing.Point (7, 5);
			groupBox1.TabIndex = 10;
			groupBox1.TabStop = false;
			groupBox1.Text = "Client Info :";
			groupBox1.Size = new System.Drawing.Size (282, 128);
			label3.Location = new System.Drawing.Point (69, 52);
			label3.Text = "Logon Domain :";
			label3.Size = new System.Drawing.Size (82, 14);
			label3.TabIndex = 2;
			label3.TextAlign = System.WinForms.HorizontalAlignment.Right;
			m_labelMachineName.Location = new System.Drawing.Point (157, 75);
			m_labelMachineName.Size = new System.Drawing.Size (116, 17);
			m_labelMachineName.BorderStyle = System.WinForms.BorderStyle.Fixed3D;
			m_labelMachineName.TabIndex = 6;
			label1.Location = new System.Drawing.Point (62, 25);
			label1.Text = "Logon User ID :";
			label1.Size = new System.Drawing.Size (89, 18);
			label1.TabIndex = 0;
			label1.TextAlign = System.WinForms.HorizontalAlignment.Right;
			m_labelIPAddress.Location = new System.Drawing.Point (157, 99);
			m_labelIPAddress.Size = new System.Drawing.Size (97, 17);
			m_labelIPAddress.BorderStyle = System.WinForms.BorderStyle.Fixed3D;
			m_labelIPAddress.TabIndex = 8;
			m_labelServerInfo.Location = new System.Drawing.Point (13, 21);
			m_labelServerInfo.Size = new System.Drawing.Size (256, 35);
			m_labelServerInfo.BorderStyle = System.WinForms.BorderStyle.Fixed3D;
			m_labelServerInfo.TabIndex = 12;
			groupBox2.Location = new System.Drawing.Point (6, 138);
			groupBox2.TabIndex = 11;
			groupBox2.TabStop = false;
			groupBox2.Text = "Server Info :";
			groupBox2.Size = new System.Drawing.Size (283, 71);
			m_labelDomain.Location = new System.Drawing.Point (157, 50);
			m_labelDomain.Size = new System.Drawing.Size (116, 17);
			m_labelDomain.BorderStyle = System.WinForms.BorderStyle.Fixed3D;
			m_labelDomain.TabIndex = 3;
			pictureBox1.Location = new System.Drawing.Point (19, 23);
			pictureBox1.Size = new System.Drawing.Size (43, 43);
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
			pictureBox1.Image = (System.Drawing.Image) resources.GetObject ("pictureBox1.Image");
			m_labelUserID.Location = new System.Drawing.Point (157, 24);
			m_labelUserID.Size = new System.Drawing.Size (85, 17);
			m_labelUserID.BorderStyle = System.WinForms.BorderStyle.Fixed3D;
			m_labelUserID.TabIndex = 1;
			this.Text = "System Information";
			this.MaximizeBox = false;
			this.StartPosition = System.WinForms.FormStartPosition.CenterScreen;
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.BorderStyle = System.WinForms.FormBorderStyle.FixedDialog;
			this.ShowInTaskbar = false;
			this.Icon = (System.Drawing.Icon) resources.GetObject ("$this.Icon");
			this.MinimizeBox = false;
			this.ClientSize = new System.Drawing.Size (301, 251);
			groupBox2.Controls.Add (this.m_labelServerInfo);
			this.Controls.Add (this.groupBox2);
			this.Controls.Add (this.pictureBox1);
			this.Controls.Add (this.m_labelIPAddress);
			this.Controls.Add (this.label7);
			this.Controls.Add (this.m_labelMachineName);
			this.Controls.Add (this.label5);
			this.Controls.Add (this.m_bnClose);
			this.Controls.Add (this.m_labelDomain);
			this.Controls.Add (this.label3);
			this.Controls.Add (this.m_labelUserID);
			this.Controls.Add (this.label1);
			this.Controls.Add (this.groupBox1);
		}

		protected void OnClickClose (object sender, System.EventArgs e)
		{
			this.Close();
		}

		protected void PopulateSystemInfo(){
			string l_strLogonUser = Environment.GetEnvironmentVariable("USERNAME");
			string l_strLogonDomain = Environment.GetEnvironmentVariable("USERDOMAIN");
			string l_strComputerName = DNS.GetHostName();
			IPAddress l_IPAddress = DNS.Resolve(l_strComputerName);
			string l_strIPAddress = l_IPAddress.ToString();

			m_labelIPAddress.Text = l_strIPAddress;
			m_labelUserID.Text = l_strLogonUser;
			m_labelDomain.Text = l_strLogonDomain;
			m_labelMachineName.Text = l_strComputerName;
			
			m_labelServerInfo.Text = m_strServerInfo;
			return ;
		}

    }
}

