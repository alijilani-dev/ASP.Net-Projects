Imports System.Text.RegularExpressions
Public Class PopMail
    Inherits System.Web.UI.Page
    Protected WithEvents AnswerTable As System.Web.UI.WebControls.Table

    Protected WithEvents MsgCount As System.Web.UI.WebControls.TableCell
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents srv As System.Web.UI.WebControls.TextBox
    Protected WithEvents Usr As System.Web.UI.WebControls.TextBox
    Protected WithEvents Passwd As System.Web.UI.WebControls.TextBox
    Protected WithEvents Answer As System.Web.UI.WebControls.Literal
    Protected WithEvents MsgBoxSize As System.Web.UI.WebControls.TableCell

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Page.IsPostBack Then
            Dim p As New pop3(Srv.Text)

            Dim success As Boolean = False

            success = p.logon(Usr.Text, Passwd.Text)
            If success Then
                Answer.Text = "Logon Successfull"

                'create and array for the mail details
                Dim ma(p.MessageCount) As pop3.MailMessage
                Dim r As TableRow
                Dim c As TableCell
                'cycle through mails, diplsaying size and id
                Dim cnt As Integer
                For cnt = 1 To p.MessageCount
                    'create a new instane of mail in the array
                    ma(cnt) = New pop3.MailMessage
                    ma(cnt).ID = cnt
                    'get the mail message in full
                    p.getMail(ma(cnt))

                    ''Grap the undelivered message subject body
                    If Not ma(cnt).Subject Is Nothing Then
                        Dim strSubject As String
                        strSubject = ma(cnt).Subject
                        If (strSubject.IndexOf("Undeliverable") > 0) Or _
                        (strSubject.IndexOf("failure notice") > 0) Or _
                        (strSubject.IndexOf("Delivery Status Notification (Failure)") > 0) Or _
                         (strSubject.IndexOf("failed recipient") > 0) Then
                            System.Diagnostics.Debug.Write(strSubject)
                            r = New TableRow
                            c = New TableCell
                            c.Text = "Date:"
                            c.HorizontalAlign = HorizontalAlign.Left
                            c.VerticalAlign = VerticalAlign.Top
                            c.Font.Bold = True
                            r.Cells.Add(c)
                            c = New TableCell
                            c.Text = strSubject
                            c.HorizontalAlign = HorizontalAlign.Left
                            c.VerticalAlign = VerticalAlign.Top
                            r.Cells.Add(c)
                            AnswerTable.Rows.Add(r)

                        End If
                    End If

                    If Not ma(cnt).Body Is Nothing Then
                        Dim strBody As String
                        strBody = ma(cnt).Body
                        If (strBody.IndexOf("recipient(s) could not be reached") > 0) Or _
                            (strBody.IndexOf("No such user") > 0) Or _
                            (strBody.IndexOf("Delivery to the following recipients failed") > 0) _
                            Or (strBody.IndexOf("Delivery to the following recipient failed") > 0) Or _
                            (strBody.IndexOf("No such user here by that name") > 0) Or _
                            (strBody.IndexOf("Failed Recipient") > 0) Then

                            System.Diagnostics.Debug.Write(strBody)
                            r = New TableRow
                            c = New TableCell
                            c.Text = "Date:"
                            c.HorizontalAlign = HorizontalAlign.Left
                            c.VerticalAlign = VerticalAlign.Top
                            c.Font.Bold = True
                            r.Cells.Add(c)
                            c = New TableCell
                            c.Text = strBody
                            c.HorizontalAlign = HorizontalAlign.Left
                            c.VerticalAlign = VerticalAlign.Top
                            r.Cells.Add(c)
                            AnswerTable.Rows.Add(r)

                        End If
                    End If
                       

                Next
                'show table
                AnswerTable.Visible = True
            Else
                Answer.Text = "Logon Unsuccessfull"
            End If
            p.logoff()
        End If
    End Sub

    Class pop3
        'class for holding details about each mail
        Public Class MailMessage
            Inherits System.Web.Mail.MailMessage

            Private _ID As Integer = -1
            Property ID() As Integer
                Get
                    Return _ID
                End Get
                Set(ByVal Value As Integer)
                    _ID = Value
                End Set
            End Property

            Private _Size As Integer = -1
            Property Size() As Integer
                Get
                    Return _Size
                End Get
                Set(ByVal Value As Integer)
                    _Size = Value
                End Set
            End Property
        End Class

        Private Function getData() As String
            Dim bData(t.ReceiveBufferSize) As Byte
            getData = ""
            Do
                'get the data
                s.Read(bData, 0, bData.Length)
                getData += System.Text.Encoding.ASCII.GetString(bData)
                'clear byte array for next pass
                bData.Clear(bData, 0, bData.Length)
                'wait for the dataavailble flag to get set
                System.Threading.Thread.Sleep(1000)
                'if there is more data repeat
            Loop While s.DataAvailable
        End Function

        Public Function getHeader(ByRef m As MailMessage) As Boolean
            Dim h As String

            h = SendCmd("top " + m.ID.ToString + " 0")

            'check the command was accepted OK
            If Left(h, 3) = "+OK" Then
                setHeader(m, h)
                Return True
            Else
                Return False
            End If
        End Function

        Public Function getMail(ByRef m As MailMessage) As Boolean
            Dim msg As String
            Dim hend As Integer

            'make sure the buffer is big enough to hold the message.
            'to be sure make it just a little bigger
            't.ReceiveBufferSize = m.Size
            msg = SendCmd("retr " + m.ID.ToString + "") '" 0")

            'check the command was accepted OK
            If Left(msg, 3) = "+OK" Then
                'find the end of the header.
                'this is denoted by the first empty line in the message
                hend = msg.IndexOf(vbCrLf + vbCrLf)

                'set the header
                setHeader(m, Left(msg, hend))

                'set the mail body
                'this is everything after the header.
                m.Body = msg.Substring(hend + 4)
                'Dim x As String
                'getHeader(m)
                Return True
            Else
                Return False
            End If
        End Function

        Private Sub setHeader(ByRef m As MailMessage, ByVal h As String)
            'extract standard headers values from header string using regular expressions
            'and save to the mailmessage class
            m.To = Regex.Match(h, "\nTo:(?<to>[^\n]+)\n", RegexOptions.IgnoreCase).Groups("to").Value
            m.From = Regex.Match(h, "\nFrom:(?<from>[^\n]+)\n", RegexOptions.IgnoreCase).Groups("from").Value
            m.Cc = Regex.Match(h, "\nCC:(?<cc>[^\n]+)\n", RegexOptions.IgnoreCase).Groups("cc").Value
            m.Subject = Regex.Match(h, "\nSubject:(?<subject>[^\n]+)\n", RegexOptions.IgnoreCase).Groups("subject").Value
   

            'clear existing header values
            'this is just incase the same mailmessage instance is being reused
            'for different mails 
            m.Headers.Clear()

            'extract less standard headers values from header string using regular expressions
            'and add to the mailmessage.headers.
            ' m.Headers.Add("Status", Regex.Match(h, "\nStatus:(?<Status>[^\n]+)\n", RegexOptions.IgnoreCase).Groups("Status").Value)

            m.Headers.Add("Reply-To", Regex.Match(h, "\nReply-To:(?<ReplyTo>[^\n]+)\n", RegexOptions.IgnoreCase).Groups("ReplyTo").Value)
            m.Headers.Add("Message-ID", Regex.Match(h, "\nMessage-ID:(?<MessageID>[^\n]+)\n", RegexOptions.IgnoreCase).Groups("MessageID").Value)
            m.Headers.Add("Date", Regex.Match(h, "\nDate:(?<Date>[^\n]+)\n", RegexOptions.IgnoreCase).Groups("Date").Value)
        End Sub

        '-- the code below is as before .

        'a private holder for the number of mails
        Private _MessageCount As Integer = -1
        ReadOnly Property MessageCount() As Integer
            Get
                'if the count has not yet been set, request details from server
                If _MessageCount = -1 Then
                    GetStats()
                End If
                Return _MessageCount
            End Get
        End Property

        'private holder for mailbox size
        Private _MailBoxSize As Integer = -1
        ReadOnly Property MailBoxSize() As Integer
            Get
                'if the size has not yet been set, request details from server
                If _MailBoxSize = -1 Then
                    GetStats()
                End If
                Return _MailBoxSize
            End Get
        End Property

        Private Sub GetStats()
            Dim a As String()
            'issue the stat command to the server
            'split the returned string into an array
            a = SendCmd("stat").Split(" ")

            'set the count
            _MessageCount = CType(a(1), Integer)
            'set the size
            _MailBoxSize = CType(a(2), Integer)
        End Sub

        Public Function getSize(ByVal m As MailMessage) As Boolean
            Dim a() As String

            'perform the list command
            a = SendCmd("list " + m.ID.ToString).Split(" ")

            'if the command was ok set the message size
            If a(0) = "+OK" Then
                m.Size = CType(a(2), Integer)
                Return True
                'else indicate the mail doesn't exist
            Else
                m.ID = -1
                m.Size = 0
                Return False
            End If
        End Function

        Private s As System.Net.Sockets.NetworkStream
        Private t As New System.Net.Sockets.TcpClient
        Private Cnct As Boolean = False

        Public Sub New(ByVal Server As String)
            'open port 110 ( the pop3 port ) On the server
            Try
                'catch any error resuting from a bad server name
                t.Connect(Server, 110)
                s = t.GetStream()

                'check that the connection is okay
                If Left(getData(), 3) = "+OK" Then
                    Cnct = True
                End If
            Catch
            End Try
        End Sub

        Public Function logon(ByVal User As String, ByVal passwd As String) As Boolean
            Dim ret As String

            logon = False

            'make sure you have a connection
            If Cnct Then
                'send the username
                ret = SendCmd("user " + User)

                'if that was successfull, send the password
                If Left(ret, 3) = "+OK" Then
                    ret = SendCmd("pass " + passwd)

                    'if that was successfull set the return flas to true
                    If Left(ret, 3) = "+OK" Then
                        logon = True
                    End If
                End If
            End If
        End Function

        Public Function logoff() As String
            If Cnct Then
                logoff = SendCmd("QUIT")
            End If
        End Function

        Private Function SendCmd(ByVal Cmd As String) As String
            Dim bCmd As Byte()
            'byte encode the command
            bCmd = System.Text.Encoding.ASCII.GetBytes(Cmd + vbCrLf)

            'send the data
            s.Write(bCmd, 0, bCmd.Length)
            SendCmd = getData()
        End Function
    End Class


End Class

'display the returned values
'these have been htmlencoded to prevent problems with being display
'in a web page
'''r = New TableRow
'''c = New TableCell
'''c.Text = "To:"
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''c.Font.Bold = True
'''r.Cells.Add(c)
'''c = New TableCell
'''c.Text = Server.HtmlEncode(ma(cnt).To)
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''r.Cells.Add(c)
'''AnswerTable.Rows.Add(r)

'''r = New TableRow
'''c = New TableCell
'''c.Text = "Cc:"
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''c.Font.Bold = True
'''r.Cells.Add(c)
'''c = New TableCell
'''c.Text = Server.HtmlEncode(ma(cnt).Cc)
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''r.Cells.Add(c)
'''AnswerTable.Rows.Add(r)

'''r = New TableRow
'''c = New TableCell
'''c.Text = "From:"
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''c.Font.Bold = True
'''r.Cells.Add(c)
'''c = New TableCell
'''c.Text = Server.HtmlEncode(ma(cnt).From)
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''r.Cells.Add(c)
'''AnswerTable.Rows.Add(r)

'''r = New TableRow
'''c = New TableCell
'''c.Text = "Subject:"
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''c.Font.Bold = True
'''r.Cells.Add(c)
'''c = New TableCell
'''c.Text = Server.HtmlEncode(ma(cnt).Subject)
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''r.Cells.Add(c)
'''AnswerTable.Rows.Add(r)

'''r = New TableRow
'''c = New TableCell
'''c.Text = "Reply To:"
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''c.Font.Bold = True
'''r.Cells.Add(c)
'''c = New TableCell
'''c.Text = Server.HtmlEncode(ma(cnt).Headers("Reply-To"))
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''r.Cells.Add(c)
'''AnswerTable.Rows.Add(r)

'''r = New TableRow
'''c = New TableCell
'''c.Text = "Message ID:"
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''c.Font.Bold = True
'''r.Cells.Add(c)
'''c = New TableCell
'''c.Text = Server.HtmlEncode(ma(cnt).Headers("Message-ID"))
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''r.Cells.Add(c)
'''AnswerTable.Rows.Add(r)

'''r = New TableRow
'''c = New TableCell
'''c.Text = "Date:"
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''c.Font.Bold = True
'''r.Cells.Add(c)
'''c = New TableCell
'''c.Text = Server.HtmlEncode(ma(cnt).Headers("Date"))
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''r.Cells.Add(c)
'''AnswerTable.Rows.Add(r)

'''r = New TableRow
'''c = New TableCell
'''c.Text = Server.HtmlEncode(ma(cnt).Body).Replace(vbCrLf, "<br>")
'''c.ColumnSpan = 2
'''c.HorizontalAlign = HorizontalAlign.Left
'''c.VerticalAlign = VerticalAlign.Top
'''c.BackColor = System.Drawing.Color.White
'''r.Cells.Add(c)
'''AnswerTable.Rows.Add(r)