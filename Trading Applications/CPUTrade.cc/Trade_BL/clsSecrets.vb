Public Class Secret

#Region "Private Variables"

    Private pi_int_MS_id As Integer
    Private pi_int_MobileSrNo As Integer
    Private pi_str_MobileSecret As String
    Private pi_int_Portal_id As Integer
    Private pi_int_Status As Integer
    Private pi_dat_timestamp As DateTime

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"


    Public Property MS_id() As Integer
        Get
            Return pi_int_MS_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_MS_id = Value
        End Set
    End Property
    Public Property MobileSrNo() As Integer
        Get
            Return pi_int_MobileSrNo
        End Get
        Set(ByVal Value As Integer)
            pi_int_MobileSrNo = Value
        End Set
    End Property
    Public Property MobileSecret() As String
        Get
            Return pi_str_MobileSecret
        End Get
        Set(ByVal Value As String)
            pi_str_MobileSecret = Value
        End Set
    End Property
    Public Property Portal_id() As Integer
        Get
            Return pi_int_Portal_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_Portal_id = Value
        End Set
    End Property
    Public Property Status() As Integer
        Get
            Return pi_int_Status
        End Get
        Set(ByVal Value As Integer)
            pi_int_Status = Value
        End Set
    End Property

    Public Property timestamp() As DateTime
        Get
            Return pi_dat_timestamp
        End Get
        Set(ByVal Value As DateTime)
            pi_dat_timestamp = Value
        End Set
    End Property

#End Region


#Region "get Select ALL / SINGLE Secret"
    Public Function GetSecret(Optional ByVal vid As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If vid = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_MOBILESECRET")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@MS_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = vid
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_MOBILESECRET", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    Public Function GetSecret_Manufacturer() As DataTable

        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MMANUFACTURER_SECRET")
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT Secret"

#End Region

#Region "DELETE Secret"

#End Region

#Region "UPDATE Secret"

#End Region

End Class
