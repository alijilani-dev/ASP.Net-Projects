Public Class TradeMain
    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Top_AD_Banner As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_Site_Links As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_Content_Ad_Banner As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_Main_Links As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_World_Time As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_Logo As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_Top_AD_Banner As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_Footer As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_Content_Left_Pane As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_Content_Main_Pane As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_Content_Right_Pane As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_Content_Top_Header1 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD_Content_Top_Header As System.Web.UI.HtmlControls.HtmlTableCell

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
    Private pi_obj_mainlinks As New Trade_BL.MainLinks
    Private Pi_dt_link As New DataTable
    Private Pi_dr_link As DataRow
    Private pi_main_link_ID As Integer
    Private pi_Sub_link_ID As Integer

    Private pi_Redirect_Main_link_ID As Integer

    Private pi_WebPath As String
#End Region

    Public Property Main_Links_ID() As Integer
        Get
            Return pi_main_link_ID
        End Get
        Set(ByVal Value As Integer)
            pi_main_link_ID = Value
        End Set
    End Property

    Public Property Sub_Links_ID() As Integer
        Get
            Return pi_Sub_link_ID
        End Get
        Set(ByVal Value As Integer)
            pi_Sub_link_ID = Value
        End Set
    End Property

    Public Property Redirect_Main_link_ID() As Integer
        Get
            Return pi_Redirect_Main_link_ID
        End Get
        Set(ByVal Value As Integer)
            pi_Redirect_Main_link_ID = Value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        'Show_Site_Links()
        Show_Logo()
        Show_Top_AD_Banner()
        Show_World_Time()
        Show_Main_Links()
        Show_Content_Top_Header()
        Show_Content_Ad_Banner()
        Show_Content_Left_Pane()
        Show_Content_Main_Pane()
        Show_Content_Right_Pane()
        Show_Footer()
    End Sub

#Region "Public methods"
    Public Sub Show_Site_Links()
        Dim dt As New DataTable
        Dim dr As DataRow

        Dim ctrl_TD_Site_Links As Control ' td where we have to show the content control specified in module
        ctrl_TD_Site_Links = Me.FindControl("TD_Site_Links")

        Dim objmodule As New Trade_BL.Modules
        dt = objmodule.GetMainLinksModules(pi_main_link_ID, pi_Sub_link_ID, Trade_BL.Placeholder.Site_Links)

        Dim ctrl_Site_Links As TradeControl
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            If dr("Show_Flag") = 1 Then
                ctrl_TD_Site_Links.Visible = True
                Try
                    ctrl_Site_Links = Me.LoadControl(pi_WebPath & dr("module_url"))
                    ' initiliazing base class members
                    ctrl_Site_Links.Module_ID = Convert.ToInt32("0" & dr("module_id"))
                    ctrl_Site_Links.Main_Links_ID = Convert.ToInt32("0" & Main_Links_ID)
                    ctrl_Site_Links.Sub_Links_ID = Convert.ToInt32("0" & Sub_Links_ID)

                    ctrl_Site_Links.Redirect_Main_Links_ID = Convert.ToInt32("0" & Redirect_Main_link_ID)

                    ctrl_Site_Links.Placeholder = Trade_BL.Placeholder.Site_Links
                    ' initiliazing base class members
                Catch ex As Exception
                    System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
                End Try

                ctrl_TD_Site_Links.Controls.Add(ctrl_Site_Links)
            Else
                ctrl_TD_Site_Links.Visible = False
            End If
        Else
            ctrl_TD_Site_Links.Visible = False
        End If
        objmodule = Nothing
    End Sub

    Public Sub Show_Logo()
        Dim dt As New DataTable
        Dim dr As DataRow

        Dim ctrl_TD_Logo As Control ' td where we have to show the content control specified in module
        ctrl_TD_Logo = Me.FindControl("TD_Logo")

        Dim objmodule As New Trade_BL.Modules
        dt = objmodule.GetMainLinksModules(pi_main_link_ID, pi_Sub_link_ID, Trade_BL.Placeholder.Logo)

        Dim ctrl_Logo As TradeControl
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            If dr("Show_Flag") = 1 Then
                ctrl_TD_Logo.Visible = True
                Try
                    ctrl_Logo = Me.LoadControl(pi_WebPath & dr("module_url"))
                    ' initiliazing base class members
                    ctrl_Logo.Module_ID = Convert.ToInt32("0" & dr("module_id"))
                    ctrl_Logo.Main_Links_ID = Convert.ToInt32("0" & Main_Links_ID)
                    ctrl_Logo.Sub_Links_ID = Convert.ToInt32("0" & Sub_Links_ID)
                    ctrl_Logo.Redirect_Main_Links_ID = Convert.ToInt32("0" & Redirect_Main_link_ID)
                    ctrl_Logo.Placeholder = Trade_BL.Placeholder.Logo
                    ' initiliazing base class members
                Catch ex As Exception
                    System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
                End Try

                ctrl_TD_Logo.Controls.Add(ctrl_Logo)
            Else
                ctrl_TD_Logo.Visible = False
            End If
        Else
            ctrl_TD_Logo.Visible = False
        End If
        objmodule = Nothing
    End Sub

    Public Sub Show_Top_AD_Banner()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim iWebControlCounter As Integer

        Dim ctrl_TD_Top_AD_Banner As Control ' td where we have to show the content control specified in module
        ctrl_TD_Top_AD_Banner = Me.FindControl("TD_Top_AD_Banner")

        Dim objmodule As New Trade_BL.Modules
        dt = objmodule.GetMainLinksModules(pi_main_link_ID, pi_Sub_link_ID, Trade_BL.Placeholder.Top_AD_Banner)

        Dim ctrl_Top_AD_Banner As TradeControl
        If dt.Rows.Count > 0 Then
            ctrl_TD_Top_AD_Banner.Visible = False
            For iWebControlCounter = 0 To dt.Rows.Count - 1
                dr = dt.Rows(iWebControlCounter)
                If dr("Show_Flag") = 1 Then
                    ctrl_TD_Top_AD_Banner.Visible = True
                    Try
                        ctrl_Top_AD_Banner = Me.LoadControl(pi_WebPath & dr("module_url"))
                        ' initiliazing base class members
                        ctrl_Top_AD_Banner.Module_ID = Convert.ToInt32("0" & dr("module_id"))
                        ctrl_Top_AD_Banner.Main_Links_ID = Convert.ToInt32("0" & Main_Links_ID)
                        ctrl_Top_AD_Banner.Sub_Links_ID = Convert.ToInt32("0" & Sub_Links_ID)

                        ctrl_Top_AD_Banner.Redirect_Main_Links_ID = Convert.ToInt32("0" & Redirect_Main_link_ID)


                        ctrl_Top_AD_Banner.Placeholder = Trade_BL.Placeholder.Top_AD_Banner
                        ' initiliazing base class members

                    Catch ex As Exception
                        System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
                    End Try

                    ctrl_TD_Top_AD_Banner.Controls.Add(ctrl_Top_AD_Banner)
                Else
                    ctrl_TD_Top_AD_Banner.Visible = False
                End If
            Next
        Else
            ctrl_TD_Top_AD_Banner.Visible = False
        End If
        objmodule = Nothing
    End Sub

    Public Sub Show_World_Time()
        Dim dt As New DataTable
        Dim dr As DataRow

        Dim ctrl_TD_World_Time As Control ' td where we have to show the content control specified in module
        ctrl_TD_World_Time = Me.FindControl("TD_World_Time")

        Dim objmodule As New Trade_BL.Modules
        dt = objmodule.GetMainLinksModules(pi_main_link_ID, pi_Sub_link_ID, Trade_BL.Placeholder.World_Time)

        Dim ctrl_World_Time As TradeControl
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            If dr("Show_Flag") = 1 Then
                ctrl_TD_World_Time.Visible = True
                Try
                    ctrl_World_Time = Me.LoadControl(pi_WebPath & dr("module_url"))
                    ' initiliazing base class members
                    ctrl_World_Time.Module_ID = Convert.ToInt32("0" & dr("module_id"))
                    ctrl_World_Time.Main_Links_ID = Convert.ToInt32("0" & Main_Links_ID)
                    ctrl_World_Time.Sub_Links_ID = Convert.ToInt32("0" & Sub_Links_ID)

                    ctrl_World_Time.Redirect_Main_Links_ID = Convert.ToInt32("0" & Redirect_Main_link_ID)

                    ctrl_World_Time.Placeholder = Trade_BL.Placeholder.World_Time
                    ' initiliazing base class members

                Catch ex As Exception
                    System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
                End Try

                ctrl_TD_World_Time.Controls.Add(ctrl_World_Time)
            Else
                ctrl_TD_World_Time.Visible = False
            End If
        Else
            ctrl_TD_World_Time.Visible = False
        End If
        objmodule = Nothing
    End Sub

    Public Sub Show_Main_Links()
        Dim iWebControlCounter As Integer
        Dim dt As New DataTable
        Dim dr As DataRow

        Dim ctrl_TD_Main_Links As Control ' td where we have to show the content control specified in module
        ctrl_TD_Main_Links = Me.FindControl("TD_Main_Links")

        Dim objmodule As New Trade_BL.Modules
        dt = objmodule.GetMainLinksModules(pi_main_link_ID, pi_Sub_link_ID, Trade_BL.Placeholder.Main_Links)  ' 3 constant position

        Dim ctrl_Main_Links As TradeControl
        If dt.Rows.Count > 0 Then
            ctrl_TD_Main_Links.Visible = False
            For iWebControlCounter = 0 To dt.Rows.Count - 1
                dr = dt.Rows(iWebControlCounter)
                If dr("Show_Flag") = 1 Then
                    Try
                        ctrl_TD_Main_Links.Visible = True
                        ctrl_Main_Links = Me.LoadControl(pi_WebPath & dr("module_url"))
                        ' initiliazing base class members
                        ctrl_Main_Links.Module_ID = Convert.ToInt32("0" & dr("module_id"))
                        ctrl_Main_Links.Main_Links_ID = Convert.ToInt32("0" & Main_Links_ID)
                        ctrl_Main_Links.Sub_Links_ID = Convert.ToInt32("0" & Sub_Links_ID)

                        ctrl_Main_Links.Redirect_Main_Links_ID = Convert.ToInt32("0" & Redirect_Main_link_ID)


                        ctrl_Main_Links.Placeholder = Trade_BL.Placeholder.Main_Links
                        ' initiliazing base class members
                        ctrl_TD_Main_Links.Controls.Add(ctrl_Main_Links)
                    Catch
                        ctrl_TD_Main_Links.Visible = False
                    End Try
                Else
                    ctrl_TD_Main_Links.Visible = False
                End If
            Next
        Else
            ctrl_TD_Main_Links.Visible = False
        End If
        objmodule = Nothing
    End Sub

    Public Sub Show_Content_Top_Header()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim iWebControlCounter As Integer

        Dim ctrl_TD_Content_Top_Header As Control ' td where we have to show the content control specified in module
        ctrl_TD_Content_Top_Header = Me.FindControl("TD_Content_Top_Header")

        Dim objmodule As New Trade_BL.Modules
        dt = objmodule.GetMainLinksModules(pi_main_link_ID, pi_Sub_link_ID, Trade_BL.Placeholder.Content_Top_Header)   ' 3 constant position

        Dim ctrl_Content_Top_Header As TradeControl
        If dt.Rows.Count > 0 Then
            ctrl_TD_Content_Top_Header.Visible = False
            For iWebControlCounter = 0 To dt.Rows.Count - 1
                dr = dt.Rows(iWebControlCounter)
                If dr("Show_Flag") = 1 Then
                    Try
                        ctrl_TD_Content_Top_Header.Visible = True
                        ctrl_Content_Top_Header = Me.LoadControl(pi_WebPath & dr("module_url"))
                        ' initiliazing base class members
                        ctrl_Content_Top_Header.Module_ID = dr("Module_ID")
                        ctrl_Content_Top_Header.Main_Links_ID = Convert.ToInt32("0" & Main_Links_ID)
                        ctrl_Content_Top_Header.Sub_Links_ID = Convert.ToInt32("0" & Sub_Links_ID)

                        ctrl_Content_Top_Header.Redirect_Main_Links_ID = Convert.ToInt32("0" & Redirect_Main_link_ID)

                        ctrl_Content_Top_Header.Placeholder = Trade_BL.Placeholder.Content_Top_Header
                        ' initiliazing base class members
                        ctrl_TD_Content_Top_Header.Controls.Add(ctrl_Content_Top_Header)
                    Catch
                        ctrl_TD_Content_Top_Header.Visible = False
                    End Try
                Else
                    ctrl_TD_Content_Top_Header.Visible = False
                End If
            Next
        Else
            ctrl_TD_Content_Top_Header.Visible = False
        End If
        objmodule = Nothing
    End Sub

    Public Sub Show_Content_Ad_Banner()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim iWebControlCounter As Integer

        Dim ctrl_TD_Content_Ad_Banner As Control ' td where we have to show the content control specified in module
        ctrl_TD_Content_Ad_Banner = Me.FindControl("TD_Content_Ad_Banner")

        Dim objmodule As New Trade_BL.Modules
        dt = objmodule.GetMainLinksModules(pi_main_link_ID, pi_Sub_link_ID, Trade_BL.Placeholder.Content_Ad_Banner)   ' 3 constant position

        Dim ctrl_Content_Ad_Banner As TradeControl
        If dt.Rows.Count > 0 Then
            ctrl_TD_Content_Ad_Banner.Visible = False
            For iWebControlCounter = 0 To dt.Rows.Count - 1
                dr = dt.Rows(iWebControlCounter)
                If dr("Show_Flag") = 1 Then
                    Try
                        ctrl_TD_Content_Ad_Banner.Visible = True
                        ctrl_Content_Ad_Banner = Me.LoadControl(pi_WebPath & dr("module_url"))
                        ' initiliazing base class members
                        ctrl_Content_Ad_Banner.Module_ID = dr("Module_ID")
                        ctrl_Content_Ad_Banner.Main_Links_ID = Convert.ToInt32("0" & Main_Links_ID)
                        ctrl_Content_Ad_Banner.Sub_Links_ID = Convert.ToInt32("0" & Sub_Links_ID)

                        ctrl_Content_Ad_Banner.Redirect_Main_Links_ID = Convert.ToInt32("0" & Redirect_Main_link_ID)

                        ctrl_Content_Ad_Banner.Placeholder = Trade_BL.Placeholder.Content_Ad_Banner
                        ' initiliazing base class members
                        ctrl_TD_Content_Ad_Banner.Controls.Add(ctrl_Content_Ad_Banner)
                    Catch
                        ctrl_TD_Content_Ad_Banner.Visible = False
                    End Try
                End If
            Next
        Else
            ctrl_TD_Content_Ad_Banner.Visible = False
        End If
        objmodule = Nothing
    End Sub

    Public Sub Show_Content_Left_Pane()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim iWebControlCounter As Integer

        Dim ctrl_TD_Content_Left_Pane As Control ' td where we have to show the content control specified in module
        ctrl_TD_Content_Left_Pane = Me.FindControl("TD_Content_Left_Pane")

        Dim objmodule As New Trade_BL.Modules
        dt = objmodule.GetMainLinksModules(pi_main_link_ID, pi_Sub_link_ID, Trade_BL.Placeholder.Content_Left_Pane)   ' 3 constant position

        Dim ctrl_Content_Left_Pane As TradeControl
        If dt.Rows.Count > 0 Then
            ctrl_TD_Content_Left_Pane.Visible = False
            For iWebControlCounter = 0 To dt.Rows.Count - 1
                dr = dt.Rows(iWebControlCounter)
                If dr("Show_Flag") = 1 Then
                    Try
                        ctrl_TD_Content_Left_Pane.Visible = True
                        ctrl_Content_Left_Pane = Me.LoadControl(pi_WebPath & dr("module_url"))
                        ' initiliazing base class members
                        ctrl_Content_Left_Pane.Module_ID = dr("Module_ID")
                        ctrl_Content_Left_Pane.Main_Links_ID = Convert.ToInt32("0" & Main_Links_ID)
                        ctrl_Content_Left_Pane.Sub_Links_ID = Convert.ToInt32("0" & Sub_Links_ID)

                        ctrl_Content_Left_Pane.Redirect_Main_Links_ID = Convert.ToInt32("0" & Redirect_Main_link_ID)


                        ctrl_Content_Left_Pane.Placeholder = Trade_BL.Placeholder.Content_Left_Pane
                        ' initiliazing base class members
                        ctrl_TD_Content_Left_Pane.Controls.Add(ctrl_Content_Left_Pane)
                    Catch
                        ctrl_TD_Content_Left_Pane.Visible = False
                    End Try
                End If
            Next
        Else
            ctrl_TD_Content_Left_Pane.Visible = False
        End If
        objmodule = Nothing
    End Sub

    Public Sub Show_Content_Main_Pane()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim iWebControlCounter As Integer

        Dim ctrl_TD_Content_Main_Pane As Control ' td where we have to show the Content_Main_Pane control specified in module
        ctrl_TD_Content_Main_Pane = Me.FindControl("TD_Content_Main_Pane")

        Dim objmodule As New Trade_BL.Modules

        Dim objSubLinks As New Trade_BL.Sublinks

        dt = objmodule.GetMainLinksModules(pi_main_link_ID, pi_Sub_link_ID, Trade_BL.Placeholder.Content_Main_Pane)   ' 3 constant position
        ' if pi_Sub_link_ID > 0 then
        ' you have to load the ascx from the sub link table
        If pi_Sub_link_ID > 0 Then
            dt = objSubLinks.GetSublinks(pi_Sub_link_ID)
        End If

        Dim ctrl_Content_Main_Pane As TradeControl
        If dt.Rows.Count > 0 Then
            ctrl_TD_Content_Main_Pane.Visible = False
            For iWebControlCounter = 0 To dt.Rows.Count - 1
                dr = dt.Rows(iWebControlCounter)
                If dr("Show_Flag") = 1 Then
                    Try
                        ctrl_TD_Content_Main_Pane.Visible = True

                        If pi_Sub_link_ID > 0 Then
                            ctrl_Content_Main_Pane = Me.LoadControl(pi_WebPath & dr("sub_link_url"))
                            ' initiliazing base class members
                            ctrl_Content_Main_Pane.Module_ID = 0
                        Else
                            ctrl_Content_Main_Pane = Me.LoadControl(pi_WebPath & dr("module_url"))
                            ' initiliazing base class members
                            ctrl_Content_Main_Pane.Module_ID = dr("Module_ID")
                        End If

                        ctrl_Content_Main_Pane.Main_Links_ID = Convert.ToInt32("0" & Main_Links_ID)
                        ctrl_Content_Main_Pane.Sub_Links_ID = Convert.ToInt32("0" & Sub_Links_ID)

                        ctrl_Content_Main_Pane.Redirect_Main_Links_ID = Convert.ToInt32("0" & Redirect_Main_link_ID)

                        ctrl_Content_Main_Pane.Placeholder = Trade_BL.Placeholder.Content_Main_Pane
                        ' initiliazing base class members
                        ctrl_TD_Content_Main_Pane.Controls.Add(ctrl_Content_Main_Pane)
                    Catch ex As Exception
                        Throw ex
                        ctrl_TD_Content_Main_Pane.Visible = False
                    End Try
                End If
            Next
        Else
            ctrl_TD_Content_Main_Pane.Visible = False
        End If
        objmodule = Nothing
    End Sub

    Public Sub Show_Content_Right_Pane()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim iWebControlCounter As Integer

        Dim ctrl_TD_Content_Right_Pane As Control ' td where we have to show the content control specified in module
        ctrl_TD_Content_Right_Pane = Me.FindControl("TD_Content_Right_Pane")

        Dim objmodule As New Trade_BL.Modules
        dt = objmodule.GetMainLinksModules(pi_main_link_ID, pi_Sub_link_ID, Trade_BL.Placeholder.Content_Right_Pane)   ' 3 constant position

        Dim ctrl_Content_Right_Pane As TradeControl
        If dt.Rows.Count > 0 Then
            ctrl_TD_Content_Right_Pane.Visible = False
            For iWebControlCounter = 0 To dt.Rows.Count - 1
                dr = dt.Rows(iWebControlCounter)
                If dr("Show_Flag") = 1 Then
                    Try
                        ctrl_TD_Content_Right_Pane.Visible = True
                        ctrl_Content_Right_Pane = Me.LoadControl(pi_WebPath & dr("module_url"))
                        ' initiliazing base class members
                        ctrl_Content_Right_Pane.Module_ID = dr("Module_ID")
                        ctrl_Content_Right_Pane.Main_Links_ID = Convert.ToInt32("0" & Main_Links_ID)
                        ctrl_Content_Right_Pane.Sub_Links_ID = Convert.ToInt32("0" & Sub_Links_ID)

                        ctrl_Content_Right_Pane.Redirect_Main_Links_ID = Convert.ToInt32("0" & Redirect_Main_link_ID)

                        ctrl_Content_Right_Pane.Placeholder = Trade_BL.Placeholder.Content_Right_Pane
                        ' initiliazing base class members
                        ctrl_TD_Content_Right_Pane.Controls.Add(ctrl_Content_Right_Pane)
                    Catch
                        ctrl_TD_Content_Right_Pane.Visible = False
                    End Try
                End If
            Next
        Else
            ctrl_TD_Content_Right_Pane.Visible = False
        End If
        objmodule = Nothing
    End Sub

    Public Sub Show_Footer()
        Dim dt As New DataTable
        Dim dr As DataRow

        Dim ctrl_TD_Footer As Control ' td where we have to show the content control specified in module
        ctrl_TD_Footer = Me.FindControl("TD_Footer")

        Dim objmodule As New Trade_BL.Modules
        dt = objmodule.GetMainLinksModules(pi_main_link_ID, pi_Sub_link_ID, Trade_BL.Placeholder.Footer)

        Dim ctrl_Footer As TradeControl
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            If dr("Show_Flag") = 1 Then
                ctrl_TD_Footer.Visible = True
                Try
                    ctrl_Footer = Me.LoadControl(pi_WebPath & dr("module_url"))

                    ' initiliazing base class members
                    ctrl_Footer.Module_ID = Convert.ToInt32("0" & dr("module_id"))
                    ctrl_Footer.Main_Links_ID = Convert.ToInt32("0" & Main_Links_ID)
                    ctrl_Footer.Sub_Links_ID = Convert.ToInt32("0" & Sub_Links_ID)

                    ctrl_Footer.Redirect_Main_Links_ID = Convert.ToInt32("0" & Redirect_Main_link_ID)

                    ctrl_Footer.Placeholder = Trade_BL.Placeholder.Footer
                    ' initiliazing base class members
                    ctrl_TD_Footer.Controls.Add(ctrl_Footer)
                Catch ex As Exception
                    System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
                    ctrl_TD_Footer.Visible = False
                End Try
            Else
                ctrl_TD_Footer.Visible = False
            End If
        Else
            ctrl_TD_Footer.Visible = False
        End If
        objmodule = Nothing
    End Sub

#End Region

End Class
