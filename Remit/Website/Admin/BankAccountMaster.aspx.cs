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
using Evernet.Shared;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.Admin {
	/// <summary>
	/// Summary description for BankAccountMaster.
	/// </summary>
	public class BankAccountMaster : System.Web.UI.Page {
		protected System.Web.UI.WebControls.DataGrid dgrdBankAccount;
		protected System.Web.UI.WebControls.TextBox txtBankName;
		protected System.Web.UI.WebControls.TextBox txtAccountNumber;
		protected System.Web.UI.WebControls.TextBox txtBankAddress;
		protected System.Web.UI.WebControls.TextBox txtContactPerson;
		protected System.Web.UI.WebControls.TextBox txtTelephoneNumber;
		protected System.Web.UI.WebControls.DropDownList ddlCurrencyList;
		protected System.Web.UI.WebControls.DropDownList ddlCountryList;
		protected System.Web.UI.WebControls.Button butAdd;
	
		private void Page_Load(object sender, System.EventArgs e) {
			if(!IsPostBack) {
				BindAll();
			}
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {    
			this.dgrdBankAccount.CancelCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgrdBankAccount_CancelCommand);
			this.dgrdBankAccount.EditCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgrdBankAccount_EditCommand);
			this.dgrdBankAccount.UpdateCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgrdBankAccount_UpdateCommand);
			this.dgrdBankAccount.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgrdBankAccount_DeleteCommand);
			this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BindAll() {
			BindCurrencyList();
			BindCountryList();
			BindGrid();
		}

		private void BindCurrencyList() {
			string query = "Select Id, Name +'['+Code+']' as Display From CurrencyList Order By Name";

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			ddlCurrencyList.DataSource = ds;
			ddlCurrencyList.DataBind();
		}

		private void BindCountryList() {
			string query = "Select Id,Name +'['+Code+']' Display From CountryList Order by Name";

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			ddlCountryList.DataSource = ds;
			ddlCountryList.DataBind();
		}

		private void BindGrid() {
			string query = "Select bam.*, curl.Name as CurrencyName, conl.Name as CountryName From BankAccountMaster bam Join CurrencyList curl On bam.CurrencyId = curl.Id Join CountryList conl On conl.Id = bam.CountryId Order by bam.Name";

			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			dgrdBankAccount.DataSource = ds;
			dgrdBankAccount.DataBind();
		}

		private void butAdd_Click(object sender, System.EventArgs e) {
			string query = "Insert Into BankAccountMaster(Name,AccountNumber, Address, CurrencyId, CountryId, ContactPerson, TelephoneNumber)";
			query += " Values ('"+ txtBankName.Text +"', '"+ txtAccountNumber.Text +"', '"+ txtBankAddress.Text +"', '"+ ddlCurrencyList.SelectedValue +"', '"+ ddlCountryList.SelectedValue +"', '"+ txtContactPerson.Text +"', '"+ txtTelephoneNumber.Text +"')";

			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			BindGrid();
		}

		private void dgrdBankAccount_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e) {
			dgrdBankAccount.EditItemIndex = -1;
			BindGrid();
		}

		private void dgrdBankAccount_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e) {
			dgrdBankAccount.EditItemIndex = e.Item.ItemIndex;
			BindGrid();
		}

		private void dgrdBankAccount_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e) {
			string query = "Update BankAccountMaster Set Name= '"+ ((TextBox)dgrdBankAccount.Items[e.Item.ItemIndex].Cells[0].Controls[0]).Text +"'";
			query += ",AccountNumber='"+ ((TextBox)e.Item.Cells[1].Controls[0]).Text +"'";
			query += ",Address='"+ ((TextBox)e.Item.Cells[2].Controls[0]).Text +"'";
			query += ",ContactPerson = '"+ ((TextBox)e.Item.Cells[5].Controls[0]).Text +"'";
			query += ",TelephoneNumber = '"+ ((TextBox)e.Item.Cells[6].Controls[0]).Text +"'";
			query +=" Where Id = '"+ dgrdBankAccount.DataKeys[e.Item.ItemIndex].ToString() +"'";

			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			dgrdBankAccount.EditItemIndex = -1;

			BindGrid();
		}

		private void dgrdBankAccount_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e) {
			string query = "Delete From BankAccountMaster Where Id = '"+ dgrdBankAccount.DataKeys[e.Item.ItemIndex].ToString() +"'";
            
			SqlHelper.ExecuteNonQuery(ConfigHelper.ConStr,
				CommandType.Text,
				query);

			BindGrid();
		}
	}
}
