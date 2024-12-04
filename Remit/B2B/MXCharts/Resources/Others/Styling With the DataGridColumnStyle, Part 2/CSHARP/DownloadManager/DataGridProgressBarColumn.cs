

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace Microsoft.Msdn.Article.DataGridColumnStyles.DownloadManager {
	
	public class DataGridProgressBarColumn : DataGridColumnStyle {

		private Size m_controlSize;
		private bool m_stretchToFit;
		private DataGridColumnStylePadding m_padding;

		public DataGridProgressBarColumn() : base() {
			
			this.Padding = new DataGridColumnStylePadding( 4, 8, 4, 8 );
			this.ControlSize = new Size( 80, 10 );
			this.Width = this.GetPreferredSize( null, null ).Width;
			m_stretchToFit = true;

		}

		public Size ControlSize {
			get { return m_controlSize; }
			set { m_controlSize = value; }
		}
		
		public DataGridColumnStylePadding Padding {
			get { return m_padding; }
			set { m_padding = value; }
		}

		
		public bool StretchToFit {
			get { return m_stretchToFit; }
			set { m_stretchToFit = value; }
		}

		protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, CurrencyManager source, int rowNum, System.Drawing.Brush backBrush, System.Drawing.Brush foreBrush, bool alignToRight) {

			g.FillRectangle( backBrush, bounds );
			Rectangle controlBounds = this.GetControlBounds( bounds );

			if ( m_stretchToFit ) {
				controlBounds.Width = bounds.Width - ( this.Padding.Left + this.Padding.Right );
				controlBounds.X = bounds.X + this.Padding.Left;
			}

			Rectangle fillRect = new Rectangle( 
				controlBounds.X + 2, 
				controlBounds.Y + 2,
				controlBounds.Width - 3,
				controlBounds.Height - 3 );

			int maxWidth = fillRect.Width;
			double indexWidth = ( (  double ) fillRect.Width ) / 100; // determines the width of each index.
			fillRect.Width = ( int )( ( ( int ) this.GetColumnValueAtRow( source, rowNum ) ) * indexWidth );
			
			if ( fillRect.Width > maxWidth ) {
				fillRect.Width = maxWidth;
			}

			using ( Pen p = new Pen( new SolidBrush( Color.Black ) ) ) {
				g.DrawRectangle( p, controlBounds ); 
			}

			using ( SolidBrush sb = new SolidBrush( Color.Red ) ) {
				g.FillRectangle( sb, fillRect );
			}

		}

		private Rectangle GetControlBounds( Rectangle cellBounds ) {

			Rectangle controlBounds = new Rectangle( 
				cellBounds.X + this.Padding.Left, 
				cellBounds.Y + this.Padding.Top, 
				this.ControlSize.Width,
				this.ControlSize.Height );

			return controlBounds;

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