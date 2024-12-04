<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<%
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if
Dim rsLatest
set rsLatest = Server.CreateObject("Adodb.Recordset")

%>
<HTML>
<Head>
<Title>
Latest Mobile Selection
</Title>
<LINK rel="stylesheet" type="text/css" href="../Global/MyStyle.css">
</Head>

<body>
<form name="frmLatest" method="post" action="InsertLatest.asp">
<input type="hidden" name="hdMobiles" value="">
<script language="JavaScript">
function Submit()
{
var Sub = document.frmLatest.cboSub;
	for (var i = 0; i <=Sub.options.length-1;i++)
		{
		Sub.selectedIndex = i;
		document.frmLatest.hdMobiles.value = document.frmLatest.hdMobiles.value + "'" + Sub.options[i].value + "', ";
		}
		
		///alert(document.frmLatest.hdMobiles.value);
		document.frmLatest.action="InsertLatest.asp";
		document.frmLatest.submit();
		return true;
}
function MoveRight()
{
	var Main = document.frmLatest.cboMobiles;
	var Sub = document.frmLatest.cboSub;	
	var x = Main.options.selectedIndex;
if (x!=-1)
{
	if (Sub.options.length<11)
	{
		Sub.options[Sub.options.length] = new Option(Main.options[x].text,Main.options[x].value);
	}
//alert(Main.options[x].value);
//alert(Main.options[x].text);
}

}

function MoveLeft()
{
// onClick="if (this.options.selectedIndex!=-1) {alert(this.options[this.options.selectedIndex].value);}"
	var Sub = document.frmLatest.cboSub;	
	var x = Sub.options.selectedIndex;
if (x!=-1) {	Sub.options[x] = null; }
}
</script>
  <table width="60%" height="20" border="0" cellpadding="5" cellspacing="1" bgcolor="#999999">
    <tr bgcolor=lightgrey> 
      <td width="45%" height="20" class=tablehead><strong>Mobile Models</strong></td>
      <td width="10%" height="20" class=tablehead></td>
      <td width="45%" height="20" class=tablehead><strong>Latest Mobiles</strong></td>
    </tr>
    <tr bgcolor="#FFEFDF"> 
      <td width="45%" align="center"> <select name="cboMobiles" size="20" class="TextBox">
   <%
rsLatest.open "Select * from mMobileModel inner join mManufacturer on mMobileModel.ManufCode = mManufacturer.ManufCode order by mManufacturer.ManufName, mMobileModel.ModelNo",conn,3,2
do while not rsLatest.eof
%>
          <option value="<%=rsLatest("ModelNo")%>">
          <% Response.Write rsLatest("ManufName") & "  -  " & rsLatest("ModelNo")%>
          </option>
          <%rsLatest.movenext
loop
%>        </select></td>
      <td width="10%" valign="top"><input name="btnMvRight" type="button" id="btnMvRight" value="&gt;&gt;" onClick="javascript:MoveRight();">
        <br>
        <br>
        <input name="btnMvLeft" type="button" id="btnMvLeft" value="&lt;&lt;" onClick="javascript:MoveLeft();"> 
        <br>
      </td>
      <td width="45%" align="center" valign="top"><select name="cboSub" size="6" multiple class="TextBox">
        </select>
        <br>
        <br>
        <br>
        <br>
        <br>
        <input type="button" name="Button" value="Update" onClick="javascript:Submit();"> </td>
    </tr>
  </table>
</form>
</body>
</html>
