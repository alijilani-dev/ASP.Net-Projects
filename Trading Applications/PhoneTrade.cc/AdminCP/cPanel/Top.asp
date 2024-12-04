<%@ Language=VBScript %>
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
if len(Session("sLogmeinadmin"))=0 then
	Response.Redirect "Login.asp"	
end if
%>  
<script language=JavaScript>
function Logout()
{
  document.frmMain.target="_top"; 
  document.frmMain.action="Login.asp?Process=Logout";
  document.frmMain.submit();  
}
function Show(index)
{
	var i;
	for (i=0;i<=4;i++)
	{
		if (i==index)
		{
			eval("Link"+i).style.backgroundColor="#990000";
			eval("Link"+i).style.color="White";
			eval("Link"+i).style.cursor="Hand";
		}
		else
		{
			eval("Link"+i).style.backgroundColor="#666666";
			eval("Link"+i).style.color="#ffffff";						
		}
	}
}
 function Move(page)
{
	document.frmMain.target="_top";
	document.frmMain.action=page;
	document.frmMain.submit();
}

</script>
<link href="../Styles/CssStyles.CSS" rel="stylesheet" type="text/css">
<script language="JavaScript1.2" type="text/JavaScript1.2" src="../Main/Main.js"></script>
<HTML>

<body topmargin="0" leftmargin="0" Rightmargin="0" bottommargin="0">
<form name=frmMain method=post>
<TABLE border=0 cellspacing=0 cellpadding=0 width="100%">
	<tr><td>&nbsp;</td></tr>
	<tr Class=MainHeading>
      <td Align=middle>Mobile portal</td>
    </tr>
	<tr Class=SubHeading>
      <td Align=middle>&nbsp;</td>
    </tr>
	<tr><td>&nbsp;</td></tr>
	<tr><td>
	<table width=100% border=0 cellpadding="2">
          <tr> 
            <td width="14%" align=Center class=HeadingWithBackGround Id=Link0 onClick="JavaScript:Move('Members.asp')" onmouseover="JavaScript:Show(0)">Member 
              Details </td>
            <td width="12%" align=Center class=HeadingWithBackGround Id=Link1 onClick="JavaScript:Move('ImageUpload.asp')" onmouseover="JavaScript:Show(1)">Upload 
              Images </td>
            <td width="11%" align=Center class=HeadingWithBackGround Id=Link2 onClick="JavaScript:Move('Misc.asp')" onmouseover="JavaScript:Show(2)">Miscellaneous</td>
            <td width="19%" align=Center class=HeadingWithBackGround Id=Link3 onClick="JavaScript:Logout()" onmouseover="JavaScript:Show(3)">Logout</td>
            <td width="44%" align=Center class=HeadingWithBackGround Id=Link4 onClick="JavaScript:Move('../Mobiles/Login.asp')" onmouseover="JavaScript:Show(4)">Update 
              Mobiles </td>
          </tr>
        </table>
    </td></tr>		
</table>
</form>
</body>
</html>
