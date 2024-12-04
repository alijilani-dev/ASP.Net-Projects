<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<%
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if
%>
<HTML>
<Head>
<Title>
Manufacturer Main
</Title>
<LINK rel="stylesheet" type="text/css" href="../Global/MyStyle.css">
<script language='javascript' src=../Global/valid.js></script>
</Head>

<body>
<a href="newManufacturer.asp" class="link3"><b>Add New Manufacturer </b></a>
<% 
dim strMode
strMode=Request.QueryString("mode")
if strMode="1" then
	Response.Write "<p align=center><font color=Red size=2>Manufacturer name has been successfully Added</font></p>"
elseif strMode="2" then
	Response.Write "<p align=center><font color=Red size=2>Manufacturer name has been successfully Modified</font></p>"
elseif strMode="3" then
	Response.Write "<p align=center><font color=Red size=2>Manufacturer name has been successfully Deleted</font></p>"
elseif strMode="4" then
	Response.Write "<p align=center><font color=Red size=2>Sorry, Manufacturer name can not be deleted! Master reference found</font></p>"
elseif strMode="5" then
	Response.Write "<p align=center><font color=Red size=2>Logo image has been successfully changed</font></p>"

end if
%>
<form name=frmManufacturer method=post>

<input type=hidden name=hdCode value="">
<input type=hidden name=hdAction value="">

<script language=javascript>

	function show(p,q)

	{

		if (q==1) 

		{ 
		     document.frmManufacturer.hdCode.value =p;
		     document.frmManufacturer.action="EditManufacturer.asp";
		     document.frmManufacturer.submit()
		}
		if (q==3) 

		{ 
		     document.frmManufacturer.hdCode.value =p;
		     document.frmManufacturer.action="ViewImage.asp";
		     document.frmManufacturer.submit()
		}

		if (q==2)

		{
			
			if (confirm("Are you sure to Delete this Manufacturer Name")==true)
			{
				document.frmManufacturer.hdCode.value =p;
				document.frmManufacturer.hdAction.value ="Del";
				document.frmManufacturer.action = "ManufacturerInfo.asp";
				document.frmManufacturer.submit()
			}		 			
		}

	}
</script>
<% Dim Rsmain, sql, i

	sql="select * from mManufacturer order by ManufName"
	set Rsmain=Server.CreateObject("Adodb.RecordSet")
	Rsmain.Open sql,conn,3,2
	Response.write "<table width=""100%"" border=1 cellspacing=0 cellpadding=2>"
	Response.write "<tr bgcolor=lightgrey><td class=tablehead> Sr.no.</td>"
	Response.write "<td class=tablehead>Manufacturer Name </td>"
	Response.write "<td class=tablehead>Logo</td>"
	Response.write "<td class=tablehead> Edit/Delete </td> </tr>"

	do while not Rsmain.EOF
		i=i+1
		Response.write "<tr> <td> " & i & "</td>"
		Response.write "<td><b> " & Rsmain("ManufName") & "</b></td>"
		Response.write "<td> <a href='javascript:show(" & Rsmain("ManufCode") & ",3);' class=""link3"">View/Edit image</td>"
		Response.write "<td> <a href='javascript:show(" & Rsmain("ManufCode") & ",1);' class=""link3"">"
		Response.write "Edit</a> | "
		Response.write "<a href='javascript:show(" & Rsmain("ManufCode") & ",2);' class=""link3"">"
		Response.write "Delete </a></td></tr>"
		Rsmain.movenext
	loop

	Response.write "</table>"

%>

</form>
</body>
</html>
