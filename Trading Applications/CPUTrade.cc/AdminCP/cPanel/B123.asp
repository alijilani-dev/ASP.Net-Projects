<%
'	Query ="http://www.phonetrade.cc/Print.htm"
	'Set objHttp = Server.CreateObject("Msxml4.ServerXMLHTTP")
	'Set objHttp = Server.CreateObject("Microsoft.XMLHTTP")
'Set oXMLHTTP = Server.CreateObject("Microsoft.XMLHTTP")
	Query ="http://www.phonetrade.cc/signup_email.htm"
	
	'objHttp.open "GET", Query, False
	'objHttp.SetRequestHeader "Content-Type", "application/x-www-form-urlencoded"	
	'objHttp.send
	'strHTML = objHttp.responseText
	
	'Response.Write(Query)
	Set oXMLHTTP = Server.CreateObject("Microsoft.XMLHTTP")
	oXMLHTTP.Open "POST", Query, false
	oXMLHTTP.SetRequestHeader "Content-Type", "application/x-www-form-urlencoded"
	'oXMLHTTP.Send sPostData
	sResult = oXMLHTTP.responseText
	Set oXMLHTTP = nothing
	Response.Write sResult & "Ok"
	Response.End()

%>
