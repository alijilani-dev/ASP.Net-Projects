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
	public class ViewReport_ExchangeEarnings : System.Web.UI.Page {
		protected System.Web.UI.WebControls.DropDownList ddlAgentAccount;
		protected System.Web.UI.WebControls.TextBox txtStartDate;
		protected System.Web.UI.WebControls.DataGrid dgrdExchangeEarning;
		protected System.Web.UI.WebControls.Button butDisplay;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.TextBox txtEndDate;
		protected System.Web.UI.WebControls.HyperLink hlnkPrintView;

		protected decimal totalEarning = 0;
		protected decimal totalAgencyEarning = 0;
		protected decimal totalPayInAmount = 0;
	
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BindAll() {
			BindAgentAccount();
			BindDefaultDate();
		}

		private void BindAgentAccount() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From AgentMaster Order by Name");

			ddlAgentAccount.DataSource = ds;
			ddlAgentAccount.DataBind();

			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUser
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);
			aoUser.Refresh(new Guid(User.Identity.Name));

			if(!aoUser.Col_IsAgencyEmployee.Value) {
				ddlAgentAccount.Enabled=false;
				ddlAgentAccount.SelectedIndex=-1;
				ListItem li = ddlAgentAccount.Items.FindByValue(aoUser.Col_AgentAccountId.ToString());

				if(li!=null) li.Selected=true;
			}
		}

		private void BindDefaultDate() {
			txtStartDate.Text = "19 Dec 2004";
			txtEndDate.Text = DateTime.Today.ToString("dd MMM yyyy");
		}

		private void BindEarningGrid() {
			ListItem li = ddlAgentAccount.SelectedItem;

			if(li!=null) {
				DateTime startDate = DateTime.Today;
				DateTime endDate = DateTime.Today;

				try {
					startDate = DateTime.Parse(txtStartDate.Text);
				}catch{
					lblMessage.Text = "Invalid start date";
					return;
				}

				try {
					endDate = DateTime.Parse(txtEndDate.Text);
				}catch{
					lblMessage.Text = "Invalid end date";
					return;
				}

				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					@"Select 	PayInDateTime, aad.VoucherNumber, TransactionNumber, PayInAmount, 
					PayInAmount - (PayInAmount * (AgentMarginPercent/100)) as AgencyAmount,
					PayInAmount - (PayInAmount - (PayInAmount * (AgentMarginPercent/100))) as Earnings
					From TransactionDetails td
					Join AgentLocationList al
					On td.PayInAgentLocationId = al.Id
					Join AgentMaster am
					On al.AgentAccountId = am.Id
					Join AgentAccountDetails aad
					On aad.TransactionId = td.Id
					And aad.CreditDateTime Is Null
					Where PayInDateTime Between '"+ startDate.ToString() +@"' And '"+ endDate.AddDays(1).ToString() +@"'
					And am.Id='"+ li.Value +@"' and td.status <> 'CancelledWithoutRefund'
					Order by PayInDateTime");

				foreach(DataRow dr in ds.Tables[0].Rows) {
					totalEarning += decimal.Round(decimal.Parse(dr["Earnings"].ToString()),3);
					totalAgencyEarning += decimal.Round(decimal.Parse(dr["AgencyAmount"].ToString()),3);
					totalPayInAmount += decimal.Round(decimal.Parse(dr["PayInAmount"].ToString()),3);
				}

				dgrdExchangeEarning.DataSource = ds;
				dgrdExchangeEarning.DataBind();

				string url = "PrintView_ExchangeEarnings.aspx?AgentAccountId="+ li.Value +"&StartDate="+ txtStartDate.Text +"&EndDate="+txtEndDate.Text;
				hlnkPrintView.NavigateUrl = url;

				hlnkPrintView.Visible=true;
			}
		}

		private void butDisplay_Click(object sender, System.EventArgs e) {
			BindEarningGrid();
		}
	}
}