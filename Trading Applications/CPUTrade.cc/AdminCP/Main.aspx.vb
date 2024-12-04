Namespace Admin
    Public Class Main1
        Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

        'This call is required by the Web Form Designer.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

        End Sub
        Protected WithEvents Hyperlink2 As System.Web.UI.WebControls.HyperLink
        Protected WithEvents Body1 As System.Web.UI.HtmlControls.HtmlGenericControl

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
            'If Page.IsPostBack = False Then
            '    sMenu.DataSource = Server.MapPath("menu.xml")

            '    sMenu.HighlightTopMenu = True

            '    sMenu.DataBind()
            'End If

        End Sub

        Private Sub lnkButLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Session(Session_str_Admin) = "FALSE"
            Response.Redirect("default.aspx")
        End Sub
    End Class
End Namespace