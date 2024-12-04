using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Microsoft.ApplicationBlocks.Data;
using Evernet.Shared;

namespace Evernet.MoneyExchange.Admin {
	
	public class BankAvailablePaymentModeList : System.Web.UI.Page {
		protected System.Web.UI.WebControls.DataGrid dgrdList;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.Panel pnlAddEdit;
		protected System.Web.UI.WebControls.Button butAdd;
		protected System.Web.UI.WebControls.DropDownList ddlPaymentMode;
		protected System.Web.UI.WebControls.DropDownList ddlBankList;
		protected System.Web.UI.WebControls.HyperLink hlnkAddNew;

		private PageMode mode = PageMode.Add;
	
		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
			if(Request["Mode"]==null) {
				mode = PageMode.List;
			} else if(Request["Mode"]=="Add") {
				mode = PageMode.Add;
			} else if(Request["Mode"]=="Delete") {
				mode = PageMode.Delete;
			}

			if(!IsPostBack) {
				if(mode == PageMode.Add) {
					pnlAddEdit.Visible=true;
					BindBankList();
					BindPaymentModeList();
				} else if(mode == PageMode.Delete){
					DeleteAssociation(Request["Id"]);
					Response.Redirect("BankAvailablePaymentModeList.aspx");
				} else if(mode == PageMode.List) {
					BindGrid();
					pnlAddEdit.Visible=false;
				}
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e) {
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
		private void InitializeComponent() {    
			this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BindBankList() {
			string query = "Select Id, Name From BankList Order by Name";

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			ddlBankList.DataTextField = "Name";
			ddlBankList.DataValueField = "Id";

			ddlBankList.DataSource = ds;
			ddlBankList.DataBind();
		}

		private void BindPaymentModeList() {
			string query = "Select Name, Value from PaymentModeList Order by Name";

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			ddlPaymentMode.DataTextField = "Name";
			ddlPaymentMode.DataValueField = "Value";

			ddlPaymentMode.DataSource = ds;
			ddlPaymentMode.DataBind();
		}

		private void BindGrid() {
			string query = "Select bapml.Id, bl.Name as BankName, pml.Name as PaymentModeName From BankAvailablePaymentModeList bapml Join BankList bl on bapml.BankId = bl.Id Join PaymentModeList pml On bapml.PaymentMode = pml.Value Order by bl.Name";

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			dgrdList.DataSource = ds;
			dgrdList.DataBind();
		}

		private void DeleteAssociation(string assocId) {
			string query = "Delete From BankAvailablePaymentModeList Where Id='"+ assocId +"'";
			
			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
				query);
		}

		private void butAdd_Click(object sender, System.EventArgs e) {
			string query = "Insert Into BankAvailablePaymentModeList Values (newid(),'"+ ddlBankList.SelectedValue +"','"+ ddlPaymentMode.SelectedValue +"',1)";

			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			Response.Redirect("BankAvailablePaymentModeList.aspx");
		}
	}

	enum PageMode {
		List,
		Add,
		Delete
	}
}
