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
using Evernet.MoneyExchange.BusinessLogic;
using Microsoft.ApplicationBlocks.Data;

namespace Evernet.MoneyExchange.Admin {
	/// <summary>
	/// Summary description for BulkCardAssigner.
	/// </summary>
	public class BulkCardAssigner : System.Web.UI.Page {
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.DropDownList ddlAgent;
		protected System.Web.UI.WebControls.TextBox txtPrefixCode;
		protected System.Web.UI.WebControls.TextBox txtStartRange;
		protected System.Web.UI.WebControls.TextBox txtEndRange;
		protected System.Web.UI.WebControls.DropDownList ddlAgentAccount;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.TextBox txtFormatString;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.Button butCreateAndAssign;
	
		private void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
			if(!IsPostBack) {
				BindAll();
				UpdateLastUsed();
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
			this.ddlAgentAccount.SelectedIndexChanged += new System.EventHandler(this.ddlAgentAccount_SelectedIndexChanged);
			this.ddlAgent.SelectedIndexChanged += new System.EventHandler(this.ddlAgent_SelectedIndexChanged);
			this.butCreateAndAssign.Click += new System.EventHandler(this.butCreateAndAssign_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void UpdateLastUsed() {
			ListItem li = ddlAgent.SelectedItem;
			txtStartRange.Text = String.Format(txtFormatString.Text,0);
			txtEndRange.Text = String.Format(txtFormatString.Text,0);
			if(li!=null) {
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select Top 1 coalesce(cast(SubString(Code,7,Len(Code)) as int),0)+1 as Code From CustomerCardList Where AgentId='"+ li.Value +"' Order by 1 Desc");

				if(ds.Tables[0].Rows.Count>0) {
					txtStartRange.Text = ds.Tables[0].Rows[0]["Code"].ToString();
					txtEndRange.Text = ds.Tables[0].Rows[0]["Code"].ToString();
				}
			}
		}

		private void BindAll() {
			BindAgentAccount();
			BindAgentList();
			BindPrefixCode();
		}

		private void BindAgentAccount() {
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select Id [ID1],Name Display From AgentMaster Order by Name");

			ddlAgentAccount.DataSource = ds;
			ddlAgentAccount.DataBind();
		}

		private void BindAgentList() {
			ListItem li = ddlAgentAccount.SelectedItem;

			if(li!=null) {
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select Id [ID1], Name Display From AgentLocationList Where AgentAccountId='"+ li.Value +"' Order by Name");

				ddlAgent.DataSource = ds;
				ddlAgent.DataBind();
			}
		}

		private void BindPrefixCode() {
			ListItem li = ddlAgentAccount.SelectedItem;

			if(li!=null) {
				DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select PrefixCode From AgentGroupList Where AgentAccountId='"+ li.Value +"'");

				if(ds.Tables[0].Rows.Count>0) {
					txtPrefixCode.Text = ds.Tables[0].Rows[0]["PrefixCode"].ToString();
				} else {
					txtPrefixCode.Text = "<no code assigned>";
				}
			}
		}

		private void butCreateAndAssign_Click(object sender, System.EventArgs e) {
			lblMessage.Text=String.Empty;

			ListItem li = ddlAgent.SelectedItem;

			Evernet.MoneyExchange.DataClasses.Parameters.spI_CustomerCardList prmiCard
				= new Evernet.MoneyExchange.DataClasses.Parameters.spI_CustomerCardList(true);
			Evernet.MoneyExchange.DataClasses.StoredProcedures.spI_CustomerCardList spsCard
				= new Evernet.MoneyExchange.DataClasses.StoredProcedures.spI_CustomerCardList(false);

			prmiCard.SetUpConnection(ConfigHelper.ConStr);

			if(li!=null) {
				int startValue = int.Parse(txtStartRange.Text);
				int endValue = int.Parse(txtEndRange.Text);

				if(endValue < startValue) {
					lblMessage.Text = "Start value cannot be greater than end value";
					return;
				}

				for(int i=startValue;i<=endValue;i++) {
					prmiCard.Param_Id_UseDefaultValue();
					prmiCard.Param_AgentId = new Guid(li.Value);
					prmiCard.Param_Code = txtPrefixCode.Text+i.ToString(txtFormatString.Text);
					prmiCard.Param_Status = CardStatus.AssignedToAgent.ToString();
					spsCard.Execute(ref prmiCard);

					prmiCard.Reset();
				}
				lblMessage.Text = "Cards created successfully! Any card code which is similiar to existing ones will be skipped!";
			}
		}

		private void ddlAgentAccount_SelectedIndexChanged(object sender, System.EventArgs e) {
			BindAgentList();
			BindPrefixCode();
			UpdateLastUsed();
		}

		private void ddlAgent_SelectedIndexChanged(object sender, System.EventArgs e) {
			UpdateLastUsed();
		}
	}
}
