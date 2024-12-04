<%@ Language=VBScript %>
<!-- #Include File = "../Global/MainSrc.asp" -->
<% Dim rsMain, rsTemp
set rsMain = Server.CreateObject("Adodb.Recordset")
set rsTemp = Server.CreateObject("Adodb.Recordset")
dim ModelNo, ManufCode
ModelNo = Request.QueryString("Model")
ManufCode = Request.QueryString("Manuf")
if len(Session("sLogmein"))=0 then
	Response.Redirect "../Login.asp"	
end if

%>
<html>
<head>
<title>Image Upload</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<link href="../Global/MyStyle.CSS" rel="stylesheet" type="text/css">
<script language='javascript' src=../Global/valid.js></script>
</head>

<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<table width="100%" border="0" align="center" cellpadding="0" cellspacing="0" class="contact">
  <tr>
    <td>
    <form name="frmImage" method="post" encType="multipart/form-data" action="Upload.asp" onSubmit="JavaScript:return FormSubmit();">
<input type=hidden name="hdCbo">
<script language=javascript>
function FormSubmit()
{
	errStr = "The following error(s) occurred:\n";
	var CanSubmit = false;
	x = document.frmImage.cboModel.value;
	CanSubmit = DefaultCheck(x,"    - Model name is required.");	
	CanSubmit = CanSubmit & ForceEntry(document.forms["frmImage"].imgFile1,"    - Main Image is required.");
	CanSubmit = CanSubmit & ForceEntry(document.forms["frmImage"].imgFile2,"    - Small Image is required.");		
	CanSubmit = (CanSubmit!=0)
	if (CanSubmit==false) 
	{alert(errStr);
	return false;
	}
	else
	{
		//document.frmImage.hdModelNo.value = document.frmImage.cboModel.value;
		//document.frmImage.hdManufCode.value = document.frmImage.cboManuf.options[document.frmImage.cboManuf.selectedIndex].value;
		//alert(document.frmImage.hdModelNo.value);
		//alert(document.frmImage.hdManufCode.value);
		//document.frmImage.hdAction.value="Add";
		document.frmImage.hdCbo.value = document.frmImage.cboModel.value+'*';
		document.frmImage.action="Upload.asp"
		document.frmImage.submit();
	}

}
</script>
<% 
dim strMode
strMode=Request.QueryString("mode")
if strMode="1" then Response.Write "<p align=center><font color=Red size=2>Images has been successfully uploaded.</font></p>"
%>
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0" class="Border2">
          <tr> 
            <td><table width="100%" border="0" cellpadding="2" cellspacing="0" class="contact">
                <tr> 
                  <td class="HeadingBackGroundLeft">Step 2: provide images</td>
                </tr>
              </table></td>
          </tr>
        </table>
        <br>
        
        <table width="60%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr> 
            <td width="100%" bgcolor="#FFFFFF" class="LightBackground"><table width=100% border=0 align=Center class="Border">
                <tr align="left"> 
                  <td Colspan=3 Class=HeadingBackGroundLeft>Upload Images</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td width="14%" align=right class="contact">Manufacturer</td>
                  <td width="59%">
                    <select name=cboManuf class=Textbox onChange="changeinfo(this);">
          <% 
			sql="SELECT mManufacturer.ManufCode, mManufacturer.ManufName, mMobileModel.ModelNo, " & _
				"mMobileModel.ModelNo " & _
				"FROM mManufacturer INNER JOIN mMobileModel " & _
				" ON mManufacturer.ManufCode = mMobileModel.ManufCode " & _
				" Order by mManufacturer.ManufName, mManufacturer.ManufCode"			
			set rsTemp=conn.execute(sql)
			' write the Program code for the javascript...fn change()

			strFn = "function changeinfo(cbo){" & vbCrlf & _
					" var x; " & vbCrLf & "x=cbo.options[cbo.selectedIndex].text;" 
					
			strFn=strFn & "for (var i = document.frmImage.cboModel." & _
				"options.length; i >= 0; i--){" & vbCrlf & _
				"document.frmImage.cboModel.options[i] = null;" & vbCrlf
			strFn = strFn & "}" & vbCrlf & _
				"if (cbo.options[cbo.selectedIndex].value==0" & "){" & vbCrlf 
			strFn = strFn & "document.frmImage.cboModel.options[" & _
				"document.frmImage.cboModel.options.length] = new Option('Select Category','0');" & vbCrlf				
			if not rsTemp.EOF then
				rsTemp.MoveFirst 
				do while not rsTemp.EOF
					If strName <> rsTemp("ManufName") Then
					  ' if so, add an entry to the first listbox
					  strName = rsTemp("ManufName")
					  Response.Write "<OPTION VALUE=" & rsTemp("ManufCode") & ">" & strName & "</OPTION>"
					  ' and combine the javascript...fn change with the new element
					  strFn = strFn & "}" & vbCrlf & _
					    "if (cbo.options[cbo.selectedIndex].value==" & _
							rsTemp("ManufCode") & "){" & vbCrlf
					End If
					strFn = strFn & "document.frmImage.cboModel.options[" & _
						"document.frmImage.cboModel.options.length] = new Option('" & _
						rsTemp("ModelNo") & "','" & rsTemp("ModelNo") & "');" & vbCrlf
					rsTemp.MoveNext 						
				loop 
			else
				strFn = strFn & "document.frmImage.cboModel.options[" & _
						"document.frmImage.cboModel.options.length] = new Option('Select Category','0');" & vbCrlf
			end if
			strFn = strFn & vbCrlf & "}" & vbCrlf & "}" & vbCrlf
			Response.Write "<SCRIPT LANGUAGE=""JavaScript"">" & vbCrlf
			Response.Write strFn & vbCrlf & "</SCRIPT>" & vbCrlf
			rsTemp.Close
			Set rsTemp = Nothing
			%>
        </select>
		 <SCRIPT LANGUAGE=javascript>
		value = "<%=ManufCode%>" 
		for (i=0;i<document.frmImage.cboManuf.length;i++)
		if (document.frmImage.cboManuf.options[i].value==value)
			document.frmImage.cboManuf.selectedIndex = i;
		</SCRIPT>

                   </td>
                  <td width="27%">&nbsp;</td>
                </tr>
                
                <tr Class=TableBackGround> 
                  <td width="14%" align=right class="contact">Model </td>
                  <td width="59%">
                    <select name=cboModel class=Textbox>          
                            <%
                            if len(ManufCode)>0 and len(ModelNo)>0 then 
                             set rsTemp  = conn.Execute("select * from mMobileModel where ManufCode=" & ManufCode & " order by ModelNo")
								rsTemp.MoveFirst 
							do while not rsTemp.EOF  
							%>
                            <option value=<%=rsTemp("ModelNo")%>><%=rsTemp("ModelNo")%></option>
                            <% rsTemp.MoveNext 
						loop 
						set rsTemp=nothing 
						%>
						<%else%>
						<SCRIPT LANGUAGE=javascript>
						document.frmImage.cboModel.options[document.frmImage.cboModel.options.length] = new Option('[--Select--]','select');
						</script>						
						<%end if%>
                    </select>

		 <SCRIPT LANGUAGE=javascript>
		value = "<%=ModelNo%>" 
		for (i=0;i<document.frmImage.cboModel.length;i++)
		if (document.frmImage.cboModel.options[i].value==value)
			document.frmImage.cboModel.selectedIndex = i;
		</SCRIPT>

                    </td>
                  <td width="27%">&nbsp;</td>
                </tr>

                <tr Class=TableBackGround> 
                  <td width="14%" align=right class="contact"><strong>Main Image</strong>* 
                  </td>
                  <td width="59%"><INPUT name="imgFile1" type="File" class=buttons id="imgFile1" style="width: 250px;">
                    <font color="#666666"> <span class="contact">Size (275 x 275)</span></font></td>
                  <td width="27%"><%
                  'if rsMain.State then rsMain.Close
                  'rsMain.Open "Select ImgFile1 from mMobileModel where ModelNo='" & ModelNo & "'",conn,3,2
				  'if len(rsMain("ImgFile1")&"")>0 then response.Write "<a href=""javascript:show('" & rsMain("ModelNo") & "');"" class=""link3"">View image</a>"
				  %>&nbsp;</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact"><strong>Small Image</strong>*</td>
                  <td><INPUT name="imgFile2" type="File" class=buttons id="imgFile2" style="width: 250px;">
                    <font color="#666666"> <span class="contact">Size (70 x 70) 
                    </span></font> </td>
                  <td>&nbsp;</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Image 3</td>
                  <td><INPUT name="imgFile3" type="File" class=buttons id="imgFile3" style="width: 250px;">
                    <font color="#666666"> <span class="contact">Size (275 x 275) 
                    </span></font> </td>
                  <td>&nbsp;</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Image 4</td>
                  <td><INPUT name="imgFile4" type="File" class=buttons id="imgFile4" style="width: 250px;">
                    <font color="#666666"> <span class="contact">Size (275 x 275) 
                    </span></font> </td>
                  <td>&nbsp;</td>
                </tr>
                <tr Class=TableBackGround> 
                  <td align=right class="contact">Image 5</td>
                  <td><INPUT name="imgFile5" type="File" class=buttons id="imgFile5" style="width: 250px;">
                    <font color="#666666"> <span class="contact">Size (275 x 275) 
                    </span></font> </td>
                  <td>&nbsp;</td>
                </tr>
                <tr height=2> 
                  <td colspan="3" align=right class="HeadingWithBackGround"></td>
                </tr>
                <tr> 
                  <td class="LightBackground"></td>
                  <td class="LightBackground"> <input type=Submit name=btnOk value="  Upload  " class=Buttons> 
                    <input type=Reset name=btnCancel value=" Cancel " class=Buttons onClick='javascript:history.back();'> 
                  </td>
                  <td class="LightBackground">&nbsp;</td>
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
