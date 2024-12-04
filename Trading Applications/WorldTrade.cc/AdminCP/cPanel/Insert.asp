<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
if len(Session("sLogmeinadmin"))=0 then
	Response.Redirect "Login.asp"	
end if
	Dim MyCDONTSMail
	Dim objHttp
	Dim strHTML,Query

	Dim rsMain 
	set rsMain = server.CreateObject("Adodb.Recordset")
	Dim hdProc
	hdProc=trim(Request.Form("btnOk")) & Request.Form("hdProc") & "" 
	

Dim member_company, company_contact1_name
Dim mailing_address, country_id, CompanyType
Dim company_Phone, company_fax, company_contact1_mobile
Dim company_email, member_id, password, MailFlag, MemberLevel
Dim Flag, MemberCode, Category, Colour, Activate

Select case hdProc
case "Sign Up1"

	MemberLevel	= Request.Form("cboSelect") & ""
	company_contact1_name = replace(Request.Form("txtName"),"'","`")
	member_company = replace(Request.Form("txtmember_company"),"'","`")

manufacturer_type =0
exp_imp_type = Request.Form("chkExpImp")
dealer_reseller_type = Request.Form("chkDealer")
retailer_type = Request.Form("chkRetailer")
service_prov_type = Request.Form("chkServProv")
freight_type = Request.Form("chkFF")

	mailing_address = replace(Request.Form("txtmailing_address"),"'","`")
	country_id = Request.Form("cboCountry")

	company_Phone = replace(Request.Form("txtPhCou"),"'","`") & "*" & replace(Request.Form("txtPhArea"),"'","`") & "*" & replace(Request.Form("txtPhone"),"'","`")
	company_fax = replace(Request.Form("txtFaxCou"),"'","`") & "*" & replace(Request.Form("txtFaxArea"),"'","`") & "*" & replace(Request.Form("txtcompany_fax"),"'","`")
	company_contact1_mobile = replace(Request.Form("txtMobCou"),"'","`") & "*" & replace(Request.Form("txtMobArea"),"'","`") & "*" & replace(Request.Form("txtcompany_contact1_mobile"),"'","`")
	company_contact1_mobile1 = replace(Request.Form("txtMobCou1"),"'","`") & "*" & replace(Request.Form("txtMobArea1"),"'","`") & "*" & replace(Request.Form("txtcompany_contact1_mobile1"),"'","`")

	company_contact2_name =  replace(Request.Form("txtcompany_contact2_name"),"'","`")	
	'company_Phone = replace(Request.Form("txtPhone"),"'","`")
	'company_fax = replace(Request.Form("txtcompany_fax"),"'","`")
	'company_contact1_mobile = replace(Request.Form("txtcompany_contact1_mobile"),"'","`")
	
	company_email = Request.Form("txtEmail")
	company_contact1_email= Request.Form("txtPersEmail1")
	company_contact2_email= Request.Form("txtPersEmail2")
	Website = replace(Request.Form("txtWeb"),"'","`")
	Category = Request.Form("chkCategory")
	Activate  = Request.Form("cboActivate") 
	member_id = replace(Request.Form("txtUserName"),"'","`")
	password = replace(Request.Form("txtpassword"),"'","`")

if MemberLevel & ""="1" then
'		MemberCode = conn.Execute("select Max(MemberCode) from Members")(0)
'		MemberCode=MemberCode & ""
'		if len(MemberCode)=0 then 
'			MemberCode=1 
'		else
'			MemberCode = cdbl(MemberCode) + 1
'		end if
'		if len(MemberCode)=0 OR IsNull(MemberCode) then MemberCode=1
    
		set ObjRs = server.CreateObject("adodb.recordset")
		ObjRs.Open "select * from Members",conn,3,3
		ObjRs.AddNew 	
'		ObjRs("MemberCode") = MemberCode


ObjRs("member_id")=member_id
ObjRs("password")=password

		ObjRs("company_contact1_name") = company_contact1_name
		ObjRs("member_company") = member_company
		ObjRs("manufacturer_type") =cint(manufacturer_type)
		ObjRs("exp_imp_type") =cint(exp_imp_type)
		ObjRs("dealer_reseller_type") =cint(dealer_reseller_type)
		ObjRs("retailer_type") =cint(retailer_type)
		ObjRs("service_prov_type") =cint(service_prov_type)
		ObjRs("freight_type") =cint(freight_type)								
		ObjRs("mailing_address") = mailing_address
		ObjRs("country_id") = country_id
		ObjRs("company_Phone") = company_Phone
		ObjRs("company_fax") = company_fax
		ObjRs("company_contact1_mobile") = company_contact1_mobile
		ObjRs("company_contact2_mobile") = company_contact2_mobile
		ObjRs("company_contact2_name") = company_contact2_name
		ObjRs("company_contact1_email") = company_contact1_email
		ObjRs("company_contact2_email") = company_contact2_email
		ObjRs("company_email") = company_email
		ObjRs("CategoryCode") = Category
		ObjRs("Activateflag") = Activate
		ObjRs("portal_id") = 1
ObjRs("timestamp") =dateadd("h", -4, Now())'dateadd("n", -30,dateadd("h", -5, Now()))'dateadd("h", -4, Now())'dateadd("n", -30,dateadd("h", -3, Now()))

		if len(Website)>7 then
			ObjRs("Website") = Website
		end if
		ObjRs.Update
		Flag="Yes"
		'Response.Write Flag
		'Response.end
		
		if err.number <> 0 then
			Response.Redirect "Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			
			''Mailing process					
				''This is to send b4 activation '/Phonetrade
				'Query ="http://www.phonetrade.cc/signup_email.asp?mem=" & member_company '& "&usr=" & strUser & "&pd=" & strpassword
				'Set objHttp = Server.CreateObject("Msxml2.ServerXMLHTTP")
				'objHttp.open "GET", Query, False
				'objHttp.send
				'strHTML = objHttp.responseText

				'Set MyCDONTSMail = CreateObject("CDONTS.NewMail")
				'MyCDONTSMail.From= "info@phonetrade.cc"
				'MyCDONTSMail.To= strToMail
				'MyCDONTSMail.BCC= "sales@phonetrade.cc"
				'MyCDONTSMail.Subject="Thanks for your Registration - Phonetrade.cc"'


				'MyCDONTSMail.BodyFormat=0
				'MyCDONTSMail.MailFormat=0
				'MyCDONTSMail.Body= strHTML
				'MyCDONTSMail.Send
				'set MyCDONTSMail=nothing
	
				Response.Redirect("Activate.asp")
		end if

		ObjRs.Close
		Set ObjRs = nothing
elseif MemberLevel & ""="2" then
		member_id = replace(Request.Form("txtUserName"),"'","`")
		password = replace(Request.Form("txtpassword"),"'","`")
		strSql = "select MemberCode from Members where member_id = '" & member_id & "'"
		rsMain.Open strSql,conn,3,2
		If Not rsMain.EOF Then 
			Flag = "No"
		else
			Flag = "Ok"
		end if
		rsMain.Close
		Set rsMain = Nothing
		if Flag="Ok" then
			set ObjRs = server.CreateObject("adodb.recordset")
			ObjRs.Open "select * from Members",conn,3,3
			ObjRs.AddNew 	
			ObjRs("company_contact1_name") = company_contact1_name
			ObjRs("member_company") = member_company
			ObjRs("manufacturer_type") =cint(manufacturer_type)
		ObjRs("exp_imp_type") =cint(exp_imp_type)
		ObjRs("dealer_reseller_type") =cint(dealer_reseller_type)
		ObjRs("retailer_type") =cint(retailer_type)
		ObjRs("service_prov_type") =cint(service_prov_type)
		ObjRs("freight_type") =cint(freight_type)								

			ObjRs("mailing_address") = mailing_address
			ObjRs("country_id") = country_id
			ObjRs("company_Phone") = company_Phone
			ObjRs("company_fax") = company_fax
			ObjRs("company_contact1_mobile") = company_contact1_mobile
			ObjRs("company_contact2_mobile") = company_contact2_mobile
			ObjRs("company_contact2_name") = company_contact2_name
			ObjRs("company_contact1_email") = company_contact1_email
			ObjRs("company_contact2_email") = company_contact2_email
			ObjRs("company_email") = company_email
			ObjRs("CategoryCode") = Category
			ObjRs("Activateflag") = Activate
			ObjRs("MemberLevel") = MemberLevel
			ObjRs("member_id") = member_id		
			ObjRs("password") = password		
ObjRs("timestamp") =dateadd("h", -4, Now())'dateadd("n", -30,dateadd("h", -5, Now()))'dateadd("h", -4, Now())'dateadd("n", -30,dateadd("h", -3, Now()))
			if len(Website)>7 then
				ObjRs("Website") = Website
			end if
			ObjRs.Update
			Flag="Yes"
			'Response.Write Flag
			'Response.end
		
			if err.number <> 0 then
				Response.Redirect "Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
				Response.End 
			else
				
			''Mailing process					
				''This is to send b4 activation '/Phonetrade
				'Query ="http://www.phonetrade.cc/signup_email.asp?mem=" & member_company '& "&usr=" & strUser & "&pd=" & strpassword
				'Set objHttp = Server.CreateObject("Msxml2.ServerXMLHTTP")
				'objHttp.open "GET", Query, False
				'objHttp.send
				'strHTML = objHttp.responseText

				'Set MyCDONTSMail = CreateObject("CDONTS.NewMail")
				'MyCDONTSMail.From= "sales@phonetrade.cc"
				'MyCDONTSMail.To= strToMail
				'MyCDONTSMail.CC= "sales@phonetrade.cc"
				'MyCDONTSMail.Subject="Thanks for your Registration - Phonetrade.cc"'


				'MyCDONTSMail.BodyFormat=0
				'MyCDONTSMail.MailFormat=0
				'MyCDONTSMail.Body= strHTML
				'MyCDONTSMail.Send
				'set MyCDONTSMail=nothing

				Response.Redirect("Activate.asp")
			end if

			ObjRs.Close
			Set ObjRs = nothing

		end if
end if	
case "Update2"
Response.Write("DONE")
'Response.end
	company_contact1_name = replace(Request.Form("txtName"),"'","`")
	member_company = replace(Request.Form("txtmember_company"),"'","`")
	CompanyType = Request.Form("chkType")
	mailing_address = replace(Request.Form("txtmailing_address"),"'","`")
	country_id = Request.Form("cboCountry")

	company_Phone = replace(Request.Form("txtPhCou"),"'","`") & "*" & replace(Request.Form("txtPhArea"),"'","`") & "*" & replace(Request.Form("txtPhone"),"'","`")
	company_fax = replace(Request.Form("txtFaxCou"),"'","`") & "*" & replace(Request.Form("txtFaxArea"),"'","`") & "*" & replace(Request.Form("txtcompany_fax"),"'","`")
	company_contact1_mobile = replace(Request.Form("txtMobCou"),"'","`") & "*" & replace(Request.Form("txtMobArea"),"'","`") & "*" & replace(Request.Form("txtcompany_contact1_mobile"),"'","`")
	company_contact1_mobile1 = replace(Request.Form("txtMobCou1"),"'","`") & "*" & replace(Request.Form("txtMobArea1"),"'","`") & "*" & replace(Request.Form("txtcompany_contact1_mobile1"),"'","`")

	company_Phone = replace(replace(replace(company_Phone,"PhonNo","P"),"AreaCode","A"),"Country","C")
	company_fax = replace(replace(replace(company_fax,"company_fax","F"),"AreaCode","A"),"Country","C")
	company_contact1_mobile = replace(replace(replace(company_contact1_mobile,"company_contact1_mobile","MN"),"MobileCode","M"),"Country","C")
	company_contact1_mobile1 = replace(replace(replace(company_contact1_mobile1,"company_contact1_mobile","MN"),"MobileCode","M"),"Country","C")
	company_contact2_name =  replace(Request.Form("txtSecondName"),"'","`")	
	'company_Phone = replace(Request.Form("txtPhone"),"'","`")
	'company_fax = replace(Request.Form("txtcompany_fax"),"'","`")
	'company_contact1_mobile = replace(Request.Form("txtcompany_contact1_mobile"),"'","`")
	
	company_email = Request.Form("txtEmail")
	company_contact1_email= Request.Form("txtPersEmail1")
	company_contact2_email= Request.Form("txtPersEmail2")
	Website = replace(Request.Form("txtWeb"),"'","`")
	Category = Request.Form("chkCategory")
	MemberCode = Request.Form("cboMembName")
	Activate  = Request.Form("cboActivate") 
	MemberLevel	= Request.Form("cboSelect") & ""

	set ObjRs = server.CreateObject("adodb.recordset")
	ObjRs.Open "select * from Members where MemberCode=" & MemberCode,conn,3,3
	ObjRs("company_contact1_name") = company_contact1_name
	ObjRs("member_company") = member_company
	ObjRs("mailing_address") = mailing_address
	ObjRs("country_id") = country_id
	ObjRs("company_Phone") = company_Phone
	ObjRs("company_fax") = company_fax
	ObjRs("company_contact1_mobile") = company_contact1_mobile
	ObjRs("company_contact2_mobile") = company_contact2_mobile
	ObjRs("company_contact2_name") = company_contact2_name
	ObjRs("company_contact1_email") = company_contact1_email
	ObjRs("company_contact2_email") = company_contact2_email
	ObjRs("company_email") = company_email
	ObjRs("CategoryCode") = Category
	'ObjRs("[timestamp]") = Now()
	ObjRs("Activateflag") = Activate
	ObjRs("MemberLevel") = MemberLevel

	ObjRs("Company_Website") = Website

	if Request.Form("chkUsrpassword") & "" ="1" then
		member_id = replace(Request.Form("txtUserName"),"'","`")
		password = replace(Request.Form("txtpassword"),"'","`")
		ObjRs("member_id") = member_id		
		ObjRs("password") = password
	end if
	ObjRs.Update

	if err.number <> 0 then
		Response.Redirect "Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
		Response.End 
	else 
		Flag="YesUpdated"
		'response.Redirect("EditMember.asp?action=Updated&Id=" & MemberCode)
	end if

end select

		
%>

<HTML>
<HEAD>
<META NAME="GENERATOR" Content="Microsoft Visual Studio 6.0">
</HEAD>
<body onLoad="change();">
<form name=frm method=post>
<input type=hidden name="hdCode" value="<%=MemberCode%>">
<input type=Hidden name=txtName value="<%=company_contact1_name%>">
<input type=Hidden name=txtmember_company value="<%=member_company%>">
<input type=Hidden name=txtmailing_address value="<%=mailing_address%>">
<input type=Hidden name=cboCountry value="<%=country_id%>">
<input type=Hidden name=txtPhone value="<%=company_Phone%>">
<input type=Hidden name=txtcompany_fax value="<%=company_fax%>">
<input type=Hidden name=txtcompany_contact1_mobile value="<%=company_contact1_mobile%>">
<input type=Hidden name=txtEmail value="<%=company_email%>">
<input type=Hidden name=txtWeb value="<%=Website%>">
<input type=Hidden name=txtUserName value="<%=member_id%>">
<input type=Hidden name=txtpassword value="<%=password%>">
<input type=Hidden name=chkCategory value="<%=Category%>">
<input type=Hidden name=txtcompany_contact1_mobile1 value="<%=company_contact1_mobile1%>">
<input type=Hidden name=txtSecondName value="<%=company_contact2_name%>">
<input type=Hidden name=txtPersEmail1 value="<%=company_contact1_email%>">
<input type=Hidden name=txtPersEmail2 value="<%=company_contact2_email%>">
<input type=Hidden name=cboSelect value="<%=MemberLevel%>">
	
<input type=Hidden name=hdMsg value="">
	<script language=Javascript>
		function change()
		{
		//alert("<%=Flag%>");
			if ("<%=Flag%>"=="No")
			{
			document.frm.hdMsg.value = "Sorry user already Exists, Please try with another username!";
			document.frm.action="NewMember.asp"
			document.frm.submit();
			}
			if ("<%=Flag%>"=="YesUpdated")
			{
			document.frm.hdMsg.value = "Member information:\'<%=member_company%>' has been updated.";
			document.frm.action="Members.asp"
			document.frm.submit();
			}
		
		}
		
	</script>
</form>
</body>

</HTML>
