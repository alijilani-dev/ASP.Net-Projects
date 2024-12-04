
using System;
using System.Windows.Forms;

namespace Microsoft.Msdn.Article.DataGridColumnStyles.DownloadManager {

	public class ButtonColumnEventArgs : EventArgs {
		
		private int m_rowNum;
		private int m_columnNum;
		private string m_buttonValue;

		public int Column {
			get { return m_columnNum; }
		}

		public int Row {
			get { return m_rowNum; }
		}

		public string ButtonValue {
			get { return m_buttonValue; }
		}


		public ButtonColumnEventArgs( int rowNum, int columnNum, string buttonValue ) : base() {
			
			m_rowNum = rowNum;
			m_columnNum = columnNum;
			m_buttonValue = buttonValue;

		}

	}

}