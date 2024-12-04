Imports SmartPhi_BL
Public Class DeliveryReport1
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents dgReport As System.Web.UI.WebControls.DataGrid

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Private pi_obj_Group As New clsGroup
    Private pi_obj_MailingList As New clsMailingList
    Private pi_obj_Capmaign As New clsCampaign
    Private pi_obj_Schedule As New clsSchedule
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Session(Session_str_MemberID) = 1
        Dim nCampaignId As Integer
        Dim strScheduleId As String
        Try
            nCampaignId = pi_obj_Capmaign.GetCampaignID(New Guid(Request("campaign").ToString.Trim))
            strScheduleId = Request("schedule").ToString()
            LoadDeliveryReport(nCampaignId, strScheduleId)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try


    End Sub

    Private Sub LoadDeliveryReport(ByVal prmCampaignID As Integer, ByVal prmScheduleID As String)
        Dim dtMailingList As DataTable
        Dim ds As New DataSet

        Dim strScheduleId As String()
        strScheduleId = prmScheduleID.Split(",")
        Dim i As Integer
        For i = 0 To strScheduleId.Length - 1
            ds.Merge(pi_obj_MailingList.GetDeliveryReport(prmCampaignID, pi_obj_Schedule.EncryptValue(strScheduleId(i))))
        Next
        'dtMailingList = pi_obj_MailingList.GetDeliveryReport(prmCampaignID, prmScheduleID)
        dgReport.DataSource = ds
        dgReport.DataBind()

        ds = Nothing
    End Sub

End Class