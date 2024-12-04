using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FTPExplorer
{
	/// <summary>
	/// Summary description for FTPNewFolderDlg.
	/// </summary>
	public class FTPNewFolderDlg : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox m_tBNewFolderName;
		private System.Windows.Forms.Button m_bnOK;
		private System.Windows.Forms.Button m_bnCancel;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.ComponentModel.IContainer components;

		private string m_strFolderName;
		public string NewFolder {
			get { return m_strFolderName;}
			set { m_strFolderName = value;}
		}

		public FTPNewFolderDlg()
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
			this.m_tBNewFolderName = new System.Windows.Forms.TextBox();
			this.m_bnOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.m_bnCancel = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// m_tBNewFolderName
			// 
			this.m_tBNewFolderName.Location = new System.Drawing.Point(114, 22);
			this.m_tBNewFolderName.MaxLength = 30;
			this.m_tBNewFolderName.Name = "m_tBNewFolderName";
			this.m_tBNewFolderName.Size = new System.Drawing.Size(157, 20);
			this.m_tBNewFolderName.TabIndex = 0;
			this.m_tBNewFolderName.Text = "";
			this.toolTip1.SetToolTip(this.m_tBNewFolderName, "Enter new folder name");
			// 
			// m_bnOK
			// 
			this.m_bnOK.Location = new System.Drawing.Point(196, 53);
			this.m_bnOK.Name = "m_bnOK";
			this.m_bnOK.TabIndex = 1;
			this.m_bnOK.Text = "&OK";
			this.toolTip1.SetToolTip(this.m_bnOK, "Closes this window and saves changes that you have made");
			this.m_bnOK.Click += new System.EventHandler(this.OnClickOK);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "New Folder Name : ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// m_bnCancel
			// 
			this.m_bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_bnCancel.Location = new System.Drawing.Point(116, 53);
			this.m_bnCancel.Name = "m_bnCancel";
			this.m_bnCancel.TabIndex = 2;
			this.m_bnCancel.Text = "&Cancel";
			this.toolTip1.SetToolTip(this.m_bnCancel, "Closes this window and discards any changes that you have made");
			this.m_bnCancel.Click += new System.EventHandler(this.OnClickCancel);
			// 
			// FTPNewFolderDlg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(279, 84);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.m_bnCancel,
																		  this.m_bnOK,
																		  this.m_tBNewFolderName,
																		  this.label1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FTPNewFolderDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FTP Explorer - New Folder";
			this.ResumeLayout(false);

		}
		#endregion

		private void OnClickOK(object sender, System.EventArgs e) {
			m_strFolderName = m_tBNewFolderName.Text;
			m_strFolderName.Trim();
			if ( m_strFolderName.Length > 0 ){
				string l_strSearch = ".\\/[]{}:;\"\'<>?,~!@#$%^&*()+=";
				int l_iRetval = m_strFolderName.IndexOfAny(l_strSearch.ToCharArray());
				/* If found, display error message */
				if ( l_iRetval != -1 ){
					MessageBox.Show("Entered Folder name is not valid. Please enter a valid Folder name","New Folder - Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
					m_tBNewFolderName.Focus();
					return;
				}
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else {
				MessageBox.Show("Entered Folder name is not valid. Please enter a valid Folder name","New Folder - Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
				m_tBNewFolderName.Text = "";
				m_tBNewFolderName.Focus();
			}
		}

		private void OnClickCancel(object sender, System.EventArgs e) {
			m_strFolderName = "";
			DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
