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
	public class ViewSentTransactions : System.Web.UI.Page {
		protected System.Web.UI.WebControls.DropDownList ddlLoginNames;
		protected System.Web.UI.WebControls.TextBox txtStartDate;
		protected System.Web.UI.WebControls.TextBox txtEndDate;
		protected System.Web.UI.WebControls.Button butDisplay;
		protected System.Web.UI.WebControls.DropDownList ddlStatus;
		protected System.Web.UI.WebControls.Button btnReport;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.DataGrid dgrdDraftDetails;
		protected System.Web.UI.WebControls.DataGrid dgrdTransactionDetails;
		protected System.Web.UI.WebControls.Label lblCashOverCounter;
		protected System.Web.UI.WebControls.Label lblBankTransfer;
		protected System.Web.UI.WebControls.Label lblTotalCOC;
		protected System.Web.UI.WebControls.Label lblTotalBTs;
		public string urlToBeRediretedTo = String.Empty;

		private void Page_Load(object sender, System.EventArgs e) {
			if(!IsPostBack) 
			{
				SortExpression = "PayInDateTime";
				SortOrder = "ASC";
				txtStartDate.Text = DateTime.Today.ToString("dd MMM yyyy");
				txtEndDate.Text = DateTime.Today.ToString("dd MMM yyyy");
				BindLoginList();
				btnReport.Visible = false;
				urlToBeRediretedTo = "ShowReport.aspx?Type=ForSentTrans";
				urlToBeRediretedTo = Server.UrlEncode(urlToBeRediretedTo);
			}
		}

		protected bool canChangeStatus(object currentStatus, string targetStatus) 
		{
			return canChangeStatus(currentStatus.ToString(), targetStatus);
		}

		/// <summary>
		/// Used for changing Transaction Status.
		/// </summary>
		/// <param name="currentStatus"></param>
		/// <param name="targetStatus"></param>
		/// <returns></returns>
		protected bool canChangeStatus(string currentStatus, string targetStatus) 
		{
			bool canChange = false;
			Guid userId = new Guid(User.Identity.Name);

			if(currentStatus==targetStatus)
				return false;

			if(currentStatus!=TransactionStatus.Paid.ToString()
				&&
				currentStatus!=TransactionStatus.CancelledWithoutRefund.ToString()
				&&
				currentStatus!=TransactionStatus.CancelledWithRefund.ToString()) 
			{
				switch(currentStatus) 
				{
					case "AgentBlocked":
						goto case "AgencyBlocked";
					case "OFACBlocked":
						goto case "AgencyBlocked";
					case "AgencyBlocked":
						if(targetStatus==TransactionStatus.CancelledWithoutRefund.ToString()
							||
							targetStatus==TransactionStatus.CancelledWithRefund.ToString()
							||
							targetStatus==TransactionStatus.UnPaid.ToString())
						{
							canChange=true;
						}
						break;
					case "PendingApproval":
						if(targetStatus == TransactionStatus.UnPaid.ToString())
						{
							canChange = false;
						}
						else if(targetStatus == TransactionStatus.AgentBlocked.ToString())
						{
							canChange = true;
						}
						break;//goto case "UnPaid";
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
			BindLoginList();
			BindTransactionGrid();
		}

		private string SortExpression {
			get {
				return ViewState["SortExpression"].ToString();
			}

			set {
				ViewState["SortExpression"] = value;
			}
		}

		private string SortOrder {
			get {
				return ViewState["SortOrder"].ToString();
			}
			set {
				ViewState["SortOrder"]=value;
			}
		}

		private void BindLoginList() {

			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUser
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);

			aoUser.Refresh(new Guid(User.Identity.Name));

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select Id [ID1], LoginName [Display] From UserList Where AgentAccountId='"+ aoUser.Col_AgentAccountId.ToString() +"'");

			ddlLoginNames.DataSource = ds;
			ddlLoginNames.DataBind();

			if(!User.IsInRole(UserRoles.AgentAccountManager.ToString())) 
			{
				ListItem li = ddlLoginNames.Items.FindByValue(User.Identity.Name);

				if(li!=null) 
				{
					ddlLoginNames.SelectedIndex=-1;
					li.Selected=true;
				}
				
				ddlLoginNames.Enabled=false;
			}
			else
			{
				ddlLoginNames.Items.Insert(0,"All");
				//lblMessage.Text = ddlLoginNames.Items.FindByValue("All").Value;
			}
		}

		private void BindTransactionGrid() {
			ListItem li = ddlLoginNames.SelectedItem;

			if(li!=null) {
				DateTime startDate = DateTime.Parse(txtStartDate.Text);
				DateTime endDate = DateTime.Parse(txtEndDate.Text);
				//	////////////////////////////////////////////////////////
				String strQry = "Select Id, PayInAgentUserId_LoginName, TransactionNumber, PayInDateTime, CustomerId_FirstName + ' ' + CustomerId_LastName as Remitter, PayInAmount, PayOutAmount, PayOutCurrencyId_Code, Status_Name, Status_Value, Status From fnTransactionDetails_Full(Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null) Where ";
				
				if (!(li.Value == "All"))
					strQry += "PayInAgentUserId='"+ li.Value;
				else
				{
					Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUser
						= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);

					aoUser.Refresh(new Guid(User.Identity.Name));
					strQry += "PayInAgentLocationId='" + aoUser.Col_AgentId.Value;
				}

				strQry += "' And PayInDateTime Between '"+ txtStartDate.Text +"' And '"+ endDate.AddDays(1).ToString("dd MMM yyyy") +"' And Status Like '"+ ddlStatus.SelectedValue +"'";
				String strDryCOC = strQry + "And PaymentMode_Prefix =  'COC' Order by "+SortExpression+" " + SortOrder; 
				String strDryDTB = strQry + "And PaymentMode_Prefix <> 'COC' Order by "+SortExpression+" " + SortOrder;
				
				DataSet dsCOC = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					strDryCOC );
				
				DataSet dsDTB = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					strDryDTB );
				// Rebuild the query for report.
				strQry = String.Empty;
				strQry = "Select PayInAgentUserId_LoginName, TransactionNumber, PayInDateTime, CustomerId_FirstName + ' ' + CustomerId_LastName as Remitter, PayInAmount, PayOutAmount, PayOutCurrencyId_Code, Status_Name From fnTransactionDetails_Full(Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null) Where ";
				
				if (!(li.Value == "All"))
					strQry += "PayInAgentUserId='"+ li.Value;
				else
				{
					Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUser
						= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);

					aoUser.Refresh(new Guid(User.Identity.Name));
					strQry += "PayInAgentLocationId='" + aoUser.Col_AgentId.Value;
				}
				
				strQry += "' And PayInDateTime Between '"+ txtStartDate.Text +"' And '"+ endDate.AddDays(1).ToString("dd MMM yyyy") +"' And Status Like '"+ ddlStatus.SelectedValue +"'";
				strDryCOC = strQry + "And PaymentMode_Prefix =  'COC' Order by "+SortExpression+" " + SortOrder;
				strDryDTB = strQry + "And PaymentMode_Prefix <> 'COC' Order by "+SortExpression+" " + SortOrder;

				//"Select * From fnTransactionDetails_Full(Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null) Where PayInAgentUserId='"+ li.Value +"' And PayInDateTime Between '"+ txtStartDate.Text +"' And '"+ endDate.AddDays(1).ToString("dd MMM yyyy") +"' And Status Like '"+ ddlStatus.SelectedValue +"' Order by "+SortExpression+" "+SortOrder);
				//"PaymentMode_Name,PaymentMode_Value,PaymentMode_BaseType,PaymentMode_ChannelThrough,PaymentMode_FinalEntity,PaymentMode_Prefix"

				dgrdTransactionDetails.DataSource = dsCOC;
				dgrdTransactionDetails.DataBind();

				dgrdDraftDetails.DataSource = dsDTB;
				dgrdDraftDetails.DataBind();

				lblTotalCOC.Text = "Total Transactions: " + dsCOC.Tables[0].Rows.Count;
				lblTotalBTs.Text = "Total Transactions: " + dsDTB.Tables[0].Rows.Count;
				
				lblTotalCOC.Visible = true;
				lblTotalBTs.Visible = true;

				Session["ReportQryCOC"]= strDryCOC.ToString();
				Session["ReportQryDTB"]= strDryDTB.ToString();
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
			this.ddlLoginNames.SelectedIndexChanged += new System.EventHandler(this.ddlLoginNames_SelectedIndexChanged);
			this.butDisplay.Click += new System.EventHandler(this.butDisplay_Click);
			this.dgrdDraftDetails.SortCommand += new System.Web.UI.WebControls.DataGridSortCommandEventHandler(this.dgrdTransactionDetails_SortCommand);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void ddlLoginNames_SelectedIndexChanged(object sender, System.EventArgs e) {
			BindTransactionGrid();
		}

		private void dgrdTransactionDetails_SortCommand(object sender, DataGridSortCommandEventArgs e) {
			if(SortExpression==e.SortExpression) {
				if(SortOrder == "ASC") {
					SortOrder = "DESC";
				} else {
					SortOrder = "ASC";
				}
			} else {
				SortExpression = e.SortExpression;
				SortOrder = "ASC";
			}
			BindTransactionGrid();
		}

		private void butDisplay_Click(object sender, System.EventArgs e) {
			BindTransactionGrid();
			lblBankTransfer.Visible = true;
			lblCashOverCounter.Visible = true;
		}

		private void btnReport_Click(object sender, System.EventArgs e)
		{
			string urlToBeRediretedTo = "ShowReport.aspx?Type=ForSentTrans";
			urlToBeRediretedTo = Server.UrlEncode(urlToBeRediretedTo);
			Response.Redirect("Redirector.aspx?ru="+urlToBeRediretedTo);
		}
	}
}