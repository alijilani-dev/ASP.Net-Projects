/*	Project		:	FTPExplorer
 *  Version		:	2.0
 *	File Name	:	AboutDlg.cs
 *	Purpose		:	About Window and Version information
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
    ///    Summary description for AboutDlg.
    /// </summary>
    public class AboutDlg : System.WinForms.Form
    {
        /// <summary>
        ///    Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components;
		private System.WinForms.Label label6;
		private System.WinForms.Label label5;
		private System.WinForms.Label label4;
		private System.WinForms.Label label3;
		private System.WinForms.GroupBox groupBox1;
		private System.WinForms.LinkLabel m_linkLabelWebsite;
		private System.WinForms.Label label2;
		private System.WinForms.ToolTip m_toolTip;
		private System.WinForms.LinkLabel m_linkLabelEMail;
		private System.WinForms.Label label1;
		private System.WinForms.Button m_bnClose;
		private System.WinForms.PictureBox m_pictureBoxLogo;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager (typeof(AboutDlg));
			this.components = new System.ComponentModel.Container ();
			this.groupBox1 = new System.WinForms.GroupBox ();
			this.m_bnClose = new System.WinForms.Button ();
			this.label6 = new System.WinForms.Label ();
			this.label2 = new System.WinForms.Label ();
			this.label1 = new System.WinForms.Label ();
			this.label5 = new System.WinForms.Label ();
			this.m_linkLabelWebsite = new System.WinForms.LinkLabel ();
			this.m_linkLabelEMail = new System.WinForms.LinkLabel ();
			this.m_toolTip = new System.WinForms.ToolTip (this.components);
			this.label4 = new System.WinForms.Label ();
			this.label3 = new System.WinForms.Label ();
			this.m_pictureBoxLogo = new System.WinForms.PictureBox ();
			//@this.TrayHeight = 90;
			//@this.TrayLargeIcon = false;
			//@this.TrayAutoArrange = true;
			groupBox1.Location = new System.Drawing.Point (2, 114);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Size = new System.Drawing.Size (440, 7);
			m_bnClose.Location = new System.Drawing.Point (361, 250);
			m_bnClose.Size = new System.Drawing.Size (75, 23);
			m_bnClose.TabIndex = 1;
			m_bnClose.Text = "&Close";
			m_bnClose.Click += new System.EventHandler (this.OnClickClose);
			label6.Location = new System.Drawing.Point (185, 200);
			label6.Text = "Developed for Windows and Unix based FTP Servers. Tested against Windows NT 5.0, IBM-AIX and Sun Solaris FTP services.";
			label6.Size = new System.Drawing.Size (245, 40);
			label6.TabIndex = 10;
			label2.Location = new System.Drawing.Point (100, 154);
			label2.Text = "Web Site :";
			label2.Size = new System.Drawing.Size (75, 15);
			label2.TabIndex = 4;
			label2.TextAlign = System.WinForms.HorizontalAlignment.Right;
			label1.Location = new System.Drawing.Point (19, 134);
			label1.Text = "Designed and Developed by :";
			label1.Size = new System.Drawing.Size (156, 16);
			label1.TabIndex = 2;
			label1.TextAlign = System.WinForms.HorizontalAlignment.Right;
			label5.Location = new System.Drawing.Point (64, 200);
			label5.Text = "More Information :";
			label5.Size = new System.Drawing.Size (112, 13);
			label5.TabIndex = 9;
			label5.TextAlign = System.WinForms.HorizontalAlignment.Right;
			m_linkLabelWebsite.Text = "Cognizant Technology Solutions Ltd.";
			m_linkLabelWebsite.Size = new System.Drawing.Size (194, 19);
			m_toolTip.SetToolTip (m_linkLabelWebsite, "www.cognizant.com");
			m_linkLabelWebsite.TabIndex = 5;
			m_linkLabelWebsite.TabStop = true;
			m_linkLabelWebsite.Location = new System.Drawing.Point (185, 155);
			m_linkLabelWebsite.LinkClicked += new System.WinForms.LinkLabelLinkClickedEventHandler (this.OnClickWebsite);
			m_linkLabelEMail.Text = "Niranjan Kumar. K";
			m_linkLabelEMail.Size = new System.Drawing.Size (100, 17);
			m_toolTip.SetToolTip (m_linkLabelEMail, "KNiranja@chn.cognizant.com");
			m_linkLabelEMail.TabIndex = 3;
			m_linkLabelEMail.TabStop = true;
			m_linkLabelEMail.Location = new System.Drawing.Point (185, 133);
			m_linkLabelEMail.BackColor = System.Drawing.SystemColors.Control;
			m_linkLabelEMail.LinkClicked += new System.WinForms.LinkLabelLinkClickedEventHandler (this.OnClickEmail);
			//@m_toolTip.SetLocation (new System.Drawing.Point (7, 7));
			m_toolTip.Active = true;
			label4.Location = new System.Drawing.Point (114, 177);
			label4.Text = "Version :";
			label4.Size = new System.Drawing.Size (61, 13);
			label4.TabIndex = 8;
			label4.TextAlign = System.WinForms.HorizontalAlignment.Right;
			label3.Location = new System.Drawing.Point (185, 178);
			label3.Text = "2.0";
			label3.Size = new System.Drawing.Size (49, 17);
			label3.TabIndex = 7;
			m_pictureBoxLogo.Cursor = System.Drawing.Cursors.Hand;
			m_toolTip.SetToolTip (m_pictureBoxLogo, "Where do you want to go today?");
			m_pictureBoxLogo.Size = new System.Drawing.Size (453, 114);
			m_pictureBoxLogo.TabIndex = 0;
			m_pictureBoxLogo.TabStop = false;
			m_pictureBoxLogo.Image = (System.Drawing.Image) resources.GetObject ("m_pictureBoxLogo.Image");
			m_pictureBoxLogo.Click += new System.EventHandler (this.OnClickPictureBoxLogo);
			this.Text = "About FTP Explorer Version 2.0";
			this.MaximizeBox = false;
			this.StartPosition = System.WinForms.FormStartPosition.CenterScreen;
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.BorderStyle = System.WinForms.FormBorderStyle.FixedDialog;
			this.ShowInTaskbar = false;
			this.Icon = (System.Drawing.Icon) resources.GetObject ("$this.Icon");
			this.MinimizeBox = false;
			this.ClientSize = new System.Drawing.Size (445, 283);
			this.Controls.Add (this.label6);
			this.Controls.Add (this.label5);
			this.Controls.Add (this.label4);
			this.Controls.Add (this.label3);
			this.Controls.Add (this.groupBox1);
			this.Controls.Add (this.m_linkLabelWebsite);
			this.Controls.Add (this.label2);
			this.Controls.Add (this.m_linkLabelEMail);
			this.Controls.Add (this.label1);
			this.Controls.Add (this.m_bnClose);
			this.Controls.Add (this.m_pictureBoxLogo);
		}

		protected void OnClickClose (object sender, System.EventArgs e)
		{
			this.Close();
		}

		protected void OnClickPictureBoxLogo (object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("http://msdn.microsoft.com/net");
		}

		protected void OnClickWebsite (object sender, System.WinForms.LinkLabelLinkClickedEventArgs e)
		{
			m_linkLabelWebsite.LinkVisited = true;
			System.Diagnostics.Process.Start("http://www.cognizant.com");
		}

		protected void OnClickEmail (object sender, System.WinForms.LinkLabelLinkClickedEventArgs e)
		{
			m_linkLabelWebsite.LinkVisited = true;
			System.Diagnostics.Process.Start("mailto:KNiranja@chn.cognizant.com");
		}
    }
}
