Public Class Home
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

    '#Region "Public methods"
    '    Public Sub ShowLogo()
    '        Dim dt As New DataTable
    '        Dim dr As DataRow

    '        Dim ctrl_TD_Logo As Control ' td where we have to show the content control specified in module
    '        ctrl_TD_Logo = Page.FindControl("TD_Logo")

    '        Dim objmodule As New clsModules
    '        dt = objmodule.GetMainLinksModules(pi_main_link_ID, clsPlaceholder.Logo)

    '        Dim ctrl_Logo As Control
    '        If dt.Rows.Count > 0 Then
    '            dr = dt.Rows(0)
    '            If dr("Show_Flag") = 1 Then
    '                ctrl_TD_Logo.Visible = True
    '                Try
    '                    ctrl_Logo = Page.LoadControl(pi_WebPath & dr("module_url"))
    '                Catch ex As Exception
    '                    System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
    '                End Try

    '                ctrl_TD_Logo.Controls.Add(ctrl_Logo)
    '            Else
    '                ctrl_TD_Logo.Visible = False
    '            End If
    '        Else
    '            ctrl_TD_Logo.Visible = False
    '        End If
    '        objmodule = Nothing
    '    End Sub
    '    Public Sub ShowBanner()
    '        Dim dt As New DataTable
    '        Dim dr As DataRow
    '        Dim iWebControlCounter As Integer

    '        Dim ctrl_TD_Banner As Control ' td where we have to show the content control specified in module
    '        ctrl_TD_Banner = Page.FindControl("TD_Banner")

    '        Dim objmodule As New clsModules
    '        dt = objmodule.GetMainLinksModules(pi_main_link_ID, clsPlaceholder.Banner)

    '        Dim ctrl_Banner As TradeControl
    '        If dt.Rows.Count > 0 Then
    '            ctrl_TD_Banner.Visible = False
    '            For iWebControlCounter = 0 To dt.Rows.Count - 1
    '                dr = dt.Rows(iWebControlCounter)
    '                If dr("Show_Flag") = 1 Then
    '                    ctrl_TD_Banner.Visible = True
    '                    Try
    '                        ctrl_Banner = Page.LoadControl(pi_WebPath & dr("module_url"))
    '                    Catch ex As Exception
    '                        System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
    '                    End Try

    '                    ctrl_TD_Banner.Controls.Add(ctrl_Banner)
    '                Else
    '                    ctrl_TD_Banner.Visible = False
    '                End If
    '            Next
    '        Else
    '            ctrl_TD_Banner.Visible = False
    '        End If
    '        objmodule = Nothing
    '    End Sub
    '    Public Sub ShowMainLinks()
    '        Dim dt As New DataTable
    '        Dim dr As DataRow

    '        Dim ctrl_TD_Main_Link As Control ' td where we have to show the content control specified in module
    '        ctrl_TD_Main_Link = Page.FindControl("TD_Main_Link")

    '        Dim objmodule As New clsModules
    '        dt = objmodule.GetMainLinksModules(pi_main_link_ID, clsPlaceholder.MainLink) ' 3 constant position

    '        Dim ctrl_Main_Link As Control
    '        If dt.Rows.Count > 0 Then
    '            dr = dt.Rows(0)
    '            If dr("Show_Flag") = 1 Then
    '                ctrl_TD_Main_Link.Visible = True
    '                ctrl_Main_Link = Page.LoadControl(pi_WebPath & dr("module_url"))
    '                ctrl_TD_Main_Link.Controls.Add(ctrl_Main_Link)
    '            Else
    '                ctrl_TD_Main_Link.Visible = False
    '            End If
    '        Else
    '            ctrl_TD_Main_Link.Visible = False
    '        End If
    '        objmodule = Nothing
    '    End Sub
    '    Public Sub ShowLeftPane()
    '        Dim dt As New DataTable
    '        Dim dr As DataRow
    '        Dim iWebControlCounter As Integer

    '        Dim ctrl_TD_Left_Pane As Control ' td where we have to show the content control specified in module
    '        ctrl_TD_Left_Pane = Page.FindControl("TD_Left_Pane")

    '        Dim objmodule As New clsModules
    '        dt = objmodule.GetMainLinksModules(pi_main_link_ID, clsPlaceholder.LeftPane) ' 3 constant position

    '        Dim ctrl_Left_Pane As TradeControl
    '        If dt.Rows.Count > 0 Then
    '            ctrl_TD_Left_Pane.Visible = False
    '            For iWebControlCounter = 0 To dt.Rows.Count - 1
    '                dr = dt.Rows(iWebControlCounter)
    '                If dr("Show_Flag") = 1 Then
    '                    Try
    '                        ctrl_TD_Left_Pane.Visible = True
    '                        ctrl_Left_Pane = Page.LoadControl(pi_WebPath & dr("module_url"))
    '                        ctrl_Left_Pane.Module_ID = dr("Module_ID")
    '                        ctrl_TD_Left_Pane.Controls.Add(ctrl_Left_Pane)
    '                    Catch
    '                        ctrl_TD_Left_Pane.Visible = False
    '                    End Try
    '                End If
    '            Next
    '        Else
    '            ctrl_TD_Left_Pane.Visible = False
    '        End If
    '        objmodule = Nothing
    '    End Sub
    '    Public Sub ShowContent()
    '        Dim dt As New DataTable
    '        Dim dr As DataRow
    '        Dim iWebControlCounter As Integer

    '        Dim ctrl_TD_Content_Pane As Control ' td where we have to show the Content_Pane control specified in module
    '        ctrl_TD_Content_Pane = Page.FindControl("TD_Content_Pane")

    '        Dim objmodule As New clsModules
    '        dt = objmodule.GetMainLinksModules(pi_main_link_ID, clsPlaceholder.Content) ' 3 constant position

    '        Dim ctrl_Content_Pane As TradeControl
    '        If dt.Rows.Count > 0 Then
    '            ctrl_TD_Content_Pane.Visible = False
    '            For iWebControlCounter = 0 To dt.Rows.Count - 1
    '                dr = dt.Rows(iWebControlCounter)
    '                If dr("Show_Flag") = 1 Then
    '                    Try
    '                        ctrl_TD_Content_Pane.Visible = True

    '                        ctrl_Content_Pane = Page.LoadControl(pi_WebPath & dr("module_url"))
    '                        ctrl_Content_Pane.Module_ID = dr("Module_ID")
    '                        ctrl_TD_Content_Pane.Controls.Add(ctrl_Content_Pane)
    '                    Catch
    '                        ctrl_TD_Content_Pane.Visible = False
    '                    End Try
    '                End If
    '            Next
    '        Else
    '            ctrl_TD_Content_Pane.Visible = False
    '        End If
    '        objmodule = Nothing
    '    End Sub
    '    Public Sub ShowRightPane()
    '        Dim dt As New DataTable
    '        Dim dr As DataRow
    '        Dim iWebControlCounter As Integer

    '        Dim ctrl_TD_Right_Pane As Control ' td where we have to show the content control specified in module
    '        ctrl_TD_Right_Pane = Page.FindControl("TD_Right_Pane")

    '        Dim objmodule As New clsModules
    '        dt = objmodule.GetMainLinksModules(pi_main_link_ID, clsPlaceholder.RightPane) ' 3 constant position

    '        Dim ctrl_Right_Pane As TradeControl
    '        If dt.Rows.Count > 0 Then
    '            ctrl_TD_Right_Pane.Visible = False
    '            For iWebControlCounter = 0 To dt.Rows.Count - 1
    '                dr = dt.Rows(iWebControlCounter)
    '                If dr("Show_Flag") = 1 Then
    '                    Try
    '                        ctrl_TD_Right_Pane.Visible = True
    '                        ctrl_Right_Pane = Page.LoadControl(pi_WebPath & dr("module_url"))
    '                        ctrl_Right_Pane.Module_ID = dr("Module_ID")
    '                        ctrl_TD_Right_Pane.Controls.Add(ctrl_Right_Pane)
    '                    Catch
    '                        ctrl_TD_Right_Pane.Visible = False
    '                    End Try
    '                End If
    '            Next
    '        Else
    '            ctrl_TD_Right_Pane.Visible = False
    '        End If
    '        objmodule = Nothing
    '    End Sub
    '    Public Sub ShowFooter()
    '        Dim dt As New DataTable
    '        Dim dr As DataRow

    '        Dim ctrl_TD_Footer As Control ' td where we have to show the content control specified in module
    '        ctrl_TD_Footer = Page.FindControl("TD_Footer")

    '        Dim objmodule As New clsModules
    '        dt = objmodule.GetMainLinksModules(pi_main_link_ID, clsPlaceholder.Footer)

    '        Dim ctrl_Footer As Control
    '        If dt.Rows.Count > 0 Then
    '            dr = dt.Rows(0)
    '            If dr("Show_Flag") = 1 Then
    '                ctrl_TD_Footer.Visible = True
    '                Try
    '                    ctrl_Footer = Page.LoadControl(pi_WebPath & dr("module_url"))
    '                    ctrl_TD_Footer.Controls.Add(ctrl_Footer)
    '                Catch ex As Exception
    '                    System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
    '                    ctrl_TD_Footer.Visible = False
    '                End Try
    '            Else
    '                ctrl_TD_Footer.Visible = False
    '            End If
    '        Else
    '            ctrl_TD_Footer.Visible = False
    '        End If
    '        objmodule = Nothing
    '    End Sub
    '#End Region

End Class
