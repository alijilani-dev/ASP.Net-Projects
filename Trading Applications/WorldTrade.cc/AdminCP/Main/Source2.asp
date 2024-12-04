<% Dim Conn, StrConnection


session.Timeout = 60

'StrConnection ="Provider=SQLOLEDB.1;Persist Security Info=False;User 'ID=sa;Initial Catalog=Callmate;Data Source=Basheer"

StrConnection ="Provider=SQLOLEDB.1;Persist Security Info=False;User ID=uaeprop;PWD=123property;Initial Catalog=uaeprop;Data Source=sql15.webcontrolcenter.com"

Set Conn=Server.createObject("Adodb.Connection")
Conn.open StrConnection
Conn.CursorLocation=3
%>
