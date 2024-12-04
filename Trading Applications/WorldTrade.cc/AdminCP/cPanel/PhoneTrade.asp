<% 
	Response.ContentType = "application/vnd.ms-excel"
%>
<!-- #Include File = "../Main/Source.asp" -->
<%
	Const adOpenForwardOnly = 0
	Const adLockReadOnly = 1
	Const adUseClient = 3
		
	Dim rsMain, sql, strSelect
	strNow = Request.QueryString("Id")
	if len(strNow & "")=0 then 
		 strNow=FormatDateTime(Now()-1, vbShortDate)
	end if

	Set rsMain = Server.CreateObject("ADODB.Recordset")
		
%>
<html>
<head>
<title>
Phonetrade.cc [Trading Floor - Excel]
</title>
<script language="JavaScript1.2">
<!--

/***********************************************
* Auto Maximize Window Script- © Dynamic Drive (www.dynamicdrive.com)
* This notice must stay intact for use
* Visit http://www.dynamicdrive.com/ for this script and 100's more.
***********************************************/

top.window.moveTo(0,0);
if (document.all) {
top.window.resizeTo(screen.availWidth,screen.availHeight);
}
else if (document.layers||document.getElementById) {
if (top.window.outerHeight<screen.availHeight||top.window.outerWidth<screen.availWidth){
top.window.outerHeight = screen.availHeight;
top.window.outerWidth = screen.availWidth;
}
}
//-->
</script>
</head>

<body>
<p>
<a href"http://www.phonetrade.cc/"><img src="http://www.phoneTrade.cc/images/logo1.jpg" border=0></a>
</p>
<table width="600" border=0>
  <tr>
    <td height=50>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
<TABLE width="953" BORDER=1>
<tr> 
<td width="40" bgcolor="#AED7FF"><font color="#000000" face=Verdana><strong>Sr No.</strong></font></td>
<td width="111" bgcolor="#AED7FF"><font color="#000000" face=Verdana><strong>Date & Time</strong></font></td>
<td width="137" bgcolor="#AED7FF"><font color="#000000" face=Verdana><strong>Subject</strong></font></td>
<td width="321" bgcolor="#AED7FF"><font color="#000000" face=Verdana><strong>Message</strong></font></td>
<td width="159" bgcolor="#AED7FF"><font color="#000000" face=Verdana><strong>Company Name</strong></font></td>
<td width="196" bgcolor="#AED7FF"><font color="#000000" face=Verdana><strong>Contact name & Mobile No.</strong></font></td>
</tr>
<% dim i 
	if len(strNow & "")=0 or FormatDateTime(strNow, vbShortDate)=FormatDateTime(Now()-1, vbShortDate) then 
		strNow =dateadd("d",-1, Now())
		sql ="Select Members.*, REPLACE(Members.MobileNo,'*', ' ') AS Mobile, MessageCode, tMessage.MemberCode as MemberCode, MessageType, MessageTitle, Message, ActDate " & _
		"from tMessage inner join Members on tMessage.MemberCode = Members.MemberCode " & _
		" Where Datepart(Year,ActDate)='" & Year(strNow) & "' and Datepart(Month,ActDate)='" & Month(strNow) &  "' " & _
		" and Datepart(day,ActDate)>='" & Day(strNow) & "'" & _
		" Order by ActDate desc"
	else
		sql ="Select Members.*,  REPLACE(Members.MobileNo,'*', ' ') AS Mobile, MessageCode, tMessage.MemberCode as MemberCode, MessageType, MessageTitle, Message, ActDate " & _
		"from tMessage inner join Members on tMessage.MemberCode = Members.MemberCode " & _
		" Where Datepart(Year,ActDate)='" & Year(strNow) & "' and Datepart(Month,ActDate)='" & Month(strNow) &  "' " & _
		" and Datepart(day,ActDate)='" & Day(strNow) & "'" & _
		" Order by ActDate desc"
	end if
if rsMain.State then rsMain.Close 
    rsMain.Open sql,conn,adOpenForwardOnly, adLockReadOnly

do while not rsMain.EOF 
i = i + 1
if (i mod 2=0) then 
	Response.Write "<tr valign=top>" 
	colr="#ECF5FF"
else 
	Response.Write "<tr valign=top>"
	colr="#FFFFFF"
end if
%>
<td width="40" bgcolor="<%=colr%>"><font color="#000000" face=Verdana><strong><%=i%></strong></font></td> 
    <td  width="111"  bgcolor="<%=colr%>"><div align="justify"><font color="#000000" face=Verdana><%
			ActTime=rsMain("ActDate") & ""
			valDb = Day(ActTime) & " " & MonthName(month(ActTime)) & ", " & FormatDateTime(ActTime,vbShortTime)
			Response.Write  valDb
    %></font></div></td>
  <td  width="137" bgcolor="<%=colr%>"><div align="justify"><font color="#000000" face=Verdana>
	<%
	valDb=rsMain("MessageTitle") & ""
	Response.Write valDb
	%></font>
      </div></td>
  <td  width="321" bgcolor="<%=colr%>"><div align="justify"><font color="#000000" face=Verdana>
	<%
	valDb=rsMain("Message") & ""
	Response.Write valDb
	%></font>
      </div></td>
<td width="159"  bgcolor="<%=colr%>"><div align="justify"><font color="#000000" face=Verdana>
<a href="http://www.phonetrade.cc/TraderDetails.asp?Code=<%=rsMain("MemberCode")%>">
<%=rsMain("CompanyName")%></a></font></div></td>
  <td width="196" bgcolor="<%=colr%>"><div align="justify"><font color="#000000" face=Verdana>
	<%
	valDb=rsMain("YourName") & ", +" & replace(rsMain("Mobile"),"C*M*MN","Nil")
	Response.Write valDb
	%></font>
      </div></td>

</tr>
<% rsMain.MoveNext 
'i=i+1
loop
rsMain.close
%>
</table>
</body>
</html>