<%@ Language=VBScript %>
<%
if len(Session("sLogmein"))=0 then
	Response.Redirect "Login.asp"	
end if
%>
<HTML>
<Head>
<Title>
Master
</Title>
</Head>
<frameset rows="20%,*" cols="*" frameborder="NO" border="0" framespacing="0">
  <frame src="Mobiles/MobilesTop.asp" name=fraTop scrolling="NO"  noresize></frame>
    <frame src="Mobiles/ImageUpload.asp" name="mainFrame">
  </frameset>    
<noframes><body>

</body></noframes>
</HTML>

