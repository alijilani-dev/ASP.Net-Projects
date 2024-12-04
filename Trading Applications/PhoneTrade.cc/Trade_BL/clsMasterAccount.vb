Public Class MasterAccount

    '------- MASTER_ACCOUNT ----------


#Region "Private Variables"

    Private pi_str_username As String
    Private pi_str_password As String
    Private pi_intUserID As Integer
    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property username() As String
        Get
            Return pi_str_username
        End Get
        Set(ByVal Value As String)
            pi_str_username = Value
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

#End Region
    Public Function GetMasterAccount(Optional ByVal prm_MasterAccount_Code As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_MasterAccount_Code = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MasterAccount")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@MasterAccount_Code", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_MasterAccount_Code
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MasterAccount", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function IsValid(ByVal prmPortal_ID As Integer, ByVal prmUserName As String, ByVal prmUserPassword As String) As Boolean
        Dim idbparameter(2) As IDataParameter
        Dim ds As New DataSet
        Dim dr As DataRow
        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Portal_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = 0
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@UserName", DbType.String, 20, ParameterDirection.Input)
            idbparameter(1).Value = prmUserName
            idbparameter(2) = GlobalData.DataHelper.GetParameter("@UserPwd", DbType.String, 20, ParameterDirection.Input)
            idbparameter(2).Value = prmUserPassword

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Valid_MasterAccount", idbparameter)
            myDatatable = ds.Tables(0)
            If myDatatable.Rows.Count > 0 Then
                dr = myDatatable.Rows(0)
                If String.Compare(dr("username"), prmUserName) <= 0 And _
                        String.Compare(dr("password"), prmUserPassword) <= 0 Then
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

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub
End Class
