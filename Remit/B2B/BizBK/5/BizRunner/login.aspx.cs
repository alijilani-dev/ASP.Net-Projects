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
	/// Summary description for MobileWebForm1.
	/// </summary>
	public class MobileWebForm1 : System.Web.UI.MobileControls.MobilePage
	{
		#region Declarations.
		protected System.Web.UI.MobileControls.Label lblPswd;
		protected System.Web.UI.MobileControls.TextBox txtLogin;
		protected System.Web.UI.MobileControls.TextBox txtPswd;
		protected System.Web.UI.MobileControls.Command cmdSignIn;
		protected System.Web.UI.MobileControls.Command cmdReset;
		protected System.Web.UI.MobileControls.Label lblLogin;
		protected System.Web.UI.MobileControls.Form frmLogin;
		protected System.Web.UI.MobileControls.Link lnkForgotPswd;
		protected System.Web.UI.MobileControls.Command cmdBacktoRec;
		protected System.Web.UI.MobileControls.Label lblMsg;
		protected System.Web.UI.MobileControls.Label lblHeading;
		protected System.Web.UI.MobileControls.Form frmMessage;
		protected System.Web.UI.MobileControls.Label lblMessage;
		string strBizRunConn = (string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("BizRun.ConnectionString").GetValue(0);
		#endregion Declarations.
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
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
			this.cmdSignIn.Click += new System.EventHandler(this.cmdSignIn_Click);
			this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
			this.cmdBacktoRec.Click += new System.EventHandler(this.cmdBacktoRec_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void cmdSignIn_Click(object sender, System.EventArgs e)
		{
			SqlConnection sqlConn = new SqlConnection(strBizRunConn);
			String strAuthQry = @"Select * from UserList where LoginName = '" + txtLogin.Text + "' and Password = '" + txtPswd.Text + "'";
			DataSet ds_Authentication;

			try
			{
				ds_Authentication = SqlHelper.ExecuteDataset(sqlConn,
				CommandType.Text,
				strAuthQry);
			}
			catch(Exception ex){throw ex;}
			finally{sqlConn.Close();}
			if(ds_Authentication.Tables[0].Rows.Count>0)
			{
				lblMsg.Text = "Logged In..";
				Session["UserId"] = ds_Authentication.Tables[0].Rows[0]["Id"].ToString();
				this.RedirectToMobilePage("controlpanel.aspx");
			}
			else
				lblMsg.Text = "Invalid Password..";
				ActiveForm = frmMessage;
		}

		private void cmdReset_Click(object sender, System.EventArgs e)
		{
			txtLogin.Text = String.Empty;
			txtPswd.Text = String.Empty;
			ActiveForm = frmLogin;
		}

		private void cmdBacktoRec_Click(object sender, System.EventArgs e)
		{
			ActiveForm = frmLogin;
		}
	}
}