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
	/// Summary description for WebFormList_BeneficeryBankList.
	/// </summary>
	public class WebFormList_BeneficeryBankList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_BeneficeryBankList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_BeneficeryBankList_SelectDisplay repeater_BeneficeryBankList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerList com_CustomerId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CountryList com_CountryId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_CustomerId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AccountNumber;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_BranchName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Address;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_ZipCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_CountryId;
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

				// com_CustomerId
				System.Data.SqlTypes.SqlGuid colCustomerId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["CustomerId"] != String.Empty) {
				
					try {
					
						colCustomerId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["CustomerId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_CustomerId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_CustomerId.RefreshData(colCustomerId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CustomerList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CustomerList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_CustomerId.Items.Insert(0, "Show all");

				// com_CountryId
				System.Data.SqlTypes.SqlGuid colCountryId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["CountryId"] != String.Empty) {
				
					try {
					
						colCountryId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["CountryId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_CountryId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_CountryId.RefreshData(colCountryId);
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
				com_CountryId.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_CustomerId;
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

				if (ViewState["WebFormList_BeneficeryBankList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_BeneficeryBankList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_BeneficeryBankList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_BeneficeryBankList_SelectDisplay.EnableViewState = true;

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

			this.com_CustomerId.SelectedIndexChanged += new System.EventHandler(this.com_CustomerId_SelectedIndexChanged);
			this.com_CountryId.SelectedIndexChanged += new System.EventHandler(this.com_CountryId_SelectedIndexChanged);
			this.Label_CustomerId.Click += new System.EventHandler(this.Label_CustomerId_Click);
			this.Label_AccountNumber.Click += new System.EventHandler(this.Label_AccountNumber_Click);
			this.Label_Name.Click += new System.EventHandler(this.Label_Name_Click);
			this.Label_BranchName.Click += new System.EventHandler(this.Label_BranchName_Click);
			this.Label_Address.Click += new System.EventHandler(this.Label_Address_Click);
			this.Label_ZipCode.Click += new System.EventHandler(this.Label_ZipCode_Click);
			this.Label_CountryId.Click += new System.EventHandler(this.Label_CountryId_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_CustomerId
			, SortBy_AccountNumber
			, SortBy_Name
			, SortBy_BranchName
			, SortBy_Address
			, SortBy_ZipCode
			, SortBy_CountryId
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_CustomerId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_CountryId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid CustomerId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_CustomerId.SelectedIndex != 0) {

				CustomerId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_CustomerId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid CountryId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_CountryId.SelectedIndex != 0) {

				CountryId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_CountryId.SelectedItem.Value));
			}

			repeater_BeneficeryBankList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, CustomerId, CountryId);
			try {

				repeater_BeneficeryBankList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_BeneficeryBankList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_BeneficeryBankList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_BeneficeryBankList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_BeneficeryBankList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_CustomerId:
					SortDirective = spS_BeneficeryBankList_SelectDisplay.Resultset1.Fields.Column_CustomerId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AccountNumber:
					SortDirective = spS_BeneficeryBankList.Resultset1.Fields.Column_AccountNumber.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Name:
					SortDirective = spS_BeneficeryBankList.Resultset1.Fields.Column_Name.ColumnName;
					break;

				case CurrentSortEnum.SortBy_BranchName:
					SortDirective = spS_BeneficeryBankList.Resultset1.Fields.Column_BranchName.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Address:
					SortDirective = spS_BeneficeryBankList.Resultset1.Fields.Column_Address.ColumnName;
					break;

				case CurrentSortEnum.SortBy_ZipCode:
					SortDirective = spS_BeneficeryBankList.Resultset1.Fields.Column_ZipCode.ColumnName;
					break;

				case CurrentSortEnum.SortBy_CountryId:
					SortDirective = spS_BeneficeryBankList_SelectDisplay.Resultset1.Fields.Column_CountryId_Display.ColumnName;
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
			repeater_BeneficeryBankList_SelectDisplay.DataBind();
		}

		private void Label_CustomerId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BeneficeryBankList_CurrentSort"] == CurrentSortEnum.SortBy_CustomerId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BeneficeryBankList_CurrentSort"] = CurrentSortEnum.SortBy_CustomerId;
			}

			RefreshList();
		}

		private void Label_AccountNumber_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BeneficeryBankList_CurrentSort"] == CurrentSortEnum.SortBy_AccountNumber) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BeneficeryBankList_CurrentSort"] = CurrentSortEnum.SortBy_AccountNumber;
			}

			RefreshList();
		}

		private void Label_Name_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BeneficeryBankList_CurrentSort"] == CurrentSortEnum.SortBy_Name) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BeneficeryBankList_CurrentSort"] = CurrentSortEnum.SortBy_Name;
			}

			RefreshList();
		}

		private void Label_BranchName_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BeneficeryBankList_CurrentSort"] == CurrentSortEnum.SortBy_BranchName) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BeneficeryBankList_CurrentSort"] = CurrentSortEnum.SortBy_BranchName;
			}

			RefreshList();
		}

		private void Label_Address_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BeneficeryBankList_CurrentSort"] == CurrentSortEnum.SortBy_Address) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BeneficeryBankList_CurrentSort"] = CurrentSortEnum.SortBy_Address;
			}

			RefreshList();
		}

		private void Label_ZipCode_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BeneficeryBankList_CurrentSort"] == CurrentSortEnum.SortBy_ZipCode) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BeneficeryBankList_CurrentSort"] = CurrentSortEnum.SortBy_ZipCode;
			}

			RefreshList();
		}

		private void Label_CountryId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_BeneficeryBankList_CurrentSort"] == CurrentSortEnum.SortBy_CountryId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_BeneficeryBankList_CurrentSort"] = CurrentSortEnum.SortBy_CountryId;
			}

			RefreshList();
		}

	}
}
