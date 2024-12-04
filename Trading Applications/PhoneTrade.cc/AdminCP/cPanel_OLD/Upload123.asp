<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<!-- #Include File = "../Main/clsUpload.asp" -->
<!-- #Include File = "../Main/clsImage.asp" -->

<% on error resume next

'Response.CacheControl = "no-cache"
'Response.AddHeader "Pragma", "no-cache"
'Response.Expires = -1

if len(Session("sLogmeinadmin"))=0 then
	Response.Redirect "Login.asp"	
end if
	
	Dim Upload, Folder
	Dim imgFile1, imgFile2
	Dim Flag
	Dim MemberCode
	
	   
	'Folder = Server.MapPath("..\Images\Logo") & "\"
	Folder = "..\Images\Logo"
	Folder = Server.MapPath(Folder) & "\"
	'Folder="http://" &  Request.ServerVariables("Server_Name") & "/Portal/Images/Logo/"
	
	Set Upload = New clsUpload
	MemberCode = Upload("hdMembName").value
	if instr(MemberCode,"*")>0 then MemberCode=left(MemberCode,InStr(MemberCode,"*")-1)
	imgFile1 = Upload("imgFile1").FileName
	'if mid(Folder,1,1)="`" then Folder=mid(Folder,2)
	'Response.Write imgFile1'Folder' 
	'Response.End 

''First Image
if len(imgFile1 & "")>0 and Right(imgFile1,4)<>".bin" then		
	Set Image = New clsImage
	Image.DataStream = Upload.Fields("imgFile1").BinaryData
	Select Case Image.ImageType
	Case "GIF", "JPG", "BMP"    
			'Response.Write Image.Width
			'Response.End 

		If Image.Width > 25000 Then
		    Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 120 x 60 or less. (" & imgFile1 & " " & Image.Width & ")"
		ElseIf Image.Height > 60 Then
		    Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 120 x 60 or less. (" & imgFile1 & ")"
		Else	
			Upload("imgFile1").SaveAs Folder & "m_" & MemberCode & imgFile1
			'Upload("imgFile1").SaveAs Folder & imgFile1

		end if
	Case Else
	    Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=File type not supported." 
	End Select
	Set Image = Nothing
end if


''Second Image
	'Folder = Server.MapPath("..\Images\MainImage") & "\"
	Folder = "..\Images\MainImage"
	Folder = Server.MapPath(Folder) & "\"
	'Folder="http://" &  Request.ServerVariables("Server_Name") & "/Portal/Images/MainImage/"
	imgFile2 = Upload("imgFile2").FileName

if len(imgFile2 & "")>0 and Right(imgFile2,4)<>".bin" then		
	Set Image = New clsImage
	Image.DataStream = Upload.Fields("imgFile2").BinaryData
	Select Case Image.ImageType
	Case "GIF", "JPG", "BMP"    
		If Image.Width > 525 Then
		    'Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 525 x 260 or less. (" & imgFile2 & ")"
		    Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=(" & Image.Width & ")"
		ElseIf Image.Height > 260 Then
		    Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 525 x 260 or less. (" & imgFile2 & ")"
		Else	
			Upload("imgFile2").SaveAs Folder & "m_" & MemberCode & imgFile2
			'Upload("imgFile2").SaveAs Folder & imgFile2
		end if
	Case Else
	    Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=File type not supported." 
	End Select
	Set Image = Nothing
end if

	dim ObjRs1, sql
	set ObjRs1 = server.CreateObject("Adodb.Recordset")
	

	sql = "select * from Members where MemberCode='" & MemberCode & "'"

	ObjRs1.Open sql,conn,3,2

	if len(imgFile1 & "")>0 and Right(imgFile1,4)<>".bin" then ObjRs1("imgLogo") = "m_" & MemberCode & imgFile1
	if len(imgFile2 & "")>0 and Right(imgFile2,4)<>".bin" then ObjRs1("imgMain") = "m_" & MemberCode & imgFile2
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
%> 
