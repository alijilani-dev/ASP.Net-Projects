Public Class myaccount
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

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
    Dim pi_obj_mainlinks As New Trade_BL.MainLinks
    Dim Pi_dt_link As New DataTable
    Dim Pi_dr_link As DataRow
    Dim pi_main_link_ID As Integer
    Dim pi_WebPath As String

#End Region

#Region "Public variables"
    Public WithEvents TradeMainCtrl As TradeMain
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        ' get the current Link ID from query string 
        ' and set the Session Variable 
        ' cureent Main_Link_ID

        pi_main_link_ID = Request.QueryString("Main_Links_ID")

        pi_WebPath = ""
        TradeMainCtrl.Main_Links_ID = pi_main_link_ID

        'ShowLogo()
        'ShowBanner()
        'ShowMainLinks()
        'ShowLeftPane()
        'ShowContent()
        'ShowRightPane()
        'ShowFooter()
    End Sub


End Class
