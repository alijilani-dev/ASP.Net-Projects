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
	/// stored procedure 'spU_CustomerList'. It allows also to specify specific connection
	/// information such as the ConnectionString to be use, the command time-out and so forth.
	/// </summary>
	[Serializable()]
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:06", SqlObjectDependancyName="spU_CustomerList", SqlObjectDependancyRevision=0)]
#endif
	public class spU_CustomerList : MarshalByRefObject, IDisposable, IParameter {

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
		/// Initializes a new instance of the spU_CustomerList class. If you use this constructor version,
		/// not assigning parameter values implies using the parameter default values.
		/// </summary>
		public spU_CustomerList() : this(true) {

		}

		/// <summary>
		/// Initializes a new instance of the spU_CustomerList class.
		/// </summary>
		/// <param name="useDefaultValue">If True, this parameter indicates that "not assigning parameter values" implies "using the parameter default values". If False, this parameter indicates that "not assigning parameter values" implies "using the SQL Server Null value".</param>
		public spU_CustomerList(bool useDefaultValue) {

			this.useDefaultValue = useDefaultValue;

			this.internal_Param_Id_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_LoginName_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_LoginName_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Password_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_Password_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_FirstName_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_FirstName_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_LastName_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_LastName_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_CardId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_CardId_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Address_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_Address_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Telephone_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_Telephone_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Fax_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_Fax_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Mobile_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_Mobile_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Email_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_Email_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_IDType_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_IDType_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_IDDetails_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_IDDetails_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_IDExpirationDate_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_IDExpirationDate_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Nationality_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_Nationality_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_Active_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_Active_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_AccountActivated_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_AccountActivated_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_CardIssued_UseDefaultValue = this.useDefaultValue;
			this.internal_Param_ConsiderNull_CardIssued_UseDefaultValue = this.useDefaultValue;
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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spU_CustomerList'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spU_CustomerList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spU_CustomerList'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spU_CustomerList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spU_CustomerList'";
				sqlCommand.Transaction = sqlTransaction;

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlTransaction.Connection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spU_CustomerList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
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
				this.internal_Param_LoginName = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_LoginName = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_Password = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_Password = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_FirstName = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_FirstName = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_LastName = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_LastName = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_CardId = System.Data.SqlTypes.SqlGuid.Null;
				this.internal_Param_ConsiderNull_CardId = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_Address = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_Address = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_Telephone = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_Telephone = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_Fax = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_Fax = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_Mobile = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_Mobile = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_Email = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_Email = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_IDType = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_IDType = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_IDDetails = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_IDDetails = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_IDExpirationDate = System.Data.SqlTypes.SqlDateTime.Null;
				this.internal_Param_ConsiderNull_IDExpirationDate = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_Nationality = System.Data.SqlTypes.SqlString.Null;
				this.internal_Param_ConsiderNull_Nationality = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_Active = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_ConsiderNull_Active = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_AccountActivated = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_ConsiderNull_AccountActivated = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_CardIssued = System.Data.SqlTypes.SqlBoolean.Null;
				this.internal_Param_ConsiderNull_CardIssued = System.Data.SqlTypes.SqlBoolean.Null;

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
		~spU_CustomerList() {

			Dispose(false);
		}

		/// <summary>
		/// Returns the stored procedure name for which this class was built, i.e. 'spU_CustomerList'.
		/// </summary>
		public string StoredProcedureName {

			get {

				return("spU_CustomerList");
			}
		}

		private System.Data.SqlTypes.SqlInt32 internal_Param_RETURN_VALUE;

		private System.Data.SqlTypes.SqlGuid internal_Param_Id;
		internal bool internal_Param_Id_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_LoginName;
		internal bool internal_Param_LoginName_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_LoginName;
		internal bool internal_Param_ConsiderNull_LoginName_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Password;
		internal bool internal_Param_Password_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_Password;
		internal bool internal_Param_ConsiderNull_Password_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_FirstName;
		internal bool internal_Param_FirstName_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_FirstName;
		internal bool internal_Param_ConsiderNull_FirstName_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_LastName;
		internal bool internal_Param_LastName_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_LastName;
		internal bool internal_Param_ConsiderNull_LastName_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlGuid internal_Param_CardId;
		internal bool internal_Param_CardId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_CardId;
		internal bool internal_Param_ConsiderNull_CardId_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Address;
		internal bool internal_Param_Address_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_Address;
		internal bool internal_Param_ConsiderNull_Address_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Telephone;
		internal bool internal_Param_Telephone_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_Telephone;
		internal bool internal_Param_ConsiderNull_Telephone_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Fax;
		internal bool internal_Param_Fax_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_Fax;
		internal bool internal_Param_ConsiderNull_Fax_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Mobile;
		internal bool internal_Param_Mobile_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_Mobile;
		internal bool internal_Param_ConsiderNull_Mobile_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Email;
		internal bool internal_Param_Email_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_Email;
		internal bool internal_Param_ConsiderNull_Email_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_IDType;
		internal bool internal_Param_IDType_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_IDType;
		internal bool internal_Param_ConsiderNull_IDType_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_IDDetails;
		internal bool internal_Param_IDDetails_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_IDDetails;
		internal bool internal_Param_ConsiderNull_IDDetails_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlDateTime internal_Param_IDExpirationDate;
		internal bool internal_Param_IDExpirationDate_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_IDExpirationDate;
		internal bool internal_Param_ConsiderNull_IDExpirationDate_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlString internal_Param_Nationality;
		internal bool internal_Param_Nationality_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_Nationality;
		internal bool internal_Param_ConsiderNull_Nationality_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_Active;
		internal bool internal_Param_Active_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_Active;
		internal bool internal_Param_ConsiderNull_Active_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_AccountActivated;
		internal bool internal_Param_AccountActivated_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_AccountActivated;
		internal bool internal_Param_ConsiderNull_AccountActivated_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_CardIssued;
		internal bool internal_Param_CardIssued_UseDefaultValue = true;

		private System.Data.SqlTypes.SqlBoolean internal_Param_ConsiderNull_CardIssued;
		internal bool internal_Param_ConsiderNull_CardIssued_UseDefaultValue = true;


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

			this.internal_Param_LoginName = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_LoginName_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_LoginName = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_LoginName_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Password = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Password_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_Password = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_Password_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_FirstName = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_FirstName_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_FirstName = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_FirstName_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_LastName = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_LastName_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_LastName = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_LastName_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_CardId = System.Data.SqlTypes.SqlGuid.Null;
			this.internal_Param_CardId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_CardId = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_CardId_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Address = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Address_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_Address = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_Address_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Telephone = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Telephone_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_Telephone = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_Telephone_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Fax = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Fax_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_Fax = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_Fax_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Mobile = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Mobile_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_Mobile = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_Mobile_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Email = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Email_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_Email = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_Email_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_IDType = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_IDType_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_IDType = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_IDType_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_IDDetails = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_IDDetails_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_IDDetails = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_IDDetails_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_IDExpirationDate = System.Data.SqlTypes.SqlDateTime.Null;
			this.internal_Param_IDExpirationDate_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_IDExpirationDate = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_IDExpirationDate_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Nationality = System.Data.SqlTypes.SqlString.Null;
			this.internal_Param_Nationality_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_Nationality = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_Nationality_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_Active = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_Active_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_Active = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_Active_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_AccountActivated = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_AccountActivated_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_AccountActivated = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_AccountActivated_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_CardIssued = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_CardIssued_UseDefaultValue = this.useDefaultValue;

			this.internal_Param_ConsiderNull_CardIssued = System.Data.SqlTypes.SqlBoolean.Null;
			this.internal_Param_ConsiderNull_CardIssued_UseDefaultValue = this.useDefaultValue;

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
		/// Sets the value of the stored procedure INPUT parameter '@LoginName'.
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
		/// the parameter default value, consider calling the Param_LoginName_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_LoginName {

			get {

				if (this.internal_Param_LoginName_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_LoginName);
			}

			set {

				this.internal_Param_LoginName_UseDefaultValue = false;
				this.internal_Param_LoginName = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@LoginName' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_LoginName_UseDefaultValue() {

			this.internal_Param_LoginName_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_LoginName'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_LoginName_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_LoginName {

			get {

				if (this.internal_Param_ConsiderNull_LoginName_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_LoginName);
			}

			set {

				this.internal_Param_ConsiderNull_LoginName_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_LoginName = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_LoginName' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_LoginName_UseDefaultValue() {

			this.internal_Param_ConsiderNull_LoginName_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Password'.
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
		/// the parameter default value, consider calling the Param_Password_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_Password {

			get {

				if (this.internal_Param_Password_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Password);
			}

			set {

				this.internal_Param_Password_UseDefaultValue = false;
				this.internal_Param_Password = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Password' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Password_UseDefaultValue() {

			this.internal_Param_Password_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_Password'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_Password_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_Password {

			get {

				if (this.internal_Param_ConsiderNull_Password_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_Password);
			}

			set {

				this.internal_Param_ConsiderNull_Password_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_Password = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_Password' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_Password_UseDefaultValue() {

			this.internal_Param_ConsiderNull_Password_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@FirstName'.
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
		/// the parameter default value, consider calling the Param_FirstName_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_FirstName {

			get {

				if (this.internal_Param_FirstName_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_FirstName);
			}

			set {

				this.internal_Param_FirstName_UseDefaultValue = false;
				this.internal_Param_FirstName = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@FirstName' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_FirstName_UseDefaultValue() {

			this.internal_Param_FirstName_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_FirstName'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_FirstName_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_FirstName {

			get {

				if (this.internal_Param_ConsiderNull_FirstName_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_FirstName);
			}

			set {

				this.internal_Param_ConsiderNull_FirstName_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_FirstName = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_FirstName' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_FirstName_UseDefaultValue() {

			this.internal_Param_ConsiderNull_FirstName_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@LastName'.
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
		/// the parameter default value, consider calling the Param_LastName_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_LastName {

			get {

				if (this.internal_Param_LastName_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_LastName);
			}

			set {

				this.internal_Param_LastName_UseDefaultValue = false;
				this.internal_Param_LastName = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@LastName' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_LastName_UseDefaultValue() {

			this.internal_Param_LastName_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_LastName'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_LastName_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_LastName {

			get {

				if (this.internal_Param_ConsiderNull_LastName_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_LastName);
			}

			set {

				this.internal_Param_ConsiderNull_LastName_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_LastName = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_LastName' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_LastName_UseDefaultValue() {

			this.internal_Param_ConsiderNull_LastName_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@CardId'.
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
		/// the parameter default value, consider calling the Param_CardId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlGuid Param_CardId {

			get {

				if (this.internal_Param_CardId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_CardId);
			}

			set {

				this.internal_Param_CardId_UseDefaultValue = false;
				this.internal_Param_CardId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@CardId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_CardId_UseDefaultValue() {

			this.internal_Param_CardId_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_CardId'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_CardId_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_CardId {

			get {

				if (this.internal_Param_ConsiderNull_CardId_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_CardId);
			}

			set {

				this.internal_Param_ConsiderNull_CardId_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_CardId = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_CardId' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_CardId_UseDefaultValue() {

			this.internal_Param_ConsiderNull_CardId_UseDefaultValue = true;
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
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_Address'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_Address_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_Address {

			get {

				if (this.internal_Param_ConsiderNull_Address_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_Address);
			}

			set {

				this.internal_Param_ConsiderNull_Address_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_Address = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_Address' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_Address_UseDefaultValue() {

			this.internal_Param_ConsiderNull_Address_UseDefaultValue = true;
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
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_Telephone'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_Telephone_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_Telephone {

			get {

				if (this.internal_Param_ConsiderNull_Telephone_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_Telephone);
			}

			set {

				this.internal_Param_ConsiderNull_Telephone_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_Telephone = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_Telephone' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_Telephone_UseDefaultValue() {

			this.internal_Param_ConsiderNull_Telephone_UseDefaultValue = true;
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
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_Fax'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_Fax_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_Fax {

			get {

				if (this.internal_Param_ConsiderNull_Fax_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_Fax);
			}

			set {

				this.internal_Param_ConsiderNull_Fax_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_Fax = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_Fax' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_Fax_UseDefaultValue() {

			this.internal_Param_ConsiderNull_Fax_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Mobile'.
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
		/// the parameter default value, consider calling the Param_Mobile_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_Mobile {

			get {

				if (this.internal_Param_Mobile_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Mobile);
			}

			set {

				this.internal_Param_Mobile_UseDefaultValue = false;
				this.internal_Param_Mobile = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Mobile' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Mobile_UseDefaultValue() {

			this.internal_Param_Mobile_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_Mobile'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_Mobile_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_Mobile {

			get {

				if (this.internal_Param_ConsiderNull_Mobile_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_Mobile);
			}

			set {

				this.internal_Param_ConsiderNull_Mobile_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_Mobile = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_Mobile' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_Mobile_UseDefaultValue() {

			this.internal_Param_ConsiderNull_Mobile_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Email'.
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
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_Email'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_Email_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_Email {

			get {

				if (this.internal_Param_ConsiderNull_Email_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_Email);
			}

			set {

				this.internal_Param_ConsiderNull_Email_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_Email = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_Email' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_Email_UseDefaultValue() {

			this.internal_Param_ConsiderNull_Email_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@IDType'.
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
		/// the parameter default value, consider calling the Param_IDType_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_IDType {

			get {

				if (this.internal_Param_IDType_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_IDType);
			}

			set {

				this.internal_Param_IDType_UseDefaultValue = false;
				this.internal_Param_IDType = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@IDType' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_IDType_UseDefaultValue() {

			this.internal_Param_IDType_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_IDType'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_IDType_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_IDType {

			get {

				if (this.internal_Param_ConsiderNull_IDType_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_IDType);
			}

			set {

				this.internal_Param_ConsiderNull_IDType_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_IDType = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_IDType' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_IDType_UseDefaultValue() {

			this.internal_Param_ConsiderNull_IDType_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@IDDetails'.
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
		/// the parameter default value, consider calling the Param_IDDetails_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_IDDetails {

			get {

				if (this.internal_Param_IDDetails_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_IDDetails);
			}

			set {

				this.internal_Param_IDDetails_UseDefaultValue = false;
				this.internal_Param_IDDetails = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@IDDetails' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_IDDetails_UseDefaultValue() {

			this.internal_Param_IDDetails_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_IDDetails'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_IDDetails_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_IDDetails {

			get {

				if (this.internal_Param_ConsiderNull_IDDetails_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_IDDetails);
			}

			set {

				this.internal_Param_ConsiderNull_IDDetails_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_IDDetails = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_IDDetails' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_IDDetails_UseDefaultValue() {

			this.internal_Param_ConsiderNull_IDDetails_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@IDExpirationDate'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [smalldatetime]
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_IDExpirationDate_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlDateTime Param_IDExpirationDate {

			get {

				if (this.internal_Param_IDExpirationDate_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_IDExpirationDate);
			}

			set {

				this.internal_Param_IDExpirationDate_UseDefaultValue = false;
				this.internal_Param_IDExpirationDate = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@IDExpirationDate' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_IDExpirationDate_UseDefaultValue() {

			this.internal_Param_IDExpirationDate_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_IDExpirationDate'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_IDExpirationDate_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_IDExpirationDate {

			get {

				if (this.internal_Param_ConsiderNull_IDExpirationDate_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_IDExpirationDate);
			}

			set {

				this.internal_Param_ConsiderNull_IDExpirationDate_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_IDExpirationDate = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_IDExpirationDate' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_IDExpirationDate_UseDefaultValue() {

			this.internal_Param_ConsiderNull_IDExpirationDate_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@Nationality'.
		/// </summary>
		/// <remarks>
		/// <list type="number">
		/// <item>
		/// <description>
		/// In SQL Server, this parameter is of type: [nvarchar](4)
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// If this parameter is not set before the stored procedure call occurs, a Null (SQL Server meaning) value
		/// will be supplied to the corresponding parameter when the call is made. If you wish to use
		/// the parameter default value, consider calling the Param_Nationality_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlString Param_Nationality {

			get {

				if (this.internal_Param_Nationality_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_Nationality);
			}

			set {

				this.internal_Param_Nationality_UseDefaultValue = false;
				this.internal_Param_Nationality = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@Nationality' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_Nationality_UseDefaultValue() {

			this.internal_Param_Nationality_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_Nationality'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_Nationality_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_Nationality {

			get {

				if (this.internal_Param_ConsiderNull_Nationality_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_Nationality);
			}

			set {

				this.internal_Param_ConsiderNull_Nationality_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_Nationality = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_Nationality' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_Nationality_UseDefaultValue() {

			this.internal_Param_ConsiderNull_Nationality_UseDefaultValue = true;
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

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_Active'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_Active_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_Active {

			get {

				if (this.internal_Param_ConsiderNull_Active_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_Active);
			}

			set {

				this.internal_Param_ConsiderNull_Active_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_Active = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_Active' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_Active_UseDefaultValue() {

			this.internal_Param_ConsiderNull_Active_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@AccountActivated'.
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
		/// the parameter default value, consider calling the Param_AccountActivated_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_AccountActivated {

			get {

				if (this.internal_Param_AccountActivated_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_AccountActivated);
			}

			set {

				this.internal_Param_AccountActivated_UseDefaultValue = false;
				this.internal_Param_AccountActivated = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@AccountActivated' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_AccountActivated_UseDefaultValue() {

			this.internal_Param_AccountActivated_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_AccountActivated'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_AccountActivated_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_AccountActivated {

			get {

				if (this.internal_Param_ConsiderNull_AccountActivated_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_AccountActivated);
			}

			set {

				this.internal_Param_ConsiderNull_AccountActivated_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_AccountActivated = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_AccountActivated' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_AccountActivated_UseDefaultValue() {

			this.internal_Param_ConsiderNull_AccountActivated_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@CardIssued'.
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
		/// the parameter default value, consider calling the Param_CardIssued_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_CardIssued {

			get {

				if (this.internal_Param_CardIssued_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_CardIssued);
			}

			set {

				this.internal_Param_CardIssued_UseDefaultValue = false;
				this.internal_Param_CardIssued = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@CardIssued' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_CardIssued_UseDefaultValue() {

			this.internal_Param_CardIssued_UseDefaultValue = true;
		}

		/// <summary>
		/// Sets the value of the stored procedure INPUT parameter '@ConsiderNull_CardIssued'.
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
		/// the parameter default value, consider calling the Param_ConsiderNull_CardIssued_UseDefaultValue() method.
		/// </description>
		/// </item>
		/// </list>
		/// </remarks>
		public System.Data.SqlTypes.SqlBoolean Param_ConsiderNull_CardIssued {

			get {

				if (this.internal_Param_ConsiderNull_CardIssued_UseDefaultValue) {
				
					throw new InvalidOperationException("This parameter is not assigned and maps to the stored procedure parameter default value.");
				}
				return(this.internal_Param_ConsiderNull_CardIssued);
			}

			set {

				this.internal_Param_ConsiderNull_CardIssued_UseDefaultValue = false;
				this.internal_Param_ConsiderNull_CardIssued = value;
			}
		}            

		/// <summary>
		/// Indicates that the '@ConsiderNull_CardIssued' parameter value is not supplied and that the default value should be used.
		/// </summary>
		public void Param_ConsiderNull_CardIssued_UseDefaultValue() {

			this.internal_Param_ConsiderNull_CardIssued_UseDefaultValue = true;
		}

  	}
}

namespace Evernet.MoneyExchange.DataClasses.StoredProcedures {

	/// <summary>
	/// This class allows you to execute the 'spU_CustomerList' stored procedure;
	/// it gives you the ability to:
	/// <list type="bullet">
	/// <item><description>Set all the necessary parameters to execute the stored procedure</description></item>
	/// <item><description>To execute the stored procedure</description></item>
	/// <item><description>To get back after the execution the return value and all the output parameters value</description></item>
	/// </list>
	/// </summary>
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:06", SqlObjectDependancyName="spU_CustomerList", SqlObjectDependancyRevision=0)]
#endif
	public class spU_CustomerList : MarshalByRefObject, IDisposable {


		private bool throwExceptionOnExecute = false;

		/// <summary>
		/// Initializes a new instance of the spU_CustomerList class.
		/// By default, no exception will be thrown when you call the Execute method. Instead, a Boolean return status will be returned.
		/// </summary>
		public spU_CustomerList() : this(false) {

		}

		/// <summary>
		/// Initializes a new instance of the spU_CustomerList class.
		/// </summary>
		/// <param name="throwExceptionOnExecute">True if an exception has to be thrown if the Execute call fails.</param>
		public spU_CustomerList(bool throwExceptionOnExecute) {

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
		~spU_CustomerList() {

			Dispose(false);
		}

		private void ResetParameter(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_CustomerList parameters) {

			parameters.internal_Set_RETURN_VALUE (System.Data.SqlTypes.SqlInt32.Null);
		}

		private bool InitializeConnection(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_CustomerList parameters, out System.Data.SqlClient.SqlCommand sqlCommand, ref bool connectionMustBeClosed) {

			try {

				this.sqlConnection = null;
				sqlCommand = null;
				connectionMustBeClosed = true;

				if (parameters.ConnectionType == ConnectionType.None) {

					throw new InvalidOperationException("No connection information was supplied. Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spU_CustomerList object before doing this call.");
				}

				if (parameters.ConnectionType == ConnectionType.SqlConnection && parameters.SqlConnection == null) {

					throw new InvalidOperationException("No connection information was supplied (SqlConnection == null). Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spU_CustomerList object before doing this call.");
				}

				if (parameters.ConnectionType == ConnectionType.SqlTransaction && parameters.SqlTransaction== null) {

					throw new InvalidOperationException("No connection information was supplied (SqlTransaction == null). Consider calling the 'SetUpConnection' method of the Evernet.MoneyExchange.DataClasses.Parameters.spU_CustomerList object before doing this call.");
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

							throw new System.InvalidOperationException("No connection information was supplied (ConnectionString == \"\")! (Evernet.MoneyExchange.DataClasses.Parameters.spU_CustomerList)");
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
				sqlCommand.CommandText = "spU_CustomerList";

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

		private bool DeclareParameters(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_CustomerList parameters, ref System.Data.SqlClient.SqlCommand sqlCommand) {

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

				sqlParameter = new System.Data.SqlClient.SqlParameter("@LoginName", System.Data.SqlDbType.NVarChar, 300);
				sqlParameter.SourceColumn = "LoginName";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_LoginName_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_LoginName.IsNull) {

					sqlParameter.Value = parameters.Param_LoginName;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_LoginName", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_LoginName_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_LoginName.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_LoginName;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "Password";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Password_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Password.IsNull) {

					sqlParameter.Value = parameters.Param_Password;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Password", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_Password_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_Password.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_Password;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 300);
				sqlParameter.SourceColumn = "FirstName";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_FirstName_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_FirstName.IsNull) {

					sqlParameter.Value = parameters.Param_FirstName;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_FirstName", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_FirstName_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_FirstName.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_FirstName;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 300);
				sqlParameter.SourceColumn = "LastName";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_LastName_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_LastName.IsNull) {

					sqlParameter.Value = parameters.Param_LastName;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_LastName", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_LastName_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_LastName.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_LastName;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@CardId", System.Data.SqlDbType.UniqueIdentifier, 16);
				sqlParameter.SourceColumn = "CardId";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_CardId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_CardId.IsNull) {

					sqlParameter.Value = parameters.Param_CardId;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_CardId", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_CardId_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_CardId.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_CardId;
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

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Address", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_Address_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_Address.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_Address;
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

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Telephone", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_Telephone_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_Telephone.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_Telephone;
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

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Fax", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_Fax_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_Fax.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_Fax;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Mobile", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "Mobile";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Mobile_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Mobile.IsNull) {

					sqlParameter.Value = parameters.Param_Mobile;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Mobile", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_Mobile_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_Mobile.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_Mobile;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 100);
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

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Email", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_Email_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_Email.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_Email;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@IDType", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "IDType";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_IDType_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_IDType.IsNull) {

					sqlParameter.Value = parameters.Param_IDType;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_IDType", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_IDType_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_IDType.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_IDType;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@IDDetails", System.Data.SqlDbType.NVarChar, 100);
				sqlParameter.SourceColumn = "IDDetails";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_IDDetails_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_IDDetails.IsNull) {

					sqlParameter.Value = parameters.Param_IDDetails;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_IDDetails", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_IDDetails_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_IDDetails.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_IDDetails;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@IDExpirationDate", System.Data.SqlDbType.SmallDateTime, 16);
				sqlParameter.SourceColumn = "IDExpirationDate";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_IDExpirationDate_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_IDExpirationDate.IsNull) {

					sqlParameter.Value = parameters.Param_IDExpirationDate;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_IDExpirationDate", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_IDExpirationDate_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_IDExpirationDate.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_IDExpirationDate;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@Nationality", System.Data.SqlDbType.NVarChar, 4);
				sqlParameter.SourceColumn = "Nationality";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_Nationality_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_Nationality.IsNull) {

					sqlParameter.Value = parameters.Param_Nationality;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Nationality", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_Nationality_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_Nationality.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_Nationality;
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

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_Active", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_Active_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_Active.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_Active;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@AccountActivated", System.Data.SqlDbType.Bit, 1);
				sqlParameter.SourceColumn = "AccountActivated";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_AccountActivated_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_AccountActivated.IsNull) {

					sqlParameter.Value = parameters.Param_AccountActivated;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_AccountActivated", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_AccountActivated_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_AccountActivated.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_AccountActivated;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@CardIssued", System.Data.SqlDbType.Bit, 1);
				sqlParameter.SourceColumn = "CardIssued";
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_CardIssued_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_CardIssued.IsNull) {

					sqlParameter.Value = parameters.Param_CardIssued;
				}
				else {

					sqlParameter.IsNullable = true;
					sqlParameter.Value = System.DBNull.Value;
				}
				sqlCommand.Parameters.Add(sqlParameter);

				sqlParameter = new System.Data.SqlClient.SqlParameter("@ConsiderNull_CardIssued", System.Data.SqlDbType.Bit, 1);
				sqlParameter.Direction = System.Data.ParameterDirection.Input;
				if (parameters.internal_Param_ConsiderNull_CardIssued_UseDefaultValue) {

					sqlParameter.Value = null;				
				}
				else if (!parameters.Param_ConsiderNull_CardIssued.IsNull) {

					sqlParameter.Value = parameters.Param_ConsiderNull_CardIssued;
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

		private bool RetrieveParameters(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_CustomerList parameters, ref System.Data.SqlClient.SqlCommand sqlCommand) {

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
		/// This method allows you to execute the [spU_CustomerList] stored procedure.
		/// </summary>
		/// <param name="parameters">
		/// Contains all the necessary information to execute correctly the stored procedure, i.e. 
		/// the database connection to use and all the necessary input parameters to be supplied
		/// for this stored procedure execution. After the execution, this object will allow you
		/// to retrieve back the stored procedure return value and all the output parameters.
		/// </param>
		/// <returns>True if the call was successful. Otherwise, it returns False.</returns>
		public bool Execute(ref Evernet.MoneyExchange.DataClasses.Parameters.spU_CustomerList parameters) {

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

