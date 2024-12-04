<% Dim Conn, StrConnection

StrConnection ="Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;PWD=sa;Initial Catalog=trade;Data Source=eul01"
StrConnection ="Provider=SQLOLEDB.1;Persist Security Info=False;User ID=trade;PWD=etrade;Initial Catalog=trade;Data Source=eul01"

Set Conn=Server.createObject("Adodb.Connection")
Conn.open StrConnection
Conn.CursorLocation=3

Private Function formatSQLInput(ByVal strInputEntry)

	'Remove malisous charcters from links and images
	strInputEntry = Replace(strInputEntry, "<", "&lt;")
	strInputEntry = Replace(strInputEntry, ">", "&gt;")
	strInputEntry = Replace(strInputEntry, "[", "&#091;")
	strInputEntry = Replace(strInputEntry, "]", "&#093;")
	strInputEntry = Replace(strInputEntry, """", "", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "=", "&#061;", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "'", "''", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "select", "sel&#101;ct", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "join", "jo&#105;n", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "union", "un&#105;on", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "where", "wh&#101;re", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "insert", "ins&#101;rt", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "delete", "del&#101;te", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "update", "up&#100;ate", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "like", "lik&#101;", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "drop", "dro&#112;", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "create", "cr&#101;ate", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "modify", "mod&#105;fy", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "rename", "ren&#097;me", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "alter", "alt&#101;r", 1, -1, 1)
	strInputEntry = Replace(strInputEntry, "cast", "ca&#115;t", 1, -1, 1)

	'Return
	formatSQLInput = strInputEntry
End Function
%>


