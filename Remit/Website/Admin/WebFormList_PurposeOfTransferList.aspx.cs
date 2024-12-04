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
	/// Summary description for WebFormList_PurposeOfTransferList.
	/// </summary>
	public class WebFormList_PurposeOfTransferList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_PurposeOfTransferList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_PurposeOfTransferList_SelectDisplay repeater_PurposeOfTransferList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentModeBaseTypeList com_PaymentModeBaseType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Value;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PaymentModeBaseType;
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

				// com_PaymentModeBaseType
				System.Data.SqlTypes.SqlString colPaymentModeBaseType = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["PaymentModeBaseType"] != String.Empty) {
				
					try {
					
						colPaymentModeBaseType = Request.Params["PaymentModeBaseType"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PaymentModeBaseType.Initialize(ConnectionString);
				try {

					com_PaymentModeBaseType.RefreshData(colPaymentModeBaseType);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentModeBaseTypeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_PaymentModeBaseTypeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PaymentModeBaseType.Items.Insert(0, "Show all");

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

				if (ViewState["WebFormList_PurposeOfTransferList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_PurposeOfTransferList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_PurposeOfTransferList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_PurposeOfTransferList_SelectDisplay.EnableViewState = true;

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

			this.com_PaymentModeBaseType.SelectedIndexChanged += new System.EventHandler(this.com_PaymentModeBaseType_SelectedIndexChanged);
			this.Label_Name.Click += new System.EventHandler(this.Label_Name_Click);
			this.Label_Value.Click += new System.EventHandler(this.Label_Value_Click);
			this.Label_PaymentModeBaseType.Click += new System.EventHandler(this.Label_PaymentModeBaseType_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Name
			, SortBy_Value
			, SortBy_PaymentModeBaseType
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_PaymentModeBaseType_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlString PaymentModeBaseType = System.Data.SqlTypes.SqlString.Null;
			if (com_PaymentModeBaseType.SelectedIndex != 0) {

				PaymentModeBaseType = new System.Data.SqlTypes.SqlString(com_PaymentModeBaseType.SelectedItem.Value);
			}

			repeater_PurposeOfTransferList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlString.Null, PaymentModeBaseType);
			try {

				repeater_PurposeOfTransferList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_PurposeOfTransferList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_PurposeOfTransferList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_PurposeOfTransferList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_PurposeOfTransferList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Name:
					SortDirective = spS_PurposeOfTransferList.Resultset1.Fields.Column_Name.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Value:
					SortDirective = spS_PurposeOfTransferList.Resultset1.Fields.Column_Value.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PaymentModeBaseType:
					SortDirective = spS_PurposeOfTransferList_SelectDisplay.Resultset1.Fields.Column_PaymentModeBaseType_Display.ColumnName;
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
			repeater_PurposeOfTransferList_SelectDisplay.DataBind();
		}

		private void Label_Name_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PurposeOfTransferList_CurrentSort"] == CurrentSortEnum.SortBy_Name) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PurposeOfTransferList_CurrentSort"] = CurrentSortEnum.SortBy_Name;
			}

			RefreshList();
		}

		private void Label_Value_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PurposeOfTransferList_CurrentSort"] == CurrentSortEnum.SortBy_Value) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PurposeOfTransferList_CurrentSort"] = CurrentSortEnum.SortBy_Value;
			}

			RefreshList();
		}

		private void Label_PaymentModeBaseType_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PurposeOfTransferList_CurrentSort"] == CurrentSortEnum.SortBy_PaymentModeBaseType) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PurposeOfTransferList_CurrentSort"] = CurrentSortEnum.SortBy_PaymentModeBaseType;
			}

			RefreshList();
		}

	}
}
