<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1

if len(Session("sLogmeinadmin"))=0 then
	Response.Redirect "Login.asp"	
end if
Dim strMonth, strYr
	strMonth =  Request.Form("cboMonth")
	strYr=  Request.Form("cboYear")
	if len(strMonth&"")=0 then strMonth=month(date)
	if strYr & "" = "" then strYr = Year(Date)
Dim MemberCount
Dim PostCount
MemberCount = Conn.Execute("Select count(*) from Members")(0)
PostCount = Conn.Execute("Select count(*) from tMessage")(0)
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
<form name="frmStats" method="post" action="Stats.asp">
<script language="JavaScript">
function change()
{
	document.frmStats.submit();
}
</script>
  <table width="80%" border="0" align="center" cellpadding="0" cellspacing="0">
    <tr> 
      <td width="17%"><strong>Total Members</strong></td>
      <td width="83%"><strong><%=MemberCount%></strong></td>
    </tr>
    <tr> 
      <td><strong>Total Postings</strong></td>
      <td><strong><%=PostCount%></strong></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
      <td>&nbsp;</td>
    </tr>
  </table>
  <table width="80%" border="0" align="center" cellpadding="0" cellspacing="0" style="Border: 1px solid #999999;">
  <tr class="HeadingWithBackGround"> 
      <td colspan="2">Statistics of Members &amp; Postings</td>
  </tr>
  <tr>
    <td>Select Month &amp; Year</td>
    <td><select name="cboMonth" id="cboMonth" class="TextBox" style="Width: 100px;">
          <option value="1">Jan</option>
          <option value="2">Feb</option>
          <option value="3">Mar</option>
          <option value="4">Apr</option>
          <option value="5">May</option>
          <option value="6">June</option>
          <option value="7" selected>July</option>
          <option value="8">Aug</option>
          <option value="9">Sept</option>
          <option value="10">Oct</option>
          <option value="11">Nov</option>
          <option value="12">Dec</option>
        </select>
        <script language=javascript>
mm="<%=strMonth%>"
for (i=0;i<document.frmStats.cboMonth.length;i++)
if (document.frmStats.cboMonth.options[i].value==mm)
{
	document.frmStats.cboMonth.selectedIndex = i;
	}
</script> 
        <select name="cboYear" id="cboYear">
          <option value="2005" selected>2005</option>
          <option value="2006">2006</option>
          <option value="2007">2007</option>
          <option value="2008">2008</option>
          <option value="2009">2009</option>
          <option value="2010">2010</option>
        </select>
<SCRIPT LANGUAGE=javascript>
mm="<%=strYr%>"
for (i=0;i<document.frmStats.cboYear.length;i++)
if (document.frmStats.cboYear.options[i].value==mm)
{
	document.frmStats.cboYear.selectedIndex = i;
	}
</script>
        <input type="submit" name="Submit" value="GO" onClick="javascript:change();"> </td>
  </tr>
  <tr> 
      <td width="27%">&nbsp;</td>
    <td width="73%">&nbsp;</td>
  </tr>
</table>
  <br>
  <table width="80%" border="0" align="center" cellpadding="0" cellspacing="0">
    <tr> 
      <td width="50%" valign="top"> 
        <%
Dim rsMain
	set rsMain=server.CreateObject("ADODB.Recordset")
	strSQL= "select Convert(varchar(12),[timestamp]), count(*) from Members " & _
	"Where Datepart(Month,[timestamp])='" & strMonth & "'" & _
	" and Datepart(Year,[timestamp])='" & strYr & "'" & _
	" group by Convert(varchar(12),[timestamp])  Order by Convert(varchar(12),[timestamp]) desc"
	rsMain.open strSQl,conn,3,2
%>
        <table width="80%" border="0" align="center" cellpadding="3" cellspacing="0" style="Border: 1px solid #999999;">
          <tr class="HeadingWithBackGround"> 
            <td colspan="2">Statistics of Members</td>
          </tr>
          <% i =0
	do while not rsMain.eof %>
          <tr class="<%if i mod 2 = 0 then Response.Write("OddRowContent") else Response.Write("EvenRowContent")%>"> 
            <td><%=rsMain(0)%></td>
            <td><%=rsMain(1)%></td>
          </tr>
          <%rsMain.movenext
	i=i+1
	loop%>
          <tr> 
            <td width="27%">&nbsp;</td>
            <td width="73%">&nbsp;</td>
          </tr>
        </table></td>
      <td width="50%" valign="top">
        <%
  Dim rsPostings
	set rsPostings=server.CreateObject("ADODB.Recordset")
	strSQL= "select Convert(varchar(12),ActDate), count(*) from tMessage " & _
	"Where Datepart(Month,ActDate)='" & strMonth & "'" & _
	" and Datepart(Year,ActDate)='" & strYr & "'" & _
	" group by Convert(varchar(12),ActDate)  Order by Convert(varchar(12),ActDate) desc"
	if rsPostings.state then rsPostings.close
	rsPostings.open strSQl,conn,3,2
%>
        <table width="80%" border="0" align="center" cellpadding="3" cellspacing="0" style="Border: 1px solid #999999;">
          <tr class="HeadingWithBackGround"> 
            <td colspan="2">Statistics of Postings</td>
          </tr>
          <% i =0
	do while not rsPostings.eof %>
          <tr class="<%if i mod 2 = 0 then Response.Write("OddRowContent") else Response.Write("EvenRowContent")%>"> 
            <td><%=rsPostings(0)%></td>
            <td><%=rsPostings(1)%></td>
          </tr>
          <%rsPostings.movenext
	i=i+1
	loop%>
          <tr> 
            <td width="27%">&nbsp;</td>
            <td width="73%">&nbsp;</td>
          </tr>
        </table></td>
    </tr>
  </table>
  <br>
</form>
</body>
</html>
