Imports SmartPhi_BL

Public Class AddParam
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents btnCreate As System.Web.UI.WebControls.Button
    Protected WithEvents lblConfirm As System.Web.UI.WebControls.Label
    Protected WithEvents dgParams As System.Web.UI.WebControls.DataGrid
    Protected WithEvents ddlTemplateName As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtParamName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEditParamName As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlParamType As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lstTemplate As System.Web.UI.WebControls.ListBox
    Protected WithEvents rfvParamName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rfvDefaultValue As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtParamValue As System.Web.UI.WebControls.TextBox
    Protected WithEvents trGridView As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents trFormView As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents lnkCreateParam As System.Web.UI.WebControls.LinkButton
    Protected WithEvents btnUpdate As System.Web.UI.WebControls.Button
    Protected WithEvents txtParamId As System.Web.UI.WebControls.TextBox

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Private pi_obj_Template As New clsTemplate
    Private pi_obj_Parameter As New clsParameter
    Dim lEditMode As Boolean

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Not Page.IsPostBack) Then
            lEditMode = False
            LoadTemplates()
            LoadParameters()
            LoadParametersTypes()
        End If
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim lcounter As Integer

        pi_obj_Parameter.TemplateID = ddlTemplateName.SelectedValue
        pi_obj_Parameter.CampaignID = Session(Session_str_CampaginID) ' Session("campaign_id")
        pi_obj_Parameter.ParameterName = txtParamName.Text
        pi_obj_Parameter.ParameterTypeID = ddlParamType.SelectedValue
        pi_obj_Parameter.TemplateID = lstTemplate.SelectedValue

        Try
            If pi_obj_Parameter.Update(False) = True Then
                lblConfirm.Visible = True
                lblConfirm.Text = "A new parameter has been added successfully"
                ClearForm()
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub LoadTemplates()
        Dim dtTemplates As DataTable
        dtTemplates = pi_obj_Template.GetTemplate()
        lstTemplate.DataSource = dtTemplates
        lstTemplate.DataBind()
        lstTemplate.SelectedIndex = 0

        ddlTemplateName.DataSource = dtTemplates
        ddlTemplateName.DataBind()
        ddlTemplateName.SelectedIndex = 0
        trFormView.Visible = False
    End Sub

    Private Sub LoadParameters()
        Try
            Dim dtParams As DataTable
            dtParams = pi_obj_Parameter.GetParameters(Session(Session_str_MemberID), ddlTemplateName.SelectedValue)
            dgParams.DataSource = dtParams
            dgParams.DataKeyField = "ParamID"
            dgParams.DataBind()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub LoadParametersTypes()
        Try
            ddlParamType.Items.Clear()
            Dim dtParamTypes As DataTable
            dtParamTypes = pi_obj_Parameter.GetParamTypes()
            ddlParamType.DataSource = dtParamTypes
            ddlParamType.DataBind()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub ddlTemplateName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlTemplateName.SelectedIndexChanged
        LoadParameters()
        lstTemplate.SelectedValue = ddlTemplateName.SelectedValue
        lblConfirm.Visible = True
        lblConfirm.Text = ""
        trGridView.Visible = True
        trFormView.Visible = False
    End Sub

    Private Sub dgParams_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgParams.EditCommand
        lEditMode = True
        Dim dt As DataTable
        Dim dr As DataRow
        txtParamId.Text = CType(e.Item.Cells(5).FindControl("lblParamID"), Label).Text
        dt = pi_obj_Parameter.GetParameterDetails(CType(e.Item.Cells(5).FindControl("lblParamID"), Label).Text)
        If (dt.Rows.Count > 0) Then
            dr = dt.Rows(0)
        Else
            Exit Sub
        End If
        trGridView.Visible = False
        trFormView.Visible = True
        LoadParametersTypes()
        txtParamName.Text = dr("ParamName").ToString()
        ddlParamType.SelectedValue = dr("ParamTypeID").ToString()
        lstTemplate.SelectedValue = dr("TemplateID").ToString()
        ' Saves current info on temporary, use later in Grids Itembound()
        LoadParameters()
        lEditMode = True
    End Sub

    Private Sub dgParams_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgParams.DeleteCommand

        Dim dt As DataTable
        Dim dr As DataRow
        txtParamId.Text = CType(e.Item.Cells(5).FindControl("lblParamID"), Label).Text
        If (txtParamId.Text <> "") Then
            lblConfirm.Visible = True
            pi_obj_Parameter.ParameterID = txtParamId.Text
            If (pi_obj_Parameter.DeleteParameter(txtParamId.Text)) Then
                lblConfirm.Visible = True
                lblConfirm.Text = "The parameter is successfully Deleted."
                ClearForm()
            Else
                lblConfirm.Visible = True
                lblConfirm.Text = "Problem Updating Parameter."
            End If
        End If

        dgParams.EditItemIndex = -1
        LoadParameters()

    End Sub

    Private Sub dgParams_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgParams.CancelCommand
        dgParams.EditItemIndex = -1
        LoadParameters()
    End Sub

    Private Function ClearForm()
        txtParamId.Text = ""
        txtParamName.Text = ""
        LoadParametersTypes()
        ddlParamType.SelectedIndex = 0
        lstTemplate.SelectedValue = ddlTemplateName.SelectedValue
    End Function

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        If (lEditMode) Then
            'btnCreate.Text = "Update Parameter"
            btnUpdate.Visible = True
            btnCreate.Visible = False
        Else
            'btnCreate.Text = "Create New Parameter"
            btnUpdate.Visible = False
            btnCreate.Visible = True
        End If

    End Sub

    Private Sub lnkCreateParam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkCreateParam.Click

        lEditMode = False
        trGridView.Visible = False
        trFormView.Visible = True
        ClearForm()

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim lcounter As Integer

        If (txtParamId.Text <> "") Then
            lblConfirm.Visible = True
            pi_obj_Parameter.ParameterID = txtParamId.Text
            'ClearForm()
        Else
            lblConfirm.Text = "Problem Updating Parameter."
        End If
        pi_obj_Parameter.TemplateID = ddlTemplateName.SelectedValue
        pi_obj_Parameter.CampaignID = Session(Session_str_CampaginID) 'Session("campaign_id")
        pi_obj_Parameter.ParameterName = txtParamName.Text
        pi_obj_Parameter.ParameterTypeID = ddlParamType.SelectedValue
        pi_obj_Parameter.TemplateID = lstTemplate.SelectedValue

        Try
            If pi_obj_Parameter.Update(True) = True Then
                lblConfirm.Visible = True
                lblConfirm.Text = "A new parameter has been Updated successfully"
                ClearForm()
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub dgParams_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgParams.ItemDataBound

        If (e.Item.ItemType <> ListItemType.Header) Then
            Dim ibtnDelete As ImageButton
            'ibtnDelete = CType(dgParams.Items(e.Item.ItemIndex).Cells(5).FindControl("imgDelete"), ImageButton)
            ibtnDelete = e.Item.Cells(4).FindControl("imgDelete")
            If Not (ibtnDelete Is Nothing) Then
                ibtnDelete.Attributes.Add("onclick", "return confirm('Are you Sure you want to delete the selected parameter?');")
            End If
        End If

    End Sub

End Class
