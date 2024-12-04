using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Diagnostics;


namespace MSDNMag.DataGridDemo
{
	// Derive class from DataGridTextBoxColumn
	public class DataGridComboBoxColumn : DataGridTextBoxColumn
	{
		// Hosted ComboBox control
		private ComboBox comboBox;
		private CurrencyManager cm;
		private int iCurrentRow;
		
		// Constructor - create combobox, register selection change event handler,
		// register lose focus event handler
		public DataGridComboBoxColumn()
		{
			this.cm = null;

			// Create ComboBox and force DropDownList style
			this.comboBox = new ComboBox();
			this.comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			
			// Add event handler for notification of when ComboBox loses focus
			this.comboBox.Leave += new EventHandler(comboBox_Leave);
		}
		
		// Property to provide access to ComboBox
		public ComboBox ComboBox
		{
			get { return comboBox; }
		}																				 
																									
		// On edit, add scroll event handler, and display combo box
		protected override void Edit(System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Rectangle bounds, bool readOnly, string instantText, bool cellIsVisible)
		{
			Debug.WriteLine(String.Format("Edit {0}", rowNum));
			base.Edit(source, rowNum, bounds, readOnly, instantText, cellIsVisible);

			if (!readOnly && cellIsVisible)
			{
				// Save current row in the datagrid and currency manager associated with
				// the data source for the datagrid
				this.iCurrentRow = rowNum;
				this.cm = source;
		
				// Add event handler for datagrid scroll notification
				this.DataGridTableStyle.DataGrid.Scroll += new EventHandler(DataGrid_Scroll);

				// Site the combo box control within the bounds of the current cell
				this.comboBox.Parent = this.TextBox.Parent;
				Rectangle rect = this.DataGridTableStyle.DataGrid.GetCurrentCellBounds();
				this.comboBox.Location = rect.Location;
				this.comboBox.Size = new Size(this.TextBox.Size.Width, this.comboBox.Size.Height);

				// Set combo box selection to given text
				this.comboBox.SelectedIndex = this.comboBox.FindStringExact(this.TextBox.Text);

				// Make the ComboBox visible and place on top text box control
				this.comboBox.Show();
				this.comboBox.BringToFront();
				this.comboBox.Focus();
			}
		}

		// Given a row, get the value member associated with a row.  Use the value
		// member to find the associated display member by iterating over bound datasource
		protected override object GetColumnValueAtRow(System.Windows.Forms.CurrencyManager source, int rowNum)
		{
			Debug.WriteLine(String.Format("GetColumnValueAtRow {0}", rowNum));
			// Given a row number in the datagrid, get the display member
			object obj =  base.GetColumnValueAtRow(source, rowNum);
			
			// Iterate through the datasource bound to the ColumnComboBox
			// Don't confuse this datasource with the datasource of the associated datagrid
			CurrencyManager cm = (CurrencyManager) 
				(this.DataGridTableStyle.DataGrid.BindingContext[this.comboBox.DataSource]);
			// Assumes the associated DataGrid is bound to a DataView, or DataTable that
			// implements a default DataView
			DataView dataview = ((DataView)cm.List);
								
			int i;

			for (i = 0; i < dataview.Count; i++)
			{
				if (obj.Equals(dataview[i][this.comboBox.ValueMember]))
					break;
			}
			
			if (i < dataview.Count)
				return dataview[i][this.comboBox.DisplayMember];
			
			return DBNull.Value;
		}

		// Given a row and a display member, iterating over bound datasource to find
		// the associated value member.  Set this value member.
		protected override void SetColumnValueAtRow(System.Windows.Forms.CurrencyManager source, int rowNum, object value)
		{
			Debug.WriteLine(String.Format("SetColumnValueAtRow {0} {1}", rowNum, value));
			object s = value;

			// Iterate through the datasource bound to the ColumnComboBox
			// Don't confuse this datasource with the datasource of the associated datagrid
			CurrencyManager cm = (CurrencyManager) 
				(this.DataGridTableStyle.DataGrid.BindingContext[this.comboBox.DataSource]);
			// Assumes the associated DataGrid is bound to a DataView, or DataTable that
			// implements a default DataView
			DataView dataview = ((DataView)cm.List);
			int i;

			for (i = 0; i < dataview.Count; i++)
			{
				if (s.Equals(dataview[i][this.comboBox.DisplayMember]))
					break;
			}

			// If set item was found return corresponding value, otherwise return DbNull.Value
			if(i < dataview.Count)
				s =  dataview[i][this.comboBox.ValueMember];
			else
				s = DBNull.Value;
			
			base.SetColumnValueAtRow(source, rowNum, s);
		}

		// On datagrid scroll, hide the combobox
		private void DataGrid_Scroll(object sender, EventArgs e)
		{
			Debug.WriteLine("Scroll");
			this.comboBox.Hide();
		}

		// On combo box losing focus, set the column value, hide the combo box,
		// and unregister scroll event handler
		private void comboBox_Leave(object sender, EventArgs e)
		{
			DataRowView rowView = (DataRowView) this.comboBox.SelectedItem;
			string s = (string) rowView.Row[this.comboBox.DisplayMember];
			Debug.WriteLine(String.Format("Leave: {0} {1}", this.comboBox.Text, s));

			SetColumnValueAtRow(this.cm, this.iCurrentRow, s);
			Invalidate();

			this.comboBox.Hide();
			this.DataGridTableStyle.DataGrid.Scroll -= new EventHandler(DataGrid_Scroll);			
		}
	}
}

