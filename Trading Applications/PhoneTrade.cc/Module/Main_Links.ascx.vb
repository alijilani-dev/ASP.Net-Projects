Public Class main_links
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DLMainlink As System.Web.UI.WebControls.DataList

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
    Private pi_obj_main_Links As New Trade_BL.MainLinks
    Private pi_Portal_ID As Integer
    Private pi_web_Path As String
    Private pi_dt_Main_Links As New DataTable

    Private pi_Row_Position As Integer
    Private Selected_Menu_id As Integer
#End Region
#Region "Public Properties"
    Public Property Portal_ID() As Integer
        Get
            Return pi_Portal_ID
        End Get
        Set(ByVal Value As Integer)
            pi_Portal_ID = Value
        End Set
    End Property

    Public Property Row_Position() As Integer
        Get
            Return pi_Row_Position
        End Get
        Set(ByVal Value As Integer)
            pi_Row_Position = Value
        End Set
    End Property
    Public Property Selected_Menu() As Integer
        Get
            Return Selected_Menu_id
        End Get
        Set(ByVal Value As Integer)
            Selected_Menu_id = Value
        End Set
    End Property
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here


        pi_dt_Main_Links = pi_obj_main_Links.GetPortalMainLinks(Session(Session_str_Portal_ID), Row_Position)
        If Session(Session_str_UserName) <> "" Then
            If pi_dt_Main_Links.Select("link_name='Member Login'").Length > 0 Then
                'pi_dt_Main_Links.Select("link_name='Member Login'")(0).Item("Img_Url") = "<script type=""text/javascript"" language=""JavaScript1.2"" src=""myprofile.js""></script>"
                pi_dt_Main_Links.Select("link_name='Member Login'")(0).Item("Img_Url") = "images/btn_MyProfile_nrml.jpg"
                pi_dt_Main_Links.Select("link_name='Member Login'")(0).Item("Img_Url_MouseOver") = "images/btn_MyProfile_ovr.jpg"
            End If
        End If
        Dim s As String
        ''If Selected_Menu.ToString.Length > 0 Then
        ''    s = "main_links_id=" & Selected_Menu
        ''    pi_dt_Main_Links.Select(s)(0).Item("Img_Url") = pi_dt_Main_Links.Select(s)(0).Item("Img_Url_mouseover")
        ''End If
        Select Case Selected_Menu
            Case 1 'Home
                s = "main_links_id=" & Selected_Menu
                pi_dt_Main_Links.Select(s)(0).Item("Img_Url") = pi_dt_Main_Links.Select(s)(0).Item("Img_Url_mouseover") '"images/top_buttonsfreight_forwarov.jpg"

            Case 2 'Trders direc
                s = "main_links_id=" & Selected_Menu
                pi_dt_Main_Links.Select(s)(0).Item("Img_Url") = pi_dt_Main_Links.Select(s)(0).Item("Img_Url_mouseover") '"images/layout_mainimage2ov.jpg"
            Case 3 'FFDirec
                s = "main_links_id=" & Selected_Menu
                pi_dt_Main_Links.Select(s)(0).Item("Img_Url") = pi_dt_Main_Links.Select(s)(0).Item("Img_Url_mouseover") '"images/top_buttonsfreight_forwarov.jpg"
            Case 4 'T/F
                s = "main_links_id=" & Selected_Menu
                pi_dt_Main_Links.Select(s)(0).Item("Img_Url") = pi_dt_Main_Links.Select(s)(0).Item("Img_Url_mouseover") '"images/top_buttonsfreight_forwarov.jpg"
            Case 5 'Mobile rev
                s = "main_links_id=" & Selected_Menu
                pi_dt_Main_Links.Select(s)(0).Item("Img_Url") = pi_dt_Main_Links.Select(s)(0).Item("Img_Url_mouseover") ' "images/top_buttonsfreight_forwarov.jpg"
            Case 8 ''Useful links
                s = "main_links_id=" & Selected_Menu
                pi_dt_Main_Links.Select(s)(0).Item("Img_Url") = pi_dt_Main_Links.Select(s)(0).Item("Img_Url_mouseover") '"images/top_buttonsfreight_forwarov.jpg"
            Case 9 'Contactus
                s = "main_links_id=" & Selected_Menu
                pi_dt_Main_Links.Select(s)(0).Item("Img_Url") = pi_dt_Main_Links.Select(s)(0).Item("Img_Url_mouseover")
            Case 7 'Pres rel
                s = "main_links_id=" & Selected_Menu
                pi_dt_Main_Links.Select(s)(0).Item("Img_Url") = pi_dt_Main_Links.Select(s)(0).Item("Img_Url_mouseover") '"images/layout_mainimage2ov.jpg"
            Case 24 ''Members
                s = "main_links_id=" & Selected_Menu
                pi_dt_Main_Links.Select(s)(0).Item("Img_Url") = pi_dt_Main_Links.Select(s)(0).Item("Img_Url_mouseover") '"images/top_buttonsfreight_forwarov.jpg"

            Case 25 'Register
                s = "main_links_id=" & Selected_Menu
                pi_dt_Main_Links.Select(s)(0).Item("Img_Url") = pi_dt_Main_Links.Select(s)(0).Item("Img_Url_mouseover")
            Case 30 'Testimo
                s = "main_links_id=" & Selected_Menu
                pi_dt_Main_Links.Select(s)(0).Item("Img_Url") = pi_dt_Main_Links.Select(s)(0).Item("Img_Url_mouseover")

        End Select

        DLMainlink.DataSource = pi_dt_Main_Links
        'DLMainlink.DataKeyField = "Main_Links_ID"
        DLMainlink.DataBind()
        'DLMainlink.Attributes.Add("style", "this.src='images/nav_btn_on_bg.gif'")
        'Dim l_rowcounter As Integer
        '' draw the first line of menu
        'Dim dr() As DataRow
        'dr = pi_dt_Main_Links.Select("Show_Flag = 1 and Row_Position =1")

        ''Response.Flush()
        'Context.Response.Write("<TABLE>")

        'If dr.GetUpperBound(0) > 0 Then
        '    For l_rowcounter = 0 To dr.GetUpperBound(0)
        '        Context.Response.Write("<a href='PortDefault.aspx?main_links_ID=" & dr(l_rowcounter).Item("Main_Links_ID") & "'>")
        '        If "" & dr(l_rowcounter).Item("Img_url") = "" Then
        '            ' means image is not present
        '            Context.Response.Write(dr(l_rowcounter).Item("link_name"))
        '        Else
        '            'image present
        '            Context.Response.Write("<input border='0' src='" & dr(l_rowcounter).Item("Img_url") & "' name='IR" & l_rowcounter & "' type='image'>")
        '        End If
        '        Context.Response.Write("</a>")
        '    Next
        'End If
        'Context.Response.Write("</TABLE>")
    End Sub

    Private Sub DLMainlink_ItemDataBound(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataListItemEventArgs) Handles DLMainlink.ItemDataBound
        Dim hprLinks2 As HyperLink
        hprLinks2 = e.Item.FindControl("hprLinks1")
        hprLinks2.Attributes.Add("onmouseover", "this.src='" & DataBinder.Eval(e.Item.DataItem, "img_url_mouseover") & "'")
        hprLinks2.Attributes.Add("onmouseout", "this.src='" & DataBinder.Eval(e.Item.DataItem, "img_url") & "'")

        Dim str As String = DataBinder.Eval(e.Item.DataItem, "link_name").ToString
        Dim lblMenuCtrl As Label
        lblMenuCtrl = e.Item.FindControl("lblMenu")
        If str = "Member Login" And Session(Session_str_UserName) <> "" Then
            hprLinks2.Visible = False
            lblMenuCtrl.Text = "<script type='text/javascript' language='JavaScript1.2' src='myprofile.js'></script>"
            lblMenuCtrl.Visible = True
        Else
            lblMenuCtrl.Text = ""
        End If




        '<script type=""text/javascript"" language=""JavaScript1.2"" src=""myprofile.js""></script>
        '    'If e.Item.ItemType = ListItemType.Item Then
        '    '    Try
        '    '        hprLinks1 = e.Item.FindControl("hprLinks1")
        '    '        hprLinks1.Attributes.Add("onmouseover", "this.firstChild.src='" & DataBinder.Eval(e.Item.DataItem, "img_url_mouseover") & "'")
        '    '        hprLinks1.Attributes.Add("onmouseout", "this.firstChild.src='" & DataBinder.Eval(e.Item.DataItem, "img_url") & "'")
        '    '        'Hyplink.Attributes.Add("onclick", "this.firstChild.src='" & DataBinder.Eval(e.Item.DataItem, "link_img_url_click") & "'")
        '    '    Catch
        '    '    End Try
        '    'End If
        '    Try

        '        ' e.Item.Attributes.Add("onmouseover", "this.firstChild.src='" & DataBinder.Eval(e.Item.DataItem, "img_url_mouseover") & "'")
        '        ' e.Item.Attributes.Add("onmouseout", "this.firstChild.src='" & DataBinder.Eval(e.Item.DataItem, "img_url") & "'")
        '        'Hyplink2 = e.Item.FindControl("hyperlink2")
        '        'Hyplink2.Attributes.Add("onmouseover", "this.firstChild.src='" & DataBinder.Eval(e.Item.DataItem, "img_url_mouseover") & "'")
        '        'Hyplink2.Attributes.Add("onmouseout", "this.firstChild.src='" & DataBinder.Eval(e.Item.DataItem, "img_url") & "'")

        '    Catch
        '    End Try
        '    Dim hpr As HyperLink
        '    hpr = DLMainlink.SelectedItem.FindControl("hprLinks1")
        '    If Not hpr Is Nothing Then hpr.ImageUrl = "images/nav_btn_on_bg.gif" 'DataBinder.Eval(e.Item.DataItem, "img_url_mouseover")
        '    'DLMainlink.SelectedItem.CssClass = "testcss"
    End Sub

    'Private Sub DLMainlink_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DLMainlink.SelectedIndexChanged
    '    DLMainlink.SelectedItem.CssClass = "testcss"

    '    DLMainlink.Attributes.Add("style", "this.src='images/nav_btn_on_bg.gif'")
    'End Sub

   
End Class
