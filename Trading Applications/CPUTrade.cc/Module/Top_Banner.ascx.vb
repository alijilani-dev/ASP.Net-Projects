Public Class Top_Banner
    Inherits TradeControl


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub
    Protected WithEvents DLContent As System.Web.UI.WebControls.DataList

#End Region

#Region "Private Variables"
    'Private pi_Module_ID As Integer
    Private pi_obj_Content As New Trade_BL.Content
#End Region

#Region "Public Properties"

#End Region


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        DLContent.DataSource = pi_obj_Content.GetModuleContent(MyBase.Module_ID, Session(Session_str_Portal_ID))
        DLContent.DataBind()
    End Sub

End Class
