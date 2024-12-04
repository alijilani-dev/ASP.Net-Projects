/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:46:44 PM
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
	/// stored procedure 'spI_AgentLocationList'. It allows also to specify specific connection
	/// information such as the ConnectionString to be use, the command time-out and so forth.
	/// </summary>
	[Serializable()]
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:46:44", SqlObjectDependancyName="spI_AgentLocationList", SqlObjectDependancyRevision=0)]
#endif
	public class spI_AgentLocationList : MarshalByRefObject, IDisposable, IParameter {

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
		/// Initializes a new instance of the spI_AgentLocationList class. If you use this constructor version,
		/// not assigning parameter values implies using the parameter default values.
		/// </summary>
		public spI_AgentLocationList() : this(true) {

		}

		/// <summary>
		/// Initializes a new instance of the spI_AgentLocationList class.
		/// </summary>
		/// <param name="useDefaultValue">If True, this parameter indicates that "not assigning parameter values" implies "using the parameter default values". If False, this parameter indicates that "not assigning parameter values" implies "using the SQL Server Null value".</param>
		public spI_AgentLocationList(bool useDefaultValue) {

			this.useDefaultValue = useDefaultValue;

			this.internal_Param_Id_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Name_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Code_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_AgentAccountId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_AgentGroupId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_CreditLimitInUSD_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_IndividualTransactionLimit_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_AllowedDomesticTransactionType_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_AllowedInternationalTransactionType_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ListOnWebFor_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Address_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Telephone_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Fax_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Email_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_LocationId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ContactPerson_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Active_UseDefaultValue = this.useDefaultValue;
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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spI_AgentLocationList'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spI_AgentLocationList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spI_AgentLocationList'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spI_AgentLocationList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spI_AgentLocationList'";
				sqlCommand.Transaction = sqlTransaction;

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlTransaction.Connection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spI_AgentLocationList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				this.internal_Param_Name = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_Code = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_AgentAccountId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_AgentGroupId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_CreditLimitInUSD = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_IndividualTransactionLimit = System.Data.SqlTypes.SqlDecimal.Null;
				this.internal_Param_AllowedDomesticTransactionType = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_AllowedInternationalTransactionType = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ListOnWebFor = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_Address = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_Telephone = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_Fax = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_Email = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_LocationId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ContactPerson = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_Active = System.Data.SqlTypes.SqlBoolean.Null;

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
		~spI_AgentLocationList() {

			Dispose(false);
		}

		/// <summary>
		/// Returns the stored procedure name for which this class was built, i.e. 'spI_AgentLocationList'.
		/// </summary>
		public string StoredProcedureName {

			get {

				return("spI_AgentLocationList");
			}
		}

		private System.Data.SqlTypes.SqlInt32 internal_Param_RETURN_VALUE;

		private System.Data.SqlTypes.SqlGuid internal_Param_Id;
		internal bool internal_Param_Id_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Name;
		internal bool internal_Param_Name_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Code;
		internal bool internal_Param_Code_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_AgentAccountId;
		internal bool internal_Param_AgentAccountId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_AgentGroupId;
		internal bool internal_Param_AgentGroupId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_CreditLimitInUSD;
		internal bool internal_Param_CreditLimitInUSD_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDecimal internal_Param_IndividualTransactionLimit;
		internal bool internal_Param_IndividualTransactionLimit_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_AllowedDomesticTransactionType;
		internal bool internal_Param_AllowedDomesticTransactionType_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_AllowedInternationalTransactionType;
		internal bool internal_Param_AllowedInternationalTransactionType_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_ListOnWebFor;
		internal bool internal_Param_ListOnWebFor_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Address;
		internal bool internal_Param_Address_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Telephone;
		internal bool internal_Param_Telephone_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Fax;
		internal bool internal_Param_Fax_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Email;
		internal bool internal_Param_Email_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_LocationId;
		internal bool internal_Param_LocationId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_ContactPerson;
		internal bool internal_Param_ContactPerson_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_Active;
		internal bool internal_Param_Active_UseDefaultValue = true;


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

			this.internal_Param_Name = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Name_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Code = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Code_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_AgentAccountId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_AgentAccountId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_AgentGroupId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_AgentGroupId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_CreditLimitInUSD = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_CreditLimitInUSD_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_IndividualTransactionLimit = System.Data.SqlTypes.SqlDecimal.Null;
			this.internal_Param_IndividualTransactionLimit_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_AllowedDomesticTransactionType = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_AllowedDomesticTransactionType_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_AllowedInternationalTransactionType = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_AllowedInternationalTransactionType_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ListOnWebFor = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_ListOnWebFor_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Address = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Address_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Telephone = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Telephone_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Fax = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Fax_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Email = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Email_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_LocationId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_LocationId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ContactPerson = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_ContactPerson_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Active = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_Active_UseDefaultValue = this.useDefaultValue;

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
		/// Sets or returns the value of the stored procedure OUTPUT parameter '@Id'.
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
		/// Sets the value of the stored procedure INPUT parameter '@Name'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](500)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_Name_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_Name {

			get {

				if (this.internal_Param_Name_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Name);
			}

			set {

				this.internal_Param_Name_UseDefaultValue = false;
				this.internal_Param_Name = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Name' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Name_UseDefaultValue() {

			this.internal_Param_Name_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Code'.
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
		/// the parameter default value, consider calling the Param_Code_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_Code {

			get {

				if (this.internal_Param_Code_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Code);
			}

			set {

				this.internal_Param_Code_UseDefaultValue = false;
				this.internal_Param_Code = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Code' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Code_UseDefaultValue() {

			this.internal_Param_Code_UseDefaultValue = true;
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
		/// Sets the value of the stored procedure INPUT parameter '@AgentGroupId'.
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
		/// the parameter default value, consider calling the Param_AgentGroupId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_AgentGroupId {

			get {

				if (this.internal_Param_AgentGroupId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_AgentGroupId);
			}

			set {

				this.internal_Param_AgentGroupId_UseDefaultValue = false;
				this.internal_Param_AgentGroupId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@AgentGroupId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_AgentGroupId_UseDefaultValue() {

			this.internal_Param_AgentGroupId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@CreditLimitInUSD'.
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
		/// the parameter default value, consider calling the Param_CreditLimitInUSD_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_CreditLimitInUSD {

			get {

				if (this.internal_Param_CreditLimitInUSD_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_CreditLimitInUSD);
			}

			set {

				this.internal_Param_CreditLimitInUSD_UseDefaultValue = false;
				this.internal_Param_CreditLimitInUSD = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@CreditLimitInUSD' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_CreditLimitInUSD_UseDefaultValue() {

			this.internal_Param_CreditLimitInUSD_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@IndividualTransactionLimit'.
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
		/// the parameter default value, consider calling the Param_IndividualTransactionLimit_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDecimal Param_IndividualTransactionLimit {

			get {

				if (this.internal_Param_IndividualTransactionLimit_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_IndividualTransactionLimit);
			}

			set {

				this.internal_Param_IndividualTransactionLimit_UseDefaultValue = false;
				this.internal_Param_IndividualTransactionLimit = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@IndividualTransactionLimit' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_IndividualTransactionLimit_UseDefaultValue() {

			this.internal_Param_IndividualTransactionLimit_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@AllowedDomesticTransactionType'.
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
		/// the parameter default value, consider calling the Param_AllowedDomesticTransactionType_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_AllowedDomesticTransactionType {

			get {

				if (this.internal_Param_AllowedDomesticTransactionType_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_AllowedDomesticTransactionType);
			}

			set {

				this.internal_Param_AllowedDomesticTransactionType_UseDefaultValue = false;
				this.internal_Param_AllowedDomesticTransactionType = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@AllowedDomesticTransactionType' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_AllowedDomesticTransactionType_UseDefaultValue() {

			this.internal_Param_AllowedDomesticTransactionType_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@AllowedInternationalTransactionType'.
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
		/// the parameter default value, consider calling the Param_AllowedInternationalTransactionType_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_AllowedInternationalTransactionType {

			get {

				if (this.internal_Param_AllowedInternationalTransactionType_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_AllowedInternationalTransactionType);
			}

			set {

				this.internal_Param_AllowedInternationalTransactionType_UseDefaultValue = false;
				this.internal_Param_AllowedInternationalTransactionType = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@AllowedInternationalTransactionType' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_AllowedInternationalTransactionType_UseDefaultValue() {

			this.internal_Param_AllowedInternationalTransactionType_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ListOnWebFor'.
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
		/// the parameter default value, consider calling the Param_ListOnWebFor_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_ListOnWebFor {

			get {

				if (this.internal_Param_ListOnWebFor_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ListOnWebFor);
			}

			set {

				this.internal_Param_ListOnWebFor_UseDefaultValue = false;
				this.internal_Param_ListOnWebFor = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ListOnWebFor' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ListOnWebFor_UseDefaultValue() {

			this.internal_Param_ListOnWebFor_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Address'.
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
		/// the parameter default value, consider calling the Param_Address_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_Address {

			get {

				if (this.internal_Param_Address_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Address);
			}

			set {

				this.internal_Param_Address_UseDefaultValue = false;
				this.internal_Param_Address = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Address' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Address_UseDefaultValue() {

			this.internal_Param_Address_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Telephone'.
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
		/// the parameter default value, consider calling the Param_Telephone_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_Telephone {

			get {

				if (this.internal_Param_Telephone_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Telephone);
			}

			set {

				this.internal_Param_Telephone_UseDefaultValue = false;
				this.internal_Param_Telephone = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Telephone' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Telephone_UseDefaultValue() {

			this.internal_Param_Telephone_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Fax'.
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
		/// the parameter default value, consider calling the Param_Fax_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_Fax {

			get {

				if (this.internal_Param_Fax_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Fax);
			}

			set {

				this.internal_Param_Fax_UseDefaultValue = false;
				this.internal_Param_Fax = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Fax' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Fax_UseDefaultValue() {

			this.internal_Param_Fax_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Email'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](500)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_Email_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_Email {

			get {

				if (this.internal_Param_Email_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Email);
			}

			set {

				this.internal_Param_Email_UseDefaultValue = false;
				this.internal_Param_Email = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Email' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Email_UseDefaultValue() {

			this.internal_Param_Email_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@LocationId'.
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
		/// the parameter default value, consider calling the Param_LocationId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_LocationId {

			get {

				if (this.internal_Param_LocationId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_LocationId);
			}

			set {

				this.internal_Param_LocationId_UseDefaultValue = false;
				this.internal_Param_LocationId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@LocationId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_LocationId_UseDefaultValue() {

			this.internal_Param_LocationId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ContactPerson'.
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
		/// the parameter default value, consider calling the Param_ContactPerson_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_ContactPerson {

			get {

				if (this.internal_Param_ContactPerson_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ContactPerson);
			}

			set {

				this.internal_Param_ContactPerson_UseDefaultValue = false;
				this.internal_Param_ContactPerson = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ContactPerson' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ContactPerson_UseDefaultValue() {

			this.internal_Param_ContactPerson_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Active'.
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
		/// the parameter default value, consider calling the Param_Active_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_Active {

			get {

				if (this.internal_Param_Active_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Active);
			}

			set {

				this.internal_Param_Active_UseDefaultValue = false;
				this.internal_Param_Active = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Active' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Active_UseDefaultValue() {

			this.internal_Param_Active_UseDefaultValue = true;
		}

  	}
}

namespace Evernet.MoneyExchange.DataClasses.StoredProcedures {

	/// <summary>
	/// This class allows you to execute the 'spI_AgentLocationList' stored procedure;
	/// it gives you the ability to:
	/// <list type="bullet">
	/// <item><description>Set all the necessary parameters to execute the stored procedure</description></item>
	/// <item><description>To execute the stored procedure</description></item>
	/// <item><description>To get back after the execution the return value and all the output parameters value</description></item>
	/// </list>
	/// </summary>
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:46:44", SqlObjectDependancyName="spI_AgentLocationList", SqlObjectDependancyRevision=0)]
#endif
	public class spI_AgentLocationList : MarshalByRefObject, IDisposable {


		private bool throwExceptionOnExecute = false;

		/// <summary>
		/// Initializes a new instance of the spI_AgentLocationList class.
		/// By default, no exception will be thrown when you call the Execute method. Instead, a Boolean return status will be returned.
		/// </summary>
		public spI_AgentLocationList() : this(false) {

		}

		/// <summary>
		/// Initializes a new instance of the spI_AgentLocationList class.
		/// </summary>
		/// <param name="throwExceptionOnExecute">True if an exception has to be thrown if the Execute call fails.</param>
		public spI_AgentLocationList(bool throwExceptionOnExecute) {

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
		~spI_AgentLocationList() {

			Dispose(false);
		}

		private void ResetParameter(ref Evernet.MoneyExchange.DataClasses.Parameters.spI_AgentLocationList parameters) {

			parameters.internal_Set_RETURN_VALUE (System.Data.SqlTypes.SqlInt32.Null);
		}

		private bool InitializeConnection(ref Evernet.MoneyExchange.DataClasses.Parameters.spI_AgentLocationList parameters, out System.Data.SqlClient.SqlCommand sqlCommand, ref bool connectionMustBeClosed) {

			try {

				this.sqlConnection = null;
				sqlCommand = null;
				connectionMustBeClosed = true;

				if (parameters.ConnectionType == ConnectionType.None) {

					throw new InvalidOperationException("No connection information was supplied. Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spI_AgentLocationList object before doing this call.");
				}

				if (parameters.ConnectionType == ConnectionType.SqlConnection && parameters.SqlConnection == null) {

					throw new InvalidOperationException("No connection information was supplied (SqlConnection == null). Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spI_AgentLocationList object before doing this call.");
				}

				if (parameters.ConnectionType == ConnectionType.SqlTransaction && parameters.SqlTransaction== null) {

					throw new InvalidOperationException("No connection information was supplied (SqlTransaction == null). Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spI_AgentLocationList object before doing this call.");
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

							throw new System.InvalidOperationException("No connection information was supplied (ConnectionString == \"\")! (Evernet.MoneyExchange.DataClasses.Parameters.spI_AgentLocationList)");
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
				sqlCommand.CommandText = "spI_AgentLocationList";

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

		private bool DeclareParameters(ref Evernet.MoneyExchange.DataClasses.Parameters.spI_AgentLocationList parameters, ref System.Data.SqlClient.SqlCommand sqlCommand) {

			try {

				System.Data.SqlClient.SqlParameter sqlParameter;

				sqlParameter = new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4);
				sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
				sqlParameter.IsNullable = true;
				sqlParameter.Value = System.DBNull.Value;
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "Id";
				sqlParameter.Direction = System.Data.ParameterDirection.InputOutput;
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

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 500);
				sqlParameter.SourceColumn = "Name";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Name_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Name.IsNull) {

					sqlParameter.Value = parameters.Param_Name;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Code", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "Code";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Code_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Code.IsNull) {

					sqlParameter.Value = parameters.Param_Code;
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

				sqlParameter = new System.Data.SqlClient.SqlParameter("@AgentGroupId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "AgentGroupId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_AgentGroupId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_AgentGroupId.IsNull) {

					sqlParameter.Value = parameters.Param_AgentGroupId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@CreditLimitInUSD", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "CreditLimitInUSD";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 2;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_CreditLimitInUSD_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_CreditLimitInUSD.IsNull) {

					sqlParameter.Value = parameters.Param_CreditLimitInUSD;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@IndividualTransactionLimit", System.Data.SqlDbType.Decimal, 20);
				sqlParameter.SourceColumn = "IndividualTransactionLimit";
				sqlParameter.Precision = 18;
				sqlParameter.Scale = 2;
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_IndividualTransactionLimit_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_IndividualTransactionLimit.IsNull) {

					sqlParameter.Value = parameters.Param_IndividualTransactionLimit;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@AllowedDomesticTransactionType", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "AllowedDomesticTransactionType";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_AllowedDomesticTransactionType_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_AllowedDomesticTransactionType.IsNull) {

					sqlParameter.Value = parameters.Param_AllowedDomesticTransactionType;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@AllowedInternationalTransactionType", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "AllowedInternationalTransactionType";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_AllowedInternationalTransactionType_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_AllowedInternationalTransactionType.IsNull) {

					sqlParameter.Value = parameters.Param_AllowedInternationalTransactionType;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ListOnWebFor", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "ListOnWebFor";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ListOnWebFor_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ListOnWebFor.IsNull) {

					sqlParameter.Value = parameters.Param_ListOnWebFor;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 600);
				sqlParameter.SourceColumn = "Address";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Address_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Address.IsNull) {

					sqlParameter.Value = parameters.Param_Address;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Telephone", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "Telephone";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Telephone_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Telephone.IsNull) {

					sqlParameter.Value = parameters.Param_Telephone;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "Fax";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Fax_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Fax.IsNull) {

					sqlParameter.Value = parameters.Param_Fax;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 500);
				sqlParameter.SourceColumn = "Email";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Email_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Email.IsNull) {

					sqlParameter.Value = parameters.Param_Email;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@LocationId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "LocationId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_LocationId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_LocationId.IsNull) {

					sqlParameter.Value = parameters.Param_LocationId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ContactPerson", System.Data.SqlDbType.NVarChar, 300);
				sqlParameter.SourceColumn = "ContactPerson";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ContactPerson_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ContactPerson.IsNull) {

					sqlParameter.Value = parameters.Param_ContactPerson;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.Bit, 1);
				sqlParameter.SourceColumn = "Active";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Active_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Active.IsNull) {

					sqlParameter.Value = parameters.Param_Active;
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

		private bool RetrieveParameters(ref Evernet.MoneyExchange.DataClasses.Parameters.spI_AgentLocationList parameters, ref System.Data.SqlClient.SqlCommand sqlCommand) {

			try {

				if (sqlCommand.Parameters["@RETURN_VALUE"].Value != System.DBNull.Value) {

					parameters.internal_Set_RETURN_VALUE ((System.Int32)sqlCommand.Parameters["@RETURN_VALUE"].Value);
				}
				else {

					parameters.internal_Set_RETURN_VALUE (System.Data.SqlTypes.SqlInt32.Null);
				}

				if (sqlCommand.Parameters["@Id"].Value != System.DBNull.Value) {

						try {

							parameters.Param_Id = (System.Data.SqlTypes.SqlGuid)sqlCommand.Parameters["@Id"].Value;
						}
						catch (System.InvalidCastException) {

							parameters.Param_Id = (System.Guid)sqlCommand.Parameters["@Id"].Value;
						}
				}
				else {

					parameters.Param_Id = System.Data.SqlTypes.SqlGuid.Null;
				}
				parameters.internal_Param_Id_UseDefaultValue = false;

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
		/// This method allows you to execute the [spI_AgentLocationList] stored procedure.
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spI_AgentLocationList parameters) {

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

