<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
Dim strCode, strSql
Dim rsMain, rsTemp
Dim member_company, company_contact1_name
Dim mailing_address, Country_id
Dim company_phone, company_fax, company_contact1_mobile
Dim PhCountry, FaxCountry, MobCountry, MobCountry1
Dim PhArea, FaxArea, MobArea, company_contact1_mobile1	
Dim company_email, UsrName, Pwd, 	MailFlag
Dim Flag, MemberCode, msg, CategoryCode, CompType, pos, pos2

	set rsMain = server.CreateObject("Adodb.Recordset")	
	set rsTemp = server.CreateObject("Adodb.Recordset")
	strCode = Request.QueryString("Code")
	if len(strCode)>0 then 
		strSql = "Select * from Members where MemberCode=" & strCode 
		rsMain.open strSql, conn,3,2
		if not rsMain.eof then
			Flag = "Ok"
			company_contact1_name = rsMain("company_contact1_name")
			member_company = rsMain("member_company")
			mailing_address = rsMain("mailing_address")
			Country_id = rsMain("Country_id")
			MemberLevel = rsMain("MemberLevel")		
			ActivateFlag= rsMain("ActivateFlag")				
			Category= rsMain("CategoryCode")
			company_phone = rsMain("company_phone")
			pos = instr(company_phone, "*")
			PhCountry = mid(company_phone,1,pos-1)
			company_phone = mid(company_phone,pos+1)
			pos = instr(company_phone, "*")
			PhArea = mid(company_phone,1,pos-1)
			'if PhArea="A" then PhArea="AreaCode"
			company_phone = mid(company_phone,pos+1)
			
			company_fax = rsMain("company_fax")
			pos = instr(company_fax, "*")
			FaxCountry = mid(company_fax,1,pos-1)
			company_fax = mid(company_fax,pos+1)
			pos = instr(company_fax, "*")
			FaxArea = mid(company_fax,1,pos-1)
			'if FaxArea="A" then FaxArea="AreaCode"
			company_fax = mid(company_fax,pos+1)
		
			company_contact1_mobile = rsMain("company_contact1_mobile")
			'pos = instr(company_contact1_mobile, "*")
			'MobCountry = mid(company_contact1_mobile,1,pos-1)
			'company_contact1_mobile = mid(company_contact1_mobile,pos+1)
			'pos = instr(company_contact1_mobile, "*")
			'MobArea = mid(company_contact1_mobile,1,pos-1)
			'if MobArea="A" then MobArea="AreaCode"
			'company_contact1_mobile = mid(company_contact1_mobile,pos+1)
		
			company_contact2_mobile = rsMain("company_contact2_mobile") & ""
			'if len(company_contact1_mobile1)>0 then
			'	pos = instr(company_contact1_mobile1, "*")
			'	MobCountry1 = mid(company_contact1_mobile1,1,pos-1)
			'	company_contact1_mobile1 = mid(company_contact1_mobile1,pos+1)
			'	pos = instr(company_contact1_mobile1, "*")
			'	MobArea1 = mid(company_contact1_mobile1,1,pos-1)
			'	if MobArea1="A" then MobArea1="AreaCode"
			'	company_contact1_mobile1 = mid(company_contact1_mobile1,pos+1)
			'end if
			company_email = rsMain("company_email")
			company_contact2_name= rsMain("company_contact2_name")
			company_contact1_email= rsMain("company_contact1_email")
			company_contact2_email= rsMain("company_contact2_email")	
			
			company_website = rsMain("company_website")
			'CompanyType = rsMain("CompanyType")
			'CategoryCode = rsMain("CategoryCode")
			
			manufacturer_type = rsMain("manufacturer_type")
			exp_imp_type = rsMain("exp_imp_type")
			dealer_reseller_type = rsMain("dealer_reseller_type")
			retailer_type= rsMain("retailer_type")
			service_prov_type= rsMain("service_prov_type")
			freight_type= rsMain("freight_type")
			
		Dim rsMain1
		set rsMain1 = server.CreateObject("Adodb.Recordset")
		rsMain1.open "Select * from Country where Country_id=" & Country_id, conn,2,1
		if not rsMain1.eof then
		Country=rsMain1("Country_Name")
		End If 
		rsMain1.close
		
		end if
	end if
%>

<html>
<head>
<title>Phonetrade.cc [Member Details]</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">

<link href="../Styles/CssStyles.CSS" rel="stylesheet" type="text/css">
<script language="JavaScript1.2" type="text/JavaScript1.2" src="../Main/Main.js"></script>
</head>

<body onLoad="window.print();">
<% if Flag = "Ok" then%>
<table width="650" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td><img src="http://www.phonetrade.cc/images/email_t1.jpg" width="650" height="76"></td>
  </tr>
</table>
<table width="650" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#666666">
  <tr> 
    <td width="901" bgcolor="#FFFFFF"><table width="100%" border="0" cellspacing="0" cellpadding="3">
        <tr> 
          <td width="51%" class="siz"><font size="2"><strong>Company 
            Details</strong></font></td>
          <td width="49%" class="siz"><font size="2"><strong>Personal 
            Details</strong></font></td>
        </tr>
        <tr> 
          <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr> 
                <td height=1 bgcolor="#999999"></td>
              </tr>
            </table></td>
          <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr> 
                <td height=1 bgcolor="#999999"></td>
              </tr>
            </table></td>
        </tr>
        <tr> 
          <td height=8></td>
          <td></td>
        </tr>
        <tr> 
          <td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr class="siz"> 
                <td height="20" valign="top"><strong>Company Name</strong></td>
                <td height="20" valign="top">:</td>
                <td height="20"><%=member_company%></td>
              </tr>
              <tr class="siz"> 
                <td width="37%" height="20" valign="top"><strong>mailing_address</strong></td>
                <td width="4%" height="20" valign="top">:</td>
                <td width="59%" height="20"><%=replace(mailing_address,vbcrlf,"<Br>")%></td>
              </tr>
              <tr class="siz">
                <td height="20"><strong>Country</strong></td>
                <td height="20">:</td>
                <td height="20"><%=Country%></td>
              </tr>
              <tr class="siz"> 
                <td height="20"><strong>Phone</strong></td>
                <td height="20">:</td>
                <td height="20"> 
                  <%
	if PhArea="A" then 
		Response.Write "+" & PhCountry & " " & company_phone 
	else
		Response.Write "+" & PhCountry & " (" & PhArea & ") " & company_phone 
	end if
%>
                </td>
              </tr>
              <tr class="siz"> 
                <td height="20"><strong>Fax</strong></td>
                <td height="20">:</td>
                <td height="20"> 
                  <%
	if PhArea="A" then 
		Response.Write "+" & PhCountry & " " & company_fax 
	else
		Response.Write "+" & PhCountry & " (" & FaxArea & ") " & company_fax 
	end if
%>
                </td>
              </tr>
              <tr class="siz"> 
                <td height="20"><strong>Email</strong></td>
                <td height="20">:</td>
                <td height="20"><%=company_email%></td>
              </tr>
              <tr class="siz"> 
                <td height="20"><strong>company_website</strong></td>
                <td height="20">:</td>
                <td height="20"><%=company_website%></td>
              </tr>
            </table></td>
          <td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr class="siz"> 
                <td width="37%" height="20"><strong>Name</strong></td>
                <td width="4%" height="20">:</td>
                <td width="59%" height="20"><%=company_contact1_name%></td>
              </tr>
              <tr class="siz"> 
                <td height="20"><strong>Mobile</strong></td>
                <td height="20">:</td>
                <td height="20"> 
                  <%
if company_contact1_mobile<>"**" then
	pos = instr(company_contact1_mobile, "*")
	PhCountry = mid(company_contact1_mobile,1,pos-1)
	company_contact1_mobile = mid(company_contact1_mobile,pos+1)
	pos = instr(company_contact1_mobile, "*")
	PhArea = mid(company_contact1_mobile,1,pos-1)
	company_contact1_mobile = mid(company_contact1_mobile,pos+1)
	if PhArea="M" then 
		Response.Write "+" & PhCountry & " " & company_contact1_mobile 
	else
		Response.Write "+" & PhCountry & " (" & PhArea & ") " & company_contact1_mobile 
	end if
else 
Response.Write "--"
end if
%>
                </td>
              </tr>
              <% %>
              <tr class="siz"> 
                <td height="20"><strong>Personal Email</strong></td>
                <td height="20">:</td>
                <td height="20"> 
                  <%if company_contact1_email&""="" then Response.Write "--" else Response.Write(company_contact1_email)%>
                </td>
              </tr>
              <tr class="siz"> 
                <td height="20">&nbsp;</td>
                <td height="20">&nbsp;</td>
                <td height="20">&nbsp;</td>
              </tr>
              <tr class="siz"> 
                <td height="20"><strong>Second Contact</strong></td>
                <td height="20">:</td>
                <td height="20"> 
                  <%if company_contact2_name&""="" then Response.Write "--" else Response.Write(company_contact2_name)%>
                </td>
              </tr>
              <tr class="siz"> 
                <td height="20"><strong>Mobile No 2</strong></td>
                <td height="20">:</td>
                <td height="20"> 
                  <%
if company_contact2_mobile<>"**" then
	pos = instr(company_contact2_mobile, "*")
	PhCountry = mid(company_contact2_mobile,1,pos-1)
	company_contact2_mobile = mid(company_contact2_mobile,pos+1)
	pos = instr(company_contact2_mobile, "*")
	PhArea = mid(company_contact2_mobile,1,pos-1)
	company_contact2_mobile = mid(company_contact2_mobile,pos+1)
	if PhArea="M" then 
		Response.Write "+" & PhCountry & " " & company_contact2_mobile
	else
		Response.Write "+" & PhCountry & " (" & PhArea & ") " & company_contact2_mobile
	end if
else 
Response.Write "--"
end if
%>
                </td>
              </tr>
              <tr class="siz"> 
                <td height="20"><strong>Personal Email</strong></td>
                <td height="20">:</td>
                <td height="20"> 
                  <%if company_contact2_email&""="" then Response.Write "--" else Response.Write(company_contact2_email)%>
                </td>
              </tr>
            </table></td>
        </tr>
        <tr> 
          <td height="22" colspan="2" valign="top">&nbsp;</td>
        </tr>
        <tr> 
          <td height="22" colspan="2" valign="top"><strong>Company Type</strong></td>
        </tr>
        <tr align="center"> 
          <td height="22" colspan="2" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0">
              <tr>
              <%if manufacturer_type &""="1" then Response.Write "<td width=200><img src=../Images/tick.gif border=0><font color=#990000><b>Manufacturer</b></font></td>"
              if exp_imp_type &""="1" then Response.Write "<td width=200><img src=../Images/tick.gif border=0><font color=#990000><b>Exporter / Importer</b></font></td>"
              if dealer_reseller_type &""="1" then Response.Write "<td width=200><img src=../Images/tick.gif border=0><font color=#990000><b>Dealer / Reseller</b></font></td>"
			if retailer_type &""="1" then Response.Write "<td width=200><img src=../Images/tick.gif border=0><font color=#990000><b>Retailer</b></font></td>"
			if service_prov_type &""="1" then Response.Write "<td width=200><img src=../Images/tick.gif border=0><font color=#990000><b>Service Providerr</b></font></td>"
			if freight_type &""="1" then Response.Write "<td width=200><img src=../Images/tick.gif border=0><font color=#990000><b> Freight forwarder</b></font></td>"
%>
              </tr>
              <SCRIPT LANGUAGE=javascript>
				/*	var col="<%=CompanyType%>".split(", ");
					var loc=0;
					var cl=0;
					//alert(col.length);
					document.write("<tr>");
					while (loc < col.length)
					{
						value = returnValue(col[loc]);
						if (cl>2)
						{
						document.write("</tr><tr> <td colspan=3 height=17></td></tr><tr>");
						cl=0;
						}
						if (col.length==1 && value.length==0)
						{document.write("<td width=200>&nbsp;</td>");}
						else {document.write("<td width=200><img src=../Images/tick.gif border=0><font color=#990000><b> "+value+"</b></font></td>");}
						cl+=1;
						loc+=1;
					}
					document.write("</tr>");*/
					</SCRIPT>
            </table></td>
        </tr>
        <tr align="center"> 
          <td height="104" colspan="2" valign="top"> <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td bgcolor="#000000" height=1></td>
              </tr>
            </table>
            <table width="630" border="0" cellspacing="0" cellpadding="0">
              <tr> 
                <td colspan="2" align="center">&nbsp;</td>
              </tr>
              <tr> 
                <td colspan="2" align="center"><font color="#000000" size="2" face="Arial, Helvetica, sans-serif"><strong>I 
                  agree to the Terms and Conditions</strong></font></td>
              </tr>
              <tr> 
                <td width="328" align="center">&nbsp;</td>
                <td width="302" align="center">&nbsp;</td>
              </tr>
              <tr> 
                <td><font color="#000000" size="2" face="Arial, Helvetica, sans-serif">Name:&nbsp;&nbsp;</font><font size="2" face="Arial, Helvetica, sans-serif" color="#000000">_______________________</font></td>
                <td><font color="#000000" size="2" face="Arial, Helvetica, sans-serif">Date:&nbsp;&nbsp;_______________</font></td>
              </tr>
              <tr> 
                <td>&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
              <tr> 
                <td>&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
              <tr> 
                <td>&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
              <tr> 
                <td><font color="#000000">Signature:&nbsp;&nbsp;<font size="2" face="Arial, Helvetica, sans-serif">_______________________</font></font></td>
                <td><font color="#000000">Company Seal:&nbsp;&nbsp;</font></td>
              </tr>
              <tr> 
                <td>&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
              <tr> 
                <td>&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
              <tr> 
                <td>&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
              </table>
          </td>
        </tr>
        <tr align="center">
          <td height="80" colspan="2" valign="middle" bgcolor="#0066FF">
			<table border="0" width="100%" id="table1">
				<tr>
					<td width="46">&nbsp;</td>
					<td><b><font color="#FFFFFF">1. Kindly add your signature 
					and company seal <br>
					2. Send along with the copy of your Trade 
					License/Certificate of Incorporation <br>
					3. Fax it to us on <font size="2">[ +971 (4) 2994 492 ].
					</font><br>
					Company Information and Company Logo to be emailed at logos@phonetrade.cc</font></b></td>
					<td width="38">&nbsp;</td>
				</tr>
			</table>
			</td>
        </tr>
      </table></td>
  </tr>
</table>
<%end if%>
</body>
</html>
