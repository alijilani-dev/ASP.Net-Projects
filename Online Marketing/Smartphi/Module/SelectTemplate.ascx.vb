Imports SmartPhi_BL
Public Class TemplateControl
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lstCategory As System.Web.UI.WebControls.ListBox
    Protected WithEvents lstTemplate As System.Web.UI.WebControls.ListBox
    Protected WithEvents imgPreview As System.Web.UI.WebControls.ImageButton
    Protected WithEvents btnSaveTemplate As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents rfvCategory As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rfvTemplate As System.Web.UI.WebControls.RequiredFieldValidator

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Dim pi_obj_Category As New clsCategory
    Dim pi_obj_Template As New clsTemplate

#Region " Variables "
    Public pi_str_Campaign_name As String
    Public pi_str_Subject As String
    Public pi_int_Category_ID As Integer
    Public pi_int_Template_ID As Integer
#End Region

#Region " Properties"
    Public Property Campaign_name() As String
        Get
            Return pi_str_Campaign_name
        End Get
        Set(ByVal Value As String)
            pi_str_Campaign_name = Value
        End Set
    End Property
    Public Property Subject() As String
        Get
            Return pi_str_Subject

        End Get
        Set(ByVal Value As String)
            pi_str_Subject = Value
        End Set
    End Property
    Public Property CategoryID() As Integer
        Get
            Return pi_int_Category_ID
        End Get
        Set(ByVal Value As Integer)
            pi_int_Category_ID = Value
        End Set
    End Property
    Public Property TemplateID() As Integer
        Get
            Return pi_int_Template_ID

        End Get
        Set(ByVal Value As Integer)
            pi_int_Template_ID = Value
        End Set
    End Property
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (Not Page.IsPostBack) Then
            lstCategory.DataSource = pi_obj_Category.GetCategory()
            lstCategory.DataBind()
            lstCategory.SelectedIndex = 0
            If (lstCategory.Items.Count > 0) Then
                lstTemplate.DataSource = pi_obj_Template.GetCategoryTemplates(lstCategory.SelectedValue)
                lstTemplate.DataBind()
                lstTemplate.SelectedIndex = 0
            End If
        End If
        If (CategoryID <> Nothing) Then
            lstCategory.Items.FindByValue(CategoryID).Selected = True
        End If
        If (TemplateID <> Nothing) Then
            lstTemplate.Items.FindByValue(TemplateID).Selected = True
        End If

        'btnSaveTemplate.Attributes.Add("OnClick", "ShowImage('../images/MonthlyNL.gif');return true;")
    End Sub

    Private Sub btnSaveTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btnSaveTemplate.Click
        If (Not lstTemplate.SelectedIndex = Nothing) Then
            Dim nCampaignID As Integer
            Me.CategoryID = lstCategory.SelectedValue
            Me.TemplateID = lstTemplate.SelectedValue
            pi_obj_Template.campaign_name = Me.Campaign_name
            pi_obj_Template.subject = Me.Subject
            pi_obj_Template.template_id = Me.TemplateID
            pi_obj_Template.date_created = DateTime.Now
            pi_obj_Template.member_id = Session(Session_str_MemberID)
            Try
                pi_obj_Template.Insert()
                nCampaignID = pi_obj_Template.campaign_id
                If (nCampaignID > 0) Then
                    Session(Session_str_CampaginID) = nCampaignID
                    Session(Session_str_CampaginGUID) = pi_obj_Template.GetCampaignGUID(nCampaignID).Rows(0)("GUIDNo").ToString().Trim()
                    Session(Session_str_TemplateID) = Me.TemplateID
                End If
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine(ex.Message)
            End Try
        End If
    End Sub

    Private Sub lstCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCategory.SelectedIndexChanged
        If Not (sender Is Nothing) Then
            lstTemplate.Items.Clear()
            lstTemplate.DataSource = pi_obj_Template.GetCategoryTemplates(lstCategory.SelectedValue)
            lstTemplate.DataBind()
        End If
        CategoryID = lstCategory.SelectedValue
    End Sub

    Private Sub lstTemplate_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstTemplate.SelectedIndexChanged
        Dim dt As New DataTable
        dt = pi_obj_Template.GetTemplate(lstTemplate.SelectedValue)
        ShowImage("../images/" & dt.Rows(0)("TemplateImage").ToString())
        CategoryID = lstCategory.SelectedValue
        TemplateID = lstTemplate.SelectedValue
    End Sub

    Public Sub ShowImage(ByVal ImgPath As String)
        Image1.ImageUrl = ImgPath
    End Sub

End Class
