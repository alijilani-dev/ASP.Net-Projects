Public Class AdvertisementType

#Region "Private Variables"

    Private pi_int_advert_type_id As Integer
    Private pi_str_advert_type As String


    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"


    Public Property advert_type_id() As Integer
        Get
            Return pi_int_advert_type_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_advert_type_id = Value
        End Set
    End Property

    Public Property advert_type() As String
        Get
            Return pi_str_advert_type
        End Get
        Set(ByVal Value As String)
            pi_str_advert_type = Value
        End Set
    End Property




#End Region

#Region "get Select ALL / SINGLE AdvertisementType"
    Public Function GetAdvertisemenType(Optional ByVal prm_advert_Type_id As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_advert_Type_id = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_ADVERTISEMENT_TYPE")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@advert_Type_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_advert_Type_id
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_ADVERTISEMENT_TYPE", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT AdvertisementType"

#End Region

#Region "DELETE AdvertisementType"

#End Region

#Region "UPDATE AdvertisementType"

#End Region
End Class
