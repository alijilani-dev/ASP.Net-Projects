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
	/// This class allows you to very easily retrieve a record from the [CommissionSlabMaster] table.
	/// </summary>
	[Serializable()]
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[Evernet.MoneyExchange.DataClasses.OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:31", SqlObjectDependancyName="CommissionSlabMaster", SqlObjectDependancyRevision=1520)]
#endif
	public class Abstract_CommissionSlabMaster {

		Params.spS_CommissionSlabMaster Param;
		private bool CloseConnectionAfterUse = true;

		/// <summary>
		/// Create a new instance of the Abstract_CommissionSlabMaster class.
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		public Abstract_CommissionSlabMaster(string connectionString) {

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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'CommissionSlabMaster'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "CommissionSlabMaster", CurrentRevision, OriginalRevision, System.Environment.NewLine));
					}
				}
			}
#endif

			this.Param = new Params.spS_CommissionSlabMaster(true);
			this.Param.SetUpConnection(connectionString);
		}

		/// <summary>
		/// Create a new instance of the Abstract_CommissionSlabMaster class.
		/// </summary>
		/// <param name="sqlConnection">A valid System.Data.SqlClient.SqlConnection to the database.</param>
		public Abstract_CommissionSlabMaster(System.Data.SqlClient.SqlConnection sqlConnection) {

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'CommissionSlabMaster'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "CommissionSlabMaster", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.Param = new Params.spS_CommissionSlabMaster(true);
			this.Param.SetUpConnection(sqlConnection);
			CloseConnectionAfterUse = (this.Param.SqlConnection.State != System.Data.ConnectionState.Open);
		}

		/// <summary>
		/// Create a new instance of the Abstract_CommissionSlabMaster class.
		/// </summary>
		/// <param name="sqlTransaction">A valid System.Data.SqlClient.SqlTransaction to the database.</param>
		public Abstract_CommissionSlabMaster(System.Data.SqlClient.SqlTransaction sqlTransaction) {

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'CommissionSlabMaster'";
				sqlCommand.Transaction = sqlTransaction;

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlTransaction.Connection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "CommissionSlabMaster", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.Param = new Params.spS_CommissionSlabMaster(true);
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

		private System.Data.SqlTypes.SqlGuid col_PayInCountryId;
		/// <summary>
		/// Returns the value of the PayInCountryId column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_PayInCountryId {

			get {

				return (this.col_PayInCountryId);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_PayOutCountryId;
		/// <summary>
		/// Returns the value of the PayOutCountryId column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_PayOutCountryId {

			get {

				return (this.col_PayOutCountryId);
			}
		}

		private System.Data.SqlTypes.SqlString col_ModeOfPayment;
		/// <summary>
		/// Returns the value of the ModeOfPayment column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_ModeOfPayment {

			get {

				return (this.col_ModeOfPayment);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_StartRange;
		/// <summary>
		/// Returns the value of the StartRange column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_StartRange {

			get {

				return (this.col_StartRange);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_EndRange;
		/// <summary>
		/// Returns the value of the EndRange column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_EndRange {

			get {

				return (this.col_EndRange);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_BaseToBaseCommissionAmount;
		/// <summary>
		/// Returns the value of the BaseToBaseCommissionAmount column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_BaseToBaseCommissionAmount {

			get {

				return (this.col_BaseToBaseCommissionAmount);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_BaseToUSDCommissionAmount;
		/// <summary>
		/// Returns the value of the BaseToUSDCommissionAmount column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_BaseToUSDCommissionAmount {

			get {

				return (this.col_BaseToUSDCommissionAmount);
			}
		}

		private System.Data.SqlTypes.SqlString col_PayInCommissionType;
		/// <summary>
		/// Returns the value of the PayInCommissionType column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_PayInCommissionType {

			get {

				return (this.col_PayInCommissionType);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_PayInCommissionAmount;
		/// <summary>
		/// Returns the value of the PayInCommissionAmount column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_PayInCommissionAmount {

			get {

				return (this.col_PayInCommissionAmount);
			}
		}

		private System.Data.SqlTypes.SqlString col_PayOutCommissionType;
		/// <summary>
		/// Returns the value of the PayOutCommissionType column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_PayOutCommissionType {

			get {

				return (this.col_PayOutCommissionType);
			}
		}

		private System.Data.SqlTypes.SqlString col_PayOutCurrencyType;
		/// <summary>
		/// Returns the value of the PayOutCurrencyType column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_PayOutCurrencyType {

			get {

				return (this.col_PayOutCurrencyType);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_PayOutCommissionAmount;
		/// <summary>
		/// Returns the value of the PayOutCommissionAmount column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_PayOutCommissionAmount {

			get {

				return (this.col_PayOutCommissionAmount);
			}
		}

		/// <summary>
		/// This method allows to clear all the properties previously loaded by a call to the Refresh method.
		/// </summary>
		public void Reset() {

			this.col_Id = System.Data.SqlTypes.SqlGuid.Null;
			this.col_PayInCountryId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_PayOutCountryId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_ModeOfPayment = System.Data.SqlTypes.SqlString.Null;
			this.col_StartRange = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_EndRange = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_BaseToBaseCommissionAmount = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_BaseToUSDCommissionAmount = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_PayInCommissionType = System.Data.SqlTypes.SqlString.Null;
			this.col_PayInCommissionAmount = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_PayOutCommissionType = System.Data.SqlTypes.SqlString.Null;
			this.col_PayOutCurrencyType = System.Data.SqlTypes.SqlString.Null;
			this.col_PayOutCommissionAmount = System.Data.SqlTypes.SqlDecimal.Null;
		}

		/// <summary>
		/// Allows you to load a specific record of the [CommissionSlabMaster] table.
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
			SPs.spS_CommissionSlabMaster SP = new SPs.spS_CommissionSlabMaster(false);

			if (SP.Execute(ref this.Param, out DR)) {

				Status = false;
				if (DR.Read()) {

					if (!DR.IsDBNull(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayInCountryId.ColumnIndex)) {

						this.col_PayInCountryId = DR.GetSqlGuid(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayInCountryId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayOutCountryId.ColumnIndex)) {

						this.col_PayOutCountryId = DR.GetSqlGuid(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayOutCountryId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_ModeOfPayment.ColumnIndex)) {

						this.col_ModeOfPayment = DR.GetSqlString(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_ModeOfPayment.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_StartRange.ColumnIndex)) {

						this.col_StartRange = DR.GetSqlDecimal(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_StartRange.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_EndRange.ColumnIndex)) {

						this.col_EndRange = DR.GetSqlDecimal(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_EndRange.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_BaseToBaseCommissionAmount.ColumnIndex)) {

						this.col_BaseToBaseCommissionAmount = DR.GetSqlDecimal(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_BaseToBaseCommissionAmount.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_BaseToUSDCommissionAmount.ColumnIndex)) {

						this.col_BaseToUSDCommissionAmount = DR.GetSqlDecimal(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_BaseToUSDCommissionAmount.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayInCommissionType.ColumnIndex)) {

						this.col_PayInCommissionType = DR.GetSqlString(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayInCommissionType.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayInCommissionAmount.ColumnIndex)) {

						this.col_PayInCommissionAmount = DR.GetSqlDecimal(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayInCommissionAmount.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayOutCommissionType.ColumnIndex)) {

						this.col_PayOutCommissionType = DR.GetSqlString(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayOutCommissionType.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayOutCurrencyType.ColumnIndex)) {

						this.col_PayOutCurrencyType = DR.GetSqlString(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayOutCurrencyType.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayOutCommissionAmount.ColumnIndex)) {

						this.col_PayOutCommissionAmount = DR.GetSqlDecimal(SPs.spS_CommissionSlabMaster.Resultset1.Fields.Column_PayOutCommissionAmount.ColumnIndex);
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

				throw new Evernet.MoneyExchange.DataClasses.CustomException(this.Param, "Evernet.MoneyExchange.AbstractClasses.Abstract_CommissionSlabMaster", "Refresh");
			}
		}
	}
}
