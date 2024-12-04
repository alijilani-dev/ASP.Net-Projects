/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:47:02 PM
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
	/// stored procedure 'spS_TransactionDetails_Full'. It allows also to specify specific connection
	/// information such as the ConnectionString to be use, the command time-out and so forth.
	/// </summary>
	[Serializable()]
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:02", SqlObjectDependancyName="spS_TransactionDetails_Full", SqlObjectDependancyRevision=0)]
#endif
	public class spS_TransactionDetails_Full : MarshalByRefObject, IDisposable, IParameter {

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

		private CurrentExecution currentExecution = CurrentExecution.None;
		
		private System.Data.SqlClient.SqlCommand sqlCommand = null;
		internal void internal_Set_SqlCommand(ref System.Data.SqlClient.SqlCommand sqlCommand) {
		
			this.sqlCommand = sqlCommand;
		}

		/// <summary>
		/// Returns the System.Data.SqlClient.SqlCommand that has been used.
		/// </summary>
		public System.Data.SqlClient.SqlCommand SqlCommand {
		
			get {
			
				return(this.sqlCommand);
			}
		}
		
		private System.Data.SqlClient.SqlDataReader sqlDataReader = null;
		internal void internal_Set_SqlDataReader(ref System.Data.SqlClient.SqlDataReader sqlDataReader) {
		
			this.currentExecution = CurrentExecution.SqlDataReader;
			this.sqlDataReader = sqlDataReader;
		}

		private System.Xml.XmlReader xmlReader = null;
		internal void internal_Set_XmlReader(ref System.Xml.XmlReader xmlReader) {
		
			this.currentExecution = CurrentExecution.XmlReader;
			this.xmlReader = xmlReader;
		}

		internal void internal_SetErrorSource(ErrorSource errorSource) {

			this.errorSource = errorSource;
		}

		private bool useDefaultValue = true;

		/// <summary>
		/// Initializes a new instance of the spS_TransactionDetails_Full class. If you use this constructor version,
		/// not assigning parameter values implies using the parameter default values.
		/// </summary>
		public spS_TransactionDetails_Full() : this(true) {

		}

		/// <summary>
		/// Initializes a new instance of the spS_TransactionDetails_Full class.
		/// </summary>
		/// <param name="useDefaultValue">If True, this parameter indicates that "not assigning parameter values" implies "using the parameter default values". If False, this parameter indicates that "not assigning parameter values" implies "using the SQL Server Null value".</param>
		public spS_TransactionDetails_Full(bool useDefaultValue) {

			this.useDefaultValue = useDefaultValue;

			this.internal_Param_Id_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_CustomerId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_BeneficeryId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_BeneficeryBankId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PaymentMode_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PurposeOfTransfer_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayInCurrencyId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayOutCurrencyId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_AssociatedBankId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayInAgentUserId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayInAgentLocationId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_PayOutAgentUserId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Status_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_SettlementStatus_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ReturnXML_UseDefaultValue = this.useDefaultValue;
		}

		private bool returnValueAvailable = true;

		internal void internal_Set_ReturnValue_Available(bool value) {

			this.returnValueAvailable = value;
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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spS_TransactionDetails_Full'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spS_TransactionDetails_Full", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spS_TransactionDetails_Full'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spS_TransactionDetails_Full", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spS_TransactionDetails_Full'";
				sqlCommand.Transaction = sqlTransaction;

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlTransaction.Connection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spS_TransactionDetails_Full", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				this.internal_Param_CustomerId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_BeneficeryId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_BeneficeryBankId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_PaymentMode = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_PurposeOfTransfer = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_PayInCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_PayOutCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_AssociatedBankId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_PayInAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_PayInAgentLocationId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_PayOutAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_Status = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_SettlementStatus = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ReturnXML = System.Data.SqlTypes.SqlBoolean.Null;

				this.sqlException = null;
				this.otherException = null;
				this.connectionString = null;
				this.sqlConnection = null;
				this.sqlTransaction = null;

				this.sqlCommand = null;
				this.sqlDataReader = null;
				this.xmlReader = null;
			}
		}

		/// <summary>
		/// This member overrides 'Object.Finalize'.
		/// </summary>
		~spS_TransactionDetails_Full() {

			Dispose(false);
		}

		/// <summary>
		/// Returns the stored procedure name for which this class was built, i.e. 'spS_TransactionDetails_Full'.
		/// </summary>
		public string StoredProcedureName {

			get {

				return("spS_TransactionDetails_Full");
			}
		}

		private System.Data.SqlTypes.SqlInt32 internal_Param_RETURN_VALUE;

		private System.Data.SqlTypes.SqlGuid internal_Param_Id;
		internal bool internal_Param_Id_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_CustomerId;
		internal bool internal_Param_CustomerId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_BeneficeryId;
		internal bool internal_Param_BeneficeryId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_BeneficeryBankId;
		internal bool internal_Param_BeneficeryBankId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_PaymentMode;
		internal bool internal_Param_PaymentMode_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_PurposeOfTransfer;
		internal bool internal_Param_PurposeOfTransfer_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_PayInCurrencyId;
		internal bool internal_Param_PayInCurrencyId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_PayOutCurrencyId;
		internal bool internal_Param_PayOutCurrencyId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_AssociatedBankId;
		internal bool internal_Param_AssociatedBankId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_PayInAgentUserId;
		internal bool internal_Param_PayInAgentUserId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_PayInAgentLocationId;
		internal bool internal_Param_PayInAgentLocationId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_PayOutAgentUserId;
		internal bool internal_Param_PayOutAgentUserId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Status;
		internal bool internal_Param_Status_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_SettlementStatus;
		internal bool internal_Param_SettlementStatus_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ReturnXML;
		internal bool internal_Param_ReturnXML_UseDefaultValue = true;


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

			this.currentExecution = CurrentExecution.None;
			this.sqlCommand = null;
			this.sqlDataReader = null;
			this.xmlReader = null;

			this.internal_Param_RETURN_VALUE = System.Data.SqlTypes.SqlInt32.Null;

			this.internal_Param_Id = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_Id_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_CustomerId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_CustomerId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_BeneficeryId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_BeneficeryId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_BeneficeryBankId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_BeneficeryBankId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PaymentMode = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_PaymentMode_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PurposeOfTransfer = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_PurposeOfTransfer_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayInCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_PayInCurrencyId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayOutCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_PayOutCurrencyId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_AssociatedBankId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_AssociatedBankId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayInAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_PayInAgentUserId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayInAgentLocationId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_PayInAgentLocationId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_PayOutAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_PayOutAgentUserId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Status = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Status_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_SettlementStatus = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_SettlementStatus_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ReturnXML = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ReturnXML_UseDefaultValue = this.useDefaultValue;

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

		private void RetrieveOutputParameters() {
		
			if (this.sqlCommand.Parameters["@RETURN_VALUE"].Value != System.DBNull.Value) {

				this.internal_Set_RETURN_VALUE ((System.Int32)this.sqlCommand.Parameters["@RETURN_VALUE"].Value);
			}
			else {

				this.internal_Set_RETURN_VALUE (System.Data.SqlTypes.SqlInt32.Null);
			}


			this.returnValueAvailable = true;
		}

		/// <summary>
		/// Returns the value returned back by the stored procedure execution.
		/// </summary>
		public System.Data.SqlTypes.SqlInt32 Param_RETURN_VALUE {

			get {

				if (!returnValueAvailable) {

					switch (this.currentExecution) {
					
						case CurrentExecution.SqlDataReader:
							if (this.sqlDataReader.IsClosed) {

								RetrieveOutputParameters();
							}
							else {
							
								throw new System.InvalidOperationException("The stored procedure return value has not been populated. You must close the underlying SqlDataReader first !");
							}
							break;

						case CurrentExecution.XmlReader:
							if (this.xmlReader.ReadState == System.Xml.ReadState.Closed) {

								RetrieveOutputParameters();
							}
							else {
							
								throw new System.InvalidOperationException("The stored procedure return value has not been populated. You must close the underlying XmlReader first !");
							}
							break;
					}
				}
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
		/// Sets the value of the stored procedure INPUT parameter '@ReturnXML'.
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
		/// the parameter default value, consider calling the Param_ReturnXML_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ReturnXML {

			get {

				if (this.internal_Param_ReturnXML_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ReturnXML);
			}

			set {

				this.internal_Param_ReturnXML_UseDefaultValue = false;
				this.internal_Param_ReturnXML = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ReturnXML' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ReturnXML_UseDefaultValue() {

			this.internal_Param_ReturnXML_UseDefaultValue = true;
		}

  	}
}

namespace Evernet.MoneyExchange.DataClasses.StoredProcedures {

	/// <summary>
	/// This class allows you to execute the 'spS_TransactionDetails_Full' stored procedure;
	/// it gives you the ability to:
	/// <list type="bullet">
	/// <item><description>Set all the necessary parameters to execute the stored procedure</description></item>
	/// <item><description>To execute the stored procedure</description></item>
	/// <item><description>To get back after the execution the return value and all the output parameters value</description></item>
	/// </list>
	/// </summary>
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:02", SqlObjectDependancyName="spS_TransactionDetails_Full", SqlObjectDependancyRevision=0)]
#endif
	public class spS_TransactionDetails_Full : MarshalByRefObject, IDisposable {


		private bool throwExceptionOnExecute = false;

		/// <summary>
		/// Initializes a new instance of the spS_TransactionDetails_Full class.
		/// By default, no exception will be thrown when you call the Execute method. Instead, a Boolean return status will be returned.
		/// </summary>
		public spS_TransactionDetails_Full() : this(false) {

		}

		/// <summary>
		/// Initializes a new instance of the spS_TransactionDetails_Full class.
		/// </summary>
		/// <param name="throwExceptionOnExecute">True if an exception has to be thrown if the Execute call fails.</param>
		public spS_TransactionDetails_Full(bool throwExceptionOnExecute) {

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
		~spS_TransactionDetails_Full() {

			Dispose(false);
		}

		private void ResetParameter(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full parameters) {

			parameters.internal_Set_RETURN_VALUE (System.Data.SqlTypes.SqlInt32.Null);
		}

		private bool InitializeConnection(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full parameters, out System.Data.SqlClient.SqlCommand sqlCommand, ref bool connectionMustBeClosed) {

			try {

				this.sqlConnection = null;
				sqlCommand = null;
				connectionMustBeClosed = true;

				if (parameters.ConnectionType == ConnectionType.None) {

					throw new InvalidOperationException("No connection information was supplied. Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full object before doing this call.");
				}

				if (parameters.ConnectionType == ConnectionType.SqlConnection && parameters.SqlConnection == null) {

					throw new InvalidOperationException("No connection information was supplied (SqlConnection == null). Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full object before doing this call.");
				}

				if (parameters.ConnectionType == ConnectionType.SqlTransaction && parameters.SqlTransaction== null) {

					throw new InvalidOperationException("No connection information was supplied (SqlTransaction == null). Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full object before doing this call.");
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

							throw new System.InvalidOperationException("No connection information was supplied (ConnectionString == \"\")! (Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full)");
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
				sqlCommand.CommandText = "spS_TransactionDetails_Full";

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

		private bool DeclareParameters(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full parameters, ref System.Data.SqlClient.SqlCommand sqlCommand) {

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

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ReturnXML", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ReturnXML_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ReturnXML.IsNull) {

					sqlParameter.Value = parameters.Param_ReturnXML;
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

		private bool RetrieveParameters(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full parameters, ref System.Data.SqlClient.SqlCommand sqlCommand) {

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
		/// This method allows you to execute the [spS_TransactionDetails_Full] stored procedure and retrieve back the data
		/// accessible via a SqlDataReader (System.Data.SqlClient.SqlDataReader).
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <param name="sqlDataReader">
		/// Will be created after execution. Don't forget to close it after usage.
		/// </param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full parameters, out System.Data.SqlClient.SqlDataReader sqlDataReader) {

			return(Execute(ref parameters, out sqlDataReader, System.Data.CommandBehavior.Default));
		}

		/// <summary>
		/// This method allows you to execute the [spS_TransactionDetails_Full] stored procedure and retrieve back the data
		/// accessible via a SqlDataReader (System.Data.SqlClient.SqlDataReader).
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <param name="sqlDataReader">
		/// Will be created after execution. Don't forget to close it after usage.
		/// </param>
		/// <param name="commandBehavior">
		/// One of the CommandBehavior values. 
		/// </param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full parameters, out System.Data.SqlClient.SqlDataReader sqlDataReader, System.Data.CommandBehavior commandBehavior) {

			System.Data.SqlClient.SqlCommand sqlCommand = null;
			System.Boolean returnStatus = false;
			System.Boolean connectionMustBeClosed = true;

			try {

				sqlDataReader = null;
				ResetParameter(ref parameters);

				parameters.Param_ReturnXML = new System.Data.SqlTypes.SqlBoolean(false);

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
				sqlDataReader = sqlCommand.ExecuteReader(commandBehavior);
                
				parameters.internal_Set_ReturnValue_Available(false);

				parameters.internal_Set_SqlDataReader(ref sqlDataReader);
				parameters.internal_Set_SqlCommand(ref sqlCommand);
			}

			catch (System.Data.SqlClient.SqlException sqlException) {

				sqlDataReader = null;
				parameters.internal_UpdateExceptionInformation(sqlException);
				returnStatus = false;

				if (this.throwExceptionOnExecute) {

					throw sqlException;
				}
			}

			catch (System.Exception exception) {

				sqlDataReader = null;
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

				// We do not close the SqlConnection because the SqlReader object needs it.
				// It is the responsability of the caller to close it by calling: SqlDataReader.Close();

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

		/// <summary>
		/// This method allows you to execute the [spS_TransactionDetails_Full] stored procedure and retrieve back the data
		/// populated in a DataSet (System.Data.DataSet).
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <param name="dataset">
		/// Will be populated with the data after execution. The table based name used will be: 'spS_TransactionDetails_Full'.
		/// </param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full parameters, ref System.Data.DataSet dataset) {

			return(Execute(ref parameters, ref dataset, "spS_TransactionDetails_Full", -1, -1));
		}

		/// <summary>
		/// This method allows you to execute the [spS_TransactionDetails_Full] stored procedure and retrieve back the data
		/// populated in a DataSet (System.Data.DataSet).
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <param name="dataset">
		/// Will be populated with the data after execution. The table based name used will be: 'spS_TransactionDetails_Full'.
		/// </param>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full parameters, ref System.Data.DataSet dataset, int startRecord, int maxRecords) {

			return(Execute(ref parameters, ref dataset, "spS_TransactionDetails_Full", startRecord, maxRecords));
		}

		/// <summary>
		/// This method allows you to execute the [spS_TransactionDetails_Full] stored procedure and retrieve back the data
		/// populated in a DataSet (System.Data.DataSet).
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <param name="dataset">
		/// Will be populated with the data after execution.
		/// </param>
		/// <param name="tableName">
		/// Will be the based name of the table in the database.
		/// </param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full parameters, ref System.Data.DataSet dataset, string tableName) {

			return(Execute(ref parameters, ref dataset, tableName, -1, -1));
		}

		/// <summary>
		/// This method allows you to execute the [spS_TransactionDetails_Full] stored procedure and retrieve back the data
		/// populated in a DataSet (System.Data.DataSet).
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <param name="dataset">
		/// Will be populated with the data after execution.
		/// </param>
		/// <param name="tableName">
		/// Will be the based name of the table in the database.
		/// </param>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full parameters, ref System.Data.DataSet dataset, string tableName, int startRecord, int maxRecords) {

			System.Data.SqlClient.SqlCommand sqlCommand = null;
			System.Data.SqlClient.SqlDataAdapter sqlDataAdapter = null;
			System.Boolean returnStatus = false;
			System.Boolean connectionMustBeClosed = true;

			try {

				if (dataset == null) {

					dataset = new System.Data.DataSet();
				}
				ResetParameter(ref parameters);

				parameters.Param_ReturnXML = new System.Data.SqlTypes.SqlBoolean(false);

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
				sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
				sqlDataAdapter.SelectCommand = sqlCommand;

				if (startRecord == -1) {

					sqlDataAdapter.Fill(dataset, tableName);
				}
				else {

					sqlDataAdapter.Fill(dataset, startRecord, maxRecords, tableName);
				}
				sqlDataAdapter.Dispose();

				dataset.Tables[tableName].Columns["Id"].Caption = "Id (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Id\" column)";
				dataset.Tables[tableName].Columns["VoucherNumber"].Caption = "VoucherNumber (update this label in the \"Olymars/ColumnLabel\" extended property of the \"VoucherNumber\" column)";
				dataset.Tables[tableName].Columns["TransactionNumber"].Caption = "TransactionNumber (update this label in the \"Olymars/ColumnLabel\" extended property of the \"TransactionNumber\" column)";
				dataset.Tables[tableName].Columns["CustomerId"].Caption = "CustomerId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"CustomerId\" column)";
				dataset.Tables[tableName].Columns["BeneficeryId"].Caption = "BeneficeryId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"BeneficeryId\" column)";
				dataset.Tables[tableName].Columns["BeneficeryBankId"].Caption = "BeneficeryBankId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"BeneficeryBankId\" column)";
				dataset.Tables[tableName].Columns["PaymentMode"].Caption = "PaymentMode (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PaymentMode\" column)";
				dataset.Tables[tableName].Columns["PurposeOfTransfer"].Caption = "PurposeOfTransfer (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PurposeOfTransfer\" column)";
				dataset.Tables[tableName].Columns["PayInCurrencyId"].Caption = "PayInCurrencyId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayInCurrencyId\" column)";
				dataset.Tables[tableName].Columns["PayInAmount"].Caption = "PayInAmount (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayInAmount\" column)";
				dataset.Tables[tableName].Columns["PayOutCurrencyId"].Caption = "PayOutCurrencyId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayOutCurrencyId\" column)";
				dataset.Tables[tableName].Columns["PayOutAmount"].Caption = "PayOutAmount (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayOutAmount\" column)";
				dataset.Tables[tableName].Columns["Commission"].Caption = "Commission (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Commission\" column)";
				dataset.Tables[tableName].Columns["Question"].Caption = "Question (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Question\" column)";
				dataset.Tables[tableName].Columns["Answer"].Caption = "Answer (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Answer\" column)";
				dataset.Tables[tableName].Columns["MessageToBeneficery"].Caption = "MessageToBeneficery (update this label in the \"Olymars/ColumnLabel\" extended property of the \"MessageToBeneficery\" column)";
				dataset.Tables[tableName].Columns["MessageToPayOutAgent"].Caption = "MessageToPayOutAgent (update this label in the \"Olymars/ColumnLabel\" extended property of the \"MessageToPayOutAgent\" column)";
				dataset.Tables[tableName].Columns["BankExchangeRateForPayInCurrency"].Caption = "BankExchangeRateForPayInCurrency (update this label in the \"Olymars/ColumnLabel\" extended property of the \"BankExchangeRateForPayInCurrency\" column)";
				dataset.Tables[tableName].Columns["BankExchangeRateForPayOutCurrency"].Caption = "BankExchangeRateForPayOutCurrency (update this label in the \"Olymars/ColumnLabel\" extended property of the \"BankExchangeRateForPayOutCurrency\" column)";
				dataset.Tables[tableName].Columns["PayInCurrencyGroup"].Caption = "PayInCurrencyGroup (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayInCurrencyGroup\" column)";
				dataset.Tables[tableName].Columns["PayOutCurrencyGroup"].Caption = "PayOutCurrencyGroup (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayOutCurrencyGroup\" column)";
				dataset.Tables[tableName].Columns["FinalBankExchangeRate"].Caption = "FinalBankExchangeRate (update this label in the \"Olymars/ColumnLabel\" extended property of the \"FinalBankExchangeRate\" column)";
				dataset.Tables[tableName].Columns["AgencyMarginPercent"].Caption = "AgencyMarginPercent (update this label in the \"Olymars/ColumnLabel\" extended property of the \"AgencyMarginPercent\" column)";
				dataset.Tables[tableName].Columns["AgencyExchangeRate"].Caption = "AgencyExchangeRate (update this label in the \"Olymars/ColumnLabel\" extended property of the \"AgencyExchangeRate\" column)";
				dataset.Tables[tableName].Columns["AgentMarginPercent"].Caption = "AgentMarginPercent (update this label in the \"Olymars/ColumnLabel\" extended property of the \"AgentMarginPercent\" column)";
				dataset.Tables[tableName].Columns["AgentExchangeRate"].Caption = "AgentExchangeRate (update this label in the \"Olymars/ColumnLabel\" extended property of the \"AgentExchangeRate\" column)";
				dataset.Tables[tableName].Columns["AssociatedBankId"].Caption = "AssociatedBankId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"AssociatedBankId\" column)";
				dataset.Tables[tableName].Columns["PayOutLocationId"].Caption = "PayOutLocationId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayOutLocationId\" column)";
				dataset.Tables[tableName].Columns["PayInAgentUserId"].Caption = "PayInAgentUserId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayInAgentUserId\" column)";
				dataset.Tables[tableName].Columns["PayInAgentLocationId"].Caption = "PayInAgentLocationId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayInAgentLocationId\" column)";
				dataset.Tables[tableName].Columns["PayInDateTime"].Caption = "PayInDateTime (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayInDateTime\" column)";
				dataset.Tables[tableName].Columns["RecommendedPayOutAgentId"].Caption = "RecommendedPayOutAgentId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"RecommendedPayOutAgentId\" column)";
				dataset.Tables[tableName].Columns["ActualPayOutAgentId"].Caption = "ActualPayOutAgentId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"ActualPayOutAgentId\" column)";
				dataset.Tables[tableName].Columns["PayOutAgentUserId"].Caption = "PayOutAgentUserId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayOutAgentUserId\" column)";
				dataset.Tables[tableName].Columns["PayOutDateTime"].Caption = "PayOutDateTime (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayOutDateTime\" column)";
				dataset.Tables[tableName].Columns["CollectedBeneficeryIdDetails"].Caption = "CollectedBeneficeryIdDetails (update this label in the \"Olymars/ColumnLabel\" extended property of the \"CollectedBeneficeryIdDetails\" column)";
				dataset.Tables[tableName].Columns["IsOpenTransaction"].Caption = "IsOpenTransaction (update this label in the \"Olymars/ColumnLabel\" extended property of the \"IsOpenTransaction\" column)";
				dataset.Tables[tableName].Columns["Status"].Caption = "Status (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Status\" column)";
				dataset.Tables[tableName].Columns["SettlementStatus"].Caption = "SettlementStatus (update this label in the \"Olymars/ColumnLabel\" extended property of the \"SettlementStatus\" column)";
				dataset.Tables[tableName].Columns["CustomerId_Id"].Caption = "Id (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Id\" column)";
				dataset.Tables[tableName].Columns["CustomerId_LoginName"].Caption = "LoginName";
				dataset.Tables[tableName].Columns["CustomerId_Password"].Caption = "Password";
				dataset.Tables[tableName].Columns["CustomerId_FirstName"].Caption = "FirstName";
				dataset.Tables[tableName].Columns["CustomerId_LastName"].Caption = "LastName";
				dataset.Tables[tableName].Columns["CustomerId_CardId"].Caption = "Card";
				dataset.Tables[tableName].Columns["CustomerId_Address"].Caption = "Address";
				dataset.Tables[tableName].Columns["CustomerId_Telephone"].Caption = "Telephone";
				dataset.Tables[tableName].Columns["CustomerId_Fax"].Caption = "Fax";
				dataset.Tables[tableName].Columns["CustomerId_Mobile"].Caption = "Mobile";
				dataset.Tables[tableName].Columns["CustomerId_Email"].Caption = "Email";
				dataset.Tables[tableName].Columns["CustomerId_IDType"].Caption = "IDType";
				dataset.Tables[tableName].Columns["CustomerId_IDDetails"].Caption = "IDDetails";
				dataset.Tables[tableName].Columns["CustomerId_IDExpirationDate"].Caption = "IDExpirationDate";
				dataset.Tables[tableName].Columns["CustomerId_Nationality"].Caption = "Nationality";
				dataset.Tables[tableName].Columns["CustomerId_Active"].Caption = "Active";
				dataset.Tables[tableName].Columns["CustomerId_AccountActivated"].Caption = "AccountActivated";
				dataset.Tables[tableName].Columns["CustomerId_CardIssued"].Caption = "CardIssued";
				dataset.Tables[tableName].Columns["BeneficeryId_Id"].Caption = "Id (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Id\" column)";
				dataset.Tables[tableName].Columns["BeneficeryId_LoginName"].Caption = "LoginName";
				dataset.Tables[tableName].Columns["BeneficeryId_Password"].Caption = "Password";
				dataset.Tables[tableName].Columns["BeneficeryId_FirstName"].Caption = "FirstName";
				dataset.Tables[tableName].Columns["BeneficeryId_LastName"].Caption = "LastName";
				dataset.Tables[tableName].Columns["BeneficeryId_CardId"].Caption = "Card";
				dataset.Tables[tableName].Columns["BeneficeryId_Address"].Caption = "Address";
				dataset.Tables[tableName].Columns["BeneficeryId_Telephone"].Caption = "Telephone";
				dataset.Tables[tableName].Columns["BeneficeryId_Fax"].Caption = "Fax";
				dataset.Tables[tableName].Columns["BeneficeryId_Mobile"].Caption = "Mobile";
				dataset.Tables[tableName].Columns["BeneficeryId_Email"].Caption = "Email";
				dataset.Tables[tableName].Columns["BeneficeryId_IDType"].Caption = "IDType";
				dataset.Tables[tableName].Columns["BeneficeryId_IDDetails"].Caption = "IDDetails";
				dataset.Tables[tableName].Columns["BeneficeryId_IDExpirationDate"].Caption = "IDExpirationDate";
				dataset.Tables[tableName].Columns["BeneficeryId_Nationality"].Caption = "Nationality";
				dataset.Tables[tableName].Columns["BeneficeryId_Active"].Caption = "Active";
				dataset.Tables[tableName].Columns["BeneficeryId_AccountActivated"].Caption = "AccountActivated";
				dataset.Tables[tableName].Columns["BeneficeryId_CardIssued"].Caption = "CardIssued";
				dataset.Tables[tableName].Columns["BeneficeryBankId_Id"].Caption = "Id (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Id\" column)";
				dataset.Tables[tableName].Columns["BeneficeryBankId_CustomerId"].Caption = "Customer";
				dataset.Tables[tableName].Columns["BeneficeryBankId_RegistrationDateTime"].Caption = "RegistrationDateTime (update this label in the \"Olymars/ColumnLabel\" extended property of the \"RegistrationDateTime\" column)";
				dataset.Tables[tableName].Columns["BeneficeryBankId_AccountNumber"].Caption = "AccountNumber";
				dataset.Tables[tableName].Columns["BeneficeryBankId_Name"].Caption = "Name";
				dataset.Tables[tableName].Columns["BeneficeryBankId_BranchName"].Caption = "BranchName";
				dataset.Tables[tableName].Columns["BeneficeryBankId_Address"].Caption = "Address";
				dataset.Tables[tableName].Columns["BeneficeryBankId_ZipCode"].Caption = "ZipCode";
				dataset.Tables[tableName].Columns["BeneficeryBankId_CountryId"].Caption = "Country";
				dataset.Tables[tableName].Columns["PaymentMode_Name"].Caption = "Name";
				dataset.Tables[tableName].Columns["PaymentMode_Value"].Caption = "Value";
				dataset.Tables[tableName].Columns["PaymentMode_BaseType"].Caption = "BaseType";
				dataset.Tables[tableName].Columns["PaymentMode_ChannelThrough"].Caption = "ChannelThrough";
				dataset.Tables[tableName].Columns["PaymentMode_FinalEntity"].Caption = "FinalEntity";
				dataset.Tables[tableName].Columns["PaymentMode_Prefix"].Caption = "Prefix";
				dataset.Tables[tableName].Columns["PurposeOfTransfer_Name"].Caption = "Name";
				dataset.Tables[tableName].Columns["PurposeOfTransfer_Value"].Caption = "Value";
				dataset.Tables[tableName].Columns["PurposeOfTransfer_PaymentModeBaseType"].Caption = "PaymentModeBaseType";
				dataset.Tables[tableName].Columns["PayInCurrencyId_Id"].Caption = "Id (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Id\" column)";
				dataset.Tables[tableName].Columns["PayInCurrencyId_Name"].Caption = "Name";
				dataset.Tables[tableName].Columns["PayInCurrencyId_Code"].Caption = "Code";
				dataset.Tables[tableName].Columns["PayInCurrencyId_Scale"].Caption = "Scale";
				dataset.Tables[tableName].Columns["PayOutCurrencyId_Id"].Caption = "Id (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Id\" column)";
				dataset.Tables[tableName].Columns["PayOutCurrencyId_Name"].Caption = "Name";
				dataset.Tables[tableName].Columns["PayOutCurrencyId_Code"].Caption = "Code";
				dataset.Tables[tableName].Columns["PayOutCurrencyId_Scale"].Caption = "Scale";
				dataset.Tables[tableName].Columns["AssociatedBankId_Id"].Caption = "Id (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Id\" column)";
				dataset.Tables[tableName].Columns["AssociatedBankId_Name"].Caption = "Name";
				dataset.Tables[tableName].Columns["AssociatedBankId_BranchName"].Caption = "BranchName";
				dataset.Tables[tableName].Columns["AssociatedBankId_InternalCode"].Caption = "InternalCode";
				dataset.Tables[tableName].Columns["AssociatedBankId_ExternalCode"].Caption = "ExternalCode";
				dataset.Tables[tableName].Columns["AssociatedBankId_Address"].Caption = "Address";
				dataset.Tables[tableName].Columns["AssociatedBankId_ZipCode"].Caption = "ZipCode";
				dataset.Tables[tableName].Columns["AssociatedBankId_AccountId"].Caption = "Account";
				dataset.Tables[tableName].Columns["AssociatedBankId_LocationId"].Caption = "City/Division";
				dataset.Tables[tableName].Columns["PayInAgentUserId_Id"].Caption = "Id (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Id\" column)";
				dataset.Tables[tableName].Columns["PayInAgentUserId_LoginName"].Caption = "LoginName";
				dataset.Tables[tableName].Columns["PayInAgentUserId_LoginPassword"].Caption = "LoginPassword";
				dataset.Tables[tableName].Columns["PayInAgentUserId_TransactionPassword"].Caption = "TransactionPassword";
				dataset.Tables[tableName].Columns["PayInAgentUserId_AgentAccountId"].Caption = "AgentAccount";
				dataset.Tables[tableName].Columns["PayInAgentUserId_AgentId"].Caption = "Agent";
				dataset.Tables[tableName].Columns["PayInAgentUserId_Email"].Caption = "Email";
				dataset.Tables[tableName].Columns["PayInAgentUserId_IsAgencyEmployee"].Caption = "IsAgencyEmployee";
				dataset.Tables[tableName].Columns["PayInAgentUserId_CanBeEdited"].Caption = "CanBeEdited";
				dataset.Tables[tableName].Columns["PayInAgentUserId_Active"].Caption = "Active";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_Id"].Caption = "Id (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Id\" column)";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_Name"].Caption = "Name";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_Code"].Caption = "Code";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_AgentAccountId"].Caption = "AgentAccount";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_AgentGroupId"].Caption = "AgentGroup";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_CreditLimitInUSD"].Caption = "CreditLimitInUSD";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_IndividualTransactionLimit"].Caption = "IndividualTransactionLimit";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_AllowedDomesticTransactionType"].Caption = "AllowedDomesticTransactionType";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_AllowedInternationalTransactionType"].Caption = "AllowedInternationalTransactionType";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_ListOnWebFor"].Caption = "ListOnWebFor";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_Address"].Caption = "Address";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_Telephone"].Caption = "Telephone";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_Fax"].Caption = "Fax";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_Email"].Caption = "Email";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_LocationId"].Caption = "Location";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_ContactPerson"].Caption = "ContactPerson";
				dataset.Tables[tableName].Columns["PayInAgentLocationId_Active"].Caption = "Active";
				dataset.Tables[tableName].Columns["PayOutAgentUserId_Id"].Caption = "Id (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Id\" column)";
				dataset.Tables[tableName].Columns["PayOutAgentUserId_LoginName"].Caption = "LoginName";
				dataset.Tables[tableName].Columns["PayOutAgentUserId_LoginPassword"].Caption = "LoginPassword";
				dataset.Tables[tableName].Columns["PayOutAgentUserId_TransactionPassword"].Caption = "TransactionPassword";
				dataset.Tables[tableName].Columns["PayOutAgentUserId_AgentAccountId"].Caption = "AgentAccount";
				dataset.Tables[tableName].Columns["PayOutAgentUserId_AgentId"].Caption = "Agent";
				dataset.Tables[tableName].Columns["PayOutAgentUserId_Email"].Caption = "Email";
				dataset.Tables[tableName].Columns["PayOutAgentUserId_IsAgencyEmployee"].Caption = "IsAgencyEmployee";
				dataset.Tables[tableName].Columns["PayOutAgentUserId_CanBeEdited"].Caption = "CanBeEdited";
				dataset.Tables[tableName].Columns["PayOutAgentUserId_Active"].Caption = "Active";
				dataset.Tables[tableName].Columns["Status_Name"].Caption = "Name (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Name\" column)";
				dataset.Tables[tableName].Columns["Status_Value"].Caption = "Value (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Value\" column)";
				dataset.Tables[tableName].Columns["SettlementStatus_Name"].Caption = "Name (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Name\" column)";
				dataset.Tables[tableName].Columns["SettlementStatus_Value"].Caption = "Value (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Value\" column)";

				parameters.internal_SetErrorSource(ErrorSource.ParametersRetrieval);
				returnStatus = RetrieveParameters(ref parameters, ref sqlCommand);
			}

			catch (System.Data.SqlClient.SqlException sqlException) {

				dataset = null;
				parameters.internal_UpdateExceptionInformation(sqlException);
				returnStatus = false;

				if (this.throwExceptionOnExecute) {

					throw sqlException;
				}
			}

			catch (System.Exception exception) {

				dataset = null;
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

		/// <summary>
		/// This method allows you to execute the [spS_TransactionDetails_Full] stored procedure and retrieve back the data
		/// accessible via a string XML content.
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <param name="xml">
		/// Will contains XML content provided by SQL Server.
		/// </param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full parameters, ref string xml) {

			System.Data.SqlClient.SqlCommand sqlCommand = null;
			System.Boolean returnStatus = false;
			System.Xml.XmlTextReader xmlTextReader = null;
			System.Boolean connectionMustBeClosed = true;

			try {

				xml = String.Empty;
				ResetParameter(ref parameters);

				parameters.Param_ReturnXML = new System.Data.SqlTypes.SqlBoolean(true);

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
				xmlTextReader = (System.Xml.XmlTextReader)sqlCommand.ExecuteXmlReader();

				if (xmlTextReader != null) {

					xmlTextReader.MoveToContent();
					System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
					while (!xmlTextReader.EOF) {
						stringBuilder.Append(xmlTextReader.ReadOuterXml());
					}
					xml = stringBuilder.ToString();
					stringBuilder = null;

					if (xmlTextReader.ReadState != System.Xml.ReadState.Closed) {

						xmlTextReader.Close();	                
					}
				}
				
				parameters.internal_SetErrorSource(ErrorSource.ParametersRetrieval);
				returnStatus = RetrieveParameters(ref parameters, ref sqlCommand);
			}

			catch (System.Data.SqlClient.SqlException sqlException) {

				parameters.internal_UpdateExceptionInformation(sqlException);
				xml = String.Empty;
				returnStatus = false;

				if (this.throwExceptionOnExecute) {

					throw sqlException;
				}
			}

			catch (System.Exception exception) {

				parameters.internal_UpdateExceptionInformation(exception);
				xml = String.Empty;
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

		/// <summary>
		/// This method allows you to execute the [spS_TransactionDetails_Full] stored procedure and retrieve back the data
		/// accessible via an XmlReader (System.Xml.XmlReader).
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <param name="xmlReader">
		/// Reader a System.Xml.XmlReader.
		/// </param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_TransactionDetails_Full parameters, out System.Xml.XmlReader xmlReader) {

			System.Data.SqlClient.SqlCommand sqlCommand = null;
			System.Boolean returnStatus = false;
			System.Boolean connectionMustBeClosed = true;
			xmlReader = null;

			try {

				ResetParameter(ref parameters);

				parameters.Param_ReturnXML = new System.Data.SqlTypes.SqlBoolean(true);

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
				xmlReader = sqlCommand.ExecuteXmlReader();
				
				parameters.internal_Set_ReturnValue_Available(false);

				parameters.internal_Set_XmlReader(ref xmlReader);
				parameters.internal_Set_SqlCommand(ref sqlCommand);
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

				// We do not close the SqlConnection because the XmlReader object needs it.
				// It is the responsability of the caller to close it by calling: xmlReader.Close();

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

		/// <summary>
		/// This class allows to easily retrieve the name or index of all the fields
		/// of the resulset #1 existing in the Dataset or the SqlDatReader returned by
		/// the Execute method of the 'spS_TransactionDetails_Full' class.
		/// </summary>
		public class Resultset1 {


			/// <summary>
			/// This collection provides the fields collection for this resultset.
			/// </summary>
			public class Fields {

				/// <summary>
				/// Allows to get the Index and Name of the field Id via shared members
				/// </summary>
				public class Column_Id {

					/// <summary>
					/// Returns "Id"
					/// </summary>
					public const System.String ColumnName = "Id";
					/// <summary>
					/// Returns 0
					/// </summary>
					public const System.Int32 ColumnIndex = 0;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field VoucherNumber via shared members
				/// </summary>
				public class Column_VoucherNumber {

					/// <summary>
					/// Returns "VoucherNumber"
					/// </summary>
					public const System.String ColumnName = "VoucherNumber";
					/// <summary>
					/// Returns 1
					/// </summary>
					public const System.Int32 ColumnIndex = 1;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionNumber via shared members
				/// </summary>
				public class Column_TransactionNumber {

					/// <summary>
					/// Returns "TransactionNumber"
					/// </summary>
					public const System.String ColumnName = "TransactionNumber";
					/// <summary>
					/// Returns 2
					/// </summary>
					public const System.Int32 ColumnIndex = 2;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId via shared members
				/// </summary>
				public class Column_CustomerId {

					/// <summary>
					/// Returns "CustomerId"
					/// </summary>
					public const System.String ColumnName = "CustomerId";
					/// <summary>
					/// Returns 3
					/// </summary>
					public const System.Int32 ColumnIndex = 3;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId via shared members
				/// </summary>
				public class Column_BeneficeryId {

					/// <summary>
					/// Returns "BeneficeryId"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId";
					/// <summary>
					/// Returns 4
					/// </summary>
					public const System.Int32 ColumnIndex = 4;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryBankId via shared members
				/// </summary>
				public class Column_BeneficeryBankId {

					/// <summary>
					/// Returns "BeneficeryBankId"
					/// </summary>
					public const System.String ColumnName = "BeneficeryBankId";
					/// <summary>
					/// Returns 5
					/// </summary>
					public const System.Int32 ColumnIndex = 5;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PaymentMode via shared members
				/// </summary>
				public class Column_PaymentMode {

					/// <summary>
					/// Returns "PaymentMode"
					/// </summary>
					public const System.String ColumnName = "PaymentMode";
					/// <summary>
					/// Returns 6
					/// </summary>
					public const System.Int32 ColumnIndex = 6;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PurposeOfTransfer via shared members
				/// </summary>
				public class Column_PurposeOfTransfer {

					/// <summary>
					/// Returns "PurposeOfTransfer"
					/// </summary>
					public const System.String ColumnName = "PurposeOfTransfer";
					/// <summary>
					/// Returns 7
					/// </summary>
					public const System.Int32 ColumnIndex = 7;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInCurrencyId via shared members
				/// </summary>
				public class Column_PayInCurrencyId {

					/// <summary>
					/// Returns "PayInCurrencyId"
					/// </summary>
					public const System.String ColumnName = "PayInCurrencyId";
					/// <summary>
					/// Returns 8
					/// </summary>
					public const System.Int32 ColumnIndex = 8;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAmount via shared members
				/// </summary>
				public class Column_PayInAmount {

					/// <summary>
					/// Returns "PayInAmount"
					/// </summary>
					public const System.String ColumnName = "PayInAmount";
					/// <summary>
					/// Returns 9
					/// </summary>
					public const System.Int32 ColumnIndex = 9;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutCurrencyId via shared members
				/// </summary>
				public class Column_PayOutCurrencyId {

					/// <summary>
					/// Returns "PayOutCurrencyId"
					/// </summary>
					public const System.String ColumnName = "PayOutCurrencyId";
					/// <summary>
					/// Returns 10
					/// </summary>
					public const System.Int32 ColumnIndex = 10;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutAmount via shared members
				/// </summary>
				public class Column_PayOutAmount {

					/// <summary>
					/// Returns "PayOutAmount"
					/// </summary>
					public const System.String ColumnName = "PayOutAmount";
					/// <summary>
					/// Returns 11
					/// </summary>
					public const System.Int32 ColumnIndex = 11;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field Commission via shared members
				/// </summary>
				public class Column_Commission {

					/// <summary>
					/// Returns "Commission"
					/// </summary>
					public const System.String ColumnName = "Commission";
					/// <summary>
					/// Returns 12
					/// </summary>
					public const System.Int32 ColumnIndex = 12;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field Question via shared members
				/// </summary>
				public class Column_Question {

					/// <summary>
					/// Returns "Question"
					/// </summary>
					public const System.String ColumnName = "Question";
					/// <summary>
					/// Returns 13
					/// </summary>
					public const System.Int32 ColumnIndex = 13;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field Answer via shared members
				/// </summary>
				public class Column_Answer {

					/// <summary>
					/// Returns "Answer"
					/// </summary>
					public const System.String ColumnName = "Answer";
					/// <summary>
					/// Returns 14
					/// </summary>
					public const System.Int32 ColumnIndex = 14;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field MessageToBeneficery via shared members
				/// </summary>
				public class Column_MessageToBeneficery {

					/// <summary>
					/// Returns "MessageToBeneficery"
					/// </summary>
					public const System.String ColumnName = "MessageToBeneficery";
					/// <summary>
					/// Returns 15
					/// </summary>
					public const System.Int32 ColumnIndex = 15;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field MessageToPayOutAgent via shared members
				/// </summary>
				public class Column_MessageToPayOutAgent {

					/// <summary>
					/// Returns "MessageToPayOutAgent"
					/// </summary>
					public const System.String ColumnName = "MessageToPayOutAgent";
					/// <summary>
					/// Returns 16
					/// </summary>
					public const System.Int32 ColumnIndex = 16;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BankExchangeRateForPayInCurrency via shared members
				/// </summary>
				public class Column_BankExchangeRateForPayInCurrency {

					/// <summary>
					/// Returns "BankExchangeRateForPayInCurrency"
					/// </summary>
					public const System.String ColumnName = "BankExchangeRateForPayInCurrency";
					/// <summary>
					/// Returns 17
					/// </summary>
					public const System.Int32 ColumnIndex = 17;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BankExchangeRateForPayOutCurrency via shared members
				/// </summary>
				public class Column_BankExchangeRateForPayOutCurrency {

					/// <summary>
					/// Returns "BankExchangeRateForPayOutCurrency"
					/// </summary>
					public const System.String ColumnName = "BankExchangeRateForPayOutCurrency";
					/// <summary>
					/// Returns 18
					/// </summary>
					public const System.Int32 ColumnIndex = 18;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInCurrencyGroup via shared members
				/// </summary>
				public class Column_PayInCurrencyGroup {

					/// <summary>
					/// Returns "PayInCurrencyGroup"
					/// </summary>
					public const System.String ColumnName = "PayInCurrencyGroup";
					/// <summary>
					/// Returns 19
					/// </summary>
					public const System.Int32 ColumnIndex = 19;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutCurrencyGroup via shared members
				/// </summary>
				public class Column_PayOutCurrencyGroup {

					/// <summary>
					/// Returns "PayOutCurrencyGroup"
					/// </summary>
					public const System.String ColumnName = "PayOutCurrencyGroup";
					/// <summary>
					/// Returns 20
					/// </summary>
					public const System.Int32 ColumnIndex = 20;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field FinalBankExchangeRate via shared members
				/// </summary>
				public class Column_FinalBankExchangeRate {

					/// <summary>
					/// Returns "FinalBankExchangeRate"
					/// </summary>
					public const System.String ColumnName = "FinalBankExchangeRate";
					/// <summary>
					/// Returns 21
					/// </summary>
					public const System.Int32 ColumnIndex = 21;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AgencyMarginPercent via shared members
				/// </summary>
				public class Column_AgencyMarginPercent {

					/// <summary>
					/// Returns "AgencyMarginPercent"
					/// </summary>
					public const System.String ColumnName = "AgencyMarginPercent";
					/// <summary>
					/// Returns 22
					/// </summary>
					public const System.Int32 ColumnIndex = 22;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AgencyExchangeRate via shared members
				/// </summary>
				public class Column_AgencyExchangeRate {

					/// <summary>
					/// Returns "AgencyExchangeRate"
					/// </summary>
					public const System.String ColumnName = "AgencyExchangeRate";
					/// <summary>
					/// Returns 23
					/// </summary>
					public const System.Int32 ColumnIndex = 23;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AgentMarginPercent via shared members
				/// </summary>
				public class Column_AgentMarginPercent {

					/// <summary>
					/// Returns "AgentMarginPercent"
					/// </summary>
					public const System.String ColumnName = "AgentMarginPercent";
					/// <summary>
					/// Returns 24
					/// </summary>
					public const System.Int32 ColumnIndex = 24;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AgentExchangeRate via shared members
				/// </summary>
				public class Column_AgentExchangeRate {

					/// <summary>
					/// Returns "AgentExchangeRate"
					/// </summary>
					public const System.String ColumnName = "AgentExchangeRate";
					/// <summary>
					/// Returns 25
					/// </summary>
					public const System.Int32 ColumnIndex = 25;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AssociatedBankId via shared members
				/// </summary>
				public class Column_AssociatedBankId {

					/// <summary>
					/// Returns "AssociatedBankId"
					/// </summary>
					public const System.String ColumnName = "AssociatedBankId";
					/// <summary>
					/// Returns 26
					/// </summary>
					public const System.Int32 ColumnIndex = 26;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutLocationId via shared members
				/// </summary>
				public class Column_PayOutLocationId {

					/// <summary>
					/// Returns "PayOutLocationId"
					/// </summary>
					public const System.String ColumnName = "PayOutLocationId";
					/// <summary>
					/// Returns 27
					/// </summary>
					public const System.Int32 ColumnIndex = 27;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentUserId via shared members
				/// </summary>
				public class Column_PayInAgentUserId {

					/// <summary>
					/// Returns "PayInAgentUserId"
					/// </summary>
					public const System.String ColumnName = "PayInAgentUserId";
					/// <summary>
					/// Returns 28
					/// </summary>
					public const System.Int32 ColumnIndex = 28;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId via shared members
				/// </summary>
				public class Column_PayInAgentLocationId {

					/// <summary>
					/// Returns "PayInAgentLocationId"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId";
					/// <summary>
					/// Returns 29
					/// </summary>
					public const System.Int32 ColumnIndex = 29;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInDateTime via shared members
				/// </summary>
				public class Column_PayInDateTime {

					/// <summary>
					/// Returns "PayInDateTime"
					/// </summary>
					public const System.String ColumnName = "PayInDateTime";
					/// <summary>
					/// Returns 30
					/// </summary>
					public const System.Int32 ColumnIndex = 30;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field RecommendedPayOutAgentId via shared members
				/// </summary>
				public class Column_RecommendedPayOutAgentId {

					/// <summary>
					/// Returns "RecommendedPayOutAgentId"
					/// </summary>
					public const System.String ColumnName = "RecommendedPayOutAgentId";
					/// <summary>
					/// Returns 31
					/// </summary>
					public const System.Int32 ColumnIndex = 31;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field ActualPayOutAgentId via shared members
				/// </summary>
				public class Column_ActualPayOutAgentId {

					/// <summary>
					/// Returns "ActualPayOutAgentId"
					/// </summary>
					public const System.String ColumnName = "ActualPayOutAgentId";
					/// <summary>
					/// Returns 32
					/// </summary>
					public const System.Int32 ColumnIndex = 32;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutAgentUserId via shared members
				/// </summary>
				public class Column_PayOutAgentUserId {

					/// <summary>
					/// Returns "PayOutAgentUserId"
					/// </summary>
					public const System.String ColumnName = "PayOutAgentUserId";
					/// <summary>
					/// Returns 33
					/// </summary>
					public const System.Int32 ColumnIndex = 33;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutDateTime via shared members
				/// </summary>
				public class Column_PayOutDateTime {

					/// <summary>
					/// Returns "PayOutDateTime"
					/// </summary>
					public const System.String ColumnName = "PayOutDateTime";
					/// <summary>
					/// Returns 34
					/// </summary>
					public const System.Int32 ColumnIndex = 34;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CollectedBeneficeryIdDetails via shared members
				/// </summary>
				public class Column_CollectedBeneficeryIdDetails {

					/// <summary>
					/// Returns "CollectedBeneficeryIdDetails"
					/// </summary>
					public const System.String ColumnName = "CollectedBeneficeryIdDetails";
					/// <summary>
					/// Returns 35
					/// </summary>
					public const System.Int32 ColumnIndex = 35;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field IsOpenTransaction via shared members
				/// </summary>
				public class Column_IsOpenTransaction {

					/// <summary>
					/// Returns "IsOpenTransaction"
					/// </summary>
					public const System.String ColumnName = "IsOpenTransaction";
					/// <summary>
					/// Returns 36
					/// </summary>
					public const System.Int32 ColumnIndex = 36;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field Status via shared members
				/// </summary>
				public class Column_Status {

					/// <summary>
					/// Returns "Status"
					/// </summary>
					public const System.String ColumnName = "Status";
					/// <summary>
					/// Returns 37
					/// </summary>
					public const System.Int32 ColumnIndex = 37;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field SettlementStatus via shared members
				/// </summary>
				public class Column_SettlementStatus {

					/// <summary>
					/// Returns "SettlementStatus"
					/// </summary>
					public const System.String ColumnName = "SettlementStatus";
					/// <summary>
					/// Returns 38
					/// </summary>
					public const System.Int32 ColumnIndex = 38;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_Id via shared members
				/// </summary>
				public class Column_CustomerId_Id {

					/// <summary>
					/// Returns "CustomerId_Id"
					/// </summary>
					public const System.String ColumnName = "CustomerId_Id";
					/// <summary>
					/// Returns 39
					/// </summary>
					public const System.Int32 ColumnIndex = 39;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_LoginName via shared members
				/// </summary>
				public class Column_CustomerId_LoginName {

					/// <summary>
					/// Returns "CustomerId_LoginName"
					/// </summary>
					public const System.String ColumnName = "CustomerId_LoginName";
					/// <summary>
					/// Returns 40
					/// </summary>
					public const System.Int32 ColumnIndex = 40;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_Password via shared members
				/// </summary>
				public class Column_CustomerId_Password {

					/// <summary>
					/// Returns "CustomerId_Password"
					/// </summary>
					public const System.String ColumnName = "CustomerId_Password";
					/// <summary>
					/// Returns 41
					/// </summary>
					public const System.Int32 ColumnIndex = 41;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_FirstName via shared members
				/// </summary>
				public class Column_CustomerId_FirstName {

					/// <summary>
					/// Returns "CustomerId_FirstName"
					/// </summary>
					public const System.String ColumnName = "CustomerId_FirstName";
					/// <summary>
					/// Returns 42
					/// </summary>
					public const System.Int32 ColumnIndex = 42;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_LastName via shared members
				/// </summary>
				public class Column_CustomerId_LastName {

					/// <summary>
					/// Returns "CustomerId_LastName"
					/// </summary>
					public const System.String ColumnName = "CustomerId_LastName";
					/// <summary>
					/// Returns 43
					/// </summary>
					public const System.Int32 ColumnIndex = 43;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_CardId via shared members
				/// </summary>
				public class Column_CustomerId_CardId {

					/// <summary>
					/// Returns "CustomerId_CardId"
					/// </summary>
					public const System.String ColumnName = "CustomerId_CardId";
					/// <summary>
					/// Returns 44
					/// </summary>
					public const System.Int32 ColumnIndex = 44;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_Address via shared members
				/// </summary>
				public class Column_CustomerId_Address {

					/// <summary>
					/// Returns "CustomerId_Address"
					/// </summary>
					public const System.String ColumnName = "CustomerId_Address";
					/// <summary>
					/// Returns 45
					/// </summary>
					public const System.Int32 ColumnIndex = 45;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_Telephone via shared members
				/// </summary>
				public class Column_CustomerId_Telephone {

					/// <summary>
					/// Returns "CustomerId_Telephone"
					/// </summary>
					public const System.String ColumnName = "CustomerId_Telephone";
					/// <summary>
					/// Returns 46
					/// </summary>
					public const System.Int32 ColumnIndex = 46;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_Fax via shared members
				/// </summary>
				public class Column_CustomerId_Fax {

					/// <summary>
					/// Returns "CustomerId_Fax"
					/// </summary>
					public const System.String ColumnName = "CustomerId_Fax";
					/// <summary>
					/// Returns 47
					/// </summary>
					public const System.Int32 ColumnIndex = 47;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_Mobile via shared members
				/// </summary>
				public class Column_CustomerId_Mobile {

					/// <summary>
					/// Returns "CustomerId_Mobile"
					/// </summary>
					public const System.String ColumnName = "CustomerId_Mobile";
					/// <summary>
					/// Returns 48
					/// </summary>
					public const System.Int32 ColumnIndex = 48;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_Email via shared members
				/// </summary>
				public class Column_CustomerId_Email {

					/// <summary>
					/// Returns "CustomerId_Email"
					/// </summary>
					public const System.String ColumnName = "CustomerId_Email";
					/// <summary>
					/// Returns 49
					/// </summary>
					public const System.Int32 ColumnIndex = 49;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_IDType via shared members
				/// </summary>
				public class Column_CustomerId_IDType {

					/// <summary>
					/// Returns "CustomerId_IDType"
					/// </summary>
					public const System.String ColumnName = "CustomerId_IDType";
					/// <summary>
					/// Returns 50
					/// </summary>
					public const System.Int32 ColumnIndex = 50;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_IDDetails via shared members
				/// </summary>
				public class Column_CustomerId_IDDetails {

					/// <summary>
					/// Returns "CustomerId_IDDetails"
					/// </summary>
					public const System.String ColumnName = "CustomerId_IDDetails";
					/// <summary>
					/// Returns 51
					/// </summary>
					public const System.Int32 ColumnIndex = 51;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_IDExpirationDate via shared members
				/// </summary>
				public class Column_CustomerId_IDExpirationDate {

					/// <summary>
					/// Returns "CustomerId_IDExpirationDate"
					/// </summary>
					public const System.String ColumnName = "CustomerId_IDExpirationDate";
					/// <summary>
					/// Returns 52
					/// </summary>
					public const System.Int32 ColumnIndex = 52;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_Nationality via shared members
				/// </summary>
				public class Column_CustomerId_Nationality {

					/// <summary>
					/// Returns "CustomerId_Nationality"
					/// </summary>
					public const System.String ColumnName = "CustomerId_Nationality";
					/// <summary>
					/// Returns 53
					/// </summary>
					public const System.Int32 ColumnIndex = 53;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_Active via shared members
				/// </summary>
				public class Column_CustomerId_Active {

					/// <summary>
					/// Returns "CustomerId_Active"
					/// </summary>
					public const System.String ColumnName = "CustomerId_Active";
					/// <summary>
					/// Returns 54
					/// </summary>
					public const System.Int32 ColumnIndex = 54;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_AccountActivated via shared members
				/// </summary>
				public class Column_CustomerId_AccountActivated {

					/// <summary>
					/// Returns "CustomerId_AccountActivated"
					/// </summary>
					public const System.String ColumnName = "CustomerId_AccountActivated";
					/// <summary>
					/// Returns 55
					/// </summary>
					public const System.Int32 ColumnIndex = 55;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CustomerId_CardIssued via shared members
				/// </summary>
				public class Column_CustomerId_CardIssued {

					/// <summary>
					/// Returns "CustomerId_CardIssued"
					/// </summary>
					public const System.String ColumnName = "CustomerId_CardIssued";
					/// <summary>
					/// Returns 56
					/// </summary>
					public const System.Int32 ColumnIndex = 56;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_Id via shared members
				/// </summary>
				public class Column_BeneficeryId_Id {

					/// <summary>
					/// Returns "BeneficeryId_Id"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_Id";
					/// <summary>
					/// Returns 57
					/// </summary>
					public const System.Int32 ColumnIndex = 57;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_LoginName via shared members
				/// </summary>
				public class Column_BeneficeryId_LoginName {

					/// <summary>
					/// Returns "BeneficeryId_LoginName"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_LoginName";
					/// <summary>
					/// Returns 58
					/// </summary>
					public const System.Int32 ColumnIndex = 58;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_Password via shared members
				/// </summary>
				public class Column_BeneficeryId_Password {

					/// <summary>
					/// Returns "BeneficeryId_Password"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_Password";
					/// <summary>
					/// Returns 59
					/// </summary>
					public const System.Int32 ColumnIndex = 59;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_FirstName via shared members
				/// </summary>
				public class Column_BeneficeryId_FirstName {

					/// <summary>
					/// Returns "BeneficeryId_FirstName"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_FirstName";
					/// <summary>
					/// Returns 60
					/// </summary>
					public const System.Int32 ColumnIndex = 60;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_LastName via shared members
				/// </summary>
				public class Column_BeneficeryId_LastName {

					/// <summary>
					/// Returns "BeneficeryId_LastName"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_LastName";
					/// <summary>
					/// Returns 61
					/// </summary>
					public const System.Int32 ColumnIndex = 61;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_CardId via shared members
				/// </summary>
				public class Column_BeneficeryId_CardId {

					/// <summary>
					/// Returns "BeneficeryId_CardId"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_CardId";
					/// <summary>
					/// Returns 62
					/// </summary>
					public const System.Int32 ColumnIndex = 62;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_Address via shared members
				/// </summary>
				public class Column_BeneficeryId_Address {

					/// <summary>
					/// Returns "BeneficeryId_Address"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_Address";
					/// <summary>
					/// Returns 63
					/// </summary>
					public const System.Int32 ColumnIndex = 63;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_Telephone via shared members
				/// </summary>
				public class Column_BeneficeryId_Telephone {

					/// <summary>
					/// Returns "BeneficeryId_Telephone"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_Telephone";
					/// <summary>
					/// Returns 64
					/// </summary>
					public const System.Int32 ColumnIndex = 64;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_Fax via shared members
				/// </summary>
				public class Column_BeneficeryId_Fax {

					/// <summary>
					/// Returns "BeneficeryId_Fax"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_Fax";
					/// <summary>
					/// Returns 65
					/// </summary>
					public const System.Int32 ColumnIndex = 65;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_Mobile via shared members
				/// </summary>
				public class Column_BeneficeryId_Mobile {

					/// <summary>
					/// Returns "BeneficeryId_Mobile"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_Mobile";
					/// <summary>
					/// Returns 66
					/// </summary>
					public const System.Int32 ColumnIndex = 66;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_Email via shared members
				/// </summary>
				public class Column_BeneficeryId_Email {

					/// <summary>
					/// Returns "BeneficeryId_Email"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_Email";
					/// <summary>
					/// Returns 67
					/// </summary>
					public const System.Int32 ColumnIndex = 67;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_IDType via shared members
				/// </summary>
				public class Column_BeneficeryId_IDType {

					/// <summary>
					/// Returns "BeneficeryId_IDType"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_IDType";
					/// <summary>
					/// Returns 68
					/// </summary>
					public const System.Int32 ColumnIndex = 68;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_IDDetails via shared members
				/// </summary>
				public class Column_BeneficeryId_IDDetails {

					/// <summary>
					/// Returns "BeneficeryId_IDDetails"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_IDDetails";
					/// <summary>
					/// Returns 69
					/// </summary>
					public const System.Int32 ColumnIndex = 69;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_IDExpirationDate via shared members
				/// </summary>
				public class Column_BeneficeryId_IDExpirationDate {

					/// <summary>
					/// Returns "BeneficeryId_IDExpirationDate"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_IDExpirationDate";
					/// <summary>
					/// Returns 70
					/// </summary>
					public const System.Int32 ColumnIndex = 70;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_Nationality via shared members
				/// </summary>
				public class Column_BeneficeryId_Nationality {

					/// <summary>
					/// Returns "BeneficeryId_Nationality"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_Nationality";
					/// <summary>
					/// Returns 71
					/// </summary>
					public const System.Int32 ColumnIndex = 71;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_Active via shared members
				/// </summary>
				public class Column_BeneficeryId_Active {

					/// <summary>
					/// Returns "BeneficeryId_Active"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_Active";
					/// <summary>
					/// Returns 72
					/// </summary>
					public const System.Int32 ColumnIndex = 72;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_AccountActivated via shared members
				/// </summary>
				public class Column_BeneficeryId_AccountActivated {

					/// <summary>
					/// Returns "BeneficeryId_AccountActivated"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_AccountActivated";
					/// <summary>
					/// Returns 73
					/// </summary>
					public const System.Int32 ColumnIndex = 73;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryId_CardIssued via shared members
				/// </summary>
				public class Column_BeneficeryId_CardIssued {

					/// <summary>
					/// Returns "BeneficeryId_CardIssued"
					/// </summary>
					public const System.String ColumnName = "BeneficeryId_CardIssued";
					/// <summary>
					/// Returns 74
					/// </summary>
					public const System.Int32 ColumnIndex = 74;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryBankId_Id via shared members
				/// </summary>
				public class Column_BeneficeryBankId_Id {

					/// <summary>
					/// Returns "BeneficeryBankId_Id"
					/// </summary>
					public const System.String ColumnName = "BeneficeryBankId_Id";
					/// <summary>
					/// Returns 75
					/// </summary>
					public const System.Int32 ColumnIndex = 75;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryBankId_CustomerId via shared members
				/// </summary>
				public class Column_BeneficeryBankId_CustomerId {

					/// <summary>
					/// Returns "BeneficeryBankId_CustomerId"
					/// </summary>
					public const System.String ColumnName = "BeneficeryBankId_CustomerId";
					/// <summary>
					/// Returns 76
					/// </summary>
					public const System.Int32 ColumnIndex = 76;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryBankId_RegistrationDateTime via shared members
				/// </summary>
				public class Column_BeneficeryBankId_RegistrationDateTime {

					/// <summary>
					/// Returns "BeneficeryBankId_RegistrationDateTime"
					/// </summary>
					public const System.String ColumnName = "BeneficeryBankId_RegistrationDateTime";
					/// <summary>
					/// Returns 77
					/// </summary>
					public const System.Int32 ColumnIndex = 77;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryBankId_AccountNumber via shared members
				/// </summary>
				public class Column_BeneficeryBankId_AccountNumber {

					/// <summary>
					/// Returns "BeneficeryBankId_AccountNumber"
					/// </summary>
					public const System.String ColumnName = "BeneficeryBankId_AccountNumber";
					/// <summary>
					/// Returns 78
					/// </summary>
					public const System.Int32 ColumnIndex = 78;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryBankId_Name via shared members
				/// </summary>
				public class Column_BeneficeryBankId_Name {

					/// <summary>
					/// Returns "BeneficeryBankId_Name"
					/// </summary>
					public const System.String ColumnName = "BeneficeryBankId_Name";
					/// <summary>
					/// Returns 79
					/// </summary>
					public const System.Int32 ColumnIndex = 79;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryBankId_BranchName via shared members
				/// </summary>
				public class Column_BeneficeryBankId_BranchName {

					/// <summary>
					/// Returns "BeneficeryBankId_BranchName"
					/// </summary>
					public const System.String ColumnName = "BeneficeryBankId_BranchName";
					/// <summary>
					/// Returns 80
					/// </summary>
					public const System.Int32 ColumnIndex = 80;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryBankId_Address via shared members
				/// </summary>
				public class Column_BeneficeryBankId_Address {

					/// <summary>
					/// Returns "BeneficeryBankId_Address"
					/// </summary>
					public const System.String ColumnName = "BeneficeryBankId_Address";
					/// <summary>
					/// Returns 81
					/// </summary>
					public const System.Int32 ColumnIndex = 81;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryBankId_ZipCode via shared members
				/// </summary>
				public class Column_BeneficeryBankId_ZipCode {

					/// <summary>
					/// Returns "BeneficeryBankId_ZipCode"
					/// </summary>
					public const System.String ColumnName = "BeneficeryBankId_ZipCode";
					/// <summary>
					/// Returns 82
					/// </summary>
					public const System.Int32 ColumnIndex = 82;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field BeneficeryBankId_CountryId via shared members
				/// </summary>
				public class Column_BeneficeryBankId_CountryId {

					/// <summary>
					/// Returns "BeneficeryBankId_CountryId"
					/// </summary>
					public const System.String ColumnName = "BeneficeryBankId_CountryId";
					/// <summary>
					/// Returns 83
					/// </summary>
					public const System.Int32 ColumnIndex = 83;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PaymentMode_Name via shared members
				/// </summary>
				public class Column_PaymentMode_Name {

					/// <summary>
					/// Returns "PaymentMode_Name"
					/// </summary>
					public const System.String ColumnName = "PaymentMode_Name";
					/// <summary>
					/// Returns 84
					/// </summary>
					public const System.Int32 ColumnIndex = 84;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PaymentMode_Value via shared members
				/// </summary>
				public class Column_PaymentMode_Value {

					/// <summary>
					/// Returns "PaymentMode_Value"
					/// </summary>
					public const System.String ColumnName = "PaymentMode_Value";
					/// <summary>
					/// Returns 85
					/// </summary>
					public const System.Int32 ColumnIndex = 85;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PaymentMode_BaseType via shared members
				/// </summary>
				public class Column_PaymentMode_BaseType {

					/// <summary>
					/// Returns "PaymentMode_BaseType"
					/// </summary>
					public const System.String ColumnName = "PaymentMode_BaseType";
					/// <summary>
					/// Returns 86
					/// </summary>
					public const System.Int32 ColumnIndex = 86;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PaymentMode_ChannelThrough via shared members
				/// </summary>
				public class Column_PaymentMode_ChannelThrough {

					/// <summary>
					/// Returns "PaymentMode_ChannelThrough"
					/// </summary>
					public const System.String ColumnName = "PaymentMode_ChannelThrough";
					/// <summary>
					/// Returns 87
					/// </summary>
					public const System.Int32 ColumnIndex = 87;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PaymentMode_FinalEntity via shared members
				/// </summary>
				public class Column_PaymentMode_FinalEntity {

					/// <summary>
					/// Returns "PaymentMode_FinalEntity"
					/// </summary>
					public const System.String ColumnName = "PaymentMode_FinalEntity";
					/// <summary>
					/// Returns 88
					/// </summary>
					public const System.Int32 ColumnIndex = 88;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PaymentMode_Prefix via shared members
				/// </summary>
				public class Column_PaymentMode_Prefix {

					/// <summary>
					/// Returns "PaymentMode_Prefix"
					/// </summary>
					public const System.String ColumnName = "PaymentMode_Prefix";
					/// <summary>
					/// Returns 89
					/// </summary>
					public const System.Int32 ColumnIndex = 89;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PurposeOfTransfer_Name via shared members
				/// </summary>
				public class Column_PurposeOfTransfer_Name {

					/// <summary>
					/// Returns "PurposeOfTransfer_Name"
					/// </summary>
					public const System.String ColumnName = "PurposeOfTransfer_Name";
					/// <summary>
					/// Returns 90
					/// </summary>
					public const System.Int32 ColumnIndex = 90;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PurposeOfTransfer_Value via shared members
				/// </summary>
				public class Column_PurposeOfTransfer_Value {

					/// <summary>
					/// Returns "PurposeOfTransfer_Value"
					/// </summary>
					public const System.String ColumnName = "PurposeOfTransfer_Value";
					/// <summary>
					/// Returns 91
					/// </summary>
					public const System.Int32 ColumnIndex = 91;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PurposeOfTransfer_PaymentModeBaseType via shared members
				/// </summary>
				public class Column_PurposeOfTransfer_PaymentModeBaseType {

					/// <summary>
					/// Returns "PurposeOfTransfer_PaymentModeBaseType"
					/// </summary>
					public const System.String ColumnName = "PurposeOfTransfer_PaymentModeBaseType";
					/// <summary>
					/// Returns 92
					/// </summary>
					public const System.Int32 ColumnIndex = 92;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInCurrencyId_Id via shared members
				/// </summary>
				public class Column_PayInCurrencyId_Id {

					/// <summary>
					/// Returns "PayInCurrencyId_Id"
					/// </summary>
					public const System.String ColumnName = "PayInCurrencyId_Id";
					/// <summary>
					/// Returns 93
					/// </summary>
					public const System.Int32 ColumnIndex = 93;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInCurrencyId_Name via shared members
				/// </summary>
				public class Column_PayInCurrencyId_Name {

					/// <summary>
					/// Returns "PayInCurrencyId_Name"
					/// </summary>
					public const System.String ColumnName = "PayInCurrencyId_Name";
					/// <summary>
					/// Returns 94
					/// </summary>
					public const System.Int32 ColumnIndex = 94;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInCurrencyId_Code via shared members
				/// </summary>
				public class Column_PayInCurrencyId_Code {

					/// <summary>
					/// Returns "PayInCurrencyId_Code"
					/// </summary>
					public const System.String ColumnName = "PayInCurrencyId_Code";
					/// <summary>
					/// Returns 95
					/// </summary>
					public const System.Int32 ColumnIndex = 95;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInCurrencyId_Scale via shared members
				/// </summary>
				public class Column_PayInCurrencyId_Scale {

					/// <summary>
					/// Returns "PayInCurrencyId_Scale"
					/// </summary>
					public const System.String ColumnName = "PayInCurrencyId_Scale";
					/// <summary>
					/// Returns 96
					/// </summary>
					public const System.Int32 ColumnIndex = 96;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutCurrencyId_Id via shared members
				/// </summary>
				public class Column_PayOutCurrencyId_Id {

					/// <summary>
					/// Returns "PayOutCurrencyId_Id"
					/// </summary>
					public const System.String ColumnName = "PayOutCurrencyId_Id";
					/// <summary>
					/// Returns 97
					/// </summary>
					public const System.Int32 ColumnIndex = 97;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutCurrencyId_Name via shared members
				/// </summary>
				public class Column_PayOutCurrencyId_Name {

					/// <summary>
					/// Returns "PayOutCurrencyId_Name"
					/// </summary>
					public const System.String ColumnName = "PayOutCurrencyId_Name";
					/// <summary>
					/// Returns 98
					/// </summary>
					public const System.Int32 ColumnIndex = 98;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutCurrencyId_Code via shared members
				/// </summary>
				public class Column_PayOutCurrencyId_Code {

					/// <summary>
					/// Returns "PayOutCurrencyId_Code"
					/// </summary>
					public const System.String ColumnName = "PayOutCurrencyId_Code";
					/// <summary>
					/// Returns 99
					/// </summary>
					public const System.Int32 ColumnIndex = 99;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutCurrencyId_Scale via shared members
				/// </summary>
				public class Column_PayOutCurrencyId_Scale {

					/// <summary>
					/// Returns "PayOutCurrencyId_Scale"
					/// </summary>
					public const System.String ColumnName = "PayOutCurrencyId_Scale";
					/// <summary>
					/// Returns 100
					/// </summary>
					public const System.Int32 ColumnIndex = 100;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AssociatedBankId_Id via shared members
				/// </summary>
				public class Column_AssociatedBankId_Id {

					/// <summary>
					/// Returns "AssociatedBankId_Id"
					/// </summary>
					public const System.String ColumnName = "AssociatedBankId_Id";
					/// <summary>
					/// Returns 101
					/// </summary>
					public const System.Int32 ColumnIndex = 101;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AssociatedBankId_Name via shared members
				/// </summary>
				public class Column_AssociatedBankId_Name {

					/// <summary>
					/// Returns "AssociatedBankId_Name"
					/// </summary>
					public const System.String ColumnName = "AssociatedBankId_Name";
					/// <summary>
					/// Returns 102
					/// </summary>
					public const System.Int32 ColumnIndex = 102;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AssociatedBankId_BranchName via shared members
				/// </summary>
				public class Column_AssociatedBankId_BranchName {

					/// <summary>
					/// Returns "AssociatedBankId_BranchName"
					/// </summary>
					public const System.String ColumnName = "AssociatedBankId_BranchName";
					/// <summary>
					/// Returns 103
					/// </summary>
					public const System.Int32 ColumnIndex = 103;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AssociatedBankId_InternalCode via shared members
				/// </summary>
				public class Column_AssociatedBankId_InternalCode {

					/// <summary>
					/// Returns "AssociatedBankId_InternalCode"
					/// </summary>
					public const System.String ColumnName = "AssociatedBankId_InternalCode";
					/// <summary>
					/// Returns 104
					/// </summary>
					public const System.Int32 ColumnIndex = 104;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AssociatedBankId_ExternalCode via shared members
				/// </summary>
				public class Column_AssociatedBankId_ExternalCode {

					/// <summary>
					/// Returns "AssociatedBankId_ExternalCode"
					/// </summary>
					public const System.String ColumnName = "AssociatedBankId_ExternalCode";
					/// <summary>
					/// Returns 105
					/// </summary>
					public const System.Int32 ColumnIndex = 105;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AssociatedBankId_Address via shared members
				/// </summary>
				public class Column_AssociatedBankId_Address {

					/// <summary>
					/// Returns "AssociatedBankId_Address"
					/// </summary>
					public const System.String ColumnName = "AssociatedBankId_Address";
					/// <summary>
					/// Returns 106
					/// </summary>
					public const System.Int32 ColumnIndex = 106;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AssociatedBankId_ZipCode via shared members
				/// </summary>
				public class Column_AssociatedBankId_ZipCode {

					/// <summary>
					/// Returns "AssociatedBankId_ZipCode"
					/// </summary>
					public const System.String ColumnName = "AssociatedBankId_ZipCode";
					/// <summary>
					/// Returns 107
					/// </summary>
					public const System.Int32 ColumnIndex = 107;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AssociatedBankId_AccountId via shared members
				/// </summary>
				public class Column_AssociatedBankId_AccountId {

					/// <summary>
					/// Returns "AssociatedBankId_AccountId"
					/// </summary>
					public const System.String ColumnName = "AssociatedBankId_AccountId";
					/// <summary>
					/// Returns 108
					/// </summary>
					public const System.Int32 ColumnIndex = 108;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field AssociatedBankId_LocationId via shared members
				/// </summary>
				public class Column_AssociatedBankId_LocationId {

					/// <summary>
					/// Returns "AssociatedBankId_LocationId"
					/// </summary>
					public const System.String ColumnName = "AssociatedBankId_LocationId";
					/// <summary>
					/// Returns 109
					/// </summary>
					public const System.Int32 ColumnIndex = 109;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentUserId_Id via shared members
				/// </summary>
				public class Column_PayInAgentUserId_Id {

					/// <summary>
					/// Returns "PayInAgentUserId_Id"
					/// </summary>
					public const System.String ColumnName = "PayInAgentUserId_Id";
					/// <summary>
					/// Returns 110
					/// </summary>
					public const System.Int32 ColumnIndex = 110;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentUserId_LoginName via shared members
				/// </summary>
				public class Column_PayInAgentUserId_LoginName {

					/// <summary>
					/// Returns "PayInAgentUserId_LoginName"
					/// </summary>
					public const System.String ColumnName = "PayInAgentUserId_LoginName";
					/// <summary>
					/// Returns 111
					/// </summary>
					public const System.Int32 ColumnIndex = 111;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentUserId_LoginPassword via shared members
				/// </summary>
				public class Column_PayInAgentUserId_LoginPassword {

					/// <summary>
					/// Returns "PayInAgentUserId_LoginPassword"
					/// </summary>
					public const System.String ColumnName = "PayInAgentUserId_LoginPassword";
					/// <summary>
					/// Returns 112
					/// </summary>
					public const System.Int32 ColumnIndex = 112;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentUserId_TransactionPassword via shared members
				/// </summary>
				public class Column_PayInAgentUserId_TransactionPassword {

					/// <summary>
					/// Returns "PayInAgentUserId_TransactionPassword"
					/// </summary>
					public const System.String ColumnName = "PayInAgentUserId_TransactionPassword";
					/// <summary>
					/// Returns 113
					/// </summary>
					public const System.Int32 ColumnIndex = 113;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentUserId_AgentAccountId via shared members
				/// </summary>
				public class Column_PayInAgentUserId_AgentAccountId {

					/// <summary>
					/// Returns "PayInAgentUserId_AgentAccountId"
					/// </summary>
					public const System.String ColumnName = "PayInAgentUserId_AgentAccountId";
					/// <summary>
					/// Returns 114
					/// </summary>
					public const System.Int32 ColumnIndex = 114;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentUserId_AgentId via shared members
				/// </summary>
				public class Column_PayInAgentUserId_AgentId {

					/// <summary>
					/// Returns "PayInAgentUserId_AgentId"
					/// </summary>
					public const System.String ColumnName = "PayInAgentUserId_AgentId";
					/// <summary>
					/// Returns 115
					/// </summary>
					public const System.Int32 ColumnIndex = 115;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentUserId_Email via shared members
				/// </summary>
				public class Column_PayInAgentUserId_Email {

					/// <summary>
					/// Returns "PayInAgentUserId_Email"
					/// </summary>
					public const System.String ColumnName = "PayInAgentUserId_Email";
					/// <summary>
					/// Returns 116
					/// </summary>
					public const System.Int32 ColumnIndex = 116;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentUserId_IsAgencyEmployee via shared members
				/// </summary>
				public class Column_PayInAgentUserId_IsAgencyEmployee {

					/// <summary>
					/// Returns "PayInAgentUserId_IsAgencyEmployee"
					/// </summary>
					public const System.String ColumnName = "PayInAgentUserId_IsAgencyEmployee";
					/// <summary>
					/// Returns 117
					/// </summary>
					public const System.Int32 ColumnIndex = 117;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentUserId_CanBeEdited via shared members
				/// </summary>
				public class Column_PayInAgentUserId_CanBeEdited {

					/// <summary>
					/// Returns "PayInAgentUserId_CanBeEdited"
					/// </summary>
					public const System.String ColumnName = "PayInAgentUserId_CanBeEdited";
					/// <summary>
					/// Returns 118
					/// </summary>
					public const System.Int32 ColumnIndex = 118;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentUserId_Active via shared members
				/// </summary>
				public class Column_PayInAgentUserId_Active {

					/// <summary>
					/// Returns "PayInAgentUserId_Active"
					/// </summary>
					public const System.String ColumnName = "PayInAgentUserId_Active";
					/// <summary>
					/// Returns 119
					/// </summary>
					public const System.Int32 ColumnIndex = 119;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_Id via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_Id {

					/// <summary>
					/// Returns "PayInAgentLocationId_Id"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_Id";
					/// <summary>
					/// Returns 120
					/// </summary>
					public const System.Int32 ColumnIndex = 120;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_Name via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_Name {

					/// <summary>
					/// Returns "PayInAgentLocationId_Name"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_Name";
					/// <summary>
					/// Returns 121
					/// </summary>
					public const System.Int32 ColumnIndex = 121;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_Code via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_Code {

					/// <summary>
					/// Returns "PayInAgentLocationId_Code"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_Code";
					/// <summary>
					/// Returns 122
					/// </summary>
					public const System.Int32 ColumnIndex = 122;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_AgentAccountId via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_AgentAccountId {

					/// <summary>
					/// Returns "PayInAgentLocationId_AgentAccountId"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_AgentAccountId";
					/// <summary>
					/// Returns 123
					/// </summary>
					public const System.Int32 ColumnIndex = 123;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_AgentGroupId via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_AgentGroupId {

					/// <summary>
					/// Returns "PayInAgentLocationId_AgentGroupId"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_AgentGroupId";
					/// <summary>
					/// Returns 124
					/// </summary>
					public const System.Int32 ColumnIndex = 124;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_CreditLimitInUSD via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_CreditLimitInUSD {

					/// <summary>
					/// Returns "PayInAgentLocationId_CreditLimitInUSD"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_CreditLimitInUSD";
					/// <summary>
					/// Returns 125
					/// </summary>
					public const System.Int32 ColumnIndex = 125;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_IndividualTransactionLimit via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_IndividualTransactionLimit {

					/// <summary>
					/// Returns "PayInAgentLocationId_IndividualTransactionLimit"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_IndividualTransactionLimit";
					/// <summary>
					/// Returns 126
					/// </summary>
					public const System.Int32 ColumnIndex = 126;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_AllowedDomesticTransactionType via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_AllowedDomesticTransactionType {

					/// <summary>
					/// Returns "PayInAgentLocationId_AllowedDomesticTransactionType"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_AllowedDomesticTransactionType";
					/// <summary>
					/// Returns 127
					/// </summary>
					public const System.Int32 ColumnIndex = 127;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_AllowedInternationalTransactionType via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_AllowedInternationalTransactionType {

					/// <summary>
					/// Returns "PayInAgentLocationId_AllowedInternationalTransactionType"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_AllowedInternationalTransactionType";
					/// <summary>
					/// Returns 128
					/// </summary>
					public const System.Int32 ColumnIndex = 128;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_ListOnWebFor via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_ListOnWebFor {

					/// <summary>
					/// Returns "PayInAgentLocationId_ListOnWebFor"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_ListOnWebFor";
					/// <summary>
					/// Returns 129
					/// </summary>
					public const System.Int32 ColumnIndex = 129;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_Address via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_Address {

					/// <summary>
					/// Returns "PayInAgentLocationId_Address"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_Address";
					/// <summary>
					/// Returns 130
					/// </summary>
					public const System.Int32 ColumnIndex = 130;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_Telephone via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_Telephone {

					/// <summary>
					/// Returns "PayInAgentLocationId_Telephone"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_Telephone";
					/// <summary>
					/// Returns 131
					/// </summary>
					public const System.Int32 ColumnIndex = 131;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_Fax via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_Fax {

					/// <summary>
					/// Returns "PayInAgentLocationId_Fax"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_Fax";
					/// <summary>
					/// Returns 132
					/// </summary>
					public const System.Int32 ColumnIndex = 132;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_Email via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_Email {

					/// <summary>
					/// Returns "PayInAgentLocationId_Email"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_Email";
					/// <summary>
					/// Returns 133
					/// </summary>
					public const System.Int32 ColumnIndex = 133;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_LocationId via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_LocationId {

					/// <summary>
					/// Returns "PayInAgentLocationId_LocationId"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_LocationId";
					/// <summary>
					/// Returns 134
					/// </summary>
					public const System.Int32 ColumnIndex = 134;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_ContactPerson via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_ContactPerson {

					/// <summary>
					/// Returns "PayInAgentLocationId_ContactPerson"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_ContactPerson";
					/// <summary>
					/// Returns 135
					/// </summary>
					public const System.Int32 ColumnIndex = 135;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayInAgentLocationId_Active via shared members
				/// </summary>
				public class Column_PayInAgentLocationId_Active {

					/// <summary>
					/// Returns "PayInAgentLocationId_Active"
					/// </summary>
					public const System.String ColumnName = "PayInAgentLocationId_Active";
					/// <summary>
					/// Returns 136
					/// </summary>
					public const System.Int32 ColumnIndex = 136;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutAgentUserId_Id via shared members
				/// </summary>
				public class Column_PayOutAgentUserId_Id {

					/// <summary>
					/// Returns "PayOutAgentUserId_Id"
					/// </summary>
					public const System.String ColumnName = "PayOutAgentUserId_Id";
					/// <summary>
					/// Returns 137
					/// </summary>
					public const System.Int32 ColumnIndex = 137;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutAgentUserId_LoginName via shared members
				/// </summary>
				public class Column_PayOutAgentUserId_LoginName {

					/// <summary>
					/// Returns "PayOutAgentUserId_LoginName"
					/// </summary>
					public const System.String ColumnName = "PayOutAgentUserId_LoginName";
					/// <summary>
					/// Returns 138
					/// </summary>
					public const System.Int32 ColumnIndex = 138;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutAgentUserId_LoginPassword via shared members
				/// </summary>
				public class Column_PayOutAgentUserId_LoginPassword {

					/// <summary>
					/// Returns "PayOutAgentUserId_LoginPassword"
					/// </summary>
					public const System.String ColumnName = "PayOutAgentUserId_LoginPassword";
					/// <summary>
					/// Returns 139
					/// </summary>
					public const System.Int32 ColumnIndex = 139;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutAgentUserId_TransactionPassword via shared members
				/// </summary>
				public class Column_PayOutAgentUserId_TransactionPassword {

					/// <summary>
					/// Returns "PayOutAgentUserId_TransactionPassword"
					/// </summary>
					public const System.String ColumnName = "PayOutAgentUserId_TransactionPassword";
					/// <summary>
					/// Returns 140
					/// </summary>
					public const System.Int32 ColumnIndex = 140;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutAgentUserId_AgentAccountId via shared members
				/// </summary>
				public class Column_PayOutAgentUserId_AgentAccountId {

					/// <summary>
					/// Returns "PayOutAgentUserId_AgentAccountId"
					/// </summary>
					public const System.String ColumnName = "PayOutAgentUserId_AgentAccountId";
					/// <summary>
					/// Returns 141
					/// </summary>
					public const System.Int32 ColumnIndex = 141;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutAgentUserId_AgentId via shared members
				/// </summary>
				public class Column_PayOutAgentUserId_AgentId {

					/// <summary>
					/// Returns "PayOutAgentUserId_AgentId"
					/// </summary>
					public const System.String ColumnName = "PayOutAgentUserId_AgentId";
					/// <summary>
					/// Returns 142
					/// </summary>
					public const System.Int32 ColumnIndex = 142;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutAgentUserId_Email via shared members
				/// </summary>
				public class Column_PayOutAgentUserId_Email {

					/// <summary>
					/// Returns "PayOutAgentUserId_Email"
					/// </summary>
					public const System.String ColumnName = "PayOutAgentUserId_Email";
					/// <summary>
					/// Returns 143
					/// </summary>
					public const System.Int32 ColumnIndex = 143;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutAgentUserId_IsAgencyEmployee via shared members
				/// </summary>
				public class Column_PayOutAgentUserId_IsAgencyEmployee {

					/// <summary>
					/// Returns "PayOutAgentUserId_IsAgencyEmployee"
					/// </summary>
					public const System.String ColumnName = "PayOutAgentUserId_IsAgencyEmployee";
					/// <summary>
					/// Returns 144
					/// </summary>
					public const System.Int32 ColumnIndex = 144;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutAgentUserId_CanBeEdited via shared members
				/// </summary>
				public class Column_PayOutAgentUserId_CanBeEdited {

					/// <summary>
					/// Returns "PayOutAgentUserId_CanBeEdited"
					/// </summary>
					public const System.String ColumnName = "PayOutAgentUserId_CanBeEdited";
					/// <summary>
					/// Returns 145
					/// </summary>
					public const System.Int32 ColumnIndex = 145;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field PayOutAgentUserId_Active via shared members
				/// </summary>
				public class Column_PayOutAgentUserId_Active {

					/// <summary>
					/// Returns "PayOutAgentUserId_Active"
					/// </summary>
					public const System.String ColumnName = "PayOutAgentUserId_Active";
					/// <summary>
					/// Returns 146
					/// </summary>
					public const System.Int32 ColumnIndex = 146;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field Status_Name via shared members
				/// </summary>
				public class Column_Status_Name {

					/// <summary>
					/// Returns "Status_Name"
					/// </summary>
					public const System.String ColumnName = "Status_Name";
					/// <summary>
					/// Returns 147
					/// </summary>
					public const System.Int32 ColumnIndex = 147;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field Status_Value via shared members
				/// </summary>
				public class Column_Status_Value {

					/// <summary>
					/// Returns "Status_Value"
					/// </summary>
					public const System.String ColumnName = "Status_Value";
					/// <summary>
					/// Returns 148
					/// </summary>
					public const System.Int32 ColumnIndex = 148;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field SettlementStatus_Name via shared members
				/// </summary>
				public class Column_SettlementStatus_Name {

					/// <summary>
					/// Returns "SettlementStatus_Name"
					/// </summary>
					public const System.String ColumnName = "SettlementStatus_Name";
					/// <summary>
					/// Returns 149
					/// </summary>
					public const System.Int32 ColumnIndex = 149;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field SettlementStatus_Value via shared members
				/// </summary>
				public class Column_SettlementStatus_Value {

					/// <summary>
					/// Returns "SettlementStatus_Value"
					/// </summary>
					public const System.String ColumnName = "SettlementStatus_Value";
					/// <summary>
					/// Returns 150
					/// </summary>
					public const System.Int32 ColumnIndex = 150;

				}

			}
		}

		/// <summary>
		/// This class allows to easily retrieve the name or index of all the fields
		/// of the resulset #2 existing in the Dataset or the SqlDatReader returned by
		/// the Execute method of the 'spS_TransactionDetails_Full' class.
		/// </summary>
		public class Resultset2 {


			/// <summary>
			/// This collection provides the fields collection for this resultset.
			/// </summary>
			public class Fields {

				/// <summary>
				/// Allows to get the Index and Name of the field XML_F52E2B61-18A1-11d1-B105-00805F49916B via shared members
				/// </summary>
				public class Column_XML_F52E2B6118A111d1B10500805F49916B {

					/// <summary>
					/// Returns "XML_F52E2B61-18A1-11d1-B105-00805F49916B"
					/// </summary>
					public const System.String ColumnName = "XML_F52E2B61-18A1-11d1-B105-00805F49916B";
					/// <summary>
					/// Returns 0
					/// </summary>
					public const System.Int32 ColumnIndex = 0;

				}

			}
		}

	}

}

