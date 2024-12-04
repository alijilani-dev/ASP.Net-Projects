<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
	dim rsTemp , Flag, chk
	chk=Request.QueryString("chk")
set	rsTemp=Server.CreateObject("adodb.recordset")
rsTemp.open "Select MemberCode from Members where Member_id='" & chk & "'",conn,3,2
if not rsTemp.eof then
	Flag="Yes"
else
	Flag="No"
end if
%>
<html>
<head>
<title>Check the User Name</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="../Styles/CssStyles.css" rel="stylesheet" type="text/css">
</head>

<body>
<table width="100%" border="0" cellspacing="1" cellpadding="0">
  <tr class="HeadingWithBackGround"> 
    <td>Checking the username for existance</td>
  </tr>
  <tr>
    <td height="50" align="center" valign="middle"> <font color="#0000FF">
      <% if Flag="Yes" then 
			Response.Write("<font color=red><b>Sorry</b></font>, The username :'" & chk & "' already exists with the system. Please try with another username")
		else
			Response.Write("<font color=red><b>Congratulations</b></font>, The username :'" & chk & "' is not found with the system. You are allowed to use this username.")
		end if
	%>&nbsp;</font>
    </td>
  </tr>
</table>
</body>
</html>
