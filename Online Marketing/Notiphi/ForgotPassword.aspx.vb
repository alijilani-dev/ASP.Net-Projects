Imports Notiphi_BL

Public Class ForgotPassword
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblConfirm As System.Web.UI.WebControls.Label
    Protected WithEvents btnSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents Middle As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents tbMain As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tbWelcome As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tdWelcome As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents rfvUserName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtUserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents redEmailId As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents rfvEmailId As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtEmailID As System.Web.UI.WebControls.TextBox
    Protected WithEvents tblPassword As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tblThanks As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents hlnkLogin As System.Web.UI.WebControls.HyperLink

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
        tblThanks.Visible = False
        tblPassword.Visible = True
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        Dim pi_obj_Encrypt As New clsEncryptData
        Dim pi_obj_Member As New clsMember
        Dim dtMember As DataTable
        Dim drMember As DataRow

        Try
            dtMember = pi_obj_Member.GetUserNameInfo(txtUserName.Text.Trim)
            drMember = dtMember.Rows(0)
            Dim strPass As String = pi_obj_Encrypt.GenerateRandomPassword(10)

            If (drMember("EmailID").ToString() = txtEmailID.Text) Then
                If pi_obj_Member.UpdateForgottenPassword(drMember("UserName").ToString(), pi_obj_Encrypt.Encrypt(strPass)) Then
                    tblPassword.Visible = False
                    tblThanks.Visible = True
                End If
                ' Get the latest Member account information.
                dtMember = pi_obj_Member.GetUserNameInfo(txtUserName.Text.Trim)
                drMember = dtMember.Rows(0)
                ' Send the Password Email.
                SendPasswordMessage(drMember("UserName"), drMember("EmailID"), strPass)
            Else
                Page.RegisterClientScriptBlock("InvalidEmail", "<script>alert('Invalid information provided.');</script>")
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.Write(ex.Message)
            Page.RegisterClientScriptBlock("InvalidEmail", "<script>alert('Invalid information provided.');</script>")
        End Try

    End Sub

    Private Sub SendPasswordMessage(ByVal prmUserName As String, ByVal prmToEmailID As String, ByVal prmPassword As String)

        Dim strHTML As String
        Dim objMessage As Object
        Dim strBasePath As String = ConfigurationSettings.AppSettings("BasePath").ToString()
        Dim strCompanyName As String = ConfigurationSettings.AppSettings("CompanyName").ToString()

        Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
        Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 
        Const cdoAnonymous = 0 'Do not authenticate
        Const cdoBasic = 1 'basic (clear-text) authentication
        Const cdoNTLM = 2 'NTLM

        objMessage = CreateObject("CDO.Message")
        objMessage.Subject = "Your account is activated - Notiphi.com"
        objMessage.From = "sales@Notiphi.com"
        objMessage.To = prmToEmailID

        strHTML = GetPasswordMessage()
        strHTML = strHTML.Replace("[$Username$]", prmUserName)
        strHTML = strHTML.Replace("[$Password$]", prmPassword)
        strHTML = strHTML.Replace("[$LoginURL$]", strBasePath + "/Login.aspx")
        strHTML = strHTML.Replace("[$CompanyName$]", strCompanyName)

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

    Private Function GetPasswordMessage() As String

        Dim strBodyText As New System.Text.StringBuilder
        Dim file As New System.IO.StreamReader(Server.MapPath("~") & "\Templates\ActivationMessage.htm")
        strBodyText.Append(file.ReadToEnd())
        file.Close()
        Return strBodyText.ToString

    End Function

End Class
