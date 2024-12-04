<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
	Dim rsMain
	Dim strNow
	strNow = date'dateadd("n", -30,dateadd("h", -5, date))
	set rsMain = server.CreateObject("Adodb.Recordset")
	sql="Select MessageCode, MemberCode, MessageType, MessageTitle, Message, ActDate from tMessage " & _
			" where DATEPART(YEAR, ActDate) = '" & year(strNow) & "' AND " & _
			" DATEPART(MONTH,Actdate) = '" & Month(strNow) & "' AND DATEPART(DAY, Actdate) = '" & Day(strNow) & "'" & _
			" ORDER BY ActDate DESC"
rsMain.open sql,conn,3,3
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
          <td width="10">&nbsp;</td>
          <td width="598">&nbsp;</td>
          <td width="11">&nbsp;</td>
        </tr>
        <tr> 
          <td>&nbsp;</td>
          <td><font size="2" face="Arial, Helvetica, sans-serif">Dear Member,</font> 
            <p><font size="2" face="Arial, Helvetica, sans-serif">There are <%if not rsMain.eof then Response.Write(rsMain.RecordCount)%>
              new listings posted today on PhoneTrade.cc. For detailed <br>
              listing information, Please visit: <a href="http://www.phonetrade.cc/TradingFloor.asp" target="_blank">http://www.phonetrade.cc/TradingFloor.asp</a>.<br>
              </font></p>
            <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#999999">
              <tr>
                <td bgcolor="#FFFFFF"><table width="100%" border="0" cellspacing="1" cellpadding="0">
                    <%do while not rsMain.eof%>
                    <tr> 
                      <td><font size="2" face="Verdana, Arial, Helvetica, sans-serif">Posted 
                        On</font></td>
                      <td><font size="2" face="Verdana, Arial, Helvetica, sans-serif"> 
                        <%ActTime=rsMain("ActDate")
	strTime = Day(ActTime) & " " & MonthName(month(ActTime)) & ", " & TimeValue(FormatDateTime(ActTime,vbLongTime))
	pos = instr(strTime,":")
	pos  = instr(pos+1,strTime,":")
	ActTime =  mid(strTime,1,pos-1) & " "  & mid(strTime,pos+3)
	Response.Write(ActTime)
				%>
                        </font></td>
                    </tr>

                    <tr> 
                      <td width="26%"><font size="2" face="Verdana, Arial, Helvetica, sans-serif">Message 
                        Title</font></td>
                      <td width="74%"><font size="2" face="Verdana, Arial, Helvetica, sans-serif"> 
                       <b> <%=rsMain("MessageTitle")%></b> </font></td>
                    </tr>
                    <tr> 
                      <td valign="Top"><font size="2" face="Verdana, Arial, Helvetica, sans-serif">Posted 
                        Message</font></td>
                      <td><font size="2" face="Verdana, Arial, Helvetica, sans-serif"><%=replace(rsMain("Message"),vbcrlf,"<br>")%></font></td>
                    </tr>
                    <tr> 
                      <td colspan="2"><hr></td>
                    </tr>
                    <%rsMain.MoveNext
loop%>
                  </table></td>
              </tr>
            </table>
            <p><font size="2" face="Arial, Helvetica, sans-serif">To change your 
              mail alert setting, Please login into your member area <a href="http://www.phonetrade.cc/Login.asp" target="_blank">http://www.phonetrade.cc/Login.asp</a><br>
              </font></p>
            <p><font size="2" face="Arial, Helvetica, sans-serif">Best regards 
              and thanks.</font></p>
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
