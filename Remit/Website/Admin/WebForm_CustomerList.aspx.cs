/*
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
	/// Summary description for WebForm_CustomerList.
	/// </summary>
	public class WebForm_CustomerList : System.Web.UI.Page {

		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_LoginName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_LoginName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_LoginName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Password;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Password;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Password;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_FirstName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_FirstName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_FirstName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_LastName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_LastName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_LastName;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_CardId;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CustomerCardList com_CardId;
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
		protected System.Web.UI.WebControls.Label lab_Telephone;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Telephone;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Telephone;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Fax;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Fax;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Fax;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Mobile;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Mobile;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Mobile;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Email;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_Email;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_Email;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_IDType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_IDType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_IDType;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_IDDetails;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_IDDetails;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_IDDetails;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_IDExpirationDate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.TextBox txt_IDExpirationDate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label labError_IDExpirationDate;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.Label lab_Nationality;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_MasterCountryList com_Nationality;
		/// <summary>
		/// [To be supplied.]
		/// </summary>
		protected System.Web.UI.WebControls.CheckBox chk_Active;
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
		public WebForm_CustomerList() {

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

			labError_IDExpirationDate.Visible = false;

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

			com_CardId.Initialize(ConnectionString, System.Data.SqlTypes.SqlGuid.Null, System.Data.SqlTypes.SqlString.Null);
			try {

				com_CardId.RefreshData(System.Data.SqlTypes.SqlGuid.Null);
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
			com_CardId.Items.Insert(0, "[No value set]");

			com_Nationality.Initialize(ConnectionString);
			try {

				com_Nationality.RefreshData(System.Data.SqlTypes.SqlString.Null);
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
			com_Nationality.Items.Insert(0, "[No value set]");

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

			Evernet.MoneyExchange.AbstractClasses.Abstract_CustomerList oAbstract_CustomerList = new Evernet.MoneyExchange.AbstractClasses.Abstract_CustomerList(ConnectionString);

			if (!oAbstract_CustomerList.Refresh(CurrentID)) {

				MainDisplay.Visible = false;
				ErrorDisplay.Visible = true;
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}

			if (!oAbstract_CustomerList.Col_LoginName.IsNull) {

				txt_LoginName.Text = oAbstract_CustomerList.Col_LoginName.Value.ToString();
			}
			else {

				txt_LoginName.Text = String.Empty;
			}

			if (!oAbstract_CustomerList.Col_Password.IsNull) {

				txt_Password.Text = oAbstract_CustomerList.Col_Password.Value.ToString();
			}
			else {

				txt_Password.Text = String.Empty;
			}

			if (!oAbstract_CustomerList.Col_FirstName.IsNull) {

				txt_FirstName.Text = oAbstract_CustomerList.Col_FirstName.Value.ToString();
			}
			else {

				txt_FirstName.Text = String.Empty;
			}

			if (!oAbstract_CustomerList.Col_LastName.IsNull) {

				txt_LastName.Text = oAbstract_CustomerList.Col_LastName.Value.ToString();
			}
			else {

				txt_LastName.Text = String.Empty;
			}

			if (!oAbstract_CustomerList.Col_CardId.IsNull) {

				com_CardId.Items.FindByValue(Convert.ToString(oAbstract_CustomerList.Col_CardId)).Selected = true;
			}
			else {

				com_CardId.SelectedIndex = 0;
			}

			if (!oAbstract_CustomerList.Col_Address.IsNull) {

				txt_Address.Text = oAbstract_CustomerList.Col_Address.Value.ToString();
			}
			else {

				txt_Address.Text = String.Empty;
			}

			if (!oAbstract_CustomerList.Col_Telephone.IsNull) {

				txt_Telephone.Text = oAbstract_CustomerList.Col_Telephone.Value.ToString();
			}
			else {

				txt_Telephone.Text = String.Empty;
			}

			if (!oAbstract_CustomerList.Col_Fax.IsNull) {

				txt_Fax.Text = oAbstract_CustomerList.Col_Fax.Value.ToString();
			}
			else {

				txt_Fax.Text = String.Empty;
			}

			if (!oAbstract_CustomerList.Col_Mobile.IsNull) {

				txt_Mobile.Text = oAbstract_CustomerList.Col_Mobile.Value.ToString();
			}
			else {

				txt_Mobile.Text = String.Empty;
			}

			if (!oAbstract_CustomerList.Col_Email.IsNull) {

				txt_Email.Text = oAbstract_CustomerList.Col_Email.Value.ToString();
			}
			else {

				txt_Email.Text = String.Empty;
			}

			if (!oAbstract_CustomerList.Col_IDType.IsNull) {

				txt_IDType.Text = oAbstract_CustomerList.Col_IDType.Value.ToString();
			}
			else {

				txt_IDType.Text = String.Empty;
			}

			if (!oAbstract_CustomerList.Col_IDDetails.IsNull) {

				txt_IDDetails.Text = oAbstract_CustomerList.Col_IDDetails.Value.ToString();
			}
			else {

				txt_IDDetails.Text = String.Empty;
			}

			if (!oAbstract_CustomerList.Col_IDExpirationDate.IsNull) {

				txt_IDExpirationDate.Text = oAbstract_CustomerList.Col_IDExpirationDate.Value.ToString();
			}
			else {

				txt_IDExpirationDate.Text = String.Empty;
			}

			if (!oAbstract_CustomerList.Col_Nationality.IsNull) {

				com_Nationality.Items.FindByValue(Convert.ToString(oAbstract_CustomerList.Col_Nationality)).Selected = true;
			}
			else {

				com_Nationality.SelectedIndex = 0;
			}

			if (!oAbstract_CustomerList.Col_Active.IsNull) {

				chk_Active.Checked = oAbstract_CustomerList.Col_Active.Value;
			}
			else {

				chk_Active.Checked = false;
			}

		}

		private void EmptyControls() {

			txt_LoginName.Text = String.Empty;
			txt_Password.Text = String.Empty;
			txt_FirstName.Text = String.Empty;
			txt_LastName.Text = String.Empty;
			com_CardId.SelectedIndex = 0;
			txt_Address.Text = String.Empty;
			txt_Telephone.Text = String.Empty;
			txt_Fax.Text = String.Empty;
			txt_Mobile.Text = String.Empty;
			txt_Email.Text = String.Empty;
			txt_IDType.Text = String.Empty;
			txt_IDDetails.Text = String.Empty;
			txt_IDExpirationDate.Text = String.Empty;
			com_Nationality.SelectedIndex = 0;
			chk_Active.Checked = false;
		}

		private void cmdAdd_Click(object sender, System.EventArgs e) {

			if (ReturnURL.Visible) {

				Response.Redirect(String.Format("WebForm_CustomerList.aspx?Action=Add&ReturnToUrl={0}&ReturnToDisplay={1}", ReturnURL.NavigateUrl, ReturnURL.Text));
			}
			else {

				Response.Redirect("WebForm_CustomerList.aspx?Action=Add");
			}
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e) {

			if (!CheckValues()) {
			
				return;
			}

			if (Action == ActionEnum.Edit) {

				Params.spU_CustomerList Param = null;
				SPs.spU_CustomerList SP = null;

				Param = new Params.spU_CustomerList();

				Param.SetUpConnection(ConnectionString);

				Param.Param_Id = CurrentID;

				if (txt_LoginName.Text.Trim() != String.Empty) {

					Param.Param_LoginName = new System.Data.SqlTypes.SqlString(txt_LoginName.Text);
				}

				if (txt_Password.Text.Trim() != String.Empty) {

					Param.Param_Password = new System.Data.SqlTypes.SqlString(txt_Password.Text);
				}

				if (txt_FirstName.Text.Trim() != String.Empty) {

					Param.Param_FirstName = new System.Data.SqlTypes.SqlString(txt_FirstName.Text);
				}

				if (txt_LastName.Text.Trim() != String.Empty) {

					Param.Param_LastName = new System.Data.SqlTypes.SqlString(txt_LastName.Text);
				}

				if (com_CardId.SelectedIndex != 0) {

					Param.Param_CardId = new Guid(com_CardId.SelectedItem.Value);
				}

				if (txt_Address.Text.Trim() != String.Empty) {

					Param.Param_Address = new System.Data.SqlTypes.SqlString(txt_Address.Text);
				}

				if (txt_Telephone.Text.Trim() != String.Empty) {

					Param.Param_Telephone = new System.Data.SqlTypes.SqlString(txt_Telephone.Text);
				}

				if (txt_Fax.Text.Trim() != String.Empty) {

					Param.Param_Fax = new System.Data.SqlTypes.SqlString(txt_Fax.Text);
				}

				if (txt_Mobile.Text.Trim() != String.Empty) {

					Param.Param_Mobile = new System.Data.SqlTypes.SqlString(txt_Mobile.Text);
				}

				if (txt_Email.Text.Trim() != String.Empty) {

					Param.Param_Email = new System.Data.SqlTypes.SqlString(txt_Email.Text);
				}

				if (txt_IDType.Text.Trim() != String.Empty) {

					Param.Param_IDType = new System.Data.SqlTypes.SqlString(txt_IDType.Text);
				}

				if (txt_IDDetails.Text.Trim() != String.Empty) {

					Param.Param_IDDetails = new System.Data.SqlTypes.SqlString(txt_IDDetails.Text);
				}

				if (txt_IDExpirationDate.Text.Trim() != String.Empty) {

					Param.Param_IDExpirationDate = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_IDExpirationDate.Text));
				}

				if (com_Nationality.SelectedIndex != 0) {

					Param.Param_Nationality = Convert.ToString(com_Nationality.SelectedItem.Value);
				}

				Param.Param_Active = new System.Data.SqlTypes.SqlBoolean(chk_Active.Checked);
				SP = new SPs.spU_CustomerList();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_CustomerList.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", CurrentID.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_CustomerList.aspx?Action=Edit&ID={0}", CurrentID.ToString()));
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

				Params.spI_CustomerList Param = null;
				SPs.spI_CustomerList SP = null;

				Param = new Params.spI_CustomerList();

				Param.SetUpConnection(ConnectionString);

				if (txt_LoginName.Text.Trim() != String.Empty) {

					Param.Param_LoginName = new System.Data.SqlTypes.SqlString(txt_LoginName.Text);
				}

				if (txt_Password.Text.Trim() != String.Empty) {

					Param.Param_Password = new System.Data.SqlTypes.SqlString(txt_Password.Text);
				}

				if (txt_FirstName.Text.Trim() != String.Empty) {

					Param.Param_FirstName = new System.Data.SqlTypes.SqlString(txt_FirstName.Text);
				}

				if (txt_LastName.Text.Trim() != String.Empty) {

					Param.Param_LastName = new System.Data.SqlTypes.SqlString(txt_LastName.Text);
				}

				if (com_CardId.SelectedIndex != 0) {

					Param.Param_CardId = new Guid(com_CardId.SelectedItem.Value);
				}

				if (txt_Address.Text.Trim() != String.Empty) {

					Param.Param_Address = new System.Data.SqlTypes.SqlString(txt_Address.Text);
				}

				if (txt_Telephone.Text.Trim() != String.Empty) {

					Param.Param_Telephone = new System.Data.SqlTypes.SqlString(txt_Telephone.Text);
				}

				if (txt_Fax.Text.Trim() != String.Empty) {

					Param.Param_Fax = new System.Data.SqlTypes.SqlString(txt_Fax.Text);
				}

				if (txt_Mobile.Text.Trim() != String.Empty) {

					Param.Param_Mobile = new System.Data.SqlTypes.SqlString(txt_Mobile.Text);
				}

				if (txt_Email.Text.Trim() != String.Empty) {

					Param.Param_Email = new System.Data.SqlTypes.SqlString(txt_Email.Text);
				}

				if (txt_IDType.Text.Trim() != String.Empty) {

					Param.Param_IDType = new System.Data.SqlTypes.SqlString(txt_IDType.Text);
				}

				if (txt_IDDetails.Text.Trim() != String.Empty) {

					Param.Param_IDDetails = new System.Data.SqlTypes.SqlString(txt_IDDetails.Text);
				}

				if (txt_IDExpirationDate.Text.Trim() != String.Empty) {

					Param.Param_IDExpirationDate = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_IDExpirationDate.Text));
				}

				if (com_Nationality.SelectedIndex != 0) {

					Param.Param_Nationality = Convert.ToString(com_Nationality.SelectedItem.Value);
				}

				Param.Param_Active = new System.Data.SqlTypes.SqlBoolean(chk_Active.Checked);
				SP = new SPs.spI_CustomerList();

				if (SP.Execute(ref Param)) {

					if (ReturnURL.Visible) {

						Response.Redirect(String.Format("WebForm_CustomerList.aspx?Action=Edit&ID={0}&ReturnToUrl={1}&ReturnToDisplay={2}", Param.Param_Id.ToString(), ReturnURL.NavigateUrl, ReturnURL.Text));
					}
					else {

						Response.Redirect(String.Format("WebForm_CustomerList.aspx?Action=Edit&ID={0}", Param.Param_Id.ToString()));
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

			Params.spD_CustomerList Param = null;
			SPs.spD_CustomerList SP = null;

			Param = new Params.spD_CustomerList();

			Param.SetUpConnection(ConnectionString);

			Param.Param_Id = CurrentID;

			SP = new SPs.spD_CustomerList();

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
			try {

				System.Data.SqlTypes.SqlDateTime value = new System.Data.SqlTypes.SqlDateTime(System.Convert.ToDateTime(txt_IDExpirationDate.Text));
			}

			catch {

				labError_IDExpirationDate.Text = "INVALID";
				labError_IDExpirationDate.Visible = true;
				status = false;
			}

			return(status);
		}
	}
}
