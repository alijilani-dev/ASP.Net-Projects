Imports SmartPhi_BL
Public Class Activate
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents tbMain As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tbActivate As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tdContent As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents tdActivate As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents tdMain As System.Web.UI.HtmlControls.HtmlTableCell

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tdMain.Visible = False
        tdActivate.Visible = True
        showUpdateMailSettings()
        If Page.IsPostBack Then
            ActivateAccount()
            tdMain.Visible = True
            tdActivate.Visible = False
        End If

    End Sub

    Public Sub showUpdateMailSettings()

        Dim ctrl_TD_Group As Control
        ctrl_TD_Group = Me.FindControl("tdContent")
        ctrl_TD_Group.Visible = True

        Dim objCtrl As UpdateMailSettings
        objCtrl = CType(Me.LoadControl("Module\UpdateMailSettings.ascx"), UpdateMailSettings)
        objCtrl.MemberGUID = Request.QueryString("Activate").ToString

        Try
            ctrl_TD_Group.Controls.Add(objCtrl)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
        End Try

    End Sub

    Private Sub ActivateAccount()

        Dim pi_obj_Encrypt As New clsEncryptData
        Dim pi_obj_Member As New clsMember
        Dim prmGUID As New Guid(Request.QueryString("Activate").ToString)
        Dim strPass As String = pi_obj_Encrypt.GenerateRandomPassword(10)
        pi_obj_Member.ActivateAccount(prmGUID, True, pi_obj_Encrypt.Encrypt(strPass))
        SendActivationMessage(pi_obj_Member.UserName, pi_obj_Member.EmailID, strPass)

    End Sub

    Private Sub SendActivationMessage(ByVal prmUserName As String, ByVal prmToEmailID As String, ByVal prmPassword As String)

        Dim strHTML As String
        Dim strBasePath As String = ConfigurationSettings.AppSettings("BasePath").ToString()
        Dim strLoginURL As String = strBasePath + "/Login.aspx"

        Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
        Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 
        Const cdoAnonymous = 0 'Do not authenticate
        Const cdoBasic = 1 'basic (clear-text) authentication
        Const cdoNTLM = 2 'NTLM

        Dim objMessage As Object
        objMessage = CreateObject("CDO.Message")
        objMessage.Subject = "Your account is activated - Smartphi.com"
        objMessage.From = "sales@smartphi.com"
        objMessage.To = prmToEmailID

        strHTML = GetActivationMessage()

        strHTML = strHTML.Replace("[$Username$]", prmUserName)
        strHTML = strHTML.Replace("[$Password$]", prmPassword)
        strHTML = strHTML.Replace("[$LoginURL$]", strLoginURL)

        'Inserint the mail body content as html
        objMessage.HTMLBody = CStr("" & strHTML)

        '==This section provides the configuration information for the remote SMTP server.

        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2

        'Name or IP of Remote SMTP Server
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "213.42.18.90" '"10.4.29.4" '

        'Type of authentication, NONE, Basic (Base64 encoded), NTLM
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate") = cdoBasic

        'Your UserID on the SMTP server
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/sendusername") = "admin50534137@helpmanzil.com"

        'Your password on the SMTP server
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/sendpassword") = "admin"

        'Server port (typically 25)
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25

        'Use SSL for the connection (False or True)
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = False

        objMessage.Configuration.Fields.Update()

        '==End remote SMTP server configuration section==

        objMessage.Send()
        objMessage = Nothing
        'End of mail sending code
    End Sub

    Private Function GetActivationMessage() As String

        Dim strBodyText As New System.Text.StringBuilder
        Dim file As New System.IO.StreamReader(Server.MapPath("~") & "\Templates\ActivationMessage.htm")
        strBodyText.Append(file.ReadToEnd())
        file.Close()
        Return strBodyText.ToString

    End Function

End Class
