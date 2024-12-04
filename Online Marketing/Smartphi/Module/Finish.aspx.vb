Imports SmartPhi_BL
Imports System.Text
Imports System.Web.Mail

Public Class Finish
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents rdoTest As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rdoSchedule As System.Web.UI.WebControls.RadioButton
    Protected WithEvents btnNext As System.Web.UI.WebControls.Button
    Protected WithEvents tdContent As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents btnTest As System.Web.UI.WebControls.Button
    Protected WithEvents txtEmailID3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmailID2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtEmailID1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnSchedule As System.Web.UI.WebControls.Button
    Protected WithEvents ddlMin As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlHour As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlYear As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlDay As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlMonth As System.Web.UI.WebControls.DropDownList
    Protected WithEvents tblSchedule As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tblTest As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents rfvEmailID1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents ddlGroupName As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtValidDate As System.Web.UI.WebControls.TextBox
    Protected WithEvents revDate As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents lblConfirm As System.Web.UI.WebControls.Label
    Protected WithEvents lstGroup As System.Web.UI.WebControls.ListBox
    Protected WithEvents hlnkTrackRpt As System.Web.UI.WebControls.HyperLink
    Protected WithEvents Middle As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents Table1 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents Table3 As System.Web.UI.HtmlControls.HtmlTable

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Private variable"
    'Private pi_ctrl_Schedule As ScheduleControl#
    Private pi_obj_Member As New clsMember
    Private pi_obj_Param As New clsParameter
    Private pi_obj_Campaign As New clsCampaign
    Private pi_obj_Group As New clsGroup
    Private pi_obj_Contact As New clsContact
    Private pi_obj_Schedule As New clsSchedule
    Private pi_obj_MailingList As New clsMailingList
    Private pi_str_Subject As String
#End Region

    Property Subject() As String
        Get
            Return pi_str_Subject
        End Get
        Set(ByVal Value As String)
            pi_str_Subject = Value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (CInt(Session(Session_str_MemberID)) = 0 Or Session(Session_str_MemberID) Is Nothing) Then
            Response.Redirect("..\Login.aspx")
        End If

        If Page.IsPostBack Then
            tblSchedule.Visible = rdoSchedule.Checked
            tblTest.Visible = Not rdoSchedule.Checked
        Else
            tblSchedule.Visible = False
            tblTest.Visible = False
        End If

        ddlMonth.Attributes.Add("onChange", "javascript:GetDate();")
        ddlDay.Attributes.Add("onChange", "javascript:GetDate();")
        ddlYear.Attributes.Add("onChange", "javascript:GetDate();")
        ddlHour.Attributes.Add("onChange", "javascript:GetDate();")
        ddlMin.Attributes.Add("onChange", "javascript:GetDate();")

    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click

        tblSchedule.Visible = rdoSchedule.Checked
        tblTest.Visible = Not rdoSchedule.Checked

        If rdoSchedule.Checked Then
            LoadGroupNames()
            LoadDefaultDatevalues()
        End If

    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click

        Dim strTemplate As String
        strTemplate = GenerateHTMLContent(Session(Session_str_CampaginID))
        SendCampaignMail(strTemplate)
        lblConfirm.Text = "Test Mails have been sent Successfully"
        lblConfirm.Visible = True

    End Sub

    Private Sub btnSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchedule.Click

        Dim strGroupID, strTemplate As String

        If revDate.IsValid Then

            strGroupID = ""
            For Each lstItem As ListItem In lstGroup.Items
                If lstItem.Selected Then strGroupID = strGroupID & "," & lstItem.Value
            Next

            pi_obj_Schedule.CampaignID = Session(Session_str_CampaginID)
            pi_obj_Schedule.GroupID = strGroupID 'ddlGroupName.SelectedValue
            pi_obj_Schedule.ScheduledDateTime = CDate(txtValidDate.Text)
            pi_obj_Schedule.StatusSend = 0 'Scheduled
            pi_obj_Schedule.GroupID = Mid(strGroupID, 2)

            If pi_obj_Schedule.Update(1) = True Then
                lblConfirm.Visible = True
                lblConfirm.Text = "The campaign has been scheduled proeprly."
                '''Only update the value in the Schedule database table, the scheduling will takes place in 
                ''SendScheduledMails.aspx
                'strTemplate = GenerateHTMLContent(Session(Session_str_CampaginID))
                'SendCampaignMailToGroup(strTemplate, Mid(pi_obj_Schedule.ReturnScheduleids, 2), Mid(strGroupID, 2), Me.Subject)
            End If

        End If

    End Sub

    Private Function GenerateHTMLContent(ByVal prmCampaignId As Integer) As String

        Dim dt As New DataTable
        Dim nTemplateId As Integer
        Dim strTemplatePath As String
        Dim dtValues As DataTable
        Dim dr As DataRow
        Dim i, j As Integer
        Dim strMode As String

        Try
            dt = pi_obj_Campaign.GetCampaignTemplate(prmCampaignId)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

        If dt.Rows.Count > 0 Then
            nTemplateId = CInt(dt.Rows(0)("TemplateID").ToString())
            strTemplatePath = dt.Rows(0)("TemplatePath").ToString()
            Me.Subject = dt.Rows(0)("Subject").ToString()

        End If

        Dim strPath As String = Server.MapPath("~")
        Dim file As New System.IO.StreamReader(strPath & "\Templates\" & strTemplatePath)
        Dim words As String = file.ReadToEnd()
        file.Close()

        Try
            dt = pi_obj_Param.GetCampaignParamValues(prmCampaignId, nTemplateId) '''Get the edited values for the specified ntemplateid
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

        Dim StrBasePath As String = ConfigurationSettings.AppSettings("BasePath").ToString()

        If (dt.Rows.Count > 0) Then
            '--------------------------------------------------------
            For i = 0 To dt.Rows.Count - 1
                dr = dt.Rows(i)
                If (dr("ParamValue").ToString() <> "") Then
                    ' CASE For each ParamTypeId
                    '--------------
                    Select Case CType(dr("ParamTypeID").ToString(), Integer)
                        'Case 1 ' Text
                        'Case 2 ' Link
                    Case 3 ' ImagePath
                            Dim strID, strImgPath As String
                            Dim chrComma As Char = Chr(44)
                            Dim nCommaIndex As Integer = dr("ParamValue").ToString().IndexOf(chrComma)
                            strID = dr("ParamValue").ToString().Substring(0, nCommaIndex)
                            strImgPath = dr("ParamValue").ToString().Substring(nCommaIndex + 1, dr("ParamValue").ToString().Length - nCommaIndex - 1)
                            strImgPath = StrBasePath + strImgPath.TrimStart(Chr(46))
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", String.Format(str_ImagePath_Format, strID, strImgPath)) 'dr("ParamValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString()))
                        Case 4 ' ImagePath
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", HttpUtility.HtmlDecode(dr("ParamValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString())))
                        Case Else ' Content
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString()))
                    End Select
                    '-------------
                    words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", "")
                Else
                    words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", "")
                    words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", "")
                End If
            Next
            '--------------------------------------------------------
            ' Params Without values
            Try
                dt = pi_obj_Param.GetParameterValues(nTemplateId) '/*HARDCODED*/
            Catch ex As Exception
                strMode = String.Empty
            End Try
            If (dt.Rows.Count > 0) Then

                For j = 0 To dt.Rows.Count - 1
                    dr = dt.Rows(j)
                    words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", "")     ' Insert No Value
                    words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", "")   ' Insert No Value
                Next

            End If
            ' Prams Without values
        Else
            ' New Campaign (Having no params values.)
            Try
                dt = pi_obj_Param.GetParameterValues(nTemplateId) '/*HARDCODED*/
            Catch ex As Exception
                strMode = String.Empty
            End Try
            If (dt.Rows.Count > 0) Then

                For i = 0 To dt.Rows.Count - 1
                    dr = dt.Rows(i)
                    words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", "")     ' Insert No Value
                    words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", "")   ' Insert No Value
                Next

            End If

        End If

        Return words.ToString()

    End Function

    Private Function SendCampaignMail(ByVal strHTML As String) As Boolean

        Dim msgMail As New MailMessage
        Dim strTo1, strTo2, strTo3 As String

        strTo1 = txtEmailID1.Text.Trim
        strTo2 = txtEmailID2.Text.Trim
        strTo3 = txtEmailID3.Text.Trim

        If strTo1.Length > 0 Then
            SendTestMails(strHTML, strTo1)
        End If

        If strTo2.Length > 0 Then
            SendTestMails(strHTML, strTo2)
        End If

        If strTo3.Length > 0 Then
            SendTestMails(strHTML, strTo3)
        End If

    End Function

    Function SendTestMails(ByVal strHTML As String, ByVal strToEmailID As String) As Boolean

        Dim dtMember As DataTable
        Dim strFromMailId, strSMTPserver, strSMTPusername, strSMTPpassword, strSMTPport As String

        Try
            dtMember = pi_obj_Member.GetMembers(Session(Session_str_MemberID))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

        If dtMember.Rows.Count > 0 Then
            strFromMailId = dtMember.Rows(0)("EmailID")
            strSMTPserver = dtMember.Rows(0)("SMTPserver")
            strSMTPusername = dtMember.Rows(0)("SMTPusername")
            strSMTPpassword = dtMember.Rows(0)("SMTPpassword")
            strSMTPport = dtMember.Rows(0)("SMTPport")

            Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
            Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 
            Const cdoAnonymous = 0 'Do not authenticate
            Const cdoBasic = 1 'basic (clear-text) authentication
            Const cdoNTLM = 2 'NTLM

            Dim objMessage As Object
            objMessage = CreateObject("CDO.Message")
            objMessage.Subject = "Test SmartPhi Campaign "
            objMessage.From = strFromMailId
            objMessage.To = strToEmailID

            ''Inserint the mail body content as html
            objMessage.HTMLBody = CStr("" & strHTML)

            'This section provides the configuration information for the remote SMTP server.

            objMessage.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2

            'Name or IP of Remote SMTP Server
            objMessage.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/smtpserver") = strSMTPserver

            'Type of authentication, NONE, Basic (Base64 encoded), NTLM
            objMessage.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate") = cdoBasic

            'Your UserID on the SMTP server
            objMessage.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/sendusername") = strSMTPusername

            'Your password on the SMTP server
            objMessage.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/sendpassword") = strSMTPpassword

            'Server port (typically 25)
            objMessage.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = strSMTPport

            'Use SSL for the connection (False or True)
            objMessage.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = False

            objMessage.Configuration.Fields.Update()

            'End remote SMTP server configuration section==

            objMessage.Send()
            objMessage = Nothing
        End If

    End Function

    Private Function SendCampaignMailToGroup(ByVal strHTML As String, ByVal strSchedule As String, ByVal strGroup As String, ByVal strSubject As String) As Boolean

        Dim msgMail As New MailMessage
        Dim strTo As String
        Dim dt As DataTable
        Dim strGroupID As Integer
        Dim arrScheduleID As Array = Split(strSchedule, ",")
        Dim i As Integer = 0
        Dim strTrack As String
        Try
            If Not strGroup Is Nothing Then
                For Each strGroupID In Split(strGroup, ",")
                    dt = pi_obj_Contact.GetGroupContact(Session(Session_str_MemberID), strGroupID)
                    For Each dr As DataRow In dt.Rows
                        strTrack = ""
                        strTo = dr("ContactEmailID")
                        If strTo.Length > 0 Then
                            strTrack = "camid=" & Session(Session_str_CampaginID) & _
                                        "&schid=" & arrScheduleID(i) & _
                                        "&contid=" & dr("ContactID") & "&sess=" & Session.SessionID
                            'Send the mail
                            msgMail.From = "basheer@skyphi.com"
                            msgMail.To = strTo
                            msgMail.Subject = strSubject
                            msgMail.BodyFormat = MailFormat.Html
                            msgMail.Body = Replace(strHTML, "[$track$]", strTrack) ''''[$track$]
                            SmtpMail.Send(msgMail)

                            'Update the reporting table with ids
                            pi_obj_MailingList.CampaignID = Session(Session_str_CampaginID)
                            pi_obj_MailingList.ContactID = dr("ContactID")
                            pi_obj_MailingList.ScheduleID = arrScheduleID(i)
                            If pi_obj_MailingList.Update(1) Then

                            End If
                        End If
                    Next
                    i = i + 1
                Next
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.Write(ex.Message)
        End Try

        '****************Un comment these line before upload
        'Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
        'Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 
        'Const cdoAnonymous = 0 'Do not authenticate
        'Const cdoBasic = 1 'basic (clear-text) authentication
        'Const cdoNTLM = 2 'NTLM

        'Dim objMessage As Object
        'objMessage = CreateObject("CDO.Message")
        'objMessage.Subject = "Thank you for joining cputrade.cc."
        'objMessage.From = "sales@cputrade.cc"
        'objMessage.To = "abash2002@yahoo.com"
        'objMessage.bcc = "aliakbar@skyphi.com"
        ''Inserint the mail body content as html
        'objMessage.HTMLBody = CStr("" & strHTML)

        '==This section provides the configuration information for the remote SMTP server.

        'objMessage.Configuration.Fields.Item _
        '("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2

        ''Name or IP of Remote SMTP Server
        'objMessage.Configuration.Fields.Item _
        '("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "10.4.29.4"

        ''Type of authentication, NONE, Basic (Base64 encoded), NTLM
        'objMessage.Configuration.Fields.Item _
        '("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate") = cdoBasic

        ''Your UserID on the SMTP server
        'objMessage.Configuration.Fields.Item _
        '("http://schemas.microsoft.com/cdo/configuration/sendusername") = "admin50534137@helpmanzil.com"

        ''Your password on the SMTP server
        'objMessage.Configuration.Fields.Item _
        '("http://schemas.microsoft.com/cdo/configuration/sendpassword") = "admin"

        ''Server port (typically 25)
        'objMessage.Configuration.Fields.Item _
        '("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25

        ''Use SSL for the connection (False or True)
        'objMessage.Configuration.Fields.Item _
        '("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = False

        'objMessage.Configuration.Fields.Update()

        ''==End remote SMTP server configuration section==

        'objMessage.Send()
        'objMessage = Nothing

    End Function

    Private Sub LoadGroupNames()

        Dim dtGroupNames As DataTable
        dtGroupNames = pi_obj_Group.GetGroups(Session(Session_str_MemberID))

        ddlGroupName.DataSource = dtGroupNames
        ddlGroupName.DataBind()
        ddlGroupName.SelectedIndex = 0

        lstGroup.DataSource = dtGroupNames
        lstGroup.DataBind()
        lstGroup.SelectedIndex = 0

    End Sub

    Private Sub LoadDefaultDatevalues()

        Dim arrMonth As New Hashtable
        Dim i As Integer
        For i = DateTime.Now.Month To 12
            arrMonth.Add(i, MonthName(i))
        Next

        ddlMonth.DataSource = arrMonth
        ddlMonth.DataValueField = "Key"
        ddlMonth.DataTextField = "Value"
        ddlMonth.DataBind()

        Dim arrDay As New ArrayList
        For i = 1 To 31
            arrDay.Add(i)
        Next

        ddlDay.DataSource = arrDay
        ddlDay.DataBind()
        arrDay.Clear()

        For i = DateTime.Now.Year To DateTime.Now.Year + 2
            arrDay.Add(i)
        Next

        ddlYear.DataSource = arrDay
        ddlYear.DataBind()

    End Sub

End Class
