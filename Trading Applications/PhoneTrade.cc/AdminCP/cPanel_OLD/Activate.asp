<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
if len(Session("sLogmeinadmin"))=0 then
	Response.Redirect "Login.asp"	
end if
Dim strSelect, strAction, strMsg, strhdUpdate, strmember_id, strpassword
	strSelect=Request.Form("cboMembName")
	strAction=Request.Form("hdAction")
	strhdUpdate=Request.Form("hdUpdate")
	Response.Write(strAction)
	Response.Write(strSelect)
	Response.Write(hdUpdate)
	'Response.end
	if len(strSelect & "")=0 then strSelect = Request.QueryString("Id")
	Dim rsMain
    Set rsMain = Server.CreateObject("ADODB.Recordset")
if strAction="Done" then
	Dim strActFlag
	strActFlag = Request.Form("hdActDeact") & ""
	if strActFlag="1" then strActFlag="2" else strActFlag="1" 
		
	if strhdUpdate="DoUpdate" then

		'strmember_id=Request.Form("txtUserName")
		strpassword=Request.Form("txtpassword")

		dim rsChk, Flag
		set rsChk = Server.CreateObject("Adodb.Recordset")
		strSql = "select MemberCode, Member_id from Members where MemberCode = '" & strSelect & "'"
		rsChk.Open strSql,conn,3,2
		If Not rsChk.EOF Then 
			strmember_id =rsChk("Member_id")
'			Response.Write(strmember_id)
'			Response.End()
			Flag = "Ok"
		else
			Flag = "No"
		end if
		rsChk.Close
		Set rsChk = Nothing

		if Flag = "Ok" then
		Response.Write("Update Members set password='" & strpassword & _
			"', Activateflag=" & strActFlag & " where MemberCode=" & strSelect)
			'Response.end 
			conn.execute "Update Members set password='" & strpassword & _
			"', Activateflag=" & strActFlag & " where MemberCode=" & strSelect
			if Request.Form("chkMail")="1" then			
				''Mailing process
				dim strToMail, strName
				strToMail = Request.Form("hdEMail") 
				strName =  Request.Form("hdMember") 
									
				Dim MyCDONTSMail
				Dim objHttp
				Dim strHTML,Query
												
				'This is to send b4 activation '/Phonetrade
				'Query ="http://" & Request.ServerVariables("SERVER_NAME") & "/cPanel/Activate_email.asp?mem=" & replace(strName,"&","@*@") & "&usr1=" & strmember_id & "&pd=" & strpassword
				Query ="http://www.phonetrade.cc/AdminCp/cPanel/Activate_email.asp?mem=" & replace(strName,"&","@*@") & "&usr1=" & strmember_id & "&pd=" & strpassword
				'Response.Write(Query)
				'Response.End 
				
				Set objHttp = Server.CreateObject("Msxml2.ServerXMLHTTP")
				objHttp.open "GET", Query, False
				objHttp.send
				strHTML = objHttp.responseText
					Response.Write(strHTML)
					Response.end
					Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
					Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 
					
					Const cdoAnonymous = 0 'Do not authenticate
					Const cdoBasic = 1 'basic (clear-text) authentication
					Const cdoNTLM = 2 'NTLM
					
					Set objMessage = CreateObject("CDO.Message") 
					objMessage.Subject = "Your account is activated - Phonetrade.cc"
					objMessage.From = "info@phonetrade.cc" 
					objMessage.To = strToMail
					objMessage.HTMLBody = CStr("" & strHTML)
					
					'==This section provides the configuration information for the remote SMTP server.
					
					objMessage.Configuration.Fields.Item _
					("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2 
					
					'Name or IP of Remote SMTP Server
					objMessage.Configuration.Fields.Item _
					("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "10.4.29.4"
					
					'Type of authentication, NONE, Basic (Base64 encoded), NTLM
					objMessage.Configuration.Fields.Item _
					("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate") = cdoBasic
					
					'Your UserID on the SMTP server
					objMessage.Configuration.Fields.Item _
					("http://schemas.microsoft.com/cdo/configuration/sendusername") = "admin50534137@helpmanzil.com"
					
					'Your password on the SMTP server
					objMessage.Configuration.Fields.Item _
					("http://schemas.microsoft.com/cdo/configuration/sendpassword") = "admin"
					
					'Server port (typically 25)
					objMessage.Configuration.Fields.Item _
					("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25 
					
					'Use SSL for the connection (False or True)
					objMessage.Configuration.Fields.Item _
					("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = False
					
					objMessage.Configuration.Fields.Update
					
					'==End remote SMTP server configuration section==
					
					objMessage.Send

			end if
		else
			Flag = "NotOk"
		end if
	else
		conn.execute "Update Members set Activateflag=" & strActFlag & " where MemberCode=" & strSelect
	end if
end if

strMsg = Request.Form("txtMsg")
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

<title>Activate Membership</title>

<body topmargin="0" leftmargin="0" Rightmargin="0" bottommargin="0">
<form name=frmMain method=post>
  <TABLE border=0 cellspacing=0 cellpadding=0 width="100%">
    <tr> 
      <td>&nbsp;</td>
    </tr>
    <tr Class=MainHeading> 
      <td Align=middle>Mobile portal</td>
    </tr>
    <tr Class=SubHeading> 
      <td Align=middle>&nbsp;</td>
    </tr>
    <tr> 
      <td>&nbsp;</td>
    </tr>
    <tr> 
      <td> <table width=100% border=0 cellpadding="2">
          <tr> 
            <td width="18%" align=Center class=HeadingWithBackGround Id=Link0 onClick="JavaScript:Move('Masters.asp')" onmouseover="JavaScript:Show(0)">Master 
              entry</td>
            <td width="18%" align=Center class=HeadingWithBackGround Id=Link1 onClick="JavaScript:Move('Members.asp')" onmouseover="JavaScript:Show(1)">Member 
              Details</td>
            <td width="15%" align=Center class=HeadingWithBackGround Id=Link2 onClick="JavaScript:Move('ImageUpload.asp')" onmouseover="JavaScript:Show(2)">Upload 
              Images </td>
            <td width="16%" align=Center class=HeadingWithBackGround Id=Link3 onClick="JavaScript:Move('PostMessage.asp')" onmouseover="JavaScript:Show(3)">Post/Edit 
              Message</td>
            <td width="14%" align=Center class=HeadingWithBackGround Id=Link4 onClick="JavaScript:Logout()" onmouseover="JavaScript:Show(4)">Logout</td>
            <td width="37%" align=Center class=HeadingWithBackGround Id=Link5>&nbsp;</td>
          </tr>
        </table></td>
    </tr>
  </table>
</form>
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr> 
    <td>
<form name=frm method=post>
<input type="hidden" name="hdMember" value="">
<input type="hidden" name="hdPromote" value="">
<input type="hidden" name="hdAction" value="">


        <script language=Javascript>
		function move()
		{
			document.frm.action = "Activate.asp";
			document.frm.submit();
		}
		function Activate()
		{
		
			document.frm.hdAction.value="Done";
			document.frm.hdMember.value= document.frm.cboMembName.options[document.frm.cboMembName.selectedIndex].text;
			document.frm.action = "Activate.asp";
			document.frm.submit();
		}																
		function GoandDo()
		{
		
			document.frm.hdPromote.value= document.frm.cboSelect.options[document.frm.cboSelect.selectedIndex].value;
			document.frm.hdMember.value= document.frm.cboMembName.options[document.frm.cboMembName.selectedIndex].text;
			document.frm.action = "Promote.asp";
			document.frm.submit();
		}																
function CheckUserName()
{
	var x=document.frm.txtUserName.value;
	if (x.length==0)
	{
	alert("Please check the mark, and put the username");
	document.frm.txtUserName.focus();
	}
	else
	{
		window.open("CheckUserName.asp?chk=" + x,'Check','width=400,height=150');
	}
}

</script>
        <br>
        &nbsp;&nbsp;&nbsp; 
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr> 
            <td><table width=100% border=0 align=Center class="Border">
                <tr align="left"> 
                  <td Colspan=3 class="HeadingWithBackGround">Activate member</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="18%" align=right class="contact">Member Name</td>
                  <td width="63%"> <select name="cboMembName" style="width:250px">
                      <%
sSQL = "select member_company,MemberCode from Members order by member_company"
if rsMain.State then rsMain.Close 
rsMain.Open sSQL,conn,2,1
do while not rsMain.EOF 
%>
                      <option value="<%=rsMain("MemberCode")%>"><%=rsMain("member_company")%></option>
                      <%
rsMain.MoveNext 
loop
rsMain.Close
%>
                    </select> &nbsp; <SCRIPT LANGUAGE=javascript>
con = "<%=strSelect%>" 
for (i=0;i<document.frm.cboMembName.length;i++)
if (document.frm.cboMembName.options[i].value==con)
document.frm.cboMembName.selectedIndex = i;
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
              </table></td>
          </tr>
        </table>
<% 
    Set rsTemp = Server.CreateObject("ADODB.Recordset")
    rsTemp.Open "Select * from Members where MemberCode=" & strSelect ,conn,3,2
    if not rsTemp.EOF  then
%>
<input type="hidden" name="hdUpdate" value="<%if rsTemp("Activateflag") & ""="2" or len(rsTemp("password") & "")=0 then Response.Write "DoUpdate"%>">
<input type="hidden" name="hdEMail" value="<%=rsTemp("company_email")%>">
        <table width="60%" border=0 align=center cellpadding=0 cellspacing=2>
          <tr class="contact"> 
            <td width="28%" height="18" valign=top>member_company </td>
            <td width="2%" height="18" valign=top>:</td>
            <td width="70%" height="18"><strong> 
              <%
  valDb= rsTemp("member_company")
  Response.Write valDb
    %>
              </strong></td>
          </tr>
          <tr class="contact"> 
            <td height="18" valign=top>Member since </td>
            <td height="18" valign=top>:</td>
            <td height="18"><strong> 
              <%
  valDb= rsTemp("timestamp")
  Response.Write valDb
    %>
              </strong></td>
          </tr>
          <tr class="contact"> 
            <td height="18" valign=top>mailing_address</td>
            <td height="18" valign=top>:</td>
            <td height="18"><strong> 
              <%
  valDb= rsTemp("mailing_address")
  Response.Write valDb
    %>
              </strong></td>
          </tr>
          <tr class="contact"> 
            <td height="18" valign=top>Phone </td>
            <td height="18" valign=top>:</td>
            <td height="18"><strong> 
              <%
  valDb= rsTemp("company_phone")
  Response.Write valDb
    %>
              </strong></td>
          </tr>
          <tr class="contact"> 
            <td height="18" valign=top>Fax</td>
            <td height="18" valign=top>:</td>
            <td height="18"><strong> 
              <%
  valDb= rsTemp("company_fax")
  Response.Write valDb
    %>
              </strong></td>
          </tr>
          <tr class="contact"> 
            <td height="18" valign=top>Mobile</td>
            <td height="18" valign=top>:</td>
            <td height="18"><strong> 
              <%
  valDb= rsTemp("company_contact1_mobile")
  Response.Write valDb
    %>
              </strong></td>
          </tr>
          <tr class="contact"> 
            <td height="18" valign=top>Mail Id </td>
            <td height="18" valign=top>:</td>
            <td height="18"><strong> 
              <%
  valDb= rsTemp("company_email")
  Response.Write valDb
    %>
              </strong></td>
          </tr>
          <tr class="contact"> 
            <td height="18" valign=top>company_website </td>
            <td height="18" valign=top>:</td>
            <td height="18"><strong> 
              <%
  valDb= rsTemp("company_website")
  Response.Write valDb
    %>
              </strong></td>
          </tr>
<% if Flag="NotOk" then %>
		  <tr class="contact"> 
            <td height="18" valign=top colspan=3><font color=red>Username already exists, Please try with another username.</font></td>
          </tr>
<% end if%>
<%if rsTemp("Activateflag")&""="1" or len(rsTemp("password") & "")=0 then %>
		  <tr class="contact"> 
            <td height="18" valign=top>UserName</td>
            <td height="18" valign=top>:</td>
            <td height="18"><!--<input type=text name=txtUserName value="">
              <strong><a href="Javascript:CheckUserName();"><font color="#FF0000"><u>Check 
              Username</u></font></a></strong> -->
			  <%=rsTemp("member_id")%>
			  </td>
          </tr>
          <tr class="contact">
            <td height="18" valign=top>Password</td>
            <td height="18" valign=top>:</td>
            <td height="18"><input type=text name=txtpassword value=""></td>
          </tr>
          <tr class="contact"> 
            <td height="18" valign=top>&nbsp;</td>
            <td height="18" valign=top>&nbsp;</td>
            <td height="18"><input type=Checkbox name=chkMail value="1">Send mail to client</td>
          </tr>
<% end if%>
          <tr bgcolor="#CCCCCC" class="contact"> 
            <td height="18" valign=top><strong>Status</strong></td>
            <td height="18" valign=top>&nbsp;</td>
            <td height="18"> <strong><font color="#FF0000"> 
              <%  valDb= rsTemp("Activateflag") & ""
		 if valDb="1" then Response.Write "Active Member" else  Response.Write "Deactivated Member"
			  %>
              </font></strong></td>
          </tr>
          <tr class="contact"> 
            <td height="18" valign=top>&nbsp;</td>
            <td height="18" valign=top>&nbsp;</td>
            <td height="18"> 
              <%  valDb= rsTemp("Activateflag") & ""
		 if valDb="2" then valDb="Activate Member" else valDb="Deactivate Member"
			  %>
              <input type="hidden" name="hdActDeact" value="<%=rsTemp("Activateflag") & ""%>"> 
              <input name="btnActivate" type="button" id="btnActivate" value="<%=valDb%>" onClick="Javascript:Activate()"></td>
          </tr>
          <%
		   valDb= rsTemp("MemberLevel") & ""
		  end if%>
        </table>
        <br>
        <br>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr> 
            <td><table width=100% border=0 align=Center class="Border">
                <tr align="left"> 
                  <td Colspan=3 class="HeadingWithBackGround">Promote Membership</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td colspan="3" align=left class="contact"><b><font color=black>Select 
                    the level of membership and press Go</font></b></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="18%" align=right class="contact">&nbsp;</td>
                  <td width="63%"><select name="cboSelect" style="width:200px">
                      <option value="1">Basic Level [Traders]</option>
                      <option value="2">Silver Level [Traders & Members]</option>
                    </select> <script language=javascript>
con = "<%=valDb%>" 
for (i=0;i<document.frm.cboSelect.length;i++)
if (document.frm.cboSelect.options[i].value==con)
document.frm.cboSelect.selectedIndex = i;
</script>
                    <input type=button onClick="return GoandDo();" name=btnGo1 value=" Go "></td>
                  <td width="19%">&nbsp;</td>
                </tr>
                <tr height=2> 
                  <td colspan="3" align=right class="HeadingWithBackGround"></td>
                </tr>

                <tr> 
                  <td></td>
                  <td>&nbsp;</td>
                  <td>&nbsp;</td>
                </tr>
                <% if len(strMsg)>0 then %>
                <tr> 
                  <td colspan="3" align="center"><strong><%=strMsg%></strong></td>
                </tr>
                <%end if%>
              </table></td>
          </tr>
        </table>
        <br>
      </form>
      
    </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
  </tr>
</table>
</body>
</html>
