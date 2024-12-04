Public MustInherit Class ChangePassword
  Inherits TradeControl
  Protected WithEvents tbOldPassword As System.Web.UI.WebControls.TextBox
  Protected WithEvents tbNewPassword As System.Web.UI.WebControls.TextBox
  Protected WithEvents RFVOldPassword As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RFVNewPassword As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents RFVReNewPassword As System.Web.UI.WebControls.RequiredFieldValidator
  Protected WithEvents CVReNewPassword As System.Web.UI.WebControls.CompareValidator
  Protected WithEvents butOk As System.Web.UI.WebControls.Button
  Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
  Protected WithEvents tbReNewPassword As System.Web.UI.WebControls.TextBox

#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Put user code to initialize the page here
        If Session(Session_str_UserName) = "" Or Session(Session_str_UserName) Is Nothing Then
            Response.Redirect("PortalDefault.aspx?Main_Links_ID=24")
        End If
        'If Page.IsPostBack = False Then
        'lblMessage.Text = "Change Password"
        'End If
  End Sub

  Private Sub butOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOk.Click
    Dim l_Obj_Member As New Trade_BL.Member()
    Dim dt_member As DataTable
    Dim oldpassword As String
    Try

      dt_member = l_Obj_Member.GetMembers(Session(Session_str_UserName))
            If dt_member.Rows.Count > 0 Then
                lblMessage.Visible = True
                oldpassword = dt_member.Rows(0).Item("password")
                If tbOldPassword.Text.ToString.Equals(oldpassword) Then
                    l_Obj_Member.UpdatePassword(Session(Session_str_UserName), tbNewPassword.Text)
                    lblMessage.Text = "Your password has been modified sucessfully!"
                    'If String.Compare(oldpassword, tbOldPassword.Text, False) > 0 Then
                Else
                    lblMessage.Text = "Old Password is incorrect, Please try again!"
                End If
            End If

        Catch ex As Exception
      Throw ex
    End Try
  End Sub
End Class
