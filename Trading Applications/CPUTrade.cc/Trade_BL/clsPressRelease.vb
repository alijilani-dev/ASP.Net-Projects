Public Class PressRelease

#Region "Private Variables"

    Private pi_int_press_release_id As Integer
    Private pi_int_module_id As Integer
    Private pi_str_press_release_image As String
    Private pi_str_press_release_text As String
    Private pi_str_press_release_Detail As String
    Private pi_dat_timestamp As DateTime

    Private pi_bln_Show_Flag As Boolean


    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"


    Public Property press_release_id() As Integer
        Get
            Return pi_int_press_release_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_press_release_id = Value
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

    Public Property press_release_image() As String
        Get
            Return pi_str_press_release_image
        End Get
        Set(ByVal Value As String)
            pi_str_press_release_image = Value
        End Set
    End Property

    Public Property press_release_text() As String
        Get
            Return pi_str_press_release_text
        End Get
        Set(ByVal Value As String)
            pi_str_press_release_text = Value
        End Set
    End Property

    Public Property press_release_Detail() As String
        Get
            Return pi_str_press_release_Detail
        End Get
        Set(ByVal Value As String)
            pi_str_press_release_Detail = Value
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

    Public Property Show_Flag() As Boolean
        Get
            Return pi_bln_Show_Flag
        End Get
        Set(ByVal Value As Boolean)
            pi_bln_Show_Flag = Value
        End Set
    End Property


#End Region

#Region "get Select ALL / SINGLE PressRelease"
    Public Function GetModulePressRelease(ByVal prm_Module_ID As Integer) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Module_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Module_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_Press_Releases", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetPressRelease(Optional ByVal prm_PressRelease_id As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_PressRelease_id = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PRESS_RELEASE")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@press_release_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_PressRelease_id
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PRESS_RELEASE", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT Press Release"
    Public Function Insert() As Boolean

        Dim idb_pressrelease_parameter(7) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '       @press_release_id int = NULL output,
        '@module_id int = NULL,
        '@press_release_image varchar(50) = NULL,
        '@press_release_text varchar(200) = NULL,
        '@press_release_detail  varchar(1000) = NULL,
        '@timestamp datetime = NULL,
        '@Show_Flag INT =0

        idb_pressrelease_parameter(0) = GlobalData.DataHelper.GetParameter("@press_release_id", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_pressrelease_parameter(0).Value = Me.press_release_id
        idb_pressrelease_parameter(1) = GlobalData.DataHelper.GetParameter("@module_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_pressrelease_parameter(1).Value = Me.module_id
        idb_pressrelease_parameter(2) = GlobalData.DataHelper.GetParameter("@press_release_image", DbType.String, 50, ParameterDirection.Input)
        idb_pressrelease_parameter(2).Value = Me.press_release_image
        idb_pressrelease_parameter(3) = GlobalData.DataHelper.GetParameter("@press_release_text", DbType.String, 200, ParameterDirection.Input)
        idb_pressrelease_parameter(3).Value = Me.press_release_text
        idb_pressrelease_parameter(4) = GlobalData.DataHelper.GetParameter("@press_release_detail", DbType.String, 1000, ParameterDirection.Input)
        idb_pressrelease_parameter(4).Value = Me.press_release_Detail
        idb_pressrelease_parameter(5) = GlobalData.DataHelper.GetParameter("@timestamp", DbType.DateTime, 8, ParameterDirection.Input)
        idb_pressrelease_parameter(5).Value = DateTime.Now
        idb_pressrelease_parameter(6) = GlobalData.DataHelper.GetParameter("@show_flag", DbType.Int32, 4, ParameterDirection.Input)
        idb_pressrelease_parameter(6).Value = Me.Show_Flag

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_INSERT_PRESS_RELEASE", idb_pressrelease_parameter)
            Me.press_release_id = idb_pressrelease_parameter(0).Value

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

#Region "DELETE Press Release"
    Public Function Delete(Optional ByVal prm_press_release_id As Integer = 0) As Boolean

        Dim idb_pressrelease_parameter(1) As IDataParameter

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@ann_id int = NULL

        If prm_press_release_id = 0 Then
            idb_pressrelease_parameter(0) = GlobalData.DataHelper.GetParameter("@press_release_id", DbType.Int32, 4, ParameterDirection.Input)
            idb_pressrelease_parameter(0).Value = Me.press_release_id
        Else
            idb_pressrelease_parameter(0) = GlobalData.DataHelper.GetParameter("@press_release_id", DbType.Int32, 4, ParameterDirection.Input)
            idb_pressrelease_parameter(0).Value = prm_press_release_id
        End If

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_DELETE_PRESS_RELEASE", idb_pressrelease_parameter)

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

#Region "UPDATE Press Release"
    Public Function Update() As Boolean

        Dim idb_pressrelease_parameter(7) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '       @press_release_id int = NULL output,
        '@module_id int = NULL,
        '@press_release_image varchar(50) = NULL,
        '@press_release_text varchar(200) = NULL,
        '@press_release_detail  varchar(1000) = NULL,
        '@timestamp datetime = NULL,
        '@Show_Flag INT =0

        idb_pressrelease_parameter(0) = GlobalData.DataHelper.GetParameter("@press_release_id", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_pressrelease_parameter(0).Value = Me.press_release_id
        idb_pressrelease_parameter(1) = GlobalData.DataHelper.GetParameter("@module_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_pressrelease_parameter(1).Value = Me.module_id
        idb_pressrelease_parameter(2) = GlobalData.DataHelper.GetParameter("@press_release_image", DbType.String, 50, ParameterDirection.Input)
        idb_pressrelease_parameter(2).Value = Me.press_release_image
        idb_pressrelease_parameter(3) = GlobalData.DataHelper.GetParameter("@press_release_text", DbType.String, 200, ParameterDirection.Input)
        idb_pressrelease_parameter(3).Value = Me.press_release_text
        idb_pressrelease_parameter(4) = GlobalData.DataHelper.GetParameter("@press_release_detail", DbType.String, 1000, ParameterDirection.Input)
        idb_pressrelease_parameter(4).Value = Me.press_release_Detail
        idb_pressrelease_parameter(5) = GlobalData.DataHelper.GetParameter("@timestamp", DbType.DateTime, 8, ParameterDirection.Input)
        idb_pressrelease_parameter(5).Value = DateTime.Now
        idb_pressrelease_parameter(6) = GlobalData.DataHelper.GetParameter("@show_flag", DbType.Int32, 4, ParameterDirection.Input)
        idb_pressrelease_parameter(6).Value = Me.Show_Flag


        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_INSERT_PRESS_RELEASE", idb_pressrelease_parameter)

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
