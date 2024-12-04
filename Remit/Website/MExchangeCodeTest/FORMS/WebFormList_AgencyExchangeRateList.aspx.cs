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
	/// Summary description for WebFormList_AgencyExchangeRateList.
	/// </summary>
	public class WebFormList_AgencyExchangeRateList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_AgencyExchangeRateList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_AgencyExchangeRateList_SelectDisplay repeater_AgencyExchangeRateList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryList com_PayInCountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryList com_PayOutCountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyList com_PayOutCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_ExchangeSetName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayInCountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayOutCountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayOutCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_MarginPercent;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_MaximumAgentMargin;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_MinimumAgentMargin;
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

				// com_PayInCountryId
				System.Data.SqlTypes.SqlGuid colPayInCountryId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["PayInCountryId"] != String.Empty) {
				
					try {
					
						colPayInCountryId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["PayInCountryId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PayInCountryId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_PayInCountryId.RefreshData(colPayInCountryId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CountryList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CountryList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PayInCountryId.Items.Insert(0, "Show all");

				// com_PayOutCountryId
				System.Data.SqlTypes.SqlGuid colPayOutCountryId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["PayOutCountryId"] != String.Empty) {
				
					try {
					
						colPayOutCountryId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["PayOutCountryId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PayOutCountryId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_PayOutCountryId.RefreshData(colPayOutCountryId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CountryList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CountryList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PayOutCountryId.Items.Insert(0, "Show all");

				// com_PayOutCurrencyId
				System.Data.SqlTypes.SqlGuid colPayOutCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["PayOutCurrencyId"] != String.Empty) {
				
					try {
					
						colPayOutCurrencyId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["PayOutCurrencyId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PayOutCurrencyId.Initialize(ConnectionString);
				try {

					com_PayOutCurrencyId.RefreshData(colPayOutCurrencyId);
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
				com_PayOutCurrencyId.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_ExchangeSetName;
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

				if (ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_AgencyExchangeRateList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_AgencyExchangeRateList_SelectDisplay.EnableViewState = true;

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

			this.com_PayInCountryId.SelectedIndexChanged += new System.EventHandler(this.com_PayInCountryId_SelectedIndexChanged);
			this.com_PayOutCountryId.SelectedIndexChanged += new System.EventHandler(this.com_PayOutCountryId_SelectedIndexChanged);
			this.com_PayOutCurrencyId.SelectedIndexChanged += new System.EventHandler(this.com_PayOutCurrencyId_SelectedIndexChanged);
			this.Label_ExchangeSetName.Click += new System.EventHandler(this.Label_ExchangeSetName_Click);
			this.Label_PayInCountryId.Click += new System.EventHandler(this.Label_PayInCountryId_Click);
			this.Label_PayOutCountryId.Click += new System.EventHandler(this.Label_PayOutCountryId_Click);
			this.Label_PayOutCurrencyId.Click += new System.EventHandler(this.Label_PayOutCurrencyId_Click);
			this.Label_MarginPercent.Click += new System.EventHandler(this.Label_MarginPercent_Click);
			this.Label_MaximumAgentMargin.Click += new System.EventHandler(this.Label_MaximumAgentMargin_Click);
			this.Label_MinimumAgentMargin.Click += new System.EventHandler(this.Label_MinimumAgentMargin_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_ExchangeSetName
			, SortBy_PayInCountryId
			, SortBy_PayOutCountryId
			, SortBy_PayOutCurrencyId
			, SortBy_MarginPercent
			, SortBy_MaximumAgentMargin
			, SortBy_MinimumAgentMargin
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_PayInCountryId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PayOutCountryId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PayOutCurrencyId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid PayInCountryId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_PayInCountryId.SelectedIndex != 0) {

				PayInCountryId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_PayInCountryId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid PayOutCountryId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_PayOutCountryId.SelectedIndex != 0) {

				PayOutCountryId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_PayOutCountryId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid PayOutCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_PayOutCurrencyId.SelectedIndex != 0) {

				PayOutCurrencyId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_PayOutCurrencyId.SelectedItem.Value));
			}

			repeater_AgencyExchangeRateList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, PayInCountryId, PayOutCountryId, PayOutCurrencyId);
			try {

				repeater_AgencyExchangeRateList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgencyExchangeRateList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgencyExchangeRateList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_AgencyExchangeRateList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_ExchangeSetName:
					SortDirective = spS_AgencyExchangeRateList.Resultset1.Fields.Column_ExchangeSetName.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayInCountryId:
					SortDirective = spS_AgencyExchangeRateList_SelectDisplay.Resultset1.Fields.Column_PayInCountryId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayOutCountryId:
					SortDirective = spS_AgencyExchangeRateList_SelectDisplay.Resultset1.Fields.Column_PayOutCountryId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayOutCurrencyId:
					SortDirective = spS_AgencyExchangeRateList_SelectDisplay.Resultset1.Fields.Column_PayOutCurrencyId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_MarginPercent:
					SortDirective = spS_AgencyExchangeRateList.Resultset1.Fields.Column_MarginPercent.ColumnName;
					break;

				case CurrentSortEnum.SortBy_MaximumAgentMargin:
					SortDirective = spS_AgencyExchangeRateList.Resultset1.Fields.Column_MaximumAgentMargin.ColumnName;
					break;

				case CurrentSortEnum.SortBy_MinimumAgentMargin:
					SortDirective = spS_AgencyExchangeRateList.Resultset1.Fields.Column_MinimumAgentMargin.ColumnName;
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
			repeater_AgencyExchangeRateList_SelectDisplay.DataBind();
		}

		private void Label_ExchangeSetName_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_ExchangeSetName) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_ExchangeSetName;
			}

			RefreshList();
		}

		private void Label_PayInCountryId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_PayInCountryId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_PayInCountryId;
			}

			RefreshList();
		}

		private void Label_PayOutCountryId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_PayOutCountryId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_PayOutCountryId;
			}

			RefreshList();
		}

		private void Label_PayOutCurrencyId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_PayOutCurrencyId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_PayOutCurrencyId;
			}

			RefreshList();
		}

		private void Label_MarginPercent_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_MarginPercent) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_MarginPercent;
			}

			RefreshList();
		}

		private void Label_MaximumAgentMargin_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_MaximumAgentMargin) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_MaximumAgentMargin;
			}

			RefreshList();
		}

		private void Label_MinimumAgentMargin_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_MinimumAgentMargin) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgencyExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_MinimumAgentMargin;
			}

			RefreshList();
		}

	}
}
