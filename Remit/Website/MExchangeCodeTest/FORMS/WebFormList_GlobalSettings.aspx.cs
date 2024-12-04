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
	/// Summary description for WebFormList_GlobalSettings.
	/// </summary>
	public class WebFormList_GlobalSettings: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_GlobalSettings() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeater_GlobalSettings repeater_GlobalSettings_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AdministrativeEmail;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_TechnicalEmail;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_TransactionThreshold;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_TransactionNumberFormat;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_TransactionThresholdUSD;
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

				if (ViewState["WebFormList_GlobalSettings_CurrentSort"] == null) {

					ViewState.Add("WebFormList_GlobalSettings_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_GlobalSettings_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_GlobalSettings_SelectDisplay.EnableViewState = true;

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

			this.Label_Name.Click += new System.EventHandler(this.Label_Name_Click);
			this.Label_AdministrativeEmail.Click += new System.EventHandler(this.Label_AdministrativeEmail_Click);
			this.Label_TechnicalEmail.Click += new System.EventHandler(this.Label_TechnicalEmail_Click);
			this.Label_TransactionThreshold.Click += new System.EventHandler(this.Label_TransactionThreshold_Click);
			this.Label_TransactionNumberFormat.Click += new System.EventHandler(this.Label_TransactionNumberFormat_Click);
			this.Label_TransactionThresholdUSD.Click += new System.EventHandler(this.Label_TransactionThresholdUSD_Click);
			this.Label_Active.Click += new System.EventHandler(this.Label_Active_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_Name
			, SortBy_AdministrativeEmail
			, SortBy_TechnicalEmail
			, SortBy_TransactionThreshold
			, SortBy_TransactionNumberFormat
			, SortBy_TransactionThresholdUSD
			, SortBy_Active
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void RefreshList() {

			repeater_GlobalSettings_SelectDisplay.Initialize(ConnectionString);
			try {

				repeater_GlobalSettings_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_GlobalSettings' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_GlobalSettings' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_GlobalSettings_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_GlobalSettings_CurrentSort"]) {

				case CurrentSortEnum.SortBy_Name:
					SortDirective = spS_GlobalSettings.Resultset1.Fields.Column_Name.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AdministrativeEmail:
					SortDirective = spS_GlobalSettings.Resultset1.Fields.Column_AdministrativeEmail.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TechnicalEmail:
					SortDirective = spS_GlobalSettings.Resultset1.Fields.Column_TechnicalEmail.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TransactionThreshold:
					SortDirective = spS_GlobalSettings.Resultset1.Fields.Column_TransactionThreshold.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TransactionNumberFormat:
					SortDirective = spS_GlobalSettings.Resultset1.Fields.Column_TransactionNumberFormat.ColumnName;
					break;

				case CurrentSortEnum.SortBy_TransactionThresholdUSD:
					SortDirective = spS_GlobalSettings.Resultset1.Fields.Column_TransactionThresholdUSD.ColumnName;
					break;

				case CurrentSortEnum.SortBy_Active:
					SortDirective = spS_GlobalSettings.Resultset1.Fields.Column_Active.ColumnName;
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
			repeater_GlobalSettings_SelectDisplay.DataBind();
		}

		private void Label_Name_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_GlobalSettings_CurrentSort"] == CurrentSortEnum.SortBy_Name) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_GlobalSettings_CurrentSort"] = CurrentSortEnum.SortBy_Name;
			}

			RefreshList();
		}

		private void Label_AdministrativeEmail_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_GlobalSettings_CurrentSort"] == CurrentSortEnum.SortBy_AdministrativeEmail) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_GlobalSettings_CurrentSort"] = CurrentSortEnum.SortBy_AdministrativeEmail;
			}

			RefreshList();
		}

		private void Label_TechnicalEmail_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_GlobalSettings_CurrentSort"] == CurrentSortEnum.SortBy_TechnicalEmail) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_GlobalSettings_CurrentSort"] = CurrentSortEnum.SortBy_TechnicalEmail;
			}

			RefreshList();
		}

		private void Label_TransactionThreshold_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_GlobalSettings_CurrentSort"] == CurrentSortEnum.SortBy_TransactionThreshold) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_GlobalSettings_CurrentSort"] = CurrentSortEnum.SortBy_TransactionThreshold;
			}

			RefreshList();
		}

		private void Label_TransactionNumberFormat_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_GlobalSettings_CurrentSort"] == CurrentSortEnum.SortBy_TransactionNumberFormat) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_GlobalSettings_CurrentSort"] = CurrentSortEnum.SortBy_TransactionNumberFormat;
			}

			RefreshList();
		}

		private void Label_TransactionThresholdUSD_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_GlobalSettings_CurrentSort"] == CurrentSortEnum.SortBy_TransactionThresholdUSD) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_GlobalSettings_CurrentSort"] = CurrentSortEnum.SortBy_TransactionThresholdUSD;
			}

			RefreshList();
		}

		private void Label_Active_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_GlobalSettings_CurrentSort"] == CurrentSortEnum.SortBy_Active) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_GlobalSettings_CurrentSort"] = CurrentSortEnum.SortBy_Active;
			}

			RefreshList();
		}

	}
}
