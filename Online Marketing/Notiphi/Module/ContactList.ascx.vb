Imports NotiPhi_BL
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
    Protected WithEvents txtEmailID As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblConfirm As System.Web.UI.WebControls.Label
    Protected WithEvents ddlGroupName As System.Web.UI.WebControls.DropDownList
    Protected WithEvents dgContacts As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnCreateNew As System.Web.UI.WebControls.Button
    Protected WithEvents tblCreateContact As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents txtMobileno As System.Web.UI.WebControls.TextBox
    Protected WithEvents Requiredfieldvalidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents chkLstGroup As System.Web.UI.WebControls.CheckBoxList
    Protected WithEvents txtContactID As System.Web.UI.WebControls.TextBox
    Protected WithEvents rblStatus As System.Web.UI.WebControls.RadioButtonList
    Protected WithEvents btnUpdateContact As System.Web.UI.WebControls.Button
    Protected WithEvents lblTitle As System.Web.UI.WebControls.Label
    Protected WithEvents txtGroupIDstoDelete As System.Web.UI.WebControls.TextBox

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
    Private pi_obj_Contact As New clsPhoneBook
    Dim lEditMode As Boolean
    'Private pi_int_GroupIDsToDelete As String

    'Property GroupIDsToDelete() As String
    '    Get
    '        Return pi_int_GroupIDsToDelete
    '    End Get
    '    Set(ByVal Value As String)
    '        pi_int_GroupIDsToDelete = Value
    '    End Set
    'End Property
    'Private pi_int_HiddenGroupID As Integer

    'Property HiddenGroupID() As Integer
    '    Get
    '        Return pi_int_HiddenGroupID
    '    End Get
    '    Set(ByVal Value As Integer)
    '        pi_int_HiddenGroupID = Value
    '    End Set
    'End Property
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
        pi_obj_Contact.ContactMobileNo = txtMobileno.Text
        pi_obj_Contact.IsActive = IIf(rblStatus.Items(0).Selected, 1, 0)
        strGroupID = ""
        For Each lstItem As ListItem In chkLstGroup.Items
            If lstItem.Selected Then strGroupID = strGroupID & "," & lstItem.Value
        Next
        pi_obj_Contact.GroupID = GetHiddenGroupID() & strGroupID 'Mid(strGroupID, 2)
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

    Private Sub LoadGroupNames(Optional ByVal prmBindSelectGroup As Boolean = True)
        Dim dtGroupNames As DataTable
        dtGroupNames = pi_obj_Group.GetAllGroupNames(Session(Session_str_MemberID))
        If prmBindSelectGroup Then
            ddlGroupName.DataSource = dtGroupNames
            ddlGroupName.DataBind()
            ddlGroupName.SelectedIndex = 0
            ddlGroupName.Items.FindByText("Individuals").Text = "All Individual Contacts"
        End If

        chkLstGroup.DataSource = dtGroupNames
        chkLstGroup.DataBind()
        chkLstGroup.Items.Remove(chkLstGroup.Items.FindByText("Individuals"))

    End Sub
    Private Function GetHiddenGroupID() As Integer
        Dim dtGroupNames As DataTable
        dtGroupNames = pi_obj_Group.GetAllGroupNames(Session(Session_str_MemberID))
        If dtGroupNames.Rows.Count > 0 Then
            Return CType(dtGroupNames.Rows(0)("GroupID"), Integer)
        End If
    End Function
    Private Sub LoadContactList()

        If ddlGroupName.SelectedIndex <> -1 Then
            Dim dtContacts As DataTable
            dtContacts = pi_obj_Contact.GetGroupContact(Session(Session_str_MemberID), ddlGroupName.SelectedValue)
            dgContacts.DataSource = dtContacts
            dgContacts.DataBind()
        End If

    End Sub

    Private Sub dgContacts_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles dgContacts.ItemDataBound

        'If e.Item.ItemType = ListItemType.EditItem Then

        '    Dim txtBox As TextBox = CType(e.Item.FindControl("ContactName"), TextBox)
        '    txtBox.Text = pi_obj_Contact.ContactName

        '    txtBox = CType(e.Item.FindControl("EmailID"), TextBox)
        '    txtBox.Text = pi_obj_Contact.ContactEmailID

        '    txtBox = CType(e.Item.FindControl("ContactMobile"), TextBox)
        '    txtBox.Text = pi_obj_Contact.ContactMobileNo

        '    Dim chkBox As CheckBox = CType(e.Item.FindControl("Active"), CheckBox)
        '    chkBox.Checked = pi_obj_Contact.IsActive

        'End If

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

    ''Private Sub dgContacts_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgContacts.UpdateCommand

    ''    pi_obj_Contact.ContactID = CType(e.Item.FindControl("ContactID"), TextBox).Text
    ''    pi_obj_Contact.ContactName = CType(e.Item.FindControl("ContactName"), TextBox).Text
    ''    pi_obj_Contact.ContactMobileNo = CType(e.Item.FindControl("ContactMobile"), TextBox).Text
    ''    pi_obj_Contact.ContactEmailID = CType(e.Item.FindControl("EmailID"), TextBox).Text
    ''    pi_obj_Contact.IsActive = CType((CType(e.Item.FindControl("Active"), CheckBox).Checked), Boolean)

    ''    Try
    ''        If pi_obj_Contact.Update(2) = True Then
    ''            lblConfirm.Visible = True
    ''            lblConfirm.Text = "Contact name has been updated successfully"

    ''        End If
    ''    Catch ex As Exception
    ''        System.Diagnostics.Debug.WriteLine(ex.Message)
    ''    End Try
    ''    dgContacts.EditItemIndex = -1
    ''    LoadContactList()

    ''End Sub

    Private Sub dgContacts_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgContacts.EditCommand

        dgContacts.EditItemIndex = e.Item.DataSetIndex
        '' Saves current info on temporary, use later in Grids Itembound()
        'pi_obj_Contact.ContactID = CType(e.Item.FindControl("lblContactID"), Label).Text
        'pi_obj_Contact.ContactName = CType(e.Item.FindControl("lblContactName"), Label).Text
        'pi_obj_Contact.ContactMobileNo = CType(e.Item.FindControl("lblContactMobile"), Label).Text
        'pi_obj_Contact.ContactEmailID = CType(e.Item.FindControl("lblContactEmailID"), Label).Text
        'pi_obj_Contact.IsActive = CType((CType(e.Item.FindControl("lblActive"), Label).Text), Boolean)
        LoadContactList()
        LoadGroupNames(False)

        Dim dt As DataTable
        Dim dr As DataRow
        txtContactID.Text = CType(e.Item.FindControl("lblContactID"), Label).Text
        dt = pi_obj_Contact.GetPhoneBook(CInt(txtContactID.Text))
        If (dt.Rows.Count > 0) Then
            dr = dt.Rows(0)
            lEditMode = True
        Else
            lEditMode = False
            Exit Sub
        End If
        txtContactName.Text = dr("ContactName").ToString()
        txtMobileno.Text = dr("ContactMobileNo").ToString()
        txtEmailID.Text = dr("ContactEmailID").ToString()
        rblStatus.Items(0).Selected = CType(dr("IsActive"), Boolean)
        rblStatus.Items(1).Selected = Not rblStatus.Items(0).Selected

        LoadGroupForEdit(CInt(txtContactID.Text))

        lEditMode = True
        btnCreate.Visible = False
        btnUpdateContact.Visible = True
        tblCreateContact.Visible = True
        lblTitle.Text = "Edit Contact"
    End Sub
    Private Sub LoadGroupForEdit(ByVal prmContactID As Integer)
        Dim dtGroupNames As DataTable
        Dim strGroupID As String
        dtGroupNames = pi_obj_Contact.GetGroupContactByID(prmContactID)

        If dtGroupNames.Rows.Count > 0 Then
            Dim dr As DataRow
            strGroupID = ""
            For Each dr In dtGroupNames.Rows
                chkLstGroup.Items.FindByValue(dr("GroupID")).Selected = True
                strGroupID = strGroupID & "," & dr("GroupID")
            Next
            txtGroupIDstoDelete.Text = Mid(strGroupID, 2)
        Else
            txtGroupIDstoDelete.Text = String.Empty 'GetHiddenGroupID()
        End If
        'chkLstGroup.DataSource = dtGroupNames
        'chkLstGroup.DataBind()
        'chkLstGroup.Items.Remove(chkLstGroup.Items.FindByText("Individuals"))

    End Sub
    Private Sub dgContacts_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgContacts.CancelCommand

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
        'lstGroup.SelectedValue = ddlGroupName.SelectedValue
        tblCreateContact.Visible = True
        lblConfirm.Text = String.Empty
        lblConfirm.Visible = False
        btnCreate.Visible = True
        btnUpdateContact.Visible = False
        lblTitle.Text = "Add New Contact"
        EmptyForm()
    End Sub

    Private Function EmptyForm()

        txtContactName.Text = String.Empty
        txtMobileno.Text = String.Empty
        txtEmailID.Text = String.Empty

    End Function

    Private Sub btnUpdateContact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdateContact.Click
        Dim strGroupID As String
        pi_obj_Contact.ContactID = txtContactID.Text
        pi_obj_Contact.ContactName = txtContactName.Text
        pi_obj_Contact.ContactMobileNo = txtMobileno.Text
        pi_obj_Contact.ContactEmailID = txtEmailID.Text
        pi_obj_Contact.IsActive = IIf(rblStatus.Items(0).Selected, 1, 0)
        pi_obj_Contact.GroupIDsToDelete = txtGroupIDstoDelete.Text

        strGroupID = ""
        For Each lstItem As ListItem In chkLstGroup.Items
            If lstItem.Selected Then strGroupID = strGroupID & "," & lstItem.Value
        Next
        pi_obj_Contact.GroupID = Mid(strGroupID, 2) 'GetHiddenGroupID() &

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
        btnCreate.Visible = False
        btnUpdateContact.Visible = False
        tblCreateContact.Visible = False

    End Sub
End Class
