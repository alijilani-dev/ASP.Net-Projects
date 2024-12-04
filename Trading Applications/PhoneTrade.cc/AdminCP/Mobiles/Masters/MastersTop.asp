<%@ Language=VBScript %>
<%
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if

%>
<script language=JavaScript>
function Logout()
{
  document.frmMain.target="_top"; 
  document.frmMain.action="../Login.asp?Process=Logout";
  document.frmMain.submit();  
}
function Show(index)
{
	var i;
	for (i=0;i<=3;i++)
	{
		if (i==index)
		{
			eval("Link"+i).style.backgroundColor="orange";
			eval("Link"+i).style.color="#ffffff";
			eval("Link"+i).style.cursor="Hand";
			
		}
		else
		{
			eval("Link"+i).style.backgroundColor="#996600";
			eval("Link"+i).style.color="#ffffff";						
		}
	}
}
 function Move(page)
{
	document.frmMain.target="_top";
	document.frmMain.action="../" + page;
	document.frmMain.submit();
}

</script>
<HTML>
<LINK rel="stylesheet" type="text/css" href="../Global/MyStyle.css">
<body topmargin="0" leftmargin="0" Rightmargin="0" bottommargin="0">
<form name=frmMain method=post>
<TABLE border=0 cellspacing=0 cellpadding=0 width="100%">
	<tr><td>&nbsp;</td></tr>
	<tr Class=MainHeading><td Align=middle>Phonetrade.cc</font></td></tr>
	<tr Class=SubHeading><td Align=middle>Control Panel to update Mobile Models</td></tr>
	<tr><td>&nbsp;</td></tr>
	<tr><td>
	<table border=0 width=100%>
          <tr> 
            <td class=HeadingWithBackGround align=Center Id=Link0 onmouseover="JavaScript:Show(0)" onClick="JavaScript:Move('Master.asp')">Master 
              entries </td>
            <td class=HeadingWithBackGround align=Center Id=Link1 onmouseover="JavaScript:Show(1)" onClick="JavaScript:Move('Mobiles.asp')">Mobiles</td>
            <td class=HeadingWithBackGround align=Center Id=Link2 onmouseover="JavaScript:Show(2)" onClick="JavaScript:Move('Upload.asp')">Upload 
              Images </td>
            <td class=HeadingWithBackGround align=Center Id=Link3 onmouseover="JavaScript:Show(3)" onClick="JavaScript:Logout()">Logout</td>
          </tr>
        </table>
    </td></tr>		
</table>
</form>
</body>
</html>
