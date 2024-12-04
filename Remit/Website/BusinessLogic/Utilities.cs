using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace Evernet.MoneyExchange.BusinessLogic {
	public class Utilities {
		public static string ExportToCSV(DataSet ds) {
			// Create the CSV file to which grid data will be exported.
			StringBuilder sb = new StringBuilder(10000);
			StringWriter sw = new StringWriter(sb);

			// First we will write the headers.
			DataTable dt = ds.Tables[0];
			int iColCount = dt.Columns.Count;
			
			for(int i = 0; i < iColCount; i++) {
				sw.Write(dt.Columns[i]);
				if (i < iColCount - 1) {
					sw.Write(",");
				}
			}
			sw.Write(sw.NewLine);
			
			// Now write all the rows.
			foreach (DataRow dr in dt.Rows) {
				for (int i = 0; i < iColCount; i++) {
					if (!Convert.IsDBNull(dr[i])) {
						sw.Write("\""+dr[i].ToString()+"\"");
					}
					if ( i < iColCount - 1) {
						sw.Write(",");
					}
				}
				sw.Write(sw.NewLine);
			}
			sw.Close();

			return sb.ToString();
		}
	}
}
