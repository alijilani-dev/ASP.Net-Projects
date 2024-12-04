using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Microsoft.Msdn.Article.DataGridColumnStyles.DownloadManager {

	public class MainForm : System.Windows.Forms.Form {
		private System.ComponentModel.IContainer components;

		public MainForm() {
			InitializeComponent();
						
			BindControls();
			m_progressList = new ArrayList();
		
		}

		private ArrayList m_progressList;
		private System.Windows.Forms.DataGrid dataGrid;
		private System.Windows.Forms.Timer progressTimer;

		private void BindControls() {
			
			DataTable dmTable = new DataTable( "DownloadManager" );
			dmTable.Columns.Add( new DataColumn( "Item", typeof( string ) ) );
			dmTable.Columns.Add( new DataColumn( "LocationId", typeof( int ) ) );
			dmTable.Columns.Add( new DataColumn( "Progress", typeof( int ) ) );
			dmTable.Columns.Add( new DataColumn( "ButtonText", typeof( string ) ) );

			DataRow dr = dmTable.NewRow();
			dr[ "Item" ] = "The Day After Tomorrow";
			dr[ "LocationId" ] = 1;
			dr[ "Progress" ] = 0;
			dr[ "ButtonText" ] = "Start";

			dmTable.Rows.Add( dr );

			DataRow dr2 = dmTable.NewRow();
			dr2[ "Item" ] = "Shrek 2";
			dr2[ "LocationId" ] = 1;
			dr2[ "Progress" ] = 0;
			dr2[ "ButtonText" ] = "Start";

			dmTable.Rows.Add( dr2 );

			DataRow dr3 = dmTable.NewRow();
			dr3[ "Item" ] = "Dodgeball";
			dr3[ "LocationId" ] = 1;
			dr3[ "Progress" ] = 0;
			dr3[ "ButtonText" ] = "Start";

			dmTable.Rows.Add( dr3 );
		
			dataGrid.TableStyles.Add( CreateTableStyle() );
			dataGrid.DataSource = dmTable;			

		}

		private DataGridTableStyle CreateTableStyle() {

			DataGridTableStyle dst = new DataGridTableStyle();
			dst.MappingName = "DownloadManager";
			DataGridLabelColumn cs = new DataGridLabelColumn();
			cs.MappingName = "Item";
			cs.HeaderText = "Movie title";

			DataGridComboBoxColumn cb = new DataGridComboBoxColumn();
			cb.MappingName = "LocationId";
			cb.HeaderText = "Location";

			DataGridProgressBarColumn cs2 = new DataGridProgressBarColumn();
			cs2.MappingName = "Progress";
			cs2.HeaderText = "Progress";

			DataGridButtonColumn bc = new DataGridButtonColumn();
			bc.Click += new DataGridButtonColumn.ButtonColumnClickHandler(bc_Click);
			bc.MappingName = "ButtonText";

			dst.GridColumnStyles.Add( cs );
			dst.GridColumnStyles.Add( cs2 );
			dst.GridColumnStyles.Add( cb );
			dst.GridColumnStyles.Add( bc );

			return dst;

		}

		#region Main entry point
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new MainForm());
		}
		#endregion Main entry point

		#region Dispose

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion Dispose

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.dataGrid = new System.Windows.Forms.DataGrid();
			this.progressTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid
			// 
			this.dataGrid.AccessibleName = "DataGrid";
			this.dataGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
			this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid.DataMember = "";
			this.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid.Location = new System.Drawing.Point(16, 16);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.ParentRowsVisible = false;
			this.dataGrid.ReadOnly = true;
			this.dataGrid.Size = new System.Drawing.Size(584, 144);
			this.dataGrid.TabIndex = 6;
			// 
			// progressTimer
			// 
			this.progressTimer.Interval = 50;
			this.progressTimer.Tick += new System.EventHandler(this.preloaderTimer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(616, 181);
			this.Controls.Add(this.dataGrid);
			this.Name = "MainForm";
			this.Text = "Download Manager";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void bc_Click(ButtonColumnEventArgs e) {

			DataTable dt = ( DataTable ) dataGrid.DataSource;
			CellInfo ci = new CellInfo( e.Row, e.Column );

			if ( e.ButtonValue.Equals( "Stop" ) )	{

				m_progressList.Add( ci );
			
				if ( !progressTimer.Enabled ) {
					progressTimer.Start();
				}

			} else if ( e.ButtonValue.EndsWith( "Start" ) ) {

				if ( m_progressList.Contains( ci ) ) {
					m_progressList.Remove( ci );
				}
			
				if ( m_progressList.Count == 0 ) {
					progressTimer.Stop();
				}

			} else if ( e.ButtonValue.Equals( "Reset" ) ) {
				
				Rectangle progressCellBounds = dataGrid.GetCellBounds( e.Row, 1 );
				Rectangle buttonCellBounds = dataGrid.GetCellBounds( e.Row, e.Column );
				dt.Rows[ e.Row ][ "Progress" ] = 0;
				dt.Rows[ e.Row ][ "ButtonText" ] = "Start";

				dataGrid.Invalidate( buttonCellBounds );
				dataGrid.Invalidate( progressCellBounds );

			}


		}

		private void preloaderTimer_Tick(object sender, System.EventArgs e) {
		
			DataTable dt = ( DataTable ) dataGrid.DataSource;
			int row, column;
			int percentageValue;
			ArrayList cellsToRemove = new ArrayList();

			for ( int i=0; i < m_progressList.Count; i++ ) {
				
				row = ( ( CellInfo ) m_progressList[i] ).Row;
				column = ( ( CellInfo ) m_progressList[i] ).Column;
				percentageValue = ( int ) dt.Rows[ row ][ "Progress" ];

				if ( percentageValue < 100 ) {

					dt.Rows[ row ][ "Progress" ] = ++percentageValue;
					
					if ( percentageValue >= 100 ) {
						
						Rectangle buttonCellBounds = dataGrid.GetCellBounds( row, column );
						dt.Rows[ row ][ column ] = "Reset";
						dataGrid.Invalidate( buttonCellBounds );
						cellsToRemove.Add( m_progressList[i] );
					
					}

					Rectangle bounds = dataGrid.GetCellBounds( row, 1 );
					dataGrid.Invalidate( bounds );

				}

			}

			// remove items if their progress has been maxed
			foreach ( CellInfo ci in cellsToRemove ) {
				if ( m_progressList.Contains( ci ) ) {
					m_progressList.Remove( ci );
				}
			}

			// stop the timer if there are no items in the list
			if ( m_progressList.Count == 0 ) {
				progressTimer.Stop();
			}
			
		}
	
	}

	public struct CellInfo {
		
		private int m_row;
		private int m_column;

		public int Row {
			get { return m_row; }
		}

		public int Column {
			get { return m_column; }
		}

		public CellInfo( int row, int column ) {

			m_row = row;
			m_column = column;

		}

	}

}
