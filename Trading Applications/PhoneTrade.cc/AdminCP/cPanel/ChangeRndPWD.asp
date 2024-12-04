<!-- #Include File = "../Main/Source.asp" -->
<%
Dim rsTemp , strRandompwd
Dim MyCDONTSMail
Dim objHttp
Dim strHTML,Query

Function RandomNumber(intHighestNumber)
	Randomize
	RandomNumber = Int(intHighestNumber * Rnd) + 1
End Function


set rsTemp = server.CreateObject("Adodb.Recordset")

rsTemp.open "Select * from Members where Activateflag=1",conn,3,2
''rsTemp.open "Select * from Members where MemberCode >500",conn,3,2
''rsTemp.open "Select * from Members where MemberCode in (2,4,210)",conn,3,2
do while not rsTemp.eof
	strRandompwd = mid(rsTemp("Member_id"),1,1) &  RandomNumber(100) & mid(rsTemp("Member_id"),1,3) & RandomNumber(100000)
	strPwd = strRandompwd
	strSQL = "Update Members set Password='" & strPwd & "' where	MemberCode=" & rsTemp("MemberCode")
	Response.Write(strSQL & "<BR>")	
rsTemp.movenext
loop

%>

<%
'		rsTemp("password") = strRandompwd
'		rsTemp.update					
'		strName = rsTemp("CompanyName")
'		strUsrName = rsTemp("UsrName")
'		strToMail = rsTemp("EmailId")
'	response.write(strName & "   :     " & strRandompwd & "<BR>")
		'Query ="http://www.phonetrade.cc/cPanel/Activate_Pwd.asp?mem=" & replace(strName,"&","@*@") & "&usr1=" & strUsrName & "&pd=" & strPwd
		'Set objHttp = Server.CreateObject("Msxml2.ServerXMLHTTP")
		'objHttp.open "GET", Query, False
		'objHttp.send
		'strHTML = objHttp.responseText

		'Set MyCDONTSMail = CreateObject("CDONTS.NewMail")
		'MyCDONTSMail.From= "info@phonetrade.cc"
		'MyCDONTSMail.To= strToMail
		'MyCDONTSMail.BCC= "basheer@skyphi.com"
	'	MyCDONTSMail.Subject="Account information has been changed for security reason!!! - Phonetrade.cc"


		'MyCDONTSMail.BodyFormat=0
		'MyCDONTSMail.MailFormat=0
		'MyCDONTSMail.Body= strHTML
		'MyCDONTSMail.Send
		'set MyCDONTSMail=nothing


%>