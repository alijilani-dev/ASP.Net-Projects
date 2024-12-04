using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
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
	/// Summary description for MobileWebForm2.
	/// </summary>
	public class MobileWebForm2 : System.Web.UI.MobileControls.MobilePage
	{
		#region Declarations.
		protected System.Web.UI.MobileControls.Command cmdSendPswd;
		protected System.Web.UI.MobileControls.TextBox txtUserName;
		protected System.Web.UI.MobileControls.Label lblEmail;
		protected System.Web.UI.MobileControls.Label lblUserName;
		protected System.Web.UI.MobileControls.TextBox txtEmail;
		protected System.Web.UI.MobileControls.Form frmForgot;
		protected System.Web.UI.MobileControls.Command cmdBacktoRec;
		protected System.Web.UI.MobileControls.Label lblMsg;
		protected System.Web.UI.MobileControls.Label lblHeading;
		protected System.Web.UI.MobileControls.Form frmMessage;
		protected System.Web.UI.MobileControls.Command cmdCancel;
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
			this.cmdSendPswd.Click += new System.EventHandler(this.cmdSendPswd_Click);
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			this.cmdBacktoRec.Click += new System.EventHandler(this.cmdBacktoRec_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("login.aspx");
		}

		private void cmdSendPswd_Click(object sender, System.EventArgs e)
		{
			lblMsg.Text = "Your password has been sent.";
			ActiveForm = frmMessage;
		}

		private void cmdBacktoRec_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("login.aspx");
		}
	}
}