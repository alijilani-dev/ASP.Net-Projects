using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;
using Params = Evernet.MoneyExchange.DataClasses.Parameters;
using SPs = Evernet.MoneyExchange.DataClasses.StoredProcedures;
using Evernet.MoneyExchange.BusinessLogic;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.Web.Forms
{
	/// <summary>
	/// Summary description for WebFormList_BankExchangeRateList.
	/// </summary>
	public class WebForm_GBPBankExchangeRateList: System.Web.UI.Page
	{
		public WebForm_GBPBankExchangeRateList() {

			Page.Init += new System.EventHandler(Page_Init);
		}

		protected System.Web.UI.WebControls.Label lab_CurrencyId;
		protected System.Web.UI.WebControls.Label lab_ExchangeType;
		protected Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_CurrencyExchangeType com_ExchangeType;
		protected System.Web.UI.WebControls.Label lab_BidRate;
		protected System.Web.UI.WebControls.TextBox txt_BidRate;
		protected System.Web.UI.WebControls.Label labError_BidRate;
		protected System.Web.UI.WebControls.Label lab_OfferRate;
		protected System.Web.UI.WebControls.TextBox txt_OfferRate;
		protected System.Web.UI.WebControls.Label labError_OfferRate;
		protected System.Web.UI.WebControls.Button cmdRefresh;
		protected System.Web.UI.WebControls.Label lab_Error;
		protected System.Web.UI.WebControls.Button cmdUpdate;
		protected System.Web.UI.WebControls.HyperLink ReturnURL;
		private string ConnectionString;
		private string strCurrency;
		private ActionEnum Action = ActionEnum.None;
		private System.Data.SqlTypes.SqlGuid CurrentID = System.Data.SqlTypes.SqlGuid.Null;
		protected System.Web.UI.WebControls.Label lblCurrency;
		private enum ActionEnum 
		{

			None, Add, Edit, Delete
		}

		private System.Globalization.CultureInfo CurrentUserCulture;
		private void Page_Load(object sender, System.EventArgs e) 
		{
			string Language = "en-US";
			if (Request.UserLanguages.Length != 0) 
			{
				Language = Request.UserLanguages[0];
			}
			CurrentUserCulture = System.Globalization.CultureInfo.CreateSpecificCulture(Language);
			System.Threading.Thread.CurrentThread.CurrentUICulture = CurrentUserCulture;
			System.Threading.Thread.CurrentThread.CurrentCulture = CurrentUserCulture;
			if (ConfigurationSettings.AppSettings["mexchange ConnectionString"] != null) 
			{
				ConnectionString = ConfigurationSettings.AppSettings["mexchange ConnectionString"];
			}
			else if (Application["ConnectionString"] != null) 
			{
				ConnectionString = Application["ConnectionString"].ToString().Trim();
			}
			else 
			{
				ConnectionString = String.Empty;
			}
			//////////////////////////////
			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUser
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConnectionString);
			Guid userId = new Guid(Context.User.Identity.Name);
			aoUser.Refresh(userId);

			string strAUser = aoUser.Col_LoginName.Value;
			if ((!Context.User.Identity.IsAuthenticated)||(aoUser.Col_LoginName.Value.ToUpper() != "ASPI"))
			{
				Response.Redirect("../login.aspx");
			}
			//////////////////////////////
			strCurrency = "GREAT BRITON POUNDS [GBP]";
			
			if (!Page.IsPostBack)
			{
				if (Request.Params["ReturnToUrl"] != null)
				{
					ReturnURL.NavigateUrl = Request.Params["ReturnToUrl"].ToString();
					if (Request.Params["ReturnToDisplay"] != null)
					{
						ReturnURL.Text = Request.Params["ReturnToDisplay"].ToString();
					}
					ReturnURL.Visible = true;
				}
			}
			labError_BidRate.Visible = false;
			labError_OfferRate.Visible = false;
			Action = ActionEnum.Edit;
			object ID = Request.Params["ID"];
			if (ID != null) 
			{
				try 
				{
					CurrentID = new Guid(Request.Params["ID"].ToString());
				}
				catch 
				{
					lab_Error.Text = "ERROR: Action=Edit-> ID supplied is not a valid Guid";
					return;
				}
			}
			else 
			{
				try 
				{
					CurrentID = new Guid(GetCurrentId());
				}
				catch 
				{
					lab_Error.Text = "ERROR: Action=Edit-> ID supplied is not a valid Guid";
					return;
				}
			}
			if (!Page.IsPostBack)
			{
				RefreshAll();
			}
		}

		private void Page_Init(object sender, EventArgs e) 
		{
			InitializeComponent();
		}

		#region Web Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() 
		{
			this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void RefreshForeignTables() 
		{
			lblCurrency.Text = strCurrency;

			com_ExchangeType.Initialize(ConnectionString);
			try 
			{
				com_ExchangeType.RefreshData(System.Data.SqlTypes.SqlString.Null);
			}
			catch (Evernet.MoneyExchange.DataClasses.CustomException customException) 
			{
				if (customException.Parameter.SqlException != null) 
				{
					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CurrencyExchangeType' class. Exception message is: {0}", customException.Parameter.SqlException.Message), customException);
				}
				else if (customException.Parameter.OtherException != null) 
				{
					throw new Exception(String.Format("An exception has been thrown in the underlying DataClass that is used by the 'WebDropDownList_CurrencyExchangeType' class. Exception message is: {0}", customException.Parameter.OtherException.Message), customException);
				}
				else 
				{
					throw;
				}
			}
		}

		private void UpdateForm() 
		{
			if (Action == ActionEnum.Edit || Action == ActionEnum.None) 
			{
				cmdRefresh.Visible = true;
				cmdUpdate.Visible = true;
				cmdUpdate.Text = "Update";
				RefreshRecord();
			}
			else 
			{
				cmdRefresh.Visible = false;
				cmdUpdate.Visible = true;
				cmdUpdate.Text = "OK";
				EmptyControls();
			}
		}

		private void RefreshAll() 
		{
			RefreshForeignTables();
			UpdateForm();
		}

		private void cmdRefresh_Click(object sender, System.EventArgs e) 
		{
			RefreshAll();
		}

		private void RefreshRecord() 
		{
			Evernet.MoneyExchange.AbstractClasses.Abstract_BankExchangeRateList oAbstract_BankExchangeRateList = new Evernet.MoneyExchange.AbstractClasses.Abstract_BankExchangeRateList(ConnectionString);
			System.Guid TempId = new Guid(GetCurrentId());
			if (!oAbstract_BankExchangeRateList.Refresh(TempId)) 
			{
				lab_Error.Text = String.Format("No record with ID: {0}", CurrentID.ToString());
				return;
			}
			lblCurrency.Text = strCurrency;
			com_ExchangeType.Items.FindByValue(Convert.ToString(oAbstract_BankExchangeRateList.Col_ExchangeType)).Selected = true;
			if (!oAbstract_BankExchangeRateList.Col_BidRate.IsNull) 
			{
				txt_BidRate.Text = oAbstract_BankExchangeRateList.Col_BidRate.Value.ToString();
			}
			else 
			{
				txt_BidRate.Text = String.Empty;
			}
			if (!oAbstract_BankExchangeRateList.Col_OfferRate.IsNull) 
			{
				txt_OfferRate.Text = oAbstract_BankExchangeRateList.Col_OfferRate.Value.ToString();
			}
			else 
			{
				txt_OfferRate.Text = String.Empty;
			}
		}

		private void EmptyControls() 
		{
			lblCurrency.Text = strCurrency;
			com_ExchangeType.SelectedIndex = 0;
			txt_BidRate.Text = String.Empty;
			txt_OfferRate.Text = String.Empty;
		}
		private void cmdUpdate_Click(object sender, System.EventArgs e) 
		{
			if (!CheckValues()) 
			{
				lab_Error.Text = "ERROR: Please Check the Validity of Exchange rates.";
				return;
			}
			if (Action == ActionEnum.Edit) 
			{
				Params.spU_BankExchangeRateList Param = null;
				Param = new Params.spU_BankExchangeRateList();
				Param.SetUpConnection(ConnectionString);
				Param.Param_Id = CurrentID;
				Param.Param_CurrencyId = new Guid(GetCurrencyId());
				Param.Param_ExchangeType = Convert.ToString(com_ExchangeType.SelectedItem.Value);
				if (txt_BidRate.Text.Trim() != String.Empty) 
				{
					Param.Param_BidRate = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BidRate.Text));
				}
				if (txt_OfferRate.Text.Trim() != String.Empty) 
				{
					Param.Param_OfferRate = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_OfferRate.Text));
				}
				/////////////////////////////////////////////////////
				// Update the values in BankExchangeRateList Table	 
				String strQry = @"Update BankExchangeRateList Set BidRate = " + txt_BidRate.Text + ",OfferRate = " + txt_OfferRate.Text + "where Id = '" + CurrentID.ToString() + "'";
				
				SqlHelper.ExecuteNonQuery(ConnectionString,
					CommandType.Text,
					strQry);
				RefreshRecord();
				/////////////////////////////////////////////////////
			}
		}
		private string GetCurrentId()
		{
			SqlConnection strConn = new SqlConnection(ConnectionString);
			SqlCommand cmdSelect = new SqlCommand("select berl.Id from BankExchangeRateList berl join CurrencyList cl on cl.Id = berl.CurrencyId where cl.Code = 'GBP'" , strConn);
			cmdSelect.CommandTimeout = 30;
			SqlDataAdapter daCountry = new SqlDataAdapter();
			daCountry.SelectCommand = cmdSelect;
			strConn.Open();
			DataSet dsCountry = new DataSet();
			daCountry.Fill(dsCountry, "TransactionDetails");
			strConn.Close();
			if(dsCountry.Tables[0].Rows.Count != 0)
			{
				return dsCountry.Tables[0].Rows[0][0].ToString();
			}
			else
				return string.Empty;
		}
		private string GetCurrencyId()
		{
			SqlConnection strConn = new SqlConnection(ConnectionString);
			SqlCommand cmdSelect = new SqlCommand("Select * from CurrencyList where Code = 'GBP'" , strConn);
			cmdSelect.CommandTimeout = 30;
			SqlDataAdapter daCountry = new SqlDataAdapter();
			daCountry.SelectCommand = cmdSelect;
			strConn.Open();
			DataSet dsCountry = new DataSet();
			daCountry.Fill(dsCountry, "CurrencyList");
			strConn.Close();
			if(dsCountry.Tables[0].Rows.Count != 0)
			{
				return dsCountry.Tables[0].Rows[0][0].ToString();
			}
			else
				return string.Empty;
		}
		private bool CheckValues() 
		{
			bool status = true;
			try 
			{
				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_BidRate.Text));
			}
			catch 
			{
				labError_BidRate.Text = "INVALID";
				labError_BidRate.Visible = true;
				status = false;
			}
			try 
			{
				System.Data.SqlTypes.SqlDecimal value = new System.Data.SqlTypes.SqlDecimal(System.Convert.ToDecimal(txt_OfferRate.Text));
			}
			catch 
			{
				labError_OfferRate.Text = "INVALID";
				labError_OfferRate.Visible = true;
				status = false;
			}
			return(status);
		}
	}
}