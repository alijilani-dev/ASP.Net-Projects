<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
	Const adOpenForwardOnly = 0
	Const adLockReadOnly = 1
	Const adUseClient = 3

	Dim rsMain, sql, pge, strPgNo, strSubject
	pge = Request.Form("hdPageNo")
	strSubject= Request.Form("txtSubject")
	if len(strSubject & "")=0 then strSubject = "Today's new phone trade listings posted on PhoneTrade.cc"

	If Len(pge) = 0  Then pge=0
	set rsMain=Server.CreateObject("Adodb.Recordset")
	sql = "select  * from Members where MailFlag=2 ORDER BY SrNo DESC"
	rsMain.PageSize = 100
	rsMain.CacheSize = 100
	rsMain.CursorLocation = adUseClient
    rsMain.Open sql,conn,adOpenForwardOnly, adLockReadOnly

%>

<html>

<head>
<title></title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="../Styles/CssStyles.CSS" rel="stylesheet" type="text/css">
<script language="JavaScript1.2" type="text/JavaScript1.2" src="../Main/Main.js"></script>

</head>

<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<!--#Include file="Top1.asp"-->
<table width="96%" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td valign="middle">
    <form method=post name=frmNewLetter>
	<input type=hidden name="hdPageNo" value="<%=pge%>">
    <script language=Javascript>
function GoTo(p)
{
	document.frmNewLetter.hdPageNo.value= p;	
	document.frmNewLetter.action = "MailingProc.asp";
	document.frmNewLetter.submit();
}							
	function move()
	{
		document.frmNewLetter.action="SendMail.asp";
		document.frmNewLetter.submit();	
	}
</script>
        <table width="100%" border="0" cellpadding="5" cellspacing="0" class="contact">
          <tr> 
            <td align="center" valign="middle">
	<%if not rsMain.EOF  then 	
		rsMain.MoveFirst 
		If Len(pge) = 0 or pge="0"  Then
				pge=0
				rsMain.AbsolutePage = 1
		Else
			If CInt(pge) <= rsMain.PageCount Then
					rsMain.AbsolutePage = pge
				Else
					rsMain.AbsolutePage = 1
			End If
		End If
		Dim absPage, pageCnt,intRec
		absPage = rsMain.AbsolutePage
		pageCnt = rsMain.PageCount
		Dim pg_Rec
		pg_Rec = -1
						Response.Write "<table width=""60%"" border=1 class=contact align=center cellpadding=0 cellspacing=1 bgcolor=""#CCCCCC""><tr><br>"
					
						'''For Previous page link
						'If abspage = 1 Then
						'	Response.Write "<td width=""100"" valign=top align=left>&lt;&lt;Previous Page</td>"
						'Else
						'	Response.Write "<td width=""100"" valign=top align=left><a href=""JavaScript:Go(" & abspage - 1 & ");"">&lt;&lt;Previous Page </a></td>"
						'End If
						Response.Write "<td width=""60%"" valign=middle align=center>"

							'''For Previous page link
							If abspage = 1 Then
								Response.Write "<img src=""../images/previouspage.gif"" alt=""Next Page"" Border=0 align=""absmiddle"">&nbsp;"
							Else
								Response.Write "<a href=""JavaScript:GoTo(" & abspage - 1 & ");"">"
								Response.Write "<img src=""../images/previouspage.gif"" alt=""Previous Page"" Border=0 align=""absmiddle""></a>&nbsp;"
							End If

							for k= pge+1 to rsMain.PageCount
								pg_Rec = pg_Rec + 1
								if pg_Rec=20 then
									Response.Write "<br>"
									pg_Rec=0
								end if
								if absPage=k then 
									Response.Write "<Font color=red>[" & k & "]</font>&nbsp;|&nbsp;"
								else
									Response.Write "<a href=""JavaScript:GoTo(" & k & ");"">" & k & "</a>&nbsp;|&nbsp;"
								end if
							next 
							
							''For next page link
							If abspage < pagecnt Then
								Response.Write "<a href=""JavaScript:GoTo(" & abspage + 1 & ");"">"
								Response.Write "<img src=""../images/nextpage.gif"" alt=""Next Page"" Border=0 valign=middle align=""absmiddle""></a>"
							else
								Response.Write "<img src=""../images/nextpage.gif"" alt=""Next Page"" Border=0 align=""absmiddle"">"
							End If

					Response.Write "</td>"
					
						''For next page link
						'If abspage < pagecnt Then
						'	Response.Write "<td width=""100"" valign=top align=right><a href=""JavaScript:GoTo(" & abspage + 1 & ");"">Next Page&gt;&gt;</a></td>"
						'else
						'	Response.Write "<td width=""100"" valign=top align=right>Next Page&gt;&gt;</td>"
						'End If
						Response.Write "</tr></table><br>"
							
			%>
            <table border=0 width=60% align=center>
                <tr> 
                  <td align=Center Class=HeadingWithBackGround>Send todays posting 
                    to all members in daily mail alert list</td>
                </tr>
			<tr Class=TableBackGround> 
              <td align=left>
              <input type=text name=txtSubject value="<%=strSubject%>" size=100>
              </td></tr>
			<tr Class=TableBackGround> 
              <td align=right>
              <input type=button name=btnOk2 value="Send News Letter" class=Buttons style="width: 150px" onClick="Javascript:move();"> 
              </td></tr>

                <% 
				i =0
				For intRec=1 To rsMain.PageSize
				If Not rsMain.EOF Then 
					if intRec=1 then
						Response.Write "<input type=hidden name=hdTo value=" & rsMain("SrNo") & ">"
					end if
		
					if intRec=rsMain.PageSize then
						Response.Write "<input type=hidden name=hdFrom value=" & rsMain("SrNo") & ">"
					end if

                 %>
				<tr Class=TableBackGround> 
                  <td align=left><%=rsMain("EmailId")%></td>
                </tr>
				<% 
				i = i +1
				rsMain.MoveNext 
				end if
				next
				end if
				%>
				<tr Class=TableBackGround> 
                  <td align=right>
                  <input type=button name=btnOk2 value="Send News Letter" class=Buttons style="width: 150px" onClick="Javascript:move();"> 
                  </td></tr>
              </table></td>
          </tr>
        </table>
      </form></td>
  </tr>
</table>
</body>
</html>
