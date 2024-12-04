﻿/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:47:49 PM
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

[assembly:System.Web.UI.TagPrefix("Evernet.MoneyExchange.Web.Repeaters", "mexchangeRepeaters")]


namespace Evernet.MoneyExchange.Web.Repeaters {

	/// <summary>
	/// This class is based on a System.Web.UI.WebControls.Repeater class and was built to display the 'CustomerLoyaltyPointsAccumulationHistory' table content.
	/// </summary>
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[Evernet.MoneyExchange.DataClasses.OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:49", SqlObjectDependancyName="CustomerLoyaltyPointsAccumulationHistory", SqlObjectDependancyRevision=640)]
#endif
	[System.Drawing.ToolboxBitmap(typeof(WebRepeater_CustomerLoyaltyPointsAccumulationHistory), "WebRepeater.bmp")]
	public class WebRepeater_CustomerLoyaltyPointsAccumulationHistory : System.Web.UI.WebControls.Repeater {

		private Params.spS_CustomerLoyaltyPointsAccumulationHistory param;
		private System.Data.SqlTypes.SqlGuid FK_CustomerId = System.Data.SqlTypes.SqlGuid.Null;
		private System.Data.SqlTypes.SqlGuid FK_TransactionId = System.Data.SqlTypes.SqlGuid.Null;
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
		/// Returns the Evernet.MoneyExchange.DataClasses.Parameters.spS_CustomerLoyaltyPointsAccumulationHistory class that was used to populate this control.
		/// </summary>
		public Params.spS_CustomerLoyaltyPointsAccumulationHistory SP_Parameter {

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
		/// Disposes the current instance of this object.
		/// </summary>
		public override void Dispose() {

			this.FK_CustomerId = System.Data.SqlTypes.SqlGuid.Null;
			this.FK_TransactionId = System.Data.SqlTypes.SqlGuid.Null;

			if (this.param != null) {

				this.param.Dispose();
			}

			base.Dispose();
		}

		/// <summary>
		/// Create a new instance of the Evernet.MoneyExchange.Web.Repeaters.WebRepeater_CustomerLoyaltyPointsAccumulationHistory class.
		/// </summary>
		public WebRepeater_CustomerLoyaltyPointsAccumulationHistory() : base() {

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
		/// Initializes the control. You need to specify how to connect to the SQL Server database and if you want to populate the whole table content
		/// or only a subset (based on its foreign keys).
		/// </summary>
		/// <param name="connectionString">A valid connection string to the database.</param>
		/// <param name="FK_CustomerId">Value for this foreign key.</param>
		/// <param name="FK_TransactionId">Value for this foreign key.</param>
		public void Initialize(string connectionString, System.Data.SqlTypes.SqlGuid FK_CustomerId, System.Data.SqlTypes.SqlGuid FK_TransactionId) {

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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'CustomerLoyaltyPointsAccumulationHistory'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "CustomerLoyaltyPointsAccumulationHistory", CurrentRevision, OriginalRevision, System.Environment.NewLine));
					}
				}
			}
#endif

			this.FK_CustomerId = FK_CustomerId;
			this.FK_TransactionId = FK_TransactionId;
		}

		/// <summary>
		/// Initializes the control. You need to specify how to connect to the SQL Server database and if you want to populate the whole table content
		/// or only a subset (based on its foreign keys).
		/// </summary>
		/// <param name="sqlConnection">A valid SqlConnection object.
		/// If it is not opened, it will be opened when used then closed again after the job is done.</param>
		/// <param name="FK_CustomerId">Value for this foreign key.</param>
		/// <param name="FK_TransactionId">Value for this foreign key.</param>
		public void Initialize(System.Data.SqlClient.SqlConnection sqlConnection, System.Data.SqlTypes.SqlGuid FK_CustomerId, System.Data.SqlTypes.SqlGuid FK_TransactionId) {

			this.sqlConnection= sqlConnection;
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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'CustomerLoyaltyPointsAccumulationHistory'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "CustomerLoyaltyPointsAccumulationHistory", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.FK_CustomerId = FK_CustomerId;
			this.FK_TransactionId = FK_TransactionId;
		}

		/// <summary>
		/// Load or reloads all the table content.
		/// In order to successfully call this method, you need to call first the Initialize method.
		/// </summary>
		public void RefreshData() {

			this.RefreshData(-1, -1);
		}

		/// <summary>
		/// Load or reloads a subset of the table content. In order to successfully call this method, you need to call first
		/// the Initialize method.
		/// </summary>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		public void RefreshData(int startRecord, int maxRecords) {

			if (this.LastKnownConnectionType == Evernet.MoneyExchange.DataClasses.ConnectionType.None) {

				throw new InvalidOperationException("You must call the 'Initialize' method before calling this method.");
			}

			this.param = new Params.spS_CustomerLoyaltyPointsAccumulationHistory(true);

			switch (this.LastKnownConnectionType) {

 				case Evernet.MoneyExchange.DataClasses.ConnectionType.ConnectionString:
					this.param.SetUpConnection(this.connectionString);
					break;

 				case Evernet.MoneyExchange.DataClasses.ConnectionType.SqlConnection:
					this.param.SetUpConnection(this.sqlConnection);
					break;
			}

			this.param.CommandTimeOut = this.commandTimeOut;

			if (!this.FK_CustomerId.IsNull) {

				this.param.Param_CustomerId = this.FK_CustomerId;
			}

			if (!this.FK_TransactionId.IsNull) {

				this.param.Param_TransactionId = this.FK_TransactionId;
			}

			System.Data.DataSet DS = null;
				
			SPs.spS_CustomerLoyaltyPointsAccumulationHistory SP = new SPs.spS_CustomerLoyaltyPointsAccumulationHistory(false);
			if (SP.Execute(ref this.param, ref DS, startRecord, maxRecords)) {

				this.DataSource = DS.Tables["spS_CustomerLoyaltyPointsAccumulationHistory"].DefaultView;
				if (this.doDataBindAfterRefreshData) {

					this.DataBind();
				}

				SP.Dispose();
			}

			else {

				SP.Dispose();
				throw new Evernet.MoneyExchange.DataClasses.CustomException(this.param, "WebRepeater_CustomerLoyaltyPointsAccumulationHistory : System.Web.UI.WebControls.Repeater", "RefreshData");
			}
		}
	}
}
