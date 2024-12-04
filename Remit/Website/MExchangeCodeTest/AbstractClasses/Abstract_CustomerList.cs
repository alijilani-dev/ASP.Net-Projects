/*
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
	/// This class allows you to very easily retrieve a record from the [CustomerList] table.
	/// </summary>
	[Serializable()]
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[Evernet.MoneyExchange.DataClasses.OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:31", SqlObjectDependancyName="CustomerList", SqlObjectDependancyRevision=1984)]
#endif
	public class Abstract_CustomerList {

		Params.spS_CustomerList Param;
		private bool CloseConnectionAfterUse = true;

		/// <summary>
		/// Create a new instance of the Abstract_CustomerList class.
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		public Abstract_CustomerList(string connectionString) {

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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'CustomerList'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "CustomerList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
					}
				}
			}
#endif

			this.Param = new Params.spS_CustomerList(true);
			this.Param.SetUpConnection(connectionString);
		}

		/// <summary>
		/// Create a new instance of the Abstract_CustomerList class.
		/// </summary>
		/// <param name="sqlConnection">A valid System.Data.SqlClient.SqlConnection to the database.</param>
		public Abstract_CustomerList(System.Data.SqlClient.SqlConnection sqlConnection) {

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'CustomerList'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "CustomerList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.Param = new Params.spS_CustomerList(true);
			this.Param.SetUpConnection(sqlConnection);
			CloseConnectionAfterUse = (this.Param.SqlConnection.State != System.Data.ConnectionState.Open);
		}

		/// <summary>
		/// Create a new instance of the Abstract_CustomerList class.
		/// </summary>
		/// <param name="sqlTransaction">A valid System.Data.SqlClient.SqlTransaction to the database.</param>
		public Abstract_CustomerList(System.Data.SqlClient.SqlTransaction sqlTransaction) {

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'CustomerList'";
				sqlCommand.Transaction = sqlTransaction;

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlTransaction.Connection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "CustomerList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.Param = new Params.spS_CustomerList(true);
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

		private System.Data.SqlTypes.SqlString col_Password;
		/// <summary>
		/// Returns the value of the Password column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_Password {

			get {

				return (this.col_Password);
			}
		}

		private System.Data.SqlTypes.SqlString col_FirstName;
		/// <summary>
		/// Returns the value of the FirstName column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_FirstName {

			get {

				return (this.col_FirstName);
			}
		}

		private System.Data.SqlTypes.SqlString col_LastName;
		/// <summary>
		/// Returns the value of the LastName column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_LastName {

			get {

				return (this.col_LastName);
			}
		}

		private System.Data.SqlTypes.SqlGuid col_CardId;
		/// <summary>
		/// Returns the value of the CardId column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlGuid Col_CardId {

			get {

				return (this.col_CardId);
			}
		}

		private System.Data.SqlTypes.SqlString col_Address;
		/// <summary>
		/// Returns the value of the Address column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_Address {

			get {

				return (this.col_Address);
			}
		}

		private System.Data.SqlTypes.SqlString col_Telephone;
		/// <summary>
		/// Returns the value of the Telephone column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_Telephone {

			get {

				return (this.col_Telephone);
			}
		}

		private System.Data.SqlTypes.SqlString col_Fax;
		/// <summary>
		/// Returns the value of the Fax column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_Fax {

			get {

				return (this.col_Fax);
			}
		}

		private System.Data.SqlTypes.SqlString col_Mobile;
		/// <summary>
		/// Returns the value of the Mobile column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_Mobile {

			get {

				return (this.col_Mobile);
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

		private System.Data.SqlTypes.SqlString col_IDType;
		/// <summary>
		/// Returns the value of the IDType column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_IDType {

			get {

				return (this.col_IDType);
			}
		}

		private System.Data.SqlTypes.SqlString col_IDDetails;
		/// <summary>
		/// Returns the value of the IDDetails column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_IDDetails {

			get {

				return (this.col_IDDetails);
			}
		}

		private System.Data.SqlTypes.SqlDateTime col_IDExpirationDate;
		/// <summary>
		/// Returns the value of the IDExpirationDate column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlDateTime Col_IDExpirationDate {

			get {

				return (this.col_IDExpirationDate);
			}
		}

		private System.Data.SqlTypes.SqlString col_Nationality;
		/// <summary>
		/// Returns the value of the Nationality column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlString Col_Nationality {

			get {

				return (this.col_Nationality);
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

		private System.Data.SqlTypes.SqlBoolean col_AccountActivated;
		/// <summary>
		/// Returns the value of the AccountActivated column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlBoolean Col_AccountActivated {

			get {

				return (this.col_AccountActivated);
			}
		}

		private System.Data.SqlTypes.SqlBoolean col_CardIssued;
		/// <summary>
		/// Returns the value of the CardIssued column.
		/// More info on this column: 
		/// </summary>
		public System.Data.SqlTypes.SqlBoolean Col_CardIssued {

			get {

				return (this.col_CardIssued);
			}
		}

		/// <summary>
		/// This method allows to clear all the properties previously loaded by a call to the Refresh method.
		/// </summary>
		public void Reset() {

			this.col_Id = System.Data.SqlTypes.SqlGuid.Null;
			this.col_LoginName = System.Data.SqlTypes.SqlString.Null;
			this.col_Password = System.Data.SqlTypes.SqlString.Null;
			this.col_FirstName = System.Data.SqlTypes.SqlString.Null;
			this.col_LastName = System.Data.SqlTypes.SqlString.Null;
			this.col_CardId = System.Data.SqlTypes.SqlGuid.Null;
			this.col_Address = System.Data.SqlTypes.SqlString.Null;
			this.col_Telephone = System.Data.SqlTypes.SqlString.Null;
			this.col_Fax = System.Data.SqlTypes.SqlString.Null;
			this.col_Mobile = System.Data.SqlTypes.SqlString.Null;
			this.col_Email = System.Data.SqlTypes.SqlString.Null;
			this.col_IDType = System.Data.SqlTypes.SqlString.Null;
			this.col_IDDetails = System.Data.SqlTypes.SqlString.Null;
			this.col_IDExpirationDate = System.Data.SqlTypes.SqlDateTime.Null;
			this.col_Nationality = System.Data.SqlTypes.SqlString.Null;
			this.col_Active = System.Data.SqlTypes.SqlBoolean.Null;
			this.col_AccountActivated = System.Data.SqlTypes.SqlBoolean.Null;
			this.col_CardIssued = System.Data.SqlTypes.SqlBoolean.Null;
		}

		/// <summary>
		/// Allows you to load a specific record of the [CustomerList] table.
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
			SPs.spS_CustomerList SP = new SPs.spS_CustomerList(false);

			if (SP.Execute(ref this.Param, out DR)) {

				Status = false;
				if (DR.Read()) {

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_LoginName.ColumnIndex)) {

						this.col_LoginName = DR.GetSqlString(SPs.spS_CustomerList.Resultset1.Fields.Column_LoginName.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_Password.ColumnIndex)) {

						this.col_Password = DR.GetSqlString(SPs.spS_CustomerList.Resultset1.Fields.Column_Password.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_FirstName.ColumnIndex)) {

						this.col_FirstName = DR.GetSqlString(SPs.spS_CustomerList.Resultset1.Fields.Column_FirstName.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_LastName.ColumnIndex)) {

						this.col_LastName = DR.GetSqlString(SPs.spS_CustomerList.Resultset1.Fields.Column_LastName.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_CardId.ColumnIndex)) {

						this.col_CardId = DR.GetSqlGuid(SPs.spS_CustomerList.Resultset1.Fields.Column_CardId.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_Address.ColumnIndex)) {

						this.col_Address = DR.GetSqlString(SPs.spS_CustomerList.Resultset1.Fields.Column_Address.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_Telephone.ColumnIndex)) {

						this.col_Telephone = DR.GetSqlString(SPs.spS_CustomerList.Resultset1.Fields.Column_Telephone.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_Fax.ColumnIndex)) {

						this.col_Fax = DR.GetSqlString(SPs.spS_CustomerList.Resultset1.Fields.Column_Fax.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_Mobile.ColumnIndex)) {

						this.col_Mobile = DR.GetSqlString(SPs.spS_CustomerList.Resultset1.Fields.Column_Mobile.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_Email.ColumnIndex)) {

						this.col_Email = DR.GetSqlString(SPs.spS_CustomerList.Resultset1.Fields.Column_Email.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_IDType.ColumnIndex)) {

						this.col_IDType = DR.GetSqlString(SPs.spS_CustomerList.Resultset1.Fields.Column_IDType.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_IDDetails.ColumnIndex)) {

						this.col_IDDetails = DR.GetSqlString(SPs.spS_CustomerList.Resultset1.Fields.Column_IDDetails.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_IDExpirationDate.ColumnIndex)) {

						this.col_IDExpirationDate = DR.GetSqlDateTime(SPs.spS_CustomerList.Resultset1.Fields.Column_IDExpirationDate.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_Nationality.ColumnIndex)) {

						this.col_Nationality = DR.GetSqlString(SPs.spS_CustomerList.Resultset1.Fields.Column_Nationality.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_Active.ColumnIndex)) {

						this.col_Active = DR.GetSqlBoolean(SPs.spS_CustomerList.Resultset1.Fields.Column_Active.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_AccountActivated.ColumnIndex)) {

						this.col_AccountActivated = DR.GetSqlBoolean(SPs.spS_CustomerList.Resultset1.Fields.Column_AccountActivated.ColumnIndex);
					}

					if (!DR.IsDBNull(SPs.spS_CustomerList.Resultset1.Fields.Column_CardIssued.ColumnIndex)) {

						this.col_CardIssued = DR.GetSqlBoolean(SPs.spS_CustomerList.Resultset1.Fields.Column_CardIssued.ColumnIndex);
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

				throw new Evernet.MoneyExchange.DataClasses.CustomException(this.Param, "Evernet.MoneyExchange.AbstractClasses.Abstract_CustomerList", "Refresh");
			}
		}
	}
}
