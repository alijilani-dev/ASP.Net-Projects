using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.Mobile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.MobileControls;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Microsoft.ApplicationBlocks.Data;

namespace BizRunner
{
	/// <summary>
	/// Summary description for RoleAssignment.
	/// </summary>
	public class RoleAssignment : System.Web.UI.MobileControls.MobilePage
	{
		protected System.Web.UI.MobileControls.Command cmdBacktoRec;
		protected System.Web.UI.MobileControls.Label lblMsg;
		protected System.Web.UI.MobileControls.Label lblHeading;
		protected System.Web.UI.MobileControls.Form frmMessage;
		protected System.Web.UI.MobileControls.Command cmdCancel;
		protected System.Web.UI.MobileControls.Command Command5;
		protected System.Web.UI.MobileControls.Command Command4;
		protected System.Web.UI.MobileControls.Command cmdBack;
		protected System.Web.UI.MobileControls.Command cmdDelete;
		protected System.Web.UI.MobileControls.Command cmdUpdate;
		protected System.Web.UI.MobileControls.Command cmdAdd;
		protected System.Web.UI.MobileControls.Command cmdNext;
		protected System.Web.UI.MobileControls.Command cmdSales;
		protected System.Web.UI.MobileControls.Command cmdRoles;
		protected System.Web.UI.MobileControls.Command cmdPrev;
		protected System.Web.UI.MobileControls.TextBox txtMobile;
		protected System.Web.UI.MobileControls.Label lblMobile;
		protected System.Web.UI.MobileControls.TextBox txtEmail;
		protected System.Web.UI.MobileControls.Label lblEmail;
		protected System.Web.UI.MobileControls.TextBox txtLastName;
		protected System.Web.UI.MobileControls.Label lblLastName;
		protected System.Web.UI.MobileControls.TextBox txtFirstName;
		protected System.Web.UI.MobileControls.Label lblFirstName;
		protected System.Web.UI.MobileControls.TextBox txtPassword;
		protected System.Web.UI.MobileControls.Label lblPassword;
		protected System.Web.UI.MobileControls.TextBox txtLoginName;
		protected System.Web.UI.MobileControls.Label lblLoginName;
		protected System.Web.UI.MobileControls.Form frmUserDetails;
		protected System.Web.UI.MobileControls.Label lblAvailableRoles;
		protected System.Web.UI.MobileControls.Label lblAssignedRoles;
		protected System.Web.UI.MobileControls.SelectionList SelectionList1;
		protected System.Web.UI.MobileControls.Label lblUserName;
		protected System.Web.UI.MobileControls.Form Form1;
		protected System.Web.UI.MobileControls.List lstAvailableRoles;
		protected System.Web.UI.MobileControls.List lstAssignedRoles;
		protected System.Web.UI.MobileControls.Command cmdAssign;
		protected System.Web.UI.MobileControls.Command cmdRemove;
		string strBizRunConn = (string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("BizRun.ConnectionString").GetValue(0);
		DataSet ds = null;
		DataSet dsUserRoles = null;
		int n_CurrentRec = 0;

		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				Session["CurrentResIndex"] = 0;
				Session["CurrentRes"] = 0;
				ds = GetAllRoles();
				dsUserRoles = GetRolesData();
				lstAssignedRoles.DataSource = dsUserRoles;
				lstAssignedRoles.DataBind();
				lstAvailableRoles.DataSource = ds;
				lstAvailableRoles.DataBind();
			}
			else
			{
				ds = GetRolesData();
				//lblTotalUsers.Text = GetRolesCount().ToString();
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
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
		private void InitializeComponent()
		{    
			this.cmdAssign.Click += new System.EventHandler(this.cmdAssign_Click);
			this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion	
		private int GetRolesCount()
		{
			//int nTotalCost = ds.Tables[0].Rows.Count;
			return ds.Tables[0].Rows.Count;
		}

		private DataSet GetAllRoles()
		{
			string strQuery = "select ul.LoginName, url.Name, url.Value from UserList ul join UserRoleAssignmentList ural on ural.UserId = ul.Id join UserRoleList url on ural.RoleId = url.Id order by url.Name";
			ds = SqlHelper.ExecuteDataset(strBizRunConn,
				CommandType.Text,
				strQuery);
			return ds;
		}

		private DataSet GetRolesData()
		{
			string strQuery = "select ul.LoginName, url.Name, url.Value from UserList ul join UserRoleAssignmentList ural on ural.UserId = ul.Id join UserRoleList url on ural.RoleId = url.Id where ul.Id = 2 order by url.Name";
			dsUserRoles = SqlHelper.ExecuteDataset(strBizRunConn,
				CommandType.Text,
				strQuery);
			return dsUserRoles;
		}

		private void lstResources_ItemCommand(object sender, System.Web.UI.MobileControls.ListCommandEventArgs e)
		{
			/*
			// Get the DataValueField for the Item.
			n_CurrentRec = int.Parse(e.ListItem.Value);
			//Session["CurrentRec"] = n_CurrentRec;
			Session["CurrentRes"] = e.ListItem.Index.ToString();
			Session["CurrentResIndex"] = e.ListItem.Index.ToString();

			// Fill Cutomer Information into the form and display;
			if (!FillResourcesInfo(n_CurrentRec))
			{
				lblMsg.Text = "No valid record exists for selected Service.";
				ActiveForm = frmMessage;
			}*/
		}

		private bool FillResourcesInfo(int nRec)
		{	
			/*
			// Use the DataValueField to pull data from DB.
			string strQuery = "select Id, LoginName, Password, FirstName, LastName, Email, Mobile, IsEmployee, Active from UserList where Id = " + nRec.ToString() + " order by Id";
			DataSet dsUserInfo = SqlHelper.ExecuteDataset(strBizRunConn,
				CommandType.Text,
				strQuery);
			DataRow drUserInfo = null;

			try
			{
				drUserInfo = dsUserInfo.Tables[0].Rows[0];//ds.Tables[0].Rows[nRec];
			}
			catch{}
			
			if (drUserInfo == null)
				return false;

			// Fill the form with respective values.
			txtLoginName.Text = drUserInfo["LoginName"].ToString();
			txtPassword.Text = drUserInfo["Password"].ToString();
			txtFirstName.Text = drUserInfo["FirstName"].ToString();
			txtLastName.Text = drUserInfo["LastName"].ToString();
			txtEmail.Text = drUserInfo["Email"].ToString();
			txtMobile.Text = drUserInfo["Mobile"].ToString();
			//txtName.Text = drResourceInfo["Name"].ToString();
			//txtUserName.Text = drResourceInfo["Name"].ToString();
			//txtCost.Text = drResourceInfo["Cost"].ToString();
			//txtDescription.Text = drResourceInfo["Description"].ToString();
			ActiveForm = frmUserDetails;*/
			return true;
		}

		#region Manipulation Commands.
		private void cmdAdd_Click(object sender, System.EventArgs e)
		{
			/*
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				CommandType.Text,
				@"INSERT INTO UserList(LoginName, Password, FirstName, LastName, Email, Mobile, IsEmployee, Active) Values ('" +
				txtLoginName.Text + "','" + txtPassword.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtEmail.Text + "','" + txtMobile.Text + "',1,1)");
			if (nResult > 0)
			{
				lblMsg.Text = "Record successfully added.";
				ActiveForm = frmMessage;
			}
			else
			{
				lblMsg.Text = "An error occurred while executing the command.";
				ActiveForm = frmMessage;
			}
			*/
		}

		private void cmdUpdate_Click(object sender, System.EventArgs e)
		{
			/*
			int nCurrentRec = int.Parse(Session["CurrentResIndex"].ToString());
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				CommandType.Text,
				@"Update UserList Set " + 
				"LoginName		= '" + txtLoginName.Text			+ "' ," +
				"Password		= '" + txtPassword.Text			+ "' ," +
				"FirstName		= '" + txtFirstName.Text		+ "' ," +
				"LastName		= '" + txtLastName.Text			+ "' ," +
				"Email			= '" + txtEmail.Text			+ "' ," +
				"Mobile			= '" + txtMobile.Text			+ "' ," +
				"IsEmployee		= 1 ," +
				"Active		= 1 where Id = " + ds.Tables[0].Rows[nCurrentRec]["Id"].ToString() );


			if (nResult > 0)
			{
				lblMsg.Text = "Record successfully added.";
				ActiveForm = frmMessage;
			}
			else
			{
				lblMsg.Text = "An error occurred while executing the command.";
				ActiveForm = frmMessage;
			}
			*/
		}

		private void cmdDelete_Click(object sender, System.EventArgs e)
		{
			/*
			int nCurrentRec = int.Parse(Session["CurrentResIndex"].ToString());
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				CommandType.Text,
				@"Delete from UserList where Id = " + ds.Tables[0].Rows[nCurrentRec]["Id"].ToString() );

			if (nResult > 0)
			{
				lblMsg.Text = "Record successfully deleted.";
				ActiveForm = frmMessage;
			}
			else
			{
				lblMsg.Text = "An error occurred while executing the command.";
				ActiveForm = frmMessage;
			}*/
		}

		#endregion Manipulation Commands.
		#region Navigation Commands.
		private void cmdPrev_Click(object sender, System.EventArgs e)
		{
			/*
			int nIndex = int.Parse(Session["CurrentResIndex"].ToString());
			int n_CurrentRec = 0;
			if (nIndex>0)
			{
				nIndex--;
				n_CurrentRec = int.Parse(ds.Tables[0].Rows[nIndex]["Id"].ToString());
				FillResourcesInfo(n_CurrentRec);
				Session["CurrentResIndex"] = nIndex.ToString();
			}
			else
			{
				lblMsg.Text = "No valid record exists for selected resource.";
				ActiveForm = frmMessage;
			}*/		
		}

		private void cmdNext_Click(object sender, System.EventArgs e)
		{
			/*
			int nIndex = int.Parse(Session["CurrentResIndex"].ToString());
			int n_CurrentRec = 0;
			if (nIndex<ds.Tables[0].Rows.Count-1)
			{
				nIndex++;
				n_CurrentRec = int.Parse(ds.Tables[0].Rows[nIndex]["Id"].ToString());
				FillResourcesInfo(n_CurrentRec);
				Session["CurrentResIndex"] = nIndex.ToString();
			}
			else
			{
				lblMsg.Text = "No valid record exists for selected resource.";
				ActiveForm = frmMessage;
			}*/		
		}

		private void cmdAddNew_Click(object sender, System.EventArgs e)
		{
			//ActiveForm = frmUserDetails;
		}

		private void cmdBacktoRec_Click(object sender, System.EventArgs e)
		{
			//ActiveForm = frmUserDetails;
		}

		private void cmdBack_Click(object sender, System.EventArgs e)
		{
			//this.RedirectToMobilePage("securityview.aspx");
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			//this.RedirectToMobilePage("securityview.aspx");
			//ActiveForm = frmSecurityView;
		}
		#endregion Navigation Commands.
		private void cmdAssign_Click(object sender, System.EventArgs e)
		{
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				CommandType.Text,
				@"INSERT INTO UserRoleAssignmentList(LoginName, Password, FirstName, LastName, Email, Mobile, IsEmployee, Active) Values ('" +
				txtLoginName.Text + "','" + txtPassword.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtEmail.Text + "','" + txtMobile.Text + "',1,1)");
			if (nResult > 0)
			{
				lblMsg.Text = "Record successfully added.";
				ActiveForm = frmMessage;
			}
			else
			{
				lblMsg.Text = "An error occurred while executing the command.";
				ActiveForm = frmMessage;
			}
		}

		private void cmdRemove_Click(object sender, System.EventArgs e)
		{
			int nCurrentRec = int.Parse(Session["CurrentResIndex"].ToString());
			int nResult = SqlHelper.ExecuteNonQuery(strBizRunConn,
				CommandType.Text,
				@"Delete from UserList where Id = " + ds.Tables[0].Rows[nCurrentRec]["Id"].ToString() );

			if (nResult > 0)
			{
				lblMsg.Text = "Record successfully deleted.";
				ActiveForm = frmMessage;
			}
			else
			{
				lblMsg.Text = "An error occurred while executing the command.";
				ActiveForm = frmMessage;
			}
		}
	}
}
