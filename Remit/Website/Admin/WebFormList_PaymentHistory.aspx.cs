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
	/// Summary description for WebFormList_PaymentHistory.
	/// </summary>
	public class WebFormList_PaymentHistory: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_PaymentHistory() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_PaymentHistory_SelectDisplay repeater_PaymentHistory_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyList com_PaymentCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentType com_Type;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Id;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_EntryDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PaymentDateTime;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PaymentCurrencyId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Debit;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Credit;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Type;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Particulars;
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

				// com_PaymentCurrencyId
				System.Data.SqlTypes.SqlGuid colPaymentCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["PaymentCurrencyId"] != String.Empty) {
				
					try {
					
						colPaymentCurrencyId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["PaymentCurrencyId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PaymentCurrencyId.Initialize(ConnectionString);
				try {

					com_PaymentCurrencyId.RefreshData(colPaymentCurrencyId);
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
				com_PaymentCurrencyId.Items.Insert(0, "Show all");

				// com_Type
				System.Data.SqlTypes.SqlString colType = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["Type"] != String.Empty) {
				
					try {
					
						colType = Request.Params["Type"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_Type.Initialize(ConnectionString);
				try {

					com_Type.RefreshData(colType);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentType' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentType' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_Type.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_Id;
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

				if (ViewState["WebFormList_PaymentHistory_CurrentSort"] == null) {

					ViewState.Add("WebFormList_PaymentHistory_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_PaymentHistory_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_PaymentHistory_SelectDisplay.EnableViewState = true;

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

			this.com_PaymentCurrencyId.SelectedIndexChanged += new System.EventHandler(this.com_PaymentCurrencyId_SelectedIndexChanged);
			this.com_Type.SelectedIndexChanged += new System.EventHandler(this.com_Type_SelectedIndexChanged);
			this.Label_Id.Click += new System.EventHandler(this.Label_Id_Click);
			this.Label_EntryDateTime.Click += new System.EventHandler(this.Label_EntryDateTime_Click);
			this.Label_PaymentDateTime.Click += new System.EventHandler(this.Label_PaymentDateTime_Click);
			this.Label_PaymentCurrencyId.Click += new System.EventHandler(this.Label_PaymentCurrencyId_Click);
			this.Label_Debit.Click += new System.EventHandler(this.Label_Debit_Click);
			this.Label_Credit.Click += new System.EventHandler(this.Label_Credit_Click);
			this.Label_Type.Click += new System.EventHandler(this.Label_Type_Click);
			this.Label_Particulars.Click += new System.EventHandler(this.Label_Particulars_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Id
			, SortBy_EntryDateTime
			, SortBy_PaymentDateTime
			, SortBy_PaymentCurrencyId
			, SortBy_Debit
			, SortBy_Credit
			, SortBy_Type
			, SortBy_Particulars
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_PaymentCurrencyId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_Type_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid PaymentCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_PaymentCurrencyId.SelectedIndex != 0) {

				PaymentCurrencyId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_PaymentCurrencyId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlString Type = System.Data.SqlTypes.SqlString.Null;
			if (com_Type.SelectedIndex != 0) {

				Type = new System.Data.SqlTypes.SqlString(com_Type.SelectedItem.Value);
			}

			repeater_PaymentHistory_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, PaymentCurrencyId, Type);
			try {

				repeater_PaymentHistory_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_PaymentHistory' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_PaymentHistory' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_PaymentHistory_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_PaymentHistory_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Id:
					SortDirective = spS_PaymentHistory.Resultset1.Fields.Column_Id.ColumnName;
					break;

				case CurrentSortEnum.SortBy_EntryDateTime:
					SortDirective = spS_PaymentHistory.Resultset1.Fields.Column_EntryDateTime.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PaymentDateTime:
					SortDirective = spS_PaymentHistory.Resultset1.Fields.Column_PaymentDateTime.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PaymentCurrencyId:
					SortDirective = spS_PaymentHistory_SelectDisplay.Resultset1.Fields.Column_PaymentCurrencyId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Debit:
					SortDirective = spS_PaymentHistory.Resultset1.Fields.Column_Debit.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Credit:
					SortDirective = spS_PaymentHistory.Resultset1.Fields.Column_Credit.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Type:
					SortDirective = spS_PaymentHistory_SelectDisplay.Resultset1.Fields.Column_Type_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Particulars:
					SortDirective = spS_PaymentHistory.Resultset1.Fields.Column_Particulars.ColumnName;
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
			repeater_PaymentHistory_SelectDisplay.DataBind();
		}

		private void Label_Id_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentHistory_CurrentSort"] == CurrentSortEnum.SortBy_Id) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentHistory_CurrentSort"] = CurrentSortEnum.SortBy_Id;
			}

			RefreshList();
		}

		private void Label_EntryDateTime_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentHistory_CurrentSort"] == CurrentSortEnum.SortBy_EntryDateTime) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentHistory_CurrentSort"] = CurrentSortEnum.SortBy_EntryDateTime;
			}

			RefreshList();
		}

		private void Label_PaymentDateTime_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentHistory_CurrentSort"] == CurrentSortEnum.SortBy_PaymentDateTime) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentHistory_CurrentSort"] = CurrentSortEnum.SortBy_PaymentDateTime;
			}

			RefreshList();
		}

		private void Label_PaymentCurrencyId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentHistory_CurrentSort"] == CurrentSortEnum.SortBy_PaymentCurrencyId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentHistory_CurrentSort"] = CurrentSortEnum.SortBy_PaymentCurrencyId;
			}

			RefreshList();
		}

		private void Label_Debit_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentHistory_CurrentSort"] == CurrentSortEnum.SortBy_Debit) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentHistory_CurrentSort"] = CurrentSortEnum.SortBy_Debit;
			}

			RefreshList();
		}

		private void Label_Credit_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentHistory_CurrentSort"] == CurrentSortEnum.SortBy_Credit) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentHistory_CurrentSort"] = CurrentSortEnum.SortBy_Credit;
			}

			RefreshList();
		}

		private void Label_Type_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentHistory_CurrentSort"] == CurrentSortEnum.SortBy_Type) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentHistory_CurrentSort"] = CurrentSortEnum.SortBy_Type;
			}

			RefreshList();
		}

		private void Label_Particulars_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentHistory_CurrentSort"] == CurrentSortEnum.SortBy_Particulars) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentHistory_CurrentSort"] = CurrentSortEnum.SortBy_Particulars;
			}

			RefreshList();
		}

	}
}
