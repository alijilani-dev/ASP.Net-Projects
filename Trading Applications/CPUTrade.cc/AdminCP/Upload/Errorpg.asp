
<SCRIPT LANGUAGE=javascript>
function MoveHome()
{	
	if (opener != null)
	{
		opener.top.location = "Index.asp";
		window.close();
		return;
	}
	window.location.href='<% %>';
}

function MoveBack()
{
	if (history.length ==0)
	{
		window.close();
		return;
	}
	else
	history.back();
}

</SCRIPT>
<HTML>
<HEAD>
<META NAME="GENERATOR" Content="Microsoft Visual Studio 6.0">
<TITLE>Phonetrade.cc</TITLE>
</HEAD>
<BODY TopMargin = 0 Leftmargin=0 Link=Red Alink=Green Vlink=Red target="_top">

<TABLE Bgcolor="Navy" Width='100%'>
	 <TR><TD align=center> <Font color=white>Phonetrade.cc </font></TD> </TR>
</TABLE>

<BR>
<BR>
<BR>
<TABLE width=50% align=center height="15%">
  <% if Request.QueryString("errNo")="10000000" then%>
  <TR> 
    <TD>&nbsp; </TD>
    <TD>&nbsp; </TD>
  </TR>
  <% else %>
  <TR> 
    <TD Bgcolor=Lightblue> Number: </TD>
    <TD Bgcolor=Lightblue> <%=Request.QueryString("errNo") %> </TD>
  </TR>
  <% END IF %>
  <TR> 
    <TD Bgcolor=Lightblue> Message: </TD>
    <TD Bgcolor=Lightblue> <%=Request.QueryString("errDesc") %> </TD>
  </TR>
 <% if Instr(Request.QueryString("errDesc"),"too wide")>0 then %>
  <TR>
    <TD><a href="ImageUpload1.asp">Please click here to upload image</a> </TD>
    <TD>&nbsp;</TD>
  </TR>
  <%end if%>
</TABLE>
<BR>
<BR>
<CENTER>
<FORM Name = "frmErr" Method = "Post">
<INPUT Type=Button class = Buttons  Value="Go Back" Onclick="MoveBack()" name = 'btnGoback' >
<INPUT Type=Button class = Buttons Value="Home" Onclick= "MoveHome()"> 
</FORM>
</CENTER>
<SCRIPT LANGUAGE=javascript>
document.frmErr.btnGoback.focus();
</SCRIPT>
</BODY>
</HTML>
