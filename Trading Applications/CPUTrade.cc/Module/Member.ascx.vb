Imports System.IO
Imports System.Web.Mail
Imports Trade_BL

Public Class Member
    Inherits TradeControl

#Region "Private variables for controls like combo/label "
    Private pi_DLLCountry_DataTextField As String = "Country_Name"
    Private pi_DLLCountry_DataValueField As String = "Country_ID1"
#End Region

#Region "Private variables"
    Private pi_bln_Admin As Boolean = False
    Private pi_bln_Member As Boolean = False

    Private CurrentUserName As String
    Private pi_obj_members As New Trade_BL.Member
    Private pi_obj_Country As New Trade_BL.Country
    Protected WithEvents chkDealInMS As System.Web.UI.WebControls.CheckBox
    Protected WithEvents cmdSignIn As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents TBMember As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents LogoImage As System.Web.UI.WebControls.Image
    Protected WithEvents Tbl_LogoImage As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents CompanyLogoFile As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents tbl_TermsAgree As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents btnUpdateInformation As System.Web.UI.WebControls.Button
    Protected WithEvents tbl_AdminUpdate As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tr_companyLogofile As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents RFVEmailID1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RFVEmailID2 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents lblUserNameDuplicate As System.Web.UI.WebControls.Label
    Protected WithEvents tbCompName As System.Web.UI.WebControls.TextBox
    Protected WithEvents RFVCompName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents tbUserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents RFVUserName As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents tbPassword As System.Web.UI.WebControls.TextBox
    Protected WithEvents chkCompanyTypeM As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chkCompanyTypeEI As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chkCompanyTypeDR As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chkCompanyTypeR As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chkCompanyTypeSP As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chkCompanyTypeFF As System.Web.UI.WebControls.CheckBox
    Protected WithEvents tbAddress As System.Web.UI.WebControls.TextBox
    Protected WithEvents RFVMailingAdd As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents tbPhoneCountry As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbPhoneAreaCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbPhoneNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents RFVPhone As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents tbFaxCountry As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbFaxAreaCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbFaxNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbWebSite As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbEmailID As System.Web.UI.WebControls.TextBox
    Protected WithEvents RFVEmailID As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents REVEmailID As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents tbHPassword As System.Web.UI.HtmlControls.HtmlInputHidden
    Protected WithEvents TRPassword As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents tbContactPersonName1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents ReqFVContact1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents tbEmailID1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents REVEmailID1 As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents tbMobileCountry1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbMobilePhoneAreaCode1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbMobileNo1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents RFVCont_per_phoneNo As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents tbContactPersonName2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbEmailID2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents REVEmailID2 As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents tbMobileCountry2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbMobilePhoneAreaCode2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents tbMobileNo2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents ReqFVCountry As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents DDLCountry As System.Web.UI.WebControls.DropDownList
    Protected WithEvents tbWelcome As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents DLDealingIn As System.Web.UI.WebControls.DataList


    Private pi_obj_Trading_Category As New Trade_BL.TradingCategory
#End Region

#Region "Public Property"
    Public Property Member() As Boolean
        Get
            Return pi_bln_Member
        End Get
        Set(ByVal Value As Boolean)
            pi_bln_Member = Value
        End Set
    End Property

    Public Property Admin() As Boolean
        Get
            Return pi_bln_Admin
        End Get
        Set(ByVal Value As Boolean)
            pi_bln_Admin = Value
        End Set
    End Property
#End Region

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents chkIAgree As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chkDealInSIMFreePhone As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chkDealInNetworkStk As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chkDealInUsedMP As System.Web.UI.WebControls.CheckBox
    Protected WithEvents chkDealInMPA As System.Web.UI.WebControls.CheckBox


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
        lblUserNameDuplicate.Text = "Messaage Sent.."
        'Put user code to initialize the page here

        If Main_Links_ID <> 25 And (Session(Session_str_UserName) = "" Or Session(Session_str_UserName) Is Nothing) Then
            Response.Redirect("PortalDefault.aspx?Main_Links_ID=24")
        End If

        'IS ADMIN LOOGED IN
        If Page.IsPostBack = False Then
            viewState("vpi_bln_Admin") = pi_bln_Admin
        Else
            pi_bln_Admin = viewState("vpi_bln_Admin")
        End If

        ' IS USER LOGGED IN
        If Session(Session_str_UserName) <> "" Then
            Member_ID = Session(Session_str_UserName)
            Member = True
        Else
            Member_ID = ""
            Member = False
        End If

        'Confirm.Visible = False
        'Confirm.Main_Links_ID = Me.Main_Links_ID
        'Confirm.Sub_Links_ID = Me.Sub_Links_ID
        'Confirm.Module_ID = Me.Module_ID

        'Confirm.Message = "Your Registration Completed Successfully, your user name and password will be mailing you to your email address"
        'Confirm.Todo = "Thank you for registering, to Register another member "

        lblUserNameDuplicate.Visible = False

        ' xxxxxxxxxxxxxxxxxxxxx
        TRPassword.Visible = pi_bln_Admin 'True
        'Tbl_LogoImage.Visible = pi_bln_Admin 'True
        tr_companyLogofile.Visible = pi_bln_Admin
        tbl_TermsAgree.Visible = Not pi_bln_Admin Or Not Member 'True
        tbl_AdminUpdate.Visible = pi_bln_Admin 'True

        ' xxxxxxxxxxxxxxxxxxxxx

        If Page.IsPostBack = False Then
            'If pi_bln_Admin = True Then            
            'Else
            '   TRPassword.Visible = False
            '  Tbl_LogoImage.Visible = True
            'End If

            'XXXXXXXXXX Fill Country XXXXXXXXX
            '''Coded first line commented by Basheer on jan 23rd
            '''DDLCountry.DataSource = pi_obj_Country.GetCountries()
            DDLCountry.DataSource = pi_obj_Country.GetAllCountries()
            '''The abv one line code inserted
            DDLCountry.DataTextField = pi_DLLCountry_DataTextField
            DDLCountry.DataValueField = pi_DLLCountry_DataValueField
            DDLCountry.DataBind()
            'XXXXXXXXXX Fill Country XXXXXXXXX
            DLDealingIn.DataSource = pi_obj_Trading_Category.GetTradingCategories()
            DLDealingIn.DataKeyField = "Trading_Cat_ID"
            DLDealingIn.DataBind()
            Try
                CurrentUserName = Session(Session_str_UserName)
            Catch
                CurrentUserName = ""
            End Try
            Try
                If Me.Member_ID <> "" Then
                    CurrentUserName = Me.Member_ID
                Else
                    CurrentUserName = ""
                End If
            Catch ex As Exception
                CurrentUserName = ""
            End Try

            pi_obj_members = New Trade_BL.Member
            If CurrentUserName = "" Then
                cmdSignIn.Text = "Sign In"
                chkIAgree.Visible = True
                tbUserName.Enabled = True
            ElseIf CurrentUserName <> "" Then
                ' the user already logged in hence
                ' show for editing
                '
                UpdateProfile()
            End If
        Else

        End If
        tbWelcome.Visible = False
    End Sub
    Public Sub UpdateProfile()
        Dim lcounter As Integer
        Dim SplitArray() As String
        Dim dr_trad_cat As DataRow
        Dim dt_Member As DataTable
        Dim dr_Member As DataRow

        Try
            If Me.Member_ID <> "" Then
                CurrentUserName = Me.Member_ID
            Else
                CurrentUserName = ""
            End If
        Catch ex As Exception
            CurrentUserName = ""
        End Try
        cmdSignIn.Text = "Update Profile"
        chkIAgree.Visible = False
        dt_Member = pi_obj_members.GetMembers(CurrentUserName)
        If dt_Member.Rows.Count <= 0 Then
            Exit Sub
        End If
        dr_Member = dt_Member.Rows(0)

        pi_obj_members.member_id = dr_Member("member_id")
        pi_obj_members.portal_id = dr_Member("portal_id")
        pi_obj_members.password = dr_Member("password")
        pi_obj_members.member_company = dr_Member("member_company").ToString
        pi_obj_members.manufacturer_type = IIf(dr_Member("manufacturer_type") = 1, True, False)
        pi_obj_members.exp_imp_type = IIf(dr_Member("exp_imp_type") = 1, True, False)
        pi_obj_members.dealer_reseller_type = IIf(dr_Member("dealer_reseller_type") = 1, True, False)
        pi_obj_members.retailer_type = IIf(dr_Member("retailer_type") = 1, True, False)
        pi_obj_members.service_prov_type = IIf(dr_Member("service_prov_type") = 1, True, False)
        pi_obj_members.freight_type = IIf(dr_Member("freight_type") = 1, True, False)
        pi_obj_members.mailing_address = dr_Member("mailing_address").ToString
        pi_obj_members.company_phone = dr_Member("company_phone").ToString
        pi_obj_members.company_fax = dr_Member("company_fax").ToString
        pi_obj_members.company_email = dr_Member("company_email").ToString
        pi_obj_members.company_website = dr_Member("company_website").ToString
        pi_obj_members.company_contact1_name = dr_Member("company_contact1_name").ToString
        pi_obj_members.company_contact1_mobile = dr_Member("company_contact1_mobile").ToString
        pi_obj_members.company_contact1_email = dr_Member("company_contact1_email").ToString
        pi_obj_members.company_contact2_name = dr_Member("company_contact2_name").ToString
        pi_obj_members.company_contact2_mobile = dr_Member("company_contact2_mobile").ToString
        pi_obj_members.company_contact2_email = dr_Member("company_contact2_email").ToString
        pi_obj_members.country_id = dr_Member("country_id")

        tbUserName.Enabled = False

        tbUserName.Text = pi_obj_members.member_id
        pi_obj_members.portal_id = Session(Session_str_Portal_ID)

        tbHPassword.Value = pi_obj_members.password

        tbCompName.Text = pi_obj_members.member_company
        'chkCompanyTypeM.Checked = pi_obj_members.manufacturer_type
        chkCompanyTypeEI.Checked = pi_obj_members.exp_imp_type
        chkCompanyTypeDR.Checked = pi_obj_members.dealer_reseller_type
        chkCompanyTypeR.Checked = pi_obj_members.retailer_type
        chkCompanyTypeSP.Checked = pi_obj_members.service_prov_type
        chkCompanyTypeFF.Checked = pi_obj_members.freight_type
        tbAddress.Text = pi_obj_members.mailing_address

        SplitArray = Split(pi_obj_members.company_phone, "*")

        Try
            tbPhoneCountry.Text = SplitArray(0)
        Catch ex As Exception
            tbPhoneAreaCode.Text = ""
        End Try
        Try
            tbPhoneAreaCode.Text = SplitArray(1)
        Catch ex As Exception
            tbPhoneCountry.Text = ""
        End Try
        Try
            tbPhoneNo.Text = SplitArray(2)
        Catch ex As Exception
            tbPhoneNo.Text = ""
        End Try

        SplitArray = Split(pi_obj_members.company_fax, "*")
        Try
            tbFaxCountry.Text = SplitArray(0)
        Catch ex As Exception
            tbFaxAreaCode.Text = ""
        End Try
        Try
            tbFaxAreaCode.Text = SplitArray(1)
        Catch ex As Exception
            tbFaxCountry.Text = ""
        End Try
        Try
            tbFaxNo.Text = SplitArray(2)
        Catch ex As Exception
            tbFaxNo.Text = ""
        End Try

        tbEmailID.Text = pi_obj_members.company_email
        tbWebSite.Text = pi_obj_members.company_website
        tbContactPersonName1.Text = pi_obj_members.company_contact1_name

        SplitArray = Split(pi_obj_members.company_contact1_mobile, "*")

        Try
            tbMobileCountry1.Text = SplitArray(0)
        Catch ex As Exception
            tbMobilePhoneAreaCode1.Text = ""
        End Try
        Try
            tbMobilePhoneAreaCode1.Text = SplitArray(1)
        Catch ex As Exception
            tbMobileCountry1.Text = ""
        End Try
        Try
            tbMobileNo1.Text = SplitArray(2)
        Catch ex As Exception
            tbMobileNo1.Text = ""
        End Try

        tbEmailID1.Text = pi_obj_members.company_contact1_email
        tbContactPersonName2.Text = pi_obj_members.company_contact2_name

        SplitArray = Split(pi_obj_members.company_contact2_mobile, "*")

        Try
            tbMobileCountry2.Text = SplitArray(0)
        Catch ex As Exception
            tbMobilePhoneAreaCode2.Text = ""
        End Try
        Try
            tbMobilePhoneAreaCode2.Text = SplitArray(1)
        Catch ex As Exception
            tbMobileCountry2.Text = ""
        End Try
        Try
            tbMobileNo2.Text = SplitArray(2)
        Catch ex As Exception
            tbMobileNo2.Text = ""
        End Try

        tbEmailID2.Text = pi_obj_members.company_contact2_email
        'DDLCountry.Items.FindByValue(pi_obj_members.country_id)
        Dim liSelection As ListItem
        liSelection = DDLCountry.Items.FindByValue(pi_obj_members.country_id)
        liSelection.Selected = True

        pi_obj_members.Trading_Cat = pi_obj_members.GetMemberTradingCategories(dr_Member("member_id"))

        For lcounter = 0 To DLDealingIn.Items.Count - 1
            For Each dr_trad_cat In pi_obj_members.Trading_Cat.Rows
                If DLDealingIn.DataKeys.Item(lcounter) = dr_trad_cat("Trading_Cat_ID") Then
                    CType(DLDealingIn.Items(lcounter).Controls(1), CheckBox).Checked = True
                End If
            Next
        Next
    End Sub
    Private Sub cmdSignin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSignIn.Click
        Dim lcounter As Integer
        Dim dr As DataRow

        pi_obj_members.member_id = tbUserName.Text
        pi_obj_members.portal_id = Session(Session_str_Portal_ID)
        pi_obj_members.password = tbHPassword.Value
        pi_obj_members.member_company = tbCompName.Text
        'pi_obj_members.manufacturer_type = IIf(chkCompanyTypeM.Checked = True, "1", "0")
        pi_obj_members.manufacturer_type = 0 '''Added to have 0 in ManufType - Basheer
        pi_obj_members.exp_imp_type = IIf(chkCompanyTypeEI.Checked = True, "1", "0")
        pi_obj_members.dealer_reseller_type = IIf(chkCompanyTypeDR.Checked = True, "1", "0")
        pi_obj_members.retailer_type = IIf(chkCompanyTypeR.Checked = True, "1", "0")
        pi_obj_members.service_prov_type = IIf(chkCompanyTypeSP.Checked = True, "1", "0")
        pi_obj_members.freight_type = IIf(chkCompanyTypeFF.Checked = True, "1", "0")
        pi_obj_members.mailing_address = tbAddress.Text
        pi_obj_members.company_phone = tbPhoneCountry.Text & "*" & tbPhoneAreaCode.Text & "*" & tbPhoneNo.Text
        pi_obj_members.company_fax = tbFaxCountry.Text & "*" & tbFaxAreaCode.Text & "*" & tbFaxNo.Text
        pi_obj_members.company_email = tbEmailID.Text
        pi_obj_members.company_website = tbWebSite.Text
        pi_obj_members.company_contact1_name = tbContactPersonName1.Text
        pi_obj_members.company_contact1_mobile = tbMobileCountry1.Text & "*" & tbMobilePhoneAreaCode1.Text & "*" & tbMobileNo1.Text
        pi_obj_members.company_contact1_email = tbEmailID1.Text
        pi_obj_members.company_contact2_name = tbContactPersonName2.Text
        pi_obj_members.company_contact2_mobile = tbMobileCountry2.Text & "*" & tbMobilePhoneAreaCode2.Text & "*" & tbMobileNo2.Text
        pi_obj_members.company_contact2_email = tbEmailID2.Text
        pi_obj_members.country_id = DDLCountry.SelectedItem.Value

        pi_obj_members.Trading_Cat.Clear()

        For lcounter = 0 To DLDealingIn.Items.Count - 1
            If CType(DLDealingIn.Items(lcounter).Controls(1), CheckBox).Checked = True Then
                dr = pi_obj_members.Trading_Cat.NewRow()
                dr("Trading_Cat_ID") = DLDealingIn.DataKeys.Item(lcounter)
                pi_obj_members.Trading_Cat.Rows.Add(dr)
            End If
        Next

        If chkIAgree.Visible = True And chkIAgree.Checked = True And chkIAgree.Text = "I Agree to the Terms and Condition" Then ' customer agrees
            ' insert into the table
            If pi_obj_members.DuplicateUserName() Then
                lblUserNameDuplicate.Text = "Duplicate User Name, Please enter Valid User name"
                lblUserNameDuplicate.Visible = True
                Exit Sub
            End If

            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            ' if administrator is login 
            ''Commented by BASHEER on Jan 07, time 2.16pm -- comment starts
            '''If pi_bln_Admin = True Then
            '''    Dim strImg As String

            '''    strImg = Server.MapPath("images/") & tbUserName.Text & ".jpg"
            '''    Try
            '''        CompanyLogoFile.PostedFile.SaveAs(strImg)
            '''    Catch Exc As Exception
            '''        lblUserNameDuplicate.Text = "Please enter proper Image file"
            '''        lblUserNameDuplicate.Visible = True
            '''        Exit Sub
            '''    End Try
            '''    pi_obj_members.Compony_Logo_url = "images/" & tbUserName.Text & ".jpg"
            '''End If
            ''''Till here.......... comment ends


            If pi_obj_members.Update(1) = True Then
                'Confirm.Message = "Your Registration Completed Successfully, your user name and password will be mailing you to your email address"
                'Confirm.Todo = "Thank you for registering, to Register another member "
                'Response.Redirect("PortalDefault.aspx?Main_Links_ID=")
                Show_WelcomeMessage()
                '********************************* Sending Email To Admin and Customer.
                ' sending thanks & wellcome mail
                '*********************************
                SendWellComeMail(pi_obj_members)
                SendWellComeForm(pi_obj_members)
                'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                If Admin = True Then
                    'Confirm.link = "..\admin\MemberDetails.aspx"
                End If

                'Confirm.ShowConfirmationMessage()
                TBMember.Visible = False
                System.Diagnostics.Debug.WriteLine("Hi")
                'Response.Redirect("PortalDefault.aspx?Main_Links_ID=" & MyBase.Main_Links_ID & "&Sub_Links_ID=" & MyBase.Sub_Links_ID)
            End If
        Else
            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            ' if administrator is login
            ''Commented by BASHEER on Jan 07, time 2.16pm -- comment starts
            ''''If pi_bln_Admin = True Then
            ''''    Dim strImg As String
            ''''    strImg = Server.MapPath("images/") & tbUserName.Text & ".jpg"

            ''''    Try
            ''''        CompanyLogoFile.PostedFile.SaveAs(strImg)

            ''''    Catch Exc As Exception
            ''''        lblUserNameDuplicate.Text = "Please enter proper Image file"
            ''''        lblUserNameDuplicate.Visible = True
            ''''        Exit Sub
            ''''    End Try
            ''''End If
            ''''pi_obj_members.Compony_Logo_url = "images//" & tbUserName.Text & ".jpg"
            ''Commented by BASHEER on Jan 07, time 2.16pm -- comment ends



            If Session(Session_str_UserName) <> "" And pi_obj_members.Update(2) = True Then
                lblMessage.Visible = (Session(Session_str_UserName) <> "")
                lblMessage.Text = "Member details has been updated successfully."
                'Confirm.Message = "Your profile is updated successfully"
                'Confirm.Todo = "Thank you for being a member, to Register another member "
                'Response.Redirect("PortalDefault.aspx?Main_Links_ID=6") ' & MyBase.Main_Links_ID & "&Sub_Links_ID=" & MyBase.Sub_Links_ID)
                If Admin = True Then
                    'Confirm.link = "PortalDefault.aspx?Main_Links_ID=" & MyBase.Main_Links_ID
                    Response.Redirect("PortalDefault.aspx?Main_Links_ID=" & MyBase.Main_Links_ID)
                    Response.End()                    'Confirm.link = "..\admin\MemberDetails.aspx"
                    ' Commented by Ali.
                    'Confirm.link = "..\admin\MemberDetails.aspx"
                    'Response.Redirect("..\admin\MemberDetails.aspx")
                    'Response.End()
                End If

                'Confirm.ShowConfirmationMessage()
                System.Diagnostics.Debug.WriteLine("Hi")
                'Response.Redirect("PortalDefault.aspx?Main_Links_ID=" & MyBase.Main_Links_ID & "&Sub_Links_ID=" & MyBase.Sub_Links_ID)
            End If
        End If
    End Sub
    Private Sub btnUpdateInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateInformation.Click
        'call sgn in code for updatetion
        cmdSignin_Click(sender, e)
    End Sub
    '''''Private Sub SendWellComeMail(ByVal pi_obj_members As Trade_BL.Member)
    '''''    Dim objXMLHTTP, xml
    '''''    Dim strMailContent As String
    '''''    Try
    '''''        xml = CreateObject("Msxml2.ServerXMLHTTP")
    '''''        ' Notice the two changes in the next two lines:
    '''''        xml.Open("GET", "http://mobiphi.com/mailtemplate.htm", False)
    '''''        xml.Send()
    '''''        strMailContent = xml.responseText()
    '''''        xml = Nothing

    '''''        strMailContent = strMailContent.Replace("< UserName >", "<font color = '#FF0000'>" & pi_obj_members.member_id & " </font>")

    '''''        Dim mlMsg As New MailMessage
    '''''        mlMsg.From = "aliakbar@skiphi.com"
    '''''        mlMsg.To = "alicputrade@hotmail.com"
    '''''        'mlMsg.Bcc = "malik@skyphi.com"
    '''''        mlMsg.BodyFormat = MailFormat.Html
    '''''        mlMsg.Subject = "Phone Trade Enquiry ...."
    '''''        mlMsg.Body = strMailContent
    '''''        'mlMsg.Attachments.Add(New MailAttachment("c:\Roses.jpg"))
    '''''        ''mlMsg.Attachments.Add(New MailAttachment(Request.MapPath("http://www.cputrade.cc/thanksmail/logo.jpg")))
    '''''        Mail.SmtpMail.SmtpServer = ""
    '''''        Mail.SmtpMail.Send(mlMsg)
    '''''    Catch ex As Exception
    '''''        Response.Write(ex.Message)
    '''''    End Try
    '''''End Sub
    '''''Private Sub SendWellComeForm(ByVal pi_obj_members As Trade_BL.Member)

    '''''    Dim objXMLHTTP, xml
    '''''    Dim strMailContent As String
    '''''    Try
    '''''        xml = CreateObject("Msxml2.ServerXMLHTTP")
    '''''        ' Notice the two changes in the next two lines:
    '''''        xml.Open("GET", "http://www.mobiphi.com/Print.htm", False)
    '''''        xml.Send()
    '''''        strMailContent = xml.responseText()
    '''''        xml = Nothing
    '''''        strMailContent = strMailContent.Replace("< CompanyName >", "<font color = '#FF0000'>" & pi_obj_members.member_id & " </font>")
    '''''        strMailContent = strMailContent.Replace("< Address >", "<font color = '#FF0000'>" & pi_obj_members.mailing_address & " </font>")
    '''''        strMailContent = strMailContent.Replace("< Country >", "<font color = '#FF0000'>" & DDLCountry.SelectedItem.Text & " </font>")
    '''''        strMailContent = strMailContent.Replace("< Phone >", "<font color = '#FF0000'>" & pi_obj_members.company_phone & " </font>")
    '''''        strMailContent = strMailContent.Replace("< Fax >", "<font color = '#FF0000'>" & pi_obj_members.company_fax & " </font>")
    '''''        strMailContent = strMailContent.Replace("< Email >", "<font color = '#FF0000'>" & pi_obj_members.company_email & " </font>")
    '''''        strMailContent = strMailContent.Replace("< Website >", "<font color = '#FF0000'>" & pi_obj_members.company_website & " </font>")
    '''''        strMailContent = strMailContent.Replace("< Name >", "<font color = '#FF0000'>" & pi_obj_members.company_contact2_name & " </font>")
    '''''        strMailContent = strMailContent.Replace("< Mobile >", "<font color = '#FF0000'>" & pi_obj_members.company_contact1_mobile & " </font>")
    '''''        strMailContent = strMailContent.Replace("< PersonalEmail >", "<font color = '#FF0000'>" & pi_obj_members.company_contact1_email & " </font>")
    '''''        strMailContent = strMailContent.Replace("< SecondContact >", "<font color = '#FF0000'>" & pi_obj_members.company_contact2_name & " </font>")
    '''''        strMailContent = strMailContent.Replace("< MobileNo2 >", "<font color = '#FF0000'>" & pi_obj_members.company_contact2_mobile & " </font>")
    '''''        strMailContent = strMailContent.Replace("< PersonalEmail2 >", "<font color = '#FF0000'>" & pi_obj_members.company_contact2_email & " </font>")
    '''''        Dim i As Integer
    '''''        Dim strCompanyType As String = New String("")

    '''''        For i = 0 To pi_obj_members.Trading_Cat.Rows.Count
    '''''            strCompanyType = strCompanyType & "<TR><TD>" & pi_obj_members.Trading_Cat.Rows(1)(0) & "</TD></TR>"
    '''''        Next

    '''''        strMailContent = strMailContent.Replace("< %CompanyType% >", strCompanyType)

    '''''        Dim mlMsg As New MailMessage
    '''''        mlMsg.From = "info@cputrade.cc"
    '''''        mlMsg.To = "alicputrade@hotmail.com"
    '''''        'mlMsg.Bcc = "malik@skyphi.com"
    '''''        mlMsg.BodyFormat = MailFormat.Html
    '''''        mlMsg.Subject = "Phone Trade Enquiry ...."
    '''''        mlMsg.Body = strMailContent
    '''''        ''mlMsg.Attachments.Add(New MailAttachment(Request.MapPath("http://www.cputrade.cc/thanksmail/logo.jpg")))
    '''''        Mail.SmtpMail.SmtpServer = ""
    '''''        Mail.SmtpMail.Send(mlMsg)
    '''''        Response.Write("Sent")
    '''''    Catch ex As Exception
    '''''        Response.Write(ex.Message)
    '''''    End Try
    '''''End Sub
    Private Sub SendWellComeMail(ByVal pi_obj_members As Trade_BL.Member)
        Dim strBody As String
        '''Dim msgMail As New MailMessage

        'strBody = GetBodyText()
        strBody = GetBodyTextVersion2()

        '''msgMail.From = "sales@cputrade.cc"
        '''msgMail.To = pi_obj_members.company_email
        '''msgMail.Bcc = "basheer@ireuae.com"
        '''msgMail.Subject = "Thank you for joining cputrade.cc."
        '''msgMail.BodyFormat = MailFormat.Html
        '''msgMail.Body = Replace(strBody, "*Member*", pi_obj_members.member_company)
        '''SmtpMail.Send(msgMail)
        ''''Response.Write(Replace(strBody, "*Member*", pi_obj_members.member_company))
        Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
        Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 

        Const cdoAnonymous = 0 'Do not authenticate
        Const cdoBasic = 1 'basic (clear-text) authentication
        Const cdoNTLM = 2 'NTLM
        Dim objMessage As Object
        objMessage = CreateObject("CDO.Message")
        objMessage.Subject = "Thank you for joining cputrade.cc."
        objMessage.From = "sales@cputrade.cc"
        objMessage.To = pi_obj_members.company_email
        If Len(pi_obj_members.company_contact1_email & "") > 0 Then objMessage.Cc = pi_obj_members.company_email
        objMessage.bcc = "sales@cputrade.cc"
        objMessage.HTMLBody = CStr("" & Replace(strBody, "*Member*", pi_obj_members.member_company))

        '==This section provides the configuration information for the remote SMTP server.

        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2

        'Name or IP of Remote SMTP Server
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "10.4.29.4"

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
    End Sub
    Private Sub SendWellComeForm(ByVal pi_obj_members As Trade_BL.Member)
        Dim strMailContent As String
        Dim strMailTemp As String
        '''Dim msgMail As New MailMessage

        'strMailTemp = GetPrintForm()
        strMailTemp = GetPrintFormVersion2()


        strMailContent = strMailTemp
        strMailContent = strMailContent.Replace("*CompanyName*", "<font color = '#000000'>" & pi_obj_members.member_company & " </font>")
        strMailContent = strMailContent.Replace("*Address*", "<font color = '#000000'>" & pi_obj_members.mailing_address & " </font>")
        strMailContent = strMailContent.Replace("*Country*", "<font color = '#000000'>" & DDLCountry.SelectedItem.Text & "</font>")
        strMailContent = strMailContent.Replace("*Phone*", "<font color = '#000000'>" & Replace(pi_obj_members.company_phone, "*", " ") & " </font>")
        strMailContent = strMailContent.Replace("*Fax*", "<font color = '#000000'>" & Replace(pi_obj_members.company_fax, "*", " ") & " </font>")
        strMailContent = strMailContent.Replace("*Email*", "<font color = '#000000'>" & pi_obj_members.company_email & " </font>")
        strMailContent = strMailContent.Replace("*Website*", "<font color = '#000000'>" & pi_obj_members.company_website & " </font>")
        strMailContent = strMailContent.Replace("*Name*", "<font color = '#000000'>" & pi_obj_members.company_contact2_name & " </font>")
        strMailContent = strMailContent.Replace("*Mobile*", "<font color = '#000000'>" & Replace(pi_obj_members.company_contact1_mobile, "*", " ") & " </font>")
        strMailContent = strMailContent.Replace("*PersonalEmail*", "<font color = '#000000'>" & pi_obj_members.company_contact1_email & " </font>")
        strMailContent = strMailContent.Replace("*SecondContact*", "<font color = '#000000'>" & pi_obj_members.company_contact2_name & " </font>")
        strMailContent = strMailContent.Replace("*MobileNo2*", "<font color = '#000000'>" & Replace(pi_obj_members.company_contact2_mobile, "*", " ") & " </font>")
        strMailContent = strMailContent.Replace("*PersonalEmail2*", "<font color = '#000000'>" & pi_obj_members.company_contact2_email & " </font>")

        ''Dim i As Integer
        ''Dim strCompanyType As String = New String("")

        ''For i = 0 To pi_obj_members.Trading_Cat.Rows.Count
        ''    strCompanyType = strCompanyType & "<img src=http://www.cputrade.cc/Images/tick.gif border=0>" & pi_obj_members.Trading_Cat.Rows(1)(0) & "<br>"
        ''Next

        ''strMailContent = strMailContent.Replace("*CompanyType*", strCompanyType.ToString)

        strMailContent = strMailContent.Replace("*CompanyType*", String.Empty)
        strMailContent = strMailContent.Replace("*Mobile*", "")
        strMailContent = strMailContent.Replace("*PersonalEmail*", "")
        strMailContent = strMailContent.Replace("*SecondContact*", "")
        strMailContent = strMailContent.Replace("*MobileNo2*", "")
        strMailContent = strMailContent.Replace("*PersonalEmail2*", "")

        strMailContent = strMailContent.Replace("**", "")

        '''msgMail.From = "sales@cputrade.cc"
        '''msgMail.To = pi_obj_members.company_email

        '''msgMail.Bcc = "basheer@ireuae.com"
        '''msgMail.Subject = "cputrade.cc: Member Confirmation!"

        '''msgMail.BodyFormat = MailFormat.Html
        '''msgMail.Body = strMailContent

        '''SmtpMail.Send(msgMail)
        ''''Response.Write(strMailContent)
        Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
        Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 

        Const cdoAnonymous = 0 'Do not authenticate
        Const cdoBasic = 1 'basic (clear-text) authentication
        Const cdoNTLM = 2 'NTLM
        Dim objMessage As Object
        objMessage = CreateObject("CDO.Message")
        objMessage.Subject = "cputrade.cc: Member Confirmation!"
        objMessage.From = "sales@cputrade.cc"
        objMessage.To = pi_obj_members.company_email
        If Len(pi_obj_members.company_contact1_email & "") > 0 Then objMessage.Cc = pi_obj_members.company_contact1_email
        objMessage.bcc = "sales@cputrade.cc"
        objMessage.HTMLBody = CStr("" & strMailContent)

        '==This section provides the configuration information for the remote SMTP server.

        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2

        'Name or IP of Remote SMTP Server
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "10.4.29.4"

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
    End Sub
    Public Sub Show_WelcomeMessage()

        Dim ctrl_TD_WelcomeMsg As Control ' td where we have to show the content control specified in module
        tbWelcome.Visible = True
        ctrl_TD_WelcomeMsg = Me.FindControl("TD_WelcomeMsg")
        ctrl_TD_WelcomeMsg.Visible = True
        Try
            ctrl_TD_WelcomeMsg.Controls.Add(Me.LoadControl("../Module/Welcome.ascx"))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message.ToString)
        End Try
    End Sub
    Private Function GetBodyText() As String
        Dim objXMLHTTP, xml
        Dim bodytxt As String
        Try
            xml = CreateObject("Msxml2.ServerXMLHTTP")
            xml.Open("GET", "http://www.cputrade.cc/signup_email.htm", False)
            xml.Send()

            bodytxt = xml.responseText()
            xml = Nothing
            Return bodytxt
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Function
    Private Function GetBodyTextVersion2() As String
        Dim strBodyText As New System.Text.StringBuilder

        strBodyText.Append("<html><head><title>Thanks for registering with us. cputrade.cc</title></head>")
        strBodyText.Append("<body leftmargin=""0"" topmargin=""5"" marginwidth=""0"" marginheight=""0"" bgcolor=""#333333"" rightmargin=""0"" bottommargin=""5"">")
        strBodyText.Append("<div align=""center""><table width=""742"" border=""0"" cellspacing=""0"" cellpadding=""0"" style=""border-right: 1px solid #FFFFFF; border-top: 1px solid #FFFFFF"">")
        strBodyText.Append("<tr><td width=""742"" background=""http://www.cputrade.cc/Images/thanksmail/top_bg.jpg""><img src=""http://www.cputrade.cc/Images/thanksmail/logo.jpg"" width=""742"" height=""76""></td>  </tr></table></div>")
        strBodyText.Append("<div align=""center""><table width=""742"" border=""0"" cellspacing=""0"" cellpadding=""0"">  <tr> ")
        strBodyText.Append("<td width=""430"" valign=""top"" bgcolor=""ECECEC""><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">")
        strBodyText.Append("<tr> <td><img src=""http://www.cputrade.cc/Images/thanksmail/left_img.jpg"" width=""430"" height=""502""></td></tr></table><br>")
        strBodyText.Append("<table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr valign=""top""> ")
        strBodyText.Append("<td width=""8%"" height=""21"" align=""center"" valign=""middle""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr>")
        strBodyText.Append("<td height=4></td></tr></table><img src=""http://www.cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td>")
        strBodyText.Append("<td width=""92%"" valign=""middle""><div align=""justify""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">For any enquires please feel free to contact us:</font></b></div></td>")
        strBodyText.Append("</tr></table><table width=""102%"" border=""0"" cellpadding=""0"" cellspacing=""0""><tr valign=""top""> ")
        strBodyText.Append("<td width=""8%"" height=""21"" align=""center"" valign=""middle""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr></table>")
        strBodyText.Append("<img src=""http://www.cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td width=""16%"" valign=""middle""><div align=""justify""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Phone ")
        strBodyText.Append("</font></b></div></td><td width=""5%"" align=""center"" valign=""middle""><strong><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">:</font></strong></td>")
        strBodyText.Append("<td width=""71%"" valign=""middle""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif""> +971 4 3681 764</font></b></td></tr>")
        strBodyText.Append("<tr valign=""top""> <td height=""21"" align=""center"" valign=""middle""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr></table>")
        strBodyText.Append("<img src=""http://www.cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td valign=""middle""><div align=""justify""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Fax </font></b></div></td>")
        strBodyText.Append("<td align=""center"" valign=""middle""><strong><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">: </font></strong></td><td valign=""middle""><b>")
        strBodyText.Append("<font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">+971 4 2994 492</font></b></td></tr><tr valign=""top""> ")
        strBodyText.Append("<td height=""21"" align=""center"" valign=""middle""><img src=""http://www.cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td valign=""middle""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Mobile ")
        strBodyText.Append("</font></b></td><td align=""center"" valign=""middle""><strong><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">:</font></strong></td><td valign=""middle""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif""> ")
        strBodyText.Append("+971 50 2052 150</font></b></td></tr><tr valign=""top""> <td height=""21"" align=""center"" valign=""middle""><img src=""http://www.cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td>")
        strBodyText.Append("<td valign=""middle""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Email</font></b></td><td align=""center"" valign=""middle""><strong><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif""> ")
        strBodyText.Append(":</font></strong></td><td valign=""middle""><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif""> <a href=""mailto:info@cputrade.cc"">info@cputrade.cc</a></font></td></tr>")
        strBodyText.Append("<tr valign=""top""> <td height=""21"" align=""center"" valign=""middle"">&nbsp;</td><td valign=""middle"">&nbsp;</td><td align=""center"" valign=""middle"">&nbsp;</td><td valign=""middle"">&nbsp;</td></tr>")
        strBodyText.Append("</table> </td><td width=""312"" valign=""top"" bgcolor=""ECECEC""><table border=""0"" cellspacing=""0"" cellpadding=""0""><tr><td height=""450"" valign=""top"" bgcolor=""f7f7f7""><table width=""312"" border=""0"" cellspacing=""0"" cellpadding=""0"">")
        strBodyText.Append("<tr> <td width=""10"" height=""57"">&nbsp;</td><td width=""295"" valign=""top""><div align=""justify""> <p align=""left""><font size=""3"" face=""Tahoma, Arial""><b><font face=""Tahoma"">Dear</font></b><strong> ")
        strBodyText.Append("*Member* ,<font color=""#9E0C0C"" face=""Arial, Helvetica, sans-serif""><br><br></font></strong></font><strong><font color=""#9E0C0C"" face=""Arial, Helvetica, sans-serif""><font size=""2"" face=""Tahoma, Arial"">Thank you</font></font><font color=""747474"" face=""Arial, Helvetica, sans-serif"" size=""2""> ")
        strBodyText.Append("for joining cputrade.cc.<br>We will Email your Sign Up form for you to add your signature  and company seal.<br><br>Your account will be activated upon receipt of the following  documentation:</font></strong></p> </p></div></td>")
        strBodyText.Append("<td width=""10"">&nbsp;</td></tr><tr> <td>&nbsp;</td><td><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td width=""86%""><table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""1"" bgcolor=""FFCC00"">")
        strBodyText.Append("<tr> <td bgcolor=""ffffff""><table width=""100%"" height=""57"" border=""0"" cellpadding=""0"" cellspacing=""2"" bordercolor=""#999999""><tr valign=""top""> <td height=""16"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> ")
        strBodyText.Append("<td height=4></td></tr></table><img src=""http://www.cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td height=""19""><font size=""2"" face=""Arial, Helvetica, sans-serif"">Signup  with your signature and company sea<font size=""3"">l</font></font></td>")
        strBodyText.Append("</tr><tr valign=""top""> <td width=""9%"" height=""16"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr></table>")
        strBodyText.Append("<img src=""http://www.cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td width=""91%"" height=""19""><font size=""2"" face=""Arial, Helvetica, sans-serif"">Copy  Trade License / Certificate of Incorporation ")
        strBodyText.Append(" and your Company details<br></font><font color=""#FF0000"" size=""1"" face=""Arial, Helvetica, sans-serif""><strong>Please Note:</strong> We need this to activate your account</font></td></tr>")
        strBodyText.Append("<tr valign=""top""> <td height=""16"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr></table>")
        strBodyText.Append("<img src=""http://www.cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td height=""19""><font size=""2"" face=""Arial, Helvetica, sans-serif"">Your  Company logo to be emailed to <a href=""mailto:logos@cputrade.cc"">logos@cputrade.cc</a><br>")
        strBodyText.Append("<strong>Please Note:</strong> If we don't  receive your Logo within 7 days, Account will  be Deactivated </font></td></tr></table></td></tr></table></td></tr>")
        strBodyText.Append("<tr> <td align=""center""><font size=""3"" face=""Arial, Helvetica, sans-serif"">&nbsp;</font></td></tr></table></td><td>&nbsp;</td></tr><tr> <td height=""102"">&nbsp;</td><td valign=""top""><div align=""left""><font color=""747474"" size=""3"" face=""Arial, Helvetica, sans-serif""><strong>This ")
        strBodyText.Append(" will help us to create your profile in the member&#8217;s directory.<br><br>After activation, you can avail the following benefits:</strong></font></div></td><td>&nbsp;</td>")
        strBodyText.Append("</tr><tr> <td>&nbsp;</td> <td><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0""> <tr valign=""top""> <td width=""6%"" height=""21"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0"">")
        strBodyText.Append("<tr> <td height=4></td></tr></table><img src=""http://www.cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td width=""94%""><div align=""justify""><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Add  company profile</font></div></td>")
        strBodyText.Append("</tr><tr valign=""top""> <td height=""21"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr></table>")
        strBodyText.Append("<img src=""http://www.cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td><div align=""justify""><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Make global presence in the market</font></div></td>")
        strBodyText.Append("</tr><tr valign=""top""> <td height=""21"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr>")
        strBodyText.Append("</table><img src=""http://www.cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td><div align=""justify""><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Check  the latest Mobiles</font></div></td>")
        strBodyText.Append("</tr><tr valign=""top""> <td height=""21"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr></table>")
        strBodyText.Append("<img src=""http://www.cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td><div align=""justify""><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Browse  the Member&#8217;s Directory</font></div></td>")
        strBodyText.Append("</tr></table></td><td>&nbsp;</td></tr></table></td></tr><tr><td><img src=""http://www.cputrade.cc/Images/thanksmail/right_bot.jpg"" width=""312"" height=""52""></td>")
        strBodyText.Append("</tr></table></td></tr></table></div><br></body></html>")

        Return strBodyText.ToString

    End Function
    Private Function GetPrintForm() As String
        Dim objXMLHTTP, xml
        Dim bodytxt As String
        Try
            xml = CreateObject("Msxml2.ServerXMLHTTP")
            xml.Open("GET", "http://www.cputrade.cc/Print.htm", False)
            xml.Send()

            bodytxt = xml.responseText()
            xml = Nothing
            Return bodytxt
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Function
    Private Function GetPrintFormVersion2() As String
        Dim strPrintForm As New System.Text.StringBuilder
        strPrintForm.Append("<html><head><title>cputrade.cc [Member Details]</title></head><body><table width=""650"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">")
        strPrintForm.Append("<tr><td><img src=""http://www.cputrade.cc/images/email_t1.jpg"" width=""650"" height=""76""></td></tr></table><table width=""650"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""1"" bgcolor=""#666666"">")
        strPrintForm.Append("<tr> <td width=""901"" bgcolor=""#FFFFFF""><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""3""><tr> <td width=""51%"" class=""siz""><font size=""2"" face=""Arial, Helvetica, sans-serif""><strong>Company Details</strong></font></td>")
        strPrintForm.Append("<td width=""49%"" class=""siz""><font size=""2"" face=""Arial, Helvetica, sans-serif""><strong>Personal Details</strong></font></td></tr><tr> <td><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">")
        strPrintForm.Append("<tr> <td height=1 bgcolor=""#999999""></td></tr></table></td><td><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> ")
        strPrintForm.Append("<td height=1 bgcolor=""#999999""></td></tr></table></td></tr><tr> <td height=8></td><td></td></tr><tr> <td valign=""top""><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">")
        strPrintForm.Append("<tr class=""siz""> <td height=""20"" valign=""top""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Company Name</font></strong></td><td height=""20"" valign=""top"">:</td>")
        strPrintForm.Append("<td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*CompanyName*</font></td></tr><tr class=""siz""> <td width=""37%"" height=""20"" valign=""top""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">mailing_address</font></strong></td>")
        strPrintForm.Append("<td width=""4%"" height=""20"" valign=""top"">:</td><td width=""59%"" height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Address*</font></td></tr>")
        strPrintForm.Append("<tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Country</font></strong></td><td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Country*</font></td>")
        strPrintForm.Append("</tr><tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Phone</font></strong></td><td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Phone*</font></td></tr>")
        strPrintForm.Append("<tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Fax</font></strong></td><td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Fax*</font></td></tr>")
        strPrintForm.Append("<tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Email</font></strong></td><td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Email*</font></td></tr>")
        strPrintForm.Append("<tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Company Website</font></strong></td><td height=""20"">:</td>")
        strPrintForm.Append("<td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Website*</font></td></tr></table></td><td valign=""top""><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">")
        strPrintForm.Append("<tr class=""siz""> <td width=""37%"" height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Name</font></strong></td><td width=""4%"" height=""20"">:</td>")
        strPrintForm.Append("<td width=""59%"" height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Name*</font></td></tr><tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Mobile</font></strong></td>")
        strPrintForm.Append("<td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Mobile*</font></td></tr><tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Personal  Email</font></strong></td>")
        strPrintForm.Append("<td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*PersonalEmail*</font></td></tr><tr class=""siz""> <td height=""20"">&nbsp;</td><td height=""20"">&nbsp;</td>")
        strPrintForm.Append("<td height=""20"">&nbsp;</td></tr><tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Second  Contact</font></strong></td>")
        strPrintForm.Append("<td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*SecondContact*</font></td></tr><tr class=""siz""> ")
        strPrintForm.Append("<td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Mobile  No 2</font></strong></td><td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*MobileNo2*</font></td>")
        strPrintForm.Append("</tr><tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Personal Email</font></strong></td>")
        strPrintForm.Append("<td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*PersonalEmail2*</font></td></tr></table></td></tr>")
        strPrintForm.Append("<tr> <td height=""22"" colspan=""2"" valign=""top"">&nbsp;</td></tr><tr> <td height=""22"" colspan=""2"" valign=""top""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Company ")
        strPrintForm.Append("Type</font></strong></td></tr><tr align=""center""> <td height=""22"" colspan=""2"" valign=""top""><table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"">")
        strPrintForm.Append("<tr> <td width=200><font size=""2"" face=""Arial, Helvetica, sans-serif""> *CompanyType*</font></td></tr></table></td></tr>")
        strPrintForm.Append("<tr align=""center""> <td height=""104"" colspan=""2"" valign=""top""> <table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td bgcolor=""#000000"" height=1></td> </tr>")
        strPrintForm.Append("</table><table width=""630"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td colspan=""2"" align=""center"">&nbsp;</td></tr><tr> <td colspan=""2"" align=""center""><font color=""#000000"" size=""2"" face=""Arial, Helvetica, sans-serif""><strong>I ")
        strPrintForm.Append(" agree to the Terms and Conditions</strong></font></td></tr><tr> <td width=""328"" align=""center"">&nbsp;</td><td width=""302"" align=""center"">&nbsp;</td> </tr>")
        strPrintForm.Append("<tr> <td><font color=""#000000"" size=""2"" face=""Arial, Helvetica, sans-serif"">Name:&nbsp;&nbsp;</font><font size=""2"" face=""Arial, Helvetica, sans-serif"" color=""#000000"">_______________________</font></td>  <td><font color=""#000000"" size=""2"" face=""Arial, Helvetica, sans-serif"">Date:&nbsp;&nbsp;_______________</font></td></tr>")
        strPrintForm.Append("<tr> <td>&nbsp;</td><td>&nbsp;</td></tr><tr> <td>&nbsp;</td><td>&nbsp;</td></tr><tr> <td>&nbsp;</td><td>&nbsp;</td></tr>")
        strPrintForm.Append("<tr> <td><font color=""#000000"" size=""2"" face=""Arial, Helvetica, sans-serif"">Signature:</font><font color=""#000000"">&nbsp;&nbsp;<font size=""2"" face=""Arial, Helvetica, sans-serif"">_______________________</font></font></td>")
        strPrintForm.Append("<td><font color=""#000000"" size=""2"" face=""Arial, Helvetica, sans-serif"">Company  Seal</font><font color=""#000000"">:&nbsp;&nbsp;</font></td></tr>")
        strPrintForm.Append("<tr> <td>&nbsp;</td><td>&nbsp;</td></tr><tr> <td>&nbsp;</td><td>&nbsp;</td></tr><tr> <td>&nbsp;</td><td>&nbsp;</td></tr>")
        strPrintForm.Append("</table></td></tr><tr align=""center""> <td height=""80"" colspan=""2"" valign=""middle"" bgcolor=""#0066FF""> <table border=""0"" width=""100%"" id=""table1"">")
        strPrintForm.Append("<tr> <td width=""46"">&nbsp;</td><td><b><font color=""#FFFFFF"" size=""2"" face=""Arial, Helvetica, sans-serif"">1.  Kindly add your signature and company seal <br> 2. Send along with the copy of your Trade License/Certificate ")
        strPrintForm.Append(" of Incorporation <br>3. Fax it to us on [ +971 (4) 2994 492 ]. <br>Company Information and Company Logo to be emailed at logos@cputrade.cc</font></b></td>")
        strPrintForm.Append("<td width=""38"">&nbsp;</td></tr></table></td></tr><tr align=""center""><td height=""80"" colspan=""2"" valign=""middle""><div align=""left""><font size=""2"" face=""Arial, Helvetica, sans-serif"">Kindly ")
        strPrintForm.Append("be in touch with our online support team if you require any help.<br> We are online, on yahoo and msn messengers for our fellow traders.  Simply add us to your messengers.<br> <br>")
        strPrintForm.Append(" Yahoo Messenger: <font color=""#000099""><strong>cputrade_live@yahoo.com</strong></font><br> MSN Messenger:<strong><font color=""#000066""> trading_support@hotmail.com</font></strong><br>")
        strPrintForm.Append("<br><strong>&#8220;Our motive is to help you in better ways.&#8221;</strong> <br><br>Regards,<br>cputrade.cc<br>Web Team<br></font><br></div><br>")
        strPrintForm.Append("<font size=""1"" face=""Arial, Helvetica, sans-serif"">Note: We are sending out  this email, because you or someone on behalf of you have requested<br> To be a member of a leading B2B mobile phone trading website &#8220;cputrade.cc.&#8221;<br>")
        strPrintForm.Append(" Kindly ignore this email/message if you have not request for the new  membership.</font></td></tr></table></td></tr></table></body></html>")
        'strPrintForm.Append("")
        'strPrintForm.Append("")
        Return strPrintForm.ToString
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim msgMail As New MailMessage
        Dim str As String
        str = GetPrintFormVersion2()
        Response.Write(str)
        'msgMail.From = "sales@cputrade.cc"
        'msgMail.To = "basheer@cputrade.cc" 'pi_obj_members.company_email

        'msgMail.Bcc = "basheer@ireuae.com"
        'msgMail.Subject = "cputrade.cc: Member Confirmation!"
        'Try
        '    msgMail.BodyFormat = MailFormat.Html
        '    msgMail.Body = str

        '    SmtpMail.Send(msgMail)
        'Catch ex As Exception
        '    Response.Write(ex.Message)
        'End Try

        Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
        Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 

        Const cdoAnonymous = 0 'Do not authenticate
        Const cdoBasic = 1 'basic (clear-text) authentication
        Const cdoNTLM = 2 'NTLM
        Dim objMessage As Object
        objMessage = CreateObject("CDO.Message")
        objMessage.Subject = "cputrade.cc: Member Confirmation!"
        objMessage.From = "sales@cputrade.cc"
        objMessage.To = "basheer@cputrade.cc"
        objMessage.bcc = "basheer@ireuae.com"
        objMessage.HTMLBody = CStr("" & str)

        '==This section provides the configuration information for the remote SMTP server.

        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2

        'Name or IP of Remote SMTP Server
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "10.4.29.4"

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
    End Sub
End Class
