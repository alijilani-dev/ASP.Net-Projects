using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FTPExplorer
{
	/// <summary>
	/// Summary description for FTPConfigureDlg.
	/// </summary>
	public class FTPConfigureDlg : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button m_bnOK;
		private System.Windows.Forms.Button m_bnCancel;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ComboBox m_cBServerOS;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox m_tbFTPPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown m_nUDSendTimeOut;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown m_nUDRecvTimeOut;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton m_rBASCIIMode;
		private System.Windows.Forms.RadioButton m_rBBinaryMode;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.ComponentModel.IContainer components;

		public FTPProperties m_FTPProperties;

		public int FTPPort {
			get {
				try {
					int l_iPort = int.Parse(m_tbFTPPort.Text);
					return l_iPort;
				}
				catch ( Exception e ){
					return -1;
				}
			}
		}

		public int SendTimeOut {
			get {
				try {
					return (int) m_nUDSendTimeOut.Value;
				}
				catch ( Exception e){
					return -1;
				}
			}
		}

		public int RecvTimeOut {
			get {
				try {
					return (int) m_nUDRecvTimeOut.Value;
				}
				catch ( Exception e){
					return -1;
				}
			}
		}

		public FTPConfigureDlg(bool l_bStatus,FTPProperties l_FTPProperties)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			m_FTPProperties = l_FTPProperties;
			if ( l_bStatus == true ){
				m_tbFTPPort.Enabled = true;
				m_cBServerOS.SelectedIndex = 2;
			}
			else {
				m_tbFTPPort.Enabled = false;
				m_cBServerOS.Enabled = false;
			}

			m_rBASCIIMode.Checked = true;
			m_rBBinaryMode.Enabled = false;

			m_nUDSendTimeOut.Enabled = true;
			m_nUDRecvTimeOut.Enabled = true;

			m_tbFTPPort.Text = m_FTPProperties.Port.ToString();
			m_cBServerOS.SelectedIndex = m_FTPProperties.ServerTypeIndex;
			m_nUDSendTimeOut.Value = m_FTPProperties.SendTimeOut;
			m_nUDRecvTimeOut.Value = m_FTPProperties.RecvTimeOut;

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
			this.m_cBServerOS = new System.Windows.Forms.ComboBox();
			this.m_bnOK = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.m_tbFTPPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.m_nUDSendTimeOut = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.m_nUDRecvTimeOut = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.m_rBBinaryMode = new System.Windows.Forms.RadioButton();
			this.m_rBASCIIMode = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.m_bnCancel = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_nUDSendTimeOut)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_nUDRecvTimeOut)).BeginInit();
			this.tabPage1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_cBServerOS
			// 
			this.m_cBServerOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_cBServerOS.DropDownWidth = 142;
			this.m_cBServerOS.Items.AddRange(new object[] {
															  "Windows",
															  "Unix",
															  "Auto Detect"});
			this.m_cBServerOS.Location = new System.Drawing.Point(128, 18);
			this.m_cBServerOS.Name = "m_cBServerOS";
			this.m_cBServerOS.Size = new System.Drawing.Size(142, 22);
			this.m_cBServerOS.TabIndex = 0;
			this.toolTip1.SetToolTip(this.m_cBServerOS, "Select your FTP server OS");
			// 
			// m_bnOK
			// 
			this.m_bnOK.Location = new System.Drawing.Point(221, 145);
			this.m_bnOK.Name = "m_bnOK";
			this.m_bnOK.TabIndex = 4;
			this.m_bnOK.Text = "&OK";
			this.toolTip1.SetToolTip(this.m_bnOK, "Closes this window and saves changes that you have made");
			this.m_bnOK.Click += new System.EventHandler(this.OnClickOK);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.label1,
																				   this.m_tbFTPPort,
																				   this.label2,
																				   this.m_nUDSendTimeOut,
																				   this.label4,
																				   this.label3,
																				   this.m_nUDRecvTimeOut,
																				   this.label5});
			this.tabPage2.Location = new System.Drawing.Point(4, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(281, 117);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Advanced";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "FTP Port No : ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// m_tbFTPPort
			// 
			this.m_tbFTPPort.Location = new System.Drawing.Point(115, 12);
			this.m_tbFTPPort.Name = "m_tbFTPPort";
			this.m_tbFTPPort.Size = new System.Drawing.Size(49, 20);
			this.m_tbFTPPort.TabIndex = 1;
			this.m_tbFTPPort.Text = "";
			this.toolTip1.SetToolTip(this.m_tbFTPPort, "Enter FTP Port number");
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(19, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Send Time Out : ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// m_nUDSendTimeOut
			// 
			this.m_nUDSendTimeOut.Increment = new System.Decimal(new int[] {
																			   500,
																			   0,
																			   0,
																			   0});
			this.m_nUDSendTimeOut.Location = new System.Drawing.Point(115, 39);
			this.m_nUDSendTimeOut.Maximum = new System.Decimal(new int[] {
																			 60000,
																			 0,
																			 0,
																			 0});
			this.m_nUDSendTimeOut.Minimum = new System.Decimal(new int[] {
																			 1000,
																			 0,
																			 0,
																			 0});
			this.m_nUDSendTimeOut.Name = "m_nUDSendTimeOut";
			this.m_nUDSendTimeOut.Size = new System.Drawing.Size(52, 20);
			this.m_nUDSendTimeOut.TabIndex = 2;
			this.toolTip1.SetToolTip(this.m_nUDSendTimeOut, "Enter Timeout in milli seconds for socket write operations");
			this.m_nUDSendTimeOut.Value = new System.Decimal(new int[] {
																		   1000,
																		   0,
																		   0,
																		   0});
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(173, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "(in milli seconds)";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(18, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Recv Time Out : ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// m_nUDRecvTimeOut
			// 
			this.m_nUDRecvTimeOut.Increment = new System.Decimal(new int[] {
																			   500,
																			   0,
																			   0,
																			   0});
			this.m_nUDRecvTimeOut.Location = new System.Drawing.Point(115, 65);
			this.m_nUDRecvTimeOut.Maximum = new System.Decimal(new int[] {
																			 60000,
																			 0,
																			 0,
																			 0});
			this.m_nUDRecvTimeOut.Minimum = new System.Decimal(new int[] {
																			 2000,
																			 0,
																			 0,
																			 0});
			this.m_nUDRecvTimeOut.Name = "m_nUDRecvTimeOut";
			this.m_nUDRecvTimeOut.Size = new System.Drawing.Size(52, 20);
			this.m_nUDRecvTimeOut.TabIndex = 2;
			this.toolTip1.SetToolTip(this.m_nUDRecvTimeOut, "Enter Timeout in milli seconds for socket read operations");
			this.m_nUDRecvTimeOut.Value = new System.Decimal(new int[] {
																		   3000,
																		   0,
																		   0,
																		   0});
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(174, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 16);
			this.label5.TabIndex = 3;
			this.label5.Text = "(in milli seconds)";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(33, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "Server OS : ";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.m_rBBinaryMode,
																				   this.m_rBASCIIMode,
																				   this.label6,
																				   this.m_cBServerOS,
																				   this.groupBox1});
			this.tabPage1.Location = new System.Drawing.Point(4, 23);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(281, 98);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "General";
			// 
			// m_rBBinaryMode
			// 
			this.m_rBBinaryMode.Location = new System.Drawing.Point(144, 63);
			this.m_rBBinaryMode.Name = "m_rBBinaryMode";
			this.m_rBBinaryMode.Size = new System.Drawing.Size(67, 17);
			this.m_rBBinaryMode.TabIndex = 3;
			this.m_rBBinaryMode.Text = "Binary";
			this.toolTip1.SetToolTip(this.m_rBBinaryMode, "Data will be transfered in Binary mode");
			// 
			// m_rBASCIIMode
			// 
			this.m_rBASCIIMode.Location = new System.Drawing.Point(68, 66);
			this.m_rBASCIIMode.Name = "m_rBASCIIMode";
			this.m_rBASCIIMode.Size = new System.Drawing.Size(65, 12);
			this.m_rBASCIIMode.TabIndex = 2;
			this.m_rBASCIIMode.Text = "ASCII";
			this.toolTip1.SetToolTip(this.m_rBASCIIMode, "Data will be transfered in ASCII mode");
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(9, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(263, 34);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data Transfer Mode : ";
			// 
			// m_bnCancel
			// 
			this.m_bnCancel.Location = new System.Drawing.Point(141, 144);
			this.m_bnCancel.Name = "m_bnCancel";
			this.m_bnCancel.TabIndex = 5;
			this.m_bnCancel.Text = "&Cancel";
			this.toolTip1.SetToolTip(this.m_bnCancel, "Closes this window and discards any changes that you have made");
			this.m_bnCancel.Click += new System.EventHandler(this.OnClickCancel);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage1,
																					  this.tabPage2});
			this.tabControl1.Location = new System.Drawing.Point(8, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(289, 125);
			this.tabControl1.TabIndex = 6;
			// 
			// FTPConfigureDlg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(303, 177);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabControl1,
																		  this.m_bnCancel,
																		  this.m_bnOK});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FTPConfigureDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FTP Explorer - Configure";
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_nUDSendTimeOut)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_nUDRecvTimeOut)).EndInit();
			this.tabPage1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void OnClickOK(object sender, System.EventArgs e) {
			try {
				int l_iPort = int.Parse(m_tbFTPPort.Text);
				if ( l_iPort < 1 ){
					throw (new Exception("Invalid Port number entered. Enter a positive value"));
				}

				m_FTPProperties.ServerType = m_cBServerOS.SelectedText;
				m_FTPProperties.Port = l_iPort;
				m_FTPProperties.SendTimeOut = (int) m_nUDSendTimeOut.Value;
				m_FTPProperties.RecvTimeOut = (int) m_nUDRecvTimeOut.Value;

				if ( m_rBASCIIMode.Checked == true ){
					m_FTPProperties.TransferMode = 'A';
				}
				else {
					m_FTPProperties.TransferMode = 'B';
				}
				DialogResult = DialogResult.OK;
				Close();
			}
			catch ( Exception e1){
				MessageBox.Show(e1.Message,"Server Configuration - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				m_tbFTPPort.Focus();
			}
		}

		private void OnClickCancel(object sender, System.EventArgs e) {
			DialogResult = DialogResult.Cancel;
		}
	}
}
