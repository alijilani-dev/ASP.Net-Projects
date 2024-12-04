<!--
function dispcount(p,s)
{
document.write("<table width=\"138\" border=\"0\" align=\"center\" cellpadding=\"1\" cellspacing=\"0\" style=\"Border: 1px Solid #999999\">");
document.write("<tr><td width=\"134\" bgcolor=\"#003366\"><div align=\"center\"><font color=\"#FFFFFF\" size=\"2\" face=\"Verdana, Arial, Helvetica, sans-serif\"><strong>No ");
document.write("of Members</strong></font></div></td></tr><tr><td valign=\"middle\" align=center><table border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">");
document.write("<tr valign=\"top\">");
for (var i=0; i < p.length; i++) 
{
   var c = p.charAt(i);
	document.write("<td width=\"12\"><img src=\'Images/pic/");
	document.write(p.charAt(i));
	document.write(".gif\' width=\"12\" height=\"16\"></td>");
}
document.write("</tr></table></td></tr><tr><td height=\"8\">&nbsp;</td></tr></table><br> ");

document.write("<table width=\"138\" border=\"0\" align=\"center\" cellpadding=\"1\" cellspacing=\"0\" style=\"Border: 1px Solid #999999\">");
document.write("<tr><td width=\"134\" bgcolor=\"#003366\"><div align=\"center\"><font color=\"#FFFFFF\" size=\"2\" face=\"Verdana, Arial, Helvetica, sans-serif\"><strong>No ");
document.write("of Postings</strong></font></div></td></tr><tr><td valign=\"middle\" align=center><table border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">");
document.write("<tr valign=\"top\">");
for (var i=0; i < s.length; i++) 
{
   var c = s.charAt(i);
	document.write("<td width=\"12\"><img src=\'Images/pic/");
	document.write(s.charAt(i));
	document.write(".gif\' width=\"12\" height=\"16\"></td>");
}
document.write("</tr></table></td></tr><tr><td height=\"8\">&nbsp;</td></tr></table><br> ");

}
//-->
