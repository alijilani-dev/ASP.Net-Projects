﻿/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:54:02 PM
			Generator name: EVERNET\kvsg
			Template last update: 10/13/2003 4:51:40 AM
			Template revision: 56177501

			SQL Server version: 08.00.0859
			Server: localhost
			Database: [mexchange]

	WARNING: This source is provided "AS IS" without warranty of any kind.
	The author disclaims all warranties, either express or implied, including
	the warranties of merchantability and fitness for a particular purpose.
	In no event shall the author or its suppliers be liable for any damages
	whatsoever including direct, indirect, incidental, consequential, loss of
	business profits or special damages, even if the author or its suppliers
	have been advised of the possibility of such damages.

	    More information: http://www.microsoft.com/france/msdn/olymars
	Latest interim build: http://www.olymars.net/latest.zip
	       Author's blog: http://blogs.msdn.com/olymars
*/

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
using Params = Evernet.MoneyExchange.DataClasses.Parameters;
using SPs = Evernet.MoneyExchange.DataClasses.StoredProcedures;

namespace Evernet.MoneyExchange.Web.Forms {

	/// <summary>
	/// Summary description for WebForm_BankList.
	/// </summary>
	public class WebForm_BankList : System.Web.UI.Page {

		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Name;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_BranchName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_BranchName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_BranchName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_InternalCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_InternalCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_InternalCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_ExternalCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_ExternalCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_ExternalCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Address;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Address;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Address;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_ZipCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_ZipCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_ZipCode;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_AccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_AgentMaster com_AccountId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_LocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_LocationList com_LocationId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Button cmdRefresh;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Button cmdDelete;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Panel MainDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Error;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Panel ErrorDisplay;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Button cmdUpdate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.HyperLink ReturnURL;
	
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		public WebForm_BankList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		private string ConnectionString;
		private ActionEnum Action = ActionEnum.None;
		private System.Data.SqlTypes.SqlGuid CurrentID = System.Data.SqlTypes.SqlGuid.Null;

		private enum ActionEnum {

			None, Add, Edit, Delete
		}

		private System.Globalization.CultureInfo CurrentUserCulture;
		private void Page_Load(object sender, System.EventArgs e) {

			string Language = "en-US";
			if (Request.UserLanguages.Length != 0) {

				Language = Request.UserLanguages[0];
			}

			CurrentUserCulture = System.Globalization.CultureInfo.CreateSpecificCulture(Language);
			System.Threading.Thread.CurrentThread.CurrentUICulture = CurrentUserCulture;
			System.Threading.Thread.CurrentThread.CurrentCulture = CurrentUserCulture;

			/*
				Add the following in your web.config file
				<appSettings>
					<add key="mexchange ConnectionString" value="Data Source=localhost; Initial Catalog=mexchange; Integrated Security=SSPI" />
				</appSettings>
			*/
			if (ConfigurationSettings.AppSettings["mexchange ConnectionString"] != null) {

				ConnectionString = ConfigurationSettings.AppSettings["mexchange ConnectionString"];
			}

			else if (Application["ConnectionString"] != null) {

				ConnectionString = Application["ConnectionString"].ToString().Trim();
			}

			else {

				ConnectionString = String.Empty;
			}

			if (!Page.IsPostBack) {

				if (Request.Params["ReturnToUrl"] != null) {

					ReturnURL.NavigateUrl = Request.Params["ReturnToUrl"].ToString();
					if (Request.Params["ReturnToDisplay"] != null) {

						ReturnURL.Text = Request.Params["ReturnToDisplay"].ToString();
					}
					ReturnURL.Visible = true;
				}
			}


			if (Request.Params["Action"] != null) {

				switch(Request.Params["Action"].ToString()) {

					case "Add":
						Action = ActionEnum.Add;
						CurrentID = System.Data.SqlTypes.SqlGuid.Null;
						break;

					case "Edit":
						Action = ActionEnum.Edit;
						object ID = Request.Params["ID"];

						if (ID != null) {

							try {

								CurrentID = new Guid(Request.Params["ID"].ToString());
							}
							catch {

								MainDisplay.Visible = false;
								ErrorDisplay.Visible = true;
								lab_Error.Text = "ERROR: Action=Edit-> ID supplied is not a valid Guid";
								return;
							}
						}
						else {

							MainDisplay.Visible = false;
							ErrorDisplay.Visible = true;
							lab_Error.Text = "ERROR: Action=Edit-> No ID was supplied";
							return;
						}
						break;

					case "Delete":
						Action = ActionEnum.Delete;
						if (Request.Params["ID"] != null) {

							try {

								CurrentID = new Guid(Request.Params["ID"].ToString());
							}
							catch {

								MainDisplay.Visible = false;
								ErrorDisplay.Visible = true;
								lab_Error.Text = "ERROR: Action=Edit-> ID supplied is not a valid Int32";
								return;
							}
							cmdDelete_Click(null, null);
							return;
						}
						else {

							MainDisplay.Visible = false;
							ErrorDisplay.Visible = true;
							lab_Error.Text = "ERROR: Action=Delete-> No ID was supplied";
							return;
						}

					default:
						Action = ActionEnum.None;
						CurrentID = System.Data.SqlTypes.SqlGuid.Null;
						MainDisplay.Visible = false;
						ErrorDisplay.Visible = true;
						lab_Error.Text = "ERROR: Action must be Add, Edit Or Delete";
						return;
				}

				if (!Page.IsPostBack) {

					RefreshAll();
				}
			}

			else {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = "ERROR: No Action was supplied";
			}
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

			this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void RefreshForeignTables() {

			com_AccountId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
			try {

				com_AccountId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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

			com_LocationId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlGuid.Null);
			try {

				com_LocationId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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

		}

		private void UpdateForm() {

			if (Action == ActionEnum.Edit || Action == ActionEnum.None) {

				cmdRefresh.Visible = true;
				cmdDelete.Visible = true;
				cmdUpdate.Visible = true;
				cmdUpdate.Text = "Update";
				RefreshRecord();
			}
			else {

				cmdRefresh.Visible = false;
				cmdDelete.Visible = false;
				cmdUpdate.Visible = true;
				cmdUpdate.Text = "OK";
				EmptyControls();
			}
		}

		private void RefreshAll() {

			RefreshForeignTables();
			UpdateForm();
		}

		private void cmdRefresh_Click(object sender, System.EventArgs e) {

			RefreshAll();
		}

		private void RefreshRecord() {

			Evernet.MoneyExchange.AbstractClasses.Abstract_BankList oAbstract_BankList = new Evernet.MoneyExchange.AbstractClasses.Abstract_BankList(ConnectionString);

			if (!oAbstract_BankList.Refresh(CurrentID)) {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}

			if (!oAbstract_BankList.Col_Name.IsNull) {

				txt_Name.Text = oAbstract_BankList.Col_Name.Value.ToString();
			}
			else {

				txt_Name.Text = String.Empty;
			}

			if (!oAbstract_BankList.Col_BranchName.IsNull) {

				txt_BranchName.Text = oAbstract_BankList.Col_BranchName.Value.ToString();
			}
			else {

				txt_BranchName.Text = String.Empty;
			}

			if (!oAbstract_BankList.Col_InternalCode.IsNull) {

				txt_InternalCode.Text = oAbstract_BankList.Col_InternalCode.Value.ToString();
			}
			else {

				txt_InternalCode.Text = String.Empty;
			}

			if (!oAbstract_BankList.Col_ExternalCode.IsNull) {

				txt_ExternalCode.Text = oAbstract_BankList.Col_ExternalCode.Value.ToString();
			}
			else {

				txt_ExternalCode.Text = String.Empty;
			}

			if (!oAbstract_BankList.Col_Address.IsNull) {

				txt_Address.Text = oAbstract_BankList.Col_Address.Value.ToString();
			}
			else {

				txt_Address.Text = String.Empty;
			}

			if (!oAbstract_BankList.Col_ZipCode.IsNull) {

				txt_ZipCode.Text = oAbstract_BankList.Col_ZipCode.Value.ToString();
			}
			else {

				txt_ZipCode.Text = String.Empty;
			}

			com_AccountId.Items.FindByValue(Convert.ToString(oAbstract_BankList.Col_AccountId)).Selected = true;

			com_LocationId.Items.FindByValue(Convert.ToString(oAbstract_BankList.Col_LocationId)).Selected = true;

		}

		private void EmptyControls() {

			txt_Name.Text = String.Empty;
			txt_BranchName.Text = String.Empty;
			txt_InternalCode.Text = String.Empty;
			txt_ExternalCode.Text = String.Empty;
			txt_Address.Text = String.Empty;
			txt_ZipCode.Text = String.Empty;
			com_AccountId.SelectedIndex = 0;
			com_LocationId.SelectedIndex = 0;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {

			if (ReturnURL.Visible) {

				Response.Redirect(String.Format("WebForm_BankList.aspx?Action=Add&ReturnToUrl={0}&ReturnToDisplay={1}", ReturnURL.NavigateUrl, ReturnURL.Text));
			}
			else {

				Response.Redirect("WebForm_BankList.aspx?Action=Add");
			}
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e) {

			if (!CheckValues()) {
			
				return;
			}

			if (Action == ActionEnum.Edit) {

				Params.spU_BankList Param = null;
				SPs.spU_BankList SP = null;

				Param = new Params.spU_BankList();

				Param.SetUpConnection(ConnectionString);

				Param.Param_Id = CurrentID;

				if (txt_Name.Text.Trim() != String.Empty) {

					Param.Param_Name = new System.Data.SqlTypes.SqlString(txt_Name.Text);
				}

				if (txt_BranchName.Text.Trim() != String.Empty) {

					Param.Param_BranchName = new System.Data.SqlTypes.SqlString(txt_BranchName.Text);
				}

				if (txt_InternalCode.Text.Trim() != String.Empty) {

					Param.Param_InternalCode = new System.Data.SqlTypes.SqlString(txt_InternalCode.Text);
				}

				if (txt_ExternalCode.Text.Trim() != String.Empty) {

					Param.Param_ExternalCode = new System.Data.SqlTypes.SqlString(txt_ExternalCode.Text);
				}

				if (txt_Address.Text.Trim() != String.Empty) {

					Param.Param_Address = new System.Data.SqlTypes.SqlString(txt_Address.Text);
				}

				if (txt_ZipCode.Text.Trim() != String.Empty) {

					Param.Param_ZipCode = new System.Data.SqlTypes.SqlString(txt_ZipCode.Text);
				}

				Param.Param_AccountId = new Guid(com_AccountId.SelectedItem.Value);

				Param.Param_LocationId = new Guid(com_LocationId.SelectedItem.Value);

				SP = new SPs.spU_BankList();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_BankList.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", CurrentID.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_BankList.aspx?Action=Edit&ID={0}", CurrentID.ToString()));
					}
					return;
				}
				else {

					if (Param.SqlException != null) {

						throw Param.SqlException;
					}

					if (Param.OtherException != null) {

						throw Param.OtherException;
					}
				}
			}

			else {

				Params.spI_BankList Param = null;
				SPs.spI_BankList SP = null;

				Param = new Params.spI_BankList();

				Param.SetUpConnection(ConnectionString);

				if (txt_Name.Text.Trim() != String.Empty) {

					Param.Param_Name = new System.Data.SqlTypes.SqlString(txt_Name.Text);
				}

				if (txt_BranchName.Text.Trim() != String.Empty) {

					Param.Param_BranchName = new System.Data.SqlTypes.SqlString(txt_BranchName.Text);
				}

				if (txt_InternalCode.Text.Trim() != String.Empty) {

					Param.Param_InternalCode = new System.Data.SqlTypes.SqlString(txt_InternalCode.Text);
				}

				if (txt_ExternalCode.Text.Trim() != String.Empty) {

					Param.Param_ExternalCode = new System.Data.SqlTypes.SqlString(txt_ExternalCode.Text);
				}

				if (txt_Address.Text.Trim() != String.Empty) {

					Param.Param_Address = new System.Data.SqlTypes.SqlString(txt_Address.Text);
				}

				if (txt_ZipCode.Text.Trim() != String.Empty) {

					Param.Param_ZipCode = new System.Data.SqlTypes.SqlString(txt_ZipCode.Text);
				}

				Param.Param_AccountId = new Guid(com_AccountId.SelectedItem.Value);

				Param.Param_LocationId = new Guid(com_LocationId.SelectedItem.Value);

				SP = new SPs.spI_BankList();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_BankList.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", Param.Param_Id.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_BankList.aspx?Action=Edit&ID={0}", Param.Param_Id.ToString()));
					}
					return;
				}
				else {

					if (Param.SqlException != null) {

						throw Param.SqlException;
					}

					if (Param.OtherException != null) {

						throw Param.OtherException;
					}
				}
			}
		}

		private void cmdDelete_Click(object sender, System.EventArgs e) {

			Params.spD_BankList Param = null;
			SPs.spD_BankList SP = null;

			Param = new Params.spD_BankList();

			Param.SetUpConnection(ConnectionString);

			Param.Param_Id = CurrentID;

			SP = new SPs.spD_BankList();

			if (SP.Execute(ref Param)) {

				Param.Dispose();
				SP.Dispose();

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("Record with ID: {0} was successfully deleted!", CurrentID.ToString());

				return;
			}
			else {

				if (Param.SqlException != null) {

					throw Param.SqlException;
				}

				if (Param.OtherException != null) {

					throw Param.OtherException;
				}
			}
		}

		private bool CheckValues() {

			bool status = true;
			return(status);
		}
	}
}
