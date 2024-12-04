<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1

if len(Session("sLogmeinadmin"))=0 then
	Response.Redirect "Login.asp"	
end if

	Dim rsMain, strSubject
	Dim MyCDONTSMail, strNLName
	Dim objHttp
	Dim strHTML,Query, strEmail
	
	Set objHttp = Server.CreateObject("Msxml2.ServerXMLHTTP")
	set rsMain=Server.CreateObject("Adodb.Recordset")

	Dim strTo, strFrom, sql, pge, Flag
	strTo  = Request.Form("hdTo")
	strFrom  = Request.Form("hdFrom")
	strSubject= Request.Form("txtSubject")
	if len(strSubject & "")=0 then strSubject = "Today's new phone trade listings posted on PhoneTrade.cc"
	pge = Request.Form("hdPageNo")

	if len(pge&"")<=0 or pge="0" then 
		pge=1 
	else 
		pge=cint(pge)+1
	end if
	if strTo & ""="" and strFrom &""="" then Response.Redirect "MailingProc.asp"
	if len(strFrom & "")>0 then
		sql="select  * from Members where MailFlag=2 and SrNo >=" & strFrom & " and SrNo <=" & strTo & " ORDER BY SrNo DESC"
	else
		sql="select  * from Members where MailFlag=2 and SrNo <=" & strTo & " ORDER BY SrNo DESC"	
	end if
	'rsMain.Open "select  * from mSubscriber where EmailId='abash2002@yahoo.com' ORDER BY SrNo DESC",conn,3,2
	rsMain.Open sql,conn,3,2
	'Response.Write rsMain.RecordCount
	'Response.End 
	
	do while not rsMain.EOF 
		strEmail=rsMain("EmailId")
		'Query ="http://" & Request.ServerVariables("SERVER_NAME") & "/cPanel/DailyUpdates.asp"
		Query ="http://www.phonetrade.cc/cPanel/DailyUpdates.asp"
		
		objHttp.open "GET", Query, False
		objHttp.send
		strHTML = objHttp.responseText
		'response.write(strhtml)
		'Response.End 
		
		Set MyCDONTSMail = CreateObject("CDONTS.NewMail")	
		MyCDONTSMail.From= "sales@phonetrade.cc"
		MyCDONTSMail.To= strEmail
		MyCDONTSMail.Subject=strSubject 

		MyCDONTSMail.BodyFormat=0
		MyCDONTSMail.MailFormat=0
		MyCDONTSMail.Body= strHTML
		MyCDONTSMail.Send
		rsMain.MoveNext 
		set MyCDONTSMail=nothing

	'Response.Write strEmail
	'Response.Write Query & vbCrLf
	'Response.Write strHTML & vbCrLf
	'Response.End 

	loop
	Flag="Yes"
	set objHttp=nothing
	
%>
<html>
<head>
<body onLoad="change();">
<form name=frm method=post>
 <input type=hidden name=hdPageNo value="<%=pge%>">
 <input type=hidden name=txtSubject value="<%=strSubject%>">
 
 <input type=hidden name=txtMsg>   
	<script language=Javascript>
		function change()
		{
			if ("<%=Flag%>"=="Yes")
			{
			document.frm.txtMsg.value = "Mail sent to 100 members";
			document.frm.action = "MailingProc.asp";
			document.frm.submit();
			}
		}
		
	</script>
</form>
</body>
</head>
</htmL>