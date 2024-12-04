<% Dim Conn, StrConnection


session.Timeout = 60
'StrConnection ="Provider=SQLOLEDB.1;Persist Security Info=False;User ID=uae;PWD=uae2005*@prop;Initial Catalog=uaeproperty;Data Source=67.19.231.146"

StrConnection ="Provider=SqlServer;Persist Security Info=False;User ID=trade;PWD=etrade;Initial Catalog=trade;Data Source=DSVR002666"


Set Conn=Server.createObject("Adodb.Connection")
Conn.open StrConnection
Conn.CursorLocation=3
%>
