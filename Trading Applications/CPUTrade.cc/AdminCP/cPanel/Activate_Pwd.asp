
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
dim mem, usr, pd
mem= Request.QueryString("mem")
mem = Replace(mem,"@*@","&")
usr= Request.QueryString("usr1")
pd= Request.QueryString("pd")
%>
<html>
<head>
<title>mail</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
</head>

<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<table width="620" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td><img src="http://www.phonetrade.cc/Images/nl_top.jpg" width="620" height="74"></td>
  </tr>
</table>
<table width="620" border="0" cellpadding="0" cellspacing="1" bgcolor="2B80D3">
  <tr>
    <td height="214" valign="top" bgcolor="#FFFFFF"><br>
      <table width="619" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td align="center"><table width="550" border="0" cellpadding="0" cellspacing="1" bgcolor="2B80D3">
              <tr> 
                <td height="41" align="center" bgcolor="#FFFFCC"><font size="4" face="Verdana, Arial, Helvetica, sans-serif">Password 
                  has been changed for security reason!!! </font></td>
              </tr>
            </table></td>
        </tr>
      </table>
      <table width="619" border="0" cellspacing="0" cellpadding="0">
        <tr> 
          <td width="10">&nbsp;</td>
          <td width="598">&nbsp;</td>
          <td width="11">&nbsp;</td>
        </tr>
        <tr> 
          <td>&nbsp;</td>
          <td><font size="2" face="Arial, Helvetica, sans-serif">Dear <b><%=mem%></b> 
            ,</font> <p><font size="2" face="Arial, Helvetica, sans-serif">This 
              is a request to all members to kindly change your <b>PASSWORD</b> to log-in 
              at the website since it seems your password has not been changed 
              for a long time, for security reason our automatic password authentication 
              program generated a random password to login into your account.<br>
              <br>
              Also, please review your contact information.<br>
              </font><font size="2" face="Arial, Helvetica, sans-serif"><a href="http://www.phonetrade.cc/Login.asp" target="_blank"><br>
              http://www.phonetrade.cc/Login.asp</a><br>
              Username: <strong><%=usr%></strong><br>
              Password: <strong><%=pd%></strong></font></p>
            <p><font size="2" face="Arial, Helvetica, sans-serif">Please keep 
              this email for your records. </font></p>
            <p><font size="2" face="Arial, Helvetica, sans-serif">Should you have 
              any problems, please contact <a href="mailto:info@phonetrade.cc">info@phonetrade.cc</a><br>
              Best regards and thanks you for registering.</font></p>
            <p><font size="2" face="Arial, Helvetica, sans-serif"> PhoneTrade.cc<br>
              <a href="mailto:info@phonetrade.cc">info@phonetrade.cc</a></font><font size="2" face="Arial, Helvetica, sans-serif"><br>
              </font></p>
            </td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
      </table> </td>
  </tr>
</table>
</body>
</html>
