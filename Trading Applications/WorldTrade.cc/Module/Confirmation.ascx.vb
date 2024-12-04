Public Class Confirmation
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents TDMessage As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblTodo As System.Web.UI.WebControls.Label
    Protected WithEvents Hlnk As System.Web.UI.WebControls.HyperLink

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
    Private pi_str_Message As String
    Private pi_str_Todo As String
    Private pi_str_link As String
#End Region

#Region "public properties"
    Public Property Message() As String
        Get
            Return pi_str_Message
        End Get
        Set(ByVal Value As String)
            pi_str_Message = Value
        End Set
    End Property
    Public Property Todo() As String
        Get
            Return pi_str_Todo
        End Get
        Set(ByVal Value As String)
            pi_str_Todo = Value
        End Set
    End Property

    Public Property link() As String
        Get
            Return pi_str_link
        End Get
        Set(ByVal Value As String)
            pi_str_link = Value
        End Set
    End Property
#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Public Sub ShowConfirmationMessage()
        Me.Visible = True
        Me.lblMessage.Text = pi_str_Message
        Me.lblTodo.Text = pi_str_Todo
        Me.Hlnk.Text = "Click Here"
        If link <> "" Then
            Me.Hlnk.NavigateUrl = link
        Else
            Me.Hlnk.NavigateUrl = "..\PortalDefault.aspx?Main_Links_ID=" & MyBase.Main_Links_ID & "&Sub_Links_ID=" & MyBase.Sub_Links_ID
        End If

    End Sub
End Class

