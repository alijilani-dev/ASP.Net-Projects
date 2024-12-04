using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace FTPExplorer
{
	/// <summary>
	/// Summary description for AboutDlg.
	/// </summary>
	public class AboutDlg : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button m_bnOK;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel m_lLName;
		private System.Windows.Forms.LinkLabel m_lLCompany;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.ComponentModel.IContainer components;

		public AboutDlg()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AboutDlg));
			this.m_bnOK = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.m_lLName = new System.Windows.Forms.LinkLabel();
			this.m_lLCompany = new System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_bnOK
			// 
			this.m_bnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_bnOK.Location = new System.Drawing.Point(359, 150);
			this.m_bnOK.Name = "m_bnOK";
			this.m_bnOK.TabIndex = 2;
			this.m_bnOK.Text = "&OK";
			// 
			// m_lLName
			// 
			this.m_lLName.Location = new System.Drawing.Point(276, 95);
			this.m_lLName.Name = "m_lLName";
			this.m_lLName.Size = new System.Drawing.Size(95, 19);
			this.m_lLName.TabIndex = 3;
			this.m_lLName.TabStop = true;
			this.m_lLName.Text = "Niranjan Kumar";
			this.toolTip1.SetToolTip(this.m_lLName, "KNiranja@chn.cognizant.com");
			this.m_lLName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClickedName);
			// 
			// m_lLCompany
			// 
			this.m_lLCompany.Location = new System.Drawing.Point(224, 122);
			this.m_lLCompany.Name = "m_lLCompany";
			this.m_lLCompany.Size = new System.Drawing.Size(164, 19);
			this.m_lLCompany.TabIndex = 3;
			this.m_lLCompany.TabStop = true;
			this.m_lLCompany.Text = "Cognizant Technology Solutions";
			this.toolTip1.SetToolTip(this.m_lLCompany, "www.cognizant.com");
			this.m_lLCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClickeCompany);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(440, 81);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(61, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(215, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "This product is designed and developed by ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(61, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Version 1.0. All rights Reserved.";
			// 
			// AboutDlg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(439, 180);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label2,
																		  this.m_lLCompany,
																		  this.m_lLName,
																		  this.m_bnOK,
																		  this.pictureBox1,
																		  this.label1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About FTP Explorer";
			this.ResumeLayout(false);

		}
		#endregion

		private void OnLinkClickedName(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
			Process.Start("mailto:KNiranja@chn.cognizant.com&subject=reg. FTP Explorer");
		}

		private void OnLinkClickeCompany(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
			Process.Start("http://www.cognizant.com");
		}
	}
}
