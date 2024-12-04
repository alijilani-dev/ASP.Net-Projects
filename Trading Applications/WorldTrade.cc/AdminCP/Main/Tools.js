function CreateButton(szName, szText, szWidth)
	{
	document.write("<td style='text-align: center; width: " + szWidth + "; cursor: default; border-style: solid; border-width: 1px; border-color: #DBD8D1;' ");
	document.write("name='" + szName + "' id='" + szName + "' ");
	document.write("onmouseover='ButtonOver(this)' ");
	document.write("onmouseout='ButtonOut(this)' ");
	document.write("onmousedown='ButtonDown(this)' ");
	document.write("onmouseup='ButtonUp(this)' ");
	document.write(">\n");
	document.write(szText + "\n");
	document.write("</td>\n");
	}
	
function CreateCombo(szName, szAction, szWidth)
	{
	document.write("<td style='width: " + szWidth + "px;' style='cursor: default; padding: 1px;'>");
	document.write("<select style='width: 100%;' name='" + szName + "' id='" + szName + "' size='1' ");
	document.write("onChange='ComboAction(this, this.options[this.selectedIndex].innerText)'");
	document.write(">");
	document.write("</select>")
	document.write("</td>");
	}

function ComboAction(el, szChoice)
	{
	switch(el.id)
		{
		case "cmbFontFamily":
			idEditing.document.execCommand("FontName", false, szChoice);
			break;
		case "cmbFontSize":
			idEditing.document.execCommand("FontSize", false, szChoice);
			break;
		}
	}

function CreateComboEle(eCombo, szText, szValue)
	{
	var oOption = document.createElement("OPTION");
	oOption.text=szText;
	oOption.value=szValue;
	oOption.style.fontFamily = "Verdana";
	oOption.style.fontSize = "8pt";
	oOption.style.backgroundColor = "#F9F9F9";
	document.all(eCombo).add(oOption);
	}
	
function CreateSeperator()
	{
	document.write("<td style='width: 2px;'>");
	document.write("<img src='Images/tools/seperator.gif'>");
	document.write("</td>");
	}


function CreateColorButton()
	{
	document.write("<td style='width: 2px;'>");
	document.write("<a href='#'><img src='Images/tools/color.gif' ");
	document.write("onClick='window.open(\"color.htm\",\"Color\",\"width=400,height=300\")'");
	document.write("border='0' alt='Select Color'></a>");
	document.write("</td>");
	}
	
function ButtonOver(el)
	{
	el.style.backgroundColor = "#B6BDD2";
	el.style.borderColor = "#0A246A";
	}
	
function ButtonDown(el)
	{
	el.style.backgroundColor = "#8592B5";
	}
	
function ButtonUp(el)
	{
	el.style.backgroundColor = "#B6BDD2";
	runHandler(el.id);
	}
	
function ButtonOut(el)
	{
	el.style.backgroundColor = "transparent"; //modified by basheer
	//el.style.backgroundColor = "#CCCCCC";
	el.style.borderColor = "#DBD8D1";
	}