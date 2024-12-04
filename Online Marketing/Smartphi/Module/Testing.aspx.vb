Imports SmartPhi_BL
Imports CDO

Public Class Testing
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents txtSubject As System.Web.UI.WebControls.TextBox

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Private pi_obj_Member As New clsMember
    Private pi_obj_Param As New clsParameter
    Private pi_obj_Campaign As New clsCampaign

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

    End Sub
    Sub test()
        Dim strTemplate As String
        'Session(Session_str_CampaginID) = 1
        strTemplate = GenerateHTMLContent(187)
        SendCampaignMail(strTemplate)
        ' Response.Write("Welcome")
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
            'For i = 0 To dt.Rows.Count - 1
            '    dr = dt.Rows(i)
            '    words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamValue").ToString().Trim())
            '    words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", String.Empty)
            '    'words = words.Replace("<*$" & dr("ParamName").ToString().Trim() & "/$*>", dr("ParamEditValue").ToString().Trim())
            'Next
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
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", HttpUtility.HtmlDecode(dr("ParamValue").ToString().Trim().Replace("{*0*}", 187)))
                        Case Else ' Content
                            words = words.Replace("<$" & dr("ParamName").ToString().Trim() & "/$>", dr("ParamValue").ToString().Trim().Replace("{*0*}", 187))
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
        'spnContent.InnerHtml = words.ToString()

    End Function

    Private Function SendCampaignMail(ByVal strHTML As String) As Boolean

        Dim strTo1 As String

        strTo1 = TextBox1.Text '"basheer@skyphi.com"

        If strTo1.Length > 0 Then
            SendTestMails(strHTML, strTo1)
        End If

    End Function

    Function SendTestMails(ByVal strHTML As String, ByVal strToEmailID As String) As Boolean

        Dim dtMember As DataTable
        Dim strFromMailId, strSMTPserver, strSMTPusername, strSMTPpassword, strSMTPport As String


        strFromMailId = "aliakbar@skyphi.com"
        strSMTPserver = "213.42.18.90" '"10.4.29.4"
        strSMTPusername = "admin50534137@helpmanzil.com"
            strSMTPpassword = "admin"
            strSMTPport = "25"
            ''strFromMailId = dtMember.Rows(0)("EmailID")
            ''strSMTPserver = dtMember.Rows(0)("SMTPserver")
            ''strSMTPusername = dtMember.Rows(0)("SMTPusername")
            ''strSMTPpassword = dtMember.Rows(0)("SMTPpassword")
            ''strSMTPport = dtMember.Rows(0)("SMTPport")

            Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
            Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 

            Const cdoAnonymous = 0 'Do not authenticate
            Const cdoBasic = 1 'basic (clear-text) authentication
            Const cdoNTLM = 2 'NTLM

            Dim objMessage As Object
            objMessage = CreateObject("CDO.Message")
        objMessage.Subject = txtSubject.Text '"This is 2nd teting Sep102006 5:39"
        objMessage.From = strFromMailId
        objMessage.To = strToEmailID
        objMessage.ReplyTo = strToEmailID
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
            ("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25 'strSMTPport

            'Use SSL for the connection (False or True)
            objMessage.Configuration.Fields.Item _
            ("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = False

        objMessage.fields("urn:schemas:mailheader:disposition-notification-to") = "basheer@skyphi.com"
        objMessage.fields("urn:schemas:mailheader:return-receipt-to") = "basheer@skyphi.com"
        objMessage.fields("urn:schemas:mailheader:return-path") = "basheer@skyphi.com"
        objMessage.fields("urn:schemas:mailheader:sender") = strFromMailId
        ' objMessage.DSNOptions = CdoDSNOptions.cdoDSNFailure 'cdoDSNSuccessFailOrDelay
        objMessage.DSNOptions = 14

            objMessage.Configuration.Fields.Update()

            '==End remote SMTP server configuration section==
            Try
            objMessage.Send()
            Response.Write("Mail Sent")
            Catch ex As Exception
            'Dim lException As Exception
            'lException = ex.GetBaseException()
            Response.Write(ex.Message)
                System.Diagnostics.Debug.WriteLine(ex.Message)
            End Try

            objMessage = Nothing


    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        test()
    End Sub
End Class
