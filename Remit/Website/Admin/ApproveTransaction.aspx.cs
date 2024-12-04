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
using Microsoft.ApplicationBlocks.Data;
using Evernet.MoneyExchange.BusinessLogic;

namespace Evernet.MoneyExchange.Admin {
	/// <summary>
	/// Summary description for ApproveTransaction.
	/// </summary>
	public class ApproveTransaction : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.Panel pnlApprove;
		protected System.Web.UI.WebControls.Button butApprove;
		protected System.Web.UI.WebControls.TextBox txtTransactionPassword;
		protected System.Web.UI.WebControls.Label lblApprovalFor;
		private int butApproveBlocker=0;
		protected System.Web.UI.WebControls.Label lblTransactionNumber;
		private int pnlApproveBlocker=0;
	
		private void Page_Load(object sender, System.EventArgs e) {
			if(Request["Id"]==null) {
				Response.Redirect("/Admin/Home.aspx");
			}

			if(!IsPostBack) {
				Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails aoTrans
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails(ConfigHelper.ConStr);
				Guid transId = new Guid(Request["Id"]);

				if(aoTrans.Refresh(transId)) {
					if(aoTrans.Col_Status.Value==TransactionStatus.PendingApproval.ToString()){
						lblApprovalFor.Text = "PayIn";
					} else if(aoTrans.Col_Status.Value==TransactionStatus.PendingPayOutApproval.ToString()) {
						lblApprovalFor.Text = "PayOut";
					} else {
						lblMessage.Text = "The provided transaction is not pending for approval";
						pnlApproveBlocker++;
					}
					lblTransactionNumber.Text = aoTrans.Col_TransactionNumber.Value;
				} else {
					pnlApproveBlocker++;
				}

				ViewState["TransactionId"] = aoTrans.Col_Id.Value;
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
			this.butApprove.Click += new System.EventHandler(this.butApprove_Click);
			this.Load += new System.EventHandler(this.Page_Load);
			this.PreRender += new System.EventHandler(this.ApproveTransaction_PreRender);

		}
		#endregion

		private void ApproveTransaction_PreRender(object sender, System.EventArgs e) {
			if(pnlApproveBlocker>0) 
				pnlApprove.Visible=false;
			else {
				pnlApprove.Visible=true;
				lblMessage.Text = String.Empty;
			}

			if(butApproveBlocker>0)
				butApprove.Enabled=false;
			else
				butApprove.Enabled=true;
		}

		private void butApprove_Click(object sender, System.EventArgs e) {
			Guid transId = (Guid) ViewState["TransactionId"];

			Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails aoTrans
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails(ConfigHelper.ConStr);

			aoTrans.Refresh(transId);

			if(aoTrans.Col_Status.Value == TransactionStatus.PendingApproval.ToString()) {
				SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
					CommandType.Text,
					"Update TransactionDetails Set Status='"+ TransactionStatus.UnPaid.ToString() +"' Where Id='"+ aoTrans.Col_Id.ToString() +"'");

			} else {
			
				SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
					CommandType.Text,
					"Update TransactionDetails Set Status='"+ TransactionStatus.Paid.ToString() +"' Where Id='"+ aoTrans.Col_Id.ToString() +"'");
			}

			pnlApproveBlocker++;
			lblMessage.Text = "Successfully approved transaction!";
		}
	}
}
