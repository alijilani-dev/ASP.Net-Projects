using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MXCharts
{
	public class Vouchers : System.Windows.Forms.Form
	{
		//bool bl_MasterAdded=false;
		string expDetails = string.Empty;
		string expMaster = string.Empty;
		bool IsValidGroup = false;
		bool MasterIDsUpdated = false;
		private DataSet dsv;
		private int n_MasterID=0;
		private BindingManagerBase BindingManager;
		#region Declarations.

		private System.Windows.Forms.TextBox txt_VoucherNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_RemoveRecords;
		private System.Windows.Forms.MainMenu mnu_Vouchers;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txt_VoucherDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_ValueDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_Insert;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGrid dg_Vouchers;
		private System.ComponentModel.Container components = null;
		private SqlConnection ARYFL_Conn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblNetDebit;
		private System.Windows.Forms.Label lblNetCredit;
		private System.Windows.Forms.Button btn_NewRecord;
		private System.Windows.Forms.TextBox txt_Narration;
		private System.Windows.Forms.Label label4;
		string ConnectionString = "Password=m;Persist Security Info=True;User ID=mexchange;Initial Catalog=mexchange;Data Source=spraedxb004";
		#endregion Declarations.
		public Vouchers()
		{
			ARYFL_Conn = new SqlConnection(ConnectionString);
			InitializeComponent();
			dsv = new DataSet();
			DataTable dtvd = new DataTable("VoucherDetails");
			dtvd.Columns.Add("AgentAccountID");
			//dtvd.Columns.Add("AgentAccount");
			dtvd.Columns.Add("MasterID");
			dtvd.Columns.Add("Rate");
			dtvd.Columns.Add("CurrencyCode");
			dtvd.Columns.Add("Principal");
			dtvd.Columns.Add("FC_Debit");
			dtvd.Columns.Add("LC_Debit");
			dtvd.Columns.Add("FC_Credit");
			dtvd.Columns.Add("LC_Credit");
			dsv.Tables.Add(dtvd);

			for (int n_RowsCount=0; n_RowsCount<11; n_RowsCount++)
			{
				InsertBlankRow();
			}
			DataTable dtam = (GetAgentNames()).Copy();
			dsv.Tables.Add(dtam);
			EmbedComboColumn();
			dg_Vouchers.DataSource = dsv.Tables["VoucherDetails"];
			this.dg_Vouchers.CurrentCellChanged +=new EventHandler(dg_Vouchers_CurrentCellChanged);
			BindingManager = this.BindingContext[dg_Vouchers.DataSource];
			//BindingManager.PositionChanged += new System.EventHandler(RowChanged);
			txt_VoucherDate.Text = DateTime.Now.ToShortDateString();
			txt_ValueDate.Text = DateTime.Now.ToShortDateString();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_NewRecord = new System.Windows.Forms.Button();
			this.txt_VoucherNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_RemoveRecords = new System.Windows.Forms.Button();
			this.mnu_Vouchers = new System.Windows.Forms.MainMenu();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_VoucherDate = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_ValueDate = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_Insert = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblNetCredit = new System.Windows.Forms.Label();
			this.lblNetDebit = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dg_Vouchers = new System.Windows.Forms.DataGrid();
			this.txt_Narration = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg_Vouchers)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_NewRecord
			// 
			this.btn_NewRecord.Location = new System.Drawing.Point(536, 432);
			this.btn_NewRecord.Name = "btn_NewRecord";
			this.btn_NewRecord.Size = new System.Drawing.Size(96, 23);
			this.btn_NewRecord.TabIndex = 28;
			this.btn_NewRecord.Text = "&Refresh";
			this.btn_NewRecord.Click += new System.EventHandler(this.btn_NewRecord_Click);
			// 
			// txt_VoucherNumber
			// 
			this.txt_VoucherNumber.Enabled = false;
			this.txt_VoucherNumber.Location = new System.Drawing.Point(120, 432);
			this.txt_VoucherNumber.Name = "txt_VoucherNumber";
			this.txt_VoucherNumber.Size = new System.Drawing.Size(96, 20);
			this.txt_VoucherNumber.TabIndex = 27;
			this.txt_VoucherNumber.Text = "";
			this.txt_VoucherNumber.Visible = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 432);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 26;
			this.label1.Text = "Voucher Number:";
			this.label1.Visible = false;
			// 
			// btn_RemoveRecords
			// 
			this.btn_RemoveRecords.Location = new System.Drawing.Point(16, 432);
			this.btn_RemoveRecords.Name = "btn_RemoveRecords";
			this.btn_RemoveRecords.Size = new System.Drawing.Size(96, 23);
			this.btn_RemoveRecords.TabIndex = 18;
			this.btn_RemoveRecords.Text = "&Remove";
			this.btn_RemoveRecords.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txt_VoucherDate);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txt_ValueDate);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(16, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(864, 40);
			this.panel1.TabIndex = 15;
			// 
			// txt_VoucherDate
			// 
			this.txt_VoucherDate.Location = new System.Drawing.Point(112, 8);
			this.txt_VoucherDate.Name = "txt_VoucherDate";
			this.txt_VoucherDate.Size = new System.Drawing.Size(344, 20);
			this.txt_VoucherDate.TabIndex = 1;
			this.txt_VoucherDate.Text = "3/13/2005";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(472, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Value Date:";
			// 
			// txt_ValueDate
			// 
			this.txt_ValueDate.Location = new System.Drawing.Point(552, 8);
			this.txt_ValueDate.Name = "txt_ValueDate";
			this.txt_ValueDate.Size = new System.Drawing.Size(296, 20);
			this.txt_ValueDate.TabIndex = 2;
			this.txt_ValueDate.Text = "3/13/2005";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Voucher Date:";
			// 
			// btn_Insert
			// 
			this.btn_Insert.Location = new System.Drawing.Point(656, 432);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.Size = new System.Drawing.Size(96, 23);
			this.btn_Insert.TabIndex = 17;
			this.btn_Insert.Text = "&Post";
			this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.Location = new System.Drawing.Point(776, 432);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(96, 23);
			this.btn_Exit.TabIndex = 25;
			this.btn_Exit.Text = "E&xit";
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblNetCredit);
			this.groupBox2.Controls.Add(this.lblNetDebit);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.dg_Vouchers);
			this.groupBox2.Location = new System.Drawing.Point(16, 64);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(864, 288);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Voucher Details";
			// 
			// lblNetCredit
			// 
			this.lblNetCredit.Location = new System.Drawing.Point(760, 264);
			this.lblNetCredit.Name = "lblNetCredit";
			this.lblNetCredit.Size = new System.Drawing.Size(96, 14);
			this.lblNetCredit.TabIndex = 6;
			// 
			// lblNetDebit
			// 
			this.lblNetDebit.Location = new System.Drawing.Point(568, 264);
			this.lblNetDebit.Name = "lblNetDebit";
			this.lblNetDebit.Size = new System.Drawing.Size(88, 14);
			this.lblNetDebit.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(728, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 16);
			this.label8.TabIndex = 4;
			this.label8.Text = "Credit";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(464, 264);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 16);
			this.label7.TabIndex = 3;
			this.label7.Text = "Net Debit(LC):";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(656, 264);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "Net Credit(LC):";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(576, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "Debit";
			// 
			// dg_Vouchers
			// 
			this.dg_Vouchers.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dg_Vouchers.BackColor = System.Drawing.Color.Gainsboro;
			this.dg_Vouchers.BackgroundColor = System.Drawing.Color.Silver;
			this.dg_Vouchers.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dg_Vouchers.CaptionFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dg_Vouchers.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dg_Vouchers.CaptionVisible = false;
			this.dg_Vouchers.DataMember = "";
			this.dg_Vouchers.ForeColor = System.Drawing.Color.Black;
			this.dg_Vouchers.GridLineColor = System.Drawing.Color.DarkGray;
			this.dg_Vouchers.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dg_Vouchers.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dg_Vouchers.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dg_Vouchers.HeaderForeColor = System.Drawing.Color.White;
			this.dg_Vouchers.LinkColor = System.Drawing.Color.MidnightBlue;
			this.dg_Vouchers.Location = new System.Drawing.Point(16, 32);
			this.dg_Vouchers.Name = "dg_Vouchers";
			this.dg_Vouchers.ParentRowsBackColor = System.Drawing.Color.DarkGray;
			this.dg_Vouchers.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dg_Vouchers.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dg_Vouchers.SelectionForeColor = System.Drawing.Color.White;
			this.dg_Vouchers.Size = new System.Drawing.Size(832, 232);
			this.dg_Vouchers.TabIndex = 0;
			// 
			// txt_Narration
			// 
			this.txt_Narration.Location = new System.Drawing.Point(132, 368);
			this.txt_Narration.Multiline = true;
			this.txt_Narration.Name = "txt_Narration";
			this.txt_Narration.Size = new System.Drawing.Size(736, 48);
			this.txt_Narration.TabIndex = 29;
			this.txt_Narration.Text = "";
			this.txt_Narration.Leave += new System.EventHandler(this.txt_Narration_Leave);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(28, 368);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 30;
			this.label4.Text = "Narration:";
			// 
			// Vouchers
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(896, 470);
			this.Controls.Add(this.txt_Narration);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_VoucherNumber);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_RemoveRecords);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_Insert);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btn_NewRecord);
			this.Menu = this.mnu_Vouchers;
			this.Name = "Vouchers";
			this.Text = "MXCharts";
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg_Vouchers)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		[STAThread]
		static void Main() 
		{
			Application.Run(new Vouchers());
		}
		private void getposition(string strCaption)
		{
			int n_BP = 0;
			int n_BC = 0;
			int n_DRC = 0;
			int n_GRI = 0;
			string strText;
			try
			{
				n_BP = BindingManager.Position;// BindingPosition.
			}
			catch(Exception ex){}
			try
			{
				n_BC = Convert.ToInt32(BindingManager.Current.ToString()); // BindingPositionCurrent.
			}
			catch(Exception ex){}
			try
			{
				n_DRC = dsv.Tables["VoucherDetails"].Rows.Count;// DataSetRowCount
			}
			catch(Exception ex){}
			try
			{
				n_GRI = dg_Vouchers.CurrentRowIndex;// GridRowIndex.
			}
			catch(Exception ex){}

			strText = "BP: " + n_BP.ToString() + ", BC: " + n_BC.ToString() + ", DRC: " + n_DRC.ToString() + ", GRI: " + n_GRI.ToString();

			MessageBox.Show(strText,strCaption);
		}
		private string GetQuery(Actions n_ActionType, DataRow drParamVouchers)
		{
			string str_Query= string.Empty;
			switch(n_ActionType)
			{
				#region Show
				case Actions.Show:
				{
					str_Query = "Showing Data";
					break;
				}
				#endregion
				#region Add Master
				case Actions.AddMaster:
				{	
					str_Query = "INSERT INTO VoucherMaster(VoucherNumber, VoucherDate, ValueDate, Narration)" +
						" VALUES(" + Convert.ToInt32(GetMaxVoucherNumber()) + ", '" + DateTime.Parse(txt_VoucherDate.Text).ToShortDateString() + "', '" + DateTime.Parse(txt_ValueDate.Text).ToShortDateString() + "','" + txt_Narration.Text + "') Select @@IDENTITY";
					break;
				}
				#endregion
				#region Add Details
				case Actions.AddDetails:
				{
					Guid AgentID = new Guid(drParamVouchers["AgentAccountID"].ToString());
					str_Query = "INSERT INTO VoucherDetails( AgentAccountID, MasterID, FC_Debit, LC_Debit, FC_Credit, LC_Credit, Rate, Principal_Commision)" +
								" VALUES( @AgentAccountID, " + drParamVouchers["MasterID"] + "," + drParamVouchers["FC_Debit"] + "," + drParamVouchers["LC_Debit"] + "," + drParamVouchers["FC_Credit"] + "," + drParamVouchers["LC_Credit"] + "," + drParamVouchers["Rate"] + ",'" + drParamVouchers["Principal"] + "' )";
					break;
				}
				#endregion
				#region Update
				case Actions.Update:
				{
					str_Query = "UPDATE VoucherDetails" +
						" SET " +
						//" DetailID=@DetailID" +
						" AgentAccountID=@AgentAccountID " +
						" ,MasterID=@MasterID " +
						" ,FC_Debit=@FC_Debit " +
						" ,LC_Debit=@LC_Debit " +
						" ,FC_Credit=@FC_Credit " +
						" ,LC_Credit=@LC_Credit " +
						" ,Rate=@Rate" +
						" WHERE DetailID=@ConDetailID";
					break;
				}
				#endregion
				#region Delete
				case Actions.Delete:
				{
					str_Query = "Deleting Data";
					break;
				}
				#endregion
				#region Default
				default:
				{
					str_Query = "Defaulting Data";
					break;
				}
				#endregion
			}
			return str_Query;
		}
		#region Events.
		private void btn_NewRecord_Click(object sender, System.EventArgs e)
		{
			dsv.Tables["VoucherDetails"].Rows.Clear();
			txt_VoucherDate.Text = DateTime.Now.ToShortDateString();
			txt_ValueDate.Text = DateTime.Now.ToShortDateString();
			txt_Narration.Text = "";
			for (int n_RowsCount=0; n_RowsCount<11; n_RowsCount++)
			{
				InsertBlankRow();
			}
			expDetails = string.Empty;
			expMaster = string.Empty;
			IsValidGroup = false;
			bool MasterIDsUpdated = false;
			txt_VoucherDate.Focus();
		}
		private void btn_Exit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void RowChanged(object sender, System.EventArgs e) 
 		{
			//if(dsv.Tables["VoucherDetails"].Rows.Count < BindingManager.Position )
			//if(dg_Vouchers.VisibleRowCount >= BindingManager.Position)
			//if((BindingManager.Position >= ((DataTable)dg_Vouchers.DataSource).Rows.Count))
			//if(BindingManager.Position == dsv.Tables["VoucherDetails"].Rows.Count-1)
			{
				//getposition("RowCount" + ((DataTable)dg_Vouchers.DataSource).Rows.Count.ToString() + "-:GRC-" + dg_Vouchers.VisibleRowCount.ToString());
				//dg_Vouchers.Refresh();
				//InsertBlankRow();
			}
		}
		private void cmb_SelectedValueChanged(object sender, System.EventArgs e)
		{
			string str_Text = (((ComboBox)sender).GetItemText(((ComboBox)sender).SelectedItem)).ToString().Trim();
			string strdelims = "[]";
			char[] delimiter = strdelims.ToCharArray();
			string[] split = null;
			split=str_Text.Split(delimiter,5);
			delimiter = (".").ToCharArray();
			string[] n_Flag = split[1].Split(delimiter,5);
			if((n_Flag[1]=="1"))
			dsv.Tables["VoucherDetails"].Rows[BindingManager.Position]["Principal"] = "P";
			else
			dsv.Tables["VoucherDetails"].Rows[BindingManager.Position]["Principal"] = "C";
			dsv.Tables["VoucherDetails"].Rows[BindingManager.Position]["AgentAccountID"] = (((ComboBox)sender).SelectedValue).ToString();
			DataRow dr_Rate = GetRate((((ComboBox)sender).GetItemText(((ComboBox)sender).SelectedValue)).ToString().Trim());
			dsv.Tables["VoucherDetails"].Rows[BindingManager.Position]["Rate"] = Convert.ToDecimal(dr_Rate[0].ToString()).ToString();
			dsv.Tables["VoucherDetails"].Rows[BindingManager.Position]["CurrencyCode"] = dr_Rate[1].ToString();
			if(dr_Rate[1].ToString().Trim()=="BKU")
			{
				dsv.Tables["VoucherDetails"].Rows[BindingManager.Position]["FC_Debit"] = 0;
				dsv.Tables["VoucherDetails"].Rows[BindingManager.Position]["FC_Credit"] = 0;
			}
			dsv.Tables["VoucherDetails"].Rows[BindingManager.Position]["MasterID"] = n_MasterID.ToString();
		}
		private void txt_Narration_Leave(object sender, System.EventArgs e)
		{
			string strQuery = string.Empty;
			string strRegister = string.Empty;
			strQuery = GetQuery(Actions.AddMaster,null);
			strRegister = "INSERT INTO AgentAccountDetails(Id, CreditDateTime, DebitDateTime, AgentAccountId, TransactionId, CreditLC, CreditUSD, DebitLC, DebitUSD)" +
				" VALUES('" + Guid.NewGuid() + "', NULL, NULL, NULL, NULL, 0, 0, 0, 0)";		  
			SqlCommand cmd_Add = new SqlCommand(strQuery,ARYFL_Conn);
			SqlCommand cmd_Reg = new SqlCommand(strRegister,ARYFL_Conn);
			if(MessageBox.Show("Are you sure you want to add current record","MXCharts",MessageBoxButtons.YesNo)==DialogResult.Yes)
			{
				try
				{
					InsertVoucherNumber(ConnectionString,cmd_Reg);
					AddMaster(cmd_Add);
					//expMaster = true;
					//bl_MasterAdded = true;
				}
				catch(SqlException ex)
				{
					//MessageBox.Show("Problem with Narration Data.","MXCharts",MessageBoxButtons.OK);
					expMaster = ex.Number.ToString();
					throw ex;
				}
				finally
				{
					//dsv.Tables["VoucherDetails"].Columns["MasterID"] = n_MasterID.ToString();
					Application.DoEvents();
				}
			}
		}

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{
			DataTable dtv = dsv.Tables["VoucherDetails"];
			//bool IsValidGroup = true;// Moved to global variable.
			for (int n_Counter = 0; n_Counter < dtv.Rows.Count ; n_Counter++)
			{
				if(!dtv.Rows[n_Counter][0].Equals(string.Empty))
				{
					if(IsValidGroup)
					{
						string strQuery = GetQuery(Actions.AddDetails,dtv.Rows[n_Counter]);
						//MessageBox.Show(strQuery);
						SqlCommand cmd_Add = new SqlCommand(strQuery,ARYFL_Conn);
						Guid AgentAccountID = new Guid(dtv.Rows[n_Counter]["AgentAccountID"].ToString());
						cmd_Add.Parameters.Add(new SqlParameter("@AgentAccountID", SqlDbType.UniqueIdentifier , 16));
						cmd_Add.Parameters["@AgentAccountID"].Value = AgentAccountID;

						try 
						{
							cmd_Add.Connection.Open();
							cmd_Add.ExecuteNonQuery();
						}
						catch (SqlException ex)
						{
							if (ex.Number == 547)
							{
								cmd_Add.Connection.Close();
								expDetails = ex.Number.ToString();
								//MessageBox.Show("Error#:" +ex.Number.ToString()+ " | Please Insert Relevant Narration.","MXCharts",MessageBoxButtons.OKCancel);
							}
							else
							{
								cmd_Add.Connection.Close();
								expDetails = ex.Number.ToString();
								throw ex;
							}
						}
						finally
						{
							cmd_Add.Connection.Close();
							dsv.AcceptChanges();
							dg_Vouchers.Refresh();
							Application.DoEvents();
						}
					}
				}
			}
			if(expMaster == string.Empty)
			{
				if(IsValidGroup == true)
				{
					if(expDetails==string.Empty)
					{MessageBox.Show("Your data has been successfully posted.","MXCharts",MessageBoxButtons.OK);}
					else
					{MessageBox.Show("Please insert valid Narration and records." + expDetails.ToString(),"MXCharts",MessageBoxButtons.OK);}//"Please Insert Narration.","MXCharts",MessageBoxButtons.OK);}
				}
				else
				{
					if(expDetails==string.Empty)
					{MessageBox.Show("Total Credits and Debits do not match.","MXCharts",MessageBoxButtons.OK);}
					else
					{MessageBox.Show("Please ensure matching credit and debit totals, Possible problem in inserted records.","MXCharts",MessageBoxButtons.OK);}//{MessageBox.Show("Total Credits and Debits do not match.","MXCharts",MessageBoxButtons.OK);}
				}
			}
			else
			{
				MessageBox.Show("Please Insert Narration.","MXCharts",MessageBoxButtons.OK);
			}
		}
		
		private void FC_Debit_Leave(object sender, System.EventArgs e)
		{
			if(dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["FC_Debit"].ToString()!= "")
			{
				if(dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["FC_Debit"].ToString()!="0")
				{
					dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["LC_Debit"] = Decimal.Round(Convert.ToDecimal(dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["FC_Debit"].ToString()) * Convert.ToDecimal(dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["Rate"].ToString()),2).ToString();
					//dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["FC_Credit"] = 0;
					//dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["LC_Credit"] = 0;
				}
				else
				{
					dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["LC_Debit"] = Decimal.Round(Convert.ToDecimal(dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["FC_Debit"].ToString()) * Convert.ToDecimal(dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["Rate"].ToString()),2).ToString();
				}
			}
			else
			{
				dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["FC_Debit"] = "0";
			}
		}
		private void LC_Debit_TextChanged(object sender, System.EventArgs e)
		{
			string strFC_Debit = dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["FC_Debit"].ToString().Trim();
			string strLC_Debit = dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["LC_Debit"].ToString().Trim();
			string txtLC_Debit="";
			if((strFC_Debit=="0")&&(txtLC_Debit!="0"))
			{
				//MessageBox.Show("FC: " + strFC_Debit + " LC:" + strLC_Debit,"LC_Debit_TextChanged.1");
				//dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["FC_Credit"] = 0;
				//dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["LC_Credit"] = 0;
				//dg_Vouchers.Refresh();
			}
			else
			{
				//MessageBox.Show("FC: " + strFC_Debit + " LC:" + strLC_Debit,"LC_Debit_TextChanged.2");
				//dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["LC_Debit"] = 0;//(Convert.ToDecimal(dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["FC_Debit"].ToString()) * Convert.ToDecimal(dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["Rate"].ToString())).ToString();
				//dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["FC_Credit"] = " ";
				//dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["LC_Credit"] = " ";
			}
		}

		private void FC_Credit_Leave(object sender, System.EventArgs e)
		{
			if(dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["FC_Credit"].ToString() != "")
			{
				dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["LC_Credit"] = Decimal.Round(Convert.ToDecimal(dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["FC_Credit"].ToString()) * Convert.ToDecimal(dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["Rate"].ToString()),2).ToString();
			}
			else
			{
				dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["FC_Credit"] = "0";
			}
		}
		private void LC_Credit_Leave(object sender, System.EventArgs e)
		{
			if(dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["LC_Credit"].ToString() == "")
			{
				dsv.Tables["VoucherDetails"].Rows[dg_Vouchers.CurrentRowIndex]["LC_Credit"] = "0";
			}

		}
		public void dg_Vouchers_CurrentCellChanged(object sender, System.EventArgs e)
		{
			decimal n_TotalDebits=0;
			decimal n_TotalCredits=0;
			for(int n_Row =0; n_Row<dsv.Tables["VoucherDetails"].Rows.Count; n_Row++)
			{
				if(dsv.Tables["VoucherDetails"].Rows[n_Row]["LC_Debit"].ToString()!="")
				n_TotalDebits += Convert.ToDecimal(dsv.Tables["VoucherDetails"].Rows[n_Row]["LC_Debit"]);
				if(dsv.Tables["VoucherDetails"].Rows[n_Row]["LC_Credit"].ToString()!="")
				n_TotalCredits += Convert.ToDecimal(dsv.Tables["VoucherDetails"].Rows[n_Row]["LC_Credit"]);
			}
			lblNetDebit.Text = n_TotalDebits.ToString();
			lblNetCredit.Text = n_TotalCredits.ToString();
			if(lblNetCredit.Text.ToString() == lblNetDebit.Text.ToString())
			{
				IsValidGroup = true;
			}
			//DataView dv = dsv.Tables["VoucherDetails"].DefaultView;
			//if (dv[dg_Vouchers.CurrentRowIndex][((DataGrid)sender).CurrentCell.RowNumber]!="")
		}
		public void Cell_TextChanged(object sender, DataGridEnableEventArgs e)
		{
			//((DataGridEnableTextBoxColumn)sender)
			//if (e.Column == 7)
				//e.EnableValue = false;
			if(e.Value == "0")
			{
				//MessageBox.Show(e.Column.ToString() + "-Row:-" + e.Row.ToString() + "-Val:-" + e.Value.ToString(),"Cell_TextChanged.1");
				//e.EnableValue = false;
				//e.Value = "Disabled";
			}
			else
			{
				//MessageBox.Show(e.Column.ToString() + "-Row:-" + e.Row.ToString() + "-Val:-" + e.Value.ToString(),"Cell_TextChanged.2");
				//e.EnableValue = true;
				//e.Value = "1";
			}
		}
		
		#endregion Events.
		#region Facade.
		public DataTable GetAgentNames()
		{
			DataSet ds_AMaster = new DataSet("AgentMaster");
			string str_Query = "Select Name + ' [' + Number + '.1]' Name, id from AgentMaster union Select Name + ' [' + Number + '.2]' Name, id from AgentMaster";
			SqlDataAdapter da_AMaster = new SqlDataAdapter(str_Query,ARYFL_Conn);
			da_AMaster.SelectCommand = ARYFL_Conn.CreateCommand();
			da_AMaster.SelectCommand.CommandText = str_Query.ToString();
			da_AMaster.Fill(ds_AMaster,"AgentMaster");
			return ds_AMaster.Tables["AgentMaster"];
		}
		public DataRow GetRate(string strID)
		{
			DataSet ds_ARate = new DataSet("AgentRate");
			string str_Query = @"Select 1/berl.bidrate AS Rate, crl.code AS Code " +
				"From BankExchangeRateList berl, AgentMaster am, CountryList cl, currencylist crl " +
				"Where am.CountryId = cl.id " +
				"and berl.CurrencyId = cl.BaseCurrency " +
				"and crl.id = cl.basecurrency " +
				"and am.id = '" + strID +"'";
			SqlDataAdapter da_ARate = new SqlDataAdapter(str_Query,ARYFL_Conn);
			da_ARate.SelectCommand = ARYFL_Conn.CreateCommand();
			da_ARate.SelectCommand.CommandText = str_Query.ToString();
			da_ARate.Fill(ds_ARate,"AgentRate");
			return ds_ARate.Tables["AgentRate"].Rows[0];
		}
		public bool InsertVoucherNumber(string ConnectionString, SqlCommand CmdInsert)
		{
			try 
			{
				CmdInsert.Connection.Open();
				CmdInsert.ExecuteNonQuery();
			}
			catch (SqlException ex)
			{
				if (ex.Number == 2627)
				{
					CmdInsert.Connection.Close();
					throw ex;
				}
				else
				{
					CmdInsert.Connection.Close();
					throw ex;
				}
			}
			CmdInsert.Connection.Close();
			return true;
		}
		public int GetMaxVoucherNumber()
		{
			DataSet ds_VNumb = new DataSet("AgentAccountDetails");
			string str_Query = "Select max(VoucherNumber) from AgentAccountDetails";
			SqlCommand cmd_Select = new SqlCommand(str_Query, ARYFL_Conn);
			cmd_Select.CommandTimeout = 20;
			SqlDataAdapter da_VNumb = new SqlDataAdapter(str_Query,ARYFL_Conn);
			da_VNumb.SelectCommand = ARYFL_Conn.CreateCommand();
			da_VNumb.SelectCommand.CommandText = "Select max(VoucherNumber) from AgentAccountDetails";
			da_VNumb.Fill(ds_VNumb,"AgentAccountDetails");
			return Convert.ToInt32(ds_VNumb.Tables["AgentAccountDetails"].Rows[0][0].ToString())+1;
		}
		
		public bool AddMaster(SqlCommand CmdInsert)
		{
			try 
			{
				CmdInsert.Connection.Open();
				//CmdInsert.ExecuteNonQuery();
				n_MasterID = Convert.ToInt32(CmdInsert.ExecuteScalar());//ExecuteNonQuery();
				//n_MasterID = Convert.ToInt32(drMasterID[0]);
			}
			catch (SqlException ex)
			{
				if (ex.Number == 2627)
				{
					CmdInsert.Connection.Close();
					expMaster = ex.Number.ToString();
					//throw ex;
				}
				else
				{
					CmdInsert.Connection.Close();
					expMaster = ex.Number.ToString();
					throw ex;
				}
			}
			//MessageBox.Show(n_MasterID.ToString());
			if(expMaster==string.Empty)
			{
				for (int n_Row=0; n_Row<dsv.Tables["VoucherDetails"].Rows.Count;n_Row++)
				{
					dsv.Tables["VoucherDetails"].Rows[n_Row]["MasterID"] = n_MasterID.ToString();
					MasterIDsUpdated = true;
				}
			}
			CmdInsert.Connection.Close();
			return true;
		}
		private void EmbedComboColumn()
		{
			// Create a table style that will hold the new column style 
			// that we set and also tie it to our customer's table from our DB
			DataGridTableStyle tableStyle = new DataGridTableStyle();
			tableStyle.MappingName = "VoucherDetails";

			DataTable dt_Vouchers = dsv.Tables["VoucherDetails"];
			for(int i = 0; i < dt_Vouchers.Columns.Count; ++i)
			{
				if(i != 0)
				{
					DataGridEnableTextBoxColumn TextCol = new DataGridEnableTextBoxColumn(i, dt_Vouchers.Columns[i].ColumnName);
					TextCol.MappingName = dt_Vouchers.Columns[i].ColumnName;
					TextCol.CheckCellEnabled += new EnableCellEventHandler(Cell_TextChanged);
					#region DataGridEnableTextBoxColumn ColumnStyles.
					switch(dt_Vouchers.Columns[i].ColumnName)
					{
						case"AgentAccount":
						{
							TextCol.HeaderText = dt_Vouchers.Columns[i].ColumnName;
							//((DataGridEnableTextBoxColumn)TextCol).
							//((DataTable)dg_Vouchers.DataSource).Columns["AgentAccount"].ColumnMapping = MappingType.Hidden;
							//dsv.Tables["VoucherDetails"].Columns["AgentAccount"].ColumnMapping = MappingType.Hidden;
							TextCol.Width = 0;
							break;
						}
						case"MasterID":
						{
							TextCol.HeaderText = dt_Vouchers.Columns[i].ColumnName;
							TextCol.Width = 0;
							break;
						}
						case"Principal":
						{
							
							TextCol.HeaderText = dt_Vouchers.Columns[i].ColumnName;
							break;
						}
						case "FC_Debit":
						{
							TextCol.HeaderText = "FC";
							TextCol.TextBox.Leave += new EventHandler(FC_Debit_Leave);
							//TextCol.TextBox.TextChanged +=new EventHandler(FC_Debit_TextChanged);
							break;
						}
						case "LC_Debit":
						{
							TextCol.HeaderText = "LC";
							TextCol.TextBox.TextChanged += new EventHandler(LC_Debit_TextChanged);
							break;
						}
						case "FC_Credit":
						{
							TextCol.HeaderText = "FC";
							TextCol.TextBox.Leave += new EventHandler(FC_Credit_Leave);
							break;
						}
						case "LC_Credit":
						{
							TextCol.HeaderText = "LC";
							TextCol.TextBox.Leave += new EventHandler(LC_Credit_Leave);
							break;
						}
						default:
						{
							TextCol.HeaderText = dt_Vouchers.Columns[i].ColumnName;
							break;
						}
					}
					#endregion ColumnStyles.
					tableStyle.GridColumnStyles.Add(TextCol);
				}
				else
				{
					#region DataGridComboBoxColumn.
					DataGridComboBoxColumn ComboTextCol = new DataGridComboBoxColumn();
					//ComboTextCol.MappingName = "employeeID"; //must be from the grid table...
					ComboTextCol.MappingName = "AgentAccountID"; //must be from the grid table...
					ComboTextCol.HeaderText = "Agent Account";
					ComboTextCol.NullText = "";
					ComboTextCol.Width = 250;
					ComboTextCol.ColumnComboBox.DataSource = dsv.Tables["AgentMaster"].DefaultView;
					ComboTextCol.ColumnComboBox.SelectionChangeCommitted += new System.EventHandler(this.cmb_SelectedValueChanged);
					ComboTextCol.ColumnComboBox.DisplayMember = "Name";//use for string value in combo
					ComboTextCol.ColumnComboBox.ValueMember = "ID";//use for string value in combo
					tableStyle.PreferredRowHeight = ComboTextCol.ColumnComboBox.Height + 2;
					tableStyle.GridColumnStyles.Add(ComboTextCol);
					#endregion DataGridComboBoxColumn.
				}
			}
			dg_Vouchers.TableStyles.Clear();
			dg_Vouchers.TableStyles.Add(tableStyle);
			dg_Vouchers.DataSource = dt_Vouchers;
			((DataTable)dg_Vouchers.DataSource).DefaultView.AllowNew = true;
		}
		private void InsertBlankRow()
		{
			DataRow drvd = dsv.Tables["VoucherDetails"].NewRow();
			drvd["AgentAccountID"] = "";
			drvd["MasterID"] = "";
			drvd["Rate"] = "";
			drvd["CurrencyCode"] = "";
			drvd["Principal"] = "";
			drvd["FC_Debit"] = "";
			drvd["LC_Debit"] = "";
			drvd["FC_Credit"] = "";
			drvd["LC_Credit"] = "";
			dsv.Tables["VoucherDetails"].Rows.Add(drvd);
			dsv.Tables["VoucherDetails"].AcceptChanges();
		}

		#endregion Facade.
	}
}