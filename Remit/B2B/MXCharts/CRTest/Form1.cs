using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;

namespace CRTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		//VoucherDetails crReportDocument;	// Report Object.
		//ADO.NET Variables
		//SqlConnection SqlConn;
		//SqlDataAdapter da_Vouchers;
		//DataSet ds_Vouchers;
		//DS_Report ds_Vouchers;
		private VouchersReport VouchersByMasterID;
		private CrystalReport1 crtesting;

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
			VouchersByMasterID = new VouchersReport();
			VouchersByMasterID.SetParameterValue("MasterID",1);
			//crystalReportViewer1.ReportSource = VouchersByMasterID;
			crtesting = new CrystalReport1();
			crtesting.SetParameterValue("MID",1);
			crystalReportViewer1.ReportSource = crtesting;
			//string connectionString= "Server=spr01; User Id=mexchange; Password=syncmaster591S;Initial Catalog=mexchange";
			//ds_Vouchers = new DataSet();//DS_Report();
			//SqlConn = new SqlConnection(connectionString);
			//string sqlString = string.Empty;
			//DataTable dt_Details = new DataTable("VoucherDetails");
			//DataTable dt_Master = new DataTable("VoucherMaster");
			//DataTable dt_AgentMaster = new DataTable("AgentMaster");
			
			//sqlString = "select vm.ID, vm.VoucherNumber, vm.VoucherDate, vm.ValueDate, vm.Narration , vd.DetailID, vd.AgentAccountID, vd.MasterID, vd.FC_Debit, vd.LC_Debit, vd.FC_Credit, vd.LC_Credit, vd.Rate, vd.Principal_Commision, am.Id, am.ParentId, am.Name, am.Number, am.Active " +
			//			"from VoucherMaster vm left outer join VoucherDetails vd on vd.MasterId = vm.id , AgentMaster am "+
			//			"where vd.AgentAccountId = am.Id";
			//da_Vouchers = new SqlDataAdapter(sqlString, SqlConn);
			//ds_Vouchers = new DS_Report();
			//da_Vouchers.Fill(ds_Vouchers,"Vouchers");

			/*sqlString = "Select DetailID, AgentAccountID, MasterID, FC_Debit, LC_Debit, FC_Credit, LC_Credit, Rate, Principal_Commision From VoucherDetails";
			da_Vouchers = new SqlDataAdapter(sqlString, SqlConn);
			ds_Vouchers = new DS_Report();
			da_Vouchers.Fill(dt_Details);//, "VoucherDetails");

			sqlString = "Select Id, ParentId, Name, Number, Active From AgentMaster";
			da_Vouchers = new SqlDataAdapter(sqlString, SqlConn);
			//ds_Vouchers = new DataSet();
			da_Vouchers.Fill(dt_AgentMaster);//, "AgentMaster");

			ds_Vouchers.Tables.Add(dt_Details);
			ds_Vouchers.Tables.Add(dt_Master);
			ds_Vouchers.Tables.Add(dt_AgentMaster);*/

			//Create an instance of the strongly-typed report object
			//crReportDocument = new VoucherDetails();

			//Pass the populated dataset to the report
			//crReportDocument.SetDataSource(ds_Vouchers);

			//Set the viewer to the report object to be previewed.
			//crystalReportViewer1.ReportSource = crReportDocument;
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
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = "D:\\MExchange\\MXCharts\\CRTest\\VouchersReport.rpt";
			this.crystalReportViewer1.Size = new System.Drawing.Size(1028, 746);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1028, 746);
			this.Controls.Add(this.crystalReportViewer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void crystalReportViewer1_Load(object sender, System.EventArgs e)
		{

		}
	}
}
