<%@ Language=VBScript %>
<%
'if Request.Cookies("islogin") = "nothing" or Request.Cookies("islogin") = "" then
'Response.Redirect("AdminLogin.asp")
'end if
%>

<HTML>
<Head>
<Title>
Masters Menu
</Title>
</Head>
<frameset rows="16%,5%,*" cols="*" frameborder="NO" border="0" framespacing="0">
    <frame src="Top.asp" name="mainTopFrame" scrolling="NO" noresize>
    <frame src="Masters/MasterTop.asp" name="topFrame" scrolling="NO" noresize>
    <frame src="Masters/MastersMain.asp" name="mainFrame">  
  </frameset>
<noframes><body>

</body></noframes>
</HTML>

