<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
	Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
	Dim rsMain
	set rsMain = server.CreateObject("Adodb.Recordset")
	Dim member_company, company_contact1_name
	Dim mailing_address, Country_id
	Dim company_phone, company_fax, company_contact1_mobile
	Dim PhCountry, FaxCountry, MobCountry, MobCountry1
	Dim PhArea, FaxArea, MobArea, company_contact1_mobile1	
	Dim company_email, member_id, password, 	MailFlag
	Dim Flag, MemberCode, msg, CategoryCode, CompType, pos, pos2
	set rsMain = server.CreateObject("Adodb.Recordset")
	set rsTemp = server.CreateObject("Adodb.Recordset")	
	
	MemberCode = Request.QueryString("Id")
	if len(MemberCode & "")=0 then 
		MemberCode=-1
		MemberCode=Request.Form("cboMembName")
		if len(MemberCode & "")=0 then MemberCode=-1
	end if
'Response.Write("Select * from Members where MemberCode=" & MemberCode)
'Response.End()
	rsMain.open "Select * from Members where MemberCode=" & MemberCode, conn,2,1
	if not rsMain.eof then
	Flag = "Ok"
	company_contact1_name = rsMain("company_contact1_name")
	member_company = rsMain("member_company")
	mailing_address = rsMain("mailing_address")
	Country_id = rsMain("Country_id")
	MemberLevel = rsMain("MemberLevel")		
	ActivateFlag= rsMain("ActivateFlag")				
	manufacturer_type=	rsMain("manufacturer_type") 
	exp_imp_type	=rsMain("exp_imp_type")
	dealer_reseller_type=	rsMain("dealer_reseller_type")
	retailer_type	=rsMain("retailer_type")
	service_prov_type	=rsMain("service_prov_type")
	freight_type	=rsMain("freight_type")								
	
	company_phone = rsMain("company_phone")
	pos = instr(company_phone, "*")
	PhCountry = mid(company_phone,1,pos-1)
	company_phone = mid(company_phone,pos+1)
	pos = instr(company_phone, "*")
	PhArea = mid(company_phone,1,pos-1)

	company_phone = mid(company_phone,pos+1)

	
	company_fax = rsMain("company_fax")
	pos = instr(company_fax, "*")
	FaxCountry = mid(company_fax,1,pos-1)
	company_fax = mid(company_fax,pos+1)
	pos = instr(company_fax, "*")
	FaxArea = mid(company_fax,1,pos-1)

	company_fax = mid(company_fax,pos+1)

	
	company_contact1_mobile = rsMain("company_contact1_mobile")
	pos = instr(company_contact1_mobile, "*")
	MobCountry = mid(company_contact1_mobile,1,pos-1)

	company_contact1_mobile = mid(company_contact1_mobile,pos+1)
	pos = instr(company_contact1_mobile, "*")
	MobArea = mid(company_contact1_mobile,1,pos-1)

	company_contact1_mobile = mid(company_contact1_mobile,pos+1)

	company_contact2_mobile = rsMain("company_contact2_mobile") & ""
	if len(company_contact1_mobile1)>0 then
		pos = instr(company_contact1_mobile1, "*")
		MobCountry1 = mid(company_contact1_mobile1,1,pos-1)
	
		company_contact1_mobile1 = mid(company_contact1_mobile1,pos+1)
		pos = instr(company_contact1_mobile1, "*")
		MobArea1 = mid(company_contact1_mobile1,1,pos-1)

		company_contact1_mobile1 = mid(company_contact1_mobile1,pos+1)
	end if
	company_email = rsMain("company_email")
	company_contact2_name= rsMain("company_contact2_name")
	company_contact1_email= rsMain("company_contact1_email")
	company_contact2_email= rsMain("company_contact2_email")	
	
	company_website = rsMain("company_website")
	CategoryCode = rsMain("CategoryCode")
	Colour= rsMain("ColourValue")
	MailFlag= rsMain("MailFlag")
	end if
	msg = Request.Form("hdMsg")
	if len(Request.QueryString("action") & "")>0 then msg="Member information successfully modified"
%>
<html>
<head>
<title>Edit Member</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="../Styles/CssStyles.CSS" rel="stylesheet" type="text/css">
<script language="JavaScript1.2" type="text/JavaScript1.2" src="../Main/Main.js"></script>

</head>

<body>
<!--#Include file="Top1.asp"-->
<form name="frmEditMember" method="post" action=""  onSubmit="JavaScript:return FormSubmit();">
  <input type=hidden name="hdProc" value="">
  <script language=javascript>

function Check(str){
var chk = document.frmEditMember.chkCategory;
var flg=false;
	for (i = 0; i < chk.length; i++){
	if (chk[i].checked == true){
		//display = display + boxes[i].value + ", ";
		flg=true;
		break;
		}
	}
	
	if (flg==false)
	{
		errStr = errStr + str + "\n";
		return false;
	}
	return true;
}


 function FormSubmit()
{

		var CanSubmit = false;
		errStr = "The following fields must be entered\n";
		CanSubmit =  ForceEntry(document.forms["frmEditMember"].txtmember_company,"    - Company name is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmEditMember"].txtmailing_address,"    - Mailing mailing_address is required.");
		CanSubmit = CanSubmit & DefaultCheck(document.forms["frmEditMember"].cboCountry.value,"    - Country is required.");

		CanSubmit = CanSubmit & DefaultCheckText("Country",document.forms["frmEditMember"].txtPhCou.value,"    - Country Code is required for Phone number.");
		CanSubmit = CanSubmit & DefaultCheckText("company_phone",document.forms["frmEditMember"].txtPhone.value,"    - Phone number is required.");

		CanSubmit = CanSubmit & DefaultCheckText("Country",document.forms["frmEditMember"].txtFaxCou.value,"    - Country Code is required for Fax number.");
		CanSubmit = CanSubmit & DefaultCheckText("company_fax",document.forms["frmEditMember"].txtcompany_fax.value,"    - Fax number is required.");

		//CanSubmit = CanSubmit & ForceEntry(document.forms["frmEditMember"].txtcompany_fax,"    - Fax number is required.");		
		//CanSubmit = CanSubmit & ForceEntry(document.forms["frmEditMember"].txtcompany_contact1_mobile,"    - Mobile number is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmEditMember"].txtEmail,"    - Email-id is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmEditMember"].txtName,"    - Contact person is required.");	

		CanSubmit = CanSubmit & DefaultCheckText("Country",document.forms["frmEditMember"].txtMobCou.value,"    - Country Code is required for Mobile number.");
		CanSubmit = CanSubmit & DefaultCheckText("MobileCode",document.forms["frmEditMember"].txtMobArea.value,"    - Mobile Code is required for Mobile number.");
		CanSubmit = CanSubmit & DefaultCheckText("company_contact1_mobile",document.forms["frmEditMember"].txtcompany_contact1_mobile.value,"    - Mobile number is required.");
	
		if (document.forms["frmEditMember"].txtEmail.value.length>0)
			CanSubmit = CanSubmit & checkemail(document.forms["frmEditMember"].txtEmail.value,"    - Invalid Email-id.");

		//if(document.frmEditMember.chkType[5].checked==false)
		//{CanSubmit = CanSubmit & Check("    - Please atleast select one items from \'Dealing in group\'.");}

		var x = document.frmEditMember.cboSelect.options[document.frmEditMember.cboSelect.selectedIndex].value;
		if (x==2)
		{
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmEditMember"].txtUserName,"    - Username is required.");		
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmEditMember"].txtpassword,"    - Password is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmEditMember"].txtRepassword,"    - Retype password is required.");
		var a=document.forms["frmEditMember"].txtpassword.value;
		var b=document.forms["frmEditMember"].txtRepassword.value;		
		if (a.length>0 && b.length>0 && a!=b)
		{
			errStr = errStr + "    - Passwords Mismatch.\n";
			CanSubmit = false;
		}	
		}

						
		CanSubmit = (CanSubmit!=0)
		
		if (CanSubmit)
		{		
			CanSubmit = CanSubmit & numEntry(document.forms["frmEditMember"].txtPhCou.value,"    - Country Code should be Numeric for Phone number.");
			x = document.forms["frmEditMember"].txtPhArea.value;
			if (x!='AreaCode') CanSubmit = CanSubmit & numEntry(x,"    - Area Code should be Numeric for Phone number.");
			CanSubmit = CanSubmit & numEntry(document.forms["frmEditMember"].txtPhone.value,"    - Phone number should be Numeric.");

			CanSubmit = CanSubmit & numEntry(document.forms["frmEditMember"].txtFaxCou.value,"    - Country Code should be Numeric for Fax number.");
			x = document.forms["frmEditMember"].txtFaxArea.value;
			if (x!='AreaCode') CanSubmit = CanSubmit & numEntry(x,"    - Area Code should be Numeric for Fax number.");
			CanSubmit = CanSubmit & numEntry(document.forms["frmEditMember"].txtcompany_fax.value,"    - Fax number should be Numeric.");
			
			CanSubmit = CanSubmit & checkemail(document.forms["frmEditMember"].txtEmail.value,"    - Invalid Email-id.");

			CanSubmit = CanSubmit & numEntry(document.forms["frmEditMember"].txtMobCou.value,"    - Country Code should be Numeric for Mobile number.");
			x = document.forms["frmEditMember"].txtMobArea.value;
			if (x!='AreaCode') CanSubmit = CanSubmit & numEntry(x,"    - Area Code should be Numeric for Phone number.");
			CanSubmit = CanSubmit & numEntry(document.forms["frmEditMember"].txtcompany_contact1_mobile.value,"    - Mobile number should be Numeric.");

		//if(document.frmEditMember.chkType[5].checked==false)
		//{CanSubmit = CanSubmit & Check("    - Please atleast select one items from \'Dealing in group\'.");}
		}
		CanSubmit = (CanSubmit!=0)
		if (CanSubmit==false) 
		{
		alert(errStr);
		return false;
		}
		else
		{
			document.frmEditMember.hdProc.value="2"
			document.frmEditMember.action="Insert.asp";
			document.frmEditMember.submit();   
		}
}

function move()
{
	document.frmEditMember.action = "EditMember.asp";
	document.frmEditMember.submit();
}
function Delete()
{
	document.frmEditMember.hdProc.value=document.frmEditMember.cboMembName.options[document.frmEditMember.cboMembName.selectedIndex].value;
	//alert(document.frmEditMember.hdProc.value);
	document.frmEditMember.action = "DeleteMember.asp";
	document.frmEditMember.submit();
}
function CheckUserName()
{
	var x=document.frmEditMember.txtUserName.value;
	if (x.length==0)
	{
	alert("Please check the mark, and put the username");
	document.frmEditMember.txtUserName.focus();
	}
	else
	{
		window.open("CheckUserName.asp?chk=" + x,'Check','width=400,height=150');
	}
}

</script>
  <br>
  <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0">
    <tr> 
      <td><table width=100% border=0 align=Center class="Border">
          <tr align="left"> 
            <td Colspan=3 class="HeadingWithBackGround">Select Member to Edit/Delete</td>
          </tr>
          <tr Class=TableBackGround> 
            <td width="18%" align=right class="contact">Member Name</td>
            <td width="63%"> 
			<select name="cboMembName" style="width:250px">
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
              </select> &nbsp; <SCRIPT LANGUAGE=javascript>
con = "<%=MemberCode%>" 
for (i=0;i<document.frmEditMember.cboMembName.length;i++)
if (document.frmEditMember.cboMembName.options[i].value==con)
document.frmEditMember.cboMembName.selectedIndex = i;
</SCRIPT>
              <input type=button onClick="return move();" name=btnGo value=" Go "> 
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
  <br>
  <% if Flag="Ok" then%>
 
  <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
    <tr>
      <td align="right"><input type="button" name="btnDelete" value="Delete Member" onClick="javascript:Delete();"></td>
    </tr>
  </table> <br>
  <TABLE width="90%"  border=0 align="center">
    <TBODY>
      <TR> 
        <TD class=HeadingWithBackGround align=left 
                        colSpan=2>Company Information</TD>
      </TR>
      <TR class=TableBackGround> 
        <TD width="35%" align=right>Select type of member</TD>
        <TD width="65%"><select name="cboSelect" style="width:200px">
            <option value="1" selected>Basic Level [Traders]</option>
            <option value="2">Silver Level [Traders & Members]</option>
          </select> <SCRIPT LANGUAGE=javascript>
								con = "<%=MemberLevel%>"
								for (i=0;i<document.frmEditMember.cboSelect.length;i++)
									if (document.frmEditMember.cboSelect.options[i].value==con)
										document.frmEditMember.cboSelect.selectedIndex = i;
							</SCRIPT></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Activate</TD>
        <TD><select name="cboActivate" id="cboActivate" style="width:200px">
            <option value="1" selected>Activate</option>
            <option value="2">Deactivate</option>
          </select> <SCRIPT LANGUAGE=javascript>
								con = "<%=ActivateFlag%>"
								for (i=0;i<document.frmEditMember.cboActivate.length;i++)
									if (document.frmEditMember.cboActivate.options[i].value==con)
										document.frmEditMember.cboActivate.selectedIndex = i;
							</SCRIPT></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Company Name*</TD>
        <TD><input class=Textbox maxlength=100 name=txtmember_company value="<%=member_company%>"></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Company Type</TD>
        <TD> 
          <!--<select name="cboType" size="5" multiple style="width:200px">
                  <option value="1" selected>Manufacturer</option>
                  <option value="2">Exporter</option>
                  <option value="3">Importer</option>
                  <option value="4">Dealer / Reseller</option>
                  <option value="5">Retailer</option>
                  <option value="6">Service Provider</option>
                </select>-->
          <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr> 
              <td width="31%"><input type="checkbox" name="chkExpImp" value="1" <% if exp_imp_type & ""="1" then Response.Write("checked")%>>
                Exporter / Importer</td>
              <td width="34%"><input type="checkbox" name="chkDealer" value="2" <% if dealer_reseller_type & ""="1" then Response.Write("checked")%>>
                Dealer / Reseller</td>
              <td width="35%"><input type="checkbox" name="chkRetailer" value="3" <% if retailer_type & ""="1" then Response.Write("checked")%>>
                Retailer</td>
            </tr>
            <tr> 
              <td><input type="checkbox" name="chkServProv" value="4" <% if service_prov_type & ""="1" then Response.Write("checked")%>>
                Service Provider&nbsp;&nbsp;</td>
              <td><input type="checkbox" name="chkFF" value="5" <% if freight_type & ""="1" then Response.Write("checked")%>>
                Freight forwarder</td>
              <td>&nbsp;</td>
            </tr>
          </table>
          
        </TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Mailing mailing_address*</TD>
        <TD><textarea name="txtmailing_address" cols="35" rows="4" id="textarea"><%=mailing_address%></textarea></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Country*</TD>
        <TD> <select name = "cboCountry" class=textbox style="width:200px">
            <option value='select'>[--select--]</option>
            <% 
                                set rsTemp  = conn.Execute("select * from Country order by Country_Name")
						  	rsTemp.MoveFirst 
						  	do while not rsTemp.EOF  %>
            <option value="<%=rsTemp("Country_id")%>"><%=rsTemp("Country_Name")%></option>
            <% rsTemp.MoveNext 
						  	loop 
						  	set rsTemp=nothing %>
          </select> <SCRIPT LANGUAGE=javascript>
								con = "<%=Country_id%>"
								if (con.length==0) 
								 con = "1" 
								for (i=0;i<document.frmEditMember.cboCountry.length;i++)
									if (document.frmEditMember.cboCountry.options[i].value==con)
										document.frmEditMember.cboCountry.selectedIndex = i;
							</SCRIPT> </TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Phone* </TD>
        <TD>+ 
          <input name="txtPhCou" type="text" class="TextBox" value="<%if len(PhCountry & "")=0 then Response.Write "Country" else Response.Write PhCountry%>" size="6" maxlength="4" style="Width: 50px;" onFocus="if (this.value=='Country') this.value='';"  onBlur="if (this.value=='') this.value='Country';"> 
          <input name="txtPhArea" type="text" class="TextBox" id="txtPhArea" value="<%if len(PhArea & "")=0 then Response.Write "AreaCode" else Response.Write PhArea%>" size="10" maxlength="6" style="Width: 75px;"  onFocus="if (this.value=='AreaCode') this.value='';"  onBlur="if (this.value=='') this.value='AreaCode';"> 
          <input name="txtPhone" type="text" class="TextBox" id="txtPhone" value="<%if len(company_phone & "")=0 then Response.Write "company_phone" else Response.Write company_phone%>" size="15" maxlength="12" onFocus="if (this.value=='company_phone') this.value='';"  onBlur="if (this.value=='') this.value='company_phone';"></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Fax No* </TD>
        <TD>+ 
          <input name="txtFaxCou" type="text" class="TextBox" id="txtFaxCou" value="<%if len(FaxCountry & "")=0 then Response.Write "Country" else Response.Write FaxCountry%>" size="6" maxlength="4" style="Width: 50px;" onFocus="if (this.value=='Country') this.value='';"  onBlur="if (this.value=='') this.value='Country';"> 
          <input name="txtFaxArea" type="text" class="TextBox" id="txtFaxArea" value="<%if len(FaxArea & "")=0 then Response.Write "AreaCode" else Response.Write FaxArea%>" size="10" maxlength="6" style="Width: 75px;" onFocus="if (this.value=='AreaCode') this.value='';"  onBlur="if (this.value=='') this.value='AreaCode';"> 
          <INPUT class=Textbox maxLength=20 name=txtcompany_fax  value="<%if len(company_fax & "")=0 then Response.Write "company_fax" else Response.Write company_fax%>" onFocus="if (this.value=='company_fax') this.value='';"  onBlur="if (this.value=='') this.value='company_fax';"></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Email Id* </TD>
        <TD><INPUT class=Textbox maxLength=100 name=txtEmail value="<%=company_email%>"></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>company_website</TD>
        <TD><INPUT name=txtWeb class=Textbox  value="<%=company_website%>" maxLength=100></TD>
      </TR>
    </TBODY>
  </TABLE>
  <br>
  <TABLE width="90%"  border=0 align="center">
    <TBODY>
      <TR> 
        <TD class=HeadingWithBackGround align=left 
                        colSpan=2>Contact Information</TD>
      </TR>
      <TR class=TableBackGround> 
        <TD width="35%" align=right>Contact person name*</TD>
        <TD width="65%"><input class=TextBox maxlength=100 name=txtName value="<%=company_contact1_name%>"></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Mobile No* </TD>
        <TD>+ 
          <input name="txtMobCou" type="text" class="TextBox" id="txtMobCou" value="<%if len(MobCountry & "")=0 then Response.Write "Country" else Response.Write MobCountry%>" size="6" maxlength="4" style="Width: 50px;" onFocus="if (this.value=='Country') this.value='';"  onBlur="if (this.value=='') this.value='Country';"> 
          <input name="txtMobArea" type="text" class="TextBox" id="txtMobArea" value="<%if len(MobArea & "")=0 then Response.Write "MobileCode" else Response.Write MobArea%>" size="10" maxlength="6" style="Width: 75px;" onFocus="if (this.value=='MobileCode') this.value='';"  onBlur="if (this.value=='') this.value='MobileCode';"> 
          <input name="txtcompany_contact1_mobile" type="text" class="TextBox" id="txtcompany_contact1_mobile" value="<%if len(company_contact1_mobile & "")=0 then Response.Write "company_contact1_mobile" else Response.Write company_contact1_mobile%>" size="15" maxlength="12" onFocus="if (this.value=='company_contact1_mobile') this.value='';"  onBlur="if (this.value=='') this.value='company_contact1_mobile';"> 
        </TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Personal Email Id</TD>
        <TD><INPUT class=Textbox maxLength=100 name=txtPersEmail1 value="<%=company_contact1_email%>"></TD>
      </TR>
      <TR class=HeadingWithBackGround height="1"> 
        <TD colspan="2" align=right></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Second contact</TD>
        <TD><input class=TextBox maxlength=100 name=txtSecondName value="<%=company_contact2_name%>"></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Mobile No</TD>
        <TD>+ 
          <input name="txtMobCou1" type="text" class="TextBox" id="txtMobCou1" value="<%if len(MobCountry1 & "")=0 then Response.Write "Country" else Response.Write MobCountry1%>" size="6" maxlength="4" style="Width: 50px;" onFocus="if (this.value=='Country') this.value='';"  onBlur="if (this.value=='') this.value='Country';"> 
          <input name="txtMobArea1" type="text" class="TextBox" id="txtMobArea1" value="<%if len(MobArea1 & "")=0 then Response.Write "MobileCode" else Response.Write MobArea1%>" size="10" maxlength="6" style="Width: 75px;"  onFocus="if (this.value=='MobileCode') this.value='';"  onBlur="if (this.value=='') this.value='MobileCode';"> 
          <input name="txtcompany_contact1_mobile1" type="text" class="TextBox" id="txtcompany_contact1_mobile1" value="<%if len(company_contact1_mobile1 & "")=0 then Response.Write "company_contact1_mobile" else Response.Write company_contact1_mobile1%>" size="15" maxlength="12"  onFocus="if (this.value=='company_contact1_mobile') this.value='';"  onBlur="if (this.value=='') this.value='company_contact1_mobile';"> 
        </TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Personal Email Id</TD>
        <TD><INPUT class=Textbox maxLength=100 name=txtPersEmail2 value="<%=company_contact2_email%>"></TD>
      </TR>
    </TBODY>
  </TABLE>
  <br>
  <TABLE width="90%"  border=0 align="center">
    <TBODY>
      <TR> 
        <TD class=HeadingWithBackGround align=left 
                        colSpan=3>Dealing in</TD>
      </TR>
      <tr>
        <td><input type="checkbox" name="chkCategory" value="1">
          SIM Free Phones</td>
        <td><input type="checkbox" name="chkCategory"  value="2">
          Newtwork Stock</td>
        <td><input type="checkbox" name="chkCategory" value="3">
          Used Mobile Phones</td>
      </tr>
      <script language=javascript>          
var col="<%=Category%>".split(", ");
var chk = document.frmEditMember.chkCategory;
var loc=0;
while (loc < col.length)
{
	for (i = 0; i < chk.length; i++){
	if (chk[i].value == col[loc]){
		chk[i].checked=true;
		break
		}
	}
	loc+=1;
}
</script>
    </TBODY>
  </TABLE>
  <br>

   
  <TABLE width="90%"  border=0 align="center">
    <TBODY>
      <TR> 
        <TD class=HeadingWithBackGround align=left>Login Information (Required 
          for SilverLevel members) </TD>
        <TD class=HeadingWithBackGround align=right><div align="center">
            <input name="chkUsrpassword" type="checkbox" value="1">
            Change user name and password?</div></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD width="35%" align=right>UserName* </TD>
        <TD width="65%"><INPUT class=Textbox maxLength=25 name=txtUserName  value="<%=member_id%>">
          <strong><a href="Javascript:CheckUserName();"><font color="#FF0000"><u>Check Username</u></font></a></strong></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Password* </TD>
        <TD><INPUT class=Textbox type=password maxLength=20 
                        name=txtpassword></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Retype Password*</TD>
        <TD><input class=Textbox type=password maxlength=20 
                        name=txtRepassword></TD>
      </TR>
    </TBODY>
  </TABLE>
  <br>
  <TABLE width="90%"  border=0 align="center" dwcopytype="CopyTableRow">
    <TBODY>
      <TR class=TableBackGround> 
        <TD width="34%" align=right>&nbsp;</TD>
        <TD width="66%">&nbsp;</TD>
      </TR>
      <TR class=TableBackGround> 
        <TD height="18" align=right>&nbsp;</TD>
        <TD><input class=Buttons type=submit value="    Update   " name=btnOk> 
          <input class=Buttons onClick=javascript:history.back(); type=button value=" Cancel " name=btnCancel></TD>
      </TR>
    </TBODY>
  </TABLE>
  <% end if%>
  <script language=javascript>
					var txt="<%=msg%>";
					if (txt.length>0)
					{
					     alert(txt);
					}
					</script>
</form>
</body>
</html>
