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
using Evernet.MoneyExchange.BusinessLogic;

namespace Evernet.MoneyExchange.Admin {

	public class ViewTransactionStatus : System.Web.UI.Page {
		protected System.Web.UI.WebControls.TextBox txtStartDate;
		protected System.Web.UI.WebControls.Button butDisplay;
		protected System.Web.UI.WebControls.TextBox txtEndDate;
		protected System.Web.UI.WebControls.TextBox txtTransactionNumber;
		protected System.Web.UI.WebControls.Button butDisplayByTRNum;
		protected System.Web.UI.WebControls.DropDownList ddlStatus;
		protected System.Web.UI.WebControls.DataGrid dgrdTransactionList;
		protected bool canCancelWithoutRefund=false;
		protected bool canCancelWithRefund=false;
		protected bool canBlock=false;
		protected bool canUnBlock = false;
		protected int serialNo = 1;

		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
			if(!IsPostBack) {
				BindAll();
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
			this.butDisplay.Click += new System.EventHandler(this.butDisplay_Click);
			this.butDisplayByTRNum.Click += new System.EventHandler(this.butDisplayByTRNum_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		protected bool canChangeStatus(object currentStatus, string targetStatus) {
			return canChangeStatus(currentStatus.ToString(), targetStatus);
		}

		protected bool canChangeStatus(string currentStatus, string targetStatus) {
			bool canChange = false;

			if(currentStatus==targetStatus)
				return false;
			
			if(currentStatus!=TransactionStatus.Paid.ToString()
				&&
				currentStatus!=TransactionStatus.CancelledWithoutRefund.ToString()
				&&
				currentStatus!=TransactionStatus.CancelledWithRefund.ToString()) {
				switch(currentStatus) {
					case "AgentBlocked":
						goto case "AgencyBlocked";
					case "OFACBlocked":
						goto case "AgencyBlocked";
					case "AgencyBlocked":
						if(targetStatus==TransactionStatus.CancelledWithoutRefund.ToString()
							||
							targetStatus==TransactionStatus.CancelledWithRefund.ToString()
							||
							targetStatus==TransactionStatus.UnPaid.ToString()) {
							canChange=true;
						}
						break;

					case "PendingApproval":
						goto case "UnPaid";
					case "PendingPayOutApproval":
						goto case "UnPaid";
					case "UnPaid":
						canChange=true;
						break;
				}
			}
			return canChange;
		}

		private void BindAll() {
			BindDates();
			BindStatus();
		}

		private void BindDates() {
			////////////////////////////////// [Ali]07/07/2005 Code begins.
			txtStartDate.Text = DateTime.Today.ToString("dd MMM yyyy");//"19 Dec 2004";
			////////////////////////////////// [Ali] Code ends.
			txtEndDate.Text = DateTime.Today.ToString("dd MMM yyyy");
		}

		private void BindStatus() {
			string query = "Select * From TransactionStatusList Order by Name";

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			ddlStatus.DataSource = ds;
			ddlStatus.DataBind();

			ListItem li = new ListItem("[Show All]");
			ddlStatus.Items.Insert(0,li);
		}

		private void BindTransactionDetailsByDate() {
			DateTime startDate = DateTime.Parse("19 Dec 2004");
			DateTime endDate = DateTime.Today;

			try {
				startDate = DateTime.Parse(txtStartDate.Text);
			}catch{}

			try {
				endDate = DateTime.Parse(txtEndDate.Text);
			}catch{}
			endDate = endDate.AddDays(1);


			string query = string.Empty;

			if(ddlStatus.SelectedIndex==0) {
				query = "Select Id, TransactionNumber, Status, PayInDateTime From TransactionDetails Where PayInDateTime between '"+ startDate.ToString("dd MMM yyy") +"' And '"+ endDate.ToString("dd MMM yyyy") +"' Order by PayInDateTime";
			} else {
				query = "Select Id, TransactionNumber, Status, PayInDateTime From TransactionDetails Where PayInDateTime between '"+ startDate.ToString("dd MMM yyy") +"' And '"+ endDate.ToString("dd MMM yyyy") +"' And Status='"+ ddlStatus.SelectedValue +"' Order by PayInDateTime";
			}

			BindTransactionDetailsByQuery(query);
		}

		private void BindTransactionDetailsByNumber() {
			if(txtTransactionNumber.Text.Trim()!=string.Empty) {
				string query = "Select Id, TransactionNumber, Status, PayInDateTime From TransactionDetails Where TransactionNumber='"+ txtTransactionNumber.Text +"'";
				BindTransactionDetailsByQuery(query);
			}
		}

		private void BindTransactionDetailsByQuery(string query) {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);
			dgrdTransactionList.DataSource = ds;
			dgrdTransactionList.DataBind();
		}

		private void butDisplay_Click(object sender, System.EventArgs e) {
            BindTransactionDetailsByDate();
		}

		private void butDisplayByTRNum_Click(object sender, System.EventArgs e) {
			BindTransactionDetailsByNumber();
		}
	}
}
