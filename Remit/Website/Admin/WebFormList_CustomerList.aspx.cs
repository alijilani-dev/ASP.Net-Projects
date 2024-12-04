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
	/// Summary description for WebFormList_CustomerList.
	/// </summary>
	public class WebFormList_CustomerList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_CustomerList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_CustomerList_SelectDisplay repeater_CustomerList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerCardList com_CardId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_MasterCountryList com_Nationality;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_LoginName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Password;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_FirstName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_LastName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_CardId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Address;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Telephone;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Fax;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Mobile;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Email;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_IDType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_IDDetails;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_IDExpirationDate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Nationality;
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

				// com_CardId
				System.Data.SqlTypes.SqlGuid colCardId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["CardId"] != String.Empty) {
				
					try {
					
						colCardId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["CardId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_CardId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
				try {

					com_CardId.RefreshData(colCardId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CustomerCardList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CustomerCardList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_CardId.Items.Insert(0, "Show all");

				// com_Nationality
				System.Data.SqlTypes.SqlString colNationality = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["Nationality"] != String.Empty) {
				
					try {
					
						colNationality = Request.Params["Nationality"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_Nationality.Initialize(ConnectionString);
				try {

					com_Nationality.RefreshData(colNationality);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_MasterCountryList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_MasterCountryList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_Nationality.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_LoginName;
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

				if (ViewState["WebFormList_CustomerList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_CustomerList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_CustomerList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_CustomerList_SelectDisplay.EnableViewState = true;

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

			this.com_CardId.SelectedIndexChanged += new System.EventHandler(this.com_CardId_SelectedIndexChanged);
			this.com_Nationality.SelectedIndexChanged += new System.EventHandler(this.com_Nationality_SelectedIndexChanged);
			this.Label_LoginName.Click += new System.EventHandler(this.Label_LoginName_Click);
			this.Label_Password.Click += new System.EventHandler(this.Label_Password_Click);
			this.Label_FirstName.Click += new System.EventHandler(this.Label_FirstName_Click);
			this.Label_LastName.Click += new System.EventHandler(this.Label_LastName_Click);
			this.Label_CardId.Click += new System.EventHandler(this.Label_CardId_Click);
			this.Label_Address.Click += new System.EventHandler(this.Label_Address_Click);
			this.Label_Telephone.Click += new System.EventHandler(this.Label_Telephone_Click);
			this.Label_Fax.Click += new System.EventHandler(this.Label_Fax_Click);
			this.Label_Mobile.Click += new System.EventHandler(this.Label_Mobile_Click);
			this.Label_Email.Click += new System.EventHandler(this.Label_Email_Click);
			this.Label_IDType.Click += new System.EventHandler(this.Label_IDType_Click);
			this.Label_IDDetails.Click += new System.EventHandler(this.Label_IDDetails_Click);
			this.Label_IDExpirationDate.Click += new System.EventHandler(this.Label_IDExpirationDate_Click);
			this.Label_Nationality.Click += new System.EventHandler(this.Label_Nationality_Click);
			this.Label_Active.Click += new System.EventHandler(this.Label_Active_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_LoginName
			, SortBy_Password
			, SortBy_FirstName
			, SortBy_LastName
			, SortBy_CardId
			, SortBy_Address
			, SortBy_Telephone
			, SortBy_Fax
			, SortBy_Mobile
			, SortBy_Email
			, SortBy_IDType
			, SortBy_IDDetails
			, SortBy_IDExpirationDate
			, SortBy_Nationality
			, SortBy_Active
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_CardId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_Nationality_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid CardId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_CardId.SelectedIndex != 0) {

				CardId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_CardId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlString Nationality = System.Data.SqlTypes.SqlString.Null;
			if (com_Nationality.SelectedIndex != 0) {

				Nationality = new System.Data.SqlTypes.SqlString(com_Nationality.SelectedItem.Value);
			}

			repeater_CustomerList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, CardId, Nationality);
			try {

				repeater_CustomerList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_CustomerList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_CustomerList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_CustomerList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_LoginName:
					SortDirective = spS_CustomerList.Resultset1.Fields.Column_LoginName.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Password:
					SortDirective = spS_CustomerList.Resultset1.Fields.Column_Password.ColumnName;
					break;

				case CurrentSortEnum.SortBy_FirstName:
					SortDirective = spS_CustomerList.Resultset1.Fields.Column_FirstName.ColumnName;
					break;

				case CurrentSortEnum.SortBy_LastName:
					SortDirective = spS_CustomerList.Resultset1.Fields.Column_LastName.ColumnName;
					break;

				case CurrentSortEnum.SortBy_CardId:
					SortDirective = spS_CustomerList_SelectDisplay.Resultset1.Fields.Column_CardId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Address:
					SortDirective = spS_CustomerList.Resultset1.Fields.Column_Address.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Telephone:
					SortDirective = spS_CustomerList.Resultset1.Fields.Column_Telephone.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Fax:
					SortDirective = spS_CustomerList.Resultset1.Fields.Column_Fax.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Mobile:
					SortDirective = spS_CustomerList.Resultset1.Fields.Column_Mobile.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Email:
					SortDirective = spS_CustomerList.Resultset1.Fields.Column_Email.ColumnName;
					break;

				case CurrentSortEnum.SortBy_IDType:
					SortDirective = spS_CustomerList.Resultset1.Fields.Column_IDType.ColumnName;
					break;

				case CurrentSortEnum.SortBy_IDDetails:
					SortDirective = spS_CustomerList.Resultset1.Fields.Column_IDDetails.ColumnName;
					break;

				case CurrentSortEnum.SortBy_IDExpirationDate:
					SortDirective = spS_CustomerList.Resultset1.Fields.Column_IDExpirationDate.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Nationality:
					SortDirective = spS_CustomerList_SelectDisplay.Resultset1.Fields.Column_Nationality_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Active:
					SortDirective = spS_CustomerList.Resultset1.Fields.Column_Active.ColumnName;
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
			repeater_CustomerList_SelectDisplay.DataBind();
		}

		private void Label_LoginName_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_LoginName) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_LoginName;
			}

			RefreshList();
		}

		private void Label_Password_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_Password) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_Password;
			}

			RefreshList();
		}

		private void Label_FirstName_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_FirstName) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_FirstName;
			}

			RefreshList();
		}

		private void Label_LastName_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_LastName) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_LastName;
			}

			RefreshList();
		}

		private void Label_CardId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_CardId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_CardId;
			}

			RefreshList();
		}

		private void Label_Address_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_Address) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_Address;
			}

			RefreshList();
		}

		private void Label_Telephone_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_Telephone) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_Telephone;
			}

			RefreshList();
		}

		private void Label_Fax_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_Fax) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_Fax;
			}

			RefreshList();
		}

		private void Label_Mobile_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_Mobile) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_Mobile;
			}

			RefreshList();
		}

		private void Label_Email_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_Email) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_Email;
			}

			RefreshList();
		}

		private void Label_IDType_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_IDType) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_IDType;
			}

			RefreshList();
		}

		private void Label_IDDetails_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_IDDetails) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_IDDetails;
			}

			RefreshList();
		}

		private void Label_IDExpirationDate_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_IDExpirationDate) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_IDExpirationDate;
			}

			RefreshList();
		}

		private void Label_Nationality_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_Nationality) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_Nationality;
			}

			RefreshList();
		}

		private void Label_Active_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_CustomerList_CurrentSort"] == CurrentSortEnum.SortBy_Active) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_CustomerList_CurrentSort"] = CurrentSortEnum.SortBy_Active;
			}

			RefreshList();
		}

	}
}
