Imports GotDotNet.ApplicationBlocks.Data
Public Class clsCredit

#Region "Private Variables"

    Private pi_int_Master_Code As Integer
    Private pi_int_Child_Code As Integer
    Private pi_int_Member_id As Integer
    Private pi_str_DateLastPurchased As String
    Private pi_int_TotalCredits As Integer
    Private pi_int_Rate As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property ChildCode() As Integer
        Get
            Return pi_int_Child_Code
        End Get
        Set(ByVal Value As Integer)
            pi_int_Child_Code = Value
        End Set
    End Property
    Public Property MasterCode() As Integer
        Get
            Return pi_int_Master_Code
        End Get
        Set(ByVal Value As Integer)
            pi_int_Master_Code = Value
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
    Public Property DateLastPurchased() As String
        Get
            Return pi_str_DateLastPurchased
        End Get
        Set(ByVal Value As String)
            pi_str_DateLastPurchased = Value
        End Set
    End Property
    Public Property TotalCredits() As Integer
        Get
            Return pi_int_TotalCredits
        End Get
        Set(ByVal Value As Integer)
            pi_int_TotalCredits = Value
        End Set
    End Property
    Public Property Rate() As Integer
        Get
            Return pi_int_Rate
        End Get
        Set(ByVal Value As Integer)
            pi_int_Rate = Value
        End Set
    End Property

#End Region

#Region "INSERT"

    Public Function AddUserCredits(ByVal nCredits As Integer, ByVal nMember_Id As Integer) As Boolean

        If nMember_Id <> Nothing Then
            Dim idbMasterParams(3) As IDataParameter
            Dim idbChildParams(6) As IDataParameter
            Dim objTransaction As IDbTransaction
            Dim objConnection As IDbConnection

            objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
            objConnection.Open()
            objTransaction = objConnection.BeginTransaction()

            If (Me.MasterCode = Nothing) Or (Me.MasterCode <= 0) Then
                Return False
            End If

            '''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Added the parameters value into the Child collection
            idbChildParams(0) = GlobalData.DataHelper.GetParameter("@Child_Code", DbType.Int32, 20, ParameterDirection.InputOutput)
            idbChildParams(1) = GlobalData.DataHelper.GetParameter("@Master_Code", DbType.Int32, 20, ParameterDirection.Input)
            idbChildParams(1).Value = Me.MasterCode
            idbChildParams(2) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 20, ParameterDirection.Input)
            idbChildParams(2).Value = Me.MemberID
            idbChildParams(3) = GlobalData.DataHelper.GetParameter("@DatePurchased", DbType.DateTime, 8, ParameterDirection.Input)
            idbChildParams(3).Value = Me.DateLastPurchased
            idbChildParams(4) = GlobalData.DataHelper.GetParameter("@CreditsCount", DbType.Int32, 20, ParameterDirection.Input)
            idbChildParams(4).Value = Me.TotalCredits
            idbChildParams(5) = GlobalData.DataHelper.GetParameter("@AtRateOf", DbType.Int32, 20, ParameterDirection.Input)
            idbChildParams(5).Value = Me.Rate

            Try
                pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_INSERT_CHILD_CREDIT", idbChildParams)
                Me.ChildCode = idbChildParams(0).Value
                'Commit and close the transaction
                'objTransaction.Commit()
                'objConnection.Close()
                'Return True
            Catch ex As Exception
                'If any error roll back the transaction
                objTransaction.Rollback()
                objConnection.Close()
                System.Diagnostics.Debug.WriteLine(ex.Message)
                'Return 
                Return False
                Exit Function
            End Try

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Added the parameters value into the Master collection
            idbMasterParams(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 20, ParameterDirection.Input)
            idbMasterParams(0).Value = Me.MemberID
            idbMasterParams(1) = GlobalData.DataHelper.GetParameter("@Dated", DbType.DateTime, 100, ParameterDirection.Input)
            idbMasterParams(1).Value = Me.DateLastPurchased
            idbMasterParams(2) = GlobalData.DataHelper.GetParameter("@CreditsCount", DbType.Int32, 20, ParameterDirection.Input)
            idbMasterParams(2).Value = Me.TotalCredits

            Try
                pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_ADD_CREDIT", idbMasterParams)
                'Commit and close the transaction
                objTransaction.Commit()
                objConnection.Close()
                Return True
            Catch ex As Exception
                'If any error roll back the transaction
                objTransaction.Rollback()
                objConnection.Close()
                System.Diagnostics.Debug.WriteLine(ex.Message)
                'Return 
                Return False
                Exit Function
            End Try

        Else
            Return False
        End If

    End Function

#End Region

#Region "Get Credits"

    Public Function GetMemberCredit(Optional ByVal Member_ID As Integer = 0, Optional ByVal isVisible As Boolean = False, Optional ByVal Group_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtGroups As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Member_ID
            'idbparameter(1) = GlobalData.DataHelper.GetParameter("@isVisible", DbType.Boolean, 1, ParameterDirection.Input)
            'idbparameter(1).Value = isVisible
            'idbparameter(2) = GlobalData.DataHelper.GetParameter("@Group_id", DbType.Int32, 4, ParameterDirection.Input)
            'idbparameter(2).Value = MasterCode
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MEMBER_CREDIT", idbparameter)
            dtGroups = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtGroups
    End Function

    Public Function GetCreditRateList(Optional ByVal nSerial_No As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtCredits As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If (nSerial_No <> Nothing) And (nSerial_No <> 0) Then
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@serial_no", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = nSerial_No
            End If
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_RATELIST", idbparameter)
            dtCredits = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

        ' Return the table
        Return dtCredits
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
            idbparameter(1).Value = Trim(Me.DateLastPurchased)
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