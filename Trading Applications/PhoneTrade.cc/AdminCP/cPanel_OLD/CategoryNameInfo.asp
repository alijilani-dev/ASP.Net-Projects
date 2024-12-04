<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
if len(Session("sLogmeinadmin"))=0 then
	Response.Redirect "Login.asp"	
end if

	Dim strAct
	Dim rsMain, sql, strCategoryName, strCode
	strAct = Request.Form("hdAction") & Trim(Request.Form("btnOk"))
	'Response.Write Request.Form("hdAction") & Trim(Request.Form("btnOk")) & "A"
	'Response.End 
	select case strAct
	case "AddAdd"
		strCode = conn.Execute("select Max(CategoryCode) from mProdCategory")(0)
		strCode = strCode & ""
		if len(strCode)=0 then 
			strCode=1 
		else
			strCode = cdbl(strCode) +1
		end if
		strCategoryName = Replace(Request.Form("txtProdCategory"),"'","`")

		set rsMain=server.CreateObject("ADODB.Recordset")
		rsMain.Open "select * from mProdCategory",conn,3,3
		rsMain.AddNew 
		rsMain("CategoryCode")=strCode
		rsMain("CategoryName")=strCategoryName
		rsMain.Update 
		'Response.Write err.Description & err.number 
		'Response.End 
		if err.number<>0 then
			Response.Redirect "Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			'Response.Write "Done"
			'Response.End 
			Response.Redirect "Masters.asp?mode=1"
			
		end if 	
	case "EditUpdate"
		strCode = Request.Form("hdCode")
		strCategoryName= replace(Request.Form("txtProdCategory"),"'","`")

		sql = "Update mProdCategory set CategoryName='" & strCategoryName  & "' where CategoryCode=" & strCode 
		'Response.Write sql
		'Response.End 
		conn.execute sql
		if err.number<>0 then
			Response.Redirect "Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "Masters.asp?mode=2"
		end if 	
	case "Del"
		strCode = Request.Form("hdCode")
		set rsTemp = server.CreateObject("Adodb.Recordset")
		rsTemp.Open "Select CategoryCode from Members where CategoryCode like '%" & strCode & "%'" ,conn,3,3
		if not rsTemp.EOF then
			Response.Redirect "Masters.asp?mode=4"
			Response.End 
		end if


		sql = "Delete from mProdCategory where CategoryCode=" & strCode 
		conn.execute sql
		if err.number<>0 then
			Response.Redirect "Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "Masters.asp?mode=3"
		end if 	
				
	End select
%>