Imports GotDotNet.ApplicationBlocks.Data

Public Class clsReports

#Region "Private Variables"
    Private pi_int_member_id As Integer
    Private pi_int_campaign_id As Integer
    Private pi_int_schedul_id As Integer


    'ADO Helper
    Private pi_helper As AdoHelper
    'Transaction
    Private pi_IDBtra As IDbTransaction
    'Connection
    Private pi_IDBcon As IDbConnection

#End Region

#Region "Properties"

    Public Property MemberID() As Integer
        Get
            Return pi_int_member_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_member_id = Value
        End Set
    End Property

    Public Property CampaignID() As Integer
        Get
            Return pi_int_campaign_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_campaign_id = Value
        End Set
    End Property

    Public Property SchedulID() As Integer
        Get
            Return pi_int_schedul_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_schedul_id = Value
        End Set
    End Property

#End Region

#Region "Get Reports"

    Public Function GetReportCampaignSchedule(ByVal Schedule_Date As DateTime, Optional ByVal Member_ID As Integer = 0, Optional ByVal Campaign_ID As Integer = 0) As DataSet
        Dim idbparameter(2) As IDataParameter
        Dim dsReport As New DataSet

        ' Create and Fill the DataSet
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Member_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Member_ID
            idbparameter(1) = GlobalData.DataHelper.GetParameter("@Campaign_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(1).Value = Campaign_ID
            'idbparameter(2) = GlobalData.DataHelper.GetParameter("@Schedule_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(2) = GlobalData.DataHelper.GetParameter("@Schedule_Date", DbType.DateTime, 20, ParameterDirection.Input)
            idbparameter(2).Value = Schedule_Date.ToString("yyyy-MM-dd HH:mm:ss") '.ToLongDateString()
            dsReport = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_REPORT_CAMPAIGNSCHEDULE", idbparameter)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        ' Return the DataSet
        Return dsReport

    End Function

    Public Function GetReportMailingList(Optional ByVal Campaign_ID As Integer = 0, Optional ByVal Schedule_ID As Integer = 0) As DataTable
        Dim idbparameter(2) As IDataParameter
        Dim ds As New DataSet

        ' Create and Fill the DataSet
        Dim dtReport As New DataTable
        Try
            pi_helper = GlobalData.DataHelper
            idbparameter(0) = GlobalData.DataHelper.GetParameter("@Campaign_id", DbType.Int32, 4, ParameterDirection.Input)
            idbparameter(0).Value = Campaign_ID

            If Schedule_ID = 0 Then
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_REPORT_CAMPAIGNSCHEDULE", idbparameter)
            Else
                idbparameter(1) = GlobalData.DataHelper.GetParameter("@Schedule_id", DbType.Int32, 4, ParameterDirection.Input)
                idbparameter(1).Value = Schedule_ID
                ds = pi_helper.ExecuteDataset(GlobalData.ConnectionString, CommandType.StoredProcedure, "USP_SELECT_REPORT_CAMPAIGNSCHEDULE", idbparameter)
            End If
            dtReport = ds.Tables(0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dtReport
    End Function

#End Region

    Public Sub New()
        pi_helper = GlobalData.DataHelper
    End Sub

End Class