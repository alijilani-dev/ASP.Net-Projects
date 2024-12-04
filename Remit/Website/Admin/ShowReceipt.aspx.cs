using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Evernet.MoneyExchange.BusinessLogic;
using Evernet.Shared;
using System.IO;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.Admin {
	public class ShowReceipt : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Panel pnlNonPrint;
		protected System.Web.UI.WebControls.Button butNewTransaction;
		protected System.Web.UI.WebControls.Button butHome;
		protected System.Web.UI.WebControls.Literal litReceipt;
		protected System.Web.UI.WebControls.Button butBack;

		string[,] words = new string[,]{{"1","One"},{"2","Two"},{"3","Three"},{"4","Four"},{"5","Five"},{"6","Six"},{"7","Seven"},{"8","Eight"},{"9","Nine"},{"0","Zero"}};
		//array

	
		private void Page_Load(object sender, System.EventArgs e) {
			if(Request["Id"]==null) {
				Response.Write("Transaction Id is required!");
				return;
			}

			string receiptType = "ForPayIn";
			if(Request["Type"]!=null) {
				receiptType = Request["Type"];
			}
			bool forPrint=false;
			bool showTransactionLink = true;
			if(Request["ForPrint"]!=null){
				forPrint=true;
			}
			if(Request["ShowNewTransactionLink"]!=null) {
				showTransactionLink = bool.Parse(Request["ShowNewTransactionLink"]);
			}
			Guid transId = new Guid(Request["Id"]);
			/////////////////////////////////////////////////22/06/2005
			string OFAC = string.Empty;
			if(Request["OFAC"]!=null) 
			{
				OFAC = Request["OFAC"].ToString();
			}
			/////////////////////////////////////////////////22/06/2005 ends.
			/////////////////////////////////////////////////21/06/2005
			SqlConnection sqlConn = new SqlConnection(ConfigHelper.ConStr);
			String strSel = "Select * from TransactionDetails where Id = '" + transId.ToString() + "' ";
			SqlCommand cmdSel = new SqlCommand(strSel);
			cmdSel.Connection = sqlConn;

			DataSet dsTran = SqlHelper.ExecuteDataset(sqlConn,CommandType.Text,strSel);
			DataRow drTran = dsTran.Tables[0].Rows[0];
			DataSet ds = null;
			// Set up parameters (15 inputs 0 outputs) 
			SqlParameter [] arParms = new SqlParameter[15];

			// @ID Input Parameter 
			arParms[0] = new SqlParameter("@ID", SqlDbType.UniqueIdentifier ); 
			arParms[0].Direction = ParameterDirection.Input;
			arParms[0].Value = transId;

			// @CustomerId Output Parameter
			arParms[1] = new SqlParameter("@CustomerId", SqlDbType.UniqueIdentifier);
			arParms[1].Direction = ParameterDirection.Input;
			//arParms[1].Value = new Guid(drTran["CustomerId"].ToString());//DBNull.Value;

			// @BeneficeryId Output Parameter
			arParms[2] = new SqlParameter("@BeneficeryId", SqlDbType.UniqueIdentifier);
			arParms[2].Direction = ParameterDirection.Input;
			//arParms[2].Value = new Guid(drTran["BeneficeryId"].ToString());//DBNull.Value;

			// @BeneficeryBankId Output Parameter
			arParms[3] = new SqlParameter("@BeneficeryBankId", SqlDbType.UniqueIdentifier);
			arParms[3].Direction = ParameterDirection.Input;
			//arParms[3].Value = DBNull.Value;//new Guid(drTran["BeneficeryBankId"].ToString());
			
			// @PaymentMode Output Parameter
			arParms[4] = new SqlParameter("@PaymentMode", SqlDbType.NVarChar,50);
			arParms[4].Direction = ParameterDirection.Input;
			//arParms[4].Value = drTran["PaymentMode"].ToString();//DBNull.Value;
			
			// @PurposeOfTransfer Output Parameter
			arParms[5] = new SqlParameter("@PurposeOfTransfer", SqlDbType.NVarChar,50);
			arParms[5].Direction = ParameterDirection.Input;
			//arParms[5].Value = drTran["PurposeOfTransfer"].ToString();//DBNull.Value;
			
			// @PayInCurrencyId Output Parameter
			arParms[6] = new SqlParameter("@PayInCurrencyId", SqlDbType.UniqueIdentifier);
			arParms[6].Direction = ParameterDirection.Input;
			//arParms[6].Value = new Guid(drTran["PayInCurrencyId"].ToString());//DBNull.Value;
			
			// @PayOutCurrencyId Output Parameter
			arParms[7] = new SqlParameter("@PayOutCurrencyId", SqlDbType.UniqueIdentifier);
			arParms[7].Direction = ParameterDirection.Input;
			//arParms[7].Value = new Guid(drTran["PayOutCurrencyId"].ToString());//DBNull.Value;
			
			// @AssociatedBankId Output Parameter
			arParms[8] = new SqlParameter("@AssociatedBankId", SqlDbType.UniqueIdentifier);
			arParms[8].Direction = ParameterDirection.Input;
			//arParms[8].Value = DBNull.Value;//new Guid(drTran["AssociatedBankId"].ToString());
			
			// @PayInAgentUserId Output Parameter
			arParms[9] = new SqlParameter("@PayInAgentUserId", SqlDbType.UniqueIdentifier);
			arParms[9].Direction = ParameterDirection.Input;
			//arParms[9].Value = new Guid(drTran["PayInAgentUserId"].ToString());//DBNull.Value;
			
			// @PayInAgentLocationId Output Parameter
			arParms[10] = new SqlParameter("@PayInAgentLocationId", SqlDbType.UniqueIdentifier);
			arParms[10].Direction = ParameterDirection.Input;
			//arParms[10].Value = new Guid(drTran["PayInAgentLocationId"].ToString());//DBNull.Value;
			
			// @PayOutAgentUserId Output Parameter
			arParms[11] = new SqlParameter("@PayOutAgentUserId", SqlDbType.UniqueIdentifier);
			arParms[11].Direction = ParameterDirection.Input;
			//arParms[11].Value = DBNull.Value;//new Guid(drTran["PayOutAgentUserId"].ToString());
			
			// @Status Output Parameter
			arParms[12] = new SqlParameter("@Status", SqlDbType.UniqueIdentifier);
			arParms[12].Direction = ParameterDirection.Input;
			arParms[12].Value = drTran["Status"].ToString();//"CancelledWithoutRefund";
			
			// @SettlementStatus Output Parameter
			arParms[13] = new SqlParameter("@SettlementStatus", SqlDbType.UniqueIdentifier);
			arParms[13].Direction = ParameterDirection.Input;
			//arParms[13].Value = DBNull.Value;//new Guid(drTran["SettlementStatus"].ToString());

			// @ReturnXML Output Parameter
			arParms[14] = new SqlParameter("@ReturnXML", SqlDbType.UniqueIdentifier);
			arParms[14].Direction = ParameterDirection.Input;
			//arParms[14].Value = 0;//DBNull.Value;
			/////////////////////////////////////////////////
			try
			{
				sqlConn.Open();
				//SqlHelper.ExecuteDataset(sqlConn,CommandType.Text,strSel);
				ds = SqlHelper.ExecuteDataset(sqlConn,"spS_TransactionDetails_Full",arParms);
			}
			catch(SqlException ex)
			{
				Response.Write("SqlException Occured! Message: " + ex.Message);
				return;
			}
			finally
			{
				sqlConn.Close();
			}
			//for (int i=0; i<ds.Tables[0].Rows.Count; i++)
			//{
			//	for (int j=0; j<ds.Tables[0].Columns.Count; j++)
			//	{
			//		Response.Write(":" + ds.Tables[0].Rows[i][j].ToString());
			//	}
			//}
			//Response.Write("Successful." + ds.Tables[0].Rows[0][0].ToString());
			
			/*
			Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full prmsTrans
				= new Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full();
			prmsTrans.SetUpConnection(ConfigHelper.ConStr);
			Evernet.MoneyExchange.DataClasses.StoredProcedures.spS_TransactionDetails_Full spsTrans
				= new Evernet.MoneyExchange.DataClasses.StoredProcedures.spS_TransactionDetails_Full();
			prmsTrans.Param_Id = transId;
			DataSet ds = null;
			spsTrans.Execute(ref prmsTrans, ref ds);
			*/
			DataRow dr = (DataRow)ds.Tables[0].Rows[0];

			Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList aoPaymentMode
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList(ConfigHelper.ConStr);

			aoPaymentMode.Refresh(dr["PaymentMode"].ToString());

/*******************************
 * 
 * 
 * Load the Template file
 * 
 * 
 * ***************/

			string templateFile = String.Empty;

			if(receiptType=="ForPayIn") {
				if(aoPaymentMode.Col_ChannelThrough.Value=="Agent") {
					if(aoPaymentMode.Col_FinalEntity.Value=="Agent" || aoPaymentMode.Col_FinalEntity.Value=="Home") {
						templateFile = "/Admin/CashTransactionReceiptTemplate.htm";
						if((dr["PayOutCurrencyId_Code"].ToString() == "Rs.")||(dr["PayOutCurrencyId_Code"].ToString() == "BTK"))
							templateFile = "/Admin/CashZohaTransactionReceiptTemplate.htm";
					} 
					else if(aoPaymentMode.Col_FinalEntity.Value=="Bank") 
					{
						templateFile = "/Admin/BankTransactionReceiptTemplate.htm";
					} else if(aoPaymentMode.Col_FinalEntity.Value=="FixedBank") {
						templateFile ="/Admin/DepositOnlineToBankPayInReceiptTemplate.htm";
					}
				} else if(aoPaymentMode.Col_ChannelThrough.Value=="Bank") {
					
					if(aoPaymentMode.Col_FinalEntity.Value=="Bank") {
						templateFile ="/Admin/DraftToBankPayInReceiptTemplate.htm";
					} else if(aoPaymentMode.Col_FinalEntity.Value=="Home") {
						//templateFile ="/Admin/DraftToHomePayInReceiptTemplate.htm";
						templateFile ="/Admin/DraftToBankPayInReceiptTemplate.htm";
					} else if(aoPaymentMode.Col_FinalEntity.Value=="FixedBank") {
						templateFile ="/Admin/DepositOnlineToBankPayInReceiptTemplate.htm";
					}
				}
			} else if(receiptType=="ForPayOut") {
				showTransactionLink=false;
				if(aoPaymentMode.Col_ChannelThrough.Value=="Agent") {
					if(aoPaymentMode.Col_FinalEntity.Value=="Agent" || aoPaymentMode.Col_FinalEntity.Value=="Home") {
						templateFile = "/Admin/CashTransactionPayOutTemplate.htm";
						butHome.Visible = false;
						butBack.Visible = true;
					}else if(aoPaymentMode.Col_FinalEntity.Value=="Bank") {
						templateFile = "/Admin/BankTransactionPayOutTemplate.htm";
					} else if(aoPaymentMode.Col_FinalEntity.Value=="FixedBank") {
						templateFile ="/Admin/DepositOnlineToBankPayOutReceiptTemplate.htm";
					}
				} else if(aoPaymentMode.Col_ChannelThrough.Value=="Bank") {
					if(aoPaymentMode.Col_FinalEntity.Value=="Bank") {
						templateFile ="/Admin/DraftToBankPayOutReceiptTemplate.htm";
					} else if(aoPaymentMode.Col_FinalEntity.Value=="Home") {
						templateFile ="/Admin/DraftToHomePayOutReceiptTemplate.htm";
					} else if(aoPaymentMode.Col_FinalEntity.Value=="FixedBank") {
						templateFile ="/Admin/DepositOnlineToBankPayOutReceiptTemplate.htm";
					}
				}
			}

			templateFile = Server.MapPath(templateFile);

			if(!File.Exists(templateFile)) {
				Response.Write("Receipt Template File not Found!");
				return;
			}

			StreamReader sr = new StreamReader(templateFile);

			string fileContent = sr.ReadToEnd();

			sr.Close();

			/*******************************/

			Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoPayInCurrency
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

			Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoPayOutCurrency
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

			DataSet dsEMCNumber = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select ccl.EMCNumber as EMCNumber from CustomerCardList ccl join CustomerList cl on cl.CardId = ccl.Id join TransactionDetails td on cl.Id = td.CustomerId where td.Id = '" + transId.ToString() + "'");

			aoPayInCurrency.Refresh(new Guid(dr["PayInCurrencyId"].ToString()));
			aoPayOutCurrency.Refresh(new Guid(dr["PayOutCurrencyId"].ToString()));

			switch(OFAC.ToUpper())
			{
				case "COFAC":
				{
					fileContent = fileContent.Replace("{COFACFound}","<font color = '#FF0000'>Found in OFAC List</font>");
					fileContent = fileContent.Replace("{BOFACFound}"," ");
					break;
				}
				case "BOFAC":
				{
					fileContent = fileContent.Replace("{COFACFound}"," ");
					fileContent = fileContent.Replace("{BOFACFound}","<font color = '#FF0000'>Found in OFAC List</font>");
					break;
				}
				case "":
				{
					fileContent = fileContent.Replace("{COFACFound}"," ");
					fileContent = fileContent.Replace("{BOFACFound}"," ");
					break;
				}
			}
			
			DateTime tDT = DateTime.Parse(dr["PayInDateTime"].ToString());
			fileContent = fileContent.Replace("{Date}",tDT.ToString("dd MMM yyyy"));
			fileContent = fileContent.Replace("{Today}",DateTime.Today.ToString("dd MMM yyyy"));
			fileContent = fileContent.Replace("{Time}",tDT.ToString("hh:mm:ss"));
			fileContent = fileContent.Replace("{AmountInWords}",VJ.RnD.NumberToWords.NumberToWords.GetWords(decimal.Round(decimal.Parse(dr["PayOutAmount"].ToString()),aoPayOutCurrency.Col_Scale.Value)));
			fileContent = fileContent.Replace("{PaymentMode}",dr["PaymentMode_Prefix"].ToString());

			if(dsEMCNumber.Tables[0].Rows[0]["EMCNumber"] != DBNull.Value)
				fileContent = fileContent.Replace("{EMCNumber}",dsEMCNumber.Tables[0].Rows[0]["EMCNumber"].ToString());
			else
				fileContent = fileContent.Replace("<b>Exclusive Membership Card No: </b>{EMCNumber}"," ");

			fileContent = fileContent.Replace("{TRNO}",dr["TransactionNumber"].ToString());
			fileContent = fileContent.Replace("{BeneficeryName}",dr["BeneficeryId_FirstName"].ToString()+" "+dr["BeneficeryId_LastName"].ToString());
			fileContent = fileContent.Replace("{LocalCurrencyAmount}", decimal.Round(decimal.Parse(dr["PayInAmount"].ToString()),aoPayInCurrency.Col_Scale.Value).ToString());
			fileContent = fileContent.Replace("{LocalCurrencyCode}",dr["PayInCurrencyId_Code"].ToString());

			// Special case, if payout is IDR, show it in USD
			if((dr["PayInCurrencyId_Code"].ToString()=="QAR" && dr["PayOutCurrencyId_Code"].ToString()=="IDR") && receiptType=="ForPayIn") {
				decimal bankRate = decimal.Parse(dr["BankExchangeRateForPayOutCurrency"].ToString());
				decimal agentMarginPercent = decimal.Parse(dr["AgentMarginPercent"].ToString());
				decimal agencyMarginPercent = decimal.Parse(dr["AgencyMarginPercent"].ToString());
				decimal finalRate = bankRate - (bankRate * (agentMarginPercent/100)) - (bankRate * (agencyMarginPercent/100));
				fileContent = fileContent.Replace("{ForeignCurrencyAmount}", decimal.Round(decimal.Parse(dr["PayOutAmount"].ToString()) / finalRate,2).ToString());
				fileContent = fileContent.Replace("{ForeignCurrencyCode}","USD");
				fileContent = fileContent.Replace("{ExchangeRate}", "");
			} else {
				fileContent = fileContent.Replace("{ForeignCurrencyAmount}", decimal.Round(decimal.Parse(dr["PayOutAmount"].ToString()),aoPayOutCurrency.Col_Scale.Value).ToString());
				fileContent = fileContent.Replace("{ForeignCurrencyCode}",dr["PayOutCurrencyId_Code"].ToString());
				fileContent = fileContent.Replace("{ExchangeRate}", decimal.Round(decimal.Parse(dr["AgentExchangeRate"].ToString()), 6).ToString());
			}

			fileContent = fileContent.Replace("{CommissionCharge}",decimal.Round(decimal.Parse(dr["Commission"].ToString()),aoPayInCurrency.Col_Scale.Value).ToString());
			fileContent = fileContent.Replace("{TotalPayable}", decimal.Round(decimal.Parse(dr["PayInAmount"].ToString()) + decimal.Parse(dr["Commission"].ToString()),aoPayInCurrency.Col_Scale.Value).ToString());
			if(dr["PayOutCurrencyId_Code"].ToString() == "BTK")
				fileContent = fileContent.Replace("{BenefAddress}","ID Details");
			else
				fileContent = fileContent.Replace("{BenefAddress}","Address");
			fileContent = fileContent.Replace("{BeneficeryAddress}", dr["BeneficeryId_Address"].ToString());
			fileContent = fileContent.Replace("{BeneficeryTelephone}",dr["BeneficeryId_Telephone"].ToString());
			fileContent = fileContent.Replace("{BeneficeryMobile}",dr["BeneficeryId_Mobile"].ToString());
			fileContent = fileContent.Replace("{BeneficeryZipCode}",String.Empty);
			fileContent = fileContent.Replace("{PurposeOfTransferName}",dr["PurposeOfTransfer_Name"].ToString());
			fileContent = fileContent.Replace("{PayInAgentTelephone}",dr["PayInAgentLocationId_Telephone"].ToString());
			fileContent = fileContent.Replace("{BeneficeryBankAccountNumber}",dr["BeneficeryBankId_AccountNumber"].ToString());
			fileContent = fileContent.Replace("{BeneficeryBankName}",dr["BeneficeryBankId_Name"].ToString());
			fileContent = fileContent.Replace("{BeneficeryBankBranchName}",dr["BeneficeryBankId_BranchName"].ToString());
			fileContent = fileContent.Replace("{BeneficeryBankAddress}",dr["BeneficeryBankId_Address"].ToString());
			fileContent = fileContent.Replace("{BeneficeryBankZip}",dr["BeneficeryBankId_ZipCode"].ToString());

			if(aoPaymentMode.Col_ChannelThrough.Value=="Agent") {
				Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList aoAgent
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList(ConfigHelper.ConStr);

				if(dr["ActualPayOutAgentId"]!=DBNull.Value) 
				{
					aoAgent.Refresh(new Guid(dr["ActualPayOutAgentId"].ToString()));
				} else {
					aoAgent.Refresh(new Guid(dr["RecommendedPayOutAgentId"].ToString()));
				}

				fileContent = fileContent.Replace("{PayOutAgentName}", aoAgent.Col_Name.Value);
				if((aoAgent.Col_Name.Value.Trim().StartsWith("MUTHOOT")))
				{
					fileContent = fileContent.Replace(@"<TR><TD vAlign='top' width='93'>Working Hours</TD><TD>WeekDays :(10:00 AM to 3:00 PM)<BR>Saturdays: (10:00 AM to 01:00 PM)</TD></TR>"," ");
					//fileContent = fileContent.Replace(@"<TR><TD vAlign='top' width='93'>Working Hours</TD><TD>" + dr["AgentWorkingHours"].ToString() + "</TD></TR>"," ");
				}
				else
				{
					fileContent = fileContent.Replace(@"<TR><TD vAlign='top' width='93'>Working Hours</TD><TD>WeekDays :(10:00 AM to 3:00 PM)<BR>Saturdays: (10:00 AM to 01:00 PM)</TD></TR>","<TR><TD vAlign='top' width='93'>Working Hours</TD><TD>" + dr["AgentWorkingHours"].ToString() + "</TD></TR>");
				}
				if(aoAgent.Col_Address.IsNull)
					fileContent = fileContent.Replace("{PayOutAgentAddress}",String.Empty);
				else
					fileContent = fileContent.Replace("{PayOutAgentAddress}",aoAgent.Col_Address.Value);

				if(aoAgent.Col_Telephone.IsNull)
					fileContent = fileContent.Replace("{PayOutAgentTelephone}",String.Empty);
				else
					fileContent = fileContent.Replace("{PayOutAgentTelephone}",aoAgent.Col_Telephone.Value);

				if(aoAgent.Col_Fax.IsNull)
					fileContent = fileContent.Replace("{PayOutAgentFax}", String.Empty);
				else
					fileContent = fileContent.Replace("{PayOutAgentFax}", aoAgent.Col_Fax.Value);

				if(aoAgent.Col_Email.IsNull)
					fileContent = fileContent.Replace("{PayOutAgentEmail}",String.Empty);
				else
					fileContent = fileContent.Replace("{PayOutAgentEmail}",aoAgent.Col_Email.Value);
			}
			else if(aoPaymentMode.Col_ChannelThrough.Value=="Bank") 
			{
				Evernet.MoneyExchange.AbstractClasses.Abstract_BankList aoBankList
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_BankList(ConfigHelper.ConStr);

				aoBankList.Refresh(new Guid(dr["AssociatedBankId"].ToString()));

				// payout bank name
				fileContent = fileContent.Replace("{PayOutBankName}",aoBankList.Col_Name.Value);
				
				// payout bank branch
				fileContent = fileContent.Replace("{PayOutBankBranchName}",aoBankList.Col_BranchName.Value);

				// payout bank address
				if(!aoBankList.Col_Address.IsNull)
					fileContent = fileContent.Replace("{PayOutBankAddress}",aoBankList.Col_Address.Value);
				else
					fileContent = fileContent.Replace("{PayOutBankAddress}",string.Empty);
			}
			
			Evernet.MoneyExchange.AbstractClasses.Abstract_CustomerList aoCustomer
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_CustomerList(ConfigHelper.ConStr);
			aoCustomer.Refresh(new Guid(dr["CustomerId"].ToString()));

			fileContent = fileContent.Replace("{RemitterName}",aoCustomer.Col_FirstName.Value +" "+ aoCustomer.Col_LastName.Value);
			fileContent = fileContent.Replace("{RemitterAddress}",aoCustomer.Col_Address.Value);
			fileContent = fileContent.Replace("{RemitterTelephone}",aoCustomer.Col_Telephone.Value);
			fileContent = fileContent.Replace("{RemitterMobile}",aoCustomer.Col_Mobile.Value);

			Evernet.MoneyExchange.AbstractClasses.Abstract_CustomerCardList aoCard
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_CustomerCardList(ConfigHelper.ConStr);

			aoCard.Refresh(aoCustomer.Col_CardId);

			fileContent = fileContent.Replace("{CustomerId}",aoCard.Col_Code.Value);

			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoPayInUser
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);

			aoPayInUser.Refresh(new Guid(dr["PayInAgentUserId"].ToString()));

			Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList aoPayInAgent
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList(ConfigHelper.ConStr);

			aoPayInAgent.Refresh(aoPayInUser.Col_AgentId);

			fileContent = fileContent.Replace("{PayInAgentName}",aoPayInAgent.Col_Name.Value);
			if(aoPayInAgent.Col_Address.IsNull)
				fileContent = fileContent.Replace("{PayInAgentAddress}",String.Empty);
			else
				fileContent = fileContent.Replace("{PayInAgentAddress}",aoPayInAgent.Col_Address.Value);

			if(receiptType=="ForPayOut") {
				butNewTransaction.Visible=false;
			
				string[] benIdArray = dr["CollectedBeneficeryIdDetails"].ToString().Split(new char[]{','});

				string benProvidedIdType = String.Empty;
				string benProvidedIdDetails = String.Empty;
				string benProvidedIdExpiry = String.Empty;

				if(benIdArray.Length>1) {
					if(benIdArray[0]!=null) {
						benProvidedIdType = benIdArray[0];
					}

					if(benIdArray[1]!=null) {
						benProvidedIdDetails = benIdArray[1];
					}
					if(benIdArray[2]!=null) {
						benProvidedIdExpiry= benIdArray[2];
					}
				}

				fileContent = fileContent.Replace("{BeneficeryProvidedIdType}",benProvidedIdType);
				fileContent = fileContent.Replace("{BeneficeryProvidedIdDetails}",benProvidedIdDetails);
				fileContent = fileContent.Replace("{BeneficeryProvidedIdExpiry}",benProvidedIdExpiry);
			}

			litReceipt.Text=fileContent;

			if(forPrint) {
				pnlNonPrint.Visible=false;
			}

			if(showTransactionLink)
				butNewTransaction.Visible=true;
			else
				butNewTransaction.Visible=false;
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
			this.butNewTransaction.Click += new System.EventHandler(this.butNewTransaction_Click);
			this.butHome.Click += new System.EventHandler(this.butHome_Click);
			this.butBack.Click += new System.EventHandler(this.btnBack_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void butNewTransaction_Click(object sender, System.EventArgs e) {
			Response.Redirect("InitiateTransfer.aspx");
		}

		private void butHome_Click(object sender, System.EventArgs e) {
			Response.Redirect("Home.aspx");
		}

		private void btnBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("ViewIncomingTransaction.aspx");
		}
	}
}