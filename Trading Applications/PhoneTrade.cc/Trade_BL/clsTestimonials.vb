Public Class Testimonials

#Region "Private Variables"

    Private pi_int_T_ID As Integer
    Private pi_Str_Member_Id As String

    Private pi_Int_Portal_ID As Integer

    Private pi_Str_Text As String

    Private pi_dtt_TimeStamp As DateTime

    Private pi_Show_Flag As Integer
    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property Testimonial_ID() As Integer
        Get
            Return pi_int_T_ID
        End Get
        Set(ByVal Value As Integer)
            pi_int_T_ID = Value
        End Set
    End Property

    Public Property Member_Id() As String
        Get
            Return pi_Str_Member_Id
        End Get
        Set(ByVal Value As String)
            pi_Str_Member_Id = Value
        End Set
    End Property

    Public Property Portal_ID() As Integer
        Get
            Return pi_Int_Portal_ID
        End Get
        Set(ByVal Value As Integer)
            pi_Int_Portal_ID = Value
        End Set
    End Property

    Public Property Text() As String
        Get
            Return pi_Str_Text
        End Get
        Set(ByVal Value As String)
            pi_Str_Text = Value
        End Set
    End Property

    Public Property Show_Flag() As Integer
        Get
            Return pi_Show_Flag
        End Get
        Set(ByVal Value As Integer)
            pi_Show_Flag = Value
        End Set
    End Property
    Public Property TimeStamp() As DateTime
        Get
            Return pi_dtt_TimeStamp
        End Get
        Set(ByVal Value As DateTime)
            pi_dtt_TimeStamp = Value
        End Set
    End Property

#End Region

#Region "get Select ALL / SINGLE Testimonials"
    Public Function GetPortalTestimonials(ByVal prm_Portal_ID As Integer) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Portal_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Portal_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_TESTIMONIALS", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetTestimonials(Optional ByVal prm_Trading_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_Trading_ID = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_TESTIMONIALS")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@T_ID", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_Trading_ID
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_TESTIMONIALS", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetMemberTestimonials(ByVal prm_Portal_ID As Integer, ByVal prm_Member_ID As String) As DataTable
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

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_GET_TESTIMONIALS", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

#End Region

#Region "INSERT Testimonials"
    Public Function Insert() As Boolean

        Dim idb_Testimonial_parameter(6) As IDataParameter

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@TID		int=NULL OUTPUT,
        '@Portal_ID	int, 
        '@Member_ID	varchar(20) ,
        '@Text	varchar(1000) ,
        '@TimeStamp	datetime,
        '@SHow_lag	int = 1

        idb_Testimonial_parameter(0) = GlobalData.DataHelper.GetParameter("@TID", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_Testimonial_parameter(0).Value = Me.Testimonial_ID

        idb_Testimonial_parameter(1) = GlobalData.DataHelper.GetParameter("@Portal_ID", DbType.Int32, 4, ParameterDirection.Input)
        idb_Testimonial_parameter(1).Value = Me.Portal_ID

        idb_Testimonial_parameter(2) = GlobalData.DataHelper.GetParameter("@Member_ID", DbType.String, 20, ParameterDirection.Input)
        idb_Testimonial_parameter(2).Value = Me.Member_Id

        idb_Testimonial_parameter(3) = GlobalData.DataHelper.GetParameter("@Text", DbType.String, 1000, ParameterDirection.Input)
        idb_Testimonial_parameter(3).Value = Me.Text

        idb_Testimonial_parameter(4) = GlobalData.DataHelper.GetParameter("@TimeStamp", DbType.DateTime, 8, ParameterDirection.Input)
        idb_Testimonial_parameter(4).Value = DateTime.Now

        idb_Testimonial_parameter(5) = GlobalData.DataHelper.GetParameter("@SHow_flag", DbType.Int32, 4, ParameterDirection.Input)
        idb_Testimonial_parameter(5).Value = Me.Show_Flag


        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_INSERT_Testimonial", idb_Testimonial_parameter)

            pi_IDBtra.Commit()
            Me.Testimonial_ID = idb_Testimonial_parameter(0).Value

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

#Region "DELETE Testimonials"
    Public Function Delete(Optional ByVal prm_Testimonial_id As Integer = 0) As Boolean

        Dim idb_Testimonial_parameter(1) As IDataParameter

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@Tid int = NULL

        If prm_Testimonial_id = 0 Then
            idb_Testimonial_parameter(0) = GlobalData.DataHelper.GetParameter("@Tid", DbType.Int32, 4, ParameterDirection.Input)
            idb_Testimonial_parameter(0).Value = Me.Testimonial_ID
        Else
            idb_Testimonial_parameter(0) = GlobalData.DataHelper.GetParameter("@Tid", DbType.Int32, 4, ParameterDirection.Input)
            idb_Testimonial_parameter(0).Value = prm_Testimonial_id
        End If

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_DELETE_Testimonial", idb_Testimonial_parameter)

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

#Region "UPDATE Testimonials"
    Public Function Update() As Boolean

        Dim idb_Testimonial_parameter(6) As IDataParameter

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@TID		int=NULL OUTPUT,
        '@Portal_ID	int, 
        '@Member_ID	varchar(20) ,
        '@Text	varchar(1000) ,
        '@TimeStamp	datetime,
        '@SHow_lag	int = 1

        idb_Testimonial_parameter(0) = GlobalData.DataHelper.GetParameter("@TID", DbType.Int32, 4, ParameterDirection.Input)
        idb_Testimonial_parameter(0).Value = Me.Testimonial_ID

        idb_Testimonial_parameter(1) = GlobalData.DataHelper.GetParameter("@Portal_ID", DbType.Int32, 4, ParameterDirection.Input)
        idb_Testimonial_parameter(1).Value = Me.Portal_ID

        idb_Testimonial_parameter(2) = GlobalData.DataHelper.GetParameter("@Member_ID", DbType.String, 20, ParameterDirection.Input)
        idb_Testimonial_parameter(2).Value = Me.Member_Id

        idb_Testimonial_parameter(3) = GlobalData.DataHelper.GetParameter("@Text", DbType.String, 1000, ParameterDirection.Input)
        idb_Testimonial_parameter(3).Value = Me.Text

        idb_Testimonial_parameter(4) = GlobalData.DataHelper.GetParameter("@TimeStamp", DbType.DateTime, 8, ParameterDirection.Input)
        idb_Testimonial_parameter(4).Value = DateTime.Now

        idb_Testimonial_parameter(5) = GlobalData.DataHelper.GetParameter("@SHow_flag", DbType.Int32, 4, ParameterDirection.Input)
        idb_Testimonial_parameter(5).Value = Me.Show_Flag


        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_UPDATE_Testimonial", idb_Testimonial_parameter)

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
