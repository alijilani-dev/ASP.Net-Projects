/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:47:33 PM
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

namespace Evernet.MoneyExchange.SqlDataAdapters {

	/// <summary>
	/// This class represents a full operational System.Data.SqlClient.SqlDataAdapter that can be
	/// used against the [TransactionDetails] table. The four basics operations are supported: Insert, Update, Delete and Select.
	/// </summary>
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[Evernet.MoneyExchange.DataClasses.OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:33", SqlObjectDependancyName="TransactionDetails", SqlObjectDependancyRevision=3344)]
#endif
	public class SqlDataAdapter_TransactionDetails {

		private string connectionString;
		private System.Data.SqlClient.SqlConnection sqlConnection;
		private System.Data.SqlClient.SqlTransaction sqlTransaction;
		private bool CloseConnectionAfterUse = true;
		private Evernet.MoneyExchange.DataClasses.ConnectionType lastKnownConnectionType = Evernet.MoneyExchange.DataClasses.ConnectionType.None;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter;
		private bool hasBeenConfigured = false;

		/// <summary>
		/// Returns the current type of connection that is going or has been used
		/// against the Sql Server database. It can be: ConnectionString, SqlConnection
		/// or SqlTransaction
		/// </summary>
		public Evernet.MoneyExchange.DataClasses.ConnectionType ConnectionType {

			get {

				return(this.lastKnownConnectionType);
			}
		}

		/// <summary>
		/// Returns the connection string used to access the Sql Server database.
		/// </summary>
		public string ConnectionString {

			get {

				if (this.lastKnownConnectionType != Evernet.MoneyExchange.DataClasses.ConnectionType.ConnectionString) {

					throw new InvalidOperationException("The connection string was not set in the class constructor.");
				}

				return(this.connectionString);
			}
		}

		/// <summary>
		/// Returns the SqlConnection used to access the Sql Server database.
		/// </summary>
		public System.Data.SqlClient.SqlConnection SqlConnection {

			get {

				if (this.lastKnownConnectionType != Evernet.MoneyExchange.DataClasses.ConnectionType.SqlConnection) {

					throw new InvalidOperationException("The SqlConnection was not set in the class constructor.");
				}

				return(this.sqlConnection);
			}
		}

		/// <summary>
		/// Returns the SqlTransaction used to access the Sql Server database.
		/// </summary>
		public System.Data.SqlClient.SqlTransaction SqlTransaction{

			get {

				if (this.lastKnownConnectionType != Evernet.MoneyExchange.DataClasses.ConnectionType.SqlTransaction) {

					throw new InvalidOperationException("The SqlTransaction was not set in the class constructor.");
				}

				return(this.sqlTransaction);
			}
		}

		/// <summary>
		/// Returns the underlying System.Data.SqlClient.SqlDataAdapter object.
		/// </summary>
		public System.Data.SqlClient.SqlDataAdapter SqlDataAdapter {

			get {

				return(this.sqlDataAdapter);
			}
		}

		/// <summary>
		/// Creates a new instance of the SqlDataAdapter_TransactionDetails class.
		/// In this constructor version, the SqlDataAdapter is not pre-configured. You need
		/// to call the Configure method before calling the FillDataSet method.
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		public SqlDataAdapter_TransactionDetails(string connectionString) {

			if (connectionString == null) {

				throw new ArgumentNullException("connectionString", "connectionString can be an empty string but can not be null.");
			}

			this.connectionString = connectionString;
			this.lastKnownConnectionType = Evernet.MoneyExchange.DataClasses.ConnectionType.ConnectionString;

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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'TransactionDetails'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "TransactionDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
					}
				}
			}
#endif
		}

		/// <summary>
		/// Creates a new instance of the SqlDataAdapter_TransactionDetails class.
		/// In this constructor version, the SqlDataAdapter is not pre-configured. You need
		/// to call the Configure method before calling the FillDataSet method.
		/// </summary>
		/// <param name="sqlConnection">A valid System.Data.SqlClient.SqlConnection to the database.</param>
		public SqlDataAdapter_TransactionDetails(System.Data.SqlClient.SqlConnection sqlConnection) {

			if (sqlConnection == null) {

				throw new ArgumentNullException("sqlConnection", "Invalid connection!");
			}

			this.sqlConnection = sqlConnection;
			this.lastKnownConnectionType = Evernet.MoneyExchange.DataClasses.ConnectionType.SqlConnection;

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'TransactionDetails'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "TransactionDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif
		}

		/// <summary>
		/// Creates a new instance of the SqlDataAdapter_TransactionDetails class.
		/// In this constructor version, the SqlDataAdapter is not pre-configured. You need
		/// to call the Configure method before calling the FillDataSet method.
		/// </summary>
		/// <param name="sqlTransaction">A valid System.Data.SqlClient.SqlTransaction to the database.</param>
		public SqlDataAdapter_TransactionDetails(System.Data.SqlClient.SqlTransaction sqlTransaction) {

			if (sqlTransaction == null || sqlTransaction.Connection == null) {

				throw new ArgumentNullException("sqlTransaction", "Invalid transaction!");
			}

			this.sqlTransaction = sqlTransaction;
			this.lastKnownConnectionType = Evernet.MoneyExchange.DataClasses.ConnectionType.SqlTransaction;

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'TransactionDetails'";
				sqlCommand.Transaction = sqlTransaction;

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlTransaction.Connection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "TransactionDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif
		}

		/// <summary>
		/// Creates and configures a new instance of the SqlDataAdapter_TransactionDetails class.
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		/// <param name="FK_CustomerId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryBankId">Value for this foreign key.</param>
		/// <param name="FK_PaymentMode">Value for this foreign key.</param>
		/// <param name="FK_PurposeOfTransfer">Value for this foreign key.</param>
		/// <param name="FK_PayInCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_PayOutCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_AssociatedBankId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentLocationId">Value for this foreign key.</param>
		/// <param name="FK_PayOutAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_Status">Value for this foreign key.</param>
		/// <param name="FK_SettlementStatus">Value for this foreign key.</param>
		/// <param name="tableName">Table name to be use in the DataSet.</param>
		public SqlDataAdapter_TransactionDetails(string connectionString, System.Data.SqlTypes.SqlGuid FK_CustomerId, System.Data.SqlTypes.SqlGuid FK_BeneficeryId, System.Data.SqlTypes.SqlGuid FK_BeneficeryBankId, System.Data.SqlTypes.SqlString FK_PaymentMode, System.Data.SqlTypes.SqlString FK_PurposeOfTransfer, System.Data.SqlTypes.SqlGuid FK_PayInCurrencyId, System.Data.SqlTypes.SqlGuid FK_PayOutCurrencyId, System.Data.SqlTypes.SqlGuid FK_AssociatedBankId, System.Data.SqlTypes.SqlGuid FK_PayInAgentUserId, System.Data.SqlTypes.SqlGuid FK_PayInAgentLocationId, System.Data.SqlTypes.SqlGuid FK_PayOutAgentUserId, System.Data.SqlTypes.SqlString FK_Status, System.Data.SqlTypes.SqlString FK_SettlementStatus, string tableName) : this(connectionString) {

			this.Configure(FK_CustomerId, FK_BeneficeryId, FK_BeneficeryBankId, FK_PaymentMode, FK_PurposeOfTransfer, FK_PayInCurrencyId, FK_PayOutCurrencyId, FK_AssociatedBankId, FK_PayInAgentUserId, FK_PayInAgentLocationId, FK_PayOutAgentUserId, FK_Status, FK_SettlementStatus, tableName);
		}

		/// <summary>
		/// Creates and configures a new instance of the SqlDataAdapter_TransactionDetails class.
		/// </summary>
		/// <param name="sqlConnection">A valid System.Data.SqlClient.SqlConnection to the database.</param>
		/// <param name="FK_CustomerId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryBankId">Value for this foreign key.</param>
		/// <param name="FK_PaymentMode">Value for this foreign key.</param>
		/// <param name="FK_PurposeOfTransfer">Value for this foreign key.</param>
		/// <param name="FK_PayInCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_PayOutCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_AssociatedBankId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentLocationId">Value for this foreign key.</param>
		/// <param name="FK_PayOutAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_Status">Value for this foreign key.</param>
		/// <param name="FK_SettlementStatus">Value for this foreign key.</param>
		/// <param name="tableName">Table name to be use in the DataSet.</param>
		public SqlDataAdapter_TransactionDetails(System.Data.SqlClient.SqlConnection sqlConnection, System.Data.SqlTypes.SqlGuid FK_CustomerId, System.Data.SqlTypes.SqlGuid FK_BeneficeryId, System.Data.SqlTypes.SqlGuid FK_BeneficeryBankId, System.Data.SqlTypes.SqlString FK_PaymentMode, System.Data.SqlTypes.SqlString FK_PurposeOfTransfer, System.Data.SqlTypes.SqlGuid FK_PayInCurrencyId, System.Data.SqlTypes.SqlGuid FK_PayOutCurrencyId, System.Data.SqlTypes.SqlGuid FK_AssociatedBankId, System.Data.SqlTypes.SqlGuid FK_PayInAgentUserId, System.Data.SqlTypes.SqlGuid FK_PayInAgentLocationId, System.Data.SqlTypes.SqlGuid FK_PayOutAgentUserId, System.Data.SqlTypes.SqlString FK_Status, System.Data.SqlTypes.SqlString FK_SettlementStatus, string tableName) : this(sqlConnection) {

			this.Configure(FK_CustomerId, FK_BeneficeryId, FK_BeneficeryBankId, FK_PaymentMode, FK_PurposeOfTransfer, FK_PayInCurrencyId, FK_PayOutCurrencyId, FK_AssociatedBankId, FK_PayInAgentUserId, FK_PayInAgentLocationId, FK_PayOutAgentUserId, FK_Status, FK_SettlementStatus, tableName);
		}

		/// <summary>
		/// Creates and configures a new instance of the SqlDataAdapter_TransactionDetails class.
		/// </summary>
		/// <param name="sqlTransaction">A valid System.Data.SqlClient.SqlTransaction to the database.</param>
		/// <param name="FK_CustomerId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryBankId">Value for this foreign key.</param>
		/// <param name="FK_PaymentMode">Value for this foreign key.</param>
		/// <param name="FK_PurposeOfTransfer">Value for this foreign key.</param>
		/// <param name="FK_PayInCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_PayOutCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_AssociatedBankId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentLocationId">Value for this foreign key.</param>
		/// <param name="FK_PayOutAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_Status">Value for this foreign key.</param>
		/// <param name="FK_SettlementStatus">Value for this foreign key.</param>
		/// <param name="tableName">Table name to be use in the DataSet.</param>
		public SqlDataAdapter_TransactionDetails(System.Data.SqlClient.SqlTransaction sqlTransaction, System.Data.SqlTypes.SqlGuid FK_CustomerId, System.Data.SqlTypes.SqlGuid FK_BeneficeryId, System.Data.SqlTypes.SqlGuid FK_BeneficeryBankId, System.Data.SqlTypes.SqlString FK_PaymentMode, System.Data.SqlTypes.SqlString FK_PurposeOfTransfer, System.Data.SqlTypes.SqlGuid FK_PayInCurrencyId, System.Data.SqlTypes.SqlGuid FK_PayOutCurrencyId, System.Data.SqlTypes.SqlGuid FK_AssociatedBankId, System.Data.SqlTypes.SqlGuid FK_PayInAgentUserId, System.Data.SqlTypes.SqlGuid FK_PayInAgentLocationId, System.Data.SqlTypes.SqlGuid FK_PayOutAgentUserId, System.Data.SqlTypes.SqlString FK_Status, System.Data.SqlTypes.SqlString FK_SettlementStatus, string tableName) : this(sqlTransaction) {

			this.Configure(FK_CustomerId, FK_BeneficeryId, FK_BeneficeryBankId, FK_PaymentMode, FK_PurposeOfTransfer, FK_PayInCurrencyId, FK_PayOutCurrencyId, FK_AssociatedBankId, FK_PayInAgentUserId, FK_PayInAgentLocationId, FK_PayOutAgentUserId, FK_Status, FK_SettlementStatus, tableName);
		}

		/// <summary>
		/// Creates and configures a new instance of the SqlDataAdapter_TransactionDetails class.
		/// The table name in the DataSet will be: TransactionDetails
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		/// <param name="FK_CustomerId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryBankId">Value for this foreign key.</param>
		/// <param name="FK_PaymentMode">Value for this foreign key.</param>
		/// <param name="FK_PurposeOfTransfer">Value for this foreign key.</param>
		/// <param name="FK_PayInCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_PayOutCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_AssociatedBankId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentLocationId">Value for this foreign key.</param>
		/// <param name="FK_PayOutAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_Status">Value for this foreign key.</param>
		/// <param name="FK_SettlementStatus">Value for this foreign key.</param>
		public SqlDataAdapter_TransactionDetails(string connectionString, System.Data.SqlTypes.SqlGuid FK_CustomerId, System.Data.SqlTypes.SqlGuid FK_BeneficeryId, System.Data.SqlTypes.SqlGuid FK_BeneficeryBankId, System.Data.SqlTypes.SqlString FK_PaymentMode, System.Data.SqlTypes.SqlString FK_PurposeOfTransfer, System.Data.SqlTypes.SqlGuid FK_PayInCurrencyId, System.Data.SqlTypes.SqlGuid FK_PayOutCurrencyId, System.Data.SqlTypes.SqlGuid FK_AssociatedBankId, System.Data.SqlTypes.SqlGuid FK_PayInAgentUserId, System.Data.SqlTypes.SqlGuid FK_PayInAgentLocationId, System.Data.SqlTypes.SqlGuid FK_PayOutAgentUserId, System.Data.SqlTypes.SqlString FK_Status, System.Data.SqlTypes.SqlString FK_SettlementStatus) : this(connectionString) {

			this.Configure(FK_CustomerId, FK_BeneficeryId, FK_BeneficeryBankId, FK_PaymentMode, FK_PurposeOfTransfer, FK_PayInCurrencyId, FK_PayOutCurrencyId, FK_AssociatedBankId, FK_PayInAgentUserId, FK_PayInAgentLocationId, FK_PayOutAgentUserId, FK_Status, FK_SettlementStatus, "TransactionDetails");
		}

		/// <summary>
		/// Creates and configures a new instance of the SqlDataAdapter_TransactionDetails class.
		/// The table name in the DataSet will be: TransactionDetails
		/// </summary>
		/// <param name="sqlConnection">A valid System.Data.SqlClient.SqlConnection to the database.</param>
		/// <param name="FK_CustomerId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryBankId">Value for this foreign key.</param>
		/// <param name="FK_PaymentMode">Value for this foreign key.</param>
		/// <param name="FK_PurposeOfTransfer">Value for this foreign key.</param>
		/// <param name="FK_PayInCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_PayOutCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_AssociatedBankId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentLocationId">Value for this foreign key.</param>
		/// <param name="FK_PayOutAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_Status">Value for this foreign key.</param>
		/// <param name="FK_SettlementStatus">Value for this foreign key.</param>
		public SqlDataAdapter_TransactionDetails(System.Data.SqlClient.SqlConnection sqlConnection, System.Data.SqlTypes.SqlGuid FK_CustomerId, System.Data.SqlTypes.SqlGuid FK_BeneficeryId, System.Data.SqlTypes.SqlGuid FK_BeneficeryBankId, System.Data.SqlTypes.SqlString FK_PaymentMode, System.Data.SqlTypes.SqlString FK_PurposeOfTransfer, System.Data.SqlTypes.SqlGuid FK_PayInCurrencyId, System.Data.SqlTypes.SqlGuid FK_PayOutCurrencyId, System.Data.SqlTypes.SqlGuid FK_AssociatedBankId, System.Data.SqlTypes.SqlGuid FK_PayInAgentUserId, System.Data.SqlTypes.SqlGuid FK_PayInAgentLocationId, System.Data.SqlTypes.SqlGuid FK_PayOutAgentUserId, System.Data.SqlTypes.SqlString FK_Status, System.Data.SqlTypes.SqlString FK_SettlementStatus) : this(sqlConnection) {

			this.Configure(FK_CustomerId, FK_BeneficeryId, FK_BeneficeryBankId, FK_PaymentMode, FK_PurposeOfTransfer, FK_PayInCurrencyId, FK_PayOutCurrencyId, FK_AssociatedBankId, FK_PayInAgentUserId, FK_PayInAgentLocationId, FK_PayOutAgentUserId, FK_Status, FK_SettlementStatus, "TransactionDetails");
		}

		/// <summary>
		/// Creates and configures a new instance of the SqlDataAdapter_TransactionDetails class.
		/// The table name in the DataSet will be: TransactionDetails
		/// </summary>
		/// <param name="sqlTransaction">A valid System.Data.SqlClient.SqlTransaction to the database.</param>
		/// <param name="FK_CustomerId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryBankId">Value for this foreign key.</param>
		/// <param name="FK_PaymentMode">Value for this foreign key.</param>
		/// <param name="FK_PurposeOfTransfer">Value for this foreign key.</param>
		/// <param name="FK_PayInCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_PayOutCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_AssociatedBankId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentLocationId">Value for this foreign key.</param>
		/// <param name="FK_PayOutAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_Status">Value for this foreign key.</param>
		/// <param name="FK_SettlementStatus">Value for this foreign key.</param>
		public SqlDataAdapter_TransactionDetails(System.Data.SqlClient.SqlTransaction sqlTransaction, System.Data.SqlTypes.SqlGuid FK_CustomerId, System.Data.SqlTypes.SqlGuid FK_BeneficeryId, System.Data.SqlTypes.SqlGuid FK_BeneficeryBankId, System.Data.SqlTypes.SqlString FK_PaymentMode, System.Data.SqlTypes.SqlString FK_PurposeOfTransfer, System.Data.SqlTypes.SqlGuid FK_PayInCurrencyId, System.Data.SqlTypes.SqlGuid FK_PayOutCurrencyId, System.Data.SqlTypes.SqlGuid FK_AssociatedBankId, System.Data.SqlTypes.SqlGuid FK_PayInAgentUserId, System.Data.SqlTypes.SqlGuid FK_PayInAgentLocationId, System.Data.SqlTypes.SqlGuid FK_PayOutAgentUserId, System.Data.SqlTypes.SqlString FK_Status, System.Data.SqlTypes.SqlString FK_SettlementStatus) : this(sqlTransaction) {

			this.Configure(FK_CustomerId, FK_BeneficeryId, FK_BeneficeryBankId, FK_PaymentMode, FK_PurposeOfTransfer, FK_PayInCurrencyId, FK_PayOutCurrencyId, FK_AssociatedBankId, FK_PayInAgentUserId, FK_PayInAgentLocationId, FK_PayOutAgentUserId, FK_Status, FK_SettlementStatus, "TransactionDetails");
		}

		/// <summary>
		/// Configures the SqlDataAdapter.
		/// The table name in the DataSet will be: TransactionDetails
		/// </summary>
		/// <param name="FK_CustomerId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryBankId">Value for this foreign key.</param>
		/// <param name="FK_PaymentMode">Value for this foreign key.</param>
		/// <param name="FK_PurposeOfTransfer">Value for this foreign key.</param>
		/// <param name="FK_PayInCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_PayOutCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_AssociatedBankId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentLocationId">Value for this foreign key.</param>
		/// <param name="FK_PayOutAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_Status">Value for this foreign key.</param>
		/// <param name="FK_SettlementStatus">Value for this foreign key.</param>
		public void Configure(System.Data.SqlTypes.SqlGuid FK_CustomerId, System.Data.SqlTypes.SqlGuid FK_BeneficeryId, System.Data.SqlTypes.SqlGuid FK_BeneficeryBankId, System.Data.SqlTypes.SqlString FK_PaymentMode, System.Data.SqlTypes.SqlString FK_PurposeOfTransfer, System.Data.SqlTypes.SqlGuid FK_PayInCurrencyId, System.Data.SqlTypes.SqlGuid FK_PayOutCurrencyId, System.Data.SqlTypes.SqlGuid FK_AssociatedBankId, System.Data.SqlTypes.SqlGuid FK_PayInAgentUserId, System.Data.SqlTypes.SqlGuid FK_PayInAgentLocationId, System.Data.SqlTypes.SqlGuid FK_PayOutAgentUserId, System.Data.SqlTypes.SqlString FK_Status, System.Data.SqlTypes.SqlString FK_SettlementStatus) {

			this.Configure(FK_CustomerId, FK_BeneficeryId, FK_BeneficeryBankId, FK_PaymentMode, FK_PurposeOfTransfer, FK_PayInCurrencyId, FK_PayOutCurrencyId, FK_AssociatedBankId, FK_PayInAgentUserId, FK_PayInAgentLocationId, FK_PayOutAgentUserId, FK_Status, FK_SettlementStatus, "TransactionDetails");
		}

		/// <summary>
		/// Configures the SqlDataAdapter.
		/// </summary>
		/// <param name="FK_CustomerId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryBankId">Value for this foreign key.</param>
		/// <param name="FK_PaymentMode">Value for this foreign key.</param>
		/// <param name="FK_PurposeOfTransfer">Value for this foreign key.</param>
		/// <param name="FK_PayInCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_PayOutCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_AssociatedBankId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentLocationId">Value for this foreign key.</param>
		/// <param name="FK_PayOutAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_Status">Value for this foreign key.</param>
		/// <param name="FK_SettlementStatus">Value for this foreign key.</param>
		/// <param name="tableName">Table name to be use in the DataSet.</param>
		public void Configure(System.Data.SqlTypes.SqlGuid FK_CustomerId, System.Data.SqlTypes.SqlGuid FK_BeneficeryId, System.Data.SqlTypes.SqlGuid FK_BeneficeryBankId, System.Data.SqlTypes.SqlString FK_PaymentMode, System.Data.SqlTypes.SqlString FK_PurposeOfTransfer, System.Data.SqlTypes.SqlGuid FK_PayInCurrencyId, System.Data.SqlTypes.SqlGuid FK_PayOutCurrencyId, System.Data.SqlTypes.SqlGuid FK_AssociatedBankId, System.Data.SqlTypes.SqlGuid FK_PayInAgentUserId, System.Data.SqlTypes.SqlGuid FK_PayInAgentLocationId, System.Data.SqlTypes.SqlGuid FK_PayOutAgentUserId, System.Data.SqlTypes.SqlString FK_Status, System.Data.SqlTypes.SqlString FK_SettlementStatus, string tableName) {

			this.hasBeenConfigured = true;

			this.sqlDataAdapter = null;

			System.Data.SqlClient.SqlCommand sqlSelectCommand;
			System.Data.SqlClient.SqlCommand sqlInsertCommand;
			System.Data.SqlClient.SqlCommand sqlUpdateCommand;
			System.Data.SqlClient.SqlCommand sqlDeleteCommand;
			System.Data.SqlClient.SqlParameter sqlParameter;
			
			sqlSelectCommand = new System.Data.SqlClient.SqlCommand();
			sqlInsertCommand = new System.Data.SqlClient.SqlCommand();
			sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
			sqlDeleteCommand = new System.Data.SqlClient.SqlCommand();

			System.Data.SqlClient.SqlConnection localSqlConnection = null;
			switch (this.lastKnownConnectionType) {

				case Evernet.MoneyExchange.DataClasses.ConnectionType.ConnectionString:

					string connectionString = this.ConnectionString;
				
					if (connectionString.Length == 0) {

						connectionString = Evernet.MoneyExchange.DataClasses.Information.GetConnectionStringFromConfigurationFile;
						if (connectionString.Length == 0) {

							connectionString = Evernet.MoneyExchange.DataClasses.Information.GetConnectionStringFromRegistry;
						}
					}

					if (connectionString.Length == 0) {

						throw new System.InvalidOperationException("No connection information was supplied (ConnectionString == \"\")! (Evernet.MoneyExchange.SqlDataAdapters.SqlDataAdapter_TransactionDetails)");
					}

					localSqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

					sqlSelectCommand.Connection = localSqlConnection;
					sqlInsertCommand.Connection = localSqlConnection;
					sqlUpdateCommand.Connection = localSqlConnection;
					sqlDeleteCommand.Connection = localSqlConnection;

					break;

				case Evernet.MoneyExchange.DataClasses.ConnectionType.SqlConnection:

					localSqlConnection = this.SqlConnection;

					sqlSelectCommand.Connection = localSqlConnection;
					sqlInsertCommand.Connection = localSqlConnection;
					sqlUpdateCommand.Connection = localSqlConnection;
					sqlDeleteCommand.Connection = localSqlConnection;

					break;

				case Evernet.MoneyExchange.DataClasses.ConnectionType.SqlTransaction:

					sqlSelectCommand.Connection = this.sqlTransaction.Connection;
					sqlSelectCommand.Transaction = this.sqlTransaction;

					sqlInsertCommand.Connection = this.sqlTransaction.Connection;
					sqlInsertCommand.Transaction = this.sqlTransaction;

					sqlUpdateCommand.Connection = this.sqlTransaction.Connection;
					sqlUpdateCommand.Transaction = this.sqlTransaction;

					sqlDeleteCommand.Connection = this.sqlTransaction.Connection;
					sqlDeleteCommand.Transaction = this.sqlTransaction;

					break;
			}

			sqlSelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
			sqlSelectCommand.CommandText = "spS_TransactionDetails";

			sqlParameter = new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4);
			sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "Id";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@CustomerId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "CustomerId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			if (!FK_CustomerId.IsNull) {

				sqlParameter.Value = FK_CustomerId;
			}

			else {

				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
			}
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@BeneficeryId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "BeneficeryId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			if (!FK_BeneficeryId.IsNull) {

				sqlParameter.Value = FK_BeneficeryId;
			}

			else {

				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
			}
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@BeneficeryBankId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "BeneficeryBankId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			if (!FK_BeneficeryBankId.IsNull) {

				sqlParameter.Value = FK_BeneficeryBankId;
			}

			else {

				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
			}
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PaymentMode", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "PaymentMode";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			if (!FK_PaymentMode.IsNull) {

				sqlParameter.Value = FK_PaymentMode;
			}

			else {

				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
			}
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PurposeOfTransfer", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "PurposeOfTransfer";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			if (!FK_PurposeOfTransfer.IsNull) {

				sqlParameter.Value = FK_PurposeOfTransfer;
			}

			else {

				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
			}
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInCurrencyId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayInCurrencyId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			if (!FK_PayInCurrencyId.IsNull) {

				sqlParameter.Value = FK_PayInCurrencyId;
			}

			else {

				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
			}
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutCurrencyId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayOutCurrencyId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			if (!FK_PayOutCurrencyId.IsNull) {

				sqlParameter.Value = FK_PayOutCurrencyId;
			}

			else {

				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
			}
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@AssociatedBankId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "AssociatedBankId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			if (!FK_AssociatedBankId.IsNull) {

				sqlParameter.Value = FK_AssociatedBankId;
			}

			else {

				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
			}
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInAgentUserId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayInAgentUserId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			if (!FK_PayInAgentUserId.IsNull) {

				sqlParameter.Value = FK_PayInAgentUserId;
			}

			else {

				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
			}
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInAgentLocationId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayInAgentLocationId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			if (!FK_PayInAgentLocationId.IsNull) {

				sqlParameter.Value = FK_PayInAgentLocationId;
			}

			else {

				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
			}
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutAgentUserId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayOutAgentUserId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			if (!FK_PayOutAgentUserId.IsNull) {

				sqlParameter.Value = FK_PayOutAgentUserId;
			}

			else {

				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
			}
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "Status";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			if (!FK_Status.IsNull) {

				sqlParameter.Value = FK_Status;
			}

			else {

				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
			}
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@SettlementStatus", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "SettlementStatus";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			if (!FK_SettlementStatus.IsNull) {

				sqlParameter.Value = FK_SettlementStatus;
			}

			else {

				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
			}
			sqlSelectCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ReturnXML", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = false;
			sqlSelectCommand.Parameters.Add(sqlParameter);


			sqlInsertCommand.CommandType = System.Data.CommandType.StoredProcedure;
			sqlInsertCommand.CommandText = "spI_TransactionDetails";

			sqlParameter = new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4);
			sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "Id";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@VoucherNumber", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "VoucherNumber";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@TransactionNumber", System.Data.SqlDbType.NVarChar, 40);
			sqlParameter.SourceColumn = "TransactionNumber";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@CustomerId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "CustomerId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@BeneficeryId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "BeneficeryId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@BeneficeryBankId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "BeneficeryBankId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PaymentMode", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "PaymentMode";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PurposeOfTransfer", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "PurposeOfTransfer";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInCurrencyId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayInCurrencyId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInAmount", System.Data.SqlDbType.Decimal, 40);
			sqlParameter.SourceColumn = "PayInAmount";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutCurrencyId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayOutCurrencyId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutAmount", System.Data.SqlDbType.Decimal, 40);
			sqlParameter.SourceColumn = "PayOutAmount";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@Commission", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "Commission";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@Question", System.Data.SqlDbType.NVarChar, 400);
			sqlParameter.SourceColumn = "Question";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@Answer", System.Data.SqlDbType.NVarChar, 400);
			sqlParameter.SourceColumn = "Answer";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@MessageToBeneficery", System.Data.SqlDbType.NVarChar, 600);
			sqlParameter.SourceColumn = "MessageToBeneficery";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@MessageToPayOutAgent", System.Data.SqlDbType.NVarChar, 600);
			sqlParameter.SourceColumn = "MessageToPayOutAgent";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@BankExchangeRateForPayInCurrency", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "BankExchangeRateForPayInCurrency";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@BankExchangeRateForPayOutCurrency", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "BankExchangeRateForPayOutCurrency";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInCurrencyGroup", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "PayInCurrencyGroup";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutCurrencyGroup", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "PayOutCurrencyGroup";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@FinalBankExchangeRate", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "FinalBankExchangeRate";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@AgencyMarginPercent", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "AgencyMarginPercent";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@AgencyExchangeRate", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "AgencyExchangeRate";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@AgentMarginPercent", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "AgentMarginPercent";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@AgentExchangeRate", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "AgentExchangeRate";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@AssociatedBankId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "AssociatedBankId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutLocationId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayOutLocationId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInAgentUserId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayInAgentUserId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInAgentLocationId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayInAgentLocationId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInDateTime", System.Data.SqlDbType.DateTime, 16);
			sqlParameter.SourceColumn = "PayInDateTime";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@RecommendedPayOutAgentId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "RecommendedPayOutAgentId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ActualPayOutAgentId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "ActualPayOutAgentId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutAgentUserId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayOutAgentUserId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutDateTime", System.Data.SqlDbType.DateTime, 16);
			sqlParameter.SourceColumn = "PayOutDateTime";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@CollectedBeneficeryIdDetails", System.Data.SqlDbType.NVarChar, 300);
			sqlParameter.SourceColumn = "CollectedBeneficeryIdDetails";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@IsOpenTransaction", System.Data.SqlDbType.Bit, 1);
			sqlParameter.SourceColumn = "IsOpenTransaction";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "Status";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@SettlementStatus", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "SettlementStatus";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlInsertCommand.Parameters.Add(sqlParameter);


			sqlUpdateCommand.CommandType = System.Data.CommandType.StoredProcedure;
			sqlUpdateCommand.CommandText = "spU_TransactionDetails";

			sqlParameter = new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4);
			sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "Id";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@VoucherNumber", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "VoucherNumber";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_VoucherNumber", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@TransactionNumber", System.Data.SqlDbType.NVarChar, 40);
			sqlParameter.SourceColumn = "TransactionNumber";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_TransactionNumber", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@CustomerId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "CustomerId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_CustomerId", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@BeneficeryId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "BeneficeryId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_BeneficeryId", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@BeneficeryBankId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "BeneficeryBankId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_BeneficeryBankId", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PaymentMode", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "PaymentMode";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PaymentMode", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PurposeOfTransfer", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "PurposeOfTransfer";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PurposeOfTransfer", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInCurrencyId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayInCurrencyId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayInCurrencyId", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInAmount", System.Data.SqlDbType.Decimal, 40);
			sqlParameter.SourceColumn = "PayInAmount";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayInAmount", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutCurrencyId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayOutCurrencyId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayOutCurrencyId", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutAmount", System.Data.SqlDbType.Decimal, 40);
			sqlParameter.SourceColumn = "PayOutAmount";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayOutAmount", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@Commission", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "Commission";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Commission", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@Question", System.Data.SqlDbType.NVarChar, 400);
			sqlParameter.SourceColumn = "Question";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Question", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@Answer", System.Data.SqlDbType.NVarChar, 400);
			sqlParameter.SourceColumn = "Answer";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Answer", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@MessageToBeneficery", System.Data.SqlDbType.NVarChar, 600);
			sqlParameter.SourceColumn = "MessageToBeneficery";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_MessageToBeneficery", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@MessageToPayOutAgent", System.Data.SqlDbType.NVarChar, 600);
			sqlParameter.SourceColumn = "MessageToPayOutAgent";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_MessageToPayOutAgent", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@BankExchangeRateForPayInCurrency", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "BankExchangeRateForPayInCurrency";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_BankExchangeRateForPayInCurrency", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@BankExchangeRateForPayOutCurrency", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "BankExchangeRateForPayOutCurrency";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_BankExchangeRateForPayOutCurrency", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInCurrencyGroup", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "PayInCurrencyGroup";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayInCurrencyGroup", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutCurrencyGroup", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "PayOutCurrencyGroup";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayOutCurrencyGroup", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@FinalBankExchangeRate", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "FinalBankExchangeRate";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_FinalBankExchangeRate", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@AgencyMarginPercent", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "AgencyMarginPercent";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_AgencyMarginPercent", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@AgencyExchangeRate", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "AgencyExchangeRate";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_AgencyExchangeRate", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@AgentMarginPercent", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "AgentMarginPercent";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_AgentMarginPercent", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@AgentExchangeRate", System.Data.SqlDbType.Decimal, 20);
			sqlParameter.SourceColumn = "AgentExchangeRate";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_AgentExchangeRate", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@AssociatedBankId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "AssociatedBankId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_AssociatedBankId", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutLocationId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayOutLocationId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayOutLocationId", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInAgentUserId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayInAgentUserId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayInAgentUserId", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInAgentLocationId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayInAgentLocationId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayInAgentLocationId", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInDateTime", System.Data.SqlDbType.DateTime, 16);
			sqlParameter.SourceColumn = "PayInDateTime";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayInDateTime", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@RecommendedPayOutAgentId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "RecommendedPayOutAgentId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_RecommendedPayOutAgentId", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ActualPayOutAgentId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "ActualPayOutAgentId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_ActualPayOutAgentId", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutAgentUserId", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "PayOutAgentUserId";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayOutAgentUserId", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutDateTime", System.Data.SqlDbType.DateTime, 16);
			sqlParameter.SourceColumn = "PayOutDateTime";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayOutDateTime", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@CollectedBeneficeryIdDetails", System.Data.SqlDbType.NVarChar, 300);
			sqlParameter.SourceColumn = "CollectedBeneficeryIdDetails";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_CollectedBeneficeryIdDetails", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@IsOpenTransaction", System.Data.SqlDbType.Bit, 1);
			sqlParameter.SourceColumn = "IsOpenTransaction";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_IsOpenTransaction", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "Status";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Status", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@SettlementStatus", System.Data.SqlDbType.NVarChar, 100);
			sqlParameter.SourceColumn = "SettlementStatus";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlUpdateCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_SettlementStatus", System.Data.SqlDbType.Bit, 1);
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.Value = true;
			sqlUpdateCommand.Parameters.Add(sqlParameter);


			sqlDeleteCommand.CommandType = System.Data.CommandType.StoredProcedure;
			sqlDeleteCommand.CommandText = "spD_TransactionDetails";

			sqlParameter = new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4);
			sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlDeleteCommand.Parameters.Add(sqlParameter);

			sqlParameter = new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16);
			sqlParameter.SourceColumn = "Id";
			sqlParameter.Direction = System.Data.ParameterDirection.Input;
			sqlParameter.IsNullable = true;
			sqlParameter.Value = System.DBNull.Value;
			sqlDeleteCommand.Parameters.Add(sqlParameter);


			// Let's create the SqlDataAdapter
			this.sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter();

			this.sqlDataAdapter.SelectCommand = sqlSelectCommand;
			this.sqlDataAdapter.InsertCommand = sqlInsertCommand;
			this.sqlDataAdapter.UpdateCommand = sqlUpdateCommand;
			this.sqlDataAdapter.DeleteCommand = sqlDeleteCommand;

			this.sqlDataAdapter.TableMappings.AddRange (

				new System.Data.Common.DataTableMapping[] {

					new System.Data.Common.DataTableMapping (
						 "TransactionDetails"
						,tableName
						,new System.Data.Common.DataColumnMapping[] {
							 new System.Data.Common.DataColumnMapping("Id", "Id")
							,new System.Data.Common.DataColumnMapping("VoucherNumber", "VoucherNumber")
							,new System.Data.Common.DataColumnMapping("TransactionNumber", "TransactionNumber")
							,new System.Data.Common.DataColumnMapping("CustomerId", "CustomerId")
							,new System.Data.Common.DataColumnMapping("BeneficeryId", "BeneficeryId")
							,new System.Data.Common.DataColumnMapping("BeneficeryBankId", "BeneficeryBankId")
							,new System.Data.Common.DataColumnMapping("PaymentMode", "PaymentMode")
							,new System.Data.Common.DataColumnMapping("PurposeOfTransfer", "PurposeOfTransfer")
							,new System.Data.Common.DataColumnMapping("PayInCurrencyId", "PayInCurrencyId")
							,new System.Data.Common.DataColumnMapping("PayInAmount", "PayInAmount")
							,new System.Data.Common.DataColumnMapping("PayOutCurrencyId", "PayOutCurrencyId")
							,new System.Data.Common.DataColumnMapping("PayOutAmount", "PayOutAmount")
							,new System.Data.Common.DataColumnMapping("Commission", "Commission")
							,new System.Data.Common.DataColumnMapping("Question", "Question")
							,new System.Data.Common.DataColumnMapping("Answer", "Answer")
							,new System.Data.Common.DataColumnMapping("MessageToBeneficery", "MessageToBeneficery")
							,new System.Data.Common.DataColumnMapping("MessageToPayOutAgent", "MessageToPayOutAgent")
							,new System.Data.Common.DataColumnMapping("BankExchangeRateForPayInCurrency", "BankExchangeRateForPayInCurrency")
							,new System.Data.Common.DataColumnMapping("BankExchangeRateForPayOutCurrency", "BankExchangeRateForPayOutCurrency")
							,new System.Data.Common.DataColumnMapping("PayInCurrencyGroup", "PayInCurrencyGroup")
							,new System.Data.Common.DataColumnMapping("PayOutCurrencyGroup", "PayOutCurrencyGroup")
							,new System.Data.Common.DataColumnMapping("FinalBankExchangeRate", "FinalBankExchangeRate")
							,new System.Data.Common.DataColumnMapping("AgencyMarginPercent", "AgencyMarginPercent")
							,new System.Data.Common.DataColumnMapping("AgencyExchangeRate", "AgencyExchangeRate")
							,new System.Data.Common.DataColumnMapping("AgentMarginPercent", "AgentMarginPercent")
							,new System.Data.Common.DataColumnMapping("AgentExchangeRate", "AgentExchangeRate")
							,new System.Data.Common.DataColumnMapping("AssociatedBankId", "AssociatedBankId")
							,new System.Data.Common.DataColumnMapping("PayOutLocationId", "PayOutLocationId")
							,new System.Data.Common.DataColumnMapping("PayInAgentUserId", "PayInAgentUserId")
							,new System.Data.Common.DataColumnMapping("PayInAgentLocationId", "PayInAgentLocationId")
							,new System.Data.Common.DataColumnMapping("PayInDateTime", "PayInDateTime")
							,new System.Data.Common.DataColumnMapping("RecommendedPayOutAgentId", "RecommendedPayOutAgentId")
							,new System.Data.Common.DataColumnMapping("ActualPayOutAgentId", "ActualPayOutAgentId")
							,new System.Data.Common.DataColumnMapping("PayOutAgentUserId", "PayOutAgentUserId")
							,new System.Data.Common.DataColumnMapping("PayOutDateTime", "PayOutDateTime")
							,new System.Data.Common.DataColumnMapping("CollectedBeneficeryIdDetails", "CollectedBeneficeryIdDetails")
							,new System.Data.Common.DataColumnMapping("IsOpenTransaction", "IsOpenTransaction")
							,new System.Data.Common.DataColumnMapping("Status", "Status")
							,new System.Data.Common.DataColumnMapping("SettlementStatus", "SettlementStatus")
						}
					)
				}
			);
		}

		/// <summary>
		/// Populates the supplied DataSet object. By default,
		///the populated table name in the DataSet will be: TransactionDetails.
		/// </summary>
		/// <param name="dataSet">DataSet to be populated by the SqlDataAdapter.</param>
		public void FillDataSet(ref System.Data.DataSet dataSet) {

			this.FillDataSet(ref dataSet, "TransactionDetails", -1, -1);
		}

		/// <summary>
		/// Populates the supplied DataSet object.
		/// </summary>
		/// <param name="dataSet">DataSet to be populated by the SqlDataAdapter.</param>
		/// <param name="tableName">Table name to be use in the DataSet.</param>
		public void FillDataSet(ref System.Data.DataSet dataSet, string tableName) {

			this.FillDataSet(ref dataSet, tableName, -1, -1);
		}

		/// <summary>
		/// Populates the supplied DataSet object. By default,
		///the populated table name in the DataSet will be: TransactionDetails.
		/// </summary>
		/// <param name="dataSet">DataSet to be populated by the SqlDataAdapter.</param>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		public void FillDataSet(ref System.Data.DataSet dataSet, int startRecord, int maxRecords) {

			this.FillDataSet(ref dataSet, "TransactionDetails", startRecord, maxRecords);
		}

		/// <summary>
		/// Populates the supplied DataSet object.
		/// </summary>
		/// <param name="dataSet">DataSet to be populated by the SqlDataAdapter.</param>
		/// <param name="tableName">Table name to be use in the DataSet.</param>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		public void FillDataSet(ref System.Data.DataSet dataSet, string tableName, int startRecord, int maxRecords) {

			if (!this.hasBeenConfigured) {

				throw new InvalidOperationException("This SqlDataAdapter has not been configured. Call the Configure method first.");
			}

			if (this.lastKnownConnectionType == Evernet.MoneyExchange.DataClasses.ConnectionType.SqlConnection && this.sqlConnection != null) {
			
				CloseConnectionAfterUse = (this.SqlConnection.State != System.Data.ConnectionState.Open);
			}

			if (dataSet == null) {

				dataSet = new System.Data.DataSet();
			}

			if (startRecord == -1) {

				this.sqlDataAdapter.Fill(dataSet, tableName);
			}
			else {

				this.sqlDataAdapter.Fill(dataSet, startRecord, maxRecords, tableName);
			}

			if (this.CloseConnectionAfterUse && this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open) {

				this.sqlConnection.Close();
			}
		}	
	}
}
