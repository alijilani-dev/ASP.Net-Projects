
Imports System.Web
Imports System.Web.SessionState
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text.Encoding

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

#Region "Global Events"

  Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
    ' Fires when the application is started
    InitializeApp()
  End Sub

  Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started
        'Session("Portal_ID") = 1
        'Session("Portal_Name") = "Phone Trade"
        'Session("Portal_Url") = "default.aspx"

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
    Session.RemoveAll()
    Session.Abandon()
    'FormsAuthentication.SignOut()
  End Sub

  Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
    ' Fires when the application ends
  End Sub
#End Region

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
            Return "tradecpuDB"
    End Get
  End Property

  'Database User Name 
  Public Shared ReadOnly Property DBUserName() As String
    Get
            Return "tradecpu"
    End Get
  End Property

  'Database User Password 
  Public Shared ReadOnly Property DBUserPwd() As String
    Get
            Return "cpu*trade*18"

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

  'PROPERTIES FOR IMAGES USED IN THE APPLICATION
#Region "Image URL Properties"

  Public Shared ReadOnly Property EditImageURL() As String
    Get
      Return "<img border=0 src=" & Global.AppRoot & ConfigurationSettings.AppSettings("imgEditURL") & ">"
    End Get
  End Property
  Public Shared ReadOnly Property UpdateImageURL() As String
    Get
      Return "<img border=0 src=" & Global.AppRoot & ConfigurationSettings.AppSettings("imgUpdateURL") & ">"
    End Get
  End Property
  Public Shared ReadOnly Property DeleteImageURL() As String
    Get
      Return "<img border=0 src=" & Global.AppRoot & ConfigurationSettings.AppSettings("imgDeleteURL") & ">"
    End Get
  End Property
  Public Shared ReadOnly Property CancelImageURL() As String
    Get
      Return "<img border=0 src=" & Global.AppRoot & ConfigurationSettings.AppSettings("imgCancelURL") & ">"
    End Get
  End Property

  Public Shared ReadOnly Property SearchImageURL() As String
    Get
      Return ConfigurationSettings.AppSettings("imgSearchURL")
    End Get
  End Property

  Public Shared ReadOnly Property CalendarImageURL() As String
    Get
      Return "<img border=0 src=" & Global.AppRoot & ConfigurationSettings.AppSettings("imgCalendarURL") & ">"
    End Get
  End Property

  Public Shared ReadOnly Property HeaderImageURL() As String
    Get
      Return "<img border=0 src=" & Global.AppRoot & ConfigurationSettings.AppSettings("imgHeaderURL") & ">"
    End Get
  End Property

  Public Shared ReadOnly Property LoginImageURL() As String
    Get
      Return "<img border=0 src=" & Global.AppRoot & ConfigurationSettings.AppSettings("imgLoginURL") & ">"
    End Get
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

#Region "Encryption/Decryption"
  'Function To encrypt text.
  '***********************************************************************************
  'Programmer				      : Vishal
  'Date Of Creation			  : 02-03-2005
  'Description				    : Procedure To Encrypt the text.
  'Accepted Parameters	  : Text to Encrypt, Encryption Key (8 SPECIAL CHARACTERS)
  'Return Values			    : Encrypted Text
  'Global Variables Accessed	:  -
  'Global Variables Modified	:  -
  'Called by				      : UserInfo.aspx, SignIn.aspx
  'Calls					        :
  'Tables/Fields Accessed	: 
  'Last Edited By			    :
  'Last Edited On			    :
  'Reason				          :
  '***********************************************************************************
  Public Shared Function Encrypt(ByVal strText As String, ByVal strEncrKey As String) As String

    Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}

    Try
      Dim byKey() As Byte = System.Text.Encoding.UTF8.GetBytes(strEncrKey)

      Dim des As New DESCryptoServiceProvider()
      Dim inputByteArray() As Byte = UTF8.GetBytes(strText)
      Dim ms As New MemoryStream()
      Dim cs As New CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write)
      cs.Write(inputByteArray, 0, inputByteArray.Length)
      cs.FlushFinalBlock()
      Return System.Convert.ToBase64String(ms.ToArray())

    Catch ex As Exception
      Return ex.Message
    End Try

  End Function

  'The function used to decrypt the text
  '***********************************************************************************
  'Programmer				      : Vishal
  'Date Of Creation			  : 02-03-2005
  'Description				    : Procedure To decrypt the text.
  'Accepted Parameters	  : Text to decrypt, decryption Key (8 SPECIAL CHARACTERS)
  'Return Values			    : Decrypted Text
  'Global Variables Accessed	:  -
  'Global Variables Modified	:  -
  'Called by				      : UserInfo.aspx, SignIn.aspx
  'Calls					        :
  'Tables/Fields Accessed	: 
  'Last Edited By			    :
  'Last Edited On			    :
  'Reason				          :
  '***********************************************************************************
  Public Shared Function Decrypt(ByVal strText As String, ByVal sDecrKey As String) As String
    Dim byKey() As Byte = {}
    Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
    Dim inputByteArray(strText.Length) As Byte

    Try
      byKey = System.Text.Encoding.UTF8.GetBytes(sDecrKey)
      Dim des As New DESCryptoServiceProvider()
      inputByteArray = System.Convert.FromBase64String(strText)
      Dim ms As New MemoryStream()
      Dim cs As New CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write)

      cs.Write(inputByteArray, 0, inputByteArray.Length)
      cs.FlushFinalBlock()
      Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8

      Return encoding.GetString(ms.ToArray())

    Catch ex As Exception
      Return ex.Message
    End Try
  End Function
#End Region

#Region "Private/Public Methods"

  '***********************************************************************************
  'Programmer				      :  Vishal Dattani
  'Date Of Creation			  :  16-08-2005
  'Description				    :  Method sets the parameters used by the Application.
  'Accepted Parameters		:  -
  'Return Values			    :  -
  'Global Variables Accessed	:  -
  'Global Variables Modified	:  -
  '
  'Called by				      :   Application_Start()
  'Called					        :
  '
  'Tables/Fields Accessed	:  Web.config file.
  '
    'Last Edited By			    : Saeed Kudaimati
  'Last Edited On			    : 16-08-2005
  'Reason				          : Taking Database Configuration From web.Config File
  '***********************************************************************************
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

  'Procedure To Set Grid Style.
  '***********************************************************************************
  'Programmer				      : Vishal
  'Date Of Creation			  : 16-08-2005
  'Description				    : Procedure To Set Grid Style.
  'Accepted Parameters	  : datagrid reference
  'Return Values			    : -
  'Global Variables Accessed	:  -
  'Global Variables Modified	:  -
  'Called by				      : All Forms Having Datagrid
  'Calls					        :
  'Tables/Fields Accessed	: 
  'Last Edited By			    :
  'Last Edited On			    :
  'Reason				          :
  'NOTE                   : The 'Styles.css' File should be referenced in the forms
  '                         html code for the styles to to be applied
  '                         <LINK rel="stylesheet" type="text/css" href="Styles.css">                          
  '***********************************************************************************
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
