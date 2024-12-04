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
	strCode = Request.form("cboMembName")
	if len(strCode&"")=0 then strCode=Request.QueryString("Id")
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
			company_fax = rsMain("company_fax")
			company_contact1_mobile = rsMain("company_contact1_mobile")
			company_contact2_mobile = rsMain("company_contact2_mobile") & ""

			company_email = rsMain("company_email")
			company_contact2_name= rsMain("company_contact2_name")
			company_contact1_email= rsMain("company_contact1_email")
			company_contact2_email= rsMain("company_contact2_email")	
			
			company_website = rsMain("company_website")
			manufacturer_type = rsMain("manufacturer_type")
			exp_imp_type = rsMain("exp_imp_type")
			dealer_reseller_type = rsMain("dealer_reseller_type")
			retailer_type= rsMain("retailer_type")
			service_prov_type= rsMain("service_prov_type")
			freight_type= rsMain("freight_type")
	
			'CompanyType = rsMain("CompanyType")
			'CategoryCode = rsMain("CategoryCode")
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
<script language="JavaScript" type="text/JavaScript">
<!--
function MM_openBrWindow(theURL,winName,features) { //v2.0
  window.open(theURL,winName,features);
}
//-->
</script>
</head>

<body>
<!--#Include file="Top1.asp"-->
<form name="frmPrint" method="post" action="">
  <input type=hidden name="hdProc" value="">
  <script language=javascript>
function Print()
{
	document.frmPrint.action = "PrintPrv.asp";
	document.frmPrint.submit();
}
function PrintTo(p)
{
	var x = 'Print.asp?Code=' + p;
	MM_openBrWindow(x,'','scrollbars=yes,width=650,height=500')
}
</script>
  <table width=90% border=0 align=Center class="Border">
    <tr align="left"> 
      <td colspan=3 class="HeadingWithBackGround">Select member to Print</td>
    </tr>
    <tr class=TableBackGround> 
      <td width="18%" align=right class="contact">Member Name</td>
      <td width="63%"> <select name="cboMembName" style="width:250px">
          <%
sSQL = "select member_company,MemberCode from Members order by member_company"
if rsTemp.State then rsTemp.Close 
rsTemp.Open sSQL,conn,2,1
do while not rsTemp.EOF 
%>
          <option value="<%=rsTemp("MemberCode")%>"><%=rsTemp("member_company")%></option>
          <%
rsTemp.MoveNext 
loop
rsTemp.Close
%>
        </select> &nbsp; <script language=javascript>
con = "<%=strCode%>" 
for (i=0;i<document.frmPrint.cboMembName.length;i++)
if (document.frmPrint.cboMembName.options[i].value==con)
document.frmPrint.cboMembName.selectedIndex = i;
</script> <input type=button onClick="return Print();" name=btnGo value=" Go "> 
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
  <br>
  <% if Flag = "Ok" then%>
  <table width="90%" border="0" align="center" cellpadding="0" cellspacing="1">
    <tr>
      <td align="right"><input type="button" name="btnPrint" value="  Print  "  onClick="Javascript:PrintTo(<%=strCode%>)"></td>
    </tr>
  </table>
  <table width="90%" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#666666">
    <tr>
      <td bgcolor="#FFFFFF"><table width="100%" border="0" cellspacing="0" cellpadding="3">
          <tr> 
            <td width="51%" bgcolor="#D9ECFF" class="siz"><font size="2"><strong>Company 
              Details</strong></font></td>
            <td width="49%" bgcolor="#B9DCFF" class="siz"><font size="2"><strong>Personal 
              Details</strong></font></td>
          </tr>
          <tr> 
            <td bgcolor="#D9ECFF"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr> 
                  <td height=1 bgcolor="#999999"></td>
                </tr>
              </table></td>
            <td bgcolor="#B9DCFF"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr> 
                  <td height=1 bgcolor="#999999"></td>
                </tr>
              </table></td>
          </tr>
          <tr> 
            <td bgcolor="#D9ECFF" height=8></td>
            <td bgcolor="#B9DCFF"></td>
          </tr>
          <tr> 
            <td valign="top" bgcolor="#D9ECFF"><table width="100%" border="0" cellspacing="0" cellpadding="0">
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
if company_phone<>"**" then
	pos = instr(company_phone, "*")
	PhCountry = mid(company_phone,1,pos-1)
	company_phone = mid(company_phone,pos+1)
	pos = instr(company_phone, "*")
	PhArea = mid(company_phone,1,pos-1)
	company_phone = mid(company_phone,pos+1)
	if PhArea="A" then 
		Response.Write "+" & PhCountry & " " & company_phone 
	else
		Response.Write "+" & PhCountry & " (" & PhArea & ") " & company_phone 
	end if
else 
Response.Write "--"
end if
%>
                  </td>
                </tr>
                <tr class="siz"> 
                  <td height="20"><strong>Fax</strong></td>
                  <td height="20">:</td>
                  <td height="20"> 
                    <%
if company_fax<>"**" then
	pos = instr(company_fax, "*")
	PhCountry = mid(company_fax,1,pos-1)
	company_fax = mid(company_fax,pos+1)
	pos = instr(company_fax, "*")
	PhArea = mid(company_fax,1,pos-1)
	company_fax = mid(company_fax,pos+1)
	if PhArea="A" then 
		Response.Write "+" & PhCountry & " " & company_fax 
	else
		Response.Write "+" & PhCountry & " (" & PhArea & ") " & company_fax 
	end if
else 
Response.Write "--"
end if
%>
                  </td>
                </tr>
                <tr class="siz"> 
                  <td height="20"><strong>Email</strong></td>
                  <td height="20">:</td>
                  <td height="20"><a class="link4" href="mailto:<%=Email%>"><%=company_email%></a></td>
                </tr>
                <tr class="siz"> 
                  <td height="20"><strong>Website</strong></td>
                  <td height="20">:</td>
                  <td height="20"><a  href="http://<%=Web%>" target="_blank" class="link4" ><%=company_website%></a></td>
                </tr>
              </table></td>
            <td valign="top" bgcolor="#B9DCFF"><table width="100%" border="0" cellspacing="0" cellpadding="0">
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
					/*var col="<%=CompanyType%>".split(", ");
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
        </table></td>
    </tr>
  </table>
 <%end if%>
</form>
</body>
</html>
