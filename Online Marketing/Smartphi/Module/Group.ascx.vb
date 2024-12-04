Imports NotiPhi_BL

Public Class GroupControl

    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents btnCreate As System.Web.UI.WebControls.Button
    Protected WithEvents rfvGroupName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtGroupName As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMode As System.Web.UI.WebControls.Label
    Protected WithEvents lblConfirm As System.Web.UI.WebControls.Label
    Protected WithEvents lstGroup As System.Web.UI.WebControls.ListBox
    Protected WithEvents btnEdit As System.Web.UI.WebControls.Button
    Protected WithEvents btnDelete As System.Web.UI.WebControls.Button
    Protected WithEvents btnViewContact As System.Web.UI.WebControls.Button
    Protected WithEvents btnUpdate As System.Web.UI.WebControls.Button
    Protected WithEvents tblGroup As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents btnNew As System.Web.UI.WebControls.Button

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Private variables"
    Private pi_obj_Groups As New clsGroup
    'Private pi_str_Mode As String
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadGroupNames()
        tblGroup.Visible = False
        lblMode.Text = " [NEW]"
        btnCreate.Visible = True
        btnUpdate.Visible = False
        lstGroup.Attributes.Add("onChange", "javascript:EnableFunctions();")
        btnDelete.Attributes.Add("onclick", "return confirm('Are you sure you want to delete selected GROUP and all its CONTACTS?');")

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        Dim lcounter As Integer
        Dim dr As DataRow

        pi_obj_Groups.GroupName = txtGroupName.Text
        pi_obj_Groups.MemberID = Session(Session_str_MemberID)
        Try
            If pi_obj_Groups.CheckDuplicate = False Then
                If pi_obj_Groups.Update(1) = True Then
                    LoadGroupNames() ''Rebind the List box to bring added group name.
                    ShowConfirm()
                End If
            Else
                lblConfirm.Visible = True
                lblConfirm.Text = "Group name '" & txtGroupName.Text & "' already exists. Group name can not be duplicated."
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub ShowConfirm()

        lblConfirm.Visible = True
        lblConfirm.Text = "Group name has been added successfully"

    End Sub

    Private Sub LoadGroupNames()

        lstGroup.DataSource = pi_obj_Groups.GetGroups(Session(Session_str_MemberID))
        lstGroup.DataBind()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        LoadGroupNameForEdit(lstGroup.SelectedValue)
        tblGroup.Visible = True

    End Sub

    Private Sub LoadGroupNameForEdit(ByVal prmGoupID As Integer)

        Dim dtGroup As DataTable
        Try
            dtGroup = pi_obj_Groups.GetGroups(Session(Session_str_MemberID), prmGoupID)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        If dtGroup.Rows.Count > 0 Then
            txtGroupName.Text = dtGroup.Rows(0)("GroupName")
            lblMode.Text = " [EDIT]"
            btnUpdate.Visible = True
            btnCreate.Visible = False
        End If

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        pi_obj_Groups.GroupID = lstGroup.SelectedValue
        pi_obj_Groups.GroupName = txtGroupName.Text
        pi_obj_Groups.MemberID = Session(Session_str_MemberID)
        Try
            If pi_obj_Groups.CheckDuplicate = False Then
                If pi_obj_Groups.Update(2) = True Then
                    LoadGroupNames() 'Rebind the List box to bring added group name.
                    lblConfirm.Visible = True
                    lblConfirm.Text = "Group name has been modified successfully"

                End If
            Else
                lblConfirm.Visible = True
                lblConfirm.Text = "Group name '" & txtGroupName.Text & "' already exists. Group name can not be duplicated."
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        pi_obj_Groups.GroupID = lstGroup.SelectedValue
        pi_obj_Groups.MemberID = Session(Session_str_MemberID)
        Try
            If pi_obj_Groups.Delete = True Then
                LoadGroupNames() 'Rebind the List box to bring added group name.
                lblConfirm.Visible = True
                lblConfirm.Text = "Group name has been successfully deleted."
            Else
                lblConfirm.Visible = True
                lblConfirm.Text = "Group name can not be deleted."
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub btnViewContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewContact.Click
        Response.Redirect("Group.aspx?module=2")
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'tblGroup.Visible = True
    End Sub

    Private Sub lstGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstGroup.SelectedIndexChanged
        tblGroup.Visible = False
    End Sub

End Class
