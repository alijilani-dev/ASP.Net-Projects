Imports Trade_BL.GlobalData

Public Class main
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

        ''Put user code to initialize the page here
        'Try
        '    Page.Controls.Add(Page.LoadControl("~/User_Controls/MainLinks.ascx"))
        'Catch ex As Exception
        '    Throw ex
        'End Try


    End Sub

#End Region

#Region "Private Variable"
    Private pi_obj_portal As New Trade_BL.Portal
    Private pi_obj_mainlinks As New Trade_BL.MainLinks
    Private pi_main_link_ID As Integer
    Private Pi_dt_link As New DataTable
    Private Pi_dr_link As DataRow
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim dr As DataRow

        Dim portal_id As Integer
        Try
            ' get the portal id from the query string 
            ' of the default.aspx
            ' if portal_id is specified then
            ' then portal is independed visited
            ' if Session object of portal_id is Zero 
            ' that means it has to be initialize to default portal
            portal_id = Request.QueryString.Item("Portal_ID")

        Catch ex As Exception
            portal_id = 0               ' *HardCoded* 
        End Try

        ' this procedure gets the portal details like Id, Name
        ' if portal_ID is present i.e. > 0 then
        ' just get the details of portal and store that 
        ' into the session variables
        ' else if portal_ID is ZERO then get the 
        ' assume the first portal is default portal
        ' and proceed further
        dt = pi_obj_portal.GetPortal(portal_id)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            ' portal related information into the session
            ' for the current session
            Session(Session_str_Portal_ID) = dr("Portal_ID")
            Session(Session_str_Portal_Name) = dr("Portal_Name")
            Session(Session_str_Portal_Url) = "http://localhost/Trade/" ' *HardCoded*'dr("Portal_Url")
            Session(Session_str_Portal_Logo) = dr("Portal_Logo")
            Session(Session_str_Portal_StyleSheet) = dr("Portal_StyleSheet")
            ' current main_link id which is visited 
            ' by the current session user 
            ' initially both [ZERO]

            Session(Session_Str_Cur_Main_Link_ID) = 0   ' *HardCoded*
            Session(Session_Str_Cur_Sub_Link_ID) = 0    ' *HardCoded*

            Try
                pi_main_link_ID = Request.QueryString.Item("Main_Link_ID")
            Catch ex As Exception
                pi_main_link_ID = 0
            End Try

            If pi_main_link_ID = 0 Then
                ' if main link is zero hence get
                ' fisrt link from the main_link tables
                ' using the portal id
                Pi_dt_link = pi_obj_mainlinks.GetPortalMainLinks(Session("Portal_ID"), 0)
                Pi_dr_link = Pi_dt_link.Rows(0)
                pi_main_link_ID = Pi_dr_link("Main_Links_ID")
            End If

            'after you have main_link_Id with you
            ' get the details of that link
            Pi_dt_link = New DataTable
            Pi_dt_link = pi_obj_mainlinks.GetMainLinks(pi_main_link_ID)

            Pi_dr_link = Pi_dt_link.Rows(0)
            pi_main_link_ID = Pi_dr_link("Main_Links_ID")

            Session(Session_Str_Cur_Main_Link_ID) = pi_main_link_ID
            Session(Session_Str_Cur_Sub_Link_ID) = 0

            'Response.Redirect(Pi_dr_link("Link_URL") & "?Main_Links_ID=" & pi_main_link_ID)
            'Response.Redirect("PortalDefault.aspx?Main_Links_ID=" & pi_main_link_ID)
            Response.Redirect("PortalDefault.aspx?Main_Links_ID=1")
        End If
        'Response.Redirect("PortalDefault.aspx?Main_Link_ID=0")

        'End If
        'IIf(Session(Session_str_Portal_ID) = Nothing, 1, Session(Session_str_Portal_ID))
        Session(Session_str_Portal_ID) = 1 'dr("Portal_ID")
    End Sub

End Class
