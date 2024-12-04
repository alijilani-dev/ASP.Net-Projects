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
using Microsoft.ApplicationBlocks.Data;
using Evernet.MoneyExchange.BusinessLogic;
using System.Data.SqlClient;
using Evernet.Shared;

namespace Evernet.MoneyExchange.Admin {
	/// <summary>
	/// Summary description for SRUserManagement.
	/// </summary>
	public class SRUserManagement : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.TextBox txtLoginName;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.TextBox txtEmailId;
		protected System.Web.UI.WebControls.Button butCreate;
		protected System.Web.UI.WebControls.DataGrid dgrdSREmployees;
	
		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
			if(!User.IsInRole(UserRoles.Administrator.ToString())) {
				Response.Redirect("Home.aspx");
			}
			if(!IsPostBack) {
				BindAll();
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e) {
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {    
			this.dgrdSREmployees.CancelCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgrdSREmployees_CancelCommand);
			this.dgrdSREmployees.EditCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgrdSREmployees_EditCommand);
			this.dgrdSREmployees.UpdateCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgrdSREmployees_UpdateCommand);
			this.dgrdSREmployees.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgrdSREmployees_DeleteCommand);
			this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion


		private void BindAll() {
			BindEmployeeList();
		}


		private void BindEmployeeList() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From UserList Where IsAgencyEmployee=1 Order by LoginName");

			dgrdSREmployees.DataSource = ds;
			dgrdSREmployees.DataBind();
		}

		private void butCreate_Click(object sender, System.EventArgs e) {
			string query = @"Insert Into UserList(Id,LoginName,LoginPassword, TransactionPassword,Email,IsAgencyEmployee,CanBeEdited,Active) 
								Values (newid(),'"+ txtLoginName.Text +"','"+ txtPassword.Text +"','','"+ txtEmailId.Text +"',1,1,1)";

			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			BindEmployeeList();
		}

		private void dgrdSREmployees_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e) {
			Guid userId = (Guid) dgrdSREmployees.DataKeys[e.Item.ItemIndex];

			string query = "Delete From UserList Where Id='"+ userId.ToString() +"'";

			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			BindEmployeeList();
		}

		private void dgrdSREmployees_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e) {
			dgrdSREmployees.EditItemIndex = e.Item.ItemIndex;
			BindEmployeeList();
		}

		private void dgrdSREmployees_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e) {
			dgrdSREmployees.EditItemIndex=-1;
			BindEmployeeList();
		}

		private void dgrdSREmployees_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e) {
			Guid userId = (Guid) dgrdSREmployees.DataKeys[e.Item.ItemIndex];

			TextBox txtCurrentPassword = (TextBox) e.Item.FindControl("txtLoginPassword");
			TextBox txtCurrenctLoginName = (TextBox)e.Item.FindControl("txtEditLoginName");
			TextBox txtCurrentEmail = (TextBox) e.Item.FindControl("txtEditEmail");;

			string query = "Update UserList Set LoginName='"+ txtCurrenctLoginName.Text +"', Email='"+ txtCurrentEmail.Text +"' ";
			

			if(txtCurrentPassword.Text!=String.Empty) {
				query += ", LoginPassword='"+ txtCurrentPassword.Text +"' ";
			}

			query +=" Where Id='"+ userId.ToString() +"'";


			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
			query);


			dgrdSREmployees.EditItemIndex=-1;

			BindEmployeeList();
		}
	}
}
