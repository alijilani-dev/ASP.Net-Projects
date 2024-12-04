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
using Evernet.Shared;

namespace Evernet.MoneyExchange.Admin {
	public class SRUserRoleManagement : System.Web.UI.Page {
		protected System.Web.UI.WebControls.DataGrid dgrdSRUserList;
		protected System.Web.UI.WebControls.Panel pnlRoleAssigner;
		protected System.Web.UI.WebControls.Label lblMessage;
		private ActionEnum Action=ActionEnum.Add;
		protected System.Web.UI.WebControls.ListBox lbxAvailableRoles;
		protected System.Web.UI.WebControls.Button butRemove;
		protected System.Web.UI.WebControls.Button butAdd;
		protected System.Web.UI.WebControls.ListBox lbxAssignedRoles;
		protected System.Web.UI.WebControls.Label lblSeletedUser;
		private Guid userId = Guid.Empty;
	
		private void Page_Load(object sender, System.EventArgs e) {

			if(Request["Mode"]!=null) {
				Action = (ActionEnum) Enum.Parse(typeof(ActionEnum),Request["Mode"],true);
			}

			if(Action==ActionEnum.Edit) {

				if(Request["Id"]==null)
					return;

				pnlRoleAssigner.Visible=true;

				userId = new Guid(Request["Id"]);
			}

			if(!IsPostBack) {
				BindAll();

				if(Action==ActionEnum.Edit) {
					lblSeletedUser.Text = UserManager.GetLoginNameForUserId(userId);
					BindRolesForUser(userId);
				}
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
			this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
			this.butRemove.Click += new System.EventHandler(this.butRemove_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BindAll() {
			BindSRUserList();

			if(Action==ActionEnum.Edit) {
				BindAvailableRoles();
			}
		}


		private void BindSRUserList() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From UserList Where IsAgencyEmployee=1 Order by LoginName");

			dgrdSRUserList.DataSource = ds;
			dgrdSRUserList.DataBind();
		}


		private void BindRolesForUser(Guid userId) {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select ural.Id,url.Name,url.Value From UserRoleAssignmentList ural Join UserRoleList url On url.Value=ural.Role Where UserId='"+ userId.ToString() +"' Order by Name");

			lbxAssignedRoles.DataSource=ds;
			lbxAssignedRoles.DataBind();
		}

		private void BindAvailableRoles() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From UserRoleList Where (Type='Agency' Or Type='Both') And Visible=1 Order by Name");

			lbxAvailableRoles.DataSource=ds;
			lbxAvailableRoles.DataBind();
		}

		private void butAdd_Click(object sender, System.EventArgs e) {
			if(userId != Guid.Empty) {
				ListItem li = lbxAvailableRoles.SelectedItem;

				if(li!=null) {
					SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
						CommandType.Text,
						"Exec sp_addRoleToAgencyEmployee @userId='"+ userId.ToString() +"', @role='"+ li.Value +"'");

					BindRolesForUser(userId);
				}
			}
		}

		private void butRemove_Click(object sender, System.EventArgs e) {
			if(userId!=Guid.Empty) {
				ListItem li = lbxAssignedRoles.SelectedItem;

				if(li!=null) {
					SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
						CommandType.Text,
						"Exec sp_removeRoleToAgencyEmployee @userId='"+ userId.ToString() +"',@role='"+ li.Value +"'");

					BindRolesForUser(userId);
				}
			}
		}

		private enum ActionEnum {
			Add,Edit
		}

	}
}