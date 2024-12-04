/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:47:32 PM
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
	/// This class allows you to very easily retrieve a record from the [GlobalSettings] table.
	/// </summary>
	[Serializable()]
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[Evernet.MoneyExchange.DataClasses.OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:32", SqlObjectDependancyName="GlobalSettings", SqlObjectDependancyRevision=832)]
#endif
	public class Abstract_GlobalSettings {

		Params.spS_GlobalSettings Param;
		private bool CloseConnectionAfterUse = true;

		/// <summary>
		/// Create a new instance of the Abstract_GlobalSettings class.
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		public Abstract_GlobalSettings(string connectionString) {

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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'GlobalSettings'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "GlobalSettings", CurrentRevision, OriginalRevision, System.Environment.NewLine));
					}
				}
			}
#endif

			this.Param = new Params.spS_GlobalSettings(true);
			this.Param.SetUpConnection(connectionString);
		}

		/// <summary>
		/// Create a new instance of the Abstract_GlobalSettings class.
		/// </summary>
		/// <param name="sqlConnection">A valid System.Data.SqlClient.SqlConnection to the database.</param>
		public Abstract_GlobalSettings(System.Data.SqlClient.SqlConnection sqlConnection) {

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'GlobalSettings'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "GlobalSettings", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.Param = new Params.spS_GlobalSettings(true);
			this.Param.SetUpConnection(sqlConnection);
			CloseConnectionAfterUse = (this.Param.SqlConnection.State != System.Data.ConnectionState.Open);
		}

		/// <summary>
		/// Create a new instance of the Abstract_GlobalSettings class.
		/// </summary>
		/// <param name="sqlTransaction">A valid System.Data.SqlClient.SqlTransaction to the database.</param>
		public Abstract_GlobalSettings(System.Data.SqlClient.SqlTransaction sqlTransaction) {

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'GlobalSettings'";
				sqlCommand.Transaction = sqlTransaction;

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlTransaction.Connection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "GlobalSettings", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.Param = new Params.spS_GlobalSettings(true);
			this.Param.SetUpConnection(sqlTransaction);
		}

		private System.Data.SqlTypes.SqlByte col_Id;
		/// <summary>
		/// Returns the value of the Id column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;Id&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlByte Col_Id {

			get {

				return (this.col_Id);
			}
		}

		private System.Data.SqlTypes.SqlString col_Name;
		/// <summary>
		/// Returns the value of the Name column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_Name {

			get {

				return (this.col_Name);
			}
		}

		private System.Data.SqlTypes.SqlString col_AdministrativeEmail;
		/// <summary>
		/// Returns the value of the AdministrativeEmail column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_AdministrativeEmail {

			get {

				return (this.col_AdministrativeEmail);
			}
		}

		private System.Data.SqlTypes.SqlString col_TechnicalEmail;
		/// <summary>
		/// Returns the value of the TechnicalEmail column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_TechnicalEmail {

			get {

				return (this.col_TechnicalEmail);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_TransactionThreshold;
		/// <summary>
		/// Returns the value of the TransactionThreshold column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_TransactionThreshold {

			get {

				return (this.col_TransactionThreshold);
			}
		}

		private System.Data.SqlTypes.SqlString col_TransactionNumberFormat;
		/// <summary>
		/// Returns the value of the TransactionNumberFormat column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_TransactionNumberFormat {

			get {

				return (this.col_TransactionNumberFormat);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_TransactionThresholdUSD;
		/// <summary>
		/// Returns the value of the TransactionThresholdUSD column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_TransactionThresholdUSD {

			get {

				return (this.col_TransactionThresholdUSD);
			}
		}

		private System.Data.SqlTypes.SqlBoolean col_Active;
		/// <summary>
		/// Returns the value of the Active column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlBoolean Col_Active {

			get {

				return (this.col_Active);
			}
		}

		/// <summary>
		/// This method allows to clear all the properties previously loaded by a call to the Refresh method.
		/// </summary>
		public void Reset() {

			this.col_Id = System.Data.SqlTypes.SqlByte.Null;
			this.col_Name = System.Data.SqlTypes.SqlString.Null;
			this.col_AdministrativeEmail = System.Data.SqlTypes.SqlString.Null;
			this.col_TechnicalEmail = System.Data.SqlTypes.SqlString.Null;
			this.col_TransactionThreshold = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_TransactionNumberFormat = System.Data.SqlTypes.SqlString.Null;
			this.col_TransactionThresholdUSD = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_Active = System.Data.SqlTypes.SqlBoolean.Null;
		}

		/// <summary>
		/// Allows you to load a specific record of the [GlobalSettings] table.
		/// </summary>
		/// <param name="col_Id">Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;Id&quot; column.</param>
		public bool Refresh(System.Data.SqlTypes.SqlByte col_Id) {

			bool Status;
			Reset();

			if (col_Id.IsNull) {

				throw new ArgumentNullException("col_Id" , "The primary key 'col_Id' can not have a Null value!");
			}


			this.col_Id = col_Id;

			this.Param.Reset();

			this.Param.Param_Id = this.col_Id;

			System.Data.SqlClient.SqlDataReader DR;
			SPs.spS_GlobalSettings SP = new SPs.spS_GlobalSettings(false);

			if (SP.Execute(ref this.Param, out DR)) {

				Status = false;
				if (DR.Read()) {

					if (!DR.IsDBNull(SPs.spS_GlobalSettings.Resultset1.Fields.Column_Name.ColumnIndex)) {

						this.col_Name = DR.GetSqlString(SPs.spS_GlobalSettings.Resultset1.Fields.Column_Name.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_GlobalSettings.Resultset1.Fields.Column_AdministrativeEmail.ColumnIndex)) {

						this.col_AdministrativeEmail = DR.GetSqlString(SPs.spS_GlobalSettings.Resultset1.Fields.Column_AdministrativeEmail.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_GlobalSettings.Resultset1.Fields.Column_TechnicalEmail.ColumnIndex)) {

						this.col_TechnicalEmail = DR.GetSqlString(SPs.spS_GlobalSettings.Resultset1.Fields.Column_TechnicalEmail.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_GlobalSettings.Resultset1.Fields.Column_TransactionThreshold.ColumnIndex)) {

						this.col_TransactionThreshold = DR.GetSqlDecimal(SPs.spS_GlobalSettings.Resultset1.Fields.Column_TransactionThreshold.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_GlobalSettings.Resultset1.Fields.Column_TransactionNumberFormat.ColumnIndex)) {

						this.col_TransactionNumberFormat = DR.GetSqlString(SPs.spS_GlobalSettings.Resultset1.Fields.Column_TransactionNumberFormat.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_GlobalSettings.Resultset1.Fields.Column_TransactionThresholdUSD.ColumnIndex)) {

						this.col_TransactionThresholdUSD = DR.GetSqlDecimal(SPs.spS_GlobalSettings.Resultset1.Fields.Column_TransactionThresholdUSD.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_GlobalSettings.Resultset1.Fields.Column_Active.ColumnIndex)) {

						this.col_Active = DR.GetSqlBoolean(SPs.spS_GlobalSettings.Resultset1.Fields.Column_Active.ColumnIndex);
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

				throw new Evernet.MoneyExchange.DataClasses.CustomException(this.Param, "Evernet.MoneyExchange.AbstractClasses.Abstract_GlobalSettings", "Refresh");
			}
		}
	}
}
