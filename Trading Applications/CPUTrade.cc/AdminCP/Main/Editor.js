function Init()
	{
	// Windows resizing stuff
	//window.onresize = hteResize;
	//document.all.idEditing.style.pixelHeight = document.body.clientHeight - document.all.idToolbar.offsetHeight - 2;
			
	// Turn on design mode
	idEditing.document.designMode = "on";
	}

function hteResize()
	{
	document.all.idEditing.style.pixelHeight = document.body.clientHeight - document.all.idToolbar.offsetHeight - 2;
	}

function doFormat(szWhat, szHow)
	{
	// Get selection
	var oSel = doGetSelection();
	var sType = oSel.type;
	var oTarget = (sType == "None" ? idEditing.document : oSel);
	idEditing.focus();
	
	// Apply formatting
	oTarget.execCommand(szWhat, false, szHow);
	
	// Restore selection
	RestoreSelection();
	idEditing.focus();
	}

function runHandler(btnID)
	{
	switch(btnID)
		{
		// Save
		case "btnSave":
			break;
		
		// Clipboard
		case "btnCut":
			doFormat("Cut", null);
			break;
		case "btnCopy":
			doFormat("Copy", null);
			break;
		case "btnPaste":
			doFormat("Paste", null);
			break;
		
		// Formatting
		case "btnBold":
			doFormat("Bold", null);
			break;
		case "btnItalic":
			doFormat("Italic", null);
			break;
		case "btnUnderline":
			doFormat("Underline", null);
			break;

		// Justification
		case "btnLeft":
			doFormat("JustifyLeft", null);
			break;
		case "btnCenter":
			doFormat("JustifyCenter", null);
			break;
		case "btnRight":
			doFormat("JustifyRight", null);
			break;
		case "btnJustify":
			doFormat("JustifyFull", null);
			break;

		// Blocks
		case "btnNumbered":
			doFormat("InsertOrderedList", null);
			break;
		case "btnBulletted":
			doFormat("InsertUnorderedList", null);
			break;
		case "btnIndent":
			doFormat("Indent", null);
			break;
		case "btnOutdent":
			doFormat("Outdent", null);
			break;

		// Other
		case "btnHyperlink":
			//alert("Link");
			var oSel = doGetSelection();
			var sType = oSel.type;
			var oTarget = (sType == "None" ? idEditing.document : oSel);
			idEditing.focus();
		
			// Apply formatting
			oTarget.execCommand("CreateLink");

			//doFormat("CreateLink",null);
			break;
		
		}
	}

function RestoreSelection() 
{
	if (this.selection) this.selection.select()
}

function doGetSelection() 
{
	var oSel = this.selection
	if (!oSel)
		{
		oSel = idEditing.document.selection.createRange()
		oSel.type = idEditing.document.selection.type
		}
	return oSel
}