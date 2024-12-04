namespace Evernet.MoneyExchange.UserControls {
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Summary description for StatusInfo.
	/// </summary>
	public class StatusInfo : System.Web.UI.UserControl {
		protected System.Web.UI.WebControls.Label lblLogin;

		private void Page_Load(object sender, System.EventArgs e) {
			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUser
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(Evernet.Shared.ConfigHelper.ConStr);

			aoUser.Refresh(new Guid(Context.User.Identity.Name));
			//Response.Write("Welcome :"+aoUser.Col_LoginName.Value);
			lblLogin.Text = aoUser.Col_LoginName.Value;
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
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
