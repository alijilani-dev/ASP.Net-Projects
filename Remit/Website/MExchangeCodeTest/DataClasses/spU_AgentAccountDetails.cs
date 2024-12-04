/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:47:06 PM
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
	/// stored procedure 'spU_AgentAccountDetails'. It allows also to specify specific connection
	/// information such as the ConnectionString to be use, the command time-out and so forth.
	/// </summary>
	[Serializable()]
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:06", SqlObjectDependancyName="spU_AgentAccountDetails", SqlObjectDependancyRevision=0)]
#endif
	public class spU_AgentAccountDetails : MarshalByRefObject, IDisposable, IParameter {

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
		/// Initializes a new instance of the spU_AgentAccountDetails class. If you use this constructor version,
		/// not assigning parameter values implies using the parameter default values.
		/// </summary>
		public spU_AgentAccountDetails() : this(true) {

		}

		/// <summary>
		/// Initializes a new instance of the spU_AgentAccountDetails class.
		/// </summary>
		/// <param name="useDefaultValue">If True, this parameter indicates that "not assigning parameter values" implies "using the parameter default values". If False, this parameter indicates that "not assigning parameter values" implies "using the SQL Server Null value".</param>
		public spU_AgentAccountDetails(bool useDefaultValue) {

			this.useDefaultValue = useDefaultValue;

			this.internal_Param_Id_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_CreditDateTime_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_CreditDateTime_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_DebitDateTime_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_DebitDateTime_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_AgentAccountId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_AgentAccountId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_TransactionId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_TransactionId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_CreditLC_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_CreditLC_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_CreditUSD_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_CreditUSD_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_DebitLC_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_DebitLC_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_DebitUSD_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_DebitUSD_UseDefaultValue = this.useDefaultValue;
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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spU_AgentAccountDetails'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spU_AgentAccountDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spU_AgentAccountDetails'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spU_AgentAccountDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spU_AgentAccountDetails'";
				sqlCommand.Transaction = sqlTransaction;

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlTransaction.Connection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spU_AgentAccountDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				this.internal_Param_CreditDateTime = System.Data.SqlTypes.SqlDateTime.Null;
				this.internal_Param_ConsiderNull_CreditDateTime = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_DebitDateTime = System.Data.SqlTypes.SqlDateTime.Null;
				this.internal_Param_ConsiderNull_DebitDateTime = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_AgentAccountId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_AgentAccountId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_TransactionId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_TransactionId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_CreditLC = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_CreditLC = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_CreditUSD = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_CreditUSD = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_DebitLC = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_DebitLC = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_DebitUSD = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_ConsiderNull_DebitUSD = System.Data.SqlTypes.SqlBoolean.Null;

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
		~spU_AgentAccountDetails() {

			Dispose(false);
		}

		/// <summary>
		/// Returns the stored procedure name for which this class was built, i.e. 'spU_AgentAccountDetails'.
		/// </summary>
		public string StoredProcedureName {

			get {

				return("spU_AgentAccountDetails");
			}
		}

		private System.Data.SqlTypes.SqlInt32 internal_Param_RETURN_VALUE;

		private System.Data.SqlTypes.SqlGuid internal_Param_Id;
		internal bool internal_Param_Id_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDateTime internal_Param_CreditDateTime;
		internal bool internal_Param_CreditDateTime_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_CreditDateTime;
		internal bool internal_Param_ConsiderNull_CreditDateTime_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDateTime internal_Param_DebitDateTime;
		internal bool internal_Param_DebitDateTime_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_DebitDateTime;
		internal bool internal_Param_ConsiderNull_DebitDateTime_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_AgentAccountId;
		internal bool internal_Param_AgentAccountId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_AgentAccountId;
		internal bool internal_Param_ConsiderNull_AgentAccountId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_TransactionId;
		internal bool internal_Param_TransactionId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_TransactionId;
		internal bool internal_Param_ConsiderNull_TransactionId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_CreditLC;
		internal bool internal_Param_CreditLC_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_CreditLC;
		internal bool internal_Param_ConsiderNull_CreditLC_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_CreditUSD;
		internal bool internal_Param_CreditUSD_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_CreditUSD;
		internal bool internal_Param_ConsiderNull_CreditUSD_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_DebitLC;
		internal bool internal_Param_DebitLC_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_DebitLC;
		internal bool internal_Param_ConsiderNull_DebitLC_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_DebitUSD;
		internal bool internal_Param_DebitUSD_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_DebitUSD;
		internal bool internal_Param_ConsiderNull_DebitUSD_UseDefaultValue = true;


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

			this.internal_Param_CreditDateTime = System.Data.SqlTypes.SqlDateTime.Null;
			this.internal_Param_CreditDateTime_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_CreditDateTime = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_CreditDateTime_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_DebitDateTime = System.Data.SqlTypes.SqlDateTime.Null;
			this.internal_Param_DebitDateTime_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_DebitDateTime = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_DebitDateTime_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_AgentAccountId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_AgentAccountId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_AgentAccountId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_AgentAccountId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_TransactionId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_TransactionId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_TransactionId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_TransactionId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_CreditLC = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_CreditLC_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_CreditLC = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_CreditLC_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_CreditUSD = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_CreditUSD_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_CreditUSD = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_CreditUSD_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_DebitLC = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_DebitLC_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_DebitLC = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_DebitLC_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_DebitUSD = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_DebitUSD_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_DebitUSD = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_DebitUSD_UseDefaultValue = this.useDefaultValue;

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
		/// Sets the value of the stored procedure INPUT parameter '@CreditDateTime'.
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
		/// the parameter default value, consider calling the Param_CreditDateTime_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDateTime Param_CreditDateTime {

			get {

				if (this.internal_Param_CreditDateTime_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_CreditDateTime);
			}

			set {

				this.internal_Param_CreditDateTime_UseDefaultValue = false;
				this.internal_Param_CreditDateTime = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@CreditDateTime' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_CreditDateTime_UseDefaultValue() {

			this.internal_Param_CreditDateTime_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_CreditDateTime'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_CreditDateTime_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_CreditDateTime {

			get {

				if (this.internal_Param_ConsiderNull_CreditDateTime_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_CreditDateTime);
			}

			set {

				this.internal_Param_ConsiderNull_CreditDateTime_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_CreditDateTime = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_CreditDateTime' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_CreditDateTime_UseDefaultValue() {

			this.internal_Param_ConsiderNull_CreditDateTime_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@DebitDateTime'.
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
		/// the parameter default value, consider calling the Param_DebitDateTime_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDateTime Param_DebitDateTime {

			get {

				if (this.internal_Param_DebitDateTime_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_DebitDateTime);
			}

			set {

				this.internal_Param_DebitDateTime_UseDefaultValue = false;
				this.internal_Param_DebitDateTime = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@DebitDateTime' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_DebitDateTime_UseDefaultValue() {

			this.internal_Param_DebitDateTime_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_DebitDateTime'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_DebitDateTime_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_DebitDateTime {

			get {

				if (this.internal_Param_ConsiderNull_DebitDateTime_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_DebitDateTime);
			}

			set {

				this.internal_Param_ConsiderNull_DebitDateTime_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_DebitDateTime = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_DebitDateTime' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_DebitDateTime_UseDefaultValue() {

			this.internal_Param_ConsiderNull_DebitDateTime_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@AgentAccountId'.
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
		/// the parameter default value, consider calling the Param_AgentAccountId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_AgentAccountId {

			get {

				if (this.internal_Param_AgentAccountId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_AgentAccountId);
			}

			set {

				this.internal_Param_AgentAccountId_UseDefaultValue = false;
				this.internal_Param_AgentAccountId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@AgentAccountId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_AgentAccountId_UseDefaultValue() {

			this.internal_Param_AgentAccountId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_AgentAccountId'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_AgentAccountId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_AgentAccountId {

			get {

				if (this.internal_Param_ConsiderNull_AgentAccountId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_AgentAccountId);
			}

			set {

				this.internal_Param_ConsiderNull_AgentAccountId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_AgentAccountId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_AgentAccountId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_AgentAccountId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_AgentAccountId_UseDefaultValue = true;
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
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_TransactionId'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_TransactionId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_TransactionId {

			get {

				if (this.internal_Param_ConsiderNull_TransactionId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_TransactionId);
			}

			set {

				this.internal_Param_ConsiderNull_TransactionId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_TransactionId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_TransactionId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_TransactionId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_TransactionId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@CreditLC'.
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
		/// the parameter default value, consider calling the Param_CreditLC_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_CreditLC {

			get {

				if (this.internal_Param_CreditLC_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_CreditLC);
			}

			set {

				this.internal_Param_CreditLC_UseDefaultValue = false;
				this.internal_Param_CreditLC = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@CreditLC' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_CreditLC_UseDefaultValue() {

			this.internal_Param_CreditLC_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_CreditLC'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_CreditLC_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_CreditLC {

			get {

				if (this.internal_Param_ConsiderNull_CreditLC_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_CreditLC);
			}

			set {

				this.internal_Param_ConsiderNull_CreditLC_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_CreditLC = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_CreditLC' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_CreditLC_UseDefaultValue() {

			this.internal_Param_ConsiderNull_CreditLC_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@CreditUSD'.
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
		/// the parameter default value, consider calling the Param_CreditUSD_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_CreditUSD {

			get {

				if (this.internal_Param_CreditUSD_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_CreditUSD);
			}

			set {

				this.internal_Param_CreditUSD_UseDefaultValue = false;
				this.internal_Param_CreditUSD = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@CreditUSD' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_CreditUSD_UseDefaultValue() {

			this.internal_Param_CreditUSD_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_CreditUSD'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_CreditUSD_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_CreditUSD {

			get {

				if (this.internal_Param_ConsiderNull_CreditUSD_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_CreditUSD);
			}

			set {

				this.internal_Param_ConsiderNull_CreditUSD_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_CreditUSD = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_CreditUSD' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_CreditUSD_UseDefaultValue() {

			this.internal_Param_ConsiderNull_CreditUSD_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@DebitLC'.
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
		/// the parameter default value, consider calling the Param_DebitLC_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_DebitLC {

			get {

				if (this.internal_Param_DebitLC_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_DebitLC);
			}

			set {

				this.internal_Param_DebitLC_UseDefaultValue = false;
				this.internal_Param_DebitLC = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@DebitLC' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_DebitLC_UseDefaultValue() {

			this.internal_Param_DebitLC_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_DebitLC'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_DebitLC_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_DebitLC {

			get {

				if (this.internal_Param_ConsiderNull_DebitLC_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_DebitLC);
			}

			set {

				this.internal_Param_ConsiderNull_DebitLC_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_DebitLC = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_DebitLC' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_DebitLC_UseDefaultValue() {

			this.internal_Param_ConsiderNull_DebitLC_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@DebitUSD'.
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
		/// the parameter default value, consider calling the Param_DebitUSD_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_DebitUSD {

			get {

				if (this.internal_Param_DebitUSD_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_DebitUSD);
			}

			set {

				this.internal_Param_DebitUSD_UseDefaultValue = false;
				this.internal_Param_DebitUSD = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@DebitUSD' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_DebitUSD_UseDefaultValue() {

			this.internal_Param_DebitUSD_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_DebitUSD'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_DebitUSD_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_DebitUSD {

			get {

				if (this.internal_Param_ConsiderNull_DebitUSD_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_DebitUSD);
			}

			set {

				this.internal_Param_ConsiderNull_DebitUSD_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_DebitUSD = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_DebitUSD' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_DebitUSD_UseDefaultValue() {

			this.internal_Param_ConsiderNull_DebitUSD_UseDefaultValue = true;
		}

  	}
}

namespace Evernet.MoneyExchange.DataClasses.StoredProcedures {

	/// <summary>
	/// This class allows you to execute the 'spU_AgentAccountDetails' stored procedure;
	/// it gives you the ability to:
	/// <list type="bullet">
	/// <item><description>Set all the necessary parameters to execute the stored procedure</description></item>
	/// <item><description>To execute the stored procedure</description></item>
	/// <item><description>To get back after the execution the return value and all the output parameters value</description></item>
	/// </list>
	/// </summary>
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:06", SqlObjectDependancyName="spU_AgentAccountDetails", SqlObjectDependancyRevision=0)]
#endif
	public class spU_AgentAccountDetails : MarshalByRefObject, IDisposable {


		private bool throwExceptionOnExecute = false;

		/// <summary>
		/// Initializes a new instance of the spU_AgentAccountDetails class.
		/// By default, no exception will be thrown when you call the Execute method. Instead, a Boolean return status will be returned.
		/// </summary>
		public spU_AgentAccountDetails() : this(false) {

		}

		/// <summary>
		/// Initializes a new instance of the spU_AgentAccountDetails class.
		/// </summary>
		/// <param name="throwExceptionOnExecute">True if an exception has to be thrown if the Execute call fails.</param>
		public spU_AgentAccountDetails(bool throwExceptionOnExecute) {

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
		~spU_AgentAccountDetails() {

			Dispose(false);
		}

		private void ResetParameter(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_AgentAccountDetails parameters) {

			parameters.internal_Set_RETURN_VALUE (System.Data.SqlTypes.SqlInt32.Null);
		}

		private bool InitializeConnection(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_AgentAccountDetails parameters, out System.Data.SqlClient.SqlCommand sqlCommand, ref bool connectionMustBeClosed) {

			try {

				this.sqlConnection = null;
				sqlCommand = null;
				connectionMustBeClosed = true;

				if (parameters.ConnectionType == ConnectionType.None) {

					throw new InvalidOperationException("No connection information was supplied. Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spU_AgentAccountDetails object before doing this call.");
				}

				if (parameters.ConnectionType == ConnectionType.SqlConnection && parameters.SqlConnection == null) {

					throw new InvalidOperationException("No connection information was supplied (SqlConnection == null). Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spU_AgentAccountDetails object before doing this call.");
				}

				if (parameters.ConnectionType == ConnectionType.SqlTransaction && parameters.SqlTransaction== null) {

					throw new InvalidOperationException("No connection information was supplied (SqlTransaction == null). Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spU_AgentAccountDetails object before doing this call.");
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

							throw new System.InvalidOperationException("No connection information was supplied (ConnectionString == \"\")! (Evernet.MoneyExchange.DataClasses.Parameters.spU_AgentAccountDetails)");
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
				sqlCommand.CommandText = "spU_AgentAccountDetails";

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

		private bool DeclareParameters(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_AgentAccountDetails parameters, ref System.Data.SqlClient.SqlCommand sqlCommand) {

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

				sqlParameter = new System.Data.SqlClient.SqlParameter("@CreditDateTime", System.Data.SqlDbType.DateTime, 16);
				sqlParameter.SourceColumn = "CreditDateTime";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_CreditDateTime_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_CreditDateTime.IsNull) {

					sqlParameter.Value = parameters.Param_CreditDateTime;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_CreditDateTime", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_CreditDateTime_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_CreditDateTime.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_CreditDateTime;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@DebitDateTime", System.Data.SqlDbType.DateTime, 16);
				sqlParameter.SourceColumn = "DebitDateTime";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_DebitDateTime_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_DebitDateTime.IsNull) {

					sqlParameter.Value = parameters.Param_DebitDateTime;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_DebitDateTime", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_DebitDateTime_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_DebitDateTime.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_DebitDateTime;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@AgentAccountId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "AgentAccountId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_AgentAccountId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_AgentAccountId.IsNull) {

					sqlParameter.Value = parameters.Param_AgentAccountId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_AgentAccountId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_AgentAccountId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_AgentAccountId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_AgentAccountId;
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

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_TransactionId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_TransactionId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_TransactionId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_TransactionId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@CreditLC", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "CreditLC";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 6;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_CreditLC_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_CreditLC.IsNull) {

					sqlParameter.Value = parameters.Param_CreditLC;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_CreditLC", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_CreditLC_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_CreditLC.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_CreditLC;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@CreditUSD", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "CreditUSD";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 6;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_CreditUSD_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_CreditUSD.IsNull) {

					sqlParameter.Value = parameters.Param_CreditUSD;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_CreditUSD", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_CreditUSD_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_CreditUSD.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_CreditUSD;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@DebitLC", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "DebitLC";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 6;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_DebitLC_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_DebitLC.IsNull) {

					sqlParameter.Value = parameters.Param_DebitLC;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_DebitLC", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_DebitLC_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_DebitLC.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_DebitLC;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@DebitUSD", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "DebitUSD";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 6;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_DebitUSD_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_DebitUSD.IsNull) {

					sqlParameter.Value = parameters.Param_DebitUSD;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_DebitUSD", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_DebitUSD_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_DebitUSD.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_DebitUSD;
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

		private bool RetrieveParameters(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_AgentAccountDetails parameters, ref System.Data.SqlClient.SqlCommand sqlCommand) {

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
		/// This method allows you to execute the [spU_AgentAccountDetails] stored procedure.
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_AgentAccountDetails parameters) {

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

