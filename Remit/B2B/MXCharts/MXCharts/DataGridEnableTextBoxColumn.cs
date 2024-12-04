using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MXCharts
{
	/// <summary>
	/// Summary description for DataGridEnableTextBoxColumn.
	/// </summary>
	public class DataGridEnableTextBoxColumn : DataGridTextBoxColumn
	{
		//in your handler, set the EnableValue to true or false, depending upon the row & col
		public event EnableCellEventHandler CheckCellEnabled;
		private int _col;
		private string _name;
		public DataGridEnableTextBoxColumn(int column, string name)
		{
			_col = column;
			_name = name;
		}

		protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Brush backBrush, System.Drawing.Brush foreBrush, bool alignToRight)
		{
			//can remove this if you don't want to vary the color of diabled cells
			//bool enabled = true;
			if(this.GetColumnValueAtRow(source, rowNum).ToString().Trim()=="0")
			{
				//DataGridEnableEventArgs e = new DataGridEnableEventArgs(rowNum, _col, false, "0");
				DataGridEnableEventArgs e = new DataGridEnableEventArgs(rowNum, _col, true, "1");
				CheckCellEnabled(this, e);
				backBrush = Brushes.LightGray;
				//enabled = false;
			}
			else
			{
				DataGridEnableEventArgs e = new DataGridEnableEventArgs(rowNum, _col, false, "1");
				CheckCellEnabled(this, e);
				//enabled = true;
			}
			base.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight);
		}

		protected override void Edit(System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Rectangle bounds, bool readOnly, string instantText, bool cellIsVisible)
		{
			bool enabled = true;
			/// Can use this.textbox.   or container. or source. or
			/// this.SetColumnValueAtRow(source,rowNum, ((object)"value").ToString());
			/// this._col.ToString(), this._name,
			if(this.GetColumnValueAtRow(source, rowNum).ToString().Trim()=="0")
			{
				
				//MessageBox.Show(instantText);
				//enabled = false;
				this.EndEdit();
			}
			else
			{
				enabled = true;
			}
			if(enabled)
				base.Edit(source, rowNum, bounds, readOnly, instantText, cellIsVisible);
		}
	}
	public delegate void EnableCellEventHandler(object sender, DataGridEnableEventArgs e);
	public class DataGridEnableEventArgs : EventArgs
	{
		private int _column;
		private int _row;
		private bool _enablevalue;
		private string _name;
		private string _value;

		public DataGridEnableEventArgs(int row, int col, bool enabval, string val)
		{
			_row = row;
			_column = col;
			_enablevalue = enabval;
			_value = val;
		}

		public int Column
		{
			get{ return _column;}
			set{ _column = value;}
		}
		public string Name
		{
			get{ return _name;}
			set{ _name = value;}
		}

		public int Row
		{
			get{ return _row;}
			set{ _row = value;}
		}
		public bool EnableValue
		{
			get{ return _enablevalue;}
			set{ _enablevalue = value;}
		}
		public string Value
		{
			get{ return _value;}
			set{ _value = value;}
		}
	}
}
