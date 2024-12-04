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
	/// Summary description for logins.
	/// </summary>
	public class logins : System.Web.UI.MobileControls.MobilePage
	{
		protected System.Web.UI.MobileControls.Label Label1;
		protected System.Web.UI.MobileControls.TextBox txtUsername;
		protected System.Web.UI.MobileControls.Label Label2;
		protected System.Web.UI.MobileControls.TextBox txtPassword;
		protected System.Web.UI.MobileControls.Command Command1;
		protected System.Web.UI.MobileControls.Label lblError;
		protected System.Web.UI.MobileControls.Form formA;

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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
