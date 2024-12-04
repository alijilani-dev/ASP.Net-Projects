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
using Evernet.Shared;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.Admin {

	public class Home : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Label lblCurrentUser;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.DataGrid dgrdRoleList;
	
		private void Page_Load(object sender, System.EventArgs e) {
//			hlink_News.Attributes.Add("onclick","window.open('SpeedEast.htm', null, 'location=no,width=800,height=600,status=no,resizable=no,scrollbars=yes,toolbar=no,menubar=no');");
			// Put user code to initialize the page here
			if(!IsPostBack) {
				Guid userId = new Guid(Context.User.Identity.Name);
//				string roles = UserManager.GetUserRoles(userId);
//				string[] roleList = roles.Split(new char[]{'|'});
//				dgrdRoleList.DataSource = roleList;
//				dgrdRoleList.DataBind();

				string query = "Select url.Name From UserRoleAssignmentList aral Join UserList ul On ul.Id=aral.UserId Join UserRoleList url On url.Value=aral.[Role] Where ul.Id='"+  User.Identity.Name +"' Order by url.Name";

			
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					query);

				dgrdRoleList.DataSource= ds;
				dgrdRoleList.DataBind();


				Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUser
					= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);

				aoUser.Refresh(userId);

				lblCurrentUser.Text = aoUser.Col_LoginName.Value;
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}