<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<%
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if%>
<HTML>
<Head>
<Title>
Display Type Main
</Title>
<LINK rel="stylesheet" type="text/css" href="../Global/MyStyle.css">
<script language='javascript' src=../Global/valid.js></script>
</Head>

<body>
<a href="NewDisplayType.asp" class="link3"><b>Add New Display type </b></a>
<% 
dim strMode
strMode=Request.QueryString("mode")
if strMode="1" then
	Response.Write "<p align=center><font color=Red size=2>Display Type name has been successfully Added</font></p>"
elseif strMode="2" then
	Response.Write "<p align=center><font color=Red size=2>Display Type name has been successfully Modified</font></p>"
elseif strMode="3" then
	Response.Write "<p align=center><font color=Red size=2>Display Type name has been successfully Deleted</font></p>"
elseif strMode="4" then
	Response.Write "<p align=center><font color=Red size=2>Sorry, Display Type name can not be deleted! Master reference found</font></p>"
elseif strMode="5" then
	Response.Write "<p align=center><font color=Red size=2>Logo image has been successfully changed</font></p>"

end if
%>
<form name=frmDispType method=post>

<input type=hidden name=hdCode value="">
<input type=hidden name=hdAction value="">

<script language=javascript>

	function show(p,q)

	{

		if (q==1) 

		{ 
		     document.frmDispType.hdCode.value =p;
		     document.frmDispType.action="EditDisplayType.asp";
		     document.frmDispType.submit()
		}
		if (q==3) 

		{ 
		     document.frmDispType.hdCode.value =p;
		     document.frmDispType.action="ViewImage.asp";
		     document.frmDispType.submit()
		}

		if (q==2)

		{
			
			if (confirm("Are you sure to Delete this Display Type Name")==true)
			{
				document.frmDispType.hdCode.value =p;
				document.frmDispType.hdAction.value ="Del";
				document.frmDispType.action = "DispTypeInfo.asp";
				document.frmDispType.submit()
			}		 			
		}

	}
</script>
<% Dim Rsmain, sql, i

	sql="select * from mDispType order by DispType"
	set Rsmain=Server.CreateObject("Adodb.RecordSet")
	Rsmain.Open sql,conn,3,2
	Response.write "<table width=""100%"" border=1 cellspacing=0 cellpadding=2>"
	Response.write "<tr bgcolor=lightgrey><td class=tablehead> Sr.no.</td>"
	Response.write "<td class=tablehead>Display Type Name </td>"
	Response.write "<td class=tablehead> Edit/Delete </td> </tr>"

	do while not Rsmain.EOF
		i=i+1
		Response.write "<tr> <td> " & i & "</td>"
		Response.write "<td><b> " & Rsmain("DispType") & "</b></td>"
		Response.write "<td> <a href='javascript:show(" & Rsmain("DispTypeCode") & ",1);' class=""link3"">"
		Response.write "Edit</a> | "
		Response.write "<a href='javascript:show(" & Rsmain("DispTypeCode") & ",2);' class=""link3"">"
		Response.write "Delete </a></td></tr>"
		Rsmain.movenext
	loop

	Response.write "</table>"

%>

</form>
</body>
</html>
