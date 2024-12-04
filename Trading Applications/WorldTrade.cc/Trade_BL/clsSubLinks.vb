Public Class Sublinks

#Region "Private Variables"

    Private pi_int_sub_links_id As Integer
    Private pi_int_main_links_id As Integer
    Private pi_str_sub_link_name As String
    Private pi_str_sub_link_url As String
    Private pi_str_sub_link_open_type As String


    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"


    Public Property sub_links_id() As Integer
        Get
            Return pi_int_sub_links_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_sub_links_id = Value
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

    Public Property sub_link_name() As String
        Get
            Return pi_str_sub_link_name
        End Get
        Set(ByVal Value As String)
            pi_str_sub_link_name = Value
        End Set
    End Property

    Public Property sub_link_url() As String
        Get
            Return pi_str_sub_link_url
        End Get
        Set(ByVal Value As String)
            pi_str_sub_link_url = Value
        End Set
    End Property

    Public Property sub_link_open_type() As String
        Get
            Return pi_str_sub_link_open_type
        End Get
        Set(ByVal Value As String)
            pi_str_sub_link_open_type = Value
        End Set
    End Property




#End Region

#Region "get Select ALL / SINGLE sub links"
    Public Function GetPortalSublinks(ByVal prm_portal_id As Integer, ByVal prm_Main_Links_ID As Integer) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Portal_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_portal_id
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Main_Links_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(1).Value = prm_Main_Links_ID

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_Portal_Main_Sub_Links", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    Public Function GetSublinks(Optional ByVal prm_Sub_Link_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_Sub_Link_ID = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_SUB_LINKS")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@sub_links_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_Sub_Link_ID
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_SUB_LINKS", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT Sublinks"

#End Region

#Region "DELETE Sublinks"

#End Region

#Region "UPDATE Sublinks"

#End Region

End Class
