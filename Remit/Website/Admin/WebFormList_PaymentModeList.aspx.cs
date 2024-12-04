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
	/// Summary description for WebFormList_PaymentModeList.
	/// </summary>
	public class WebFormList_PaymentModeList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_PaymentModeList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_PaymentModeList_SelectDisplay repeater_PaymentModeList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_PaymentModeBaseTypeList com_BaseType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_EntityList com_ChannelThrough;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_EntityList com_FinalEntity;
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
		protected System.Web.UI.WebControls.LinkButton Label_BaseType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_ChannelThrough;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_FinalEntity;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Prefix;
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

				// com_BaseType
				System.Data.SqlTypes.SqlString colBaseType = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["BaseType"] != String.Empty) {
				
					try {
					
						colBaseType = Request.Params["BaseType"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_BaseType.Initialize(ConnectionString);
				try {

					com_BaseType.RefreshData(colBaseType);
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
				com_BaseType.Items.Insert(0, "Show all");

				// com_ChannelThrough
				System.Data.SqlTypes.SqlString colChannelThrough = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["ChannelThrough"] != String.Empty) {
				
					try {
					
						colChannelThrough = Request.Params["ChannelThrough"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_ChannelThrough.Initialize(ConnectionString);
				try {

					com_ChannelThrough.RefreshData(colChannelThrough);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_EntityList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_EntityList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_ChannelThrough.Items.Insert(0, "Show all");

				// com_FinalEntity
				System.Data.SqlTypes.SqlString colFinalEntity = System.Data.SqlTypes.SqlString.Null;
				if (Request.Params["FinalEntity"] != String.Empty) {
				
					try {
					
						colFinalEntity = Request.Params["FinalEntity"];
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_FinalEntity.Initialize(ConnectionString);
				try {

					com_FinalEntity.RefreshData(colFinalEntity);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_EntityList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_EntityList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_FinalEntity.Items.Insert(0, "Show all");

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

				if (ViewState["WebFormList_PaymentModeList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_PaymentModeList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_PaymentModeList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_PaymentModeList_SelectDisplay.EnableViewState = true;

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

			this.com_BaseType.SelectedIndexChanged += new System.EventHandler(this.com_BaseType_SelectedIndexChanged);
			this.com_ChannelThrough.SelectedIndexChanged += new System.EventHandler(this.com_ChannelThrough_SelectedIndexChanged);
			this.com_FinalEntity.SelectedIndexChanged += new System.EventHandler(this.com_FinalEntity_SelectedIndexChanged);
			this.Label_Name.Click += new System.EventHandler(this.Label_Name_Click);
			this.Label_Value.Click += new System.EventHandler(this.Label_Value_Click);
			this.Label_BaseType.Click += new System.EventHandler(this.Label_BaseType_Click);
			this.Label_ChannelThrough.Click += new System.EventHandler(this.Label_ChannelThrough_Click);
			this.Label_FinalEntity.Click += new System.EventHandler(this.Label_FinalEntity_Click);
			this.Label_Prefix.Click += new System.EventHandler(this.Label_Prefix_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Name
			, SortBy_Value
			, SortBy_BaseType
			, SortBy_ChannelThrough
			, SortBy_FinalEntity
			, SortBy_Prefix
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_BaseType_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_ChannelThrough_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_FinalEntity_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlString BaseType = System.Data.SqlTypes.SqlString.Null;
			if (com_BaseType.SelectedIndex != 0) {

				BaseType = new System.Data.SqlTypes.SqlString(com_BaseType.SelectedItem.Value);
			}

			System.Data.SqlTypes.SqlString ChannelThrough = System.Data.SqlTypes.SqlString.Null;
			if (com_ChannelThrough.SelectedIndex != 0) {

				ChannelThrough = new System.Data.SqlTypes.SqlString(com_ChannelThrough.SelectedItem.Value);
			}

			System.Data.SqlTypes.SqlString FinalEntity = System.Data.SqlTypes.SqlString.Null;
			if (com_FinalEntity.SelectedIndex != 0) {

				FinalEntity = new System.Data.SqlTypes.SqlString(com_FinalEntity.SelectedItem.Value);
			}

			repeater_PaymentModeList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlString.Null, BaseType, ChannelThrough, FinalEntity);
			try {

				repeater_PaymentModeList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_PaymentModeList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_PaymentModeList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_PaymentModeList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_PaymentModeList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Name:
					SortDirective = spS_PaymentModeList.Resultset1.Fields.Column_Name.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Value:
					SortDirective = spS_PaymentModeList.Resultset1.Fields.Column_Value.ColumnName;
					break;

				case CurrentSortEnum.SortBy_BaseType:
					SortDirective = spS_PaymentModeList_SelectDisplay.Resultset1.Fields.Column_BaseType_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_ChannelThrough:
					SortDirective = spS_PaymentModeList_SelectDisplay.Resultset1.Fields.Column_ChannelThrough_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_FinalEntity:
					SortDirective = spS_PaymentModeList_SelectDisplay.Resultset1.Fields.Column_FinalEntity_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Prefix:
					SortDirective = spS_PaymentModeList.Resultset1.Fields.Column_Prefix.ColumnName;
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
			repeater_PaymentModeList_SelectDisplay.DataBind();
		}

		private void Label_Name_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentModeList_CurrentSort"] == CurrentSortEnum.SortBy_Name) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentModeList_CurrentSort"] = CurrentSortEnum.SortBy_Name;
			}

			RefreshList();
		}

		private void Label_Value_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentModeList_CurrentSort"] == CurrentSortEnum.SortBy_Value) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentModeList_CurrentSort"] = CurrentSortEnum.SortBy_Value;
			}

			RefreshList();
		}

		private void Label_BaseType_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentModeList_CurrentSort"] == CurrentSortEnum.SortBy_BaseType) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentModeList_CurrentSort"] = CurrentSortEnum.SortBy_BaseType;
			}

			RefreshList();
		}

		private void Label_ChannelThrough_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentModeList_CurrentSort"] == CurrentSortEnum.SortBy_ChannelThrough) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentModeList_CurrentSort"] = CurrentSortEnum.SortBy_ChannelThrough;
			}

			RefreshList();
		}

		private void Label_FinalEntity_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentModeList_CurrentSort"] == CurrentSortEnum.SortBy_FinalEntity) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentModeList_CurrentSort"] = CurrentSortEnum.SortBy_FinalEntity;
			}

			RefreshList();
		}

		private void Label_Prefix_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_PaymentModeList_CurrentSort"] == CurrentSortEnum.SortBy_Prefix) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_PaymentModeList_CurrentSort"] = CurrentSortEnum.SortBy_Prefix;
			}

			RefreshList();
		}

	}
}
