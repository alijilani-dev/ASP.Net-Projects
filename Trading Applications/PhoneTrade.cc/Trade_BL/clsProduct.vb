Public Class Product

#Region "Private Variables"

    Private pi_int_product_id As Integer
    Private pi_int_module_id As Integer
    Private pi_str_product_name As String
    Private pi_str_product_short_image_url As String
    Private pi_str_product_short_desc As String
    Private pi_str_product_big_image_url As String
    Private pi_str_product_desc As String
    Private pi_str_product_web_url As String
    Private pi_dat_timestamp As DateTime


    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"


    Public Property product_id() As Integer
        Get
            Return pi_int_product_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_product_id = Value
        End Set
    End Property

    Public Property module_id() As Integer
        Get
            Return pi_int_module_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_module_id = Value
        End Set
    End Property

    Public Property product_name() As String
        Get
            Return pi_str_product_name
        End Get
        Set(ByVal Value As String)
            pi_str_product_name = Value
        End Set
    End Property

    Public Property product_short_image_url() As String
        Get
            Return pi_str_product_short_image_url
        End Get
        Set(ByVal Value As String)
            pi_str_product_short_image_url = Value
        End Set
    End Property

    Public Property product_short_desc() As String
        Get
            Return pi_str_product_short_desc
        End Get
        Set(ByVal Value As String)
            pi_str_product_short_desc = Value
        End Set
    End Property

    Public Property product_big_image_url() As String
        Get
            Return pi_str_product_big_image_url
        End Get
        Set(ByVal Value As String)
            pi_str_product_big_image_url = Value
        End Set
    End Property

    Public Property product_desc() As String
        Get
            Return pi_str_product_desc
        End Get
        Set(ByVal Value As String)
            pi_str_product_desc = Value
        End Set
    End Property

    Public Property product_web_url() As String
        Get
            Return pi_str_product_web_url
        End Get
        Set(ByVal Value As String)
            pi_str_product_web_url = Value
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

#Region "get Select ALL / SINGLE Product"
    Public Function GetModuleProduct(ByVal prm_Module_ID As Integer) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Module_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Module_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_Products", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetProduct(Optional ByVal prm_Product_id As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_Product_id = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PRODUCTS")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Contact_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_Product_id
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PRODUCTS", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT Product"

#End Region

#Region "DELETE Product"

#End Region

#Region "UPDATE Product"

#End Region

End Class
