Imports SmartPhi_BL
Public Class Register
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents hlnkCheck As System.Web.UI.WebControls.HyperLink
    Protected WithEvents btnSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents txtMemberName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFaxNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmailID As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAddress As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCity As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlCountry As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtUserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtTerms As System.Web.UI.WebControls.TextBox
    Protected WithEvents rfvMemberName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rfvTelephoneNo As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rfvFirstName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rfvEmailId As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rfvCountry As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents rfvUserName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents redEmailId As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents txtPhoneNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtContactPerson As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtMobileNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblConfirm As System.Web.UI.WebControls.Label
    Protected WithEvents Middle As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents tdWelcome As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents tbMain As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tbWelcome As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents table6 As System.Web.UI.HtmlControls.HtmlTable

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Private variables"
    Private pi_obj_country As New clsCountry
    Private pi_obj_Member As New clsMember
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Put user code to initialize the page here
        If Not Page.IsPostBack Then
            LoadCountry()
        End If
        tbWelcome.Visible = False

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        pi_obj_Member.MemberName = txtMemberName.Text
        pi_obj_Member.PhoneNo = txtPhoneNo.Text
        pi_obj_Member.Address = txtAddress.Text
        pi_obj_Member.FaxNo = txtFaxNo.Text
        pi_obj_Member.MobileNo = txtMobileNo.Text
        pi_obj_Member.ContactPerson = txtContactPerson.Text
        pi_obj_Member.City = txtCity.Text
        pi_obj_Member.CountryID = ddlCountry.SelectedValue
        pi_obj_Member.EmailID = txtEmailID.Text
        pi_obj_Member.UserName = txtUserName.Text
        pi_obj_Member.isActive = False

        If pi_obj_Member.Update(1) Then
            lblConfirm.Visible = True
            lblConfirm.Text = "Thank you for registering with us."
            SendThanksMail(pi_obj_Member.GUID)
            ShowWelcomeMessage()
        End If

    End Sub

    Sub LoadCountry()
        pi_obj_country.GetCountry()
        ddlCountry.DataSource = pi_obj_country.GetCountry()
        ddlCountry.DataBind()
        ddlCountry.SelectedIndex = 0
    End Sub

    Sub SendThanksMail(ByVal prmGUID As String)

        Dim strHTML As String

        Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
        Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 
        Const cdoAnonymous = 0 'Do not authenticate
        Const cdoBasic = 1 'basic (clear-text) authentication
        Const cdoNTLM = 2 'NTLM

        Dim objMessage As Object
        objMessage = CreateObject("CDO.Message")
        objMessage.Subject = "Thanks for joining with us"
        objMessage.From = "sales@smartphi.com"
        objMessage.To = txtEmailID.Text

        strHTML = GetThanksMessage(prmGUID)
        'Inserint the mail body content as html
        'Replace the mail body with Campaign ID, schid, contact id to gen.track report status
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

    Sub ShowWelcomeMessage()

        Dim ctrl_TD_WelcomeMsg As Control
        tbWelcome.Visible = True
        tdWelcome.Visible = True
        tbMain.Visible = False
        ctrl_TD_WelcomeMsg = Me.FindControl("tdWelcome")
        ctrl_TD_WelcomeMsg.Visible = True
        Try
            ctrl_TD_WelcomeMsg.Controls.Add(Me.LoadControl("Module\Welcome.ascx"))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
        End Try

    End Sub

    Private Function GetThanksMessage(ByVal prmGUID As String) As String

        Dim strBodyText As New System.Text.StringBuilder
        Dim strActivationCode As String
        Dim StrBasePath As String = ConfigurationSettings.AppSettings("BasePath").ToString()
        Dim strPath As String = Server.MapPath("~")
        Dim file As New System.IO.StreamReader(strPath & "\Templates\ThanksMessage.htm")
        strActivationCode = StrBasePath & "/activate.aspx?Activate=" & prmGUID & "&code=" & Session.SessionID & "&identifier=" & Mid(prmGUID, 1, 2) & Mid(prmGUID, 6, 2) & Mid(prmGUID, Len(prmGUID) - 2, 2)
        strBodyText.Append(file.ReadToEnd())
        file.Close()
        strBodyText.Replace("[$Username$]", Session(Session_str_UserName))
        strBodyText.Replace("[$ActivationCode$]", strActivationCode)
        Return strBodyText.ToString

    End Function

End Class
