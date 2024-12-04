﻿/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:48:46 PM
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
using SPs = Evernet.MoneyExchange.DataClasses.StoredProcedures;
using Params = Evernet.MoneyExchange.DataClasses.Parameters;

[assembly:System.Web.UI.TagPrefix("Evernet.MoneyExchange.Web.CheckBoxLists", "mexchangeCheckBoxLists")]

namespace Evernet.MoneyExchange.Web.CheckBoxLists {

	/// <summary>
	/// This class is based on a System.Web.UI.WebControls.CheckBoxList class and was built to display
	/// the resultset returned back by the
	/// 'spS_CountryAvailablePaymentModeList_Full' stored procedure.
	/// </summary>
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[Evernet.MoneyExchange.DataClasses.OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:48:46", SqlObjectDependancyName="spS_CountryAvailablePaymentModeList_Full", SqlObjectDependancyRevision=0)]
#endif
	[System.Drawing.ToolboxBitmap(typeof(WebCheckBoxListCustom_spS_CountryAvailablePaymentModeList_Full), "WebCheckBoxList.bmp")]
	public class WebCheckBoxListCustom_spS_CountryAvailablePaymentModeList_Full : System.Web.UI.WebControls.CheckBoxList {

		private string valueMember;
		private string displayMember;
		private string tableName;
		private Params.spS_CountryAvailablePaymentModeList_Full param;
		private System.Data.SqlTypes.SqlGuid param_Id = System.Data.SqlTypes.SqlGuid.Null;
		private System.Data.SqlTypes.SqlGuid param_CountryId = System.Data.SqlTypes.SqlGuid.Null;
		private System.Data.SqlTypes.SqlString param_PaymentMode = System.Data.SqlTypes.SqlString.Null;
		private string connectionString;
		private System.Data.SqlClient.SqlConnection sqlConnection;
		private Evernet.MoneyExchange.DataClasses.ConnectionType LastKnownConnectionType = Evernet.MoneyExchange.DataClasses.ConnectionType.None;
		private bool doDataBindAfterRefreshData = true;

		/// <summary>
		/// Returns the current type of connection that is going
		/// or has been used against the Sql Server database.
		/// </summary>
		public Evernet.MoneyExchange.DataClasses.ConnectionType ConnectionType {

			get {

				return(this.LastKnownConnectionType);
			}
		}

		/// <summary>
		/// Returns the connection string used to access the Sql Server database.
		/// </summary>
		public string ConnectionString {

			get {

				if (this.LastKnownConnectionType != Evernet.MoneyExchange.DataClasses.ConnectionType.ConnectionString) {

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

				if (this.LastKnownConnectionType != Evernet.MoneyExchange.DataClasses.ConnectionType.SqlConnection) {

					throw new InvalidOperationException("The SqlConnection was not set in the class constructor.");
				}

				return(this.sqlConnection );
			}
		}

		/// <summary>
		/// Returns the Parameter class that was used to populate this control.
		/// </summary>
		public Params.spS_CountryAvailablePaymentModeList_Full SP_Parameter {

			get {

				return(this.param);
			}
		}

		private int commandTimeOut = 30;
		/// <summary>
		/// Gets or sets the command timeout for the underlying stored procedure execution (default is 30 seconds)
		/// </summary>
		public int CommandTimeOut {

			get {

				return(this.commandTimeOut);
			}
			set {

				this.commandTimeOut = value;
			}
		}

		/// <summary>
		/// Returns an array of the currently checked records primary keys.
		/// </summary>
		public System.Collections.ArrayList CheckedRecordsID {

			get {
						
				System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
				
				foreach(System.Web.UI.WebControls.ListItem currentItem in this.Items) {
				
					if (currentItem.Selected) {
					
						arrayList.Add(currentItem.Value);
					}
				}
				
				return(arrayList);
			}
		}

		/// <summary>
		/// Disposes the current instance of this object.
		/// </summary>
		public override void Dispose() {

			this.param_Id = System.Data.SqlTypes.SqlGuid.Null;
			this.param_CountryId = System.Data.SqlTypes.SqlGuid.Null;
			this.param_PaymentMode = System.Data.SqlTypes.SqlString.Null;
			if (this.param != null) {

				this.param.Dispose();
			}

			base.Dispose();
		}

		/// <summary>
		/// Create a new instance of the WebCheckBoxListCustom_spS_CountryAvailablePaymentModeList_Full class.
		/// </summary>
		public WebCheckBoxListCustom_spS_CountryAvailablePaymentModeList_Full() : base() {

		}

		/// <summary>
		/// Gets or sets the databinding behavior after the RefreshData method is called. True if DataBind has to be called after
		/// RefreshData call, False if not.
		/// </summary>
		public bool DoDataBindAfterRefreshData {

			get {

				return(this.doDataBindAfterRefreshData);
			}

			set {

				this.doDataBindAfterRefreshData = value;
			}
		}

		/// <summary>
		/// Initializes the control. You need to specify how to connect to the SQL Server database.
		/// You also need to supply the 'spS_CountryAvailablePaymentModeList_Full' stored procedure parameters.
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		/// <param name="valueMember">name of the field to be used as a primary key.</param>
		/// <param name="displayMember">name of the field to be used for the content display.</param>
		/// <param name="tableName">name of the table to use to populate the control.</param>
		/// <param name="param_Id">Value for the parameter @Id.</param>
		/// <param name="param_CountryId">Value for the parameter @CountryId.</param>
		/// <param name="param_PaymentMode">Value for the parameter @PaymentMode.</param>
		public void Initialize(string connectionString, string valueMember, string displayMember, string tableName, System.Data.SqlTypes.SqlGuid param_Id, System.Data.SqlTypes.SqlGuid param_CountryId, System.Data.SqlTypes.SqlString param_PaymentMode) {

			if (connectionString == null) {

				throw new ArgumentNullException("connectionString", "connectionString can be an empty string but can not be null.");
			}

			this.connectionString = connectionString;
			this.LastKnownConnectionType = Evernet.MoneyExchange.DataClasses.ConnectionType.ConnectionString;

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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spS_CountryAvailablePaymentModeList_Full'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spS_CountryAvailablePaymentModeList_Full", CurrentRevision, OriginalRevision, System.Environment.NewLine));
					}
				}
			}
#endif

			this.valueMember = valueMember;
			this.displayMember = displayMember;
			this.tableName = tableName;

			this.param_Id = param_Id;
			this.param_CountryId = param_CountryId;
			this.param_PaymentMode = param_PaymentMode;
		}

		/// <summary>
		/// Initializes the control. You need to specify how to connect to the SQL Server database.
		/// You also need to supply the 'spS_CountryAvailablePaymentModeList_Full' stored procedure parameters.
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		/// <param name="valueMember">name of the field to be used as a primary key.</param>
		/// <param name="displayMember">name of the field to be used for the content display.</param>
		/// <param name="param_Id">Value for the parameter @Id.</param>
		/// <param name="param_CountryId">Value for the parameter @CountryId.</param>
		/// <param name="param_PaymentMode">Value for the parameter @PaymentMode.</param>
		public void Initialize(string connectionString, string valueMember, string displayMember, System.Data.SqlTypes.SqlGuid param_Id, System.Data.SqlTypes.SqlGuid param_CountryId, System.Data.SqlTypes.SqlString param_PaymentMode) {

			if (connectionString == null) {

				throw new ArgumentNullException("connectionString", "connectionString can be an empty string but can not be null.");
			}

			this.connectionString = connectionString;
			this.LastKnownConnectionType = Evernet.MoneyExchange.DataClasses.ConnectionType.ConnectionString;

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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spS_CountryAvailablePaymentModeList_Full'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spS_CountryAvailablePaymentModeList_Full", CurrentRevision, OriginalRevision, System.Environment.NewLine));
					}
				}
			}
#endif

			this.valueMember = valueMember;
			this.displayMember = displayMember;
			this.tableName = "spS_CountryAvailablePaymentModeList_Full";

			this.param_Id = param_Id;
			this.param_CountryId = param_CountryId;
			this.param_PaymentMode = param_PaymentMode;
		}

		/// <summary>
		/// Initializes the control. You need to specify how to connect to the SQL Server database.
		/// You also need to supply the 'spS_CountryAvailablePaymentModeList_Full' stored procedure parameters.
		/// </summary>
		/// <param name="sqlConnection">A valid SqlConnection object. If it is not opened, it will be opened when used then closed again after the job is done.</param>
		/// <param name="valueMember">name of the field to be used as a primary key.</param>
		/// <param name="displayMember">name of the field to be used for the content display.</param>
		/// <param name="tableName">name of the table to use to populate the control.</param>
		/// <param name="param_Id">Value for the parameter @Id.</param>
		/// <param name="param_CountryId">Value for the parameter @CountryId.</param>
		/// <param name="param_PaymentMode">Value for the parameter @PaymentMode.</param>
		public void Initialize(System.Data.SqlClient.SqlConnection sqlConnection, string valueMember, string displayMember, string tableName, System.Data.SqlTypes.SqlGuid param_Id, System.Data.SqlTypes.SqlGuid param_CountryId, System.Data.SqlTypes.SqlString param_PaymentMode) {

			this.sqlConnection = sqlConnection;
			this.LastKnownConnectionType = Evernet.MoneyExchange.DataClasses.ConnectionType.SqlConnection;

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spS_CountryAvailablePaymentModeList_Full'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spS_CountryAvailablePaymentModeList_Full", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.valueMember = valueMember;
			this.displayMember = displayMember;
			this.tableName = tableName;

			this.param_Id = param_Id;
			this.param_CountryId = param_CountryId;
			this.param_PaymentMode = param_PaymentMode;
		}

		/// <summary>
		/// Initializes the control. You need to specify how to connect to the SQL Server database.
		/// You also need to supply the 'spS_CountryAvailablePaymentModeList_Full' stored procedure parameters.
		/// </summary>
		/// <param name="sqlConnection">A valid SqlConnection object. If it is not opened, it will be opened when used then closed again after the job is done.</param>
		/// <param name="valueMember">name of the field to be used as a primary key.</param>
		/// <param name="displayMember">name of the field to be used for the content display.</param>
		/// <param name="param_Id">Value for the parameter @Id.</param>
		/// <param name="param_CountryId">Value for the parameter @CountryId.</param>
		/// <param name="param_PaymentMode">Value for the parameter @PaymentMode.</param>
		public void Initialize(System.Data.SqlClient.SqlConnection sqlConnection, string valueMember, string displayMember, System.Data.SqlTypes.SqlGuid param_Id, System.Data.SqlTypes.SqlGuid param_CountryId, System.Data.SqlTypes.SqlString param_PaymentMode) {

			this.sqlConnection = sqlConnection;
			this.LastKnownConnectionType = Evernet.MoneyExchange.DataClasses.ConnectionType.SqlConnection;

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'spS_CountryAvailablePaymentModeList_Full'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "spS_CountryAvailablePaymentModeList_Full", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.valueMember = valueMember;
			this.displayMember = displayMember;
			this.tableName = "spS_CountryAvailablePaymentModeList_Full";

			this.param_Id = param_Id;
			this.param_CountryId = param_CountryId;
			this.param_PaymentMode = param_PaymentMode;
		}

		/// <summary>
		/// Load or reloads the chosen resultset returned by the stored procedure.
		/// In order to successfully call this method, you need to call first the Initialize method.
		/// </summary>
		public void RefreshData() {

			this.RefreshData(new object[0], -1, -1);
		}

		/// <summary>
		/// Load or reloads a subset of the chosen resultset returned by the stored procedure.
		/// In order to successfully call this method, you need to call first the Initialize method.
		/// </summary>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		public void RefreshData(int startRecord, int maxRecords) {

			this.RefreshData(new object[0], startRecord, maxRecords);
		}

		/// <summary>
		/// Load or reloads the chosen resultset returned by the stored procedure.
		/// In order to successfully call this method, you need to call first the Initialize method.
		/// </summary>
		/// <param name="ArrayOf_PrimaryKeys">Primary keys of the records you want to be checked by default.</param>
		public void RefreshData(System.Collections.ArrayList ArrayOf_PrimaryKeys) {

			this.RefreshData(ArrayOf_PrimaryKeys, -1, -1);
		}

		/// <summary>
		/// Load or reloads a subset of the chosen resultset returned by the stored procedure.
		/// You can specify which record you want to be checked by default.
		/// </summary>
		/// <param name="ArrayOf_PrimaryKeys">Primary keys of the records you want to be checked by default.</param>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		public void RefreshData(System.Collections.ArrayList ArrayOf_PrimaryKeys, int startRecord, int maxRecords) {

			if (ArrayOf_PrimaryKeys != null && ArrayOf_PrimaryKeys.Count > 0) {

				object[] typedArray = new object[ArrayOf_PrimaryKeys.Count];
				int index = 0;
				foreach(object item in ArrayOf_PrimaryKeys) {

					typedArray[index] = item;
					index++;
				}
				this.RefreshData(typedArray, startRecord, maxRecords);
			}
			else {

				this.RefreshData(startRecord, maxRecords);
			}
		}

		/// <summary>
		/// Load or reloads the chosen resultset returned by the stored procedure.
		/// In order to successfully call this method, you need to call first the Initialize method.
		/// </summary>
		/// <param name="ArrayOf_PrimaryKeys">Primary keys of the records you want to be checked by default.</param>
		public void RefreshData(object[] ArrayOf_PrimaryKeys) {

			this.RefreshData(ArrayOf_PrimaryKeys, -1, -1);
		}

		/// <summary>
		/// Load or reloads a subset of the chosen resultset returned by the stored procedure.
		/// You can specify which record you want to be checked by default.
		/// </summary>
		/// <param name="ArrayOf_PrimaryKeys">Primary keys of the records you want to be checked by default.</param>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		public void RefreshData(object[] ArrayOf_PrimaryKeys, int startRecord, int maxRecords) {

			if (this.LastKnownConnectionType == Evernet.MoneyExchange.DataClasses.ConnectionType.None) {

				throw new InvalidOperationException("You must call the 'Initialize' method before calling this method.");
			}

			this.param = new Params.spS_CountryAvailablePaymentModeList_Full();

			switch (this.LastKnownConnectionType) {

 				case Evernet.MoneyExchange.DataClasses.ConnectionType.ConnectionString:
					this.param.SetUpConnection(this.connectionString);
					break;

 				case Evernet.MoneyExchange.DataClasses.ConnectionType.SqlConnection:
					this.param.SetUpConnection(this.sqlConnection);
					break;
			}

			this.param.CommandTimeOut = this.commandTimeOut;


			if (!this.param_Id.IsNull) {

				this.param.Param_Id = this.param_Id;
			}


			if (!this.param_CountryId.IsNull) {

				this.param.Param_CountryId = this.param_CountryId;
			}


			if (!this.param_PaymentMode.IsNull) {

				this.param.Param_PaymentMode = this.param_PaymentMode;
			}


			System.Data.DataSet DS = null;
			
			SPs.spS_CountryAvailablePaymentModeList_Full SP = new SPs.spS_CountryAvailablePaymentModeList_Full();
			if (SP.Execute(ref this.param, ref DS, startRecord, maxRecords)) {

				this.DataSource = DS.Tables[this.tableName].DefaultView;
				this.DataValueField = this.valueMember;
				this.DataTextField = this.displayMember;
				if (this.doDataBindAfterRefreshData) {

					this.DataBind();
				}

				if (ArrayOf_PrimaryKeys != null) {

					this.SetRecordsChecked(ArrayOf_PrimaryKeys, true);
				}

			}

			else {

				SP.Dispose();
				throw new Evernet.MoneyExchange.DataClasses.CustomException(this.param, "WebCheckBoxListCustom_spS_CountryAvailablePaymentModeList_Full", "RefreshData");
			}

		}
		/// <summary>
		/// Sets the supplied collection records to a given selected status.
		/// </summary>
		/// <param name="ArrayOf_PrimaryKeys">Primary keys of the records to set the check state for.</param>
		/// <param name="value">True if the records must be checked. Otherwise False.</param>
		public void SetRecordsChecked(System.Collections.ArrayList ArrayOf_PrimaryKeys, bool value) {
		
			if (ArrayOf_PrimaryKeys != null && ArrayOf_PrimaryKeys.Count > 0) {

				object[] typedArray = new object[ArrayOf_PrimaryKeys.Count];
				int index = 0;
				foreach(object item in ArrayOf_PrimaryKeys) {

					typedArray[index] = item;
					index++;
				}
				this.SetRecordsChecked(typedArray, value);
			}
		}

		/// <summary>
		/// Sets the supplied collection records to a given selected status.
		/// </summary>
		/// <param name="ArrayOf_PrimaryKeys">Primary keys of the records to set the check state for.</param>
		/// <param name="value">True if the records must be checked. Otherwise False.</param>
		public void SetRecordsChecked(object[] ArrayOf_PrimaryKeys, bool value) {

			this.ClearSelection();

			if (ArrayOf_PrimaryKeys != null) {

				foreach (object PrimaryKey in ArrayOf_PrimaryKeys) {

					System.Web.UI.WebControls.ListItem listItem = this.Items.FindByValue(PrimaryKey.ToString());
					if (listItem != null) {

						listItem.Selected = value;
					}
				}
			}
		}
	}
}
