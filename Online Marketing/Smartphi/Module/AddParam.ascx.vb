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
    Protected WithEvents txtParamType As System.Web.UI.WebControls.TextBox

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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Not Page.IsPostBack) Then
            LoadTemplates()
            LoadParameters()
        End If
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim lcounter As Integer
        'Dim dr As DataRow

        pi_obj_Parameter.TemplateID = 1
        pi_obj_Parameter.CampaignID = Session("campaign_id")
        pi_obj_Parameter.ParameterName = txtParamName.Text
        pi_obj_Parameter.ParameterTypeID = ddlParamType.SelectedValue
        pi_obj_Parameter.ParameterValue = txtParamValue.Text
        pi_obj_Parameter.TemplateID = lstTemplate.SelectedValue
        Try
            If pi_obj_Parameter.Update(1) = True Then
                lblConfirm.Visible = True
                lblConfirm.Text = "A new parameter has been added successfully"
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

    Private Sub ddlTemplateName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlTemplateName.SelectedIndexChanged
        LoadParameters()
    End Sub

    Private Sub dgParams_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgParams.EditCommand
        dgParams.EditItemIndex = e.Item.ItemIndex
        Dim dt As DataTable
        Dim dr As DataRow
        dt = pi_obj_Parameter.GetParameters(1, CType(e.Item.FindControl("lblParamID"), Label).Text)
        If (dt.Rows.Count > 0) Then
            dr = dt.Rows(0)
        Else
            Exit Sub
        End If
        trGridView.Visible = False
        trFormView.Visible = True
        txtParamName.Text = dr("ParamName").ToString()
        ddlParamType.SelectedValue = dr("ParamTypeID").ToString()
        txtParamValue.Text = dr("ParamValue").ToString()
        lstTemplate.SelectedValue = dr("TemplateID").ToString()
        ' Saves current info on temporary, use later in Grids Itembound()
        LoadParameters()
    End Sub

    Private Sub dgParams_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgParams.DeleteCommand

    End Sub

    Private Sub dgParams_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgParams.CancelCommand
        dgParams.EditItemIndex = -1
        LoadParameters()
    End Sub

End Class
