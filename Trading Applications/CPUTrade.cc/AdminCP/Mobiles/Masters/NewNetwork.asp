<%
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if

%>
<html>
<head>
<title>NetworkType Information</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="../Global/MyStyle.CSS" rel="stylesheet" type="text/css">
<script language='javascript' src=../Global/valid.js></script>
</head>

<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" class="contact">
  <tr>
    <td>    
	<form name="frmNetwork" method="post" action="NetworkTypeInfo.asp" onSubmit="JavaScript:return FormSubmit()">
    <input type=hidden name=hdAction value="">
<script language=javascript>
 function FormSubmit()
{
	if (trim(document.frmNetwork.txtNetwork.value)=="")
	{
		alert("Please enter Network type name");
		document.frmNetwork.txtNetwork.focus();
		return false;
	}
	alert("1");
	document.frmNetwork.hdAction.value="Add";
	document.frmNetwork.action="NetworkTypeInfo.asp";
	document.frmNetwork.submit();
}
</script>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0" class="Border2">
          <tr> 
            <td><table width="100%" border="0" cellpadding="2" cellspacing="0" class="contact">
                <tr> 
                  <td class="HeadingBackGroundLeft">Add new network type</td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" class="LightBackground"><table width=100% border=0 align=Center class="Border">
                <tr align="left"> 
                  <td Colspan=2 Class=HeadingBackGroundLeft>Network</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="32%" align=right class="contact">Network info.</td>
                  <td width="68%"><input name=txtNetwork type=text class=Textbox id="txtNetwork" value="" maxlength="100"></td>
                </tr>
                <tr height=2> 
                  <td colspan="2" align=right class="HeadingWithBackGround"></td>
                </tr>
                <tr> 
                  <td class="LightBackground"></td>
                  <td class="LightBackground"> <input type=Submit name=btnOk value="     Ok      " class=Buttons> 
                    <input type=Reset name=btnCancel value=" Cancel " class=Buttons onClick='javascript:history.back();'> 
                  </td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
        <br>
      </form>
      
    </td>
  </tr>
</table>

</body>
</html>
