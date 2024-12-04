using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace MXCharts
{
	public class DataGridComboBox:ComboBox
	{
		public DataGridComboBox(DataTable DataSource, string DisplayMember , string ValueMember)
		{
			base.DataSource  = DataSource;
			base.DisplayMember = DisplayMember;
			base.ValueMember = ValueMember;
			base.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		public bool isInEditOrNavigateMode = true;
	}

	public class DataGridComboBoxColumn:DataGridColumnStyle
	{
		//
		// Creates a combo box column on a data grid
		// all cells in the column have the same data source


		//
		// UI constants    
		//
		private int xMargin = 2;
		private int yMargin = 1;
		public DataGridComboBox Combo;
		private string m_displayMember;
		private string m_valueMember;

		private CurrencyManager m_currencyManager;
		private int m_rowNum;
		//
		// Used to track editing state
		//

		private string OldVal=new string(string.Empty.ToCharArray());
		private bool InEdit= false;
		//
		// Create a new column - DisplayMember, ValueMember
		// Passed by ordinal 

		public DataGridComboBoxColumn(DataTable DataSource, int DisplayMember,int ValueMember)
		{
			System.Diagnostics.Debug.WriteLine("DataGridComboBoxColumn()");
			m_displayMember = DataSource.Columns[DisplayMember].ToString();
			m_valueMember = DataSource.Columns[ValueMember].ToString();
			Combo = new DataGridComboBox(DataSource, m_displayMember, m_valueMember);
			Combo.Visible=false;
			Combo.SelectedIndexChanged +=new System.EventHandler(Combo_SelectedIndexChanged);
		}

		//
		// Create a new column - DisplayMember, ValueMember passed by string
		//
		public DataGridComboBoxColumn(DataTable DataSource,string DisplayMember,string ValueMember)
		{
			System.Diagnostics.Debug.WriteLine("DataGridComboBoxColumn()");
			Combo = new DataGridComboBox(DataSource, DisplayMember, ValueMember);
			Combo.Visible = false;
			Combo.SelectedIndexChanged +=new System.EventHandler(Combo_SelectedIndexChanged);
		}	
		//------------------------------------------------------
		// Methods overridden from DataGridColumnStyle
		//------------------------------------------------------
		//
		// Abort Changes
		//
		protected override void Abort(int RowNum)
		{
			System.Diagnostics.Debug.WriteLine("Abort()");
			RollBack();
			HideComboBox();
			EndEdit();
		}
		//
		// Commit Changes
		//
		protected override bool Commit(CurrencyManager cm,int RowNum)
		{
			HideComboBox();
			if(!InEdit)
			{
				return true;
			}
			try
			{
				object Value = Combo.SelectedValue;
				if(NullText.Equals(Value))
				{
					Value = System.Convert.DBNull; 
				}
				System.Diagnostics.Debug.WriteLine("Commit()" + Value);
				SetColumnValueAtRow(cm, RowNum, Value);
			}
			catch
			{
				RollBack();
				return false;	
			}
			this.EndEdit();
			return true;
		}

		//
		// Remove focus
		//
		protected override void ConcedeFocus()
		{
			System.Diagnostics.Debug.WriteLine("ConcedeFocus()");
			Combo.Visible=false;
		}

		//
		// Edit Grid
		//
		protected override void Edit(CurrencyManager cm ,int RowNum, Rectangle Bounds, bool ReadOnly,string InstantText, bool CellIsVisible)
		{
			m_currencyManager = cm;
			m_rowNum = RowNum;

			Combo.Text = string.Empty;
			Rectangle OriginalBounds = Bounds;
			OldVal = Combo.Text;
	
			if(CellIsVisible)
			{
				Bounds.Offset(xMargin, yMargin);
				Bounds.Width -= xMargin * 2;
				Bounds.Height -= yMargin;
				Combo.Bounds = Bounds;
				Combo.Visible = true;
			}
			else
			{
				Combo.Bounds = OriginalBounds;
				Combo.Visible = false;
			}
			
			try 
			{
				Combo.SelectedValue = GetValue(GetColumnValueAtRow(cm, RowNum));
				System.Diagnostics.Debug.WriteLine("-------------Edit();--------------{" + Combo.SelectedValue.ToString() + "}");
			} 
			catch 
			{
				Combo.SelectedIndex = -1;
			}
			
				if(InstantText!=null)
				{
					try {
						Combo.SelectedText = InstantText;
					} catch (System.Exception ex) {
						System.Diagnostics.Debug.WriteLine("-------------Edit(InstantText);--------------{" + InstantText.ToString() + "(" + ex.Message + ")}");
						//MessageBox.Show(ex.ToString());
					}
				}
				
			Combo.RightToLeft = this.DataGridTableStyle.DataGrid.RightToLeft;
			
			if(InstantText==null)
			{
				Combo.SelectAll();
				
				// Pre-selects an item in the combo when user tries to add
				// a new record by moving the columns using tab.

				// Combo.SelectedIndex = 0;
			}
			else
			{
				int End = Combo.Text.Length;
				Combo.Select(End, 0);
			}
			if(Combo.Visible)
			{
				DataGridTableStyle.DataGrid.Invalidate(OriginalBounds);
			}

			InEdit = true;
		}

		protected override int GetMinimumHeight()
		{
			System.Diagnostics.Debug.WriteLine("GetMinimumHeight()");
			//
			// Set the minimum height to the height of the combobox
			//
			return Combo.PreferredHeight + yMargin;
		}

		protected override int GetPreferredHeight(Graphics g ,object Value)
		{
			System.Diagnostics.Debug.WriteLine("GetPreferredHeight()");
			int NewLineIndex  = 0;
			int NewLines = 0;
			string ValueString = this.GetText(Value);
			do
			{
				NewLineIndex = ValueString.IndexOf("r\n", NewLineIndex + 1);
				NewLines += 1;
			}while(NewLineIndex != -1);
			return FontHeight * NewLines + yMargin;
		}

		protected override Size GetPreferredSize(Graphics g, object Value)
		{
			System.Diagnostics.Debug.WriteLine("GetPreferredSize()");
			Size Extents = Size.Ceiling(g.MeasureString(GetText(Value), this.DataGridTableStyle.DataGrid.Font));
			Extents.Width += xMargin * 2 + DataGridTableGridLineWidth ;
			Extents.Height += yMargin;
			return Extents;
		}

		protected override void Paint(Graphics g,Rectangle Bounds,CurrencyManager Source,int RowNum)
		{
			System.Diagnostics.Debug.WriteLine("Paint 1");
			Paint(g, Bounds, Source, RowNum, false);
		}

		protected override void Paint(Graphics g,Rectangle Bounds,CurrencyManager Source,int RowNum,bool AlignToRight)
		{
			System.Diagnostics.Debug.WriteLine("Paint 2{" + GetColumnValueAtRow(Source, RowNum) + "}");
			string Text = Combo.Text;//GetText(GetColumnValueAtRow(Source, RowNum));
			PaintText(g, Bounds, Text, AlignToRight);
		}

		protected override void Paint(Graphics g,Rectangle Bounds,CurrencyManager Source,int RowNum,Brush BackBrush ,Brush ForeBrush ,bool AlignToRight)
		{
			//System.Diagnostics.Debug.WriteLine("Paint 3");
			//if(GetEntryType()=="P")
			//{
				string Text = GetText(GetColumnValueAtRow(Source, RowNum));
			//}
			PaintText(g, Bounds, Text, BackBrush, ForeBrush, AlignToRight);
		}

		protected override void SetDataGridInColumn(DataGrid Value)
		{
			System.Diagnostics.Debug.WriteLine("SetDataGridInColumn()");
			base.SetDataGridInColumn(Value);
			if(Combo.Parent!=Value)
			{
				if(Combo.Parent!=null)
				{
					Combo.Parent.Controls.Remove(Combo);
				}
			}
			if(Value!=null) 
			{
				Value.Controls.Add(Combo);
			}
		}

		protected override void UpdateUI(CurrencyManager Source,int RowNum, string InstantText)
		{
			System.Diagnostics.Debug.WriteLine("UpdateUI()");
			Combo.Text = GetText(GetColumnValueAtRow(Source, RowNum));
			if(InstantText!=null)
			{
				Combo.Text = InstantText;
			}
		}
															 
		//----------------------------------------------------------------------
		// Helper Methods 
		//----------------------------------------------------------------------
		private int DataGridTableGridLineWidth
		{
			get
			{
				if(this.DataGridTableStyle.GridLineStyle == DataGridLineStyle.Solid) 
				{ 
					return 1;
				}
				else
				{
					return 0;
				}
			}
		}
		public void EndEdit()
		{
			InEdit = false;
			Invalidate();
		}
		private string GetText(object Value)
		{
			System.Diagnostics.Debug.WriteLine("GetText()");
			if(Value==System.DBNull.Value)
			{
				return NullText;
			}
			if(Value!=null)
			{
				DataTable dt = (DataTable) Combo.DataSource;
				DataRow[] drs = dt.Select(Combo.ValueMember + " like '" + Value.ToString() + "%'");
				//if(GetEntryType()=="P")
                    return drs[0][Combo.DisplayMember].ToString();
				//else if(GetEntryType()=="C")
				//	return drs[1][Combo.DisplayMember].ToString();
				//else
				//	return string.Empty;
				//DataTable dt = (DataTable) Combo.DataSource;
				//DataRow[] drs = dt.Select(Combo.ValueMember + " = '" + Value.ToString() + "'");
				//Trace.WriteLine("-------------GetText();--------------" + drs[1][Combo.DisplayMember].ToString());
				//return drs[0][Combo.DisplayMember].ToString();
				//return Value.ToString();
			}
			else
			{
				return string.Empty;
			}
		}
		private string GetEntryType()
		{
			if((Combo.SelectedValue) != System.DBNull.Value)
			{
				string str_Text = (Combo.GetItemText(Combo.Text)).ToString().Trim();
				string strdelims = "[]";
				char[] delimiter = strdelims.ToCharArray();
				string[] split = null;
				split=str_Text.Split(delimiter,5);
				delimiter = (".").ToCharArray();
				string[] n_Flag = split[1].Split(delimiter,5);
				if((n_Flag[1]=="1"))
				{Trace.WriteLine("-------------GetEntryType();--------------{P-Text}");
					return "P";}
				else
				{Trace.WriteLine("-------------GetEntryType();--------------{C-Text}");
					return "C";}
			}
			/*else
			{
				string str_Text = (Combo.GetItemText(Combo.SelectedItem)).ToString().Trim();
				string strdelims = "[]";
				char[] delimiter = strdelims.ToCharArray();
				string[] split = null;
				split=str_Text.Split(delimiter,5);
				delimiter = (".").ToCharArray();
				string[] n_Flag = split[1].Split(delimiter,5);
				if((n_Flag[1]=="1"))
				{
					Trace.WriteLine("-------------GetEntryType();--------------{P-Old}");
					return "P";}
				else
				{
					Trace.WriteLine("-------------GetEntryType();--------------{C-Old}");
					return "C";}
			}*/
			return NullText;
		}

		private string GetValue(object Value) 
		{
			System.Diagnostics.Debug.WriteLine("GetValue()");
			if(Value==System.DBNull.Value) 
			{
				return NullText;
			}
			if(Value!=null) 
			{
				return Value.ToString();
			}
			else 
			{
				return string.Empty;
			}
		}

		private void HideComboBox()
		{
			System.Diagnostics.Debug.WriteLine("HideComboBox()");
			if(Combo.Focused)
			{
				this.DataGridTableStyle.DataGrid.Focus();
			}
			Combo.Visible = false;
		}

		private void RollBack()
		{
			System.Diagnostics.Debug.WriteLine("RollBack()");
			Combo.Text = OldVal;
		}

		private void PaintText(Graphics g ,Rectangle Bounds,string Text,bool AlignToRight)
		{
			System.Diagnostics.Debug.WriteLine("PaintText(1)");
			Brush BackBrush = new SolidBrush(this.DataGridTableStyle.BackColor);
			Brush ForeBrush= new SolidBrush(this.DataGridTableStyle.ForeColor);
			PaintText(g, Bounds, Text, BackBrush, ForeBrush, AlignToRight);
		}
		private void PaintText(Graphics g , Rectangle TextBounds, string Text, Brush BackBrush,Brush ForeBrush,bool AlignToRight)
		{	
			System.Diagnostics.Debug.WriteLine("PaintText(2){" + Text + "}");
			Rectangle Rect = TextBounds;
			RectangleF RectF  = Rect; 
			StringFormat Format = new StringFormat();
			if(AlignToRight)
			{
				Format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
			}
			switch(this.Alignment)
			{
				case HorizontalAlignment.Left:
					Format.Alignment = StringAlignment.Near;
					break;
				case HorizontalAlignment.Right:
					Format.Alignment = StringAlignment.Far;
					break;
				case HorizontalAlignment.Center:
					Format.Alignment = StringAlignment.Center;
					break;
			}
			Format.FormatFlags =Format.FormatFlags;
			Format.FormatFlags =StringFormatFlags.NoWrap;
			g.FillRectangle(BackBrush, Rect);
			Rect.Offset(0, yMargin);
			Rect.Height -= yMargin;
			g.DrawString(Text, this.DataGridTableStyle.DataGrid.Font, ForeBrush, RectF, Format);
			Format.Dispose();
		}

		private void Combo_SelectedIndexChanged(object sender, System.EventArgs e) 
		{
			System.Diagnostics.Debug.WriteLine("Combo_SelectedIndexChanged()");
			if(m_currencyManager != null) 
			{
				ComboBox cb = (ComboBox) sender;
				if(cb.SelectedValue != null) 
				{
					SetColumnValueAtRow(m_currencyManager, m_rowNum, cb.SelectedValue);
					ColumnStartedEditing((Control) sender);
				}
			}
		}
	}
}