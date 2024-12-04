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
	Dim Member_id
	
	   
'	Folder = "..\Images\Logo"
	Folder = "\Images\Logo"	
	Folder = Server.MapPath(Folder) & "\"
	
	Set Upload = New clsUpload
	Member_id = Upload("hdMembName").value
	if instr(Member_id,"*")>0 then Member_id=left(Member_id,InStr(Member_id,"*")-1)
	imgFile1 = Upload("imgFile1").FileName
''First Image
if len(imgFile1 & "")>0 and Right(imgFile1,4)<>".bin" then		
	Set Image = New clsImage
	Image.DataStream = Upload.Fields("imgFile1").BinaryData
	Select Case Image.ImageType
	Case "GIF", "JPG", "BMP", "JPEG", "JIF"    
		If Image.Width > 120 Then
		    Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 120 x 60 or less. (" & imgFile1 & " " & Image.Width & ")"
		ElseIf Image.Height > 60 Then
		    Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 120 x 60 or less. (" & imgFile1 & ")"
		Else	
			Upload("imgFile1").SaveAs Folder & "m_" & Member_id & imgFile1
		end if
	Case Else
	    Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=File type not supported." 
	End Select
	Set Image = Nothing
end if


''Second Image
'	Folder = "..\Images\MainImage"
	Folder = "\Images\MainImage"	
	Folder = Server.MapPath(Folder) & "\"
	imgFile2 = Upload("imgFile2").FileName

if len(imgFile2 & "")>0 and Right(imgFile2,4)<>".bin" then		
	Set Image = New clsImage
	Image.DataStream = Upload.Fields("imgFile2").BinaryData
	Select Case Image.ImageType
	Case "GIF", "JPG", "BMP", "JPEG", "JIF"   
		If Image.Width > 525 Then
		    'Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 525 x 260 or less. (" & imgFile2 & ")"
		    Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=(" & Image.Width & ")"
		ElseIf Image.Height > 260 Then
		    Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 525 x 260 or less. (" & imgFile2 & ")"
		Else	
			Upload("imgFile2").SaveAs Folder & "m_" & Member_id & imgFile2
		end if
	Case Else
	    Response.Redirect "Errorpg.asp?errNo=10000000&errDesc=File type not supported." 
	End Select
	Set Image = Nothing
end if

	dim ObjRs1, sql
	set ObjRs1 = server.CreateObject("Adodb.Recordset")
	

	sql = "select * from Members where Member_id='" & Member_id & "'"

	ObjRs1.Open sql,conn,3,2
'Response.Write sql & ObjRs1.recordcount
'Response.End()

	if len(imgFile1 & "")>0 and Right(imgFile1,4)<>".bin" then ObjRs1("Company_Logo_Url") = "m_" & Member_id & imgFile1
	if len(imgFile2 & "")>0 and Right(imgFile2,4)<>".bin" then ObjRs1("Company_Logo_Url_Main") = "m_" & Member_id & imgFile2
	ObjRs1.Update 
 	if err.number<>0 then
		Response.Redirect "Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
		Response.End 
	else
		Finished="yes"
		Response.Redirect "ImageUpload.asp?hdMsg=Images has been successfully updated."
	end if 	
%> 
