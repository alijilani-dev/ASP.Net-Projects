/*
	This C# source code was automatically generated using:

		SQL Server Centric .NET Code Generator
			v 1.0.1697.21165

			Generation Date: 11/30/2004 11:47:38 PM
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

[assembly:System.Web.UI.TagPrefix("Evernet.MoneyExchange.Web.DropDownLists", "mexchangeDropDownLists")]

namespace Evernet.MoneyExchange.Web.DropDownLists {

	/// <summary>
	/// This class derives from System.Web.UI.WebControls.DropDownList class and was built to display the 'TransactionDetails' table content.
	/// </summary>
#if OLYMARS_ATTRIBUTE || OLYMARS_DEBUG
	[Evernet.MoneyExchange.DataClasses.OlymarsInformation(DeveloperName="Evernet Technologies LLC", GeneratedOn="2004/11/30 19:47:38", SqlObjectDependancyName="TransactionDetails", SqlObjectDependancyRevision=3344)]
#endif
	[System.Drawing.ToolboxBitmap(typeof(WebDropDownList_TransactionDetails), "WebDropDownList.bmp")]
	public class WebDropDownList_TransactionDetails : System.Web.UI.WebControls.DropDownList {

		private Params.spS_TransactionDetails_Display param;
		private Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails oAbstract_TransactionDetails;
		private System.Data.SqlTypes.SqlGuid FK_CustomerId = System.Data.SqlTypes.SqlGuid.Null;
		private System.Data.SqlTypes.SqlGuid FK_BeneficeryId = System.Data.SqlTypes.SqlGuid.Null;
		private System.Data.SqlTypes.SqlGuid FK_BeneficeryBankId = System.Data.SqlTypes.SqlGuid.Null;
		private System.Data.SqlTypes.SqlString FK_PaymentMode = System.Data.SqlTypes.SqlString.Null;
		private System.Data.SqlTypes.SqlString FK_PurposeOfTransfer = System.Data.SqlTypes.SqlString.Null;
		private System.Data.SqlTypes.SqlGuid FK_PayInCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
		private System.Data.SqlTypes.SqlGuid FK_PayOutCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
		private System.Data.SqlTypes.SqlGuid FK_AssociatedBankId = System.Data.SqlTypes.SqlGuid.Null;
		private System.Data.SqlTypes.SqlGuid FK_PayInAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
		private System.Data.SqlTypes.SqlGuid FK_PayInAgentLocationId = System.Data.SqlTypes.SqlGuid.Null;
		private System.Data.SqlTypes.SqlGuid FK_PayOutAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
		private System.Data.SqlTypes.SqlString FK_Status = System.Data.SqlTypes.SqlString.Null;
		private System.Data.SqlTypes.SqlString FK_SettlementStatus = System.Data.SqlTypes.SqlString.Null;
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
		public Params.spS_TransactionDetails_Display SP_Parameter {

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
		/// Returns the 'TransactionDetails' abstract class so that you can access any table
		/// column for the current record selection. When the selection has changed, you need to call the
		/// RefreshCurrentRecord method first before accessing this property.
		/// </summary>
		public Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails Abstract_TransactionDetails {

			get {

				return(this.oAbstract_TransactionDetails);
			}
		}

		/// <summary>
		/// Returns the currently selected record primary key.
		/// </summary>
		public System.Data.SqlTypes.SqlGuid SelectedRecordID {

			get {

				return(new Guid(this.SelectedItem.Value));
			}
		}

		/// <summary>
		/// Disposes the current instance of this object.
		/// </summary>
		public override void Dispose() {

			this.oAbstract_TransactionDetails = null;

			this.FK_CustomerId = System.Data.SqlTypes.SqlGuid.Null;
			this.FK_BeneficeryId = System.Data.SqlTypes.SqlGuid.Null;
			this.FK_BeneficeryBankId = System.Data.SqlTypes.SqlGuid.Null;
			this.FK_PaymentMode = System.Data.SqlTypes.SqlString.Null;
			this.FK_PurposeOfTransfer = System.Data.SqlTypes.SqlString.Null;
			this.FK_PayInCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
			this.FK_PayOutCurrencyId = System.Data.SqlTypes.SqlGuid.Null;
			this.FK_AssociatedBankId = System.Data.SqlTypes.SqlGuid.Null;
			this.FK_PayInAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
			this.FK_PayInAgentLocationId = System.Data.SqlTypes.SqlGuid.Null;
			this.FK_PayOutAgentUserId = System.Data.SqlTypes.SqlGuid.Null;
			this.FK_Status = System.Data.SqlTypes.SqlString.Null;
			this.FK_SettlementStatus = System.Data.SqlTypes.SqlString.Null;

			if (this.param != null) {

				this.param.Dispose();
			}

			base.Dispose();
		}

		/// <summary>
		/// Create a new instance of the Evernet.MoneyExchange.Web.DropDownLists.WebDropDownList_TransactionDetails class.
		/// </summary>
		public WebDropDownList_TransactionDetails() : base() {

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
		/// <param name="FK_CustomerId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryBankId">Value for this foreign key.</param>
		/// <param name="FK_PaymentMode">Value for this foreign key.</param>
		/// <param name="FK_PurposeOfTransfer">Value for this foreign key.</param>
		/// <param name="FK_PayInCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_PayOutCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_AssociatedBankId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentLocationId">Value for this foreign key.</param>
		/// <param name="FK_PayOutAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_Status">Value for this foreign key.</param>
		/// <param name="FK_SettlementStatus">Value for this foreign key.</param>
		public void Initialize(string connectionString, System.Data.SqlTypes.SqlGuid FK_CustomerId, System.Data.SqlTypes.SqlGuid FK_BeneficeryId, System.Data.SqlTypes.SqlGuid FK_BeneficeryBankId, System.Data.SqlTypes.SqlString FK_PaymentMode, System.Data.SqlTypes.SqlString FK_PurposeOfTransfer, System.Data.SqlTypes.SqlGuid FK_PayInCurrencyId, System.Data.SqlTypes.SqlGuid FK_PayOutCurrencyId, System.Data.SqlTypes.SqlGuid FK_AssociatedBankId, System.Data.SqlTypes.SqlGuid FK_PayInAgentUserId, System.Data.SqlTypes.SqlGuid FK_PayInAgentLocationId, System.Data.SqlTypes.SqlGuid FK_PayOutAgentUserId, System.Data.SqlTypes.SqlString FK_Status, System.Data.SqlTypes.SqlString FK_SettlementStatus) {

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
					sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'TransactionDetails'";

					int CurrentRevision = (int)sqlCommand.ExecuteScalar();

					sqlConnection.Close();

					int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
					if (CurrentRevision != OriginalRevision) {

						throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "TransactionDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
					}
				}
			}
#endif

			this.FK_CustomerId = FK_CustomerId;
			this.FK_BeneficeryId = FK_BeneficeryId;
			this.FK_BeneficeryBankId = FK_BeneficeryBankId;
			this.FK_PaymentMode = FK_PaymentMode;
			this.FK_PurposeOfTransfer = FK_PurposeOfTransfer;
			this.FK_PayInCurrencyId = FK_PayInCurrencyId;
			this.FK_PayOutCurrencyId = FK_PayOutCurrencyId;
			this.FK_AssociatedBankId = FK_AssociatedBankId;
			this.FK_PayInAgentUserId = FK_PayInAgentUserId;
			this.FK_PayInAgentLocationId = FK_PayInAgentLocationId;
			this.FK_PayOutAgentUserId = FK_PayOutAgentUserId;
			this.FK_Status = FK_Status;
			this.FK_SettlementStatus = FK_SettlementStatus;
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
		/// <param name="FK_CustomerId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryId">Value for this foreign key.</param>
		/// <param name="FK_BeneficeryBankId">Value for this foreign key.</param>
		/// <param name="FK_PaymentMode">Value for this foreign key.</param>
		/// <param name="FK_PurposeOfTransfer">Value for this foreign key.</param>
		/// <param name="FK_PayInCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_PayOutCurrencyId">Value for this foreign key.</param>
		/// <param name="FK_AssociatedBankId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_PayInAgentLocationId">Value for this foreign key.</param>
		/// <param name="FK_PayOutAgentUserId">Value for this foreign key.</param>
		/// <param name="FK_Status">Value for this foreign key.</param>
		/// <param name="FK_SettlementStatus">Value for this foreign key.</param>
		public void Initialize(System.Data.SqlClient.SqlConnection sqlConnection, System.Data.SqlTypes.SqlGuid FK_CustomerId, System.Data.SqlTypes.SqlGuid FK_BeneficeryId, System.Data.SqlTypes.SqlGuid FK_BeneficeryBankId, System.Data.SqlTypes.SqlString FK_PaymentMode, System.Data.SqlTypes.SqlString FK_PurposeOfTransfer, System.Data.SqlTypes.SqlGuid FK_PayInCurrencyId, System.Data.SqlTypes.SqlGuid FK_PayOutCurrencyId, System.Data.SqlTypes.SqlGuid FK_AssociatedBankId, System.Data.SqlTypes.SqlGuid FK_PayInAgentUserId, System.Data.SqlTypes.SqlGuid FK_PayInAgentLocationId, System.Data.SqlTypes.SqlGuid FK_PayOutAgentUserId, System.Data.SqlTypes.SqlString FK_Status, System.Data.SqlTypes.SqlString FK_SettlementStatus) {

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
				sqlCommand.CommandText = "Select sysobjects.schema_ver from sysobjects where sysobjects.name = 'TransactionDetails'";

				int CurrentRevision = (int)sqlCommand.ExecuteScalar();

				if (NotAlreadyOpened) {

					sqlConnection.Close();
				}

				int OriginalRevision = ((Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute)System.Attribute.GetCustomAttribute(this.GetType(), typeof(Evernet.MoneyExchange.DataClasses.OlymarsInformationAttribute), false)).SqlObjectDependancyRevision;
				if (CurrentRevision != OriginalRevision) {

					throw new System.InvalidOperationException(System.String.Format("OLYMARS: This code is not in sync anymore with [{0}]. It was generated when [{0}] version was: {2}. Current [{0}] version is: {1}{3}{3}You can either regenerate the code for this class so that it will be based on the new version or edit the configuration file of the class caller application and paste the following code:{3}{3}<?xml version=\"1.0\" encoding=\"utf-8\" ?>{3}<configuration>{3}\t<appSettings>{3}\t\t<add key=\"OlymarsDebugCheck\" value=\"False\" />{3}\t</appSettings>{3}</configuration>{3}{3}You will need to reload the caller application if it is a Windows Forms based application.", "TransactionDetails", CurrentRevision, OriginalRevision, System.Environment.NewLine));
				}
			}
#endif

			this.FK_CustomerId = FK_CustomerId;
			this.FK_BeneficeryId = FK_BeneficeryId;
			this.FK_BeneficeryBankId = FK_BeneficeryBankId;
			this.FK_PaymentMode = FK_PaymentMode;
			this.FK_PurposeOfTransfer = FK_PurposeOfTransfer;
			this.FK_PayInCurrencyId = FK_PayInCurrencyId;
			this.FK_PayOutCurrencyId = FK_PayOutCurrencyId;
			this.FK_AssociatedBankId = FK_AssociatedBankId;
			this.FK_PayInAgentUserId = FK_PayInAgentUserId;
			this.FK_PayInAgentLocationId = FK_PayInAgentLocationId;
			this.FK_PayOutAgentUserId = FK_PayOutAgentUserId;
			this.FK_Status = FK_Status;
			this.FK_SettlementStatus = FK_SettlementStatus;
		}

		/// <summary>
		/// Load or reloads all the table content. In order to successfully call this method,
		/// you need to call first the Initialize method.
		/// </summary>
		public void RefreshData() {

			this.RefreshData(System.Data.SqlTypes.SqlGuid.Null, -1, -1);
		}

		/// <summary>
		/// Load or reloads a subset of the table content. In order to successfully call this method, you need to call first
		/// the Initialize method.
		/// </summary>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		public void RefreshData(int startRecord, int maxRecords) {

			this.RefreshData(System.Data.SqlTypes.SqlGuid.Null, startRecord, maxRecords);
		}

		/// <summary>
		/// Load or reloads all the table content. You can specify which record you want to be selected by default.
		/// In order to successfully call this method, you need to call first the Initialize method.
		/// </summary>
		/// <param name="PK_Id">Primary key of the record you want to be selected by default.</param>
		public void RefreshData(System.Data.SqlTypes.SqlGuid PK_Id) {

			this.RefreshData(PK_Id, -1, -1);
		}

		/// <summary>
		/// Load or reloads a subset of the table content. You can specify which record you want to be selected
		/// by default. In order to successfully call this method, you need to call first the Initialize method.
		/// </summary>
		/// <param name="PK_Id">Primary key of the record you want to be selected by default.</param>
		/// <param name="startRecord">The zero-based record number to start with.</param>
		/// <param name="maxRecords">The maximum number of records to retrieve.</param>
		public void RefreshData(System.Data.SqlTypes.SqlGuid PK_Id, int startRecord, int maxRecords) {

			this.param = new Params.spS_TransactionDetails_Display(true);

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
			this.param.Param_CustomerId = this.FK_CustomerId;
			this.param.Param_BeneficeryId = this.FK_BeneficeryId;
			this.param.Param_BeneficeryBankId = this.FK_BeneficeryBankId;
			this.param.Param_PaymentMode = this.FK_PaymentMode;
			this.param.Param_PurposeOfTransfer = this.FK_PurposeOfTransfer;
			this.param.Param_PayInCurrencyId = this.FK_PayInCurrencyId;
			this.param.Param_PayOutCurrencyId = this.FK_PayOutCurrencyId;
			this.param.Param_AssociatedBankId = this.FK_AssociatedBankId;
			this.param.Param_PayInAgentUserId = this.FK_PayInAgentUserId;
			this.param.Param_PayInAgentLocationId = this.FK_PayInAgentLocationId;
			this.param.Param_PayOutAgentUserId = this.FK_PayOutAgentUserId;
			this.param.Param_Status = this.FK_Status;
			this.param.Param_SettlementStatus = this.FK_SettlementStatus;

			System.Data.DataSet DS = null;
			
			SPs.spS_TransactionDetails_Display SP = new SPs.spS_TransactionDetails_Display(false);

			if (SP.Execute(ref this.param, ref DS, startRecord, maxRecords)) {

				this.DataSource = DS.Tables["spS_TransactionDetails_Display"].DefaultView;
				this.DataValueField = SPs.spS_TransactionDetails_Display.Resultset1.Fields.Column_ID1.ColumnName;
				this.DataTextField = SPs.spS_TransactionDetails_Display.Resultset1.Fields.Column_Display.ColumnName;
				if (this.doDataBindAfterRefreshData) {

					this.DataBind();
				}

				if (!PK_Id.IsNull) {

					System.Web.UI.WebControls.ListItem listItem = this.Items.FindByValue(PK_Id.Value.ToString());
					if (listItem != null) {

						listItem.Selected = true;
					}
				}

			}
			else {

				SP.Dispose();
				throw new Evernet.MoneyExchange.DataClasses.CustomException(this.param, "WebDropDownList_TransactionDetails : System.Web.UI.WebControls.DropDownList", "RefreshData");
			}

		}


		/// <summary>
		/// Loads the TransactionDetails abstract class for the current selected record primary key.
		/// </summary>
		/// <returns>true if the call succeeded; false, otherwise.</returns>
		public bool RefreshCurrentRecord() {

			if (this.SelectedIndex == -1) {

				if (oAbstract_TransactionDetails != null) {

					oAbstract_TransactionDetails.Reset();
				}
				return(false);
			}

			System.Data.SqlTypes.SqlGuid PK_Id = new Guid(this.SelectedItem.Value);

			if (this.oAbstract_TransactionDetails == null) {

				switch (this.LastKnownConnectionType) {

					case Evernet.MoneyExchange.DataClasses.ConnectionType.ConnectionString:
							this.oAbstract_TransactionDetails = new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails(this.connectionString);
						break;

					case Evernet.MoneyExchange.DataClasses.ConnectionType.SqlConnection:
							this.oAbstract_TransactionDetails = new Evernet.MoneyExchange.AbstractClasses.Abstract_TransactionDetails(this.sqlConnection);
						break;
				}
			}

			return(this.oAbstract_TransactionDetails.Refresh(PK_Id));
		}
	}
}
