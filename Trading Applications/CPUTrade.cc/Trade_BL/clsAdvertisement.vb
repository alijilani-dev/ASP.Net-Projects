Public Class Advertisement

#Region "Private Variables"

    Private pi_int_advert_id As Integer
    Private pi_int_module_id As Integer
    Private pi_str_member_id As String
    Private pi_str_advert_image_url As String
    Private pi_str_advert_alt_text As String
    Private pi_str_advert_priority As String
    Private pi_dat_timestamp As DateTime
    Private pi_int_advert_type_id As Integer
    Private pi_str_Ad_Position As String


    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property advert_id() As Integer
        Get
            Return pi_int_advert_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_advert_id = Value
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

    Public Property member_id() As String
        Get
            Return pi_str_member_id
        End Get
        Set(ByVal Value As String)
            pi_str_member_id = Value
        End Set
    End Property

    Public Property advert_image_url() As String
        Get
            Return pi_str_advert_image_url
        End Get
        Set(ByVal Value As String)
            pi_str_advert_image_url = Value
        End Set
    End Property

    Public Property advert_alt_text() As String
        Get
            Return pi_str_advert_alt_text
        End Get
        Set(ByVal Value As String)
            pi_str_advert_alt_text = Value
        End Set
    End Property

    Public Property advert_priority() As String
        Get
            Return pi_str_advert_priority
        End Get
        Set(ByVal Value As String)
            pi_str_advert_priority = Value
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

    Public Property advert_type_id() As Integer
        Get
            Return pi_int_advert_type_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_advert_type_id = Value
        End Set
    End Property

    Public Property Ad_Position() As String
        Get
            Return pi_str_Ad_Position
        End Get
        Set(ByVal Value As String)
            pi_str_Ad_Position = Value
        End Set
    End Property
#End Region

#Region "get Select ALL / SINGLE Advertisement"
    Public Function GetModuleAdvertisement(ByVal prm_Module_ID As Integer, ByVal prm_PlaceHolder As String, ByVal prm_Ad_Type As String) As DataTable
        Dim idbparameter(3) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Module_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Module_ID

            idbparameter(1) = GlobalData.DataHelper.GetParameter("@PlaceHolder", DbType.String, 50, ParameterDirection.Input)
            idbparameter(1).Value = prm_PlaceHolder

            idbparameter(2) = GlobalData.DataHelper.GetParameter("@Ad_Type", DbType.String, 50, ParameterDirection.Input)
            idbparameter(2).Value = prm_Ad_Type

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_Advertisements", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetAdvertisement(Optional ByVal prm_advert_id As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_advert_id = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_ADVERTISEMENT")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@advert_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_advert_id
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_ADVERTISEMENT", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT Advertisement"
    Public Function Insert() As Boolean

        Dim idb_Advertisement_parameter(9) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@advert_id int = NULL output,
        '@module_id int = NULL,
        '@member_id varchar(20) = NULL,
        '@advert_image_url varchar(200) = NULL,
        '@advert_alt_text varchar(100) = NULL,
        '@advert_priority varchar(2) = NULL,
        '@timestamp datetime = NULL,
        '@advert_type_id int = NULL,
        '@ad_Position varchar(50) = NULL

        idb_Advertisement_parameter(0) = GlobalData.DataHelper.GetParameter("@advert_id", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_Advertisement_parameter(0).Value = Me.advert_id

        idb_Advertisement_parameter(1) = GlobalData.DataHelper.GetParameter("@module_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Advertisement_parameter(1).Value = Me.module_id

        idb_Advertisement_parameter(2) = GlobalData.DataHelper.GetParameter("@member_id", DbType.String, 20, ParameterDirection.Input)
        idb_Advertisement_parameter(2).Value = Me.member_id

        idb_Advertisement_parameter(3) = GlobalData.DataHelper.GetParameter("@advert_image_url", DbType.String, 200, ParameterDirection.Input)
        idb_Advertisement_parameter(3).Value = Me.advert_image_url

        idb_Advertisement_parameter(4) = GlobalData.DataHelper.GetParameter("@advert_alt_text", DbType.String, 100, ParameterDirection.Input)
        idb_Advertisement_parameter(4).Value = Me.advert_alt_text

        idb_Advertisement_parameter(5) = GlobalData.DataHelper.GetParameter("@advert_priority", DbType.String, 2, ParameterDirection.Input)
        idb_Advertisement_parameter(5).Value = Me.advert_priority

        idb_Advertisement_parameter(6) = GlobalData.DataHelper.GetParameter("@timestamp", DbType.DateTime, 8, ParameterDirection.Input)
        idb_Advertisement_parameter(6).Value = DateTime.Now

        idb_Advertisement_parameter(7) = GlobalData.DataHelper.GetParameter("@advert_type_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Advertisement_parameter(7).Value = Me.advert_type_id

        idb_Advertisement_parameter(8) = GlobalData.DataHelper.GetParameter("@ad_Position", DbType.String, 50, ParameterDirection.Input)
        idb_Advertisement_parameter(8).Value = Me.Ad_Position

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_INSERT_ADVERTISEMENT", idb_Advertisement_parameter)
            Me.advert_id = idb_Advertisement_parameter(0).Value

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

#Region "DELETE Advertisement"
    Public Function Delete(Optional ByVal prmad_Id As Integer = 0) As Boolean

        Dim idb_Advertisement_parameter(1) As IDataParameter

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@advert_id int = NULL

        If prmad_Id = 0 Then
            idb_Advertisement_parameter(0) = GlobalData.DataHelper.GetParameter("@advert_id", DbType.Int32, 4, ParameterDirection.Input)
            idb_Advertisement_parameter(0).Value = Me.advert_id
        Else
            idb_Advertisement_parameter(0) = GlobalData.DataHelper.GetParameter("@advert_id", DbType.Int32, 4, ParameterDirection.Input)
            idb_Advertisement_parameter(0).Value = prmad_Id
        End If

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_DELETE_ADVERTISEMENT", idb_Advertisement_parameter)

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

#Region "UPDATE Advertisement"
    Public Function Update() As Boolean

        Dim idb_Advertisement_parameter(9) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@advert_id int = NULL ,
        '@module_id int = NULL,
        '@member_id varchar(20) = NULL,
        '@advert_image_url varchar(200) = NULL,
        '@advert_alt_text varchar(100) = NULL,
        '@advert_priority varchar(2) = NULL,
        '@timestamp datetime = NULL,
        '@advert_type_id int = NULL,
        '@ad_Position varchar(50) = NULL

        idb_Advertisement_parameter(0) = GlobalData.DataHelper.GetParameter("@advert_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Advertisement_parameter(0).Value = Me.advert_id

        idb_Advertisement_parameter(1) = GlobalData.DataHelper.GetParameter("@module_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Advertisement_parameter(1).Value = Me.module_id

        idb_Advertisement_parameter(2) = GlobalData.DataHelper.GetParameter("@member_id", DbType.String, 20, ParameterDirection.Input)
        idb_Advertisement_parameter(2).Value = Me.member_id

        idb_Advertisement_parameter(3) = GlobalData.DataHelper.GetParameter("@advert_image_url", DbType.String, 200, ParameterDirection.Input)
        idb_Advertisement_parameter(3).Value = Me.advert_image_url

        idb_Advertisement_parameter(4) = GlobalData.DataHelper.GetParameter("@advert_alt_text", DbType.String, 100, ParameterDirection.Input)
        idb_Advertisement_parameter(4).Value = Me.advert_alt_text

        idb_Advertisement_parameter(5) = GlobalData.DataHelper.GetParameter("@advert_priority", DbType.String, 2, ParameterDirection.Input)
        idb_Advertisement_parameter(5).Value = Me.advert_priority

        idb_Advertisement_parameter(6) = GlobalData.DataHelper.GetParameter("@timestamp", DbType.DateTime, 8, ParameterDirection.Input)
        idb_Advertisement_parameter(6).Value = DateTime.Now

        idb_Advertisement_parameter(7) = GlobalData.DataHelper.GetParameter("@advert_type_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Advertisement_parameter(7).Value = Me.advert_type_id

        idb_Advertisement_parameter(8) = GlobalData.DataHelper.GetParameter("@ad_Position", DbType.String, 50, ParameterDirection.Input)
        idb_Advertisement_parameter(8).Value = Me.Ad_Position

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_UPDATE_ADVERTISEMENT", idb_Advertisement_parameter)
            Me.advert_id = idb_Advertisement_parameter(0).Value

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
