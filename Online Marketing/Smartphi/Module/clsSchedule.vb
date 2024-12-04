Imports GotDotNet.ApplicationBlocks.Data
Public Class clsSchedule

#Region "Private Variables"

    Private pi_int_Schedule_id As Integer
    Private pi_int_Campaign_id As Integer
    Private pi_int_Group_id As Integer
    Private pi_dd_ScheduledDateTime As DateTime
    Private pi_int_StatusSend As Integer
    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"
    Public Property ScheduleID() As Integer
        Get
            Return pi_int_Schedule_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_Schedule_id = Value
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

    Public Property GroupID() As Integer
        Get
            Return pi_int_Group_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_Group_id = Value
        End Set
    End Property

    Public Property ScheduledDateTime() As DateTime
        Get
            Return pi_dd_ScheduledDateTime
        End Get
        Set(ByVal Value As DateTime)
            pi_dd_ScheduledDateTime = Value
        End Set
    End Property

    Public Property StatusSend() As Integer
        Get
            Return pi_int_StatusSend
        End Get
        Set(ByVal Value As Integer)
            pi_int_StatusSend = Value
        End Set
    End Property
#End Region

#Region "INSERT"

    Public Function Update(ByVal prm_Mode As Integer) As Boolean
        Dim idbparameter(4) As IDataParameter

        ' prm_Mode
        ' prm_Mode = 1 - insert
        ' prm_Mode = 2 - update
        ' prm_Mode = 3 - delete
        '@Group_id	varchar(20) OUTPUT,
        '@Group_name	varchar(100) =NULL

        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        ''Added the parameters value into the collection
        idbparameter(0) = GlobalData.DataHelper.GetParameter("@Schedule_id", DbType.Int32, 20, ParameterDirection.InputOutput)
        idbparameter(0).Value = Me.ScheduleID
        idbparameter(1) = GlobalData.DataHelper.GetParameter("@Campaign_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(1).Value = Me.CampaignID
        idbparameter(2) = GlobalData.DataHelper.GetParameter("@Group_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(2).Value = Me.GroupID
        idbparameter(3) = GlobalData.DataHelper.GetParameter("@ScheduledDateTime", DbType.DateTime, 20, ParameterDirection.Input)
        idbparameter(3).Value = Me.ScheduledDateTime
        idbparameter(4) = GlobalData.DataHelper.GetParameter("@StatusSend", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(4).Value = Me.StatusSend

        Try
            If prm_Mode = 1 Then 'insert
                pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_INSERT_SCHEDULE", idbparameter)
            ElseIf prm_Mode = 2 Then 'update
                pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_UPDATE_SCHEDULE", idbparameter)
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

    Public Function Delete() As Boolean
        Dim idbparameter(1) As IDataParameter

        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()

        ''Added the parameters value into the collection
        idbparameter(0) = GlobalData.DataHelper.GetParameter("@Schedule_id", DbType.Int32, 20, ParameterDirection.Input)
        idbparameter(0).Value = Me.ScheduleID

        Try
            pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_DELETE_SCHEDULE", idbparameter)

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

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub
End Class

