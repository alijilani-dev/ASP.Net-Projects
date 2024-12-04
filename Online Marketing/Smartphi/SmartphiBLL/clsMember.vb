Imports GotDotNet.ApplicationBlocks.Data
Public Class clsMember

#Region "Private variables"

    Private pi_int_MemberID As Integer
    Private pi_str_MemberName As String
    Private pi_str_Address As String
    Private pi_str_City As String
    Private pi_int_CountryID As Integer
    Private pi_str_PhoneNo As String
    Private pi_str_FaxNo As String
    Private pi_str_MobileNo As String
    Private pi_str_ContactPerson As String
    Private pi_str_EmailID As String
    Private pi_str_CompanyLogo As String
    Private pi_bol_IsActive As Boolean
    Private pi_str_JoiningDate As String
    Private pi_str_UserName As String
    Private pi_str_Password As String

    Private pi_str_SMTPServer As String
    Private pi_str_SMTPUserName As String
    Private pi_str_SMTPPassword As String
    Private pi_str_SMTPServerPort As String
    Private pi_str_GUID As String

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection


#End Region

#Region "Properties"
    Property MemberID() As Integer
        Get
            Return pi_int_MemberID
        End Get
        Set(ByVal Value As Integer)
            pi_int_MemberID = Value
        End Set
    End Property

    Property MemberName() As String
        Get
            Return pi_str_MemberName
        End Get
        Set(ByVal Value As String)
            pi_str_MemberName = Value
        End Set
    End Property

    Property Address() As String
        Get
            Return pi_str_Address
        End Get
        Set(ByVal Value As String)
            pi_str_Address = Value
        End Set
    End Property

    Property City() As String
        Get
            Return pi_str_City
        End Get
        Set(ByVal Value As String)
            pi_str_City = Value
        End Set
    End Property

    Property CountryID() As Integer
        Get
            Return pi_int_CountryID
        End Get
        Set(ByVal Value As Integer)
            pi_int_CountryID = Value
        End Set
    End Property

    Property PhoneNo() As String
        Get
            Return pi_str_PhoneNo
        End Get
        Set(ByVal Value As String)
            pi_str_PhoneNo = Value
        End Set
    End Property

    Property FaxNo() As String
        Get
            Return pi_str_FaxNo
        End Get
        Set(ByVal Value As String)
            pi_str_FaxNo = Value
        End Set
    End Property

    Property MobileNo() As String
        Get
            Return pi_str_MobileNo
        End Get
        Set(ByVal Value As String)
            pi_str_MobileNo = Value
        End Set
    End Property

    Property ContactPerson() As String
        Get
            Return pi_str_ContactPerson
        End Get
        Set(ByVal Value As String)
            pi_str_ContactPerson = Value
        End Set
    End Property

    Property EmailID() As String
        Get
            Return pi_str_EmailID
        End Get
        Set(ByVal Value As String)
            pi_str_EmailID = Value
        End Set
    End Property

    Property CompanyLogo() As String
        Get
            Return pi_str_CompanyLogo
        End Get
        Set(ByVal Value As String)
            pi_str_CompanyLogo = Value
        End Set
    End Property

    Property isActive() As Boolean
        Get
            Return pi_bol_IsActive
        End Get
        Set(ByVal Value As Boolean)
            pi_bol_IsActive = Value
        End Set
    End Property

    Property UserName() As String
        Get
            Return pi_str_UserName
        End Get
        Set(ByVal Value As String)
            pi_str_UserName = Value
        End Set
    End Property

    Property Password() As String
        Get
            Return pi_str_Password
        End Get
        Set(ByVal Value As String)
            pi_str_Password = Value
        End Set
    End Property

    Property SMTPServer() As String
        Get
            Return pi_str_SMTPServer
        End Get
        Set(ByVal Value As String)
            pi_str_SMTPServer = Value
        End Set
    End Property

    Property SMTPUserName() As String
        Get
            Return pi_str_SMTPUserName
        End Get
        Set(ByVal Value As String)
            pi_str_SMTPUserName = Value
        End Set
    End Property

    Property SMTPPassword() As String
        Get
            Return pi_str_SMTPPassword
        End Get
        Set(ByVal Value As String)
            pi_str_SMTPPassword = Value
        End Set
    End Property

    Property SMTPServerPort() As String
        Get
            Return pi_str_SMTPServerPort
        End Get
        Set(ByVal Value As String)
            pi_str_SMTPServerPort = Value
        End Set
    End Property
    Public Property GUID() As String
        Get
            Return pi_str_GUID
        End Get
        Set(ByVal Value As String)
            pi_str_GUID = Value
        End Set
    End Property
#End Region

#Region "Insert / Update Methods"

    Public Function Update(ByVal prm_Mode As Integer) As Boolean
        Dim idbparameter(14) As IDataParameter

        ' prm_Mode
        ' prm_Mode = 1 - insert
        ' prm_Mode = 2 - update

        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        'Added the parameters value into the collection
        If prm_Mode = 1 Then '
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 20, ParameterDirection.InputOutput)
            idbparameter(0).Value = Me.MemberID
        ElseIf prm_Mode = 2 Then '
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 20, ParameterDirection.Input)
            idbparameter(0).Value = Me.MemberID
        End If


        idbparameter(1) = GlobalData.DataHelper.GetParameter("@Member_name", DbType.String, 100, ParameterDirection.Input)
        idbparameter(1).Value = Me.MemberName

        idbparameter(2) = GlobalData.DataHelper.GetParameter("@Address", DbType.String, 255, ParameterDirection.Input)
        idbparameter(2).Value = Me.Address

        idbparameter(3) = GlobalData.DataHelper.GetParameter("@City", DbType.String, 100, ParameterDirection.Input)
        idbparameter(3).Value = Me.City

        idbparameter(4) = GlobalData.DataHelper.GetParameter("@Country_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(4).Value = Me.CountryID

        idbparameter(5) = GlobalData.DataHelper.GetParameter("@PhoneNo", DbType.String, 20, ParameterDirection.Input)
        idbparameter(5).Value = Me.PhoneNo

        idbparameter(6) = GlobalData.DataHelper.GetParameter("@FaxNo", DbType.String, 20, ParameterDirection.Input)
        idbparameter(6).Value = Me.FaxNo

        idbparameter(7) = GlobalData.DataHelper.GetParameter("@MobileNo", DbType.String, 20, ParameterDirection.Input)
        idbparameter(7).Value = Me.MobileNo

        idbparameter(8) = GlobalData.DataHelper.GetParameter("@ContactPerson", DbType.String, 100, ParameterDirection.Input)
        idbparameter(8).Value = Me.ContactPerson

        idbparameter(9) = GlobalData.DataHelper.GetParameter("@EmailID", DbType.String, 100, ParameterDirection.Input)
        idbparameter(9).Value = Me.EmailID

        idbparameter(10) = GlobalData.DataHelper.GetParameter("@CompanyLogo", DbType.String, 100, ParameterDirection.Input)
        idbparameter(10).Value = Me.CompanyLogo

        idbparameter(11) = GlobalData.DataHelper.GetParameter("@IsActive", DbType.Boolean, 10, ParameterDirection.Input)
        idbparameter(11).Value = Me.isActive

        idbparameter(12) = GlobalData.DataHelper.GetParameter("@UserName", DbType.String, 50, ParameterDirection.Input)
        idbparameter(12).Value = Me.UserName

        If prm_Mode = 1 Then '
            idbparameter(13) = GlobalData.DataHelper.GetParameter("@ActivationCode", DbType.String, 50, ParameterDirection.Output)
            idbparameter(13).Value = Me.GUID
        ElseIf prm_Mode = 2 Then '
            idbparameter(13) = GlobalData.DataHelper.GetParameter("@ActivationCode", DbType.String, 50, ParameterDirection.Input)
            idbparameter(13).Value = Me.GUID
        End If



        Try
            If prm_Mode = 1 Then 'insert
                pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_INSERT_MEMBER", idbparameter)
            ElseIf prm_Mode = 2 Then 'update
                pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_UPDATE_MEMBER", idbparameter)
            End If

            'Commit and close the transaction
            objTransaction.Commit()
            objConnection.Close()
            If prm_Mode = 1 Then Me.GUID = idbparameter(13).Value
            Return True

        Catch ex As Exception
            'If any error roll back the transaction
            objTransaction.Rollback()
            objConnection.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try
    End Function

    Public Function Delete() As Boolean
        Dim idbparameter(1) As IDataParameter

        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        'Added the parameters value into the collection
        idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(0).Value = Me.MemberID

        Try
            pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_DELETE_MEMBER", idbparameter)

            'Commit and close the transaction
            objTransaction.Commit()
            objConnection.Close()

            Return True

        Catch ex As Exception
            'If any error roll back the transaction
            objTransaction.Rollback()
            objConnection.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try
    End Function

    Public Function UpdateMailSetting(ByVal prmMemberID As Integer) As Boolean
        Dim idbparameter(4) As IDataParameter
        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        'Added the parameters value into the collection
        idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(0).Value = prmMemberID

        idbparameter(1) = GlobalData.DataHelper.GetParameter("@SMTPserver", DbType.String, 100, ParameterDirection.Input)
        idbparameter(1).Value = Me.SMTPServer

        idbparameter(2) = GlobalData.DataHelper.GetParameter("@SMTPusername", DbType.String, 100, ParameterDirection.Input)
        idbparameter(2).Value = Me.SMTPUserName

        idbparameter(3) = GlobalData.DataHelper.GetParameter("@SMTPpassword", DbType.String, 100, ParameterDirection.Input)
        idbparameter(3).Value = Me.SMTPPassword

        idbparameter(4) = GlobalData.DataHelper.GetParameter("@SMTPport", DbType.String, 5, ParameterDirection.Input)
        idbparameter(4).Value = Me.SMTPServerPort

        Try

            pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_UPDATE_MAILSETTINGS", idbparameter)

            'Commit and close the transaction
            objTransaction.Commit()
            objConnection.Close()

            Return True

        Catch ex As Exception
            'If any error roll back the transaction
            objTransaction.Rollback()
            objConnection.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try
    End Function

    Public Function ActivateAccount(ByVal prmGUID As GUID, ByVal prmisActive As Boolean, ByVal prmPassword As Byte()) As Boolean
        Dim idbparameter(4) As IDataParameter
        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        'Added the parameters value into the collection
        idbparameter(0) = GlobalData.DataHelper.GetParameter("@ActivationCode", DbType.Guid, 50, ParameterDirection.Input)
        idbparameter(0).Value = prmGUID
        idbparameter(1) = GlobalData.DataHelper.GetParameter("@isActive", DbType.Boolean, 1, ParameterDirection.Input)
        idbparameter(1).Value = prmisActive
        idbparameter(2) = GlobalData.DataHelper.GetParameter("@Password", DbType.Binary, 20, ParameterDirection.Input)
        idbparameter(2).Value = prmPassword
        idbparameter(3) = GlobalData.DataHelper.GetParameter("@Username", DbType.String, 20, ParameterDirection.Output)
        idbparameter(3).Value = ""
        idbparameter(4) = GlobalData.DataHelper.GetParameter("@EmailID", DbType.String, 100, ParameterDirection.Output)
        idbparameter(4).Value = ""

        Try
            pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_ACTIVATE_ACCOUNT", idbparameter)

            'Commit and close the transaction
            objTransaction.Commit()
            objConnection.Close()
            Me.UserName = idbparameter(3).Value
            Me.EmailID = idbparameter(4).Value
            Return True

        Catch ex As Exception
            'If any error roll back the transaction
            objTransaction.Rollback()
            objConnection.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try

        Return True

    End Function

    Public Function UpdatePassword(ByVal prmMemberID As Integer, ByVal prmPassword As Byte()) As Boolean
        Dim idbparameter(1) As IDataParameter
        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        'Added the parameters value into the collection
        idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 10, ParameterDirection.Input)
        idbparameter(0).Value = prmMemberID
        idbparameter(1) = GlobalData.DataHelper.GetParameter("@Password", DbType.Binary, 20, ParameterDirection.Input)
        idbparameter(1).Value = prmPassword

        Try
            pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_UPDATE_PASSWORD", idbparameter)

            'Commit and close the transaction
            objTransaction.Commit()
            objConnection.Close()

            Return True

        Catch ex As Exception
            'If any error roll back the transaction
            objTransaction.Rollback()
            objConnection.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try

        Return True

    End Function

    Public Function UpdateForgottenPassword(ByVal strUserName As String, ByVal prmPassword As Byte()) As Boolean

        If (strUserName <> Nothing) And (strUserName <> "") Then
            Dim idbparameter(1) As IDataParameter
            Dim objTransaction As IDbTransaction
            Dim objConnection As IDbConnection

            objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
            objConnection.Open()
            objTransaction = objConnection.BeginTransaction()

            'Added the parameters value into the collection
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@UserName", DbType.String, 50, ParameterDirection.Input)
            idbparameter(0).Value = strUserName
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Password", DbType.Binary, 20, ParameterDirection.Input)
            idbparameter(1).Value = prmPassword

            Try
                pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_UPDATE_FORGOTTEN_PASSWORD", idbparameter)
                'Commit and close the transaction
                objTransaction.Commit()
                objConnection.Close()
                Return True

            Catch ex As Exception
                'If any error roll back the transaction
                objTransaction.Rollback()
                objConnection.Close()
                System.Diagnostics.Debug.WriteLine(ex.Message)
                ' Return 
                Return False
                Exit Function
            End Try

        End If
        Return True

    End Function

    Public Function CheckPassword(ByVal prmMemberID As Integer, ByVal prmUserPassword As Byte()) As Boolean
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet
        Dim dr As DataRow
        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            ' Dim strQry As String
            ' strQry = "Select MemberID from Member where MemberId=" & prmMemberID.ToString & " [Password]='" & 
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 10, ParameterDirection.Input)
            idbparameter(0).Value = prmMemberID

            idbparameter(1) = GlobalData.DataHelper.GetParameter("@UserPwd", DbType.Binary, 20, ParameterDirection.Input)
            idbparameter(1).Value = prmUserPassword

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.Text, "USP_CHECK_PASS", idbparameter)
            myDatatable = ds.Tables(0)
            If myDatatable.Rows.Count > 0 Then
                dr = myDatatable.Rows(0)
                MemberID = dr("MemberID")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

#End Region

#Region "Check Login authentication"

    Public Function IsValidMember(ByVal prmUserName As String, ByVal prmUserPassword As Byte()) As Boolean
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet
        Dim dr As DataRow
        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@UserName", DbType.String, 20, ParameterDirection.Input)
            idbparameter(0).Value = prmUserName
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@UserPwd", DbType.Binary, 20, ParameterDirection.Input)
            idbparameter(1).Value = prmUserPassword

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_ValidMember", idbparameter)
            myDatatable = ds.Tables(0)
            If myDatatable.Rows.Count > 0 Then
                dr = myDatatable.Rows(0)
                MemberID = dr("MemberID")
                MemberName = dr("MemberName")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

#End Region

#Region "Get Members function"

    Public Function GetMembers(Optional ByVal Member_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtMembers As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If Member_ID = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MEMBERS")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = Member_ID
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MEMBERS", idbparameter)
            End If
            dtMembers = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtMembers
    End Function

    Public Function GetUserNameInfo(ByVal strUserName As String) As DataTable

        Dim idbparameter(1) As IDataParameter
        Dim dsMember As New DataSet
        Dim dtMember As New DataTable

        Try
            pi_helper = GlobalData.DataHelper
            If (strUserName <> Nothing) Or (strUserName <> "") Then
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@UserName", DbType.String, 50, ParameterDirection.Input)
                idbparameter(0).Value = strUserName
                dsMember = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_USERNAME_INFO", idbparameter)
            End If
            dtMember = dsMember.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

        ' Return the table
        Return dtMember

    End Function

    Public Function GetMemberID(ByVal prm_MemberGUID As GUID) As Integer
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtCampaign As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@MemberGUID", DbType.Guid, 50, ParameterDirection.Input)
            idbparameter(0).Value = prm_MemberGUID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_MEMBER_ID", idbparameter)
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0).Rows(0)(0)
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Return 0 'No campaign id
        End Try

    End Function

#End Region

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub

End Class
