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
using System.Data.SqlTypes;
using Params = Evernet.MoneyExchange.DataClasses.Parameters;
using SPs = Evernet.MoneyExchange.DataClasses.StoredProcedures;

namespace Evernet.MoneyExchange.Admin {
	public class Report_CreditDebitForAgentAccount : System.Web.UI.Page {
		protected System.Web.UI.WebControls.DropDownList ddlAgentAccount;
		protected System.Web.UI.WebControls.TextBox txtStartDate;
		protected System.Web.UI.WebControls.DropDownList ddlAccountType;
		protected System.Web.UI.WebControls.Button butFilter;
		protected System.Web.UI.WebControls.TextBox txtEndDate;
		protected System.Web.UI.WebControls.DataGrid dgrdAccounts;
	
		private void Page_Load(object sender, System.EventArgs e) {
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
			this.butFilter.Click += new System.EventHandler(this.butFilter_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BindAll() {
			BindAgentAccount();
			BindAccountTypes();
		}

		private void BindAgentAccount() {
			Params.spS_AgentMaster_Display prsAgentMaster = new Params.spS_AgentMaster_Display();
			SPs.spS_AgentMaster_Display spsAgentMaster = new SPs.spS_AgentMaster_Display();

			prsAgentMaster.SetUpConnection(ConfigHelper.ConStr);

			DataSet ds = null;

			spsAgentMaster.Execute(ref prsAgentMaster,ref ds);

			ddlAgentAccount.DataSource=ds;
			ddlAgentAccount.DataBind();
		}

		private void BindAccountTypes() {
			ListItem liAll = new ListItem("All");
			ListItem liPrinciple = new ListItem("Principle And Commission","P");
			ListItem liCommission = new ListItem("Commission Account","C");
			ListItem liDifferenceIncome = new ListItem("Difference Income Account","D");

			//ddlAccountType.Items.Add(liAll);
			ddlAccountType.Items.Add(liPrinciple);
			ddlAccountType.Items.Add(liCommission);
			ddlAccountType.Items.Add(liDifferenceIncome);
		}

		private void butFilter_Click(object sender, System.EventArgs e) {
			SqlDateTime StartDate = SqlDateTime.Null;
			SqlDateTime EndDate = SqlDateTime.Null;
			SqlString AccountType = SqlString.Null;
            
			if(txtStartDate.Text != String.Empty) {
				try {
					StartDate = DateTime.Parse(txtStartDate.Text);
				}catch{}
			}

			if(txtEndDate.Text != String.Empty) {
				try {
					EndDate = DateTime.Parse(txtEndDate.Text);
				}catch{}
			}

			string query ="Select * From CreditDebitInfo Where AgentAccountId='"+ ddlAgentAccount.SelectedValue +"'";

			switch(ddlAccountType.SelectedValue) {
				case "P":
					query += " And AccountType='PrincipleAndCommission'";
					break;
				case "C":
					query += " And AccountType='Commission'";
					break;
				case "D":
					query = @"Select 
						'Diff Inc Acc' as AccountType,
						dia.Id, 
						td.TransactionNumber, 
						dia.CreditLC, 
						dia.CreditUSD as CreditInUSD, 
						dia.DebitLC,
						dia.DebitUSD as DebitInUSD
						from PayInAgentDifferenceIncomeAccount dia 
						Inner Join TransactionDetails td On dia.Id=td.Id
						Where AgentAccountId='"+ ddlAgentAccount.SelectedValue +"'";
					break;
			}

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			dgrdAccounts.DataSource = ds;
			dgrdAccounts.DataBind();
		}
	}
}
