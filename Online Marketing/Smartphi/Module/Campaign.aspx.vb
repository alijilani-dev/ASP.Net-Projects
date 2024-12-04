Imports SmartPhi_BL
Public Class Campaign
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Middle As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents btnBack As System.Web.UI.WebControls.Button
    Protected WithEvents btnSaveTemplate As System.Web.UI.WebControls.Button
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents rfvTemplate As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lstTemplate As System.Web.UI.WebControls.ListBox
    Protected WithEvents rfvCategory As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lstCategory As System.Web.UI.WebControls.ListBox
    Protected WithEvents btnNext As System.Web.UI.WebControls.Button
    Protected WithEvents rfvSubject As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtSubject As System.Web.UI.WebControls.TextBox
    Protected WithEvents rfvCampaignName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtCampaignName As System.Web.UI.WebControls.TextBox
    Protected WithEvents tdCampaign As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents tdselectTemplate As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents tdFooter As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents dgCampaign As System.Web.UI.WebControls.DataGrid
    Protected WithEvents txtCampaignId As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnUpdate As System.Web.UI.WebControls.Button
    Protected WithEvents lblConfirm As System.Web.UI.WebControls.Label
    Protected WithEvents hlnkCreateCampaign As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkManageCampaign As System.Web.UI.WebControls.HyperLink

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Private Variables"
    Private pi_obj_Category As New clsCategory
    Private pi_obj_Template As New clsTemplate
    Private pi_obj_Campaign As New clsCampaign
    Private pi_obj_Parameter As New clsParameter

    Private pi_str_campaign_name As String = ""
    Private pi_str_subject As String = ""

    Private pi_int_category_id As Integer = 0
    Private pi_int_template_id As Integer = 0
    Private pi_int_campaign_id As Integer = 0
    Private pi_str_date_created As String = ""
    Private pi_int_times_sent As Integer = 0
    Private pi_int_member_id As Integer = 0
    Private pi_int_FwdPointer As Boolean
    Dim lEditMode As Boolean

#End Region

#Region " Properties"
    Public Property CampaignName() As String
        Get
            Return pi_str_campaign_name
        End Get
        Set(ByVal Value As String)
            pi_str_campaign_name = Value
        End Set
    End Property
    Public Property Subject() As String
        Get
            Return pi_str_subject

        End Get
        Set(ByVal Value As String)
            pi_str_subject = Value
        End Set
    End Property
    Public Property CategoryID() As Integer
        Get
            Return pi_int_category_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_category_id = Value
        End Set
    End Property
    Public Property TemplateID() As Integer
        Get
            Return pi_int_template_id

        End Get
        Set(ByVal Value As Integer)
            pi_int_template_id = Value
        End Set
    End Property
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If (CInt(Session(Session_str_MemberID)) = 0 Or Session(Session_str_MemberID) Is Nothing) Then
            Response.Redirect("..\Login.aspx")
        End If


        If (Not Page.IsPostBack) Then
            tdCampaign.Visible = True
            tdselectTemplate.Visible = False
            LoadCategory()
            LoadTemplates()
            If ((CInt(Request("Mode")) = 2) Or (lEditMode)) Then        ' EDIT Mode
                LoadCampaigns()
            Else
                ClearForm()
            End If
        End If
    End Sub
    Private Sub LoadCategory()
        lstCategory.DataSource = pi_obj_Category.GetCategory()
        lstCategory.DataBind()
        lstCategory.SelectedIndex = 0
    End Sub
    Private Sub LoadTemplates()
        If (lstCategory.Items.Count > 0) Then
            lstTemplate.DataSource = pi_obj_Template.GetCategoryTemplates(lstCategory.SelectedValue)
            lstTemplate.DataBind()
            lstTemplate.SelectedIndex = 0
            Dim dt As New DataTable
            dt = pi_obj_Template.GetTemplate(lstTemplate.SelectedValue)
            ShowImage("../images/" & dt.Rows(0)("TemplateImage").ToString())
        End If
    End Sub
    Private Sub LoadCampaigns()
        Dim dtCampaign As DataTable = pi_obj_Campaign.GetMemberCampaigns(Session(Session_str_MemberID))
        If (dtCampaign.Rows.Count > 0) Then
            dgCampaign.DataSource = dtCampaign
            dgCampaign.DataBind()
            dgCampaign.SelectedIndex = -1
        Else
            dgCampaign.Visible = False
            lblConfirm.Text = "No campaign created."
            lblConfirm.Visible = True
        End If
    End Sub
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        CampaignName = txtCampaignName.Text
        Subject = txtSubject.Text
        tdCampaign.Visible = False
        tdselectTemplate.Visible = True
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        pi_obj_Campaign.campaign_id = CInt(txtCampaignId.Text)
        pi_obj_Campaign.campaign_name = txtCampaignName.Text
        pi_obj_Campaign.subject = txtSubject.Text
        pi_obj_Campaign.Update()

        Dim pi_obj_Template As New clsTemplate
        pi_obj_Template.campaign_id = pi_obj_Campaign.campaign_id
        Dim dr As DataRow = CType(pi_obj_Campaign.GetCampaignTemplate(pi_obj_Campaign.campaign_id), DataTable).Rows(0)

        Session(Session_str_TemplateID) = CInt(dr("TemplateID").ToString())
        Session(Session_str_CampaginID) = pi_obj_Campaign.campaign_id
        Session(Session_str_CampaginGUID) = pi_obj_Template.GetCampaignGUID(pi_obj_Campaign.campaign_id).Rows(0)("GUIDNo").ToString().Trim()
        Response.Redirect("Preview.aspx")

    End Sub
    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click

        tdCampaign.Visible = True
        tdselectTemplate.Visible = False

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
    Private Sub ClearForm()
        txtCampaignName.Text = ""
        txtSubject.Text = ""
        txtCampaignId.Text = ""
        btnUpdate.Visible = False
        btnNext.Visible = True
        'LoadCampaigns()
    End Sub
    Private Sub btnSaveTemplate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveTemplate.Click
        'Session(Session_str_MemberID) = 2
        Dim pi_obj_Template As New clsTemplate
        If (lstTemplate.SelectedIndex <> -1) Then
            Dim nCampaginID As Integer
            Dim nTemplateID As Integer
            Me.CategoryID = lstCategory.SelectedValue
            Me.TemplateID = lstTemplate.SelectedValue
            nTemplateID = lstTemplate.SelectedValue
            pi_obj_Template.campaign_name = txtCampaignName.Text 'CampaignName
            pi_obj_Template.subject = txtSubject.Text 'Subject
            pi_obj_Template.template_id = TemplateID
            pi_obj_Template.category_id = CategoryID
            pi_obj_Template.date_created = DateTime.Now
            pi_obj_Template.member_id = Session(Session_str_MemberID)
            Try
                pi_obj_Template.Insert()
                nCampaginID = pi_obj_Template.campaign_id
                If (nCampaginID > 0) Then
                    Session(Session_str_CampaginID) = nCampaginID
                    Session(Session_str_TemplateID) = nTemplateID
                    Session(Session_str_CampaginGUID) = pi_obj_Template.GetCampaignGUID(nCampaginID)
                End If
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine(ex.Message)
            End Try
            Response.Redirect("Preview.aspx")

        End If
    End Sub
    Private Sub dgCampaign_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCampaign.EditCommand
        lEditMode = True
        Dim dt As DataTable
        Dim dr As DataRow
        txtCampaignId.Text = CType(e.Item.Cells(3).FindControl("lblCampaignID"), Label).Text
        dt = pi_obj_Campaign.GetCampaignInfo(CInt(CType(e.Item.Cells(3).FindControl("lblCampaignID"), Label).Text))
        If (dt.Rows.Count > 0) Then
            dr = dt.Rows(0)
        Else
            Exit Sub
        End If
        txtCampaignName.Text = dr("CampaignName").ToString()
        txtSubject.Text = dr("Subject").ToString()
        dgCampaign.SelectedIndex = e.Item.ItemIndex
        btnNext.Visible = False
        btnUpdate.Visible = True
        lEditMode = True
    End Sub
    Private Sub dgCampaign_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgCampaign.DeleteCommand
        Dim dt As DataTable
        Dim dr As DataRow
        txtCampaignId.Text = CType(e.Item.Cells(3).FindControl("lblCampaignID"), Label).Text

        If (txtCampaignId.Text <> "") Then
            pi_obj_Campaign.campaign_id = CInt(txtCampaignId.Text)
            dt = pi_obj_Campaign.GetCampaignTemplate(CInt(txtCampaignId.Text))

            If (dt.Rows.Count > 0) Then
                ' Delete Params
                pi_obj_Campaign.DeleteCampaignParamValues(CInt(txtCampaignId.Text), CInt(dt.Rows(0)("TemplateID").ToString()))

                If (pi_obj_Campaign.DeleteCampaign(txtCampaignId.Text)) Then
                    lblConfirm.Visible = True
                    lblConfirm.Text = "The Campaign is successfully Deleted."
                    ClearForm()
                Else
                    lblConfirm.Visible = True
                    lblConfirm.Text = "Problem Deleting Campaign."
                End If
            End If
        End If
        dgCampaign.EditItemIndex = -1
        LoadCampaigns()

    End Sub
    Private Sub dgCampaign_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgCampaign.ItemDataBound
        'Dim btnDelete As ImageButton = CType(e.Item.Cells(2).FindControl("ibtnDelete"), ImageButton)
        'btnDelete.Attributes.Add("onclick", "javascript: return confirm('Are you sure you want to delete the campaign?');")
        If (e.Item.ItemType <> ListItemType.Header) Then
            Dim btnDelete As ImageButton
            btnDelete = e.Item.Cells(2).FindControl("ibtnDelete")
            If Not (btnDelete Is Nothing) Then
                btnDelete.Attributes.Add("onclick", "return confirm('Are you Sure you want to delete the selected parameter?');")
            End If
        End If

    End Sub

End Class
