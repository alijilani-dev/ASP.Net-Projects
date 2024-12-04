Public Class Content

#Region "Private Variables"

    Private pi_int_content_id As Integer
    Private pi_int_module_id As Integer
    Private pi_int_Portal_id As Integer
    Private pi_str_content_image_url As String
    Private pi_str_content_text_url As String
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


    Public Property content_id() As Integer
        Get
            Return pi_int_content_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_content_id = Value
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

    Public Property Portal_id() As Integer
        Get
            Return pi_int_Portal_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_Portal_id = Value
        End Set
    End Property


    Public Property content_image_url() As String
        Get
            Return pi_str_content_image_url
        End Get
        Set(ByVal Value As String)
            pi_str_content_image_url = Value
        End Set
    End Property

    Public Property content_text_url() As String
        Get
            Return pi_str_content_text_url
        End Get
        Set(ByVal Value As String)
            pi_str_content_text_url = Value
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


#Region "get Select ALL / SINGLE content"
    Public Function GetModuleContent(ByVal prm_Module_ID As Integer, Optional ByVal prm_Portal_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Module_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Module_ID

            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Portal_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(1).Value = prm_Portal_ID

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_Contents", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetContent(Optional ByVal vid As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If vid = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_CONTENT")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Content_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = vid
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_CONTENT", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT content"

#End Region

#Region "DELETE content"

#End Region

#Region "UPDATE content"

#End Region

End Class
