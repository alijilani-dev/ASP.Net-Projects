Public Class TradeControl
    Inherits System.Web.UI.UserControl

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
    End Sub

#End Region

#Region "private Variable"
    Private pi_Mobile_SrNo As Integer
    Private pi_Member_ID As String
    Private pi_Logo_Url As String
    Private pi_Module_ID As Integer
    Private pi_main_link_ID As Integer
    Private pi_Sub_link_ID As Integer
    Private pi_Redirect_Main_link_ID As Integer
    Private pi_Show_Admin_Login As Boolean
    Private pi_Placeholder As String

#End Region

    Public Property Mobile_SrNo() As Integer
        Get
            Return pi_Mobile_SrNo
        End Get
        Set(ByVal Value As Integer)
            pi_Mobile_SrNo = Value
        End Set
    End Property
    Public Property Member_ID() As String
        Get
            Return pi_Member_ID
        End Get
        Set(ByVal Value As String)
            pi_Member_ID = Value
        End Set
    End Property
    Public Overridable Property Module_ID() As Integer
        Get
            Return pi_Module_ID
        End Get
        Set(ByVal Value As Integer)
            pi_Module_ID = Value
        End Set
    End Property
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
    Public Property Redirect_Main_Links_ID() As Integer
        Get
            Return pi_Redirect_Main_link_ID
        End Get
        Set(ByVal Value As Integer)
            pi_Redirect_Main_link_ID = Value
        End Set
    End Property
    Public Property Show_Admin_Login() As Boolean
        Get
            Return pi_Show_Admin_Login
        End Get
        Set(ByVal Value As Boolean)
            pi_Show_Admin_Login = Value
        End Set
    End Property
    Public Property Placeholder() As String
        Get
            Return pi_Placeholder
        End Get
        Set(ByVal Value As String)
            pi_Placeholder = Value
        End Set
    End Property
    Public Property Logo_Url() As String
        Get
            Return pi_Logo_Url
        End Get
        Set(ByVal Value As String)
            pi_Logo_Url = Value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

End Class
