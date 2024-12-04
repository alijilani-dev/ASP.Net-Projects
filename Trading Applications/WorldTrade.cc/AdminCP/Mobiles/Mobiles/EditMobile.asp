<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<% Dim rsMain, sql, i
Dim strCode, rsTemp
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if

set rsMain = Server.CreateObject("Adodb.Recordset")
set rsTemp = Server.CreateObject("Adodb.Recordset")

	Dim strMsg, Flag
	Dim ModelNo, ManufCode, AdditionalInfo
	Dim NetworkTypeCode, Announced, Status
	Dim Weight, Dimension, PhoneBook
	Dim CallRecords, DispTypeCode, DisplayInfo
	Dim DispSize, RingtoneTypeCode, CustomizeTone	
	dim Vibration, BatteryInfo, OSType
	Dim GPRS, DataSpeed, SMS, BlueTooth
	Dim MMS, EmailMsg, InstantMsg
	Dim Clock, Alarm, InfraRed
	Dim Games, MobileColor, Camera
	Dim CameraInfo, Features, Model3G, Descriptions
	strMsg = Request.Form("txtMsg")


	strCode = Request.Form("hdCode")
	sql="select * from mMobileModel where ModelNo='" & strCode & "' order by ModelNo"
	rsMain.Open sql,conn,3,2
	'Response.Write rsMain.RecordCount
	'Response.End 
if not rsMain.EOF then 
	ModelNo = rsMain("ModelNo") & ""
	ManufCode = rsMain("ManufCode") & ""
	AdditionalInfo = rsMain("AdditionalInfo") & ""
	
	NetworkTypeCode = rsMain("NetworkTypeCode") & ""
	Announced = rsMain("Announced") & ""
	Status = rsMain("Status") & ""

	Weight = rsMain("Weight") & ""
	Dimension = rsMain("Dimension") & ""
	PhoneBook = rsMain("PhoneBook") & ""
	
	CallRecords = rsMain("CallRecords") & ""
	DispTypeCode = rsMain("DispTypeCode") & ""
	DisplayInfo = rsMain("DisplayInfo") & ""
	
	DispSize = rsMain("DispSize") & ""
	RingtoneTypeCode = rsMain("RingtoneTypeCode") & ""
	CustomizeTone = rsMain("CustomizeTone")' & ""
	
	Vibration = rsMain("Vibration")' & ""
	BatteryInfo = rsMain("BatteryInfo") & ""
	OSType = rsMain("OSType") & ""
	
	GPRS = rsMain("GPRS") & ""
	DataSpeed = rsMain("DataSpeed") & ""
	SMS = rsMain("SMS")' & ""
	BlueTooth = rsMain("BlueTooth")' & ""
	
	MMS = rsMain("MMS")' & ""
	EmailMsg = rsMain("EmailMsg")' & ""
	InstantMsg = rsMain("InstantMsg")' & ""
	
	Clock = rsMain("Clock")' & ""
	Alarm = rsMain("Alarm")' & ""
	InfraRed = rsMain("InfraRed") '& ""

	Games = rsMain("Games") & ""
	MobileColor = rsMain("MobileColor") & ""
	Camera = rsMain("Camera")' & ""

	Descriptions= rsMain("Descriptions") & ""

	CameraInfo = rsMain("CameraInfo") & ""
	Features = rsMain("Features") & ""
	Model3G = rsMain("Model3G")' & ""
end if
'strCode = Request.Form("hdCode")
'	sql="select * from mDispType where DispTypeCode=" & strCode & "order by DispType"
'	set rsMain=Server.CreateObject("Adodb.RecordSet")
'	rsMain.Open sql,conn,3,2
%>

<html>
<head>
<title>Mobile Information</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="../Global/MyStyle.CSS" rel="stylesheet" type="text/css">
<script language='javascript' src=../Global/valid.js></script>
</head>

<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" class="contact">
  <tr>
    <td>
    <form name="frmMobiles" method="post" action="MobileInfo.asp" onSubmit="JavaScript:return FormSubmit();">
    <input type=hidden name=hdAction value="">
    <input type=hidden name=hdCode value="<%=strCode%>">
    
<script language=javascript>
 function FormSubmit()
{
		errStr = "The following error(s) occurred:\n";
		var CanSubmit = false;
		
		//x=document.frmMobiles.cboManuf.options[document.frmMobiles.cboManuf.selectedIndex].text;
		x = document.frmMobiles.cboManuf.value;
		CanSubmit = DefaultCheck(x,"    - Manufacturer name is required.");	

		// Check to make sure that the full name field is not empty.
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmMobiles"].txtModel,"    - Modal no/name is required.");	
		
		x = document.frmMobiles.cboNetwork.value;
		CanSubmit = CanSubmit & DefaultCheck(x,"    - Network type is required.");	

		CanSubmit = CanSubmit & ForceEntry(document.forms["frmMobiles"].txtAnnounced,"    - Model announced information is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmMobiles"].txtWeight,"    - Mobile weight is required.");
		CanSubmit = CanSubmit & numEntry(document.forms["frmMobiles"].txtWeight.value,"    - Mobile weight should not contain invalid characters!.");		

		CanSubmit = CanSubmit & ForceEntry(document.forms["frmMobiles"].txtDimension,"    - Dimension of the mobile is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmMobiles"].txtDescription,"    - Phone Description is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmMobiles"].txtPhBook,"    - Phone book entry is required.");
		CanSubmit = CanSubmit & ForceEntry(document.forms["frmMobiles"].txtCallRecords,"    - Call records information is required.");

		x = document.frmMobiles.cboDispType.value;
		CanSubmit = CanSubmit & DefaultCheck(x,"    - Display type is required.");	

		CanSubmit = CanSubmit & ForceEntry(document.forms["frmMobiles"].txtDisplaySize,"    - Display size is required.");

		x = document.frmMobiles.cboRingType.value;
		CanSubmit = CanSubmit & DefaultCheck(x,"    - Ringtone type is required.");	

		CanSubmit = CanSubmit & ForceEntry(document.forms["frmMobiles"].txtBattery,"    - Battery performance is required.");	

		CanSubmit = (CanSubmit!=0)

		if (CanSubmit)
		{
			x = document.frmMobiles.cboManuf.value;
			CanSubmit = CanSubmit &  DefaultCheck(x,"    - Manufacturer name is required.");	

			x = document.frmMobiles.cboNetwork.value;
			CanSubmit = CanSubmit & DefaultCheck(x,"    - Network type is required.");	

			CanSubmit = CanSubmit & numEntry(document.forms["frmMobiles"].txtWeight.value,"    - Mobile weight should not contain invalid characters!.");		

			CanSubmit = CanSubmit & LenCheck(document.forms["frmMobiles"].txtDescription,1000,"    - Phone Description entry should be less than 255 characters!.");		
			CanSubmit = CanSubmit & LenCheck(document.forms["frmMobiles"].txtPhBook,255,"    - Phone book entry should be less than 255 characters!.");		

			CanSubmit = CanSubmit & LenCheck(document.forms["frmMobiles"].txtCallRecords,255,"    - Call records entry should be less than 255 characters!.");		
			
			CanSubmit = CanSubmit & LenCheck(document.forms["frmMobiles"].txtBattery,255,"    - Battery performance entry should be less than 255 characters!.");
			
			x = document.frmMobiles.cboRingType.value;
			CanSubmit = CanSubmit & DefaultCheck(x,"    - Ringtone type is required.");	
			
		}
		CanSubmit = (CanSubmit!=0)

		if (CanSubmit==false) 
		{alert(errStr);
		return false;
		}
		else
		{
			document.frmMobiles.hdAction.value="Edit";
			document.frmMobiles.action="MobileInfo.asp";
			document.frmMobiles.submit();
		}
}
</script>
<%if len(strMsg)>0 then %>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="1" class="TableBackGround">
          <tr>
            <td align=center><font color=red>
			<%=strMsg%>
			</font></td>
          </tr>
        </table><br>
<% end if%>
        
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0" class="Border2">
          <tr>
            <td><table width="100%" border="0" cellpadding="2" cellspacing="0" class="contact">
                <tr>
                  <td class="HeadingBackGroundLeft">Edit mobile information 
                    </td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" class="LightBackground"><table width=100% border=0 align=Center class="Border">
                <tr align="left"> 
                  <td Colspan=2 Class=HeadingBackGroundLeft>General Information</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="32%" align=right class="contact">Manufacturer</td>
                  <td width="68%"><select name="cboManuf" class="TextBox" id="cboManuf" style="width: 150px;">
                  <option value="select">[--Select--]</option>
                            <% set rsTemp  = conn.Execute("select * from mManufacturer order by ManufName")
								rsTemp.MoveFirst 
							do while not rsTemp.EOF  
							%>
                            <option value=<%=rsTemp("ManufCode")%>><%=rsTemp("ManufName")%></option>
                            <% rsTemp.MoveNext 
						loop 
						set rsTemp=nothing %>
                          </select>
					 <SCRIPT LANGUAGE=javascript>
						value = "<%=ManufCode%>" 
						for (i=0;i<document.frmMobiles.cboManuf.length;i++)
							if (document.frmMobiles.cboManuf.options[i].value==value)
								document.frmMobiles.cboManuf.selectedIndex = i;
					</SCRIPT>

                    </td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Model Name</td>
                  <td><input name=txtModel type=text class=Textbox id="txtModel" value="<%=ModelNo%>" maxlength="20" readonly> 
                     <font color="#0000FF">You cannot change the model name</font></td>
                </tr>
                <tr Class=TableBackGround>
                  <td align=right class="contact">Additional information </td>
                  <td><input name=txtAddInfo type=text class=Textbox id="txtAddInfo" value="<%=AdditionalInfo%>" maxlength="100">
                    <font color="#0000FF">Any other information about model</font></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Network</td>
                  <td><select name="cboNetwork" class="TextBox" id="cboNetwork" size="4" multiple>
                  <option value="select">[--Select--]</option>
                            <% set rsTemp  = conn.Execute("select * from mNetwork order by NetworkType")
								rsTemp.MoveFirst 
							do while not rsTemp.EOF  
							%>
                            <option value=<%=rsTemp("NetworkTypeCode")%>><%=rsTemp("NetworkType")%></option>
                            <% rsTemp.MoveNext 
						loop 
						set rsTemp=nothing %>

                    </select> 
					 <SCRIPT LANGUAGE=javascript>
					var col="<%=NetworkTypeCode%>".split(", ");
					var loc=0;
					while (loc < col.length)
					{
						value = col[loc];
						for (i=0;i<document.frmMobiles.cboNetwork.length;i++)
						{	if (document.frmMobiles.cboNetwork.options[i].value==value)
								document.frmMobiles.cboNetwork.options[i].selected  = true			
						}
						loc+=1;
					}

					</SCRIPT>

                    </td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Announced</td>
                  <td><input name=txtAnnounced type=text class=Textbox id="txtAnnounced" value="<%=Announced%>" maxlength="30"> 
                    <font color="#0000FF">Eg. April 2005</font></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Status</td>
                  <td><select name="cboStatus" class="TextBox" id="cboStatus">
                      <option value="1" selected>Available</option>
                      <option value="2">Comming Soon</option>
                      <option value="3">Cancelled</option>
                    </select> 
					 <SCRIPT LANGUAGE=javascript>
						value = "<%=status%>" 
						for (i=0;i<document.frmMobiles.cboStatus.length;i++)
							if (document.frmMobiles.cboStatus.options[i].value==value)
								document.frmMobiles.cboStatus.selectedIndex = i;
					</SCRIPT>

                    </td>
                </tr>
                <tr height=2> 
                  <td colspan="2" align=right class="HeadingWithBackGround"></td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0" class="Border">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" class="LightBackground"><table width=100% border=0 align=Center class="contact">
                <tr align="left"> 
                  <td Colspan=2 Class=HeadingBackGroundLeft>Size</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="32%" align=right class="contact">Weight</td>
                  <td width="68%"><input name="txtWeight" type=text class=Textbox id="txtWeight" value="<%=Weight%>" maxlength="10">
                    grams <font color="#0000FF">Eg. 100</font></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Dimension</td>
                  <td> <input name="txtDimension" type=text class=Textbox id="txtDimension" value="<%=Dimension%>" maxlength="30">
                    <font color="#0000FF">Eg. 105 x 45 x 21 mm</font></td>
                </tr>
                <tr height=2> 
                  <td colspan="2" align=right class="HeadingWithBackGround"></td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0" class="Border">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" class="LightBackground"><table width=100% border=0 align=Center class="contact">
                <tr align="left"> 
                  <td Colspan=2 Class=HeadingBackGroundLeft>Phone description</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="32%" align=right class="contact">Description</td>
                  <td width="68%"><font color="#0000FF">Description of the phone 
                    model </font><font color="#0000FF">Max. 1000 Char.<br>
                    </font> <textarea name="txtDescription" class="TextBox" id="txtDescription" style="width: 300px; height: 100px;"><%=Descriptions%></textarea></td>
                </tr>
                <tr height=2> 
                  <td colspan="2" align=right class="HeadingWithBackGround"></td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0" class="Border">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" class="LightBackground"><table width=100% border=0 align=Center class="contact">
                <tr align="left"> 
                  <td Colspan=2 Class=HeadingBackGroundLeft>Memory</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="32%" align=right class="contact">Phone Book</td>
                  <td width="68%">
				<font color="#0000FF">No. of Ph Book entries that can be stored Max. 255 Char.<br></font> 
				<textarea name="txtPhBook" class="TextBox" id="txtPhBook" style="width: 200px; height: 100px;"><%=PhoneBook%></textarea>                    

                  </td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Call Records</td>
                  <td>
				<font color="#0000FF">No. of Call Rec. entries that can be 
                    stored Max. 255 Char.<br></font> 
				<textarea name="txtCallRecords" class="TextBox" id="txtCallRecords" style="width: 200px; height: 100px;"><%=CallRecords%></textarea>                    

                    </td>
                </tr>
                <tr height=2> 
                  <td colspan="2" align=right class="HeadingWithBackGround"></td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0" class="Border">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" class="LightBackground"><table width=100% border=0 align=Center class="contact">
                <tr align="left"> 
                  <td Colspan=2 Class=HeadingBackGroundLeft>Display</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="32%" align=right class="contact">Type</td>
                  <td width="68%"><select name="cboDispType" class="TextBox" id="cboDispType">
							<option value="select">[--Select--]</option>
                            <% set rsTemp  = conn.Execute("select * from mDispType order by DispType")
								rsTemp.MoveFirst 
							do while not rsTemp.EOF  
							%>
                            <option value=<%=rsTemp("DispTypeCode")%>><%=rsTemp("DispType")%></option>
                            <% rsTemp.MoveNext 
						loop 
						set rsTemp=nothing %>

                    </select>
					 <SCRIPT LANGUAGE=javascript>
						value = "<%=DispTypeCode%>" 
						for (i=0;i<document.frmMobiles.cboDispType.length;i++)
							if (document.frmMobiles.cboDispType.options[i].value==value)
								document.frmMobiles.cboDispType.selectedIndex = i;
					</SCRIPT>

                    <input name="txtDispTypeInfo" type=text class=Textbox id="txtDispTypeInfo" value="<%=DisplayInfo%>" maxlength="100">
                    <font color="#0000FF">(Display desc.)</font></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Size</td>
                  <td> <input name="txtDisplaySize" type=text class=Textbox id="txtDisplaySize" value="<%=DispSize%>" maxlength="50">
                    <font color="#0000FF">Eg. 128 x 128 Pixels, 8 Lines</font></td>
                </tr>
                <tr height=2> 
                  <td colspan="2" align=right class="HeadingWithBackGround"></td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0" class="Border">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" class="LightBackground"><table width=100% border=0 align=Center class="contact">
                <tr align="left"> 
                  <td Colspan=2 Class=HeadingBackGroundLeft>Ringtone</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="32%" align=right class="contact">Type</td>
                  <td width="68%"><select name="cboRingType" class="TextBox" id="cboRingType" size="4" multiple>
                  <option value="select">[--Select--]</option>
                            <% set rsTemp  = conn.Execute("select * from mRingtone order by RingtoneType")
								rsTemp.MoveFirst 
							do while not rsTemp.EOF  
							%>
                            <option value=<%=rsTemp("RingtoneTypeCode")%>><%=rsTemp("RingtoneType")%></option>
                            <% rsTemp.MoveNext 
						loop 
						set rsTemp=nothing %>

                    </select> 
					 <SCRIPT LANGUAGE=javascript>
					var col="<%=RingtoneTypeCode%>".split(", ");
					var loc=0;
					while (loc < col.length)
					{
						value = col[loc];
						for (i=0;i<document.frmMobiles.cboRingType.length;i++)
						{	if (document.frmMobiles.cboRingType.options[i].value==value)
								document.frmMobiles.cboRingType.options[i].selected  = true			
						}
						loc+=1;
					}

					</SCRIPT>

                    </td>
                </tr>
                <tr Class=TableBackGround>
                  <td align=right class="contact">Customization</td>
                  <td><input name="chkRingDownload" type="checkbox" id="chkRingDownload" value="1" <%if CustomizeTone then Response.Write "checked" else Response.Write CustomizeTone%> >
                    Downloadable ?</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Vibration</td>
                  <td> <input name="chkVibration" type="checkbox" id="chkVibration" value="1" <%if Vibration then Response.Write "checked"%>>
                  </td>
                </tr>
                <tr height=2> 
                  <td colspan="2" align=right class="HeadingWithBackGround"></td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0" class="Border">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" class="LightBackground"><table width=100% border=0 align=Center class="contact">
                <tr align="left"> 
                  <td Colspan=2 Class=HeadingBackGroundLeft>Battery performance</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="32%" align=right class="contact">Battery performance<br>
                    (Stand by and Talk time)</td>
                  <td width="68%" valign="top">
                  <font color="#0000FF">Duration of talk time and etc. Max 255 char.</font>
                   <textarea name="txtBattery" class="TextBox" id="txtBattery" style="width: 200px; height: 100px;"><%=BatteryInfo%></textarea> 
                  </td>
                </tr>
                <tr height=2> 
                  <td colspan="2" align=right class="HeadingWithBackGround"></td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0" class="Border">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" class="LightBackground"><table width=100% border=0 align=Center class="contact">
                <tr align="left"> 
                  <td Colspan=2 Class=HeadingBackGroundLeft>Features</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="32%" align=right class="contact">Clock</td>
                  <td width="68%"><input name="chkClock" type="checkbox" id="chkClock" value="1"  <%if Clock then Response.Write "checked"%>> 
                  </td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Alarm</td>
                  <td><input name="chkAlarm" type="checkbox" id="chkAlarm" value="1"  <%if Alarm then Response.Write "checked"%>> 
                  </td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Messaging</td>
                  <td><input name="chkSMS" type="checkbox" id="chkSMS" value="1"  <%if SMS then Response.Write "checked"%>>
                    SMS 
                    <input name="chkMMS" type="checkbox" id="chkMMS" value="1"  <%if MMS then Response.Write "checked"%>>
                    MMS 
                    <input name="chkEmail" type="checkbox" id="chkEmail" value="1"  <%if EmailMsg then Response.Write "checked"%>>
                    Email 
                    <input name="chkInstMsg" type="checkbox" id="chkInstMsg" value="1"  <%if InstantMsg then Response.Write "checked"%>>
                    Instant Message</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Camera</td>
                  <td><input name="chkCamera" type="checkbox" id="chkCamera" value="1"  <%if Camera then Response.Write "checked"%>>
                    Yes/No 
                    <input name="txtCameraInfo" type=text class=Textbox id="txtCameraInfo" value="<%=CameraInfo%>" maxlength="50"> 
                    <font color="#0000FF">(Display desc.)</font></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Blue Tooth</td>
                  <td><input name="chkBlueTh" type="checkbox" id="chkBlueTh" value="1"></td>
                </tr>
                <tr Class=TableBackGround>
                  <td align=right class="contact">Infra Red</td>
                  <td> 
                    <input name="chkInfraRed" type="checkbox" id="chkInfraRed" value="1"  <%if InfraRed then Response.Write "checked"%>></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">3G</td>
                  <td><input name="chk3G" type="checkbox" id="chk3G" value="1"  <%if Model3G then Response.Write "checked"%>></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">OS Type</td>
                  <td><input name="txtOSType" type=text class=Textbox id="txtOSType" value="<%=OSType%>" maxlength="100"></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">GPRS</td>
                  <td><input name="txtGPRS" type=text class=Textbox id="txtGPRS" value="<%=GPRS%>" maxlength="50"></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Data Speed</td>
                  <td><input name="txtDataSpeed" type=text class=Textbox id="txtDataSpeed" value="<%=DataSpeed%>" maxlength="50"></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Games</td>
                  <td><input name="txtGames" type=text class=Textbox id="txtGames" value="<%=Games%>" maxlength="100"></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Mobile Color</td>
                  <td><input name="txtMobileColor" type=text class=Textbox id="txtMobileColor" value="<%=MobileColor%>" maxlength="100"></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Other Features</td>
                  <td><textarea name="txtFeatures" class="TextBox" style="width: 200px; height: 100px;"><%=Features%></textarea> 
                  </td>
                </tr>
                <tr height=2> 
                  <td colspan="2" align=right class="HeadingWithBackGround"></td>
                </tr>
                <tr> 
                  <td class="LightBackground"></td>
                  <td class="LightBackground"> <input type=Submit name=btnOk value="  Update  " class=Buttons> 
                    <input type=Reset name=btnCancel value=" Cancel " class=Buttons onClick='javascript:history.back();'> 
                  </td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
      </form>
      
    </td>
  </tr>
</table>

</body>
</html>
