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
	/// Summary description for PayOutOpenTransaction.
	/// </summary>
	public class PayOutOpenTransaction : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Label lblTransactionNumber;
		protected System.Web.UI.WebControls.Label lblPayOutAmount;
		protected System.Web.UI.WebControls.Button butPayOut;
		protected System.Web.UI.WebControls.DropDownList ddlPayOutAgent;
	
		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
			
			if(Request["Id"]!=null) {
				if(!IsPostBack) {
					Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails aoTrans
						= new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails(ConfigHelper.ConStr);
					aoTrans.Refresh(new Guid(Request["id"]));

					lblTransactionNumber.Text = aoTrans.Col_TransactionNumber.Value;
					lblPayOutAmount.Text = aoTrans.Col_PayOutAmount.Value.ToString();

					ddlPayOutAgent.DataSource = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
						CommandType.Text,
						"Select * From AgentLocationList al Where LocationId='"+ aoTrans.Col_PayOutLocationId.ToString() +"'");

					ddlPayOutAgent.DataBind();
				}
			} else {
				Response.Write("No valid transaction Id!");
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
			this.butPayOut.Click += new System.EventHandler(this.butPayOut_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void butPayOut_Click(object sender, System.EventArgs e) {
			ListItem li = ddlPayOutAgent.SelectedItem;
            
			if(li!=null) {
				Guid agentAccountId = AgentManager.GetAgentAccountForAgentLocation(new Guid(li.Value));
				Guid transactionId = new Guid(Request["Id"]);

				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select * From TransitionAccountDetails Where TransactionId='"+ transactionId.ToString() +"'");

				if(ds.Tables[0].Rows.Count>0) {
					DataRow dr = ds.Tables[0].Rows[0];

					SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
						CommandType.Text,
						"Insert Into AgentAccountDetails Values (newid(), getdate(),NULL, '"+ agentAccountId.ToString() +"','"+ transactionId.ToString() +"',"+ dr["CreditLC"].ToString() +","+ dr["CreditUSD"].ToString() +",0,0)");

					SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
						CommandType.Text,
						"Insert Into AgentCommissionIncomeAccount Values(newid(),getdate(),NULL,'"+ agentAccountId.ToString() +"','"+ transactionId.ToString() +"','"+ dr["CommissionCreditLC"].ToString() +"','"+ dr["CommissionCreditUSD"].ToString() +"',0,0)");

					SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
						CommandType.Text,
						"Update TransactionDetails Set Status='"+ TransactionStatus.Paid.ToString() +"', ActualPayOutAgentId='"+ li.Value +"', PayOutDateTime=getdate() Where Id='"+ transactionId.ToString() +"'");
				}
			}
		}
	}
}