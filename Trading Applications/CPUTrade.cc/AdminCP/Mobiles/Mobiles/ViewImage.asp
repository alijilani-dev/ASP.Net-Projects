<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<%
	dim strCode, rsMain, Sql, strInfo
	set rsMain = Server.CreateObject("Adodb.Recordset")
	strCode =  Request.QueryString("m")
	Sql="select ImgFile1, ImgFile2, ImgFile3, ImgFile4, ImgFile5 from mMobileModel where ModelNo='" & strCode & "'"
	rsMain.Open Sql,conn,3,2
	strInfo = " var imgArr=new Array() " & vbCrLf
	
	dim imgPath
	imgPath = "/Images/Models/"
	
	if not rsMain.EOF then 
		valdb = rsMain("ImgFile1")&""
		if len(valdb)>0 then strInfo = strInfo & " imgArr[0] = '" & valdb & "' " & vbCrLf
		valdb = rsMain("ImgFile2")&""
		if len(valdb)>0 then strInfo = strInfo & " imgArr[1] = '" & valdb & "' " & vbCrLf
		valdb = rsMain("ImgFile3")&""
		if len(valdb)>0 then strInfo = strInfo & " imgArr[2] = '" & valdb & "' " & vbCrLf
		valdb = rsMain("ImgFile4")&""
		if len(valdb)>0 then strInfo = strInfo & " imgArr[3] = '" & valdb & "' " & vbCrLf
		valdb = rsMain("ImgFile5")&""
		if len(valdb)>0 then strInfo = strInfo & " imgArr[4] = '" & valdb & "' " & vbCrLf
	end if

 %>
				  
<HTML>
<HEAD>
<META NAME="GENERATOR" Content="Microsoft Visual Studio 6.0">
<TITLE></TITLE>
<script type="text/javascript">
<%=strInfo%>

var allimages=new Array()
for (i=0;i<imgArr.length;i++){
allimages[i]=new Image()
allimages[i].src='<%=imgPath%>'+imgArr[i];
}
function a2(p)
{
if (document.all && id2.filters)
{
	id2.filters.revealTrans.Transition=Math.floor(Math.random()*23)
	id2.filters.revealTrans.stop()
	id2.filters.revealTrans.apply()
	document.images.id2.src='<%=imgPath%>'+imgArr[p]
	id2.filters.revealTrans.play()
}
}
</script>
</HEAD>
<BODY>
<script type="text/javascript">
document.write('<img src="<%=imgPath%>'+imgArr[0]+'" name="id2" style="filter:revealTrans(duration=2,transition=23)" border=0><br>')
for (i=0;i<imgArr.length;i++){
document.write('<a href="#"  onClick="a2('+i+');return false;">'+i+'</a>&nbsp;');}
</script>
</BODY>
</HTML>
