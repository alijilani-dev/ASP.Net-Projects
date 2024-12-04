Imports SmartPhi_BL
Public Class MyProfile
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Middle As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents Table1 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tdContent As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents hlnkProfile As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkConfig As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkUpdatewd As System.Web.UI.WebControls.HyperLink

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If (CInt(Session(Session_str_MemberID)) = 0 Or Session(Session_str_MemberID) Is Nothing) Then
            Response.Redirect("..\Login.aspx")
        End If

        Dim reqModule As String
        reqModule = Request.QueryString("module") & ""
        If reqModule.ToString.Length > 0 And reqModule = "1" Then
            showProfile()
        ElseIf reqModule.ToString.Length > 0 And reqModule = "2" Then
            showMailSetting()
        ElseIf reqModule.ToString.Length > 0 And reqModule = "3" Then
            showChangePwd()
        End If
    End Sub
    Public Sub showProfile()

        Dim ctrl_TD_Group As Control ' td where we have to show the content control specified in module    
        ctrl_TD_Group = Me.FindControl("tdContent")
        ctrl_TD_Group.Visible = True
        Try
            ctrl_TD_Group.Controls.Add(Me.LoadControl("Profile.ascx"))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
        End Try
    End Sub
    Public Sub showMailSetting()

        Dim ctrl_TD_Group As Control ' td where we have to show the content control specified in module    
        ctrl_TD_Group = Me.FindControl("tdContent")
        ctrl_TD_Group.Visible = True
        Try
            ctrl_TD_Group.Controls.Add(Me.LoadControl("UpdateMailSettings.ascx"))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
        End Try
    End Sub
    Public Sub showChangePwd()

        Dim ctrl_TD_Group As Control ' td where we have to show the content control specified in module    
        ctrl_TD_Group = Me.FindControl("tdContent")
        ctrl_TD_Group.Visible = True
        Try
            ctrl_TD_Group.Controls.Add(Me.LoadControl("ChangePassword.ascx"))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
        End Try
    End Sub
End Class
