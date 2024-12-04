<%
'	Query ="http://www.phonetrade.cc/Print.htm"
	'Set objHttp = Server.CreateObject("Msxml4.ServerXMLHTTP")
Set objHttp = Server.CreateObject("Microsoft.XMLHTTP")
	Query ="http://www.phonetrade.cc/signup_email.htm"
	
	objHttp.open "GET", Query, False
	objHttp.send
	strHTML = objHttp.responseText
	Response.Write(strHTML)
	Response.End()
	
	'Response.Write(Query)

%>
