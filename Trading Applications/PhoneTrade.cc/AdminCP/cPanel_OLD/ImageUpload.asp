<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
'Response.CacheControl = "no-cache"
'Response.AddHeader "Pragma", "no-cache"
'Response.Expires = -1
if len(Session("sLogmeinadmin"))=0 then
	Response.Redirect "Login.asp"	
end if
Dim strSelect, strAction
	strSelect=Request.Form("cboMembName")
	if len(strSelect & "")=0 then strSelect = Request.QueryString("Id")
	if len(strSelect & "")=0 then strSelect = -1
	Dim rsMain
    Set rsMain = Server.CreateObject("ADODB.Recordset")

%>  
<script language=JavaScript>
function Logout()
{
  document.frmMain.target="_top"; 
  document.frmMain.action="Login.asp?Process=Logout";
  document.frmMain.submit();  
}
function Show(index)
{
	var i;
	for (i=0;i<=4;i++)
	{
		if (i==index)
		{
			eval("Link"+i).style.backgroundColor="#990000";
			eval("Link"+i).style.color="White";
			eval("Link"+i).style.cursor="Hand";
			
		}
		else
		{
			eval("Link"+i).style.backgroundColor="#666666";
			eval("Link"+i).style.color="#ffffff";						
		}
	}
}
 function Move(page)
{
	document.frmMain.target="_top";
	document.frmMain.action=page;
	document.frmMain.submit();
}

</script>
<link href="../Styles/CssStyles.CSS" rel="stylesheet" type="text/css">
<script language="JavaScript1.2" type="text/JavaScript1.2" src="../Main/Main.js"></script>
<HTML>

<title>Activate Membership</title><body topmargin="0" leftmargin="0" Rightmargin="0" bottommargin="0">
<!--#include file="Top1.asp"-->
<table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" class="contact">
  <tr>
    <td> 
<form name=frm method=post>
<input type="hidden" name="hdMember" value="">
        <input type="hidden" name="hdAction" value="">
        <script language=Javascript>
		function move()
		{
			document.frm.action = "ImageUpload.asp";
			document.frm.submit();
		}

</script>
	<table width="60%" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr> 
          <td><table width=100% border=0 align=Center class="Border">
              <tr align="left"> 
                <td Colspan=3 class="HeadingWithBackGround">Select member</td>
              </tr>
              <tr Class=TableBackGround> 
                <td width="18%" align=right class="contact">Member Name</td>
                <td width="63%"> <select name="cboMembName" style="width:250px">
                    <%
sSQL = "select CompanyName,MemberCode from Members order by CompanyName"
if rsMain.State then rsMain.Close 
rsMain.Open sSQL,conn,2,1
do while not rsMain.EOF 
%>
                    <option value="<%=rsMain("MemberCode")%>"><%=rsMain("CompanyName")%></option>
                    <%
rsMain.MoveNext 
loop
rsMain.Close
%>
                  </select> &nbsp; <SCRIPT LANGUAGE=javascript>
con = "<%=strSelect%>" 
for (i=0;i<document.frm.cboMembName.length;i++)
if (document.frm.cboMembName.options[i].value==con)
document.frm.cboMembName.selectedIndex = i;
</SCRIPT> <input type=button onClick="return move();" name=btnGo value=" Go "> 
                </td>
                <td width="19%">&nbsp;</td>
              </tr>
              <tr height=2> 
                <td colspan="3" align=right class="HeadingWithBackGround"></td>
              </tr>
              <tr> 
                <td></td>
                <td>&nbsp; </td>
                <td>&nbsp;</td>
              </tr>
            </table></td>
        </tr>
      </table>
        <br>
        <% 
    Set rsTemp = Server.CreateObject("ADODB.Recordset")
    rsTemp.Open "Select * from Members where MemberCode=" & strSelect ,conn,3,2
    if not rsTemp.EOF  then
%>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr> 
            <td><table width=100% border=0 align=Center class="Border">
                <tr align="left"> 
                  <td Colspan=2 class="HeadingWithBackGround">Preview Image(s)</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="21%" align=right class="contact">Logo Image</td>
                  <td width="79%"> 			  
<%
'dim imgA
valDb= rsTemp("imgLogo") & ""
'imgA = "http://" &  Request.ServerVariables("Server_Name")  
'imgA=Server.MapPath("..\Images\Logo")  
if len(valDb)>0 then 
	Response.Write "<img src='..\Images\Logo\" & valDb & "' style=""Border: 1px solid;"">"
else
	Response.Write "<font color=red>No image uploaded</font>"
end if
%>

                  </td>
                </tr>
                <tr height=2> 
                  <td colspan="2" align=right class="HeadingWithBackGround"></td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Main Image</td>
                  <td> 
 				  
<%
valDb= rsTemp("imgMain") & ""
'imgA = "http://" &  Request.ServerVariables("Server_Name")
'imgA=Server.MapPath("..\Images\MainImage")  
if len(valDb)>0 then 
	Response.Write "<img src='..\Images\MainImage\" & valDb & "' style=""Border: 1px solid;"">"
else
	Response.Write "<font color=red>No image uploaded</font>"
end if

%>

                  </td>
                </tr>
              </table></td>
          </tr>
        </table>
       <%end if%>
      </form>
      <form name="frmImage" method="post" encType="multipart/form-data" action="Upload123.asp" onSubmit="JavaScript:return FormSubmit();">
<input type=hidden name="hdMembName" value="<%=strSelect%>*">
<script language=javascript>
function FormSubmit()
{
	errStr = "The following error(s) occurred:\n";
	var CanSubmit = false;

	CanSubmit = ForceEntry(document.forms["frmImage"].imgFile1,"    - Logo Image required.");
	CanSubmit = CanSubmit & ForceEntry(document.forms["frmImage"].imgFile2,"    - Main Image is required.");		
	CanSubmit = (CanSubmit!=0)
	if (CanSubmit==false) 
	{alert(errStr);
	return false;
	}
	else
	{
		document.frmImage.action="Upload123.asp"
		document.frmImage.submit();
	}

}
</script>
        <br>
        <br>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" ><table width=100% border=0 align=Center class="Border">
                <tr align="left"> 
                  <td Colspan=3 class="HeadingWithBackGround">Upload Images</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="18%" align=right class="contact"><strong>Logo Image</strong>* 
                  </td>
                  <td width="63%"><INPUT name="imgFile1" type="File" class=buttons id="imgFile1" style="width: 250px;">
                    <font color="#666666"> <span class="contact">Size (120 x 60)</span></font></td>
                  <td width="19%">&nbsp; </td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact"><strong>Main Image</strong>*</td>
                  <td><INPUT name="imgFile2" type="File" class=buttons id="imgFile2" style="width: 250px;">
                    <font color="#666666"> <span class="contact">Size (525 x 260) 
                    </span></font> </td>
                  <td>&nbsp;</td>
                </tr>
                <tr height=2> 
                  <td colspan="3" align=right class="HeadingWithBackGround"></td>
                </tr>
                <tr> 
                  <td></td>
                  <td> <input type=Submit name=btnOk value="  Upload  " class=Buttons> 
                    <input type=Reset name=btnCancel value=" Cancel " class=Buttons onClick='javascript:history.back();'> 
                  </td>
                  <td>&nbsp;</td>
                </tr>
              </table></td>
          </tr>
        </table>
        
      </form>
    </td>
  </tr>
</table>
</body>
</html>
