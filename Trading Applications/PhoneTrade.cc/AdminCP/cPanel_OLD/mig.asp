<%
dim cn, rs
set cn = server.CreateObject("Adodb.Connection")
'cn.open "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=A123;Data Source=BASHEER"
cn.open "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=TmpPT;Data Source=BASHEER"

set rs = server.CreateObject("Adodb.Recordset")
'rs.open "select member_id, member_company from MEMBERS where member_id not like 'memb_%' order by member_id"
rs.open "select UsrName, CompanyType, CompanyName from Members where UsrName is not null order by UsrName",cn,3,3
dim arr, i, strsql
do while not rs.eof
strsql=""

	arr = split(rs("CompanyType"),", ")
	for i = 0 to ubound(arr)
		select case cint(arr(i))
		case 1
			strsql= strsql & "manufacturer_type='1'"
		case 2
			strsql= strsql & "exp_imp_type='1'"
		case 3
			strsql= strsql & "dealer_reseller_type='1'"
		case 4
			strsql= strsql & "retailer_type='1'"
		case 5
			strsql= strsql & "service_prov_type='1'"
		case 6											
			strsql= strsql & "freight_type='1'"
		end select
		strsql = strsql & ","
	next 
'	Response.Write(strsql & rs("UsrName"))'
'	Response.End()
	
	if len(strsql)>0 then strsql="Update MEMBERS  " & mid(strsql,1,len(strsql)-1) & " where member_id='" & rs("UsrName") & "'"
	Response.Write(strsql & "<br>")
rs.movenext
loop

%>