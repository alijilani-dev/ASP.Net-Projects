<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
if len(Session("sLogmeinadmin"))=0 then
	Response.Redirect "Login.asp"	
end if

	Dim Flag, strCode, rsTemp
	strCode = Request.Form("hdProc")
	
	set rsTemp = server.CreateObject("Adodb.Recordset")
	rsTemp.Open "Select Trade_Floor.Member_id from Trade_Floor inner join Members on Trade_Floor.Member_id = Members.Member_id " & _ 
			" where Members.MemberCode=" & strCode, conn,3,3
	if not rsTemp.EOF then
		Flag="No"
	else
		sql = "Delete from Members where MemberCode=" & strCode 
		conn.execute sql
		if err.number<>0 then
			Response.Redirect "Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Flag="Deleted"
		end if
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
			document.frm.hdMsg.value = "Member information can not be deleted, Some postings found for this member";
			document.frm.action="EditMember.asp"
			document.frm.submit();
			}

			if ("<%=Flag%>"=="Deleted")
			{
			document.frm.hdMsg.value = "Member information has been successfully deleted.";
			document.frm.action="Members.asp"
			document.frm.submit();
			}
		}
		
	</script>
</form>
</body>

</HTML>
