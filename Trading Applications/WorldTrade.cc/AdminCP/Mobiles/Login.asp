<%@ Language=VBScript %>
<!-- #Include File = "Global\MainSrc.asp" -->
<%
	Dim Login
	if Request.QueryString("Process")="Submit" Then
	  Dim rsMain, sql
		sql="Select AdLogin,AdPwd from mControl where AdLogin='" & replace(trim(Request.Form("txtUserName")),"'","`") & "' and AdPwd='" & replace(trim(Request.Form("txtPassword")),"'","`") & "'"
		set rsMain=server.CreateObject("ADODB.Recordset")
		set rsMain=conn.Execute(sql)
	   	if rsMain.RecordCount <>0 Then
			Session("sLogmein")=Trim(Request.Form("txtUserName"))
			Response.Cookies("qLogmein")=Trim(Request.Form("txtUserName"))
			Response.Redirect "Top.asp"
		Else 
			Login="Failed"
		End if
	End if
%>
<HTML>
<link href="Global/MyStyle.CSS" rel="stylesheet" type="text/css">
<Head>
<Title>
Admin Login
</Title>
</Head>
<script language='javascript' src=Global/valid.js></script>
<script language=javascript>
 function Login()
{
	var x = chkKey(document.frmMain.txtUserName);		
	if (x==true)
	{
		alert("Invlaid character found in the UserName box");
		document.frmMain.txtUserName.value ="";
		document.frmMain.txtUserName.focus();
		return false;
		}
 
	if (document.frmMain.txtPassWord.value=="" || document.frmMain.txtUserName.value=="")
	{
		alert("Please enter username and password!");
		return false;
	}
	else
	{
		document.frmMain.action="Login.asp?Process=Submit";
		document.frmMain.submit();
	}
}
function ShowMessage()
{
	if ("<%=Login%>"=="Failed") alert("Invalid username/password!");
	document.frmMain.txtUserName.focus();
}
</script>
<body onLoad="ShowMessage()">
<form name="frmMain" method=post onSubmit="JavaScript:return Login()" autocomplete="off">
  <TABLE border=0 cellspacing=0 cellpadding=0 width="100%">
    <tr>
      <td Align=middle Class=MainHeading>Phonetrade.cc</td>
    </tr>
    <tr>
      <td Align=middle Class=SubHeading>Control Panel to update Mobile Models</td>
    </tr>
    <tr>
      <td>&nbsp;</td>
    </tr>
  </table>
<hr>
  <table width="100%" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td height="400" align="center" valign="middle"><table width="35%" border="0" align="center" cellpadding="0" cellspacing="1" class="HeadingWithBackGround">
          <tr> 
            <td bgcolor="#FFFFFF" class="LightBackground"><table width=100% border=0 align=Center class="contact">
                <tr> 
                  <td Colspan=2 align=Center Class=HeadingWithBackGround>Admin 
                    Login</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">User Name</td>
                  <td><input type=text name=txtUserName value="" class=Textbox></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Password</td>
                  <td><input type=password name=txtPassWord value="" class=Textbox></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=Center colspan=2> <input type=Submit name=btnOk value="     Ok      " class=Buttons> 
                    <input type=Reset name=btnCancel value=" Clear " class=Buttons> 
                  </td>
                </tr>
                <tr> 
                  <td align=Center colspan=2 class=contact> 
<%if Request.QueryString("Process")="Logout" Then 
Response.Write "<font color=Red size=2>You are logged out successfully!</font>"
Response.Cookies("qLogmein")= "" 	
Session("sLogmein")=""
end if
%>
                    &nbsp;</td>
                </tr>
              </table></td>
          </tr>
        </table></td>
    </tr>
  </table>
  </form>
</body>
</html>
