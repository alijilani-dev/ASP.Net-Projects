<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Offer.aspx.vb" Inherits="Trade.Offer" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Offer</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="Styles.css">
		<SCRIPT type="text/javascript">
var idSpnTimeOut = 0;
var arr_Models = new Array();
/*arr_Models[0] = {BGclr:"white", manuf:"NOKIA", model:"8800", gif:"Thumb/m_160-70.jpg", links:"65"};
arr_Models[1] = {BGclr:"#ffe2b4", manuf:"NOKIA", model:"6230i", gif:"Thumb/m_6111small.jpg", links:"56"};
arr_Models[2] = {BGclr:"white", manuf:"MOTOROLA", model:"V3", gif:"Thumb/m_6270small.jpg", links:"15"};
arr_Models[3] = {BGclr:"#ffe2b4", manuf:"SAMSUNG", model:"D500", gif:"Thumb/m_7370-70.jpg", links:"68"};
*/
<%=strPhotos%>
function getItems(objTop15) {
  if (objTop15 == null) return "";
var pickId = "<table border=0 onMouseOver=\"clearTimeout(idSpnTimeOut);\" style=\"background-color:" + objTop15.BGclr + "\" width=98% height=90 CELLSPACING=0 CELLPADDING=0 _background=\"../images/bg_cell.gif\">" +
"<tr><td align=\"left\" style=\"background-color:" + objTop15.BGclr + "\" class=\"normalText\"><a href=\"../PortalDefault.aspx?Main_Links_ID=4&MobileSrNo="+objTop15.links+"\" target=\"_top\"><img style=\"cursor:hand\" src=\"../Images/"+objTop15.gif+"\" border=0>&nbsp;" + objTop15.manuf  + " " + objTop15.model + "</a></td></tr>" +
"<tr><td align=\"left\" style=\"background-color:" + objTop15.BGclr + "\" class=\"normalText\">Quantity: " + objTop15.Qty + "</td></tr>" +
"<tr><td height=25>&nbsp;</td></tr>" + "</table>";
	return pickId
}


var currArrID = 0;
function applyEffect() {
	spnTrans.filters[0].apply();
	spnTrans.innerHTML = getItems(arr_Models[currArrID++]); //+ " " + getItems(arr_Models[currArrID++]) ;
  spnTrans.filters[0].play(duration=2);
	if (currArrID >= arr_Models.length) currArrID = 0; 
	clearTimeout(idSpnTimeOut);
	idSpnTimeOut = setTimeout('applyEffect()',3000);
}

		</SCRIPT>
	</HEAD>
	<body MS_POSITIONING="GridLayout" onload="clearTimeout(idSpnTimeOut);applyEffect();">
		<table class="normaltext" cellSpacing="0" cellPadding="0" align="center" border="0">
			<tr>
				<td>
					<!--
				Reomved the codes on DIV tag from this place on 25th jan 
				And placed on the .Vb file with comments
				
				-->
					<!-- Newly added on Jan 25th Second test as like RAMPAL-->
					<span id="spnTrans"  onmouseover="clearTimeout(idSpnTimeOut);" style="filter: progid:DXImageTransform.Microsoft.GradientWipe(GradientSize=0.50,wipestyle=0,motion=reverse); width: 193px; height: 150px" onmouseout="idSpnTimeOut = setTimeout('applyEffect()',1000);">
					
					</span>
					<!--End of newly added code-->
				</td>
			</tr>
		</table>
	</body>
</HTML>
