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
using Evernet.MoneyExchange.BusinessLogic;
using System.Web.Security;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange {
	public class Login : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Button butLogin;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.TextBox txtLoginName;
		protected System.Web.UI.WebControls.Label lblErrorMessage;
	
		private void Page_Load(object sender, System.EventArgs e) {
//			if(!IsPostBack) {
//				if(!IsApplicationActive()) {
//					pnlLogin.Visible=false;
//					lblStatus.Visible=true;
//				} else {
//					pnlLogin.Visible=true;
//					lblStatus.Visible=false;
//				}
//			}
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
			this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void butLogin_Click(object sender, System.EventArgs e) {
			AuthenticationResult ar = UserManager.AuthenticateUser(txtLoginName.Text,txtPassword.Text);
			string returnUrl = Request.QueryString["ReturnUrl"];

			if(ar.WasAuthenticated) {
				if(ar.UserType=="Admin") {
					Guid userId = new Guid(ar.Message);
					string roles = UserManager.GetUserRoles(userId);
					if(!UserManager.IsInRole(userId,UserRoles.Administrator.ToString())) {
						if(!IsApplicationActive()) {
							lblErrorMessage.Text = "Application not active! Only Administrator login is allowed!";
							return;
						}
					}

					FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
						userId.ToString(),
						DateTime.Now,
						DateTime.Now.AddMinutes(30),
						false,
						roles,
						FormsAuthentication.FormsCookiePath);
					string hash = FormsAuthentication.Encrypt(ticket);
					HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName,
						hash);
					Response.Cookies.Add(cookie);
					if (returnUrl == null || returnUrl=="/Admin/Default.aspx") returnUrl = "/Admin/Home.aspx";
					
				} else if(ar.UserType=="Customer") {
					if(IsApplicationActive()) {
						Guid userId = new Guid(ar.Message);
						FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
							userId.ToString(),
							DateTime.Now,
							DateTime.Now.AddMinutes(30),
							false,
							"Customer",
							FormsAuthentication.FormsCookiePath);
						string hash = FormsAuthentication.Encrypt(ticket);
						HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName,
							hash);
						Response.Cookies.Add(cookie);
						returnUrl = "/Customer/Home.aspx";
					} else {
						lblErrorMessage.Text = "Application not active! Only Administrator login is allowed!";
						return;
					}
				}
				Server.ScriptTimeout = 50;
				Response.Redirect(returnUrl);

			} else {
				lblErrorMessage.Text = ar.Message;
			}
		}

		private bool IsApplicationActive() {
			bool isActive = true;

			DataSet ds = SqlHelper.ExecuteDataset(Evernet.Shared.ConfigHelper.ConStr,
				CommandType.Text,
				"Select Active From GlobalSettings Where Id=1");

			isActive = Convert.ToBoolean(ds.Tables[0].Rows[0]["Active"].ToString());

			return isActive;
		}
	}
}
