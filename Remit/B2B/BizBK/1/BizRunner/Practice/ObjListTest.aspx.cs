using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.Mobile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.MobileControls;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Microsoft.ApplicationBlocks.Data;

namespace BizRunner
{
	/// <summary>
	/// Summary description for ObjListTest.
	/// </summary>
	public class ObjListTest : System.Web.UI.MobileControls.MobilePage
	{
		protected System.Web.UI.MobileControls.ObjectList List1;
		protected System.Web.UI.MobileControls.Form Form1;
		protected System.Web.UI.MobileControls.Label ResLabel;
		protected System.Web.UI.MobileControls.Link ResLink;
		protected System.Web.UI.MobileControls.Form Form2;
		protected System.Web.UI.MobileControls.Label BuyLabel;
		protected System.Web.UI.MobileControls.Link BuyLink;
		protected System.Web.UI.MobileControls.Form Form3;
		protected System.Web.UI.MobileControls.Label DefLabel;
		protected System.Web.UI.MobileControls.Link DefLink;
		protected System.Data.DataSet dataSet1;
		protected System.Data.DataTable UserList;
		protected System.Data.DataColumn Id;
		protected System.Data.DataColumn Name;
		protected System.Web.UI.MobileControls.Form Form4;

		class GroceryItem
		{
			private String _department, _item, _status;

			public GroceryItem(string department, string item, string status)
			{ 
				_department = department;
				_item = item;
				_status = status;
			}

			public String Department { get { return _department; } }
			public String Item { get { return _item; } }
			public String Status { get { return _status; } }
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			if (!IsPostBack)
			{
				SqlConnection strBizRunConn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("MExchange.ConnectionString").GetValue(0));
				string strQuery = "Select Id, LoginName as Name From UserList";
				DataSet ds = SqlHelper.ExecuteDataset(strBizRunConn,
					CommandType.Text,
					strQuery);
				List1.DataSource = ds;
				List1.DataBind();
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.dataSet1 = new System.Data.DataSet();
			this.UserList = new System.Data.DataTable();
			this.Id = new System.Data.DataColumn();
			this.Name = new System.Data.DataColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UserList)).BeginInit();
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "dataSet1";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
																		  this.UserList});
			// 
			// UserList
			// 
			this.UserList.Columns.AddRange(new System.Data.DataColumn[] {
																			this.Id,
																			this.Name});
			this.UserList.Constraints.AddRange(new System.Data.Constraint[] {
																				new System.Data.UniqueConstraint("Constraint1", new string[] {
																																				 "Id"}, true)});
			this.UserList.PrimaryKey = new System.Data.DataColumn[] {
																		this.Id};
			this.UserList.TableName = "UserList";
			// 
			// Id
			// 
			this.Id.AllowDBNull = false;
			this.Id.Caption = "UserId";
			this.Id.ColumnName = "Id";
			this.Id.DataType = typeof(System.Guid);
			// 
			// Name
			// 
			this.Name.ColumnName = "Name";
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UserList)).EndInit();

		}
		#endregion
		public void List1_Click(Object sender, ObjectListCommandEventArgs e)
		{
			if (e.CommandName == "Reserve")
			{
				ActiveForm = Form2;
			}
			else if (e.CommandName == "Buy")
			{
				ActiveForm = Form3;
			}
			else
			{
				ActiveForm = Form4;
			}
		}



	}
}
