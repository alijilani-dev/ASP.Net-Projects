<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<!-- #Include File = "../Global/clsUpload.asp" -->
<!-- #Include File = "../Global/clsImage.asp" -->

<% on error resume next
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if
	
	Dim Upload, Folder
	Dim imgFile1, imgFile2, imgFile3, imgFile4, imgFile5 
	Dim Flag
	Dim ModelNo, ManufCode

	Folder = "/Images/Models/"
	Folder = Server.MapPath(Folder) & "\"
	
	Set Upload = New clsUpload
	ModelNo = Upload("hdCbo").value

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
		If Image.Width > 400 Then
		    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 275 x 275 or less. (" & imgFile1 & ")"
		ElseIf Image.Height > 400 Then
		    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 275 x 275 or less. (" & imgFile1 & ")"
		Else	
			Upload("imgFile1").SaveAs Folder & "m_" & imgFile1
		end if
	Case Else
	    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=File type not supported." 
	End Select
	Set Image = Nothing
end if


''Second Image
	imgFile2 = Upload("imgFile2").FileName

if len(imgFile2 & "")>0 and Right(imgFile2,4)<>".bin" then		
	Set Image = New clsImage
	Image.DataStream = Upload.Fields("imgFile2").BinaryData
	Select Case Image.ImageType
	Case "GIF", "JPG", "BMP"    
		If Image.Width > 140 Then
		    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 70 x 70 or less. (" & imgFile2 & ")"
		ElseIf Image.Height > 140 Then
		    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 70 x 70 or less. (" & imgFile2 & ")"
		Else	
			Upload("imgFile2").SaveAs Folder & "Thumb\m_" & imgFile2
		end if
	Case Else
	    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=File type not supported." 
	End Select
	Set Image = Nothing
end if

''Third Image
	imgFile3 = Upload("imgFile3").FileName

if len(imgFile3 & "")>0 and Right(imgFile3,4)<>".bin" then		
	Set Image = New clsImage
	Image.DataStream = Upload.Fields("imgFile3").BinaryData
	Select Case Image.ImageType
	Case "GIF", "JPG", "BMP"    
		If Image.Width > 400 Then
		    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 275 x 275 or less. (" & imgFile3 & ")"
		ElseIf Image.Height > 400 Then
		    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 275 x 275 or less. (" & imgFile3 & ")"
		Else	
			Upload("imgFile3").SaveAs Folder & "m_" & imgFile3
		end if
	Case Else
	    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=File type not supported." 
	End Select
	Set Image = Nothing
end if

''4th Image
	imgFile4 = Upload("imgFile4").FileName

if len(imgFile4 & "")>0 and Right(imgFile4,4)<>".bin" then		
	Set Image = New clsImage
	Image.DataStream = Upload.Fields("imgFile4").BinaryData
	Select Case Image.ImageType
	Case "GIF", "JPG", "BMP"    
		If Image.Width > 400 Then
		    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 275 x 275 or less. (" & imgFile4 & ")"
		ElseIf Image.Height > 400 Then
		    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 275 x 275 or less. (" & imgFile4 & ")"
		Else	
			Upload("imgFile4").SaveAs Folder & "m_" & imgFile4
		end if
	Case Else
	    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=File type not supported." 
	End Select
	Set Image = Nothing
end if

''5th Image
	imgFile5 = Upload("imgFile5").FileName

if len(imgFile5 & "")>0 and Right(imgFile5,4)<>".bin" then		
	Set Image = New clsImage
	Image.DataStream = Upload.Fields("imgFile5").BinaryData
	Select Case Image.ImageType
	Case "GIF", "JPG", "BMP"    
		If Image.Width > 400 Then
		    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 275 x 275 or less. (" & imgFile5 & ")"
		ElseIf Image.Height > 400 Then
		    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 275 x 275 or less. (" & imgFile5 & ")"
		Else	
			Upload("imgFile5").SaveAs Folder & "m_" & imgFile5
		end if
	Case Else
	    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=File type not supported." 
	End Select
	Set Image = Nothing
end if
	dim ObjRs1, sql
	set ObjRs1 = server.CreateObject("Adodb.Recordset")
	
	if instr(ModelNo,"*")>0 then ModelNo=left(ModelNo,InStr(ModelNo,"*")-1)

	sql = "select * from mMobileModel where ModelNo='" & ModelNo & "'"

	ObjRs1.Open sql,conn,3,2
	
	if len(imgFile1 & "")>0 and Right(imgFile1,4)<>".bin" then ObjRs1("ImgFile1") = "m_" & imgFile1
	if len(imgFile2 & "")>0 and Right(imgFile2,4)<>".bin" then ObjRs1("ImgFile2") = "Thumb/m_" & imgFile2
	if len(imgFile3 & "")>0 and Right(imgFile3,4)<>".bin" then ObjRs1("ImgFile3") = "m_" & imgFile3
	if len(imgFile4 & "")>0 and Right(imgFile4,4)<>".bin" then ObjRs1("ImgFile4") = "m_" & imgFile4
	if len(imgFile5 & "")>0 and Right(imgFile5,4)<>".bin" then ObjRs1("ImgFile5") = "m_" & imgFile5
	ObjRs1.Update 
 	if err.number<>0 then
		Response.Redirect "..\Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
		Response.End 
	else
		Finished="yes"
		Response.Redirect "ImageUpload.asp?mode=1"
	end if 	
%> 
