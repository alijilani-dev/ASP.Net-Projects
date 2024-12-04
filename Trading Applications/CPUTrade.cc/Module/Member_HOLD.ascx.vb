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
    Protected WithEvents DLDealingIn As System.Web.UI.WebControls.DataList
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
    Private Sub SendWellComeMail(ByVal pi_obj_members As Trade_BL.Member)
        Dim objXMLHTTP, xml
        Dim strMailContent As String
        Try
            xml = CreateObject("Msxml2.ServerXMLHTTP")
            ' Notice the two changes in the next two lines:
            xml.Open("GET", "http://mobiphi.com/mailtemplate.htm", False)
            xml.Send()
            strMailContent = xml.responseText()
            xml = Nothing

            strMailContent = strMailContent.Replace("< UserName >", "<font color = '#FF0000'>" & pi_obj_members.member_id & " </font>")

            Dim mlMsg As New MailMessage
            mlMsg.From = "aliakbar@skiphi.com"
            mlMsg.To = "aliphonetrade@hotmail.com"
            'mlMsg.Bcc = "malik@skyphi.com"
            mlMsg.BodyFormat = MailFormat.Html
            mlMsg.Subject = "Phone Trade Enquiry ...."
            mlMsg.Body = strMailContent
            'mlMsg.Attachments.Add(New MailAttachment("c:\Roses.jpg"))
            ''mlMsg.Attachments.Add(New MailAttachment(Request.MapPath("http://www.phonetrade.cc/thanksmail/logo.jpg")))
            Mail.SmtpMail.SmtpServer = ""
            Mail.SmtpMail.Send(mlMsg)
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Private Sub SendWellComeForm(ByVal pi_obj_members As Trade_BL.Member)

        Dim objXMLHTTP, xml
        Dim strMailContent As String
        Try
            xml = CreateObject("Msxml2.ServerXMLHTTP")
            ' Notice the two changes in the next two lines:
            xml.Open("GET", "http://www.mobiphi.com/Print.htm", False)
            xml.Send()
            strMailContent = xml.responseText()
            xml = Nothing
            strMailContent = strMailContent.Replace("< CompanyName >", "<font color = '#FF0000'>" & pi_obj_members.member_id & " </font>")
            strMailContent = strMailContent.Replace("< Address >", "<font color = '#FF0000'>" & pi_obj_members.mailing_address & " </font>")
            strMailContent = strMailContent.Replace("< Country >", "<font color = '#FF0000'>" & DDLCountry.SelectedItem.Text & " </font>")
            strMailContent = strMailContent.Replace("< Phone >", "<font color = '#FF0000'>" & pi_obj_members.company_phone & " </font>")
            strMailContent = strMailContent.Replace("< Fax >", "<font color = '#FF0000'>" & pi_obj_members.company_fax & " </font>")
            strMailContent = strMailContent.Replace("< Email >", "<font color = '#FF0000'>" & pi_obj_members.company_email & " </font>")
            strMailContent = strMailContent.Replace("< Website >", "<font color = '#FF0000'>" & pi_obj_members.company_website & " </font>")
            strMailContent = strMailContent.Replace("< Name >", "<font color = '#FF0000'>" & pi_obj_members.company_contact2_name & " </font>")
            strMailContent = strMailContent.Replace("< Mobile >", "<font color = '#FF0000'>" & pi_obj_members.company_contact1_mobile & " </font>")
            strMailContent = strMailContent.Replace("< PersonalEmail >", "<font color = '#FF0000'>" & pi_obj_members.company_contact1_email & " </font>")
            strMailContent = strMailContent.Replace("< SecondContact >", "<font color = '#FF0000'>" & pi_obj_members.company_contact2_name & " </font>")
            strMailContent = strMailContent.Replace("< MobileNo2 >", "<font color = '#FF0000'>" & pi_obj_members.company_contact2_mobile & " </font>")
            strMailContent = strMailContent.Replace("< PersonalEmail2 >", "<font color = '#FF0000'>" & pi_obj_members.company_contact2_email & " </font>")
            Dim i As Integer
            Dim strCompanyType As String = New String("")

            For i = 0 To pi_obj_members.Trading_Cat.Rows.Count
                strCompanyType = strCompanyType & "<TR><TD>" & pi_obj_members.Trading_Cat.Rows(1)(0) & "</TD></TR>"
            Next

            strMailContent = strMailContent.Replace("< %CompanyType% >", strCompanyType)

            Dim mlMsg As New MailMessage
            mlMsg.From = "info@phonetrade.cc"
            mlMsg.To = "aliphonetrade@hotmail.com"
            'mlMsg.Bcc = "malik@skyphi.com"
            mlMsg.BodyFormat = MailFormat.Html
            mlMsg.Subject = "Phone Trade Enquiry ...."
            mlMsg.Body = strMailContent
            ''mlMsg.Attachments.Add(New MailAttachment(Request.MapPath("http://www.phonetrade.cc/thanksmail/logo.jpg")))
            Mail.SmtpMail.SmtpServer = ""
            Mail.SmtpMail.Send(mlMsg)
            Response.Write("Sent")
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
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
End Class
