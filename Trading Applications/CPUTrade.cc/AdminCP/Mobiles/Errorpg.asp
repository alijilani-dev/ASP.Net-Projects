
<SCRIPT LANGUAGE=javascript>
function MoveHome()
{	
	if (opener != null)
	{
		opener.top.location = "Default.asp";
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
<link rel=stylesheet type=text/css href=./Styles/Styles.css>
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
		<TD>&nbsp;
			
		</TD>	
		<TD>&nbsp; 
			
		</TD>	
	</TR>
	<% else %>
	<TR>
		<TD Bgcolor=Lightblue>
			Number:
		</TD>	
		<TD Bgcolor=Lightblue>
			<%=Request.QueryString("errNo") %>
		</TD>	
	</TR>
	<% END IF %>
	<TR>
		<TD Bgcolor=Lightblue>
			Message:
		</TD>	
		<TD Bgcolor=Lightblue>
			<%=Request.QueryString("errDesc") %>
		</TD>	
	</TR>
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
<!-- Start of StatCounter Code -->
<script type="text/javascript" language="javascript">
var sc_project=407286; 
var sc_partition=2; 
var sc_invisible=1; 
</script>
<script type="text/javascript" language="javascript" src="http://www.statcounter.com/counter/counter.js"></script><noscript><a href="http://www.statcounter.com/free_hit_counter.html" target="_blank"><img  src="http://c3.statcounter.com/counter.php?sc_project=407286&amp;java=0&amp;invisible=1" alt="webcounter" border="0"></a> </noscript>
<!-- End of StatCounter Code -->
</BODY>
</HTML>
