<%@ Language=VBScript %>
<!-- #Include File = "../Main/Source.asp" -->
<%
Response.CacheControl = "no-cache"
Response.AddHeader "Pragma", "no-cache"
Response.Expires = -1
if len(Session("sLogmeinadmin"))=0 then
	Response.Redirect "Login.asp"	
end if
Dim strSelect, strAction, strCode, strCategory
	Dim rsMain
    Set rsMain = Server.CreateObject("ADODB.Recordset")

	strAction=Request.Form("hdAction")
	strCode=Request.Form("hdCode")
if len(strAction)=0 then strAction = "Add"
if strAction = "Edit" then
	strCategory = Conn.execute("Select CategoryName from mProdCategory where CategoryCode=" & strCode)(0)
	strCategory = strCategory & ""
end if	
	

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

<title>Master - Product category</title><body topmargin="0" leftmargin="0" Rightmargin="0" bottommargin="0">
<!--#include file="Top1.asp"-->
<form name="frmMaster" method="post" action="CategoryNameInfo.asp" onSubmit="JavaScript:return FormSubmit();">
        <input type=hidden name=hdCode value="<%=strCode%>">
		 <input type=hidden name=hdAction value="<%=strAction%>">

<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr> 
      <td><script language=javascript>
function FormSubmit()
{
	errStr = "The following error(s) occurred:\n";
	var CanSubmit = false;

	CanSubmit = ForceEntry(document.forms["frmMaster"].txtProdCategory,"    - Product Category name is required.");
	CanSubmit = (CanSubmit!=0)
	if (CanSubmit==false) 
	{alert(errStr);
	return false;
	}
	else
	{
		//document.frmMaster.hdAction.value ="Add";	
		document.frmMaster.action="CategoryNameInfo.asp"
		document.frmMaster.submit();
	}

}
</script>
        <script language=javascript>
	function show(p,q)

	{

		if (q==1) 

		{ 
		     document.frmMaster.hdCode.value =p;
		     document.frmMaster.action="Masters.asp";
			document.frmMaster.hdAction.value ="Edit";
		     document.frmMaster.submit()
		}

		if (q==2)

		{
			
			if (confirm("Are you sure to Delete this Product Category Name")==true)
			{
				document.frmMaster.hdCode.value =p;
				document.frmMaster.hdAction.value ="Del";
				document.frmMaster.action = "CategoryNameInfo.asp";
				document.frmMaster.submit()
			}		 			
		}

	}
</script> 
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" >
              <table width=100% border=0 align=Center class="Border">
                <tr align="left"> 
                  <td Colspan=2 class="HeadingWithBackGround">Master - Product 
                    Category</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="18%" align=right class="contact"><strong>Product 
                    category </strong></td>
                  <td width="63%"> <font color="#666666">
                    <input name="txtProdCategory" type="text" class="TextBox" maxlength="100" value="<%=strCategory%>">
                    </font></td>
                </tr>
                <tr class="TableBackGround"> 
                  <td></td>
                  <td><input type=Submit name=btnOk value="<%if len(strCategory)=0 then response.write "  Add  " else response.write "  Update  "%>" class=Buttons> 
                    <input type=Reset name=btnCancel value=" Cancel " class=Buttons onClick='javascript:history.back();'></td>
                </tr>
              </table></td>
          </tr>
        </table>
       <% if Request.QueryString("mode")=4 then
			Response.Write("<Div align=center><br><font Color=red>Master reference found can not delete this product</font></Div>")
			end  if %>
              <br>
	    <br>
        <% Dim sql, i

	sql="select * from mProdCategory order by CategoryCode"
	set Rsmain=Server.CreateObject("Adodb.RecordSet")
	Rsmain.Open sql,conn,3,2
	Response.write "<table width=""80%"" border=1 cellspacing=0 cellpadding=2 align=center>"
	Response.write "<tr bgcolor=lightgrey><td class=tablehead> Sr.no.</td>"
	Response.write "<td class=tablehead>Product category </td>"
	Response.write "<td class=tablehead> Edit/Delete </td> </tr>"

	do while not Rsmain.EOF
		i=i+1
		Response.write "<tr> <td> " & i & "</td>"
		Response.write "<td><b> " & Rsmain("CategoryName") & "</b></td>"
		Response.write "<td> <a href='javascript:show(" & Rsmain("CategoryCode") & ",1);' class=""link3"">"
		Response.write "Edit</a> | "
		Response.write "<a href='javascript:show(" & Rsmain("CategoryCode") & ",2);' class=""link3"">"
		Response.write "Delete </a></td></tr>"
		Rsmain.movenext
	loop

	Response.write "</table>"

%>
      </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
  </tr>
</table>
</form>
</body>
</html>
