/*	Project		:	FTPExplorer
 *  Version		:	2.0
 *	File Name	:	CreateFolderDlg.cs
 *	Purpose		:	Create Folder Window
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

    /// <summary>
    ///    Summary description for CreateFolderDlg.
    /// </summary>
    public class CreateFolderDlg : System.WinForms.Form
    {
        /// <summary>
        ///    Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components;
		private System.WinForms.ToolTip m_toolTip;
		private System.WinForms.Button m_bnCancel;
		private System.WinForms.Button m_bnOK;
		private System.WinForms.TextBox m_tbFolderName;
		private System.WinForms.Label label1;

		public string m_strFolderName;
        public CreateFolderDlg()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
			m_strFolderName = "";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager (typeof(CreateFolderDlg));
			this.components = new System.ComponentModel.Container ();
			this.m_toolTip = new System.WinForms.ToolTip (this.components);
			this.m_tbFolderName = new System.WinForms.TextBox ();
			this.label1 = new System.WinForms.Label ();
			this.m_bnCancel = new System.WinForms.Button ();
			this.m_bnOK = new System.WinForms.Button ();
			//@this.TrayHeight = 90;
			//@this.TrayLargeIcon = false;
			//@this.TrayAutoArrange = true;
			//@m_toolTip.SetLocation (new System.Drawing.Point (7, 7));
			m_toolTip.Active = true;
			m_tbFolderName.Location = new System.Drawing.Point (101, 24);
			m_tbFolderName.MaxLength = 30;
			m_toolTip.SetToolTip (m_tbFolderName, "Enter name of folder you want to create in FTP server");
			m_tbFolderName.TabIndex = 1;
			m_tbFolderName.Size = new System.Drawing.Size (223, 20);
			label1.Location = new System.Drawing.Point (11, 27);
			label1.Text = "Folder Name :";
			label1.Size = new System.Drawing.Size (84, 14);
			label1.TabIndex = 0;
			label1.TextAlign = System.WinForms.HorizontalAlignment.Right;
			m_bnCancel.Location = new System.Drawing.Point (166, 55);
			m_toolTip.SetToolTip (m_bnCancel, "Discards any changes that you have made and closes this window");
			m_bnCancel.Size = new System.Drawing.Size (75, 23);
			m_bnCancel.TabIndex = 3;
			m_bnCancel.Text = "&Cancel";
			m_bnCancel.Click += new System.EventHandler (this.OnClickCancel);
			m_bnOK.Location = new System.Drawing.Point (250, 55);
			m_toolTip.SetToolTip (m_bnOK, "Saves changes that you have made and closes this window");
			m_bnOK.Size = new System.Drawing.Size (75, 23);
			m_bnOK.TabIndex = 2;
			m_bnOK.Text = "&OK";
			m_bnOK.Click += new System.EventHandler (this.OnClickOK);
			this.Text = "Create New Folder";
			this.MaximizeBox = false;
			this.StartPosition = System.WinForms.FormStartPosition.CenterScreen;
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.BorderStyle = System.WinForms.FormBorderStyle.FixedDialog;
			this.ShowInTaskbar = false;
			this.Icon = (System.Drawing.Icon) resources.GetObject ("$this.Icon");
			this.MinimizeBox = false;
			this.ClientSize = new System.Drawing.Size (337, 89);
			this.Controls.Add (this.m_bnCancel);
			this.Controls.Add (this.m_bnOK);
			this.Controls.Add (this.m_tbFolderName);
			this.Controls.Add (this.label1);
		}

		protected void OnClickCancel (object sender, System.EventArgs e)
		{
			m_strFolderName = "";
			this.Close();
		}

		protected void OnClickOK (object sender, System.EventArgs e)
		{
			m_strFolderName = m_tbFolderName.Text;
			m_strFolderName.Trim();
			if ( m_strFolderName.Length == 0 ) {
				MessageBox.Show("Folder Name cannot be empty","FTP Explorer - Create New Folder",MessageBox.IconInformation);
				m_tbFolderName.Focus();
				return;
			}
			int l_iRetval = m_strFolderName.IndexOf("\\",0,m_strFolderName.Length);
			if ( l_iRetval > 0 ) {
				MessageBox.Show("Directory name cannot contain back slash character","FTP Explorer - Create New Folder",MessageBox.IconError);
				m_tbFolderName.Text = "";
				m_tbFolderName.Focus();
				return;
			}

			l_iRetval = m_strFolderName.IndexOf("/",0,m_strFolderName.Length);
			if ( l_iRetval > 0 ) {
				MessageBox.Show("Directory name cannot contain slash character","FTP Explorer - Create New Folder",MessageBox.IconError);
				m_tbFolderName.Text = "";
				m_tbFolderName.Focus();
				return;
			}
			this.Close();
		}
    }
}
