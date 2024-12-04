﻿/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:47:47 PM
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
using Abstracts = Evernet.MoneyExchange.AbstractClasses;

[assembly:System.Web.UI.TagPrefix("Evernet.MoneyExchange.Web.CheckBoxLists", "mexchangeCheckBoxLists")]

namespace Evernet.MoneyExchange.Web.CheckBoxLists {

	/// <summary>
	/// This class derives from System.Web.UI.WebControls.CheckBoxList class and was built to display the 'TransactionSettlementStatusList' table content.
	/// </summary>
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[Evernet.MoneyExchange.DataClasses.OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:47", SqlObjectDependancyName="TransactionSettlementStatusList", SqlObjectDependancyRevision=208)]
#endif
	[System.Drawing.ToolboxBitmap(typeof(WebCheckBoxList_TransactionSettlementStatusList), "WebCheckBoxList.bmp")]
	public class WebCheckBoxList_TransactionSettlementStatusList : System.Web.UI.WebControls.CheckBoxList {

		private Params.spS_TransactionSettlementStatusList_Display param;
		private Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionSettlementStatusList oAbstract_TransactionSettlementStatusList;
		private string connectionString;
		private System.Data.SqlClient.SqlConnection sqlConnection;
		private Evernet.MoneyExchange.DataClasses.ConnectionType LastKnownConnectionType = Evernet.MoneyExchange.DataClasses.ConnectionType.None;
		private bool doDataBindAfterRefreshData = true;

		/// <summary>
		/// Returns the current type of connection that is going or has been used against the Sql Server database.
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
		public Params.spS_TransactionSettlementStatusList_Display SP_Parameter {

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
		/// Returns the 'TransactionSettlementStatusList' abstract class so that you can access any table
		/// column for the current record selection. When the selection has changed, you need to call the
		/// RefreshCurrentRecord method first before accessing this property.
		/// </summary>
		public Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionSettlementStatusList Abstract_TransactionSettlementStatusList {

			get {

				return(this.oAbstract_TransactionSettlementStatusList);
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
					
						arrayList.Add(Convert.ToString(currentItem.Value));
					}
				}
				
				return(arrayList);
			}
		}

		/// <summary>
		/// Disposes the current instance of this object.
		/// </summary>
		public override void Dispose() {

			this.oAbstract_TransactionSettlementStatusList = null;


			if (this.param != null) {

				this.param.Dispose();
			}

			base.Dispose();
		}

		/// <summary>
		/// Create a new instance of the Evernet.MoneyExchange.Web.CheckBoxLists.WebCheckBoxList_TransactionSettlementStatusList class.
		/// </summary>
		public WebCheckBoxList_TransactionSettlementStatusList() : base() {

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
		/// Initializes the control. You need to specify how to connect to the
		/// SQL Server database and if you want to populate the whole table content or
		/// only a subset (based on its foreign keys). The data will only be populated once
		/// you have called the RefreshData method.
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		public void Initialize(string connectionString) {

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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'TransactionSettlementStatusList'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "TransactionSettlementStatusList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
					}
				}
			}
#endif

		}

		/// <summary>
		/// Initializes the control. You need to specify how to connect to the
		/// SQL Server database and if you want to populate the whole table content or
		/// only a subset (based on its foreign keys). The data will only be populated once
		/// you have called the RefreshData method.
		/// </summary>
		/// <param name="sqlConnection">
		/// A valid System.Data.SqlClient.SqlConnection object. If it is not opened, it will be
		/// opened when used then closed again after the job is done.
		/// </param>
		public void Initialize(System.Data.SqlClient.SqlConnection sqlConnection) {

			if (sqlConnection == null) {

				throw new ArgumentNullException("sqlConnection", "Invalid connection!");
			}

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'TransactionSettlementStatusList'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "TransactionSettlementStatusList", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

		}

		/// <summary>
		/// Load or reloads all the table content. In order to successfully call this method,
		/// you need to call first the Initialize method.
		/// </summary>
		public void RefreshData() {

			this.RefreshData(new System.Data.SqlTypes.SqlString[0], -1, -1);
		}

		/// <summary>
		/// Load or reloads a subset of the table content. In order to successfully call this method, you need to call first
		/// the Initialize method.
		/// </summary>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		public void RefreshData(int startRecord, int maxRecords) {

			this.RefreshData(new System.Data.SqlTypes.SqlString[0], startRecord, maxRecords);
		}

		/// <summary>
		/// Load or reloads all the table content. You can specify which records you want to be checked by default.
		/// In order to successfully call this method, you need to call first the Initialize method.
		/// </summary>
		/// <param name="ArrayOf_PK_Value">Primary keys of the records you want to be checked by default.</param>
		public void RefreshData(System.Collections.ArrayList ArrayOf_PK_Value) {

			this.RefreshData(ArrayOf_PK_Value, -1, -1);
		}

		/// <summary>
		/// Load or reloads a subset of the table content. You can specify which record you want to be checked by default.
		/// In order to successfully call this method, you need to call first the Initialize method.
		/// </summary>
		/// <param name="ArrayOf_PK_Value">Primary keys of the records you want to be checked by default.</param>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		public void RefreshData(System.Collections.ArrayList ArrayOf_PK_Value, int startRecord, int maxRecords) {

			if (ArrayOf_PK_Value != null && ArrayOf_PK_Value.Count > 0) {

				System.Data.SqlTypes.SqlString[] typedArray = new System.Data.SqlTypes.SqlString[ArrayOf_PK_Value.Count];
				int index = 0;
				foreach(object item in ArrayOf_PK_Value) {

					if (item is System.Data.SqlTypes.SqlString) {

						typedArray[index] = (System.Data.SqlTypes.SqlString)item;
						index++;
					}
					else if (item is System.String) {

						typedArray[index] = (System.String)item;
						index++;
					}
					else {

						throw new InvalidOperationException("ArrayOf_PK_Value does not contain ONLY System.Data.SqlTypes.SqlString or System.String elements.");
					}
				}
				this.RefreshData(typedArray, startRecord, maxRecords);
			}
			else {

				this.RefreshData(startRecord, maxRecords);
			}
		}

		/// <summary>
		/// Load or reloads all the table content. You can specify which records you want to be checked by default.
		/// In order to successfully call this method, you need to call first the Initialize method.
		/// </summary>
		/// <param name="ArrayOf_PK_Value">Primary keys of the records you want to be checked by default.</param>
		public void RefreshData(System.Data.SqlTypes.SqlString[] ArrayOf_PK_Value) {

			this.RefreshData(ArrayOf_PK_Value, -1, -1);
		}

		/// <summary>
		/// Load or reloads all the table content. You can specify which records you want to be checked by default.
		/// In order to successfully call this method, you need to call first the Initialize method.
		/// </summary>
		/// <param name="ArrayOf_PK_Value">Primary keys of the records you want to be checked by default.</param>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		public void RefreshData(System.Data.SqlTypes.SqlString[] ArrayOf_PK_Value, int startRecord, int maxRecords) {

			this.param = new Params.spS_TransactionSettlementStatusList_Display(true);

			switch (this.LastKnownConnectionType) {

 				case Evernet.MoneyExchange.DataClasses.ConnectionType.ConnectionString:
					this.param.SetUpConnection(this.connectionString);
					break;

 				case Evernet.MoneyExchange.DataClasses.ConnectionType.SqlConnection:
					this.param.SetUpConnection(this.sqlConnection);
					break;

				default:
					throw new InvalidOperationException("This control has not been initialized. You must call the Initialize method before calling this method.");
			}

			this.param.CommandTimeOut = this.commandTimeOut;

			System.Data.DataSet DS = null;
			
			SPs.spS_TransactionSettlementStatusList_Display SP = new SPs.spS_TransactionSettlementStatusList_Display(false);

			if (SP.Execute(ref this.param, ref DS, startRecord, maxRecords)) {

				this.DataSource = DS.Tables["spS_TransactionSettlementStatusList_Display"].DefaultView;
				this.DataValueField = SPs.spS_TransactionSettlementStatusList_Display.Resultset1.Fields.Column_ID1.ColumnName;
				this.DataTextField = SPs.spS_TransactionSettlementStatusList_Display.Resultset1.Fields.Column_Display.ColumnName;
				if (this.doDataBindAfterRefreshData) {

					this.DataBind();
				}

				if (ArrayOf_PK_Value != null) {

					this.SetRecordsChecked(ArrayOf_PK_Value, true);
				}
			}
			else {

				SP.Dispose();
				throw new Evernet.MoneyExchange.DataClasses.CustomException(this.param, "WebCheckBoxList_TransactionSettlementStatusList : System.Web.UI.WebControls.CheckBoxList", "RefreshData");
			}

		}
		/// <summary>
		/// Sets the supplied collection records to a given selected status.
		/// </summary>
		/// <param name="ArrayOf_PK_Value">Primary keys of the records to set the check state for.</param>
		/// <param name="value">True if the records must be checked. Otherwise False.</param>
		public void SetRecordsChecked(System.Collections.ArrayList ArrayOf_PK_Value, bool value) {
		
			if (ArrayOf_PK_Value != null && ArrayOf_PK_Value.Count > 0) {

				System.Data.SqlTypes.SqlString[] typedArray = new System.Data.SqlTypes.SqlString[ArrayOf_PK_Value.Count];
				int index = 0;
				foreach(object item in ArrayOf_PK_Value) {

					if (item is System.Data.SqlTypes.SqlString) {

						typedArray[index] = (System.Data.SqlTypes.SqlString)item;
						index++;
					}
					else if (item is System.String) {

						typedArray[index] = (System.String)item;
						index++;
					}
					else {

						throw new InvalidOperationException("ArrayOf_PK_Value does not contain ONLY System.Data.SqlTypes.SqlString or System.String elements.");
					}
				}
				this.SetRecordsChecked(typedArray, value);
			}
		}

		/// <summary>
		/// Sets the supplied collection records to a given selected status.
		/// </summary>
		/// <param name="ArrayOf_PK_Value">Primary keys of the records to set the check state for.</param>
		/// <param name="value">True if the records must be checked. Otherwise False.</param>
		public void SetRecordsChecked(System.Data.SqlTypes.SqlString[] ArrayOf_PK_Value, bool value) {

			this.ClearSelection();

			if (ArrayOf_PK_Value != null) {

				foreach (System.Data.SqlTypes.SqlString PK_Value in ArrayOf_PK_Value) {

					System.Web.UI.WebControls.ListItem listItem = this.Items.FindByValue(PK_Value.Value.ToString());
					if (listItem != null) {

						listItem.Selected = value;
					}
				}
			}
		}


		/// <summary>
		/// Loads the TransactionSettlementStatusList abstract class for the current selected record primary key.
		/// </summary>
		/// <returns>true if the call succeeded; false, otherwise.</returns>
		public bool RefreshCurrentRecord() {

			if (this.SelectedIndex == -1) {

				if (oAbstract_TransactionSettlementStatusList != null) {

					oAbstract_TransactionSettlementStatusList.Reset();
				}
				return(false);
			}

			System.Data.SqlTypes.SqlString PK_Value = Convert.ToString(this.SelectedItem.Value);

			if (this.oAbstract_TransactionSettlementStatusList == null) {

				switch (this.LastKnownConnectionType) {

					case Evernet.MoneyExchange.DataClasses.ConnectionType.ConnectionString:
							this.oAbstract_TransactionSettlementStatusList = new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionSettlementStatusList(this.connectionString);
						break;

					case Evernet.MoneyExchange.DataClasses.ConnectionType.SqlConnection:
							this.oAbstract_TransactionSettlementStatusList = new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionSettlementStatusList(this.sqlConnection);
						break;
				}
			}

			return(this.oAbstract_TransactionSettlementStatusList.Refresh(PK_Value));
		}
	}
}
