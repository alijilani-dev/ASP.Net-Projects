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
	/// Summary description for WebFormList_BankExchangeRateList.
	/// </summary>
	public class WebFormList_BankExchangeRateList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_BankExchangeRateList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_BankExchangeRateList_SelectDisplay repeater_BankExchangeRateList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyList com_CurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyExchangeType com_ExchangeType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_CurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_ExchangeType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_BidRate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_OfferRate;
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

				// com_CurrencyId
				System.Data.SqlTypes.SqlGuid colCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["CurrencyId"] != String.Empty) {
				
					try {
					
						colCurrencyId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["CurrencyId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_CurrencyId.Initialize(ConnectionString);
				try {

					com_CurrencyId.RefreshData(colCurrencyId);
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
				com_CurrencyId.Items.Insert(0, "Show all");

				// com_ExchangeType
				System.Data.SqlTypes.SqlString colExchangeType = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["ExchangeType"] != String.Empty) {
				
					try {
					
						colExchangeType = Request.Params["ExchangeType"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_ExchangeType.Initialize(ConnectionString);
				try {

					com_ExchangeType.RefreshData(colExchangeType);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CurrencyExchangeType' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CurrencyExchangeType' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_ExchangeType.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_CurrencyId;
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

				if (ViewState["WebFormList_BankExchangeRateList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_BankExchangeRateList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_BankExchangeRateList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_BankExchangeRateList_SelectDisplay.EnableViewState = true;

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

			this.com_CurrencyId.SelectedIndexChanged += new System.EventHandler(this.com_CurrencyId_SelectedIndexChanged);
			this.com_ExchangeType.SelectedIndexChanged += new System.EventHandler(this.com_ExchangeType_SelectedIndexChanged);
			this.Label_CurrencyId.Click += new System.EventHandler(this.Label_CurrencyId_Click);
			this.Label_ExchangeType.Click += new System.EventHandler(this.Label_ExchangeType_Click);
			this.Label_BidRate.Click += new System.EventHandler(this.Label_BidRate_Click);
			this.Label_OfferRate.Click += new System.EventHandler(this.Label_OfferRate_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_CurrencyId
			, SortBy_ExchangeType
			, SortBy_BidRate
			, SortBy_OfferRate
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_CurrencyId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_ExchangeType_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid CurrencyId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_CurrencyId.SelectedIndex != 0) {

				CurrencyId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_CurrencyId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlString ExchangeType = System.Data.SqlTypes.SqlString.Null;
			if (com_ExchangeType.SelectedIndex != 0) {

				ExchangeType = new System.Data.SqlTypes.SqlString(com_ExchangeType.SelectedItem.Value);
			}

			repeater_BankExchangeRateList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, CurrencyId, ExchangeType);
			try {

				repeater_BankExchangeRateList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_BankExchangeRateList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_BankExchangeRateList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_BankExchangeRateList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_BankExchangeRateList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_CurrencyId:
					SortDirective = spS_BankExchangeRateList_SelectDisplay.Resultset1.Fields.Column_CurrencyId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_ExchangeType:
					SortDirective = spS_BankExchangeRateList_SelectDisplay.Resultset1.Fields.Column_ExchangeType_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_BidRate:
					SortDirective = spS_BankExchangeRateList.Resultset1.Fields.Column_BidRate.ColumnName;
					break;

				case CurrentSortEnum.SortBy_OfferRate:
					SortDirective = spS_BankExchangeRateList.Resultset1.Fields.Column_OfferRate.ColumnName;
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
			repeater_BankExchangeRateList_SelectDisplay.DataBind();
		}

		private void Label_CurrencyId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BankExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_CurrencyId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BankExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_CurrencyId;
			}

			RefreshList();
		}

		private void Label_ExchangeType_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BankExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_ExchangeType) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BankExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_ExchangeType;
			}

			RefreshList();
		}

		private void Label_BidRate_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BankExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_BidRate) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BankExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_BidRate;
			}

			RefreshList();
		}

		private void Label_OfferRate_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BankExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_OfferRate) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BankExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_OfferRate;
			}

			RefreshList();
		}

	}
}
