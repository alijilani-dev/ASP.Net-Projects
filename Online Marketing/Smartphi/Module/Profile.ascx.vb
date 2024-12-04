Imports SmartPhi_BL
Public Class Profile
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents btnSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents rfvCountry As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents ddlCountry As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtAddress As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCity As System.Web.UI.WebControls.TextBox
    Protected WithEvents redEmailId As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents rfvEmailId As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtEmailID As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtMobileNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents rfvFirstName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtContactPerson As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFaxNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents rfvTelephoneNo As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtPhoneNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents rfvUserName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtUserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents rfvMemberName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtMemberName As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblConfirm As System.Web.UI.WebControls.Label
    Protected WithEvents tbMain As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents table1 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents table2 As System.Web.UI.HtmlControls.HtmlTable

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private pi_obj_Member As New clsMember
    Private pi_obj_country As New clsCountry
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If Not Page.IsPostBack Then
            LoadCountry()
            LoadMemberDetails()


        End If

    End Sub

    Sub LoadMemberDetails()
        Dim dt As DataTable
        dt = pi_obj_Member.GetMembers(Session(Session_str_MemberID))

        If dt.Rows.Count > 0 Then
            pi_obj_Member.MemberID = Session(Session_str_MemberID)
            pi_obj_Member.MemberName = dt.Rows(0)("MemberName")
            pi_obj_Member.Address = dt.Rows(0)("Address")
            pi_obj_Member.City = dt.Rows(0)("City")
            pi_obj_Member.CountryID = dt.Rows(0)("CountryID")
            pi_obj_Member.PhoneNo = dt.Rows(0)("PhoneNo")
            pi_obj_Member.FaxNo = dt.Rows(0)("FaxNo")
            pi_obj_Member.MobileNo = dt.Rows(0)("MobileNo")
            pi_obj_Member.ContactPerson = dt.Rows(0)("ContactPerson")
            pi_obj_Member.EmailID = dt.Rows(0)("EmailID")
            pi_obj_Member.UserName = dt.Rows(0)("UserName")

            txtMemberName.Text = pi_obj_Member.MemberName
            txtAddress.Text = pi_obj_Member.Address
            txtCity.Text = pi_obj_Member.City
            txtPhoneNo.Text = pi_obj_Member.PhoneNo
            txtFaxNo.Text = pi_obj_Member.FaxNo
            txtMobileNo.Text = pi_obj_Member.MobileNo
            txtContactPerson.Text = pi_obj_Member.ContactPerson
            txtEmailID.Text = pi_obj_Member.EmailID
            txtUserName.Text = pi_obj_Member.UserName

            ddlCountry.SelectedIndex = -1
            Dim liSelection As ListItem
            liSelection = ddlCountry.Items.FindByValue(pi_obj_Member.CountryID)
            liSelection.Selected = True


        End If
    End Sub
    Sub LoadCountry()
        pi_obj_country.GetCountry()
        ddlCountry.DataSource = pi_obj_country.GetCountry()
        ddlCountry.DataBind()

        ddlCountry.SelectedIndex = 0

    End Sub
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        pi_obj_Member.MemberName = txtMemberName.Text
        pi_obj_Member.PhoneNo = txtPhoneNo.Text
        pi_obj_Member.Address = txtAddress.Text
        pi_obj_Member.FaxNo = txtFaxNo.Text
        pi_obj_Member.MobileNo = txtMobileNo.Text
        pi_obj_Member.ContactPerson = txtContactPerson.Text
        pi_obj_Member.City = txtCity.Text
        pi_obj_Member.CountryID = ddlCountry.SelectedValue
        pi_obj_Member.EmailID = txtEmailID.Text
        pi_obj_Member.UserName = txtUserName.Text
        pi_obj_Member.isActive = False

        If pi_obj_Member.Update(2) Then
            lblConfirm.Visible = True
            lblConfirm.Text = "Your profile has been modified successfully."

        End If
    End Sub
End Class
