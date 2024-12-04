Public Class Review

#Region "Private Variables"

    Private pi_int_MR_id As Integer
    Private pi_int_MobileSrNo As Integer
    Private pi_str_MobileReview As String
    Private pi_int_Portal_id As Integer
    Private pi_int_Status As Integer
    Private pi_dat_timestamp As DateTime

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"


    Public Property MR_id() As Integer
        Get
            Return pi_int_MR_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_MR_id = Value
        End Set
    End Property
    Public Property MobileSrNo() As Integer
        Get
            Return pi_int_MobileSrNo
        End Get
        Set(ByVal Value As Integer)
            pi_int_MobileSrNo = Value
        End Set
    End Property
    Public Property MobileReview() As String
        Get
            Return pi_str_MobileReview
        End Get
        Set(ByVal Value As String)
            pi_str_MobileReview = Value
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
    Public Property Status() As Integer
        Get
            Return pi_int_Status
        End Get
        Set(ByVal Value As Integer)
            pi_int_Status = Value
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


#Region "get Select ALL / SINGLE Review"
    Public Function GetReview(Optional ByVal vid As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If vid = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_MobileReview")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@MR_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = vid
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_MobileReview", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
    '''New Method added on Feb2nd by Basheer
    '''To get all latest mobile models from the selected items
    Public Function GetLatestMobiles() As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_LatestMobiles")
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

#End Region

#Region "INSERT Review"
    Public Function Insert() As Boolean

        Dim idb_MobileReview_parameter(7) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@MR_id int = NULL ,
        '@MobileSrNo int = NULL,
        '@MobileReview  varchar(1000) = NULL,
        '@PortalID INT,
        '@Status INT =0,
        '@timestamp datetime = NULL

        idb_MobileReview_parameter(0) = GlobalData.DataHelper.GetParameter("@MR_id", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_MobileReview_parameter(0).Value = Me.MR_id
        idb_MobileReview_parameter(1) = GlobalData.DataHelper.GetParameter("@MobileSrNo", DbType.Int32, 4, ParameterDirection.Input)
        idb_MobileReview_parameter(1).Value = Me.MobileSrNo
        idb_MobileReview_parameter(2) = GlobalData.DataHelper.GetParameter("@MobileReview", DbType.String, 1000, ParameterDirection.Input)
        idb_MobileReview_parameter(2).Value = Me.MobileReview
        idb_MobileReview_parameter(3) = GlobalData.DataHelper.GetParameter("@PortalID", DbType.Int32, 4, ParameterDirection.Input)
        idb_MobileReview_parameter(3).Value = Me.Portal_id
        idb_MobileReview_parameter(4) = GlobalData.DataHelper.GetParameter("@Status", DbType.Int32, 4, ParameterDirection.Input)
        idb_MobileReview_parameter(4).Value = Me.Status
        idb_MobileReview_parameter(5) = GlobalData.DataHelper.GetParameter("@timestamp", DbType.DateTime, 8, ParameterDirection.Input)
        idb_MobileReview_parameter(5).Value = DateTime.Now

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_INSERT_MOBILEREVIEW", idb_MobileReview_parameter)
            Me.MR_id = idb_MobileReview_parameter(0).Value

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

#Region "DELETE Review"
    Public Function Delete(Optional ByVal prm_MobileReview_id As Integer = 0) As Boolean

        Dim idb_MobileReview_parameter(1) As IDataParameter

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@ann_id int = NULL

        If prm_MobileReview_id = 0 Then
            idb_MobileReview_parameter(0) = GlobalData.DataHelper.GetParameter("@MR_id", DbType.Int32, 4, ParameterDirection.Input)
            idb_MobileReview_parameter(0).Value = Me.MR_id
        Else
            idb_MobileReview_parameter(0) = GlobalData.DataHelper.GetParameter("@MR_id", DbType.Int32, 4, ParameterDirection.Input)
            idb_MobileReview_parameter(0).Value = prm_MobileReview_id
        End If

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_DELETE_MOBILEREVIEW", idb_MobileReview_parameter)

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

#Region "UPDATE Review"
    Public Function Update() As Boolean


        Dim idb_MobileReview_parameter(7) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@MR_id int = NULL ,
        '@MobileSrNo int = NULL,
        '@MobileReview  varchar(1000) = NULL,
        '@PortalID INT,
        '@Status INT =0,
        '@timestamp datetime = NULL

        idb_MobileReview_parameter(0) = GlobalData.DataHelper.GetParameter("@MR_id", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_MobileReview_parameter(0).Value = Me.MR_id
        idb_MobileReview_parameter(1) = GlobalData.DataHelper.GetParameter("@MobileSrNo", DbType.Int32, 4, ParameterDirection.Input)
        idb_MobileReview_parameter(1).Value = Me.MobileSrNo
        idb_MobileReview_parameter(2) = GlobalData.DataHelper.GetParameter("@MobileReview", DbType.String, 1000, ParameterDirection.Input)
        idb_MobileReview_parameter(2).Value = Me.MobileReview
        idb_MobileReview_parameter(3) = GlobalData.DataHelper.GetParameter("@PortalID", DbType.Int32, 4, ParameterDirection.Input)
        idb_MobileReview_parameter(3).Value = Me.Portal_id
        idb_MobileReview_parameter(4) = GlobalData.DataHelper.GetParameter("@Status", DbType.Int32, 4, ParameterDirection.Input)
        idb_MobileReview_parameter(4).Value = Me.Status
        idb_MobileReview_parameter(5) = GlobalData.DataHelper.GetParameter("@timestamp", DbType.DateTime, 8, ParameterDirection.Input)
        idb_MobileReview_parameter(5).Value = DateTime.Now
        Try
            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_UPDATE_MOBILEREVIEW", idb_MobileReview_parameter)

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
