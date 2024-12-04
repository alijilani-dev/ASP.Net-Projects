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
  <frame src="Masters/MastersTop.asp" name=fraTop scrolling="NO"  noresize></frame>
  <frameset rows="*" cols="15%,*" framespacing="0" frameborder="NO" border="0">
    <frame src="Masters/MastersLeft.asp" name="leftFrame" noresize>
    <frame src="Masters/MastersMain.asp" name="mainFrame">
  </frameset>    

  </frameset>
<noframes><body>

</body></noframes>
</HTML>

