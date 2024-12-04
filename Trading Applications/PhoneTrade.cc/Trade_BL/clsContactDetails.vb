Public Class ContactDetails

#Region "Private Variables"

    Private pi_int_contact_id As Integer
    Private pi_int_module_id As Integer
    Private pi_str_contact_text As String
    Private pi_dat_timestamp As DateTime


    Private pi_intUserID As Integer

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"


    Public Property contact_id() As Integer
        Get
            Return pi_int_contact_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_contact_id = Value
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

    Public Property contact_text() As String
        Get
            Return pi_str_contact_text
        End Get
        Set(ByVal Value As String)
            pi_str_contact_text = Value
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

#Region "get Select ALL / SINGLE ContactDetails"
    Public Function GetModuleContactDetails(ByVal prm_Module_ID As Integer) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Module_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = prm_Module_ID
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_Get_Contact_Details", idbparameter)
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function

    Public Function GetContactDetails(Optional ByVal prm_Contact_id As Integer = 0) As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim myDatatable As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prm_Contact_id = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_CONTACT_DETAILS")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Contact_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prm_Contact_id
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_CONTACT_DETAILS", idbparameter)
            End If
            myDatatable = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return myDatatable
    End Function
#End Region

#Region "INSERT ContactDetails"

#End Region

#Region "DELETE ContactDetails"

#End Region

#Region "UPDATE ContactDetails"

#End Region

End Class
