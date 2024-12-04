<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<% Dim Rsmain, sql, i
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if

Dim strCode
strCode = Request.Form("hdCode")
	sql="select * from mManufacturer where ManufCode=" & strCode & "order by ManufName"
	set Rsmain=Server.CreateObject("Adodb.RecordSet")
	Rsmain.Open sql,conn,3,2
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
    <form name="frmManuf" method="post" encType="multipart/form-data" action="addManuf.asp" onSubmit="JavaScript:return FormSubmit()">
    <input type=hidden name=hdAction value="">
	    <input type=hidden name=hdCode value="<%=strCode%>">
<script language=javascript>
 function FormSubmit()
{
	if (trim(document.frmManuf.imgFile.value)=="")
	{
		alert("Please select logo");
		document.frmManuf.imgFile.focus();
		return false;
	}
		document.frmManuf.hdAction.value="Add";
		document.frmManuf.action="UpdateImage.asp";
		document.frmManuf.submit();
}
</script>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0" class="Border2">
          <tr> 
            <td><table width="100%" border="0" cellpadding="2" cellspacing="0" class="contact">
                <tr> 
                  <td class="HeadingBackGroundLeft">View/Edit Manufacturer's logo</td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" class="LightBackground"><table width=100% border=0 align=Center class="Border">
                <tr align="left"> 
                  <td Colspan=2 Class=HeadingBackGroundLeft>Edit Logo</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="32%" align=right class="contact">Image</td>
                  <td width="68%" align="center"><% 
					dim imgA
					imgA = "http://" &  Request.ServerVariables("Server_Name") '& "/newuae"
				  %>
				  <img src="<%Response.Write imgA & "\mobiles\Images\Models\" & Rsmain("Logo")%>" border=0>
				  </td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Logo Size(95x23) *</td>
                  <td><INPUT type="File" name="imgFile" style="width: 250px;" class=buttons> </td>
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
