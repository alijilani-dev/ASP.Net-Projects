﻿/*
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
	/// This class allows you to very easily retrieve a record from the [AgentCommissionIncomeAccount] table.
	/// </summary>
	[Serializable()]
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[Evernet.MoneyExchange.DataClasses.OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:31", SqlObjectDependancyName="AgentCommissionIncomeAccount", SqlObjectDependancyRevision=864)]
#endif
	public class Abstract_AgentCommissionIncomeAccount {

		Params.spS_AgentCommissionIncomeAccount Param;
		private bool CloseConnectionAfterUse = true;

		/// <summary>
		/// Create a new instance of the Abstract_AgentCommissionIncomeAccount class.
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		public Abstract_AgentCommissionIncomeAccount(string connectionString) {

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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'AgentCommissionIncomeAccount'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "AgentCommissionIncomeAccount", CurrentRevision, OriginalRevision, System.Environment.NewLine));
					}
				}
			}
#endif

			this.Param = new Params.spS_AgentCommissionIncomeAccount(true);
			this.Param.SetUpConnection(connectionString);
		}

		/// <summary>
		/// Create a new instance of the Abstract_AgentCommissionIncomeAccount class.
		/// </summary>
		/// <param name="sqlConnection">A valid System.Data.SqlClient.SqlConnection to the database.</param>
		public Abstract_AgentCommissionIncomeAccount(System.Data.SqlClient.SqlConnection sqlConnection) {

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'AgentCommissionIncomeAccount'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "AgentCommissionIncomeAccount", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.Param = new Params.spS_AgentCommissionIncomeAccount(true);
			this.Param.SetUpConnection(sqlConnection);
			CloseConnectionAfterUse = (this.Param.SqlConnection.State != System.Data.ConnectionState.Open);
		}

		/// <summary>
		/// Create a new instance of the Abstract_AgentCommissionIncomeAccount class.
		/// </summary>
		/// <param name="sqlTransaction">A valid System.Data.SqlClient.SqlTransaction to the database.</param>
		public Abstract_AgentCommissionIncomeAccount(System.Data.SqlClient.SqlTransaction sqlTransaction) {

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'AgentCommissionIncomeAccount'";
				sqlCommand.Transaction = sqlTransaction;

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlTransaction.Connection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "AgentCommissionIncomeAccount", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.Param = new Params.spS_AgentCommissionIncomeAccount(true);
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

		private System.Data.SqlTypes.SqlGuid col_AgentAccountId;
		/// <summary>
		/// Returns the value of the AgentAccountId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;AgentAccountId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_AgentAccountId {

			get {

				return (this.col_AgentAccountId);
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

		private System.Data.SqlTypes.SqlDecimal col_CommissionCreditLC;
		/// <summary>
		/// Returns the value of the CommissionCreditLC column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;CommissionCreditLC&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_CommissionCreditLC {

			get {

				return (this.col_CommissionCreditLC);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_CommissionCreditUSD;
		/// <summary>
		/// Returns the value of the CommissionCreditUSD column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;CommissionCreditUSD&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_CommissionCreditUSD {

			get {

				return (this.col_CommissionCreditUSD);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_CommissionDebitLC;
		/// <summary>
		/// Returns the value of the CommissionDebitLC column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;CommissionDebitLC&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_CommissionDebitLC {

			get {

				return (this.col_CommissionDebitLC);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_CommissionDebitUSD;
		/// <summary>
		/// Returns the value of the CommissionDebitUSD column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;CommissionDebitUSD&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_CommissionDebitUSD {

			get {

				return (this.col_CommissionDebitUSD);
			}
		}

		/// <summary>
		/// This method allows to clear all the properties previously loaded by a call to the Refresh method.
		/// </summary>
		public void Reset() {

			this.col_Id = System.Data.SqlTypes.SqlGuid.Null;
			this.col_CreditDateTime = System.Data.SqlTypes.SqlDateTime.Null;
			this.col_DebitDateTime = System.Data.SqlTypes.SqlDateTime.Null;
			this.col_AgentAccountId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_TransactionId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_CommissionCreditLC = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_CommissionCreditUSD = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_CommissionDebitLC = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_CommissionDebitUSD = System.Data.SqlTypes.SqlDecimal.Null;
		}

		/// <summary>
		/// Allows you to load a specific record of the [AgentCommissionIncomeAccount] table.
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
			SPs.spS_AgentCommissionIncomeAccount SP = new SPs.spS_AgentCommissionIncomeAccount(false);

			if (SP.Execute(ref this.Param, out DR)) {

				Status = false;
				if (DR.Read()) {

					if (!DR.IsDBNull(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_CreditDateTime.ColumnIndex)) {

						this.col_CreditDateTime = DR.GetSqlDateTime(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_CreditDateTime.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_DebitDateTime.ColumnIndex)) {

						this.col_DebitDateTime = DR.GetSqlDateTime(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_DebitDateTime.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_AgentAccountId.ColumnIndex)) {

						this.col_AgentAccountId = DR.GetSqlGuid(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_AgentAccountId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_TransactionId.ColumnIndex)) {

						this.col_TransactionId = DR.GetSqlGuid(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_TransactionId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_CommissionCreditLC.ColumnIndex)) {

						this.col_CommissionCreditLC = DR.GetSqlDecimal(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_CommissionCreditLC.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_CommissionCreditUSD.ColumnIndex)) {

						this.col_CommissionCreditUSD = DR.GetSqlDecimal(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_CommissionCreditUSD.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_CommissionDebitLC.ColumnIndex)) {

						this.col_CommissionDebitLC = DR.GetSqlDecimal(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_CommissionDebitLC.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_CommissionDebitUSD.ColumnIndex)) {

						this.col_CommissionDebitUSD = DR.GetSqlDecimal(SPs.spS_AgentCommissionIncomeAccount.Resultset1.Fields.Column_CommissionDebitUSD.ColumnIndex);
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

				throw new Evernet.MoneyExchange.DataClasses.CustomException(this.Param, "Evernet.MoneyExchange.AbstractClasses.Abstract_AgentCommissionIncomeAccount", "Refresh");
			}
		}
	}
}