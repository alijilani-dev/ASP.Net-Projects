Imports GotDotNet.ApplicationBlocks.Data
Public Class clsPhoneBook

#Region "Private Variables"

    Private pi_str_Group_id As String 'Multiple group ids seperated by comma
    Private pi_int_ContactID As Integer
    Private pi_str_ContactName As String
    Private pi_str_ContactEmailID As String
    Private pi_str_ContactMobileNo As String
    Private pi_int_IsActive As Boolean

    Private pi_int_GroupIDsToDelete As String
    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property GroupID() As String
        Get
            Return pi_str_Group_id
        End Get
        Set(ByVal Value As String)
            pi_str_Group_id = Value
        End Set
    End Property
    Public Property ContactID() As Integer
        Get
            Return pi_int_ContactID
        End Get
        Set(ByVal Value As Integer)
            pi_int_ContactID = Value
        End Set
    End Property
    Public Property ContactName() As String
        Get
            Return pi_str_ContactName
        End Get
        Set(ByVal Value As String)
            pi_str_ContactName = Value
        End Set
    End Property
    Public Property ContactEmailID() As String
        Get
            Return pi_str_ContactEmailID
        End Get
        Set(ByVal Value As String)
            pi_str_ContactEmailID = Value
        End Set
    End Property
    Public Property ContactMobileNo() As String
        Get
            Return pi_str_ContactMobileNo
        End Get
        Set(ByVal Value As String)
            pi_str_ContactMobileNo = Value
        End Set
    End Property
    Public Property IsActive() As Boolean

        Get
            Return pi_int_IsActive
        End Get
        Set(ByVal Value As Boolean)
            pi_int_IsActive = Value
        End Set
    End Property

    Property GroupIDsToDelete() As String
        Get
            Return pi_int_GroupIDsToDelete
        End Get
        Set(ByVal Value As String)
            pi_int_GroupIDsToDelete = Value
        End Set
    End Property

#End Region

#Region "Insert"

    Public Function Update(ByVal prm_Mode As Integer) As Boolean
        Dim idbparameter(5) As IDataParameter
        Dim idbparameterGrpContact(1) As IDataParameter
        Dim strContactID As Integer

        ' prm_Mode
        ' prm_Mode = 1 - insert
        ' prm_Mode = 2 - update
        ' prm_Mode = 3 - delete

        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        'Added the parameters value into the collection
        If prm_Mode = 1 Then
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Contact_ID", DbType.Int32, 20, ParameterDirection.Output)
            idbparameter(0).Value = Me.ContactID
        ElseIf prm_Mode = 2 Then
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Contact_ID", DbType.Int32, 20, ParameterDirection.Input)
            idbparameter(0).Value = Me.ContactID
        End If
        idbparameter(1) = GlobalData.DataHelper.GetParameter("@Contact_Name", DbType.String, 100, ParameterDirection.Input)
        idbparameter(1).Value = Me.ContactName
        idbparameter(2) = GlobalData.DataHelper.GetParameter("@Contact_EmailID", DbType.String, 100, ParameterDirection.Input)
        idbparameter(2).Value = Me.ContactEmailID
        idbparameter(3) = GlobalData.DataHelper.GetParameter("@ContactMobileNo", DbType.String, 20, ParameterDirection.Input)
        idbparameter(3).Value = Me.ContactMobileNo
        idbparameter(4) = GlobalData.DataHelper.GetParameter("@Is_Active", DbType.Boolean, 0, ParameterDirection.Input)
        idbparameter(4).Value = Me.IsActive

        Try
            If prm_Mode = 1 Then 'insert
                pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_INSERT_PHONEBOOK", idbparameter)
            ElseIf prm_Mode = 2 Then 'update
                pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_UPDATE_PHONEBOOK", idbparameter)
            End If
            strContactID = idbparameter(0).Value
            '''Delete group contacts and insert 
            If prm_Mode = 2 And GroupIDsToDelete.ToString.Length > 0 Then
                For Each strGroupID As Integer In Split(GroupIDsToDelete, ",")

                    Dim idbParamdelete(1) As IDataParameter
                    idbParamdelete(0) = GlobalData.DataHelper.GetParameter("@Group_ID", DbType.Int32, 20, ParameterDirection.Input)
                    idbParamdelete(0).Value = strGroupID

                    idbParamdelete(1) = GlobalData.DataHelper.GetParameter("@Contact_ID", DbType.Int32, 20, ParameterDirection.Input)
                    idbParamdelete(1).Value = strContactID

                    pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_DELETE_GROUPCONTACT", idbParamdelete)

                Next
            End If '''end of delete  
            If GroupID.ToString.Length > 0 Then
                For Each strGroupID As Integer In Split(GroupID, ",")
                    idbparameterGrpContact(0) = GlobalData.DataHelper.GetParameter("@Contact_ID", DbType.Int32, 20, ParameterDirection.Input)
                    idbparameterGrpContact(0).Value = strContactID
                    idbparameterGrpContact(1) = GlobalData.DataHelper.GetParameter("@Group_ID", DbType.Int32, 20, ParameterDirection.Input)
                    idbparameterGrpContact(1).Value = strGroupID
                    pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_INSERT_GROUPCONTACT", idbparameterGrpContact)
                Next
            End If

            'Commit and close the transaction
            objTransaction.Commit()
            objConnection.Close()

            Return True

        Catch ex As Exception
            ''If any error roll back the transaction
            objTransaction.Rollback()
            objConnection.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try

    End Function

    Public Function UpdateUnsubscribeStatus(ByVal Contact_ID As Integer) As Boolean

        Dim idbparameter(1) As IDataParameter

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        Try
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Contact_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(1).Value = Contact_ID

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_UPDATE_UNSUBSCRIBE", idbparameter)

            pi_IDBtra.Commit()

            pi_IDBcon.Close()
            ' Return 
            Return True

        Catch ex As Exception
            pi_IDBtra.Rollback()
            pi_IDBcon.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Return False
            Exit Function
        End Try

    End Function

#End Region

#Region "Delete"

    Public Function DeleteGroupContact(Optional ByVal Group_ID As Integer = 0, Optional ByVal Contact_ID As Integer = 0) As Boolean

        Dim idbparameter(1) As IDataParameter

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        Try
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Group_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Group_ID

            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Contact_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(1).Value = Contact_ID

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_DELETE_GROUPCONTACT", idbparameter)

            pi_IDBtra.Commit()

            pi_IDBcon.Close()
            ' Return 
            Return True

        Catch ex As Exception
            pi_IDBtra.Rollback()
            pi_IDBcon.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Return False
            Exit Function
        End Try

    End Function

#End Region

#Region "Get Groups' contact"
    Public Function GetPhoneBook(ByVal prmContact_ID As Integer) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtGroupContacts As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Contact_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prmContact_ID

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PHONEBOOK", idbparameter)
            dtGroupContacts = ds.Tables(0)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        ' Return the table
        Return dtGroupContacts
    End Function

    Public Function GetGroupContact(Optional ByVal Member_ID As Integer = 0, Optional ByVal Group_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtGroupContacts As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Member_ID

            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Group_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(1).Value = Group_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_GROUPCONTACT", idbparameter)
            dtGroupContacts = ds.Tables(0)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        ' Return the table
        Return dtGroupContacts

    End Function

    Public Function GetGroupContactByID(ByVal prmContactID As Integer) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtGroupContacts As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@ContactID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prmContactID

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_GROUPCONTACT_BYCONTACTID", idbparameter)
            dtGroupContacts = ds.Tables(0)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        ' Return the table
        Return dtGroupContacts

    End Function
#End Region

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub

End Class
