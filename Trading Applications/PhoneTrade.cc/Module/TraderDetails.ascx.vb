Public Class TraderDetails

    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DLTradeDetail As System.Web.UI.WebControls.DataList
    Protected WithEvents trContact1Name As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents trContact2Name As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents trContact1Mobile As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents trContact2Mobile As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents trContact1Email As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents trContact2Email As System.Web.UI.HtmlControls.HtmlTableRow

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
    Private pi_obj_member As Trade_BL.Member
    Private pi_str_Member_ID As String
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub FillTraderDetail(ByVal MemberID As String)
        Dim pi_dt_member As New DataTable

        pi_obj_member = New Trade_BL.Member
        pi_dt_member = pi_obj_member.GetMembers(MemberID)

        DLTradeDetail.DataSource = pi_dt_member
        DLTradeDetail.DataBind()
    End Sub

End Class
