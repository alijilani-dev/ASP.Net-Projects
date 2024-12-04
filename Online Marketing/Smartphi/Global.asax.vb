Imports System.Web
Imports System.Web.SessionState
Imports SmartPhi_BL

Public Class Global
    Inherits System.Web.HttpApplication

    Private Shared pi_strDateFormat As String = "dd-MMM-yyyy"
    Private Shared pi_strAppRoot As String = "/Trade/"
    Private Shared pi_strAppPhysicalPath As String

#Region " Component Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started
        InitializeApp()
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        Session(Session_str_Admin) = False
        Session(Session_str_UserName) = ""
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

#Region "Public Properties"
    'APPLICATION PROPERTIES
#Region "Application Properties"

    'AppRoot Property Will Return The Virtual Directory Path Of The Application
    Public Shared Property AppRoot() As String
        Get
            Return pi_strAppRoot
        End Get
        Set(ByVal Value As String)
            pi_strAppRoot = Value
        End Set
    End Property

    'AppPhysicalPath Property Will Return The Physical Directory Path Of The Application
    Public Shared Property AppPhysicalPath() As String
        Get
            Return pi_strAppPhysicalPath
        End Get
        Set(ByVal Value As String)
            pi_strAppPhysicalPath = Value
        End Set
    End Property

#End Region

    'DATABASE CONNECTION PROPERTIES
#Region "Database Connection Properties"
    'Properties for Database Connection
    'Database Server Name
    Public Shared ReadOnly Property DBServerName() As String
        Get
            Return ConfigurationSettings.AppSettings("Server")
        End Get
    End Property

    'Database Server Type
    Public Shared ReadOnly Property DBProviderType() As String
        Get
            Return ConfigurationSettings.AppSettings("Type")
        End Get
    End Property

    'Database Max Pool Size
    Public Shared ReadOnly Property DBPoolSize() As String
        Get
            Return ConfigurationSettings.AppSettings("PoolSize")
        End Get
    End Property

    'Database Name 
    Public Shared ReadOnly Property DBName() As String
        Get
            Return "SmartPhi"
        End Get
    End Property

    'Database User Name 
    Public Shared ReadOnly Property DBUserName() As String
        Get
            Return "SmartPhi"
        End Get
    End Property

    'Database User Password 
    Public Shared ReadOnly Property DBUserPwd() As String
        Get
            Return "phi*Smart*18"
        End Get
    End Property
#End Region

    'USER RELATED PROPERTIES
#Region "User Related Properties"

    Public Shared ReadOnly Property UserModules() As String
        Get
            Return "UserModules"
        End Get
    End Property

    Public Shared ReadOnly Property UserId() As String
        Get
            Return "UserId"
        End Get
    End Property

    Public Shared ReadOnly Property UserName() As String
        Get
            Return "UserName"
        End Get
    End Property

    Public Shared ReadOnly Property UserRoleId() As String
        Get
            Return "UserRoleId"
        End Get
    End Property

    Public Shared ReadOnly Property UserRoleName() As String
        Get
            Return "UserRoleName"
        End Get
    End Property

    Public Shared Property UserDateFormat() As String
        Get
            Return pi_strDateFormat
        End Get
        Set(ByVal Value As String)
            pi_strDateFormat = Value
        End Set
    End Property

#End Region

    'PROPERTIES FOR MESSAGES USED IN THE APPLICATION
#Region "Message Properties"

    Public Shared ReadOnly Property DeleteConfirmation() As String
        Get
            Return "Do You Wish To Delete The Record(s) ?"
        End Get
    End Property

    Public Shared ReadOnly Property DeleteMessage() As String
        Get
            Return "Record(s) Deleted Successfully!!!"
        End Get
    End Property

    Public Shared ReadOnly Property SaveMessage() As String
        Get
            Return "Record(s) Saved Successfully!!!"
        End Get
    End Property

    Public Shared ReadOnly Property AddRightsMessage() As String
        Get
            Return "No Rights To Add Record!!!"
        End Get
    End Property

    Public Shared ReadOnly Property EditRightsMessage() As String
        Get
            Return "No Rights To Edit Record!!!"
        End Get
    End Property

    Public Shared ReadOnly Property DeleteRightsMessage() As String
        Get
            Return "No Rights To Delete Record!!!"
        End Get
    End Property

    Public Shared ReadOnly Property ViewRightsMessage() As String
        Get
            Return "No Rights To View Record!!!"
        End Get
    End Property

    Public Shared ReadOnly Property DeleteSystemMessage() As String
        Get
            Return "Cannot Delete System Record!!!"
        End Get
    End Property

    Public Shared ReadOnly Property EditSystemMessage() As String
        Get
            Return "Cannot Edit System Record!!!"
        End Get
    End Property

#End Region

#End Region

#Region "Private/Public Methods"

    Private Sub InitializeApp()
        Dim ls_Server, ls_ProviderType, ls_ConnString As String
        Dim ls_Database, ls_User, ls_Pwd, ls_PoolSize As String

        ' Retrieve information about ADOHelper Class.
        ls_Server = DBServerName 'ConfigurationSettings.AppSettings("Server")
        ls_ProviderType = DBProviderType 'ConfigurationSettings.AppSettings("Type")
        ls_Database = DBName ' "Trade"   'ConfigurationSettings.AppSettings("dbase")
        ls_User = DBUserName '"trade" 'DBUserName ' "trade"    'ConfigurationSettings.AppSettings("usr")
        ls_Pwd = DBUserPwd   ' "" 'ConfigurationSettings.AppSettings("pwd")
        ls_PoolSize = DBPoolSize

        'Prepare Connection String and assign it to the BL's ConnectionString property.
        'ls_ConnString = "Data Source=" & ls_Server & ";Initial Catalog=" & ls_Database & ";User ID=" & ls_User & ";password=" & ls_Pwd & ";Max Pool Size=" & ls_PoolSize

        If ls_User = "" Then
            ls_ConnString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ls_Database & ";Data Source=" & ls_Server
        Else
            ls_ConnString = "Data Source=" & ls_Server & ";Initial Catalog=" & ls_Database & ";User ID=" & ls_User & ";password=" & ls_Pwd & ";Max Pool Size=" & ls_PoolSize
        End If

        ' Set the Connection string to be used by the BL.
        GlobalData.pg_SetConnectionString(ls_ConnString)
        ' Set the Provider Class to be used by the BL.
        GlobalData.pg_SetProviderClass(ls_ProviderType)
    End Sub

    Public Shared Sub SetGridStyle(ByRef dgList As DataGrid)
        dgList.CssClass = "Grid"
        dgList.HeaderStyle.CssClass = "GridHeader"
        dgList.ItemStyle.CssClass = "GridItem"
        dgList.AlternatingItemStyle.CssClass = "GridAltItem"
        dgList.FooterStyle.CssClass = "GridFooter"
        dgList.PagerStyle.CssClass = "GridTd"
    End Sub

#End Region

End Class
