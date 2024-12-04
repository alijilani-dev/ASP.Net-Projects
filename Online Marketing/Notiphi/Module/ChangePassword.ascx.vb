Imports NotiPhi_BL

Public Class ChangePassword

    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents btnUpdate As System.Web.UI.WebControls.Button
    Protected WithEvents rfv3 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rfv2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rfv1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lblConfirm As System.Web.UI.WebControls.Label
    Protected WithEvents tblGroup As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents txtOldpwd As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNewpwd As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRetypepwd As System.Web.UI.WebControls.TextBox
    Protected WithEvents CVReNewPassword As System.Web.UI.WebControls.CompareValidator

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Dim pi_obj_Member As New clsMember

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim pi_obj_Encrypt As New clsEncryptData
        Dim dtMember As DataTable
        Dim drMember As DataRow

        Try
            dtMember = pi_obj_Member.GetMembers(Session(Session_str_MemberID))
            drMember = dtMember.Rows(0)

            If pi_obj_Member.IsValidMember(drMember("UserName"), pi_obj_Encrypt.Encrypt(txtOldpwd.Text.Trim)) Then
                If pi_obj_Member.UpdatePassword(Session(Session_str_MemberID), pi_obj_Encrypt.Encrypt(txtNewpwd.Text)) Then
                    lblConfirm.Text = "Your password has been modified sucessfully!"
                    lblConfirm.Visible = True
                End If
            Else
                lblConfirm.Text = "Problem updating password! Old password does not match"
                lblConfirm.Visible = True
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.Write(ex.Message)
        End Try

    End Sub

End Class
