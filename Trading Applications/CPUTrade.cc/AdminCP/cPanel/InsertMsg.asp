<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
	Dim hdProc
	hdProc=Request.Form("hdProc")

Dim Message, MessageTitle
Dim Flag, MessageCode, MemberName

Select case cint(hdProc)
case 1
	MessageType=Request.Form("rdoType")
	MessageTitle = replace(Request.Form("txtTitle"),"'","`")
	Message = replace(Request.Form("txtMessage"),"'","`")
	MemberCode=Request.Form("cboMembName")
	MemberName=Request.Form("hdMemberName")
	MessageCode = conn.Execute("select Max(MessageCode) from tMessage")(0)
	MessageCode=MessageCode & ""
	if len(MessageCode)=0 then 
		MessageCode=1 
	else
		MessageCode = cdbl(MessageCode) + 1
	end if
	if len(MessageCode)=0 OR IsNull(MessageCode) then MessageCode=1
    
		set ObjRs = server.CreateObject("adodb.recordset")
		ObjRs.Open "select * from tMessage",conn,3,3
		ObjRs.AddNew 
		ObjRs("MessageCode") = MessageCode
		ObjRs("MemberCode") = MemberCode
		ObjRs("MessageType") = MessageType		
		ObjRs("MessageTitle") = MessageTitle
		ObjRs("Message") = Message
		ObjRs("ActDate") = dateadd("h", -4, Now())'dateadd("n", -30,dateadd("h", -5, Now()))'dateadd("h", -4, Now())'dateadd("n", -30,dateadd("h", -3, Now()))
		ObjRs.Update

		if err.number <> 0 then
			Response.Redirect "Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
			Flag = "No"
		else
			Flag = "Yes"
		end if

		ObjRs.Close
		Set ObjRs = nothing
		
		Dim Company, rsTemp, strEmail
		Dim MyCDONTSMail, Query, objHttp
		
		'set rsTemp = server.CreateObject("adodb.recordset")
		'rsTemp.Open "select CompanyName, EmailId from Members where  CompanyType Not like '%6%' and MailFlag=1"  ,conn,3,3
		'Do while not rsTemp.EOF 
			'strEmail = rsTemp("EmailId") & ""
			'Company = rsTemp("CompanyName") & ""

			'Query ="http://www.phonetrade.cc/poststock_email.asp?mem=" & MemberCode & "&msgCode=" & MessageCode'& "&title=" & replace(MessageTitle,"&","@") & "&msg=" & replace(replace(Message,vbcrlf,"<br>"),"&","@")			
			'Query ="http://" & Request.ServerVariables("SERVER_NAME") & "/poststock_email.asp?mem=" & MemberName & "&title=" & MessageTitle & "&msg=" & replace(Message,vbcrlf,"<br>")
			'Set objHttp = Server.CreateObject("Msxml2.ServerXMLHTTP")
			'objHttp.open "GET", Query, False
			'objHttp.send
			'strHTML = objHttp.responseText

			'Set MyCDONTSMail = CreateObject("CDONTS.NewMail")
			'MyCDONTSMail.To= strEmail
			'MyCDONTSMail.From= "info@phonetrade.cc"
			'MyCDONTSMail.Subject=MessageTitle
			'MyCDONTSMail.BodyFormat=0
			'MyCDONTSMail.MailFormat=0
			
			'MyCDONTSMail.Body= strHTML
			'MyCDONTSMail.Send	
			'Set MyCDONTSMail = Nothing
			'rsTemp.MoveNext	
		'loop
case 2
	MessageType=Request.Form("rdoType")
    MessageCode=Request.QueryString("Msgcode")
	MessageTitle = replace(Request.Form("txtTitle"),"'","`")
	Message = replace(Request.Form("txtMessage"),"'","`")
	MemberCode=Request.Form("cboMembName")
    
		set ObjRs = server.CreateObject("adodb.recordset")
		ObjRs.Open "select * from tMessage where MessageCode=" & MessageCode,conn,3,3
			
		ObjRs("MessageCode") = MessageCode
		ObjRs("MemberCode") = MemberCode
		ObjRs("MessageType") = MessageType		
		ObjRs("MessageTitle") = MessageTitle
		ObjRs("Message") = Message
		ObjRs("ActDate") = dateadd("h", -4, Now())'dateadd("n", -30,dateadd("h", -5, Now()))'dateadd("h", -4, Now())'dateadd("n", -30,dateadd("h", -3, Now()))
		ObjRs.Update

		if err.number <> 0 then
			Response.Redirect "Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
			Flag = "No"
		else
			Flag = "Yes"
		end if

		ObjRs.Close
		Set ObjRs = nothing

end select

if ucase(request.QueryString("Delete"))<>"NOTHING" and request.QueryString("Delete")<>"" and len(request.QueryString("Delete"))>0 then

    MessageCode=Request.QueryString("Delete")
	MemberCode=Request.QueryString("Memb")
	   
		set ObjRs = server.CreateObject("adodb.recordset")
		ObjRs.Open "select * from tMessage where MessageCode=" & MessageCode,conn,3,3
		ObjRs.Delete

		if err.number <> 0 then
			Response.Redirect "Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
			Flag = "No"
		else
			Flag = "Yes"
		end if

		ObjRs.Close
		Set ObjRs = nothing

end if 
%>

<HTML>
<HEAD>
<META NAME="GENERATOR" Content="Microsoft Visual Studio 6.0">
</HEAD>
<body onLoad="change();">
<form name=frm method=post>
<input type=Hidden name=hdMsg value="">
	<script language=Javascript>
		function change()
		{
			if ("<%=Flag%>"=="No")
			{
			document.frm.hdMsg.value = "Error in updating information.";
			document.frm.action="PostMessage.asp?Memb=<%=MemberCode%>"
			document.frm.submit();
			}
			else
			{
			document.frm.action="PostMessage.asp?Memb=<%=MemberCode%>"
			document.frm.submit();
			} 						
		}
		
	</script>
</form>
 
</body>

</HTML>

