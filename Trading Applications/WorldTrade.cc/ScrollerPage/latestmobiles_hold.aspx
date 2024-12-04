<%@ Page Language="vb" AutoEventWireup="false" Codebehind="latestmobiles.aspx.vb" Inherits="Trade.Latestmobiles" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>NewMember</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
		<SCRIPT type="text/javascript">
var idSpnTimeOut1 = 0;
var arr_Models_new = new Array();

<%=Latest%>

function getLatest(objTop15) {
  if (objTop15 == null) return "";
var pickId = "<table border=0 onMouseOver=\"clearTimeout(idSpnTimeOut1);\" style=\"background-color:" + objTop15.BGclr + "\" width=98% height=90 CELLSPACING=0 CELLPADDING=0 _background=\"../images/bg_cell.gif\">" +
"<tr style=\"background-color:" + objTop15.stypeBG + "\">" +
"<td rowspan=3 width=70><a href=\"../PortalDefault.aspx?Main_Links_ID=5&MobileSrNo="+objTop15.links+"\" target=\"_top\"><img style=\"cursor:hand\" src=\"../Images/Models/"+objTop15.gif+"\" height=70 width=70 border=0 HSPACE=15></a></td>" +
"<td>&nbsp;</td></tr>" +
"<tr><td align=\"left\" style=\"background-color:" + objTop15.BGclr + "\" class=\"normalText\"><a href=\"../PortalDefault.aspx?Main_Links_ID=5&MobileSrNo="+objTop15.links+"\" target=\"_top\">" + objTop15.manuf  + " <br> " + objTop15.model + "</a></td>" +
"</tr><tr><td height=20>&nbsp;</td></tr>" + "</table>";
	return pickId
}


var currArrID = 0;
function applyEffect_Latest() {
	spnLatest.filters[0].apply();
	spnLatest.innerHTML = getLatest(arr_Models_new[currArrID++]);
  spnLatest.filters[0].play(duration=2);
	if (currArrID >= arr_Models_new.length) currArrID = 0; 
	clearTimeout(idSpnTimeOut1);
	idSpnTimeOut1 = setTimeout('applyEffect_Latest()',3000);
}

		</SCRIPT>
	</HEAD>
	<body MS_POSITIONING="GridLayout" onload="clearTimeout(idSpnTimeOut1);applyEffect_Latest();">
		<div align="center">
			<table style="border:1px solid #3f8bd7; WIDTH: 176px; BACKGROUND-REPEAT: repeat-x"
				cellSpacing="0" cellPadding="0" height="121" background="../images/bg_cell.gif"
				border="0" id="table47">
				<tr>
					<td width="3" rowSpan="3">
						<img height="1" width="3"></td>
					<td width="168" height="3"></td>
					<td width="192" rowSpan="3">
						<img height="1" width="3"></td>
				</tr>
				<tr>
					<td class="boxhdn" style="COLOR: white; BACKGROUND-REPEAT: no-repeat" height="19" bgcolor="#3f8bd7">
						&nbsp;Latest Models</td>
				</tr>
				<tr>
					<td width="168" align="center" valign="top">
						<table border="0" width="100%" id="table48" cellspacing="0" cellpadding="0">
							<tr>
								<td>
									<!-- Newly added on Jan 25th Second test as like RAMPAL-->
	<span id="spnLatest"  onmouseover="clearTimeout(idSpnTimeOut1);" style="filter: progid:DXImageTransform.Microsoft.GradientWipe(GradientSize=0.50,wipestyle=2,motion=reverse); width: 168px; height: 105px" onmouseout="idSpnTimeOut1 = setTimeout('applyEffect_Latest()',1000);">
					
					</span>									
																<!--End of newly added code-->
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</div>
	</body>
</HTML>