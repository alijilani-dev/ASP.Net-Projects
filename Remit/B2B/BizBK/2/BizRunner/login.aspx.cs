using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
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
		protected System.Web.UI.MobileControls.Label lblMessage;
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void cmdSignIn_Click(object sender, System.EventArgs e)
		{
			/*String strCon = ConfigurationSettings.AppSettings["BizRun.ConnectionString"].ToString();
			SqlConnection sqlConn = new SqlConnection(strCon);
			String strAuthQry = @"Select * from userlist where name = '" + txtLogin.Text + "' and password = '" + txtPswd.Text + "'";
			SqlCommand cmdAuthenticate = new SqlCommand(strAuthQry,sqlConn);
            SqlDataAdapter da_Authentication = new SqlDataAdapter();
			da_Authentication.SelectCommand = cmdAuthenticate;
			DataSet ds_Authentication = new DataSet();
			try
			{
				sqlConn.Open();
				da_Authentication.Fill(ds_Authentication);
			}
			catch(Exception ex){throw ex;}
			finally{sqlConn.Close();}
			if(ds_Authentication.Tables["UserList"].Rows.Count>0)
			{
				lblMessage.Text = "Logged In..";
				//this.RedirectToMobilePage("UserList.aspx");
			}
			else
				lblMessage.Text = "Invalid Password..";*/
			this.RedirectToMobilePage("controlpanel.aspx");
		}
	}
}