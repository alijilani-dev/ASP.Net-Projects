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
	/// Summary description for WebFormList_CommissionSlabMaster.
	/// </summary>
	public class WebFormList_CommissionSlabMaster: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_CommissionSlabMaster() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_CommissionSlabMaster_SelectDisplay repeater_CommissionSlabMaster_SelectDisplay;
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
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentModeList com_ModeOfPayment;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CommissionSplitTypeList com_PayInCommissionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CommissionSplitTypeList com_PayOutCommissionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CommissionCurrencyType com_PayOutCurrencyType;
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
		protected System.Web.UI.WebControls.LinkButton Label_ModeOfPayment;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_StartRange;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_EndRange;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_BaseToBaseCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_BaseToUSDCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayInCommissionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayInCommissionAmount;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayOutCommissionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayOutCurrencyType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PayOutCommissionAmount;
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

				// com_ModeOfPayment
				System.Data.SqlTypes.SqlString colModeOfPayment = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["ModeOfPayment"] != String.Empty) {
				
					try {
					
						colModeOfPayment = Request.Params["ModeOfPayment"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_ModeOfPayment.Initialize(ConnectionString, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_ModeOfPayment.RefreshData(colModeOfPayment);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentModeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentModeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_ModeOfPayment.Items.Insert(0, "Show all");

				// com_PayInCommissionType
				System.Data.SqlTypes.SqlString colPayInCommissionType = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["PayInCommissionType"] != String.Empty) {
				
					try {
					
						colPayInCommissionType = Request.Params["PayInCommissionType"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PayInCommissionType.Initialize(ConnectionString);
				try {

					com_PayInCommissionType.RefreshData(colPayInCommissionType);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CommissionSplitTypeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CommissionSplitTypeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PayInCommissionType.Items.Insert(0, "Show all");

				// com_PayOutCommissionType
				System.Data.SqlTypes.SqlString colPayOutCommissionType = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["PayOutCommissionType"] != String.Empty) {
				
					try {
					
						colPayOutCommissionType = Request.Params["PayOutCommissionType"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PayOutCommissionType.Initialize(ConnectionString);
				try {

					com_PayOutCommissionType.RefreshData(colPayOutCommissionType);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CommissionSplitTypeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CommissionSplitTypeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PayOutCommissionType.Items.Insert(0, "Show all");

				// com_PayOutCurrencyType
				System.Data.SqlTypes.SqlString colPayOutCurrencyType = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["PayOutCurrencyType"] != String.Empty) {
				
					try {
					
						colPayOutCurrencyType = Request.Params["PayOutCurrencyType"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PayOutCurrencyType.Initialize(ConnectionString);
				try {

					com_PayOutCurrencyType.RefreshData(colPayOutCurrencyType);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CommissionCurrencyType' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CommissionCurrencyType' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PayOutCurrencyType.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_PayInCountryId;
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

				if (ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] == null) {

					ViewState.Add("WebFormList_CommissionSlabMaster_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_CommissionSlabMaster_SelectDisplay.EnableViewState = true;

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
			this.com_ModeOfPayment.SelectedIndexChanged += new System.EventHandler(this.com_ModeOfPayment_SelectedIndexChanged);
			this.com_PayInCommissionType.SelectedIndexChanged += new System.EventHandler(this.com_PayInCommissionType_SelectedIndexChanged);
			this.com_PayOutCommissionType.SelectedIndexChanged += new System.EventHandler(this.com_PayOutCommissionType_SelectedIndexChanged);
			this.com_PayOutCurrencyType.SelectedIndexChanged += new System.EventHandler(this.com_PayOutCurrencyType_SelectedIndexChanged);
			this.Label_PayInCountryId.Click += new System.EventHandler(this.Label_PayInCountryId_Click);
			this.Label_PayOutCountryId.Click += new System.EventHandler(this.Label_PayOutCountryId_Click);
			this.Label_ModeOfPayment.Click += new System.EventHandler(this.Label_ModeOfPayment_Click);
			this.Label_StartRange.Click += new System.EventHandler(this.Label_StartRange_Click);
			this.Label_EndRange.Click += new System.EventHandler(this.Label_EndRange_Click);
			this.Label_BaseToBaseCommissionAmount.Click += new System.EventHandler(this.Label_BaseToBaseCommissionAmount_Click);
			this.Label_BaseToUSDCommissionAmount.Click += new System.EventHandler(this.Label_BaseToUSDCommissionAmount_Click);
			this.Label_PayInCommissionType.Click += new System.EventHandler(this.Label_PayInCommissionType_Click);
			this.Label_PayInCommissionAmount.Click += new System.EventHandler(this.Label_PayInCommissionAmount_Click);
			this.Label_PayOutCommissionType.Click += new System.EventHandler(this.Label_PayOutCommissionType_Click);
			this.Label_PayOutCurrencyType.Click += new System.EventHandler(this.Label_PayOutCurrencyType_Click);
			this.Label_PayOutCommissionAmount.Click += new System.EventHandler(this.Label_PayOutCommissionAmount_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_PayInCountryId
			, SortBy_PayOutCountryId
			, SortBy_ModeOfPayment
			, SortBy_StartRange
			, SortBy_EndRange
			, SortBy_BaseToBaseCommissionAmount
			, SortBy_BaseToUSDCommissionAmount
			, SortBy_PayInCommissionType
			, SortBy_PayInCommissionAmount
			, SortBy_PayOutCommissionType
			, SortBy_PayOutCurrencyType
			, SortBy_PayOutCommissionAmount
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

		private void com_ModeOfPayment_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PayInCommissionType_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PayOutCommissionType_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PayOutCurrencyType_SelectedIndexChanged(object sender, System.EventArgs e) {

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

			System.Data.SqlTypes.SqlString ModeOfPayment = System.Data.SqlTypes.SqlString.Null;
			if (com_ModeOfPayment.SelectedIndex != 0) {

				ModeOfPayment = new System.Data.SqlTypes.SqlString(com_ModeOfPayment.SelectedItem.Value);
			}

			System.Data.SqlTypes.SqlString PayInCommissionType = System.Data.SqlTypes.SqlString.Null;
			if (com_PayInCommissionType.SelectedIndex != 0) {

				PayInCommissionType = new System.Data.SqlTypes.SqlString(com_PayInCommissionType.SelectedItem.Value);
			}

			System.Data.SqlTypes.SqlString PayOutCommissionType = System.Data.SqlTypes.SqlString.Null;
			if (com_PayOutCommissionType.SelectedIndex != 0) {

				PayOutCommissionType = new System.Data.SqlTypes.SqlString(com_PayOutCommissionType.SelectedItem.Value);
			}

			System.Data.SqlTypes.SqlString PayOutCurrencyType = System.Data.SqlTypes.SqlString.Null;
			if (com_PayOutCurrencyType.SelectedIndex != 0) {

				PayOutCurrencyType = new System.Data.SqlTypes.SqlString(com_PayOutCurrencyType.SelectedItem.Value);
			}

			repeater_CommissionSlabMaster_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, PayInCountryId, PayOutCountryId, ModeOfPayment, PayInCommissionType, PayOutCommissionType, PayOutCurrencyType);
			try {

				repeater_CommissionSlabMaster_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_CommissionSlabMaster' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_CommissionSlabMaster' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_CommissionSlabMaster_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_CommissionSlabMaster_CurrentSort"]) {

				case CurrentSortEnum.SortBy_PayInCountryId:
					SortDirective = spS_CommissionSlabMaster_SelectDisplay.Resultset1.Fields.Column_PayInCountryId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayOutCountryId:
					SortDirective = spS_CommissionSlabMaster_SelectDisplay.Resultset1.Fields.Column_PayOutCountryId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_ModeOfPayment:
					SortDirective = spS_CommissionSlabMaster_SelectDisplay.Resultset1.Fields.Column_ModeOfPayment_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_StartRange:
					SortDirective = spS_CommissionSlabMaster.Resultset1.Fields.Column_StartRange.ColumnName;
					break;

				case CurrentSortEnum.SortBy_EndRange:
					SortDirective = spS_CommissionSlabMaster.Resultset1.Fields.Column_EndRange.ColumnName;
					break;

				case CurrentSortEnum.SortBy_BaseToBaseCommissionAmount:
					SortDirective = spS_CommissionSlabMaster.Resultset1.Fields.Column_BaseToBaseCommissionAmount.ColumnName;
					break;

				case CurrentSortEnum.SortBy_BaseToUSDCommissionAmount:
					SortDirective = spS_CommissionSlabMaster.Resultset1.Fields.Column_BaseToUSDCommissionAmount.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayInCommissionType:
					SortDirective = spS_CommissionSlabMaster_SelectDisplay.Resultset1.Fields.Column_PayInCommissionType_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayInCommissionAmount:
					SortDirective = spS_CommissionSlabMaster.Resultset1.Fields.Column_PayInCommissionAmount.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayOutCommissionType:
					SortDirective = spS_CommissionSlabMaster_SelectDisplay.Resultset1.Fields.Column_PayOutCommissionType_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayOutCurrencyType:
					SortDirective = spS_CommissionSlabMaster_SelectDisplay.Resultset1.Fields.Column_PayOutCurrencyType_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PayOutCommissionAmount:
					SortDirective = spS_CommissionSlabMaster.Resultset1.Fields.Column_PayOutCommissionAmount.ColumnName;
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
			repeater_CommissionSlabMaster_SelectDisplay.DataBind();
		}

		private void Label_PayInCountryId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] == CurrentSortEnum.SortBy_PayInCountryId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] = CurrentSortEnum.SortBy_PayInCountryId;
			}

			RefreshList();
		}

		private void Label_PayOutCountryId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] == CurrentSortEnum.SortBy_PayOutCountryId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] = CurrentSortEnum.SortBy_PayOutCountryId;
			}

			RefreshList();
		}

		private void Label_ModeOfPayment_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] == CurrentSortEnum.SortBy_ModeOfPayment) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] = CurrentSortEnum.SortBy_ModeOfPayment;
			}

			RefreshList();
		}

		private void Label_StartRange_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] == CurrentSortEnum.SortBy_StartRange) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] = CurrentSortEnum.SortBy_StartRange;
			}

			RefreshList();
		}

		private void Label_EndRange_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] == CurrentSortEnum.SortBy_EndRange) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] = CurrentSortEnum.SortBy_EndRange;
			}

			RefreshList();
		}

		private void Label_BaseToBaseCommissionAmount_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] == CurrentSortEnum.SortBy_BaseToBaseCommissionAmount) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] = CurrentSortEnum.SortBy_BaseToBaseCommissionAmount;
			}

			RefreshList();
		}

		private void Label_BaseToUSDCommissionAmount_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] == CurrentSortEnum.SortBy_BaseToUSDCommissionAmount) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] = CurrentSortEnum.SortBy_BaseToUSDCommissionAmount;
			}

			RefreshList();
		}

		private void Label_PayInCommissionType_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] == CurrentSortEnum.SortBy_PayInCommissionType) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] = CurrentSortEnum.SortBy_PayInCommissionType;
			}

			RefreshList();
		}

		private void Label_PayInCommissionAmount_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] == CurrentSortEnum.SortBy_PayInCommissionAmount) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] = CurrentSortEnum.SortBy_PayInCommissionAmount;
			}

			RefreshList();
		}

		private void Label_PayOutCommissionType_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] == CurrentSortEnum.SortBy_PayOutCommissionType) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] = CurrentSortEnum.SortBy_PayOutCommissionType;
			}

			RefreshList();
		}

		private void Label_PayOutCurrencyType_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] == CurrentSortEnum.SortBy_PayOutCurrencyType) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] = CurrentSortEnum.SortBy_PayOutCurrencyType;
			}

			RefreshList();
		}

		private void Label_PayOutCommissionAmount_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] == CurrentSortEnum.SortBy_PayOutCommissionAmount) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CommissionSlabMaster_CurrentSort"] = CurrentSortEnum.SortBy_PayOutCommissionAmount;
			}

			RefreshList();
		}

	}
}
