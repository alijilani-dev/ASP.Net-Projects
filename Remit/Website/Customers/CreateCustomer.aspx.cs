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
using Evernet.Shared;
using System.Data.SqlClient;

namespace Evernet.MoneyExchange
{
	/// <summary>
	/// Summary description for CreateCustomer.
	/// </summary>
	public class CreateCustomer : System.Web.UI.Page
	{
		#region Declarations.
		protected System.Web.UI.WebControls.Label lblHeading;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.DropDownList ddlBenBankCountry;
		protected System.Web.UI.WebControls.TextBox txtZipCode;
		protected System.Web.UI.WebControls.TextBox txtBankAddress;
		protected System.Web.UI.WebControls.TextBox txtBranchName;
		protected System.Web.UI.WebControls.TextBox txtBankName;
		protected System.Web.UI.WebControls.TextBox txtAccountNumber;
		protected System.Web.UI.WebControls.DropDownList ddlBenNationality;
		protected System.Web.UI.WebControls.DropDownList ddlCustNationality;
		protected System.Web.UI.WebControls.TextBox txtBenIDExpiryDate;
		protected System.Web.UI.WebControls.TextBox txtCustIDExpiry;
		protected System.Web.UI.WebControls.TextBox txtBenIDNumber;
		protected System.Web.UI.WebControls.TextBox txtCustIDNumber;
		protected System.Web.UI.WebControls.TextBox txtBenIDType;
		protected System.Web.UI.WebControls.TextBox txtCustIDType;
		protected System.Web.UI.WebControls.TextBox txtBenMobile;
		protected System.Web.UI.WebControls.TextBox txtCustMobile;
		protected System.Web.UI.WebControls.TextBox txtBenTelephone;
		protected System.Web.UI.WebControls.TextBox txtCustTelephone;
		protected System.Web.UI.WebControls.TextBox txtBenAddress;
		protected System.Web.UI.WebControls.TextBox txtCustAddress;
		protected System.Web.UI.WebControls.TextBox txtBenEmail;
		protected System.Web.UI.WebControls.TextBox txtCustEmail;
		protected System.Web.UI.WebControls.TextBox txtBenLastName;
		protected System.Web.UI.WebControls.TextBox txtCustLastName;
		protected System.Web.UI.WebControls.TextBox txtBenFirstName;
		protected System.Web.UI.WebControls.TextBox txtCustFirstName;
		protected System.Web.UI.WebControls.Button btnCreateCustomer;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button btnCheckCardStatus;
		protected System.Web.UI.WebControls.TextBox txtCustomerCardNo;
		#endregion Declarations.
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack) 
			{
				BindNationality();
			}
			

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
			this.btnCheckCardStatus.Click += new System.EventHandler(this.btnCheckCardStatus_Click);
			this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void BindNationality() 
		{
			DataSet ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,

				CommandType.Text,

				"Select Code [ID1], Name [Display] From MasterCountryList Order by Name");

			DataSet ds1 = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,

				CommandType.Text,

				"Select ID [ID1], Name [Display] From CountryList Order by Name");

			
			
			ddlCustNationality.DataSource = ds;
			ddlCustNationality.DataBind();

			ddlBenNationality.DataSource = ds;
			ddlBenNationality.DataBind();
			
			ddlBenBankCountry.DataSource = ds1;
			ddlBenBankCountry.DataBind();

		}

//		private void btnSubmit_Click(object sender, System.EventArgs e)
//		{
//			Guid customerId = Guid.NewGuid();
//			Guid beneficeryId = Guid.NewGuid();
//			Guid beneficeryBankId = Guid.NewGuid();
//			
//			System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigHelper.ConStr);
//			con.Open();
//			System.Data.SqlClient.SqlTransaction trans = con.BeginTransaction();
//
//			DataSet dsCard = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
//				CommandType.Text,
//				"Select * From CustomerCardList Where Code = '" + txtCustomerCardNo.Text.ToString() + "'");
//				lblMessage.Text = "-CustomerCardList-";
//			return;
//
//			if(dsCard.Tables[0].Rows.Count != 0) 
//			{
//				SqlHelper.ExecuteNonQuery(trans,
//					CommandType.Text,
//					@"INSERT INTO [CustomerList]([Id], [LoginName], [Password], [FirstName], [LastName], [CardId], [Address], [Telephone], [Fax], [Mobile], [Email], [IDType], [IDDetails], [IDExpirationDate], [Nationality], [Active], [AccountActivated], [CardIssued])
//					VALUES('"+ customerId.ToString() +@"',
//					'"+ customerId.ToString() +@"',
//					'',
//					'"+ txtCustFirstName.Text +@"',
//					'"+ txtCustLastName.Text +@"',
//					'"+ dsCard.Tables[0].Rows[0]["Id"].ToString() +@"',
//					'"+ txtCustAddress.Text +@"',
//					'"+ txtCustTelephone.Text +@"',
//					NULL,
//					'"+ txtCustMobile.Text +@"',
//					'"+ txtCustEmail.Text +@"',
//					'"+ txtCustIDType.Text +@"',
//					'"+ txtCustIDNumber.Text +@"',
//					'"+ txtCustIDExpiry.Text +@"',
//					'"+ ddlCustNationality.SelectedValue +@"',
//					1,
//					0,
//					1)");
//
//				SqlHelper.ExecuteNonQuery(trans,
//					CommandType.Text,
//					"Update CustomerCardList Set Status='"+ "'AssignedToCustomer' Where Code='"+ txtCustomerCardNo.ToString() +"'");
//			} 
//			else 
//			{
//				lblMessage.Text = "The Customer card exists under your account, Please contact SR Customer Support for information!";
//				return;
//			}
//			
//			string beneficeryInsertQuery = @"INSERT INTO [CustomerList]([Id], [LoginName], [Password], [FirstName], [LastName], [CardId], [Address], [Telephone], [Fax], [Mobile], [Email], [IDType], [IDDetails], [IDExpirationDate], [Nationality], [Active], [AccountActivated], [CardIssued])
//			VALUES('"+ beneficeryId.ToString() +@"',";
//			beneficeryInsertQuery += "'"+beneficeryId.ToString()+"',";
//			beneficeryInsertQuery += @"'',
//			'"+ txtBenFirstName.Text +@"',
//			'"+ txtBenLastName.Text +@"',";
//			beneficeryInsertQuery += "NULL,";
//			beneficeryInsertQuery += "'"+ txtBenAddress.Text +@"',
//			'"+ txtBenTelephone.Text +@"',
//			NULL,
//			'"+ txtBenMobile.Text +@"',
//			'"+ txtBenEmail.Text +@"',
//			'"+ txtBenIDType.Text +@"',
//			NULL,";
//			beneficeryInsertQuery += @"NULL,";
//			beneficeryInsertQuery += @"'"+ ddlBenNationality.SelectedValue +@"',
//			1,
//			0,
//			1)";
//
//			SqlHelper.ExecuteNonQuery(trans,
//				CommandType.Text,
//				beneficeryInsertQuery);
//
//			SqlHelper.ExecuteNonQuery(trans,
//				CommandType.Text,
//				@"INSERT INTO [BeneficeryBankList]([Id], [CustomerId], [RegistrationDateTime], [AccountNumber], [Name], [BranchName], [Address], [ZipCode], [CountryId])
//					VALUES(
//					'"+ beneficeryBankId.ToString() +@"',
//					'"+ customerId.ToString() +@"',
//					getdate(),
//					'"+ txtAccountNumber.Text +@"',
//					'"+ txtBankName.Text +@"',
//					'"+ txtBranchName.Text +@"',
//					'"+ txtBankAddress.Text +@"',
//					'"+ txtZipCode.Text +@"',
//					'"+ ddlBenBankCountry.SelectedValue +"')");
//		}

//		private void txtCustMobile_TextChanged(object sender, System.EventArgs e)
//		{
//			Guid customerId = Guid.NewGuid();
//			Guid beneficeryId = Guid.NewGuid();
//			Guid beneficeryBankId = Guid.NewGuid();
//			
//			System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigHelper.ConStr);
//			con.Open();
//			System.Data.SqlClient.SqlTransaction trans = con.BeginTransaction();
//
//			DataSet dsCard = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
//				CommandType.Text,
//				"Select * From CustomerCardList Where Code = '" + txtCustomerCardNo.Text.ToString() + "'");
//			lblMessage.Text = "-CustomerCardList-";
//			return;
//		}

		private void btnCheckCardStatus_Click(object sender, System.EventArgs e)
		{
			DataSet dsCard = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From CustomerCardList Where Code = '" + txtCustomerCardNo.Text + "'");
			int res;
			res=dsCard.Tables[0].Rows.Count;
			if(res!=0)
			{
				if (dsCard.Tables[0].Rows[0]["Status"].ToString()!= "AssignedToAgent")
					lblMessage.Text += "Card Already Assigned.";
				else
					lblMessage.Text += "Card not Assigned.";
			}
			else
			{
				lblMessage.Text = "The Card Number you entered is incorrect!!!";
			}
		}
			
		private void btnCreateCustomer_Click(object sender, System.EventArgs e)
		{
			Guid customerId = Guid.NewGuid();
			Guid beneficeryId = Guid.NewGuid();
			Guid beneficeryBankId = Guid.NewGuid();

			System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigHelper.ConStr);
			con.Open();
			System.Data.SqlClient.SqlTransaction trans = con.BeginTransaction();

			DataSet dsCard = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From CustomerCardList Where Id Not In (Select CardId From CustomerList Where CardId Is Not Null)  And Code = '" + txtCustomerCardNo.Text.ToString() + "' Order by Code");
				//"Select * From CustomerCardList Where Code = '" + txtCustomerCardNo.Text.ToString() + "'");

			if(dsCard.Tables[0].Rows.Count != 0 && dsCard.Tables[0].Rows[0]["Status"].ToString()== "AssignedToAgent") 
			{
				lblMessage.Text = dsCard.Tables[0].Rows[0]["Status"].ToString();

				try
				{
					int nResult = SqlHelper.ExecuteNonQuery(trans,
						CommandType.Text,
						@"INSERT INTO [CustomerList]([Id], [LoginName], [Password], [FirstName], [LastName], [CardId], [Address], [Telephone], [Fax], [Mobile], [Email], [IDType], [IDDetails], [IDExpirationDate], [Nationality], [Active], [AccountActivated], [CardIssued])
					VALUES('"+ customerId.ToString() +@"',
					'',
					'',
					'"+ txtCustFirstName.Text +@"',
					'"+ txtCustLastName.Text +@"',
					'"+ dsCard.Tables[0].Rows[0]["Id"].ToString() +@"',
					'"+ txtCustAddress.Text +@"',
					'"+ txtCustTelephone.Text +@"',
					'',
					'"+ txtCustMobile.Text +@"',
					'"+ txtCustEmail.Text +@"',
					'"+ txtCustIDType.Text +@"',
					'"+ txtCustIDNumber.Text +@"',
					'"+ txtCustIDExpiry.Text +@"',
					'"+ ddlCustNationality.SelectedValue +@"',
					1,
					0,
					1)");
				}
				catch(Exception ex)
				{
					trans.Rollback();
					lblMessage.Text = ex.Message.ToString();
					return;
				}
				finally{}

				try
				{

					int nResults = SqlHelper.ExecuteNonQuery(trans,
						CommandType.Text,
						"Update CustomerCardList Set Status = 'AssignedToCustomer' Where Code = '" + txtCustomerCardNo.Text.ToString() + "'");
				}
				catch(Exception ex)
				{
					trans.Rollback();
					lblMessage.Text = ex.Message.ToString();
					return;
				}
				finally
				{
					trans.Connection.Close();
				}
				/*if (nResults>0)
					lblMessage.Text += " Done";
				else
					lblMessage.Text += " Not Done";*/
			}
			else 
			{
				lblMessage.Text = "The provided Customer card has already been assigned, Please contact SR Customer Support for information!";
				return;
			}

			trans.Commit();
			return;
		}

		private void Clear_Form()
		{
			txtCustomerCardNo.Text="";
			txtCustFirstName.Text="";
			txtZipCode.Text="";
			txtBankAddress.Text="";
            txtBranchName.Text="";
			txtBankName.Text="";
			txtAccountNumber.Text="";
			ddlBenNationality.SelectedIndex=-1;
			ddlCustNationality.SelectedIndex=-1;
			txtBenIDExpiryDate.Text="";
            txtCustIDExpiry.Text="";
			txtBenIDNumber.Text="";
			txtCustIDNumber.Text="";
			txtBenIDType.Text="";
			txtCustIDType.Text="";
			txtBenMobile.Text="";
			txtCustMobile.Text="";
			txtBenTelephone.Text="";
			txtCustTelephone.Text="";
			txtBenAddress.Text="";
			txtCustAddress.Text="";
			txtBenEmail.Text="";
			txtCustEmail.Text="";
			txtBenLastName.Text="";
			txtCustLastName.Text="";
            txtBenFirstName.Text="";
			txtCustFirstName.Text="";
			txtCustomerCardNo.Text="";
		}		
		
		private void Button1_Click(object sender, System.EventArgs e)
		{
			Guid customerId = Guid.NewGuid();
			Guid beneficeryId = Guid.NewGuid();
			Guid beneficeryBankId = Guid.NewGuid();

			System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigHelper.ConStr);
			con.Open();
			System.Data.SqlClient.SqlTransaction trans = con.BeginTransaction();
            	DataSet dsCard = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From CustomerCardList Where Id Not In (Select CardId From CustomerList Where CardId Is Not Null)  And Code = '" + txtCustomerCardNo.Text.ToString() + "' Order by Code");
			//"Select * From CustomerCardList Where Code = '" + txtCustomerCardNo.Text.ToString() + "'");
			if(dsCard.Tables[0].Rows.Count != 0 && dsCard.Tables[0].Rows[0]["Status"].ToString()== "AssignedToAgent") 
			{
				lblMessage.Text = dsCard.Tables[0].Rows[0]["Status"].ToString();

				try
				{
					
					string str;
					str="INSERT INTO [CustomerList]([Id], [FirstName], [LastName], [CardId], [Address], [Telephone], [Fax], [Mobile], [Email], [IDType], [IDDetails], [IDExpirationDate], [Nationality], [Active], [AccountActivated], [CardIssued]) VALUES('";
					str=str+ customerId.ToString() + "','" + txtCustFirstName.Text + "','" + txtCustLastName.Text + "','" + dsCard.Tables[0].Rows[0]["Id"].ToString() +"','"+ txtCustAddress.Text +"','"+ txtCustTelephone.Text + "','','" + txtCustMobile.Text + "','"+ txtCustEmail.Text +"','"+ txtCustIDType.Text + "','"+ txtCustIDNumber.Text +"','"+ txtCustIDExpiry.Text +"','"+ ddlCustNationality.SelectedValue +"',1,0,1)";
					SqlCommand cmd= new SqlCommand(str,con,trans);
					cmd.ExecuteNonQuery();
                    //lblMessage.Text="Customer Information has been Saved";
				}
				catch(Exception ex)
				{
					trans.Rollback();
					lblMessage.Text = ex.Message.ToString();
					return;
				}
				finally{}

				try
				{

					string strupdate;
					strupdate="Update CustomerCardList Set Status = 'AssignedToCustomer' Where Code = '" + txtCustomerCardNo.Text.ToString() + "'";
					SqlCommand cmdupdate= new SqlCommand(strupdate,con,trans);
					cmdupdate.ExecuteNonQuery();
					
					//lblMessage.Text += " also Updated";
								}
				catch(Exception ex)
				{
					trans.Rollback();
					lblMessage.Text = ex.Message.ToString();
					return;
				}
				finally
				{}


				try
				{
					
					string str2;
					str2="INSERT INTO [CustomerList]([Id], [LoginName],  [FirstName], [LastName], [Address], [Telephone], [Fax], [Mobile], [Email], [IDType], [IDDetails], [IDExpirationDate], [Nationality], [Active], [AccountActivated], [CardIssued]) VALUES('";
					str2=str2+ beneficeryId.ToString() + "','" + beneficeryId.ToString() + "','" + txtBenFirstName.Text + "','" + txtBenLastName.Text + "','"+ txtBenAddress.Text +"','"+ txtBenTelephone.Text + "','','" + txtBenMobile.Text + "','"+ txtBenEmail.Text +"','"+ txtBenIDType.Text + "','"+ txtBenIDNumber.Text +"','"+ txtBenIDExpiryDate.Text +"','"+ ddlBenNationality.SelectedValue +"',1,0,1)";
					//Label1.Text=str2;
					SqlCommand cmd2= new SqlCommand(str2,con,trans);
					cmd2.ExecuteNonQuery();
					//lblMessage.Text+=" and also Benificiary Information has been Saved";
				}
				catch(Exception ex)
				{
					trans.Rollback();
					lblMessage.Text = ex.Message.ToString();
					return;
				}
				finally{}

				try
				{
					
					string str3;
					str3="INSERT INTO [BeneficeryBankList]([Id], [CustomerID], [RegistrationDateTime], [AccountNumber], [Name], [BranchName], [Address], [ZipCode], [CountryId]) VALUES('";
					str3=str3+ beneficeryBankId.ToString() + "','" +  customerId.ToString() + "','" + DateTime.Today.ToString() + "','" + txtAccountNumber.Text + "','" + txtBankName.Text + "','" + txtBranchName.Text + "','" +  txtBankAddress.Text +"','"+ txtZipCode.Text  + "','" + ddlBenBankCountry.SelectedValue + "')";
					//Label1.Text=str3;
					SqlCommand cmd3= new SqlCommand(str3,con,trans);
					cmd3.ExecuteNonQuery();
					//lblMessage.Text="Benificiary Bank Information has been Saved";
				}
				catch(Exception ex)
				{
					trans.Rollback();
					lblMessage.Text = ex.Message.ToString();
					return;
				}
				finally{}



				try
				{
					string str4;
					str4="INSERT INTO [DirectMembers]([CustomerId], [BeneficeryID], [BeneficeryBankID], [PayOutCountry]) VALUES('";
					str4=str4+ customerId.ToString() + "','" +  beneficeryId.ToString() + "','" +  beneficeryBankId.ToString() + "','" +  ddlBenNationality.SelectedValue + "')";
					//Label1.Text=str3;
					SqlCommand cmd4= new SqlCommand(str4,con,trans);
					cmd4.ExecuteNonQuery();
					//lblMessage.Text+="Direct Member updated";
				}
				catch(Exception ex)
				{
					lblMessage.Text = ex.Message.ToString();
					return;
				}
				finally{}

				/*if (nResults>0)
					lblMessage.Text += " Done";
				else
					lblMessage.Text += " Not Done";*/
			}
			else 
			{
				lblMessage.Text = "The provided Customer card has already been assigned, Please contact SR Customer Support for information!";
				return;
			}
			
			trans.Commit();
			lblMessage.Text="Customer Information has been saved successfully!!!";
			Clear_Form();
			return;
					
		}

	}
}
