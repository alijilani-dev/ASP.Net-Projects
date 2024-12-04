<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<%
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if

	Dim strAct
	Dim rsMain, sql, strNetworkType, strCode
	strAct = Request.Form("hdAction") & Trim(Request.Form("btnOk"))
	'Response.Write Request.Form("hdAction") & Trim(Request.Form("btnOk")) & "A"
	'Response.End 
	select case strAct
	case "AddOk"
		strCode = conn.Execute("select Max(NetworkTypeCode) from mNetwork")(0)
		strCode = strCode & ""
		if len(strCode)=0 then 
			strCode=1 
		else
			strCode = cdbl(strCode) +1
		end if
		strNetworkType = Replace(Request.Form("txtNetwork"),"'","`")

		set rsMain=server.CreateObject("ADODB.Recordset")
		rsMain.Open "select * from mNetwork",conn,3,3
		rsMain.AddNew 
		rsMain("NetworkTypeCode")=strCode
		rsMain("NetworkType")=strNetworkType
		rsMain.Update 
		'Response.Write err.Description & err.number 
		'Response.End 
		if err.number<>0 then
			Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			'Response.Write "Done"
			'Response.End 
			Response.Redirect "Network.asp?mode=1"
			
		end if 	
	case "EditOk"
		strCode = Request.Form("hdCode")
		strNetworkType= replace(Request.Form("txtNetwork"),"'","`")

		sql = "Update mNetwork set NetworkType='" & strNetworkType  & "' where NetworkTypeCode=" & strCode 
		'Response.Write sql
		'Response.End 
		conn.execute sql
		if err.number<>0 then
			Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "Network.asp?mode=2"
		end if 	
	case "Del"
		strCode = Request.Form("hdCode")
		set rsTemp = server.CreateObject("Adodb.Recordset")
		rsTemp.Open "Select NetworkTypeCode from mMobileModel where NetworkTypeCode=" & strCode ,conn,3,3
		if not rsTemp.EOF then
			Response.Redirect "Network.asp?mode=4"
			Response.End 
		end if


		sql = "Delete from mNetwork where NetworkTypeCode=" & strCode 
		conn.execute sql
		if err.number<>0 then
			Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "Network.asp?mode=3"
		end if 	
				
	End select
%>