
Public Class Profile
    Inherits TradeControl
    Protected WithEvents idErrProfile As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents myEditor As FredCK.FCKeditorV2.FCKeditor
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents butOk As System.Web.UI.WebControls.Button

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
        Dim l_Obj_Member As New Trade_BL.Member
        Dim dt_member As DataTable
        Dim oldpassword As String
        Try

            If (Session(Session_str_UserName) = "" Or Session(Session_str_UserName) Is Nothing) Then
                Response.Redirect("PortalDefault.aspx?Main_Links_ID=24")
            End If
            If Not Page.IsPostBack Then
                dt_member = l_Obj_Member.GetMembers(Session(Session_str_UserName))
                myEditor.Value = Server.HtmlDecode(dt_member.Rows(0).Item("Profile").ToString)
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub butOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOk.Click
        Dim l_Obj_Member As New Trade_BL.Member
        Try
            'System.Diagnostics.Debug.Write(myEditor.Value)
            l_Obj_Member.UpdateProfile(Session(Session_str_Portal_ID), Session(Session_str_UserName), Server.HtmlEncode(myEditor.Value))
            lblMessage.Text = "Your profile has been updated successfully."
            lblMessage.Visible = True
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class
