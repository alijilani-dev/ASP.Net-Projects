Public Class LoginBox
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents cmdclear As System.Web.UI.WebControls.Button
    Protected WithEvents cmdLogin As System.Web.UI.WebControls.Button
    Protected WithEvents RqFVUserpwd As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents tbPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPassword As System.Web.UI.WebControls.Label
    Protected WithEvents RqFVUsername As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents tbUserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblusername As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub
    Private Function Sessions(ByVal strName As String)
        If DateTime.Today < DateTime.Parse("02/02/06") Then
            Return Session(strName.ToString())
        Else
            Return ""
        End If
    End Function

#End Region

#Region "Private variables"
    Private pi_obj_member As New Trade_BL.Member
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbUserName.Text = ""
        tbPassword.Text = ""
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        Dim iPortalID As Integer
        iPortalID = Session(Session_str_Portal_ID)
        If pi_obj_member.IsValidMember(iPortalID, tbUserName.Text.Trim, tbPassword.Text.Trim) Then
            Session(Session_str_Admin) = False
            Session(Session_str_UserName) = tbUserName.Text.Trim
            If MyBase.Redirect_Main_Links_ID > 0 Then
                Response.Redirect("PortalDefault.aspx?Main_Links_ID=" & MyBase.Redirect_Main_Links_ID)
            Else
                Response.Redirect("PortalDefault.aspx?Main_Links_ID=" & MyBase.Main_Links_ID)
            End If
        Else
            tbUserName.Text = ""
            tbPassword.Text = ""
            'lblloginHeader.Text = "Not a Valid Member, Try Again"
        End If


    End Sub
End Class
