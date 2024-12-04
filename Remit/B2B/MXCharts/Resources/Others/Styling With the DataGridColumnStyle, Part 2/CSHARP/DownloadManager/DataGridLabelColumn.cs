
using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Microsoft.Msdn.Article.DataGridColumnStyles.DownloadManager {

	public class DataGridLabelColumn : DataGridColumnStyle {
		
		private Size m_controlSize;
		private DataGridColumnStylePadding m_padding;

		public DataGridLabelColumn() : base() {

			this.Padding = new DataGridColumnStylePadding( 0 );
			this.ControlSize = new Size( 200, 24 );
			this.Width = this.GetPreferredSize( null, null ).Width;
		
		}
		
		public DataGridColumnStylePadding Padding {
			get { return m_padding; }
			set { m_padding = value; }
		}
	
		public Size ControlSize {
			get { return m_controlSize; }
			set { m_controlSize = value; }
		}

		protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, CurrencyManager source, int rowNum, System.Drawing.Brush backBrush, System.Drawing.Brush foreBrush, bool alignToRight) {
			
			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Far;
			sf.LineAlignment = StringAlignment.Center;
			sf.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox;
			g.FillRectangle( backBrush, bounds );
			
			g.DrawString( 
				this.GetColumnValueAtRow( source, rowNum ).ToString(), 
				this.DataGridTableStyle.DataGrid.Font, 
				foreBrush, 
				bounds, 
				sf );
		
		}

		#region The rest of the DataGridColumnStyle methods

		protected override void Abort(int rowNum) { /* no implementation */ }

		protected override bool Commit(CurrencyManager dataSource, int rowNum) { 
			return true; 
		}

		protected override void Edit(CurrencyManager source, int rowNum, Rectangle bounds, bool readOnly, string instantText, bool cellIsVisible) { /* no implementation */ }

		protected override int GetMinimumHeight() {
			return GetPreferredHeight( null, null );
		}

		protected override int GetPreferredHeight(System.Drawing.Graphics g, object value) {
			return this.ControlSize.Height + this.Padding.Top + this.Padding.Bottom;
		}

		protected override System.Drawing.Size GetPreferredSize(System.Drawing.Graphics g, object value) {
			
			int width = this.ControlSize.Width + this.Padding.Left + this.Padding.Right;
			int height = this.ControlSize.Height + this.Padding.Top + this.Padding.Bottom;

			return new Size( width, height );

		}

		protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, CurrencyManager source, int rowNum) {
			this.Paint( g, bounds, source, rowNum, false );
		}

		protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, CurrencyManager source, int rowNum, bool alignToRight) {
			this.Paint( g, bounds, source, rowNum, Brushes.White, Brushes.Black, false );
		}

		#endregion The rest of the DataGridColumnStyle methods

	}

}	