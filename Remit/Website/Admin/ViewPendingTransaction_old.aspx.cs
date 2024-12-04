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
	/// <summary>
	/// Summary description for ViewPendingTransaction.
	/// </summary>
	public class ViewPendingTransaction : System.Web.UI.Page {
		protected System.Web.UI.WebControls.DataGrid dgrdPayOut;
		protected System.Web.UI.WebControls.DataGrid dgrdPayIn;
		protected System.Web.UI.WebControls.Label lblMessage;
	
		private void Page_Load(object sender, System.EventArgs e) {
			if(User.IsInRole(UserRoles.AgentLocationPayInTransactonApprover.ToString())) {
				dgrdPayIn.Visible=true;
			} else {
				dgrdPayIn.Visible=false;
			}

			if(User.IsInRole(UserRoles.AgentLocationPayOutTransactionApprover.ToString())) {
				dgrdPayOut.Visible=true;
			} else {
				dgrdPayOut.Visible=false;
			}


			if(!IsPostBack) {
				BindAll();
			}
		}

		private void BindAll() {
			BindPayInTransactions();
			BindPayOutTransactions();
		}

		private void BindPayInTransactions() {
			Guid userId = new Guid(User.Identity.Name);
			Guid agentAccountId = UserManager.GetAgentAccountForUser(userId);
			Guid agentId = UserManager.GetAgentForUser(userId);

			string query = "";

			if(User.IsInRole(UserRoles.AgentAccountManager.ToString())) {
				query = "Select * From fnTransactionDetails_Full(Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null) Where Status='"+ TransactionStatus.PendingApproval.ToString() +"' And PayInAgentUserId In (Select Id From UserList Where AgentAccountId='"+ agentAccountId.ToString() +"' )";
			} else {
				query = "Select * From fnTransactionDetails_Full(Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null) Where Status='"+ TransactionStatus.PendingApproval.ToString() +"' And PayInAgentUserId In (Select Id From UserList Where AgentId='"+ agentId.ToString() +"' )";
			}

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);
			dgrdPayIn.DataSource=ds;
			dgrdPayIn.DataBind();
		}

		private void BindPayOutTransactions() {
			Guid userId = new Guid(User.Identity.Name);
			Guid agentAccountId = UserManager.GetAgentAccountForUser(userId);
			Guid agentId = UserManager.GetAgentForUser(userId);

			string query = "";

			if(User.IsInRole(UserRoles.AgentAccountManager.ToString())) {
				query = "Select * From fnTransactionDetails_Full(Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null) Where Status='"+ TransactionStatus.PendingPayOutApproval.ToString() +"' and RecommendedPayOutAgentId In (Select Id From UserList Where AgentAccountId='"+ agentAccountId.ToString() +"')";
			} else {
				query = "Select * From fnTransactionDetails_Full(Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null) Where Status='"+ TransactionStatus.PendingPayOutApproval.ToString() +"' and RecommendedPayOutAgentId In (Select Id From UserList Where AgentId='"+ agentId.ToString() +"')";
			}

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);
			dgrdPayOut.DataSource=ds;
			dgrdPayOut.DataBind();
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
	}
}