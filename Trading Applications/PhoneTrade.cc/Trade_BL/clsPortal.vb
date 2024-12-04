Public Class Portal

#Region "Private Variables"

    Private pi_int_portal_id As Integer
    Private pi_str_portal_name As String
    Private pi_str_portal_url As String
    Private pi_str_portal_logo As String
    Private pi_str_portal_stylesheet As String


    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property portal_id() As Integer
        Get
            Return pi_int_portal_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_portal_id = Value
        End Set
    End Property

    Public Property portal_name() As String
        Get
            Return pi_str_portal_name
        End Get
        Set(ByVal Value As String)
            pi_str_portal_name = Value
        End Set
    End Property

    Public Property portal_url() As String
        Get
            Return pi_str_portal_url
        End Get
        Set(ByVal Value As String)
            pi_str_portal_url = Value
        End Set
    End Property

    Public Property portal_logo() As String
        Get
            Return pi_str_portal_logo
        End Get
        Set(ByVal Value As String)
            pi_str_portal_logo = Value
        End Set
    End Property

    Public Property portal_stylesheet() As String
        Get
            Return pi_str_portal_stylesheet
        End Get
        Set(ByVal Value As String)
            pi_str_portal_stylesheet = Value
        End Set
    End Property

#End Region

#Region "get Select ALL / SINGLE Portal"
    Public Function GetPortal(Optional ByVal prm_Portal_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_Portal_ID = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PORTAL")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@portal_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_Portal_ID
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_PORTAL", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT Portal"

#End Region

#Region "DELETE Portal"

#End Region

#Region "UPDATE Portal"

#End Region
End Class
