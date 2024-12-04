Public MustInherit Class Logout1
  Inherits TradeControl
  Protected WithEvents Hlnkclicklogin As System.Web.UI.WebControls.HyperLink
  Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Private pi_obj_members As New Trade_BL.Member
#Region " Web Form Designer Generated Code "

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

  End Sub

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()
  End Sub

#End Region

  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

        pi_obj_members.UpdateOnlineStatus(Session(Session_str_UserName))
    Session(Session_str_UserName) = ""
    Hlnkclicklogin.NavigateUrl = "..\Default.aspx?Portal_ID=" & Session(Session_str_Portal_ID)
        Response.Redirect("PortalDefault.aspx?Main_Links_ID=4") ' & MyBase.Main_Links_ID & "&Sub_Links_ID=0"
  End Sub

End Class
