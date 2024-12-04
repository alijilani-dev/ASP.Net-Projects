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
	public class ViewIncomingTransaction : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.DataGrid dgrdIncomingTransactions;
	
		private void Page_Load(object sender, System.EventArgs e) {
			// add attributes to the link button.
			// 
			if(!IsPostBack) {
				CheckRoles();
				BindAll();
			}
		}

		private void CheckRoles() {
			if(!User.IsInRole(UserRoles.AgentLocationPayOutTransactionAcceptor.ToString())){
				lblMessage.Text = "Insufficient user rights!";
				dgrdIncomingTransactions.Visible=false;
			}
		}

		private void BindAll() {
			BindIncomingTransactions();
		}

		private void BindIncomingTransactions() {
			string query = "";
			Guid agentAccountId = UserManager.GetAgentAccountForUser(new Guid(User.Identity.Name));
			string strLoginName = UserManager.GetLoginNameForUserId(new Guid(User.Identity.Name));
			DataSet dsAgentName = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * from AgentLocationList alol join UserList ul on alol.Id = ul.AgentId where ul.LoginName = '" + strLoginName + "'");

			if(dsAgentName.Tables[0].Rows[0]["Name"].ToString().StartsWith("MUTHOOT"))
			{
				query = @"Select td.Id,td.TransactionNumber,td.PayOutAmount From TransactionDetails td 
						Where td.RecommendedPayOutAgentId In (Select Id From AgentLocationList Where AgentAccountId='"+ agentAccountId.ToString() + @"' and Name like '%Muthoot%')
						And td.Status='UnPaid' And PaymentMode Not Like '%Draft%'";
			}
			else if(!User.IsInRole(UserRoles.AgentAccountManager.ToString())) 
			{
				query = @"Select td.Id,td.TransactionNumber,td.PayOutAmount From TransactionDetails td 
						Join AgentLocationList al On td.RecommendedPayOutAgentId=al.Id
						Join UserList ul On ul.AgentId=al.Id
						Where ul.Id='"+ User.Identity.Name +"' And td.Status='UnPaid'";
				dgrdIncomingTransactions.Columns[3].Visible=false;
			} 
			else 
			{
				//Guid agentAccountId = UserManager.GetAgentAccountForUser(new Guid(User.Identity.Name));
				query = @"Select td.Id,td.TransactionNumber,td.PayOutAmount From TransactionDetails td 
						Where td.RecommendedPayOutAgentId In (Select Id From AgentLocationList Where AgentAccountId='"+ agentAccountId.ToString() + @"')
						And td.Status='UnPaid' And PaymentMode Not Like '%Draft%'";
				dgrdIncomingTransactions.Columns[3].Visible=true;
			}

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			dgrdIncomingTransactions.DataSource = ds;
			dgrdIncomingTransactions.DataBind();
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
