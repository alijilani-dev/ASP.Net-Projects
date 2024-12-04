<% Dim Conn, StrConnection


session.Timeout = 60
'StrConnection ="Provider=SQLOLEDB.1;Persist Security Info=False;User ID=smartphi;PWD=phi*smart*18;Initial Catalog=smartphi;Data Source=eul01"

StrConnection ="Provider=SQLOLEDB.1;Persist Security Info=False;User ID=smartphi;PWD=phi*smart*18;Initial Catalog=smartphi;Data Source=SRFZE-SERVER-01"

'StrConnection ="Provider=SQLOLEDB.1;Persist Security Info=False;User ID=smartphi;PWD=phi*smart*18;Initial Catalog=smartphi;Data Source=213.42.18.90"

Set Conn=Server.createObject("Adodb.Connection")
Conn.open StrConnection
Conn.CursorLocation=3
%>
