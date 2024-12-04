<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
strNow = Request.Form("cboDate")
%>
<html>
<head>
<title>Phonetrade.cc [Trading Floor]</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<meta http-equiv='Expires' content='0' />
<meta http-equiv="refresh" content="600">
<meta http-equiv='Pragma' content='No-Cache' />
<script language="JavaScript" type="text/JavaScript">
<!--



function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
}
function thisWinSize()  
{
      var sw=window.screen.width;
      var sh=window.screen.height;
      window.resizeTo(sw*.31,sh*.29);
      window.moveTo(sw*.036, sh*.19); 
}
//-->
</script>
<link href="../Styles/CssStyles.css" rel="stylesheet" type="text/css">



</head>

<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<!--#include file="Top1.asp"-->
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr> 
     <td width="14%" align="center" valign="top">&nbsp; </td>
    <td colspan="2" align="left" valign="top"> 
      <form name="frmTF" method="post" action="TradingFloorNew.asp">
	<script language="JavaScript">
		function ExportTo(s)
		{
			/*  document.frmTF.target="_blank"; 
			document.frmTF.action="PhoneTrade.asp?Id="+s;
			document.frmTF.submit();
			location.target="_blank";
			location.href="PhoneTrade.asp?Id="+s;*/
			window.open("PhoneTrade.asp?Id="+s,"Excel","status=yes,menubar=yes,scrollbars=yes,resizable=yes,width=750,height=500,location=Center,left=50,top=50,resize=yes");
		}
	</script>
        <br>
        <table width="550" border="0" align="center" cellpadding="3" cellspacing="0">
          <tr align="center"> 
            <td colspan="3"><table width="231" border="0" cellspacing="0" cellpadding="0">
                <tr> 
                  <td width="23"><img src="../images/print.jpg" width="21" height="25"></td>
                  <td width="86"><a href="javascript:print();">Print this page</a></td>
                  <td width="25"><img src="../images/Excel.jpg" width="18" height="18"></td>
                  <td width="97"><a href="javascript:ExportTo('<%=strNow%>');">Open 
                    in Excel</a></td>
                </tr>
              </table>
               
            </td>
          </tr>
          <tr> 
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
          <tr> 
            <td width="216"><strong>Select the date to view postings</strong></td>
            <td width="209"><select name = "cboDate" class=textbox style="width:200px" onChange="document.frmTF.submit();">
                <% Dim ActDate,ActDate2,TodaysFlag, msgDate
                           'strSQL = " SELECT TOP 100 PERCENT CAST(CONVERT(varchar(12), ActDate) AS datetime) " & _
						   '		" FROM tMessage GROUP BY CAST(CONVERT(varchar(12), ActDate) AS datetime) " & _
							'	"ORDER BY CAST(CONVERT(varchar(12), ActDate) AS datetime) DESC"
							set rsTemp  = conn.Execute("select ActDate, convert(varchar(12), ActDate) as ActDate2 from dbo.DateValues")
							'set rsTemp  = conn.Execute(strSQL)
							TodaysFlag=false
							msgDate = ""
						  	rsTemp.MoveFirst 
						  	do while not rsTemp.EOF  
						  	ActDate=rsTemp("ActDate")
						  	ActDate2=rsTemp("ActDate2")
							if FormatDateTime(ActDate, vbShortDate)=FormatDateTime(Now(), vbShortDate)  then					
							msgDate = "Today"
							elseif FormatDateTime(ActDate, vbShortDate)=FormatDateTime(Now()-1, vbShortDate)  then
								if len(msgDate)=0 then msgDate="Today"
								msgDate =  "Yesterday and " & msgDate
							Response.Write "<option value='" & ActDate & "'>" & msgDate & "</option>"
							TodaysFlag=true
							else
						  	%>
                <option value="<%=ActDate%>"><%=ActDate2%></option>
                <% end if
				rsTemp.MoveNext 
						  	loop 
						  	set rsTemp=nothing %>
              </select> <SCRIPT LANGUAGE=javascript>
								con = "<%=strNow%>"
								if (con.length==0) 
								 con = "1" 
								for (i=0;i<document.frmTF.cboDate.length;i++)
									if (document.frmTF.cboDate.options[i].value==con)
										document.frmTF.cboDate.selectedIndex = i;
							</SCRIPT> </td>
            <td width="107">&nbsp;</td>
          </tr>
        </table>
      </form></td>
    <td align="center" valign="top">&nbsp;</td>
  </tr>
  <tr> 
    <td width="14%" height="560" align="center" valign="top">&nbsp; </td>
    <td colspan="2" align="center" valign="top"> 
      <% Dim rsMain
	Dim Title, Message, ActTime
	Dim MemberCode, msg, Flag, strTime
	Dim strNow
	'''Commented on 27th June as per ash req.
	'''strNow = DateAdd("d",-2,date)
	'''strNow = "Delete from tMessage where DATEPART(YEAR, ActDate) = '" & year(strNow) & "' AND " & _
	'''	"DATEPART(MONTH,Actdate) = '" & Month(strNow) & "' AND DATEPART(DAY, Actdate) <= '" & Day(strNow) & "'"
	
	'Response.Write strNow
	'''Conn.execute strNow
	'''Added on 18th July
	'if len(strNow & "")=0 and TodaysFlag then 
	'	strNow = Now()
	'elseif len(strNow & "")=0 and TodaysFlag=false then
	'	strNow =dateadd("d",-1, Now())
	'end if
	set rsMain = server.CreateObject("Adodb.Recordset")
	'rsMain.open "Select * from tMessage ORDER BY ActDate DESC", conn,3,3
	if len(strNow & "")=0 or FormatDateTime(strNow, vbShortDate)=FormatDateTime(Now()-1, vbShortDate) then 
		strNow =dateadd("d",-1, Now())
		strSQL= "Select MessageCode, MemberCode, MessageType, MessageTitle, Message, ActDate from tMessage " & _
		" Where Datepart(Year,ActDate)='" & Year(strNow) & "' and Datepart(Month,ActDate)='" & Month(strNow) &  "' " & _
		" and Datepart(day,ActDate)>='" & Day(strNow) &  "' ORDER BY ActDate DESC"
	else	
		strSQL= "Select MessageCode, MemberCode, MessageType, MessageTitle, Message, ActDate from tMessage " & _
		" Where Datepart(Year,ActDate)='" & Year(strNow) & "' and Datepart(Month,ActDate)='" & Month(strNow) &  "' " & _
		" and Datepart(day,ActDate)='" & Day(strNow) &  "' ORDER BY ActDate DESC"
	end if
	rsMain.open strSQL, conn,3,3
	'Response.Write(strSQL)
	'Response.End()
do while not rsMain.eof
	MessageCode=rsMain("MessageCode")
	MemberCode = rsMain("MemberCode")
	MsgCat = rsMain("MessageType")
	Title = rsMain("MessageTitle")
	Message=rsMain("Message")
	ActTime=rsMain("ActDate")
	
	if MsgCat=1 Then
		MsgCat="Buy"
	Else
		MsgCat="Sell"
	End if 
	'Commented on july 26th
	'strTime = Day(ActTime) & " " & MonthName(month(ActTime)) & ", " & TimeValue(FormatDateTime(ActTime,vbLongTime))
	'pos = instr(strTime,":")
	'pos  = instr(pos+1,strTime,":")
	'ActTime =  mid(strTime,1,pos-1) & " "  & mid(strTime,pos+3)
	strTime = Day(ActTime) & " " & MonthName(month(ActTime)) & ", " & FormatDateTime(ActTime,vbShortTime)
	ActTime =strTime
	Flag="Yes"
	'if FormatDateTime(ActTime, vbShortDate)<FormatDateTime(Now()-2, vbShortDate)  then
	'	rsMain.Delete
	'	Flag="No"
	'else'if FormatDateTime(ActTime, vbShortDate) =FormatDateTime(Now(), vbShortDate)  then
	'	strTime = Day(ActTime) & " " & MonthName(month(ActTime)) & ", " & TimeValue(FormatDateTime(ActTime,vbLongTime))
	'	
	'	pos = instr(strTime,":")
	'	pos  = instr(pos+1,strTime,":")
	'	ActTime =  mid(strTime,1,pos-1) & " "  & mid(strTime,pos+3)
	'	'Commented on 7th june
	'	'strTime = FormatDateTime(ActTime, vbLongTime) 
		'pos = instr(strTime,":")
		'pos = instr(pos+1,strTime,":")
		'ActTime="Today, " & mid(strTime,1,pos-1) & " "  & mid(strTime,pos+3)
	'	Flag="Yes"
	'Commented on 7th june
	'Elseif FormatDateTime(ActTime, vbShortDate) =FormatDateTime(Now()-1, vbShortDate)  then
	'	strTime = Day(ActTime) & " " & MonthName(month(ActTime)) & ", " & TimeValue(FormatDateTime(ActTime,vbLongTime))
	'	pos = instr(strTime,":")
	'	pos  = instr(pos+1,strTime,":")
	'	ActTime =  mid(strTime,1,pos-1) & " "  & mid(strTime,pos+3)

		'Commented on 7th june
		'strTime = FormatDateTime(ActTime, vbLongTime) 
		'pos = instr(strTime,":")
		'pos = instr(pos+1,strTime,":")
		'ActTime="Today, " & mid(strTime,1,pos-1) & " "  & mid(strTime,pos+3)	
		''''ActTime="Yesterday, " & mid(strTime,1,4) & " " & mid(strTime,9)
	'	Flag="Yes"
	'end if	
	if Flag="Yes" then
		Dim rsMain1
		set rsMain1 = server.CreateObject("Adodb.Recordset")
		Dim CompanyName,cCode
		Dim PhoneNo, MobileNo, FaxNo, urName
		Dim ImgLogo, bgColValue
	
		rsMain1.open "Select * from Members where MemberCode=" & MemberCode & "and Activateflag=1", conn,2,1
		if not rsMain1.eof then
			CompanyName = rsMain1("CompanyName")
			PhoneNo = rsMain1("PhoneNo")
			MobileNo=rsMain1("MobileNo")
			FaxNo=rsMain1("FaxNo")
			ImgLogo=rsMain1("ImgLogo") & ""
			bgColValue=rsMain1("ColourValue")
			cCode=rsMain1("CountryCode")
			urName=rsMain1("YOurName")
				SecondContact = rsMain1("SecondContact") & ""
			MobileNo2 = rsMain1("MobileNo2") & ""

 %>
      <table width="550" border="0" cellspacing="0" cellpadding="0">
        <tr> 
          <td width="750"><table width="550" border="0" cellpadding="0" cellspacing="1" bgcolor="AEAEAE">
              <tr>
                <td width="748" bgcolor="#F0F0F0"><table width="548" border="0" cellspacing="0" cellpadding="0">
                    <tr> 
                      <td width="14">&nbsp;</td>
                      <td width="404"><font size="2" color=white face="Arial, Helvetica, sans-serif"><SPAN style="FONT-WEIGHT: bold; FONT-SIZE: 10pt"><FONT 
					       color="<%=bgColValue%>"><%=Title%></FONT></SPAN></font></td>
                      <td width="322" align="right"><FONT color="<%=bgColValue%>"><%=ActTime%>&nbsp;(GMT)</FONT></td>
                      <td width="8" align="right">&nbsp;</td>
                    </tr>
                  </table></td>
              </tr>
            </table>
            
          </td>
        </tr>
        <tr> 
          <td height="16"><table width="550" border="0" cellpadding="0" cellspacing="1" bgcolor="AEAEAE">
              <tr> 
                <td width="748" height="72" valign="top" bgcolor="#FFFFFF"><table width="100%" border="0" cellspacing="0" cellpadding="3">
                    <tr> 
                      <td width="1%">&nbsp;</td>
                      <td width="73%"><font color="#000000"><%=replace(Message,vbcrlf,"<br>")%></font> 
                      </td>
                      <td align="center" bgcolor="#F0F0F0"><A 
      href="TraderDetails.asp?Code=<%=MemberCode%>" ><B><%=CompanyName %></B></A><br>
                              <% if len(ImgLogo)>0 then%>
                              <A href="TraderDetails.asp?Code=<%=MemberCode%>" ><IMG src="../Images/Logo/<%=ImgLogo%>" border=0> 
                              <br>
                              </A> 
                              <%else%>
                              <IMG src="../Images/Logo/noimage.gif" border=0> 
                              <%end if%></td>
                    </tr>
                    <tr> 
                      <td colspan="3"><table width="100%" border="0" cellspacing="0" cellpadding="3">
                          <tr height="1" bgcolor="<%=bgColValue%>"> 
                            <td colspan="4"></td>
                          </tr>
                          <tr> 
                            <td width="6%" bgcolor="#ededed"><table width="60" height="36" border="0" cellpadding="0" cellspacing="0">
                                <tr> 
                                  <td width="33" height="36"><table width="30" border="0" cellpadding="0" cellspacing="1" bgcolor="#FFFFFF">
                                      <tr> 
                                        <td><img src="../images/flags/<%=cCode%>.jpg" width="60" height="36"></td>
                                      </tr>
                                    </table></td>
                                  <td width="1" background="../images/tf1.jpg"></td>
                                </tr>
                              </table></td>
                            <td width="28%" bgcolor="<%=bgColValue%>"><font color="#FFFFFF"><strong>Contact&nbsp;<br>
                              </strong>Tel : 
                              <%
if PhoneNo<>"C*A*P" then
	pos = instr(PhoneNo, "*")
	PhCountry = mid(PhoneNo,1,pos-1)
	PhoneNo = mid(PhoneNo,pos+1)
	pos = instr(PhoneNo, "*")
	PhArea = mid(PhoneNo,1,pos-1)
	PhoneNo = mid(PhoneNo,pos+1)
	if PhArea="A" then 
		Response.Write "+" & PhCountry & " " & PhoneNo 
	else
		Response.Write "+" & PhCountry & " (" & PhArea & ") " & PhoneNo 
	end if
else 
Response.Write "--"
end if
%>
                              </font></td>
                            <td width="33%" bgcolor="<%=bgColValue%>"><font color="#FFFFFF">Name: 
                              <font size="2" face="Arial, Helvetica, sans-serif"><B><%=UrName %></B></font><br>
                              Mob: 
                              <%
if MobileNo<>"C*M*MN" then
	pos = instr(MobileNo, "*")
	PhCountry = mid(MobileNo,1,pos-1)
	MobileNo = mid(MobileNo,pos+1)
	pos = instr(MobileNo, "*")
	PhArea = mid(MobileNo,1,pos-1)
	MobileNo = mid(MobileNo,pos+1)
	if PhArea="A" then 
		Response.Write "+" & PhCountry & " " & MobileNo 
	else
		Response.Write "+" & PhCountry & " (" & PhArea & ") " & MobileNo 
	end if
else 
Response.Write "--"
end if
%>
                              </font> </td>
                            <td width="33%" bgcolor="<%=bgColValue%>"> <font color="#FFFFFF" size="2" face="Arial, Helvetica, sans-serif"><b> 
                              <%
							 if len(SecondContact)>0 then Response.Write(SecondContact)
							  %>
                              <br>
                              </b> 
                              <%
if MobileNo2<>"C*M*MN" then
	pos = instr(MobileNo2, "*")
	PhCountry = mid(MobileNo2,1,pos-1)
	MobileNo2 = mid(MobileNo2,pos+1)
	pos = instr(MobileNo2, "*")
	PhArea = mid(MobileNo2,1,pos-1)
	MobileNo2 = mid(MobileNo2,pos+1)
	if PhArea="A" then 
		Response.Write "+" & PhCountry & " " & MobileNo2
	else
		Response.Write "+" & PhCountry & " (" & PhArea & ") " & MobileNo2
	end if
else 
Response.Write "&nbsp;"
end if
%>
                              </font> </td>
                          </tr>
                        </table></td>
                    </tr>
                  </table></td>
              </tr>
            </table></td>
        </tr>
      </table>
      <%
			rsMain1.close
		end if
	End if
	rsMain.movenext
	Response.Write "<br>"
Loop
rsMain.close
%>
    </td>
    <td width="14%" align="center" valign="top">&nbsp;</td>
  </tr>
  <tr> 
    <td height="19" valign="top">&nbsp;</td>
    <td width="34%" align="center" valign="top">&nbsp;</td>
    <td width="38%" valign="top">&nbsp;</td>
    <td valign="top">&nbsp;</td>
  </tr>
</table>
</body>
</html>
