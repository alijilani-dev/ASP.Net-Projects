Imports SmartPhi_BL

Public Class clsMail
#Region "Private Variables"
    Private pi_str_To As String
    Private pi_str_From As String
    Private pi_int_member_id As Integer
    Private pi_int_campaign_id As Integer
    Private pi_int_schedule_id As Integer
    Private pi_int_group_id As Integer
    Private pi_str_subject As String
    Private pi_str_SMTPServer As String
    Private pi_str_SMTPUserName As String
    Private pi_str_SMTPPassword As String
    Private pi_str_SMTPServerPort As String
    Private pi_str_GUID As String
#End Region
#Region "Properties"

    Public Property ToEmailID() As String
        Get
            Return pi_str_To
        End Get
        Set(ByVal Value As String)
            pi_str_To = Value
        End Set
    End Property

    Public Property FromEmailID() As String
        Get
            Return pi_str_From
        End Get
        Set(ByVal Value As String)
            pi_str_From = Value
        End Set
    End Property

    Public Property MemberID() As Integer
        Get
            Return pi_int_member_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_member_id = Value
        End Set
    End Property

    Public Property CampaignID() As Integer
        Get
            Return pi_int_campaign_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_campaign_id = Value
        End Set
    End Property

    Public Property ScheduleID() As Integer
        Get
            Return pi_int_schedule_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_schedule_id = Value
        End Set
    End Property

    Public Property GroupID() As Integer
        Get
            Return pi_int_group_id
        End Get
        Set(ByVal Value As Integer)
            pi_int_group_id = Value
        End Set
    End Property

    Public Property Subject() As String
        Get
            Return pi_str_subject
        End Get
        Set(ByVal Value As String)
            pi_str_subject = Value
        End Set
    End Property

    Property SMTPServer() As String
        Get
            Return pi_str_SMTPServer
        End Get
        Set(ByVal Value As String)
            pi_str_SMTPServer = Value
        End Set
    End Property

    Property SMTPUserName() As String
        Get
            Return pi_str_SMTPUserName
        End Get
        Set(ByVal Value As String)
            pi_str_SMTPUserName = Value
        End Set
    End Property

    Property SMTPPassword() As String
        Get
            Return pi_str_SMTPPassword
        End Get
        Set(ByVal Value As String)
            pi_str_SMTPPassword = Value
        End Set
    End Property

    Property SMTPServerPort() As String
        Get
            Return pi_str_SMTPServerPort
        End Get
        Set(ByVal Value As String)
            pi_str_SMTPServerPort = Value
        End Set
    End Property

    Public Property GUID() As String
        Get
            Return pi_str_GUID
        End Get
        Set(ByVal Value As String)
            pi_str_GUID = Value
        End Set
    End Property


#End Region

    Public Function SendCampaignMailToGroup(ByVal strHTML As String, ByVal strMember As String, _
            ByVal strCampaign As String, ByVal strCampaignGUID As String, _
            ByVal strSchedule As String, ByVal strGroup As String, _
            ByVal strSubject As String, ByVal strSessionID As String) As Boolean

        Dim pi_obj_Member As New clsMember
        Dim pi_obj_Contact As New clsContact
        Dim pi_obj_MailingList As New clsMailingList
        Dim pi_obj_Schedule As New clsSchedule

        'Dim strTo As String
        Dim dt As DataTable
        Dim strGroupID As Integer
        Dim arrScheduleID As Array = Split(strSchedule, ",")
        Dim i As Integer = 0
        Dim strTrack As String
        Dim dtMember As DataTable

        'To hold members mail box configuration settings
        Dim strFromMailId, strTo, strSMTPserver, strSMTPusername, strSMTPpassword, strSMTPport As String

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
                                strTrack = "camid=" & strCampaignGUID & _
                                            "&schid=" & arrScheduleID(i) & _
                                            "&contid=" & dr("ContactID") & "&sess=" & strSessionID
                                strHTML = Replace(strHTML, "[$track$]", strTrack)

                                'Mail sending code with smtp settion 
                                Dim retValue As Long
                                retValue = SendMail(strHTML, strFromMailId, strTo, strSubject, _
                                    strSMTPserver, strSMTPusername, strSMTPpassword, strSMTPport)
                              
                                'End of mail sending code

                                'Update the reporting table with ids
                                pi_obj_MailingList.CampaignID = strCampaign
                                pi_obj_MailingList.ContactID = dr("ContactID")
                                pi_obj_MailingList.ScheduleID = arrScheduleID(i)

                                'Updating the mailing list table to have track report
                                If pi_obj_MailingList.Update(1) Then

                                End If
                            End If
                        End If
                    Next '''Repeat for each row

                    '''Update the Schdule as mail send
                    pi_obj_Schedule.UpdateScheduleSendStatus(CInt(arrScheduleID(i)))
                    ''' end
                    i = i + 1
                Next '''repeat for no of groups
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.Write(ex.Message)
        End Try

    End Function

    Private Function SendMail(ByVal strHTML As String, ByVal strFromMailId As String, _
            ByVal strToEmailId As String, ByVal strSubject As String, _
            ByVal strSMTPserver As String, ByVal strSMTPusername As String, _
             ByVal strSMTPpassword As String, ByVal strSMTPport As String) As Long

        Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
        Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 
        Const cdoAnonymous = 0 'Do not authenticate
        Const cdoBasic = 1 'basic (clear-text) authentication
        Const cdoNTLM = 2 'NTLM

        Dim objMessage As Object
        objMessage = CreateObject("CDO.Message")
        objMessage.Subject = strSubject
        objMessage.From = strFromMailId
        objMessage.To = strToEmailId

        'Inserint the mail body content as html
        'Replace the mail body with Campaign ID, schid, contact id to gen.track report status
        objMessage.HTMLBody = CStr("" & strHTML)

        '==This section provides the configuration information for the remote SMTP server.

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
        ("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = CInt(strSMTPport)

        'Use SSL for the connection (False or True)
        objMessage.Configuration.Fields.Item _
        ("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = False

        objMessage.Configuration.Fields.Item _
        ("urn:schemas:mailheader:disposition-notification-to") = "basheer@skyphi.com"

        objMessage.Configuration.Fields.Item _
        ("urn:schemas:mailheader:return-path") = "basheer@skyphi.com"


        objMessage.Configuration.Fields.Update()

        '==End remote SMTP server configuration section==
        Try
            objMessage.Send()
            Return 0
        Catch ex As Exception
            Return ex.Message
        End Try

        objMessage = Nothing
    End Function

End Class
