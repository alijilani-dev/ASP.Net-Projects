Imports SmartPhi_BL
Imports System.Text
Public Class ScheduleControl
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lstGroup As System.Web.UI.WebControls.ListBox
    Protected WithEvents ddlMonth As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlDay As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlYear As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnSchedule As System.Web.UI.WebControls.Button
    Protected WithEvents txtEmailID1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmailID2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmailID3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnTest As System.Web.UI.WebControls.Button
    Protected WithEvents ddlMin As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlHour As System.Web.UI.WebControls.DropDownList
    Protected WithEvents tblSchedule As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tblTest As System.Web.UI.HtmlControls.HtmlTable

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Private variable"
    Private pi_bln_ScheduleorTest As Boolean 'True schedule, false - testing
    Private pi_obj_Param As clsParameter
    Private pi_obj_Campaign As clsCampaign
#End Region

#Region "Properties"
    Property ScheduleorTest() As Boolean
        Get
            Return pi_bln_ScheduleorTest
        End Get
        Set(ByVal Value As Boolean)
            pi_bln_ScheduleorTest = Value
        End Set
    End Property
#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        'If Not Page.IsPostBack Then
        tblSchedule.Visible = ScheduleorTest
        tblTest.Visible = Not ScheduleorTest
        'End If

    End Sub
    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Dim strTemplate As New StringBuilder
        strTemplate = GenerateHTMLContent(Session(Session_str_CampaginID))

    End Sub
    Private Function GenerateHTMLContent(ByVal prmCampaignId As Integer) As StringBuilder
        Dim dt As New DataTable
        Dim nTemplateId As Integer
        Dim strTemplatePath As String
        Dim dtValues As DataTable
        Dim dr As DataRow
        Dim i, j As Integer
        Dim strMode As String

        Try
            dt = pi_obj_Campaign.GetCampaignTemplate(prmCampaignId)
            If dt.Rows.Count > 0 Then
                nTemplateId = CInt(dt.Rows(0)("TemplateID").ToString())
                strTemplatePath = dt.Rows(0)("TemplatePath").ToString()
            End If

            Dim strTemplate As StringBuilder
            Dim strPath As String = Server.MapPath("~")
            Dim file As New System.IO.StreamReader(strPath & "\Templates\" & strTemplatePath)
            Dim words As String = file.ReadToEnd()
            file.Close()

            dt = pi_obj_Param.GetCampaignParamValues(prmCampaignId, nTemplateId) '''Get the edited values for the specified ntemplateid

            If (dt.Rows.Count > 0) Then
                For i = 0 To dt.Rows.Count - 1
                    dr = dt.Rows(i)
                    words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamValue").ToString().Trim())
                    words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", String.Empty)
                    'words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", dr("ParamEditValue").ToString().Trim())
                Next

            End If
            'Return words.ToString()
            'spnContent.InnerHtml = words.ToString()
            strTemplate = New StringBuilder(words.ToString)
            Return strTemplate
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try


    End Function

End Class
