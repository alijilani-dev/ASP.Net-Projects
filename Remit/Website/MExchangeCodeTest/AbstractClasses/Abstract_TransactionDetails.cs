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
	/// This class allows you to very easily retrieve a record from the [TransactionDetails] table.
	/// </summary>
	[Serializable()]
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[Evernet.MoneyExchange.DataClasses.OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:32", SqlObjectDependancyName="TransactionDetails", SqlObjectDependancyRevision=3344)]
#endif
	public class Abstract_TransactionDetails {

		Params.spS_TransactionDetails Param;
		private bool CloseConnectionAfterUse = true;

		/// <summary>
		/// Create a new instance of the Abstract_TransactionDetails class.
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		public Abstract_TransactionDetails(string connectionString) {

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

			this.Param = new Params.spS_TransactionDetails(true);
			this.Param.SetUpConnection(connectionString);
		}

		/// <summary>
		/// Create a new instance of the Abstract_TransactionDetails class.
		/// </summary>
		/// <param name="sqlConnection">A valid System.Data.SqlClient.SqlConnection to the database.</param>
		public Abstract_TransactionDetails(System.Data.SqlClient.SqlConnection sqlConnection) {

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

			this.Param = new Params.spS_TransactionDetails(true);
			this.Param.SetUpConnection(sqlConnection);
			CloseConnectionAfterUse = (this.Param.SqlConnection.State != System.Data.ConnectionState.Open);
		}

		/// <summary>
		/// Create a new instance of the Abstract_TransactionDetails class.
		/// </summary>
		/// <param name="sqlTransaction">A valid System.Data.SqlClient.SqlTransaction to the database.</param>
		public Abstract_TransactionDetails(System.Data.SqlClient.SqlTransaction sqlTransaction) {

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

			this.Param = new Params.spS_TransactionDetails(true);
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

		private System.Data.SqlTypes.SqlDecimal col_VoucherNumber;
		/// <summary>
		/// Returns the value of the VoucherNumber column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;VoucherNumber&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_VoucherNumber {

			get {

				return (this.col_VoucherNumber);
			}
		}

		private System.Data.SqlTypes.SqlString col_TransactionNumber;
		/// <summary>
		/// Returns the value of the TransactionNumber column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;TransactionNumber&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_TransactionNumber {

			get {

				return (this.col_TransactionNumber);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_CustomerId;
		/// <summary>
		/// Returns the value of the CustomerId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;CustomerId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_CustomerId {

			get {

				return (this.col_CustomerId);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_BeneficeryId;
		/// <summary>
		/// Returns the value of the BeneficeryId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;BeneficeryId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_BeneficeryId {

			get {

				return (this.col_BeneficeryId);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_BeneficeryBankId;
		/// <summary>
		/// Returns the value of the BeneficeryBankId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;BeneficeryBankId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_BeneficeryBankId {

			get {

				return (this.col_BeneficeryBankId);
			}
		}

		private System.Data.SqlTypes.SqlString col_PaymentMode;
		/// <summary>
		/// Returns the value of the PaymentMode column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PaymentMode&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_PaymentMode {

			get {

				return (this.col_PaymentMode);
			}
		}

		private System.Data.SqlTypes.SqlString col_PurposeOfTransfer;
		/// <summary>
		/// Returns the value of the PurposeOfTransfer column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PurposeOfTransfer&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_PurposeOfTransfer {

			get {

				return (this.col_PurposeOfTransfer);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_PayInCurrencyId;
		/// <summary>
		/// Returns the value of the PayInCurrencyId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PayInCurrencyId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_PayInCurrencyId {

			get {

				return (this.col_PayInCurrencyId);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_PayInAmount;
		/// <summary>
		/// Returns the value of the PayInAmount column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PayInAmount&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_PayInAmount {

			get {

				return (this.col_PayInAmount);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_PayOutCurrencyId;
		/// <summary>
		/// Returns the value of the PayOutCurrencyId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PayOutCurrencyId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_PayOutCurrencyId {

			get {

				return (this.col_PayOutCurrencyId);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_PayOutAmount;
		/// <summary>
		/// Returns the value of the PayOutAmount column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PayOutAmount&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_PayOutAmount {

			get {

				return (this.col_PayOutAmount);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_Commission;
		/// <summary>
		/// Returns the value of the Commission column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;Commission&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_Commission {

			get {

				return (this.col_Commission);
			}
		}

		private System.Data.SqlTypes.SqlString col_Question;
		/// <summary>
		/// Returns the value of the Question column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;Question&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_Question {

			get {

				return (this.col_Question);
			}
		}

		private System.Data.SqlTypes.SqlString col_Answer;
		/// <summary>
		/// Returns the value of the Answer column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;Answer&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_Answer {

			get {

				return (this.col_Answer);
			}
		}

		private System.Data.SqlTypes.SqlString col_MessageToBeneficery;
		/// <summary>
		/// Returns the value of the MessageToBeneficery column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;MessageToBeneficery&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_MessageToBeneficery {

			get {

				return (this.col_MessageToBeneficery);
			}
		}

		private System.Data.SqlTypes.SqlString col_MessageToPayOutAgent;
		/// <summary>
		/// Returns the value of the MessageToPayOutAgent column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;MessageToPayOutAgent&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_MessageToPayOutAgent {

			get {

				return (this.col_MessageToPayOutAgent);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_BankExchangeRateForPayInCurrency;
		/// <summary>
		/// Returns the value of the BankExchangeRateForPayInCurrency column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;BankExchangeRateForPayInCurrency&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_BankExchangeRateForPayInCurrency {

			get {

				return (this.col_BankExchangeRateForPayInCurrency);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_BankExchangeRateForPayOutCurrency;
		/// <summary>
		/// Returns the value of the BankExchangeRateForPayOutCurrency column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;BankExchangeRateForPayOutCurrency&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_BankExchangeRateForPayOutCurrency {

			get {

				return (this.col_BankExchangeRateForPayOutCurrency);
			}
		}

		private System.Data.SqlTypes.SqlString col_PayInCurrencyGroup;
		/// <summary>
		/// Returns the value of the PayInCurrencyGroup column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PayInCurrencyGroup&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_PayInCurrencyGroup {

			get {

				return (this.col_PayInCurrencyGroup);
			}
		}

		private System.Data.SqlTypes.SqlString col_PayOutCurrencyGroup;
		/// <summary>
		/// Returns the value of the PayOutCurrencyGroup column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PayOutCurrencyGroup&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_PayOutCurrencyGroup {

			get {

				return (this.col_PayOutCurrencyGroup);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_FinalBankExchangeRate;
		/// <summary>
		/// Returns the value of the FinalBankExchangeRate column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;FinalBankExchangeRate&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_FinalBankExchangeRate {

			get {

				return (this.col_FinalBankExchangeRate);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_AgencyMarginPercent;
		/// <summary>
		/// Returns the value of the AgencyMarginPercent column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;AgencyMarginPercent&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_AgencyMarginPercent {

			get {

				return (this.col_AgencyMarginPercent);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_AgencyExchangeRate;
		/// <summary>
		/// Returns the value of the AgencyExchangeRate column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;AgencyExchangeRate&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_AgencyExchangeRate {

			get {

				return (this.col_AgencyExchangeRate);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_AgentMarginPercent;
		/// <summary>
		/// Returns the value of the AgentMarginPercent column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;AgentMarginPercent&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_AgentMarginPercent {

			get {

				return (this.col_AgentMarginPercent);
			}
		}

		private System.Data.SqlTypes.SqlDecimal col_AgentExchangeRate;
		/// <summary>
		/// Returns the value of the AgentExchangeRate column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;AgentExchangeRate&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDecimal Col_AgentExchangeRate {

			get {

				return (this.col_AgentExchangeRate);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_AssociatedBankId;
		/// <summary>
		/// Returns the value of the AssociatedBankId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;AssociatedBankId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_AssociatedBankId {

			get {

				return (this.col_AssociatedBankId);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_PayOutLocationId;
		/// <summary>
		/// Returns the value of the PayOutLocationId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PayOutLocationId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_PayOutLocationId {

			get {

				return (this.col_PayOutLocationId);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_PayInAgentUserId;
		/// <summary>
		/// Returns the value of the PayInAgentUserId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PayInAgentUserId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_PayInAgentUserId {

			get {

				return (this.col_PayInAgentUserId);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_PayInAgentLocationId;
		/// <summary>
		/// Returns the value of the PayInAgentLocationId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PayInAgentLocationId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_PayInAgentLocationId {

			get {

				return (this.col_PayInAgentLocationId);
			}
		}

		private System.Data.SqlTypes.SqlDateTime col_PayInDateTime;
		/// <summary>
		/// Returns the value of the PayInDateTime column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PayInDateTime&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDateTime Col_PayInDateTime {

			get {

				return (this.col_PayInDateTime);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_RecommendedPayOutAgentId;
		/// <summary>
		/// Returns the value of the RecommendedPayOutAgentId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;RecommendedPayOutAgentId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_RecommendedPayOutAgentId {

			get {

				return (this.col_RecommendedPayOutAgentId);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_ActualPayOutAgentId;
		/// <summary>
		/// Returns the value of the ActualPayOutAgentId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;ActualPayOutAgentId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_ActualPayOutAgentId {

			get {

				return (this.col_ActualPayOutAgentId);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_PayOutAgentUserId;
		/// <summary>
		/// Returns the value of the PayOutAgentUserId column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PayOutAgentUserId&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_PayOutAgentUserId {

			get {

				return (this.col_PayOutAgentUserId);
			}
		}

		private System.Data.SqlTypes.SqlDateTime col_PayOutDateTime;
		/// <summary>
		/// Returns the value of the PayOutDateTime column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;PayOutDateTime&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlDateTime Col_PayOutDateTime {

			get {

				return (this.col_PayOutDateTime);
			}
		}

		private System.Data.SqlTypes.SqlString col_CollectedBeneficeryIdDetails;
		/// <summary>
		/// Returns the value of the CollectedBeneficeryIdDetails column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;CollectedBeneficeryIdDetails&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_CollectedBeneficeryIdDetails {

			get {

				return (this.col_CollectedBeneficeryIdDetails);
			}
		}

		private System.Data.SqlTypes.SqlBoolean col_IsOpenTransaction;
		/// <summary>
		/// Returns the value of the IsOpenTransaction column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;IsOpenTransaction&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlBoolean Col_IsOpenTransaction {

			get {

				return (this.col_IsOpenTransaction);
			}
		}

		private System.Data.SqlTypes.SqlString col_Status;
		/// <summary>
		/// Returns the value of the Status column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;Status&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_Status {

			get {

				return (this.col_Status);
			}
		}

		private System.Data.SqlTypes.SqlString col_SettlementStatus;
		/// <summary>
		/// Returns the value of the SettlementStatus column.
		/// More info on this column: Update this description in the &quot;Olymars/Description&quot; extended property of the &quot;SettlementStatus&quot; column.
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_SettlementStatus {

			get {

				return (this.col_SettlementStatus);
			}
		}

		/// <summary>
		/// This method allows to clear all the properties previously loaded by a call to the Refresh method.
		/// </summary>
		public void Reset() {

			this.col_Id = System.Data.SqlTypes.SqlGuid.Null;
			this.col_VoucherNumber = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_TransactionNumber = System.Data.SqlTypes.SqlString.Null;
			this.col_CustomerId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_BeneficeryId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_BeneficeryBankId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_PaymentMode = System.Data.SqlTypes.SqlString.Null;
			this.col_PurposeOfTransfer = System.Data.SqlTypes.SqlString.Null;
			this.col_PayInCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_PayInAmount = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_PayOutCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_PayOutAmount = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_Commission = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_Question = System.Data.SqlTypes.SqlString.Null;
			this.col_Answer = System.Data.SqlTypes.SqlString.Null;
			this.col_MessageToBeneficery = System.Data.SqlTypes.SqlString.Null;
			this.col_MessageToPayOutAgent = System.Data.SqlTypes.SqlString.Null;
			this.col_BankExchangeRateForPayInCurrency = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_BankExchangeRateForPayOutCurrency = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_PayInCurrencyGroup = System.Data.SqlTypes.SqlString.Null;
			this.col_PayOutCurrencyGroup = System.Data.SqlTypes.SqlString.Null;
			this.col_FinalBankExchangeRate = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_AgencyMarginPercent = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_AgencyExchangeRate = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_AgentMarginPercent = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_AgentExchangeRate = System.Data.SqlTypes.SqlDecimal.Null;
			this.col_AssociatedBankId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_PayOutLocationId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_PayInAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_PayInAgentLocationId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_PayInDateTime = System.Data.SqlTypes.SqlDateTime.Null;
			this.col_RecommendedPayOutAgentId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_ActualPayOutAgentId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_PayOutAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_PayOutDateTime = System.Data.SqlTypes.SqlDateTime.Null;
			this.col_CollectedBeneficeryIdDetails = System.Data.SqlTypes.SqlString.Null;
			this.col_IsOpenTransaction = System.Data.SqlTypes.SqlBoolean.Null;
			this.col_Status = System.Data.SqlTypes.SqlString.Null;
			this.col_SettlementStatus = System.Data.SqlTypes.SqlString.Null;
		}

		/// <summary>
		/// Allows you to load a specific record of the [TransactionDetails] table.
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
			SPs.spS_TransactionDetails SP = new SPs.spS_TransactionDetails(false);

			if (SP.Execute(ref this.Param, out DR)) {

				Status = false;
				if (DR.Read()) {

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_VoucherNumber.ColumnIndex)) {

						this.col_VoucherNumber = DR.GetSqlDecimal(SPs.spS_TransactionDetails.Resultset1.Fields.Column_VoucherNumber.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_TransactionNumber.ColumnIndex)) {

						this.col_TransactionNumber = DR.GetSqlString(SPs.spS_TransactionDetails.Resultset1.Fields.Column_TransactionNumber.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_CustomerId.ColumnIndex)) {

						this.col_CustomerId = DR.GetSqlGuid(SPs.spS_TransactionDetails.Resultset1.Fields.Column_CustomerId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_BeneficeryId.ColumnIndex)) {

						this.col_BeneficeryId = DR.GetSqlGuid(SPs.spS_TransactionDetails.Resultset1.Fields.Column_BeneficeryId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_BeneficeryBankId.ColumnIndex)) {

						this.col_BeneficeryBankId = DR.GetSqlGuid(SPs.spS_TransactionDetails.Resultset1.Fields.Column_BeneficeryBankId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PaymentMode.ColumnIndex)) {

						this.col_PaymentMode = DR.GetSqlString(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PaymentMode.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PurposeOfTransfer.ColumnIndex)) {

						this.col_PurposeOfTransfer = DR.GetSqlString(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PurposeOfTransfer.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayInCurrencyId.ColumnIndex)) {

						this.col_PayInCurrencyId = DR.GetSqlGuid(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayInCurrencyId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayInAmount.ColumnIndex)) {

						this.col_PayInAmount = DR.GetSqlDecimal(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayInAmount.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayOutCurrencyId.ColumnIndex)) {

						this.col_PayOutCurrencyId = DR.GetSqlGuid(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayOutCurrencyId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayOutAmount.ColumnIndex)) {

						this.col_PayOutAmount = DR.GetSqlDecimal(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayOutAmount.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_Commission.ColumnIndex)) {

						this.col_Commission = DR.GetSqlDecimal(SPs.spS_TransactionDetails.Resultset1.Fields.Column_Commission.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_Question.ColumnIndex)) {

						this.col_Question = DR.GetSqlString(SPs.spS_TransactionDetails.Resultset1.Fields.Column_Question.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_Answer.ColumnIndex)) {

						this.col_Answer = DR.GetSqlString(SPs.spS_TransactionDetails.Resultset1.Fields.Column_Answer.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_MessageToBeneficery.ColumnIndex)) {

						this.col_MessageToBeneficery = DR.GetSqlString(SPs.spS_TransactionDetails.Resultset1.Fields.Column_MessageToBeneficery.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_MessageToPayOutAgent.ColumnIndex)) {

						this.col_MessageToPayOutAgent = DR.GetSqlString(SPs.spS_TransactionDetails.Resultset1.Fields.Column_MessageToPayOutAgent.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_BankExchangeRateForPayInCurrency.ColumnIndex)) {

						this.col_BankExchangeRateForPayInCurrency = DR.GetSqlDecimal(SPs.spS_TransactionDetails.Resultset1.Fields.Column_BankExchangeRateForPayInCurrency.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_BankExchangeRateForPayOutCurrency.ColumnIndex)) {

						this.col_BankExchangeRateForPayOutCurrency = DR.GetSqlDecimal(SPs.spS_TransactionDetails.Resultset1.Fields.Column_BankExchangeRateForPayOutCurrency.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayInCurrencyGroup.ColumnIndex)) {

						this.col_PayInCurrencyGroup = DR.GetSqlString(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayInCurrencyGroup.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayOutCurrencyGroup.ColumnIndex)) {

						this.col_PayOutCurrencyGroup = DR.GetSqlString(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayOutCurrencyGroup.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_FinalBankExchangeRate.ColumnIndex)) {

						this.col_FinalBankExchangeRate = DR.GetSqlDecimal(SPs.spS_TransactionDetails.Resultset1.Fields.Column_FinalBankExchangeRate.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_AgencyMarginPercent.ColumnIndex)) {

						this.col_AgencyMarginPercent = DR.GetSqlDecimal(SPs.spS_TransactionDetails.Resultset1.Fields.Column_AgencyMarginPercent.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_AgencyExchangeRate.ColumnIndex)) {

						this.col_AgencyExchangeRate = DR.GetSqlDecimal(SPs.spS_TransactionDetails.Resultset1.Fields.Column_AgencyExchangeRate.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_AgentMarginPercent.ColumnIndex)) {

						this.col_AgentMarginPercent = DR.GetSqlDecimal(SPs.spS_TransactionDetails.Resultset1.Fields.Column_AgentMarginPercent.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_AgentExchangeRate.ColumnIndex)) {

						this.col_AgentExchangeRate = DR.GetSqlDecimal(SPs.spS_TransactionDetails.Resultset1.Fields.Column_AgentExchangeRate.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_AssociatedBankId.ColumnIndex)) {

						this.col_AssociatedBankId = DR.GetSqlGuid(SPs.spS_TransactionDetails.Resultset1.Fields.Column_AssociatedBankId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayOutLocationId.ColumnIndex)) {

						this.col_PayOutLocationId = DR.GetSqlGuid(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayOutLocationId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayInAgentUserId.ColumnIndex)) {

						this.col_PayInAgentUserId = DR.GetSqlGuid(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayInAgentUserId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayInAgentLocationId.ColumnIndex)) {

						this.col_PayInAgentLocationId = DR.GetSqlGuid(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayInAgentLocationId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayInDateTime.ColumnIndex)) {

						this.col_PayInDateTime = DR.GetSqlDateTime(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayInDateTime.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_RecommendedPayOutAgentId.ColumnIndex)) {

						this.col_RecommendedPayOutAgentId = DR.GetSqlGuid(SPs.spS_TransactionDetails.Resultset1.Fields.Column_RecommendedPayOutAgentId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_ActualPayOutAgentId.ColumnIndex)) {

						this.col_ActualPayOutAgentId = DR.GetSqlGuid(SPs.spS_TransactionDetails.Resultset1.Fields.Column_ActualPayOutAgentId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayOutAgentUserId.ColumnIndex)) {

						this.col_PayOutAgentUserId = DR.GetSqlGuid(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayOutAgentUserId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayOutDateTime.ColumnIndex)) {

						this.col_PayOutDateTime = DR.GetSqlDateTime(SPs.spS_TransactionDetails.Resultset1.Fields.Column_PayOutDateTime.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_CollectedBeneficeryIdDetails.ColumnIndex)) {

						this.col_CollectedBeneficeryIdDetails = DR.GetSqlString(SPs.spS_TransactionDetails.Resultset1.Fields.Column_CollectedBeneficeryIdDetails.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_IsOpenTransaction.ColumnIndex)) {

						this.col_IsOpenTransaction = DR.GetSqlBoolean(SPs.spS_TransactionDetails.Resultset1.Fields.Column_IsOpenTransaction.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_Status.ColumnIndex)) {

						this.col_Status = DR.GetSqlString(SPs.spS_TransactionDetails.Resultset1.Fields.Column_Status.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_TransactionDetails.Resultset1.Fields.Column_SettlementStatus.ColumnIndex)) {

						this.col_SettlementStatus = DR.GetSqlString(SPs.spS_TransactionDetails.Resultset1.Fields.Column_SettlementStatus.ColumnIndex);
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

				throw new Evernet.MoneyExchange.DataClasses.CustomException(this.Param, "Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails", "Refresh");
			}
		}
	}
}
