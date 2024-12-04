<%@ Register TagPrefix="uc1" TagName="TradeMain" Src="Module/TradeMain.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PortalDefault.aspx.vb" Inherits="Trade.PortalDefault" validateRequest="false" %>
<HTML>
<HEAD>
<title>Phone Trade - UAE leading B2B Mobile Phone Trading Portal, Reach virtually to Europe, America, Asia &amp; Middleeast Trade Markets</title>
<!--<meta http-equiv="pragma" content="no-cache">-->
<meta http-equiv="Content-Language" content="en-us">
<meta name="robots" CONTENT="index, follow">
<meta name="description" content="We are a meeting point for the Mobile phone industry bringing together network operators, manufacturers, trading companies, distributors, wholesalers and retail chains from around the world.">
<meta name="keywords" content="dubai, uae, website, mobile, mobiles, trade, trading, phone, phones, buyers, sellers, skyphi, media city, euro trade, phone trade, phonetrade, cpu, cpu trade, smart, smart trade, mobile trade, cellular, cell, nokia, ericsson, motorola, samsung, trade in, trade out, dmc, gulf, middleeast, gcc">
<meta name="Copyright" content="www.skyphi.com">
<meta name="vs_defaultClientScript" content="JavaScript">
<meta http-equiv="refresh" content="720">
<script language="javascript" src="stm31.js"></script>
<script Language="javascript">

var ns6=document.getElementById&&!document.all

function restrictinput(maxlength,e,placeholder){
if (window.event&&event.srcElement.value.length>=maxlength)
return false
else if (e.target&&e.target==eval(placeholder)&&e.target.value.length>=maxlength){
var pressedkey=/[a-zA-Z0-9\.\,\/]/ //detect alphanumeric keys
if (pressedkey.test(String.fromCharCode(e.which)))
e.stopPropagation()
}
}

function countlimit(maxlength,e,placeholder){
var theform=eval(placeholder)
var lengthleft=maxlength-theform.value.length
var placeholderobj=document.all? document.all[placeholder] : document.getElementById(placeholder)
if (window.event||e.target&&e.target==eval(placeholder)){
if (lengthleft<0)
theform.value=theform.value.substring(0,maxlength)
placeholderobj.innerHTML=lengthleft
}
}

function displaylimit(thename, theid, thelimit){
var theform=theid!=""? document.getElementById(theid) : thename
var limit_text='<b class="normaltext">Characters left: <span class="normaltext" id="'+theform.toString()+'"> '+thelimit+'</span></b>'
if (document.all||ns6)
document.write(limit_text)
if (document.all){
eval(theform).onkeypress=function(){ return restrictinput(thelimit,event,theform)}
eval(theform).onkeyup=function(){ countlimit(thelimit,event,theform)}
}
else if (ns6){
document.body.addEventListener('keypress', function(event) { restrictinput(thelimit,event,theform) }, true); 
document.body.addEventListener('keyup', function(event) { countlimit(thelimit,event,theform) }, true); 
}
}

</script>

<script language="javascript">
		
function hidedetails(x)
{
	if( eval("TradeMainCtrl_TFViewCtrl_DGTradeFloorView__ctl" + (x+2) + "_Table_Detail").style.display=='')
	{
		eval("TradeMainCtrl_TFViewCtrl_DGTradeFloorView__ctl" + (x+2) + "_Table_Detail").style.display='none';
	}
	else
	{
		eval("TradeMainCtrl_TFViewCtrl_DGTradeFloorView__ctl" + (x+2) + "_Table_Detail").style.display='';
	}
}
		function HideTable()
		{
			tblTemp.visible = false
		}
		   function Show(blockid)
		   {	
				if(document.getElementById(blockid).style.visibility==null)
				{
					document.getElementById(blockid).style.display = 'none';
					document.getElementById(blockid).style.height =10; 
					document.getElementById(blockid).style.visibility='hidden';
				}
				if(document.getElementById(blockid).style.visibility=='hidden')
				{
					document.getElementById(blockid).style.display = 'block';
					document.getElementById(blockid).style.visibility='visible';
				}
				else
				{
		     		document.getElementById(blockid).style.display = 'none';
					document.getElementById(blockid).style.visibility='hidden';
				}								         
		   }
		
		  var prevElem=null;
 		  function DisplayApps(blockid)
		   {
		     var elem;
		     if (prevElem != null)
		       {
						prevElem.style.visibility='hidden';
						prevElem.style.display='none';
		       } 
			elem=document.getElementById(blockid);		     
		    elem.style.visibility='visible';
		    elem.style.width = "400px";
		    elem.style.height = "50px";
		    elem.style.display='block';
		    prevElem=elem;
		    window.event.cancelBubble=true;
		    elem.focus();   
		   }
		  
		  function HideApps()
		  {
		     if (prevElem != null)
		       {
						prevElem.style.visibility='hidden';
						prevElem.style.display='none';
		       } 
		  }
		  function ChangeColor()
		  {
		     if (prevElem != null)
		       {
						prevElem.style.visibility='hidden';
						prevElem.style.display='none';
		       } 
		  }
		  
 		  function ShowLocation(cmb,cid)
		   {
		     if (Form1.document.getElementById(cmb).toString() = 'None') 
		     {
				Form1.document.getElementById(cid).style.visibility ='hidden';
			}
			else
			{
				Form1.document.getElementById(cid).style.visibility ='visible';
			}
		   }
</script>

<script language="javascript">
var days = new Array('Sunday','Monday','Tuesday','Wednesday','Thursday','Friday','Saturday');
var months = new Array('January','February','March','April','May','June','July','August','September','October','November','December');

function showtimes()
{
disptime();
}

function y2k(number){return (number < 1000) ? number + 1900 : number;}

function getTimes(id)
{
		theDate = new Date();

		dateStr = theDate.toGMTString()

		dateStr = dateStr.substr(0,dateStr.length - 3)

		theDate.setTime(Date.parse(dateStr))

		theDate.setHours(theDate.getHours() + id)
		return theDate

}

function timevalue(id)
{
var timeNow = getTimes(id);
var hours = timeNow.getHours();
hours  = ((hours < 10) ? "0" : "") + hours;
var minutes = timeNow.getMinutes();
var seconds = timeNow.getSeconds();

var timeValue = "" + ((hours >12) ? hours -12 :hours)
//timeValue = ((timeValue <10)? "0":"") + timeValue
timeValue += ((minutes < 10) ? ":0" : ":") + minutes
timeValue += (hours >= 12) ? " PM" : " AM"

today = timeValue 
return today;
}

function disptime()
{
theDate = new Date();

//NewyorkTime time
if (!document.all&&!document.getElementById) 
return
ltime=document.getElementById?document.getElementById("NewyorkTime"):document.all.NewyorkTime 
today="NewYork:&nbsp;"+timevalue(-5)
ltime.innerHTML="<font style='font-family : verdana;font-size : 9px;font-weight : bold;color : #ffffff'>"+today+"</font>"

//London time
if (!document.all&&!document.getElementById)
return
ltime=document.getElementById?document.getElementById("LondonTime"):document.all.LondonTime
if (theDate.getMonth()>=3 && theDate.getMonth()<=9)
{today="London:&nbsp;"+timevalue(1)}
else {today="London:&nbsp;"+timevalue(0)}
ltime.innerHTML="<font style='font-family : verdana;font-size : 9px;font-weight : bold;color : #ffffff'>"+today+"</font>"

//UAE time
if (!document.all&&!document.getElementById)
return
ltime=document.getElementById?document.getElementById("UaeTime"):document.all.UaeTime
today="Dubai:&nbsp;"+timevalue(4)
ltime.innerHTML="<font style='font-family : verdana;font-size : 9px;font-weight : bold;color : #ffffff'>"+today+"</font>"

//Hongkong time
if (!document.all&&!document.getElementById)
return
ltime=document.getElementById?document.getElementById("HongKongTime"):document.all.HongKongTime
today="HongKong:&nbsp;"+timevalue(8)
ltime.innerHTML="<font style='font-family : verdana;font-size : 9px;font-weight : bold;color : #ffffff'>"+today+"</font>"


//Paris time
if (!document.all&&!document.getElementById)
return
ltime=document.getElementById?document.getElementById("Paris"):document.all.Paris
today="Paris:&nbsp;"+timevalue(1)
ltime.innerHTML="<font style='font-family : verdana;font-size : 9px;font-weight : bold;color : #ffffff'>"+today+"</font>"

//Sydney time
if (!document.all&&!document.getElementById)
return
ltime=document.getElementById?document.getElementById("Aust"):document.all.Aust
today="Sydney:&nbsp;"+timevalue(11)
ltime.innerHTML="<font style='font-family : verdana;font-size : 9px;font-weight : bold;color : #ffffff'>"+today+"</font>"

setTimeout("disptime()",1000)
}
</script>

<script language="javascript">
<!--
function FP_preloadImgs() {//v1.0
 var d=document,a=arguments; if(!d.FP_imgs) d.FP_imgs=new Array();
 for(var i=0; i<a.length; i++) { d.FP_imgs[i]=new Image; d.FP_imgs[i].src=a[i]; }
}

function FP_swapImg() {//v1.0
 var doc=document,args=arguments,elm,n; doc.$imgSwaps=new Array(); for(n=2; n<args.length;
 n+=2) { elm=FP_getObjectByID(args[n]); if(elm) { doc.$imgSwaps[doc.$imgSwaps.length]=elm;
 elm.$src=elm.src; elm.src=args[n+1]; } }
}

function FP_getObjectByID(id,o) {//v1.0
 var c,el,els,f,m,n; if(!o)o=document; if(o.getElementById) el=o.getElementById(id);
 else if(o.layers) c=o.layers; else if(o.all) el=o.all[id]; if(el) return el;
 if(o.id==id || o.name==id) return o; if(o.childNodes) c=o.childNodes; if(c)
 for(n=0; n<c.length; n++) { el=FP_getObjectByID(id,c[n]); if(el) return el; }
 f=o.forms; if(f) for(n=0; n<f.length; n++) { els=f[n].elements;
 for(m=0; m<els.length; m++){ el=FP_getObjectByID(id,els[n]); if(el) return el; } }
 return null;
}

function FP_swapImgRestore() {//v1.0
 var doc=document,i; if(doc.$imgSwaps) { for(i=0;i<doc.$imgSwaps.length;i++) {
  var elm=doc.$imgSwaps[i]; if(elm) { elm.src=elm.$src; elm.$src=null; } } 
  doc.$imgSwaps=null; }
  
}


function newImage(arg) {
	if (document.images) {
		rslt = new Image();
		rslt.src = arg;
		return rslt;
	}
}
ImageArray = new Array;
var preloadFlag = false;
function preloadImages() {
	if (document.images) {

ImageArray[ImageArray.length++] = newImage(/*URL*/'images/top_links_changedcpu_trade.jpg');		
ImageArray[ImageArray.length++] = newImage(/*URL*/'images/top_links_changedcpu_tradov.jpg');		

ImageArray[ImageArray.length++] = newImage(/*URL*/'images/top_links_changedsmart_trad.jpg');		
ImageArray[ImageArray.length++] = newImage(/*URL*/'images/top_links_changedsmart_trov.jpg');		

		preloadFlag = true;
	}
}
function changeImages() {
	if (document.images && (preloadFlag == true)) {
		for (var i=0; i<changeImages.arguments.length; i+=2) {
			document[changeImages.arguments[i]].src = changeImages.arguments[i+1];
		}
	}
}
// -->
</script>

<style type="text/css">TR.row:hover { CURSOR: hand; BACKGROUND-COLOR: #99ccff }
	TR.over TD { CURSOR: hand; BACKGROUND-COLOR: #99ccff }
</style>
	</HEAD>
	<body onLoad="showtimes(); FP_preloadImgs(/*url*/'images/layout_mainimage2ov.jpg', /*url*/'images/layout_mainimage3ov.jpg', /*url*/'images/layout_mainimage4ov.jpg', /*url*/'images/layout_mainimage5ov.jpg', /*url*/'images/layout_mainimage6ov.jpg', /*url*/'images/layout_mainimage7ov.jpg', /*url*/'images/layout_mainimage8ov.jpg', /*url*/'images/layout_mainimage9ov.jpg', /*url*/'images/layout_mainimage10ov.jpg', /*url*/'images/layout_maincpu_tradeov.jpg', /*url*/'images/layout_mainsmart_tradeov.jpg', /*url*/'images/layout_mainimage1ov.jpg', /*url*/'images/layout_mainimageov.jpg'); preloadImages()" MS_POSITIONING="GridLayout" leftMargin="0" topMargin="0" rightmargin="0" bottommargin="0" bgcolor="#FFFFFF">
		<FORM id="Form1" method="post" runat="server">
			<uc1:TradeMain id="TradeMainCtrl" runat="server"></uc1:TradeMain>
		</FORM>
		</body>
		<div id="dhtmltooltip" class="normalText" align="left"></div>
<script type="text/javascript">

var offsetxpoint=-60 //Customize x offset of tooltip
var offsetypoint=20 //Customize y offset of tooltip
var ie=document.all
var ns6=document.getElementById && !document.all
var enabletip=false
if (ie||ns6)
var tipobj=document.all? document.all["dhtmltooltip"] : document.getElementById? document.getElementById("dhtmltooltip") : ""

function ietruebody(){
return (document.compatMode && document.compatMode!="BackCompat")? document.documentElement : document.body
}

function ddrivetip(thetext, thecolor, thewidth){
if (ns6||ie){
if (typeof thewidth!="undefined") tipobj.style.width=thewidth+"px"
if (typeof thecolor!="undefined" && thecolor!="") tipobj.style.backgroundColor=thecolor
tipobj.innerHTML=thetext
enabletip=true
return false
}
}

function positiontip(e){
if (enabletip){
var curX=(ns6)?e.pageX : event.clientX+ietruebody().scrollLeft;
var curY=(ns6)?e.pageY : event.clientY+ietruebody().scrollTop;
//Find out how close the mouse is to the corner of the window
var rightedge=ie&&!window.opera? ietruebody().clientWidth-event.clientX-offsetxpoint : window.innerWidth-e.clientX-offsetxpoint-20
var bottomedge=ie&&!window.opera? ietruebody().clientHeight-event.clientY-offsetypoint : window.innerHeight-e.clientY-offsetypoint-20

var leftedge=(offsetxpoint<0)? offsetxpoint*(-1) : -1000

//if the horizontal distance isn't enough to accomodate the width of the context menu
if (rightedge<tipobj.offsetWidth)
//move the horizontal position of the menu to the left by it's width
tipobj.style.left=ie? ietruebody().scrollLeft+event.clientX-tipobj.offsetWidth+"px" : window.pageXOffset+e.clientX-tipobj.offsetWidth+"px"
else if (curX<leftedge)
tipobj.style.left="5px"
else
//position the horizontal position of the menu where the mouse is positioned
tipobj.style.left=curX+offsetxpoint+"px"

//same concept with the vertical position
if (bottomedge<tipobj.offsetHeight)
tipobj.style.top=ie? ietruebody().scrollTop+event.clientY-tipobj.offsetHeight-offsetypoint+"px" : window.pageYOffset+e.clientY-tipobj.offsetHeight-offsetypoint+"px"
else
tipobj.style.top=curY+offsetypoint+"px"
tipobj.style.visibility="visible"
}
}

function hideddrivetip(){
if (ns6||ie){
enabletip=false
tipobj.style.visibility="hidden"
tipobj.style.left="-1000px"
tipobj.style.backgroundColor=''
tipobj.style.width=''
}
}

document.onmousemove=positiontip

</script>
</HTML>
