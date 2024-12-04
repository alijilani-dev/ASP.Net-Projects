Public Class MainLinks

#Region "Private Variables"

    Private pi_int_main_links_id As Integer
    Private pi_int_portal_id As Integer
    Private pi_str_link_name As String
    Private pi_str_link_url As String
    Private pi_str_link_open_type As String
    Private pi_int_show_flag As Integer
    Private pi_str_Img_url As String
    Private pi_str_Img_url_MouseOver As String
    Private pi_int_Row_Position As Integer
    Private pi_int_Redirect_Main_Link_ID As Integer
    Private pi_int_Links_Seq As Integer


    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"


    Public Property main_links_id() As Integer
        Get
            Return pi_int_main_links_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_main_links_id = Value
        End Set
    End Property

    Public Property portal_id() As Integer
        Get
            Return pi_int_portal_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_portal_id = Value
        End Set
    End Property

    Public Property link_name() As String
        Get
            Return pi_str_link_name
        End Get
        Set(ByVal Value As String)
            pi_str_link_name = Value
        End Set
    End Property

    Public Property link_url() As String
        Get
            Return pi_str_link_url
        End Get
        Set(ByVal Value As String)
            pi_str_link_url = Value
        End Set
    End Property

    Public Property link_open_type() As String
        Get
            Return pi_str_link_open_type
        End Get
        Set(ByVal Value As String)
            pi_str_link_open_type = Value
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

    Public Property Img_url() As String
        Get
            Return pi_str_Img_url
        End Get
        Set(ByVal Value As String)
            pi_str_Img_url = Value
        End Set
    End Property
    Public Property Img_url_MouseOver() As String
        Get
            Return pi_str_Img_url_MouseOver
        End Get
        Set(ByVal Value As String)
            pi_str_Img_url_MouseOver = Value
        End Set
    End Property
    Public Property Row_Position() As Integer
        Get
            Return pi_int_Row_Position
        End Get
        Set(ByVal Value As Integer)
            pi_int_Row_Position = Value
        End Set
    End Property
    Public Property Redirect_Main_Link_ID() As Integer
        Get
            Return pi_int_Redirect_Main_Link_ID
        End Get
        Set(ByVal Value As Integer)
            pi_int_Redirect_Main_Link_ID = Value
        End Set
    End Property
    Public Property Links_Seq() As Integer
        Get
            Return pi_int_Links_Seq
        End Get
        Set(ByVal Value As Integer)
            pi_int_Links_Seq = Value
        End Set
    End Property



#End Region

#Region "Main module link constants"
    Private Const pi_str_Module_Links_ID As String = "Module_Links_ID"
    Private Const pi_str_module_id As String = "module_id"
    Private Const pi_str_main_links_id As String = "main_links_id"
    Private Const pi_str_sub_links_id As String = "sub_links_id"
    Private Const pi_str_Module_Position As String = "Module_Position"
    Private Const pi_str_Show_flag As String = "Show_flag"
#End Region

#Region "get Select ALL / SINGLE main links"
    Public Function GetPortalMainLinks(ByVal prm_portal_id As Integer, ByVal prm_Row_Position As Integer) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet
        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable

        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Portal_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_portal_id

            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Row_Position", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(1).Value = prm_Row_Position

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_Portal_Main_Links", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetMainLinks(Optional ByVal prm_Main_Links_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_Main_Links_ID = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MAIN_LINKS")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Main_Links_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_Main_Links_ID
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_MAIN_LINKS", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT Mainlinks"
    Public Function Insert() As Boolean

        Dim idb_Main_links_parameter(11) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@main_links_id int = NULL output,
        '@portal_id int = NULL,
        '@link_name varchar(50) = NULL,
        '@link_url varchar(100) = NULL,
        '@link_open_type varchar(20) = NULL,
        '@show_flag int = NULL,
        '@Img_url varchar(250) = NULL,
        '@Img_url_MouseOver varchar(250) = NULL,
        '@Row_Position int = NULL,
        '@Redirect_Main_Link_ID INT = 0,
        '@Links_Seq INT = 0

        idb_Main_links_parameter(0) = GlobalData.DataHelper.GetParameter("@Main_links_id", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_Main_links_parameter(0).Value = Me.main_links_id

        idb_Main_links_parameter(1) = GlobalData.DataHelper.GetParameter("@portal_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Main_links_parameter(1).Value = Me.portal_id

        idb_Main_links_parameter(2) = GlobalData.DataHelper.GetParameter("@link_name", DbType.String, 50, ParameterDirection.Input)
        idb_Main_links_parameter(2).Value = Me.link_name

        idb_Main_links_parameter(3) = GlobalData.DataHelper.GetParameter("@link_url", DbType.String, 100, ParameterDirection.Input)
        idb_Main_links_parameter(3).Value = Me.link_url

        idb_Main_links_parameter(4) = GlobalData.DataHelper.GetParameter("@link_open_type", DbType.String, 20, ParameterDirection.Input)
        idb_Main_links_parameter(4).Value = Me.link_open_type

        idb_Main_links_parameter(5) = GlobalData.DataHelper.GetParameter("@show_flag", DbType.Int32, 4, ParameterDirection.Input)
        idb_Main_links_parameter(5).Value = Me.show_flag

        idb_Main_links_parameter(6) = GlobalData.DataHelper.GetParameter("@Img_url", DbType.String, 250, ParameterDirection.Input)
        idb_Main_links_parameter(6).Value = Me.Img_url

        idb_Main_links_parameter(7) = GlobalData.DataHelper.GetParameter("@Img_url_MouseOver", DbType.String, 250, ParameterDirection.Input)
        idb_Main_links_parameter(7).Value = Me.Img_url_MouseOver

        idb_Main_links_parameter(8) = GlobalData.DataHelper.GetParameter("@Row_Position", DbType.Int32, 4, ParameterDirection.Input)
        idb_Main_links_parameter(8).Value = Me.Row_Position

        idb_Main_links_parameter(9) = GlobalData.DataHelper.GetParameter("@Redirect_Main_Link_ID", DbType.Int32, 4, ParameterDirection.Input)
        idb_Main_links_parameter(9).Value = IIf(Me.Redirect_Main_Link_ID = 0, System.DBNull.Value, Me.Redirect_Main_Link_ID)

        idb_Main_links_parameter(10) = GlobalData.DataHelper.GetParameter("@Links_Seq", DbType.Int32, 4, ParameterDirection.Input)
        idb_Main_links_parameter(10).Value = Me.Links_Seq

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_INSERT_Main_links", idb_Main_links_parameter)
            Me.main_links_id = idb_Main_links_parameter(0).Value

            pi_IDBtra.Commit()

            pi_IDBcon.Close()
            ' Return 
            Return True

        Catch ex As Exception
            pi_IDBtra.Rollback()
            pi_IDBcon.Close()
            Throw ex
            ' Return 
            Return False
            Exit Function
        End Try
    End Function

#End Region

#Region "DELETE Mainlinks"

#End Region

#Region "UPDATE Mainlinks"
    Public Function Update() As Boolean

        Dim idb_Main_links_parameter(11) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@main_links_id int = NULL output,
        '@portal_id int = NULL,
        '@link_name varchar(50) = NULL,
        '@link_url varchar(100) = NULL,
        '@link_open_type varchar(20) = NULL,
        '@show_flag int = NULL,
        '@Img_url varchar(250) = NULL,
        '@Img_url_MouseOver varchar(250) = NULL,
        '@Row_Position int = NULL,
        '@Redirect_Main_Link_ID INT = 0,
        '@Links_Seq INT = 0

        idb_Main_links_parameter(0) = GlobalData.DataHelper.GetParameter("@Main_links_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Main_links_parameter(0).Value = Me.main_links_id

        idb_Main_links_parameter(1) = GlobalData.DataHelper.GetParameter("@portal_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Main_links_parameter(1).Value = Me.portal_id

        idb_Main_links_parameter(2) = GlobalData.DataHelper.GetParameter("@link_name", DbType.String, 50, ParameterDirection.Input)
        idb_Main_links_parameter(2).Value = Me.link_name

        idb_Main_links_parameter(3) = GlobalData.DataHelper.GetParameter("@link_url", DbType.String, 100, ParameterDirection.Input)
        idb_Main_links_parameter(3).Value = Me.link_url

        idb_Main_links_parameter(4) = GlobalData.DataHelper.GetParameter("@link_open_type", DbType.String, 20, ParameterDirection.Input)
        idb_Main_links_parameter(4).Value = Me.link_open_type

        idb_Main_links_parameter(5) = GlobalData.DataHelper.GetParameter("@show_flag", DbType.Int32, 4, ParameterDirection.Input)
        idb_Main_links_parameter(5).Value = Me.show_flag

        idb_Main_links_parameter(6) = GlobalData.DataHelper.GetParameter("@Img_url", DbType.String, 250, ParameterDirection.Input)
        idb_Main_links_parameter(6).Value = Me.Img_url

        idb_Main_links_parameter(7) = GlobalData.DataHelper.GetParameter("@Img_url_MouseOver", DbType.String, 250, ParameterDirection.Input)
        idb_Main_links_parameter(7).Value = Me.Img_url_MouseOver

        idb_Main_links_parameter(8) = GlobalData.DataHelper.GetParameter("@Row_Position", DbType.Int32, 4, ParameterDirection.Input)
        idb_Main_links_parameter(8).Value = Me.Row_Position

        idb_Main_links_parameter(9) = GlobalData.DataHelper.GetParameter("@Redirect_Main_Link_ID", DbType.Int32, 4, ParameterDirection.Input)
        idb_Main_links_parameter(9).Value = IIf(Me.Redirect_Main_Link_ID = 0, System.DBNull.Value, Me.Redirect_Main_Link_ID)

        idb_Main_links_parameter(10) = GlobalData.DataHelper.GetParameter("@Links_Seq", DbType.Int32, 4, ParameterDirection.Input)
        idb_Main_links_parameter(10).Value = Me.Links_Seq

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_UPDATE_Main_links", idb_Main_links_parameter)
            Me.main_links_id = idb_Main_links_parameter(0).Value

            pi_IDBtra.Commit()

            pi_IDBcon.Close()
            ' Return 
            Return True

        Catch ex As Exception
            pi_IDBtra.Rollback()
            pi_IDBcon.Close()
            Throw ex
            ' Return 
            Return False
            Exit Function
        End Try
    End Function

#End Region

#Region "Update Main Links Modules List"
    Public Function UpdateModuleLinks(ByVal main_Links_ID As Integer, ByVal dt_modules As DataTable) As Boolean
        Dim idb_ModuleLinks_parameter(6) As IDataParameter
        Dim dr As DataRow
        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.Text, "UPDATE Module_Links SET Show_Flag=0 WHERE Main_Links_ID =" & main_Links_ID)

        For Each dr In dt_modules.Rows

            '@Module_Links_ID int = NULL,
            '@module_id	int = NULL,
            '@main_links_id	int = NULL,
            '@sub_links_id	int = NULL,
            '@Module_Position varchar(20) = NULL,
            '@Show_flag	int = 1
            idb_ModuleLinks_parameter(0) = GlobalData.DataHelper.GetParameter("@Module_Links_ID", DbType.Int32, 4, ParameterDirection.Input)
            idb_ModuleLinks_parameter(0).Value = dr(pi_str_Module_Links_ID)

            idb_ModuleLinks_parameter(1) = GlobalData.DataHelper.GetParameter("@module_id", DbType.Int32, 4, ParameterDirection.Input)
            idb_ModuleLinks_parameter(1).Value = dr(pi_str_module_id)

            idb_ModuleLinks_parameter(2) = GlobalData.DataHelper.GetParameter("@main_links_id", DbType.Int32, 4, ParameterDirection.Input)
            idb_ModuleLinks_parameter(2).Value = dr(pi_str_main_links_id)

            If dr(pi_str_sub_links_id) = 0 Then
                idb_ModuleLinks_parameter(3) = GlobalData.DataHelper.GetParameter("@sub_links_id", DbType.Int32, 4, ParameterDirection.Input)
            Else
                idb_ModuleLinks_parameter(3) = GlobalData.DataHelper.GetParameter("@sub_links_id", DbType.Int32, 4, ParameterDirection.Input)
                idb_ModuleLinks_parameter(3).Value = dr(pi_str_sub_links_id)
            End If

            idb_ModuleLinks_parameter(4) = GlobalData.DataHelper.GetParameter("@Module_Position", DbType.String, 20, ParameterDirection.Input)
            idb_ModuleLinks_parameter(4).Value = dr(pi_str_Module_Position)

            idb_ModuleLinks_parameter(5) = GlobalData.DataHelper.GetParameter("@Show_flag", DbType.Int32, 4, ParameterDirection.Input)
            idb_ModuleLinks_parameter(5).Value = dr(pi_str_Show_flag)

            Try

                pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_UPDATE_Module_Links", idb_ModuleLinks_parameter)

            Catch ex As Exception
                pi_IDBtra.Rollback()
                pi_IDBcon.Close()
                Throw ex
                ' Return 
                Return False
                Exit Function
            End Try
        Next

        pi_IDBtra.Commit()
        pi_IDBcon.Close()
        Return True

    End Function

#End Region

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub
End Class
