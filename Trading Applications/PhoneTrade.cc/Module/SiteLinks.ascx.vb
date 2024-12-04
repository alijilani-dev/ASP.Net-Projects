Public Class SiteLinks
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DLSiteLinks As System.Web.UI.WebControls.DataList
    Protected WithEvents HyperLink1 As System.Web.UI.WebControls.HyperLink

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
#Region "Private Variables"
    Private pi_obj_Portal As New Trade_BL.Portal
    Private pi_Portal_ID As Integer
    Private pi_web_Path As String
    Private pi_dt_Site_Links As New DataTable
#End Region
#Region "Public Properties"
    Private Property Portal_ID() As Integer
        Get
            Return pi_Portal_ID
        End Get
        Set(ByVal Value As Integer)
            pi_Portal_ID = Value
        End Set
    End Property
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Put user code to initialize the page here
        'pi_dt_Site_Links = pi_obj_Portal.GetPortal()
        'System.Diagnostics.Debug.WriteLine(pi_dt_Site_Links.Rows.Count())
        'DLSiteLinks.DataSource = pi_dt_Site_Links
        'DLSiteLinks.DataBind()
    End Sub

    Private Sub DLSiteLinks_ItemDataBound(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataListItemEventArgs)
        Dim hypLinks As HyperLink
        hypLinks = e.Item.FindControl("hyperlink1")
        hypLinks.Attributes.Add("onmouseover", "this.firstChild.src='" & DataBinder.Eval(e.Item.DataItem, "portal_img_over_url") & "'")
        hypLinks.Attributes.Add("onmouseout", "this.firstChild.src='" & DataBinder.Eval(e.Item.DataItem, "portal_img_url") & "'")

    End Sub
End Class
