<%@ Language=VBScript %>
<!-- #Include File = "..\Global\MainSrc.asp" -->
<%
Dim rsMain, sqlQry, strManufCode
set rsMain = server.createObject("Adodb.Recordset")
strManufCode = Request.Form("hdManufCode")
%>
<html>
<head>
<title>Mobile Models</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="../Css.css" rel="stylesheet" type="text/css">
</head>

<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<table width="100%" height="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="100%" align="center">
<form name="frmMobDet" method="post">
        <input type="hidden" name="hdModelNo" value="">
        <script language="JavaScript">
function ShowMobDet(p)
{
	document.frmMobDet.hdModelNo.value = p;
	document.frmMobDet.action = "MobilesDetails.asp";
	document.frmMobDet.submit();
}
</script>
        <table height="20" border="0" align="center" cellpadding="0" cellspacing="10">
          <!-- for Project Showcase-->
          <tr> 
            <td align="center"> 
              <% 
              
sqlQry= "select * from mMobileModel where ManufCode=" & strManufCode & " Order by mMobileModel.ModelNo Desc"
'sqlQry= "select * from mManufacturer Order by mManufacturer.ManufName"
if rsMain.state then rsMain.close
rsMain.Open sqlQry,conn,1, 2
i =0
do while not rsMain.EOF
	if (i mod 5 <> 0) then Response.Write "</td><td>" else Response.Write "</td></tr><tr><td>"
 %>
              <table width="119" border="0" cellspacing="0" cellpadding="0">
                <tr> 
                  <td height="20" background="../images/small_layout.jpg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                      <tr> 
                        <td width="25%">&nbsp;</td>
                        <td width="75%" valign="bottom">
                        <a href="javascript:ShowMobDet('<%=rsMain("ModelNo")%>');" class=link1>
                        <b><%=rsMain("ModelNo")%></b>
                        </a></td>
                      </tr>
                    </table></td>
                </tr>
                <tr> 
                  <td><img src="../images/mid.jpg" width="119" height="18"></td>
                </tr>
                <tr> 
                  <td height="68" background="../images/box_bg.jpg"><table width="119" border="0" cellspacing="0" cellpadding="0">
                      <tr> 
                        <td width="15">&nbsp;</td>
                        <td width="89" align="center">
                        <a href="javascript:ShowMobDet('<%=rsMain("ModelNo")%>');">
                        <img src="../images/Models/<%=rsMain("ImgFile2")%>" width="70" height="70" border=0>
                        </a>
                        </td>
                        <td width="15">&nbsp;</td>
                      </tr>
                    </table></td>
                </tr>
                <tr> 
                  <td height="19"><img src="../images/box_bot.jpg" width="119" height="27"></td>
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