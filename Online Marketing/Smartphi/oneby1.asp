<!--#include file="cPanel\Main.asp"-->
<% 

dim camid, contid
dim ip, schid

ip = request.ServerVariables("REMOTE_ADDR")
camid = Request.QueryString("camid") & ""
schid= Request.QueryString("schid") & ""
contid= Request.QueryString("contid") & ""
'Response.Write(camid)
dim c
c= conn.execute ("Select CampaignID from Campaign where GUIDNo='" & camid & "'")(0)
camid=c
'Response.Write(c)
'Response.Write(contid)
'Response.End()
if len(camid)>0 and len(contid)>0 then
	Dim rsMain
		set rsMain=server.CreateObject("ADODB.Recordset")

Dim  sql
	'rsTemp = server.CreateObject("ADODB.Recordset")
	sql ="Select * from MailingList where CampaignID=" & camid & " and ScheduleID=" & schid & " and ContactID=" & contid
	rsMain.Open sql,conn,3,3
	'rsTemp.open sql,Conn,3,3
	'Response.Write(rsMain.recordcount)
	' Response.End()

	if not rsMain.eof then
		rsMain("DeliveryStatus") = 1
		if len(rsMain("Opened") & "")>0 then rsMain("Opened") = cint(rsMain("Opened") & "")+1 else rsMain("Opened") =1
		rsMain("DateOpened") = Now()
		rsMain("IPAddr") = ip
		rsMain.update
	end if
	set rsMain = nothing

	'Conn.execute "Insert into MailingList(CampaignID, ContactID) values(" & cint(camid) & "," & cint(contid) & ")"
	'Response.Write("Insert into MailingList(CampaignID, ContactID) values(" & cint(camid) & "," & cint(contid) & ")")
	'Response.End()
	response.write "http://www.mobiphi.com/oneby1.gif"
end if
%>