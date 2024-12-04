<%

strHTML="<HTML><HEAD><BODY>"
strHTML=strHTML & "<p><font face=""Verdana, Arial, Helvetica, sans-serif"">this email has been submitted from helpmanzil site by " & lcase(Request.form("name")) & "</font></p>"
strHTML=strHTML & "<table width=""550""  border=""1"" cellpadding=""0"" cellspacing=""4"">"
strHTML=strHTML & "<tr align=""center""><td height=""30"" colspan=""3"" bgcolor=""#F3901D""> <strong><font color=""#FFFFFF"" size=""2"" face=""Verdana, Arial, Helvetica, sans-serif"">volunteer datails</font></strong></td></tr>"		
strHTML=strHTML & "  <tr>     <td height=""15"" width=""270"">name</td>    <td height=""15""> :</td><td> <font face=""Verdana, Arial, Helvetica, sans-serif"">"
strHTML=strHTML & lcase(Request.form("name")) & "</font>     </td> </tr>"

strHTML=strHTML & "<tr> <td height=""15"" width=""270"">work phone </td><td height=""15""> :</td>"
strHTML=strHTML & "<td height=""15""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("workphone"))& "</font> </td>  </tr>"

strHTML=strHTML & "<tr><td height=""15"" width=""270"">cell phone</td><td height=""15""> :</td> "
strHTML=strHTML & "    <td height=""15""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("cellphone"))& "</font> </td></tr> "

strHTML=strHTML & " <tr><td height=""15"" width=""270"">email</td><td height=""15""> :</td> "
strHTML=strHTML & " <td height=""15""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("email")) & "</font></td></tr>  "

strHTML=strHTML & " <tr><td height=""15"" width=""270"">occupation (or retired from/ student of) </td><td height=""15""> :</td>"
strHTML=strHTML & "    <td height=""15""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("occupation"))& "  </font></td></tr> "


strHTML=strHTML & "  <tr><td height=""15"" width=""270"">name of business/school </td><td height=""15""> :</td> "
strHTML=strHTML & "   <td height=""15""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("nameBusiness"))& "</font> </td></tr>"
'strHTML=strHTML & "  <tr> <td height=""15"" width=""270"">Are you a member of manzil?</td> <td height=""15""> :</td>"
'strHTML=strHTML & "    <td height=""15""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & Request.form("mebmermanzil")& "</font> </td></tr>"

strHTML=strHTML & "  <tr> <td width=""270"">how did you hear about manzil? </td><td> :</td>"
strHTML=strHTML & "    <td> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(replace(Request.form("comments"),vbcrlf,"<Br>")) & "</font> </td></tr>"

strHTML=strHTML & "   <tr><td height=""15"" colspan=3>&nbsp;</td></tr>"

strHTML=strHTML & "  <tr> <td width=""270"">do you have one on one experience dealing with challenged individuals? </td><td> :</td>"
strHTML=strHTML & "    <td> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("vexperience"))& "</font> </td></tr>"

strHTML=strHTML & "  <tr> <td width=""270"">with which organizations have you volunteered? </td><td> :</td>"
strHTML=strHTML & "  <td> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("whatorganizationvoluntered"))& "</font> </td></tr>"

strHTML=strHTML & "  <tr> <td width=""270"">what skills, interests or hobbies would you like to share with manzil? </td><td> :</td>"
strHTML=strHTML & "    <td> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("urskills"))& "</font> </td></tr>"

strHTML=strHTML & "  <tr> <td width=""270"">is there a particular type of work that you would like to do? </td><td> :</td>"
strHTML=strHTML & "    <td> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("particularwork"))& "</font> </td></tr>"

strHTML=strHTML & "  <tr> <td width=""270"">is there a particular type of work that you would not like to do? </td><td> :</td>"
strHTML=strHTML & "    <td> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("workdontwanttodo"))& "</font> </td></tr>"

strHTML=strHTML & "   <tr> <td width=""270"">are you fluent in any language other than english? please list </td><td> :</td>"
strHTML=strHTML & "     <td> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("languages"))& "</font> </td></tr>"
strHTML=strHTML & "   <tr> <td height=""15"" colspan=""3"">&nbsp;</td>  </tr>"

strHTML=strHTML & "   <tr> <td height=""30"" colspan=""3"" align=""center"" bgcolor=""#F4901E""> "
strHTML=strHTML & "   <strong><font color=""#FFFFFF"" size=""2"" face=""Verdana, Arial, Helvetica, sans-serif""><strong>logistics</strong></font></strong></td></tr>"


	strHTML=strHTML & "   <tr> <td height=""15"" width=""270"">do you expect to be nominally paid for your voluntary work? </td><td height=""15"">:</td>"
strHTML=strHTML & "     <td height=""15""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("ocassional_jobs"))& "</font> </td></tr>"

strHTML=strHTML & "   <tr> <td height=""15"" width=""270"">which days of the week can you volunteer on?</td><td height=""15"">:</td>"
strHTML=strHTML & "     <td height=""15""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("available")) & "</font> </td></tr>"

strHTML=strHTML & "  <tr> <td height=""15"" width=""270"">what time period of the day can you volunteer? (eg 4 to 7 pm)</td><td height=""15"">:</td>"
strHTML=strHTML & "   <td height=""15""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("weekdays")) & "</font> </td></tr>"

'strHTML=strHTML & "<tr> <td height=""15"" width=""270"">Weekdays</td><td height=""15"">:</td>"
'strHTML=strHTML & "   <td height=""15""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & Request.form("weekdays")& "</font> </td></tr>"
strHTML=strHTML & " <tr> <td height=""15"" width=""270"">do you have any significant medical condition which may affect your volunteering activities?</td> <td height=""15"">:</td>"
strHTML=strHTML & "   <td height=""15""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("weekends"))& "</font> </td></tr>"
strHTML=strHTML & "   <tr><td height=""15"" colspan=3>&nbsp;</td></tr>"

strHTML=strHTML & "  <tr> <td height=""30"" colspan=""3"" align=""center"" bgcolor=""#F4901E""> "
strHTML=strHTML & "  <font color=""#FFFFFF"" size=""2"" face=""Verdana, Arial, Helvetica, sans-serif""><strong>emergency contact information</strong></font></td></tr>"
strHTML=strHTML & "  <tr> <td height=""15"" width=""270"">name</td><td height=""15"">:</td>"
strHTML=strHTML & "   <td height=""15"" align=""left""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("emergency_contact_name")) & "</font>  </td></tr>"

strHTML=strHTML & "  <tr> <td height=""15"" width=""270"">address</td><td height=""15"">:</td>"
strHTML=strHTML & "    <td height=""15"" align=""left""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("emergency_contact_address")) & "</font> </td></tr>"

strHTML=strHTML & "  <tr> <td height=""15"" width=""270"">relationship</td><td height=""15"">:</td>"
strHTML=strHTML & "   <td height=""15"" align=""left""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("emergency_contact_relationship")) & "</font> </td>  </tr>"

strHTML=strHTML & "  <tr> <td height=""15"" width=""270"">mobile phone</td><td height=""15"">:</td>"
strHTML=strHTML & "    <td height=""15"" align=""left""> <font face=""Verdana, Arial, Helvetica, sans-serif"">" & lcase(Request.form("emergency_contact_phone")) & "</font> </td></tr></table>"
strHTML=strHTML & "</body></html>"


Const cdoSendUsingPickup = 1 'Send message using the local SMTP service pickup directory. 
Const cdoSendUsingPort = 2 'Send the message using the network (SMTP over the network). 

Const cdoAnonymous = 0 'Do not authenticate
Const cdoBasic = 1 'basic (clear-text) authentication
Const cdoNTLM = 2 'NTLM

Set objMessage = CreateObject("CDO.Message") 
objMessage.Subject = "Volunteer Information From Manzil - teting" 
objMessage.From = "basheer@ireuae.com" 
objMessage.To = "basheer@skyphi.com" 
objMessage.HTMLBody = CStr("" & strHTML)

'==This section provides the configuration information for the remote SMTP server.

objMessage.Configuration.Fields.Item _
("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2 

'Name or IP of Remote SMTP Server
objMessage.Configuration.Fields.Item _
("http://schemas.microsoft.com/cdo/configuration/smtpserver") = "10.4.29.4"

'Type of authentication, NONE, Basic (Base64 encoded), NTLM
objMessage.Configuration.Fields.Item _
("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate") = cdoBasic

'Your UserID on the SMTP server
objMessage.Configuration.Fields.Item _
("http://schemas.microsoft.com/cdo/configuration/sendusername") = "admin50534137@helpmanzil.com"

'Your password on the SMTP server
objMessage.Configuration.Fields.Item _
("http://schemas.microsoft.com/cdo/configuration/sendpassword") = "admin"

'Server port (typically 25)
objMessage.Configuration.Fields.Item _
("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25 

'Use SSL for the connection (False or True)
objMessage.Configuration.Fields.Item _
("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = False

objMessage.Configuration.Fields.Update

'==End remote SMTP server configuration section==

objMessage.Send

	 
	 
%>

<html>
<head>
<TITLE>Help Manzil - a non-profit centre for individuals with challenges. located in sharjah, uae, gulf - helpmanzil.com</TITLE>
<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="Content-Language" content="en-us">
<meta name="robots" CONTENT="index, follow">
<META content=description content="a non-profit centre for individuals with challenges. manzil provides a highly professional care-giving environment for individuals with special needs to nurture their potential develop the requisite self help, social and vocational skills that are required to function in society.">
<META content=keywords content="dubai, uae, website, manzil, help, manzil, helpmanzil, help manzil, sharjah, special needs, disability, handicapped, centre, school, non-profit, challenged, charity, mental, difficulties, illness, skyphi, gulf, middleeast, gcc">
<LINK href="styles.css" type=text/css rel=stylesheet>
<META content=Copyright content="www.skyphi.com" ><meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<script language="JavaScript" type="text/JavaScript">
<!--
function mmLoadMenus() {
  if (window.mm_menu_0820174220_0) return;
    window.mm_menu_0820174220_0 = new Menu("root",112,16,"Verdana, Arial, Helvetica, sans-serif",10,"#FFFFFF","#FFFFFF","#FF9933","#996600","left","middle",3,0,1000,-5,7,true,true,true,0,true,true);
  mm_menu_0820174220_0.addMenuItem("hospital","location='aboutus.htm'");
  mm_menu_0820174220_0.addMenuItem("therapy centres","location='aboutus.htm'");
  mm_menu_0820174220_0.addMenuItem("clinics","location='aboutus.htm'");
  mm_menu_0820174220_0.addMenuItem("24 hr pharm","location='aboutus.htm'");
   mm_menu_0820174220_0.hideOnMouseOut=true;
   mm_menu_0820174220_0.bgColor='#999999';
   mm_menu_0820174220_0.menuBorder=1;
   mm_menu_0820174220_0.menuLiteBgColor='#FFFFFF';
   mm_menu_0820174220_0.menuBorderBgColor='#999999';

    
      
      window.mm_menu_0820174357_0 = new Menu("root",145,16,"Verdana, Arial, Helvetica, sans-serif",10,"#FFFFFF","#FFFFFF","#FF9933","#996600","left","middle",3,0,1000,-5,7,true,true,true,0,true,true);
  mm_menu_0820174357_0.addMenuItem("hospitals","location='hospital.htm'");
  mm_menu_0820174357_0.addMenuItem("clinics","location='clinics.htm'");
  mm_menu_0820174357_0.addMenuItem("doctors&nbsp;on&nbsp;our&nbsp;panel","location='doc_panel.htm'");
  mm_menu_0820174357_0.addMenuItem("pharmacies","location='pharm.htm'");
   mm_menu_0820174357_0.hideOnMouseOut=true;
   mm_menu_0820174357_0.bgColor='#555555';
   mm_menu_0820174357_0.menuBorder=1;
   mm_menu_0820174357_0.menuLiteBgColor='#FFFFFF';
   mm_menu_0820174357_0.menuBorderBgColor='#777777';

mm_menu_0820174357_0.writeMenus();
} // mmLoadMenus()
<!--
function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
}

//-->

function MM_swapImgRestore() { //v3.0
  var i,x,a=document.MM_sr; for(i=0;a&&i<a.length&&(x=a[i])&&x.oSrc;i++) x.src=x.oSrc;
}

function MM_findObj(n, d) { //v4.01
  var p,i,x;  if(!d) d=document; if((p=n.indexOf("?"))>0&&parent.frames.length) {
    d=parent.frames[n.substring(p+1)].document; n=n.substring(0,p);}
  if(!(x=d[n])&&d.all) x=d.all[n]; for (i=0;!x&&i<d.forms.length;i++) x=d.forms[i][n];
  for(i=0;!x&&d.layers&&i<d.layers.length;i++) x=MM_findObj(n,d.layers[i].document);
  if(!x && d.getElementById) x=d.getElementById(n); return x;
}

function MM_swapImage() { //v3.0
  var i,j=0,x,a=MM_swapImage.arguments; document.MM_sr=new Array; for(i=0;i<(a.length-2);i+=3)
   if ((x=MM_findObj(a[i]))!=null){document.MM_sr[j++]=x; if(!x.oSrc) x.oSrc=x.src; x.src=a[i+2];}
}
//-->
</script>
<script language="JavaScript" src="mm_menu.js"></script>
<style type="text/css">
<!--
.style2 {color: #F4901E}
-->
</style>
</head>

<body bgcolor="#003300" leftmargin="0" topmargin="0" marginwidth="0" marginheight="0" onLoad="MM_preloadImages('images/home_rollover1_02.jpg','images/home_rollover1_03.jpg','images/home_rollover1_04.jpg','images/home_rollover1_05.jpg','images/home_rollover1_06.jpg','images/home_rollover1_07.jpg','images/home_rollover1_08.jpg','images/home_rollover1_09.jpg','images/home_rollover1_10.jpg','images/home_rollover1_11.jpg','images/home_rollover1_13.jpg','images/home_rollover1_14.jpg','images/home_rollover1_15.jpg','images/home_rollover1_16.jpg','images/home_rollover1_01.jpg','images/home_rollover1_12.jpg','images/home_rollover1_18.jpg')">
<script language="JavaScript1.2">mmLoadMenus();</script>
<table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr> 
    <td align="left" valign="top" bgcolor="#003300"> 
      <table width="780" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="262626">
        <tr> 
          <td width="780" align="left" valign="top" bgcolor="#FFFFFF"><table width="780" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr> 
                <td><object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,29,0" width="780" height="126">
                    <param name="movie" value="images/swfs/banner anim2.swf">
                    <param name="quality" value="high">
                    <embed src="images/swfs/banner anim2.swf" quality="high" pluginspage="http://www.macromedia.com/go/getflashplayer" type="application/x-shockwave-flash" width="780" height="126"></embed></object></td>
              </tr>
            </table>
            <table width="780" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr> 
                <td width="1009" height="19"><table width="780" border="0" align="center" cellpadding="0" cellspacing="0">
                    <tr> 
                      <td width="20" height="5" valign="top"><img src="images/ma_leftheight5.jpg" width="20" height="5"></td>
                      <td width="740" align="left" valign="top" bgcolor="F3901D" height="5"></td>
                      <td width="20" align="right" valign="top"><img src="images/ma_leftheight5.jpg" width="20" height="5"></td>
                    </tr>
                  </table></td>
              </tr>
            </table>
            <table width="780" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr> 
                <td width="20" height="321" valign="top" bgcolor="#B49F68">&nbsp;</td>
                <td width="150" align="left" valign="top" bgcolor="#B49F68"><table id="Table_01" width="150" border="0" cellpadding="0" cellspacing="0">
                    <tr> 
                      <td> <a href="index.htm"><img src="images/homepagelinks1_01.jpg" alt="" name="Image16" width="150" height="20" border="0" id="Image16" onMouseOver="MM_swapImage('Image16','','images/home_rollover1_01.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      <td> <a href="aboutus.htm"><img src="images/homepagelinks1_02.jpg" alt="" name="Image1" width="150" height="20" border="0" id="Image1" onMouseOver="MM_swapImage('Image1','','images/home_rollover1_02.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      <td> <a href="royalpatron.htm"><img src="images/homepagelinks1_03.jpg" alt="" name="Image2" width="150" height="20" border="0" id="Image2" onMouseOver="MM_swapImage('Image2','','images/home_rollover1_03.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      <td> <a href="boardirectors.htm"><img src="images/homepagelinks1_04.jpg" alt="" name="Image3" width="150" height="20" border="0" id="Image3" onMouseOver="MM_swapImage('Image3','','images/home_rollover1_04.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      <td> <a href="manzilstaff.htm"><img src="images/homepagelinks1_05.jpg" alt="" name="Image4" width="150" height="20" border="0" id="Image4" onMouseOver="MM_swapImage('Image4','','images/home_rollover1_05.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      <td> <a href="programmes.htm"><img src="images/homepagelinks1_06.jpg" alt="" name="Image5" width="150" height="20" border="0" id="Image5" onMouseOver="MM_swapImage('Image5','','images/home_rollover1_06.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      <td> <a href="futureprog.htm"><img src="images/homepagelinks1_07.jpg" alt="" name="Image6" width="150" height="20" border="0" id="Image6" onMouseOver="MM_swapImage('Image6','','images/home_rollover1_07.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      <td> <a href="dis_research.htm"><img src="images/homepagelinks1_08.jpg" alt="" name="Image7" width="150" height="20" border="0" id="Image7" onMouseOver="MM_swapImage('Image7','','images/home_rollover1_08.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      <td> <a href="intl_affil.htm"><img src="images/homepagelinks1_09.jpg" alt="" name="Image8" width="150" height="20" border="0" id="Image8" onMouseOver="MM_swapImage('Image8','','images/home_rollover1_09.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      <td> <img src="images/homepagelinks1_10.jpg" alt="" name="Image9" width="150" height="20" border="0" id="Image9" onMouseOver="MM_swapImage('Image9','','images/home_rollover1_10.jpg',1);MM_showMenu(window.mm_menu_0820174357_0,150,0,null,'Image9')" onMouseOut="MM_swapImgRestore();MM_startTimeout();"></td>
                    </tr>
                    <tr> 
                      <td> <a href="event_cal.htm"><img src="images/homepagelinks1_11.jpg" alt="" name="Image10" width="150" height="20" border="0" id="Image10" onMouseOver="MM_swapImage('Image10','','images/home_rollover1_11.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      <td> <a href="pic_book.htm"><img src="images/homepagelinks1_12.jpg" alt="" name="Image11" width="150" height="20" border="0" id="Image11" onMouseOver="MM_swapImage('Image11','','images/home_rollover1_12.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      <td> <a href="corporate.htm"><img src="images/homepagelinks1_13.jpg" alt="" name="Image12" width="150" height="20" border="0" id="Image12" onMouseOver="MM_swapImage('Image12','','images/home_rollover1_13.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      <td> <a href="press_relase.htm"><img src="images/homepagelinks1_14.jpg" alt="" name="Image13" width="150" height="21" border="0" id="Image13" onMouseOver="MM_swapImage('Image13','','images/home_rollover1_14.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      <td> <a href="contact.htm"><img src="images/homepagelinks1_15.jpg" alt="" name="Image14" width="150" height="19" border="0" id="Image14" onMouseOver="MM_swapImage('Image14','','images/home_rollover1_15.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr> 
                      
                    </tr>
                    <tr> 
                      <td><a href="locationmap.htm"><img src="images/homepagelinks1_18.jpg" alt="" name="Image141" width="150" height="21" border="0" id="Image14" onMouseOver="MM_swapImage('Image141','','images/home_rollover1_18.jpg',1)" onMouseOut="MM_swapImgRestore()"></a></td>
                    </tr>
                    <tr>
                      <td><img src="images/homepagelinks1_17.jpg" width="150" height="21" alt=""></td>
                    </tr>
                  </table></td>
                <td width="7" bgcolor="#B49F68">&nbsp;</td>
                <td width="585" align="left" valign="top" bgcolor="#B49F68"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr> 
                      <td height="284" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr bgcolor="#B49F68"> 
                            <td width="67%" height="25">&nbsp;</td>
                            <td width="36%" align="left" class="heading">how 
                              to volunteer ::.</td>
                          </tr>
                        </table>
                        
                        <table width="100%"  border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td height="67" valign="top" class="txtpic"><br>
							<br>
                              &nbsp; <p align="center">thanks for applying as 
                                a manzil volunteer
                            </td>
                          </tr>
                        </table>                        
                        </td>
                    </tr>
                  </table>
                </td>
                <td width="15" align="left" valign="top" bgcolor="#B49F68">&nbsp;</td>
              </tr>
            </table>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr> 
                <td height="5"></td>
              </tr>
            </table>
            <table width="780" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr> 
                <td width="20" height="5" valign="top"><img src="images/ma_leftheight5.jpg" width="20" height="5"></td>
                <td width="740" align="left" valign="top" bgcolor="F3901D" height="5"></td>
                <td width="20" align="right" valign="top"><img src="images/ma_leftheight5.jpg" width="20" height="5"></td>
              </tr>
            </table>
            <table width="780" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr> 
                <td width="20" height="5" valign="top"><img src="images/ma_leftheight5.jpg" width="20" height="5"></td>
                <td width="740" align="left" valign="top" height="5"></td>
                <td width="20" align="right" valign="top"><img src="images/ma_leftheight5.jpg" width="20" height="5"></td>
              </tr>
            </table>
            <table width="780" border="0" align="center" cellpadding="0" cellspacing="0">
              <tr> 
                <td width="20" height="70" valign="top"><img src="images/ma_leftheight5.jpg" width="20" height="5"></td>
                <td width="740" align="left" valign="top" height="70"><img src="images/bottomlink.jpg" width="740" height="71" border="0" usemap="#Map"></td>
                <td width="20" align="right" valign="top"><img src="images/ma_leftheight5.jpg" width="20" height="5"></td>
              </tr>
            </table>
            <map name="Map">
              <area shape="rect" coords="50,23,203,45" href="how_volunteer.htm">
              <area shape="rect" coords="286,23,481,49" href="sfs_group.htm">
              <area shape="rect" coords="598,25,663,44" href="donate.htm">
            </map>
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr> 
                <td width="35%" height="22">&nbsp;</td>
                <td width="33%"><table width="154" border="0" align="center" cellpadding="0" cellspacing="0">
                          <tr> 
                            <td width="154" valign="middle">
							<p align="center">
							<a href="http://www.skyphi.com" target="_blank">
							<img border="0" src="images/logo_powered.jpg" width="66" height="34"></a></td>
                          </tr>
                        </table></td>
                <td width="32%">&nbsp;</td>
              </tr>
            </table>          </td>
        </tr>
    </table></td>
  </tr>
</table>
</body>
</html>
