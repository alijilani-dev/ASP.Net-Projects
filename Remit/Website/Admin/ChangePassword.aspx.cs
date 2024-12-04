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
using Evernet.Shared;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.Admin {
	/// <summary>
	/// Summary description for ChangePassword.
	/// </summary>
	public class ChangePassword : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.Label lblUserLoginName;
		protected System.Web.UI.WebControls.TextBox txtPassword2;
		protected System.Web.UI.WebControls.Button butChange;
		protected System.Web.UI.WebControls.CheckBox cbxChangeLoginPassword;
		protected System.Web.UI.WebControls.CheckBox cbxChangeTransactionPassword;
		protected System.Web.UI.WebControls.TextBox txtPassword3;
		protected System.Web.UI.WebControls.TextBox txtPassword4;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvTransactionPassword;
		protected System.Web.UI.WebControls.CompareValidator cvLoginPassword;
		protected System.Web.UI.WebControls.CompareValidator cvTransactionPassword;
		protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvLoginPassword;
		protected System.Web.UI.WebControls.TextBox txtPassword1;
	
		private void Page_Load(object sender, System.EventArgs e) {
			if(!IsPostBack) {
				Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUser
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);
				aoUser.Refresh(new Guid(User.Identity.Name));

				lblUserLoginName.Text = aoUser.Col_LoginName.Value;
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
			this.butChange.Click += new System.EventHandler(this.butChange_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void butChange_Click(object sender, System.EventArgs e) {
			lblMessage.Text = "";

			if(cbxChangeLoginPassword.Checked) {
				rfvLoginPassword.Enabled=true;
				cvLoginPassword.Enabled=true;
				Page.Validate();

				if(Page.IsValid) {
					SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
						CommandType.Text,
						"Update UserList Set LoginPassword='"+ txtPassword1.Text +"' Where Id='"+ User.Identity.Name +"'");
					lblMessage.Text ="Login Password changed successfully!";
				} else {
					Page.Validate();
				}
			}


			if(cbxChangeTransactionPassword.Checked) {
				rfvTransactionPassword.Enabled = true;
				cvTransactionPassword.Enabled = true;
				Page.Validate();

				if(Page.IsValid) {
					SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
						CommandType.Text,
						"Update UserList Set TransactionPassword='"+ txtPassword3.Text +"' Where Id='"+ User.Identity.Name +"'");
					lblMessage.Text +="<br>Transaction Password changed successfully!";
				} else {
					Page.Validate();
				}
			}
			
		}
	}
}