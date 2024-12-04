<%@ Language=VBScript %>
<!-- #Include File = "..\Global\MainSrc.asp" -->
<%
Dim rsMain, sqlQry, strModelNo, rsTemp, valdb
	set rsMain = server.createObject("Adodb.Recordset")
	set rsTemp=Server.CreateObject("Adodb.RecordSet")

	strModelNo = Request.Form("hdModelNo")
	sqlQry="SELECT mMobileModel.*, mManufacturer.ManufName,  mMobileModel.DispTypeCode, DispType " & _
		"FROM mMobileModel inner join mManufacturer on mMobileModel.ManufCode = mManufacturer.ManufCode " & _
		"inner join mDispType on mMobileModel.DispTypeCode = mDispType.DispTypeCode " & _		
		" Where mMobileModel.ModelNo='" & strModelNo & "'" & _
		" order by mMobileModel.ManufCode, ModelNo"

	rsMain.Open sqlQry,conn,3,2
	if rsMain.EOF or rsMain.BOF then
		Response.End 
	end if
%>
<html>
<head>
<title>Mobile Details ::<%=strModelNo%>::</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<LINK rel="stylesheet" type="text/css" href="../Css.css">
<script language="JavaScript" type="text/JavaScript">
<!--
function openWindow(theURL,winName,features) { 
  window.open(theURL,winName,features);
}
//-->
</script>
<script language=javascript>
function showdisplay(p,q)
{
	if (q==3)
	{
		openWindow('ViewImage.asp?m='+p,'ImgWind','status=yes,menubar=yes,scrollbars=yes,resizable=yes,width=450,height=450');
	}
}
</script>

</head>

<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="14%" valign="top"><table width="140" height="140" border="0" cellpadding="3" cellspacing="0">
        <tr> 
          <td width="187">
          <a href="javascript:showdisplay('<%=rsMain("ModelNo")%>',3);" class="link3">
          <img src="../images/Models/<%=rsMain("ImgFile2")%>" width="140" height="140" border=0>
          <br><b><%Response.Write rsMain("ManufName") & " - " & rsMain("ModelNo")%></b>
          </a></td>
        </tr>
      </table></td>
    <td width="86%"><table width=100% border=0 cellpadding="0" cellspacing=1 bgcolor="#CCCCCC">
        <tr bgcolor=#f8f8f8> 
          <td width=17% rowspan=4 class="siz"><b>General</b></td>
          <td width=17% height="21" class="head">Model</td>
          <td width=66% class="Content"><b> 
            <%Response.Write rsMain("ManufName") & " - " & rsMain("ModelNo")%>
            </b> </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td class="Head">Network</td>
          <td class="Content"> 
            <%valdb = ""
		if rsTemp.State then rsTemp.Close
		rsTemp.Open "Select * from mNetwork where NetworkTypeCode in (" & rsMain("NetworkTypeCode") & ")",conn,2,1
		do while not rsTemp.EOF
			valdb = valdb & rsTemp("NetworkType") & "\" 
			rsTemp.MoveNext 
		loop
		Response.write mid(valdb,1,len(valdb)-1) 
%>
          </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td class="Head">Announced</td>
          <td class="Content"><%=rsMain("Announced")%></td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td class="Head">Status</td>
          <td class="Content"> 
            <%
		  		if rsMain("Status")&""="1" then 
			Response.Write "Available"
		elseif rsMain("Status")&""="2" then 
			Response.Write "Coming soon"
		elseif rsMain("Status")&""="3" then 
			Response.Write "cancelled"
		end if
		%>
          </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td rowspan=2 class="siz"><font size="2" face="Verdana, Arial, Helvetica, sans-serif"><b>Size</b></font></td>
          <td class="Head">Dimensions</td>
          <td class="Content"><%=rsMain("Dimension")%></td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td class="Head">Weight</td>
          <td class="Content"><%=rsMain("Weight")%> g</td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td rowspan=2 class="siz"><font size="2" face="Verdana, Arial, Helvetica, sans-serif"><b>Display</b></font></td>
          <td class="Head">Type</td>
          <td class="Content"> 
            <% Response.Write rsMain("DispType") & " " & rsMain("DisplayInfo") %>
          </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td valign="top" class="Head">Size</td>
          <td class="Content"><%=rsMain("DispSize")%></td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td rowspan=3 class="siz"><font size="2" face="Verdana, Arial, Helvetica, sans-serif"><b>Ringtones</b></font></td>
          <td class="Head">Type</td>
          <td class="Content"> 
            <%
		valdb = ""
		if rsTemp.State then rsTemp.Close
		'Response.Write  "Select * from mRingtone where RingtoneTypeCode in (" & rsMain("RingtoneTypeCode") & ")"
		'Response.End 
		rsTemp.Open "Select * from mRingtone where RingtoneTypeCode in (" & rsMain("RingtoneTypeCode") & ")",conn,2,1
		do while not rsTemp.EOF
			valdb = valdb & rsTemp("RingtoneType") & ", " 
			rsTemp.MoveNext 
		loop
		Response.write mid(valdb,1,len(valdb)-1) 
		  %>
          </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td class="Head">Customization</td>
          <td class="Content"> 
            <%
		  		if rsMain("CustomizeTone") then Response.Write "Downloadable" else Response.Write "No"
		%>
          </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td class="Head">Vibration </td>
          <td class="Content"> 
            <%
		  		if rsMain("Vibration") then Response.Write "Yes" else Response.Write "No"
		%>
          </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td rowspan=2 class="siz"><font size="2" face="Verdana, Arial, Helvetica, sans-serif"><b>Memory</b></font></td>
          <td class="Head">Phonebook</td>
          <td class="Content"> 
            <%Response.Write replace(rsMain("PhoneBook"),vbcrlf,"<Br>")%>
          </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td valign="top" class="Head">Call records&nbsp;</td>
          <td class="Content"> 
            <%Response.Write replace(rsMain("CallRecords"),vbcrlf,"<Br>")%>
          </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td colspan="3" valign="top" class="siz"><table width="100%" border="0" cellpadding="0" cellspacing=0 >
              <tr bgcolor=#f8f8f8> 
                <td width="17%"><font size="2" face="Verdana, Arial, Helvetica, sans-serif"><b>Features</b></font></td>
                <td width="83%"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="Border3">
				<%Dim ValAll
				ValAll=rsMain("GPRS") & ""
				if len(ValAll)>0 then
				%>
                    <tr bgcolor=#f8f8f8> 
                      <td width="21%" class="Head">GPRS</td>
                      <td width="79%" class="Content">
                        <%Response.Write replace(ValAll,vbcrlf,"<Br>")%>
                      </td>
                    </tr>
				<%end if%>
				
				<%
				ValAll=rsMain("DataSpeed") & ""
				if len(ValAll)>0 then
				%>
                    <tr bgcolor=#f8f8f8> 
                      <td class="Head">Data speed</td>
                      <td width="79%" class="Content">
                        <%Response.Write replace(ValAll,vbcrlf,"<Br>")%>
                      </td>
                    </tr>
				<%end if%>
                    <tr bgcolor=#f8f8f8> 
                      <td class="Head">Messaging</td>
                      <td width="79%" class="Content">
            <%Dim Msg
Msg=""
if rsMain("SMS") then Msg = Msg & ", SMS" 

if rsMain("MMS") then Msg = Msg & ", MMS" 

if rsMain("EmailMsg") then Msg = Msg & ", Email" 

if rsMain("InstantMsg") then Msg = Msg & ", Instant Messaging" 

if Mid(Msg,1,1)=","  then response.write mid(Msg,2) & " " & len(ValAll) else Response.Write Msg%>
                      </td>
                    </tr>
       <tr bgcolor=#f8f8f8> 
          <td class="Head">Clock</td>
          <td width="79%" class="Content"> 
            <%if rsMain("Clock") then Response.Write "Yes" else Response.Write "No" %>
          </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td class="Head">Alarm</td>
          <td width="79%" class="Content"> 
            <%if rsMain("Alarm") then Response.Write "Yes" else Response.Write "No" %>
          </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td class="Head">Infrared port</td>
          <td width="79%" class="Content"> 
            <%if rsMain("InfraRed") then Response.Write "Yes" else Response.Write "No" %>
          </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td class="Head">Blue tooth</td>
          <td width="79%" class="Content"> 
            <%if rsMain("BlueTooth") then Response.Write "Yes" else Response.Write "No" %>
          </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td class="Head">3g Model</td>
          <td width="79%" class="Content"> 
            <%if rsMain("Model3G") then Response.Write "Yes" else Response.Write "No" %>
          </td>
        </tr>
				<%
				ValAll=rsMain("Games")&""
				if len(VallAll)>0 then
				%>
                    <tr bgcolor=#f8f8f8> 
                      <td class="Head">Games</td>
                      <td width="79%" class="Content">
                        <%Response.Write replace(ValAll,vbcrlf,"<Br>")%>
                      </td>
                    </tr>
				<%end if
				ValAll=rsMain("MobileColor")&""
				if len(ValAll)>0 then
				%>
                    <tr bgcolor=#f8f8f8> 
                      <td class="Head">Mobile Color(s)</td>
                      <td width="79%" class="Content">
                        <%Response.Write replace(ValAll,vbcrlf,"<Br>")%>
                      </td>
                    </tr>
				<%end if%>
        <tr bgcolor=#f8f8f8> 
          <td class="Head">Camera</td>
          <td width="79%" class="Content"> 
            <%if rsMain("Camera") then Response.Write "Yes "  & rsMain("CameraInfo")%>
          </td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td valign="top" class="siz">&nbsp;</td>
          <td width="79%" class="Content"> 
            <%Response.Write replace(rsMain("Features"),vbCrLf,"<br>")%>
          </td>
        </tr>
                  </table></td>
              </tr>
            </table></td>
        </tr>
        <tr bgcolor=#f8f8f8> 
          <td valign="top" class="siz"><font size="2" face="Verdana, Arial, Helvetica, sans-serif"><strong>Battery</strong></font></td>
          <td class="Head"> Stand-by/Talk time</td>
          <td class="Content"> 
            <%Response.Write replace(rsMain("BatteryInfo"),vbCrLf,"<br>")%>
          </td>
        </tr>
      </table></td>
  </tr>
</table>
</body>
</html>
