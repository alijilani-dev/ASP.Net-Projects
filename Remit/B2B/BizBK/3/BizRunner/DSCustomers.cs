﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace BizRunner {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class DSCustomers : DataSet {
        
        private CustomerListDataTable tableCustomerList;
        
        public DSCustomers() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected DSCustomers(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["CustomerList"] != null)) {
                    this.Tables.Add(new CustomerListDataTable(ds.Tables["CustomerList"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public CustomerListDataTable CustomerList {
            get {
                return this.tableCustomerList;
            }
        }
        
        public override DataSet Clone() {
            DSCustomers cln = ((DSCustomers)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["CustomerList"] != null)) {
                this.Tables.Add(new CustomerListDataTable(ds.Tables["CustomerList"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableCustomerList = ((CustomerListDataTable)(this.Tables["CustomerList"]));
            if ((this.tableCustomerList != null)) {
                this.tableCustomerList.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "DSCustomers";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/DSCustomers.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableCustomerList = new CustomerListDataTable();
            this.Tables.Add(this.tableCustomerList);
        }
        
        private bool ShouldSerializeCustomerList() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void CustomerListRowChangeEventHandler(object sender, CustomerListRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CustomerListDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnId;
            
            private DataColumn columnCompanyName;
            
            private DataColumn columnContactName;
            
            private DataColumn columnAddress;
            
            private DataColumn columnTelephone;
            
            private DataColumn columnEmail;
            
            private DataColumn columnMobile;
            
            internal CustomerListDataTable() : 
                    base("CustomerList") {
                this.InitClass();
            }
            
            internal CustomerListDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn IdColumn {
                get {
                    return this.columnId;
                }
            }
            
            internal DataColumn CompanyNameColumn {
                get {
                    return this.columnCompanyName;
                }
            }
            
            internal DataColumn ContactNameColumn {
                get {
                    return this.columnContactName;
                }
            }
            
            internal DataColumn AddressColumn {
                get {
                    return this.columnAddress;
                }
            }
            
            internal DataColumn TelephoneColumn {
                get {
                    return this.columnTelephone;
                }
            }
            
            internal DataColumn EmailColumn {
                get {
                    return this.columnEmail;
                }
            }
            
            internal DataColumn MobileColumn {
                get {
                    return this.columnMobile;
                }
            }
            
            public CustomerListRow this[int index] {
                get {
                    return ((CustomerListRow)(this.Rows[index]));
                }
            }
            
            public event CustomerListRowChangeEventHandler CustomerListRowChanged;
            
            public event CustomerListRowChangeEventHandler CustomerListRowChanging;
            
            public event CustomerListRowChangeEventHandler CustomerListRowDeleted;
            
            public event CustomerListRowChangeEventHandler CustomerListRowDeleting;
            
            public void AddCustomerListRow(CustomerListRow row) {
                this.Rows.Add(row);
            }
            
            public CustomerListRow AddCustomerListRow(int Id, string CompanyName, string ContactName, string Address, string Telephone, string Email, string Mobile) {
                CustomerListRow rowCustomerListRow = ((CustomerListRow)(this.NewRow()));
                rowCustomerListRow.ItemArray = new object[] {
                        Id,
                        CompanyName,
                        ContactName,
                        Address,
                        Telephone,
                        Email,
                        Mobile};
                this.Rows.Add(rowCustomerListRow);
                return rowCustomerListRow;
            }
            
            public CustomerListRow FindById(int Id) {
                return ((CustomerListRow)(this.Rows.Find(new object[] {
                            Id})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                CustomerListDataTable cln = ((CustomerListDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new CustomerListDataTable();
            }
            
            internal void InitVars() {
                this.columnId = this.Columns["Id"];
                this.columnCompanyName = this.Columns["CompanyName"];
                this.columnContactName = this.Columns["ContactName"];
                this.columnAddress = this.Columns["Address"];
                this.columnTelephone = this.Columns["Telephone"];
                this.columnEmail = this.Columns["Email"];
                this.columnMobile = this.Columns["Mobile"];
            }
            
            private void InitClass() {
                this.columnId = new DataColumn("Id", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnId);
                this.columnCompanyName = new DataColumn("CompanyName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCompanyName);
                this.columnContactName = new DataColumn("ContactName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnContactName);
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnTelephone = new DataColumn("Telephone", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTelephone);
                this.columnEmail = new DataColumn("Email", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEmail);
                this.columnMobile = new DataColumn("Mobile", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnMobile);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnId}, true));
                this.columnId.AllowDBNull = false;
                this.columnId.Unique = true;
            }
            
            public CustomerListRow NewCustomerListRow() {
                return ((CustomerListRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new CustomerListRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(CustomerListRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.CustomerListRowChanged != null)) {
                    this.CustomerListRowChanged(this, new CustomerListRowChangeEvent(((CustomerListRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.CustomerListRowChanging != null)) {
                    this.CustomerListRowChanging(this, new CustomerListRowChangeEvent(((CustomerListRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.CustomerListRowDeleted != null)) {
                    this.CustomerListRowDeleted(this, new CustomerListRowChangeEvent(((CustomerListRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.CustomerListRowDeleting != null)) {
                    this.CustomerListRowDeleting(this, new CustomerListRowChangeEvent(((CustomerListRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveCustomerListRow(CustomerListRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CustomerListRow : DataRow {
            
            private CustomerListDataTable tableCustomerList;
            
            internal CustomerListRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableCustomerList = ((CustomerListDataTable)(this.Table));
            }
            
            public int Id {
                get {
                    return ((int)(this[this.tableCustomerList.IdColumn]));
                }
                set {
                    this[this.tableCustomerList.IdColumn] = value;
                }
            }
            
            public string CompanyName {
                get {
                    try {
                        return ((string)(this[this.tableCustomerList.CompanyNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomerList.CompanyNameColumn] = value;
                }
            }
            
            public string ContactName {
                get {
                    try {
                        return ((string)(this[this.tableCustomerList.ContactNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomerList.ContactNameColumn] = value;
                }
            }
            
            public string Address {
                get {
                    try {
                        return ((string)(this[this.tableCustomerList.AddressColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomerList.AddressColumn] = value;
                }
            }
            
            public string Telephone {
                get {
                    try {
                        return ((string)(this[this.tableCustomerList.TelephoneColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomerList.TelephoneColumn] = value;
                }
            }
            
            public string Email {
                get {
                    try {
                        return ((string)(this[this.tableCustomerList.EmailColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomerList.EmailColumn] = value;
                }
            }
            
            public string Mobile {
                get {
                    try {
                        return ((string)(this[this.tableCustomerList.MobileColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomerList.MobileColumn] = value;
                }
            }
            
            public bool IsCompanyNameNull() {
                return this.IsNull(this.tableCustomerList.CompanyNameColumn);
            }
            
            public void SetCompanyNameNull() {
                this[this.tableCustomerList.CompanyNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsContactNameNull() {
                return this.IsNull(this.tableCustomerList.ContactNameColumn);
            }
            
            public void SetContactNameNull() {
                this[this.tableCustomerList.ContactNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsAddressNull() {
                return this.IsNull(this.tableCustomerList.AddressColumn);
            }
            
            public void SetAddressNull() {
                this[this.tableCustomerList.AddressColumn] = System.Convert.DBNull;
            }
            
            public bool IsTelephoneNull() {
                return this.IsNull(this.tableCustomerList.TelephoneColumn);
            }
            
            public void SetTelephoneNull() {
                this[this.tableCustomerList.TelephoneColumn] = System.Convert.DBNull;
            }
            
            public bool IsEmailNull() {
                return this.IsNull(this.tableCustomerList.EmailColumn);
            }
            
            public void SetEmailNull() {
                this[this.tableCustomerList.EmailColumn] = System.Convert.DBNull;
            }
            
            public bool IsMobileNull() {
                return this.IsNull(this.tableCustomerList.MobileColumn);
            }
            
            public void SetMobileNull() {
                this[this.tableCustomerList.MobileColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CustomerListRowChangeEvent : EventArgs {
            
            private CustomerListRow eventRow;
            
            private DataRowAction eventAction;
            
            public CustomerListRowChangeEvent(CustomerListRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public CustomerListRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}