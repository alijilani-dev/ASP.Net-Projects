Public Class TradingFloor
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList
    Protected WithEvents DLTradeFloor As System.Web.UI.WebControls.DataList
    Protected WithEvents DLTradeDetail As System.Web.UI.WebControls.DataList
    Protected WithEvents lnkbtnNewPost As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lnkbtnCancel As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lnkbtnAdd As System.Web.UI.WebControls.LinkButton
    Protected WithEvents RFVHeading As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RFVDesc As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtHeading As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDesc As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbl_Heading As System.Web.UI.HtmlControls.HtmlTable

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
    Private pi_obj_TradingFloor As New Trade_BL.TradingFloor
    Private pi_Portal_ID As Integer

    Private pi_dt_TradingFloor As New DataTable

    Private pi_obj_member As New Trade_BL.Member
    Private pi_dt_member As New DataTable
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

        tbl_Heading.Visible = False
        DLTradeFloor.Visible = True
        DLTradeDetail.Visible = False

        If MyBase.Sub_Links_ID > 0 And Session(Session_str_UserName) <> "" Then
            lnkbtnNewPost.Visible = True
        Else
            lnkbtnNewPost.Visible = False
        End If
        If Page.IsPostBack = False Then
            If MyBase.Sub_Links_ID > 0 Then
                pi_dt_TradingFloor = pi_obj_TradingFloor.GetMemberTradingFloor(Session(Session_str_Portal_ID), Session(Session_str_UserName))
            Else
                pi_dt_TradingFloor = pi_obj_TradingFloor.GetModuleTradingFloor(Session(Session_str_Portal_ID))
            End If

            ViewState("pi_dt_TradingFloor") = pi_dt_TradingFloor

            If pi_dt_TradingFloor.Rows.Count <= 0 Then
                DLTradeFloor.Visible = False
            End If

            DLTradeFloor.DataSource = pi_dt_TradingFloor
            DLTradeFloor.DataBind()
        End If

    End Sub

    Private Sub DLTradeFloor_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DLTradeFloor.ItemCommand
        Dim dt As DataTable
        dt = CType(ViewState("pi_dt_TradingFloor"), DataTable)
        DLTradeFloor.Visible = False
        tbl_Heading.Visible = False
        DLTradeDetail.Visible = True
        pi_dt_member = pi_obj_member.GetMembers(dt.Rows(e.Item.ItemIndex).Item("member_id"))

        DLTradeDetail.DataSource = pi_dt_member
        DLTradeDetail.DataBind()

    End Sub

    Private Sub lnkbtnNewPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkbtnNewPost.Click
        tbl_Heading.Visible = True
        DLTradeFloor.Visible = False
        DLTradeDetail.Visible = False
    End Sub

    Private Sub lnkbtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkbtnAdd.Click
        Dim pi_obj_tradeFloor As Trade_BL.TradingFloor

        pi_obj_tradeFloor = New Trade_BL.TradingFloor
        pi_obj_tradeFloor.post_id = 0
        pi_obj_tradeFloor.trading_cat_id = 1
        pi_obj_tradeFloor.post_heading = txtHeading.Text
        pi_obj_tradeFloor.post_desc = txtDesc.Text
        pi_obj_tradeFloor.module_id = 16
        pi_obj_tradeFloor.timestamp = DateTime.Today

        pi_obj_tradeFloor.Member_ID = Session(Session_str_UserName)

        If pi_obj_tradeFloor.Insert() Then
            Response.Redirect("PortalDefault.aspx?Main_Links_ID=" & MyBase.Main_Links_ID & "&Sub_Links_ID=" & MyBase.Sub_Links_ID)
        End If

    End Sub

    Private Sub lnkbtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkbtnCancel.Click
        Response.Redirect("PortalDefault.aspx?Main_Links_ID=" & MyBase.Main_Links_ID & "&Sub_Links_ID=" & MyBase.Sub_Links_ID)
    End Sub
End Class
