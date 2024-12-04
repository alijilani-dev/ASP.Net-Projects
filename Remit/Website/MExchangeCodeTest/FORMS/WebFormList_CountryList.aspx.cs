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
using System.Configuration;
using Evernet.MoneyExchange.DataClasses.StoredProcedures;

namespace Evernet.MoneyExchange.Web.Forms
{
	/// <summary>
	/// Summary description for WebFormList_CountryList.
	/// </summary>
	public class WebFormList_CountryList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_CountryList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_CountryList_SelectDisplay repeater_CountryList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyList com_BaseCurrency;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionTypeList com_AllowedInternationalTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionTypeList com_AllowedDomesticTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Code;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_BaseCurrency;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AllowedInternationalTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AllowedDomesticTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_TotalInboundThresholdPerYearPerPerson;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_MaximumTransactionsPerYearPerPersonToOneBeneficery;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_TransactionYearStartDate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_TransactionYearEndDate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_OutboundIDRequirementThreshold;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_OutboundThresholdPerTransaction;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_CanPayOutUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Active;
		private System.Globalization.CultureInfo CurrentUserCulture;
		private void Page_Load(object sender, System.EventArgs e) {

			string Language = "en-US";
			if (Request.UserLanguages.Length != 0) {

				Language = Request.UserLanguages[0];
			}

			CurrentUserCulture = System.Globalization.CultureInfo.CreateSpecificCulture(Language);

			if (ConfigurationSettings.AppSettings["mexchange ConnectionString"] != null) {

				ConnectionString = ConfigurationSettings.AppSettings["mexchange ConnectionString"];
			}
			else if (Application["ConnectionString"] != null) {

				ConnectionString = Application["ConnectionString"].ToString().Trim();
			}

			if (!Page.IsPostBack) {

				// com_BaseCurrency
				System.Data.SqlTypes.SqlGuid colBaseCurrency = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["BaseCurrency"] != String.Empty) {
				
					try {
					
						colBaseCurrency = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["BaseCurrency"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_BaseCurrency.Initialize(ConnectionString);
				try {

					com_BaseCurrency.RefreshData(colBaseCurrency);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CurrencyList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CurrencyList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_BaseCurrency.Items.Insert(0, "Show all");

				// com_AllowedInternationalTransactionType
				System.Data.SqlTypes.SqlString colAllowedInternationalTransactionType = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["AllowedInternationalTransactionType"] != String.Empty) {
				
					try {
					
						colAllowedInternationalTransactionType = Request.Params["AllowedInternationalTransactionType"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_AllowedInternationalTransactionType.Initialize(ConnectionString);
				try {

					com_AllowedInternationalTransactionType.RefreshData(colAllowedInternationalTransactionType);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionTypeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionTypeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_AllowedInternationalTransactionType.Items.Insert(0, "Show all");

				// com_AllowedDomesticTransactionType
				System.Data.SqlTypes.SqlString colAllowedDomesticTransactionType = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["AllowedDomesticTransactionType"] != String.Empty) {
				
					try {
					
						colAllowedDomesticTransactionType = Request.Params["AllowedDomesticTransactionType"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_AllowedDomesticTransactionType.Initialize(ConnectionString);
				try {

					com_AllowedDomesticTransactionType.RefreshData(colAllowedDomesticTransactionType);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionTypeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_TransactionTypeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_AllowedDomesticTransactionType.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_Name;
				if (Request.Params["SortBy"] != String.Empty) {
				
					try {
					
						sortColumn = (CurrentSortEnum)Enum.Parse(typeof(CurrentSortEnum), "SortBy_" + Request.Params["SortBy"]);
					}
					
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}

				SortOrderEnum sortOrder = SortOrderEnum.Ascending;
				if (Request.Params["SortOrder"] != String.Empty) {
				
					try {
					
						sortOrder = (SortOrderEnum)Enum.Parse(typeof(SortOrderEnum), Request.Params["SortOrder"]);
					}
					
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}

				if (ViewState["WebFormList_CountryList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_CountryList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_CountryList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_CountryList_SelectDisplay.EnableViewState = true;

			RefreshList();
		}

		private void Page_Init(object sender, EventArgs e) {

			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
		}

		#region Web Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {

			this.com_BaseCurrency.SelectedIndexChanged += new System.EventHandler(this.com_BaseCurrency_SelectedIndexChanged);
			this.com_AllowedInternationalTransactionType.SelectedIndexChanged += new System.EventHandler(this.com_AllowedInternationalTransactionType_SelectedIndexChanged);
			this.com_AllowedDomesticTransactionType.SelectedIndexChanged += new System.EventHandler(this.com_AllowedDomesticTransactionType_SelectedIndexChanged);
			this.Label_Name.Click += new System.EventHandler(this.Label_Name_Click);
			this.Label_Code.Click += new System.EventHandler(this.Label_Code_Click);
			this.Label_BaseCurrency.Click += new System.EventHandler(this.Label_BaseCurrency_Click);
			this.Label_AllowedInternationalTransactionType.Click += new System.EventHandler(this.Label_AllowedInternationalTransactionType_Click);
			this.Label_AllowedDomesticTransactionType.Click += new System.EventHandler(this.Label_AllowedDomesticTransactionType_Click);
			this.Label_TotalInboundThresholdPerYearPerPerson.Click += new System.EventHandler(this.Label_TotalInboundThresholdPerYearPerPerson_Click);
			this.Label_MaximumTransactionsPerYearPerPersonToOneBeneficery.Click += new System.EventHandler(this.Label_MaximumTransactionsPerYearPerPersonToOneBeneficery_Click);
			this.Label_TransactionYearStartDate.Click += new System.EventHandler(this.Label_TransactionYearStartDate_Click);
			this.Label_TransactionYearEndDate.Click += new System.EventHandler(this.Label_TransactionYearEndDate_Click);
			this.Label_OutboundIDRequirementThreshold.Click += new System.EventHandler(this.Label_OutboundIDRequirementThreshold_Click);
			this.Label_OutboundThresholdPerTransaction.Click += new System.EventHandler(this.Label_OutboundThresholdPerTransaction_Click);
			this.Label_CanPayOutUSD.Click += new System.EventHandler(this.Label_CanPayOutUSD_Click);
			this.Label_Active.Click += new System.EventHandler(this.Label_Active_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Name
			, SortBy_Code
			, SortBy_BaseCurrency
			, SortBy_AllowedInternationalTransactionType
			, SortBy_AllowedDomesticTransactionType
			, SortBy_TotalInboundThresholdPerYearPerPerson
			, SortBy_MaximumTransactionsPerYearPerPersonToOneBeneficery
			, SortBy_TransactionYearStartDate
			, SortBy_TransactionYearEndDate
			, SortBy_OutboundIDRequirementThreshold
			, SortBy_OutboundThresholdPerTransaction
			, SortBy_CanPayOutUSD
			, SortBy_Active
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_BaseCurrency_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_AllowedInternationalTransactionType_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_AllowedDomesticTransactionType_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid BaseCurrency = System.Data.SqlTypes.SqlGuid.Null;
			if (com_BaseCurrency.SelectedIndex != 0) {

				BaseCurrency = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_BaseCurrency.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlString AllowedInternationalTransactionType = System.Data.SqlTypes.SqlString.Null;
			if (com_AllowedInternationalTransactionType.SelectedIndex != 0) {

				AllowedInternationalTransactionType = new System.Data.SqlTypes.SqlString(com_AllowedInternationalTransactionType.SelectedItem.Value);
			}

			System.Data.SqlTypes.SqlString AllowedDomesticTransactionType = System.Data.SqlTypes.SqlString.Null;
			if (com_AllowedDomesticTransactionType.SelectedIndex != 0) {

				AllowedDomesticTransactionType = new System.Data.SqlTypes.SqlString(com_AllowedDomesticTransactionType.SelectedItem.Value);
			}

			repeater_CountryList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, BaseCurrency, AllowedInternationalTransactionType, AllowedDomesticTransactionType);
			try {

				repeater_CountryList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_CountryList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_CountryList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_CountryList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Name:
					SortDirective = spS_CountryList.Resultset1.Fields.Column_Name.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Code:
					SortDirective = spS_CountryList.Resultset1.Fields.Column_Code.ColumnName;
					break;

				case CurrentSortEnum.SortBy_BaseCurrency:
					SortDirective = spS_CountryList_SelectDisplay.Resultset1.Fields.Column_BaseCurrency_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AllowedInternationalTransactionType:
					SortDirective = spS_CountryList_SelectDisplay.Resultset1.Fields.Column_AllowedInternationalTransactionType_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AllowedDomesticTransactionType:
					SortDirective = spS_CountryList_SelectDisplay.Resultset1.Fields.Column_AllowedDomesticTransactionType_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TotalInboundThresholdPerYearPerPerson:
					SortDirective = spS_CountryList.Resultset1.Fields.Column_TotalInboundThresholdPerYearPerPerson.ColumnName;
					break;

				case CurrentSortEnum.SortBy_MaximumTransactionsPerYearPerPersonToOneBeneficery:
					SortDirective = spS_CountryList.Resultset1.Fields.Column_MaximumTransactionsPerYearPerPersonToOneBeneficery.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TransactionYearStartDate:
					SortDirective = spS_CountryList.Resultset1.Fields.Column_TransactionYearStartDate.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TransactionYearEndDate:
					SortDirective = spS_CountryList.Resultset1.Fields.Column_TransactionYearEndDate.ColumnName;
					break;

				case CurrentSortEnum.SortBy_OutboundIDRequirementThreshold:
					SortDirective = spS_CountryList.Resultset1.Fields.Column_OutboundIDRequirementThreshold.ColumnName;
					break;

				case CurrentSortEnum.SortBy_OutboundThresholdPerTransaction:
					SortDirective = spS_CountryList.Resultset1.Fields.Column_OutboundThresholdPerTransaction.ColumnName;
					break;

				case CurrentSortEnum.SortBy_CanPayOutUSD:
					SortDirective = spS_CountryList.Resultset1.Fields.Column_CanPayOutUSD.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Active:
					SortDirective = spS_CountryList.Resultset1.Fields.Column_Active.ColumnName;
					break;

			}

			switch ((SortOrderEnum)ViewState["sortOrder"]) {

				case SortOrderEnum.Ascending:
					SortDirective += " ASC";
					break;

				case SortOrderEnum.Descending:
					SortDirective += " DESC";
					break;
			}

			dataView.Sort = SortDirective;
			repeater_CountryList_SelectDisplay.DataBind();
		}

		private void Label_Name_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"] == CurrentSortEnum.SortBy_Name) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryList_CurrentSort"] = CurrentSortEnum.SortBy_Name;
			}

			RefreshList();
		}

		private void Label_Code_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"] == CurrentSortEnum.SortBy_Code) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryList_CurrentSort"] = CurrentSortEnum.SortBy_Code;
			}

			RefreshList();
		}

		private void Label_BaseCurrency_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"] == CurrentSortEnum.SortBy_BaseCurrency) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryList_CurrentSort"] = CurrentSortEnum.SortBy_BaseCurrency;
			}

			RefreshList();
		}

		private void Label_AllowedInternationalTransactionType_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"] == CurrentSortEnum.SortBy_AllowedInternationalTransactionType) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryList_CurrentSort"] = CurrentSortEnum.SortBy_AllowedInternationalTransactionType;
			}

			RefreshList();
		}

		private void Label_AllowedDomesticTransactionType_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"] == CurrentSortEnum.SortBy_AllowedDomesticTransactionType) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryList_CurrentSort"] = CurrentSortEnum.SortBy_AllowedDomesticTransactionType;
			}

			RefreshList();
		}

		private void Label_TotalInboundThresholdPerYearPerPerson_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"] == CurrentSortEnum.SortBy_TotalInboundThresholdPerYearPerPerson) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryList_CurrentSort"] = CurrentSortEnum.SortBy_TotalInboundThresholdPerYearPerPerson;
			}

			RefreshList();
		}

		private void Label_MaximumTransactionsPerYearPerPersonToOneBeneficery_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"] == CurrentSortEnum.SortBy_MaximumTransactionsPerYearPerPersonToOneBeneficery) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryList_CurrentSort"] = CurrentSortEnum.SortBy_MaximumTransactionsPerYearPerPersonToOneBeneficery;
			}

			RefreshList();
		}

		private void Label_TransactionYearStartDate_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"] == CurrentSortEnum.SortBy_TransactionYearStartDate) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryList_CurrentSort"] = CurrentSortEnum.SortBy_TransactionYearStartDate;
			}

			RefreshList();
		}

		private void Label_TransactionYearEndDate_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"] == CurrentSortEnum.SortBy_TransactionYearEndDate) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryList_CurrentSort"] = CurrentSortEnum.SortBy_TransactionYearEndDate;
			}

			RefreshList();
		}

		private void Label_OutboundIDRequirementThreshold_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"] == CurrentSortEnum.SortBy_OutboundIDRequirementThreshold) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryList_CurrentSort"] = CurrentSortEnum.SortBy_OutboundIDRequirementThreshold;
			}

			RefreshList();
		}

		private void Label_OutboundThresholdPerTransaction_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"] == CurrentSortEnum.SortBy_OutboundThresholdPerTransaction) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryList_CurrentSort"] = CurrentSortEnum.SortBy_OutboundThresholdPerTransaction;
			}

			RefreshList();
		}

		private void Label_CanPayOutUSD_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"] == CurrentSortEnum.SortBy_CanPayOutUSD) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryList_CurrentSort"] = CurrentSortEnum.SortBy_CanPayOutUSD;
			}

			RefreshList();
		}

		private void Label_Active_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryList_CurrentSort"] == CurrentSortEnum.SortBy_Active) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryList_CurrentSort"] = CurrentSortEnum.SortBy_Active;
			}

			RefreshList();
		}

	}
}
