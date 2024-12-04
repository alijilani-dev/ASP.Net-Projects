<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
	Dim rsTemp
	Dim CompanyName, YourName
	Dim Address, CountryCode
	Dim PhoneNo, FaxNo, MobileNo
	Dim EmailId, UsrName, Pwd
	Dim Flag, MemberCode, msg, Category

	YourName = replace(Request.Form("txtName"),"`","'")
	CompanyName = replace(Request.Form("txtCompanyName"),"`","'")
	Address = replace(Request.Form("txtAddress"),"`","'")
	CountryCode = Request.Form("cboCountry")
	PhoneNo = replace(Request.Form("txtPhone"),"`","'")
	FaxNo = replace(Request.Form("txtFaxNo"),"`","'")
	MobileNo = replace(Request.Form("txtMobileNo"),"`","'")
	EmailId = Request.Form("txtEmail")
	Website = replace(Request.Form("txtWeb"),"`","'")
	UsrName = replace(Request.Form("txtUserName"),"`","'")
	Pwd = replace(Request.Form("txtPwd"),"`","'")
	Category = Request.Form("chkCategory")
	MobileNo1 = replace(Request.Form("txtMobileNo1"),"`","'")
	SecondName=  replace(Request.Form("txtSecondName"),"`","'")
	PersEmailId1= Request.Form("txtPersEmail1")
	PersEmailId2= Request.Form("txtPersEmail2")
	MemberLevel= Request.Form("cboSelect") & ""
	MobileNo1 = replace(Request.Form("txtMobileNo1"),"`","'")
	
	if len(PhoneNo & "")>0 then
		pos = instr(PhoneNo, "*")
		PhCountry = mid(PhoneNo,1,pos-1)
		PhoneNo = mid(PhoneNo,pos+1)
		pos = instr(PhoneNo, "*")
		PhArea = mid(PhoneNo,1,pos-1)
		if PhArea="A" then PhArea="AreaCode"
		PhoneNo = mid(PhoneNo,pos+1)
	end if	
	if len(FaxNo & "")>0 then
		pos = instr(FaxNo, "*")
		FaxCountry = mid(FaxNo,1,pos-1)
		FaxNo = mid(FaxNo,pos+1)
		pos = instr(FaxNo, "*")
		FaxArea = mid(FaxNo,1,pos-1)
		if FaxArea="A" then FaxArea="AreaCode"
		FaxNo = mid(FaxNo,pos+1)
	end if
	if len(MobileNo & "")>0 then
		pos = instr(MobileNo, "*")
		MobCountry = mid(MobileNo,1,pos-1)
		MobileNo = mid(MobileNo,pos+1)
		pos = instr(MobileNo, "*")
		MobArea = mid(MobileNo,1,pos-1)
		if MobArea="A" then MobArea="AreaCode"
		MobileNo = mid(MobileNo,pos+1)
	end if
	if len(MobileNo1)>0 then
		pos = instr(MobileNo1, "*")
		MobCountry1 = mid(MobileNo1,1,pos-1)
		MobileNo1 = mid(MobileNo1,pos+1)
		pos = instr(MobileNo1, "*")
		MobArea1 = mid(MobileNo1,1,pos-1)
		if MobArea1="A" then MobArea1="AreaCode"
		MobileNo1 = mid(MobileNo1,pos+1)
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
function acceptedterms(str){
if (document.frmNewMember.chkTermsandcond.checked == false )
{
	errStr = errStr + str + "\n";
	return false;
}
else
return true;
}

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
		CanSubmit =  ForceEntry(document.forms["frmNewMember"].txtCompanyName,"    - Company name is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtAddress,"    - Mailing address is required.");
		CanSubmit = CanSubmit & DefaultCheck(document.forms["frmNewMember"].cboCountry.value,"    - Country is required.");

		CanSubmit = CanSubmit & DefaultCheckText("Country",document.forms["frmNewMember"].txtPhCou.value,"    - Country Code is required for Phone number.");
		CanSubmit = CanSubmit & DefaultCheckText("PhoneNo",document.forms["frmNewMember"].txtPhone.value,"    - Phone number is required.");

		CanSubmit = CanSubmit & DefaultCheckText("Country",document.forms["frmNewMember"].txtFaxCou.value,"    - Country Code is required for Fax number.");
		CanSubmit = CanSubmit & DefaultCheckText("FaxNo",document.forms["frmNewMember"].txtFaxNo.value,"    - Fax number is required.");

		//CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtFaxNo,"    - Fax number is required.");		
		//CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtMobileNo,"    - Mobile number is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtEmail,"    - Email-id is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtName,"    - Contact person is required.");	

		CanSubmit = CanSubmit & DefaultCheckText("Country",document.forms["frmNewMember"].txtMobCou.value,"    - Country Code is required for Mobile number.");
		CanSubmit = CanSubmit & DefaultCheckText("MobileCode",document.forms["frmNewMember"].txtMobArea.value,"    - Mobile Code is required for Mobile number.");
		CanSubmit = CanSubmit & DefaultCheckText("MobileNo",document.forms["frmNewMember"].txtMobileNo.value,"    - Mobile number is required.");
	
		if (document.forms["frmNewMember"].txtEmail.value.length>0)
			CanSubmit = CanSubmit & checkemail(document.forms["frmNewMember"].txtEmail.value,"    - Invalid Email-id.");

		if(document.frmNewMember.chkType[5].checked==false)
		{CanSubmit = CanSubmit & Check("    - Please atleast select one items from \'Dealing in group\'.");}
		
		var x = document.frmNewMember.cboSelect.options[document.frmNewMember.cboSelect.selectedIndex].value;
		if (x==2)
		{
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtUserName,"    - Username is required.");		
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtPwd,"    - Password is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmNewMember"].txtRePwd,"    - Retype password is required.");
		var a=document.forms["frmNewMember"].txtPwd.value;
		var b=document.forms["frmNewMember"].txtRePwd.value;		
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
			CanSubmit = CanSubmit & numEntry(document.forms["frmNewMember"].txtFaxNo.value,"    - Fax number should be Numeric.");
			
			CanSubmit = CanSubmit & checkemail(document.forms["frmNewMember"].txtEmail.value,"    - Invalid Email-id.");

			CanSubmit = CanSubmit & numEntry(document.forms["frmNewMember"].txtMobCou.value,"    - Country Code should be Numeric for Mobile number.");
			x = document.forms["frmNewMember"].txtMobArea.value;
			if (x!='AreaCode') CanSubmit = CanSubmit & numEntry(x,"    - Area Code should be Numeric for Phone number.");
			CanSubmit = CanSubmit & numEntry(document.forms["frmNewMember"].txtMobileNo.value,"    - Mobile number should be Numeric.");

		if(document.frmNewMember.chkType[5].checked==false)
		{CanSubmit = CanSubmit & Check("    - Please atleast select one items from \'Dealing in group\'.");}
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
        <TD><input class=Textbox maxlength=100 name=txtCompanyName value="<%=CompanyName%>"></TD>
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
              <td width="31%"><input type="checkbox" name="chkType" value="1">
                Manufacturer</td>
              <td width="34%"><input type="checkbox" name="chkType" value="2">
                Exporter / Importer</td>
              <td width="35%"><input type="checkbox" name="chkType" value="3">
                Dealer / Reseller</td>
            </tr>
            <tr> 
              <td><input type="checkbox" name="chkType" value="4">
                Retailer</td>
              <td><input type="checkbox" name="chkType" value="5">
                Service Provider&nbsp;&nbsp;</td>
              <td><input type="checkbox" name="chkType" value="6">
                Freight forwarder</td>
            </tr>
          </table></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Mailing address*</TD>
        <TD><textarea name="txtAddress" cols="35" rows="4" id="textarea"><%=Address%></textarea></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Country*</TD>
        <TD> <select name = "cboCountry" class=textbox style="width:200px">
            <option value='select'>[--select--]</option>
            <% 
                                set rsTemp  = conn.Execute("select * from mCountry order by CountryName")
						  	rsTemp.MoveFirst 
						  	do while not rsTemp.EOF  %>
            <option value="<%=rsTemp("CountryCode")%>"><%=rsTemp("CountryName")%></option>
            <% rsTemp.MoveNext 
						  	loop 
						  	set rsTemp=nothing %>
          </select> <SCRIPT LANGUAGE=javascript>
								con = "<%=CountryCode%>"
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
          <input name="txtPhone" type="text" class="TextBox" id="txtPhone" value="<%if len(PhoneNo & "")=0 then Response.Write "PhoneNo" else Response.Write PhoneNo%>" size="15" maxlength="12" onFocus="if (this.value=='PhoneNo') this.value='';"  onBlur="if (this.value=='') this.value='PhoneNo';"></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Fax No* </TD>
        <TD>+ 
          <input name="txtFaxCou" type="text" class="TextBox" id="txtFaxCou" value="<%if len(FaxCountry & "")=0 then Response.Write "Country" else Response.Write FaxCountry%>" size="6" maxlength="4" style="Width: 50px;" onFocus="if (this.value=='Country') this.value='';"  onBlur="if (this.value=='') this.value='Country';"> 
          <input name="txtFaxArea" type="text" class="TextBox" id="txtFaxArea" value="<%if len(FaxArea & "")=0 then Response.Write "AreaCode" else Response.Write FaxArea%>" size="10" maxlength="6" style="Width: 75px;" onFocus="if (this.value=='AreaCode') this.value='';"  onBlur="if (this.value=='') this.value='AreaCode';"> 
          <INPUT class=Textbox maxLength=20 name=txtFaxNo  value="<%if len(FaxNo & "")=0 then Response.Write "FaxNo" else Response.Write FaxNo%>" onFocus="if (this.value=='FaxNo') this.value='';"  onBlur="if (this.value=='') this.value='FaxNo';"></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Email Id* </TD>
        <TD><INPUT class=Textbox maxLength=100 name=txtEmail value="<%=EmailId%>"></TD>
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
        <TD width="65%"><input class=TextBox maxlength=100 name=txtName value="<%=YourName%>"></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Mobile No* </TD>
        <TD>+ 
          <input name="txtMobCou" type="text" class="TextBox" id="txtMobCou" value="<%if len(MobCountry & "")=0 then Response.Write "Country" else Response.Write MobCountry%>" size="6" maxlength="4" style="Width: 50px;" onFocus="if (this.value=='Country') this.value='';"  onBlur="if (this.value=='') this.value='Country';"> 
          <input name="txtMobArea" type="text" class="TextBox" id="txtMobArea" value="<%if len(MobArea & "")=0 then Response.Write "MobileCode" else Response.Write MobArea%>" size="10" maxlength="6" style="Width: 75px;" onFocus="if (this.value=='MobileCode') this.value='';"  onBlur="if (this.value=='') this.value='MobileCode';"> 
          <input name="txtMobileNo" type="text" class="TextBox" id="txtMobileNo" value="<%if len(MobileNo & "")=0 then Response.Write "MobileNo" else Response.Write MobileNo%>" size="15" maxlength="12" onFocus="if (this.value=='MobileNo') this.value='';"  onBlur="if (this.value=='') this.value='MobileNo';"> 
        </TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Personal Email Id</TD>
        <TD><INPUT class=Textbox maxLength=100 name=txtPersEmail1 value="<%=PersEmailId1%>"></TD>
      </TR>
      <TR class=HeadingWithBackGround height="1"> 
        <TD colspan="2" align=right></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Second contact</TD>
        <TD><input class=TextBox maxlength=100 name=txtSecondName value="<%=SecondName%>"></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Mobile No</TD>
        <TD>+ 
          <input name="txtMobCou1" type="text" class="TextBox" id="txtMobCou1" value="<%if len(MobCountry & "")=0 then Response.Write "Country" else Response.Write MobCountry%>" size="6" maxlength="4" style="Width: 50px;" onFocus="if (this.value=='Country') this.value='';"  onBlur="if (this.value=='') this.value='Country';"> 
          <input name="txtMobArea1" type="text" class="TextBox" id="txtMobArea1" value="<%if len(MobArea & "")=0 then Response.Write "MobileCode" else Response.Write MobArea%>" size="10" maxlength="6" style="Width: 75px;"  onFocus="if (this.value=='MobileCode') this.value='';"  onBlur="if (this.value=='') this.value='MobileCode';"> 
          <input name="txtMobileNo1" type="text" class="TextBox" id="txtMobileNo1" value="<%if len(MobileNo & "")=0 then Response.Write "MobileNo" else Response.Write MobileNo%>" size="15" maxlength="12"  onFocus="if (this.value=='MobileNo') this.value='';"  onBlur="if (this.value=='') this.value='MobileNo';"> 
        </TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Personal Email Id</TD>
        <TD><INPUT class=Textbox maxLength=100 name=txtPersEmail2 value="<%=PersEmailId2%>"></TD>
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
      <%
	Dim rsTemp1, count
	count =0 
	set rsTemp1 = Server.CreateObject("Adodb.Recordset")
	rsTemp1.Open "Select CategoryCode, CategoryName from mProdCategory",conn,2,1
	Response.Write "<TR class=TableBackGround>"
	do while not rsTemp1.EOF 
	if count=3 then 
		Response.Write "</tr><TR class=TableBackGround>"
		count=0
	end if
	Response.Write "<TD width=""33%"">"
	Response.Write "<input type=checkbox name=chkCategory value='" & rsTemp1(0) & "'>" & rsTemp1(1)
	Response.Write "</TD>"
	count = count+1
	rsTemp1.MoveNext 
	loop
	for i = count to 2
	Response.Write "<TD width=""33%"">&nbsp;</TD>"
	next
	Response.Write "</tr>"
%>
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
        <TD width="65%"><INPUT class=Textbox maxLength=25 name=txtUserName  value="<%=UsrName%>"></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Password* </TD>
        <TD><INPUT class=Textbox type=password maxLength=20 
                        name=txtPwd></TD>
      </TR>
      <TR class=TableBackGround> 
        <TD align=right>Retype Password*</TD>
        <TD><input class=Textbox type=password maxlength=20 
                        name=txtRePwd></TD>
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
