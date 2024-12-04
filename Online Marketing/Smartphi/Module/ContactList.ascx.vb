Imports SmartPhi_BL
Public Class ContactList
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents btnCreate As System.Web.UI.WebControls.Button
    Protected WithEvents ibtnDelete As System.Web.UI.WebControls.ImageButton
    Protected WithEvents redEmailId As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents rfvEmailId As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtContactName As System.Web.UI.WebControls.TextBox
    Protected WithEvents rfvContactName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtAddress As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmailID As System.Web.UI.WebControls.TextBox
    Protected WithEvents lstGroup As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblConfirm As System.Web.UI.WebControls.Label
    Protected WithEvents ddlGroupName As System.Web.UI.WebControls.DropDownList
    Protected WithEvents dgContacts As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnCreateNew As System.Web.UI.WebControls.Button
    Protected WithEvents tblCreateContact As System.Web.UI.HtmlControls.HtmlTable

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
    Private pi_obj_Contact As New clsContact

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not (Page.IsPostBack) Then
            LoadGroupNames()
            LoadContactList()
        End If

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        Dim lcounter As Integer
        Dim dr As DataRow, strGroupID As String

        pi_obj_Contact.ContactName = txtContactName.Text
        pi_obj_Contact.ContactEmailID = txtEmailID.Text
        pi_obj_Contact.ContactAddress = txtAddress.Text
        pi_obj_Contact.IsActive = True
        strGroupID = ""
        For Each lstItem As ListItem In lstGroup.Items
            If lstItem.Selected Then strGroupID = strGroupID & "," & lstItem.Value
        Next
        pi_obj_Contact.GroupID = Mid(strGroupID, 2)
        Try
            If pi_obj_Contact.Update(1) = True Then
                lblConfirm.Visible = True
                lblConfirm.Text = "Contact name has been added successfully"
                LoadContactList()
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

        EmptyForm()

    End Sub

    Private Sub LoadGroupNames()

        Dim dtGroupNames As DataTable
        dtGroupNames = pi_obj_Group.GetGroups(Session(Session_str_MemberID))
        lstGroup.DataSource = dtGroupNames
        lstGroup.DataBind()
        lstGroup.SelectedIndex = 0

        ddlGroupName.DataSource = dtGroupNames
        ddlGroupName.DataBind()
        ddlGroupName.SelectedIndex = 0

    End Sub

    Private Sub LoadContactList()

        If ddlGroupName.SelectedIndex <> -1 Then
            Dim dtContacts As DataTable
            dtContacts = pi_obj_Contact.GetGroupContact(Session(Session_str_MemberID), ddlGroupName.SelectedValue)
            dgContacts.DataSource = dtContacts
            dgContacts.DataBind()
        End If

    End Sub

    Private Sub dgContacts_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgContacts.ItemDataBound

        If e.Item.ItemType = ListItemType.EditItem Then

            Dim txtBox As TextBox = CType(e.Item.FindControl("ContactName"), TextBox)
            txtBox.Text = pi_obj_Contact.ContactName

            txtBox = CType(e.Item.FindControl("EmailID"), TextBox)
            txtBox.Text = pi_obj_Contact.ContactEmailID

            txtBox = CType(e.Item.FindControl("Address"), TextBox)
            txtBox.Text = pi_obj_Contact.ContactAddress

            Dim chkBox As CheckBox = CType(e.Item.FindControl("Active"), CheckBox)
            chkBox.Checked = pi_obj_Contact.IsActive

        End If

        If (e.Item.ItemType <> ListItemType.Header) Then

            Dim ibtnDelete As ImageButton
            ibtnDelete = e.Item.Cells(4).FindControl("ibtnDelete")

            If Not (ibtnDelete Is Nothing) Then
                ibtnDelete.Attributes.Add("onclick", "return confirm('Are you Sure you want to delete the selected contact?');")
            End If

        End If

    End Sub

    Private Sub dgContacts_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgContacts.DeleteCommand

        Try
            pi_obj_Contact.DeleteGroupContact(ddlGroupName.SelectedValue, CType(e.Item.FindControl("lblContactID"), Label).Text)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        dgContacts.EditItemIndex = -1
        LoadContactList()

    End Sub

    Private Sub dgContacts_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgContacts.UpdateCommand

        pi_obj_Contact.ContactID = CType(e.Item.FindControl("ContactID"), TextBox).Text
        pi_obj_Contact.ContactName = CType(e.Item.FindControl("ContactName"), TextBox).Text
        pi_obj_Contact.ContactAddress = CType(e.Item.FindControl("Address"), TextBox).Text
        pi_obj_Contact.ContactEmailID = CType(e.Item.FindControl("EmailID"), TextBox).Text
        pi_obj_Contact.IsActive = CType((CType(e.Item.FindControl("Active"), CheckBox).Checked), Boolean)

        Try
            If pi_obj_Contact.Update(2) = True Then
                lblConfirm.Visible = True
                lblConfirm.Text = "Contact name has been updated successfully"

            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        dgContacts.EditItemIndex = -1
        LoadContactList()

    End Sub

    Private Sub dgContacts_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgContacts.EditCommand

        dgContacts.EditItemIndex = e.Item.DataSetIndex
        ' Saves current info on temporary, use later in Grids Itembound()
        pi_obj_Contact.ContactID = CType(e.Item.FindControl("lblContactID"), Label).Text
        pi_obj_Contact.ContactName = CType(e.Item.FindControl("lblContactName"), Label).Text
        pi_obj_Contact.ContactAddress = CType(e.Item.FindControl("lblContactAddress"), Label).Text
        pi_obj_Contact.ContactEmailID = CType(e.Item.FindControl("lblContactEmailID"), Label).Text
        pi_obj_Contact.IsActive = CType((CType(e.Item.FindControl("lblActive"), Label).Text), Boolean)
        LoadContactList()

    End Sub

    Private Sub _CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgContacts.CancelCommand

        dgContacts.EditItemIndex = -1
        LoadContactList()

    End Sub

    Private Sub ddlGroupName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlGroupName.SelectedIndexChanged

        LoadContactList()
        btnCreateNew.Visible = True
        tblCreateContact.Visible = False

    End Sub

    Private Sub btnCreateNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNew.Click

        btnCreateNew.Visible = False
        lstGroup.SelectedValue = ddlGroupName.SelectedValue
        tblCreateContact.Visible = True
        lblConfirm.Text = String.Empty
        lblConfirm.Visible = False

    End Sub

    Private Function EmptyForm()

        txtContactName.Text = String.Empty
        txtAddress.Text = String.Empty
        txtEmailID.Text = String.Empty

    End Function

End Class
