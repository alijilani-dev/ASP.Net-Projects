/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:47:31 PM
			Generator name: EVERNET\kvsg
			Template last update: 10/13/2003 4:51:40 AM
			Template revision: 56177501

			SQL Server version: 08.00.0859
			Server: localhost
			Database: [mexchange]

	WARNING: This source is provided "AS IS" without warranty of any kind.
	The author disclaims all warranties, either express or implied, including
	the warranties of merchantability and fitness for a particular purpose.
	In no event shall the author or its suppliers be liable for any damages
	whatsoever including direct, indirect, incidental, consequential, loss of
	business profits or special damages, even if the author or its suppliers
	have been advised of the possibility of such damages.

	    More information: http://www.microsoft.com/france/msdn/olymars
	Latest interim build: http://www.olymars.net/latest.zip
	       Author's blog: http://blogs.msdn.com/olymars
*/

using System;
using Evernet.MoneyExchange.DataClasses;
using Params = Evernet.MoneyExchange.DataClasses.Parameters;
using SPs = Evernet.MoneyExchange.DataClasses.StoredProcedures;

namespace Evernet.MoneyExchange.AbstractClasses {

	/// <summary>
	/// This class allows you to very easily retrieve a record from the [AgencyDifferenceIncomeAccountDetails] table.
	/// </summary>
	[Serializable()]
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[Evernet.MoneyExchange.DataClasses.OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:31", SqlObjectDependancyName="AgencyDifferenceIncomeAccountDetails", SqlObjectDependancyRevision=640)]
#endif
	public class Abstract_AgencyDifferenceIncomeAccountDetails {

		Params.spS_AgencyDifferenceIncomeAccountDetails Param;
		private bool CloseConnectionAfterUse = true;

		/// <summary>
		/// Create a new instance of the Abstract_AgencyDifferenceIncomeAccountDetails class.
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		public Abstract_AgencyDifferenceIncomeAccountDetails(string connectionString) {

			if (connectionString == null) {

				throw new ArgumentNullException("connectionString", "connectionString can be an empty string but can not be null.");
			}

#if OLYMARS_DEBUG
			object olymarsDebugCheck = System.Configuration.ConfigurationSettings.AppSettings["OlymarsDebugCheck"];
			if (olymarsDebugCheck == null || (string)olymarsDebugCheck == "True") {

				string DebugConnectionString = connectionString;

				if (DebugConnectionString.Length == 0) {

					DebugConnectionString = Evernet.MoneyExchange.DataClasses.Information.GetConnectionStringFromConfigurationFile;
				}

				if (DebugConnectionString.Length == 0) {

					DebugConnectionString = Evernet.MoneyExchange.DataClasses.Information.GetConnectionStringFromRegistry;
				}

				if (DebugConnectionString.Length != 0) {

					System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(DebugConnectionString);

					sqlConnection.Open();

					System.Data.SqlClient.SqlCommand sqlCommand = sqlConnection.CreateCommand();

					sqlCommand.CommandType = System.Data.CommandType.Text;
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'AgencyDifferenceIncomeAccountDetails'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "AgencyDifferenceIncomeAccountDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
					}
				}
			}
#endif

			this.Param = new Params.spS_AgencyDifferenceIncomeAccountDetails(true);
			this.Param.SetUpConnection(connectionString);
		}

		/// <summary>
		/// Create a new instance of the Abstract_AgencyDifferenceIncomeAccountDetails class.
		/// </summary>
		/// <param name="sqlConnection">A valid System.Data.SqlClient.SqlConnection to the database.</param>
		public Abstract_AgencyDifferenceIncomeAccountDetails(System.Data.SqlClient.SqlConnection sqlConnection) {

			if (sqlConnection == null) {

				throw new ArgumentNullException("sqlConnection", "Invalid connection!");
			}

#if OLYMARS_DEBUG
			object olymarsDebugCheck = System.Configuration.ConfigurationSettings.AppSettings["OlymarsDebugCheck"];
			if (olymarsDebugCheck == null || (string)olymarsDebugCheck == "True") {

				bool NotAlreadyOpened = false;
				if (sqlConnection.State == System.Data.ConnectionState.Closed) {

					NotAlreadyOpened = true;
					sqlConnection.Open();
				}

				System.Data.SqlClient.SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlCommand.CommandType = System.Data.CommandType.Text;
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'AgencyDifferenceIncomeAccountDetails'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "AgencyDifferenceIncomeAccountDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.Param = new Params.spS_AgencyDifferenceIncomeAccountDetails(true);
			this.Param.SetUpConnection(sqlConnection);
			CloseConnectionAfterUse = (this.Param.SqlConnection.State != System.Data.ConnectionState.Open);
		}

		/// <summary>
		/// Create a new instance of the Abstract_AgencyDifferenceIncomeAccountDetails class.
		/// </summary>
		/// <param name="sqlTransaction">A valid System.Data.SqlClient.SqlTransaction to the database.</param>
		public Abstract_AgencyDifferenceIncomeAccountDetails(System.Data.SqlClient.SqlTransaction sqlTransaction) {

			if (sqlTransaction == null || sqlTransaction.Connection == null) {
				throw new ArgumentNullException("sqlTransaction", "Invalid transaction!");
			}

#if OLYMARS_DEBUG
			object olymarsDebugCheck = System.Configuration.ConfigurationSettings.AppSettings["OlymarsDebugCheck"];
			if (olymarsDebugCheck == null || (string)olymarsDebugCheck == "True") {

				bool NotAlreadyOpened = false;
				if (sqlTransaction.Connection.State == System.Data.ConnectionState.Closed) {

					NotAlreadyOpened = true;
					sqlTransaction.Connection.Open();
				}

				System.Data.SqlClient.SqlCommand sqlCommand = sqlTransaction.Connection.CreateCommand();

				sqlCommand.CommandType = System.Data.CommandType.Text;
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'AgencyDifferenceIncomeAccountDetails'";
				sqlCommand.Transaction = sqlTransaction;

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlTransaction.Connection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "AgencyDifferenceIncomeAccountDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.Param = new Params.spS_AgencyDifferenceIncomeAccountDetails(true);
			this.Param.SetUpConnection(sqlTransaction);
		}

		private System.Data.SqlTypes.SqlGuid col_Id;
		/// <summary>
		/// Returns the value of the Id column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;Id&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_Id {

			get {

				return (this.col_Id);
			}
		}

		private System.Data.SqlTypes.SqlDateTime col_CreditDateTime;
		/// <summary>
		/// Returns the value of the CreditDateTime column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;CreditDateTime&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDateTime Col_CreditDateTime {

			get {

				return (this.col_CreditDateTime);
			}
		}

		private System.Data.SqlTypes.SqlDateTime col_DebitDateTime;
		/// <summary>
		/// Returns the value of the DebitDateTime column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;DebitDateTime&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDateTime Col_DebitDateTime {

			get {

				return (this.col_DebitDateTime);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_TransactionId;
		/// <summary>
		/// Returns the value of the TransactionId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;TransactionId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_TransactionId {

			get {

				return (this.col_TransactionId);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_CreditLC;
		/// <summary>
		/// Returns the value of the CreditLC column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;CreditLC&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_CreditLC {

			get {

				return (this.col_CreditLC);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_CreditUSD;
		/// <summary>
		/// Returns the value of the CreditUSD column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;CreditUSD&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_CreditUSD {

			get {

				return (this.col_CreditUSD);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_DebitLC;
		/// <summary>
		/// Returns the value of the DebitLC column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;DebitLC&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_DebitLC {

			get {

				return (this.col_DebitLC);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_DebitUSD;
		/// <summary>
		/// Returns the value of the DebitUSD column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;DebitUSD&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_DebitUSD {

			get {

				return (this.col_DebitUSD);
			}
		}

		/// <summary>
		/// This method allows to clear all the properties previously loaded by a call to the Refresh method.
		/// </summary>
		public void Reset() {

			this.col_Id = System.Data.SqlTypes.SqlGuid.Null;
			this.col_CreditDateTime = System.Data.SqlTypes.SqlDateTime.Null;
			this.col_DebitDateTime = System.Data.SqlTypes.SqlDateTime.Null;
			this.col_TransactionId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_CreditLC = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_CreditUSD = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_DebitLC = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_DebitUSD = System.Data.SqlTypes.SqlDecimal.Null;
		}

		/// <summary>
		/// Allows you to load a specific record of the [AgencyDifferenceIncomeAccountDetails] table.
		/// </summary>
		/// <param name="col_Id">Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;Id&quot; column.</param>
		public bool Refresh(System.Data.SqlTypes.SqlGuid col_Id) {

			bool Status;
			Reset();

			if (col_Id.IsNull) {

				throw new ArgumentNullException("col_Id" , "The primary key 'col_Id' can not have a Null value!");
			}


			this.col_Id = col_Id;

			this.Param.Reset();

			this.Param.Param_Id = this.col_Id;

			System.Data.SqlClient.SqlDataReader DR;
			SPs.spS_AgencyDifferenceIncomeAccountDetails SP = new SPs.spS_AgencyDifferenceIncomeAccountDetails(false);

			if (SP.Execute(ref this.Param, out DR)) {

				Status = false;
				if (DR.Read()) {

					if (!DR.IsDBNull(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_CreditDateTime.ColumnIndex)) {

						this.col_CreditDateTime = DR.GetSqlDateTime(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_CreditDateTime.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_DebitDateTime.ColumnIndex)) {

						this.col_DebitDateTime = DR.GetSqlDateTime(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_DebitDateTime.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_TransactionId.ColumnIndex)) {

						this.col_TransactionId = DR.GetSqlGuid(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_TransactionId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_CreditLC.ColumnIndex)) {

						this.col_CreditLC = DR.GetSqlDecimal(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_CreditLC.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_CreditUSD.ColumnIndex)) {

						this.col_CreditUSD = DR.GetSqlDecimal(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_CreditUSD.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_DebitLC.ColumnIndex)) {

						this.col_DebitLC = DR.GetSqlDecimal(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_DebitLC.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_DebitUSD.ColumnIndex)) {

						this.col_DebitUSD = DR.GetSqlDecimal(SPs.spS_AgencyDifferenceIncomeAccountDetails.Resultset1.Fields.Column_DebitUSD.ColumnIndex);
					}

					Status = true;
				}

				if (DR != null && !DR.IsClosed) {

					DR.Close();
				}

				if (CloseConnectionAfterUse && SP.Connection != null && SP.Connection.State == System.Data.ConnectionState.Open) {

					SP.Connection.Close();
					SP.Connection.Dispose();
				}

				return(Status);
			}

			else {

				if (DR != null && !DR.IsClosed) {

					DR.Close();
				}

				if (CloseConnectionAfterUse && SP.Connection != null && SP.Connection.State == System.Data.ConnectionState.Open) {

					SP.Connection.Close();
					SP.Connection.Dispose();
				}

				throw new Evernet.MoneyExchange.DataClasses.CustomException(this.Param, "Evernet.MoneyExchange.AbstractClasses.Abstract_AgencyDifferenceIncomeAccountDetails", "Refresh");
			}
		}
	}
}
