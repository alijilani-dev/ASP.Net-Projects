﻿using System;
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
	/// Summary description for WebFormList_AgentExchangeRateList.
	/// </summary>
	public class WebFormList_AgentExchangeRateList: System.Web.UI.Page
	{
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebFormList_AgentExchangeRateList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString = String.Empty;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.Repeaters.WebRepeaterCustom_spS_AgentExchangeRateList_SelectDisplay repeater_AgentExchangeRateList_SelectDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentMaster com_AgentAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgencyExchangeRateList com_AgencyExchangeRateId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AgentAccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_AgencyExchangeRateId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.LinkButton Label_MarginPercent;
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

				// com_AgencyExchangeRateId
				System.Data.SqlTypes.SqlGuid colAgencyExchangeRateId = System.Data.SqlTypes.SqlGuid.Null;
				if (Request.Params["AgencyExchangeRateId"] != String.Empty) {
				
					try {
					
						colAgencyExchangeRateId = System.Data.SqlTypes.SqlGuid.Parse(Request.Params["AgencyExchangeRateId"]);
					}
					catch {
					
						// Ignore the parameter and do nothing here
					}
				}
				com_AgencyExchangeRateId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
				try {

					com_AgencyExchangeRateId.RefreshData(colAgencyExchangeRateId);
				}
				catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

					if (customException.Parameter.SqlException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgencyExchangeRateList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
					}
					else if (customException.Parameter.OtherException != null) {

						throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_AgencyExchangeRateList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
					}
					else {

						throw;
					}
				}
				com_AgencyExchangeRateId.Items.Insert(0, "Show all");

				// Any sort preferences?
				CurrentSortEnum sortColumn = CurrentSortEnum.SortBy_AgentAccountId;
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

				if (ViewState["WebFormList_AgentExchangeRateList_CurrentSort"] == null) {

					ViewState.Add("WebFormList_AgentExchangeRateList_CurrentSort", sortColumn);
				}
				else {

					ViewState["WebFormList_AgentExchangeRateList_CurrentSort"] = sortColumn;
				}

				if (ViewState["sortOrder"] == null) {

					ViewState.Add("sortOrder", sortOrder);
				}
				else {

					ViewState["sortOrder"] = sortOrder;
				}
			}

			repeater_AgentExchangeRateList_SelectDisplay.EnableViewState = true;

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
			this.com_AgencyExchangeRateId.SelectedIndexChanged += new System.EventHandler(this.com_AgencyExchangeRateId_SelectedIndexChanged);
			this.Label_AgentAccountId.Click += new System.EventHandler(this.Label_AgentAccountId_Click);
			this.Label_AgencyExchangeRateId.Click += new System.EventHandler(this.Label_AgencyExchangeRateId_Click);
			this.Label_MarginPercent.Click += new System.EventHandler(this.Label_MarginPercent_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private enum CurrentSortEnum {

			  SortBy_AgentAccountId
			, SortBy_AgencyExchangeRateId
			, SortBy_MarginPercent
		}

		private enum SortOrderEnum {

			Ascending, Descending
		}

		private void com_AgentAccountId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void com_AgencyExchangeRateId_SelectedIndexChanged(object sender, System.EventArgs e) {

			RefreshList();
		}

		private void RefreshList() {

			System.Data.SqlTypes.SqlGuid AgentAccountId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_AgentAccountId.SelectedIndex != 0) {

				AgentAccountId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_AgentAccountId.SelectedItem.Value));
			}

			System.Data.SqlTypes.SqlGuid AgencyExchangeRateId = System.Data.SqlTypes.SqlGuid.Null;
			if (com_AgencyExchangeRateId.SelectedIndex != 0) {

				AgencyExchangeRateId = new System.Data.SqlTypes.SqlGuid(new System.Guid(com_AgencyExchangeRateId.SelectedItem.Value));
			}

			repeater_AgentExchangeRateList_SelectDisplay.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, AgentAccountId, AgencyExchangeRateId);
			try {

				repeater_AgentExchangeRateList_SelectDisplay.RefreshData();
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) {

				if (customException.Parameter.SqlException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgentExchangeRateList' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) {

					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebRepeater_AgentExchangeRateList' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else {

					throw;
				}
			}
			System.Data.DataView dataView = (System.Data.DataView)repeater_AgentExchangeRateList_SelectDisplay.DataSource;

			string SortDirective = String.Empty;
			switch ((CurrentSortEnum)ViewState["WebFormList_AgentExchangeRateList_CurrentSort"]) {

				case CurrentSortEnum.SortBy_AgentAccountId:
					SortDirective = spS_AgentExchangeRateList_SelectDisplay.Resultset1.Fields.Column_AgentAccountId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_AgencyExchangeRateId:
					SortDirective = spS_AgentExchangeRateList_SelectDisplay.Resultset1.Fields.Column_AgencyExchangeRateId_Display.ColumnName;
					break;

				case CurrentSortEnum.SortBy_MarginPercent:
					SortDirective = spS_AgentExchangeRateList.Resultset1.Fields.Column_MarginPercent.ColumnName;
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
			repeater_AgentExchangeRateList_SelectDisplay.DataBind();
		}

		private void Label_AgentAccountId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_AgentAccountId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_AgentAccountId;
			}

			RefreshList();
		}

		private void Label_AgencyExchangeRateId_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_AgencyExchangeRateId) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_AgencyExchangeRateId;
			}

			RefreshList();
		}

		private void Label_MarginPercent_Click(object sender, System.EventArgs e) {

			if ((CurrentSortEnum)ViewState["WebFormList_AgentExchangeRateList_CurrentSort"] == CurrentSortEnum.SortBy_MarginPercent) {

				if ((SortOrderEnum)ViewState["sortOrder"] == SortOrderEnum.Ascending) {

					ViewState["sortOrder"] = SortOrderEnum.Descending;
				}
				else {

					ViewState["sortOrder"] = SortOrderEnum.Ascending;
				}
			}
			else {

				ViewState["WebFormList_AgentExchangeRateList_CurrentSort"] = CurrentSortEnum.SortBy_MarginPercent;
			}

			RefreshList();
		}

	}
}