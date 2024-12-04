
Public Class LatestMobiles

#Region "Private Variables"

    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

    Public Function GetLatestMobiles(Optional ByVal prm_SrNo As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_SrNo = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_LatestMobiles")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@SrNo", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_SrNo
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_LatestMobiles", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub
End Class
