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
	/// Summary description for addresource.
	/// </summary>
	public class addresource : System.Web.UI.MobileControls.MobilePage
	{
		protected System.Web.UI.MobileControls.Label lblResources;
		protected System.Web.UI.MobileControls.Label lblCost;
		protected System.Web.UI.MobileControls.Label lblDated;
		protected System.Web.UI.MobileControls.Label lblDescription;
		protected System.Web.UI.MobileControls.TextBox txtCost;
		protected System.Web.UI.MobileControls.TextBox txtDated;
		protected System.Web.UI.MobileControls.TextBox txtDescription;
		protected System.Web.UI.MobileControls.SelectionList slReources;
		protected System.Web.UI.MobileControls.Command cmdCancel;
		protected System.Web.UI.MobileControls.Command cmdOk;
		protected System.Web.UI.MobileControls.Form frmAddResource;

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
