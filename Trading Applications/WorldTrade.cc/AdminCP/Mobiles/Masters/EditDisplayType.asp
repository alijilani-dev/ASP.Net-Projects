<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<% Dim rsMain, sql, i
Dim strCode
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if

strCode = Request.Form("hdCode")
	sql="select * from mDispType where DispTypeCode=" & strCode & "order by DispType"
	set rsMain=Server.CreateObject("Adodb.RecordSet")
	rsMain.Open sql,conn,3,2
	%>

<html>
<head>
<title>Manufacturer Information</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="../Global/MyStyle.CSS" rel="stylesheet" type="text/css">
<script language='javascript' src=../Global/valid.js></script>
</head>

<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" class="contact">
  <tr>
    <td>
    <form name="frmDispType" method="post" action="DispTypeInfo.asp" onSubmit="JavaScript:return FormSubmit()">
    <input type=hidden name=hdAction value="">
    <input type=hidden name=hdCode value="<%=strCode%>">
<script language=javascript>
 function FormSubmit()
{
	if (trim(document.frmDispType.txtDisplaytype.value)=="")
	{
		alert("Please enter Display type name");
		document.frmDispType.txtDisplaytype.focus();
		return false;
	}
	document.frmDispType.hdAction.value="Edit";
	document.frmDispType.action="DispTypeInfo.asp";
	document.frmDispType.submit();
}
</script>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0" class="Border2">
          <tr> 
            <td><table width="100%" border="0" cellpadding="2" cellspacing="0" class="contact">
                <tr> 
                  <td class="HeadingBackGroundLeft">Edit Display type</td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" class="LightBackground"><table width=100% border=0 align=Center class="Border">
                <tr align="left"> 
                  <td Colspan=2 Class=HeadingBackGroundLeft>Display type</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="32%" align=right class="contact">Display type</td>
                  <td width="68%"><input name=txtDisplaytype type=text class=Textbox id="txtDisplaytype" value="<%=rsMain("DispType")%>" maxlength="100"></td>
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
