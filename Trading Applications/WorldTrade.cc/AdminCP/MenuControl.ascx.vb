Public Class MenuControl
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents hlnkMembers As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkMobileReview As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkMainlinks As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkPr As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkCountry As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkTestimonial As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkNews As System.Web.UI.WebControls.HyperLink
    Protected WithEvents lnkButLogOut As System.Web.UI.WebControls.LinkButton
    Protected WithEvents hlnkAdvertisement As System.Web.UI.WebControls.HyperLink

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
    End Sub

    Private Sub lnkButLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkButLogOut.Click
        Session(Session_str_Admin) = "FALSE"
        Response.Redirect("..\default.aspx?Portal_ID=" & Session(Session_str_Portal_ID))
    End Sub
End Class
