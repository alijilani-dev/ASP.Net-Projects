Imports System.Text
Imports GotDotNet.ApplicationBlocks.Data
Imports SmartPhi_BL

Public Class Login
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Middle As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents hlnkRegister As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkForgetPwd As System.Web.UI.WebControls.HyperLink
    Protected WithEvents btnSignIn As System.Web.UI.WebControls.Button
    Protected WithEvents txtPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents rfvUserName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtUserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents rfvPwd As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lblInvalid As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private pi_obj_member As New clsMember
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblInvalid.Visible = False

        Dim reqModule As String
        reqModule = Request.QueryString("mode") & ""
        If reqModule.ToString.Length > 0 And reqModule = "logout" Then
            Logout()
        End If

    End Sub
    Sub Logout()
        Session(Session_str_UserName) = ""
        Session(Session_str_MembName) = ""
        Session(Session_str_MemberID) = 0
        Session.Abandon()
    End Sub
    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        Dim pi_obj_Encrypt As New clsEncryptData

        If pi_obj_member.IsValidMember(txtUserName.Text.Trim, pi_obj_Encrypt.Encrypt(txtPassword.Text.Trim)) Then
            Session(Session_str_UserName) = txtUserName.Text.Trim
            Session(Session_str_MembName) = pi_obj_member.MemberName
            Session(Session_str_MemberID) = pi_obj_member.MemberID

            Response.Redirect("MemberArea.aspx")
        Else
            lblInvalid.Text = "User Name or Password is incorrect, Please try again"
            lblInvalid.Visible = True
        End If
    End Sub
End Class
