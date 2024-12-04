<%@ Language=VBScript %>
<!-- #Include File = "..\Global\MainSrc.asp" -->
<%
Dim rsMain, sqlQry
set rsMain = server.createObject("Adodb.Recordset")

%>
<html>
<head>
<title>Mobile Makers</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="Css.css" rel="stylesheet" type="text/css">
</head>

<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<table width="100%" height="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="100%" align="center">
<form name="frmMobDet" method="post">
        <input type="hidden" name="hdManufCode" value="">
        <script language="JavaScript">
function ShowMobDet(p)
{
	document.frmMobDet.hdManufCode.value = p;
	document.frmMobDet.action = "Mobiles.asp";
	document.frmMobDet.submit();
}
</script>
        <table height="20" border="0" align="center" cellpadding="0" cellspacing="10">
          <!-- for Project Showcase-->
          <tr> 
            <td align="center"> 
              <% 
sqlQry= "select * from mManufacturer Order by mManufacturer.ManufName"
if rsMain.state then rsMain.close
rsMain.Open sqlQry,conn,1, 2
i =0
do while not rsMain.EOF
	if (i mod 3 <> 0) then Response.Write "</td><td>" else Response.Write "</td></tr><tr><td>"
 %>
              <table width="115" border="0" cellspacing="0" cellpadding="0">
        <tr> 
          <td><img src="../images/manuf_top.jpg" width="115" height="21"></td>
        </tr>
        <tr> 
                  <td height="47" align="center" background="../images/manuf_bg.jpg"> 
                  <a href="javascript:ShowMobDet('<%=rsMain("ManufCode")%>');">
				  <img src="../images/Models/<%=rsMain("Logo")%>" width="92" height="22" border="0"> 
				  </a>
                  </td>
        </tr>
        <tr>
          <td><img src="../images/manuf_bot.jpg" width="115" height="8"></td>
        </tr>
      </table>
              <% 
i = i +1
rsMain.MoveNext 
loop 
'end if
%>
            </td>
          </tr>
        </table>
      </form>
<!--End of Mobile showcase-->
</td></tr>
</table>
</body>
</html>