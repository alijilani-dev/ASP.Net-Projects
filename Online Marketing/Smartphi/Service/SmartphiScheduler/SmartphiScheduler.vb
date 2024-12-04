Imports System.ServiceProcess
Imports System.Security.Cryptography
Imports System.Text
Imports SmartPhi_BL
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web

Public Class SmartphiScheduler
    Inherits System.ServiceProcess.ServiceBase

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

#Region "Properties"

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
            Return "SmartPhi"
        End Get
    End Property

    'Database User Name 
    Public Shared ReadOnly Property DBUserName() As String
        Get
            Return "SmartPhi"
        End Get
    End Property

    'Database User Password 
    Public Shared ReadOnly Property DBUserPwd() As String
        Get
            Return "phi*Smart*18"
        End Get
    End Property
#End Region

#Region " Component Designer generated code "

    Public Sub New()
        MyBase.New()

        ' This call is required by the Component Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call

    End Sub

    'UserService overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' The main entry point for the process
    <MTAThread()> _
    Shared Sub Main()
        Dim ServicesToRun() As System.ServiceProcess.ServiceBase

        ' More than one NT Service may run within the same process. To add
        ' another service to this process, change the following line to
        ' create a second service object. For example,
        '
        '   ServicesToRun = New System.ServiceProcess.ServiceBase () {New Service1, New MySecondUserService}
        '
        ServicesToRun = New System.ServiceProcess.ServiceBase() {New SmartphiScheduler}

        System.ServiceProcess.ServiceBase.Run(ServicesToRun)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Component Designer
    ' It can be modified using the Component Designer.  
    ' Do not modify it using the code editor.
    Friend WithEvents Timer1 As System.Timers.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Timer1 = New System.Timers.Timer
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 120000
        '
        'SmartphiScheduler
        '
        Me.ServiceName = "SmartphiScheduler"
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        InitDB()

        Timer1.Enabled = True
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        Timer1.Enabled = False
        pi_obj_Campaign = Nothing
        pi_obj_Contact = Nothing
        pi_obj_Group = Nothing
        pi_obj_MailingList = Nothing
        pi_obj_Member = Nothing
        pi_obj_Param = Nothing
        pi_obj_Schedule = Nothing

    End Sub

    '''Initialize database connections
    Private Sub InitDB()
        Dim ls_Server, ls_ProviderType, ls_ConnString As String
        Dim ls_Database, ls_User, ls_Pwd, ls_PoolSize As String

        ' Retrieve information about ADOHelper Class.
        ls_Server = DBServerName 'ConfigurationSettings.AppSettings("Server")
        ls_ProviderType = DBProviderType 'ConfigurationSettings.AppSettings("Type")
        ls_Database = DBName   'ConfigurationSettings.AppSettings("dbase")
        ls_User = DBUserName    'ConfigurationSettings.AppSettings("usr")
        ls_Pwd = DBUserPwd    'ConfigurationSettings.AppSettings("pwd")
        ls_PoolSize = DBPoolSize

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

    '''Sends Scheduled Mails 
    Private Sub SendScheduledMails()
        Dim strMessage As New StringBuilder
        Dim strTemplate As String
        Dim curCamID, prevCamID As String 'The Current & Previous Campaign name

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

            SendCampaignMailToGroup(strTemplate, strMemberID, curCamID, strScheduleID, strGroupID, Me.Subject)
        Next

        strMessage = Nothing
    End Sub

    ''Generate HTML content for the passed Campaign ID
    Private Function GenerateHTMLContent(ByVal prmCampaignId As Integer) As String
        Dim dt As New DataTable
        Dim nTemplateId As Integer
        Dim strTemplatePath As String
        Dim dtValues As DataTable
        Dim dr As DataRow
        Dim i, j As Integer
        Dim strMode As String
        Dim StrBasePath As String = ConfigurationSettings.AppSettings("BasePath").ToString()

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

        Dim file As New System.IO.StreamReader(StrBasePath & "\Templates\" & strTemplatePath)
        Dim words As String = file.ReadToEnd()
        file.Close()

        Try
            dt = pi_obj_Param.GetCampaignParamValues(prmCampaignId, nTemplateId) '''Get the edited values for the specified ntemplateid
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try



        If (dt.Rows.Count > 0) Then
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
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", String.Format(str_ImagePath_Format, strID, strImgPath))
                        Case 4 ' ImagePath
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", HttpUtility.HtmlDecode(dr("ParamValue").ToString().Trim()))
                        Case Else ' Content
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamValue").ToString().Trim())
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

        'place unsubscribe information for the user
        Dim strUnsubscribe As String
        strUnsubscribe = "<table width='98%' border='0' cellspacing='0' cellpadding='0'>" & _
                "<tr><td>To unsubscribe from the mailing list <a href='" + StrBasePath + "/Module/Unsubscribe.aspx?[$track$]'>click here</a></td>" & _
                "<td>&nbsp;</td></tr></table></body>"

        words = words.Replace("</body>", strUnsubscribe)

        Return words.ToString()

    End Function

    '''Send Campaign mails to selected Group
    Private Function SendCampaignMailToGroup(ByVal strHTML As String, ByVal strMember As String, ByVal strCampaign As String, ByVal strSchedule As String, ByVal strGroup As String, ByVal strSubject As String) As Boolean

        'Dim msgMail As New MailMessage
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
                                            "&contid=" & dr("ContactID") & "&sess=2" '& 'Session.SessionID

                                'Send the mail
                                'msgMail.From = "basheer@skyphi.com"
                                'msgMail.To = strTo
                                'msgMail.Subject = strSubject
                                'msgMail.BodyFormat = MailFormat.Html

                                'Replace the mail body with Campaign ID, schid, contact id to gen.track report status
                                'msgMail.Body = Replace(strHTML, "[$track$]", strTrack) ''''[$track$]
                                'SmtpMail.Send(msgMail)

                                'Mail sending code with smtp settion 

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
                                'End of mail sending code
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
                    Next '''Repeat for each row

                    '''Update the Schdule as mail send
                    pi_obj_Schedule.UpdateScheduleSendStatus(CInt(arrScheduleID(i)))
                    ''' end
                    i = i + 1
                Next '''repeat for no of groups
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.Write(ex.Message)
            'Response.Write(ex.Message & "<BR>")
        End Try

    End Function

    Private Sub Timer1_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timer1.Elapsed
        Dim MyLog As New EventLog   ' create a new event log 
        ' Check if the the Event Log Exists 
        If Not MyLog.SourceExists("SmartphiScheduler") Then
            MyLog.CreateEventSource("SmartphiScheduler", "SmartphiScheduler Log") ' Create Log 
        End If
        MyLog.Source = "SmartphiScheduler"
        ' Write to the Log 
        MyLog.WriteEntry("SmartphiScheduler Log", "This is log on " & _
        CStr(TimeOfDay), EventLogEntryType.Information)

        SendScheduledMails()

    End Sub
End Class
