<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
	Dim rsTemp
	Dim member_company, company_contact1_name
	Dim mailing_address, country_id
	Dim company_phone, company_fax, company_contact1_mobile
	Dim company_email, member_id, password
	Dim Flag, MemberCode, msg, Category

	company_contact1_name = replace(Request.Form("txtName"),"`","'")
	member_company = replace(Request.Form("txtmember_company"),"`","'")
	mailing_address = replace(Request.Form("txtmailing_address"),"`","'")
	country_id = Request.Form("cboCountry")
	company_phone = replace(Request.Form("txtPhone"),"`","'")
	company_fax = replace(Request.Form("txtcompany_fax"),"`","'")
	company_contact1_mobile = replace(Request.Form("txtcompany_contact1_mobile"),"`","'")
	company_email = Request.Form("txtEmail")
	Website = replace(Request.Form("txtWeb"),"`","'")
	member_id = replace(Request.Form("txtUserName"),"`","'")
	password = replace(Request.Form("txtpassword"),"`","'")
	Category = Request.Form("chkCategory")
	company_contact1_mobile1 = replace(Request.Form("txtcompany_contact1_mobile1"),"`","'")
	company_contact2_name=  replace(Request.Form("txtcompany_contact2_name"),"`","'")
	company_contact1_email= Request.Form("txtPersEmail1")
	company_contact2_email= Request.Form("txtPersEmail2")
	MemberLevel= Request.Form("cboSelect") & ""
	company_contact1_mobile1 = replace(Request.Form("txtcompany_contact1_mobile1"),"`","'")
	
	if len(company_phone & "")>0 then
		pos = instr(company_phone, "*")
		PhCountry = mid(company_phone,1,pos-1)
		company_phone = mid(company_phone,pos+1)
		pos = instr(company_phone, "*")
		PhArea = mid(company_phone,1,pos-1)
		if PhArea="A" then PhArea="AreaCode"
		company_phone = mid(company_phone,pos+1)
	end if	
	if len(company_fax & "")>0 then
		pos = instr(company_fax, "*")
		FaxCountry = mid(company_fax,1,pos-1)
		company_fax = mid(company_fax,pos+1)
		pos = instr(company_fax, "*")
		FaxArea = mid(company_fax,1,pos-1)
		if FaxArea="A" then FaxArea="AreaCode"
		company_fax = mid(company_fax,pos+1)
	end if
	if len(company_contact1_mobile & "")>0 then
		pos = instr(company_contact1_mobile, "*")
		MobCountry = mid(company_contact1_mobile,1,pos-1)
		company_contact1_mobile = mid(company_contact1_mobile,pos+1)
		pos = instr(company_contact1_mobile, "*")
		MobArea = mid(company_contact1_mobile,1,pos-1)
		if MobArea="A" then MobArea="AreaCode"
		company_contact1_mobile = mid(company_contact1_mobile,pos+1)
	end if
	if len(company_contact1_mobile1)>0 then
		pos = instr(company_contact1_mobile1, "*")
		MobCountry1 = mid(company_contact1_mobile1,1,pos-1)
		company_contact1_mobile1 = mid(company_contact1_mobile1,pos+1)
		pos = instr(company_contact1_mobile1, "*")
		MobArea1 = mid(company_contact1_mobile1,1,pos-1)
		if MobArea1="A" then MobArea1="AreaCode"
		company_contact1_mobile1 = mid(company_contact1_mobile1,pos+1)
	end if


	msg = Request.Form("hdMsg")
		
%>
<html>
<head>
<title>New Member</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="../Styles/CssStyles.CSS" rel="stylesheet" type="text/css">
<script language="JavaScript1.2" type="text/JavaScript1.2" src="../Main/Main.js"></script>
</head>

<body>
<!--#Include file="Top1.asp"-->
<form name="frmNewMember" method="post" action=""  onSubmit="JavaScript:return FormSubmit();">
  <input type=hidden name="hdProc" value="">
  <script language=javascript>

function Check(str){
var chk = document.frmNewMember.chkCategory;
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
		CanSubmit =  ForceEntry(document.forms["frmNewMember"].txtmember_company,"    - Company name is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtmailing_address,"    - Mailing mailing_address is required.");
		CanSubmit = CanSubmit & DefaultCheck(document.forms["frmNewMember"].cboCountry.value,"    - Country is required.");

		CanSubmit = CanSubmit & DefaultCheckText("Country",document.forms["frmNewMember"].txtPhCou.value,"    - Country Code is required for Phone number.");
		CanSubmit = CanSubmit & DefaultCheckText("company_phone",document.forms["frmNewMember"].txtPhone.value,"    - Phone number is required.");

		CanSubmit = CanSubmit & DefaultCheckText("Country",document.forms["frmNewMember"].txtFaxCou.value,"    - Country Code is required for Fax number.");
		CanSubmit = CanSubmit & DefaultCheckText("company_fax",document.forms["frmNewMember"].txtcompany_fax.value,"    - Fax number is required.");

		//CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtcompany_fax,"    - Fax number is required.");		
		//CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtcompany_contact1_mobile,"    - Mobile number is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtEmail,"    - Email-id is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtName,"    - Contact person is required.");	

		CanSubmit = CanSubmit & DefaultCheckText("Country",document.forms["frmNewMember"].txtMobCou.value,"    - Country Code is required for Mobile number.");
		CanSubmit = CanSubmit & DefaultCheckText("MobileCode",document.forms["frmNewMember"].txtMobArea.value,"    - Mobile Code is required for Mobile number.");
		CanSubmit = CanSubmit & DefaultCheckText("company_contact1_mobile",document.forms["frmNewMember"].txtcompany_contact1_mobile.value,"    - Mobile number is required.");
	
		if (document.forms["frmNewMember"].txtEmail.value.length>0)
			CanSubmit = CanSubmit & checkemail(document.forms["frmNewMember"].txtEmail.value,"    - Invalid Email-id.");

		//if(document.frmNewMember.chkType[5].checked==false)
		//{CanSubmit = CanSubmit & Check("    - Please atleast select one items from \'Dealing in group\'.");}

		var x = document.frmNewMember.cboSelect.options[document.frmNewMember.cboSelect.selectedIndex].value;
		if (x==2)
		{
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtUserName,"    - Username is required.");		
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtpassword,"    - Password is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtRepassword,"    - Retype password is required.");
		var a=document.forms["frmNewMember"].txtpassword.value;
		var b=document.forms["frmNewMember"].txtRepassword.value;		
		if (a.length>0 && b.length>0 && a!=b)
		{
			errStr = errStr + "    - Passwords Mismatch.\n";
			CanSubmit = false;
		}	
		}

						
		CanSubmit = (CanSubmit!=0)
		
		if (CanSubmit)
		{		
			CanSubmit = CanSubmit & numEntry(document.forms["frmNewMember"].txtPhCou.value,"    - Country Code should be Numeric for Phone number.");
			x = document.forms["frmNewMember"].txtPhArea.value;
			if (x!='AreaCode') CanSubmit = CanSubmit & numEntry(x,"    - Area Code should be Numeric for Phone number.");
			CanSubmit = CanSubmit & numEntry(document.forms["frmNewMember"].txtPhone.value,"    - Phone number should be Numeric.");

			CanSubmit = CanSubmit & numEntry(document.forms["frmNewMember"].txtFaxCou.value,"    - Country Code should be Numeric for Fax number.");
			x = document.forms["frmNewMember"].txtFaxArea.value;
			if (x!='AreaCode') CanSubmit = CanSubmit & numEntry(x,"    - Area Code should be Numeric for Fax number.");
			CanSubmit = CanSubmit & numEntry(document.forms["frmNewMember"].txtcompany_fax.value,"    - Fax number should be Numeric.");
			
			CanSubmit = CanSubmit & checkemail(document.forms["frmNewMember"].txtEmail.value,"    - Invalid Email-id.");

			CanSubmit = CanSubmit & numEntry(document.forms["frmNewMember"].txtMobCou.value,"    - Country Code should be Numeric for Mobile number.");
			x = document.forms["frmNewMember"].txtMobArea.value;
			if (x!='AreaCode') CanSubmit = CanSubmit & numEntry(x,"    - Area Code should be Numeric for Phone number.");
			CanSubmit = CanSubmit & numEntry(document.forms["frmNewMember"].txtcompany_contact1_mobile.value,"    - Mobile number should be Numeric.");

		//if(document.frmNewMember.chkType[5].checked==false)
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
			document.frmNewMember.hdProc.value="1"
			document.frmNewMember.action="Insert.asp";
			document.frmNewMember.submit();   
		}
}
</script>
  <TABLE width="100%"  border=0>
    <TBODY>
      <TR align="right"> 
        <TD 
                        colSpan=2>Fields marked with * are Mandatory</TD>
      </TR>
      <TR> 
        <TD class=HeadingWithBackGround align=left 
                        colSpan=2>Company Information</TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Select type of member</TD>
        <TD><select name="cboSelect" style="width:200px">
            <option value="1" selected>Basic Level [Traders]</option>
            <option value="2">Silver Level [Traders & Members]</option>
          </select>
		<SCRIPT LANGUAGE=javascript>
		con = "<%=MemberLevel%>"
		for (i=0;i<document.frmNewMember.cboSelect.length;i++)
		if (document.frmNewMember.cboSelect.options[i].value==con)
			document.frmNewMember.cboSelect.selectedIndex = i;
		</SCRIPT>
          </TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Activate</TD>
        <TD><select name="cboActivate" id="cboActivate" style="width:200px">
            <option value="1" selected>Activate</option>
            <option value="2">Deactivate</option>
          </select></TD>
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
              <td width="31%"><input type="checkbox" name="chkExpImp" value="1">
                Exporter / Importer</td>
              <td width="34%"><input type="checkbox" name="chkDealer" value="2">
                Dealer / Reseller</td>
              <td width="35%"><input type="checkbox" name="chkRetailer" value="3">
                Retailer</td>
            </tr>
            <tr> 
              <td><input type="checkbox" name="chkServProv" value="4">
                Service Provider&nbsp;&nbsp;</td>
              <td><input type="checkbox" name="chkFF" value="5">
                Freight forwarder</td>
              <td>&nbsp;</td>
            </tr>
          </table></TD>
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
                                set rsTemp  = conn.Execute("select * from Country order by country_name")
						  	rsTemp.MoveFirst 
						  	do while not rsTemp.EOF  %>
            <option value="<%=rsTemp("country_id")%>"><%=rsTemp("country_name")%></option>
            <% rsTemp.MoveNext 
						  	loop 
						  	set rsTemp=nothing %>
          </select> <SCRIPT LANGUAGE=javascript>
								con = "<%=country_id%>"
								if (con.length==0) 
								 con = "1" 
								for (i=0;i<document.frmNewMember.cboCountry.length;i++)
									if (document.frmNewMember.cboCountry.options[i].value==con)
										document.frmNewMember.cboCountry.selectedIndex = i;
							</SCRIPT> </TD>
      </TR>
      <TR class=TableBackGround> 
        <TD width="35%" align=right>Phone* </TD>
        <TD width="65%">+ 
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
        <TD align=right>Website</TD>
        <TD><INPUT name=txtWeb class=Textbox  value="<%=Website%>" maxLength=100></TD>
      </TR>
    </TBODY>
  </TABLE>
  <br>
  <TABLE width="100%"  border=0>
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
        <TD><input class=TextBox maxlength=100 name=txtcompany_contact2_name value="<%=company_contact2_name%>"></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Mobile No</TD>
        <TD>+ 
          <input name="txtMobCou1" type="text" class="TextBox" id="txtMobCou1" value="<%if len(MobCountry & "")=0 then Response.Write "Country" else Response.Write MobCountry%>" size="6" maxlength="4" style="Width: 50px;" onFocus="if (this.value=='Country') this.value='';"  onBlur="if (this.value=='') this.value='Country';"> 
          <input name="txtMobArea1" type="text" class="TextBox" id="txtMobArea1" value="<%if len(MobArea & "")=0 then Response.Write "MobileCode" else Response.Write MobArea%>" size="10" maxlength="6" style="Width: 75px;"  onFocus="if (this.value=='MobileCode') this.value='';"  onBlur="if (this.value=='') this.value='MobileCode';"> 
          <input name="txtcompany_contact1_mobile1" type="text" class="TextBox" id="txtcompany_contact1_mobile1" value="<%if len(company_contact1_mobile & "")=0 then Response.Write "company_contact1_mobile" else Response.Write company_contact1_mobile%>" size="15" maxlength="12"  onFocus="if (this.value=='company_contact1_mobile') this.value='';"  onBlur="if (this.value=='') this.value='company_contact1_mobile';"> 
        </TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Personal Email Id</TD>
        <TD><INPUT class=Textbox maxLength=100 name=txtPersEmail2 value="<%=company_contact2_email%>"></TD>
      </TR>
      <TR class=TableBackGround>
        <TD align=right>&nbsp;</TD>
        <TD>&nbsp;</TD>
      </TR>
    </TBODY>
  </TABLE>
  <br>
  <TABLE width="100%"  border=0>
    <TBODY>
      <TR> 
        <TD class=HeadingWithBackGround align=left 
                        colSpan=3>Dealing in</TD>
      </TR>
      <tr><td><input type="checkbox" name="chkCategory" value="1">	SIM Free Phones</td>
	  <td><input type="checkbox" name="chkCategory"  value="2">Newtwork Stock</td>
	  <td><input type="checkbox" name="chkCategory" value="3">Used Mobile Phones</td>
	  </tr>
      <script language=javascript>          
var col="<%=Category%>".split(", ");
var chk = document.frmNewMember.chkCategory;
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
  <TABLE width="100%"  border=0>
    <TBODY>
      <TR> 
        <TD class=HeadingWithBackGround align=left 
                        colSpan=2>Login Information (Required for SilverLevel 
          members)</TD>
      </TR>
      <TR class=TableBackGround> 
        <TD width="35%" align=right>UserName* </TD>
        <TD width="65%"><INPUT class=Textbox maxLength=25 name=txtUserName  value="<%=member_id%>"></TD>
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
  <TABLE width="100%"  border=0 dwcopytype="CopyTableRow">
    <TBODY>
      <TR class=TableBackGround> 
        <TD width="34%" align=right>&nbsp;</TD>
        <TD width="66%">&nbsp;</TD>
      </TR>
      <TR class=TableBackGround> 
        <TD height="18" align=right>&nbsp;</TD>
        <TD><input class=Buttons type=submit value="     Sign Up      " name=btnOk> 
          <input class=Buttons onClick=javascript:history.back(); type=button value=" Cancel " name=btnCancel>
        </TD>
      </TR>
    </TBODY>
  </TABLE>
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
