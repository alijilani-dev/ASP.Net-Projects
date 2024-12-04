Public Class AdvContent
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DLContent As System.Web.UI.WebControls.DataList
    Protected WithEvents butSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents RFVComments As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtComments As System.Web.UI.WebControls.TextBox
    Protected WithEvents REVEmail As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents RFVEmail As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtEmail As System.Web.UI.WebControls.TextBox
    Protected WithEvents RFVPhone As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtPhone As System.Web.UI.WebControls.TextBox
    Protected WithEvents RFVCompanyName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtCompanyName As System.Web.UI.WebControls.TextBox
    Protected WithEvents RFVContactname As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents txtcontactName As System.Web.UI.WebControls.TextBox
    Protected WithEvents tblEnquiry As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents ddlPlan As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlDuration As System.Web.UI.WebControls.DropDownList
    Protected WithEvents tblAdvForm As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tblAdvRow1 As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents tblAdvRow2 As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents tblThanksMsg As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tblPlan As System.Web.UI.HtmlControls.HtmlTable

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
    'Private pi_Module_ID As Integer
    Private pi_obj_Content As New Trade_BL.Content
    Private pi_obj_Adv_Enquiry As Trade_BL.AdvertisementEnquiry
#End Region

#Region "Public Properties"

#End Region


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        tblPlan.Visible = False
        tblThanksMsg.Visible = False

        If Not Page.IsPostBack Then
            tblAdvRow1.Visible = False
            tblAdvRow2.Visible = False
            tblPlan.Visible = True
            tblThanksMsg.Visible = False
        Else
            tblPlan.Visible = False
            tblThanksMsg.Visible = True
        End If

    End Sub

    Private Sub butSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSubmit.Click
        pi_obj_Adv_Enquiry = New Trade_BL.AdvertisementEnquiry
        pi_obj_Adv_Enquiry.Adv_Enquiry_Id = 0
        pi_obj_Adv_Enquiry.PlanID = ddlPlan.SelectedItem.Value
        pi_obj_Adv_Enquiry.Duration = ddlDuration.SelectedItem.Value
        pi_obj_Adv_Enquiry.Portal_ID = Session(Session_str_Portal_ID)
        pi_obj_Adv_Enquiry.ContactName = txtcontactName.Text
        pi_obj_Adv_Enquiry.CompanyName = txtCompanyName.Text
        pi_obj_Adv_Enquiry.Phone = txtPhone.Text
        pi_obj_Adv_Enquiry.Email = txtEmail.Text
        pi_obj_Adv_Enquiry.Comments = txtComments.Text

        If pi_obj_Adv_Enquiry.Insert Then
            SendAdvPlanMail()
            Show_ThanksMessage()
            txtcontactName.Text = ""
            txtCompanyName.Text = ""
            txtPhone.Text = ""
            txtEmail.Text = ""
            txtComments.Text = ""
        End If
    End Sub
    Private Sub SendAdvPlanMail()
        Dim strBody As String

        strBody = "<html><body>Hello,<br><p>Thank you for the time and interest you had shown in knowing more about Advertisement Plans on PhoneTrade.cc.</p>" & _
                "<p>We have attached a document, which gives you more information on different plans, which you may wish to book.</p>" & _
                "<p>Looking forward to hear from you.</p><br><br>Best Regards<br>Sales & Customer Support<br>www.PhoneTrade.cc</body></html>"

        Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
        Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 

        Const cdoAnonymous = 0 'Do not authenticate
        Const cdoBasic = 1 'basic (clear-text) authentication
        Const cdoNTLM = 2 'NTLM
        Dim objMessage As Object
        objMessage = CreateObject("CDO.Message")
        objMessage.Subject = "PhoneTrade.cc: Thank you for your Advertisement enquiry."
        objMessage.From = "ads@phonetrade.cc"
        objMessage.To = txtEmail.Text.ToString
        objMessage.bcc = "ads@phonetrade.cc, info@phonetrade.cc"
        objMessage.HTMLBody = CStr("" & strBody)
        objMessage.AddAttachment(Server.MapPath("Phonetrade_AdPlans.xls"))
        '==This section provides the configuration information for the remote SMTP server.
        'Response.Write(Server.MapPath("Phonetrade_AdPlans.xls"))
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2

        'Name or IP of Remote SMTP Server
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "88.208.204.214" '"10.4.29.4"

        'Type of authentication, NONE, Basic (Base64 encoded), NTLM
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate") = cdoBasic

        'Your UserID on the SMTP server
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/sendusername") = "ads@phonetrade.cc" '"admin50534137@helpmanzil.com"

        'Your password on the SMTP server
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/sendpassword") = "domain" '"admin"

        'Server port (typically 25)
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25

        'Use SSL for the connection (False or True)
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = False

        objMessage.Configuration.Fields.Update()

        '==End remote SMTP server configuration section==
        Try
            objMessage.Send()
        Catch ex As Exception
            Trace.Write(ex.Message)
        Finally
            objMessage = Nothing
        End Try

    End Sub
    Private Sub Show_ThanksMessage()

        Dim ctrl_TD_Thanks_Msg As Control ' td where we have to show the content control specified in module
        ctrl_TD_Thanks_Msg = Me.FindControl("TD_Thanks_Msg")
        ctrl_TD_Thanks_Msg.Visible = True
        Try
            tblPlan.Visible = False
            tblThanksMsg.Visible = True
            ctrl_TD_Thanks_Msg.Controls.Add(Me.LoadControl("../Module/ThanksAdv_Enquiry.ascx"))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
        End Try
    End Sub

End Class
