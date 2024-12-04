
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace Microsoft.Msdn.Article.DataGridColumnStyles.DownloadManager {
	
	public class DataGridButtonColumn : DataGridColumnStyle {

		private Rectangle m_depressedBounds;
		private DataGridColumnStylePadding m_padding;
		private Size m_controlSize;

		public delegate void ButtonColumnClickHandler( ButtonColumnEventArgs e );
		public event ButtonColumnClickHandler Click;

		public DataGridButtonColumn() : base() {
			
			this.ControlSize = new Size( 80, 24 );
			this.Padding = new DataGridColumnStylePadding( 4, 8, 4, 8 );
			this.Width = this.GetPreferredSize( null, null ).Width;

		}

		public DataGridColumnStylePadding Padding {
			get { return m_padding; }
			set { m_padding = value; }
		}

		public virtual Size ControlSize {
			get { return m_controlSize; }
			set { m_controlSize = value; }
		}

		protected override void SetDataGridInColumn( DataGrid value ) {

			base.SetDataGridInColumn( value );
			
			// subscribe to DataGrid events
			this.DataGridTableStyle.DataGrid.MouseDown += new MouseEventHandler(DataGrid_MouseDown);
			this.DataGridTableStyle.DataGrid.MouseUp += new MouseEventHandler(DataGrid_MouseUp);
		
		}

		protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, CurrencyManager source, int rowNum, System.Drawing.Brush backBrush, System.Drawing.Brush foreBrush, bool alignToRight) {

			g.FillRectangle( backBrush, bounds );

			Rectangle controlBounds = this.GetControlBounds( bounds );
			bool drawFocusRectangle = true;

			Rectangle focusBounds = controlBounds;
			focusBounds.Inflate( -4, -4 );
			
			Rectangle fontBounds = focusBounds;
			fontBounds.Inflate( -3, -3 );

			ButtonState bs;

			if ( m_depressedBounds != Rectangle.Empty && m_depressedBounds == bounds ) {
				bs = ButtonState.Pushed;		
			} else {
				bs = ButtonState.Inactive;
				drawFocusRectangle = false;
			}

			ControlPaint.DrawButton( g, controlBounds, bs );

			if ( drawFocusRectangle ) {
				ControlPaint.DrawFocusRectangle( g, focusBounds, Color.Gray, Control.DefaultBackColor );			
			}
			
			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Center;
			sf.LineAlignment = StringAlignment.Center;
			sf.FormatFlags = StringFormatFlags.DirectionRightToLeft | StringFormatFlags.FitBlackBox;

			g.DrawString( 
				this.GetColumnValueAtRow( source, rowNum ).ToString(), 
				this.DataGridTableStyle.DataGrid.Font, 
				foreBrush, 
				fontBounds, 
				sf );

		}
		
		private void DataGrid_MouseDown( object sender, MouseEventArgs e ) {
			
			DataGrid.HitTestInfo hti = this.DataGridTableStyle.DataGrid.HitTest( e.X, e.Y );

			// since the MouseDown event is raised every time a mouse button is
			// clicked within the grid, ensure that the following conditions are met:
			//		1. the left button was pressed,
			//		2. the cursor is above a cell, and
			//		3. the cell belongs to this column style

			if ( e.Button == MouseButtons.Left && 
				hti.Type == DataGrid.HitTestType.Cell && 
				this.DataGridTableStyle.GridColumnStyles[ hti.Column ] is DataGridButtonColumn ) {
			
				// instead of implementing a whole bunch of logic to figure out 
				// if the cursor position falls within the area where the button 
				// is painted, a 1 x 1 rectangle is created to represent the 
				// cursor location. secondly, because the cellBounds
				// represents the bounds of the entire cell, we need to calculate 
				// the bounds of the drawn button. finally, with the help of the 
				// IntersectsWith method, we're able to determine if the two 
				// rectangles intersect.
				
				Rectangle cursorRect = new Rectangle( e.X, e.Y, 1, 1 );
				Rectangle cellBounds = this.DataGridTableStyle.DataGrid.GetCellBounds( hti.Row, hti.Column );

				Rectangle buttonBounds = this.GetControlBounds( cellBounds );
				
				if ( cursorRect.IntersectsWith( buttonBounds ) ) {
							
					m_depressedBounds = cellBounds;

					// since the DataGridColumnStyle's Invalidate method will
					// invalidate the entire column region (which is a waste), 
					// we instead use the reference to the datagrid made 
					// available through the DataGridTableStyle property to
					// invalidate a more specific region of the grid.

					this.DataGridTableStyle.DataGrid.Invalidate( cellBounds );

				}

			}

		}

		private void DataGrid_MouseUp( object sender, MouseEventArgs e ) {

			DataGrid.HitTestInfo hti = this.DataGridTableStyle.DataGrid.HitTest( e.X, e.Y );

			if ( !m_depressedBounds.Equals( Rectangle.Empty ) ) {
				
				Rectangle cellBounds = this.DataGridTableStyle.DataGrid.GetCellBounds( hti.Row, hti.Column );

				if ( m_depressedBounds.Equals( cellBounds ) ) {

					// cursor has been released within the same cell it was 
					// pressed. now, check and see if it was released within 
					// the button bounds

					Rectangle cursorRect = new Rectangle( e.X, e.Y, 1, 1 );

					Rectangle buttonBounds = this.GetControlBounds( cellBounds );

					if ( cursorRect.IntersectsWith( buttonBounds ) ) {

						object ds = this.DataGridTableStyle.DataGrid.DataSource;
						string dataMember = this.DataGridTableStyle.DataGrid.DataMember;
						CurrencyManager cm = ( CurrencyManager ) this.DataGridTableStyle.DataGrid.BindingContext[ ds, dataMember ];
						
						string buttonValue = ( string ) this.GetColumnValueAtRow( cm, hti.Row );
						
						if ( buttonValue.ToLower().Equals( "start" ) ) {
							buttonValue = "Stop";
						} else if ( buttonValue.ToLower().Equals( "stop" ) ) {
							buttonValue = "Start";
						}

						this.SetColumnValueAtRow( cm, hti.Row, buttonValue );

						// raise the Click event.
						if ( Click != null && Click.GetInvocationList().Length > 0 ) {
							Click( new ButtonColumnEventArgs( hti.Row, hti.Column, buttonValue ) );
						}

					}

				}
				
				m_depressedBounds = Rectangle.Empty;
				this.DataGridTableStyle.DataGrid.Invalidate( cellBounds );

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
