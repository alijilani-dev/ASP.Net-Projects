Public Class TradingFloor

#Region "Private Variables"

    Private pi_int_post_id As Integer
    Private pi_int_module_id As Integer
    Private pi_str_post_heading As String
    Private pi_str_post_desc As String
    Private pi_dat_timestamp As DateTime
    Private pi_int_trading_cat_id As Integer

    Private pi_str_Member_ID As String


    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"


    Public Property post_id() As Integer
        Get
            Return pi_int_post_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_post_id = Value
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

    Public Property post_heading() As String
        Get
            Return pi_str_post_heading
        End Get
        Set(ByVal Value As String)
            pi_str_post_heading = Value
        End Set
    End Property

    Public Property post_desc() As String
        Get
            Return pi_str_post_desc
        End Get
        Set(ByVal Value As String)
            pi_str_post_desc = Value
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

    Public Property trading_cat_id() As Integer
        Get
            Return pi_int_trading_cat_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_trading_cat_id = Value
        End Set
    End Property

    Public Property Member_ID() As String
        Get
            return pi_str_Member_ID
        End Get
        Set(ByVal Value As String)
            pi_str_Member_ID = Value
        End Set
    End Property


#End Region

#Region "get Select ALL / SINGLE TradingFloor"
    Public Function GetModuleTradingFloor(ByVal prm_Portal_ID As Integer) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Portal_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Portal_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_TradingFloors", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetMemberTradingFloor(ByVal prm_Portal_ID As Integer, ByVal prm_Member_ID As String) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Portal_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Portal_ID

            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Member_ID", DbType.String, 20, ParameterDirection.Input)
            idbparameter(1).Value = prm_Member_ID

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_TradingFloors", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetTradingFloor(Optional ByVal prm_post_id As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_post_id = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_TRADING_FLOOR")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@post_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_post_id
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_TRADING_FLOOR", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT TradingFloor"
    Public Function Insert() As Boolean

        Dim idb_TradingFloor_parameter(7) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        idb_TradingFloor_parameter(0) = GlobalData.DataHelper.GetParameter("@post_id", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_TradingFloor_parameter(0).Value = Me.post_id
        idb_TradingFloor_parameter(1) = GlobalData.DataHelper.GetParameter("@module_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradingFloor_parameter(1).Value = Me.module_id
        idb_TradingFloor_parameter(2) = GlobalData.DataHelper.GetParameter("@post_heading", DbType.String, 100, ParameterDirection.Input)
        idb_TradingFloor_parameter(2).Value = Me.post_heading
        idb_TradingFloor_parameter(3) = GlobalData.DataHelper.GetParameter("@post_desc", DbType.String, 1000, ParameterDirection.Input)
        idb_TradingFloor_parameter(3).Value = Me.post_desc
        idb_TradingFloor_parameter(4) = GlobalData.DataHelper.GetParameter("@timestamp", DbType.DateTime, 8, ParameterDirection.Input)
        idb_TradingFloor_parameter(4).Value = Me.timestamp
        idb_TradingFloor_parameter(5) = GlobalData.DataHelper.GetParameter("@trading_cat_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_TradingFloor_parameter(5).Value = Me.trading_cat_id
        idb_TradingFloor_parameter(6) = GlobalData.DataHelper.GetParameter("@Member_ID", DbType.String, 20, ParameterDirection.Input)
        idb_TradingFloor_parameter(6).Value = Me.Member_ID

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_INSERT_TRADING_FLOOR", idb_TradingFloor_parameter)
            
            pi_IDBtra.Commit()

            pi_IDBcon.Close()
            ' Return 
            Return True

        Catch ex As Exception
            pi_IDBtra.Rollback()
            pi_IDBcon.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try
    End Function

#End Region

#Region "DELETE TradingFloor"

#End Region

#Region "UPDATE TradingFloor"

#End Region

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub
End Class
