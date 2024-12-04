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
		Query ="http://www.phonetrade.cc/signup_email.htm"
		subj = "Thanks for your Registration - Phonetrade.cc"
		SQL = "Select * from Members where MemberCode=" & memberId
	case "2"
		Query ="http://www.phonetrade.cc/Print.htm"
		subj = "Phonetrade.cc: Membership Confirmation!"
		SQL = "select Members.*, Country.Country_name from Members inner join Country on Members.Country_id = Country.Country_id where MemberCode=" & memberId	
	end select
					Set objHttp = Server.CreateObject("Msxml2.ServerXMLHTTP")
					objHttp.open "GET", Query, False
					objHttp.send
					strHTML = objHttp.responseText


	set rsTemp = server.createobject("Adodb.recordset")
	rsTemp.open SQL,conn,3,3
	
	if not rsTemp.eof then

	Select case ProcId
	case "1"
		strHTML = replace(strHTML,"*Member*",rsTemp("member_company")&"")
	case "2"
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
                    strCompanyType =strCompanyType &  "<img src=http://www.Phonetrade.cc/Images/tick.gif border=0>"
                    strCompanyType = strCompanyType & "<font color=#990000><b>Manufacturer</b></font>&nbsp;&nbsp;&nbsp;"
                End If

                If rsTemp("exp_imp_type") & "" = "1" Then
                    strCompanyType =strCompanyType &  "<img src=http://www.Phonetrade.cc/Images/tick.gif border=0>"
                    strCompanyType =strCompanyType &  "<font color=#990000><b>Exporter / Importer</b></font>&nbsp;&nbsp;&nbsp;"
                End If

                If rsTemp("dealer_reseller_type") & "" = "1" Then
                    strCompanyType =strCompanyType &  "<img src=http://www.Phonetrade.cc/Images/tick.gif border=0>"
                    strCompanyType =strCompanyType &  "<font color=#990000><b>Dealer Reseller</b></font>&nbsp;&nbsp;&nbsp;"
                End If

                If rsTemp("retailer_type") & "" = "1" Then
                    strCompanyType =strCompanyType &  "<img src=http://www.Phonetrade.cc/Images/tick.gif border=0>"
                    strCompanyType =strCompanyType &  "<font color=#990000><b>Retailer</b></font>&nbsp;&nbsp;&nbsp;"
                End If

                If rsTemp("service_prov_type") & "" = "1" Then
                    strCompanyType =strCompanyType &  "<img src=http://www.Phonetrade.cc/Images/tick.gif border=0>"
                    strCompanyType =strCompanyType &  "<font color=#990000><b>Service Provider</b></font>&nbsp;&nbsp;&nbsp;"
                End If

                If rsTemp("freight_type") & "" = "1" Then
                    strCompanyType =strCompanyType &  "<img src=http://www.Phonetrade.cc/Images/tick.gif border=0>"
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
		Set MyCDONTSMail = CreateObject("CDONTS.NewMail")
		MyCDONTSMail.From= "info@phonetrade.cc"
		MyCDONTSMail.To= strToMail
		if len(strCC)>0 then MyCDONTSMail.cc = strCC
		MyCDONTSMail.BCC= "sales@phonetrade.cc"
		MyCDONTSMail.Subject=subj
		
		
		MyCDONTSMail.BodyFormat=0	
		MyCDONTSMail.MailFormat=0
		MyCDONTSMail.Body= strHTML
		MyCDONTSMail.Send
		set MyCDONTSMail=nothing
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
