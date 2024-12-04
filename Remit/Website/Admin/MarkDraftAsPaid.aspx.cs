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
	public class MarkDraftAsPaid : System.Web.UI.Page {
		private void Page_Load(object sender, System.EventArgs e) {
			if(!IsPostBack) {
				if(Request["Id"]==null) {
					Response.Redirect("Home.aspx");
					return;
				}

//				string query = "Update TransactionDetails Set Status='Paid' Where Id='"+ Request["Id"] +"'";
//
//				SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
//					CommandType.Text,
//					query);


				Guid agentAccountId = UserManager.GetAgentAccountForUser(new Guid(User.Identity.Name));
				Guid agentId = UserManager.GetAgentForUser(new Guid(User.Identity.Name));
				Guid transId = new Guid(Request["Id"]);

				System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigHelper.ConStr);
				con.Open();

				System.Data.SqlClient.SqlTransaction trans = con.BeginTransaction();

				try {
					Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails aoTrans
						= new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails(ConfigHelper.ConStr);

					aoTrans.Refresh(transId);

					if(aoTrans.Col_Status.Value == TransactionStatus.UnPaid.ToString()) {

						if(User.IsInRole(UserRoles.AgentLocationPayOutTransactionApprover.ToString())
							||
							User.IsInRole(UserRoles.AgentAccountManager.ToString())
							) {
							SqlHelper.ExecuteNonQuery(trans,
								CommandType.Text,
								"Update TransactionDetails Set ActualPayOutAgentId='"+ agentId.ToString() +"',PayOutAgentUserId='"+ User.Identity.Name +"',PayOutDateTime=getdate(),Status='"+ TransactionStatus.Paid.ToString() +"' Where Id='"+ transId.ToString() +"'");


							DataSet dsTrans = SqlHelper.ExecuteDataset(trans,
								CommandType.Text,
								"Select * From TransitionAccountDetails Where TransactionId='"+ transId.ToString() +"'");

							DataRow dr = dsTrans.Tables[0].Rows[0];

							SqlHelper.ExecuteNonQuery(trans,
								CommandType.Text,
								"Insert Into AgentAccountDetails Values (newid(), getdate(),NULL, '"+ agentAccountId.ToString() +"','"+ transId.ToString() +"',"+ dr["CreditLC"].ToString() +","+ dr["CreditUSD"].ToString() +",0,0)");

							SqlHelper.ExecuteNonQuery(trans,
								CommandType.Text,
								"Insert Into AgentCommissionIncomeAccount Values(newid(),getdate(),NULL,'"+ agentAccountId.ToString() +"','"+ transId.ToString() +"','"+ dr["CommissionCreditLC"].ToString() +"','"+ dr["CommissionCreditUSD"].ToString() +"',0,0)");

							SqlHelper.ExecuteNonQuery(trans,
								CommandType.Text,
								"Update TransitionAccountDetails Set DebitDateTime=getdate(),DebitLC=CreditLC, DebitUSD=CreditUSD, CommissionDebitLC=CommissionCreditLC, CommissionDebitUSD=CommissionCreditUSD From TransitionAccountDetails Where TransactionId='"+ transId.ToString() +"'");

						} else if(User.IsInRole(UserRoles.AgentLocationPayOutTransactionAcceptor.ToString())) {
							SqlHelper.ExecuteNonQuery(trans,
								CommandType.Text,
								"Update TransactionDetails Set ActualPayOutAgentId='"+ agentId.ToString() +"'PayOutAgentUserId='"+ User.Identity.Name +"',PayOutDateTime=getdate(),Status='"+ TransactionStatus.PendingPayOutApproval.ToString() +"' Where Id='"+ transId.ToString() +"'");
						}
						SqlHelper.ExecuteNonQuery(trans,
							CommandType.Text,
							"Update TransactionDetails Set CollectedBeneficeryIdDetails=''");
					}
				} catch(Exception ex){
					trans.Rollback();
					Response.Write(ex);
					return;
				}
				trans.Commit();


				Response.Redirect(Request.UrlReferrer.ToString());
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
	}
}
