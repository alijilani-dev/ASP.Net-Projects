<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
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

<title>Master - Miscesllaneous Operations</title><body topmargin="0" leftmargin="0" Rightmargin="0" bottommargin="0">
<!--#include file="Top1.asp"-->
<table width="80%" border="0" align="center" cellpadding="3" cellspacing="1" bgcolor="#999999">
  <tr bgcolor="#FFFFFF">
    <td width="14%"><a href="Enquiries.asp"><strong>Enquiries</strong></a></td>
    <td width="26%"><strong><a href="AdvEnquiries.asp">Advertisement Enquiry</a></strong></td>
    <td width="11%">&nbsp;</td>
    <td width="13%">&nbsp;</td>
    <td width="36%">&nbsp;</td>
  </tr>
</table>
</body>
</html>
