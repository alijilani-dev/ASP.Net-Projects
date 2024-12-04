Imports GotDotNet.ApplicationBlocks.Data
Public Class clsSchedule

#Region "Private Variables"

    Private pi_int_Schedule_id As Integer
    Private pi_int_Campaign_id As Integer
    Private pi_int_Group_id As String
    Private pi_dd_ScheduledDateTime As DateTime
    Private pi_int_StatusSend As Integer
    Private pi_str_ReturnSchedule_ids As String

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

    Public Property GroupID() As String
        Get
            Return pi_int_Group_id
        End Get
        Set(ByVal Value As String)
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
    Public Property ReturnScheduleids() As String
        Get
            Return pi_str_ReturnSchedule_ids
        End Get
        Set(ByVal Value As String)
            pi_str_ReturnSchedule_ids = Value
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
        Dim strScheduleID As String = String.Empty
        Dim objTransaction As IDbTransaction
        Dim objConnection As IDbConnection

        objConnection = pi_helper.GetConnection(GlobalData.ConnectionString)
        objConnection.Open()
        objTransaction = objConnection.BeginTransaction()
        Try
            If Not GroupID Is Nothing Then
                For Each strGroupID As Integer In Split(GroupID, ",")
                    ''Added the parameters value into the collection
                    idbparameter(0) = GlobalData.DataHelper.GetParameter("@Schedule_id", DbType.Int32, 20, ParameterDirection.InputOutput)
                    idbparameter(0).Value = Me.ScheduleID
                    idbparameter(1) = GlobalData.DataHelper.GetParameter("@Campaign_id", DbType.Int32, 20, ParameterDirection.Input)
                    idbparameter(1).Value = Me.CampaignID
                    idbparameter(2) = GlobalData.DataHelper.GetParameter("@Group_id", DbType.Int32, 20, ParameterDirection.Input)
                    idbparameter(2).Value = strGroupID
                    idbparameter(3) = GlobalData.DataHelper.GetParameter("@ScheduledDateTime", DbType.DateTime, 20, ParameterDirection.Input)
                    idbparameter(3).Value = Me.ScheduledDateTime
                    idbparameter(4) = GlobalData.DataHelper.GetParameter("@StatusSend", DbType.Int32, 20, ParameterDirection.Input)
                    idbparameter(4).Value = Me.StatusSend

                    If prm_Mode = 1 Then 'insert
                        pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_INSERT_SCHEDULE", idbparameter)
                        strScheduleID = strScheduleID & "," & idbparameter(0).Value
                    ElseIf prm_Mode = 2 Then 'update
                        pi_helper.ExecuteNonQuery(objTransaction, CommandType.StoredProcedure, "USP_UPDATE_SCHEDULE", idbparameter)
                    End If
                Next
            End If


            ''Commit and close the transaction
            objTransaction.Commit()
            objConnection.Close()
            Me.ReturnScheduleids = strScheduleID
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

    Public Function UpdateScheduleSendStatus(ByVal prmSchedule_ID As Integer) As Boolean
        Dim idbparameter(1) As IDataParameter

        pi_IDBcon = pi_helper.GetConnection(GlobalData.ConnectionString)
        pi_IDBcon.Open()
        pi_IDBtra = pi_IDBcon.BeginTransaction()

        Try
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Schedule_ID", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(1).Value = prmSchedule_ID

            pi_helper.ExecuteNonQuery(pi_IDBtra, CommandType.StoredProcedure, "USP_UPDATE_SCHEDULESENDSTATUS", idbparameter)

            pi_IDBtra.Commit()

            pi_IDBcon.Close()
            ' Return 
            Return True

        Catch ex As Exception
            pi_IDBtra.Rollback()
            pi_IDBcon.Close()
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Return False
            Exit Function
        End Try
    End Function

#End Region

#Region "Get Schedules"

    Public Function GetSchedule(Optional ByVal prmSchedule_id As String = "") As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtCampaign As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prmSchedule_id = "" Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_SCHEDULE")
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Schedule_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(0).Value = prmSchedule_id
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_SCHEDULE", idbparameter)
            End If
            dtCampaign = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtCampaign
    End Function

    Public Function GetSchedule(ByVal prmScheduledDateTime As DateTime, Optional ByVal prmMember_id As String = "") As DataTable
        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtCampaign As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prmMember_id = "" Then
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@ScheduledDateTime", DbType.DateTime, 4, ParameterDirection.Input)
                idbparameter(0).Value = prmScheduledDateTime
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@ScheduledDateTime", DbType.DateTime, 4, ParameterDirection.Input)
                idbparameter(0).Value = prmScheduledDateTime
                idbparameter(1) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(1).Value = prmMember_id
            End If

            ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_SCHEDULE_BYDATE", idbparameter)

            dtCampaign = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtCampaign
    End Function

    Public Function EncryptValue(Optional ByVal prmSchedule_str As String = "") As Integer

        Dim idbparameter(1) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtCampaign As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            If prmSchedule_str = "" Then
                Return -1
            Else
                idbparameter(0) = GlobalData.DataHelper.GetParameter("@Schedule_str", DbType.String, 15, ParameterDirection.Input)
                idbparameter(0).Value = prmSchedule_str
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_ENCRYPT_VALUE", idbparameter)
                Return ds.Tables(0).Rows(0)("Schedule_Id")
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Return -1
        End Try
    End Function

#End Region

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub
End Class

