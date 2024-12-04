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

namespace Evernet.MoneyExchange.Admin
{
	/// <summary>
	/// Summary description for search.
	/// </summary>
	public class search : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblSearch;
		protected System.Web.UI.WebControls.Label lblCustomerDetails;
		protected System.Web.UI.WebControls.Label lblBeneficieryDetails;
		protected System.Web.UI.WebControls.HyperLink Edit;
		protected System.Web.UI.WebControls.HyperLink Delete;
		protected System.Web.UI.WebControls.TextBox txtCFirstName;
		protected System.Web.UI.WebControls.TextBox txtCLastName;
		protected System.Web.UI.WebControls.TextBox txtBFirstName;
		protected System.Web.UI.WebControls.TextBox txtBLastName;
		protected System.Web.UI.WebControls.DataGrid dgrdTransactions;
		protected System.Web.UI.WebControls.Button btnSearchName;
		protected System.Web.UI.WebControls.Button btnSearchRange;
		protected System.Web.UI.WebControls.Button btnCardNo;
		protected System.Web.UI.WebControls.Label lblCustFName;
		protected System.Web.UI.WebControls.Label lblBeneFName;
		protected System.Web.UI.WebControls.Label lblCustLName;
		protected System.Web.UI.WebControls.Label lblBeneLName;
		protected System.Web.UI.WebControls.Label lblStartRange;
		protected System.Web.UI.WebControls.TextBox txtStartRange;
		protected System.Web.UI.WebControls.Label lblEndRange;
		protected System.Web.UI.WebControls.TextBox txtEndRange;
		protected System.Web.UI.WebControls.Label lblCardNo;
		protected System.Web.UI.WebControls.TextBox txtCardNo;
		protected System.Web.UI.WebControls.Repeater rptResults;
		
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
			this.btnSearchName.Click += new System.EventHandler(this.btnSearch_Click);
			this.btnSearchRange.Click += new System.EventHandler(this.btnSearchRange_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			DataSet ds = SqlHelper.ExecuteDataset((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("mexchange ConnectionString").GetValue(0),
			CommandType.Text,
			@"Select td.TransactionNumber as SRTR, cl.FirstName as FirstName, cl.LastName as LastName, bl.FirstName as BFirstName, bl.LastName as BLastName from transactiondetails td
			join CustomerList cl on td.CustomerId = cl.Id join CustomerList bl on td.BeneficeryId = bl.Id
			where bl.FirstName like '%" + txtBFirstName.Text + @"%' and bl.LastName like '%" + txtBLastName.Text + @"%' 
			and cl.FirstName like '%" + txtCFirstName.Text + @"%' and cl.LastName like '%" + txtCLastName.Text + @"%'");
			//dgrdTransactions.DataSource = ds;
			//dgrdTransactions.DataBind();
			rptResults.DataSource = ds;
			rptResults.DataBind();
			rptResults.Visible = true;
		}

		private void btnSearchRange_Click(object sender, System.EventArgs e)
		{
			DataSet ds = SqlHelper.ExecuteDataset((string) System.Configuration.ConfigurationSettings.AppSettings.GetValues("mexchange ConnectionString").GetValue(0),
			CommandType.Text,
			@"Select td.TransactionNumber as SRTR, cl.FirstName as FirstName, cl.LastName as LastName, bl.FirstName as BFirstName, bl.LastName as BLastName from transactiondetails td
			join CustomerList cl on td.CustomerId = cl.Id join CustomerList bl on td.BeneficeryId = bl.Id
			where td.PayInDateTime < '%" + txtBFirstName.Text + @"%' and bl.LastName like '%" + txtBLastName.Text + @"%' 
			and cl.FirstName like '%" + txtCFirstName.Text + @"%' and cl.LastName like '%" + txtCLastName.Text + @"%'");
			rptResults.DataSource = ds;
			rptResults.DataBind();
			rptResults.Visible = true;
		}
	}
}
