<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<% 	
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1

if len(Session("sLogmeinadmin"))=0 then
	Response.Redirect "Login.asp"	
end if
	Dim membCode, strPromote, strMember, Finished
	
	strPromote = Request.Form("hdPromote")
	strMember = Request.Form("hdMember")
	membCode = Request.Form("cboMembName")


	sql="Update Members set MemberLevel=" & strPromote & " where MemberCode=" & membCode
	'Response.Write sql
	'Response.End 
	conn.execute sql

	if err.number<>0 then
		Response.Redirect "Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
		Response.End 
	else
		Finished="yes"
	end if 	
%> 

<html>
<head>
<body onLoad="change();">
<form name=frm method=post>
<input type=hidden name=txtMsg>   
<input type=hidden name="cboMembName" value="<%=membCode%>">

	<script language=Javascript>
		function change()
		{
			if ("<%=Finished%>"=="yes")
			{
				if ("<%=strPromote%>"=="1")
				document.frm.txtMsg.value = "Promoted membership level for the member " + "<%=strMember%>" + " to <font color=red>Basic Level</font>";
				if ("<%=strPromote%>"=="2")
				document.frm.txtMsg.value = "Promoted membership level for the member " + "<%=strMember%>" + " to <font color=red>Silver Level</font>";

			document.frm.action = "Activate.asp";
			document.frm.submit();
			}
		}
		
	</script>
</form>

</body>
</head>
</htmL>