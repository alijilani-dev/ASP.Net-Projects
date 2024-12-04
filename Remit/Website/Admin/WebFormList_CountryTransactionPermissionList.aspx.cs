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
	/// Summary description for WebFormList_CountryTransactionPermissionList.
	/// </summary>
	public class WebFormList_CountryTransactionPermissionList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_CountryTransactionPermissionList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_CountryTransactionPermissionList_SelectDisplay repeater_CountryTransactionPermissionList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryList com_BaseCountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryList com_TargetCountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryTransactionPermissionTypeList com_PermissionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_BaseCountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_TargetCountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_PermissionType;
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

				// com_BaseCountryId
				System.Data.SqlTypes.SqlGuid colBaseCountryId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["BaseCountryId"] != String.Empty) {
				
					try {
					
						colBaseCountryId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["BaseCountryId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_BaseCountryId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_BaseCountryId.RefreshData(colBaseCountryId);
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
				com_BaseCountryId.Items.Insert(0, "Show all");

				// com_TargetCountryId
				System.Data.SqlTypes.SqlGuid colTargetCountryId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["TargetCountryId"] != String.Empty) {
				
					try {
					
						colTargetCountryId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["TargetCountryId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_TargetCountryId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_TargetCountryId.RefreshData(colTargetCountryId);
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
				com_TargetCountryId.Items.Insert(0, "Show all");

				// com_PermissionType
				System.Data.SqlTypes.SqlString colPermissionType = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["PermissionType"] != String.Empty) {
				
					try {
					
						colPermissionType = Request.Params["PermissionType"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_PermissionType.Initialize(ConnectionString);
				try {

					com_PermissionType.RefreshData(colPermissionType);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CountryTransactionPermissionTypeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CountryTransactionPermissionTypeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_PermissionType.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_BaseCountryId;
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

				if (ViewState["WebFormList_CountryTransactionPermissionList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_CountryTransactionPermissionList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_CountryTransactionPermissionList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_CountryTransactionPermissionList_SelectDisplay.EnableViewState = true;

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

			this.com_BaseCountryId.SelectedIndexChanged += new System.EventHandler(this.com_BaseCountryId_SelectedIndexChanged);
			this.com_TargetCountryId.SelectedIndexChanged += new System.EventHandler(this.com_TargetCountryId_SelectedIndexChanged);
			this.com_PermissionType.SelectedIndexChanged += new System.EventHandler(this.com_PermissionType_SelectedIndexChanged);
			this.Label_BaseCountryId.Click += new System.EventHandler(this.Label_BaseCountryId_Click);
			this.Label_TargetCountryId.Click += new System.EventHandler(this.Label_TargetCountryId_Click);
			this.Label_PermissionType.Click += new System.EventHandler(this.Label_PermissionType_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_BaseCountryId
			, SortBy_TargetCountryId
			, SortBy_PermissionType
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_BaseCountryId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_TargetCountryId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_PermissionType_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid BaseCountryId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_BaseCountryId.SelectedIndex != 0) {

				BaseCountryId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_BaseCountryId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid TargetCountryId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_TargetCountryId.SelectedIndex != 0) {

				TargetCountryId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_TargetCountryId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlString PermissionType = System.Data.SqlTypes.SqlString.Null;
			if (com_PermissionType.SelectedIndex != 0) {

				PermissionType = new System.Data.SqlTypes.SqlString(com_PermissionType.SelectedItem.Value);
			}

			repeater_CountryTransactionPermissionList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, BaseCountryId, TargetCountryId, PermissionType);
			try {

				repeater_CountryTransactionPermissionList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_CountryTransactionPermissionList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_CountryTransactionPermissionList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_CountryTransactionPermissionList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_CountryTransactionPermissionList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_BaseCountryId:
					SortDirective = spS_CountryTransactionPermissionList_SelectDisplay.Resultset1.Fields.Column_BaseCountryId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TargetCountryId:
					SortDirective = spS_CountryTransactionPermissionList_SelectDisplay.Resultset1.Fields.Column_TargetCountryId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_PermissionType:
					SortDirective = spS_CountryTransactionPermissionList_SelectDisplay.Resultset1.Fields.Column_PermissionType_Display.ColumnName;
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
			repeater_CountryTransactionPermissionList_SelectDisplay.DataBind();
		}

		private void Label_BaseCountryId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryTransactionPermissionList_CurrentSort"] == CurrentSortEnum.SortBy_BaseCountryId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryTransactionPermissionList_CurrentSort"] = CurrentSortEnum.SortBy_BaseCountryId;
			}

			RefreshList();
		}

		private void Label_TargetCountryId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryTransactionPermissionList_CurrentSort"] == CurrentSortEnum.SortBy_TargetCountryId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryTransactionPermissionList_CurrentSort"] = CurrentSortEnum.SortBy_TargetCountryId;
			}

			RefreshList();
		}

		private void Label_PermissionType_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CountryTransactionPermissionList_CurrentSort"] == CurrentSortEnum.SortBy_PermissionType) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CountryTransactionPermissionList_CurrentSort"] = CurrentSortEnum.SortBy_PermissionType;
			}

			RefreshList();
		}

	}
}
