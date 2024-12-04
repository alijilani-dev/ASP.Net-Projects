<%

           strFromMailId = "basheer@skyphi.com"
	strToEmailID = "abash2002@yahoo.com" '"aliphonetrade@hotmail.com"
            strSMTPserver = "213.42.18.90" '"10.4.29.4" 
            strSMTPusername = "admin50534137@skyphi.com" 
            strSMTPpassword = "admin" 
            strSMTPport = "25" 


			strHTML ="<html><title>test</title><body><font color=red>Welcome to test this mail on Sep 10 2006 at 1.24pm</font></body></html>"

   

Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 

Const cdoAnonymous = 0 'Do not authenticate
Const cdoBasic = 1 'basic (clear-text) authentication
Const cdoNTLM = 2 'NTLM

Set objMessage = CreateObject("CDO.Message") 
objMessage.Subject = "This is 2nd teting mail on Sep 10 2006 at 1.24pm" 
objMessage.From =strFromMailId' "basheer@ireuae.com" 
objMessage.To = strToEmailID'"basheer@skyphi.com" 
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
("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25 

'Use SSL for the connection (False or True)
objMessage.Configuration.Fields.Item _
("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = False

objMessage.Configuration.Fields.Update

'==End remote SMTP server configuration section==

objMessage.Send

	 
%>