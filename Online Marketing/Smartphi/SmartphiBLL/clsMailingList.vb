Imports GotDotNet.ApplicationBlocks.Data
Public Class clsMailingList
#Region "Private Variables"
    Private pi_int_MailingList_id As Integer
    Private pi_int_Campaign_id As Integer
    Private pi_int_Schedule_id As Integer
    Private pi_int_Contact_id As String

    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property MailingListID() As Integer
        Get
            Return pi_int_MailingList_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_MailingList_id = Value
        End Set
    End Property

    Public Property CampaignID() As Integer
        Get
            Return pi_int_Campaign_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_Campaign_id = Value
        End Set
    End Property

    Public Property ScheduleID() As Integer
        Get
            Return pi_int_Schedule_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_Schedule_id = Value
        End Set
    End Property

    Public Property ContactID() As String
        Get
            Return pi_int_Contact_id
        End Get
        Set(ByVal Value As String)
            pi_int_Contact_id = Value
        End Set
    End Property

#End Region

#Region "INSERT"

    Public Function Update(ByVal prm_Mode As Integer) As Boolean
        Dim idbparameter(3) As IDataParameter

        ' prm_Mode
        ' prm_Mode = 1 - insert
        ' prm_Mode = 2 - update
    
        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()
        Try
     
            ''Added the parameters value into the collection
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@MailingList_id", DbType.Int32, 20, ParameterDirection.InputOutput)
            idbparameter(0).Value = Me.MailingListID

            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Campaign_id", DbType.Int32, 20, ParameterDirection.Input)
            idbparameter(1).Value = Me.CampaignID

            idbparameter(2) = GlobalData.DataHelper.GetParameter("@Schedule_id", DbType.Int32, 20, ParameterDirection.Input)
            idbparameter(2).Value = Me.ScheduleID

            idbparameter(3) = GlobalData.DataHelper.GetParameter("@Contact_id", DbType.Int32, 20, ParameterDirection.Input)
            idbparameter(3).Value = Me.ContactID

            If prm_Mode = 1 Then 'insert
                pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_INSERT_MAILLIST", idbparameter)
            ElseIf prm_Mode = 2 Then 'update

            End If



            ''Commit and close the transaction
            objTransaction.Commit()
            objConnection.Close()

            Return True

        Catch ex As Exception
            ''If any error roll back the transaction
            objTransaction.Rollback()
            objConnection.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            ' Return 
            Return False
            Exit Function
        End Try
    End Function

#End Region

#Region "Get Functions"

    Public Function GetDeliveryReport(Optional ByVal Campaign_id As Integer = 0, Optional ByVal Schedule_id As Integer = 0) As DataSet
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        ' Dim dtSchedule As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            'idbparameter(0) = GlobalData.DataHelper.GetParameter("@Campaign_id", DbType.Int32, 4, ParameterDirection.Input)
            'idbparameter(0).Value = Campaign_id
            'idbparameter(1) = GlobalData.DataHelper.GetParameter("@Schedule_id", DbType.Int32, 4, ParameterDirection.Input)
            'idbparameter(1).Value = Schedule_id
            'ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_REPORT_MAILINGLIST", idbparameter)
            'dtSchedule = ds.Tables(0)
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Campaign_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Campaign_id
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Schedule_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(1).Value = Schedule_id
            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_REPORT_MAILINGLIST", idbparameter)
            'dtSchedule = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return ds
    End Function

#End Region

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub

End Class
