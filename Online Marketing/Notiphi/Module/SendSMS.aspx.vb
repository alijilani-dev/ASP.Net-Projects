Imports NotiPhi_BL
Imports System
Imports System.IO
Imports System.Net
Imports System.Text


Public Class SendSMS
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtMobile As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtMessage As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSender As System.Web.UI.WebControls.TextBox
    Protected WithEvents chkFlash As System.Web.UI.WebControls.CheckBox
    Protected WithEvents btnSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents hlnkManageContact As System.Web.UI.WebControls.HyperLink
    Protected WithEvents Middle As System.Web.UI.HtmlControls.HtmlTableRow
    Protected WithEvents Table1 As System.Web.UI.HtmlControls.HtmlTable
    Protected WithEvents tdContent As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents hlnkSendSMS As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hlnkFromPhoneBook As System.Web.UI.WebControls.HyperLink
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents rfv1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Requiredfieldvalidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Requiredfieldvalidator2 As System.Web.UI.WebControls.RequiredFieldValidator

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
        'Put user code to initialize the page here
        txtMessage.Attributes.Add("onkeyup", "calcCharLeft('TA')")
        txtMessage.Attributes.Add("onBlur", "calcCharLeft('TA')")
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        SendSMS()

    End Sub

    Sub SendSMS()
        Dim sMobNo As String
        Dim sMessage As String
        Dim sSender As String
        Dim sFlash As String
        Dim sRetCode As String
        Dim oSMS As New clsSMS


        Dim sError As String
        Dim sRetVal As String
        Dim iCharLeft As Integer = 160
        Dim iLength As Integer = 160

        sMobNo = txtMobile.Text.Trim
        sMessage = txtMessage.Text.Trim
        sSender = txtSender.Text.Trim
        sFlash = chkFlash.Checked


        'Mobile Number cannot be null and should be valid one
        If sMobNo = "" Then
            sError = "<li>Mobile Number cannot be blank."
        Else
            sError = sError & oSMS.CheckMobileNos(sMobNo)
        End If

        'Message Cannot be null and not exceed the max length
        If sMessage = "" Or Len(sMessage) > CInt(iLength) Then
            sError = sError & "<li>SMS message cannot be blank and cannot exceed " & _
                  iLength & " characters.</li>"
        End If

        'Sender ID should be 16 digit Numeric or 11 charater alphanumeric
        If IsNumeric(sSender) Then
            If Len(sSender) > 16 Then
                sError = sError & "<li>Sender Name should be maximum of 16 Numeric characters."
            End If
        Else
            If Len(sSender) > 11 Then
                sError = sError & "<li>Sender Name should be maximum of 11 Alphanumeric " & _
                     "characters or 16 Numeric characters.</li>"
            End If
        End If
        If sError = "" Then
            oSMS.From = Server.UrlEncode(sSender)
            oSMS.IsFlash = sFlash

            'If Mutilingual(Arabic or other) unicode remove Line1 comment
            'If hexacode remove Line1 & Line2 Comment	
            'oSMS.SMSType = "MSMS"	'Line1
            'oSMS.UDH = "ISO"		'Line2

            sRetVal = oSMS.SendMessage(sMobNo, Server.UrlEncode(sMessage))
            sRetCode = oSMS.Status
            If InStr(1, sRetVal, "ERROR:", 1) <> 0 Then
                sError = sRetVal
            Else
                Response.Redirect("cfm.asp?" & oSMS.ProcessVal(sRetVal))
            End If
        End If
        oSMS = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Create a request using a URL that can receive a post.  
        Dim request As WebRequest = WebRequest.Create("http://www.netpipersms.com/website/sendsms.asp")
        'Dim request As WebRequest = WebRequest.Create("http://www.mobiphi.com/testpost.asp")
        ' Set the Method property of the request to POST.
        request.Method = "POST"
        ' Create POST data and convert it to a byte array.
        Dim postData As String '= "?id=10"
        postData = "UserName=basheer100" & "&Password=bash100" & "&MobNumber=971504689624" & _
                    "&Message=By the grace of almighty ALLAH. Believers put their trust on ALLAH." & _
                    "&FROM=BASH" & _
                    "&MsgType=SMS" & _
                   "&FLASH=0" & _
                   "&UDH="
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        ' Set the ContentType property of the WebRequest.
        request.ContentType = "application/x-www-form-urlencoded"
        ' Set the ContentLength property of the WebRequest.
        request.ContentLength = byteArray.Length
        ' Get the request stream.
        Dim dataStream As Stream = request.GetRequestStream()
        ' Write the data to the request stream.
        dataStream.Write(byteArray, 0, byteArray.Length)
        ' Close the Stream object.
        dataStream.Close()
        ' Get the response.
        Dim response As WebResponse = request.GetResponse()
        ' Display the status.
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        ' Get the stream containing content returned by the server.
        dataStream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)
        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()
        ' Display the content.
        Console.WriteLine(responseFromServer)
        ' Clean up the streams.
        reader.Close()
        dataStream.Close()
        response.Close()

    End Sub

    'Dim objWebSMS As Object
    'objWebSMS = CreateObject("NPSMSCom.SendSMS")
    'objWebSMS.UserName = "basheer100"
    'objWebSMS.Password = "bash100"
    'objWebSMS.SenderName = "Mohideen"
    'objWebSMS.SaveMessage = True
    'Dim err As String
    'err = objWebSMS.SendMessage(txtMessage.Text.Trim, txtMobile.Text.Trim)

    'Dim acc As String
    'acc = objWebSMS.GetAccountDetails()
End Class
