<%
Set objMessage = CreateObject("CDO.Message") 
objMessage.Subject = subj 
objMessage.From = "info@phonetrade.cc" 
objMessage.To ="basheer@phonetrade.cc"
strHTML="<font color=red> bismillah</font>"
objMessage.HTMLBody = CStr("" & strHTML)
if len(strCC)>0 then objMessage.cc = strCC
objMessage.BCC= "sales@phonetrade.cc"
objMessage.Send
%>