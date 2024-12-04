''''RESPONSE TEXT: --- Sent: 1#Credits: 1#Units Left: 49 ID: 170906160613962763000 To: 971504689624
Imports System.Web
Imports System.Net
Imports System.IO
Imports System.Text

Public Class clsSMS

    Private sIPA As String
    Private sUID As String
    Private sPWD As String
    Private sFrom As String
    Private sFlash As Boolean
    Private sType As String
    Private sUDH As String
    Private sStatus As String

    Public Sub New()
        sIPA = "http://www.netpipersms.com/website/sendsms.asp" ' DO NOT CHANGE THIS
        sUID = "basheer100" '<Your netpiper sms UserName>
        sPWD = "bash100" '<Your netpiper sms UserName>
        sType = "SMS"
        sFlash = "0"
        sFrom = "NetpiperSMS"
        sUDH = ""
    End Sub

    Public Property UserName() As String
        Get
            Return sUID
        End Get
        Set(ByVal Value As String)
            sUID = Value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return sPWD
        End Get
        Set(ByVal Value As String)
            sPWD = Value
        End Set
    End Property

    Public Property IPAddress() As String
        Get
            Return sIPA
        End Get
        Set(ByVal Value As String)
            sIPA = Value
        End Set
    End Property

    Public Property SMSType() As String
        Get
            Return sType
        End Get
        Set(ByVal Value As String)
            sType = Value
        End Set
    End Property

    Public Property IsFlash() As Boolean
        Get
            Return sFlash
        End Get
        Set(ByVal Value As Boolean)
            sFlash = Value
        End Set
    End Property

    Public Property From() As String
        Get
            Return sFrom
        End Get
        Set(ByVal Value As String)
            sFrom = Value
        End Set
    End Property

    Public Property UDH() As String
        Get
            Return sUDH
        End Get
        Set(ByVal Value As String)
            sUDH = Value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return sStatus
        End Get
        Set(ByVal Value As String)
            sStatus = Value
        End Set
    End Property

    Public Function SendMessage(ByVal sMobNo As String, ByVal sMessage As String)

        Dim sQuery
        Dim sRetVal, iRet

        ''sQuery = "UserName=" & sUID & _
        ''              "&Password=" & sPWD & _
        ''              "&MobNumber=" & sMobNo & _
        ''              "&Message=" & server.URLEncode(sMessage) & _
        ''              "&FROM=" & server.URLEncode(sFrom) & _
        ''              "&MsgType=" & sType & _
        ''     "&FLASH=" & sFlash & _
        ''     "&UDH=" & sUDH

        sQuery = "UserName=" & sUID & _
                     "&Password=" & sPWD & _
                     "&MobNumber=" & sMobNo & _
                     "&Message=" & sMessage & _
                     "&FROM=" & sFrom & _
                     "&MsgType=" & sType & _
                    "&FLASH=" & sFlash & _
                    "&UDH=" & sUDH

        sRetVal = ConnectAndSend(sIPA, sQuery, iRet)

        '''Place to store SMS History

        '''End
        If iRet <> "200" Then
            sRetVal = "ERROR:Could not connect to the SMS server at this time. Please try after some time"
        End If

        sStatus = iRet
        SendMessage = sRetVal

    End Function

    Public Function ConnectAndSend(ByVal sIPAddress As String, ByVal sQuery As String, ByRef iRet As String) As String

        Try
            Dim sRetVal As String
            ' Create a request using a URL that can receive a post.  
            Dim request As WebRequest = WebRequest.Create("http://www.netpipersms.com/website/sendsms.asp")

            ' Set the Method property of the request to POST.
            request.Method = "POST"

            ' Create POST data and convert it to a byte array.
            Dim postData As String = sQuery & "&Store=0"
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
            sRetVal = CType(response, HttpWebResponse).StatusDescription
            Dim reader As StreamReader
            If sRetVal.ToUpper = "OK" Then

                ' Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream()

                ' Open the stream using a StreamReader for easy access.
                reader = New StreamReader(dataStream)

                ' Read the content.
                Dim responseFromServer As String = reader.ReadToEnd()

                ' Display the content.
                sRetVal = responseFromServer
            End If

            ' Clean up the streams.
            reader.Close()
            dataStream.Close()
            response.Close()
            ConnectAndSend = sRetVal

        Catch ex As Exception

        End Try

        ''Dim oXMLHTTP
        ''Dim sRetVal

        ''On Error Resume Next
        '''oXMLHTTP = CreateObject("Msxml2.ServerXMLHTTP")
        ''oXMLHTTP = CreateObject("Microsoft.XMLHTTP")
        '''Dim qry As String = sIPAddress '& "?" & sQuery
        ''oXMLHTTP.open("post", sIPAddress, False)
        ''oXMLHTTP.setRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        ''oXMLHTTP.send(sQuery)

        ''sRetVal = Trim(oXMLHTTP.responseText)
        ''iRet = oXMLHTTP.Status
        ''Return sRetVal

        ''If iRet <> "200" Then
        ''    sRetVal = "ERR: 1001"
        ''ElseIf Err.Number <> 0 Then
        ''    sRetVal = "ERR: 1002"
        ''End If

        ''Err.Clear()
        ''On Error GoTo 0

        'oXMLHTTP = Nothing



    End Function

    Public Function ProcessVal(ByVal sRetVal As String) As String
        Dim arrRetVal, i
        Dim arrLines, vNum, vCode

        arrRetVal = Split(sRetVal, vbLf)
        vNum = ""
        vCode = ""
        For i = 1 To UBound(arrRetVal)
            If arrRetVal(i) <> "" Then
                arrLines = Split(arrRetVal(i), " ")
                vNum = vNum & arrLines(3) & ","
                If InStr(1, arrRetVal(i), "Err:", 1) = 0 Then
                    vCode = vCode & "000,"
                Else
                    vCode = vCode & Trim(arrLines(1)) & ","
                End If
            End If
        Next
        vNum = Mid(vNum, 1, Len(vNum) - 1)
        vCode = Mid(vCode, 1, Len(vCode) - 1)

        ProcessVal = "n=" & vNum & "&c=" & vCode
    End Function

    Public Function CheckMobileNos(ByVal strMobNos As String) As String


        Dim arrMobNos
        Dim intNoOfMobCnt
        Dim strRetVal
        Dim strMobNumber
        Dim i

        On Error Resume Next
        arrMobNos = Split(strMobNos, ",")
        intNoOfMobCnt = UBound(arrMobNos)
        strRetVal = ""

        For i = 0 To intNoOfMobCnt
            strMobNumber = Trim(arrMobNos(i))

            If strMobNumber = "" Or Len(strMobNumber) < 10 Or Len(strMobNumber) > 16 Then
                strRetVal = "<li>One or more mobile numbers invalid.</li>"
            End If

            ' Check if there is any leading 0's 
            If Left(strMobNumber, 1) = "0" And strRetVal = "" Then
                strRetVal = "<li>Mobile number cannot have leading zeroes.</li>"
            End If

            ' Check for special characters if there wasnt any error before
            If (InStr(1, strMobNumber, "+") <> 0 Or InStr(1, strMobNumber, ".") <> 0 Or _
              InStr(1, strMobNumber, "(") <> 0 Or InStr(1, strMobNumber, ")") <> 0) _
                       And strRetVal = "" Then
                strRetVal = "<li>One or more mobile numbers invalid.</li>"
            End If

            ' If there was no error check if the number was numeric
            If Not IsNumeric(strMobNumber) And strRetVal = "" Then
                strRetVal = "<li>One or more mobile numbers invalid.</li>"
            End If

            ' Now if there was any error, exit the loop
            If strRetVal <> "" Then Exit For

        Next
        On Error GoTo 0
        CheckMobileNos = strRetVal
    End Function

    Private Function FormatSMSMessage(ByVal strMessage As String) As String

        Dim strRetVal       ' Return message string after formating

        On Error Resume Next

        ' Convert special characters in the message text
        strRetVal = ""
        Dim i As Integer
        Dim c As Char
        For i = 1 To Len(strMessage)
            c = Mid(strMessage, i, 1)
            Select Case c
                Case "&" : c = "%26"
                Case "+" : c = "%2B"
                Case "%" : c = "%25"
                Case "#" : c = "%23"
                Case "=" : c = "%3D"
                Case " " : c = "%20"
            End Select
            strRetVal = strRetVal + c
        Next

        'Capture error
        If Err.Number <> 0 Then
            strRetVal = strMessage
        End If

        On Error GoTo 0

        'Return the formatted message back to the called function
        FormatSMSMessage = strRetVal


    End Function

    Public Function DecodeError(ByVal sCodeVal As String) As String

        Dim strRetVal

        Select Case Trim(sCodeVal)
            Case "000"
                strRetVal = "Submitted to the Gateway"
            Case "001", "002"
                strRetVal = "Not able to communicate with the Gateway. Report error to the support team - Error Number " & sCodeVal
            Case "003"
                strRetVal = "Communication with the Gateway lost. Report error to the support team - Error Number " & sCodeVal
            Case "004"
                strRetVal = "We are facing technical problem on the Gateway. Try again later - Error Number " & sCodeVal
            Case "005"
                strRetVal = "Not able to communicate with the Gateway. Report error to the support team - Error Number " & sCodeVal
            Case "101"
                strRetVal = "Invalid message formatting. Report error to the support team - Error Number " & sCodeVal
            Case "102"
                strRetVal = "Invalid UDH formatted. Report error to the support team - Error Number " & sCodeVal
            Case "103", "104"
                strRetVal = "Unknown Message ID passed. Report error to the support team - Error Number " & sCodeVal
            Case "105"
                strRetVal = "Invalid Destination address. Check the number and give in International format "
            Case "106"
                strRetVal = "Invalid source address. "
            Case "107"
                strRetVal = "Message cannot be empty. Invalid message formatting. - Error Number " & sCodeVal
            Case "108"
                strRetVal = "Parameter submitted to the gateway is incorrect. - Error Number " & sCodeVal
            Case "109"
                strRetVal = "Missing Message ID. Report error to the support team - Error Number " & sCodeVal
            Case "111"
                strRetVal = "Invalid protocol. Report error to the support team - Error Number " & sCodeVal
            Case "112"
                strRetVal = "Invalid message type. Report error to the support team - Error Number " & sCodeVal
            Case "113"
                strRetVal = "Allowed message length exceeded. Refine your message and try again "
            Case "114"
                strRetVal = "This mobile number is not supported by our Gateway. "
            Case "115"
                strRetVal = "Message Expired. For more details contact our Support Team"
            Case "201"
                strRetVal = "Could not start the batch. Report error to the support team - Error Number " & sCodeVal
            Case "202"
                strRetVal = "Invalid batch message sent. Report error to the support team - Error Number " & sCodeVal
            Case "301"
                strRetVal = "Gateway is temporarily unavailable. Report error to the support team - Error Number " & sCodeVal
            Case "302"
                strRetVal = "You are not allowed to sent more than the allowed quota. Report error to the support team - Error Number " & sCodeVal
            Case "1000"
                strRetVal = "This mobile number is not supported "
            Case "1001"
                strRetVal = "There was a connection problem with the Gateway. Report error to the support team - Error Number " & sCodeVal
            Case "1002"
                strRetVal = "There was a connection problem with the Gateway. Report error to the support team - Error Number " & sCodeVal
            Case Else
                strRetVal = "Unknown error occured. Report error to the support team - Error Number " & sCodeVal
        End Select

        DecodeError = strRetVal

    End Function

End Class
