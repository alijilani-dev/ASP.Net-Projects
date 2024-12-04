<%@ Language=VBScript %>
<script language=JavaScript>
function ShowSub(index)
{
	var i;
	for (i=0;i<=4;i++)
	{
		if (i==index)
		{
			eval("Link"+i).style.backgroundColor="orange";
			eval("Link"+i).style.color="#ffffff";
			eval("Link"+i).style.cursor="Hand";
			
		}
		else
		{
			eval("Link"+i).style.backgroundColor="#996600";
			eval("Link"+i).style.color="#ffffff";						
		}
	}
}
 function moveSubForm(page)
{
	document.frmSubForm.target="mainFrame";
	document.frmSubForm.action=page;
	document.frmSubForm.submit();
}
</script>
<HTML>
<LINK rel="stylesheet" type="text/css" href="../Global/MyStyle.css">
<body topmargin="0" leftmargin="0" Rightmargin="0" bottommargin="0">
<form name=frmSubForm method=post>
<center>
  <table width=100% border=0 align="center">
    <tr> 
    <td class=HeadingWithBackGround align=Center Id=Link0 onmouseover="JavaScript:ShowSub(0)" onClick="JavaScript:moveSubForm('Manufacturer.asp')">Manufacturer</td>
    </tr><tr>  
    <td class=HeadingWithBackGround align=Center Id=Link1 onmouseover="JavaScript:ShowSub(1)" onClick="JavaScript:moveSubForm('Display.asp')">Display 
      type </td>
    </tr><tr>
    <td class=HeadingWithBackGround align=Center Id=Link2 onmouseover="JavaScript:ShowSub(2)" onClick="JavaScript:moveSubForm('Network.asp')">Network 
      type </td>
    </tr><tr>
    <td class=HeadingWithBackGround align=Center Id=Link3 onmouseover="JavaScript:ShowSub(3)" onClick="JavaScript:moveSubForm('Ringtone.asp')">Ringtone 
      type</td>
    </tr>
  </table>
    <br>
    <br>
    <table width=100% border=0 align="center">
      <tr> 
        <td class=HeadingWithBackGround align=Center Id=Link4 onmouseover="JavaScript:ShowSub(4)" onClick="JavaScript:moveSubForm('LatestMobile.asp')">Select 
          latest mobiles</td>
      </tr>
    </table>
  </center></form>

</body>
</html>
