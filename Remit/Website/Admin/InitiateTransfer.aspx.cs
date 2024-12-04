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
using System.Data.SqlClient;

namespace Evernet.MoneyExchange.Admin {
	public class InitiateTransfer : System.Web.UI.Page {
		#region Declarations.
		protected System.Web.UI.WebControls.DropDownList ddlOriginCountry;
		protected System.Web.UI.WebControls.DropDownList ddlOriginLocation;
		protected System.Web.UI.WebControls.DropDownList ddlOriginAgent;
		protected System.Web.UI.WebControls.DropDownList ddlOriginUser;
		protected System.Web.UI.WebControls.Label lblCreditBalance;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.Panel pnlMiddlePart;
		protected System.Web.UI.WebControls.Panel pnlCustomerCardDetails;
		protected System.Web.UI.WebControls.Label lblCustomerCardMessage;
		protected System.Web.UI.WebControls.Panel pnlDestinationSelection;
		protected System.Web.UI.WebControls.Label lblDestinationSelectionMessage;
		protected System.Web.UI.WebControls.DropDownList ddlDestinationCountry;
		protected System.Web.UI.WebControls.DropDownList ddlDestinationModeOfPayment;
		protected System.Web.UI.WebControls.DropDownList ddlDestinationLocation;
		protected System.Web.UI.WebControls.TextBox txtDestinationAgentAddress;
		protected System.Web.UI.WebControls.Button butDestinationAgentFilter;
		protected System.Web.UI.WebControls.Panel pnlDestinationEntityDetails;
		protected System.Web.UI.WebControls.DropDownList ddlPurposeOfTransfer;
		protected System.Web.UI.WebControls.Panel pnlDestinationAgent;
		protected System.Web.UI.WebControls.DropDownList ddlDestinationAgent;
		protected System.Web.UI.WebControls.Panel pnlDestinationBank;
		protected System.Web.UI.WebControls.DropDownList ddlDestinationBank;
		protected System.Web.UI.WebControls.Panel pnlTransactionInformation;
		protected System.Web.UI.WebControls.DropDownList ddlPayInCurrency;
		protected System.Web.UI.WebControls.DropDownList ddlPayOutCurrency;
		protected System.Web.UI.WebControls.TextBox txtPayInAmount;
		protected System.Web.UI.WebControls.TextBox txtPayOutAmount;
		protected System.Web.UI.WebControls.Button butCalculate;
		protected System.Web.UI.WebControls.Panel pnlTransactionDetails;
		protected System.Web.UI.WebControls.Label lblTDPayInAmount;
		protected System.Web.UI.WebControls.Label lblTDCommissionAmount;
		protected System.Web.UI.WebControls.Label lblTDPayInCurrency;
		protected System.Web.UI.WebControls.Label lblTDCommissionCurrency;
		protected System.Web.UI.WebControls.Label lblTDPayOutAmount;
		protected System.Web.UI.WebControls.Label lblTDExchangeRate;
		protected System.Web.UI.WebControls.Label lblTDTotalPayableCurrency;
		protected System.Web.UI.WebControls.Label lblTDTotalPayableAmount;
		protected System.Web.UI.WebControls.Panel pnlCustomerDetails;
		protected System.Web.UI.WebControls.Label lblCustomerDetailsMessage;
		protected System.Web.UI.WebControls.Label lblCustomerRecordStatus;
		protected System.Web.UI.WebControls.TextBox txtCustomerFirstName;
		protected System.Web.UI.WebControls.TextBox txtCustomerLastName;
		protected System.Web.UI.WebControls.TextBox txtCustomerEmailId;
		protected System.Web.UI.WebControls.TextBox txtCustomerAddress;
		protected System.Web.UI.WebControls.TextBox txtCustomerTelephone;
		protected System.Web.UI.WebControls.TextBox txtCustomerMobile;
		protected System.Web.UI.WebControls.TextBox txtCustomerIdType;
		protected System.Web.UI.WebControls.TextBox txtCustomerIdDetails;
		protected System.Web.UI.WebControls.TextBox txtCustomerIdExpiry;
		protected System.Web.UI.WebControls.Button butUpdateCustomerRecord ;
		protected System.Web.UI.WebControls.DropDownList ddlBeneficerySelection;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryFirstName;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryLastName;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryEmailId;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryAddress;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryTelephone;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryMobile;
		protected System.Web.UI.WebControls.Button butUpdateBeneficeryRecord;
		protected System.Web.UI.WebControls.Panel pnlBeneficeryDetails;
		protected System.Web.UI.WebControls.Label lblBeneficeryBankDetailsMessage;
		protected System.Web.UI.WebControls.DropDownList ddlBeneficeryBankSelection;
		protected System.Web.UI.WebControls.Button butUpdateBeneficeryBankRecord;
		protected System.Web.UI.WebControls.Panel pnlBeneficeryBankDetails;
		protected System.Web.UI.WebControls.Button butInitiateTransfer;
		protected System.Web.UI.WebControls.Panel pnlBottomPart;
		protected System.Web.UI.WebControls.TextBox txtCustomerZip;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryZip;
		protected System.Web.UI.WebControls.TextBox txtExchangeRate;
		protected System.Web.UI.WebControls.Panel pnlExchangeRateRangeInfo;
		protected System.Web.UI.WebControls.Label lblMinimumExchangeRate;
		protected System.Web.UI.WebControls.Label lblMaximumExchangeRate;
		protected System.Web.UI.WebControls.Label lblInitateTransferMessage;
		protected System.Web.UI.WebControls.Label lblBeneficeryStatus;
		protected System.Web.UI.WebControls.DropDownList ddlBeneficeryNationality;
		protected System.Web.UI.WebControls.DropDownList ddlCustomerNationality;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryIdType;
		protected System.Web.UI.WebControls.Label lblBeneficeryBankRecordStatus;
		protected System.Web.UI.WebControls.Label lblBeneficeryDetailsMessage;
		protected System.Web.UI.WebControls.Label lblTransactionInformationMessage;
		protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
		protected System.Web.UI.WebControls.Panel pnlTopPanel;

		protected int butInititateTransactionBlocker=0;
		protected int butCalculateBlocker=0;
		protected int pnlMiddlePartBlocker=0;
		protected int pnlBottomPartBlocker=0;
		protected int pnlBeneficeryBankDetailsBlocker=0;
		protected int pnlBenBankExtraDetailsBlocker=0;
		protected int pnlBenBankNameBlocker=0;
		protected int pnlBenBankBranchNameBlocker=0;

		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator3;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryBankAccountNumber;
		protected System.Web.UI.WebControls.Label lblTDPayOutCurrency;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator7;
		protected System.Web.UI.WebControls.Label lblBeneficeryAddress;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvBenBankAccountNumber;
		protected System.Web.UI.WebControls.Panel pnlBenBankExtraDetails;
		protected System.Web.UI.WebControls.DropDownList ddlBeneficeryBankCountry;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryBankZip;
		protected System.Web.UI.WebControls.Label lblBenAddressMandarotySign;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvBenAdddress;
		protected System.Web.UI.WebControls.Label lblBenBankAddressMandatorySign;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvBenBankAddress;
		protected System.Web.UI.WebControls.Panel pnlBenBankName;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvBenBankName;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryBankName;
		protected System.Web.UI.WebControls.Panel pnlBenBankBranchName;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvBenBankBranchName;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryBankBranchName;
		protected System.Web.UI.WebControls.Label lblBenBankBranchMandatorySign;
		protected System.Web.UI.WebControls.Label lblBenBankNameMandatorySign;
		protected System.Web.UI.WebControls.Label lblBenBankAccountNumberMandatorySign;
		protected System.Web.UI.WebControls.Label lblTDModeOfPayment;
		protected System.Web.UI.WebControls.TextBox txtBeneficeryBankAddress;
		bool visibilityBasedOnModeOfPaymentExecuted = false;
		protected System.Web.UI.WebControls.Button butCheckSRTRNumber;
		protected System.Web.UI.WebControls.TextBox txtTransactionNumber;
		protected System.Web.UI.WebControls.Button butCheckCustomerCard;
		protected System.Web.UI.WebControls.TextBox txtCustomerCardNumber;
		protected System.Web.UI.WebControls.CheckBox chbxCreateNewCustomer;
		protected System.Web.UI.WebControls.Panel pnlExistingCustomer;
		protected System.Web.UI.WebControls.Label lblBankZip;
		protected System.Web.UI.WebControls.Label lblBankZipMandatorySign;
		protected System.Web.UI.WebControls.Label lblBankZipMsg;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.Button brnSearch;
		string OFAC = string.Empty;
		//int mrows;
		public string Message {
			get {
				return lblMessage.Text;
			}

			set {
				lblMessage.Text = value;
			}
		}
		#endregion Declarations.
		private void Page_Load(object sender, System.EventArgs e) {
			if(!IsPostBack) {
				if(User.IsInRole(UserRoles.Administrator.ToString())
					||
					User.IsInRole(UserRoles.AgentLocationPayInTransactionInitiator.ToString())) {
					BindNonPostBackItems();
				}
                UpdateExchangeRate();
			}
			//UpdateVisibilityChecks();
			Response.AddHeader("Expires", "Sun, 7 May 1995 12:00:00 GMT");
			Response.AddHeader("Cache-Control", "no-store, no-cache, must-revalidate");
			Response.AddHeader("Cache-Control", "post-check=0, pre-check=0");
			Response.AddHeader("Pragma", "no-cache");
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
			this.butCheckCustomerCard.Click += new System.EventHandler(this.butCheckCustomerCard_Click);
			this.butCheckSRTRNumber.Click += new System.EventHandler(this.butCheckSRTRNumber_Click);
			this.brnSearch.Click += new System.EventHandler(this.brnSearch_Click);
			this.ddlOriginCountry.SelectedIndexChanged += new System.EventHandler(this.ddlOriginCountry_SelectedIndexChanged);
			this.ddlOriginLocation.SelectedIndexChanged += new System.EventHandler(this.ddlOriginLocation_SelectedIndexChanged);
			this.ddlOriginAgent.SelectedIndexChanged += new System.EventHandler(this.ddlOriginAgent_SelectedIndexChanged);
			this.ddlOriginUser.SelectedIndexChanged += new System.EventHandler(this.ddlOriginUser_SelectedIndexChanged);
			this.ddlDestinationCountry.SelectedIndexChanged += new System.EventHandler(this.ddlDestinationCountry_SelectedIndexChanged);
			this.ddlDestinationModeOfPayment.SelectedIndexChanged += new System.EventHandler(this.ddlDestinationModeOfPayment_SelectedIndexChanged);
			this.ddlDestinationLocation.SelectedIndexChanged += new System.EventHandler(this.ddlDestinationLocation_SelectedIndexChanged);
			this.butDestinationAgentFilter.Click += new System.EventHandler(this.butDestinationAgentFilter_Click);
			this.ddlDestinationAgent.SelectedIndexChanged += new System.EventHandler(this.ddlDestinationAgent_SelectedIndexChanged);
			this.ddlDestinationBank.SelectedIndexChanged += new System.EventHandler(this.ddlDestinationBank_SelectedIndexChanged);
			this.ddlPayOutCurrency.SelectedIndexChanged += new System.EventHandler(this.ddlPayOutCurrency_SelectedIndexChanged);
			this.butCalculate.Click += new System.EventHandler(this.butCalculate_Click);
			this.butUpdateCustomerRecord.Click += new System.EventHandler(this.butUpdateCustomerRecord_Click);
			this.ddlBeneficerySelection.SelectedIndexChanged += new System.EventHandler(this.ddlBeneficerySelection_SelectedIndexChanged);
			this.butUpdateBeneficeryRecord.Click += new System.EventHandler(this.butUpdateBeneficeryRecord_Click);
			this.ddlBeneficeryBankSelection.SelectedIndexChanged += new System.EventHandler(this.ddlBeneficeryBankSelection_SelectedIndexChanged);
			this.butUpdateBeneficeryBankRecord.Click += new System.EventHandler(this.butUpdateBeneficeryBankRecord_Click);
			this.butInitiateTransfer.Click += new System.EventHandler(this.butInitiateTransfer_Click);
			this.Load += new System.EventHandler(this.Page_Load);
			this.PreRender += new System.EventHandler(this.InitiateTransfer_PreRender);

		}
		#endregion
		private void UpdateVisibilityChecks() {
			UpdateVisibilityBasedOnModeOfPayment();
			UpdateVisibilityBasedOnUserRights();
		}
		private void GetCommissionDetails() {
			ListItem liPayInCountry = ddlOriginCountry.SelectedItem;
			ListItem liPayOutCountry = ddlDestinationCountry.SelectedItem;
			ListItem liModeOfPayment = ddlDestinationModeOfPayment.SelectedItem;

			decimal payinAmount = decimal.Zero;

			try {
				payinAmount = decimal.Parse(txtPayInAmount.Text);
			}catch{}

			CommissionRate cr = null;

			if( liPayInCountry!=null
				&&
				liPayOutCountry!=null
				&&
				liModeOfPayment!=null
				&&
				payinAmount!=decimal.Zero
				) {
				Guid payinCountry = new Guid(liPayInCountry.Value);
				Guid payoutCountry = new Guid(liPayOutCountry.Value);
				string modeOfPayment = liModeOfPayment.Value;

				cr = CommissionRateManager.GetCommissionRate(payinCountry, payoutCountry, modeOfPayment, payinAmount);
				
			}

			ViewState["CommissionRate"]=cr;
		}

		private void UpdateExchangeRate() {
			AgentExchangeRate agentRate = null;
			ListItem liPayIn = ddlPayInCurrency.SelectedItem;
			ListItem liPayOut = ddlPayOutCurrency.SelectedItem;
			butCalculate.Enabled = true;
			lblTransactionInformationMessage.Text = String.Empty;

			if(liPayIn!=null
				&&
				liPayOut!=null) {
				Guid payInCountry = new Guid(ddlOriginCountry.SelectedValue);
				Guid payOutCountry = new Guid(ddlDestinationCountry.SelectedValue);

				Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoPayInCurrency
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

				Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoPayOutCurrency
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

				aoPayInCurrency.Refresh(new Guid(liPayIn.Value));
				aoPayOutCurrency.Refresh(new Guid(liPayOut.Value));

				Currency payInCurrency = new Currency();
				Currency payOutCurrency = new Currency();

				payInCurrency.Id = aoPayInCurrency.Col_Id.Value;
				payInCurrency.Code = aoPayInCurrency.Col_Code.Value;
				payInCurrency.Name = aoPayInCurrency.Col_Name.Value;
				payInCurrency.Scale = aoPayInCurrency.Col_Scale.Value;

				payOutCurrency.Id = aoPayOutCurrency.Col_Id.Value;
				payOutCurrency.Name = aoPayOutCurrency.Col_Name.Value;
				payOutCurrency.Code = aoPayOutCurrency.Col_Code.Value;
				payOutCurrency.Scale = aoPayOutCurrency.Col_Scale.Value;

				UnitExchangeRate payInUnit = ExchangeRateManager.GetUnitExchangeRateForCurrency(payInCurrency, CurrencyExchangePosition.PayIn);
				UnitExchangeRate payOutUnit = ExchangeRateManager.GetUnitExchangeRateForCurrency(payOutCurrency, CurrencyExchangePosition.PayOut);

				BankExchangeRate bankRate = ExchangeRateManager.GetBankExchangeRate(payInUnit, payOutUnit);
				AgencyExchangeRate agencyRate = ExchangeRateManager.GetAgencyExchangeRate(bankRate,payInCountry,payOutCountry);

				ListItem liOriginUser = ddlOriginUser.SelectedItem;
				Guid agentAccountId = Guid.Empty;

				if(liOriginUser!=null) {
					agentAccountId = UserManager.GetAgentAccountForUser(new Guid(liOriginUser.Value));
				}

				agentRate = ExchangeRateManager.GetAgentExchangeRate(agencyRate, agentAccountId);

				txtExchangeRate.Text = decimal.Round(agentRate.Value,9).ToString();

				if(User.IsInRole(UserRoles.ExchangeRateChangerDuringTransaction.ToString())) {
					txtExchangeRate.Enabled=true;
					txtExchangeRate.ReadOnly=false;
					pnlExchangeRateRangeInfo.Visible = true;
					lblMaximumExchangeRate.Text = decimal.Round(agentRate.MaximumAllowedRate,9).ToString();
					lblMinimumExchangeRate.Text = decimal.Round(agentRate.MinimumAllowedRate,9).ToString();
				}

				Trace.Write("Bank Exchange Rate - PayIn", agentRate.AgencyRate.BankRate.PayInValue.ToString());
				Trace.Write("Bank Exchange Rate - PayOut", agentRate.AgencyRate.BankRate.PayOutValue.ToString());
				Trace.Write("Bank Exchange Rate - Final", agentRate.AgencyRate.BankRate.Value.ToString());
				Trace.Write("Agency Exchange Rate - PayIn", agentRate.AgencyRate.PayInValue.ToString());
				Trace.Write("Agency Exchange Rate - PayOut", agentRate.AgencyRate.PayOutValue.ToString());
				Trace.Write("Agency Exchange Rate - Final", agentRate.AgencyRate.Value.ToString());
				Trace.Write("Agent Exchange Rate - PayIn", agentRate.PayInValue.ToString());
				Trace.Write("Agent Exchange Rate - PayOut", agentRate.PayOutValue.ToString());
				Trace.Write("Agent Exchange Rate - Final", agentRate.Value.ToString());
			} else {
				butCalculate.Enabled=false;
				lblTransactionInformationMessage.Text = "No Valid Payin / Payout currency combination is selected!";
			}
			ViewState["AgentExchangeRate"] = agentRate;
		}

		private void BindNonPostBackItems() {
			
			BindOriginCountry();
			
			if(!User.IsInRole(UserRoles.Administrator.ToString())) {
				BindByLoggedInUser();
			}
			
			BindNationality();
			BindBeneficeryBankCountryList();
			BindBeneficeryBankSelection();
		}

		private void BindByLoggedInUser() {
			Guid userId = new Guid(User.Identity.Name);
			Guid agentLocationId = UserManager.GetAgentForUser(userId);
			Guid locationId = UserManager.GetLocationForUser(userId);
			Guid countryId = UserManager.GetCountryForUser(userId);
		
			BindOriginCountry(false);

			ListItem liCountry = ddlOriginCountry.Items.FindByValue(countryId.ToString());

			if(null!=liCountry) {
				ddlOriginCountry.Enabled=false;
				
				ddlOriginCountry.SelectedIndex=-1;
				liCountry.Selected=true;

				BindPayInCurrency();
				BindOriginLocation(false);
				BindDestinationCountry();
				
				ListItem liLocation = ddlOriginLocation.Items.FindByValue(locationId.ToString());

				if(null!=liLocation) {
					ddlOriginLocation.Enabled=false;

					ddlOriginLocation.SelectedIndex=-1;
					liLocation.Selected=true;

					BindOriginAgent(false);

					ListItem liAgent = ddlOriginAgent.Items.FindByValue(agentLocationId.ToString());

					if(null!=liAgent) {
						ddlOriginAgent.Enabled=false;
						ddlOriginAgent.SelectedIndex=-1;
						liAgent.Selected=true;

						UpdateCreditInformation();
						BindOriginUser();

						ListItem liUser = ddlOriginUser.Items.FindByValue(userId.ToString());

						if(null!=liUser) {
							ddlOriginUser.Enabled=false;
							ddlOriginUser.SelectedIndex=-1;
							liUser.Selected=true;
						}
					}
				}
			}
		}

		private void BindOriginCountry() {
			BindOriginCountry(true);
		}

		private void BindOriginCountry(bool withCascadeUpdate) {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				@"Select [Id] [ID1], [Name] + ' ['+Code+']' [Display] From CountryList 
					Where AllowedInternationalTransactionType='"+ TransactionPermissionType.Send.ToString() +@"' Or AllowedInternationalTransactionType='"+ TransactionPermissionType.SendReceive.ToString() +@"'
					Or AllowedDomesticTransactionType='"+ TransactionPermissionType.Send.ToString() +"' Or AllowedDomesticTransactionType='"+ TransactionPermissionType.SendReceive.ToString() +"'");

			ddlOriginCountry.DataSource = ds;
			ddlOriginCountry.DataBind();

			if(withCascadeUpdate) {
				BindPayInCurrency();
				BindDestinationCountry();
				BindOriginLocation();
			}
		}

		private void BindOriginLocation() {
			BindOriginLocation(true);
		}

		private void BindOriginLocation(bool withCascadeUpdate) {
			ListItem li = ddlOriginCountry.SelectedItem;
			ddlOriginLocation.Items.Clear();
			if(li!=null) {
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					@"Select [Id] [ID1],[Name] [Display] From LocationList Where CountryId='"+ li.Value +"' Order by Display");
				ddlOriginLocation.DataSource = ds;
				ddlOriginLocation.DataBind();
			}
			if(withCascadeUpdate) {
				BindOriginAgent();
				UpdateCreditInformation();
			}
		}

		private void BindOriginAgent() {
			BindOriginAgent(true);
		}

		private void BindOriginAgent(bool withCascadeUpdate) {
			ListItem li = ddlOriginLocation.SelectedItem;
			ddlOriginAgent.Items.Clear();

			if(li!=null) {
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					@"Select [Id] [ID1], [Name] [Display] From AgentLocationList Where LocationId='"+ li.Value +"'");

				ddlOriginAgent.DataSource = ds;
				ddlOriginAgent.DataBind();
			}
			
			if(withCascadeUpdate) {
				UpdateCreditInformation();
				BindOriginUser();
			}
		}

		private void BindOriginUser() {
			ListItem li = ddlOriginAgent.SelectedItem;
			ddlOriginUser.Items.Clear();

			if(li!=null) {
				Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList aoAgentLocationList
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList(ConfigHelper.ConStr);

				aoAgentLocationList.Refresh(new Guid(li.Value));

				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					@"Select ul.[Id] [ID1], ul.[LoginName] [Display] From UserList ul
						Where AgentId='"+ li.Value +"' Or AgentAccountId='"+ aoAgentLocationList.Col_AgentAccountId.Value.ToString() +"'");

				ddlOriginUser.DataSource = ds;
				ddlOriginUser.DataBind();
			}
			UpdateVisibilityBasedOnUserRights();
		}

		private void BindDestinationCountry() 
		{
			ListItem li = ddlOriginCountry.SelectedItem;
			ddlDestinationCountry.Items.Clear();
			int n_IndexSelected = 0;
			
			if(li!=null) 
			{
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					@"Select [Id] As [ID1], [Name]+' ['+Code+']' As Display From CountryList Where Id In (Select TargetCountryId From CountryTransactionPermissionList Where BaseCountryId='"+ li.Value +"'and PermissionType='Send') Order by Name ");
				
				for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					if(ds.Tables[0].Rows[i]["Display"].ToString().StartsWith("INDIA"))
						break;
					else
						n_IndexSelected = n_IndexSelected + 1;
				}

			ddlDestinationCountry.DataSource = ds;
			ddlDestinationCountry.DataBind();
				
			}
			ddlDestinationCountry.SelectedIndex = n_IndexSelected;
			BindPayOutCurrency();
			BindDestinationModeOfPayment();
			BindDestinationLocation();
			BindDestinationBank(txtDestinationAgentAddress.Text);
		}

		private void BindPayInCurrency() {
			ListItem li = ddlOriginCountry.SelectedItem;
            ddlPayInCurrency.Items.Clear();

			if(li!=null) {
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
						CommandType.Text,
						"Select Id [ID1], Code Display From CurrencyList Where Id=(Select BaseCurrency From CountryList Where Id='"+ li.Value +"')");
				ddlPayInCurrency.DataSource = ds;
				ddlPayInCurrency.DataBind();
				UpdateCurrencyScale();
			}

			UpdateExchangeRate();
		}

		private void UpdateVisibilityBasedOnUserRights() {
	
			ListItem li = ddlOriginUser.SelectedItem;

			// pnlMiddlePart.Visible = false;
			// pnlMiddlePartBlocker++;

			// pnlBottomPart.Visible = false;
			// pnlBottomPartBlocker++;

			if(li!=null) {
//				if(UserManager.IsInRole(new Guid(li.Value),UserRoles.AgentAccountManager.ToString())
//					||
//					UserManager.IsInRole(new Guid(li.Value),UserRoles.AgentLocationPayInTransactionInitiator.ToString())) {
//					// if so make the middle and bottom panels visible
//					pnlMiddlePart.Visible = true;
//					pnlBottomPart.Visible = true;
//				}
				if(!User.IsInRole(UserRoles.AgentLocationPayInTransactionInitiator.ToString())) {
					pnlMiddlePartBlocker++;
					pnlBottomPartBlocker++;
				}
			}
	
		}

		private void UpdateVisibilityBasedOnModeOfPayment() {
			visibilityBasedOnModeOfPaymentExecuted = true;
			ListItem li = ddlDestinationModeOfPayment.SelectedItem;

			if(null!=li) {
				// Ali code starts. 12/06/05
				Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoPayOutCurrency
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

				aoPayOutCurrency.Refresh(new Guid(ddlPayOutCurrency.SelectedValue));
				// Ali code ends..	12/06/05
				Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList aoPaymentMode
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList(ConfigHelper.ConStr);
				if(aoPaymentMode.Refresh(li.Value)) {

					rfvBenBankName.Enabled=true;
					rfvBenBankBranchName.Enabled=true;
					rfvBenBankAccountNumber.Enabled = true;

					lblBenBankAccountNumberMandatorySign.Visible=true;
					lblBenBankNameMandatorySign.Visible=true;
					lblBenBankBranchMandatorySign.Visible=true;
					
					if(aoPaymentMode.Col_FinalEntity.Value=="Home") 
					{
						lblBeneficeryAddress.Text = "Courier Address :";
						rfvBenAdddress.Enabled = true;
						lblBenAddressMandarotySign.Visible=true;

						// For DTH enable only the ben bank name and branch name
						if(aoPaymentMode.Col_ChannelThrough.Value=="Bank") 
						{
							pnlBenBankExtraDetailsBlocker++;
							rfvBenBankName.Enabled=false;
							rfvBenBankBranchName.Enabled=false;
							rfvBenBankAccountNumber.Enabled = false;
							//txtBeneficeryBankAddress.Visible=false;
							//lblBenBankAddressMandatorySign.Visible=false;
							lblBenBankAccountNumberMandatorySign.Visible=false;
							lblBenBankNameMandatorySign.Visible=false;
							lblBenBankBranchMandatorySign.Visible=false;
						}
					} // Ali code starts. 12/06/05
					else if((aoPayOutCurrency.Col_Code.Value).ToString() == "BTK")
					{
						lblBeneficeryAddress.Text = "ID Details :";
						lblBenAddressMandarotySign.Visible = true;
					} // Ali code ends..  12/06/05
					else 
					{
						lblBeneficeryAddress.Text = "Address :";
						rfvBenAdddress.Enabled = false;
						lblBenAddressMandarotySign.Visible=false;
					}

					if((aoPaymentMode.Col_FinalEntity.Value=="Home" 
						||
						aoPaymentMode.Col_FinalEntity.Value=="Agent") && (aoPaymentMode.Col_ChannelThrough.Value!="Bank")) {
						pnlBeneficeryBankDetailsBlocker++;
					}

					if(aoPaymentMode.Col_FinalEntity.Value=="Bank") {
						ListItem lidestcountry = ddlDestinationCountry.SelectedItem;

						if(lidestcountry!=null) {
							ddlBeneficeryBankCountry.SelectedIndex=-1;
							ListItem libankcountry =  ddlBeneficeryBankCountry.Items.FindByValue(lidestcountry.Value);

							if(libankcountry!=null) {
								libankcountry.Selected=true;
							}
						}

						if(aoPaymentMode.Col_ChannelThrough.Value=="Agent") {
							rfvBenBankAddress.Enabled = false;
							lblBenBankAddressMandatorySign.Visible = false;
						} else if(aoPaymentMode.Col_ChannelThrough.Value=="Bank") {
							rfvBenBankAddress.Enabled = true;
							lblBenBankAddressMandatorySign.Visible = true;
						}
					}

					if(aoPaymentMode.Col_FinalEntity.Value=="FixedBank") {
						pnlBenBankExtraDetailsBlocker++;
						pnlBenBankNameBlocker++;
						pnlBenBankBranchNameBlocker++;
					}
				}
			}
		}

		private void UpdateCreditInformation() {
			
			ListItem li = ddlOriginAgent.SelectedItem;
            lblCreditBalance.Text = "No Agent Account Information Available";
			bool currentButtonState = butCalculate.Enabled;
			
			if(li!=null) {

				Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster aoAgentAccount
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster(ConfigHelper.ConStr);

				aoAgentAccount.Refresh(AgentManager.GetAgentAccountForAgentLocation(new Guid(li.Value)));

				decimal creditWarningLimit = 80;
				decimal originalCreditLimit = 0;
				if(!aoAgentAccount.Col_CreditLimitInUSD.IsNull) {
					originalCreditLimit = aoAgentAccount.Col_CreditLimitInUSD.Value;
				}
				decimal currentRemainingCredit = AgentManager.GetRemainingCreditForAgentAccount(aoAgentAccount.Col_Id.Value);
				currentRemainingCredit = decimal.Round(currentRemainingCredit,2);

				if(currentRemainingCredit <= (currentRemainingCredit - (currentRemainingCredit * (creditWarningLimit/100)))) {
					Message = "Warning! Credit limit down to "+creditWarningLimit+" %";
				}
				
				if(currentRemainingCredit<1) {
					butCalculate.Enabled = false;
					Message = "Credit limit is empty, cannot make transaction!";
					return;
				}
				Message = String.Empty;
				butCalculate.Enabled=currentButtonState;
				lblCreditBalance.Text = currentRemainingCredit.ToString();
			} else {
				butCalculate.Enabled=false;
			}
		}

		/// <summary>
		/// Selects the destination country passed as parameter [Ali-10/07/05-CustomerCard Information Retrieval].
		/// </summary>
		/// <param name="strCountry">A Guid string that represents an item value destination country.</param>
		private void SelectDestinationCountry(string strCountry)
		{
			BindDestinationCountry();
			ListItem li = ddlDestinationCountry.SelectedItem;
			ddlDestinationCountry.SelectedIndex = -1;
			if(li!=null) 
			{
				ListItem liCountry = ddlDestinationCountry.Items.FindByValue( strCountry.ToString());
				if(liCountry!=null)
					liCountry.Selected=true;
				else
					Message = "No matching record found for destination country.";
			}
		}

		private void SelectDestinationModeOfPayment(string strPaymentMode)
		{
			BindDestinationModeOfPayment();
			ListItem li = ddlDestinationModeOfPayment.SelectedItem;
			ddlDestinationModeOfPayment.SelectedIndex = -1;
			if(li!=null) 
			{
				ListItem liMOP = ddlDestinationModeOfPayment.Items.FindByValue( strPaymentMode.ToString());
				if(liMOP!=null)
					liMOP.Selected=true;
				else
					Message = "No matching mode of payment found.";
			}
			visibilityBasedOnModeOfPaymentExecuted = false;
			UpdateVisibilityBasedOnModeOfPayment();
		}

		private void SelectDestinationLocation(string strLocation)
		{
			BindDestinationLocation();
			ListItem li = ddlDestinationLocation.SelectedItem;
			ddlDestinationLocation.SelectedIndex = -1;
			if(li!=null) 
			{
				ListItem liMOP = ddlDestinationLocation.Items.FindByValue( strLocation.ToString());
				if(liMOP!=null)
					liMOP.Selected=true;
				else
					Message = "No matching destination location found.";
			}
		}

		private void SelectDestinationAgent(string strAgent)
		{
			BindDestinationAgent(String.Empty);
			ListItem li = ddlDestinationAgent.SelectedItem;
			ddlDestinationAgent.SelectedIndex = -1;
			if(li!=null)
			{
				ListItem liDAgent = ddlDestinationAgent.Items.FindByValue(strAgent.ToString());
				if(liDAgent!=null)
					liDAgent.Selected=true;
				else
					Message = "No matching destination agent found.";
			}
		}

		private void SelectDestinationBank(string strBank)
		{
			//BindDestinationBank(String.Empty);
			ListItem li = ddlDestinationBank.SelectedItem;
			ddlDestinationBank.SelectedIndex = -1;
			if(li!=null)
			{
				ListItem liDBank = ddlDestinationBank.Items.FindByValue(strBank.ToString());
				if(liDBank!=null)
					liDBank.Selected=true;
				else
					Message = "No matching destination bank found.";
			}
		}

		#region Other Code.
		private void BindPayOutCurrency() 
		{
			ListItem li = ddlDestinationCountry.SelectedItem;
			ddlPayOutCurrency.Items.Clear();

			if(li!=null) {
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					@"Select [Id] [ID1], Code Display From CurrencyList
					Where Id=(Select BaseCurrency From CountryList Where Id='"+ li.Value +"') Or (Code='USD' And Exists (Select Id From CountryList Where CanPayOutUSD=1 And Id='"+ li.Value +"' And BaseCurrency != (Select Id From CurrencyList Where Code='USD')))");
				ddlPayOutCurrency.DataSource = ds;
				ddlPayOutCurrency.DataBind();
				UpdateCurrencyScale();
			}
		}

		private void UpdateCurrencyScale() {
			ListItem liPayIn = ddlPayInCurrency.SelectedItem;
			ListItem liPayOut = ddlPayOutCurrency.SelectedItem;

			if(liPayIn!=null) {
				Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoPayInCurrency
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

				aoPayInCurrency.Refresh(new Guid(liPayIn.Value));

				// lblTIPayInCurrencyScale.Text = aoPayInCurrency.Col_Scale.ToString();
			}

			if(liPayOut!=null) {
				Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoPayOutCurrency
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

				aoPayOutCurrency.Refresh(new Guid(liPayOut.Value));

				// lblTIPayOutCurrencyScale.Text = aoPayOutCurrency.Col_Scale.ToString();
			}
		}

		private void BindDestinationModeOfPayment() {
			ListItem li = ddlDestinationCountry.SelectedItem;
			ddlDestinationModeOfPayment.Items.Clear();

			if(li!=null) {
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select Value [ID1], Name As Display From PaymentModeList Where Value in (Select PaymentMode From CountryAvailablePaymentModeList Where CountryId='"+ li.Value +"')");
				ddlDestinationModeOfPayment.DataSource = ds;
				ddlDestinationModeOfPayment.DataBind();
			}
			
			UpdateVisibilityBasedOnModeOfPayment();
		}

		private void BindDestinationLocation() {
		/*	ListItem li = ddlDestinationCountry.SelectedItem;
			ddlDestinationLocation.Items.Clear();

			if(li!=null) {
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					@"Select Id [ID1], [Name] Display From LocationList Where CountryId='"+ li.Value +"' Order by Name");
				ddlDestinationLocation.DataSource = ds;
				ddlDestinationLocation.DataBind();
			}*/
			UpdateLocationForModeOfPayment();

			BindDestinationAgentOrBank();
			BindPurposeOfTransfer();
		}

		private void BindPurposeOfTransfer() {
			ListItem li = ddlDestinationModeOfPayment.SelectedItem;
			ddlPurposeOfTransfer.Items.Clear();

			if(li!=null) {
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select Value [ID1], Name [Display] From PurposeOfTransferList Where PaymentModeBaseType In (Select  BaseType From PaymentModeList Where Value='"+ li.Value +"') Order by Name");

				ddlPurposeOfTransfer.DataSource = ds;
				ddlPurposeOfTransfer.DataBind();
			}
		}

		private void BindDestinationAgentOrBank() {
			ListItem li = ddlDestinationModeOfPayment.SelectedItem;
			pnlDestinationAgent.Visible=false;
			pnlDestinationBank.Visible=false;

			if(li!=null) {
				Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList aoPML
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList(ConfigHelper.ConStr);
				aoPML.Refresh(li.Value);

				if(aoPML.Col_ChannelThrough.Value=="Bank") {
					pnlDestinationBank.Visible = true;
					BindDestinationBank();
				} else if(aoPML.Col_ChannelThrough.Value=="Agent") {
					pnlDestinationAgent.Visible = true;
					BindDestinationAgent();
					//if()
				}
			}
		}

		private void BindNationality() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select Code [ID1], Name [Display] From MasterCountryList Order by Name");

			ddlCustomerNationality.DataSource = ds;
			ddlCustomerNationality.DataBind();

			ddlBeneficeryNationality.DataSource = ds;
			ddlBeneficeryNationality.DataBind();
		}

		private void BindDestinationAgent(){
			BindDestinationAgent(String.Empty);
		}

		private void BindDestinationAgent(string filter) {
			ListItem liLocation = ddlDestinationLocation.SelectedItem;
			ListItem liMOP = ddlDestinationModeOfPayment.SelectedItem;
			ddlDestinationAgent.Items.Clear();

			if(liLocation!=null	&& liMOP!=null) {
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					@"Select Id [ID1], Name Display From AgentLocationList Where LocationId='"+ liLocation.Value +"' And (Id In (Select AgentId From AgentAvailablePaymentModeList Where PaymentMode='"+ liMOP.Value +"') OR Id Not In (Select AgentId From AgentAvailablePaymentModeList)) And ((Address Like '%"+ filter.Trim() +"%' OR Address Is Null) OR (Name Like '%"+ filter.Trim() +"%')) And Active=1 Order by Name");
				ddlDestinationAgent.DataSource=ds;
				ddlDestinationAgent.DataBind();
			}
			if(ddlDestinationAgent.SelectedItem.Text=="Rs.10,000 GHAR APNA SHOPPING CARD")
			{
				txtPayInAmount.Text = "10000";
				if(ViewState["FirstTime"]==null) 
				{
					ViewState["FirstTime"]="false";
					DoCalculation(true);
				} 
				else 
				{
					DoCalculation(false);
				}
				UpdateVisibilityBasedOnModeOfPayment();
			}
		}

		private void BindDestinationBank() {
			BindDestinationBank(String.Empty);
		}

		private void BindDestinationBank(string filter) {
			ListItem li = ddlDestinationLocation.SelectedItem;
			ListItem liMOP = ddlDestinationModeOfPayment.SelectedItem;

			ddlDestinationBank.Items.Clear();

			if(li!=null && liMOP!=null) {
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select Id [ID1], Name [Display] From BankList Where LocationId='"+ li.Value +"' And AccountId In (Select Id From AgentMaster Where Active=1) And Id In (Select BankId From BankAvailablePaymentModeList Where PaymentMode='"+ liMOP.Value +"' OR BankId Not In (Select BankId From BankAvailablePaymentModeList)) And ((Address Like '%"+ filter.Trim() +"%' OR Address Is Null) Or (Name Like '%"+ filter.Trim() +"%')) Order by Name");
				ddlDestinationBank.DataSource = ds;
				ddlDestinationBank.DataBind();

				UpdateBeneficiaryBankDetailsByModeOfPayment();
			}
		}

		private void ddlOriginCountry_SelectedIndexChanged(object sender, System.EventArgs e) {
			BindDestinationCountry();
			BindOriginLocation();
			BindPayInCurrency();
			UpdateExchangeRate();
		}

		private void ddlDestinationCountry_SelectedIndexChanged(object sender, System.EventArgs e) {
			
			/*[Ali:17/17/2005:Bank Rakayat Indonesia.]*/
			if(((DropDownList)sender).SelectedItem.Text.ToString().StartsWith("INDONESIA"))
			{
				lblBankZip.Text = "Bank Unit no :";
				lblBankZipMandatorySign.Visible = true;
				lblBankZipMsg.Text = "(Mandatory in case of Bank Rakayat Indonesia.)";
				lblBankZipMsg.ForeColor = System.Drawing.Color.Red;
			}
			else
			{
				lblBankZip.Text = "Zip :";
				lblBankZipMandatorySign.Visible = false;
				lblBankZipMsg.Text = "(recommended for fast service)";
				lblBankZipMsg.ForeColor = System.Drawing.Color.Black;
			}
			/*[Ali:17/17/2005:Bank Rakayat Indonesia.]*/
			BindPayOutCurrency();
			BindDestinationModeOfPayment();
			BindDestinationLocation();
			UpdateExchangeRate();
			butDestinationAgentFilter_Click(sender,e);
			UpdateVisibilityChecks();
		}

		private void butDestinationAgentFilter_Click(object sender, System.EventArgs e) {
			if(ddlDestinationAgent.Visible)
				BindDestinationAgent(txtDestinationAgentAddress.Text);

			if(ddlDestinationBank.Visible)
				BindDestinationBank(txtDestinationAgentAddress.Text);
		}

		private void BindBeneficerySelection() {
			Guid customerId = CustomerManager.GetCustomerIdForCardCode(txtCustomerCardNumber.Text);
			ddlBeneficerySelection.Items.Clear();

			if(!chbxCreateNewCustomer.Checked) {
				if(customerId!=Guid.Empty) {
					DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
						CommandType.Text,
						"Select Id [ID1], FirstName+','+LastName Display From CustomerList Where Id In (Select BeneficeryId From TransactionDetails Where CustomerId='"+ customerId.ToString() +"')");
					ddlBeneficerySelection.DataSource = ds;
					ddlBeneficerySelection.DataBind();

					
				}
			}
			if(ddlBeneficerySelection.Items.Count<1) {
				ListItem li = new ListItem("New...");
				ddlBeneficerySelection.Items.Insert(0,li);
			} else {
				if(ddlBeneficerySelection.Items[0].Text!="New...") {
					ListItem li = new ListItem("New...");
					ddlBeneficerySelection.Items.Insert(0,li);
				}
			}
			if(ddlBeneficerySelection.Items.Count>1)  {
				ddlBeneficerySelection.SelectedIndex=1;
			}
			BindBeneficeryDetails();
		}

		private void ddlDestinationAgent_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(ddlDestinationModeOfPayment.SelectedItem.Value == "GharApnaCard")
			{
				ListItem liAgent = ddlDestinationAgent.SelectedItem;
				DataSet ds;
				if(liAgent!=null) 
				{
					ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
						CommandType.Text,
						@"Select Id, Name, Code From AgentLocationList Where Id = '"+ liAgent.Value +"'");
				
					switch(ds.Tables[0].Rows[0]["Code"].ToString())
					{
						case"ARYGASC1":
						{
							txtPayInAmount.Text = "5000";
							break;
						}
						case"ARYGASC2":
						{
							txtPayInAmount.Text = "10000";
							break;
						}
						case"ARYGASC3":
						{
							txtPayInAmount.Text = "20000";
							break;
						}
					}
					// Determine the Payout Amount based upon the PayIn value. (as in btn_Calculate_Click)
					if(ViewState["FirstTime"]==null) 
					{
						ViewState["FirstTime"]="false";
						DoCalculation(true);
					} 
					else 
					{
						DoCalculation(false);
					}
					UpdateVisibilityBasedOnModeOfPayment();
				}
			}
		}

		private void brnSearch_Click(object sender, System.EventArgs e)
		{
		
		}

		private void BindBeneficeryBankSelection() {
			Guid customerId = CustomerManager.GetCustomerIdForCardCode(txtCustomerCardNumber.Text);
			ddlBeneficeryBankSelection.Items.Clear();

			if(!chbxCreateNewCustomer.Checked) {
				if(customerId!=Guid.Empty) {
					DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
						CommandType.Text,
						"Select Id [ID1], '['+AccountNumber+'],'+Name+' ['+BranchName+']' Display From BeneficeryBankList Where CustomerId='"+ customerId.ToString() +"'");
					ddlBeneficeryBankSelection.DataSource = ds;
					ddlBeneficeryBankSelection.DataBind();
				}
			}
			
			ListItem li = new ListItem("New...");
			ddlBeneficeryBankSelection.Items.Insert(0,li);

			if(ddlBeneficeryBankSelection.Items.Count>1)  {
				ddlBeneficeryBankSelection.SelectedIndex=1;
			}

			BindBeneficeryBankDetails();
		}

		private void BindBeneficeryBankCountryList() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select [Id] [ID1], Name [Display] From CountryList Order By Name");

			ddlBeneficeryBankCountry.DataSource=ds;
			ddlBeneficeryBankCountry.DataBind();
		}

		private void UpdateBeneficeryBankSelectedCountry() {
			ListItem li = ddlDestinationCountry.SelectedItem;

			if(li!=null) {
				ListItem liBankCountry = ddlBeneficeryBankCountry.Items.FindByValue(li.Value);
				ddlBeneficeryBankCountry.SelectedIndex=-1;
				liBankCountry.Selected=true;
			}
		}

		private void BindBeneficeryBankDetails() {
			ListItem li = ddlBeneficeryBankSelection.SelectedItem;

			if(li!=null) {
				if(ddlBeneficeryBankSelection.SelectedItem.Text=="New...") {
					txtBeneficeryBankAccountNumber.Text = String.Empty;
					lblBeneficeryBankRecordStatus.Text = "New";
					txtBeneficeryBankName.Text = String.Empty;
					txtBeneficeryBankBranchName.Text = String.Empty;
					txtBeneficeryBankAddress.Text = String.Empty;
					txtBeneficeryBankZip.Text = String.Empty;
					ddlBeneficeryBankCountry.SelectedIndex=-1;
					butUpdateBeneficeryBankRecord.Visible=false;
				} else {
					DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
						CommandType.Text,
						"Select * From BeneficeryBankList Where Id='"+ li.Value +"'");

					DataRow dr = ds.Tables[0].Rows[0];

					lblBeneficeryBankRecordStatus.Text = "Existing";
					txtBeneficeryBankAccountNumber.Text = dr["AccountNumber"].ToString();
					txtBeneficeryBankName.Text = dr["Name"].ToString();
					txtBeneficeryBankBranchName.Text = dr["BranchName"].ToString();
					txtBeneficeryBankAddress.Text = dr["Address"].ToString();
					txtBeneficeryBankZip.Text = dr["ZipCode"].ToString();
					ddlBeneficeryBankCountry.SelectedIndex=-1;
					
					ListItem liCountry = ddlBeneficeryBankCountry.Items.FindByValue(dr["CountryId"].ToString());
					if(liCountry!=null)
						liCountry.Selected=true;

					butUpdateBeneficeryBankRecord.Visible=true;
					ViewState["BeneficeryBankId"]=new Guid(dr["Id"].ToString());
				}
			}
		}

		private void BindBeneficeryDetails() {
			ListItem li = ddlBeneficerySelection.SelectedItem;

			if(li!=null) {
				if(ddlBeneficerySelection.SelectedItem.Value=="New...") {
					// txtBeneficeryLoginName.Text = String.Empty;
					txtBeneficeryFirstName.Text = String.Empty;
					txtBeneficeryLastName.Text = String.Empty;
					// txtBeneficeryCardNumber.Text = String.Empty;
					lblBeneficeryStatus.Text = "New";
					txtBeneficeryEmailId.Text = String.Empty;
					txtBeneficeryTelephone.Text = String.Empty;
					txtBeneficeryMobile.Text = String.Empty;
//					txtBeneficeryFax.Text = String.Empty;
					txtBeneficeryIdType.Text = String.Empty;
//					txtBeneficeryIdDetails.Text = String.Empty;
//					txtBeneficeryIdExpiry.Text = String.Empty;
					txtBeneficeryAddress.Text = String.Empty;
					txtBeneficeryZip.Text = String.Empty;
					ddlBeneficeryNationality.SelectedIndex=-1;

					butUpdateBeneficeryRecord.Visible=false;

//					txtBeneficeryLoginName.Enabled=true;
//					txtBeneficeryLoginName.ReadOnly=false;
//					txtBeneficeryCardNumber.Enabled=true;
//					txtBeneficeryCardNumber.ReadOnly=false;
				} else {
                    BindBeneficeryDetails(new Guid(li.Value));				
				}
			}
		}

		private void BindBeneficeryDetails(Guid beneficeryId) {
			//Guid beneficeryId = new Guid(li.Value);

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From CustomerList Where Id='"+ beneficeryId.ToString() +"'");

			if(ds.Tables[0].Rows.Count>0) {
				DataRow dr = ds.Tables[0].Rows[0];

				//txtBeneficeryLoginName.Enabled=false;
				//txtBeneficeryLoginName.ReadOnly=true;
				//txtBeneficeryCardNumber.Enabled=false;
				//txtBeneficeryCardNumber.ReadOnly=true;

				lblBeneficeryStatus.Text = "Existing";
				//txtBeneficeryLoginName.Text = dr["LoginName"].ToString();
				txtBeneficeryFirstName.Text = dr["FirstName"].ToString();
				txtBeneficeryLastName.Text = dr["LastName"].ToString();
				txtBeneficeryAddress.Text = dr["Address"].ToString();
				txtBeneficeryTelephone.Text = dr["Telephone"].ToString();
//				txtBeneficeryFax.Text = dr["Fax"].ToString();
				txtBeneficeryMobile.Text = dr["Mobile"].ToString();
				txtBeneficeryEmailId.Text = dr["Email"].ToString();
				txtBeneficeryIdType.Text = dr["IDType"].ToString();
//				txtBeneficeryIdDetails.Text = dr["IDDetails"].ToString();
//				txtBeneficeryIdExpiry.Text = dr["IDExpirationDate"].ToString();
				ddlBeneficeryNationality.SelectedIndex=-1;
				ddlBeneficeryNationality.Items.FindByValue(dr["Nationality"].ToString()).Selected=true;

//				Evernet.MoneyExchange.AbstractClasses.Abstract_CustomerCardList aoCard
//					= new Evernet.MoneyExchange.AbstractClasses.Abstract_CustomerCardList(ConfigHelper.ConStr);
//
//				aoCard.Refresh(new Guid(dr["CardId"].ToString()));

//				txtBeneficeryCardNumber.Text = aoCard.Col_Code.Value;

				butUpdateBeneficeryRecord.Visible=true;
				ViewState["BeneficeryId"] = new Guid(dr["Id"].ToString());

				return;
			} else {
				//txtBeneficeryLoginName.Text = String.Empty;
				txtBeneficeryFirstName.Text = String.Empty;
				txtBeneficeryLastName.Text = String.Empty;
				//txtBeneficeryCardNumber.Text = String.Empty;
				lblBeneficeryStatus.Text = "New";
				txtBeneficeryEmailId.Text = String.Empty;
				txtBeneficeryTelephone.Text = String.Empty;
				txtBeneficeryMobile.Text = String.Empty;
//				txtBeneficeryFax.Text = String.Empty;
				txtBeneficeryIdType.Text = String.Empty;
//				txtBeneficeryIdDetails.Text = String.Empty;
//				txtBeneficeryIdExpiry.Text = String.Empty;
				txtBeneficeryAddress.Text = String.Empty;
				txtBeneficeryZip.Text = String.Empty;
				ddlBeneficeryNationality.SelectedIndex=-1;

				butUpdateBeneficeryRecord.Visible=false;

//				txtBeneficeryLoginName.Enabled=true;
//				txtBeneficeryLoginName.ReadOnly=false;
//				txtBeneficeryCardNumber.Enabled=true;
//				txtBeneficeryCardNumber.ReadOnly=false;
			}

			ViewState["BeneficeryId"] = Guid.Empty;
		}

		#endregion Other Code.
		private void butCheckCustomerCard_Click(object sender, System.EventArgs e) {
			DataSet dsCountry = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				@"Select Coul.Id as Id, Coul.Name as Name
					From transactiondetails td 
					join CustomerList cl on td.CustomerId = cl.Id 
					join CustomerCardList ccl on cl.CardId = ccl.Id 
					join CustomerList benel on td.BeneficeryId = benel.Id  
					left outer join AgentLocationList alol on td.RecommendedPayOutAgentId = alol.Id 
					left outer join BankList bl on td.AssociatedBankId = bl.Id 
					join AgentMaster am on (am.Id = alol.AgentAccountId or am.Id = bl.AccountId)
					join CountryList coul on am.CountryId = coul.Id
					Where ccl.Code = '"+ txtCustomerCardNumber.Text + "'");

			if(dsCountry.Tables[0].Rows.Count<1)
			{
				lblCustomerCardMessage.Text = "The mentioned card number does not exists or has not been assigned to you!";
				return;
			}

			SelectDestinationCountry(dsCountry.Tables[0].Rows[0]["Id"].ToString());
			BindPayOutCurrency();

			DataSet dsTransaction = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"select td.PaymentMode, td.PayOutLocationId, td.ActualPayOutAgentId, td.RecommendedPayOutAgentId, td.AssociatedBankId, pml.FinalEntity from transactiondetails td join CustomerList cl on td.CustomerId = cl.Id join CustomerCardList ccl on cl.CardId = ccl.Id join PaymentModeList pml on pml.Value = td.PaymentMode where ccl.Code = '"+ txtCustomerCardNumber.Text + "'");
			DataRow drTransaction = dsTransaction.Tables[0].Rows[0];
			SelectDestinationModeOfPayment(drTransaction["PaymentMode"].ToString());
			SelectDestinationLocation(drTransaction["PayOutLocationId"].ToString());
			
			if(drTransaction["FinalEntity"].ToString()=="Agent")
			{
				if (drTransaction["ActualPayOutAgentId"]!= null)
					SelectDestinationAgent(drTransaction["ActualPayOutAgentId"].ToString());
				else
					SelectDestinationAgent(drTransaction["RecommendedPayOutAgentId"].ToString());
			}
			else if(drTransaction["FinalEntity"].ToString()=="Bank")
			{
				if (drTransaction["AssociatedBankId"]!= null)
				{
					BindDestinationBank();
					SelectDestinationBank(drTransaction["AssociatedBankId"].ToString());
				}
			}
			UpdateExchangeRate();
			Message = String.Empty;
			pnlCustomerDetails.Visible=false;
			pnlBeneficeryDetails.Visible=false;
			pnlBeneficeryBankDetails.Visible=false;
			pnlBottomPart.Visible=false;
			// Check if the card exists in the database
			DataSet ds1 = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select Id From CustomerCardList Where Code='"+ txtCustomerCardNumber.Text +"'");

			if(ds1.Tables[0].Rows.Count<1) {
				lblCustomerCardMessage.Text = "The mentioned card number does not exists or has not been assigned to you!";
				Message = lblCustomerCardMessage.Text;
				return;
			}

			if(chbxCreateNewCustomer.Checked) {
				chbxCreateNewCustomer.Checked=false;
			} 

			DataSet dsCustomer = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From CustomerList Where CardId='"+ ds1.Tables[0].Rows[0]["Id"].ToString() +"'");

			if(dsCustomer.Tables[0].Rows.Count>0) {
				DataRow dr = dsCustomer.Tables[0].Rows[0];
				txtCustomerFirstName.Text = dr["FirstName"].ToString();
				txtCustomerLastName.Text = dr["LastName"].ToString();
				txtCustomerAddress.Text = dr["Address"].ToString();
				txtCustomerTelephone.Text = dr["Telephone"].ToString();
				txtCustomerMobile.Text = dr["Mobile"].ToString();
				txtCustomerEmailId.Text = dr["Email"].ToString();
				txtCustomerIdType.Text = dr["IDType"].ToString();
				txtCustomerIdDetails.Text = dr["IDDetails"].ToString();
				txtCustomerIdExpiry.Text = dr["IDExpirationDate"].ToString();
				ddlCustomerNationality.SelectedIndex=-1;
				ddlCustomerNationality.Items.FindByValue(dr["Nationality"].ToString()).Selected=true;
				lblCustomerRecordStatus.Text = "Existing";
				lblCustomerCardMessage.Text = "Existing Customer - Successfully retrieved the customer details";
				butUpdateCustomerRecord.Visible=true;
				ViewState["CustomerId"] = new Guid(dr["Id"].ToString());
			} else 
			{
				lblCustomerCardMessage.Text = "The mentioned card number has no customer records assigned! Please choose to create new customer if you intend to create a new customer";
				Message = lblCustomerCardMessage.Text;
			}
			BindBeneficerySelection();
			BindBeneficeryBankSelection();
			pnlCustomerDetails.Visible=true;
			pnlBeneficeryDetails.Visible=true;
			ListItem li = ddlDestinationModeOfPayment.SelectedItem;

			if(null!=li) 
			{
				Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList aoPaymentMode
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList(ConfigHelper.ConStr);
				aoPaymentMode.Refresh(li.Value);

				if (aoPaymentMode.Col_FinalEntity.Value == "Bank")
					pnlBeneficeryBankDetailsBlocker = 0;
				else
					pnlBeneficeryBankDetailsBlocker++;
			}
		}

		private void ddlOriginLocation_SelectedIndexChanged(object sender, System.EventArgs e) {
			BindOriginAgent();
		}

		private void ddlOriginAgent_SelectedIndexChanged(object sender, System.EventArgs e) {
			butCalculate.Enabled=true;
			UpdateCreditInformation();
			BindOriginUser();
		}

		private void butCalculate_Click(object sender, System.EventArgs e) {
			if(ViewState["FirstTime"]==null) 
			{
				ViewState["FirstTime"]="false";
				DoCalculation(true);
			} 
			else 
			{
				DoCalculation(false);
			}
			UpdateVisibilityBasedOnModeOfPayment();
			//#region Commented-New Code
			decimal providedExchangeRate=0,MinimumExchangeRate=0,MaximumExchangeRate=0;
			providedExchangeRate = decimal.Parse(txtExchangeRate.Text);
			///////////////////////////////////////////////////////////////
			if(User.IsInRole(UserRoles.ExchangeRateChangerDuringTransaction.ToString())) 
			{
				if ((lblMinimumExchangeRate.Text != null)||(lblMinimumExchangeRate.Text != String.Empty))
				{
					try
					{
						MinimumExchangeRate = decimal.Parse(lblMinimumExchangeRate.Text);
					}
					catch(Exception ex)
					{
						Message = "Error determining the minimum exchange rate.1"+ lblMinimumExchangeRate.Text + "--" + ex.Message;
						return;
					}
				}
				if ((lblMaximumExchangeRate.Text != null)||(lblMinimumExchangeRate.Text != String.Empty))
				{
					try
					{
						MaximumExchangeRate = decimal.Parse(lblMaximumExchangeRate.Text);
					}
					catch
					{
						Message = "Error determining the maximum exchange rate.2";
						return;
					}
				}
				if((providedExchangeRate>=MaximumExchangeRate)&&(providedExchangeRate<=MinimumExchangeRate))
				{
					if(ViewState["FirstTime"]==null) 
					{
						ViewState["FirstTime"]="false";
						DoCalculation(true);
					} 
					else
					{
						DoCalculation(false);
					}
				}
				else
				{
					lblMessage.Text = "Please enter an exchange rate within the specified range.3";
				}
			}
			else
			{
				if(ViewState["FirstTime"]==null)
				{
					ViewState["FirstTime"]="false";
					DoCalculation(true);
				}
				else
				{
					DoCalculation(false);
				}
			}
			//////////////////////////////////////////////////////////
			UpdateVisibilityBasedOnModeOfPayment();
			//#endregion Commented-New Code
		}

		private void DoCalculation(bool recalculate) {
			Message=String.Empty;
			AgentExchangeRate agentRate = (AgentExchangeRate) ViewState["AgentExchangeRate"];
			decimal providedExchangeRate = 0;

			try {
				providedExchangeRate = decimal.Parse(txtExchangeRate.Text);
			}catch{
				Message = "Error determining the exchange rate! Please provide an valid exchange rate!";
				butInititateTransactionBlocker++;
				return;
			}
/*
			if(!(providedExchangeRate>=decimal.Round(agentRate.MaximumAllowedRate,9) && providedExchangeRate<=decimal.Round(agentRate.MinimumAllowedRate,9))) {
				Message = "Exchange Rate Error! Please provide the exchange rate within the mentioned range!";
				butInititateTransactionBlocker++;
				return;
			}
*/
			decimal payinCurrency = 0;
			decimal payoutCurrency = 0;

			bool calculatePayOut = true;

			if(recalculate) {
				if(txtPayInAmount.Text.Trim()==string.Empty) {
					ViewState["CalculatePayOut"]="true";
				}else{
					ViewState["CalculatePayOut"]="false";
				}
			}else {                
				if(ViewState["CalculatePayOut"]==null) {
					if(txtPayInAmount.Text.Trim()==string.Empty) {
						ViewState["CalculatePayOut"]="true";
					}else{
						ViewState["CalculatePayOut"]="false";
					}
				}
			}

			calculatePayOut = bool.Parse(ViewState["CalculatePayOut"].ToString());

			Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoPayInCurrency
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

			aoPayInCurrency.Refresh(new Guid(ddlPayInCurrency.SelectedValue));

			Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoPayOutCurrency
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

			aoPayOutCurrency.Refresh(new Guid(ddlPayOutCurrency.SelectedValue));

			if(!calculatePayOut) {
				try {
					payinCurrency = decimal.Parse(txtPayInAmount.Text);
					//payoutCurrency = payinCurrency * agentRate.Value;
					payoutCurrency = payinCurrency * Convert.ToDecimal(providedExchangeRate.ToString());
				}catch{
					Message = "Error determining the payin amount! Please provide the pay-in amount.";
					butInititateTransactionBlocker++;
					return;
				}
				txtPayOutAmount.Text =  decimal.Round(payoutCurrency, aoPayOutCurrency.Col_Scale.Value).ToString();
			} else {
				try {
					payoutCurrency = decimal.Parse(txtPayOutAmount.Text);
					//payinCurrency = payoutCurrency / agentRate.Value;
					payinCurrency = payoutCurrency / Convert.ToDecimal(providedExchangeRate.ToString());
				}catch{}
				txtPayInAmount.Text = decimal.Round(payinCurrency, aoPayInCurrency.Col_Scale.Value).ToString();
			}

			if(((aoPayOutCurrency.Col_Code.Value).ToString() == "Rs.")&&(payoutCurrency > 49999))
			{
				Message = "The maximum amount you can send is Rs. 49,999.";
				butInititateTransactionBlocker++;
				return;
			}

			////////////////////////////////////////////////////////////// 29/06 Ali.
			ListItem li = ddlDestinationModeOfPayment.SelectedItem;

			if(null!=li) 
			{
				Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList aoPaymentMode
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList(ConfigHelper.ConStr);
				aoPaymentMode.Refresh(li.Value);

				if((aoPayOutCurrency.Col_Code.Value).ToString() == "MYR")
				{
					if (aoPaymentMode.Col_Prefix.Value == "CTA")
					{
						if(payoutCurrency < 1000)
						{
							Message = "Amount less then 1000 MYR can not be sent as CTA.";
							butInititateTransactionBlocker++;
							return;
						}
					}
					else if(aoPaymentMode.Col_Prefix.Value == "COC")
					{
						if(payoutCurrency < 5000)
						{
							Message = "Amount less then 5000 MYR can not be sent as COC.";
							butInititateTransactionBlocker++;
							return;
						}
					}
				}
			}
			//////////////////////////////////////////////////////////////

			GetCommissionDetails();
			UpdatePanelDisplay();

			if(!ValidateTransaction()) 
			{
				return;
			}
			//ValidateTransaction();
		}

		private void UpdatePanelDisplay() {
			CommissionRate cr = (CommissionRate) ViewState["CommissionRate"];
			AgentExchangeRate agentRate = (AgentExchangeRate) ViewState["AgentExchangeRate"];

			lblTDPayInAmount.Text = txtPayInAmount.Text;
			lblTDPayInCurrency.Text = agentRate.AgencyRate.BankRate.PayInUnitExchangeRate.UnitCurrency.Code;
			lblTDPayOutAmount.Text = txtPayOutAmount.Text;
			lblTDPayOutCurrency.Text = agentRate.AgencyRate.BankRate.PayOutUnitExchangeRate.UnitCurrency.Code;
			lblTDModeOfPayment.Text = ddlDestinationModeOfPayment.SelectedItem.Text;
			lblTDExchangeRate.Text = txtExchangeRate.Text;
			lblTDTotalPayableCurrency.Text = agentRate.AgencyRate.BankRate.PayInUnitExchangeRate.UnitCurrency.Code;

			decimal commissionAmount=0;

			if(ddlPayInCurrency.SelectedItem.Text!="USD") {
				if(ddlPayOutCurrency.SelectedItem.Text=="USD") {
					if(cr!=null)
						commissionAmount = cr.BaseToUSDCommissionAmount;
					else
						Message="No Commission slab found for the provided range!";

				} else {
					if(cr!=null)
						commissionAmount = cr.BaseToBaseCommissionAmount;
					else
						Message="No Commission slab found for the provided range!";
				}
			} else {
				if(ddlPayOutCurrency.SelectedItem.Text=="USD") {
					if(cr!=null)
						commissionAmount = cr.BaseToUSDCommissionAmount;
					else
						Message="No Commission slab found for the provided range!";
				} else {
					if(cr!=null)
						commissionAmount = cr.BaseToBaseCommissionAmount;
					else
						Message="No Commission slab found for the provided range!";
				}
			}

			lblTDCommissionCurrency.Text = lblTDPayInCurrency.Text;

			commissionAmount = decimal.Round(commissionAmount, agentRate.AgencyRate.BankRate.PayInUnitExchangeRate.UnitCurrency.Scale);

			lblTDCommissionAmount.Text = commissionAmount.ToString();
            lblTDTotalPayableAmount.Text = (decimal.Parse(txtPayInAmount.Text)+commissionAmount).ToString();
		}

		private void InitiateTransfer_PreRender(object sender, System.EventArgs e) {
			butInitiateTransfer.Enabled = butCalculate.Enabled;

			if(butInititateTransactionBlocker>0) {
				butInitiateTransfer.Enabled=false;
			} else {
				butInitiateTransfer.Enabled=true;
			}

			if(pnlMiddlePartBlocker>0) {
				pnlMiddlePart.Visible=false;
			} else {
				pnlMiddlePart.Visible=true;
			}

			if(pnlBottomPartBlocker>0) {
				pnlBottomPart.Visible=false;
			} else {
				pnlBottomPart.Visible=true;
			}

			if(pnlBeneficeryBankDetailsBlocker>0) {
				pnlBeneficeryBankDetails.Visible=false;
			} else {
				pnlBeneficeryBankDetails.Visible=true;
			}

			if(pnlBenBankExtraDetailsBlocker>0) {
				pnlBenBankExtraDetails.Visible=false;
			} else {
				pnlBenBankExtraDetails.Visible=true;
			}

			if(pnlBenBankNameBlocker>0) {
				pnlBenBankName.Visible = false;
			} else {
				pnlBenBankName.Visible = true;
			}

			if(pnlBenBankBranchNameBlocker>0) {
				pnlBenBankBranchName.Visible = false;
			} else {
				pnlBenBankBranchName.Visible = true;
			}

			if(!visibilityBasedOnModeOfPaymentExecuted) {
				UpdateVisibilityBasedOnModeOfPayment();
			}
	}

		private void ddlPayOutCurrency_SelectedIndexChanged(object sender, System.EventArgs e) {
			UpdateExchangeRate();
		}

		private void ddlDestinationModeOfPayment_SelectedIndexChanged(object sender, System.EventArgs e) {
			BindPurposeOfTransfer();
			UpdateBeneficeryBankSelectedCountry();
			UpdateLocationForModeOfPayment();
			BindDestinationAgentOrBank();
			butDestinationAgentFilter_Click(sender,e);
			UpdateVisibilityChecks();
		}

		private void UpdateLocationForModeOfPayment() {
			ListItem li = ddlDestinationModeOfPayment.SelectedItem;
			ListItem liCountry = ddlDestinationCountry.SelectedItem;

			if(li!=null && liCountry != null) {
				Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList aoPaymentMode
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList(ConfigHelper.ConStr);
				aoPaymentMode.Refresh(li.Value);
				
				string query=string.Empty;

				if(aoPaymentMode.Col_ChannelThrough.Value=="Bank") {
					query = @" Select Name Display, Id [ID1] From LocationList 
					Where Id In (Select Distinct LocationId	From BankList Where Id In (Select BankId From BankAvailablePaymentModeList Where PaymentMode='"+ li.Value +@"' OR BankId Not In (Select BankId From BankAvailablePaymentModeList)))
					And CountryId ='"+ liCountry.Value +"' Order by Name";
				} else if(aoPaymentMode.Col_ChannelThrough.Value=="Agent"){
					query = @" Select Name Display, Id [ID1] From LocationList 
					Where Id In (Select 
					Distinct
					LocationId
					From AgentLocationList 
					Where 
					(Id In (Select AgentId From AgentAvailablePaymentModeList Where PaymentMode='"+ li.Value +@"') 
					OR Id Not In (Select AgentId From AgentAvailablePaymentModeList)) 
					And Active=1)
					And CountryId ='"+ liCountry.Value +"' Order by Name";
				}

				DataSet dsLoc = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					query);

				ddlDestinationLocation.DataSource = dsLoc;
				ddlDestinationLocation.DataBind();
			}
		}

		private string GenerateTransactionNumber(string paymentModePrefix) 
		{
			string trNum = String.Empty;
			//If the Destination Country is India - Speed Cash then use GetZohaTransactionNumber() to generate transaction number
			if ((ddlDestinationCountry.SelectedItem.Text.StartsWith("INDIA - SPEED"))||(ddlDestinationCountry.SelectedItem.Text.StartsWith("BANGLADESH - SPEED")))
			{
				trNum = GetZohaTransactionNumber();
				String deleteme = trNum;
			}
			else
			{
				Random rdm1 = new Random(unchecked((int)DateTime.Now.Ticks)); 

				int num = 0;

				bool gotUnique=false;

				DataSet ds = null;

				while(!gotUnique) 
				{
					num = rdm1.Next(20000000,99999999);

					ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
						CommandType.Text,
						"Select TransactionNumber From TransactionDetails Where TransactionNumber='"+ trNum + num +"'");

					if(ds.Tables[0].Rows.Count<1) 
					{
						gotUnique=true;
						trNum += num;
					}
				}
			}
			return trNum;
		
		}

		private void ddlDestinationLocation_SelectedIndexChanged(object sender, System.EventArgs e) 
		{
			BindDestinationAgentOrBank();
			txtDestinationAgentAddress.Text = string.Empty;
			butDestinationAgentFilter_Click(sender,e);
			UpdateVisibilityBasedOnModeOfPayment();
		}

		private void ddlBeneficerySelection_SelectedIndexChanged(object sender, System.EventArgs e) {
			BindBeneficeryDetails();
		}

		private void ddlBeneficeryBankSelection_SelectedIndexChanged(object sender, System.EventArgs e) {
			BindBeneficeryBankDetails();
		}

		private void butInitiateTransfer_Click(object sender, System.EventArgs e) {
			UpdateVisibilityBasedOnModeOfPayment();
			if(!Page.IsValid){
				Page.Validate();
				return;
			}
			DoCalculation(false);
			if(!ValidateTransaction()) 
			{
				return;
			}
			decimal providedExchangeRate=0,MinimumExchangeRate=0,MaximumExchangeRate=0;
			try	{
				providedExchangeRate = decimal.Parse(txtExchangeRate.Text);
			}catch{
				Message = "Error determining the exchange rate! Please provide an valid exchange rate!";
				butInititateTransactionBlocker++;
				return;	}
			if ((lblMinimumExchangeRate.Text != null)&&(User.IsInRole(UserRoles.ExchangeRateChangerDuringTransaction.ToString())))
			{
				try
				{
					MinimumExchangeRate = decimal.Parse(lblMinimumExchangeRate.Text);
				}
				catch
				{
					Message = "Error determining the minimum exchange rate.3";
					return;
				}
			}
			if ((lblMaximumExchangeRate.Text != null)&&(User.IsInRole(UserRoles.ExchangeRateChangerDuringTransaction.ToString())))
			{
				try
				{
					MaximumExchangeRate = decimal.Parse(lblMaximumExchangeRate.Text);
				}
				catch
				{
					Message = "Error determining the maximum exchange rate.4";
					return;
				}
			}
			if(User.IsInRole(UserRoles.ExchangeRateChangerDuringTransaction.ToString()))
			{
				if((providedExchangeRate<MaximumExchangeRate)||(providedExchangeRate>MinimumExchangeRate))
				{
					lblMessage.Text = "Please enter an exchange rate within the specified range.2";
					//butInititateTransactionBlocker++;
					return;
				}
			}
			/****
			 * 
			 * 
			 * Validate inputs
			 * 
			 * 
			 * ****/
			// Check the payin and payout currency values
			if(txtPayInAmount.Text==String.Empty
				||
				txtPayOutAmount.Text==String.Empty) {
				Message = "Payin / Payout amount cannot be blank values!";
				return;
			}

			// Check if the payin amount is lesser than 0
			if(decimal.Parse(txtPayInAmount.Text)<1
				||
				decimal.Parse(txtPayOutAmount.Text)<1) {
				Message = "PayIn / Payout amount cannot be zero!";
				return;
			}

			// Check for recommended payout agent
			ListItem liPayOutAgent = ddlDestinationAgent.SelectedItem;
			ListItem liPayOutBank = ddlDestinationBank.SelectedItem;

			if(liPayOutAgent==null && liPayOutBank==null) {
				Message="Payout Agent or Bank has to be selected!";
				return;
			}

			// Mode of payment 
			ListItem liModeOfPayment = ddlDestinationModeOfPayment.SelectedItem;

			if(liModeOfPayment==null) {
				Message="Mode of payment has to be selected!";
				return;
			}

			// Purpose of transfer
			ListItem liPurpose = ddlPurposeOfTransfer.SelectedItem;
			if(liPurpose==null) {
				Message="Purpose of transfer has to be selected!";
				return;
			}

			// Check if either customer mobile or telephone is entered
			if(txtCustomerTelephone.Text==String.Empty
				&&
				txtCustomerMobile.Text==String.Empty) {
				Message = "Either customer telephone number or mobile is needed!";
				return;
			}

			// Check if either beneficery mobile or telephone is entered
			if(txtBeneficeryTelephone.Text==String.Empty
				&&
				txtBeneficeryMobile.Text==String.Empty) {
				Message = "Either beneficiary telephone number or mobile is needed!";
				return;
			}

			DateTime cusIdExpiry = DateTime.Today;
			try {
				if(txtCustomerIdExpiry.Text!=String.Empty) {
					cusIdExpiry = DateTime.Parse(txtCustomerIdExpiry.Text);
				}
			}catch{
				Message = "Entered ID Expiry date is not valid!";
				return;
			}

			Message = String.Empty;
			AgentExchangeRate agentRate = (AgentExchangeRate) ViewState["AgentExchangeRate"];
			CommissionRate cr = (CommissionRate) ViewState["CommissionRate"];
			
			decimal payinAmount = 0;
			decimal commissionAmount = 0;
			decimal remainingCreditBalance = 0;

			try {
				payinAmount = decimal.Parse(txtPayInAmount.Text);
			}catch{
				Message = "PayIn Amount is not a valid decimal!";
				return;
			}

			try {
				commissionAmount = decimal.Parse(lblTDCommissionAmount.Text);
			}catch{}

			try {
				remainingCreditBalance = decimal.Parse(lblCreditBalance.Text);
			}catch{}

			string transactionStatus = TransactionStatus.PendingApproval.ToString();
			string transactionSettlementStatus = TransactionSettlementStatus.UnPaid.ToString();
			
			Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList aopaymentModeList
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList(ConfigHelper.ConStr);
			aopaymentModeList.Refresh(ddlDestinationModeOfPayment.SelectedValue);

			string transactionNumber = GenerateTransactionNumber(aopaymentModeList.Col_Prefix.Value);
			Guid transactionId = Guid.NewGuid();
			Guid customerId = Guid.NewGuid();
			Guid beneficeryId = Guid.NewGuid();
			Guid beneficeryBankId = Guid.NewGuid();
			Guid userId = new Guid(ddlOriginUser.SelectedValue);
			Guid payinCurrencyId = new Guid(ddlPayInCurrency.SelectedValue);
			Guid payoutCurrencyId = new Guid(ddlPayOutCurrency.SelectedValue);
			string paymentMode = ddlDestinationModeOfPayment.SelectedValue;
			string purposeOfTransfer = ddlPurposeOfTransfer.SelectedValue;
			decimal payoutAmount = decimal.Parse(lblTDPayOutAmount.Text);
			decimal finalMargin = -(((providedExchangeRate-agentRate.AgencyRate.Value)/agentRate.AgencyRate.Value)*100);

			System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigHelper.ConStr);
			con.Open();
			System.Data.SqlClient.SqlTransaction trans = con.BeginTransaction();

			if(lblCustomerRecordStatus.Text!="New") 
			{
				if(ViewState["CustomerId"]!=null) {
					customerId = (Guid) ViewState["CustomerId"];
				} else {
					Message = "Please provide the customer detail!";
					return;
				}
			}
			else
			{
				DataSet dsCard = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select * From CustomerCardList Where Id Not In (Select CardId From CustomerList Where CardId Is Not Null)  And AgentId='"+ ddlOriginAgent.SelectedValue +"' Order by Code");

				if(dsCard.Tables[0].Rows.Count>0) 
				{
					try 
					{
						SqlHelper.ExecuteNonQuery(trans,
							CommandType.Text,
							@"INSERT INTO [CustomerList]([Id], [LoginName], [Password], [FirstName], [LastName], [CardId], [Address], [Telephone], [Fax], [Mobile], [Email], [IDType], [IDDetails], [IDExpirationDate], [Nationality], [Active], [AccountActivated], [CardIssued])
						VALUES('"+ customerId.ToString() +@"',
						'"+ customerId.ToString() +@"',
						'',
						'"+ txtCustomerFirstName.Text +@"',
						'"+ txtCustomerLastName.Text +@"',
						'"+ dsCard.Tables[0].Rows[0]["Id"].ToString() +@"',
						'"+ txtCustomerAddress.Text +@"',
						'"+ txtCustomerTelephone.Text +@"',
						NULL,
						'"+ txtCustomerMobile.Text +@"',
						'"+ txtCustomerEmailId.Text +@"',
						'"+ txtCustomerIdType.Text +@"',
						'"+ txtCustomerIdDetails.Text +@"',
						'"+ txtCustomerIdExpiry.Text +@"',
						'"+ ddlCustomerNationality.SelectedValue +@"',
						1,
						0,
						1)");

						SqlHelper.ExecuteNonQuery(trans,
							CommandType.Text,
							"Update CustomerCardList Set Status='"+ CardStatus.AssignedToCustomer.ToString() +"' Where Id='"+ dsCard.Tables[0].Rows[0]["Id"].ToString() +"'");

					}
					catch(Exception ex)
					{
						trans.Rollback();
						Trace.Warn("Level 1:",ex.Message,ex);
						Exception ie = ex.InnerException;
						while(ie!=null) 
						{
							Trace.Warn("Level 1",ie.Message,ie);
							ie = ie.InnerException;
						}
						Message = "Level 1 : Could not complete the transaction! Please contact the support personnel" + ex.Message;
						return;
					}
					finally
					{
						//ViewState["CardId"] = dsCard.Tables[0].Rows[0]["Id"].ToString();
					}
				} 
				else 
				{
					Message = "No customer cards exists under your account, Please contact SR Customer Support for information!";
					return;
				}
				
			}
			/////////////////////////////////////////////////////////////////////////////////
			// Ali code starts. 12/06/05 Purpose.. Bangladesh Id Mandatory.
			Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList aoPayOutCurrency
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_CurrencyList(ConfigHelper.ConStr);

			aoPayOutCurrency.Refresh(new Guid(ddlPayOutCurrency.SelectedValue));

			if(((aoPayOutCurrency.Col_Code.Value).ToString() == "BTK")&&(txtBeneficeryAddress.Text == String.Empty))
			{
				Message = "Please enter a valid ID Details of the beneficery.";
				trans.Rollback();
				return;
			} 
			// Ali code ends..	12/06/05
			/////////////////////////////////////////////////////////////////////////////////
			if(lblBeneficeryStatus.Text!="New") {
				if(ViewState["BeneficeryId"]!=null) {
					beneficeryId = (Guid) ViewState["BeneficeryId"];
				} else {
					Message="Please provide the beneficiary details!";
					return;
				}
			} else {
				try {
					string beneficeryInsertQuery = @"INSERT INTO [CustomerList]([Id], [LoginName], [Password], [FirstName], [LastName], [CardId], [Address], [Telephone], [Fax], [Mobile], [Email], [IDType], [IDDetails], [IDExpirationDate], [Nationality], [Active], [AccountActivated], [CardIssued])
						VALUES('"+ beneficeryId.ToString() +@"',";
					beneficeryInsertQuery += "'"+beneficeryId.ToString()+"',";
					beneficeryInsertQuery += @"'',
						'"+ txtBeneficeryFirstName.Text +@"',
						'"+ txtBeneficeryLastName.Text +@"',";
					beneficeryInsertQuery += "NULL,";
					beneficeryInsertQuery += "'"+ txtBeneficeryAddress.Text +@"',
						'"+ txtBeneficeryTelephone.Text +@"',
						NULL,
						'"+ txtBeneficeryMobile.Text +@"',
						'"+ txtBeneficeryEmailId.Text +@"',
						'"+ txtBeneficeryIdType.Text +@"',
						NULL,";
					beneficeryInsertQuery += @"NULL,";
					beneficeryInsertQuery += @"'"+ ddlBeneficeryNationality.SelectedValue +@"',
						1,
						0,
						1)";
					SqlHelper.ExecuteNonQuery(trans,
						CommandType.Text,
						beneficeryInsertQuery);
				} catch(Exception ex) {
					trans.Rollback();
					Message = "Level 2 : Transaction could not be completed! Please contact the support personnel";

					Exception ie = ex.InnerException;
					Trace.Warn("Level 2",ex.Message,ex);

					while(ie != null) {
						Trace.Warn("Level 2",ie.Message,ie);
						ie = ie.InnerException;
					}

					return;
				}
			}

			TransactionValidationResult tvr = new TransactionValidationResult(true,"");

			tvr = TransactionManager.ValidateAgainstNumberOfTransactionsPerYear(customerId, beneficeryId, new Guid(ddlDestinationCountry.SelectedValue));

			if(!tvr.WasSuccess) {
				lblInitateTransferMessage.Text = tvr.Message;
				//Message = tvr.Message;
				return;
			}

			if(aopaymentModeList.Col_FinalEntity.Value=="Bank"
				||
				aopaymentModeList.Col_FinalEntity.Value=="FixedBank"
				||
				aopaymentModeList.Col_ChannelThrough.Value=="Bank") {
				if(lblBeneficeryBankRecordStatus.Text != "New") {
					if(ViewState["BeneficeryBankId"]!=null) {
						beneficeryBankId = (Guid) ViewState["BeneficeryBankId"];
					} else {
						Message = "Beneficery Bank details are not provided!";
						return;
					}
				} else {
					try {
						SqlHelper.ExecuteNonQuery(trans,
							CommandType.Text,
							@"INSERT INTO [BeneficeryBankList]([Id], [CustomerId], [RegistrationDateTime], [AccountNumber], [Name], [BranchName], [Address], [ZipCode], [CountryId])
					VALUES(
					'"+ beneficeryBankId.ToString() +@"',
					'"+ customerId.ToString() +@"',
					getdate(),
					'"+ txtBeneficeryBankAccountNumber.Text +@"',
					'"+ txtBeneficeryBankName.Text +@"',
					'"+ txtBeneficeryBankBranchName.Text +@"',
					'"+ txtBeneficeryBankAddress.Text +@"',
					'"+ txtBeneficeryBankZip.Text +@"',
					'"+ ddlBeneficeryBankCountry.SelectedValue +"')");
					}catch{
						trans.Rollback();
						Message = "Level 3 : Transaction could not be completed! Please contact the support personnel";
						return;
					}
				}
			}

			//////////////////////////////////////////////////////////////////22/06/2005
/*			OFAC = string.Empty;

			// Check for OFAC Name List matches and set flag.
			DataSet dsCustOFACNames = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"select * from OFACList where Name Like '%" + txtCustomerFirstName.Text + " " + txtCustomerLastName.Text + "%'");
			if(dsCustOFACNames.Tables[0].Rows.Count>0)
			{
				OFAC = "COFAC";
			}

			// Check for OFAC Name List matches and set flag.
			DataSet dsBenefOFACNames = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"select * from OFACList where Name Like '%" + txtBeneficeryFirstName.Text + " " + txtBeneficeryLastName.Text + "%'");
			if(dsBenefOFACNames.Tables[0].Rows.Count>0)
			{
				OFAC = "BOFAC";
			}*/
			//////////////////////////////////////////////////////////////////22/06/2005 ends.

			if(User.IsInRole(UserRoles.Administrator.ToString())
				||
				User.IsInRole(UserRoles.AgentLocationPayInTransactonApprover.ToString()))
				//||User.IsInRole(UserRoles.AgentAccountManager.ToString())) 
				{
				transactionStatus = TransactionStatus.UnPaid.ToString();
			}// else if OFAC flag set transactionStatus = TransactionStatus.OFACBlocked.ToString();

			string query = @"INSERT INTO [TransactionDetails]([Id], [TransactionNumber], [CustomerId], [BeneficeryId], [BeneficeryBankId], [PaymentMode], [PurposeOfTransfer], [PayInCurrencyId], [PayInAmount], [PayOutCurrencyId], [PayOutAmount], [Commission], [BankExchangeRateForPayInCurrency], [BankExchangeRateForPayOutCurrency], [PayInCurrencyGroup], [PayOutCurrencyGroup], [FinalBankExchangeRate], [AgencyMarginPercent], [AgencyExchangeRate], [AgentMarginPercent], [AgentExchangeRate], [AssociatedBankId], [PayOutLocationId], [PayInAgentUserId], [PayInAgentLocationId], [PayInDateTime], [RecommendedPayOutAgentId], [ActualPayOutAgentId], [PayOutAgentUserId], [PayOutDateTime], [CollectedBeneficeryIdDetails], [IsOpenTransaction], [Status], [SettlementStatus], [PayInCommissionType], [PayInCommissionAmount], [PayOutCommissionType], [PayOutCommissionCurrencyType], [PayOutCommissionAmount])
							VALUES('"+ transactionId.ToString() +@"',
							'"+ transactionNumber +@"',
							'"+ customerId.ToString()+@"',
							'"+ beneficeryId.ToString() +@"'";
			if(aopaymentModeList.Col_FinalEntity.Value=="Bank" || aopaymentModeList.Col_FinalEntity.Value=="FixedBank" || aopaymentModeList.Col_ChannelThrough.Value=="Bank") {
				query+=",'"+ beneficeryBankId.ToString() +@"'";
			} else {
				query+=",NULL";
			}
							query+=@",'"+ paymentMode +@"',
							'"+ purposeOfTransfer +@"',
							'"+ payinCurrencyId.ToString() +@"',
							"+ payinAmount.ToString() +@",
							'"+ payoutCurrencyId.ToString() +@"',
							"+ payoutAmount.ToString() +@",
							"+ commissionAmount.ToString() +@",
							"+ agentRate.AgencyRate.BankRate.PayInUnitExchangeRate.Value.ToString() +@",
							"+ agentRate.AgencyRate.BankRate.PayOutUnitExchangeRate.Value.ToString() +@",
							'"+ agentRate.AgencyRate.BankRate.PayInUnitExchangeRate.ExchangeType.ToString() +@"',
							'"+ agentRate.AgencyRate.BankRate.PayOutUnitExchangeRate.ExchangeType.ToString() +@"',
							"+ agentRate.AgencyRate.BankRate.Value.ToString() + @",
							"+ agentRate.AgencyRate.AgencyMarginPercent.ToString() +@",
							"+ agentRate.AgencyRate.Value.ToString() +@",
							"+ finalMargin.ToString() +","+ providedExchangeRate.ToString();

			if(pnlDestinationBank.Visible) {
				query += ",'"+ddlDestinationBank.SelectedValue+"'";
			} else {
				query += ",NULL";
			}
																  
						query+=@",
							'"+ ddlDestinationLocation.SelectedValue +@"',
							'"+ ddlOriginUser.SelectedValue +@"',
							'"+ ddlOriginAgent.SelectedValue +@"',
							getdate()";
			if(pnlDestinationAgent.Visible) {
				query += ",'"+ddlDestinationAgent.SelectedValue+"'";
			} else {
				query += ",NULL";
			}
							query += @",NULL,
							NULL,
							NULL,
							NULL,
							1,
							'"+ transactionStatus +@"',
							'"+ transactionSettlementStatus +@"',
							'"+ cr.PayInCommissionType.ToString() +@"',
							"+ cr.PayInCommissionAmount.ToString() +@",
							'"+ cr.PayOutCommissionType.ToString() +@"',
							'"+ cr.PayOutCurrencyType.ToString() +@"',
							"+ cr.PayOutCommissionAmount.ToString() +" )";

			try {
				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					query);
				ViewState["CustIdEMC"] = customerId.ToString();
			}catch(Exception ex){
				trans.Rollback();
				Message = "Level 5 : Transaction could not be completed! Please contact the support personnel";
				Trace.Warn("Level 5",ex.Message,ex);

				Exception ie = ex.InnerException;

				while(ie!=null) {
					Trace.Warn("Level 5",ie.Message,ie);
					ie = ie.InnerException;
				}

				return;
			}

			Trace.Write(query);

			/****
			 * 
			 * Account Details
			 * 
			 * *********/
			decimal payinCommission = 0;
			decimal payoutCommission = 0;
			decimal agencyCommission = commissionAmount;
			decimal payoutCommissionUSD = 0;

			// PayIn + Commission amount
			decimal totalAmount = payinAmount + commissionAmount;
			
			// agencyAmount = Principle the Agent has to pay SR
			decimal agencyAmount = (payinAmount - (payinAmount * (finalMargin/100)));
			decimal agentDifferenceIncomeAmount = payinAmount - agencyAmount;
			

			if(cr.PayInCommissionType == CommissionType.Fixed) {
				payinCommission = cr.PayInCommissionAmount;
			} else {
				payinCommission = (commissionAmount * (cr.PayInCommissionAmount/100));
			}

			agencyCommission = agencyCommission-payinCommission;

			// Payout commission calculation

			if(cr.PayOutCommissionType == CommissionType.Fixed) {
				decimal commissionUSD = 0;
				if(cr.PayOutCurrencyType == CommissionCurrencyType.Base) {
					commissionUSD = cr.PayOutCommissionAmount * agentRate.AgencyRate.BankRate.PayOutValue;
				} else {
					commissionUSD = cr.PayOutCommissionAmount;
				}
				decimal commissionLC = commissionUSD / agentRate.AgencyRate.BankRate.PayInValue;
				payoutCommission = commissionLC;
				payoutCommissionUSD = commissionUSD;
			} else {
				if(cr.PayOutCurrencyType == CommissionCurrencyType.Base) {
					decimal commissionUSD=0;
					decimal amountToPay = (commissionAmount *  (cr.PayOutCommissionAmount/100)) ;
					commissionUSD = amountToPay * agentRate.AgencyRate.BankRate.PayInValue;
					decimal commissionLC = commissionUSD / agentRate.AgencyRate.BankRate.PayInValue;
					payoutCommission = commissionLC;
					
					payoutCommissionUSD = commissionUSD;
				} else {
					payoutCommission = (commissionAmount * (cr.PayOutCommissionAmount/100));
					payoutCommissionUSD = agentRate.AgencyRate.BankRate.PayInValue;
				}
				
			}

			agencyCommission = agencyCommission - payoutCommission;
			payoutCommission = payoutCommission * agentRate.Value;
		
			Guid agentAccountId = AgentManager.GetAgentAccountForAgentLocation(new Guid(ddlOriginAgent.SelectedValue));
			
			try {
				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					"Insert Into AgentAccountDetails Values(newid(),NULL,getdate(),'"+ agentAccountId.ToString() +"','"+ transactionId.ToString() +"',0,0,"+ (agencyAmount+commissionAmount).ToString() +","+ ((agencyAmount+commissionAmount) * agentRate.AgencyRate.BankRate.PayInValue).ToString() +")");

				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					"Insert Into AgentCommissionIncomeAccount Values(newid(),getdate(),NULL,'"+agentAccountId.ToString()+"','"+transactionId.ToString()+"',"+ payinCommission.ToString() +","+ (payinCommission * agentRate.AgencyRate.BankRate.PayInValue).ToString() +",0,0)");

				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					"Insert Into TransitionAccountDetails Values (newid(),getdate(),NULL,'"+transactionId.ToString()+"',"+ payoutAmount.ToString() +","+ (agencyAmount * agentRate.AgencyRate.BankRate.PayInValue).ToString() +",0,0,"+ payoutCommission.ToString() +","+ payoutCommissionUSD.ToString() +",0,0)");

				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					"Insert Into AgencyCommissionIncomeAccountDetails Values (newid(),getdate(),'"+ transactionId.ToString() +"',"+ agencyCommission.ToString() +","+ (agencyCommission * agentRate.AgencyRate.BankRate.PayInValue).ToString() +",0,0)");

				SqlHelper.ExecuteNonQuery(trans,
					CommandType.Text,
					"Insert Into CustomerLoyaltyPointsAccumulationHistory Values(newid(), getdate(), '"+ customerId.ToString() +"','"+ transactionId.ToString() +"',"+ decimal.Round((commissionAmount * agentRate.AgencyRate.BankRate.PayInValue),0) +")");
			}catch(Exception ex){
				trans.Rollback();
				Message = "Level 10 : System could not complete the transaction successfully! Please contact the support personnel";
				Exception ie = ex.InnerException;
				Trace.Warn("Level 10",ex.Message,ex);

				while(ie != null) {
					Trace.Warn("Level 10",ie.Message,ie);
					ie = ie.InnerException;
				}
				return;
			}

			trans.Commit();

			//////////////////////////////////////////////////////////////////////////////////	
			// Appended by Ali (280505001)
			decimal AgentRateforUSD = agentRate.AgencyRate.BankRate.PayInUnitExchangeRate.Value;
			decimal payinLC, payinUSD;
			try 
			{
				payinLC  = decimal.Parse(txtPayInAmount.Text);
				payinUSD = payinLC * AgentRateforUSD;
			}
			catch
			{
				Message = "Error determining the payin amount! Please provide the pay-in amount.";
				butInititateTransactionBlocker++;
				return;
			}
			String strEMCNumber = String.Empty;
			if(payinUSD>100)
			{
				String strCustIdEMC = ViewState["CustIdEMC"].ToString();
				DataSet dsCard2 = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"select ccl.Id as Id from transactiondetails td join customerlist cl on td.Customerid = cl.id join customercardlist ccl on cl.cardid = ccl.id where td.CustomerId = '" + strCustIdEMC + "'");

				strEMCNumber = GetEMCNumber(strCustIdEMC);
				String qryInsEMC = "Update CustomerCardList Set EMCNumber = '" + strEMCNumber + "' Where Id='"+ dsCard2.Tables[0].Rows[0]["Id"].ToString() +"'";
				SqlConnection EMCConn = new SqlConnection(ConfigHelper.ConStr);
				SqlCommand cmdInsertEMC = new SqlCommand(qryInsEMC, con);
				cmdInsertEMC.ExecuteNonQuery();
				// Works fine but halted after functioning for 2 days. (31st May, 1st June).
				/*if(!IssueCoupons(strEMCNumber, payinUSD))
					return;*/
				ViewState["CustIdEMC"] = null;
			}
			// Appended ends.
			//////////////////////////////////////////////////////////////////////////////////
			con.Close();
			string urlToBeRediretedTo = "ShowReceipt.aspx?Id="+transactionId.ToString();
			//if(OFAC!=string.Empty)
			//	urlToBeRediretedTo += "&OFAC=" + OFAC.ToString();
			urlToBeRediretedTo = Server.UrlEncode(urlToBeRediretedTo);

			Response.Redirect("Redirector.aspx?ru="+urlToBeRediretedTo);
		}

		private void ddlOriginUser_SelectedIndexChanged(object sender, System.EventArgs e) {
			UpdateVisibilityBasedOnUserRights();
		}

		private void butUpdateCustomerRecord_Click(object sender, System.EventArgs e) {
			Guid customerId = (Guid) ViewState["CustomerId"];
			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
				"Update CustomerList Set FirstName='"+ txtCustomerFirstName.Text +"', LastName='"+ txtCustomerLastName.Text +"', Address='"+ txtCustomerAddress.Text +"', Telephone='"+ txtCustomerTelephone.Text +"', Fax=NULL, Mobile='"+ txtCustomerMobile.Text +"', Email='"+ txtCustomerEmailId.Text +"', IDType='"+ txtCustomerIdType.Text +"', IDDetails='"+ txtCustomerIdDetails.Text +"',IDExpirationDate='"+ txtCustomerIdExpiry.Text +"',Nationality='"+ ddlCustomerNationality.SelectedValue +"' Where Id='"+ customerId.ToString() +"'");
		}

		private void butUpdateBeneficeryRecord_Click(object sender, System.EventArgs e) {
			Guid beneficeryId = (Guid) ViewState["BeneficeryId"];

			string beneficeryUpdateQuery = "Update CustomerList Set FirstName='"+ txtBeneficeryFirstName.Text +"', LastName='"+ txtBeneficeryLastName.Text +"', Address='"+ txtBeneficeryAddress.Text +"', Telephone='"+ txtBeneficeryTelephone.Text +"', Fax=NULL, Mobile='"+ txtBeneficeryMobile.Text +"', Email='"+ txtBeneficeryEmailId.Text +"', IDType='"+ txtBeneficeryIdType.Text +"', IDDetails=NULL,";

			beneficeryUpdateQuery += "IDExpirationDate=NULL,";
			beneficeryUpdateQuery += "Nationality='"+ ddlBeneficeryNationality.SelectedValue +"' Where Id='"+ beneficeryId.ToString() +"'";

			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
				beneficeryUpdateQuery);
		}

		private void butUpdateBeneficeryBankRecord_Click(object sender, System.EventArgs e) {
			Guid customerId = (Guid) ViewState["CustomerId"];
			Guid beneficeryBankId = (Guid) ViewState["BeneficeryBankId"];

			string beneficeryBankUpdateQuery = "Update BeneficeryBankList Set CustomerId='"+ customerId.ToString() +"', AccountNumber='"+ txtBeneficeryBankAccountNumber.Text +"', Name='"+ txtBeneficeryBankName.Text +"', BranchName='"+ txtBeneficeryBankBranchName.Text +"', Address='" + "', ZipCode='"+ txtBeneficeryBankZip.Text +"', CountryId='"+ ddlBeneficeryBankCountry.SelectedValue +"' Where Id='"+ beneficeryBankId.ToString() +"'";

			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
				beneficeryBankUpdateQuery);
		}

		private void chbxCreateNewCustomer_CheckedChanged(object sender, System.EventArgs e) {
			if(chbxCreateNewCustomer.Checked) {
				ClearCustomerDetails();
				butCalculate_Click(sender,e);
				BindBeneficerySelection();
				BindBeneficeryDetails();
				BindBeneficeryBankSelection();
				BindBeneficeryBankDetails();
				pnlExistingCustomer.Visible=false;
			} else {
				pnlExistingCustomer.Visible=true;
			}
		}

		private void ClearCustomerDetails() {
			txtCustomerCardNumber.Text = String.Empty;
			lblCustomerRecordStatus.Text="New";
			txtCustomerFirstName.Text = String.Empty;
			txtCustomerLastName.Text = String.Empty;
			txtCustomerMobile.Text = String.Empty;
			txtCustomerTelephone.Text = String.Empty;
			txtCustomerZip.Text = String.Empty;
			txtCustomerIdDetails.Text  = String.Empty;
			txtCustomerIdExpiry.Text = String.Empty;
			txtCustomerIdType.Text  = String.Empty;
		}

		private bool ValidateTransaction() {
			AgentExchangeRate agentRate = (AgentExchangeRate) ViewState["AgentExchangeRate"];
			CommissionRate cr = (CommissionRate) ViewState["CommissionRate"];

			bool isValid = true;


			if(cr==null
				||
				!cr.RangeFound) {
				Message = "Commission not available for the provided range!";
				butInititateTransactionBlocker++;

				isValid=false;
			}

			TransactionValidationResult tvr = new TransactionValidationResult(true,"");

			bool hasValidId = false;

			if(txtCustomerIdType.Text != String.Empty
				&&
				txtCustomerIdDetails.Text != String.Empty
				&&
				txtCustomerIdExpiry.Text != String.Empty) 
			{
				try 
				{
					DateTime dtIDExpiry = DateTime.Parse(txtCustomerIdExpiry.Text);

					if(dtIDExpiry > DateTime.Today) 
					{
						hasValidId=true;
					}
				}
				catch{}
			}
			else
			{
				/*if()	Added but commented out by Ali Akbar Jilani. 
				{
					Message = "Please enter a valid Id.";
					isValid=false;
				}*/
			}

			tvr = TransactionManager.ValidateAgainstOutBoundIDRequirement(new Guid(ddlOriginCountry.SelectedValue), decimal.Parse(txtPayInAmount.Text), hasValidId);

			if(!tvr.WasSuccess) {
				lblInitateTransferMessage.Text = tvr.Message;
				Message = tvr.Message;
				// butInititateTransactionBlocker++;
				// isValid=false;
			} else {
				lblInitateTransferMessage.Text = String.Empty;
			}

			decimal payinAmount = 0;
			decimal commissionAmount = 0;
			decimal remainingCreditBalance = 0;

			try {
				payinAmount = decimal.Parse(txtPayInAmount.Text);
			}catch{
				Message = "PayIn Amount is not a valid decimal!";
				isValid=false;
			}

			try {
				commissionAmount = decimal.Parse(lblTDCommissionAmount.Text);
			}catch{}

			try {
				remainingCreditBalance = decimal.Parse(lblCreditBalance.Text);
			}catch{}

			Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList aoAgent
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList(ConfigHelper.ConStr);

			aoAgent.Refresh(new Guid(ddlOriginAgent.SelectedValue));

			Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster aoAgentMaster
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster(ConfigHelper.ConStr);

			aoAgentMaster.Refresh(aoAgent.Col_AgentAccountId);

			if(payinAmount>aoAgentMaster.Col_PayInThreshold.Value) {
				Message = "The payin amount is greater than the agent per-transaction limit!";
				isValid=false;
			}

			Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList aoCountry
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_CountryList(ConfigHelper.ConStr);

			aoCountry.Refresh(new Guid(ddlOriginCountry.SelectedValue));

			if(payinAmount > aoCountry.Col_OutboundThresholdPerTransaction.Value) {
				Message = "PayIn amount is greater than the country per-transaction limit!";
				isValid = false;
			}

			Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList aopaymentModeList
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList(ConfigHelper.ConStr);

			aopaymentModeList.Refresh(ddlDestinationModeOfPayment.SelectedValue);

			tvr = TransactionManager.ValidateGlobalThreshold(payinAmount+commissionAmount, agentRate.AgencyRate.BankRate.PayInUnitExchangeRate.Value, aopaymentModeList.Col_FinalEntity.Value);

			if(!tvr.WasSuccess) {
				lblInitateTransferMessage.Text = tvr.Message;
				Message = tvr.Message;
				butInititateTransactionBlocker++;
				isValid=false;
			} else {
				lblInitateTransferMessage.Text = String.Empty;
			}


			tvr = TransactionManager.ValidateAgainstAgentCreditBalance(payinAmount+commissionAmount, agentRate.AgencyRate.BankRate.PayInUnitExchangeRate.Value, remainingCreditBalance);

			if(!tvr.WasSuccess) {
				lblInitateTransferMessage.Text = tvr.Message;
				Message = tvr.Message;
				isValid=false;
			}
			return isValid;
		}

		private void UpdateBeneficiaryBankDetailsByModeOfPayment() {
			Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList aoPayment
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_PaymentModeList(ConfigHelper.ConStr);

			ListItem li = ddlDestinationBank.SelectedItem;

			if(li!=null) {
				aoPayment.Refresh(li.Value);

				if(aoPayment.Col_FinalEntity=="FixedBank") {
					Evernet.MoneyExchange.AbstractClasses.Abstract_BankList aoBank
						= new Evernet.MoneyExchange.AbstractClasses.Abstract_BankList(ConfigHelper.ConStr);

					ListItem liBank = ddlDestinationBank.SelectedItem;

					if(liBank!=null) {
						aoBank.Refresh(new Guid(liBank.Value));

						txtBeneficeryBankName.Text = aoBank.Col_Name.Value;
						txtBeneficeryBankBranchName.Text = aoBank.Col_BranchName.Value;
						txtBeneficeryBankAddress.Text = aoBank.Col_Address.Value;
						txtBeneficeryBankZip.Text = aoBank.Col_ZipCode.Value;
					}
				}
			}
		}

		private void ddlDestinationBank_SelectedIndexChanged(object sender, System.EventArgs e) {
			UpdateBeneficiaryBankDetailsByModeOfPayment();
		}

		private string GetZohaTransactionNumber(){
			//Algorithm for generating Zoha Tr No. as provided by them
			string DateInv = DateTime.Now.Month.ToString().PadLeft(2,'0') + DateTime.Now.Day.ToString().PadLeft(2,'0') + DateTime.Now.Year.ToString().PadLeft(2,'0');
								// MM e.g. 01,  12							// DD e.g. 02,  23								// YY e.g. 2004,  2005
								// DateInv = 05302005 (30th May 2005)
			string InvBranch = "0UK005";
			string InvRec = GetMaxBatchNumber().ToString().PadLeft(8,'0');
								//InvBranch = "0UK005"
								//Positions =  012345
								//InvRec    = 00000123
								//Positions = 01234567
			string KeyZoha = InvRec.Substring(2,1);	//00[0]00123
			KeyZoha += InvRec.Substring(0,1);		//[0]0000123	
			KeyZoha += InvRec.Substring(1,1);		//0[0]000123
			KeyZoha += InvBranch.Substring(1,1);	//0[U]K005   
			KeyZoha += InvBranch.Substring(2,1);	//0U[K]005	
			KeyZoha += InvRec.Substring(4,1);		//0000[0]123
			KeyZoha += InvBranch.Substring(0,1);	//[0]UK005
			KeyZoha += InvRec.Substring(3,1);		//000[0]0123
			KeyZoha += InvBranch.Substring(4,1);	//0UK0[0]5
			KeyZoha += InvRec.Substring(7,1);		//0000012[3]
			KeyZoha += InvBranch.Substring(3,1);	//0UK[0]05
			KeyZoha += InvRec.Substring(5,1);		//00000[1]23
			KeyZoha += InvBranch.Substring(5,1);	//0UK00[5]
			KeyZoha += InvRec.Substring(6,1);		//000001[2]3
			String strDeleteme = KeyZoha;
			//lblMessage.Text = KeyZoha;
			return KeyZoha;
		}

		public string GetMaxBatchNumber()
		{
			string maxno;
			System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigHelper.ConStr);
			con.Open();
			DataSet ds_BNumb = new DataSet("TransactionDetails");
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select coalesce(count(*),0)+38 as trows from TransactionDetails where PayOutCurrencyId In (Select Id from CurrencyList Where Code = 'Rs.' or Code = 'BTK')");

			string str_Query = "Select coalesce(count(*),0)+38 as trows from TransactionDetails where PayOutCurrencyId In (Select Id from CurrencyList Where Code = 'Rs.' or Code = 'BTK')";
			
			SqlDataAdapter da_BNumb = new SqlDataAdapter(str_Query,con);
			da_BNumb.Fill(ds_BNumb,"TransactionDetails");
			maxno = ds_BNumb.Tables[0].Rows[0]["trows"].ToString();
			String strDeleteme = maxno;
			return maxno;
		}

		/// <summary>
		/// Generates a Customer Exclusive Membership Card Number.
		/// </summary>
		/// <param name="customerId">The key to customer record in CustomerList table.</param>
		/// <returns>Exclusive Membership Card as a string.</returns>
		private String GetEMCNumber(String customerId)
		{

			String EmcVal = String.Empty;
			if(customerId.ToString() != String.Empty)// Cases 1,2.
			{
				DataSet dsEMCNumber = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"select ccl.EMCNumber from transactiondetails td join customerlist cl on td.Customerid = cl.id join customercardlist ccl on cl.cardid = ccl.id where td.CustomerId = '" + customerId.ToString() + "'");
					EmcVal = dsEMCNumber.Tables[0].Rows[0][0].ToString();
			}
			else
			{
				EmcVal = String.Empty;
			}
			if(EmcVal == String.Empty)
			{
				// Generate an EMC #.
				ListItem li = ddlOriginCountry.SelectedItem;
				DataSet dsCountryList = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select CountryCode From CountryList where Id = '" + li.Value + "'");
			
				String strCountryCode = dsCountryList.Tables[0].Rows[0][0].ToString();
				ListItem liOriginAgent = ddlOriginAgent.SelectedItem;
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select td.CustomerId, td.PayInAgentLocationId as Id from TransactionDetails td join CustomerList cl on td.CustomerId = cl.Id where td.PayInDateTime >= '05/27/2005' and PayInAgentLocationId = '"+ liOriginAgent.Value + "'");
				String strSerialNumber = (ds.Tables[0].Rows.Count + 1).ToString();

				DataSet dsUpperDigits  = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select PayInDateTime from TransactionDetails where PayInDateTime >= '05/27/2005'");
			
				DataSet dsEMCode  = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"select EMCCode from AgentLocationList where Id = '" + liOriginAgent.Value + "'");
			
				String strEMCode = dsEMCode.Tables[0].Rows[0][0].ToString().Trim();
				String strEMCNumber = strCountryCode + "-0279-1" + strEMCode.PadLeft(3,'0') + "-" + strSerialNumber.PadLeft(4,'0');

				return strEMCNumber;
			}
			else
			{
				// if emc!=null return existing emc# else generate new emc# for existing customer.
				return EmcVal;
			}
		}

		/// <summary>
		/// Issues Coupons for each EMC Number based upon the PayIn Amount in USD.
		/// </summary>
		/// <param name="strEMCNumber">The EMC Number issued to customer as a string.</param>
		/// <param name="dPayInUSDAmount">A decimal value representing the PayIn US Dollar amount.</param>
		/// <returns></returns>
		private bool IssueCoupons(String strEMCNumber,decimal dPayInUSDAmount)
		{
			String strAirTKT = "T";
			int nlCoupons = 0;
			String strDrawType = String.Empty;
			if((dPayInUSDAmount >= 100) && (dPayInUSDAmount < 200))
			{
				strDrawType = "1";
				nlCoupons = 1;
			}
			else if((dPayInUSDAmount >= 200) && (dPayInUSDAmount < 400))
			{
				strDrawType = "2";
				nlCoupons = 2;
			}
			else if(dPayInUSDAmount>400)
			{
				strDrawType = "4";
				int nPayInUSDAmount = Convert.ToInt32(dPayInUSDAmount);
				nlCoupons = (nPayInUSDAmount - (nPayInUSDAmount % 400))/400;
				//Check for proper Coupons
			}

			SqlConnection ARYOffer_Conn = new SqlConnection((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("ARYOffer.ConnectionString").GetValue(0));
			String strOfferQuery = @" Insert into DrawTable( EMCNo, DrawType, Coupons, AirTKT ) Values ('" + strEMCNumber + "','" + strDrawType + "','" + nlCoupons + "','" + strAirTKT + "')";
			SqlCommand cmd_Ins = new SqlCommand(strOfferQuery, ARYOffer_Conn);

			int n_Result = 0;
			try
			{
				cmd_Ins.Connection.Open();
				n_Result = cmd_Ins.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				//throw (ex)
				Message = "Error: " + ex.Message.ToString();//System could not successfully issue coupons, Please contact the support personnel.";
				return false;
			}
			finally
			{
				cmd_Ins.Connection.Close();
			}
			if(n_Result>0)
				return true;
			else
				return false;
		}
		/// <summary>
		/// Filling the form based upon previously known SRTR Number.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void butCheckSRTRNumber_Click(object sender, System.EventArgs e)
		{
			Message = String.Empty;
			txtCustomerCardNumber.Text = String.Empty;

			// Check if the SRTR Number exists in the database
			DataSet dsCustomer = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select td.Id, td.AssociatedBankID, pml.Name From TransactionDetails td Inner Join PaymentModeList pml on td.PaymentMode = pml.Value Where TransactionNumber='"+ txtTransactionNumber.Text.Trim() +"'"); // And AgentId='"+ddlOriginAgent.SelectedValue+"'");

			if(dsCustomer.Tables[0].Rows.Count<1) 
			{
				lblCustomerCardMessage.Text = "The mentioned TransactionNumber number does not exists or has not been assigned to you!";
				return;
			}

			if(chbxCreateNewCustomer.Checked) 
			{
				chbxCreateNewCustomer.Checked=false;
			}

			DataSet dsDest = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select ccl.Code ,td.Id, td.AssociatedBankID From TransactionDetails td Join CustomerList cl on td.CustomerId = cl.Id join CustomerCardList ccl on cl.CardId = ccl.Id Where TransactionNumber='"+ txtTransactionNumber.Text.Trim() +"'"); // And AgentId='"+ddlOriginAgent.SelectedValue+"'");
			txtCustomerCardNumber.Text = dsDest.Tables[0].Rows[0]["Code"].ToString();
			butCheckCustomerCard_Click(sender,e);
			#region Commented.
			/*if(dsCustomer.Tables[0].Rows[0]["AssociatedBankID"].ToString() == string.Empty)
			{
				dsDest = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					@"Select cl.name + ' [' + cl.code + ']' As CountryName, td.CustomerID as CustID, td.BeneficeryID as BenID, td.BeneficeryBankID as BBankID,
							td.PayInAmount as InAmount, l.name as LocationName, pot.Name as PurposeOfTransfer,
							curl.Code as InCode, Ocurl.Code as OutCode,
							al.name as AgentName 
							from
							TransactionDetails td, CountryList cl, AgentLocationList al, LocationList l,
							CurrencyList curl, CurrencyList Ocurl, PurposeOfTransferList pot
							where 
							td.PayInCurrencyId = curl.Id and td.PayOutCurrencyId = Ocurl.Id and
							td.RecommendedPayOutAgentId = al.Id and al.LocationId = l.Id and td.PurposeOfTransfer = pot.Value 
							and l.CountryId = cl.Id and td.TransactionNumber = '"
					+ txtTransactionNumber.Text.Trim() + "'");
					blBankAssociated = false;
			}
			else
			{
				dsDest = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					@"Select cl.name + ' [' + cl.code + ']' As CountryName, td.CustomerID as CustID, td.BeneficeryID as BenID, td.BeneficeryBankID as BBankID,
							td.PayInAmount as InAmount, l.name as LocationName, pot.Name as PurposeOfTransfer,
							curl.Code as InCode, Ocurl.Code as OutCode,
							bl.name as BankName 
							from 
							TransactionDetails td, CountryList cl, BankList bl, LocationList l,
							CurrencyList curl, CurrencyList Ocurl, PurposeOfTransferList pot
							where 
							td.PayInCurrencyId = curl.Id and td.PayOutCurrencyId = Ocurl.Id and
							td.AssociatedbankId = bl.Id and bl.LocationId = l.Id and td.PurposeOfTransfer = pot.Value
							and l.CountryId = cl.Id and td.TransactionNumber = '"
					+ txtTransactionNumber.Text.Trim() + "'");
					blBankAssociated = true;
			}

			ddlDestinationCountry.SelectedIndex = ddlDestinationCountry.Items.IndexOf(ddlDestinationCountry.Items.FindByText(dsDest.Tables[0].Rows[0]["CountryName"].ToString().Trim()));
			ddlDestinationCountry_SelectedIndexChanged(sender,e);
			BindDestinationModeOfPayment();
			ddlDestinationModeOfPayment.SelectedIndex = ddlDestinationModeOfPayment.Items.IndexOf(ddlDestinationModeOfPayment.Items.FindByText(dsCustomer.Tables[0].Rows[0]["Name"].ToString().Trim()));
			//ddlDestinationModeOfPayment_SelectedIndexChanged(sender,e);
			ddlDestinationLocation.SelectedIndex = ddlDestinationLocation.Items.IndexOf(ddlDestinationLocation.Items.FindByText(dsDest.Tables[0].Rows[0]["LocationName"].ToString().Trim()));
			//ddlDestinationLocation_SelectedIndexChanged(sender,e);
			//if(blBankAssociated)
			ddlPurposeOfTransfer.SelectedIndex = ddlPurposeOfTransfer.Items.IndexOf(ddlPurposeOfTransfer.Items.FindByText(dsDest.Tables[0].Rows[0]["PurposeOfTransfer"].ToString().Trim()));
			BindDestinationAgentOrBank();
			if(blBankAssociated)
			{
				BindDestinationBank();
				ddlDestinationBank.SelectedIndex = ddlDestinationBank.Items.IndexOf(ddlDestinationBank.Items.FindByText(dsDest.Tables[0].Rows[0]["BankName"].ToString().Trim()));
				//UpdateBeneficiaryBankDetailsByModeOfPayment();
			}
			else
			{
				BindDestinationAgent();
				ddlDestinationAgent.SelectedIndex = ddlDestinationAgent.Items.IndexOf(ddlDestinationAgent.Items.FindByText(dsDest.Tables[0].Rows[0]["AgentName"].ToString().Trim()));
			}
			ddlPayInCurrency.SelectedIndex = ddlPayInCurrency.Items.IndexOf(ddlPayInCurrency.Items.FindByText(dsDest.Tables[0].Rows[0]["InCode"].ToString().Trim()));
			UpdateExchangeRate();
			ddlPayOutCurrency.SelectedIndex = ddlPayOutCurrency.Items.IndexOf(ddlPayOutCurrency.Items.FindByText(dsDest.Tables[0].Rows[0]["OutCode"].ToString().Trim()));
			UpdateExchangeRate();
			//txtExchangeRate
			//txtPayInAmount.Text = dsDest.Tables[0].Rows[0]["InAmount"].ToString();
			//DoCalculation(true);
			pnlCustomerDetails.Visible = true;
			BindCustomerDetails(dsDest.Tables[0].Rows[0]["CustID"].ToString());
			pnlBeneficeryDetails.Visible = true;
			BindBeneficerySelection(dsDest.Tables[0].Rows[0]["CustID"].ToString());
			BindBeneficeryDetails(new Guid(dsDest.Tables[0].Rows[0]["BenID"].ToString()));
			BindBeneficeryBankDetails(dsDest.Tables[0].Rows[0]["BBankID"].ToString());
			//txtPayOutAmount
			//butDestinationAgentFilter_Click(sender,e);*/
			/*DataSet dsCustomer = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				@"SELECT td.Id, VoucherNumber, TransactionNumber, " +
				"td.CustomerId, td.BeneficeryId, BeneficeryBankId, PaymentMode, PurposeOfTransfer, PayInCurrencyId, " +
				"PayInAmount, PayOutCurrencyId, PayOutAmount, Commission, Question, Answer, MessageToBeneficery, " +
				"MessageToPayOutAgent, BankExchangeRateForPayInCurrency, BankExchangeRateForPayOutCurrency, " +
				"PayInCurrencyGroup, PayOutCurrencyGroup, FinalBankExchangeRate, AgencyMarginPercent, AgencyExchangeRate, " +
				"AgentMarginPercent, AgentExchangeRate, AssociatedBankId, PayOutLocationId, PayInAgentUserId, " +
				"PayInAgentLocationId, PayInDateTime, RecommendedPayOutAgentId, ActualPayOutAgentId, PayOutAgentUserId, " +
				"PayOutDateTime, CollectedBeneficeryIdDetails, IsOpenTransaction, Status, SettlementStatus, PayInCommissionType, " +
				"PayInCommissionAmount, PayOutCommissionType, PayOutCommissionCurrencyType, PayOutCommissionAmount " +
				"FROM " +
				"TransactionDetails TD " +
				"Inner Join CustomerList C1 On TD.CustomerId = C1.Id " +
				"Inner Join CustomerList B1 On TD.BeneficeryId = B1.Id " +
				"Left 	Outer Join BeneficeryBankList On TD.BeneficeryBankId = BeneficeryBankList.Id " +
				"Inner Join PaymentModeList On TD.PaymentMode = PaymentModeList.Value " +
				"Inner Join PurposeOfTransferList On TD.PurposeOfTransfer = PurposeOfTransferList.Value " +
				"Inner Join CurrencyList IC1 On TD.PayInCurrencyId = IC1.Id " +
				"Inner Join CurrencyList OC2 On TD.PayOutCurrencyId = OC2.Id " +
				"Left 	Outer Join BankList On TD.AssociatedBankId = BankList.Id " +
				"Left 	Outer Join UserList IA1 On TD.PayOutAgentUserId = IA1.Id " +
				"Inner Join UserList OA2 On TD.PayInAgentUserId = OA2.Id " +
				"Inner Join AgentLocationList On TD.PayInAgentLocationId = AgentLocationList.Id " +
				"Inner Join TransactionStatusList On TD.Status = TransactionStatusList.Value " +
				"Inner Join TransactionSettlementStatusList On TD.SettlementStatus = TransactionSettlementStatusList.Value " +
				"WHERE TD.TransactionNumber = '"+ txtTransactionNumber.Text +"'");*/
			/*if(dsCustomer.Tables[0].Rows.Count>0)
			{
				DataRow dr = dsCustomer.Tables[0].Rows[0];
				butUpdateCustomerRecord.Visible=true;
			} 
			else 
			{
				lblCustomerCardMessage.Text = "The mentioned card number has no customer records assigned! Please choose to create new customer if you intend to create a new customer";
				Message = lblCustomerCardMessage.Text;
			}*/
			#endregion Commented.
		}

		private void BindCustomerDetails(string strCustomerID)
		{
			DataSet dsCustomer = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From CustomerList Where ID='"+ strCustomerID +"'");

			if(dsCustomer.Tables[0].Rows.Count<1) 
			{
				lblCustomerDetailsMessage.Text = "The mentioned SRTR number had insufficient customer information.";
				Message = lblCustomerDetailsMessage.Text;
				return;
			}

			if(dsCustomer.Tables[0].Rows.Count>0) 
			{
				DataRow dr = dsCustomer.Tables[0].Rows[0];
				txtCustomerFirstName.Text = dr["FirstName"].ToString();
				txtCustomerLastName.Text = dr["LastName"].ToString();
				txtCustomerAddress.Text = dr["Address"].ToString();
				txtCustomerTelephone.Text = dr["Telephone"].ToString();
				txtCustomerMobile.Text = dr["Mobile"].ToString();
				txtCustomerEmailId.Text = dr["Email"].ToString();
				txtCustomerIdType.Text = dr["IDType"].ToString();
				txtCustomerIdDetails.Text = dr["IDDetails"].ToString();
				if(dr["IDExpirationDate"].ToString() == "1/1/1900 12:00:00 AM")
					txtCustomerIdExpiry.Text = string.Empty;
				else
				txtCustomerIdExpiry.Text = dr["IDExpirationDate"].ToString();
				ddlCustomerNationality.SelectedIndex=-1;
				ddlCustomerNationality.Items.FindByValue(dr["Nationality"].ToString()).Selected=true;
			}
		}

		private void BindBeneficeryBankDetails(string strBeneficeryID)
		{
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From BeneficeryBankList Where Id='"+ strBeneficeryID +"'");

			DataRow dr = ds.Tables[0].Rows[0];

			lblBeneficeryBankRecordStatus.Text = "Existing";
			txtBeneficeryBankAccountNumber.Text = dr["AccountNumber"].ToString();
			txtBeneficeryBankName.Text = dr["Name"].ToString();
			txtBeneficeryBankBranchName.Text = dr["BranchName"].ToString();
			txtBeneficeryBankAddress.Text = dr["Address"].ToString();
			txtBeneficeryBankZip.Text = dr["ZipCode"].ToString();
			ddlBeneficeryBankCountry.SelectedIndex=-1;
					
			ListItem liCountry = ddlBeneficeryBankCountry.Items.FindByValue(dr["CountryId"].ToString());
			if(liCountry!=null)
				liCountry.Selected=true;

			butUpdateBeneficeryBankRecord.Visible=true;
			ViewState["BeneficeryBankId"]=new Guid(dr["Id"].ToString());
		}

		private void BindBeneficerySelection(string strBeneficeryID) 
		{
			ddlBeneficerySelection.Items.Clear();

					DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
						CommandType.Text,
						@"Select Id [ID1], FirstName+','+LastName Display From CustomerList Where Id = (Select BeneficeryId From TransactionDetails Where CustomerId='" + strBeneficeryID + "')");
					ddlBeneficerySelection.DataSource = ds;
					ddlBeneficerySelection.DataBind();

			if(ddlBeneficerySelection.Items.Count<1) 
			{
				ListItem li = new ListItem("New...");
				ddlBeneficerySelection.Items.Insert(0,li);
			} 
			else 
			{
				if(ddlBeneficerySelection.Items[0].Text!="New...") 
				{
					ListItem li = new ListItem("New...");
					ddlBeneficerySelection.Items.Insert(0,li);
				}
			}

			if(ddlBeneficerySelection.Items.Count>1)
			{
				ddlBeneficerySelection.SelectedIndex=1;
			}

		}
	}
}