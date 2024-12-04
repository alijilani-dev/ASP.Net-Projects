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
	

Dim CompanyName, YourName
Dim Address, CountryCode, CompanyType
Dim PhoneNo, FaxNo, MobileNo
Dim EmailId, UsrName, Pwd, MailFlag, MemberLevel
Dim Flag, MemberCode, Category, Colour, Activate

Select case hdProc
case "Sign Up1"

	MemberLevel	= Request.Form("cboSelect") & ""
	YourName = replace(Request.Form("txtName"),"'","`")
	CompanyName = replace(Request.Form("txtCompanyName"),"'","`")

	CompanyType = Request.Form("chkType")
	Address = replace(Request.Form("txtAddress"),"'","`")
	CountryCode = Request.Form("cboCountry")

	PhoneNo = replace(Request.Form("txtPhCou"),"'","`") & "*" & replace(Request.Form("txtPhArea"),"'","`") & "*" & replace(Request.Form("txtPhone"),"'","`")
	FaxNo = replace(Request.Form("txtFaxCou"),"'","`") & "*" & replace(Request.Form("txtFaxArea"),"'","`") & "*" & replace(Request.Form("txtFaxNo"),"'","`")
	MobileNo = replace(Request.Form("txtMobCou"),"'","`") & "*" & replace(Request.Form("txtMobArea"),"'","`") & "*" & replace(Request.Form("txtMobileNo"),"'","`")
	MobileNo1 = replace(Request.Form("txtMobCou1"),"'","`") & "*" & replace(Request.Form("txtMobArea1"),"'","`") & "*" & replace(Request.Form("txtMobileNo1"),"'","`")

	PhoneNo = replace(replace(replace(PhoneNo,"PhonNo","P"),"AreaCode","A"),"Country","C")
	FaxNo = replace(replace(replace(FaxNo,"FaxNo","F"),"AreaCode","A"),"Country","C")
	MobileNo = replace(replace(replace(MobileNo,"MobileNo","MN"),"MobileCode","M"),"Country","C")
	MobileNo1 = replace(replace(replace(MobileNo1,"MobileNo","MN"),"MobileCode","M"),"Country","C")
	SecondContact =  replace(Request.Form("txtSecondName"),"'","`")	
	'PhoneNo = replace(Request.Form("txtPhone"),"'","`")
	'FaxNo = replace(Request.Form("txtFaxNo"),"'","`")
	'MobileNo = replace(Request.Form("txtMobileNo"),"'","`")
	
	EmailId = Request.Form("txtEmail")
	PersonalEmail1= Request.Form("txtPersEmail1")
	PersonalEmail2= Request.Form("txtPersEmail2")
	Website = replace(Request.Form("txtWeb"),"'","`")
	Category = Request.Form("chkCategory")
	Activate  = Request.Form("cboActivate") 

if MemberLevel & ""="1" then
		MemberCode = conn.Execute("select Max(MemberCode) from Members")(0)
		MemberCode=MemberCode & ""
		if len(MemberCode)=0 then 
			MemberCode=1 
		else
			MemberCode = cdbl(MemberCode) + 1
		end if
		if len(MemberCode)=0 OR IsNull(MemberCode) then MemberCode=1
    
		set ObjRs = server.CreateObject("adodb.recordset")
		ObjRs.Open "select * from Members",conn,3,3
		ObjRs.AddNew 	
		ObjRs("MemberCode") = MemberCode
		ObjRs("YourName") = YourName
		ObjRs("CompanyName") = CompanyName
		ObjRs("CompanyType") = CompanyType
		ObjRs("Address") = Address
		ObjRs("CountryCode") = CountryCode
		ObjRs("PhoneNo") = PhoneNo
		ObjRs("FaxNo") = FaxNo
		ObjRs("MobileNo") = MobileNo
		ObjRs("MobileNo2") = MobileNo1
		ObjRs("SecondContact") = SecondContact
		ObjRs("PersonalEmail1") = PersonalEmail1
		ObjRs("PersonalEmail2") = PersonalEmail2
		ObjRs("EmailId") = EmailId
		ObjRs("CategoryCode") = Category
		ObjRs("Activateflag") = Activate
ObjRs("[timestamp]") =dateadd("h", -4, Now())'dateadd("n", -30,dateadd("h", -5, Now()))'dateadd("h", -4, Now())'dateadd("n", -30,dateadd("h", -3, Now()))
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
				'Query ="http://www.phonetrade.cc/signup_email.asp?mem=" & CompanyName '& "&usr=" & strUser & "&pd=" & strpwd
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
		UsrName = replace(Request.Form("txtUserName"),"'","`")
		Pwd = replace(Request.Form("txtPwd"),"'","`")
		strSql = "select MemberCode from Members where UsrName = '" & UsrName & "'"
		rsMain.Open strSql,conn,3,2
		If Not rsMain.EOF Then 
			Flag = "No"
		else
			Flag = "Ok"
		end if
		rsMain.Close
		Set rsMain = Nothing
		if Flag="Ok" then
			MemberCode = conn.Execute("select Max(MemberCode) from Members")(0)
			MemberCode=MemberCode & ""
			if len(MemberCode)=0 then 
				MemberCode=1 
			else
				MemberCode = cdbl(MemberCode) + 1
			end if
			if len(MemberCode)=0 OR IsNull(MemberCode) then MemberCode=1
    
			set ObjRs = server.CreateObject("adodb.recordset")
			ObjRs.Open "select * from Members",conn,3,3
			ObjRs.AddNew 	
			ObjRs("MemberCode") = MemberCode
			ObjRs("YourName") = YourName
			ObjRs("CompanyName") = CompanyName
			ObjRs("CompanyType") = CompanyType
			ObjRs("Address") = Address
			ObjRs("CountryCode") = CountryCode
			ObjRs("PhoneNo") = PhoneNo
			ObjRs("FaxNo") = FaxNo
			ObjRs("MobileNo") = MobileNo
			ObjRs("MobileNo2") = MobileNo1
			ObjRs("SecondContact") = SecondContact
			ObjRs("PersonalEmail1") = PersonalEmail1
			ObjRs("PersonalEmail2") = PersonalEmail2
			ObjRs("EmailId") = EmailId
			ObjRs("CategoryCode") = Category
			ObjRs("Activateflag") = Activate
			ObjRs("MemberLevel") = MemberLevel
			ObjRs("UsrName") = UsrName		
			ObjRs("Pwd") = Pwd		
ObjRs("[timestamp]") =dateadd("h", -4, Now())'dateadd("n", -30,dateadd("h", -5, Now()))'dateadd("h", -4, Now())'dateadd("n", -30,dateadd("h", -3, Now()))
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
				'Query ="http://www.phonetrade.cc/signup_email.asp?mem=" & CompanyName '& "&usr=" & strUser & "&pd=" & strpwd
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

	YourName = replace(Request.Form("txtName"),"'","`")
	CompanyName = replace(Request.Form("txtCompanyName"),"'","`")
	CompanyType = Request.Form("chkType")
	Address = replace(Request.Form("txtAddress"),"'","`")
	CountryCode = Request.Form("cboCountry")

	PhoneNo = replace(Request.Form("txtPhCou"),"'","`") & "*" & replace(Request.Form("txtPhArea"),"'","`") & "*" & replace(Request.Form("txtPhone"),"'","`")
	FaxNo = replace(Request.Form("txtFaxCou"),"'","`") & "*" & replace(Request.Form("txtFaxArea"),"'","`") & "*" & replace(Request.Form("txtFaxNo"),"'","`")
	MobileNo = replace(Request.Form("txtMobCou"),"'","`") & "*" & replace(Request.Form("txtMobArea"),"'","`") & "*" & replace(Request.Form("txtMobileNo"),"'","`")
	MobileNo1 = replace(Request.Form("txtMobCou1"),"'","`") & "*" & replace(Request.Form("txtMobArea1"),"'","`") & "*" & replace(Request.Form("txtMobileNo1"),"'","`")

	PhoneNo = replace(replace(replace(PhoneNo,"PhonNo","P"),"AreaCode","A"),"Country","C")
	FaxNo = replace(replace(replace(FaxNo,"FaxNo","F"),"AreaCode","A"),"Country","C")
	MobileNo = replace(replace(replace(MobileNo,"MobileNo","MN"),"MobileCode","M"),"Country","C")
	MobileNo1 = replace(replace(replace(MobileNo1,"MobileNo","MN"),"MobileCode","M"),"Country","C")
	SecondContact =  replace(Request.Form("txtSecondName"),"'","`")	
	'PhoneNo = replace(Request.Form("txtPhone"),"'","`")
	'FaxNo = replace(Request.Form("txtFaxNo"),"'","`")
	'MobileNo = replace(Request.Form("txtMobileNo"),"'","`")
	
	EmailId = Request.Form("txtEmail")
	PersonalEmail1= Request.Form("txtPersEmail1")
	PersonalEmail2= Request.Form("txtPersEmail2")
	Website = replace(Request.Form("txtWeb"),"'","`")
	Category = Request.Form("chkCategory")
	MemberCode = Request.Form("cboMembName")
	Activate  = Request.Form("cboActivate") 
	MemberLevel	= Request.Form("cboSelect") & ""

	set ObjRs = server.CreateObject("adodb.recordset")
	ObjRs.Open "select * from Members where MemberCode=" & MemberCode,conn,3,3
	ObjRs("YourName") = YourName
	ObjRs("CompanyName") = CompanyName
	ObjRs("CompanyType") = CompanyType
	ObjRs("Address") = Address
	ObjRs("CountryCode") = CountryCode
	ObjRs("PhoneNo") = PhoneNo
	ObjRs("FaxNo") = FaxNo
	ObjRs("MobileNo") = MobileNo
	ObjRs("MobileNo2") = MobileNo1
	ObjRs("SecondContact") = SecondContact
	ObjRs("PersonalEmail1") = PersonalEmail1
	ObjRs("PersonalEmail2") = PersonalEmail2
	ObjRs("EmailId") = EmailId
	ObjRs("CategoryCode") = Category
	'ObjRs("[timestamp]") = Now()
	ObjRs("Activateflag") = Activate
	ObjRs("MemberLevel") = MemberLevel

	ObjRs("Website") = Website

	if Request.Form("chkUsrPwd") & "" ="1" then
		UsrName = replace(Request.Form("txtUserName"),"'","`")
		Pwd = replace(Request.Form("txtPwd"),"'","`")
		ObjRs("UsrName") = UsrName		
		ObjRs("Pwd") = Pwd
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
<input type=Hidden name=txtName value="<%=YourName%>">
<input type=Hidden name=txtCompanyName value="<%=CompanyName%>">
<input type=Hidden name=txtAddress value="<%=Address%>">
<input type=Hidden name=cboCountry value="<%=CountryCode%>">
<input type=Hidden name=txtPhone value="<%=PhoneNo%>">
<input type=Hidden name=txtFaxNo value="<%=FaxNo%>">
<input type=Hidden name=txtMobileNo value="<%=MobileNo%>">
<input type=Hidden name=txtEmail value="<%=EmailId%>">
<input type=Hidden name=txtWeb value="<%=Website%>">
<input type=Hidden name=txtUserName value="<%=UsrName%>">
<input type=Hidden name=txtPwd value="<%=Pwd%>">
<input type=Hidden name=chkCategory value="<%=Category%>">
<input type=Hidden name=txtMobileNo1 value="<%=MobileNo1%>">
<input type=Hidden name=txtSecondName value="<%=SecondContact%>">
<input type=Hidden name=txtPersEmail1 value="<%=PersonalEmail1%>">
<input type=Hidden name=txtPersEmail2 value="<%=PersonalEmail2%>">
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
			document.frm.hdMsg.value = "Member information:\'<%=CompanyName%>' has been updated.";
			document.frm.action="Members.asp"
			document.frm.submit();
			}
		
		}
		
	</script>
</form>
</body>

</HTML>
