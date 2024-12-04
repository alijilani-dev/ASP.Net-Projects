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

	if len(strSelect & "")=0 then strSelect = Request.QueryString("Id")
	Dim rsMain
    Set rsMain = Server.CreateObject("ADODB.Recordset")
	if strAction="Done" then
	Dim strActFlag
	strActFlag = Request.Form("hdActDeact") & ""
	if strActFlag="1" then strActFlag="2" else strActFlag="1" 
		
	if strhdUpdate="DoUpdate" then

		strmember_id=Request.Form("txtUserName")
		strpassword=Request.Form("txtpassword")

			Flag = "Ok"
		if	Flag = "Ok" then
sql="Update Members set member_id='" & strmember_id & "', password='" & strpassword & _
			"', Activateflag=" & strActFlag & " where MemberCode=" & strSelect

			conn.execute sql
			if Request.Form("chkMail")="1" then			
				''Mailing process
				dim strToMail, strName
				strToMail = Request.Form("hdEMail") 
				strName =  Request.Form("hdMember") 
									
				Dim MyCDONTSMail
				Dim objHttp
				Dim strHTML,Query
												
				'This is to send b4 activation '/Phonetrade
			strHTML = "<html><head><title>PhoneTrade.cc</title><link href=""body.css"" rel=""stylesheet"" type=""text/css"">"
			strHTML =  strHTML & "<style type=""text/css"">"
			strHTML =  strHTML & "body {	margin-left: 10px;margin-top: 10px;margin-right: 10px;margin-bottom: 10px;}.style1 {color: #0000FF;font-weight: bold;}.style2 {color: #FF0000}"
			strHTML =  strHTML & "</style></head><body><table width=""5%""  border=""1"" align=""center"" cellpadding=""2"" cellspacing=""2"" bordercolor=""#9DCEFF"">"
			strHTML =  strHTML & "  <tr><td height=""536""><table width=""100%"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
			strHTML =  strHTML & "      <tr><td><img src=""http://www.phonetrade.cc/images/phonetradetop_features.jpg"" width=""550"" height=""76""></td>      </tr>"
			strHTML =  strHTML & "      <tr><td><div align=""right"" class=""body""><table width=""550"" border=""0"" cellspacing=""0"" cellpadding=""0"">"
			strHTML =  strHTML & "            <tr><td width=""495"" height=""30"" bgcolor=""#9DCEFF"" ><div align=""left"">"
			strHTML =  strHTML & "<p class=""body""><strong>&nbsp;Dear *Member* , </strong></p></div></td>"
			strHTML =  strHTML & "<td width=""55"" align=""center"" class=""time"" bgcolor=""#9DCEFF"">&nbsp; </td></tr></table></div></td></tr>"
			strHTML =  strHTML & "<tr><td height=""112"" valign=""top""><table bgcolor=""#D7EBFF"" width=""100%"" border=""0"" cellpadding=""2""><tr>"
			strHTML =  strHTML & "<td height=""85"" ><p align=""justify"" class=""body"">Thank you for registering your Company with <STRONG><strong>PhoneTrade.cc</strong></STRONG>, your trusted online source of B2B Mobile Phone Trading   solution.</p>"
			strHTML =  strHTML & "<p class=""body""><strong>Login Information: </strong></p><p class=""body"">Username: <strong>*User*</strong><BR>Password:<strong> *Pwd*</strong></p>"
			strHTML =  strHTML & "<p><span class=""body"">Logon to: <A title=""http://www.phonetrade.cc/PortalDefault.aspx?Main_Links_ID=24"" href=""http://www.phonetrade.cc/PortalDefault.aspx?Main_Links_ID=24"">http://www.phonetrade.cc/PortalDefault.aspx?Main_Links_ID=24</A></span> <BR>"
			strHTML =  strHTML & "<span class=""body""><br>Now that you have registered your Company with us, you may be asking yourself,"
			strHTML =  strHTML & "&nbsp;<i>&quot;Now what?&quot; </i> </span></p></td></tr><tr><td ><p class=""body""><strong>&nbsp;<br>GETTING STARTED: </strong><br>&nbsp;PhoneTrade Registration Getting Started Guide: <br>"
			strHTML =  strHTML & "<br>&nbsp;<span class=""style1"">Step 1 </span>: Review your welcome emails <br>&nbsp;<span class=""style1"">Step 2 </span>: Log in to Members Area <br>"
			strHTML =  strHTML & "  &nbsp;<span class=""style1"">Step 3 </span>: Manage your Membership features: <br>&nbsp;a: Start posting your Stocks <br>&nbsp;b: Edit or View your Stock Postings <br>"
			strHTML =  strHTML & "&nbsp;c: Edit or View your Company Contact Info. <br>&nbsp;d: Add your Company Profile. <br>&nbsp;e: Change Password. <br>&nbsp;f:&nbsp; Logout </p>              </td></tr><tr>"
			strHTML =  strHTML & "<td height=""41"" > <div align=""justify"" class=""body"">&nbsp;<br>&nbsp;Here are some answers to commonly asked questions: </div></td></tr><tr><td height=""596"" valign=""top"" >"
			strHTML =  strHTML & "<table border=""0"" width=""100%"" id=""table1"" cellspacing=""0"" cellpadding=""0"" class=""body""><tr><td width=""7"">&nbsp;</td><td><strong>PHONETRADE.CC FREQUENTLY ASKED QUESTIONS <br>"
			strHTML =  strHTML & "&nbsp;</strong></td></tr><tr><td width=""7"">&nbsp;</td><td><p align=""justify""><strong>1. What services are included when I Signup with Phonetrade? </strong>                  <br>"
			strHTML =  strHTML & "With your registration service, you receive the following tools: <br><br><strong><span class=""style2"">a. Post My Offer Page: </span><br>"
			strHTML =  strHTML & "</strong>This is set up automatically when your Account is activated. After ACTIVATION of your Account, you should login to Phonetrade.cc Members Area while connected to the Internet; you should be able to View your Membership Menu Bar along Welcome message. You can click <strong>&#8216;POST MY OFFER'</strong> link to start posting &nbsp;your <strong>BUY</strong> or <strong>SELL</strong> Deals. <br>"
			strHTML =  strHTML & "  <br><strong><span class=""style2"">b. Edit My Stock Page: </span><br></strong>Let's say that you already have posted several deals and you want to edit or refresh the deal for the next day, then this tool will help you to efficiently perform the task. By Default you will be allowed to Edit Postings of maximum as of last 3 days. <br>"
			strHTML =  strHTML & "<br><span class=""style2""><strong>c. Edit My Contact Page:</strong></span><strong><br></strong>You can edit your Company or personal, contact details so your Company Info will &nbsp;be remain updated if other Members want to approach you for Business. <br>"
			strHTML =  strHTML & "<br><span class=""style2""><strong>d.</strong></span><strong><span class=""style2""> Edit My Profile Page:</span> <br></strong>You can POST/UPDATE your Company Profile. <br>"
			strHTML =  strHTML & "&nbsp;<br><span class=""style2""><strong>e.</strong></span><strong><span class=""style2""> Change Your Password Page</span> <br>"
			strHTML =  strHTML & "<span class=""style2"">f.&nbsp; Logout</span> <br><br>2. How can I POST more then one ITEM? <br></strong>"
			strHTML =  strHTML & "<br>If you are willing to POST more then one Items, you can select the option on the &nbsp;bottom of the Posting Form stating as <strong>&#8220;I want to POST more ITEMS&#8221; </strong> and Press <strong>&nbsp;&#8220;POST REQUEST&#8221; </strong> button, this will start gathering your previous posts on the &nbsp;TOP of the Post Offer Form and you can post as much as ITEMS as you want, &nbsp;our INTELLIGENT POST FUNCTION will start gathering your postings until you &nbsp;press <strong>&#8220;POST TO TRADING FLOOR&#8221; </strong> button."
			strHTML =  strHTML & "<p align=""justify"">That's all&#8230; and now you can see your &nbsp;posting in a GROUPED form on Trading Floor.            </td></tr></table></td></tr></table></td></tr><tr><td bgcolor=""#FFFFFF""></td></tr><tr>"
			strHTML =  strHTML & "<td bgcolor=""#FFFFFF""><table width=""550"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr bgcolor=""#E6F2FF""><td height=""69"" align=""left"" valign=""top"" bgcolor=""#eeeeee"">"
			strHTML =  strHTML & "<div align=""center""><table width=""100%"" cellpadding=""2"" cellspacing=""1""><tr><td height=""137"" bgcolor=""#FFFFFF"" class=""body""> "
			strHTML =  strHTML & "<p align=""justify""><br>If you have questions regarding your Account or Services, please add our Live Customer Support Team on your MSN or Yahoo Messenger,<br>"
			strHTML =  strHTML & "<strong>MSN:</strong>						( <a href=""mailto:(trading_support@hotmail.com"">Trading_support@hotmail.com</a> )<br><strong>Yahoo:</strong> ( <a href=""mailto:(Phonetrade_live@yahoo.com"">Phonetrade_live@yahoo.com</a> )"
			strHTML =  strHTML & "<p align=""justify"">If you have a question or need any information, please &nbsp;email to our support team at: <a href=""mailto:support@phonetrade.cc"">info@phonetrade.cc</a>"
			strHTML =  strHTML & "<br><br>Sincerely, <br>Support Team<br><strong>"
			strHTML =  strHTML & "<a target=""_blank"" href=""http://www.phonetrade.cc/"">www.PhoneTrade.cc</a></strong><br><br><br>"
			strHTML =  strHTML & "</td></tr><tr><td width=""547"" height=""36"" valign=""middle""><div align=""center""><span class=""body"">"
			strHTML =  strHTML & "<font size=""1"">You received this email because you have registered with  PhoneTrade.cc<br>"
			strHTML =  strHTML & "</font></span></div></td></tr></table></div></td></tr></table></td></tr></table></td></tr></table></body></html>"
			strHTML = replace(strHTML,"*Member*",strName)
			strHTML = replace(strHTML,"*User*",strmember_id)
			strHTML = replace(strHTML,"*Pwd*",strpassword)
			
			Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
			Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 
			
			Const cdoAnonymous = 0 'Do not authenticate
			Const cdoBasic = 1 'basic (clear-text) authentication
			Const cdoNTLM = 2 'NTLM
			
			Set objMessage = CreateObject("CDO.Message") 
			objMessage.Subject = "Your account is activated - Phonetrade.cc"
			objMessage.From = "sales@phonetrade.cc" 
			objMessage.To = strToMail
			objMessage.Bcc = "newsletter@phonetrade.cc"
			objMessage.HTMLBody = CStr("" & strHTML)
			
			'==This section provides the configuration information for the remote SMTP server.
			
			objMessage.Configuration.Fields.Item _
			("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2 
			
			'Name or IP of Remote SMTP Server
			objMessage.Configuration.Fields.Item _
			("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "88.208.204.214" '"10.4.29.4"
			
			'Type of authentication, NONE, Basic (Base64 encoded), NTLM
			objMessage.Configuration.Fields.Item _
			("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate") = cdoBasic
			
			'Your UserID on the SMTP server
			objMessage.Configuration.Fields.Item _
			("http://schemas.microsoft.com/cdo/configuration/sendusername") = "sales@phonetrade.cc" '"admin50534137@helpmanzil.com"
			
			'Your password on the SMTP server
			objMessage.Configuration.Fields.Item _
			("http://schemas.microsoft.com/cdo/configuration/sendpassword") = "domain" '"admin"
			
			'Server port (typically 25)
			objMessage.Configuration.Fields.Item _
			("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25 
			
			''Use SSL for the connection (False or True)
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
<script language="JavaScript">
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
			<form name="frmMain" method="post">
				<TABLE border="0" cellspacing="0" cellpadding="0" width="100%">
					<tr>
						<td>&nbsp;</td>
					</tr>
					<tr Class="MainHeading">
						<td Align="middle">Mobile portal</td>
					</tr>
					<tr Class="SubHeading">
						<td Align="middle">&nbsp;</td>
					</tr>
					<tr>
						<td>&nbsp;</td>
					</tr>
					<tr>
						<td>
							<table width="100%" border="0" cellpadding="2">
								<tr>
									<td width="18%" align="Center" class="HeadingWithBackGround" Id="Link0" onClick="JavaScript:Move('Masters.asp')"
										onmouseover="JavaScript:Show(0)">Master entry</td>
									<td width="18%" align="Center" class="HeadingWithBackGround" Id="Link1" onClick="JavaScript:Move('Members.asp')"
										onmouseover="JavaScript:Show(1)">Member Details</td>
									<td width="15%" align="Center" class="HeadingWithBackGround" Id="Link2" onClick="JavaScript:Move('ImageUpload.asp')"
										onmouseover="JavaScript:Show(2)">Upload Images
									</td>
									<td width="16%" align="Center" class="HeadingWithBackGround" Id="Link3" onClick="JavaScript:Move('PostMessage.asp')"
										onmouseover="JavaScript:Show(3)">Post/Edit Message</td>
									<td width="14%" align="Center" class="HeadingWithBackGround" Id="Link4" onClick="JavaScript:Logout()"
										onmouseover="JavaScript:Show(4)">Logout</td>
									<td width="37%" align="Center" class="HeadingWithBackGround" Id="Link5">&nbsp;</td>
								</tr>
							</table>
						</td>
					</tr>
				</TABLE>
			</form>
			<table width="100%" border="0" cellspacing="0" cellpadding="0">
				<tr>
					<td>
						<form name="frm" method="post">
							<input type="hidden" name="hdMember" value=""> <input type="hidden" name="hdPromote" value="">
							<input type="hidden" name="hdAction" value="">
							<script language="Javascript">
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
									<td><table width="100%" border="0" align="Center" class="Border">
											<tr align="left">
												<td Colspan="3" class="HeadingWithBackGround">Activate member</td>
											</tr>
											<tr Class="TableBackGround">
												<td width="18%" align="right" class="contact">Member Name</td>
												<td width="63%">
													<select name="cboMembName" style="width:250px">
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
													</select>
													&nbsp;
													<SCRIPT LANGUAGE="javascript">
con = "<%=strSelect%>" 
for (i=0;i<document.frm.cboMembName.length;i++)
if (document.frm.cboMembName.options[i].value==con)
document.frm.cboMembName.selectedIndex = i;
													</SCRIPT>
													<input type="button" onClick="return move();" name="btnGo" value=" Go ">
												</td>
												<td width="19%">&nbsp;</td>
											</tr>
											<tr height="2">
												<td colspan="3" align="right" class="HeadingWithBackGround"></td>
											</tr>
											<tr>
												<td></td>
												<td>&nbsp;
												</td>
												<td>&nbsp;</td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
							<% 
    Set rsTemp = Server.CreateObject("ADODB.Recordset")
    rsTemp.Open "Select * from Members where MemberCode=" & strSelect ,conn,3,2
    if not rsTemp.EOF  then
%>
							<input type="hidden" name="hdUpdate" value="<%if rsTemp("Activateflag") & ""="2" or len(rsTemp("password") & "")=0 then Response.Write "DoUpdate"%>">
							<input type="hidden" name="hdEMail" value="<%=rsTemp("company_email")%>">
							<table width="60%" border="0" align="center" cellpadding="0" cellspacing="2">
								<tr class="contact">
									<td width="28%" height="18" valign="top">member_company
									</td>
									<td width="2%" height="18" valign="top">:</td>
									<td width="70%" height="18"><strong>
											<%
  valDb= rsTemp("member_company")
  Response.Write valDb
    %>
										</strong>
									</td>
								</tr>
								<tr class="contact">
									<td height="18" valign="top">Member since
									</td>
									<td height="18" valign="top">:</td>
									<td height="18"><strong>
											<%
  valDb= rsTemp("timestamp")
  Response.Write valDb
    %>
										</strong>
									</td>
								</tr>
								<tr class="contact">
									<td height="18" valign="top">mailing_address</td>
									<td height="18" valign="top">:</td>
									<td height="18"><strong>
											<%
  valDb= rsTemp("mailing_address")
  Response.Write valDb
    %>
										</strong>
									</td>
								</tr>
								<tr class="contact">
									<td height="18" valign="top">Phone
									</td>
									<td height="18" valign="top">:</td>
									<td height="18"><strong>
											<%
  valDb= rsTemp("company_phone")
  Response.Write valDb
    %>
										</strong>
									</td>
								</tr>
								<tr class="contact">
									<td height="18" valign="top">Fax</td>
									<td height="18" valign="top">:</td>
									<td height="18"><strong>
											<%
  valDb= rsTemp("company_fax")
  Response.Write valDb
    %>
										</strong>
									</td>
								</tr>
								<tr class="contact">
									<td height="18" valign="top">Mobile</td>
									<td height="18" valign="top">:</td>
									<td height="18"><strong>
											<%
  valDb= rsTemp("company_contact1_mobile")
  Response.Write valDb
    %>
										</strong>
									</td>
								</tr>
								<tr class="contact">
									<td height="18" valign="top">Mail Id
									</td>
									<td height="18" valign="top">:</td>
									<td height="18"><strong>
											<%
  valDb= rsTemp("company_email")
  Response.Write valDb
    %>
										</strong>
									</td>
								</tr>
								<tr class="contact">
									<td height="18" valign="top">company_website
									</td>
									<td height="18" valign="top">:</td>
									<td height="18"><strong>
											<%
  valDb= rsTemp("company_website")
  Response.Write valDb
    %>
										</strong>
									</td>
								</tr>
								<% if Flag="NotOk" then %>
								<tr class="contact">
									<td height="18" valign="top" colspan="3"><font color="red">Username already exists, 
											Please try with another username.</font></td>
								</tr>
								<% end if%>
								<tr class="contact">
									<td height="18" valign="top">UserName</td>
									<td height="18" valign="top">:</td>
									<td height="18">
										<input type=text name=txtUserName value="<% =rsTemp("member_id") %>">
									</td>
								</tr>
								<tr class="contact">
									<td height="18" valign="top">Password</td>
									<td height="18" valign="top">:</td>
									<td height="18"><input type="password" name="txtpassword" value=""></td>
								</tr>
								<tr class="contact">
									<td height="18" valign="top">&nbsp;</td>
									<td height="18" valign="top">&nbsp;</td>
									<td height="18"><input type="Checkbox" name="chkMail" value="1">Send mail to client</td>
								</tr>
								<tr bgcolor="#CCCCCC" class="contact">
									<td height="18" valign="top"><strong>Status</strong></td>
									<td height="18" valign="top">&nbsp;</td>
									<td height="18">
										<strong><font color="#FF0000">
												<%  valDb= rsTemp("Activateflag") & ""
		 if valDb="1" then Response.Write "Active Member" else  Response.Write "Deactivated Member"
			  %>
											</font></strong>
									</td>
								</tr>
								<tr class="contact">
									<td height="18" valign="top">&nbsp;</td>
									<td height="18" valign="top">&nbsp;</td>
									<td height="18">
										<%  valDb= rsTemp("Activateflag") & ""
		 if valDb="2" then valDb="Activate Member" else valDb="Deactivate Member"
			  %>
										<input type="hidden" name="hdActDeact" value="<% =rsTemp("Activateflag") & "" %>">
										<input name="btnActivate" type="button" id="btnActivate" value="<% =valDb %>" onClick="Javascript:Activate()"></td>
								</tr>
								<%
		   valDb= rsTemp("MemberLevel") & ""
		  end if%>
							</table>
							<br>
							<br>
							<table width="60%" border="0" align="center" cellpadding="0" cellspacing="0">
								<tr>
									<td><table width="100%" border="0" align="Center" class="Border">
											<tr align="left">
												<td Colspan="3" class="HeadingWithBackGround">Promote Membership</td>
											</tr>
											<tr Class="TableBackGround">
												<td colspan="3" align="left" class="contact"><b><font color="black">Select the level of 
															membership and press Go</font></b></td>
											</tr>
											<tr Class="TableBackGround">
												<td width="18%" align="right" class="contact">&nbsp;</td>
												<td width="63%"><select name="cboSelect" style="width:200px">
														<option value="1">Basic Level [Traders]</option>
														<option value="2">Silver Level [Traders & Members]</option>
													</select>
													<script language="javascript">
con = "<%=valDb%>" 
for (i=0;i<document.frm.cboSelect.length;i++)
if (document.frm.cboSelect.options[i].value==con)
document.frm.cboSelect.selectedIndex = i;
													</script>
													<input type="button" onClick="return GoandDo();" name="btnGo1" value=" Go "></td>
												<td width="19%">&nbsp;</td>
											</tr>
											<tr height="2">
												<td colspan="3" align="right" class="HeadingWithBackGround"></td>
											</tr>
											<tr>
												<td></td>
												<td>&nbsp;</td>
												<td>&nbsp;</td>
											</tr>
											<% if len(strMsg)>0 then %>
											<tr>
												<td colspan="3" align="center"><strong><% =strMsg %></strong></td>
											</tr>
											<% end if %>
										</table>
									</td>
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
	</HTML>
