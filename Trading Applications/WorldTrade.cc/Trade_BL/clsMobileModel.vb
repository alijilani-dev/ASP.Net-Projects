Public Class MobileModel

#Region "Private Variables"

    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

  Public Function GetBrandMobileModel(Optional ByVal prm_ManufCode As Long = 0) As DataTable
    Dim idbparameter(1) As IDataParameter
    Dim ds As New DataSet()

    ' Create and Fill the DataSet
    Dim myDatatable As New DataTable()
    Try
      pi_helper = GlobalData.DataHelper
      If prm_ManufCode = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_BrandMOBILEMODEL")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@ManufCode", DbType.Int64, 8, ParameterDirection.Input)
                idbparameter(0).Value = prm_ManufCode
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_BrandMOBILEMODEL", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
  End Function

  Public Function GetMobileModel(Optional ByVal prm_SrNo As Long = 0) As DataTable
    Dim idbparameter(1) As IDataParameter
    Dim ds As New DataSet()

    ' Create and Fill the DataSet
    Dim myDatatable As New DataTable()
    Try
      pi_helper = GlobalData.DataHelper
      If prm_SrNo = 0 Then
	ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MMOBILEMODEL")
      Else
	idbparameter(0) = GlobalData.DataHelper.GetParameter("@SrNo", DbType.Int64, 8, ParameterDirection.Input)
	idbparameter(0).Value = prm_SrNo
	ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MMOBILEMODEL", idbparameter)
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
