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
using Evernet.Shared;
using Evernet.MoneyExchange.BusinessLogic;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.Admin {
	
	public class ViewDraftTransactions : System.Web.UI.Page {
		protected System.Web.UI.WebControls.DataGrid dgrdDrafts;
		protected System.Web.UI.WebControls.HyperLink hlnkExportToExcel;
		protected System.Web.UI.WebControls.Label lblMessage;
	
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BindAll() {
			BindDraftTransactions();
		}

		private void BindDraftTransactions() {
			Guid agentAccountId = UserManager.GetAgentAccountForUser(new Guid(User.Identity.Name));

			string query = @"Select td.Id,
				td.TransactionNumber,
				td.PayInDateTime,
				bl.Name as BankName
				From TransactionDetails td 
				Join PaymentModeList pml
				On td.PaymentMode = pml.Value
				And pml.ChannelThrough='Bank'
				And (pml.FinalEntity='Bank' Or pml.FinalEntity='Home')
				Join BankList bl
				On td.AssociatedBankId = bl.Id
				Join AgentMaster am
				On bl.AccountId = am.Id
				Where Status = 'UnPaid'
				And AssociatedBankId In (Select Id From BankList Where AccountId = '"+ agentAccountId.ToString() +"') Order by PaymentMode,PayInDateTime";

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			dgrdDrafts.DataSource = ds;
			dgrdDrafts.DataBind();
		}
	}
}