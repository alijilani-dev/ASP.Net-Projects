Public Class Announcement


#Region "Private Variables"

    Private pi_int_ann_id As Integer
    Private pi_str_ann_Heading As String
    Private pi_str_ann_text As String
    Private pi_str_ann_TextLink_Url As String
    Private pi_dat_timestamp As DateTime
    Private pi_int_module_id As Integer
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


    Public Property ann_id() As Integer
        Get
            Return pi_int_ann_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_ann_id = Value
        End Set
    End Property

    Public Property ann_text() As String
        Get
            Return pi_str_ann_text
        End Get
        Set(ByVal Value As String)
            pi_str_ann_text = Value
        End Set
    End Property

    Public Property ann_Heading() As String
        Get
            Return pi_str_ann_Heading
        End Get
        Set(ByVal Value As String)
            pi_str_ann_Heading = Value
        End Set
    End Property

    Public Property ann_TextLink_Url() As String
        Get
            Return pi_str_ann_TextLink_Url
        End Get
        Set(ByVal Value As String)
            pi_str_ann_TextLink_Url = Value
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

    Public Property module_id() As Integer
        Get
            Return pi_int_module_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_module_id = Value
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

#Region "get Select ALL / SINGLE Announcement"
    Public Function GetModuleAnnouncement(ByVal prm_Module_ID As Integer) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Module_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Module_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_Announcements", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetModuleAnnouncementTOPEST(Optional ByVal prm_no_News As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@No_News", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_no_News
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_Top_Announcements", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetAnnouncement(Optional ByVal prm_ann_id As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_ann_id = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_ANNOUNCEMENTS")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@ann_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_ann_id
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_ANNOUNCEMENTS", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT Announcement"
    Public Function Insert() As Boolean

        Dim idb_Announcement_parameter(7) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '       '	@ann_id int = NULL output,
        '@ann_Heading varchar(255) = NULL,
        '@ann_text varchar(1000) = NULL,
        '@ann_textLink_Url varchar(100) = NULL,
        '@timestamp datetime = NULL,
        '@module_id int = NULL,
        '@show_flag int = NULL

        idb_Announcement_parameter(0) = GlobalData.DataHelper.GetParameter("@ann_id", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_Announcement_parameter(0).Value = Me.ann_id
        idb_Announcement_parameter(1) = GlobalData.DataHelper.GetParameter("@ann_Heading", DbType.String, 255, ParameterDirection.Input)
        idb_Announcement_parameter(1).Value = Me.ann_Heading
        idb_Announcement_parameter(2) = GlobalData.DataHelper.GetParameter("@ann_text", DbType.String, 1000, ParameterDirection.Input)
        idb_Announcement_parameter(2).Value = Me.ann_text
        idb_Announcement_parameter(3) = GlobalData.DataHelper.GetParameter("@ann_textLink_Url", DbType.String, 100, ParameterDirection.Input)
        idb_Announcement_parameter(3).Value = Me.ann_TextLink_Url
        idb_Announcement_parameter(4) = GlobalData.DataHelper.GetParameter("@timestamp", DbType.DateTime, 8, ParameterDirection.Input)
        idb_Announcement_parameter(4).Value = DateTime.Now
        idb_Announcement_parameter(5) = GlobalData.DataHelper.GetParameter("@module_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Announcement_parameter(5).Value = Me.module_id
        idb_Announcement_parameter(6) = GlobalData.DataHelper.GetParameter("@show_flag", DbType.Int32, 4, ParameterDirection.Input)
        idb_Announcement_parameter(6).Value = Me.show_flag

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_INSERT_ANNOUNCEMENTS", idb_Announcement_parameter)

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

#Region "DELETE Announcement"
    Public Function Delete(Optional ByVal prmann_Id As Integer = 0) As Boolean

        Dim idb_Announcement_parameter(1) As IDataParameter

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@ann_id int = NULL

        If prmann_Id = 0 Then
            idb_Announcement_parameter(0) = GlobalData.DataHelper.GetParameter("@ann_id", DbType.Int32, 4, ParameterDirection.Input)
            idb_Announcement_parameter(0).Value = Me.ann_id
        Else
            idb_Announcement_parameter(0) = GlobalData.DataHelper.GetParameter("@ann_id", DbType.Int32, 4, ParameterDirection.Input)
            idb_Announcement_parameter(0).Value = prmann_Id
        End If

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_DELETE_ANNOUNCEMENTS", idb_Announcement_parameter)

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

#Region "UPDATE Announcement"
    Public Function Update() As Boolean

        Dim idb_Announcement_parameter(7) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '       '	@ann_id int = NULL output,
        '@ann_Heading varchar(255) = NULL,
        '@ann_text varchar(1000) = NULL,
        '@ann_textLink_Url varchar(100) = NULL,
        '@timestamp datetime = NULL,
        '@module_id int = NULL,
        '@show_flag int = NULL

        idb_Announcement_parameter(0) = GlobalData.DataHelper.GetParameter("@ann_id", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_Announcement_parameter(0).Value = Me.ann_id
        idb_Announcement_parameter(1) = GlobalData.DataHelper.GetParameter("@ann_Heading", DbType.String, 255, ParameterDirection.Input)
        idb_Announcement_parameter(1).Value = Me.ann_Heading
        idb_Announcement_parameter(2) = GlobalData.DataHelper.GetParameter("@ann_text", DbType.String, 1000, ParameterDirection.Input)
        idb_Announcement_parameter(2).Value = Me.ann_text
        idb_Announcement_parameter(3) = GlobalData.DataHelper.GetParameter("@ann_textLink_Url", DbType.String, 100, ParameterDirection.Input)
        idb_Announcement_parameter(3).Value = Me.ann_TextLink_Url
        idb_Announcement_parameter(4) = GlobalData.DataHelper.GetParameter("@timestamp", DbType.DateTime, 8, ParameterDirection.Input)
        idb_Announcement_parameter(4).Value = DateTime.Now
        idb_Announcement_parameter(5) = GlobalData.DataHelper.GetParameter("@module_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Announcement_parameter(5).Value = Me.module_id
        idb_Announcement_parameter(6) = GlobalData.DataHelper.GetParameter("@show_flag", DbType.Int32, 4, ParameterDirection.Input)
        idb_Announcement_parameter(6).Value = Me.show_flag

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_UPDATE_ANNOUNCEMENTS", idb_Announcement_parameter)

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

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub
End Class
