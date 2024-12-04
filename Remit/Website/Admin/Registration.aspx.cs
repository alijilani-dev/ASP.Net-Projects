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
using System.Data.SqlClient;
using System.Web.Mail;



namespace SRM
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox email;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator1;
		protected System.Web.UI.WebControls.Button Submit;
		protected System.Web.UI.WebControls.CheckBox agree;
		protected System.Web.UI.WebControls.TextBox aotrans;
		protected System.Web.UI.WebControls.TextBox notrans;
		protected System.Web.UI.WebControls.RadioButton ref2;
		protected System.Web.UI.WebControls.RadioButton ref1;
		protected System.Web.UI.WebControls.TextBox nobanks;
		protected System.Web.UI.WebControls.TextBox nop;
		protected System.Web.UI.WebControls.DropDownList constitution;
		protected System.Web.UI.WebControls.TextBox whours;
		protected System.Web.UI.WebControls.TextBox nob;
		protected System.Web.UI.WebControls.TextBox hoaddress;
		protected System.Web.UI.WebControls.TextBox fax;
		protected System.Web.UI.WebControls.TextBox phone;
		protected System.Web.UI.WebControls.TextBox cperson;
		protected System.Web.UI.WebControls.TextBox caddress;
		protected System.Web.UI.WebControls.TextBox company;
		protected System.Web.UI.WebControls.TextBox dateofestab;
		protected System.Web.UI.HtmlControls.HtmlTable tb;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.Label Label1;
	
		
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
			this.Submit.Click += new System.EventHandler(this.Submit_Click);

		}
		#endregion


		public void mailCEO(string s)
		{
			MailMessage mail=new MailMessage();
			mail.From="ARY Speed Remit" + "<info@speedremit.com>";
			mail.To="info@speedremit.com";
			mail.Subject="New Agent Application";
			mail.BodyFormat=MailFormat.Text;
			mail.Body=s;
			mail.Priority=MailPriority.Normal;
			SmtpMail.SmtpServer="";
			SmtpMail.Send(mail);
				
		}
		
		private void Submit_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(agree.Checked==false)
				{
					Label2.Text="Please accept terms and conditions ";
				}
				else
				{
				
					SqlConnection conn = new SqlConnection();
					string connstr;
            
					connstr = "User ID=sa; Password=syncmaster591S; Data Source=(local); integrated Security=SSPI;";
					connstr = connstr + "Initial Catalog=ARYOffer";

					conn.ConnectionString = connstr;
					conn.Open();

					string reference;
					if(ref1.Checked==true)
						reference="YES";
					else
						reference="NO";

					string str="Insert into SRM(rdate,company,caddress,phone,fax,email,cperson,doe,hoaddress,NOB,whours,const,prop,banks,rtobanks,notrans,aotrans)";
					str=str + " values('" + DateTime.Now.Date + "','" + company.Text +"','" + caddress.Text + "','" + phone.Text + "','" + fax.Text + "','" + email.Text + "','" + cperson.Text + "','" + dateofestab.Text;
					str=str + "','" + hoaddress.Text + "','" + nob.Text + "','" + whours.Text + "','" + constitution.SelectedItem.Value + "','" + nop.Text + "','" + nobanks.Text + "','" + reference + "'," + notrans.Text + "," + aotrans.Text + ")";
					SqlCommand cmd=new SqlCommand(str,conn);
					cmd.ExecuteNonQuery();

				
					string emailstr="Dear Sir, \t\n We have a new agent application through our website www.speedremit.com. Detail of new applicant is as below...\n\n\n\n";
					emailstr=emailstr + "-----------------------------------------------------------------------------------\n\n";
					emailstr=emailstr + "\tDate of Application \t\t" + DateTime.Now + "\n";
					emailstr=emailstr + "\tCompany Name\t\t\t" + company.Text + "\n";
					emailstr=emailstr + "\tCompany Address\t\t\t" + caddress.Text + "\n";
					emailstr=emailstr + "\tContact Person\t\t\t" + cperson.Text + "\n";
					emailstr=emailstr + "\tPhone #\t\t\t\t" + phone.Text + "\n";
					emailstr=emailstr + "\tFax #\t\t\t\t" + fax.Text+ "\n";
					emailstr=emailstr + "\tEmail\t\t\t\t" + email.Text+ "\n";
					emailstr=emailstr + "\tHeEad Office Address\t\t" + hoaddress.Text+ "\n";
					emailstr=emailstr + "\tNumber of Branches\t\t\t" + nob.Text + "\n";
					emailstr=emailstr + "\tWorking Hours\t\t\t" + whours.Text+ "\n";
					emailstr=emailstr + "\tConstitution\t\t\t" + constitution.SelectedItem.Text+ "\n";
					emailstr=emailstr + "\tName of Director\t\t\t" + nop.Text + "\n";
					emailstr=emailstr + "\tBanks maintained\t\t\t" + nobanks.Text+ "\n";
					emailstr=emailstr + "\tReferecne to Banks\t\t\t" + reference+ "\n";
					emailstr=emailstr + "\tNo. of Transactions (1st Year)\t" + notrans.Text+ "\n";
					emailstr=emailstr + "\tAmount of Transactions (1st Year)\t" + aotrans.Text+ "\n\n";
					emailstr=emailstr + "-----------------------------------------------------------------------------------\n";
					emailstr=emailstr + "\n\n\nRegards\n\nwebmaster\nARY Speed Remit Worlwide FZCO.";
					mailCEO(emailstr);
					Response.Redirect("Confirm.aspx");
				}
			}
		catch
			{
				//Label2.Text="Caught exception #2.";
				//Exception ex = new Exception();
				//Label2.Text=ex.Message;
							}

		}
	}  
}

