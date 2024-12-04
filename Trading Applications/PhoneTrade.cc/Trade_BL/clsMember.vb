Public Class Member

#Region "private variables"

#Region "database Column name"
    Public Const pi_column_member_id As String = "member_id"
    Public Const pi_column_portal_id As String = "portal_id"
    Public Const pi_column_password As String = "password"
    Public Const pi_column_member_company As String = "member_company"
    Public Const pi_column_manufacturer_type As String = "manufacturer_type"
    Public Const pi_column_exp_imp_type As String = "exp_imp_type"
    Public Const pi_column_dealer_reseller_type As String = "dealer_reseller_type"
    Public Const pi_column_retailer_type As String = "retailer_type"
    Public Const pi_column_service_prov_type As String = "service_prov_type"
    Public Const pi_column_freight_type As String = "freight_type"
    Public Const pi_column_mailing_address As String = "mailing_address"
    Public Const pi_column_company_phone As String = "company_phone"
    Public Const pi_column_company_fax As String = "company_fax"
    Public Const pi_column_company_email As String = "company_email"
    Public Const pi_column_company_website As String = "company_website"
    Public Const pi_column_company_contact1_name As String = "company_contact1_name"
    Public Const pi_column_company_contact1_mobile As String = "company_contact1_mobile"
    Public Const pi_column_company_contact1_email As String = "company_contact1_email"
    Public Const pi_column_company_contact2_name As String = "company_contact2_name"
    Public Const pi_column_company_contact2_mobile As String = "company_contact2_mobile"
    Public Const pi_column_company_contact2_email As String = "company_contact2_email"
    Public Const pi_column_country_id As String = "country_id"
#End Region

#Region "Private Variables"

    Private pi_str_member_id As String
    Private pi_int_portal_id As Integer
    Private pi_str_password As String
    Private pi_str_member_company As String
    Private pi_str_manufacturer_type As String
    Private pi_str_exp_imp_type As String
    Private pi_str_dealer_reseller_type As String
    Private pi_str_retailer_type As String
    Private pi_str_service_prov_type As String
    Private pi_str_freight_type As String
    Private pi_str_mailing_address As String
    Private pi_str_company_phone As String
    Private pi_str_company_fax As String
    Private pi_str_company_email As String
    Private pi_str_company_website As String
    Private pi_str_company_contact1_name As String
    Private pi_str_company_contact1_mobile As String
    Private pi_str_company_contact1_email As String
    Private pi_str_company_contact2_name As String
    Private pi_str_company_contact2_mobile As String
    Private pi_str_company_contact2_email As String
    Private pi_int_country_id As Integer
    Private pi_str_Compony_Logo_url As String

    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

    Private pi_dt_Trading_Cat As DataTable

#End Region

#Region "Properties"
    Public Property member_id() As String
        Get
            Return pi_str_member_id
        End Get
        Set(ByVal Value As String)
            pi_str_member_id = Value
        End Set
    End Property

    Public Property portal_id() As Integer
        Get
            Return pi_int_portal_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_portal_id = Value
        End Set
    End Property

    Public Property password() As String
        Get
            Return pi_str_password
        End Get
        Set(ByVal Value As String)
            pi_str_password = Value
        End Set
    End Property

    Public Property member_company() As String
        Get
            Return pi_str_member_company
        End Get
        Set(ByVal Value As String)
            pi_str_member_company = Value
        End Set
    End Property

    Public Property manufacturer_type() As String
        Get
            Return pi_str_manufacturer_type
        End Get
        Set(ByVal Value As String)
            pi_str_manufacturer_type = Value
        End Set
    End Property

    Public Property exp_imp_type() As String
        Get
            Return pi_str_exp_imp_type
        End Get
        Set(ByVal Value As String)
            pi_str_exp_imp_type = Value
        End Set
    End Property

    Public Property dealer_reseller_type() As String
        Get
            Return pi_str_dealer_reseller_type
        End Get
        Set(ByVal Value As String)
            pi_str_dealer_reseller_type = Value
        End Set
    End Property

    Public Property retailer_type() As String
        Get
            Return pi_str_retailer_type
        End Get
        Set(ByVal Value As String)
            pi_str_retailer_type = Value
        End Set
    End Property

    Public Property service_prov_type() As String
        Get
            Return pi_str_service_prov_type
        End Get
        Set(ByVal Value As String)
            pi_str_service_prov_type = Value
        End Set
    End Property

    Public Property freight_type() As String
        Get
            Return pi_str_freight_type
        End Get
        Set(ByVal Value As String)
            pi_str_freight_type = Value
        End Set
    End Property

    Public Property mailing_address() As String
        Get
            Return pi_str_mailing_address
        End Get
        Set(ByVal Value As String)
            pi_str_mailing_address = Value
        End Set
    End Property

    Public Property company_phone() As String
        Get
            Return pi_str_company_phone
        End Get
        Set(ByVal Value As String)
            pi_str_company_phone = Value
        End Set
    End Property

    Public Property company_fax() As String
        Get
            Return pi_str_company_fax
        End Get
        Set(ByVal Value As String)
            pi_str_company_fax = Value
        End Set
    End Property

    Public Property company_email() As String
        Get
            Return pi_str_company_email
        End Get
        Set(ByVal Value As String)
            pi_str_company_email = Value
        End Set
    End Property

    Public Property company_website() As String
        Get
            Return pi_str_company_website
        End Get
        Set(ByVal Value As String)
            pi_str_company_website = Value
        End Set
    End Property

    Public Property company_contact1_name() As String
        Get
            Return pi_str_company_contact1_name
        End Get
        Set(ByVal Value As String)
            pi_str_company_contact1_name = Value
        End Set
    End Property

    Public Property company_contact1_mobile() As String
        Get
            Return pi_str_company_contact1_mobile
        End Get
        Set(ByVal Value As String)
            pi_str_company_contact1_mobile = Value
        End Set
    End Property

    Public Property company_contact1_email() As String
        Get
            Return pi_str_company_contact1_email
        End Get
        Set(ByVal Value As String)
            pi_str_company_contact1_email = Value
        End Set
    End Property

    Public Property company_contact2_name() As String
        Get
            Return pi_str_company_contact2_name
        End Get
        Set(ByVal Value As String)
            pi_str_company_contact2_name = Value
        End Set
    End Property

    Public Property company_contact2_mobile() As String
        Get
            Return pi_str_company_contact2_mobile
        End Get
        Set(ByVal Value As String)
            pi_str_company_contact2_mobile = Value
        End Set
    End Property

    Public Property company_contact2_email() As String
        Get
            Return pi_str_company_contact2_email
        End Get
        Set(ByVal Value As String)
            pi_str_company_contact2_email = Value
        End Set
    End Property

    Public Property country_id() As Integer
        Get
            Return pi_int_country_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_country_id = Value
        End Set
    End Property

    ' company Logo File url
    Public Property Compony_Logo_url() As String
        Get
            Return pi_str_Compony_Logo_url
        End Get
        Set(ByVal Value As String)
            pi_str_Compony_Logo_url = Value
        End Set
    End Property

    Public Property Trading_Cat() As DataTable
        Get
            Return pi_dt_Trading_Cat
        End Get
        Set(ByVal Value As DataTable)
            pi_dt_Trading_Cat = Value
        End Set
    End Property

#End Region

#Region "private variables"
    Private pi_objHelper As AdoHelper
    Private pi_INSERT_Member As String = "USP_INSERT_MEMBERS"
    Private pi_UpdatePassword As String = "UPDATE Members SET Password='<Password>' WHERE Member_ID='<Member_ID>'"
    Private pi_UpdateProfile As String = "USP_UPDATE_MEMBERS_PROFILE"
#End Region

#End Region

#Region "INSERT"
    Public Function Update(ByVal prm_Mode As Integer) As Boolean
        Dim idbparameter(22) As IDataParameter

        Dim idb_Member_Cat_parameter(1) As IDataParameter
        Dim dt_row As DataRow

        ' prm_Mode
        ' prm_Mode = 1 - insert
        ' prm_Mode = 2 - update
        ' prm_Mode = 3 - delete
        '@member_id	varchar(20) OUTPUT,
        '@portal_id	int =NULL,
        '@password	varchar(20)=NULL,
        '@member_company	varchar(100)=NULL,
        '@manufacturer_type	varchar(1)=NULL,
        '@exp_imp_type	varchar(1)=NULL,
        '@dealer_reseller_type	varchar(1)=NULL,
        '@retailer_type	varchar	(1)=NULL,
        '@service_prov_type	varchar	(1)=NULL,
        '@freight_type	varchar	(1)=NULL,
        '@mailing_address	varchar(500)=NULL,
        '@company_phone	varchar(30)=NULL,
        '@company_fax	varchar(30)=NULL,
        '@company_email	varchar(50)=NULL,
        '@company_website	varchar(50)=NULL,
        '@company_contact1_name	varchar(100)=NULL,
        '@company_contact1_mobile	varchar(30)=NULL,
        '@company_contact1_email	varchar(50)=NULL,
        '@company_contact2_name	varchar(100)=NULL,
        '@company_contact2_mobile	varchar(30)=NULL,
        '@company_contact2_email	varchar(50) =NULL,
        '@country_id	int = NULL ,
        '@company_Logo_Url	varchar(255) = NULL

        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection
        objConnection = pi_objHelper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        idbparameter(0) = GlobalData.DataHelper.GetParameter("@member_id", DbType.String, 20, ParameterDirection.Input)
        idbparameter(0).Value = Me.member_id
        idbparameter(1) = GlobalData.DataHelper.GetParameter("@portal_id", DbType.Int32, 4, ParameterDirection.Input)
        idbparameter(1).Value = Me.portal_id
        idbparameter(2) = GlobalData.DataHelper.GetParameter("@password", DbType.String, 20, ParameterDirection.Input)
        idbparameter(2).Value = Me.password
        idbparameter(3) = GlobalData.DataHelper.GetParameter("@member_company", DbType.String, 100, ParameterDirection.Input)
        idbparameter(3).Value = Me.member_company
        idbparameter(4) = GlobalData.DataHelper.GetParameter("@manufacturer_type", DbType.String, 1, ParameterDirection.Input)
        idbparameter(4).Value = Me.manufacturer_type
        idbparameter(5) = GlobalData.DataHelper.GetParameter("@exp_imp_type", DbType.String, 1, ParameterDirection.Input)
        idbparameter(5).Value = Me.exp_imp_type
        idbparameter(6) = GlobalData.DataHelper.GetParameter("@dealer_reseller_type", DbType.String, 1, ParameterDirection.Input)
        idbparameter(6).Value = Me.dealer_reseller_type
        idbparameter(7) = GlobalData.DataHelper.GetParameter("@retailer_type", DbType.String, 1, ParameterDirection.Input)
        idbparameter(7).Value = Me.retailer_type
        idbparameter(8) = GlobalData.DataHelper.GetParameter("@service_prov_type", DbType.String, 1, ParameterDirection.Input)
        idbparameter(8).Value = Me.service_prov_type
        idbparameter(9) = GlobalData.DataHelper.GetParameter("@freight_type", DbType.String, 1, ParameterDirection.Input)
        idbparameter(9).Value = Me.freight_type
        idbparameter(10) = GlobalData.DataHelper.GetParameter("@mailing_address", DbType.String, 500, ParameterDirection.Input)
        idbparameter(10).Value = Me.mailing_address
        idbparameter(11) = GlobalData.DataHelper.GetParameter("@company_phone", DbType.String, 30, ParameterDirection.Input)
        idbparameter(11).Value = Me.company_phone
        idbparameter(12) = GlobalData.DataHelper.GetParameter("@company_fax", DbType.String, 30, ParameterDirection.Input)
        idbparameter(12).Value = Me.company_fax
        idbparameter(13) = GlobalData.DataHelper.GetParameter("@company_email", DbType.String, 50, ParameterDirection.Input)
        idbparameter(13).Value = Me.company_email
        idbparameter(14) = GlobalData.DataHelper.GetParameter("@company_website", DbType.String, 50, ParameterDirection.Input)
        idbparameter(14).Value = Me.company_website
        idbparameter(15) = GlobalData.DataHelper.GetParameter("@company_contact1_name", DbType.String, 100, ParameterDirection.Input)
        idbparameter(15).Value = Me.company_contact1_name
        idbparameter(16) = GlobalData.DataHelper.GetParameter("@company_contact1_mobile", DbType.String, 30, ParameterDirection.Input)
        idbparameter(16).Value = Me.company_contact1_mobile
        idbparameter(17) = GlobalData.DataHelper.GetParameter("@company_contact1_email", DbType.String, 50, ParameterDirection.Input)
        idbparameter(17).Value = Me.company_contact1_email
        idbparameter(18) = GlobalData.DataHelper.GetParameter("@company_contact2_name", DbType.String, 100, ParameterDirection.Input)
        idbparameter(18).Value = Me.company_contact2_name
        idbparameter(19) = GlobalData.DataHelper.GetParameter("@company_contact2_mobile", DbType.String, 30, ParameterDirection.Input)
        idbparameter(19).Value = Me.company_contact2_mobile
        idbparameter(20) = GlobalData.DataHelper.GetParameter("@company_contact2_email", DbType.String, 50, ParameterDirection.Input)
        idbparameter(20).Value = Me.company_contact2_email
        idbparameter(21) = GlobalData.DataHelper.GetParameter("@country_id", DbType.Int32, 4, ParameterDirection.Input)
        idbparameter(21).Value = Me.country_id

        ''Commented by BASHEER on Jan 07, time 2.16pm -- comment starts
        '''idbparameter(22) = GlobalData.DataHelper.GetParameter("@company_Logo_Url", DbType.String, 255, ParameterDirection.Input)
        '''idbparameter(22).Value = Me.Compony_Logo_url
        ''Commented by BASHEER on Jan 07, time 2.16pm -- comment ends

        Try
            If prm_Mode = 1 Then 'insert
                pi_objHelper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, pi_INSERT_Member, idbparameter)
            ElseIf prm_Mode = 2 Then 'update
                pi_objHelper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_UPDATE_MEMBERS", idbparameter)
            End If


            idb_Member_Cat_parameter(0) = GlobalData.DataHelper.GetParameter("@Member_ID", DbType.String, 20, ParameterDirection.Input)
            idb_Member_Cat_parameter(0).Value = Me.member_id

            pi_objHelper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_DELETE_MEMBER_CATEGORY", idb_Member_Cat_parameter)
            For Each dt_row In Me.Trading_Cat.Rows
                idb_Member_Cat_parameter(0) = GlobalData.DataHelper.GetParameter("@Member_ID", DbType.String, 20, ParameterDirection.Input)
                idb_Member_Cat_parameter(0).Value = Me.member_id
                idb_Member_Cat_parameter(1) = GlobalData.DataHelper.GetParameter("@Trading_Cat_ID", DbType.Int32, 4, ParameterDirection.Input)
                idb_Member_Cat_parameter(1).Value = dt_row("Trading_Cat_ID")

                pi_objHelper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_INSERT_MEMBER_CATEGORY", idb_Member_Cat_parameter)
            Next

            objTransaction.Commit()

            objConnection.Close()
            ' Return 
            Return True

        Catch ex As Exception
            objTransaction.Rollback()
            objConnection.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try


    End Function
#End Region

#Region "UPDATE"

#End Region

#Region "DELETE"

#End Region

#Region "Update Profile"
    Public Function UpdateOnlineStatus(ByVal prmUserName As String, Optional ByVal prmFlag As Int32 = 0) As Boolean
        Dim idParamOnline(1) As IDataParameter
        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection
        Try
            objConnection = pi_objHelper.GetConnection(GlobalData.ConnectionString)
            objConnection.Open()
            objTransaction = objConnection.BeginTransaction()

            idParamOnline(0) = GlobalData.DataHelper.GetParameter("@member_id", DbType.String, 20, ParameterDirection.Input)
            idParamOnline(0).Value = prmUserName
            idParamOnline(1) = GlobalData.DataHelper.GetParameter("@OnlineFlag", DbType.Int32, 4, ParameterDirection.Input)
            idParamOnline(1).Value = prmFlag

            pi_objHelper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_UPDATE_MEMBERS_ONLINE_STATUS", idParamOnline)
            objTransaction.Commit()
            objConnection.Close()
        Catch ex As Exception
            objTransaction.Rollback()
            objConnection.Close()
        End Try
        Return True
    End Function
    Public Function UpdateProfile(ByVal prm_Portal_ID As Integer, ByVal prm_Member_ID As String, ByVal prm_Profile As Object) As Boolean
        Dim idbparameter(2) As IDataParameter

        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection
        Try
            objConnection = pi_objHelper.GetConnection(GlobalData.ConnectionString)
            objConnection.Open()
            objTransaction = objConnection.BeginTransaction()

            idbparameter(0) = GlobalData.DataHelper.GetParameter("@member_id", DbType.String, 20, ParameterDirection.Input)
            idbparameter(0).Value = prm_Member_ID
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@portal_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(1).Value = prm_Portal_ID
            'idbparameter(2) = GlobalData.DataHelper.GetParameter("@ProfileText", DbType.String, 1000, ParameterDirection.Input)
            idbparameter(2) = GlobalData.DataHelper.GetParameter("@ProfileText", prm_Profile)
            'idbparameter(2).Value = prm_Profile
            'System.Diagnostics.Debug.Write(prm_Profile)
            pi_objHelper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, pi_UpdateProfile, idbparameter)

            objTransaction.Commit()

            objConnection.Close()
            Return True

        Catch ex As Exception
            objTransaction.Rollback()
            objConnection.Close()
            'System.Diagnostics.Debug.WriteLine(ex.Message)
            Return False
            Exit Function
        End Try
    End Function
#End Region

#Region "Update Password"
    Public Function UpdatePassword(ByVal prm_Member_ID As String, ByVal prm_new_Password As String) As Boolean
        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection
        Try
            objConnection = pi_objHelper.GetConnection(GlobalData.ConnectionString)
            objConnection.Open()
            objTransaction = objConnection.BeginTransaction()

            'Private pi_UpdatePassword As String = "UPDATE Member SET Password='<Password>' WHERE Member_ID='<Member_ID>'"

            pi_objHelper.ExecuteNonQuery(objTransaction, CommandType.Text, pi_UpdatePassword.Replace("<Password>", prm_new_Password).Replace("<Member_ID>", prm_Member_ID))
            objTransaction.Commit()

            objConnection.Close()
            ' Return 
            Return True

        Catch ex As Exception
            objTransaction.Rollback()
            objConnection.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try


    End Function

#End Region

#Region "public Functions"
    Public Function GetMemberTradingCategories(Optional ByVal prm_Member_ID As String = "") As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_Member_ID = "" Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MEMBERS")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@member_id", DbType.String, 20, ParameterDirection.Input)
                idbparameter(0).Value = prm_Member_ID
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MEMBERS_Trading_Cat", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    Public Function GetMembers(Optional ByVal prm_Member_ID As String = "") As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_Member_ID = "" Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MEMBERS")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@member_id", DbType.String, 20, ParameterDirection.Input)
                idbparameter(0).Value = prm_Member_ID
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MEMBERS", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    Public Function GetDirectory(Optional ByVal FFdirectory As Int32 = 0, Optional ByVal CountryID As Int64 = 0) As DataSet
        Dim idbparameter(2) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            'If FFdirectory Then
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@FFdirectory", DbType.Int32, 1, ParameterDirection.Input)
            idbparameter(0).Value = FFdirectory

            idbparameter(1) = GlobalData.DataHelper.GetParameter("@CountryID", DbType.Int64, 1, ParameterDirection.Input)
            idbparameter(1).Value = CountryID


            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MEMBERS_DIRECTORY_NEW", idbparameter)

            'Else
            'ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MEMBERS_DIRECTORY_NEW")
            'End If
            'myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the data set
        'Return myDatatable
        Return ds
    End Function
    Public Function GetNewMembers(Optional ByVal prm_Portal_ID As Integer = 0, Optional ByVal prm_Days As Integer = 365) As DataTable
        Dim idbparameter(2) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_Portal_ID = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_NewMEMBERS")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Portal_ID", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_Portal_ID
                idbparameter(1) = GlobalData.DataHelper.GetParameter("@Days", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(1).Value = prm_Days

                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_NewMEMBERS", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    Public Function DuplicateUserName() As Boolean
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet
        Dim dr As DataRow
        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper

            idbparameter(0) = GlobalData.DataHelper.GetParameter("@UserName", DbType.String, 20, ParameterDirection.Input)
            idbparameter(0).Value = Me.member_id

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Check_DuplicateUserName", idbparameter)
            myDatatable = ds.Tables(0)
            If myDatatable.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function
    Public Function IsValidMember(ByVal prmPortal_ID As Integer, ByVal prmUserName As String, ByVal prmUserPassword As String) As Boolean
        Dim idbparameter(2) As IDataParameter
        Dim ds As New DataSet
        Dim dr As DataRow
        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Portal_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prmPortal_ID
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@UserName", DbType.String, 20, ParameterDirection.Input)
            idbparameter(1).Value = prmUserName
            idbparameter(2) = GlobalData.DataHelper.GetParameter("@UserPwd", DbType.String, 20, ParameterDirection.Input)
            idbparameter(2).Value = prmUserPassword

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_ValidMember", idbparameter)
            myDatatable = ds.Tables(0)
            If myDatatable.Rows.Count > 0 Then
                dr = myDatatable.Rows(0)
                If String.Compare(dr("Member_ID"), prmUserName) <= 0 And _
                        String.Compare(dr("Password"), prmUserPassword) <= 0 Then
                    '''Update the online status
                    UpdateOnlineStatus(prmUserName, 1)
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function
#End Region

    Public Sub New()
        pi_objHelper = GlobalData.DataHelper
        pi_dt_Trading_Cat = New DataTable
        pi_dt_Trading_Cat.Columns.Add(New DataColumn("Trading_Cat_ID"))
        pi_dt_Trading_Cat.Columns(0).DataType = GetType(Integer)
    End Sub
End Class
