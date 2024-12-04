Imports GotDotNet.ApplicationBlocks.Data
Public Class clsUserCreditMaster

#Region "Private Variables"

    Private pi_int_UserCreditMasterCode As Integer
    Private pi_int_MemberID As Integer
    Private pi_int_TotalCredits As String

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property UserCreditMasterCode() As Integer
        Get
            Return pi_int_UserCreditMasterCode
        End Get
        Set(ByVal Value As Integer)
            pi_int_UserCreditMasterCode = Value
        End Set
    End Property

    Public Property MemberID() As Integer
        Get
            Return pi_int_MemberID
        End Get
        Set(ByVal Value As Integer)
            pi_int_MemberID = Value
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

#End Region

#Region "Update Methods"

    Public Function Insert() As Boolean

        Dim idbparameter(2) As IDataParameter

        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        ''Added the parameters value into the collection
        idbparameter(0) = GlobalData.DataHelper.GetParameter("@UserCreditMaster", DbType.Int32, 20, ParameterDirection.Output)
        idbparameter(0).Value = Me.UserCreditMasterCode

        idbparameter(1) = GlobalData.DataHelper.GetParameter("@MemberId", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(1).Value = Me.MemberID

        idbparameter(2) = GlobalData.DataHelper.GetParameter("@TotalCredits", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(2).Value = Me.TotalCredits

        Try
            pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_INSERT_USER_CREDIT_MASTER", idbparameter)

            ''Commit and close the transaction
            objTransaction.Commit()
            objConnection.Close()

            Return True

        Catch ex As Exception
            ''If any error roll back the transaction
            objTransaction.Rollback()
            objConnection.Close()
            ' System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try
    End Function

#End Region

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub

End Class
