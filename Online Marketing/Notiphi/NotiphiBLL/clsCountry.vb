Imports GotDotNet.ApplicationBlocks.Data
Public Class clsCountry
#Region "Private Variables"

    Private pi_int_Country_id As Integer
    Private pi_str_Country_name As String
    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property CountryID() As Integer
        Get
            Return pi_int_Country_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_Country_id = Value
        End Set
    End Property

    Public Property CountryName() As String
        Get
            Return pi_str_Country_name
        End Get
        Set(ByVal Value As String)
            pi_str_Country_name = Value
        End Set
    End Property


#End Region

    Public Function GetCountry(Optional ByVal Country_id As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtGroups As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Country_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Country_id

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_COUNTRY", idbparameter)

            dtGroups = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtGroups
    End Function

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub
End Class
