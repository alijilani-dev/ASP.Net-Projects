<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<%
Dim rsMain, sql, i, valdb
dim rsTemp

	set rsMain=Server.CreateObject("Adodb.RecordSet")
	set rsTemp=Server.CreateObject("Adodb.RecordSet")

	if len(Session("sLogmein"))=0 then
		Response.Redirect "../Login.asp"	
	end if
	
Dim strNet, strNetInfo
	strNet = "var Network = new Array("
	strNetInfo = "var NetworkInfo = new Array("

	if rsTemp.State then rsTemp.Close
	rsTemp.Open "Select * from mNetwork Order by NetworkType",conn,2,1

	do while not rsTemp.EOF 
		strNet = strNet & "'" & rsTemp("NetworkTypeCode") & "',"
		strNetInfo = strNetInfo & "'" & rsTemp("NetworkType") & "',"
		rsTemp.MoveNext  
	loop
	if  mid(strNet,len(strNet),1)="," then strNet = mid(strNet,1,len(strNet)-1)
	if  mid(strNetInfo,len(strNetInfo),1)="," then strNetInfo = mid(strNetInfo,1,len(strNetInfo)-1)
	strNet = strNet & ")"
	strNetInfo = strNetInfo & ")"

Dim strRing, strRingInfo
	strRing = "var Ringtone = new Array("
	strRingInfo = "var RingtoneInfo = new Array("

	if rsTemp.State then rsTemp.Close
	rsTemp.Open "select * from mRingtone order by RingtoneType",conn,2,1

	do while not rsTemp.EOF 
		strRing = strRing & "'" & rsTemp("RingtoneTypeCode") & "',"
		strRingInfo = strRingInfo & "'" & rsTemp("RingtoneType") & "',"
		rsTemp.MoveNext  
	loop
	if  mid(strRing,len(strRing),1)="," then strRing = mid(strRing,1,len(strRing)-1)
	if  mid(strRingInfo,len(strRingInfo),1)="," then strRingInfo = mid(strRingInfo,1,len(strRingInfo)-1)
	strRing = strRing & ")"
	strRingInfo = strRingInfo & ")"


%>
<HTML>
<Head>
<Title>
Mobile Main
</Title>
<LINK rel="stylesheet" type="text/css" href="../Global/MyStyle.css">
<script language='javascript' src=../Global/valid.js></script>
<script language="JavaScript" type="text/JavaScript">
<!--
<%Response.Write  strNet & vbcrlf%>
<%Response.Write  strNetInfo & vbcrlf%>
<%Response.Write  strRing & vbcrlf%>
<%Response.Write  strRingInfo & vbcrlf%>

function openWindow(theURL,winName,features) { 
  window.open(theURL,winName,features);
}
//-->
</script>
</Head>

<body>
<a href="NewMobile.asp" class="link3"><b>Add New Mobile </b></a>
<% 
dim strMode
strMode=Request.QueryString("mode")
if strMode="1" then
	Response.Write "<p align=center><font color=Red size=2>Mobile name has been successfully Added</font></p>"
elseif strMode="2" then
	Response.Write "<p align=center><font color=Red size=2>Mobile name has been successfully Modified</font></p>"
elseif strMode="3" then
	Response.Write "<p align=center><font color=Red size=2>Mobile name has been successfully Deleted</font></p>"
elseif strMode="4" then
	Response.Write "<p align=center><font color=Red size=2>Sorry, Mobile name can not be deleted! Master reference found</font></p>"
elseif strMode="5" then
	Response.Write "<p align=center><font color=Red size=2>Logo image has been successfully changed</font></p>"

end if
%>
<form name=frmMobileModel method=post>

<input type=hidden name=hdCode value="">
<input type=hidden name=hdAction value="">

<script language=javascript>

	function show(p,q)

	{

		if (q==1) 

		{ 
		     document.frmMobileModel.hdCode.value =p;
		     document.frmMobileModel.action="EditMobile.asp";
		     document.frmMobileModel.submit()
		}

		if (q==2)

		{
			
			if (confirm("Are you sure to Delete this Mobile Name")==true)
			{
				document.frmMobileModel.hdCode.value =p;
				document.frmMobileModel.hdAction.value ="Del";
				document.frmMobileModel.action = "MobileInfo.asp";
				document.frmMobileModel.submit()
			}		 			
		}

		if (q==3)
		{
			openWindow('ViewImage.asp?m='+p,'ImgWind','status=yes,menubar=yes,scrollbars=yes,resizable=yes,width=400,height=400');
		}
	}
</script>
<% 
'MobileModel.NetworkTypeCode, NetworkType,'
'mMobileModel.RingtoneTypeCode, RingtoneType,
'"inner join mRingtone on mMobileModel.RingtoneTypeCode = mRingtone.RingtoneTypeCode " & _
'"inner join mNetwork on mMobileModel.NetworkTypeCode = mNetwork.NetworkTypeCode " & _

	sql="SELECT ModelNo, mMobileModel.ManufCode, ManufName, NetworkTypeCode,  " & _
			" mMobileModel.DispTypeCode, DispType,  " & _
			"RingtoneTypeCode, Announced, Status, ImgFile1 " & _
			"FROM mMobileModel inner join mManufacturer on mMobileModel.ManufCode = mManufacturer.ManufCode " & _
			"inner join mDispType on mMobileModel.DispTypeCode = mDispType.DispTypeCode " & _		
			"order by mMobileModel.ManufCode, ModelNo"

	rsMain.Open sql,conn,3,2
	Response.write "<table width=""100%"" border=1 cellspacing=0 cellpadding=2>"
	Response.write "<tr bgcolor=lightgrey><td class=tablehead> Sr.no.</td>"
	Response.write "<td class=tablehead>Manuf. Name </td>"
	Response.write "<td class=tablehead>Mobile Model </td>"
	Response.write "<td class=tablehead>Network</td>"
	Response.write "<td class=tablehead>Display</td>"
	Response.write "<td class=tablehead>Ringtone</td>"
	Response.write "<td class=tablehead>Announced</td>"
	Response.write "<td class=tablehead>Status</td>"
	Response.write "<td class=tablehead>View image</td>"
	Response.write "<td class=tablehead> Edit/Delete </td> </tr>"

	do while not rsMain.EOF
		i=i+1
		Response.write "<tr> <td> " & i & "</td>"
		Response.write "<td><b> " & rsMain("ManufName") & "</b></td>"
		Response.write "<td><b> " & rsMain("ModelNo") & "</b></td>"
		
		%>
		<script language=javascript>
		document.write("<td><b> "+getAllInfo(1,'<%=rsMain("NetworkTypeCode")%>')+"</b></td>");
		</script>
		<%Response.write "<td><b> " & rsMain("DispType") & "</b></td>"
		'valdb = "<script language=javascript>" & vbCrLf & _
		'	"document.write(getAllInfo(1," & rsMain("NetworkTypeCode") & "))" & vbCrLf & "</script>"
		'if rsTemp.State then rsTemp.Close
		'rsTemp.Open "Select * from mNetwork where NetworkTypeCode in (" & rsMain("NetworkTypeCode") & ")",conn,2,1
		'do while not rsTemp.EOF
		'	valdb = valdb & rsTemp("NetworkType") & "\" 
		'	rsTemp.MoveNext 
		'loop
		'Response.write "<td><b> " & mid(valdb,1,len(valdb)-1) & "</b></td>"
		'Response.write "<td><b> " & valdb & "</b></td>"
		

		'valdb = ""
		'if rsTemp.State then rsTemp.Close
		'rsTemp.Open "Select * from mRingtone where RingtoneTypeCode in (" & rsMain("RingtoneTypeCode") & ")",conn,2,1
		'do while not rsTemp.EOF
		'	valdb = valdb & rsTemp("RingtoneType") & "\" 
		'	rsTemp.MoveNext 
		'loop
		'Response.write "<td><b> " & mid(valdb,1,len(valdb)-1) & "</b></td>"
		%>
		<script language=javascript>
		document.write("<td><b> "+getAllInfo(2,'<%=rsMain("RingtoneTypeCode")%>')+"</b></td>");
		</script>

		
		<%Response.write "<td><b> " & rsMain("Announced") & "</b></td>"
		Response.write "<td><b> "
		if rsMain("Status")&""="1" then 
			Response.Write "Available"
		elseif rsMain("Status")&""="2" then 
			Response.Write "Coming soon"
		elseif rsMain("Status")&""="3" then 
			Response.Write "cancelled"
		end if
		Response.Write  "</b></td>"
		Response.write "<td>"
		if len(rsMain("ImgFile1")&"")>0 then response.Write "<a href=""javascript:show('" & rsMain("ModelNo") & "',3);"" class=""link3"">View image</a>"
		Response.write "</td><td> <a href=""javascript:show('" & rsMain("ModelNo") & "',1);"" class=""link3"">"
		Response.write "Edit</a> | "
		Response.write "<a href=""javascript:show('" & rsMain("ModelNo") & "',2);"" class=""link3"">"
		Response.write "Delete </a></td></tr>"
		rsMain.movenext
	loop

	Response.write "</table>"

%>

</form>
</body>
</html>
