using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MSDNMag.DataGridDemo
{
	// Timesheet application main form
	public class FormTimesheet : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGridClients;
		private System.Windows.Forms.DataGrid dataGridProjects;
		private System.Windows.Forms.Button buttonSubmit;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterClients;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnectionTimeTracker;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterProjects;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterEntries;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.DataSet dataSetTimeTracker;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterActivities;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Windows.Forms.DataGrid dataGridEntries;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyleClients;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnClients;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyleProjects;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnProjectName;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyleEntries;
		private DataGridComboBoxColumn dataGridComboBoxColumnActivity;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnDate;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnDesc;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumnDuration;
		private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumnApproved;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormTimesheet()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			// Set task datagrid preferred height to combo box height
			dataGridEntries.PreferredRowHeight = 
				dataGridComboBoxColumnActivity.ComboBox.Height + 1;

			// Copy data grid defaults to associated table styles
			CopyDefaultTableStyle(dataGridClients, dataGridTableStyleClients);
			CopyDefaultTableStyle(dataGridProjects, dataGridTableStyleProjects);
			CopyDefaultTableStyle(dataGridEntries, dataGridTableStyleEntries);
		}

		// Clean up any resources being used.
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormTimesheet));
			this.dataGridClients = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleClients = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnClients = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridProjects = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleProjects = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnProjectName = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridEntries = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyleEntries = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumnDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridComboBoxColumnActivity = new MSDNMag.DataGridDemo.DataGridComboBoxColumn();
			this.dataGridTextBoxColumnDesc = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumnDuration = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridBoolColumnApproved = new System.Windows.Forms.DataGridBoolColumn();
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.sqlDataAdapterClients = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnectionTimeTracker = new System.Data.SqlClient.SqlConnection();
			this.sqlDataAdapterProjects = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapterEntries = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dataSetTimeTracker = new System.Data.DataSet();
			this.sqlDataAdapterActivities = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridProjects)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEntries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetTimeTracker)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridClients
			// 
			this.dataGridClients.AllowNavigation = false;
			this.dataGridClients.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dataGridClients.BackColor = System.Drawing.Color.Gainsboro;
			this.dataGridClients.BackgroundColor = System.Drawing.Color.Silver;
			this.dataGridClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridClients.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dataGridClients.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGridClients.DataMember = "";
			this.dataGridClients.FlatMode = true;
			this.dataGridClients.Font = new System.Drawing.Font("Tahoma", 8F);
			this.dataGridClients.ForeColor = System.Drawing.Color.Black;
			this.dataGridClients.GridLineColor = System.Drawing.Color.DimGray;
			this.dataGridClients.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGridClients.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dataGridClients.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dataGridClients.HeaderForeColor = System.Drawing.Color.White;
			this.dataGridClients.LinkColor = System.Drawing.Color.MidnightBlue;
			this.dataGridClients.Location = new System.Drawing.Point(8, 16);
			this.dataGridClients.Name = "dataGridClients";
			this.dataGridClients.ParentRowsBackColor = System.Drawing.Color.DarkGray;
			this.dataGridClients.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGridClients.ReadOnly = true;
			this.dataGridClients.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dataGridClients.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridClients.Size = new System.Drawing.Size(248, 144);
			this.dataGridClients.TabIndex = 0;
			this.dataGridClients.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										this.dataGridTableStyleClients});
			// 
			// dataGridTableStyleClients
			// 
			this.dataGridTableStyleClients.DataGrid = this.dataGridClients;
			this.dataGridTableStyleClients.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														this.dataGridTextBoxColumnClients});
			this.dataGridTableStyleClients.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyleClients.MappingName = "Client";
			// 
			// dataGridTextBoxColumnClients
			// 
			this.dataGridTextBoxColumnClients.Format = "";
			this.dataGridTextBoxColumnClients.FormatInfo = null;
			this.dataGridTextBoxColumnClients.HeaderText = "Clients";
			this.dataGridTextBoxColumnClients.MappingName = "ClientName";
			this.dataGridTextBoxColumnClients.Width = 210;
			// 
			// dataGridProjects
			// 
			this.dataGridProjects.AllowNavigation = false;
			this.dataGridProjects.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dataGridProjects.BackColor = System.Drawing.Color.Gainsboro;
			this.dataGridProjects.BackgroundColor = System.Drawing.Color.Silver;
			this.dataGridProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridProjects.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dataGridProjects.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGridProjects.DataMember = "";
			this.dataGridProjects.FlatMode = true;
			this.dataGridProjects.Font = new System.Drawing.Font("Tahoma", 8F);
			this.dataGridProjects.ForeColor = System.Drawing.Color.Black;
			this.dataGridProjects.GridLineColor = System.Drawing.Color.DimGray;
			this.dataGridProjects.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGridProjects.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dataGridProjects.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dataGridProjects.HeaderForeColor = System.Drawing.Color.White;
			this.dataGridProjects.LinkColor = System.Drawing.Color.MidnightBlue;
			this.dataGridProjects.Location = new System.Drawing.Point(264, 16);
			this.dataGridProjects.Name = "dataGridProjects";
			this.dataGridProjects.ParentRowsBackColor = System.Drawing.Color.DarkGray;
			this.dataGridProjects.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGridProjects.ReadOnly = true;
			this.dataGridProjects.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dataGridProjects.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridProjects.Size = new System.Drawing.Size(248, 144);
			this.dataGridProjects.TabIndex = 1;
			this.dataGridProjects.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										 this.dataGridTableStyleProjects});
			// 
			// dataGridTableStyleProjects
			// 
			this.dataGridTableStyleProjects.DataGrid = this.dataGridProjects;
			this.dataGridTableStyleProjects.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														 this.dataGridTextBoxColumnProjectName});
			this.dataGridTableStyleProjects.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyleProjects.MappingName = "Project";
			// 
			// dataGridTextBoxColumnProjectName
			// 
			this.dataGridTextBoxColumnProjectName.Format = "";
			this.dataGridTextBoxColumnProjectName.FormatInfo = null;
			this.dataGridTextBoxColumnProjectName.HeaderText = "Projects";
			this.dataGridTextBoxColumnProjectName.MappingName = "ProjectName";
			this.dataGridTextBoxColumnProjectName.Width = 210;
			// 
			// dataGridEntries
			// 
			this.dataGridEntries.AllowNavigation = false;
			this.dataGridEntries.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dataGridEntries.BackColor = System.Drawing.Color.Gainsboro;
			this.dataGridEntries.BackgroundColor = System.Drawing.Color.Silver;
			this.dataGridEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridEntries.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dataGridEntries.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGridEntries.DataMember = "";
			this.dataGridEntries.FlatMode = true;
			this.dataGridEntries.Font = new System.Drawing.Font("Tahoma", 8F);
			this.dataGridEntries.ForeColor = System.Drawing.Color.Black;
			this.dataGridEntries.GridLineColor = System.Drawing.Color.DimGray;
			this.dataGridEntries.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGridEntries.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dataGridEntries.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dataGridEntries.HeaderForeColor = System.Drawing.Color.White;
			this.dataGridEntries.LinkColor = System.Drawing.Color.MidnightBlue;
			this.dataGridEntries.Location = new System.Drawing.Point(8, 168);
			this.dataGridEntries.Name = "dataGridEntries";
			this.dataGridEntries.ParentRowsBackColor = System.Drawing.Color.DarkGray;
			this.dataGridEntries.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGridEntries.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dataGridEntries.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridEntries.Size = new System.Drawing.Size(504, 176);
			this.dataGridEntries.TabIndex = 2;
			this.dataGridEntries.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										this.dataGridTableStyleEntries});
			// 
			// dataGridTableStyleEntries
			// 
			this.dataGridTableStyleEntries.DataGrid = this.dataGridEntries;
			this.dataGridTableStyleEntries.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																														this.dataGridTextBoxColumnDate,
																														this.dataGridComboBoxColumnActivity,
																														this.dataGridTextBoxColumnDesc,
																														this.dataGridTextBoxColumnDuration,
																														this.dataGridBoolColumnApproved});
			this.dataGridTableStyleEntries.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyleEntries.MappingName = "TimeEntry";
			// 
			// dataGridTextBoxColumnDate
			// 
			this.dataGridTextBoxColumnDate.Format = "";
			this.dataGridTextBoxColumnDate.FormatInfo = null;
			this.dataGridTextBoxColumnDate.HeaderText = "Date";
			this.dataGridTextBoxColumnDate.MappingName = "EntryDate";
			this.dataGridTextBoxColumnDate.Width = 75;
			// 
			// dataGridComboBoxColumnActivity
			// 
			this.dataGridComboBoxColumnActivity.Format = "";
			this.dataGridComboBoxColumnActivity.FormatInfo = null;
			this.dataGridComboBoxColumnActivity.HeaderText = "Activity";
			this.dataGridComboBoxColumnActivity.MappingName = "ActivityID";
			this.dataGridComboBoxColumnActivity.Width = 125;
			// 
			// dataGridTextBoxColumnDesc
			// 
			this.dataGridTextBoxColumnDesc.Format = "";
			this.dataGridTextBoxColumnDesc.FormatInfo = null;
			this.dataGridTextBoxColumnDesc.HeaderText = "Description";
			this.dataGridTextBoxColumnDesc.MappingName = "Description";
			this.dataGridTextBoxColumnDesc.Width = 135;
			// 
			// dataGridTextBoxColumnDuration
			// 
			this.dataGridTextBoxColumnDuration.Format = "#.00";
			this.dataGridTextBoxColumnDuration.FormatInfo = null;
			this.dataGridTextBoxColumnDuration.HeaderText = "Duration";
			this.dataGridTextBoxColumnDuration.MappingName = "Duration";
			this.dataGridTextBoxColumnDuration.Width = 55;
			// 
			// dataGridBoolColumnApproved
			// 
			this.dataGridBoolColumnApproved.FalseValue = false;
			this.dataGridBoolColumnApproved.HeaderText = "Approved";
			this.dataGridBoolColumnApproved.MappingName = "Approved";
			this.dataGridBoolColumnApproved.NullValue = ((object)(resources.GetObject("dataGridBoolColumnApproved.NullValue")));
			this.dataGridBoolColumnApproved.ReadOnly = true;
			this.dataGridBoolColumnApproved.TrueValue = true;
			this.dataGridBoolColumnApproved.Width = 75;
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.Location = new System.Drawing.Point(223, 352);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.TabIndex = 3;
			this.buttonSubmit.Text = "Submit";
			this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
			// 
			// sqlDataAdapterClients
			// 
			this.sqlDataAdapterClients.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapterClients.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											new System.Data.Common.DataTableMapping("Table", "_GetClients", new System.Data.Common.DataColumnMapping[] {
																																																						   new System.Data.Common.DataColumnMapping("ClientID", "ClientID"),
																																																						   new System.Data.Common.DataColumnMapping("ClientName", "ClientName")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "[_GetClients]";
			this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand1.Connection = this.sqlConnectionTimeTracker;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// sqlConnectionTimeTracker
			// 
			this.sqlConnectionTimeTracker.ConnectionString = "data source=.;initial catalog=TimeTracker;integrated security=SSPI;persist securi" +
				"ty info=False;packet size=4096";
			// 
			// sqlDataAdapterProjects
			// 
			this.sqlDataAdapterProjects.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapterProjects.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											 new System.Data.Common.DataTableMapping("Table", "_GetProjects", new System.Data.Common.DataColumnMapping[] {
																																																							 new System.Data.Common.DataColumnMapping("ProjectID", "ProjectID"),
																																																							 new System.Data.Common.DataColumnMapping("ClientID", "ClientID"),
																																																							 new System.Data.Common.DataColumnMapping("ProjectName", "ProjectName")})});
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "[_GetProjects]";
			this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand2.Connection = this.sqlConnectionTimeTracker;
			this.sqlSelectCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// sqlDataAdapterEntries
			// 
			this.sqlDataAdapterEntries.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapterEntries.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapterEntries.SelectCommand = this.sqlSelectCommand3;
			this.sqlDataAdapterEntries.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											new System.Data.Common.DataTableMapping("Table", "_GetTimeEntries", new System.Data.Common.DataColumnMapping[] {
																																																							   new System.Data.Common.DataColumnMapping("TimeEntryID", "TimeEntryID"),
																																																							   new System.Data.Common.DataColumnMapping("ProjectID", "ProjectID"),
																																																							   new System.Data.Common.DataColumnMapping("ActivityID", "ActivityID"),
																																																							   new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
																																																							   new System.Data.Common.DataColumnMapping("EntryDate", "EntryDate"),
																																																							   new System.Data.Common.DataColumnMapping("Duration", "Duration"),
																																																							   new System.Data.Common.DataColumnMapping("Description", "Description"),
																																																							   new System.Data.Common.DataColumnMapping("Approved", "Approved")})});
			this.sqlDataAdapterEntries.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "[_DeleteTimeEntry]";
			this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlDeleteCommand1.Connection = this.sqlConnectionTimeTracker;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TimeEntryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "TimeEntryID", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "[_InsertTimeEntry]";
			this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlInsertCommand1.Connection = this.sqlConnectionTimeTracker;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProjectID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "ProjectID", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ActivityID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "ActivityID", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EntryDate", System.Data.SqlDbType.DateTime, 8, "EntryDate"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Duration", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Duration", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 100, "Description"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TimeEntryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Output, false, ((System.Byte)(10)), ((System.Byte)(0)), "TimeEntryID", System.Data.DataRowVersion.Current, null));
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "[_GetTimeEntries]";
			this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand3.Connection = this.sqlConnectionTimeTracker;
			this.sqlSelectCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlSelectCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "[_UpdateTimeEntry]";
			this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlUpdateCommand1.Connection = this.sqlConnectionTimeTracker;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TimeEntryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "TimeEntryID", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProjectID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "ProjectID", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ActivityID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "ActivityID", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EntryDate", System.Data.SqlDbType.DateTime, 8, "EntryDate"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Duration", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Duration", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 100, "Description"));
			// 
			// dataSetTimeTracker
			// 
			this.dataSetTimeTracker.DataSetName = "NewDataSet";
			this.dataSetTimeTracker.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// sqlDataAdapterActivities
			// 
			this.sqlDataAdapterActivities.SelectCommand = this.sqlSelectCommand4;
			this.sqlDataAdapterActivities.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																											   new System.Data.Common.DataTableMapping("Table", "_GetActivities", new System.Data.Common.DataColumnMapping[] {
																																																								 new System.Data.Common.DataColumnMapping("ActivityID", "ActivityID"),
																																																								 new System.Data.Common.DataColumnMapping("Description", "Description")})});
			// 
			// sqlSelectCommand4
			// 
			this.sqlSelectCommand4.CommandText = "[_GetActivities]";
			this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand4.Connection = this.sqlConnectionTimeTracker;
			this.sqlSelectCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(10)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// FormTimesheet
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(520, 381);
			this.Controls.Add(this.buttonSubmit);
			this.Controls.Add(this.dataGridEntries);
			this.Controls.Add(this.dataGridProjects);
			this.Controls.Add(this.dataGridClients);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "FormTimesheet";
			this.Text = "Timesheet Application";
			this.Load += new System.EventHandler(this.FormTimesheet_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridProjects)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEntries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetTimeTracker)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		// The main entry point for the application.
		[STAThread]
		static void Main() 
		{
			Application.Run(new FormTimesheet());
		}

		private void buttonSubmit_Click(object sender, System.EventArgs e)
		{
			if (dataSetTimeTracker.HasChanges())
			{
				// Use adapter to update entries table
				DataTable table = dataSetTimeTracker.Tables["TimeEntry"].GetChanges();
				int iRet = sqlDataAdapterEntries.Update(table);	
			}
		}

		// On startup, load dataset and bind to datagrids
		private void FormTimesheet_Load(object sender, System.EventArgs e)
		{
			try
			{
				// Use client and project data adapters to fill
				// first two tables with clients and projects
				sqlDataAdapterClients.Fill(dataSetTimeTracker, "Client");
				sqlDataAdapterProjects.Fill(dataSetTimeTracker, "Project");

				// Hardcode EmployeeID parameter for TimeEntries sproc
				sqlSelectCommand3.Parameters["@EmployeeID"].Value = 1;
				// Set AddWithKey to get primary key restraints
				sqlDataAdapterEntries.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				// Use entries data adapter to fill 3rd table in dataset
				sqlDataAdapterEntries.Fill(dataSetTimeTracker, "TimeEntry");

				// Use activities data adapter to fill 4th table in dataset
				sqlDataAdapterActivities.Fill(dataSetTimeTracker, "Activity");

				// Create a relationship between the clients table and
				// projects table based on the ClientID column. Client is the
				// parent of Order.
				dataSetTimeTracker.Relations.Add("Client2Projects",
					dataSetTimeTracker.Tables["Client"].Columns["ClientID"],
					dataSetTimeTracker.Tables["Project"].Columns["ClientID"]);
				
				// Create relationship between projects and time entries based on the ProjectID column
				dataSetTimeTracker.Relations.Add("Project2TimeEntries",
					dataSetTimeTracker.Tables["Project"].Columns["ProjectID"],
					dataSetTimeTracker.Tables["TimeEntry"].Columns["ProjectID"]);

				// Set default values
				DataTable table = dataSetTimeTracker.Tables["TimeEntry"];
				table.Columns["EmployeeID"].DefaultValue = 1;
				table.Columns["EntryDate"].DefaultValue = DateTime.Today;
				table.Columns["Approved"].DefaultValue = false;

				// Bind the Clients table to the clients datagrid
				dataGridClients.SetDataBinding(dataSetTimeTracker, "Client");
				// Bind the Client2Project relationship to projects datagrid
				dataGridProjects.SetDataBinding(dataSetTimeTracker, "Client.Client2Projects");
				// Bind the Project2TimeEntries relationship to tasks datagrid
				dataGridEntries.SetDataBinding(dataSetTimeTracker, "Client.Client2Projects.Project2TimeEntries");

				// Bind activities to comboBoxActivities
				dataGridComboBoxColumnActivity.ComboBox.DataSource = 
					dataSetTimeTracker.Tables["Activity"];
				dataGridComboBoxColumnActivity.ComboBox.DisplayMember = "Description";
				dataGridComboBoxColumnActivity.ComboBox.ValueMember = "ActivityID";
			
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, Text);
			}		
		}

		// Copy the display-related properties of the given DataGrid
		// to the given DataGridTableStyle
		private void CopyDefaultTableStyle(DataGrid datagrid, DataGridTableStyle ts)
		{
			ts.AllowSorting = datagrid.AllowSorting;
			ts.AlternatingBackColor = datagrid.AlternatingBackColor;
			ts.BackColor = datagrid.BackColor;
			ts.ColumnHeadersVisible = datagrid.ColumnHeadersVisible;
			ts.ForeColor = datagrid.ForeColor;
			ts.GridLineColor = datagrid.GridLineColor;
			ts.GridLineStyle = datagrid.GridLineStyle;
			ts.HeaderBackColor = datagrid.HeaderBackColor;
			ts.HeaderFont = datagrid.HeaderFont;
			ts.HeaderForeColor = datagrid.HeaderForeColor;
			ts.LinkColor = datagrid.LinkColor;
			ts.PreferredColumnWidth = datagrid.PreferredColumnWidth;
			ts.PreferredRowHeight = datagrid.PreferredRowHeight;
			ts.ReadOnly = datagrid.ReadOnly;
			ts.RowHeadersVisible = datagrid.RowHeadersVisible;
			ts.RowHeaderWidth = datagrid.RowHeaderWidth;
			ts.SelectionBackColor = datagrid.SelectionBackColor;
			ts.SelectionForeColor = datagrid.SelectionForeColor;
		}
	}
}
