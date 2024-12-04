<!-- #Include File = "../Main/Source.asp" -->
<%



Dim ProcId 
Dim MyCDONTSMail
Dim objHttp, SQL
Dim strHTML,Query
Dim subj, memberId
Dim rsTemp
Dim DoneFlag 
DoneFlag = Request.form("hdDone")
ProcId= Request.QueryString("proc") & ""  
if len(ProcId)=0 then ProcId= Request.Form("hdproc") & ""
memberId = Request.QueryString("Id") & ""
if len(memberId)=0 then memberId= Request.Form("hdmemberId") & ""

if DoneFlag="Done" then
	Select case ProcId
	case "1"
		Query ="http://www.Cputrade.cc/signup_email.htm"
		subj = "Thanks for your Registration - Cputrade.cc"
		SQL = "Select * from Members where MemberCode=" & memberId
		
        strBodyText = strBodyText & "<html><head><title>Thanks for registering with us. Cputrade.cc</title></head>"
        strBodyText = strBodyText & "<body leftmargin=""0"" topmargin=""5"" marginwidth=""0"" marginheight=""0"" bgcolor=""#333333"" rightmargin=""0"" bottommargin=""5"">"
        strBodyText = strBodyText & "<div align=""center""><table width=""742"" border=""0"" cellspacing=""0"" cellpadding=""0"" style=""border-right: 1px solid #FFFFFF; border-top: 1px solid #FFFFFF"">"
        strBodyText = strBodyText & "<tr><td width=""742"" background=""http://www.Cputrade.cc/Images/thanksmail/top_bg.jpg""><img src=""http://www.Cputrade.cc/Images/thanksmail/logo.jpg"" width=""742"" height=""76""></td>  </tr></table></div>"
        strBodyText = strBodyText & "<div align=""center""><table width=""742"" border=""0"" cellspacing=""0"" cellpadding=""0"">  <tr> "
        strBodyText = strBodyText & "<td width=""430"" valign=""top"" bgcolor=""ECECEC""><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">"
        strBodyText = strBodyText & "<tr> <td><img src=""http://www.Cputrade.cc/Images/thanksmail/left_img.jpg"" width=""430"" height=""502""></td></tr></table><br>"
        strBodyText = strBodyText & "<table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr valign=""top""> "
        strBodyText = strBodyText & "<td width=""8%"" height=""21"" align=""center"" valign=""middle""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr>"
        strBodyText = strBodyText & "<td height=4></td></tr></table><img src=""http://www.Cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td>"
        strBodyText = strBodyText & "<td width=""92%"" valign=""middle""><div align=""justify""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">For any enquires please feel free to contact us:</font></b></div></td>"
        strBodyText = strBodyText & "</tr></table><table width=""102%"" border=""0"" cellpadding=""0"" cellspacing=""0""><tr valign=""top""> "
        strBodyText = strBodyText & "<td width=""8%"" height=""21"" align=""center"" valign=""middle""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr></table>"
        strBodyText = strBodyText & "<img src=""http://www.Cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td width=""16%"" valign=""middle""><div align=""justify""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Phone "
        strBodyText = strBodyText & "</font></b></div></td><td width=""5%"" align=""center"" valign=""middle""><strong><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">:</font></strong></td>"
        strBodyText = strBodyText & "<td width=""71%"" valign=""middle""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif""> +971 4 3681 764</font></b></td></tr>"
        strBodyText = strBodyText & "<tr valign=""top""> <td height=""21"" align=""center"" valign=""middle""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr></table>"
        strBodyText = strBodyText & "<img src=""http://www.Cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td valign=""middle""><div align=""justify""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Fax </font></b></div></td>"
        strBodyText = strBodyText & "<td align=""center"" valign=""middle""><strong><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">: </font></strong></td><td valign=""middle""><b>"
        strBodyText = strBodyText & "<font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">+971 4 2994 492</font></b></td></tr><tr valign=""top""> "
        strBodyText = strBodyText & "<td height=""21"" align=""center"" valign=""middle""><img src=""http://www.Cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td valign=""middle""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Mobile "
        strBodyText = strBodyText & "</font></b></td><td align=""center"" valign=""middle""><strong><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">:</font></strong></td><td valign=""middle""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif""> "
        strBodyText = strBodyText & "+971 50 2052 150</font></b></td></tr><tr valign=""top""> <td height=""21"" align=""center"" valign=""middle""><img src=""http://www.Cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td>"
        strBodyText = strBodyText & "<td valign=""middle""><b><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Email</font></b></td><td align=""center"" valign=""middle""><strong><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif""> "
        strBodyText = strBodyText & ":</font></strong></td><td valign=""middle""><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif""> <a href=""mailto:sales@Cputrade.cc"">sales@Cputrade.cc</a></font></td></tr>"
        strBodyText = strBodyText & "<tr valign=""top""> <td height=""21"" align=""center"" valign=""middle"">&nbsp;</td><td valign=""middle"">&nbsp;</td><td align=""center"" valign=""middle"">&nbsp;</td><td valign=""middle"">&nbsp;</td></tr>"
        strBodyText = strBodyText & "</table> </td><td width=""312"" valign=""top"" bgcolor=""ECECEC""><table border=""0"" cellspacing=""0"" cellpadding=""0""><tr><td height=""450"" valign=""top"" bgcolor=""f7f7f7""><table width=""312"" border=""0"" cellspacing=""0"" cellpadding=""0"">"
        strBodyText = strBodyText & "<tr> <td width=""10"" height=""57"">&nbsp;</td><td width=""295"" valign=""top""><div align=""justify""> <p align=""left""><font size=""3"" face=""Tahoma, Arial""><b><font face=""Tahoma"">Dear</font></b><strong> "
        strBodyText = strBodyText & "*Member* ,<font color=""#9E0C0C"" face=""Arial, Helvetica, sans-serif""><br><br></font></strong></font><strong><font color=""#9E0C0C"" face=""Arial, Helvetica, sans-serif""><font size=""2"" face=""Tahoma, Arial"">Thank you</font></font><font color=""747474"" face=""Arial, Helvetica, sans-serif"" size=""2""> "
        strBodyText = strBodyText & "for joining Cputrade.cc.<br>We will Email your Sign Up form for you to add your signature  and company seal.<br><br>Your account will be activated upon receipt of the following  documentation:</font></strong></p> </p></div></td>"
        strBodyText = strBodyText & "<td width=""10"">&nbsp;</td></tr><tr> <td>&nbsp;</td><td><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td width=""86%""><table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""1"" bgcolor=""FFCC00"">"
        strBodyText = strBodyText & "<tr> <td bgcolor=""ffffff""><table width=""100%"" height=""57"" border=""0"" cellpadding=""0"" cellspacing=""2"" bordercolor=""#999999""><tr valign=""top""> <td height=""16"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> "
        strBodyText = strBodyText & "<td height=4></td></tr></table><img src=""http://www.Cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td height=""19""><font size=""2"" face=""Arial, Helvetica, sans-serif"">Signup  with your signature and company sea<font size=""3"">l</font></font></td>"
        strBodyText = strBodyText & "</tr><tr valign=""top""> <td width=""9%"" height=""16"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr></table>"
        strBodyText = strBodyText & "<img src=""http://www.Cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td width=""91%"" height=""19""><font size=""2"" face=""Arial, Helvetica, sans-serif"">Copy  Trade License / Certificate of Incorporation "
        strBodyText = strBodyText & " and your Company details<br></font><font color=""#FF0000"" size=""1"" face=""Arial, Helvetica, sans-serif""><strong>Please Note:</strong> We need this to activate your account</font></td></tr>"
        strBodyText = strBodyText & "<tr valign=""top""> <td height=""16"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr></table>"
        strBodyText = strBodyText & "<img src=""http://www.Cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td height=""19""><font size=""2"" face=""Arial, Helvetica, sans-serif"">Your  Company logo to be emailed to <a href=""mailto:logos@Cputrade.cc"">logos@Cputrade.cc</a><br>"
        strBodyText = strBodyText & "<strong>Please Note:</strong> If we don't  receive your Logo within 7 days, Account will  be Deactivated </font></td></tr></table></td></tr></table></td></tr>"
        strBodyText = strBodyText & "<tr> <td align=""center""><font size=""3"" face=""Arial, Helvetica, sans-serif"">&nbsp;</font></td></tr></table></td><td>&nbsp;</td></tr><tr> <td height=""102"">&nbsp;</td><td valign=""top""><div align=""left""><font color=""747474"" size=""3"" face=""Arial, Helvetica, sans-serif""><strong>This "
        strBodyText = strBodyText & " will help us to create your profile in the member&#8217;s directory.<br><br>After activation, you can avail the following benefits:</strong></font></div></td><td>&nbsp;</td>"
        strBodyText = strBodyText & "</tr><tr> <td>&nbsp;</td> <td><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0""> <tr valign=""top""> <td width=""6%"" height=""21"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0"">"
        strBodyText = strBodyText & "<tr> <td height=4></td></tr></table><img src=""http://www.Cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td width=""94%""><div align=""justify""><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Add  company profile</font></div></td>"
        strBodyText = strBodyText & "</tr><tr valign=""top""> <td height=""21"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr></table>"
        strBodyText = strBodyText & "<img src=""http://www.Cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td><div align=""justify""><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Make global presence in the market</font></div></td>"
        strBodyText = strBodyText & "</tr><tr valign=""top""> <td height=""21"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr>"
        strBodyText = strBodyText & "</table><img src=""http://www.Cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td><div align=""justify""><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Check  the latest Mobiles</font></div></td>"
        strBodyText = strBodyText & "</tr><tr valign=""top""> <td height=""21"" align=""center""><table width=""20"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td height=4></td></tr></table>"
        strBodyText = strBodyText & "<img src=""http://www.Cputrade.cc/Images/thanksmail/arrow.jpg"" width=""6"" height=""6""></td><td><div align=""justify""><font color=""#333333"" size=""2"" face=""Arial, Helvetica, sans-serif"">Browse  the Member&#8217;s Directory</font></div></td>"
        strBodyText = strBodyText & "</tr></table></td><td>&nbsp;</td></tr></table></td></tr><tr><td><img src=""http://www.Cputrade.cc/Images/thanksmail/right_bot.jpg"" width=""312"" height=""52""></td>"
        strBodyText = strBodyText & "</tr></table></td></tr></table></div><br></body></html>"
		
	case "2"
		Query ="http://www.Cputrade.cc/Print.htm"
		subj = "Cputrade.cc: Membership Confirmation!"
		SQL = "select Members.*, Country.Country_name from Members inner join Country on Members.Country_id = Country.Country_id where MemberCode=" & memberId	
        strPrintForm = strPrintForm &  "<html><head><title>Cputrade.cc [Member Details]</title></head><body><table width=""650"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">"
        strPrintForm = strPrintForm &  "<tr><td><img src=""http://www.Cputrade.cc/images/email_t1.jpg"" width=""650"" height=""76""></td></tr></table><table width=""650"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""1"" bgcolor=""#666666"">"
        strPrintForm = strPrintForm &  "<tr> <td width=""901"" bgcolor=""#FFFFFF""><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""3""><tr> <td width=""51%"" class=""siz""><font size=""2"" face=""Arial, Helvetica, sans-serif""><strong>Company Details</strong></font></td>"
        strPrintForm = strPrintForm &  "<td width=""49%"" class=""siz""><font size=""2"" face=""Arial, Helvetica, sans-serif""><strong>Personal Details</strong></font></td></tr><tr> <td><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">"
        strPrintForm = strPrintForm &  "<tr> <td height=1 bgcolor=""#999999""></td></tr></table></td><td><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> "
        strPrintForm = strPrintForm &  "<td height=1 bgcolor=""#999999""></td></tr></table></td></tr><tr> <td height=8></td><td></td></tr><tr> <td valign=""top""><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">"
        strPrintForm = strPrintForm &  "<tr class=""siz""> <td height=""20"" valign=""top""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Company Name</font></strong></td><td height=""20"" valign=""top"">:</td>"
        strPrintForm = strPrintForm &  "<td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*CompanyName*</font></td></tr><tr class=""siz""> <td width=""37%"" height=""20"" valign=""top""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">mailing_address</font></strong></td>"
        strPrintForm = strPrintForm &  "<td width=""4%"" height=""20"" valign=""top"">:</td><td width=""59%"" height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Address*</font></td></tr>"
        strPrintForm = strPrintForm &  "<tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Country</font></strong></td><td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Country*</font></td>"
        strPrintForm = strPrintForm &  "</tr><tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Phone</font></strong></td><td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Phone*</font></td></tr>"
        strPrintForm = strPrintForm &  "<tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Fax</font></strong></td><td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Fax*</font></td></tr>"
        strPrintForm = strPrintForm &  "<tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Email</font></strong></td><td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Email*</font></td></tr>"
        strPrintForm = strPrintForm &  "<tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Company Website</font></strong></td><td height=""20"">:</td>"
        strPrintForm = strPrintForm &  "<td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Website*</font></td></tr></table></td><td valign=""top""><table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">"
        strPrintForm = strPrintForm &  "<tr class=""siz""> <td width=""37%"" height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Name</font></strong></td><td width=""4%"" height=""20"">:</td>"
        strPrintForm = strPrintForm &  "<td width=""59%"" height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Name*</font></td></tr><tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Mobile</font></strong></td>"
        strPrintForm = strPrintForm &  "<td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*Mobile*</font></td></tr><tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Personal  Email</font></strong></td>"
        strPrintForm = strPrintForm &  "<td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*PersonalEmail*</font></td></tr><tr class=""siz""> <td height=""20"">&nbsp;</td><td height=""20"">&nbsp;</td>"
        strPrintForm = strPrintForm &  "<td height=""20"">&nbsp;</td></tr><tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Second  Contact</font></strong></td>"
        strPrintForm = strPrintForm &  "<td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*SecondContact*</font></td></tr><tr class=""siz""> "
        strPrintForm = strPrintForm &  "<td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Mobile  No 2</font></strong></td><td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*MobileNo2*</font></td>"
        strPrintForm = strPrintForm &  "</tr><tr class=""siz""> <td height=""20""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Personal Email</font></strong></td>"
        strPrintForm = strPrintForm &  "<td height=""20"">:</td><td height=""20""><font size=""2"" face=""Arial, Helvetica, sans-serif"">*PersonalEmail2*</font></td></tr></table></td></tr>"
        strPrintForm = strPrintForm &  "<tr> <td height=""22"" colspan=""2"" valign=""top"">&nbsp;</td></tr><tr> <td height=""22"" colspan=""2"" valign=""top""><strong><font size=""2"" face=""Arial, Helvetica, sans-serif"">Company "
        strPrintForm = strPrintForm &  "Type</font></strong></td></tr><tr align=""center""> <td height=""22"" colspan=""2"" valign=""top""><table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"">"
        strPrintForm = strPrintForm &  "<tr> <td width=200><font size=""2"" face=""Arial, Helvetica, sans-serif""> *CompanyType*</font></td></tr></table></td></tr>"
        strPrintForm = strPrintForm &  "<tr align=""center""> <td height=""104"" colspan=""2"" valign=""top""> <table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td bgcolor=""#000000"" height=1></td> </tr>"
        strPrintForm = strPrintForm &  "</table><table width=""630"" border=""0"" cellspacing=""0"" cellpadding=""0""><tr> <td colspan=""2"" align=""center"">&nbsp;</td></tr><tr> <td colspan=""2"" align=""center""><font color=""#000000"" size=""2"" face=""Arial, Helvetica, sans-serif""><strong>I "
        strPrintForm = strPrintForm &  " agree to the Terms and Conditions</strong></font></td></tr><tr> <td width=""328"" align=""center"">&nbsp;</td><td width=""302"" align=""center"">&nbsp;</td> </tr>"
        strPrintForm = strPrintForm &  "<tr> <td><font color=""#000000"" size=""2"" face=""Arial, Helvetica, sans-serif"">Name:&nbsp;&nbsp;</font><font size=""2"" face=""Arial, Helvetica, sans-serif"" color=""#000000"">_______________________</font></td>  <td><font color=""#000000"" size=""2"" face=""Arial, Helvetica, sans-serif"">Date:&nbsp;&nbsp;_______________</font></td></tr>"
        strPrintForm = strPrintForm &  "<tr> <td>&nbsp;</td><td>&nbsp;</td></tr><tr> <td>&nbsp;</td><td>&nbsp;</td></tr><tr> <td>&nbsp;</td><td>&nbsp;</td></tr>"
        strPrintForm = strPrintForm &  "<tr> <td><font color=""#000000"" size=""2"" face=""Arial, Helvetica, sans-serif"">Signature:</font><font color=""#000000"">&nbsp;&nbsp;<font size=""2"" face=""Arial, Helvetica, sans-serif"">_______________________</font></font></td>"
        strPrintForm = strPrintForm &  "<td><font color=""#000000"" size=""2"" face=""Arial, Helvetica, sans-serif"">Company  Seal</font><font color=""#000000"">:&nbsp;&nbsp;</font></td></tr>"
        strPrintForm = strPrintForm &  "<tr> <td>&nbsp;</td><td>&nbsp;</td></tr><tr> <td>&nbsp;</td><td>&nbsp;</td></tr><tr> <td>&nbsp;</td><td>&nbsp;</td></tr>"
        strPrintForm = strPrintForm &  "</table></td></tr><tr align=""center""> <td height=""80"" colspan=""2"" valign=""middle"" bgcolor=""#0066FF""> <table border=""0"" width=""100%"" id=""table1"">"
        strPrintForm = strPrintForm &  "<tr> <td width=""46"">&nbsp;</td><td><b><font color=""#FFFFFF"" size=""2"" face=""Arial, Helvetica, sans-serif"">1.  Kindly add your signature and company seal <br> 2. Send along with the copy of your Trade License/Certificate "
        strPrintForm = strPrintForm &  " of Incorporation <br>3. Fax it to us on [ +971 (4) 2994 492 ]. <br>Company Information and Company Logo to be emailed at logos@Cputrade.cc</font></b></td>"
        strPrintForm = strPrintForm &  "<td width=""38"">&nbsp;</td></tr></table></td></tr><tr align=""center""><td height=""80"" colspan=""2"" valign=""middle""><div align=""left""><font size=""2"" face=""Arial, Helvetica, sans-serif"">Kindly "
        strPrintForm = strPrintForm &  "be in touch with our online support team if you require any help.<br> We are online, on yahoo and msn messengers for our fellow traders.  Simply add us to your messengers.<br> <br>"
        strPrintForm = strPrintForm &  " Yahoo Messenger: <font color=""#000099""><strong>Phonetrade_live@yahoo.com</strong></font><br> MSN Messenger:<strong><font color=""#000066""> trading_support@hotmail.com</font></strong><br>"
        strPrintForm = strPrintForm &  "<br><strong>&#8220;Our motive is to help you in better ways.&#8221;</strong> <br><br>Regards,<br>Cputrade.cc<br>Web Team<br></font><br></div><br>"
        strPrintForm = strPrintForm &  "<font size=""1"" face=""Arial, Helvetica, sans-serif"">Note: We are sending out  this email, because you or someone on behalf of you have requested<br> To be a member of a leading B2B mobile phone trading website &#8220;Cputrade.cc.&#8221;<br>"
        strPrintForm = strPrintForm &  " Kindly ignore this email/message if you have not request for the new  membership.</font></td></tr></table></td></tr></table></body></html>"
		
		
	end select
					'Set objHttp = Server.CreateObject("Msxml2.ServerXMLHTTP")
					'objHttp.open "GET", Query, False
					'objHttp.send
					'strHTML = objHttp.responseText


	set rsTemp = server.createobject("Adodb.recordset")
	rsTemp.open SQL,conn,3,3
	
	if not rsTemp.eof then

	Select case ProcId
	case "1"
		strHTML = strBodyText
		strHTML = replace(strHTML,"*Member*",rsTemp("member_company")&"")
	case "2"
		strHTML = strPrintForm
		strHTML = Replace(strHTML,"*CompanyName*", "<font color = '#000000'>" & rsTemp("member_company") & " </font>")
	strHTML = 	Replace(strHTML,"*Address*", "<font color = '#000000'>" & rsTemp("mailing_address") & " </font>")
		strHTML = Replace(strHTML,"*Country*", "<font color = '#000000'>" & rsTemp("Country_Name") & "</font>")
		strHTML = Replace(strHTML,"*Phone*", "<font color = '#000000'>" & Replace(rsTemp("company_phone"), "*", " ") & " </font>")
		strHTML = Replace(strHTML,"*Fax*", "<font color = '#000000'>" & Replace(rsTemp("company_fax"), "*", " ") & " </font>")
		strHTML = Replace(strHTML,"*Email*", "<font color = '#000000'>" & rsTemp("company_email") & " </font>")
		strHTML = Replace(strHTML,"*Website*", "<font color = '#000000'>" & rsTemp("company_website") & " </font>")
		strHTML = Replace(strHTML,"*Name*", "<font color = '#000000'>" & rsTemp("company_contact2_name") & " </font>")
		strHTML = Replace(strHTML,"*Mobile*", "<font color = '#000000'>" & Replace(rsTemp("company_contact1_mobile"), "*", " ") & " </font>")
		strHTML = Replace(strHTML,"*PersonalEmail*", "<font color = '#000000'>" & rsTemp("company_contact1_email") & " </font>")
		strHTML = Replace(strHTML,"*SecondContact*", "<font color = '#000000'>" & rsTemp("company_contact2_name") & " </font>")
		strHTML = Replace(strHTML,"*MobileNo2*", "<font color = '#000000'>" & Replace(rsTemp("company_contact2_mobile"), "*", " ") & " </font>")
		strHTML = Replace(strHTML,"*PersonalEmail2*", "<font color = '#000000'>" & rsTemp("company_contact2_email") & " </font>")
	strCompanyType=""
               If rsTemp("manufacturer_type") & "" = "1" Then
                    strCompanyType =strCompanyType &  "<img src=http://www.Cputrade.cc/Images/tick.gif border=0>"
                    strCompanyType = strCompanyType & "<font color=#990000><b>Manufacturer</b></font>&nbsp;&nbsp;&nbsp;"
                End If

                If rsTemp("exp_imp_type") & "" = "1" Then
                    strCompanyType =strCompanyType &  "<img src=http://www.Cputrade.cc/Images/tick.gif border=0>"
                    strCompanyType =strCompanyType &  "<font color=#990000><b>Exporter / Importer</b></font>&nbsp;&nbsp;&nbsp;"
                End If

                If rsTemp("dealer_reseller_type") & "" = "1" Then
                    strCompanyType =strCompanyType &  "<img src=http://www.Cputrade.cc/Images/tick.gif border=0>"
                    strCompanyType =strCompanyType &  "<font color=#990000><b>Dealer Reseller</b></font>&nbsp;&nbsp;&nbsp;"
                End If

                If rsTemp("retailer_type") & "" = "1" Then
                    strCompanyType =strCompanyType &  "<img src=http://www.Cputrade.cc/Images/tick.gif border=0>"
                    strCompanyType =strCompanyType &  "<font color=#990000><b>Retailer</b></font>&nbsp;&nbsp;&nbsp;"
                End If

                If rsTemp("service_prov_type") & "" = "1" Then
                    strCompanyType =strCompanyType &  "<img src=http://www.Cputrade.cc/Images/tick.gif border=0>"
                    strCompanyType =strCompanyType &  "<font color=#990000><b>Service Provider</b></font>&nbsp;&nbsp;&nbsp;"
                End If

                If rsTemp("freight_type") & "" = "1" Then
                    strCompanyType =strCompanyType &  "<img src=http://www.Cputrade.cc/Images/tick.gif border=0>"
                    strCompanyType =strCompanyType &  "<font color=#990000><b>Freight Forwarder</b></font>&nbsp;&nbsp;&nbsp;"
                End If

                strHTML = Replace(strHTML,"*CompanyType*", strCompanyType)	

                strHTML = Replace(strHTML, "*Mobile*", "")
                strHTML = Replace(strHTML, "*PersonalEmail*", "")
                strHTML = Replace(strHTML, "*SecondContact*", "")
                strHTML = Replace(strHTML, "*MobileNo2*", "")
                strHTML = Replace(strHTML, "*PersonalEmail2*", "")

                strHTML = Replace(strHTML, "**", "")
				
	end select


		strToMail =rsTemp("company_email") 
		strCC = rsTemp("company_contact1_email") 
		
		'Set MyCDONTSMail = CreateObject("CDONTS.NewMail")
		'MyCDONTSMail.From= "sales@Cputrade.cc"
		'MyCDONTSMail.To= strToMail
		'if len(strCC)>0 then MyCDONTSMail.cc = strCC
		'MyCDONTSMail.BCC= "sales@Cputrade.cc"
		'MyCDONTSMail.Subject=subj
		'MyCDONTSMail.BodyFormat=0	
		'MyCDONTSMail.MailFormat=0
		'MyCDONTSMail.Body= strHTML
		'MyCDONTSMail.Send
		'set MyCDONTSMail=nothing
'Set objMessage = CreateObject("CDO.Message") 
'objMessage.Subject = subj 
'objMessage.From = "sales@Cputrade.cc" 
'objMessage.To =strToMail 
'objMessage.HTMLBody = CStr("" & strHTML)
'if len(strCC)>0 then objMessage.cc = strCC
'objMessage.BCC= "sales@Cputrade.cc"
'objMessage.Send

					Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
					Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 
					
					Const cdoAnonymous = 0 'Do not authenticate
					Const cdoBasic = 1 'basic (clear-text) authentication
					Const cdoNTLM = 2 'NTLM
					
					Set objMessage = CreateObject("CDO.Message") 
					objMessage.Subject = subj
					objMessage.From = "sales@Cputrade.cc" 
					objMessage.To = strToMail
					if len(strCC)>0 then objMessage.cc = strCC
					objMessage.Bcc = "sales@Cputrade.cc"
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
					
					''Use SSL for the connection (False or True)
					objMessage.Configuration.Fields.Item _
					("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = False
					
					objMessage.Configuration.Fields.Update
					
					'==End remote SMTP server configuration section==
					
					objMessage.Send
							
	Flag="OK"
	end if
end if
%>
<html>
<head>
<title>Send Mail</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
</head>

<body>
<form name="frmMain" method="post">
<input type="hidden" name="hdDone" value="Done">
<input type="hidden" name="hdproc" value="<%=ProcId%>">
<input type="hidden" name="hdmemberId" value="<%=memberId%>">
<% if Flag="OK" then Response.Write("A mail has been sent to the Members")%>
<input type="submit" name="btn1" value="<% if ProcId="1" then response.write "Send Thanks Mail" else Response.Write "Send PRINT Form"%>">
</form>
</body>
</html>
