Imports System.Text
Imports GotDotNet.ApplicationBlocks.Data
Imports NotiPhi_BL

Public Class MemberArea1
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Middle As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents hlnkGroup As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkContactList As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkParams As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkCampaign As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkManageCampaign As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkTestCampaign As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkScheduleCampaign As System.Web.UI.WebControls.HyperLink
    Protected WithEvents HyperLink1 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents tbLogin As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents lblTitle As System.Web.UI.WebControls.Label
    Protected WithEvents lblTitle1 As System.Web.UI.WebControls.Label

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

        tbLogin.Visible = False
        If (CInt(Session(Session_str_MemberID)) = 0 Or Session(Session_str_MemberID) Is Nothing) Then
            Response.Redirect("Login.aspx")

        Else
            lblTitle.Text = Session(Session_str_MembName)
            lblTitle1.Text = Session(Session_str_MembName)
            tbLogin.Visible = True
        End If

    End Sub

End Class
