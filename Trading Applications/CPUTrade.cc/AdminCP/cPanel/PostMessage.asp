<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
if len(Session("sLogmeinadmin"))=0 then
	Response.Redirect "Login.asp"	
end if
Dim strSelect, strAction
    if len(Request.QueryString("Memb"))=0 then
	strSelect=Request.Form("cboMembName")
	if len(strSelect & "")=0 then strSelect = 1
	else
	strSelect = Request.QueryString("Memb")
	end if
	Dim rsMain
    Set rsMain = Server.CreateObject("ADODB.Recordset")
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

<title>Post Messages</title><body topmargin="0" leftmargin="0" Rightmargin="0" bottommargin="0">
<!--#include file="Top1.asp"-->
<table width="100%" border="0" cellspacing="0" cellpadding="0">
              <!--DWLayoutTable-->
              <tr> 
                <td width="11" height="14"></td>
                
    <td width="100%"  valign="top"> 
	<form name="frmPostMsg" method="post" action=""  onSubmit="JavaScript:return FormSubmit();">
                    <input type=hidden name="hdProc" value="">
        <input type=hidden name="hdMemberName" value="">
        <script language=Javascript>
		function move()
		{
			document.frmPostMsg.action = "PostMessage.asp";
			document.frmPostMsg.submit();
		}
		</script>
        <table width=70% border=0 align=Center class="Border">
                <tr align="left"> 
                  
          <td Colspan=3 class="HeadingWithBackGround">Select Member</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="18%" align=right class="contact">Member Name</td>
                  <td width="63%"> <select name="cboMembName" style="width:250px">
                      <%
sSQL = "select CompanyName,MemberCode from Members where Activateflag=1 order by CompanyName"
if rsMain.State then rsMain.Close 
rsMain.Open sSQL,conn,2,1
do while not rsMain.EOF 
if strSelect=MemberCode Then					%>
					
                      <option value="<%=rsMain("MemberCode")%>" selected><%=rsMain("CompanyName")%></option>
                      <%else %>
					  <option value="<%=rsMain("MemberCode")%>" ><%=rsMain("CompanyName")%></option>
					  <%End if
rsMain.MoveNext 
loop
rsMain.Close
%>
                    </select> &nbsp; <SCRIPT LANGUAGE=javascript>
con = "<%=strSelect%>" 
for (i=0;i<document.frmPostMsg.cboMembName.length;i++)
if (document.frmPostMsg.cboMembName.options[i].value==con)
document.frmPostMsg.cboMembName.selectedIndex = i;
</SCRIPT> <input type=button onClick="return move();" name=btnGo value=" Go "> 
                  </td>
                  <td width="19%">&nbsp;</td>
                </tr>
                <tr height=2> 
                  <td colspan="3" align=right class="HeadingWithBackGround"></td>
                </tr>
                <tr> 
                  <td></td>
                  <td>&nbsp; </td>
                  <td>&nbsp;</td>
                </tr>
              </table>
		
		          
                    <script language=javascript>
 function FormSubmit()
{
		//errStr = "The following error(s) occurred:\n";
		var CanSubmit = false;
		errStr = "";
		CanSubmit = ForceEntry(document.forms["frmPostMsg"].txtTitle,"    - Message title is required.");	
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmPostMsg"].txtMessage,"    - Message is required.");
		if (document.forms["frmPostMsg"].txtMessage.value.length>0)
			CanSubmit = CanSubmit & LenCheck(document.forms["frmPostMsg"].txtMessage,750,"    - Message entry should be less than 750 characters!.");		
		CanSubmit = (CanSubmit!=0)
		if (CanSubmit)
			CanSubmit = CanSubmit & LenCheck(document.forms["frmPostMsg"].txtMessage,750,"    - Message entry should be less than 750 characters!.");		
		CanSubmit = (CanSubmit!=0)
		if (CanSubmit==false) 
		{
		alert(errStr);
			' sErrMsg=errStr;'
			return false;
		}
		else
		{
			document.frmPostMsg.hdMemberName.value=	document.frmPostMsg.cboMembName.options[document.frmPostMsg.cboMembName.selectedIndex].text;
		    if ("<%=request.QueryString("MsgCode")%>"!="")
			{
			document.frmPostMsg.hdProc.value="2"
			document.frmPostMsg.action="InsertMsg.asp?MsgCode=<%=request.QueryString("MsgCode")%>";
'			document.frmPostMsg.submit(); '
			}
			else
			{
			document.frmPostMsg.hdProc.value="1"
			document.frmPostMsg.action="InsertMsg.asp";
'			document.frmPostMsg.submit(); '
			}
			 
		}
}

</script>
        <%if ucase(Request.QueryString("MsgCode"))<>"NOTHING" and Request.QueryString("MsgCode")<>"" and len(Request.QueryString("MsgCode"))>0 then 

	Dim Code
	Code=Request.QueryString("MsgCode")
	'set rsMain = server.CreateObject("Adodb.Recordset")
  	rsMain.open "Select * from tMessage where MessageCode=" & Code & "ORDER BY MessageCode DESC", conn,2,1
	if not rsMain.eof then
	MsgType=rsMain("MessageType")
	Title = rsMain("MessageTitle")
	Message=rsMain("Message")
	rsMain.Close
	end if
end if	
%>
        <%'	Dim rsMain	
	Dim Title, Message
	Dim MessageCode,ActTime
	Dim MemberCode, msg,Flag
 %>
        <table width="70%"  border=0 align="center">
          <tr> 
            <td class=HeadingWithBackGround align=left colspan=2>Post message</td>
          </tr>
          <!--<tr class=TableBackGround> 
            <td width="29%" height="30" align=right class="contact">&nbsp;</td>
            <td> 
              <% 'if MsgType=2 then %>
              <input type="radio" name="rdoType" value="1" > Buy 
              <input type="radio" name="rdoType" value="2" checked> Sell 
              <%'else%>
              <input type="radio" name="rdoType" value="1" checked > Buy 
              <input type="radio" name="rdoType" value="2" > Sell
              <%'End if%>
            </td>
          </tr>
-->          <tr class=TableBackGround> 
            <td width="29%" align=right class="contact">Title*</td>
            <td><input class=TextBox style="width: 250;" maxlength=100 name=txtTitle value="<%=Title%>"></td>
          </tr>
          <tr class=TableBackGround> 
            <td align=right class="contact">Message*</td>
            <td><textarea name="txtMessage" cols="60" rows="4" id="txtMessage" style="width: 450px; height: 100px;"><%=Message%></textarea></td>
          </tr>
          <tr class=TableBackGround> 
            <td align=right>&nbsp;</td>
            <td><input class=Buttons type=submit value="     Save      " name=btnOk> 
              <input class=Buttons  type=reset value=" Clear " name=btnCancel></td>
          </tr>
        </table>
                  </form></td>
                <td width="10"></td>
              </tr>
              <tr> 
                <td>&nbsp;</td>
                <td align="center">&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
              <tr> 
                <td>&nbsp;</td>
                
    <td align="center"><!--DWLayoutEmptyCell-->&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
              <tr> 
                <td></td>
                
    <td valign="top"> 
      <%'set rsMain = server.CreateObject("Adodb.Recordset")
	rsMain.open "Select * from tMessage where MemberCode=" & strSelect & "order by ActDate DESC", conn,3,3
	While not rsMain.eof
	MessageCode=rsMain("MessageCode")
	MemberCode = rsMain("MemberCode")
	MsgCat=rsMain("MessageType")
	Title = rsMain("MessageTitle")
	Message=rsMain("Message")
	ActTime=rsMain("ActDate")
	Flag="Yes"
	'if MsgCat=1 Then
	'MsgCat="Buy"
	'Else
	'MsgCat="Sell"
	'End if 

	'if FormatDateTime(ActTime, vbShortDate)<FormatDateTime(Now()-2, vbShortDate)  then
	'rsMain.Delete
	'Flag="No"
	'elseif FormatDateTime(ActTime, vbShortDate) =FormatDateTime(Now(), vbShortDate)  then
	'ActTime="Today"
	'Flag="Yes"
	'Else
	'ActTime=FormatDateTime(ActTime, vbShortDate) 
	'Flag="Yes"
	'end if
	
'	if left(ActTime,10)=left(Now,10) then
'	ActTime="Today"
'	Else
'	ActTime=left(ActTime,10)
'	end if

	if Flag="Yes" then
	Dim rsMain1
	set rsMain1 = server.CreateObject("Adodb.Recordset")
	Dim CompanyName
	Dim PhoneNo
	Dim ImgLogo

	rsMain1.open "Select * from Members where MemberCode=" & MemberCode, conn,2,1
	if not rsMain1.eof then
	CompanyName = rsMain1("CompanyName")
	PhoneNo = rsMain1("PhoneNo")
	ImgLogo=rsMain1("ImgLogo")
 	end if
%>
      <TABLE  align="center" 
style="BORDER-RIGHT: black 2px solid; BORDER-TOP: black 2px solid; BORDER-LEFT: black 2px solid; BORDER-BOTTOM: black 2px solid" 
cellSpacing=2 cellPadding=4 width=96%  bgColor=white border=0>
        <!--DWLayoutTable-->
        <TBODY >
          <TR bgColor=CACDC4> 
            <TD height="26" style="FONT-SIZE: 8pt"><FONT  color="064a79"><%=ActTime%></FONT><FONT  color="064a79"> 
            </TD>
            <TD width="295" align=middle valign="top"><SPAN style="FONT-WEIGHT: bold; FONT-SIZE: 10pt"><FONT 
      color=064a79><%=Title%></FONT></SPAN></TD>
            <TD width="96" valign="top" align="center"><strong><a href="PostMessage.asp?Msgcode=<%=MessageCode%>&Memb=<%=MemberCode%>" class="link1">Edit</a></strong></TD>
            <TD width="169" valign="top"><strong><a href="InsertMsg.asp?Delete=<%=MessageCode%>&Memb=<%=MemberCode%>" class="link1">Delete</a></strong></TD>
          </TR>
          <TR> 
            <TD height="137" vAlign=top bgcolor="whitesmoke" style="FONT-SIZE: 8pt"> 
              <P><B><%=CompanyName %> </B></P>
              <IMG 
      src="..\Images\Logo\<%=ImgLogo%>" border=0><BR> <BR> </TD>
            <TD colspan="3"><font color="#000000"><%=Message%></font></TD>
          </TR>
        </TBODY>
      </TABLE>
                  <br> 
                  <%
    rsMain1.close
	end if 
	rsMain.movenext
	Wend
	rsmain.close
%>
                </td>
                <td></td>
              </tr>
              <tr> 
                <td>&nbsp;</td>
                <td align="center">&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
            </table>
</body>
</html>
