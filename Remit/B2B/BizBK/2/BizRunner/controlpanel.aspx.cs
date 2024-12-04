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
	/// Summary description for controlpanel.
	/// </summary>
	public class controlpanel : System.Web.UI.MobileControls.MobilePage
	{
		protected System.Web.UI.MobileControls.Label lblUserName;
		protected System.Web.UI.MobileControls.Label lblWelcome;
		protected System.Web.UI.MobileControls.Image imgCustomerView;
		protected System.Web.UI.MobileControls.Image imgTaskView;
		protected System.Web.UI.MobileControls.Command cmdResources;
		protected System.Web.UI.MobileControls.Command cmdSecurity;
		protected System.Web.UI.MobileControls.Form frmControlPanel;

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
			this.cmdResources.Click += new System.EventHandler(this.cmdResources_Click);
			this.cmdSecurity.Click += new System.EventHandler(this.cmdSecurity_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void cmdResources_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("resourceview.aspx");
		}

		private void cmdSecurity_Click(object sender, System.EventArgs e)
		{
			this.RedirectToMobilePage("resourceview.aspx");
		}
	}
}
