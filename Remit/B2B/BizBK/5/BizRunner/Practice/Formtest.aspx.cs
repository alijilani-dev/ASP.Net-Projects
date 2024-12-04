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

namespace BizRunner.Practice
{
	/// <summary>
	/// Summary description for test.
	/// </summary>
	public class test : System.Web.UI.MobileControls.MobilePage
	{
		protected System.Web.UI.MobileControls.Label Label1;
		protected System.Web.UI.MobileControls.Link Link1;
		protected System.Web.UI.MobileControls.Link Link2;
		protected System.Web.UI.MobileControls.Link Link3;
		protected System.Web.UI.MobileControls.Link Link4;
		protected System.Web.UI.MobileControls.Form form4;
		protected System.Web.UI.MobileControls.Label Label2;
		protected System.Web.UI.MobileControls.Link Link5;
		protected System.Web.UI.MobileControls.Link Link6;
		protected System.Web.UI.MobileControls.Link Link7;
		protected System.Web.UI.MobileControls.Link Link8;
		protected System.Web.UI.MobileControls.Form form4a;

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
