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
<form name="frmStats" method="post" action="Stats.asp">
  <br>
  <table width="80%" border="0" align="center" cellpadding="0" cellspacing="0">
    <tr> 
      <td valign="top"> <%
Dim rsMain
	set rsMain=server.CreateObject("ADODB.Recordset")
	strSQL= "select * from Adv_Enquiry order by [Timestamp] desc, AdvId desc"
	rsMain.open strSQl,conn,3,2
%> 
        <table width="80%" border="0" align="center" cellpadding="3" cellspacing="0" style="Border: 1px solid #999999;">
          <tr class="HeadingWithBackGround"> 
            <td colspan="6">Advertisement Enquiries from the member(s)</td>
          </tr>
		   <tr class="HeadingWithBackGround"> <td>Company Name</td>
            <td>Contact person</td>
            <td>Phone No</td>
            <td>Email</td>
            <td>Comments</td>
            <td>Enquiried On</td>			
          </tr>
          <% i =0
	do while not rsMain.eof %>
          <tr class="<%if i mod 2 = 0 then Response.Write("OddRowContent") else Response.Write("EvenRowContent")%>"> 
            <td><%=rsMain("CompanyName")%></td>
            <td><%=rsMain("ContactName")%></td>
            <td><%=rsMain("Phone")%></td>
            <td><%=rsMain("Email")%></td>
            <td><%=replace(rsMain("Comments"),vbcrlf,"<BR>")%></td>
            <td><%=rsMain("TimeStamp")%></td>			
          </tr>
          <%rsMain.movenext
	i=i+1
	loop%>
          <tr> 
            <td width="27%">&nbsp;</td>
            <td width="73%">&nbsp;</td>
            <td width="73%">&nbsp;</td>
            <td width="73%">&nbsp;</td>
          </tr>
        </table></td>
    </tr>
  </table>
  <br>
</form>
</body>
</html>
