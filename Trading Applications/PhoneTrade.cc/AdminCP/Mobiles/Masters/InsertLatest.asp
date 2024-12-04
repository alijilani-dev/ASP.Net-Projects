<!-- #Include File = "../Global/MainSrc.asp" -->
<%
dim strMob
strMob = request.form("hdMobiles")
strMob = mid(strMob,1,len(strMob)-2)

Dim rsLatest, Flag
'set rsLatest = Server.CreateObject("Adodb.Recordset")
'rsLatest.open "Select top 1 * from mLatestMobiles where SrNo=1",conn,3,2
'Response.Write(rsLatest("LatestMobiles"))
'Response.End()
'rsLatest("LatestMobiles") = strMob
'rsLatest.update

Dim i 
Dim strLatestMobiles
conn.execute "Delete from mLatestMobiles"
strLatestMobiles = split(strMob,", ")
for i = 0 to ubound(strLatestMobiles)'-1
	strSql = "Insert into mLatestMobiles (LatestMobiles) values(" & strLatestMobiles(i) & ")"
'Response.Write(strSql)
'Response.End()
	conn.execute strSql
next
if err.number<>0 then
	Flag="No"
	'Response.Write err.description
else
	Flag="Yes"
end if
 %>
<HTML>
<Head>
<Title>
Latest Mobile Selection
</Title>
<LINK rel="stylesheet" type="text/css" href="../Global/MyStyle.css">
</Head>

<body>
<% if Flag="Yes" then%>
	<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td><strong>Latest mobile model(s) has been updated sucessfully</strong></td>
  </tr>
</table>
<%end if%>
</body>
</html>