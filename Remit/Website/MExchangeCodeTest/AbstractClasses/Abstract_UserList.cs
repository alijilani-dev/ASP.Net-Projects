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
	/// This class allows you to very easily retrieve a record from the [UserList] table.
	/// </summary>
	[Serializable()]
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[Evernet.MoneyExchange.DataClasses.OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:32", SqlObjectDependancyName="UserList", SqlObjectDependancyRevision=1392)]
#endif
	public class Abstract_UserList {

		Params.spS_UserList Param;
		private bool CloseConnectionAfterUse = true;

		/// <summary>
		/// Create a new instance of the Abstract_UserList class.
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		public Abstract_UserList(string connectionString) {

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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'UserList'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "UserList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
					}
				}
			}
#endif

			this.Param = new Params.spS_UserList(true);
			this.Param.SetUpConnection(connectionString);
		}

		/// <summary>
		/// Create a new instance of the Abstract_UserList class.
		/// </summary>
		/// <param name="sqlConnection">A valid System.Data.SqlClient.SqlConnection to the database.</param>
		public Abstract_UserList(System.Data.SqlClient.SqlConnection sqlConnection) {

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'UserList'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "UserList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.Param = new Params.spS_UserList(true);
			this.Param.SetUpConnection(sqlConnection);
			CloseConnectionAfterUse = (this.Param.SqlConnection.State != System.Data.ConnectionState.Open);
		}

		/// <summary>
		/// Create a new instance of the Abstract_UserList class.
		/// </summary>
		/// <param name="sqlTransaction">A valid System.Data.SqlClient.SqlTransaction to the database.</param>
		public Abstract_UserList(System.Data.SqlClient.SqlTransaction sqlTransaction) {

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'UserList'";
				sqlCommand.Transaction = sqlTransaction;

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlTransaction.Connection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "UserList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.Param = new Params.spS_UserList(true);
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

		private System.Data.SqlTypes.SqlString col_LoginName;
		/// <summary>
		/// Returns the value of the LoginName column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_LoginName {

			get {

				return (this.col_LoginName);
			}
		}

		private System.Data.SqlTypes.SqlString col_LoginPassword;
		/// <summary>
		/// Returns the value of the LoginPassword column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_LoginPassword {

			get {

				return (this.col_LoginPassword);
			}
		}

		private System.Data.SqlTypes.SqlString col_TransactionPassword;
		/// <summary>
		/// Returns the value of the TransactionPassword column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_TransactionPassword {

			get {

				return (this.col_TransactionPassword);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_AgentAccountId;
		/// <summary>
		/// Returns the value of the AgentAccountId column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_AgentAccountId {

			get {

				return (this.col_AgentAccountId);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_AgentId;
		/// <summary>
		/// Returns the value of the AgentId column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_AgentId {

			get {

				return (this.col_AgentId);
			}
		}

		private System.Data.SqlTypes.SqlString col_Email;
		/// <summary>
		/// Returns the value of the Email column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_Email {

			get {

				return (this.col_Email);
			}
		}

		private System.Data.SqlTypes.SqlBoolean col_IsAgencyEmployee;
		/// <summary>
		/// Returns the value of the IsAgencyEmployee column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlBoolean Col_IsAgencyEmployee {

			get {

				return (this.col_IsAgencyEmployee);
			}
		}

		private System.Data.SqlTypes.SqlBoolean col_CanBeEdited;
		/// <summary>
		/// Returns the value of the CanBeEdited column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlBoolean Col_CanBeEdited {

			get {

				return (this.col_CanBeEdited);
			}
		}

		private System.Data.SqlTypes.SqlBoolean col_Active;
		/// <summary>
		/// Returns the value of the Active column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlBoolean Col_Active {

			get {

				return (this.col_Active);
			}
		}

		/// <summary>
		/// This method allows to clear all the properties previously loaded by a call to the Refresh method.
		/// </summary>
		public void Reset() {

			this.col_Id = System.Data.SqlTypes.SqlGuid.Null;
			this.col_LoginName = System.Data.SqlTypes.SqlString.Null;
			this.col_LoginPassword = System.Data.SqlTypes.SqlString.Null;
			this.col_TransactionPassword = System.Data.SqlTypes.SqlString.Null;
			this.col_AgentAccountId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_AgentId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_Email = System.Data.SqlTypes.SqlString.Null;
			this.col_IsAgencyEmployee = System.Data.SqlTypes.SqlBoolean.Null;
			this.col_CanBeEdited = System.Data.SqlTypes.SqlBoolean.Null;
			this.col_Active = System.Data.SqlTypes.SqlBoolean.Null;
		}

		/// <summary>
		/// Allows you to load a specific record of the [UserList] table.
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
			SPs.spS_UserList SP = new SPs.spS_UserList(false);

			if (SP.Execute(ref this.Param, out DR)) {

				Status = false;
				if (DR.Read()) {

					if (!DR.IsDBNull(SPs.spS_UserList.Resultset1.Fields.Column_LoginName.ColumnIndex)) {

						this.col_LoginName = DR.GetSqlString(SPs.spS_UserList.Resultset1.Fields.Column_LoginName.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_UserList.Resultset1.Fields.Column_LoginPassword.ColumnIndex)) {

						this.col_LoginPassword = DR.GetSqlString(SPs.spS_UserList.Resultset1.Fields.Column_LoginPassword.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_UserList.Resultset1.Fields.Column_TransactionPassword.ColumnIndex)) {

						this.col_TransactionPassword = DR.GetSqlString(SPs.spS_UserList.Resultset1.Fields.Column_TransactionPassword.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_UserList.Resultset1.Fields.Column_AgentAccountId.ColumnIndex)) {

						this.col_AgentAccountId = DR.GetSqlGuid(SPs.spS_UserList.Resultset1.Fields.Column_AgentAccountId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_UserList.Resultset1.Fields.Column_AgentId.ColumnIndex)) {

						this.col_AgentId = DR.GetSqlGuid(SPs.spS_UserList.Resultset1.Fields.Column_AgentId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_UserList.Resultset1.Fields.Column_Email.ColumnIndex)) {

						this.col_Email = DR.GetSqlString(SPs.spS_UserList.Resultset1.Fields.Column_Email.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_UserList.Resultset1.Fields.Column_IsAgencyEmployee.ColumnIndex)) {

						this.col_IsAgencyEmployee = DR.GetSqlBoolean(SPs.spS_UserList.Resultset1.Fields.Column_IsAgencyEmployee.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_UserList.Resultset1.Fields.Column_CanBeEdited.ColumnIndex)) {

						this.col_CanBeEdited = DR.GetSqlBoolean(SPs.spS_UserList.Resultset1.Fields.Column_CanBeEdited.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_UserList.Resultset1.Fields.Column_Active.ColumnIndex)) {

						this.col_Active = DR.GetSqlBoolean(SPs.spS_UserList.Resultset1.Fields.Column_Active.ColumnIndex);
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

				throw new Evernet.MoneyExchange.DataClasses.CustomException(this.Param, "Evernet.MoneyExchange.AbstractClasses.Abstract_UserList", "Refresh");
			}
		}
	}
}
