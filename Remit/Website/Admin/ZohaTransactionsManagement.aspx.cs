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
	public class ZohaTransactionsManagement : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.DataGrid dgrdSREmployees;
		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
			/*if(!User.IsInRole(UserRoles.Administrator.ToString())) {
				Response.Redirect("Home.aspx");
			}*/
			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUser
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(Evernet.Shared.ConfigHelper.ConStr);
			aoUser.Refresh(new Guid(Context.User.Identity.Name));
			if(aoUser.Col_IsAgencyEmployee.IsFalse)
				Response.Redirect("Home.aspx");


			if(!IsPostBack) 
			{
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void BindAll() {
			BindEmployeeList();
		}

		private void BindEmployeeList() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select zt.Id as EnvoiceNumber, Substring(zt.TransactionNumber,179,14) as TransactionNumber, td.Id as Id, cl.firstname + ' ' + cl.lastname as Sendername, td.PayInDateTime as PayInDateTime, td.Status as Status From Transactiondetails td join CustomerList cl on td.BeneficeryId = cl.Id join ZohaETtxt zt on td.TransactionNumber = substring(zt.TransactionNumber,179,14) Where td.Status= 'UnPaid' and td.PayOutCurrencyId in (select id from CurrencyList where code in ('Rs.','BTK') ) Order by td.PayInDateTime");

			dgrdSREmployees.DataSource = ds;
			dgrdSREmployees.DataBind();
		}

		private void butCreate_Click(object sender, System.EventArgs e) {
			/*string query = @"Insert Into UserList(Id,LoginName,LoginPassword, TransactionPassword,Email,IsAgencyEmployee,CanBeEdited,Active) 
								Values (newid(),'"+ txtLoginName.Text +"','"+ txtPassword.Text +"','','"+ txtEmailId.Text +"',1,1,1)";

			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			BindEmployeeList();*/
		}

		private void dgrdSREmployees_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e) {
			Guid transId = (Guid) dgrdSREmployees.DataKeys[e.Item.ItemIndex];

			string query = "Delete From transactiondetails Where Id='"+ transId.ToString() +"'";

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

		private void dgrdSREmployees_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e) 
		{
			Guid transId = (Guid) dgrdSREmployees.DataKeys[e.Item.ItemIndex];
			string tranquery = "select transactionnumber From transactiondetails Where Id = '" + transId.ToString() + "'";
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
						CommandType.Text,
						tranquery);
			TextBox txtBeneficeryIdDetails = (TextBox) e.Item.FindControl("txtCollectedBeneficeryIdDetails");
			TextBox txtPayOutDateTime = (TextBox) e.Item.FindControl("txtPayOutDateTime");
			string query = "Update transactiondetails Set Status='Paid', CollectedBeneficeryIdDetails = '" + txtBeneficeryIdDetails.Text + "', PayOutDateTime = '" + txtPayOutDateTime.Text + "' where transactionnumber = '" + ds.Tables[0].Rows[0][0].ToString() + "'";
			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
			query);
			dgrdSREmployees.EditItemIndex=-1;
			BindEmployeeList();
		}
	}
}