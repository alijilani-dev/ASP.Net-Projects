Imports SmartPhi_BL

Public Class TrackReport
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents ddlCampaign As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlDate As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnGenReport As System.Web.UI.WebControls.Button
    Protected WithEvents dgReports As System.Web.UI.WebControls.DataGrid


    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Public n Private Variables"
    Private pi_obj_Campaign As New clsCampaign
    Private pi_obj_Reports As New clsReports
    Private pi_int_Schedule_ID As New Integer
    Public dsReport As DataSet
    Public drReport, drReportPrev As DataRow
    Public DsFFDirectory As DataSet
    Public nDuplicateCounter As Int32 = 0
    Public nCounter As Int32 = 0
#End Region

#Region "Pulic Properties"
    Public Property ScheduleID() As Integer
        Get
            Return pi_int_Schedule_ID

        End Get
        Set(ByVal Value As Integer)
            pi_int_Schedule_ID = Value
        End Set
    End Property
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Not Page.IsPostBack) Then
            LoadCampaigns(True)
        End If
        'GenerateReport(CInt(ddlCampaign.SelectedValue), ddlDate.SelectedValue)
    End Sub

    Private Sub LoadCampaigns(ByVal lBindSch As Boolean)

        Dim dtCampaigns As DataTable
        Dim lCampaignItem As New ListItem

        dtCampaigns = pi_obj_Campaign.GetMemberCampaigns(Session(Session_str_MemberID))
        ddlCampaign.DataSource = dtCampaigns
        ddlCampaign.DataBind()
        lCampaignItem.Text = "Select Campaign Name"
        lCampaignItem.Value = 0
        lCampaignItem.Selected = True
        ddlCampaign.Items.Add(lCampaignItem)
        ddlCampaign.SelectedIndex = ddlCampaign.Items.Count - 1

        If (lBindSch) Then
            LoadSchedules()
        End If

    End Sub

    Private Sub LoadSchedules()

        Dim dtSchedule As DataTable
        Dim lDateItem As New ListItem
        ' Get Schedules for Current Member
        dtSchedule = pi_obj_Campaign.GetCampaignSchedule(Session(Session_str_MemberID), CInt(ddlCampaign.SelectedValue))
        ddlDate.DataSource = dtSchedule
        ' Bind Schedules Datalist for Current Member
        ddlDate.DataBind()
        lDateItem.Text = "Select Date"
        lDateItem.Value = "0"
        lDateItem.Selected = True
        ddlDate.Items.Add(lDateItem)
        ddlDate.SelectedIndex = ddlDate.Items.Count - 1
        GenerateReport(CInt(ddlCampaign.SelectedValue), ddlDate.SelectedValue)

    End Sub

    Private Sub btnGenReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenReport.Click
        GenerateReport(CInt(ddlCampaign.SelectedValue), ddlDate.SelectedValue)
    End Sub

    Private Function GenerateReport(ByVal prmCampaignID As Integer, ByVal prmSchDate As String) 'As DataTable

        If (prmCampaignID <> 0) Then
            If (prmSchDate <> "0") Then
                dsReport = pi_obj_Reports.GetReportCampaignSchedule(DateTime.Parse(ddlDate.SelectedValue.ToString()), CInt(Session(Session_str_MemberID)), prmCampaignID) 'CInt(ddlDate.SelectedValue.ToString()))
            Else
                dsReport = pi_obj_Reports.GetReportCampaignSchedule(DateTime.Parse("02/02/1753 00:00:00"), CInt(Session(Session_str_MemberID)), prmCampaignID) 'Parse("1753-02-02 00:00:00.000")
            End If
            'dgReports.DataSource = dsReport
            'dgReports.DataBind()
        Else
            If (prmSchDate <> "0") Then
                dsReport = pi_obj_Reports.GetReportCampaignSchedule(DateTime.Parse(ddlDate.SelectedValue.ToString()), CInt(Session(Session_str_MemberID)), 0)  'CInt(ddlDate.SelectedValue.ToString()))
            Else
                dsReport = pi_obj_Reports.GetReportCampaignSchedule(DateTime.Parse("02/02/1753 00:00:00"), CInt(Session(Session_str_MemberID)), 0) 'Parse("1753-02-02 00:00:00.000")
            End If
            'dgReports.DataSource = dsReport
            'dgReports.DataBind()
        End If

    End Function

    Private Sub ddlCampaign_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCampaign.SelectedIndexChanged
        LoadSchedules()
    End Sub

End Class
