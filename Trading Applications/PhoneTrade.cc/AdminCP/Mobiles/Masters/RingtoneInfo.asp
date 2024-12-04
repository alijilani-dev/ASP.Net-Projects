<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<%

if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if
	Dim strAct
	Dim rsMain, sql, strRingtoneType, strCode
	strAct = Request.Form("hdAction") & Trim(Request.Form("btnOk"))
	select case strAct
	case "AddOk"
		strCode = conn.Execute("select Max(RingtoneTypeCode) from mRingtone")(0)
		strCode = strCode & ""
		if len(strCode)=0 then 
			strCode=1 
		else
			strCode = cdbl(strCode) +1
		end if
		strRingtoneType = replace(Request.Form("txtRingtone"),"'","`")

		set rsMain=server.CreateObject("ADODB.Recordset")
		rsMain.Open "select * from mRingtone",conn,3,3
		rsMain.AddNew 
		rsMain("RingtoneTypeCode")=strCode
		rsMain("RingtoneType")=strRingtoneType
		rsMain.Update 
		
		if err.number<>0 then
			Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "Ringtone.asp?mode=1"
		end if 	
	case "EditOk"
		strCode = Request.Form("hdCode")
		strRingtoneType=Replace(Request.Form("txtRingtone"),"'","`")

		sql = "Update mRingtone set RingtoneType='" & strRingtoneType  & "' where RingtoneTypeCode=" & strCode 
		'Response.Write sql
		'Response.End 
		conn.execute sql
		if err.number<>0 then
			Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "Ringtone.asp?mode=2"
		end if 	
	case "Del"
		strCode = Request.Form("hdCode")
		set rsTemp = server.CreateObject("Adodb.Recordset")
		rsTemp.Open "Select RingtoneTypeCode from mMobileModel where RingtoneTypeCode=" & strCode ,conn,3,3
		if not rsTemp.EOF then
			Response.Redirect "Ringtone.asp?mode=4"
			Response.End 
		end if


		sql = "Delete from mRingtone where RingtoneTypeCode=" & strCode 
		conn.execute sql
		if err.number<>0 then
			Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "Ringtone.asp?mode=3"
		end if 	
				
	End select
%>