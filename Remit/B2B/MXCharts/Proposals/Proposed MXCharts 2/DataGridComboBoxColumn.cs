using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MXCharts
{
	public class DataGridComboBoxColumn : DataGridTextBoxColumn
	{
		public NoKeyUpCombo ColumnComboBox;
		private System.Windows.Forms.CurrencyManager _source;
		private int _rowNum;
		private bool _isEditing;
		public static int _RowCount;
		
		public DataGridComboBoxColumn() : base()
		{
			_source = null;
			_isEditing = false;
			_RowCount = -1;
			ColumnComboBox = new NoKeyUpCombo();
			ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			ColumnComboBox.Leave += new EventHandler(LeaveComboBox);
			ColumnComboBox.SelectionChangeCommitted += new EventHandler(ComboStartEditing);
		}
		private void ComboStartEditing(object sender, EventArgs e)
		{
			_isEditing = true;
			base.ColumnStartedEditing((Control) sender);
		}
		private void HandleScroll(object sender, EventArgs e)
		{
			if(ColumnComboBox.Visible)
				ColumnComboBox.Hide();

		}		
		private void LeaveComboBox(object sender, EventArgs e)
		{
			//((DataGridTextBoxColumn)sender).TextBox.Text = ColumnComboBox.Text;
			if(_isEditing)
			{
				SetColumnValueAtRow(_source, _rowNum, ColumnComboBox.Text);
				_isEditing = false;
				Invalidate();
			}
			ColumnComboBox.Hide();
			//ColumnComboBox.Parent.Text = ColumnComboBox.SelectedText;
			//this.TextBox.Text = ColumnComboBox.SelectedText;
			this.DataGridTableStyle.DataGrid.Scroll -= new EventHandler(HandleScroll);
		}
		///
		//protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle r, System.Windows.Forms.CurrencyManager cm, int n)
		//{
			
		//}
		///
		protected override void Edit(System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Rectangle bounds, bool readOnly, string instantText, bool cellIsVisible)
		{
			

			base.Edit(source,rowNum, bounds, readOnly, instantText , cellIsVisible);

			_rowNum = rowNum;
			_source = source;
		
			ColumnComboBox.Parent = this.TextBox.Parent;
			ColumnComboBox.Location = this.TextBox.Location;
			ColumnComboBox.Size = new Size(this.TextBox.Size.Width, ColumnComboBox.Size.Height);
			ColumnComboBox.SelectedIndex = ColumnComboBox.FindStringExact(this.TextBox.Text);
			ColumnComboBox.Text =  this.TextBox.Text;
			this.TextBox.Visible = false;
			//this.TextBox.Visible = true;
			ColumnComboBox.Visible = true;
			this.DataGridTableStyle.DataGrid.Scroll += new EventHandler(HandleScroll);
			
			ColumnComboBox.BringToFront();
			ColumnComboBox.Focus();	
		}
		protected override bool Commit(System.Windows.Forms.CurrencyManager dataSource, int rowNum)
		{
			if(_isEditing)
			{
				_isEditing = false;
				SetColumnValueAtRow(dataSource, rowNum, ColumnComboBox.Text);
			}
			return true;
		}
		protected override void ConcedeFocus()
		{
			Console.WriteLine("ConcedeFocus");
			base.ConcedeFocus();
		}
		protected override object GetColumnValueAtRow(System.Windows.Forms.CurrencyManager source, int rowNum)
		{

			object s =  base.GetColumnValueAtRow(source, rowNum);
			DataView dv = (DataView)this.ColumnComboBox.DataSource;
			int rowCount = dv.Count;
			int i = 0;

			//if things are slow, you could order your dataview
			//& use binary search instead of this linear one
			while (i < rowCount)
			{
				if( s.Equals( dv[i][this.ColumnComboBox.ValueMember]))
					break;
				++i;
			}
			
			if(i < rowCount)
				return dv[i][this.ColumnComboBox.DisplayMember];
			
			return DBNull.Value;
		}
		protected override void SetColumnValueAtRow(System.Windows.Forms.CurrencyManager source, int rowNum, object value)
		{
			object s = value;

			DataView dv = (DataView)this.ColumnComboBox.DataSource;
			int rowCount = dv.Count;
			int i = 0;

			//if things are slow, you could order your dataview
			//& use binary search instead of this linear one
			while (i < rowCount)
			{
				if( s.Equals( dv[i][this.ColumnComboBox.DisplayMember]))
					break;
				++i;
			}
			if(i < rowCount)
				s =  dv[i][this.ColumnComboBox.ValueMember];
			else
				s = DBNull.Value;
			base.SetColumnValueAtRow(source, rowNum, s);

		}
	}

	public class NoKeyUpCombo : ComboBox
	{
		private const int WM_KEYUP = 0x101;

		protected override void WndProc(ref System.Windows.Forms.Message m)
		{
			if(m.Msg == WM_KEYUP)
			{
				//ignore keyup to avoid problem with tabbing & dropdownlist;
				return;
			}
			base.WndProc(ref m);
		}
	}

}
