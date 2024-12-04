<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<%
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if

	Dim strAct
	Dim rsMain, sql, strName, strCode
	strAct = Request.Form("hdAction")
	select case strAct
	case "Edit"
		strCode = Request.Form("hdCode")
		strName=replace(Request.Form("txtManufacturer"),"'","`")

		sql = "Update mManufacturer set ManufName='" & strName  & "' where ManufCode=" & strCode 
		conn.execute sql
		if err.number<>0 then
			Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "Manufacturer.asp?mode=2"
		end if 	
	case "Del"
		strCode = Request.Form("hdCode")
		set rsTemp = server.CreateObject("Adodb.Recordset")
		rsTemp.Open "Select ManufCode from mMobileModel where ManufCode=" & strCode ,conn,2,1
		if not rsTemp.EOF then
			Response.Redirect "Manufacturer.asp?mode=4"
			Response.End 
		end if
		sql = "Delete from mManufacturer where ManufCode=" & strCode 
		conn.execute sql
		if err.number<>0 then
			Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "Manufacturer.asp?mode=3"
		end if 	
				
	End select
%>