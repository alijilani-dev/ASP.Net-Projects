Imports System.Security.Cryptography
Imports System.Text
Imports SmartPhi_BL
Imports System.Web.Mail
Public Class SendScheduledMails
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents tdMessage As System.Web.UI.HtmlControls.HtmlTableCell

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Private Variable"
    'Private pi_ctrl_Schedule As ScheduleControl
    Private pi_obj_Member As New clsMember
    Private pi_obj_Param As New clsParameter
    Private pi_obj_Campaign As New clsCampaign
    Private pi_obj_Group As New clsGroup
    Private pi_obj_Contact As New clsContact
    Private pi_obj_Schedule As New clsSchedule
    Private pi_obj_MailingList As New clsMailingList
    Private pi_str_Subject As String
    Private pi_str_FromMailID As String
    Private pi_str_GUID As String

#End Region

#Region "Private Properties"

    Property Subject() As String
        Get
            Return pi_str_Subject
        End Get
        Set(ByVal Value As String)
            pi_str_Subject = Value
        End Set
    End Property

    Property FromMailID() As String
        Get
            Return pi_str_FromMailID
        End Get
        Set(ByVal Value As String)
            pi_str_FromMailID = Value
        End Set
    End Property

    Property GUID() As String
        Get
            Return pi_str_GUID
        End Get
        Set(ByVal Value As String)
            pi_str_GUID = Value
        End Set
    End Property

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SendScheduledMails()

    End Sub

    Private Sub SendScheduledMails()
        Dim strMessage As New StringBuilder
        Dim strTemplate As String
        Dim curCamID, prevCamID As String 'The Current & Previous Campaign name
        Dim row As TableRow
        Dim i As Integer = 0
        Dim dt As DataTable

        strMessage.Append("Now :" & DateTime.Now.ToString & "<br>")
        dt = pi_obj_Schedule.GetSchedule(DateTime.Now)
        strMessage.Append("Records scheduled:" & dt.Rows.Count.ToString & "<br>")
        'Loop through the rows of the DataTable
        For i = 0 To dt.Rows.Count - 1
            curCamID = dt.Rows(i).Item("CampaignID")
            If curCamID <> prevCamID Then
                prevCamID = curCamID
                strTemplate = GenerateHTMLContent(curCamID)
            End If

            Dim strMemberID, strScheduleID, strGroupID As String

            strMemberID = dt.Rows(i).Item("MemberID")
            strScheduleID = dt.Rows(i).Item("ScheduleID")
            strGroupID = dt.Rows(i).Item("GroupID")

            strMessage.Append("Memb: " & strMemberID.ToString & ", Schedule:" & strScheduleID.ToString & ",GroupID:" & strGroupID.ToString & "<BR>")

            Dim pi_obj_Mail As New clsMail

            pi_obj_Mail.SendCampaignMailToGroup(strTemplate, strMemberID, curCamID, _
                Me.GUID, strScheduleID, strGroupID, Me.Subject, Session.SessionID)

            'SendCampaignMailToGroup(strTemplate, strMemberID, curCamID, strScheduleID, strGroupID, Me.Subject)
            Response.Write("Email Successfully Sent.")
        Next
        tdMessage.InnerHtml = strMessage.ToString
        strMessage = Nothing
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
            dt = pi_obj_Campaign.GetCampaignTemplate(prmCampaignId) ''For the passed in CAMPAIGN ID
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

        If dt.Rows.Count > 0 Then
            nTemplateId = CInt(dt.Rows(0)("TemplateID").ToString())
            strTemplatePath = dt.Rows(0)("TemplatePath").ToString()
            Me.Subject = dt.Rows(0)("Subject").ToString()
            Me.GUID = dt.Rows(0)("GUIDNo").ToString()
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

            For i = 0 To dt.Rows.Count - 1
                dr = dt.Rows(i)
                If (dr("ParamValue").ToString() <> "") Then
                    ' CASE For each ParamTypeId
                    '--------------
                    Select Case CType(dr("ParamTypeID").ToString(), Integer)
                        ' Case 1 ' Text
                        ' Case 2 ' Link
                    Case 3 ' ImagePath
                            Dim strID, strImgPath As String
                            Dim chrComma As Char = Chr(44)
                            Dim nCommaIndex As Integer = dr("ParamValue").ToString().IndexOf(chrComma)
                            strID = dr("ParamValue").ToString().Substring(0, nCommaIndex)
                            strImgPath = dr("ParamValue").ToString().Substring(nCommaIndex + 1, dr("ParamValue").ToString().Length - nCommaIndex - 1)
                            strImgPath = StrBasePath + strImgPath.TrimStart(Chr(46))
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", String.Format(str_ImagePath_Format, strID, strImgPath)) 'dr("ParamValue").ToString().Trim().Replace("{*0*}", Session(Session_str_CampaginGUID).ToString()))
                        Case 4 ' ImagePath
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", HttpUtility.HtmlDecode(dr("ParamValue").ToString().Trim())) '.Replace("{*0*}", Session(Session_str_CampaginGUID).ToString())))
                        Case Else ' Content
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamValue").ToString().Trim()) '.Replace("{*0*}", Session(Session_str_CampaginGUID).ToString()))
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

        'Insert tracking asp source if its not present in the Template body
        'Used to track the mail delivery status
        If words.IndexOf("oneby1.asp?[$track$]") = -1 Then
            words = words.Replace("</body>", "<img width='1' height='1' src='" + StrBasePath + "/oneby1.asp?[$track$]' alt=''></body>")
        End If

        'Place the online HTML preview page link on top of the HTML content

        Dim strHTMLLink As String
        strHTMLLink = "<table width='98%' border='0' cellspacing='0' cellpadding='0' align='center'>" & _
                "<tr><td align='center'>If you are not clearly viewing this, <a href='" + StrBasePath + "/Module/PreviewOnline.aspx?[$track$]'>click to view</a></td>" & _
                "<td>&nbsp;</td></tr></table>"

        ' words = words.Replace("<body>", strHTMLLink)

        Dim intPos As Integer
        intPos = InStr(words, "<body")
        If intPos > 0 Then
            Dim intPosGr As Integer
            intPosGr = words.IndexOf(Chr(62), intPos)
            words = words.Insert(intPosGr + 1, strHTMLLink)
        End If

        ' place unsubscribe information for the user
        Dim strUnsubscribe As String
        strUnsubscribe = "<table width='98%' border='0' cellspacing='0' cellpadding='0'>" & _
                "<tr><td>To unsubscribe from the mailing list <a href='" + StrBasePath + "/Module/Unsubscribe.aspx?[$track$]'>click here</a></td>" & _
                "<td>&nbsp;</td></tr></table></body>"

        words = words.Replace("</body>", strUnsubscribe)

        Return words.ToString()

    End Function

    Private Function SendCampaignMailToGroup(ByVal strHTML As String, ByVal strMember As String, ByVal strCampaign As String, ByVal strSchedule As String, ByVal strGroup As String, ByVal strSubject As String) As Boolean

        Dim msgMail As New MailMessage
        Dim strTo As String
        Dim dt As DataTable
        Dim strGroupID As Integer
        Dim arrScheduleID As Array = Split(strSchedule, ",")
        Dim i As Integer = 0
        Dim strTrack As String
        Dim dtMember As DataTable

        'To hold members mail box configuration settings
        Dim strFromMailId, strSMTPserver, strSMTPusername, strSMTPpassword, strSMTPport As String

        Try
            'Get the SMTP setting for the current member
            dtMember = pi_obj_Member.GetMembers(strMember)
            If dtMember.Rows.Count > 0 Then
                strFromMailId = dtMember.Rows(0)("EmailID")
                strSMTPserver = dtMember.Rows(0)("SMTPserver")
                strSMTPusername = dtMember.Rows(0)("SMTPusername")
                strSMTPpassword = dtMember.Rows(0)("SMTPpassword")
                strSMTPport = dtMember.Rows(0)("SMTPport")
            End If
            ' end of process
        Catch ex As Exception
            System.Diagnostics.Debug.Write(ex.Message)
        End Try

        Try
            If Not strGroup Is Nothing Then
                For Each strGroupID In Split(strGroup, ",")
                    dt = pi_obj_Contact.GetGroupContact(strMember, strGroupID)
                    For Each dr As DataRow In dt.Rows
                        If CType(dr("IsActive"), Boolean) Then
                            strTrack = ""
                            strTo = dr("ContactEmailID")
                            If strTo.Length > 0 Then ' strCampaign & _
                                strTrack = "camid=" & Me.GUID & _
                                            "&schid=" & arrScheduleID(i) & _
                                            "&contid=" & dr("ContactID") & "&sess=" & Session.SessionID

                                Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
                                Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 
                                Const cdoAnonymous = 0 'Do not authenticate
                                Const cdoBasic = 1 'basic (clear-text) authentication
                                Const cdoNTLM = 2 'NTLM

                                Dim objMessage As Object
                                objMessage = CreateObject("CDO.Message")
                                objMessage.Subject = strSubject
                                objMessage.From = strFromMailId
                                objMessage.To = strTo

                                'Inserint the mail body content as html
                                'Replace the mail body with Campaign ID, schid, contact id to gen.track report status
                                objMessage.HTMLBody = CStr("" & Replace(strHTML, "[$track$]", strTrack)) ''''[$track$])

                                '==This section provides the configuration information for the remote SMTP server.

                                objMessage.Configuration.Fields.Item _
                                ("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2

                                'Name or IP of Remote SMTP Server
                                objMessage.Configuration.Fields.Item _
                                ("http://schemas.microsoft.com/cdo/configuration/smtpserver") = strSMTPserver '"10.4.29.4"

                                'Type of authentication, NONE, Basic (Base64 encoded), NTLM
                                objMessage.Configuration.Fields.Item _
                                ("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate") = cdoBasic

                                'Your UserID on the SMTP server
                                objMessage.Configuration.Fields.Item _
                                ("http://schemas.microsoft.com/cdo/configuration/sendusername") = strSMTPusername '"admin50534137@helpmanzil.com"

                                'Your password on the SMTP server
                                objMessage.Configuration.Fields.Item _
                                ("http://schemas.microsoft.com/cdo/configuration/sendpassword") = strSMTPpassword '"admin"

                                'Server port (typically 25)
                                objMessage.Configuration.Fields.Item _
                                ("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = CInt(strSMTPport) '25

                                'Use SSL for the connection (False or True)
                                objMessage.Configuration.Fields.Item _
                                ("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = False

                                objMessage.Configuration.Fields.Update()

                                '==End remote SMTP server configuration section==

                                objMessage.Send()
                                objMessage = Nothing
                                ' End of mail sending code
                                ' Response.Write(strTo & "<br>")
                                ' Response.Write(strTrack & "<br>")

                                'Update the reporting table with ids
                                pi_obj_MailingList.CampaignID = strCampaign
                                pi_obj_MailingList.ContactID = dr("ContactID")
                                pi_obj_MailingList.ScheduleID = arrScheduleID(i)
                                'Updating the mailing list table to have track report
                                If pi_obj_MailingList.Update(1) Then

                                End If
                            End If
                        End If
                    Next 'Repeat for each row

                    'Update the Schdule as mail send
                    pi_obj_Schedule.UpdateScheduleSendStatus(CInt(arrScheduleID(i)))
                    'End
                    i = i + 1
                Next 'repeat for no of groups
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.Write(ex.Message)
            'Response.Write(ex.Message & "<BR>")
        End Try

    End Function

End Class
