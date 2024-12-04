using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DataGridValidation
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private DataSet myDataSet;

		int newCurrentRow;
		int newCurrentCol;
		int oldCurrentRow;
		int oldCurrentCol;
		private bool okToValidate;


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

			newCurrentRow = -1;
			newCurrentCol = -1;
			okToValidate = true;


			MakeDataSet();
			InitDataGrid();

			
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public void InitDataGrid()
		{
			dataGrid1.SetDataBinding(myDataSet, "Codes");
			AddCustomDataTableStyle();
		}

		private void AddCustomDataTableStyle()
		{
			DataGridTableStyle ts1 = new DataGridTableStyle();
			ts1.MappingName = "Codes";
			// Set other properties.
			ts1.AlternatingBackColor = Color.LightBlue;
			ts1.RowHeaderWidth = 20;
			
			// col 0
			DataGridTextBoxColumn TextCol = new DataGridTextBoxColumn();
			TextCol.MappingName = "BlueCode";
			TextCol.HeaderText = "< 400";
			TextCol.Width = 80;
			TextCol.NullText = "0";
			ts1.GridColumnStyles.Add(TextCol);

			// col 1
			TextCol = new DataGridTextBoxColumn();
			TextCol.MappingName = "GreenCode";
			TextCol.HeaderText = "< 600";
			TextCol.Width = 80;
			TextCol.NullText = "0";
				ts1.GridColumnStyles.Add(TextCol);

			// col 2
			TextCol = new DataGridTextBoxColumn();
			TextCol.MappingName = "RedCode";
			TextCol.HeaderText = "Any";
			TextCol.Width = 80;
			TextCol.NullText = "0";

			ts1.GridColumnStyles.Add(TextCol);

			dataGrid1.TableStyles.Clear();
			dataGrid1.TableStyles.Add(ts1);

		}

	private void MakeDataSet()
	{
		// Create a DataSet.
		myDataSet = new DataSet("CodesDataSet");
		      
		// Create code strings table
		DataTable tableStrings = new DataTable("Codes");
				
		// Create a columns, and add them to the first table.
		DataColumn colCodeStrings = new DataColumn("BlueCode");
		tableStrings.Columns.Add(colCodeStrings);

		colCodeStrings = new DataColumn("GreenCode");
		tableStrings.Columns.Add(colCodeStrings);

		colCodeStrings = new DataColumn("RedCode");
		tableStrings.Columns.Add(colCodeStrings);
			
		// Add the tables to the DataSet.
		myDataSet.Tables.Add(tableStrings);
				
		/* Populates the table*/
		DataRow newRow1;
		newRow1 = tableStrings.NewRow();
		newRow1["BlueCode"] = "100";
		newRow1["GreenCode"] = "100";
		newRow1["RedCode"] = "100";
		tableStrings.Rows.Add(newRow1);

		newRow1 = tableStrings.NewRow();
		newRow1["BlueCode"] = "200";
		newRow1["GreenCode"] = "200";
		newRow1["RedCode"] = "200";
		tableStrings.Rows.Add(newRow1);

		newRow1 = tableStrings.NewRow();
		newRow1["BlueCode"] = "300";
		newRow1["GreenCode"] = "300";
		newRow1["RedCode"] = "300";
		tableStrings.Rows.Add(newRow1);


		
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
			this.dataGrid1.Location = new System.Drawing.Point(40, 24);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(544, 240);
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.Handle_CurrentCellChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 293);
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

		// validation test depending on row, col
		// return true if valid value
		public bool IsValidValue(int row, int col, string newText)
		{
			bool returnValue = true;
			try
			{
				if(col == 0)
					returnValue = (int.Parse(newText) < 400);
				else if(col == 1)
					returnValue = (int.Parse(newText) < 600);
			}
			catch(Exception ex)
			{
				//likely Parse throws an error for invalid chars
				returnValue = false;
			}
			
			return returnValue;
		}


		private void Handle_CurrentCellChanged(object sender, System.EventArgs e)
		{
			newCurrentRow = dataGrid1.CurrentCell.RowNumber;
			newCurrentCol = dataGrid1.CurrentCell.ColumnNumber;
			string newText = dataGrid1[oldCurrentRow, oldCurrentCol].ToString();
			if( okToValidate && !IsValidValue(oldCurrentRow, oldCurrentCol, newText))
			{
				MessageBox.Show("Entry Error");
				okToValidate = false;
				dataGrid1.CurrentCell = new DataGridCell(oldCurrentRow, oldCurrentCol);
				okToValidate = true;

			}
			oldCurrentRow = newCurrentRow;
			oldCurrentCol = newCurrentCol;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//set to initial current cell
			oldCurrentRow = 0;
			oldCurrentCol = 0;;
			dataGrid1.CurrentCell = new DataGridCell(oldCurrentRow, oldCurrentCol);		
		}


	}
	
}
