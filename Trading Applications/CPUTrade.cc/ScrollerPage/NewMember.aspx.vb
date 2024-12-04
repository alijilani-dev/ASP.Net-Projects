Public Class NewMember
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents RNewMember As System.Web.UI.WebControls.Repeater

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub
#End Region

#Region "private variables"
    Private pi_Obj_Member As Trade_BL.Member
#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        Dim dt_MemberSearch As New DataTable
        pi_Obj_Member = New Trade_BL.Member
        dt_MemberSearch = pi_Obj_Member.GetNewMembers(Session(Session_str_Portal_ID))
        RNewMember.DataSource = dt_MemberSearch
        RNewMember.DataBind()
    End Sub

    Private Sub RNewMember_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.RepeaterCommandEventArgs)

    End Sub
End Class