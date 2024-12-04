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
	/// Summary description for WebFormList_AgentLocationList.
	/// </summary>
	public class WebFormList_AgentLocationList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_AgentLocationList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_AgentLocationList_SelectDisplay repeater_AgentLocationList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentMaster com_AgentAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentGroupList com_AgentGroupId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionTypeList com_AllowedDomesticTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionTypeList com_AllowedInternationalTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionTypeList com_ListOnWebFor;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_LocationList com_LocationId;
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
		protected System.Web.UI.WebControls.LinkButton Label_AgentAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AgentGroupId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_CreditLimitInUSD;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_IndividualTransactionLimit;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AllowedDomesticTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AllowedInternationalTransactionType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_ListOnWebFor;
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
		protected System.Web.UI.WebControls.LinkButton Label_Email;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_LocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_ContactPerson;
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

				// com_AgentAccountId
				System.Data.SqlTypes.SqlGuid colAgentAccountId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["AgentAccountId"] != String.Empty) {
				
					try {
					
						colAgentAccountId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["AgentAccountId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_AgentAccountId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_AgentAccountId.RefreshData(colAgentAccountId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgentMaster' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgentMaster' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_AgentAccountId.Items.Insert(0, "Show all");

				// com_AgentGroupId
				System.Data.SqlTypes.SqlGuid colAgentGroupId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["AgentGroupId"] != String.Empty) {
				
					try {
					
						colAgentGroupId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["AgentGroupId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_AgentGroupId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_AgentGroupId.RefreshData(colAgentGroupId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgentGroupList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgentGroupList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_AgentGroupId.Items.Insert(0, "Show all");

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

				// com_ListOnWebFor
				System.Data.SqlTypes.SqlString colListOnWebFor = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["ListOnWebFor"] != String.Empty) {
				
					try {
					
						colListOnWebFor = Request.Params["ListOnWebFor"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_ListOnWebFor.Initialize(ConnectionString);
				try {

					com_ListOnWebFor.RefreshData(colListOnWebFor);
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
				com_ListOnWebFor.Items.Insert(0, "Show all");

				// com_LocationId
				System.Data.SqlTypes.SqlGuid colLocationId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["LocationId"] != String.Empty) {
				
					try {
					
						colLocationId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["LocationId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_LocationId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_LocationId.RefreshData(colLocationId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_LocationList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_LocationList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_LocationId.Items.Insert(0, "Show all");

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

				if (ViewState["WebFormList_AgentLocationList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_AgentLocationList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_AgentLocationList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_AgentLocationList_SelectDisplay.EnableViewState = true;

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

			this.com_AgentAccountId.SelectedIndexChanged += new System.EventHandler(this.com_AgentAccountId_SelectedIndexChanged);
			this.com_AgentGroupId.SelectedIndexChanged += new System.EventHandler(this.com_AgentGroupId_SelectedIndexChanged);
			this.com_AllowedDomesticTransactionType.SelectedIndexChanged += new System.EventHandler(this.com_AllowedDomesticTransactionType_SelectedIndexChanged);
			this.com_AllowedInternationalTransactionType.SelectedIndexChanged += new System.EventHandler(this.com_AllowedInternationalTransactionType_SelectedIndexChanged);
			this.com_ListOnWebFor.SelectedIndexChanged += new System.EventHandler(this.com_ListOnWebFor_SelectedIndexChanged);
			this.com_LocationId.SelectedIndexChanged += new System.EventHandler(this.com_LocationId_SelectedIndexChanged);
			this.Label_Name.Click += new System.EventHandler(this.Label_Name_Click);
			this.Label_Code.Click += new System.EventHandler(this.Label_Code_Click);
			this.Label_AgentAccountId.Click += new System.EventHandler(this.Label_AgentAccountId_Click);
			this.Label_AgentGroupId.Click += new System.EventHandler(this.Label_AgentGroupId_Click);
			this.Label_CreditLimitInUSD.Click += new System.EventHandler(this.Label_CreditLimitInUSD_Click);
			this.Label_IndividualTransactionLimit.Click += new System.EventHandler(this.Label_IndividualTransactionLimit_Click);
			this.Label_AllowedDomesticTransactionType.Click += new System.EventHandler(this.Label_AllowedDomesticTransactionType_Click);
			this.Label_AllowedInternationalTransactionType.Click += new System.EventHandler(this.Label_AllowedInternationalTransactionType_Click);
			this.Label_ListOnWebFor.Click += new System.EventHandler(this.Label_ListOnWebFor_Click);
			this.Label_Address.Click += new System.EventHandler(this.Label_Address_Click);
			this.Label_Telephone.Click += new System.EventHandler(this.Label_Telephone_Click);
			this.Label_Fax.Click += new System.EventHandler(this.Label_Fax_Click);
			this.Label_Email.Click += new System.EventHandler(this.Label_Email_Click);
			this.Label_LocationId.Click += new System.EventHandler(this.Label_LocationId_Click);
			this.Label_ContactPerson.Click += new System.EventHandler(this.Label_ContactPerson_Click);
			this.Label_Active.Click += new System.EventHandler(this.Label_Active_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Name
			, SortBy_Code
			, SortBy_AgentAccountId
			, SortBy_AgentGroupId
			, SortBy_CreditLimitInUSD
			, SortBy_IndividualTransactionLimit
			, SortBy_AllowedDomesticTransactionType
			, SortBy_AllowedInternationalTransactionType
			, SortBy_ListOnWebFor
			, SortBy_Address
			, SortBy_Telephone
			, SortBy_Fax
			, SortBy_Email
			, SortBy_LocationId
			, SortBy_ContactPerson
			, SortBy_Active
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_AgentAccountId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_AgentGroupId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_AllowedDomesticTransactionType_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_AllowedInternationalTransactionType_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_ListOnWebFor_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_LocationId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid AgentAccountId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_AgentAccountId.SelectedIndex != 0) {

				AgentAccountId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_AgentAccountId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid AgentGroupId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_AgentGroupId.SelectedIndex != 0) {

				AgentGroupId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_AgentGroupId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlString AllowedDomesticTransactionType = System.Data.SqlTypes.SqlString.Null;
			if (com_AllowedDomesticTransactionType.SelectedIndex != 0) {

				AllowedDomesticTransactionType = new System.Data.SqlTypes.SqlString(com_AllowedDomesticTransactionType.SelectedItem.Value);
			}

			System.Data.SqlTypes.SqlString AllowedInternationalTransactionType = System.Data.SqlTypes.SqlString.Null;
			if (com_AllowedInternationalTransactionType.SelectedIndex != 0) {

				AllowedInternationalTransactionType = new System.Data.SqlTypes.SqlString(com_AllowedInternationalTransactionType.SelectedItem.Value);
			}

			System.Data.SqlTypes.SqlString ListOnWebFor = System.Data.SqlTypes.SqlString.Null;
			if (com_ListOnWebFor.SelectedIndex != 0) {

				ListOnWebFor = new System.Data.SqlTypes.SqlString(com_ListOnWebFor.SelectedItem.Value);
			}

			System.Data.SqlTypes.SqlGuid LocationId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_LocationId.SelectedIndex != 0) {

				LocationId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_LocationId.SelectedItem.Value));
			}

			repeater_AgentLocationList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, AgentAccountId, AgentGroupId, AllowedDomesticTransactionType, AllowedInternationalTransactionType, ListOnWebFor, LocationId);
			try {

				repeater_AgentLocationList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgentLocationList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgentLocationList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_AgentLocationList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Name:
					SortDirective = spS_AgentLocationList.Resultset1.Fields.Column_Name.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Code:
					SortDirective = spS_AgentLocationList.Resultset1.Fields.Column_Code.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AgentAccountId:
					SortDirective = spS_AgentLocationList_SelectDisplay.Resultset1.Fields.Column_AgentAccountId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AgentGroupId:
					SortDirective = spS_AgentLocationList_SelectDisplay.Resultset1.Fields.Column_AgentGroupId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_CreditLimitInUSD:
					SortDirective = spS_AgentLocationList.Resultset1.Fields.Column_CreditLimitInUSD.ColumnName;
					break;

				case CurrentSortEnum.SortBy_IndividualTransactionLimit:
					SortDirective = spS_AgentLocationList.Resultset1.Fields.Column_IndividualTransactionLimit.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AllowedDomesticTransactionType:
					SortDirective = spS_AgentLocationList_SelectDisplay.Resultset1.Fields.Column_AllowedDomesticTransactionType_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AllowedInternationalTransactionType:
					SortDirective = spS_AgentLocationList_SelectDisplay.Resultset1.Fields.Column_AllowedInternationalTransactionType_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_ListOnWebFor:
					SortDirective = spS_AgentLocationList_SelectDisplay.Resultset1.Fields.Column_ListOnWebFor_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Address:
					SortDirective = spS_AgentLocationList.Resultset1.Fields.Column_Address.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Telephone:
					SortDirective = spS_AgentLocationList.Resultset1.Fields.Column_Telephone.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Fax:
					SortDirective = spS_AgentLocationList.Resultset1.Fields.Column_Fax.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Email:
					SortDirective = spS_AgentLocationList.Resultset1.Fields.Column_Email.ColumnName;
					break;

				case CurrentSortEnum.SortBy_LocationId:
					SortDirective = spS_AgentLocationList_SelectDisplay.Resultset1.Fields.Column_LocationId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_ContactPerson:
					SortDirective = spS_AgentLocationList.Resultset1.Fields.Column_ContactPerson.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Active:
					SortDirective = spS_AgentLocationList.Resultset1.Fields.Column_Active.ColumnName;
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
			repeater_AgentLocationList_SelectDisplay.DataBind();
		}

		private void Label_Name_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_Name) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_Name;
			}

			RefreshList();
		}

		private void Label_Code_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_Code) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_Code;
			}

			RefreshList();
		}

		private void Label_AgentAccountId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_AgentAccountId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_AgentAccountId;
			}

			RefreshList();
		}

		private void Label_AgentGroupId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_AgentGroupId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_AgentGroupId;
			}

			RefreshList();
		}

		private void Label_CreditLimitInUSD_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_CreditLimitInUSD) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_CreditLimitInUSD;
			}

			RefreshList();
		}

		private void Label_IndividualTransactionLimit_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_IndividualTransactionLimit) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_IndividualTransactionLimit;
			}

			RefreshList();
		}

		private void Label_AllowedDomesticTransactionType_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_AllowedDomesticTransactionType) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_AllowedDomesticTransactionType;
			}

			RefreshList();
		}

		private void Label_AllowedInternationalTransactionType_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_AllowedInternationalTransactionType) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_AllowedInternationalTransactionType;
			}

			RefreshList();
		}

		private void Label_ListOnWebFor_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_ListOnWebFor) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_ListOnWebFor;
			}

			RefreshList();
		}

		private void Label_Address_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_Address) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_Address;
			}

			RefreshList();
		}

		private void Label_Telephone_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_Telephone) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_Telephone;
			}

			RefreshList();
		}

		private void Label_Fax_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_Fax) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_Fax;
			}

			RefreshList();
		}

		private void Label_Email_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_Email) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_Email;
			}

			RefreshList();
		}

		private void Label_LocationId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_LocationId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_LocationId;
			}

			RefreshList();
		}

		private void Label_ContactPerson_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_ContactPerson) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_ContactPerson;
			}

			RefreshList();
		}

		private void Label_Active_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentLocationList_CurrentSort"] == CurrentSortEnum.SortBy_Active) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentLocationList_CurrentSort"] = CurrentSortEnum.SortBy_Active;
			}

			RefreshList();
		}

	}
}
