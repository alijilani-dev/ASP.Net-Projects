Public Class Home1
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents ImgHome As System.Web.UI.WebControls.Image
    Protected WithEvents TD_Home_Text As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents tblMembMenu As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tblLogin As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents lblPhones As System.Web.UI.WebControls.Label
    Protected WithEvents lblNews As System.Web.UI.WebControls.Label
    Protected WithEvents lblOffers As System.Web.UI.WebControls.Label
    Protected WithEvents DLSublinks As System.Web.UI.WebControls.DataList
    Protected WithEvents ddlBrand As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlModel As System.Web.UI.WebControls.DropDownList
    Protected WithEvents chkSell As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chkbuy As System.Web.UI.WebControls.CheckBox
    Protected WithEvents imgSearch As System.Web.UI.WebControls.ImageButton
    Protected WithEvents imgLogin As System.Web.UI.WebControls.ImageButton
    Protected WithEvents tbPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbUserName As System.Web.UI.WebControls.TextBox

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
    Private pi_Obj_portal As New Trade_BL.Portal
    Private pi_obj_member As New Trade_BL.Member
    Private pi_obj_sub_Links As New Trade_BL.Sublinks
    Private pi_web_Path As String
    Private pi_obj_MobileModel As New Trade_BL.MobileModel
    Private pi_obj_Brand As New Trade_BL.Manufacturer
#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        Dim dt_Portal As New DataTable
        dt_Portal = pi_Obj_portal.GetPortal(Session(Session_str_Portal_ID))

        'If dt_Portal.Rows.Count > 0 Then
        '   ImgHome.ImageUrl = dt_Portal.Rows(0).Item("Portal_Home_Img_Url")
        'TD_Home_Text.InnerHtml = dt_Portal.Rows(0).Item("Portal_Home_Text")
        'End If

        tblLogin.Visible = True
        tblMembMenu.Visible = True
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Dim dt_SubLinks As New DataTable
        DLSublinks.Attributes.Add("onmouseover", "this.firstChild.bgcolor='blue'")
        dt_SubLinks = pi_obj_sub_Links.GetPortalSublinks(Session("Portal_ID"), 6)
        dt_SubLinks.DefaultView.RowFilter = "Show_Flag=1"
        DLSublinks.DataSource = dt_SubLinks.DefaultView
        'DLSublinks.DataKeyField = "Main_Links_ID"
        DLSublinks.DataBind()

        '''Placed for Login process to bring the MEMBER MENU
        If CType(Session(Session_str_UserName), String) <> "" Then
            tblMembMenu.Visible = True
            DLSublinks.Visible = True
            tblLogin.Visible = False
        Else
            DLSublinks.Visible = False
            tblMembMenu.Visible = False
        End If
        pi_web_Path = "~/"


        '''To fill the brands and model
        If Page.IsPostBack = False Then
            FillBrand()
        End If
        FillModels()
        '''The blw two line code inserted by Basheer.. on 24th Jan to have the Acceptance tool tip on LOGIN button
        imgLogin.Attributes.Add("onMouseover", "ddrivetip('By logging into PHONETRADE you accept the Terms and Conditions of the site!','#DFDFFF', 300)")
        imgLogin.Attributes.Add("onMouseout", "hideddrivetip()")
    End Sub
    Private Sub FillBrand()
        ddlBrand.Items.Clear()
        Dim dt_Brand As New DataTable
        pi_obj_Brand = New Trade_BL.Manufacturer

        dt_Brand = pi_obj_Brand.GetManufacturer()
        ddlBrand.DataSource = dt_Brand
        ddlBrand.DataTextField = "ManufName"
        ddlBrand.DataValueField = "ManufCode"
        ddlBrand.DataBind()

        Dim li As ListItem
        li = New ListItem
        li.Text = "All"
        li.Value = "0"
        ddlBrand.Items.Add(li)

        FillModels()
    End Sub
    Private Sub FillModels()
        Dim li As ListItem
        Dim dt_MobileModel As New DataTable
        pi_obj_MobileModel = New Trade_BL.MobileModel
        dt_MobileModel = pi_obj_MobileModel.GetBrandMobileModel(ddlBrand.SelectedItem.Value)

        ddlModel.DataSource = dt_MobileModel
        ddlModel.DataTextField = "ModelNo"
        ddlModel.DataValueField = "SrNo"
        ddlModel.DataBind()

        li = New ListItem
        li.Text = "All"
        li.Value = "0"
        ddlModel.Items.Add(li)

        ddlModel.SelectedIndex = ddlModel.Items.Count - 1
    End Sub
    Private Sub ddlBrand_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlBrand.SelectedIndexChanged
        FillModels()
    End Sub
    Private Sub imgLogin_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgLogin.Click
        Dim iPortalID As Integer
        iPortalID = Session(Session_str_Portal_ID)

        If pi_obj_member.IsValidMember(iPortalID, tbUserName.Text.Trim, tbPassword.Text.Trim) Then
            Session(Session_str_Admin) = False
            Session(Session_str_UserName) = tbUserName.Text.Trim
            If MyBase.Redirect_Main_Links_ID > 0 Then
                Response.Redirect("PortalDefault.aspx?Main_Links_ID=" & MyBase.Redirect_Main_Links_ID)
                'Response.Redirect("PortalDefault.aspx?Main_Links_ID=10")
            Else
                Response.Redirect("PortalDefault.aspx?Main_Links_ID=24")
                'Response.Redirect("PortalDefault.aspx?Main_Links_ID=" & MyBase.Main_Links_ID)
            End If
        Else
            tbUserName.Text = ""
            tbPassword.Text = ""
            Response.Redirect("PortalDefault.aspx?Main_Links_ID=24&Login=failed")
        End If
    End Sub
    Private Sub imgSearch_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgSearch.Click
        Response.Redirect("PortalDefault.aspx?Main_Links_ID=4&Buy=" & IIf(chkbuy.Checked, "True", "False") & "&Sell=" & IIf(chkSell.Checked, "True", "False") & "&ManufCode=" & ddlBrand.SelectedItem.Value & "&Model=" & ddlModel.SelectedItem.Text.Trim())
    End Sub
End Class
