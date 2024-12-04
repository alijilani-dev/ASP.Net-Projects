Imports GotDotNet.ApplicationBlocks.Data
Public Class clsGroup

#Region "Private Variables"

    Private pi_int_Group_id As Integer
    Private pi_str_Group_name As String
    Private pi_int_Member_id As Integer
    Private pi_int_isVisible As Boolean
    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property GroupID() As Integer
        Get
            Return pi_int_Group_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_Group_id = Value
        End Set
    End Property

    Public Property GroupName() As String
        Get
            Return pi_str_Group_name
        End Get
        Set(ByVal Value As String)
            pi_str_Group_name = Value
        End Set
    End Property
    Public Property MemberID() As Integer
        Get
            Return pi_int_Member_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_Member_id = Value
        End Set
    End Property
    Public Property isVisible() As Boolean
        Get
            Return pi_int_isVisible
        End Get
        Set(ByVal Value As Boolean)
            pi_int_isVisible = Value
        End Set
    End Property
#End Region

#Region "INSERT"

    Public Function Update(ByVal prm_Mode As Integer) As Boolean
        Dim idbparameter(3) As IDataParameter

        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        ''Added the parameters value into the collection
        idbparameter(0) = GlobalData.DataHelper.GetParameter("@Group_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(0).Value = Me.GroupID
        idbparameter(1) = GlobalData.DataHelper.GetParameter("@Group_name", DbType.String, 100, ParameterDirection.Input)
        idbparameter(1).Value = Me.GroupName
        idbparameter(2) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(2).Value = Me.MemberID
        idbparameter(3) = GlobalData.DataHelper.GetParameter("@isVisible", DbType.Boolean, 2, ParameterDirection.Input)
        idbparameter(3).Value = Me.isVisible
        Try
            If prm_Mode = 1 Then 'insert
                pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_INSERT_GROUP", idbparameter)
            ElseIf prm_Mode = 2 Then 'update
                pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_UPDATE_GROUP", idbparameter)
            End If

            ''Commit and close the transaction
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

    Public Function Delete() As Boolean
        Dim idbparameter(1) As IDataParameter

        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        ''Added the parameters value into the collection
        idbparameter(0) = GlobalData.DataHelper.GetParameter("@Group_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(0).Value = Me.GroupID
        idbparameter(1) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(1).Value = Me.MemberID

        Try
            pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_DELETE_GROUP", idbparameter)

            ''Commit and close the transaction
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
#End Region

#Region "Get Groups"
    Public Function GetGroups(Optional ByVal Member_ID As Integer = 0, Optional ByVal isVisible As Boolean = False, Optional ByVal Group_ID As Integer = 0) As DataTable
        Dim idbparameter(2) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtGroups As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Member_ID
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@isVisible", DbType.Boolean, 1, ParameterDirection.Input)
            idbparameter(1).Value = isVisible
            If Group_ID = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_GROUP", idbparameter)
            Else
                idbparameter(2) = GlobalData.DataHelper.GetParameter("@Group_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(2).Value = Group_ID
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_GROUP", idbparameter)
            End If
            dtGroups = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtGroups
    End Function

    Public Function GetAllGroupNames(ByVal Member_ID As Integer) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtGroups As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Member_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_GROUP_V2", idbparameter)
            dtGroups = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtGroups
    End Function

    Public Function CheckDuplicate() As Boolean
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet
        Dim nCount As Integer
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Me.MemberID

            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Group_Name", DbType.String, 100, ParameterDirection.Input)
            idbparameter(1).Value = Trim(Me.GroupName)
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_CHECK_DUPLICATE_GROUP", idbparameter)

            nCount = ds.Tables(0).Rows(0)(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return (nCount > 0)
    End Function
#End Region
    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub
End Class

