<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<!-- #Include File = "../Global/clsUpload.asp" -->
<!-- #Include File = "../Global/clsImage.asp" -->

<% on error resume next
	
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if
	Dim Upload, Folder, imgFile
	Dim Flag, strManufName
	Dim ManufCode, strManufCode
	Dim ObjRs
	set ObjRs = server.CreateObject("adodb.recordset")
	Set Upload = New clsUpload
	
	ManufCode = Upload("hdCode").value
	strManufName=Replace(Upload("txtManufacturer").value,"'","`")
	
	'Folder = "http://" &  Request.ServerVariables("Server_Name") & "/newuae/Mobiles/Images/Models/"
	Folder = "/Mobiles/Images/Models/"
	Folder = Server.MapPath(Folder) & "\"
	imgFile = Upload("imgFile").FileName
	'Response.Write Folder & imgFile
	'Response.End 
if len(imgFile & "")>0 and Right(imgFile,4)<>".bin" then		
	Set Image = New clsImage
	Image.DataStream = Upload.Fields("imgFile").BinaryData
	Select Case Image.ImageType
	Case "GIF", "JPG", "BMP"    
		If Image.Width > 150 Then
		    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 150x120 or less."
		ElseIf Image.Height > 120 Then
		    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=Image is too wide. It must be 150x120 or less."
		Else	
			Upload("imgFile").SaveAs Folder & "m_" & imgFile
		end if
	Case Else
	    Response.Redirect "..\Errorpg.asp?errNo=10000000&errDesc=File type not supported." 
	End Select
	Set Image = Nothing
end if

	dim ObjRs1
	set ObjRs1 = server.CreateObject("Adodb.Recordset")
	conn.BeginTrans
	ObjRs1.Open "select * from mManufacturer where ManufCode=" & ManufCode,conn,3,3
	'ObjRs1("ManufCode") = ManufCode
	if len(imgFile & "")>0 and Right(imgFile,4)<>".bin" then ObjRs1("Logo") = "m_" & imgFile
	ObjRs1.Update 
	conn.CommitTrans
 	if err.number<>0 then
		Response.Redirect "..\Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
		Response.End 
	else
		Finished="yes"
		Response.Redirect "Manufacturer.asp?mode=5"
	end if 	
%> 
