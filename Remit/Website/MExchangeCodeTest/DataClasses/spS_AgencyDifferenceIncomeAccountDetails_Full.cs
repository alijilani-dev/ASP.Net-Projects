/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:46:50 PM
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
	/// stored procedure 'spS_AgencyDifferenceIncomeAccountDetails_Full'. It allows also to specify specific connection
	/// information such as the ConnectionString to be use, the command time-out and so forth.
	/// </summary>
	[Serializable()]
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:46:50", SqlObjectDependancyName="spS_AgencyDifferenceIncomeAccountDetails_Full", SqlObjectDependancyRevision=0)]
#endif
	public class spS_AgencyDifferenceIncomeAccountDetails_Full : MarshalByRefObject, IDisposable, IParameter {

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
		/// Initializes a new instance of the spS_AgencyDifferenceIncomeAccountDetails_Full class. If you use this constructor version,
		/// not assigning parameter values implies using the parameter default values.
		/// </summary>
		public spS_AgencyDifferenceIncomeAccountDetails_Full() : this(true) {

		}

		/// <summary>
		/// Initializes a new instance of the spS_AgencyDifferenceIncomeAccountDetails_Full class.
		/// </summary>
		/// <param name="useDefaultValue">If True, this parameter indicates that "not assigning parameter values" implies "using the parameter default values". If False, this parameter indicates that "not assigning parameter values" implies "using the SQL Server Null value".</param>
		public spS_AgencyDifferenceIncomeAccountDetails_Full(bool useDefaultValue) {

			this.useDefaultValue = useDefaultValue;

			this.internal_Param_Id_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_TransactionId_UseDefaultValue = this.useDefaultValue;
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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spS_AgencyDifferenceIncomeAccountDetails_Full'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spS_AgencyDifferenceIncomeAccountDetails_Full", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spS_AgencyDifferenceIncomeAccountDetails_Full'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spS_AgencyDifferenceIncomeAccountDetails_Full", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spS_AgencyDifferenceIncomeAccountDetails_Full'";
				sqlCommand.Transaction = sqlTransaction;

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlTransaction.Connection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spS_AgencyDifferenceIncomeAccountDetails_Full", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				this.internal_Param_TransactionId = System.Data.SqlTypes.SqlGuid.Null;
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
		~spS_AgencyDifferenceIncomeAccountDetails_Full() {

			Dispose(false);
		}

		/// <summary>
		/// Returns the stored procedure name for which this class was built, i.e. 'spS_AgencyDifferenceIncomeAccountDetails_Full'.
		/// </summary>
		public string StoredProcedureName {

			get {

				return("spS_AgencyDifferenceIncomeAccountDetails_Full");
			}
		}

		private System.Data.SqlTypes.SqlInt32 internal_Param_RETURN_VALUE;

		private System.Data.SqlTypes.SqlGuid internal_Param_Id;
		internal bool internal_Param_Id_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_TransactionId;
		internal bool internal_Param_TransactionId_UseDefaultValue = true;

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

			this.internal_Param_TransactionId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_TransactionId_UseDefaultValue = this.useDefaultValue;

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
		/// Sets the value of the stored procedure INPUT parameter '@TransactionId'.
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
		/// the parameter default value, consider calling the Param_TransactionId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_TransactionId {

			get {

				if (this.internal_Param_TransactionId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_TransactionId);
			}

			set {

				this.internal_Param_TransactionId_UseDefaultValue = false;
				this.internal_Param_TransactionId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@TransactionId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_TransactionId_UseDefaultValue() {

			this.internal_Param_TransactionId_UseDefaultValue = true;
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
	/// This class allows you to execute the 'spS_AgencyDifferenceIncomeAccountDetails_Full' stored procedure;
	/// it gives you the ability to:
	/// <list type="bullet">
	/// <item><description>Set all the necessary parameters to execute the stored procedure</description></item>
	/// <item><description>To execute the stored procedure</description></item>
	/// <item><description>To get back after the execution the return value and all the output parameters value</description></item>
	/// </list>
	/// </summary>
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:46:50", SqlObjectDependancyName="spS_AgencyDifferenceIncomeAccountDetails_Full", SqlObjectDependancyRevision=0)]
#endif
	public class spS_AgencyDifferenceIncomeAccountDetails_Full : MarshalByRefObject, IDisposable {


		private bool throwExceptionOnExecute = false;

		/// <summary>
		/// Initializes a new instance of the spS_AgencyDifferenceIncomeAccountDetails_Full class.
		/// By default, no exception will be thrown when you call the Execute method. Instead, a Boolean return status will be returned.
		/// </summary>
		public spS_AgencyDifferenceIncomeAccountDetails_Full() : this(false) {

		}

		/// <summary>
		/// Initializes a new instance of the spS_AgencyDifferenceIncomeAccountDetails_Full class.
		/// </summary>
		/// <param name="throwExceptionOnExecute">True if an exception has to be thrown if the Execute call fails.</param>
		public spS_AgencyDifferenceIncomeAccountDetails_Full(bool throwExceptionOnExecute) {

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
		~spS_AgencyDifferenceIncomeAccountDetails_Full() {

			Dispose(false);
		}

		private void ResetParameter(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full parameters) {

			parameters.internal_Set_RETURN_VALUE (System.Data.SqlTypes.SqlInt32.Null);
		}

		private bool InitializeConnection(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full parameters, out System.Data.SqlClient.SqlCommand sqlCommand, ref bool connectionMustBeClosed) {

			try {

				this.sqlConnection = null;
				sqlCommand = null;
				connectionMustBeClosed = true;

				if (parameters.ConnectionType == ConnectionType.None) {

					throw new InvalidOperationException("No connection information was supplied. Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full object before doing this call.");
				}

				if (parameters.ConnectionType == ConnectionType.SqlConnection && parameters.SqlConnection == null) {

					throw new InvalidOperationException("No connection information was supplied (SqlConnection == null). Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full object before doing this call.");
				}

				if (parameters.ConnectionType == ConnectionType.SqlTransaction && parameters.SqlTransaction== null) {

					throw new InvalidOperationException("No connection information was supplied (SqlTransaction == null). Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full object before doing this call.");
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

							throw new System.InvalidOperationException("No connection information was supplied (ConnectionString == \"\")! (Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full)");
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
				sqlCommand.CommandText = "spS_AgencyDifferenceIncomeAccountDetails_Full";

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

		private bool DeclareParameters(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full parameters, ref System.Data.SqlClient.SqlCommand sqlCommand) {

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

				sqlParameter = new System.Data.SqlClient.SqlParameter("@TransactionId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "TransactionId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_TransactionId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_TransactionId.IsNull) {

					sqlParameter.Value = parameters.Param_TransactionId;
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

		private bool RetrieveParameters(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full parameters, ref System.Data.SqlClient.SqlCommand sqlCommand) {

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
		/// This method allows you to execute the [spS_AgencyDifferenceIncomeAccountDetails_Full] stored procedure and retrieve back the data
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
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full parameters, out System.Data.SqlClient.SqlDataReader sqlDataReader) {

			return(Execute(ref parameters, out sqlDataReader, System.Data.CommandBehavior.Default));
		}

		/// <summary>
		/// This method allows you to execute the [spS_AgencyDifferenceIncomeAccountDetails_Full] stored procedure and retrieve back the data
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
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full parameters, out System.Data.SqlClient.SqlDataReader sqlDataReader, System.Data.CommandBehavior commandBehavior) {

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
		/// This method allows you to execute the [spS_AgencyDifferenceIncomeAccountDetails_Full] stored procedure and retrieve back the data
		/// populated in a DataSet (System.Data.DataSet).
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <param name="dataset">
		/// Will be populated with the data after execution. The table based name used will be: 'spS_AgencyDifferenceIncomeAccountDetails_Full'.
		/// </param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full parameters, ref System.Data.DataSet dataset) {

			return(Execute(ref parameters, ref dataset, "spS_AgencyDifferenceIncomeAccountDetails_Full", -1, -1));
		}

		/// <summary>
		/// This method allows you to execute the [spS_AgencyDifferenceIncomeAccountDetails_Full] stored procedure and retrieve back the data
		/// populated in a DataSet (System.Data.DataSet).
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <param name="dataset">
		/// Will be populated with the data after execution. The table based name used will be: 'spS_AgencyDifferenceIncomeAccountDetails_Full'.
		/// </param>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full parameters, ref System.Data.DataSet dataset, int startRecord, int maxRecords) {

			return(Execute(ref parameters, ref dataset, "spS_AgencyDifferenceIncomeAccountDetails_Full", startRecord, maxRecords));
		}

		/// <summary>
		/// This method allows you to execute the [spS_AgencyDifferenceIncomeAccountDetails_Full] stored procedure and retrieve back the data
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
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full parameters, ref System.Data.DataSet dataset, string tableName) {

			return(Execute(ref parameters, ref dataset, tableName, -1, -1));
		}

		/// <summary>
		/// This method allows you to execute the [spS_AgencyDifferenceIncomeAccountDetails_Full] stored procedure and retrieve back the data
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
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full parameters, ref System.Data.DataSet dataset, string tableName, int startRecord, int maxRecords) {

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
				dataset.Tables[tableName].Columns["CreditDateTime"].Caption = "CreditDateTime (update this label in the \"Olymars/ColumnLabel\" extended property of the \"CreditDateTime\" column)";
				dataset.Tables[tableName].Columns["DebitDateTime"].Caption = "DebitDateTime (update this label in the \"Olymars/ColumnLabel\" extended property of the \"DebitDateTime\" column)";
				dataset.Tables[tableName].Columns["TransactionId"].Caption = "TransactionId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"TransactionId\" column)";
				dataset.Tables[tableName].Columns["CreditLC"].Caption = "CreditLC (update this label in the \"Olymars/ColumnLabel\" extended property of the \"CreditLC\" column)";
				dataset.Tables[tableName].Columns["CreditUSD"].Caption = "CreditUSD (update this label in the \"Olymars/ColumnLabel\" extended property of the \"CreditUSD\" column)";
				dataset.Tables[tableName].Columns["DebitLC"].Caption = "DebitLC (update this label in the \"Olymars/ColumnLabel\" extended property of the \"DebitLC\" column)";
				dataset.Tables[tableName].Columns["DebitUSD"].Caption = "DebitUSD (update this label in the \"Olymars/ColumnLabel\" extended property of the \"DebitUSD\" column)";
				dataset.Tables[tableName].Columns["TransactionId_Id"].Caption = "Id (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Id\" column)";
				dataset.Tables[tableName].Columns["TransactionId_VoucherNumber"].Caption = "VoucherNumber (update this label in the \"Olymars/ColumnLabel\" extended property of the \"VoucherNumber\" column)";
				dataset.Tables[tableName].Columns["TransactionId_TransactionNumber"].Caption = "TransactionNumber (update this label in the \"Olymars/ColumnLabel\" extended property of the \"TransactionNumber\" column)";
				dataset.Tables[tableName].Columns["TransactionId_CustomerId"].Caption = "CustomerId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"CustomerId\" column)";
				dataset.Tables[tableName].Columns["TransactionId_BeneficeryId"].Caption = "BeneficeryId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"BeneficeryId\" column)";
				dataset.Tables[tableName].Columns["TransactionId_BeneficeryBankId"].Caption = "BeneficeryBankId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"BeneficeryBankId\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PaymentMode"].Caption = "PaymentMode (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PaymentMode\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PurposeOfTransfer"].Caption = "PurposeOfTransfer (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PurposeOfTransfer\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PayInCurrencyId"].Caption = "PayInCurrencyId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayInCurrencyId\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PayInAmount"].Caption = "PayInAmount (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayInAmount\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PayOutCurrencyId"].Caption = "PayOutCurrencyId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayOutCurrencyId\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PayOutAmount"].Caption = "PayOutAmount (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayOutAmount\" column)";
				dataset.Tables[tableName].Columns["TransactionId_Commission"].Caption = "Commission (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Commission\" column)";
				dataset.Tables[tableName].Columns["TransactionId_Question"].Caption = "Question (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Question\" column)";
				dataset.Tables[tableName].Columns["TransactionId_Answer"].Caption = "Answer (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Answer\" column)";
				dataset.Tables[tableName].Columns["TransactionId_MessageToBeneficery"].Caption = "MessageToBeneficery (update this label in the \"Olymars/ColumnLabel\" extended property of the \"MessageToBeneficery\" column)";
				dataset.Tables[tableName].Columns["TransactionId_MessageToPayOutAgent"].Caption = "MessageToPayOutAgent (update this label in the \"Olymars/ColumnLabel\" extended property of the \"MessageToPayOutAgent\" column)";
				dataset.Tables[tableName].Columns["TransactionId_BankExchangeRateForPayInCurrency"].Caption = "BankExchangeRateForPayInCurrency (update this label in the \"Olymars/ColumnLabel\" extended property of the \"BankExchangeRateForPayInCurrency\" column)";
				dataset.Tables[tableName].Columns["TransactionId_BankExchangeRateForPayOutCurrency"].Caption = "BankExchangeRateForPayOutCurrency (update this label in the \"Olymars/ColumnLabel\" extended property of the \"BankExchangeRateForPayOutCurrency\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PayInCurrencyGroup"].Caption = "PayInCurrencyGroup (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayInCurrencyGroup\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PayOutCurrencyGroup"].Caption = "PayOutCurrencyGroup (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayOutCurrencyGroup\" column)";
				dataset.Tables[tableName].Columns["TransactionId_FinalBankExchangeRate"].Caption = "FinalBankExchangeRate (update this label in the \"Olymars/ColumnLabel\" extended property of the \"FinalBankExchangeRate\" column)";
				dataset.Tables[tableName].Columns["TransactionId_AgencyMarginPercent"].Caption = "AgencyMarginPercent (update this label in the \"Olymars/ColumnLabel\" extended property of the \"AgencyMarginPercent\" column)";
				dataset.Tables[tableName].Columns["TransactionId_AgencyExchangeRate"].Caption = "AgencyExchangeRate (update this label in the \"Olymars/ColumnLabel\" extended property of the \"AgencyExchangeRate\" column)";
				dataset.Tables[tableName].Columns["TransactionId_AgentMarginPercent"].Caption = "AgentMarginPercent (update this label in the \"Olymars/ColumnLabel\" extended property of the \"AgentMarginPercent\" column)";
				dataset.Tables[tableName].Columns["TransactionId_AgentExchangeRate"].Caption = "AgentExchangeRate (update this label in the \"Olymars/ColumnLabel\" extended property of the \"AgentExchangeRate\" column)";
				dataset.Tables[tableName].Columns["TransactionId_AssociatedBankId"].Caption = "AssociatedBankId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"AssociatedBankId\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PayOutLocationId"].Caption = "PayOutLocationId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayOutLocationId\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PayInAgentUserId"].Caption = "PayInAgentUserId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayInAgentUserId\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PayInAgentLocationId"].Caption = "PayInAgentLocationId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayInAgentLocationId\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PayInDateTime"].Caption = "PayInDateTime (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayInDateTime\" column)";
				dataset.Tables[tableName].Columns["TransactionId_RecommendedPayOutAgentId"].Caption = "RecommendedPayOutAgentId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"RecommendedPayOutAgentId\" column)";
				dataset.Tables[tableName].Columns["TransactionId_ActualPayOutAgentId"].Caption = "ActualPayOutAgentId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"ActualPayOutAgentId\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PayOutAgentUserId"].Caption = "PayOutAgentUserId (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayOutAgentUserId\" column)";
				dataset.Tables[tableName].Columns["TransactionId_PayOutDateTime"].Caption = "PayOutDateTime (update this label in the \"Olymars/ColumnLabel\" extended property of the \"PayOutDateTime\" column)";
				dataset.Tables[tableName].Columns["TransactionId_CollectedBeneficeryIdDetails"].Caption = "CollectedBeneficeryIdDetails (update this label in the \"Olymars/ColumnLabel\" extended property of the \"CollectedBeneficeryIdDetails\" column)";
				dataset.Tables[tableName].Columns["TransactionId_IsOpenTransaction"].Caption = "IsOpenTransaction (update this label in the \"Olymars/ColumnLabel\" extended property of the \"IsOpenTransaction\" column)";
				dataset.Tables[tableName].Columns["TransactionId_Status"].Caption = "Status (update this label in the \"Olymars/ColumnLabel\" extended property of the \"Status\" column)";
				dataset.Tables[tableName].Columns["TransactionId_SettlementStatus"].Caption = "SettlementStatus (update this label in the \"Olymars/ColumnLabel\" extended property of the \"SettlementStatus\" column)";

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
		/// This method allows you to execute the [spS_AgencyDifferenceIncomeAccountDetails_Full] stored procedure and retrieve back the data
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
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full parameters, ref string xml) {

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
		/// This method allows you to execute the [spS_AgencyDifferenceIncomeAccountDetails_Full] stored procedure and retrieve back the data
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
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spS_AgencyDifferenceIncomeAccountDetails_Full parameters, out System.Xml.XmlReader xmlReader) {

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
		/// the Execute method of the 'spS_AgencyDifferenceIncomeAccountDetails_Full' class.
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
				/// Allows to get the Index and Name of the field CreditDateTime via shared members
				/// </summary>
				public class Column_CreditDateTime {

					/// <summary>
					/// Returns "CreditDateTime"
					/// </summary>
					public const System.String ColumnName = "CreditDateTime";
					/// <summary>
					/// Returns 1
					/// </summary>
					public const System.Int32 ColumnIndex = 1;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field DebitDateTime via shared members
				/// </summary>
				public class Column_DebitDateTime {

					/// <summary>
					/// Returns "DebitDateTime"
					/// </summary>
					public const System.String ColumnName = "DebitDateTime";
					/// <summary>
					/// Returns 2
					/// </summary>
					public const System.Int32 ColumnIndex = 2;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId via shared members
				/// </summary>
				public class Column_TransactionId {

					/// <summary>
					/// Returns "TransactionId"
					/// </summary>
					public const System.String ColumnName = "TransactionId";
					/// <summary>
					/// Returns 3
					/// </summary>
					public const System.Int32 ColumnIndex = 3;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CreditLC via shared members
				/// </summary>
				public class Column_CreditLC {

					/// <summary>
					/// Returns "CreditLC"
					/// </summary>
					public const System.String ColumnName = "CreditLC";
					/// <summary>
					/// Returns 4
					/// </summary>
					public const System.Int32 ColumnIndex = 4;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field CreditUSD via shared members
				/// </summary>
				public class Column_CreditUSD {

					/// <summary>
					/// Returns "CreditUSD"
					/// </summary>
					public const System.String ColumnName = "CreditUSD";
					/// <summary>
					/// Returns 5
					/// </summary>
					public const System.Int32 ColumnIndex = 5;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field DebitLC via shared members
				/// </summary>
				public class Column_DebitLC {

					/// <summary>
					/// Returns "DebitLC"
					/// </summary>
					public const System.String ColumnName = "DebitLC";
					/// <summary>
					/// Returns 6
					/// </summary>
					public const System.Int32 ColumnIndex = 6;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field DebitUSD via shared members
				/// </summary>
				public class Column_DebitUSD {

					/// <summary>
					/// Returns "DebitUSD"
					/// </summary>
					public const System.String ColumnName = "DebitUSD";
					/// <summary>
					/// Returns 7
					/// </summary>
					public const System.Int32 ColumnIndex = 7;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_Id via shared members
				/// </summary>
				public class Column_TransactionId_Id {

					/// <summary>
					/// Returns "TransactionId_Id"
					/// </summary>
					public const System.String ColumnName = "TransactionId_Id";
					/// <summary>
					/// Returns 8
					/// </summary>
					public const System.Int32 ColumnIndex = 8;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_VoucherNumber via shared members
				/// </summary>
				public class Column_TransactionId_VoucherNumber {

					/// <summary>
					/// Returns "TransactionId_VoucherNumber"
					/// </summary>
					public const System.String ColumnName = "TransactionId_VoucherNumber";
					/// <summary>
					/// Returns 9
					/// </summary>
					public const System.Int32 ColumnIndex = 9;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_TransactionNumber via shared members
				/// </summary>
				public class Column_TransactionId_TransactionNumber {

					/// <summary>
					/// Returns "TransactionId_TransactionNumber"
					/// </summary>
					public const System.String ColumnName = "TransactionId_TransactionNumber";
					/// <summary>
					/// Returns 10
					/// </summary>
					public const System.Int32 ColumnIndex = 10;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_CustomerId via shared members
				/// </summary>
				public class Column_TransactionId_CustomerId {

					/// <summary>
					/// Returns "TransactionId_CustomerId"
					/// </summary>
					public const System.String ColumnName = "TransactionId_CustomerId";
					/// <summary>
					/// Returns 11
					/// </summary>
					public const System.Int32 ColumnIndex = 11;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_BeneficeryId via shared members
				/// </summary>
				public class Column_TransactionId_BeneficeryId {

					/// <summary>
					/// Returns "TransactionId_BeneficeryId"
					/// </summary>
					public const System.String ColumnName = "TransactionId_BeneficeryId";
					/// <summary>
					/// Returns 12
					/// </summary>
					public const System.Int32 ColumnIndex = 12;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_BeneficeryBankId via shared members
				/// </summary>
				public class Column_TransactionId_BeneficeryBankId {

					/// <summary>
					/// Returns "TransactionId_BeneficeryBankId"
					/// </summary>
					public const System.String ColumnName = "TransactionId_BeneficeryBankId";
					/// <summary>
					/// Returns 13
					/// </summary>
					public const System.Int32 ColumnIndex = 13;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PaymentMode via shared members
				/// </summary>
				public class Column_TransactionId_PaymentMode {

					/// <summary>
					/// Returns "TransactionId_PaymentMode"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PaymentMode";
					/// <summary>
					/// Returns 14
					/// </summary>
					public const System.Int32 ColumnIndex = 14;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PurposeOfTransfer via shared members
				/// </summary>
				public class Column_TransactionId_PurposeOfTransfer {

					/// <summary>
					/// Returns "TransactionId_PurposeOfTransfer"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PurposeOfTransfer";
					/// <summary>
					/// Returns 15
					/// </summary>
					public const System.Int32 ColumnIndex = 15;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PayInCurrencyId via shared members
				/// </summary>
				public class Column_TransactionId_PayInCurrencyId {

					/// <summary>
					/// Returns "TransactionId_PayInCurrencyId"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PayInCurrencyId";
					/// <summary>
					/// Returns 16
					/// </summary>
					public const System.Int32 ColumnIndex = 16;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PayInAmount via shared members
				/// </summary>
				public class Column_TransactionId_PayInAmount {

					/// <summary>
					/// Returns "TransactionId_PayInAmount"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PayInAmount";
					/// <summary>
					/// Returns 17
					/// </summary>
					public const System.Int32 ColumnIndex = 17;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PayOutCurrencyId via shared members
				/// </summary>
				public class Column_TransactionId_PayOutCurrencyId {

					/// <summary>
					/// Returns "TransactionId_PayOutCurrencyId"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PayOutCurrencyId";
					/// <summary>
					/// Returns 18
					/// </summary>
					public const System.Int32 ColumnIndex = 18;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PayOutAmount via shared members
				/// </summary>
				public class Column_TransactionId_PayOutAmount {

					/// <summary>
					/// Returns "TransactionId_PayOutAmount"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PayOutAmount";
					/// <summary>
					/// Returns 19
					/// </summary>
					public const System.Int32 ColumnIndex = 19;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_Commission via shared members
				/// </summary>
				public class Column_TransactionId_Commission {

					/// <summary>
					/// Returns "TransactionId_Commission"
					/// </summary>
					public const System.String ColumnName = "TransactionId_Commission";
					/// <summary>
					/// Returns 20
					/// </summary>
					public const System.Int32 ColumnIndex = 20;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_Question via shared members
				/// </summary>
				public class Column_TransactionId_Question {

					/// <summary>
					/// Returns "TransactionId_Question"
					/// </summary>
					public const System.String ColumnName = "TransactionId_Question";
					/// <summary>
					/// Returns 21
					/// </summary>
					public const System.Int32 ColumnIndex = 21;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_Answer via shared members
				/// </summary>
				public class Column_TransactionId_Answer {

					/// <summary>
					/// Returns "TransactionId_Answer"
					/// </summary>
					public const System.String ColumnName = "TransactionId_Answer";
					/// <summary>
					/// Returns 22
					/// </summary>
					public const System.Int32 ColumnIndex = 22;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_MessageToBeneficery via shared members
				/// </summary>
				public class Column_TransactionId_MessageToBeneficery {

					/// <summary>
					/// Returns "TransactionId_MessageToBeneficery"
					/// </summary>
					public const System.String ColumnName = "TransactionId_MessageToBeneficery";
					/// <summary>
					/// Returns 23
					/// </summary>
					public const System.Int32 ColumnIndex = 23;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_MessageToPayOutAgent via shared members
				/// </summary>
				public class Column_TransactionId_MessageToPayOutAgent {

					/// <summary>
					/// Returns "TransactionId_MessageToPayOutAgent"
					/// </summary>
					public const System.String ColumnName = "TransactionId_MessageToPayOutAgent";
					/// <summary>
					/// Returns 24
					/// </summary>
					public const System.Int32 ColumnIndex = 24;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_BankExchangeRateForPayInCurrency via shared members
				/// </summary>
				public class Column_TransactionId_BankExchangeRateForPayInCurrency {

					/// <summary>
					/// Returns "TransactionId_BankExchangeRateForPayInCurrency"
					/// </summary>
					public const System.String ColumnName = "TransactionId_BankExchangeRateForPayInCurrency";
					/// <summary>
					/// Returns 25
					/// </summary>
					public const System.Int32 ColumnIndex = 25;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_BankExchangeRateForPayOutCurrency via shared members
				/// </summary>
				public class Column_TransactionId_BankExchangeRateForPayOutCurrency {

					/// <summary>
					/// Returns "TransactionId_BankExchangeRateForPayOutCurrency"
					/// </summary>
					public const System.String ColumnName = "TransactionId_BankExchangeRateForPayOutCurrency";
					/// <summary>
					/// Returns 26
					/// </summary>
					public const System.Int32 ColumnIndex = 26;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PayInCurrencyGroup via shared members
				/// </summary>
				public class Column_TransactionId_PayInCurrencyGroup {

					/// <summary>
					/// Returns "TransactionId_PayInCurrencyGroup"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PayInCurrencyGroup";
					/// <summary>
					/// Returns 27
					/// </summary>
					public const System.Int32 ColumnIndex = 27;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PayOutCurrencyGroup via shared members
				/// </summary>
				public class Column_TransactionId_PayOutCurrencyGroup {

					/// <summary>
					/// Returns "TransactionId_PayOutCurrencyGroup"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PayOutCurrencyGroup";
					/// <summary>
					/// Returns 28
					/// </summary>
					public const System.Int32 ColumnIndex = 28;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_FinalBankExchangeRate via shared members
				/// </summary>
				public class Column_TransactionId_FinalBankExchangeRate {

					/// <summary>
					/// Returns "TransactionId_FinalBankExchangeRate"
					/// </summary>
					public const System.String ColumnName = "TransactionId_FinalBankExchangeRate";
					/// <summary>
					/// Returns 29
					/// </summary>
					public const System.Int32 ColumnIndex = 29;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_AgencyMarginPercent via shared members
				/// </summary>
				public class Column_TransactionId_AgencyMarginPercent {

					/// <summary>
					/// Returns "TransactionId_AgencyMarginPercent"
					/// </summary>
					public const System.String ColumnName = "TransactionId_AgencyMarginPercent";
					/// <summary>
					/// Returns 30
					/// </summary>
					public const System.Int32 ColumnIndex = 30;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_AgencyExchangeRate via shared members
				/// </summary>
				public class Column_TransactionId_AgencyExchangeRate {

					/// <summary>
					/// Returns "TransactionId_AgencyExchangeRate"
					/// </summary>
					public const System.String ColumnName = "TransactionId_AgencyExchangeRate";
					/// <summary>
					/// Returns 31
					/// </summary>
					public const System.Int32 ColumnIndex = 31;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_AgentMarginPercent via shared members
				/// </summary>
				public class Column_TransactionId_AgentMarginPercent {

					/// <summary>
					/// Returns "TransactionId_AgentMarginPercent"
					/// </summary>
					public const System.String ColumnName = "TransactionId_AgentMarginPercent";
					/// <summary>
					/// Returns 32
					/// </summary>
					public const System.Int32 ColumnIndex = 32;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_AgentExchangeRate via shared members
				/// </summary>
				public class Column_TransactionId_AgentExchangeRate {

					/// <summary>
					/// Returns "TransactionId_AgentExchangeRate"
					/// </summary>
					public const System.String ColumnName = "TransactionId_AgentExchangeRate";
					/// <summary>
					/// Returns 33
					/// </summary>
					public const System.Int32 ColumnIndex = 33;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_AssociatedBankId via shared members
				/// </summary>
				public class Column_TransactionId_AssociatedBankId {

					/// <summary>
					/// Returns "TransactionId_AssociatedBankId"
					/// </summary>
					public const System.String ColumnName = "TransactionId_AssociatedBankId";
					/// <summary>
					/// Returns 34
					/// </summary>
					public const System.Int32 ColumnIndex = 34;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PayOutLocationId via shared members
				/// </summary>
				public class Column_TransactionId_PayOutLocationId {

					/// <summary>
					/// Returns "TransactionId_PayOutLocationId"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PayOutLocationId";
					/// <summary>
					/// Returns 35
					/// </summary>
					public const System.Int32 ColumnIndex = 35;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PayInAgentUserId via shared members
				/// </summary>
				public class Column_TransactionId_PayInAgentUserId {

					/// <summary>
					/// Returns "TransactionId_PayInAgentUserId"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PayInAgentUserId";
					/// <summary>
					/// Returns 36
					/// </summary>
					public const System.Int32 ColumnIndex = 36;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PayInAgentLocationId via shared members
				/// </summary>
				public class Column_TransactionId_PayInAgentLocationId {

					/// <summary>
					/// Returns "TransactionId_PayInAgentLocationId"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PayInAgentLocationId";
					/// <summary>
					/// Returns 37
					/// </summary>
					public const System.Int32 ColumnIndex = 37;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PayInDateTime via shared members
				/// </summary>
				public class Column_TransactionId_PayInDateTime {

					/// <summary>
					/// Returns "TransactionId_PayInDateTime"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PayInDateTime";
					/// <summary>
					/// Returns 38
					/// </summary>
					public const System.Int32 ColumnIndex = 38;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_RecommendedPayOutAgentId via shared members
				/// </summary>
				public class Column_TransactionId_RecommendedPayOutAgentId {

					/// <summary>
					/// Returns "TransactionId_RecommendedPayOutAgentId"
					/// </summary>
					public const System.String ColumnName = "TransactionId_RecommendedPayOutAgentId";
					/// <summary>
					/// Returns 39
					/// </summary>
					public const System.Int32 ColumnIndex = 39;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_ActualPayOutAgentId via shared members
				/// </summary>
				public class Column_TransactionId_ActualPayOutAgentId {

					/// <summary>
					/// Returns "TransactionId_ActualPayOutAgentId"
					/// </summary>
					public const System.String ColumnName = "TransactionId_ActualPayOutAgentId";
					/// <summary>
					/// Returns 40
					/// </summary>
					public const System.Int32 ColumnIndex = 40;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PayOutAgentUserId via shared members
				/// </summary>
				public class Column_TransactionId_PayOutAgentUserId {

					/// <summary>
					/// Returns "TransactionId_PayOutAgentUserId"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PayOutAgentUserId";
					/// <summary>
					/// Returns 41
					/// </summary>
					public const System.Int32 ColumnIndex = 41;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_PayOutDateTime via shared members
				/// </summary>
				public class Column_TransactionId_PayOutDateTime {

					/// <summary>
					/// Returns "TransactionId_PayOutDateTime"
					/// </summary>
					public const System.String ColumnName = "TransactionId_PayOutDateTime";
					/// <summary>
					/// Returns 42
					/// </summary>
					public const System.Int32 ColumnIndex = 42;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_CollectedBeneficeryIdDetails via shared members
				/// </summary>
				public class Column_TransactionId_CollectedBeneficeryIdDetails {

					/// <summary>
					/// Returns "TransactionId_CollectedBeneficeryIdDetails"
					/// </summary>
					public const System.String ColumnName = "TransactionId_CollectedBeneficeryIdDetails";
					/// <summary>
					/// Returns 43
					/// </summary>
					public const System.Int32 ColumnIndex = 43;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_IsOpenTransaction via shared members
				/// </summary>
				public class Column_TransactionId_IsOpenTransaction {

					/// <summary>
					/// Returns "TransactionId_IsOpenTransaction"
					/// </summary>
					public const System.String ColumnName = "TransactionId_IsOpenTransaction";
					/// <summary>
					/// Returns 44
					/// </summary>
					public const System.Int32 ColumnIndex = 44;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_Status via shared members
				/// </summary>
				public class Column_TransactionId_Status {

					/// <summary>
					/// Returns "TransactionId_Status"
					/// </summary>
					public const System.String ColumnName = "TransactionId_Status";
					/// <summary>
					/// Returns 45
					/// </summary>
					public const System.Int32 ColumnIndex = 45;

				}

				/// <summary>
				/// Allows to get the Index and Name of the field TransactionId_SettlementStatus via shared members
				/// </summary>
				public class Column_TransactionId_SettlementStatus {

					/// <summary>
					/// Returns "TransactionId_SettlementStatus"
					/// </summary>
					public const System.String ColumnName = "TransactionId_SettlementStatus";
					/// <summary>
					/// Returns 46
					/// </summary>
					public const System.Int32 ColumnIndex = 46;

				}

			}
		}

		/// <summary>
		/// This class allows to easily retrieve the name or index of all the fields
		/// of the resulset #2 existing in the Dataset or the SqlDatReader returned by
		/// the Execute method of the 'spS_AgencyDifferenceIncomeAccountDetails_Full' class.
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

