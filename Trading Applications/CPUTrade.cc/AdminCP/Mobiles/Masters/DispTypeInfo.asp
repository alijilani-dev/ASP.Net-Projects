<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<%
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if

	Dim strAct
	Dim rsMain, sql, strDispType, strCode
	strAct = Request.Form("hdAction") & Trim(Request.Form("btnOk"))
	select case strAct
	case "AddOk"
		strCode = conn.Execute("select Max(DispTypeCode) from mDispType")(0)
		strCode = strCode & ""
		if len(strCode)=0 then 
			strCode=1 
		else
			strCode = cdbl(strCode) +1
		end if
		strDispType = replace(Request.Form("txtDisplaytype"),"'","`")

		set rsMain=server.CreateObject("ADODB.Recordset")
		rsMain.Open "select * from mDispType",conn,3,3
		rsMain.AddNew 
		rsMain("DispTypeCode")=strCode
		rsMain("DispType")=strDispType
		rsMain.Update 
		
		if err.number<>0 then
			Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "Display.asp?mode=1"
		end if 	
	case "EditOk"
		strCode = Request.Form("hdCode")
		strDispType=replace(Request.Form("txtDisplaytype"),"'","`")

		sql = "Update mDispType set DispType='" & strDispType  & "' where DispTypeCode=" & strCode 
		'Response.Write sql
		'Response.End 
		conn.execute sql
		if err.number<>0 then
			Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "Display.asp?mode=2"
		end if 	
	case "Del"
		strCode = Request.Form("hdCode")
		set rsTemp = server.CreateObject("Adodb.Recordset")
		rsTemp.Open "Select DispTypeCode from mMobileModel where DispTypeCode=" & strCode ,conn,3,3
		if not rsTemp.EOF then
			Response.Redirect "Display.asp?mode=4"
			Response.End 
		end if


		sql = "Delete from mDispType where DispTypeCode=" & strCode 
		conn.execute sql
		if err.number<>0 then
			Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "Display.asp?mode=3"
		end if 	
				
	End select
%>