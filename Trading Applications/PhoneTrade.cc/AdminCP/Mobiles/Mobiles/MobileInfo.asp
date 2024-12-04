<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<%
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if

	Dim strAct, Flag
	Dim rsMain, sqlQry
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
	Dim CameraInfo, Features, Model3G
	
	ModelNo = Request.Form("txtModel")
	ManufCode = Request.Form("cboManuf")
	AdditionalInfo = replace(Request.Form("txtAddInfo"),"'","`")
	
	NetworkTypeCode = Request.Form("cboNetwork")
	Announced = replace(Request.Form("txtAnnounced"),"'","`")
	Status = Request.Form("cboStatus")

	Weight = Request.Form("txtWeight")
	Dimension = replace(Request.Form("txtDimension"),"'","`")
	PhoneBook = replace(Request.Form("txtPhBook"),"'","`")
	
	CallRecords = replace(Request.Form("txtCallRecords"),"'","`")
	DispTypeCode = Request.Form("cboDispType")
	DisplayInfo = replace(Request.Form("txtDispTypeInfo"),"'","`")
	
	DispSize = replace(Request.Form("txtDisplaySize"),"'","`")
	RingtoneTypeCode = Request.Form("cboRingType")
	CustomizeTone = Request.Form("chkRingDownload")
	
	Vibration = Request.Form("chkVibration")
	BatteryInfo = replace(Request.Form("txtBattery"),"'","`")
	OSType = Replace(Request.Form("txtOSType"),"'","`")
	
	GPRS = replace(Request.Form("txtGPRS"),"'","`")
	DataSpeed = replace(Request.Form("txtDataSpeed"),"'","`")
	SMS = Request.Form("chkSMS")
	BlueTooth = Request.Form("chkBlueTh")
	
	MMS = Request.Form("chkMMS")
	EmailMsg = Request.Form("chkEmail")
	InstantMsg = Request.Form("chkInstMsg")
	
	Clock = Request.Form("chkClock")
	Alarm = Request.Form("chkAlarm")
	InfraRed = Request.Form("chkInfraRed")

	Games = replace(Request.Form("txtGames"),"'","`")
	MobileColor = replace(Request.Form("txtMobileColor"),"'","`")
	Camera = Request.Form("chkCamera")

	CameraInfo = replace(Request.Form("txtCameraInfo"),"'","`")
	Features = replace(Request.Form("txtFeatures"),"'","`")
	Model3G = Request.Form("chk3G")
	Descriptions = replace(Request.Form("txtDescription"),"'","`")
	
	strAct = Request.Form("hdAction") & Trim(Request.Form("btnOk"))

	select case strAct
	case "AddAdd"
		set rsTemp = server.CreateObject("Adodb.Recordset")
		rsTemp.Open "Select * from mMobileModel where ModelNo='" & ModelNo & "'", conn,3,3
		Flag="NO"
		if not rsTemp.EOF then
			'Response.Redirect "MobilesMain.asp?mode=4"
			'Response.End 
			Flag="YES"
		end if
		if Flag="NO" then
	
			set rsMain=server.CreateObject("ADODB.Recordset")
			rsMain.Open "select * from mMobileModel",conn,3,3
			rsMain.AddNew 
				rsMain("ModelNo") = ModelNo
				rsMain("ManufCode") = clng(ManufCode)
				rsMain("AdditionalInfo") = AdditionalInfo
	
				rsMain("NetworkTypeCode") = NetworkTypeCode
				rsMain("Announced") = Announced
				rsMain("Status") = cint(Status)

				rsMain("Weight") = cint(Weight)
				rsMain("Dimension") = Dimension
				rsMain("PhoneBook") = PhoneBook
	
				rsMain("CallRecords") = CallRecords
				rsMain("DispTypeCode") = cint(DispTypeCode)
				rsMain("DisplayInfo") = DisplayInfo
	
				rsMain("DispSize") = DispSize
				rsMain("RingtoneTypeCode") = RingtoneTypeCode
				rsMain("CustomizeTone") = cint(CustomizeTone)
	
				rsMain("Vibration") = cint(Vibration)
				rsMain("BatteryInfo") = BatteryInfo
				rsMain("OSType") = OSType
	
				rsMain("GPRS") = GPRS
				rsMain("DataSpeed") = DataSpeed
				rsMain("SMS") = cint(SMS)
				rsMain("BlueTooth") = BlueTooth
	
				rsMain("MMS") = cint(MMS)
				rsMain("EmailMsg") = cint(EmailMsg)
				rsMain("InstantMsg") = cint(InstantMsg)
	
				rsMain("Clock") = cint(Clock)
				rsMain("Alarm") = cint(Alarm)
				rsMain("InfraRed") = cint(InfraRed)

				rsMain("Games") = Games
				rsMain("MobileColor") = MobileColor
				rsMain("Camera") = cint(Camera)

				rsMain("CameraInfo") = CameraInfo
				rsMain("Features") = Features
				rsMain("Model3G") = cint(Model3G)
				rsMain("Descriptions") = Descriptions
			rsMain.Update 
		
			if err.number<>0 then
				Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
				Response.End 
			else
				Response.Redirect "ImageUpload.asp?Model=" & ModelNo & "&Manuf=" & ManufCode
			end if 	
		end if
	case "EditUpdate"

			dim strCode
			strCode = Request.Form("hdCode")
			set rsMain=server.CreateObject("ADODB.Recordset")
			rsMain.Open "select * from mMobileModel WHERE ModelNo='" & strCode & "'",conn,3,2
			'rsMain.AddNew 
				'rsMain("ModelNo") = ModelNo
				rsMain("ManufCode") = clng(ManufCode)
				rsMain("AdditionalInfo") = AdditionalInfo
	
				rsMain("NetworkTypeCode") = NetworkTypeCode
				rsMain("Announced") = Announced
				rsMain("Status") = cint(Status)

				rsMain("Weight") = cint(Weight)
				rsMain("Dimension") = Dimension
				rsMain("PhoneBook") = PhoneBook
	
				rsMain("CallRecords") = CallRecords
				rsMain("DispTypeCode") = cint(DispTypeCode)
				rsMain("DisplayInfo") = DisplayInfo
	
				rsMain("DispSize") = DispSize
				rsMain("RingtoneTypeCode") = RingtoneTypeCode
				rsMain("CustomizeTone") = cint(CustomizeTone)
	
				rsMain("Vibration") = cint(Vibration)
				rsMain("BatteryInfo") = BatteryInfo
				rsMain("OSType") = OSType
	
				rsMain("GPRS") = GPRS
				rsMain("DataSpeed") = DataSpeed
				rsMain("SMS") = cint(SMS)
				rsMain("BlueTooth") = BlueTooth
	
				rsMain("MMS") = cint(MMS)
				rsMain("EmailMsg") = cint(EmailMsg)
				rsMain("InstantMsg") = cint(InstantMsg)
	
				rsMain("Clock") = cint(Clock)
				rsMain("Alarm") = cint(Alarm)
				rsMain("InfraRed") = cint(InfraRed)

				rsMain("Games") = Games
				rsMain("MobileColor") = MobileColor
				rsMain("Camera") = cint(Camera)

				rsMain("CameraInfo") = CameraInfo
				rsMain("Features") = Features
				rsMain("Model3G") = cint(Model3G)
				rsMain("Descriptions") = Descriptions
			rsMain.Update 

		if err.number<>0 then
			Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "MobilesMain.asp?mode=2"
		end if 	
	case "Del"
		'strCode = Request.Form("hdCode")
		'set rsTemp = server.CreateObject("Adodb.Recordset")
		'rsTemp.Open "Select RingtoneTypeCode from mMobileModel where RingtoneTypeCode=" & strCode ,conn,3,3
		'if not rsTemp.EOF then
		'	Response.Redirect "MobilesMain.asp?mode=4"
		'	Response.End 
		'end if
		
		strCode = Request.Form("hdCode")
		sqlQry = "Delete from mMobileModel where ModelNo='" & strCode & "'"
		conn.execute sqlQry
		if err.number<>0 then
			Response.Redirect "../Errorpg.asp?errNo=" & err.number & "&errDesc=" & err.Description 
			Response.End 
		else
			Response.Redirect "MobilesMain.asp?mode=3"
		end if 	
				
	End select
%>
<html>
<head>
<body onLoad="change();">
<form name=frm method=post>
 <input type=hidden name=txtModel value="<%=ModelNo%>">
 <input type=hidden name=cboManuf value="<%=ManufCode%>">
 <input type=hidden name=txtAddInfo value="<%=AdditionalInfo%>">
 
 <input type=hidden name=cboNetwork value="<%=NetworkTypeCode%>">
 <input type=hidden name=txtAnnounced value="<%=Announced%>">
 <input type=hidden name=cboStatus value="<%=Status%>">
 
 <input type=hidden name=txtWeight value="<%=Weight%>">
 <input type=hidden name=txtDimension value="<%=Dimension%>">
 <input type=hidden name=txtPhBook value="<%=PhoneBook%>">

 <input type=hidden name=txtCallRecords value="<%=CallRecords%>">
 <input type=hidden name=cboDispType value="<%=DispTypeCode%>">
 <input type=hidden name=txtDispTypeInfo value="<%=DisplayInfo%>">
	
 <input type=hidden name=txtDisplaySize value="<%=DispSize%>">
 <input type=hidden name=cboRingType value="<%=RingtoneTypeCode%>">
 <input type=hidden name=chkRingDownload value="<%=CustomizeTone%>">

 <input type=hidden name=chkVibration value="<%=Vibration%>">
 <input type=hidden name=txtBattery value="<%=BatteryInfo%>">
 <input type=hidden name=txtOSType value="<%=OSType%>">
	
 <input type=hidden name=txtGPRS value="<%=GPRS%>">
 <input type=hidden name=txtDataSpeed value="<%=DataSpeed%>">
 <input type=hidden name=chkSMS value="<%=SMS%>">
	
 <input type=hidden name=chkBlueTh value="<%=BlueTooth%>">
 <input type=hidden name=chkMMS value="<%=MMS%>">
 <input type=hidden name=chkEmail value="<%=EmailMsg%>">

 <input type=hidden name=chkInstMsg value="<%=InstantMsg%>">
 <input type=hidden name=chkClock value="<%=Clock%>">
 <input type=hidden name=chkAlarm value="<%=Alarm%>">

 <input type=hidden name=chkInfraRed value="<%=InfraRed%>">
 <input type=hidden name=txtGames value="<%=Games%>">
 <input type=hidden name=txtMobileColor value="<%=MobileColor%>">

 <input type=hidden name=chkCamera value="<%=Camera%>">
 <input type=hidden name=txtCameraInfo value="<%=CameraInfo%>">
 <input type=hidden name=txtFeatures value="<%=Features%>">
 <input type=hidden name=chk3G value="<%=Model3G%>">
<input type=hidden name=txtDescription value="<%=Descriptions%>">
 <input type=hidden name=txtMsg>   
	<script language=Javascript>
		function change()
		{
			if ("<%=Flag%>"=="YES")
			{
				document.frm.txtMsg.value = "Mobile model : " + "<%=ModelNo%>" + " already found in the database. ";
				document.frm.action = "NewMobile.asp";
				document.frm.submit();
			}
		}
		
	</script>
</form>
</body>
</head>
</htmL>