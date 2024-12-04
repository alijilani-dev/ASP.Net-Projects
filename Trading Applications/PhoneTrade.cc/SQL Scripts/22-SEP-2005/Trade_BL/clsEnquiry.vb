Public Class Enquiry

#Region "Private Variables"
    Private pi_int_Enquiry_Id As Integer
    Private pi_int_Portal_ID As Integer
    Private pi_str_ContactName As String
    Private pi_str_CompanyName As String
    Private pi_str_Phone As String
    Private pi_str_Email As String
    Private pi_str_Comments As String

    Private pi_dtt_TimeStamp As DateTime

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property Enquiry_Id() As Integer
        Get
            Return pi_int_Enquiry_Id
        End Get
        Set(ByVal Value As Integer)
            pi_int_Enquiry_Id = Value
        End Set
    End Property
    Public Property Portal_ID() As Integer
        Get
            Return pi_int_Portal_ID
        End Get
        Set(ByVal Value As Integer)
            pi_int_Portal_ID = Value
        End Set
    End Property
    Public Property ContactName() As String
        Get
            Return pi_str_ContactName
        End Get
        Set(ByVal Value As String)
            pi_str_ContactName = Value
        End Set
    End Property
    Public Property CompanyName() As String
        Get
            Return pi_str_CompanyName
        End Get
        Set(ByVal Value As String)
            pi_str_CompanyName = Value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return pi_str_Phone
        End Get
        Set(ByVal Value As String)
            pi_str_Phone = Value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return pi_str_Email
        End Get
        Set(ByVal Value As String)
            pi_str_Email = Value
        End Set
    End Property
    Public Property Comments() As String
        Get
            Return pi_str_Comments
        End Get
        Set(ByVal Value As String)
            pi_str_Comments = Value
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

#Region "get Select ALL / SINGLE Enquiry"
    Public Function GetModuleEnquiry(ByVal prm_Portal_ID As Integer) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Portal_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Portal_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_Enquiry", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetEnquiry(Optional ByVal prm_Enquiry_ID As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_Enquiry_ID = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_ENQUIRY")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Enquiry_ID", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_Enquiry_ID
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_ENQUIRY", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT Enquiry"
    Public Function Insert() As Boolean

        Dim idb_Enquiry_parameter(7) As IDataParameter
        Dim dt_row As DataRow

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        '@Enquiry_id int = NULL output,
        '@Portal_id int = NULL ,
        '@ContactName varchar(100) = NULL,
        '@CompanyName varchar(100) = NULL,
        '@Phone varchar(100) = NULL,
        '@Email varchar(255) = NULL,
        '@Comments varchar(1000) = NULL

        idb_Enquiry_parameter(0) = GlobalData.DataHelper.GetParameter("@Enquiry_id", DbType.Int32, 4, ParameterDirection.InputOutput)
        idb_Enquiry_parameter(0).Value = Me.Enquiry_Id
        idb_Enquiry_parameter(1) = GlobalData.DataHelper.GetParameter("@Portal_id", DbType.Int32, 4, ParameterDirection.Input)
        idb_Enquiry_parameter(1).Value = Me.Portal_ID
        idb_Enquiry_parameter(2) = GlobalData.DataHelper.GetParameter("@ContactName", DbType.String, 100, ParameterDirection.Input)
        idb_Enquiry_parameter(2).Value = Me.ContactName
        idb_Enquiry_parameter(3) = GlobalData.DataHelper.GetParameter("@CompanyName", DbType.String, 100, ParameterDirection.Input)
        idb_Enquiry_parameter(3).Value = Me.CompanyName
        idb_Enquiry_parameter(4) = GlobalData.DataHelper.GetParameter("@Phone", DbType.String, 100, ParameterDirection.Input)
        idb_Enquiry_parameter(4).Value = Me.Phone
        idb_Enquiry_parameter(5) = GlobalData.DataHelper.GetParameter("@Email", DbType.String, 255, ParameterDirection.Input)
        idb_Enquiry_parameter(5).Value = Me.Email
        idb_Enquiry_parameter(6) = GlobalData.DataHelper.GetParameter("@Comments", DbType.String, 1000, ParameterDirection.Input)
        idb_Enquiry_parameter(6).Value = Me.Comments

        Try

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_INSERT_ENQUIRY", idb_Enquiry_parameter)

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

#Region "DELETE Enquiry"

#End Region

#Region "UPDATE Enquiry"
    Public Function Update() As Boolean
    End Function
#End Region

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub
End Class
