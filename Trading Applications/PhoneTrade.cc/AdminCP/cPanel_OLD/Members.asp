<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
Dim strCode, strAction, hdMsg, hdSortTo

hdMsg = Request.Form("hdMsg")
if len(hdMsg & "")=0 then hdMsg = Request.QueryString("hdMsg")
strCode=Request.Form("hdCode")
strAction=Request.Form("hdAction")
hdSortTo=Request.Form("hdSortTo") & ""
'if len(hdSortTo & "")=0 then hdSortTo="11"
Dim rsMain, sql, i

select case hdSortTo
case "11"
	sql="select * from Members order by member_company asc"
case "12"
	sql="select * from Members order by member_company Desc"
case "21"
	sql="select * from Members order by timestamp"
case "22"
	sql="select * from Members order by timestamp desc"
case "31"
	sql="select * from Members order by Activateflag"
case "32"
	sql="select * from Members order by Activateflag desc"
case else
	sql="select * from Members order by timestamp desc"
end select
	set rsMain=Server.CreateObject("Adodb.RecordSet")
	rsMain.Open sql,conn,3,2
%>

<html>
<head>
<title>Control Panel -- [Members Information]</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="../Styles/CssStyles.CSS" rel="stylesheet" type="text/css">
<script language="JavaScript1.2" type="text/JavaScript1.2" src="../Main/Main.js"></script>
</head>
<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<!--#Include file="Top1.asp"-->
<table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" class="contact">
  <tr>
    <td>
    <form name="frMembersInfo" method="post" action="">
        <input type=hidden name=hdCode value="">
        <input type=hidden name=hdAction value="">
        <input type=hidden name=hdSortTo value="">
        <script language=javascript>

	function MoveToTools(p,q)

	{

		if (q==1) 

		{ 
		     document.frMembersInfo.action="EditMember.asp?Id="+p;
		     document.frMembersInfo.submit()
		}
		if (q==2)
		{	
			if (confirm("Are you sure to Delete this Member Information")==true)
			{
			     document.frMembersInfo.action="EditMember.asp?Id="+p;
				document.frMembersInfo.submit()
			}		 			
		}

		if (q==3) 

		{ 
		     document.frMembersInfo.action="PrintPrv.asp?Id="+p;
		     document.frMembersInfo.submit()
		}
		if (q==4) 

		{ 
		     document.frMembersInfo.action="ImageUpload.asp?Id="+p;
		     document.frMembersInfo.submit()
		}
		if (q==5) 

		{ 
		     document.frMembersInfo.action="Activate.asp?Id="+p;
		     document.frMembersInfo.submit()
		}


	}
function SortTo(p)
{
	document.frMembersInfo.hdSortTo.value=p;
	document.frMembersInfo.action="Members.asp";
	document.frMembersInfo.submit()
}	
</script>
        <br>
        <br>
        <table width="90%" border="0" align="center" cellpadding="0" cellspacing="1">
  <tr>
            <td><table width="80%" border="0" align="center" cellpadding="3" cellspacing="1" bgcolor="#999999">
                <tr bgcolor="#FFFFFF"> 
                  <td width="17%"><strong><a href="NewMember.asp">Add New Member</a> 
                    </strong></td>
                  <td width="20%"><strong><a href="EditMember.asp">Edit / Delete 
                    Member</a></strong></td>
                  <td width="13%"><a href="PrintPrv.asp"><strong>Print Member</strong></a></td>
                  <td width="50%">&nbsp;</td>
                </tr>
              </table></td>
  </tr>
</table>

        <br>
        <table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td align="center"><font color=red>
			<script language="JavaScript">
			document.write("<%=hdMsg%>");
			</script></font></td>
          </tr>
        </table>
        <br>
        <table width="98%" border="0" align="center" cellpadding="3" cellspacing="1" class="Border">
          <tr class="HeadingWithBackGround"> 
            <td width="3%"><strong>SrNo</strong></td>
            <td width="14%" height="20"><strong><a href="javascript:SortTo(11);"><img src="../images/Down.gif" width="13" height="11" border="0"></a>Company 
              Name<a href="javascript:SortTo(12);"><img src="../images/Up.gif" width="13" height="11" border="0"></a></strong></td>
            <td width="13%"><strong>mailing_address</strong></td>
            <td width="10%"><strong>Phone No.</strong></td>
            <td width="9%"><strong>Contact</strong></td>
            <td width="9%"><strong>Mobile No.</strong></td>
            <td width="13%"><a href="javascript:SortTo(21);"><img src="../images/Down.gif" width="13" height="11" border="0"></a>Member 
              since<a href="javascript:SortTo(22);"><img src="../images/Up.gif" width="13" height="11" border="0"></a></td>
            <td width="9%"><a href="javascript:SortTo(31);"><img src="../images/Down.gif" width="13" height="11" border="0"></a>Status
			<a href="javascript:SortTo(32);"><img src="../images/Up.gif" width="13" height="11" border="0"></a></td>
            <td width="20%"><strong>Tools</strong></td>
          </tr>
          <%Dim ColVal
	do while not rsMain.EOF
		i=i+1
	if rsMain("Activateflag") & ""="2" then 
		ColVal="RowContent"
	else
		if i mod 2 =0 then ColVal="OddRowContent"  else ColVal="EvenRowContent"
	end if
		
%>
          <tr class="<%=ColVal%>"> 
            <td> <%= i%></td>
            <td><b> <%= rsMain("member_company")%></b></td>
            <td><b><%= replace(rsMain("mailing_address"),vbcrlf,"<br>")%></b></td>
            <td><b> 
              <%company_phone=rsMain("company_phone")&""
if company_phone<>"C*A*P" then
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
              </b></td>
            <td><b><%= rsMain("company_contact1_name")%></b></td>
            <td><b> 
              <%company_contact1_mobile=rsMain("company_contact1_mobile")
if company_contact1_mobile<>"C*M*MN" then
	pos = instr(company_contact1_mobile, "*")
	PhCountry = mid(company_contact1_mobile,1,pos-1)
	company_contact1_mobile = mid(company_contact1_mobile,pos+1)
	pos = instr(company_contact1_mobile, "*")
	PhArea = mid(company_contact1_mobile,1,pos-1)
	company_contact1_mobile = mid(company_contact1_mobile,pos+1)
	if PhArea="A" then 
		Response.Write "+" & PhCountry & " " & company_contact1_mobile 
	else
		Response.Write "+" & PhCountry & " (" & PhArea & ") " & company_contact1_mobile 
	end if
else 
Response.Write "--"
end if
%>
              </b></td>
            <td> <b><% if rsMain("timestamp") & ""<>"" then Response.Write formatdatetime(rsMain("timestamp"),vblongdate)%></b> 
            </td>
            <td><b><font color="red"><%if rsMain("Activateflag")&""="1" then Response.Write "Active Member" else Response.Write "Deactivated Members"%></font></b></td>
            <td><a href='javascript:MoveToTools(<%=rsMain("MemberCode")%>,1);' class="link3"> 
              <img src="../images/EditRec.gif" width="55" height="15" border="0"></a>&nbsp; 
              <a href='javascript:MoveToTools(<%= rsMain("MemberCode") %>,2);' class="link3"> 
              <img src="../Images/DeleteRec.gif" border="0"></a> <a href='javascript:MoveToTools(<%=rsMain("MemberCode")%>,3);' class="link3"> 
              <img src="../images/print.gif" width="55" height="15" border="0"></a> 
              <a href='javascript:MoveToTools(<%=rsMain("MemberCode")%>,4);' class="link3"> 
              <img src="../images/Upload.gif" width="55" height="15" border="0"></a> 
              <a href='javascript:MoveToTools(<%=rsMain("MemberCode")%>,5);' class="link3"> 
              <img src="../images/promote.gif" width="55" height="15" border="0"></a> 
            </td>
          </tr>
          <%rsMain.movenext
	loop
%>
        </table>
        <br>
      </form>
    </td>
  </tr>
</table>
</body>
</html>
