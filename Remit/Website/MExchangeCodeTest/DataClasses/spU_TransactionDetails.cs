/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:47:07 PM
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

namespace Evernet.MoneyExchange.DataClasses.Parameters {

	/// <summary>
	/// This class allows a developer to specify the parameters expected by the
	/// stored procedure 'spU_TransactionDetails'. It allows also to specify specific connection
	/// information such as the ConnectionString to be use, the command time-out and so forth.
	/// </summary>
	[Serializable()]
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:07", SqlObjectDependancyName="spU_TransactionDetails", SqlObjectDependancyRevision=32)]
#endif
	public class spU_TransactionDetails : MarshalByRefObject, IDisposable, IParameter {

		private ErrorSource errorSource = ErrorSource.NotAvailable;
		private System.Data.SqlClient.SqlException sqlException = null;
		private System.Exception otherException = null;
		private string connectionString = String.Empty;
		private System.Data.SqlClient.SqlConnection sqlConnection = null;
		private System.Data.SqlClient.SqlTransaction sqlTransaction = null;
		private ConnectionType lastKnownConnectionType = ConnectionType.None;
		private int commandTimeOut = 30;

		internal void internal_UpdateExceptionInformation(System.Data.SqlClient.SqlException sqlException) {

			this.sqlException = sqlException;
		}

		internal void internal_UpdateExceptionInformation(System.Exception otherException) {

			this.otherException = otherException;
		}

		internal void internal_SetErrorSource(ErrorSource errorSource) {

			this.errorSource = errorSource;
		}

		private bool useDefaultValue = true;

		/// <summary>
		/// Initializes a new instance of the spU_TransactionDetails class. If you use this constructor version,
		/// not assigning parameter values implies using the parameter default values.
		/// </summary>
		public spU_TransactionDetails() : this(true) {

		}

		/// <summary>
		/// Initializes a new instance of the spU_TransactionDetails class.
		/// </summary>
		/// <param name="useDefaultValue">If True, this parameter indicates that "not assigning parameter values" implies "using the parameter default values". If False, this parameter indicates that "not assigning parameter values" implies "using the SQL Server Null value".</param>
		public spU_TransactionDetails(bool useDefaultValue) {

			this.useDefaultValue = useDefaultValue;

			this.internal_Param_Id_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_VoucherNumber_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_VoucherNumber_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_TransactionNumber_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_TransactionNumber_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_CustomerId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_CustomerId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_BeneficeryId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_BeneficeryId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_BeneficeryBankId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_BeneficeryBankId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PaymentMode_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PaymentMode_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PurposeOfTransfer_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PurposeOfTransfer_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayInCurrencyId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PayInCurrencyId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayInAmount_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PayInAmount_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayOutCurrencyId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PayOutCurrencyId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayOutAmount_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PayOutAmount_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Commission_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_Commission_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Question_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_Question_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Answer_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_Answer_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_MessageToBeneficery_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_MessageToBeneficery_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_MessageToPayOutAgent_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_MessageToPayOutAgent_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_BankExchangeRateForPayInCurrency_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_BankExchangeRateForPayInCurrency_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_BankExchangeRateForPayOutCurrency_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_BankExchangeRateForPayOutCurrency_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayInCurrencyGroup_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PayInCurrencyGroup_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayOutCurrencyGroup_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PayOutCurrencyGroup_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_FinalBankExchangeRate_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_FinalBankExchangeRate_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_AgencyMarginPercent_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_AgencyMarginPercent_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_AgencyExchangeRate_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_AgencyExchangeRate_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_AgentMarginPercent_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_AgentMarginPercent_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_AgentExchangeRate_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_AgentExchangeRate_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_AssociatedBankId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_AssociatedBankId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayOutLocationId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PayOutLocationId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayInAgentUserId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PayInAgentUserId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayInAgentLocationId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PayInAgentLocationId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayInDateTime_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PayInDateTime_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_RecommendedPayOutAgentId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_RecommendedPayOutAgentId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ActualPayOutAgentId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_ActualPayOutAgentId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayOutAgentUserId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PayOutAgentUserId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayOutDateTime_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_PayOutDateTime_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_CollectedBeneficeryIdDetails_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_CollectedBeneficeryIdDetails_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_IsOpenTransaction_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_IsOpenTransaction_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Status_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_Status_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_SettlementStatus_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_SettlementStatus_UseDefaultValue = this.useDefaultValue;
		}


		/// <summary>
		/// Sets the connection string to be used against the 
		/// SQL Server database.
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		public void SetUpConnection(string connectionString) {

			if (connectionString == null) {

				throw new ArgumentNullException("connectionString", "connectionString can be an empty string but can not be null.");
			}

			this.connectionString = connectionString;
			this.lastKnownConnectionType = ConnectionType.ConnectionString;

#if OLYMARS_DEBUG
			object olymarsDebugCheck = System.Configuration.ConfigurationSettings.AppSettings["OlymarsDebugCheck"];
			if (olymarsDebugCheck == null || (string)olymarsDebugCheck == "True") {

				string DebugConnectionString = connectionString;

				if (DebugConnectionString.Length == 0) {

					DebugConnectionString = Information.GetConnectionStringFromConfigurationFile;
				}

				if (DebugConnectionString.Length == 0) {

					DebugConnectionString = Information.GetConnectionStringFromRegistry;
				}

				if (DebugConnectionString.Length != 0) {

					System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(DebugConnectionString);

					sqlConnection.Open();

					System.Data.SqlClient.SqlCommand sqlCommand = sqlConnection.CreateCommand();

					sqlCommand.CommandType = System.Data.CommandType.Text;
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spU_TransactionDetails'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spU_TransactionDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
					}
				}
			}
#endif
		}

		/// <summary>
		/// Sets the System.Data.SqlClient.SqlConnection to be used
		/// against the SQL Server database.
		/// </summary>
		/// <param name="sqlConnection">A valid System.Data.SqlClient.SqlConnection object. It can be opened or not. If it is not opened, it will be opened when used then closed again after the job is done.</param>
		public void SetUpConnection(System.Data.SqlClient.SqlConnection sqlConnection) {

			if (sqlConnection == null) {
				throw new ArgumentNullException("sqlConnection", "Invalid connection!");
			}

			this.sqlConnection = sqlConnection;
			this.lastKnownConnectionType = ConnectionType.SqlConnection;

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spU_TransactionDetails'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spU_TransactionDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif
		}

		/// <summary>
		/// Sets the System.Data.SqlClient.SqlTransaction to be used
		/// against the SQL Server database.
		/// </summary>
		/// <param name="sqlTransaction">A valid System.Data.SqlClient.SqlTransaction object.</param>
		public void SetUpConnection(System.Data.SqlClient.SqlTransaction sqlTransaction) {

			if (sqlTransaction == null || sqlTransaction.Connection == null) {
				throw new ArgumentNullException("sqlTransaction", "Invalid connection!");
			}

			this.sqlTransaction= sqlTransaction;
			this.lastKnownConnectionType = ConnectionType.SqlTransaction;

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spU_TransactionDetails'";
				sqlCommand.Transaction = sqlTransaction;

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlTransaction.Connection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spU_TransactionDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif
		}

		/// <summary>
		/// Disposes the current instance of this object.
		/// </summary>
		public void Dispose() {

			Dispose(true);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool disposing) {

			if (disposing) {

				this.internal_Param_RETURN_VALUE = System.Data.SqlTypes.SqlInt32.Null;
				this.internal_Param_Id = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_VoucherNumber = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_VoucherNumber = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_TransactionNumber = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_TransactionNumber = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_CustomerId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_CustomerId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_BeneficeryId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_BeneficeryId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_BeneficeryBankId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_BeneficeryBankId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PaymentMode = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_PaymentMode = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PurposeOfTransfer = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_PurposeOfTransfer = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PayInCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_PayInCurrencyId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PayInAmount = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_PayInAmount = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PayOutCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_PayOutCurrencyId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PayOutAmount = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_PayOutAmount = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_Commission = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_Commission = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_Question = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_Question = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_Answer = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_Answer = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_MessageToBeneficery = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_MessageToBeneficery = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_MessageToPayOutAgent = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_MessageToPayOutAgent = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_BankExchangeRateForPayInCurrency = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_BankExchangeRateForPayInCurrency = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_BankExchangeRateForPayOutCurrency = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_BankExchangeRateForPayOutCurrency = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PayInCurrencyGroup = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_PayInCurrencyGroup = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PayOutCurrencyGroup = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_PayOutCurrencyGroup = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_FinalBankExchangeRate = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_FinalBankExchangeRate = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_AgencyMarginPercent = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_AgencyMarginPercent = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_AgencyExchangeRate = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_AgencyExchangeRate = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_AgentMarginPercent = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_AgentMarginPercent = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_AgentExchangeRate = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_AgentExchangeRate = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_AssociatedBankId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_AssociatedBankId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PayOutLocationId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_PayOutLocationId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PayInAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_PayInAgentUserId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PayInAgentLocationId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_PayInAgentLocationId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PayInDateTime = System.Data.SqlTypes.SqlDateTime.Null;
				this.internal_Param_ConsiderNull_PayInDateTime = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_RecommendedPayOutAgentId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_RecommendedPayOutAgentId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_ActualPayOutAgentId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_ActualPayOutAgentId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PayOutAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_PayOutAgentUserId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_PayOutDateTime = System.Data.SqlTypes.SqlDateTime.Null;
				this.internal_Param_ConsiderNull_PayOutDateTime = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_CollectedBeneficeryIdDetails = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_CollectedBeneficeryIdDetails = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_IsOpenTransaction = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_ConsiderNull_IsOpenTransaction = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_Status = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_Status = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_SettlementStatus = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_SettlementStatus = System.Data.SqlTypes.SqlBoolean.Null;

				this.sqlException = null;
				this.otherException = null;
				this.connectionString = null;
				this.sqlConnection = null;
				this.sqlTransaction = null;

			}
		}

		/// <summary>
		/// This member overrides 'Object.Finalize'.
		/// </summary>
		~spU_TransactionDetails() {

			Dispose(false);
		}

		/// <summary>
		/// Returns the stored procedure name for which this class was built, i.e. 'spU_TransactionDetails'.
		/// </summary>
		public string StoredProcedureName {

			get {

				return("spU_TransactionDetails");
			}
		}

		private System.Data.SqlTypes.SqlInt32 internal_Param_RETURN_VALUE;

		private System.Data.SqlTypes.SqlGuid internal_Param_Id;
		internal bool internal_Param_Id_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_VoucherNumber;
		internal bool internal_Param_VoucherNumber_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_VoucherNumber;
		internal bool internal_Param_ConsiderNull_VoucherNumber_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_TransactionNumber;
		internal bool internal_Param_TransactionNumber_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_TransactionNumber;
		internal bool internal_Param_ConsiderNull_TransactionNumber_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_CustomerId;
		internal bool internal_Param_CustomerId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_CustomerId;
		internal bool internal_Param_ConsiderNull_CustomerId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_BeneficeryId;
		internal bool internal_Param_BeneficeryId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_BeneficeryId;
		internal bool internal_Param_ConsiderNull_BeneficeryId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_BeneficeryBankId;
		internal bool internal_Param_BeneficeryBankId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_BeneficeryBankId;
		internal bool internal_Param_ConsiderNull_BeneficeryBankId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_PaymentMode;
		internal bool internal_Param_PaymentMode_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PaymentMode;
		internal bool internal_Param_ConsiderNull_PaymentMode_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_PurposeOfTransfer;
		internal bool internal_Param_PurposeOfTransfer_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PurposeOfTransfer;
		internal bool internal_Param_ConsiderNull_PurposeOfTransfer_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_PayInCurrencyId;
		internal bool internal_Param_PayInCurrencyId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PayInCurrencyId;
		internal bool internal_Param_ConsiderNull_PayInCurrencyId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_PayInAmount;
		internal bool internal_Param_PayInAmount_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PayInAmount;
		internal bool internal_Param_ConsiderNull_PayInAmount_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_PayOutCurrencyId;
		internal bool internal_Param_PayOutCurrencyId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PayOutCurrencyId;
		internal bool internal_Param_ConsiderNull_PayOutCurrencyId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_PayOutAmount;
		internal bool internal_Param_PayOutAmount_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PayOutAmount;
		internal bool internal_Param_ConsiderNull_PayOutAmount_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_Commission;
		internal bool internal_Param_Commission_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_Commission;
		internal bool internal_Param_ConsiderNull_Commission_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Question;
		internal bool internal_Param_Question_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_Question;
		internal bool internal_Param_ConsiderNull_Question_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Answer;
		internal bool internal_Param_Answer_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_Answer;
		internal bool internal_Param_ConsiderNull_Answer_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_MessageToBeneficery;
		internal bool internal_Param_MessageToBeneficery_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_MessageToBeneficery;
		internal bool internal_Param_ConsiderNull_MessageToBeneficery_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_MessageToPayOutAgent;
		internal bool internal_Param_MessageToPayOutAgent_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_MessageToPayOutAgent;
		internal bool internal_Param_ConsiderNull_MessageToPayOutAgent_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_BankExchangeRateForPayInCurrency;
		internal bool internal_Param_BankExchangeRateForPayInCurrency_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_BankExchangeRateForPayInCurrency;
		internal bool internal_Param_ConsiderNull_BankExchangeRateForPayInCurrency_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_BankExchangeRateForPayOutCurrency;
		internal bool internal_Param_BankExchangeRateForPayOutCurrency_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_BankExchangeRateForPayOutCurrency;
		internal bool internal_Param_ConsiderNull_BankExchangeRateForPayOutCurrency_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_PayInCurrencyGroup;
		internal bool internal_Param_PayInCurrencyGroup_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PayInCurrencyGroup;
		internal bool internal_Param_ConsiderNull_PayInCurrencyGroup_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_PayOutCurrencyGroup;
		internal bool internal_Param_PayOutCurrencyGroup_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PayOutCurrencyGroup;
		internal bool internal_Param_ConsiderNull_PayOutCurrencyGroup_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_FinalBankExchangeRate;
		internal bool internal_Param_FinalBankExchangeRate_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_FinalBankExchangeRate;
		internal bool internal_Param_ConsiderNull_FinalBankExchangeRate_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_AgencyMarginPercent;
		internal bool internal_Param_AgencyMarginPercent_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_AgencyMarginPercent;
		internal bool internal_Param_ConsiderNull_AgencyMarginPercent_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_AgencyExchangeRate;
		internal bool internal_Param_AgencyExchangeRate_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_AgencyExchangeRate;
		internal bool internal_Param_ConsiderNull_AgencyExchangeRate_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_AgentMarginPercent;
		internal bool internal_Param_AgentMarginPercent_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_AgentMarginPercent;
		internal bool internal_Param_ConsiderNull_AgentMarginPercent_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_AgentExchangeRate;
		internal bool internal_Param_AgentExchangeRate_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_AgentExchangeRate;
		internal bool internal_Param_ConsiderNull_AgentExchangeRate_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_AssociatedBankId;
		internal bool internal_Param_AssociatedBankId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_AssociatedBankId;
		internal bool internal_Param_ConsiderNull_AssociatedBankId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_PayOutLocationId;
		internal bool internal_Param_PayOutLocationId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PayOutLocationId;
		internal bool internal_Param_ConsiderNull_PayOutLocationId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_PayInAgentUserId;
		internal bool internal_Param_PayInAgentUserId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PayInAgentUserId;
		internal bool internal_Param_ConsiderNull_PayInAgentUserId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_PayInAgentLocationId;
		internal bool internal_Param_PayInAgentLocationId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PayInAgentLocationId;
		internal bool internal_Param_ConsiderNull_PayInAgentLocationId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDateTime internal_Param_PayInDateTime;
		internal bool internal_Param_PayInDateTime_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PayInDateTime;
		internal bool internal_Param_ConsiderNull_PayInDateTime_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_RecommendedPayOutAgentId;
		internal bool internal_Param_RecommendedPayOutAgentId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_RecommendedPayOutAgentId;
		internal bool internal_Param_ConsiderNull_RecommendedPayOutAgentId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_ActualPayOutAgentId;
		internal bool internal_Param_ActualPayOutAgentId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_ActualPayOutAgentId;
		internal bool internal_Param_ConsiderNull_ActualPayOutAgentId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_PayOutAgentUserId;
		internal bool internal_Param_PayOutAgentUserId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PayOutAgentUserId;
		internal bool internal_Param_ConsiderNull_PayOutAgentUserId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDateTime internal_Param_PayOutDateTime;
		internal bool internal_Param_PayOutDateTime_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_PayOutDateTime;
		internal bool internal_Param_ConsiderNull_PayOutDateTime_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_CollectedBeneficeryIdDetails;
		internal bool internal_Param_CollectedBeneficeryIdDetails_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_CollectedBeneficeryIdDetails;
		internal bool internal_Param_ConsiderNull_CollectedBeneficeryIdDetails_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_IsOpenTransaction;
		internal bool internal_Param_IsOpenTransaction_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_IsOpenTransaction;
		internal bool internal_Param_ConsiderNull_IsOpenTransaction_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Status;
		internal bool internal_Param_Status_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_Status;
		internal bool internal_Param_ConsiderNull_Status_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_SettlementStatus;
		internal bool internal_Param_SettlementStatus_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_SettlementStatus;
		internal bool internal_Param_ConsiderNull_SettlementStatus_UseDefaultValue = true;


		/// <summary>
		/// Allows you to know at which step did the error occured if one occured. See <see cref="ErrorSource" />
		/// for more information.
		/// </summary>
		public ErrorSource ErrorSource {

			get {

				return(this.errorSource);
			}
		}

		/// <summary>
		/// This method allows you to reset the parameter object. Please note that this
		/// method resets all the parameters members except the connection information and
		/// the command time-out which are left in their current state.
		/// </summary>
		public void Reset() {


			this.internal_Param_RETURN_VALUE = System.Data.SqlTypes.SqlInt32.Null;

			this.internal_Param_Id = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_Id_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_VoucherNumber = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_VoucherNumber_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_VoucherNumber = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_VoucherNumber_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_TransactionNumber = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_TransactionNumber_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_TransactionNumber = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_TransactionNumber_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_CustomerId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_CustomerId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_CustomerId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_CustomerId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_BeneficeryId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_BeneficeryId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_BeneficeryId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_BeneficeryId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_BeneficeryBankId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_BeneficeryBankId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_BeneficeryBankId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_BeneficeryBankId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PaymentMode = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_PaymentMode_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PaymentMode = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PaymentMode_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PurposeOfTransfer = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_PurposeOfTransfer_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PurposeOfTransfer = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PurposeOfTransfer_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayInCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_PayInCurrencyId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PayInCurrencyId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PayInCurrencyId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayInAmount = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_PayInAmount_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PayInAmount = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PayInAmount_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayOutCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_PayOutCurrencyId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PayOutCurrencyId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PayOutCurrencyId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayOutAmount = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_PayOutAmount_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PayOutAmount = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PayOutAmount_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Commission = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_Commission_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_Commission = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_Commission_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Question = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Question_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_Question = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_Question_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Answer = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Answer_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_Answer = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_Answer_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_MessageToBeneficery = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_MessageToBeneficery_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_MessageToBeneficery = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_MessageToBeneficery_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_MessageToPayOutAgent = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_MessageToPayOutAgent_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_MessageToPayOutAgent = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_MessageToPayOutAgent_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_BankExchangeRateForPayInCurrency = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_BankExchangeRateForPayInCurrency_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_BankExchangeRateForPayInCurrency = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_BankExchangeRateForPayInCurrency_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_BankExchangeRateForPayOutCurrency = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_BankExchangeRateForPayOutCurrency_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_BankExchangeRateForPayOutCurrency = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_BankExchangeRateForPayOutCurrency_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayInCurrencyGroup = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_PayInCurrencyGroup_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PayInCurrencyGroup = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PayInCurrencyGroup_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayOutCurrencyGroup = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_PayOutCurrencyGroup_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PayOutCurrencyGroup = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PayOutCurrencyGroup_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_FinalBankExchangeRate = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_FinalBankExchangeRate_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_FinalBankExchangeRate = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_FinalBankExchangeRate_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_AgencyMarginPercent = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_AgencyMarginPercent_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_AgencyMarginPercent = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_AgencyMarginPercent_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_AgencyExchangeRate = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_AgencyExchangeRate_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_AgencyExchangeRate = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_AgencyExchangeRate_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_AgentMarginPercent = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_AgentMarginPercent_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_AgentMarginPercent = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_AgentMarginPercent_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_AgentExchangeRate = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_AgentExchangeRate_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_AgentExchangeRate = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_AgentExchangeRate_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_AssociatedBankId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_AssociatedBankId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_AssociatedBankId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_AssociatedBankId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayOutLocationId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_PayOutLocationId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PayOutLocationId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PayOutLocationId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayInAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_PayInAgentUserId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PayInAgentUserId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PayInAgentUserId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayInAgentLocationId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_PayInAgentLocationId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PayInAgentLocationId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PayInAgentLocationId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayInDateTime = System.Data.SqlTypes.SqlDateTime.Null;
			this.internal_Param_PayInDateTime_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PayInDateTime = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PayInDateTime_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_RecommendedPayOutAgentId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_RecommendedPayOutAgentId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_RecommendedPayOutAgentId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_RecommendedPayOutAgentId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ActualPayOutAgentId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_ActualPayOutAgentId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_ActualPayOutAgentId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_ActualPayOutAgentId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayOutAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_PayOutAgentUserId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PayOutAgentUserId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PayOutAgentUserId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayOutDateTime = System.Data.SqlTypes.SqlDateTime.Null;
			this.internal_Param_PayOutDateTime_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_PayOutDateTime = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_PayOutDateTime_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_CollectedBeneficeryIdDetails = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_CollectedBeneficeryIdDetails_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_CollectedBeneficeryIdDetails = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_CollectedBeneficeryIdDetails_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_IsOpenTransaction = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_IsOpenTransaction_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_IsOpenTransaction = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_IsOpenTransaction_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Status = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Status_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_Status = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_Status_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_SettlementStatus = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_SettlementStatus_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_SettlementStatus = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_SettlementStatus_UseDefaultValue = this.useDefaultValue;

			this.errorSource = ErrorSource.NotAvailable;
			this.sqlException = null;
			this.otherException = null;
		}

		/// <summary>
		/// Returns the connection string to be used against the 
		/// SQL Server database.
		/// </summary>
		public System.String ConnectionString {

			get {

				return(this.connectionString);
			}
		}
            
		/// <summary>
		/// Returns the System.Data.SqlClient.SqlConnection to be used
		/// against the SQL Server database.
		/// </summary>
		public System.Data.SqlClient.SqlConnection SqlConnection {

			get {

				return(this.sqlConnection);
			}
		}

		/// <summary>
		/// Returns the System.Data.SqlClient.SqlTransaction to be used
		/// against the SQL Server database.
		/// </summary>
		public System.Data.SqlClient.SqlTransaction SqlTransaction {

			get {

				return(this.sqlTransaction);
			}
		}

		/// <summary>
		/// Returns the current type of connection that is going or has been used
		/// against the Sql Server database. It can be: ConnectionString, SqlConnection
		/// or SqlTransaction
		/// </summary>
		public ConnectionType ConnectionType {

			get {

				return(this.lastKnownConnectionType );
			}
		}

		/// <summary>
		/// In case of an ADO exception, returns the SqlException exception (System.Data.SqlClient.SqlException)
		/// that has occured.
		/// </summary>
		public System.Data.SqlClient.SqlException SqlException {

			get {

				return(this.sqlException);
			}
		}

		/// <summary>
		/// In case of a System exception, returns the standard exception (System.Exception) that 
		/// has occured.
		/// </summary>
		public System.Exception OtherException {

			get {

				return(this.otherException);
			}
		}

		/// <summary>
		/// Sets or returns the time-out (in seconds) to be use by the ADO command object
		/// (System.Data.SqlClient.SqlCommand).
		/// <remarks>
		/// Default value is 30 seconds.
		/// </remarks>
		/// </summary>
		public int CommandTimeOut {

			get {

				return(this.commandTimeOut);
			}

			set {

				this.commandTimeOut = value;
				if (this.commandTimeOut <= 0) {

					this.commandTimeOut = 30;
				}
			}
		}


		/// <summary>
		/// Returns the value returned back by the stored procedure execution.
		/// </summary>
		public System.Data.SqlTypes.SqlInt32 Param_RETURN_VALUE {

			get {

				return(this.internal_Param_RETURN_VALUE);
			}
		}
            
		internal void internal_Set_RETURN_VALUE(System.Data.SqlTypes.SqlInt32 value) {

			this.internal_Param_RETURN_VALUE = value;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Id'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [uniqueidentifier]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_Id_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_Id {

			get {

				if (this.internal_Param_Id_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Id);
			}

			set {

				this.internal_Param_Id_UseDefaultValue = false;
				this.internal_Param_Id = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Id' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Id_UseDefaultValue() {

			this.internal_Param_Id_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@VoucherNumber'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [decimal](18, 0)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_VoucherNumber_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_VoucherNumber {

			get {

				if (this.internal_Param_VoucherNumber_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_VoucherNumber);
			}

			set {

				this.internal_Param_VoucherNumber_UseDefaultValue = false;
				this.internal_Param_VoucherNumber = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@VoucherNumber' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_VoucherNumber_UseDefaultValue() {

			this.internal_Param_VoucherNumber_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_VoucherNumber'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_VoucherNumber_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_VoucherNumber {

			get {

				if (this.internal_Param_ConsiderNull_VoucherNumber_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_VoucherNumber);
			}

			set {

				this.internal_Param_ConsiderNull_VoucherNumber_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_VoucherNumber = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_VoucherNumber' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_VoucherNumber_UseDefaultValue() {

			this.internal_Param_ConsiderNull_VoucherNumber_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@TransactionNumber'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](40)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_TransactionNumber_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_TransactionNumber {

			get {

				if (this.internal_Param_TransactionNumber_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_TransactionNumber);
			}

			set {

				this.internal_Param_TransactionNumber_UseDefaultValue = false;
				this.internal_Param_TransactionNumber = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@TransactionNumber' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_TransactionNumber_UseDefaultValue() {

			this.internal_Param_TransactionNumber_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_TransactionNumber'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_TransactionNumber_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_TransactionNumber {

			get {

				if (this.internal_Param_ConsiderNull_TransactionNumber_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_TransactionNumber);
			}

			set {

				this.internal_Param_ConsiderNull_TransactionNumber_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_TransactionNumber = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_TransactionNumber' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_TransactionNumber_UseDefaultValue() {

			this.internal_Param_ConsiderNull_TransactionNumber_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@CustomerId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [uniqueidentifier]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_CustomerId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_CustomerId {

			get {

				if (this.internal_Param_CustomerId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_CustomerId);
			}

			set {

				this.internal_Param_CustomerId_UseDefaultValue = false;
				this.internal_Param_CustomerId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@CustomerId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_CustomerId_UseDefaultValue() {

			this.internal_Param_CustomerId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_CustomerId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_CustomerId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_CustomerId {

			get {

				if (this.internal_Param_ConsiderNull_CustomerId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_CustomerId);
			}

			set {

				this.internal_Param_ConsiderNull_CustomerId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_CustomerId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_CustomerId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_CustomerId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_CustomerId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@BeneficeryId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [uniqueidentifier]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_BeneficeryId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_BeneficeryId {

			get {

				if (this.internal_Param_BeneficeryId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_BeneficeryId);
			}

			set {

				this.internal_Param_BeneficeryId_UseDefaultValue = false;
				this.internal_Param_BeneficeryId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@BeneficeryId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_BeneficeryId_UseDefaultValue() {

			this.internal_Param_BeneficeryId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_BeneficeryId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_BeneficeryId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_BeneficeryId {

			get {

				if (this.internal_Param_ConsiderNull_BeneficeryId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_BeneficeryId);
			}

			set {

				this.internal_Param_ConsiderNull_BeneficeryId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_BeneficeryId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_BeneficeryId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_BeneficeryId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_BeneficeryId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@BeneficeryBankId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [uniqueidentifier]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_BeneficeryBankId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_BeneficeryBankId {

			get {

				if (this.internal_Param_BeneficeryBankId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_BeneficeryBankId);
			}

			set {

				this.internal_Param_BeneficeryBankId_UseDefaultValue = false;
				this.internal_Param_BeneficeryBankId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@BeneficeryBankId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_BeneficeryBankId_UseDefaultValue() {

			this.internal_Param_BeneficeryBankId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_BeneficeryBankId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_BeneficeryBankId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_BeneficeryBankId {

			get {

				if (this.internal_Param_ConsiderNull_BeneficeryBankId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_BeneficeryBankId);
			}

			set {

				this.internal_Param_ConsiderNull_BeneficeryBankId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_BeneficeryBankId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_BeneficeryBankId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_BeneficeryBankId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_BeneficeryBankId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PaymentMode'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](100)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PaymentMode_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_PaymentMode {

			get {

				if (this.internal_Param_PaymentMode_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PaymentMode);
			}

			set {

				this.internal_Param_PaymentMode_UseDefaultValue = false;
				this.internal_Param_PaymentMode = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PaymentMode' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PaymentMode_UseDefaultValue() {

			this.internal_Param_PaymentMode_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PaymentMode'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PaymentMode_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PaymentMode {

			get {

				if (this.internal_Param_ConsiderNull_PaymentMode_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PaymentMode);
			}

			set {

				this.internal_Param_ConsiderNull_PaymentMode_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PaymentMode = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PaymentMode' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PaymentMode_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PaymentMode_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PurposeOfTransfer'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](100)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PurposeOfTransfer_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_PurposeOfTransfer {

			get {

				if (this.internal_Param_PurposeOfTransfer_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PurposeOfTransfer);
			}

			set {

				this.internal_Param_PurposeOfTransfer_UseDefaultValue = false;
				this.internal_Param_PurposeOfTransfer = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PurposeOfTransfer' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PurposeOfTransfer_UseDefaultValue() {

			this.internal_Param_PurposeOfTransfer_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PurposeOfTransfer'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PurposeOfTransfer_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PurposeOfTransfer {

			get {

				if (this.internal_Param_ConsiderNull_PurposeOfTransfer_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PurposeOfTransfer);
			}

			set {

				this.internal_Param_ConsiderNull_PurposeOfTransfer_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PurposeOfTransfer = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PurposeOfTransfer' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PurposeOfTransfer_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PurposeOfTransfer_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PayInCurrencyId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [uniqueidentifier]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PayInCurrencyId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_PayInCurrencyId {

			get {

				if (this.internal_Param_PayInCurrencyId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PayInCurrencyId);
			}

			set {

				this.internal_Param_PayInCurrencyId_UseDefaultValue = false;
				this.internal_Param_PayInCurrencyId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PayInCurrencyId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PayInCurrencyId_UseDefaultValue() {

			this.internal_Param_PayInCurrencyId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PayInCurrencyId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PayInCurrencyId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PayInCurrencyId {

			get {

				if (this.internal_Param_ConsiderNull_PayInCurrencyId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PayInCurrencyId);
			}

			set {

				this.internal_Param_ConsiderNull_PayInCurrencyId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PayInCurrencyId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PayInCurrencyId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PayInCurrencyId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PayInCurrencyId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PayInAmount'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [decimal](38, 6)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PayInAmount_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_PayInAmount {

			get {

				if (this.internal_Param_PayInAmount_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PayInAmount);
			}

			set {

				this.internal_Param_PayInAmount_UseDefaultValue = false;
				this.internal_Param_PayInAmount = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PayInAmount' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PayInAmount_UseDefaultValue() {

			this.internal_Param_PayInAmount_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PayInAmount'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PayInAmount_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PayInAmount {

			get {

				if (this.internal_Param_ConsiderNull_PayInAmount_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PayInAmount);
			}

			set {

				this.internal_Param_ConsiderNull_PayInAmount_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PayInAmount = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PayInAmount' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PayInAmount_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PayInAmount_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PayOutCurrencyId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [uniqueidentifier]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PayOutCurrencyId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_PayOutCurrencyId {

			get {

				if (this.internal_Param_PayOutCurrencyId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PayOutCurrencyId);
			}

			set {

				this.internal_Param_PayOutCurrencyId_UseDefaultValue = false;
				this.internal_Param_PayOutCurrencyId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PayOutCurrencyId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PayOutCurrencyId_UseDefaultValue() {

			this.internal_Param_PayOutCurrencyId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PayOutCurrencyId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PayOutCurrencyId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PayOutCurrencyId {

			get {

				if (this.internal_Param_ConsiderNull_PayOutCurrencyId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PayOutCurrencyId);
			}

			set {

				this.internal_Param_ConsiderNull_PayOutCurrencyId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PayOutCurrencyId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PayOutCurrencyId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PayOutCurrencyId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PayOutCurrencyId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PayOutAmount'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [decimal](38, 6)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PayOutAmount_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_PayOutAmount {

			get {

				if (this.internal_Param_PayOutAmount_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PayOutAmount);
			}

			set {

				this.internal_Param_PayOutAmount_UseDefaultValue = false;
				this.internal_Param_PayOutAmount = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PayOutAmount' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PayOutAmount_UseDefaultValue() {

			this.internal_Param_PayOutAmount_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PayOutAmount'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PayOutAmount_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PayOutAmount {

			get {

				if (this.internal_Param_ConsiderNull_PayOutAmount_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PayOutAmount);
			}

			set {

				this.internal_Param_ConsiderNull_PayOutAmount_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PayOutAmount = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PayOutAmount' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PayOutAmount_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PayOutAmount_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Commission'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [decimal](18, 2)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_Commission_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_Commission {

			get {

				if (this.internal_Param_Commission_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Commission);
			}

			set {

				this.internal_Param_Commission_UseDefaultValue = false;
				this.internal_Param_Commission = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Commission' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Commission_UseDefaultValue() {

			this.internal_Param_Commission_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_Commission'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_Commission_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_Commission {

			get {

				if (this.internal_Param_ConsiderNull_Commission_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_Commission);
			}

			set {

				this.internal_Param_ConsiderNull_Commission_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_Commission = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_Commission' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_Commission_UseDefaultValue() {

			this.internal_Param_ConsiderNull_Commission_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Question'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](400)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_Question_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_Question {

			get {

				if (this.internal_Param_Question_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Question);
			}

			set {

				this.internal_Param_Question_UseDefaultValue = false;
				this.internal_Param_Question = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Question' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Question_UseDefaultValue() {

			this.internal_Param_Question_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_Question'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_Question_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_Question {

			get {

				if (this.internal_Param_ConsiderNull_Question_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_Question);
			}

			set {

				this.internal_Param_ConsiderNull_Question_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_Question = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_Question' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_Question_UseDefaultValue() {

			this.internal_Param_ConsiderNull_Question_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Answer'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](400)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_Answer_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_Answer {

			get {

				if (this.internal_Param_Answer_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Answer);
			}

			set {

				this.internal_Param_Answer_UseDefaultValue = false;
				this.internal_Param_Answer = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Answer' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Answer_UseDefaultValue() {

			this.internal_Param_Answer_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_Answer'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_Answer_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_Answer {

			get {

				if (this.internal_Param_ConsiderNull_Answer_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_Answer);
			}

			set {

				this.internal_Param_ConsiderNull_Answer_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_Answer = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_Answer' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_Answer_UseDefaultValue() {

			this.internal_Param_ConsiderNull_Answer_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@MessageToBeneficery'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](600)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_MessageToBeneficery_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_MessageToBeneficery {

			get {

				if (this.internal_Param_MessageToBeneficery_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_MessageToBeneficery);
			}

			set {

				this.internal_Param_MessageToBeneficery_UseDefaultValue = false;
				this.internal_Param_MessageToBeneficery = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@MessageToBeneficery' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_MessageToBeneficery_UseDefaultValue() {

			this.internal_Param_MessageToBeneficery_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_MessageToBeneficery'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_MessageToBeneficery_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_MessageToBeneficery {

			get {

				if (this.internal_Param_ConsiderNull_MessageToBeneficery_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_MessageToBeneficery);
			}

			set {

				this.internal_Param_ConsiderNull_MessageToBeneficery_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_MessageToBeneficery = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_MessageToBeneficery' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_MessageToBeneficery_UseDefaultValue() {

			this.internal_Param_ConsiderNull_MessageToBeneficery_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@MessageToPayOutAgent'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](600)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_MessageToPayOutAgent_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_MessageToPayOutAgent {

			get {

				if (this.internal_Param_MessageToPayOutAgent_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_MessageToPayOutAgent);
			}

			set {

				this.internal_Param_MessageToPayOutAgent_UseDefaultValue = false;
				this.internal_Param_MessageToPayOutAgent = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@MessageToPayOutAgent' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_MessageToPayOutAgent_UseDefaultValue() {

			this.internal_Param_MessageToPayOutAgent_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_MessageToPayOutAgent'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_MessageToPayOutAgent_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_MessageToPayOutAgent {

			get {

				if (this.internal_Param_ConsiderNull_MessageToPayOutAgent_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_MessageToPayOutAgent);
			}

			set {

				this.internal_Param_ConsiderNull_MessageToPayOutAgent_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_MessageToPayOutAgent = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_MessageToPayOutAgent' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_MessageToPayOutAgent_UseDefaultValue() {

			this.internal_Param_ConsiderNull_MessageToPayOutAgent_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@BankExchangeRateForPayInCurrency'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [decimal](18, 6)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_BankExchangeRateForPayInCurrency_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_BankExchangeRateForPayInCurrency {

			get {

				if (this.internal_Param_BankExchangeRateForPayInCurrency_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_BankExchangeRateForPayInCurrency);
			}

			set {

				this.internal_Param_BankExchangeRateForPayInCurrency_UseDefaultValue = false;
				this.internal_Param_BankExchangeRateForPayInCurrency = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@BankExchangeRateForPayInCurrency' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_BankExchangeRateForPayInCurrency_UseDefaultValue() {

			this.internal_Param_BankExchangeRateForPayInCurrency_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_BankExchangeRateForPayInCurrency'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_BankExchangeRateForPayInCurrency_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_BankExchangeRateForPayInCurrency {

			get {

				if (this.internal_Param_ConsiderNull_BankExchangeRateForPayInCurrency_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_BankExchangeRateForPayInCurrency);
			}

			set {

				this.internal_Param_ConsiderNull_BankExchangeRateForPayInCurrency_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_BankExchangeRateForPayInCurrency = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_BankExchangeRateForPayInCurrency' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_BankExchangeRateForPayInCurrency_UseDefaultValue() {

			this.internal_Param_ConsiderNull_BankExchangeRateForPayInCurrency_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@BankExchangeRateForPayOutCurrency'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [decimal](18, 6)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_BankExchangeRateForPayOutCurrency_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_BankExchangeRateForPayOutCurrency {

			get {

				if (this.internal_Param_BankExchangeRateForPayOutCurrency_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_BankExchangeRateForPayOutCurrency);
			}

			set {

				this.internal_Param_BankExchangeRateForPayOutCurrency_UseDefaultValue = false;
				this.internal_Param_BankExchangeRateForPayOutCurrency = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@BankExchangeRateForPayOutCurrency' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_BankExchangeRateForPayOutCurrency_UseDefaultValue() {

			this.internal_Param_BankExchangeRateForPayOutCurrency_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_BankExchangeRateForPayOutCurrency'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_BankExchangeRateForPayOutCurrency_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_BankExchangeRateForPayOutCurrency {

			get {

				if (this.internal_Param_ConsiderNull_BankExchangeRateForPayOutCurrency_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_BankExchangeRateForPayOutCurrency);
			}

			set {

				this.internal_Param_ConsiderNull_BankExchangeRateForPayOutCurrency_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_BankExchangeRateForPayOutCurrency = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_BankExchangeRateForPayOutCurrency' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_BankExchangeRateForPayOutCurrency_UseDefaultValue() {

			this.internal_Param_ConsiderNull_BankExchangeRateForPayOutCurrency_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PayInCurrencyGroup'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](100)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PayInCurrencyGroup_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_PayInCurrencyGroup {

			get {

				if (this.internal_Param_PayInCurrencyGroup_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PayInCurrencyGroup);
			}

			set {

				this.internal_Param_PayInCurrencyGroup_UseDefaultValue = false;
				this.internal_Param_PayInCurrencyGroup = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PayInCurrencyGroup' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PayInCurrencyGroup_UseDefaultValue() {

			this.internal_Param_PayInCurrencyGroup_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PayInCurrencyGroup'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PayInCurrencyGroup_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PayInCurrencyGroup {

			get {

				if (this.internal_Param_ConsiderNull_PayInCurrencyGroup_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PayInCurrencyGroup);
			}

			set {

				this.internal_Param_ConsiderNull_PayInCurrencyGroup_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PayInCurrencyGroup = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PayInCurrencyGroup' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PayInCurrencyGroup_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PayInCurrencyGroup_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PayOutCurrencyGroup'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](100)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PayOutCurrencyGroup_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_PayOutCurrencyGroup {

			get {

				if (this.internal_Param_PayOutCurrencyGroup_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PayOutCurrencyGroup);
			}

			set {

				this.internal_Param_PayOutCurrencyGroup_UseDefaultValue = false;
				this.internal_Param_PayOutCurrencyGroup = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PayOutCurrencyGroup' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PayOutCurrencyGroup_UseDefaultValue() {

			this.internal_Param_PayOutCurrencyGroup_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PayOutCurrencyGroup'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PayOutCurrencyGroup_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PayOutCurrencyGroup {

			get {

				if (this.internal_Param_ConsiderNull_PayOutCurrencyGroup_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PayOutCurrencyGroup);
			}

			set {

				this.internal_Param_ConsiderNull_PayOutCurrencyGroup_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PayOutCurrencyGroup = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PayOutCurrencyGroup' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PayOutCurrencyGroup_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PayOutCurrencyGroup_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@FinalBankExchangeRate'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [decimal](18, 6)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_FinalBankExchangeRate_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_FinalBankExchangeRate {

			get {

				if (this.internal_Param_FinalBankExchangeRate_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_FinalBankExchangeRate);
			}

			set {

				this.internal_Param_FinalBankExchangeRate_UseDefaultValue = false;
				this.internal_Param_FinalBankExchangeRate = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@FinalBankExchangeRate' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_FinalBankExchangeRate_UseDefaultValue() {

			this.internal_Param_FinalBankExchangeRate_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_FinalBankExchangeRate'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_FinalBankExchangeRate_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_FinalBankExchangeRate {

			get {

				if (this.internal_Param_ConsiderNull_FinalBankExchangeRate_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_FinalBankExchangeRate);
			}

			set {

				this.internal_Param_ConsiderNull_FinalBankExchangeRate_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_FinalBankExchangeRate = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_FinalBankExchangeRate' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_FinalBankExchangeRate_UseDefaultValue() {

			this.internal_Param_ConsiderNull_FinalBankExchangeRate_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@AgencyMarginPercent'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [decimal](18, 6)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_AgencyMarginPercent_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_AgencyMarginPercent {

			get {

				if (this.internal_Param_AgencyMarginPercent_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_AgencyMarginPercent);
			}

			set {

				this.internal_Param_AgencyMarginPercent_UseDefaultValue = false;
				this.internal_Param_AgencyMarginPercent = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@AgencyMarginPercent' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_AgencyMarginPercent_UseDefaultValue() {

			this.internal_Param_AgencyMarginPercent_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_AgencyMarginPercent'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_AgencyMarginPercent_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_AgencyMarginPercent {

			get {

				if (this.internal_Param_ConsiderNull_AgencyMarginPercent_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_AgencyMarginPercent);
			}

			set {

				this.internal_Param_ConsiderNull_AgencyMarginPercent_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_AgencyMarginPercent = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_AgencyMarginPercent' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_AgencyMarginPercent_UseDefaultValue() {

			this.internal_Param_ConsiderNull_AgencyMarginPercent_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@AgencyExchangeRate'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [decimal](18, 0)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_AgencyExchangeRate_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_AgencyExchangeRate {

			get {

				if (this.internal_Param_AgencyExchangeRate_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_AgencyExchangeRate);
			}

			set {

				this.internal_Param_AgencyExchangeRate_UseDefaultValue = false;
				this.internal_Param_AgencyExchangeRate = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@AgencyExchangeRate' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_AgencyExchangeRate_UseDefaultValue() {

			this.internal_Param_AgencyExchangeRate_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_AgencyExchangeRate'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_AgencyExchangeRate_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_AgencyExchangeRate {

			get {

				if (this.internal_Param_ConsiderNull_AgencyExchangeRate_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_AgencyExchangeRate);
			}

			set {

				this.internal_Param_ConsiderNull_AgencyExchangeRate_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_AgencyExchangeRate = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_AgencyExchangeRate' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_AgencyExchangeRate_UseDefaultValue() {

			this.internal_Param_ConsiderNull_AgencyExchangeRate_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@AgentMarginPercent'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [decimal](18, 6)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_AgentMarginPercent_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_AgentMarginPercent {

			get {

				if (this.internal_Param_AgentMarginPercent_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_AgentMarginPercent);
			}

			set {

				this.internal_Param_AgentMarginPercent_UseDefaultValue = false;
				this.internal_Param_AgentMarginPercent = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@AgentMarginPercent' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_AgentMarginPercent_UseDefaultValue() {

			this.internal_Param_AgentMarginPercent_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_AgentMarginPercent'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_AgentMarginPercent_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_AgentMarginPercent {

			get {

				if (this.internal_Param_ConsiderNull_AgentMarginPercent_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_AgentMarginPercent);
			}

			set {

				this.internal_Param_ConsiderNull_AgentMarginPercent_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_AgentMarginPercent = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_AgentMarginPercent' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_AgentMarginPercent_UseDefaultValue() {

			this.internal_Param_ConsiderNull_AgentMarginPercent_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@AgentExchangeRate'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [decimal](18, 0)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_AgentExchangeRate_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_AgentExchangeRate {

			get {

				if (this.internal_Param_AgentExchangeRate_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_AgentExchangeRate);
			}

			set {

				this.internal_Param_AgentExchangeRate_UseDefaultValue = false;
				this.internal_Param_AgentExchangeRate = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@AgentExchangeRate' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_AgentExchangeRate_UseDefaultValue() {

			this.internal_Param_AgentExchangeRate_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_AgentExchangeRate'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_AgentExchangeRate_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_AgentExchangeRate {

			get {

				if (this.internal_Param_ConsiderNull_AgentExchangeRate_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_AgentExchangeRate);
			}

			set {

				this.internal_Param_ConsiderNull_AgentExchangeRate_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_AgentExchangeRate = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_AgentExchangeRate' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_AgentExchangeRate_UseDefaultValue() {

			this.internal_Param_ConsiderNull_AgentExchangeRate_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@AssociatedBankId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [uniqueidentifier]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_AssociatedBankId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_AssociatedBankId {

			get {

				if (this.internal_Param_AssociatedBankId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_AssociatedBankId);
			}

			set {

				this.internal_Param_AssociatedBankId_UseDefaultValue = false;
				this.internal_Param_AssociatedBankId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@AssociatedBankId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_AssociatedBankId_UseDefaultValue() {

			this.internal_Param_AssociatedBankId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_AssociatedBankId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_AssociatedBankId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_AssociatedBankId {

			get {

				if (this.internal_Param_ConsiderNull_AssociatedBankId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_AssociatedBankId);
			}

			set {

				this.internal_Param_ConsiderNull_AssociatedBankId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_AssociatedBankId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_AssociatedBankId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_AssociatedBankId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_AssociatedBankId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PayOutLocationId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [uniqueidentifier]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PayOutLocationId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_PayOutLocationId {

			get {

				if (this.internal_Param_PayOutLocationId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PayOutLocationId);
			}

			set {

				this.internal_Param_PayOutLocationId_UseDefaultValue = false;
				this.internal_Param_PayOutLocationId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PayOutLocationId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PayOutLocationId_UseDefaultValue() {

			this.internal_Param_PayOutLocationId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PayOutLocationId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PayOutLocationId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PayOutLocationId {

			get {

				if (this.internal_Param_ConsiderNull_PayOutLocationId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PayOutLocationId);
			}

			set {

				this.internal_Param_ConsiderNull_PayOutLocationId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PayOutLocationId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PayOutLocationId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PayOutLocationId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PayOutLocationId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PayInAgentUserId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [uniqueidentifier]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PayInAgentUserId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_PayInAgentUserId {

			get {

				if (this.internal_Param_PayInAgentUserId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PayInAgentUserId);
			}

			set {

				this.internal_Param_PayInAgentUserId_UseDefaultValue = false;
				this.internal_Param_PayInAgentUserId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PayInAgentUserId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PayInAgentUserId_UseDefaultValue() {

			this.internal_Param_PayInAgentUserId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PayInAgentUserId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PayInAgentUserId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PayInAgentUserId {

			get {

				if (this.internal_Param_ConsiderNull_PayInAgentUserId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PayInAgentUserId);
			}

			set {

				this.internal_Param_ConsiderNull_PayInAgentUserId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PayInAgentUserId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PayInAgentUserId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PayInAgentUserId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PayInAgentUserId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PayInAgentLocationId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [uniqueidentifier]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PayInAgentLocationId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_PayInAgentLocationId {

			get {

				if (this.internal_Param_PayInAgentLocationId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PayInAgentLocationId);
			}

			set {

				this.internal_Param_PayInAgentLocationId_UseDefaultValue = false;
				this.internal_Param_PayInAgentLocationId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PayInAgentLocationId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PayInAgentLocationId_UseDefaultValue() {

			this.internal_Param_PayInAgentLocationId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PayInAgentLocationId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PayInAgentLocationId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PayInAgentLocationId {

			get {

				if (this.internal_Param_ConsiderNull_PayInAgentLocationId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PayInAgentLocationId);
			}

			set {

				this.internal_Param_ConsiderNull_PayInAgentLocationId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PayInAgentLocationId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PayInAgentLocationId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PayInAgentLocationId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PayInAgentLocationId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PayInDateTime'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [datetime]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PayInDateTime_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDateTime Param_PayInDateTime {

			get {

				if (this.internal_Param_PayInDateTime_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PayInDateTime);
			}

			set {

				this.internal_Param_PayInDateTime_UseDefaultValue = false;
				this.internal_Param_PayInDateTime = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PayInDateTime' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PayInDateTime_UseDefaultValue() {

			this.internal_Param_PayInDateTime_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PayInDateTime'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PayInDateTime_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PayInDateTime {

			get {

				if (this.internal_Param_ConsiderNull_PayInDateTime_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PayInDateTime);
			}

			set {

				this.internal_Param_ConsiderNull_PayInDateTime_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PayInDateTime = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PayInDateTime' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PayInDateTime_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PayInDateTime_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@RecommendedPayOutAgentId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [uniqueidentifier]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_RecommendedPayOutAgentId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_RecommendedPayOutAgentId {

			get {

				if (this.internal_Param_RecommendedPayOutAgentId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_RecommendedPayOutAgentId);
			}

			set {

				this.internal_Param_RecommendedPayOutAgentId_UseDefaultValue = false;
				this.internal_Param_RecommendedPayOutAgentId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@RecommendedPayOutAgentId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_RecommendedPayOutAgentId_UseDefaultValue() {

			this.internal_Param_RecommendedPayOutAgentId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_RecommendedPayOutAgentId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_RecommendedPayOutAgentId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_RecommendedPayOutAgentId {

			get {

				if (this.internal_Param_ConsiderNull_RecommendedPayOutAgentId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_RecommendedPayOutAgentId);
			}

			set {

				this.internal_Param_ConsiderNull_RecommendedPayOutAgentId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_RecommendedPayOutAgentId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_RecommendedPayOutAgentId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_RecommendedPayOutAgentId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_RecommendedPayOutAgentId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ActualPayOutAgentId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [uniqueidentifier]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ActualPayOutAgentId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_ActualPayOutAgentId {

			get {

				if (this.internal_Param_ActualPayOutAgentId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ActualPayOutAgentId);
			}

			set {

				this.internal_Param_ActualPayOutAgentId_UseDefaultValue = false;
				this.internal_Param_ActualPayOutAgentId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ActualPayOutAgentId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ActualPayOutAgentId_UseDefaultValue() {

			this.internal_Param_ActualPayOutAgentId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_ActualPayOutAgentId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_ActualPayOutAgentId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_ActualPayOutAgentId {

			get {

				if (this.internal_Param_ConsiderNull_ActualPayOutAgentId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_ActualPayOutAgentId);
			}

			set {

				this.internal_Param_ConsiderNull_ActualPayOutAgentId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_ActualPayOutAgentId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_ActualPayOutAgentId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_ActualPayOutAgentId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_ActualPayOutAgentId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PayOutAgentUserId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [uniqueidentifier]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PayOutAgentUserId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_PayOutAgentUserId {

			get {

				if (this.internal_Param_PayOutAgentUserId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PayOutAgentUserId);
			}

			set {

				this.internal_Param_PayOutAgentUserId_UseDefaultValue = false;
				this.internal_Param_PayOutAgentUserId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PayOutAgentUserId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PayOutAgentUserId_UseDefaultValue() {

			this.internal_Param_PayOutAgentUserId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PayOutAgentUserId'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PayOutAgentUserId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PayOutAgentUserId {

			get {

				if (this.internal_Param_ConsiderNull_PayOutAgentUserId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PayOutAgentUserId);
			}

			set {

				this.internal_Param_ConsiderNull_PayOutAgentUserId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PayOutAgentUserId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PayOutAgentUserId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PayOutAgentUserId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PayOutAgentUserId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@PayOutDateTime'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [datetime]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_PayOutDateTime_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDateTime Param_PayOutDateTime {

			get {

				if (this.internal_Param_PayOutDateTime_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_PayOutDateTime);
			}

			set {

				this.internal_Param_PayOutDateTime_UseDefaultValue = false;
				this.internal_Param_PayOutDateTime = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@PayOutDateTime' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_PayOutDateTime_UseDefaultValue() {

			this.internal_Param_PayOutDateTime_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_PayOutDateTime'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_PayOutDateTime_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_PayOutDateTime {

			get {

				if (this.internal_Param_ConsiderNull_PayOutDateTime_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_PayOutDateTime);
			}

			set {

				this.internal_Param_ConsiderNull_PayOutDateTime_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_PayOutDateTime = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_PayOutDateTime' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_PayOutDateTime_UseDefaultValue() {

			this.internal_Param_ConsiderNull_PayOutDateTime_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@CollectedBeneficeryIdDetails'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](300)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_CollectedBeneficeryIdDetails_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_CollectedBeneficeryIdDetails {

			get {

				if (this.internal_Param_CollectedBeneficeryIdDetails_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_CollectedBeneficeryIdDetails);
			}

			set {

				this.internal_Param_CollectedBeneficeryIdDetails_UseDefaultValue = false;
				this.internal_Param_CollectedBeneficeryIdDetails = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@CollectedBeneficeryIdDetails' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_CollectedBeneficeryIdDetails_UseDefaultValue() {

			this.internal_Param_CollectedBeneficeryIdDetails_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_CollectedBeneficeryIdDetails'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_CollectedBeneficeryIdDetails_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_CollectedBeneficeryIdDetails {

			get {

				if (this.internal_Param_ConsiderNull_CollectedBeneficeryIdDetails_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_CollectedBeneficeryIdDetails);
			}

			set {

				this.internal_Param_ConsiderNull_CollectedBeneficeryIdDetails_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_CollectedBeneficeryIdDetails = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_CollectedBeneficeryIdDetails' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_CollectedBeneficeryIdDetails_UseDefaultValue() {

			this.internal_Param_ConsiderNull_CollectedBeneficeryIdDetails_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@IsOpenTransaction'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_IsOpenTransaction_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_IsOpenTransaction {

			get {

				if (this.internal_Param_IsOpenTransaction_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_IsOpenTransaction);
			}

			set {

				this.internal_Param_IsOpenTransaction_UseDefaultValue = false;
				this.internal_Param_IsOpenTransaction = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@IsOpenTransaction' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_IsOpenTransaction_UseDefaultValue() {

			this.internal_Param_IsOpenTransaction_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_IsOpenTransaction'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_IsOpenTransaction_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_IsOpenTransaction {

			get {

				if (this.internal_Param_ConsiderNull_IsOpenTransaction_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_IsOpenTransaction);
			}

			set {

				this.internal_Param_ConsiderNull_IsOpenTransaction_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_IsOpenTransaction = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_IsOpenTransaction' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_IsOpenTransaction_UseDefaultValue() {

			this.internal_Param_ConsiderNull_IsOpenTransaction_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Status'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](100)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_Status_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_Status {

			get {

				if (this.internal_Param_Status_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Status);
			}

			set {

				this.internal_Param_Status_UseDefaultValue = false;
				this.internal_Param_Status = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Status' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Status_UseDefaultValue() {

			this.internal_Param_Status_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_Status'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_Status_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_Status {

			get {

				if (this.internal_Param_ConsiderNull_Status_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_Status);
			}

			set {

				this.internal_Param_ConsiderNull_Status_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_Status = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_Status' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_Status_UseDefaultValue() {

			this.internal_Param_ConsiderNull_Status_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@SettlementStatus'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](100)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_SettlementStatus_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_SettlementStatus {

			get {

				if (this.internal_Param_SettlementStatus_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_SettlementStatus);
			}

			set {

				this.internal_Param_SettlementStatus_UseDefaultValue = false;
				this.internal_Param_SettlementStatus = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@SettlementStatus' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_SettlementStatus_UseDefaultValue() {

			this.internal_Param_SettlementStatus_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_SettlementStatus'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [bit]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_ConsiderNull_SettlementStatus_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_SettlementStatus {

			get {

				if (this.internal_Param_ConsiderNull_SettlementStatus_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_SettlementStatus);
			}

			set {

				this.internal_Param_ConsiderNull_SettlementStatus_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_SettlementStatus = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_SettlementStatus' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_SettlementStatus_UseDefaultValue() {

			this.internal_Param_ConsiderNull_SettlementStatus_UseDefaultValue = true;
		}

  	}
}

namespace Evernet.MoneyExchange.DataClasses.StoredProcedures {

	/// <summary>
	/// This class allows you to execute the 'spU_TransactionDetails' stored procedure;
	/// it gives you the ability to:
	/// <list type="bullet">
	/// <item><description>Set all the necessary parameters to execute the stored procedure</description></item>
	/// <item><description>To execute the stored procedure</description></item>
	/// <item><description>To get back after the execution the return value and all the output parameters value</description></item>
	/// </list>
	/// </summary>
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:07", SqlObjectDependancyName="spU_TransactionDetails", SqlObjectDependancyRevision=32)]
#endif
	public class spU_TransactionDetails : MarshalByRefObject, IDisposable {


		private bool throwExceptionOnExecute = false;

		/// <summary>
		/// Initializes a new instance of the spU_TransactionDetails class.
		/// By default, no exception will be thrown when you call the Execute method. Instead, a Boolean return status will be returned.
		/// </summary>
		public spU_TransactionDetails() : this(false) {

		}

		/// <summary>
		/// Initializes a new instance of the spU_TransactionDetails class.
		/// </summary>
		/// <param name="throwExceptionOnExecute">True if an exception has to be thrown if the Execute call fails.</param>
		public spU_TransactionDetails(bool throwExceptionOnExecute) {

			this.throwExceptionOnExecute = throwExceptionOnExecute;
		}

		private System.Data.SqlClient.SqlConnection sqlConnection;
		/// <summary>
		/// The <see cref="System.Data.SqlClient.SqlConnection">System.Data.SqlClient.SqlConnection</see> that was actually used by this class.
		/// </summary>
		public System.Data.SqlClient.SqlConnection Connection {

			get {

				return(this.sqlConnection);
			}
		}

		/// <summary>
		/// Disposes the current instance of this object.
		/// </summary>
		public void Dispose() {

			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.
		/// </summary>
		private void Dispose(bool disposing) {

			if (disposing) {

			}
		}

		/// <summary>
		/// This member overrides 'Object.Finalize'.
		/// </summary>
		~spU_TransactionDetails() {

			Dispose(false);
		}

		private void ResetParameter(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_TransactionDetails parameters) {

			parameters.internal_Set_RETURN_VALUE (System.Data.SqlTypes.SqlInt32.Null);
		}

		private bool InitializeConnection(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_TransactionDetails parameters, out System.Data.SqlClient.SqlCommand sqlCommand, ref bool connectionMustBeClosed) {

			try {

				this.sqlConnection = null;
				sqlCommand = null;
				connectionMustBeClosed = true;

				if (parameters.ConnectionType == ConnectionType.None) {

					throw new InvalidOperationException("No connection information was supplied. Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spU_TransactionDetails object before doing this call.");
				}

				if (parameters.ConnectionType == ConnectionType.SqlConnection && parameters.SqlConnection == null) {

					throw new InvalidOperationException("No connection information was supplied (SqlConnection == null). Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spU_TransactionDetails object before doing this call.");
				}

				if (parameters.ConnectionType == ConnectionType.SqlTransaction && parameters.SqlTransaction== null) {

					throw new InvalidOperationException("No connection information was supplied (SqlTransaction == null). Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spU_TransactionDetails object before doing this call.");
				}

				switch (parameters.ConnectionType) {

					case ConnectionType.ConnectionString:

						string connectionString;
				
						if (parameters.ConnectionString.Length == 0) {

							connectionString = Information.GetConnectionStringFromConfigurationFile;
							if (connectionString.Length == 0) {

								connectionString = Information.GetConnectionStringFromRegistry;
							}
						}

						else {

							connectionString = parameters.ConnectionString;
						}

						if (connectionString.Length == 0) {

							throw new System.InvalidOperationException("No connection information was supplied (ConnectionString == \"\")! (Evernet.MoneyExchange.DataClasses.Parameters.spU_TransactionDetails)");
						}

						parameters.internal_SetErrorSource(ErrorSource.ConnectionOpening);
						this.sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
						this.sqlConnection.Open();

						sqlCommand = sqlConnection.CreateCommand();
						break;

					case ConnectionType.SqlConnection:

						sqlConnection = parameters.SqlConnection;

						if (this.sqlConnection.State != System.Data.ConnectionState.Open) {

							this.sqlConnection.Open();
						}
						else {

							connectionMustBeClosed = false;
						}
						sqlCommand = sqlConnection.CreateCommand();
						break;

					case ConnectionType.SqlTransaction:

						sqlCommand = new System.Data.SqlClient.SqlCommand();
						this.sqlConnection = parameters.SqlTransaction.Connection;
						if (this.sqlConnection == null) {

							throw new InvalidOperationException("The transaction is no longer valid.");
						}

						if (this.sqlConnection.State != System.Data.ConnectionState.Open) {
						
							this.sqlConnection.Open();
						}
						else {

							connectionMustBeClosed = false;
						}
						sqlCommand.Connection = sqlConnection;
						sqlCommand.Transaction = parameters.SqlTransaction;						break;
				}

				sqlCommand.CommandTimeout = parameters.CommandTimeOut;
				sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
				sqlCommand.CommandText = "spU_TransactionDetails";

				return(true);
			}

			catch (System.Data.SqlClient.SqlException sqlException) {

				sqlConnection = null;
				sqlCommand = null;
				parameters.internal_UpdateExceptionInformation(sqlException);
				return(false);
			}

			catch (System.Exception exception) {

				sqlConnection = null;
				sqlCommand = null;
				parameters.internal_UpdateExceptionInformation(exception);
				return(false);
			}
		}

		private bool DeclareParameters(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_TransactionDetails parameters, ref System.Data.SqlClient.SqlCommand sqlCommand) {

			try {

				System.Data.SqlClient.SqlParameter sqlParameter;

				sqlParameter = new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4);
				sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "Id";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Id_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Id.IsNull) {

					sqlParameter.Value = parameters.Param_Id;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@VoucherNumber", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "VoucherNumber";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 0;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_VoucherNumber_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_VoucherNumber.IsNull) {

					sqlParameter.Value = parameters.Param_VoucherNumber;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_VoucherNumber", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_VoucherNumber_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_VoucherNumber.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_VoucherNumber;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@TransactionNumber", System.Data.SqlDbType.NVarChar, 40);
				sqlParameter.SourceColumn = "TransactionNumber";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_TransactionNumber_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_TransactionNumber.IsNull) {

					sqlParameter.Value = parameters.Param_TransactionNumber;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_TransactionNumber", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_TransactionNumber_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_TransactionNumber.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_TransactionNumber;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@CustomerId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "CustomerId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_CustomerId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_CustomerId.IsNull) {

					sqlParameter.Value = parameters.Param_CustomerId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_CustomerId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_CustomerId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_CustomerId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_CustomerId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@BeneficeryId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "BeneficeryId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_BeneficeryId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_BeneficeryId.IsNull) {

					sqlParameter.Value = parameters.Param_BeneficeryId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_BeneficeryId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_BeneficeryId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_BeneficeryId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_BeneficeryId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@BeneficeryBankId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "BeneficeryBankId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_BeneficeryBankId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_BeneficeryBankId.IsNull) {

					sqlParameter.Value = parameters.Param_BeneficeryBankId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_BeneficeryBankId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_BeneficeryBankId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_BeneficeryBankId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_BeneficeryBankId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PaymentMode", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "PaymentMode";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PaymentMode_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PaymentMode.IsNull) {

					sqlParameter.Value = parameters.Param_PaymentMode;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PaymentMode", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PaymentMode_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PaymentMode.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PaymentMode;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PurposeOfTransfer", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "PurposeOfTransfer";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PurposeOfTransfer_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PurposeOfTransfer.IsNull) {

					sqlParameter.Value = parameters.Param_PurposeOfTransfer;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PurposeOfTransfer", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PurposeOfTransfer_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PurposeOfTransfer.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PurposeOfTransfer;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInCurrencyId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "PayInCurrencyId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PayInCurrencyId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PayInCurrencyId.IsNull) {

					sqlParameter.Value = parameters.Param_PayInCurrencyId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayInCurrencyId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PayInCurrencyId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PayInCurrencyId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PayInCurrencyId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInAmount", System.Data.SqlDbType.Decimal, 40);
				sqlParameter.SourceColumn = "PayInAmount";
				sqlParameter.Precision = 38;
				sqlParameter.Scale = 6;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PayInAmount_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PayInAmount.IsNull) {

					sqlParameter.Value = parameters.Param_PayInAmount;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayInAmount", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PayInAmount_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PayInAmount.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PayInAmount;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutCurrencyId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "PayOutCurrencyId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PayOutCurrencyId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PayOutCurrencyId.IsNull) {

					sqlParameter.Value = parameters.Param_PayOutCurrencyId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayOutCurrencyId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PayOutCurrencyId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PayOutCurrencyId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PayOutCurrencyId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutAmount", System.Data.SqlDbType.Decimal, 40);
				sqlParameter.SourceColumn = "PayOutAmount";
				sqlParameter.Precision = 38;
				sqlParameter.Scale = 6;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PayOutAmount_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PayOutAmount.IsNull) {

					sqlParameter.Value = parameters.Param_PayOutAmount;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayOutAmount", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PayOutAmount_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PayOutAmount.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PayOutAmount;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Commission", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "Commission";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 2;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Commission_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Commission.IsNull) {

					sqlParameter.Value = parameters.Param_Commission;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Commission", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_Commission_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_Commission.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_Commission;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Question", System.Data.SqlDbType.NVarChar, 400);
				sqlParameter.SourceColumn = "Question";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Question_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Question.IsNull) {

					sqlParameter.Value = parameters.Param_Question;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Question", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_Question_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_Question.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_Question;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Answer", System.Data.SqlDbType.NVarChar, 400);
				sqlParameter.SourceColumn = "Answer";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Answer_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Answer.IsNull) {

					sqlParameter.Value = parameters.Param_Answer;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Answer", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_Answer_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_Answer.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_Answer;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@MessageToBeneficery", System.Data.SqlDbType.NVarChar, 600);
				sqlParameter.SourceColumn = "MessageToBeneficery";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_MessageToBeneficery_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_MessageToBeneficery.IsNull) {

					sqlParameter.Value = parameters.Param_MessageToBeneficery;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_MessageToBeneficery", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_MessageToBeneficery_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_MessageToBeneficery.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_MessageToBeneficery;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@MessageToPayOutAgent", System.Data.SqlDbType.NVarChar, 600);
				sqlParameter.SourceColumn = "MessageToPayOutAgent";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_MessageToPayOutAgent_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_MessageToPayOutAgent.IsNull) {

					sqlParameter.Value = parameters.Param_MessageToPayOutAgent;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_MessageToPayOutAgent", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_MessageToPayOutAgent_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_MessageToPayOutAgent.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_MessageToPayOutAgent;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@BankExchangeRateForPayInCurrency", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "BankExchangeRateForPayInCurrency";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 6;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_BankExchangeRateForPayInCurrency_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_BankExchangeRateForPayInCurrency.IsNull) {

					sqlParameter.Value = parameters.Param_BankExchangeRateForPayInCurrency;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_BankExchangeRateForPayInCurrency", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_BankExchangeRateForPayInCurrency_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_BankExchangeRateForPayInCurrency.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_BankExchangeRateForPayInCurrency;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@BankExchangeRateForPayOutCurrency", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "BankExchangeRateForPayOutCurrency";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 6;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_BankExchangeRateForPayOutCurrency_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_BankExchangeRateForPayOutCurrency.IsNull) {

					sqlParameter.Value = parameters.Param_BankExchangeRateForPayOutCurrency;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_BankExchangeRateForPayOutCurrency", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_BankExchangeRateForPayOutCurrency_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_BankExchangeRateForPayOutCurrency.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_BankExchangeRateForPayOutCurrency;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInCurrencyGroup", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "PayInCurrencyGroup";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PayInCurrencyGroup_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PayInCurrencyGroup.IsNull) {

					sqlParameter.Value = parameters.Param_PayInCurrencyGroup;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayInCurrencyGroup", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PayInCurrencyGroup_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PayInCurrencyGroup.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PayInCurrencyGroup;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutCurrencyGroup", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "PayOutCurrencyGroup";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PayOutCurrencyGroup_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PayOutCurrencyGroup.IsNull) {

					sqlParameter.Value = parameters.Param_PayOutCurrencyGroup;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayOutCurrencyGroup", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PayOutCurrencyGroup_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PayOutCurrencyGroup.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PayOutCurrencyGroup;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@FinalBankExchangeRate", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "FinalBankExchangeRate";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 6;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_FinalBankExchangeRate_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_FinalBankExchangeRate.IsNull) {

					sqlParameter.Value = parameters.Param_FinalBankExchangeRate;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_FinalBankExchangeRate", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_FinalBankExchangeRate_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_FinalBankExchangeRate.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_FinalBankExchangeRate;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@AgencyMarginPercent", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "AgencyMarginPercent";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 6;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_AgencyMarginPercent_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_AgencyMarginPercent.IsNull) {

					sqlParameter.Value = parameters.Param_AgencyMarginPercent;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_AgencyMarginPercent", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_AgencyMarginPercent_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_AgencyMarginPercent.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_AgencyMarginPercent;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@AgencyExchangeRate", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "AgencyExchangeRate";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 0;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_AgencyExchangeRate_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_AgencyExchangeRate.IsNull) {

					sqlParameter.Value = parameters.Param_AgencyExchangeRate;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_AgencyExchangeRate", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_AgencyExchangeRate_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_AgencyExchangeRate.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_AgencyExchangeRate;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@AgentMarginPercent", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "AgentMarginPercent";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 6;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_AgentMarginPercent_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_AgentMarginPercent.IsNull) {

					sqlParameter.Value = parameters.Param_AgentMarginPercent;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_AgentMarginPercent", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_AgentMarginPercent_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_AgentMarginPercent.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_AgentMarginPercent;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@AgentExchangeRate", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "AgentExchangeRate";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 0;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_AgentExchangeRate_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_AgentExchangeRate.IsNull) {

					sqlParameter.Value = parameters.Param_AgentExchangeRate;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_AgentExchangeRate", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_AgentExchangeRate_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_AgentExchangeRate.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_AgentExchangeRate;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@AssociatedBankId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "AssociatedBankId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_AssociatedBankId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_AssociatedBankId.IsNull) {

					sqlParameter.Value = parameters.Param_AssociatedBankId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_AssociatedBankId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_AssociatedBankId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_AssociatedBankId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_AssociatedBankId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutLocationId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "PayOutLocationId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PayOutLocationId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PayOutLocationId.IsNull) {

					sqlParameter.Value = parameters.Param_PayOutLocationId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayOutLocationId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PayOutLocationId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PayOutLocationId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PayOutLocationId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInAgentUserId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "PayInAgentUserId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PayInAgentUserId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PayInAgentUserId.IsNull) {

					sqlParameter.Value = parameters.Param_PayInAgentUserId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayInAgentUserId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PayInAgentUserId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PayInAgentUserId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PayInAgentUserId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInAgentLocationId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "PayInAgentLocationId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PayInAgentLocationId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PayInAgentLocationId.IsNull) {

					sqlParameter.Value = parameters.Param_PayInAgentLocationId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayInAgentLocationId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PayInAgentLocationId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PayInAgentLocationId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PayInAgentLocationId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PayInDateTime", System.Data.SqlDbType.DateTime, 16);
				sqlParameter.SourceColumn = "PayInDateTime";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PayInDateTime_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PayInDateTime.IsNull) {

					sqlParameter.Value = parameters.Param_PayInDateTime;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayInDateTime", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PayInDateTime_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PayInDateTime.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PayInDateTime;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@RecommendedPayOutAgentId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "RecommendedPayOutAgentId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_RecommendedPayOutAgentId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_RecommendedPayOutAgentId.IsNull) {

					sqlParameter.Value = parameters.Param_RecommendedPayOutAgentId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_RecommendedPayOutAgentId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_RecommendedPayOutAgentId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_RecommendedPayOutAgentId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_RecommendedPayOutAgentId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ActualPayOutAgentId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "ActualPayOutAgentId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ActualPayOutAgentId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ActualPayOutAgentId.IsNull) {

					sqlParameter.Value = parameters.Param_ActualPayOutAgentId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_ActualPayOutAgentId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_ActualPayOutAgentId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_ActualPayOutAgentId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_ActualPayOutAgentId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutAgentUserId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "PayOutAgentUserId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PayOutAgentUserId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PayOutAgentUserId.IsNull) {

					sqlParameter.Value = parameters.Param_PayOutAgentUserId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayOutAgentUserId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PayOutAgentUserId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PayOutAgentUserId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PayOutAgentUserId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@PayOutDateTime", System.Data.SqlDbType.DateTime, 16);
				sqlParameter.SourceColumn = "PayOutDateTime";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_PayOutDateTime_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_PayOutDateTime.IsNull) {

					sqlParameter.Value = parameters.Param_PayOutDateTime;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_PayOutDateTime", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_PayOutDateTime_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_PayOutDateTime.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_PayOutDateTime;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@CollectedBeneficeryIdDetails", System.Data.SqlDbType.NVarChar, 300);
				sqlParameter.SourceColumn = "CollectedBeneficeryIdDetails";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_CollectedBeneficeryIdDetails_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_CollectedBeneficeryIdDetails.IsNull) {

					sqlParameter.Value = parameters.Param_CollectedBeneficeryIdDetails;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_CollectedBeneficeryIdDetails", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_CollectedBeneficeryIdDetails_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_CollectedBeneficeryIdDetails.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_CollectedBeneficeryIdDetails;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@IsOpenTransaction", System.Data.SqlDbType.Bit, 1);
				sqlParameter.SourceColumn = "IsOpenTransaction";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_IsOpenTransaction_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_IsOpenTransaction.IsNull) {

					sqlParameter.Value = parameters.Param_IsOpenTransaction;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_IsOpenTransaction", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_IsOpenTransaction_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_IsOpenTransaction.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_IsOpenTransaction;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "Status";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Status_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Status.IsNull) {

					sqlParameter.Value = parameters.Param_Status;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Status", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_Status_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_Status.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_Status;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@SettlementStatus", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "SettlementStatus";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_SettlementStatus_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_SettlementStatus.IsNull) {

					sqlParameter.Value = parameters.Param_SettlementStatus;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_SettlementStatus", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_SettlementStatus_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_SettlementStatus.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_SettlementStatus;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);


				return(true);

			}

			catch (System.Data.SqlClient.SqlException sqlException) {

				parameters.internal_UpdateExceptionInformation(sqlException);
				return(false);
			}

			catch (System.Exception exception) {

				parameters.internal_UpdateExceptionInformation(exception);
				return(false);
			}
		}

		private bool RetrieveParameters(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_TransactionDetails parameters, ref System.Data.SqlClient.SqlCommand sqlCommand) {

			try {

				if (sqlCommand.Parameters["@RETURN_VALUE"].Value != System.DBNull.Value) {

					parameters.internal_Set_RETURN_VALUE ((System.Int32)sqlCommand.Parameters["@RETURN_VALUE"].Value);
				}
				else {

					parameters.internal_Set_RETURN_VALUE (System.Data.SqlTypes.SqlInt32.Null);
				}

				return(true);
			}

			catch (System.Data.SqlClient.SqlException sqlException) {

				parameters.internal_UpdateExceptionInformation(sqlException);
				return(false);
			}

			catch (System.Exception exception) {

				parameters.internal_UpdateExceptionInformation(exception);
				return(false);
			}
		}

		/// <summary>
		/// This method allows you to execute the [spU_TransactionDetails] stored procedure.
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_TransactionDetails parameters) {

			System.Data.SqlClient.SqlCommand sqlCommand = null;
			System.Boolean returnStatus = false;
			System.Boolean connectionMustBeClosed = true;

			try {
				ResetParameter(ref parameters);

				parameters.internal_SetErrorSource(ErrorSource.ConnectionInitialization);
				returnStatus = InitializeConnection(ref parameters, out sqlCommand, ref connectionMustBeClosed);
				if (!returnStatus) {

					return(false);
				}

				parameters.internal_SetErrorSource(ErrorSource.ParametersSetting);
				returnStatus = DeclareParameters(ref parameters, ref sqlCommand);
				if (!returnStatus) {

					return(false);
				}

				parameters.internal_SetErrorSource(ErrorSource.QueryExecution);
				sqlCommand.ExecuteNonQuery();
                
				parameters.internal_SetErrorSource(ErrorSource.ParametersRetrieval);
				returnStatus = RetrieveParameters(ref parameters, ref sqlCommand);
			}

			catch (System.Data.SqlClient.SqlException sqlException) {

				parameters.internal_UpdateExceptionInformation(sqlException);
				returnStatus = false;

				if (this.throwExceptionOnExecute) {

					throw sqlException;
				}
			}

			catch (System.Exception exception) {

				parameters.internal_UpdateExceptionInformation(exception);
				returnStatus = false;
				parameters.internal_SetErrorSource(ErrorSource.Other);

				if (this.throwExceptionOnExecute) {

					throw exception;
				}
			}

			finally {

				if (sqlCommand != null) {

					sqlCommand.Dispose();
				}

				if (parameters.SqlTransaction == null) {

					if (this.sqlConnection != null && connectionMustBeClosed && this.sqlConnection.State == System.Data.ConnectionState.Open) {

						this.sqlConnection.Close();
						this.sqlConnection.Dispose();
					}
				}

				if (returnStatus) {

					parameters.internal_SetErrorSource(ErrorSource.NoError);
				}
				else {

					if (this.throwExceptionOnExecute) {

						if (parameters.SqlException != null) {

							throw parameters.SqlException;
						}
						else {

							throw parameters.OtherException;
						}
					}
				}
			}
			return(returnStatus);
       
		}

	}

}

