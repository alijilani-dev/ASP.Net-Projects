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
	public class ViewOpenTransaction : System.Web.UI.Page {
		#region Declarations.
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.Panel pnlStage1;
		protected System.Web.UI.WebControls.Button butProceedFromStage1;
		protected System.Web.UI.WebControls.TextBox txtTransactionNumber;
		protected System.Web.UI.WebControls.Panel pnlStage2;
		protected System.Web.UI.WebControls.Button butProceedFromStage2;
		protected System.Web.UI.WebControls.TextBox txtOriginLocation;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryFirstName;
		protected System.Web.UI.WebControls.Panel pnlStage3;
		protected System.Web.UI.WebControls.Button butProceedFromStage3;
		protected System.Web.UI.WebControls.Panel pnlStage4;
		protected System.Web.UI.WebControls.Button butProceedFromStage4;
		protected System.Web.UI.WebControls.TextBox txtProvidedIdExpiry;
		protected System.Web.UI.WebControls.TextBox txtProvidedIdDetails;
		protected System.Web.UI.WebControls.TextBox txtProvidedIdType;
		protected System.Web.UI.WebControls.Panel pnlStage5;
		protected System.Web.UI.WebControls.Button butPayOut;
		protected System.Web.UI.WebControls.Label lblRemitterAddress;
		protected System.Web.UI.WebControls.Label lblRemitterTelephone;
		protected System.Web.UI.WebControls.Label lblRemitterName;
		protected System.Web.UI.WebControls.Label lblBeneficeryAddress;
		protected System.Web.UI.WebControls.Label lblBeneficeryTelephone;
		protected System.Web.UI.WebControls.Label lblBeneficeryName;
		protected System.Web.UI.WebControls.Label lblPayOutAmount;
		protected System.Web.UI.WebControls.Label lblTransactionNumber;
		protected System.Web.UI.WebControls.Label lblGlobalTransactionNumber;
		protected System.Web.UI.WebControls.Label lblGlobalPayOutAmount;
		protected System.Web.UI.WebControls.DropDownList ddlAgentLocation;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvProviderIdType;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvProvidedIDDetails;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvProviderIdExpiry;
		protected System.Web.UI.WebControls.Button btnYes;
		protected System.Web.UI.WebControls.Button btnNo;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.Label lblAgentLocation;
		protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
		protected System.Web.UI.WebControls.Label lblExpectedId;
		#endregion Declarations.
		private void Page_Load(object sender, System.EventArgs e) 
		{
			if(!IsPostBack)
			{

				if(Request["Id"]!=null) 
				{
					ViewState["CurrentStage"]=2;
					lblMessage.Text = "		Are you sure you want to pay out the transaction?";
					pnlStage2.Visible = false;
					HideAllPanels();
				}
				else
				{
					ViewState["CurrentStage"] = 1;
					lblMessage.Text = String.Empty;
					btnYes.Visible = false;
					btnNo.Visible = false;
				}
			}
		}

		private void BindAgentLocation() {
			Guid agentAccountId = UserManager.GetAgentAccountForUser(new Guid(User.Identity.Name));

			Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails aoTrans
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails(ConfigHelper.ConStr);

			Guid transId = (Guid) ViewState["TransactionId"];

			aoTrans.Refresh(transId);

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select Id [ID1], Name Display From AgentLocationList Where AgentAccountId='"+ agentAccountId.ToString() +"' And Id In (Select Id From dbo.fn_getAgentLocationForPaymentMode('"+ aoTrans.Col_PaymentMode.Value +"')) And Active=1 Order by Name ");

			ddlAgentLocation.DataSource = ds;
			ddlAgentLocation.DataBind();

			Guid agentLocationId = UserManager.GetAgentForUser(new Guid(User.Identity.Name));

			ListItem li = ddlAgentLocation.Items.FindByValue(agentLocationId.ToString());

			if(li!=null) {
				ddlAgentLocation.SelectedIndex = -1;
				li.Selected=true;
				//lblAgentLocation.Visible = true;
				//ddlAgentLocation.Visible = true;
			}

			if(!User.IsInRole(UserRoles.AgentAccountManager.ToString())) {
				ddlAgentLocation.Enabled=false;
			//	butviewReceipt.Visible=false;
			} else {
				agentLocationId = aoTrans.Col_RecommendedPayOutAgentId.Value;
				li = ddlAgentLocation.Items.FindByValue(agentLocationId.ToString());

				if(li!=null) {
					ddlAgentLocation.SelectedIndex=-1;
					li.Selected=true;

				}
				ddlAgentLocation.Enabled=true;
			//	butviewReceipt.Visible=true;
			}
		}

		private void HideAllPanels() {
			pnlStage1.Visible=false;
			pnlStage2.Visible=false;
			pnlStage3.Visible=false;
			pnlStage4.Visible=false;
			pnlStage5.Visible=false;
		}

		private void GotoStage(int stage) {
			HideAllPanels();
			
			switch(stage) {
				case 1:
					pnlStage1.Visible=true;
					break;
				case 2:
					//Commented out by Ali on 2nd June 2005.
					pnlStage2.Visible=true;
					break;
				case 3:
					pnlStage3.Visible=true;
					break;
				case 4:
					pnlStage4.Visible=true;
					break;
				case 5:
					pnlStage5.Visible=true;
					break;
			}
		}

		private void BindAssociatedTransaction() {
			Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails aoTrans
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails(ConfigHelper.ConStr);

			if(aoTrans.Refresh(new Guid(Request["Id"]))) {
				txtTransactionNumber.Text = aoTrans.Col_TransactionNumber.Value;
//				txtPayOutAmount.Text = aoTrans.Col_PayOutAmount.ToString();
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
			this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
			this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
			this.butProceedFromStage1.Click += new System.EventHandler(this.butProceedFromStage1_Click);
			this.butProceedFromStage2.Click += new System.EventHandler(this.butProceedFromStage2_Click);
			this.butProceedFromStage3.Click += new System.EventHandler(this.butProceedFromStage3_Click);
			this.butProceedFromStage4.Click += new System.EventHandler(this.butProceedFromStage4_Click);
			this.butPayOut.Click += new System.EventHandler(this.butPayOut_Click);
			this.Load += new System.EventHandler(this.Page_Load);
			this.PreRender += new System.EventHandler(this.ViewOpenTransaction_PreRender);

		}
		#endregion
		private void ViewOpenTransaction_PreRender(object sender, System.EventArgs e) {
			int stage = (int) ViewState["CurrentStage"];
			if(Request["Id"]==null) 
			{
				GotoStage(stage);
			}
		}

		private void butProceedFromStage1_Click(object sender, System.EventArgs e)
		{
			Guid countryId = UserManager.GetCountryForUser(new Guid(User.Identity.Name));
			string qOld = "Select Id,PayOutAmount,PaymentMode,RecommendedPayOutAgentId From TransactionDetails Where TransactionNumber='"+ txtTransactionNumber.Text +"' And Status='"+ TransactionStatus.UnPaid.ToString() +"' And RecommendedPayOutAgentId In (Select Id From AgentLocationList Where LocationId In (Select Id From LocationList Where CountryId='"+ countryId.ToString() +"'))" ;
			string q = "Select Id,PayOutAmount,PaymentMode,RecommendedPayOutAgentId From TransactionDetails Where TransactionNumber='"+ txtTransactionNumber.Text +"' And Status='"+ TransactionStatus.UnPaid.ToString() +"'";
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				qOld);

			if(ds.Tables[0].Rows.Count>0) {
				ViewState["CurrentStage"]=2;
				lblMessage.Text = String.Empty;

				ViewState["TransactionId"] = new Guid(ds.Tables[0].Rows[0]["Id"].ToString());
				lblGlobalTransactionNumber.Text = txtTransactionNumber.Text;
				lblGlobalPayOutAmount.Text = ds.Tables[0].Rows[0]["PayOutAmount"].ToString();

				Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList aoPaymentMode
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList(ConfigHelper.ConStr);

				if(aoPaymentMode.Refresh(ds.Tables[0].Rows[0]["PaymentMode"].ToString())) {
					if(aoPaymentMode.Col_FinalEntity.Value=="Home" 
						||
						aoPaymentMode.Col_FinalEntity.Value=="Bank") {
						UpdateTransactionDetails();
						ViewState["CurrentStage"]=5;
					}
				}

				if(User.IsInRole(UserRoles.AgentAccountManager.ToString())) {
					ListItem li = ddlAgentLocation.Items.FindByValue(ds.Tables[0].Rows[0]["RecommendedPayOutAgentId"].ToString());
					if(li!=null) 
					{
						ddlAgentLocation.SelectedIndex=-1;
						li.Selected=true;
					}
					UpdateTransactionDetails();
					ViewState["CurrentStage"]=5;
				}
				BindAgentLocation();

			} else {
				lblMessage.Text = "Cannot find matching transaction or the transaction does not belong to your country!";
			}
		}

		private void butProceedFromStage2_Click(object sender, System.EventArgs e) {
			lblMessage.Text = String.Empty;
			Guid transId = (Guid) ViewState["TransactionId"];

			string query = @"Select td.Id, td.Question,bl.IdType From TransactionDetails td
							Join CustomerList bl
							On td.BeneficeryId=bl.Id
							Join CustomerList rl
							On td.CustomerId=rl.Id
							Join AgentLocationList payinal
							On td.PayInAgentLocationId=payinal.Id 
							Join LocationList ll
							On payinal.LocationId=ll.Id";
			int conditionsChecked=0;
			bool previousFilterUsed=false;

			if(txtBeneficeryFirstName.Text!=String.Empty) {
				query+=" Where bl.FirstName='"+ txtBeneficeryFirstName.Text +"' ";
				previousFilterUsed=true;
				conditionsChecked++;
			}
			else if(txtOriginLocation.Text!=String.Empty) 
			{
				if(previousFilterUsed) {
					query += " And ";
				} else {
					query += " Where ";
					previousFilterUsed=true;
				}	
				conditionsChecked++;
				query += " ll.Name='"+ txtOriginLocation.Text +"' ";
			}

			if(previousFilterUsed) {
				query +=" And td.Id='"+ transId.ToString() +"'";
			} else {
				query += " where td.Id='"+ transId.ToString() +"'";
			}

			if(conditionsChecked<1) {
				lblMessage.Text = "Cannot find matching transaction!";
				return;
			}

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			if(ds.Tables[0].Rows.Count>0) {
				lblExpectedId.Text = ds.Tables[0].Rows[0]["IdType"].ToString();
				UpdateTransactionDetails();
				ViewState["CurrentStage"]=5;
			} else {
				lblMessage.Text = "Cannot find matching transaction!";
			}
		}

		private void butProceedFromStage3_Click(object sender, System.EventArgs e) {
			/*if(lblQuestion.Text==String.Empty) {
				ViewState["CurrentStage"]=4;
			} else {
				Guid transId = (Guid) ViewState["TransactionId"];
				string query = "Select Id From TransactionDetails Where Id='"+ transId.ToString() +"'";

				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					query);

				if(ds.Tables[0].Rows.Count>0) {
					ViewState["CurrentStage"]=4;
				} else {
					lblMessage.Text = "Cannot find matching transaction!";
				}
			}*/
		}

		private void butProceedFromStage4_Click(object sender, System.EventArgs e) {
			Guid transId = (Guid) ViewState["TransactionId"];

			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
					"Update TransactionDetails Set CollectedBeneficeryIdDetails='"+ txtProvidedIdType.Text+","+txtProvidedIdDetails.Text+","+txtProvidedIdExpiry.Text +"' Where Id='"+transId.ToString()+"'");

			ViewState["CurrentStage"]=5;			
		}

		private void UpdateTransactionDetails() {
			Guid transId = (Guid) ViewState["TransactionId"];

			Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full prmsTransDetails
				= new Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full();

			prmsTransDetails.SetUpConnection(ConfigHelper.ConStr);

			Evernet.MoneyExchange.DataClasses.StoredProcedures.spS_TransactionDetails_Full spsTransDetails
				= new Evernet.MoneyExchange.DataClasses.StoredProcedures.spS_TransactionDetails_Full();

			prmsTransDetails.Param_Id = transId;
			DataSet transDetails = null;
            
			spsTransDetails.Execute(ref prmsTransDetails, ref transDetails);


			if(transDetails.Tables[0].Rows.Count>0) {
				DataRow dr = transDetails.Tables[0].Rows[0];
				lblTransactionNumber.Text = dr["TransactionNumber"].ToString();
				lblPayOutAmount.Text = dr["PayOutAmount"].ToString();

				lblBeneficeryName.Text = dr["BeneficeryId_FirstName"].ToString();
				lblBeneficeryTelephone.Text = dr["BeneficeryId_Telephone"].ToString();
				lblBeneficeryAddress.Text = dr["BeneficeryId_Address"].ToString();

				lblRemitterName.Text = dr["CustomerId_FirstName"].ToString();
				lblRemitterTelephone.Text = dr["CustomerId_Telephone"].ToString();
				lblRemitterAddress.Text = dr["CustomerId_Address"].ToString();

				//lblQuestion.Text = dr["Question"].ToString();
				//lblAnswer.Text = dr["Answer"].ToString();

				lblExpectedId.Text = dr["BeneficeryId_IDType"].ToString();

				/*if(dr["PaymentMode_FinalEntity"].ToString()=="Bank") {
					lblBankAccountNumber.Text = dr["BeneficeryBankId_AccountNumber"].ToString();
					lblBankName.Text = dr["BeneficeryBankId_Name"].ToString();
					lblBankBranchName.Text = dr["BeneficeryBankId_BranchName"].ToString();
					lblBankAddress.Text = dr["BeneficeryBankId_Address"].ToString();
					lblBankZip.Text = dr["BeneficeryBankId_ZipCode"].ToString();

					pnlBanlDetails.Visible=true;
				} else {
					pnlBanlDetails.Visible=false;
				}*/

			} else {
				lblMessage.Text = "Provided transaction details could not be loaded!";
			}
		}

		private void butPayOut_Click(object sender, System.EventArgs e) {

			Guid transId = (Guid) ViewState["TransactionId"];
			Guid userId = new Guid(User.Identity.Name);
			Guid agentAccountId = UserManager.GetAgentAccountForUser(userId);

			Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails aoTrans
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails(ConfigHelper.ConStr);

			aoTrans.Refresh(transId);

			Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList aoPaymentMode
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList(ConfigHelper.ConStr);
			
			aoPaymentMode.Refresh(aoTrans.Col_PaymentMode.Value);

			if(aoPaymentMode.Col_FinalEntity.Value=="Agent") {
				rfvProviderIdType.Enabled=true;
				rfvProvidedIDDetails.Enabled=true;
				rfvProviderIdExpiry.Enabled=true;

				Page.Validate();
			}

			if(!Page.IsValid) {
				Page.Validate();
				return;
			}

			ListItem li = ddlAgentLocation.SelectedItem;

			if(li==null) {
				lblMessage.Text = "Cannot determine PayOut Agent!";
				return;
			}

			Guid agentLocationId = new Guid(li.Value);

			System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigHelper.ConStr);
			con.Open();

			System.Data.SqlClient.SqlTransaction trans = con.BeginTransaction();

			try {
				if(User.IsInRole(UserRoles.AgentLocationPayOutTransactionApprover.ToString())
					||
					User.IsInRole(UserRoles.AgentAccountManager.ToString())
					) {
					SqlHelper.ExecuteNonQuery(trans,
						CommandType.Text,
						"Update TransactionDetails Set ActualPayOutAgentId='"+ li.Value +"',PayOutAgentUserId='"+ userId.ToString() +"',PayOutDateTime=getdate(),Status='"+ TransactionStatus.Paid.ToString() +"' Where Id='"+ transId.ToString() +"'");

					DataSet ds = SqlHelper.ExecuteDataset(trans,
						CommandType.Text,
						"Select * From TransitionAccountDetails Where TransactionId='"+ transId.ToString() +"'");

					DataRow dr = ds.Tables[0].Rows[0];

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
						"Update TransactionDetails Set ActualPayOutAgentId='"+ li.Value +"'PayOutAgentUserId='"+ userId.ToString() +"',PayOutDateTime=getdate(),Status='"+ TransactionStatus.PendingPayOutApproval.ToString() +"' Where Id='"+ transId.ToString() +"'");
				}
				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					"Update TransactionDetails Set CollectedBeneficeryIdDetails='"+ (txtProvidedIdType.Text+","+txtProvidedIdDetails.Text+","+txtProvidedIdExpiry.Text) +"' Where Id='"+ transId.ToString() +"'");
			} catch(Exception ex){
				trans.Rollback();
				Response.Write(ex);
				return;
			}
			trans.Commit();
			lblMessage.Text = "Transaction payout complete!";
			string urlToBeRediretedTo = "/Admin/ShowReceipt.aspx?Type=ForPayOut&Id="+transId.ToString();
			urlToBeRediretedTo = Server.UrlEncode(urlToBeRediretedTo);
			Response.Redirect("Redirector.aspx?ru="+urlToBeRediretedTo);
			//Response.Redirect("/Admin/ShowReceipt.aspx?Type=ForPayOut&Id="+transId.ToString());
			ViewState["CurrentStage"]=7;
		}

		private void butviewReceipt_Click(object sender, System.EventArgs e) {
			Guid transId = (Guid) ViewState["TransactionId"];
			Response.Redirect("/Admin/ShowReceipt.aspx?Type=ForPayOut&Id="+transId.ToString());
			ViewState["CurrentStage"]=7;
		}

		private void UseGreenChannel()
		{
			BindAssociatedTransaction();
			Guid countryId = UserManager.GetCountryForUser(new Guid(User.Identity.Name));
			string q = "Select Id,PayOutAmount,PaymentMode,RecommendedPayOutAgentId From TransactionDetails Where TransactionNumber='"+ txtTransactionNumber.Text +"' And Status='"+ TransactionStatus.UnPaid.ToString() +"'";

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				q);

			if(ds.Tables[0].Rows.Count>0) 
			{
				ViewState["CurrentStage"]=2;
				lblMessage.Text = String.Empty;
				ViewState["TransactionId"] = new Guid(ds.Tables[0].Rows[0]["Id"].ToString());
			}
		}

		private void btnNo_Click(object sender, System.EventArgs e)
		{
			ViewState["CurrentStage"]= null;
			Response.Redirect("/Admin/ViewIncomingTransaction.aspx");
		}

		private void btnYes_Click(object sender, System.EventArgs e)
		{
			UseGreenChannel();
			BindAgentLocation();
			ViewState["CurrentStage"] = 7;
			butPayOut_Click(sender,e);
		}
	}
}