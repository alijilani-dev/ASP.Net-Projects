<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<%
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if

%>
<HTML>
<Head>
<Title>
Property Main
</Title>
<LINK rel="stylesheet" type="text/css" href="../Global/MyStyle.css">
</Head>

<body>

</body>
</html>
