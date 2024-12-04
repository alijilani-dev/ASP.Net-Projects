<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<!-- #Include File = "../Main/Loader.asp" -->
<%
	Response.Buffer = True
if len(Session("sLogmeinadmin"))=0 then
	Response.Redirect "Login.asp"	
end if
	Dim Folder, AffCode, LocationDesc
	Dim Width, Height, Image
	Dim imgLogoFileS, imgLogoFileL

	Set load = new Loader
	load.initialize                 
	      
	MemberCode = load.getValue("hdMembName")
	if instr(MemberCode,"*")>0 then MemberCode=left(MemberCode,InStr(MemberCode,"*")-1)
	imgFile1 = LCase(load.getFileName("imgFile1"))
	IF imgFile1 <> "" THEN 
		Folder = "\Images\Logo"
		Folder = Server.MapPath(Folder) & "\" & "m_" & MemberCode & imgFile1
		fileUploaded = load.saveToFile ("imgFile1", Folder)
	END If

	imgFile2 = LCase(load.getFileName("imgFile2"))
	IF imgFile1 <> "" THEN 
	Folder = "\Images\MainImage"
	Folder = Server.MapPath(Folder) & "\"
		Folder = Server.MapPath(Folder) & "\" & "m_" & MemberCode & imgFile2
		fileUploaded = load.saveToFile ("imgFile2", Folder)
	END If
	dim ObjRs1, sql
	set ObjRs1 = server.CreateObject("Adodb.Recordset")
	

	sql = "select * from Members where MemberCode='" & MemberCode & "'"

	ObjRs1.Open sql,conn,3,2

	if len(imgFile1 & "")>0 and Right(imgFile1,4)<>".bin" then ObjRs1("Company_Logo_Url") = "m_" & MemberCode & imgFile1
	if len(imgFile2 & "")>0 and Right(imgFile2,4)<>".bin" then ObjRs1("Company_Logo_Url_Main") = "m_" & MemberCode & imgFile2
	'if len(imgFile1 & "")>0 and Right(imgFile1,4)<>".bin" then ObjRs1("imgLogo") = imgFile1
	'if len(imgFile2 & "")>0 and Right(imgFile2,4)<>".bin" then ObjRs1("imgMain") = imgFile2
	ObjRs1.Update 
 	if err.number<>0 then
		Response.Redirect "Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
		Response.End 
	else
		Finished="yes"
		Response.Redirect "Members.asp?hdMsg=Images has been successfully updated."
	end if 	
Set load = nothing
%> 
