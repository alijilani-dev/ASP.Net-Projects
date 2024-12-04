using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace DataGridUnboundCol
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(32, 24);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(568, 192);
			this.dataGrid1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(640, 245);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.dataGrid1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Set the connection and sql strings
			// assumes your mdb file is in your root
			string connString = @"Provider=Microsoft.JET.OLEDB.4.0;data source=C:\northwind.mdb";
			string sqlString = "SELECT * FROM customers";

			OleDbDataAdapter dataAdapter = null;
			DataSet _dataSet = null;

			try
			{
				// Connection object
				OleDbConnection connection = new OleDbConnection(connString);

				// Create data adapter object
				dataAdapter = new OleDbDataAdapter(sqlString, connection);
			
				// Create a dataset object and fill with data using data adapter's Fill method
				_dataSet = new DataSet();
				dataAdapter.Fill(_dataSet, "customers");
				connection.Close();
			}
			catch(Exception ex)
			{	
				MessageBox.Show("Problem with DB access-\n\n   connection: "
					+ connString + "\r\n\r\n            query: " + sqlString
					+ "\r\n\r\n\r\n" + ex.ToString());
				this.Close();
				return;
			}

			// Create a table style that will hold the new column style 
			// that we set and also tie it to our customer's table from our DB
			DataGridTableStyle tableStyle = new DataGridTableStyle();
			tableStyle.MappingName = "customers";

			// since the dataset has things like field name and number of columns,
			// we will use those to create new columnstyles for the columns in our DB table
			int numCols = _dataSet.Tables["customers"].Columns.Count;

			//add an extra column at the end of our customers table
			_dataSet.Tables["customers"].Columns.Add("Unbound");

			DataGridTextBoxColumn aColumnTextColumn ;
			for(int i = 0; i < numCols; ++i)
			{
				aColumnTextColumn = new DataGridTextBoxColumn();
				aColumnTextColumn.HeaderText = _dataSet.Tables["customers"].Columns[i].ColumnName;

				aColumnTextColumn.MappingName = _dataSet.Tables["customers"].Columns[i].ColumnName;
				tableStyle.GridColumnStyles.Add(aColumnTextColumn);

				//display the extra column after column 1.
				if( i == 1)
				{
					DataGridUnboundColumn unboundColStyle = new DataGridUnboundColumn();
					unboundColStyle.HeaderText = "UnBound";
					unboundColStyle.MappingName = "UnBound";
					tableStyle.GridColumnStyles.Add(unboundColStyle);				}
			}
			
			// make the dataGrid use our new tablestyle and bind it to our table
			dataGrid1.TableStyles.Clear();
			dataGrid1.TableStyles.Add(tableStyle);
			dataGrid1.DataSource = _dataSet.Tables["customers"];

		}
	}

	public class DataGridUnboundColumn : DataGridTextBoxColumn
	{
		protected override void Edit(System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Rectangle bounds, bool readOnly, string instantText, bool cellIsVisible) 
		{ 
			//do not allow the unbound cell to become active
			if(this.MappingName == "UnBound")
				return; 
 
			base.Edit(source, rowNum, bounds, readOnly, instantText, cellIsVisible); 
		} 
 

		protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Brush backBrush, System.Drawing.Brush foreBrush, bool alignToRight)
		{
		
			//clear the cell
			g.FillRectangle(new SolidBrush(Color.White), bounds);

			//compute & draw the value
			//string s = string.Format("{0} row", rowNum);
			// col 0 + 2 chars from col 1
			DataGrid parent = this.DataGridTableStyle.DataGrid;
			string s = parent[rowNum, 0].ToString() + ((parent[rowNum, 1].ToString())+ "  ").Substring(0,2);
			Font font = new Font("Arial", 8.25f);
			g.DrawString(s, font, new SolidBrush(Color.Black), bounds.X, bounds.Y);
			font.Dispose();
			
		}
	}
}
