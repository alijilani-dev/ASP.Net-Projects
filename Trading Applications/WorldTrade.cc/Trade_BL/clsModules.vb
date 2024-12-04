Public Class Modules

#Region "Private Variables"

    Private pi_int_module_id As Integer
    Private pi_int_main_links_id As Integer
    Private pi_int_sub_links_id As Integer
    Private pi_str_module_name As String
    Private pi_str_module_url As String
    Private pi_int_module_priority As Integer
    Private pi_str_module_position As String
    Private pi_int_show_flag As Integer


    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"


    Public Property module_id() As Integer
        Get
            Return pi_int_module_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_module_id = Value
        End Set
    End Property

    Public Property main_links_id() As Integer
        Get
            Return pi_int_main_links_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_main_links_id = Value
        End Set
    End Property

    Public Property sub_links_id() As Integer
        Get
            Return pi_int_sub_links_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_sub_links_id = Value
        End Set
    End Property

    Public Property module_name() As String
        Get
            Return pi_str_module_name
        End Get
        Set(ByVal Value As String)
            pi_str_module_name = Value
        End Set
    End Property

    Public Property module_url() As String
        Get
            Return pi_str_module_url
        End Get
        Set(ByVal Value As String)
            pi_str_module_url = Value
        End Set
    End Property

    Public Property module_priority() As Integer
        Get
            Return pi_int_module_priority
        End Get
        Set(ByVal Value As Integer)
            pi_int_module_priority = Value
        End Set
    End Property

    Public Property module_position() As String
        Get
            Return pi_str_module_position
        End Get
        Set(ByVal Value As String)
            pi_str_module_position = Value
        End Set
    End Property

    Public Property show_flag() As Integer
        Get
            Return pi_int_show_flag
        End Get
        Set(ByVal Value As Integer)
            pi_int_show_flag = Value
        End Set
    End Property




#End Region


#Region "get Select ALL / SINGLE module"
    Public Function GetMainLinksModules(ByVal prm_main_links_id As Integer, Optional ByVal prm_Sub_links_id As Integer = 0, Optional ByVal postition As String = "0") As DataTable
        Dim idbparameter(2) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If postition = "0" Then
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Main_Link_ID", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_main_links_id
                idbparameter(1) = GlobalData.DataHelper.GetParameter("@Sub_Link_ID", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(1).Value = prm_Sub_links_id

            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Main_Link_ID", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_main_links_id
                idbparameter(1) = GlobalData.DataHelper.GetParameter("@Sub_Link_ID", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(1).Value = prm_Sub_links_id

                idbparameter(2) = GlobalData.DataHelper.GetParameter("@Module_Position", DbType.String, 20, ParameterDirection.Input)
                idbparameter(2).Value = postition
            End If
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_MainLinks_Modules", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetModule(Optional ByVal vid As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If vid = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MODULES")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Module_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = vid
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MODULES", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT module"

#End Region

#Region "DELETE module"

#End Region

#Region "UPDATE module"

#End Region

End Class
