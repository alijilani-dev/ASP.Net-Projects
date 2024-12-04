function chkKey(e)
{
var x;
	x=e.value;
	 for (var i=0; i < x.length; i++) 
	 {
		var c = x.charAt(i);
		if (c=="." || c==",") 
			return true;
	}
	return false;
}
function trimSpace(x)
{
	var emptySpace = / /g;
	var trimAfter = x.replace(emptySpace,"");
	return(trimAfter);
}

function textValidate(incomingString, defaultValue)
{


	if(trimSpace(incomingString).length == 0 || incomingString.search(/[^a-zA-Z]/g) != -1 || incomingString==defaultValue)
	{
		return false;
	}
	else
		return true;
	
}

function genValidate(incomingString, defaultValue)
{
 if(trimSpace(incomingString).length == 0 || incomingString==defaultValue)
	{
		return false;
	}
	else
		return true;
}

function alphanumeric(incomingString, defaultValue)
{


	if(trimSpace(incomingString).length == 0 || incomingString.search(/[^0-9a-zA-Z]/g) != -1 || incomingString==defaultValue)
	{
		return false;
	}
	else
		return true;
	
}
function numberValidate(incomingString, defaultValue)
{
if(trimSpace(incomingString).length == 0 || incomingString.search(/[^0-9\.]/g) != -1 || incomingString==defaultValue || parseInt(incomingString, 10) <= 0 )
	{
		return false;
	}
	else
		return true;	
}



//Validating all the Textboxes in the form
function ValidateTextBoxes()
	{
		var x;
		if (trim(document.frmEnquiry.txt.value==""))
		{
		alert("Please enter Message Title");
		document.frmEnquiry.txtMsgTitle.focus();
		return false;
		}
		
		x=document.frmEnquiry.cboProjName.options[document.frmEnquiry.cboProjName.selectedIndex].text;
		if (x =='Other')
		{
			if ((document.frmEnquiry.txtOther.value==null)||(document.frmEnquiry.txtOther.value==""))
			{
			alert("Please enter your Project Name");
			document.frmEnquiry.txtOther.focus();
			return false;
			}
		}

		x=document.frmEnquiry.cboProperty.options[document.frmEnquiry.cboProperty.selectedIndex].text;
		if (x=='Other')
		{
			if ((document.frmEnquiry.txtOtherProp.value==null)||(document.frmEnquiry.txtOtherProp.value==""))
			{
			alert("Please enter your Property Name");
			document.frmEnquiry.txtOtherProp.focus();
			return false;
			}
		}

/*		
		if (x =='Villas')
		{ 		
  			if ((document.frmEnquiry.txtTotArea.value==null)||(document.frmEnquiry.txtTotArea.value==""))
			{
				alert("Please enter Total land size");
				document.frmEnquiry.txtTotArea.focus();
				return (false);	
			}

  			if(isNaN(document.frmEnquiry.txtTotArea.value  ))
			{
				alert('Land size should not contain invalid characters!');
				document.frmEnquiry.txtTotArea.value ='';
				document.frmEnquiry.txtTotArea.focus();
				return false;
			}
  			if ((document.frmEnquiry.txtBuildArea.value==null)||(document.frmEnquiry.txtBuildArea.value==""))
			{
				alert("Please enter Buildup land size");
				document.frmEnquiry.txtBuildArea.focus();
				return (false);	
			}

  			if(isNaN(document.frmEnquiry.txtBuildArea.value  ))
			{
				alert('Land size should not contain invalid characters!');
				document.frmEnquiry.txtBuildArea.value ='';
				document.frmEnquiry.txtBuildArea.focus();
				return false;
			}

  		}
  		else if (x!='Land')
  		{
  			if ((document.frmEnquiry.txtBuildArea.value==null)||(document.frmEnquiry.txtBuildArea.value==""))
			{
				alert("Please enter Buildup land size");
				document.frmEnquiry.txtBuildArea.focus();
				return (false);	
			}

  			if(isNaN(document.frmEnquiry.txtBuildArea.value  ))
			{
				alert('Land size should not contain invalid characters!');
				document.frmEnquiry.txtBuildArea.value ='';
				document.frmEnquiry.txtBuildArea.focus();
				return false;
			}
		}
		*/
  		if ((document.frmEnquiry.txtPrice.value==null)||(document.frmEnquiry.txtPrice.value==""))
		{
			alert("Please enter Price");
			document.frmEnquiry.txtPrice.focus();
			return (false);	
		}

  		if(isNaN(document.frmEnquiry.txtPrice.value  ))
		{
			alert('Price size should not contain invalid characters!');
			document.frmEnquiry.txtPrice.value ='';
			document.frmEnquiry.txtPrice.focus();
			return false;
		}
		
		if (chkKey(document.frmEnquiry.txtPrice))
		{
			alert('Price size should not contain Comma(,) or Dot(.)');
			document.frmEnquiry.txtPrice.value ='';
			document.frmEnquiry.txtPrice.focus();
			return false;
		}
		
		x=document.frmEnquiry.cboCity.options[document.frmEnquiry.cboCity.selectedIndex].text;
		if (x=='Other')
		{
			if ((document.frmEnquiry.txtOtherCity.value==null)||(document.frmEnquiry.txtOtherCity.value==""))
			{
			alert("Please enter City Name");
			document.frmEnquiry.txtOtherCity.focus();
			return false;
			}
		}


		x=document.frmEnquiry.cboLocation.options[document.frmEnquiry.cboLocation.selectedIndex].text;
		if (x=='Other')
		{
			if ((document.frmEnquiry.txtOtherLoc.value==null)||(document.frmEnquiry.txtOtherLoc.value==""))
			{
			alert("Please enter Location Name");
			document.frmEnquiry.txtOtherLoc.focus();
			return false;
			}
		}
				
		/*if (document.frmEnquiry.cboCountry.value =='---')
		{
			alert("Please select Country");
			document.frmEnquiry.cboCountry.focus();
			return false;
		}*/

		x=document.frmEnquiry.cboStatus.options[document.frmEnquiry.cboStatus.selectedIndex].text;
		if (x=='Other')
		{
			if ((document.frmEnquiry.txtOtherSt.value==null)||(document.frmEnquiry.txtOtherSt.value==""))
			{
			alert("Please enter your Status properly");
			document.frmEnquiry.txtOtherSt.focus();
			return false;
			}
		}
		
  		if ((document.frmEnquiry.txtDesc.value==null)||(document.frmEnquiry.txtDesc.value==""))
		{
			alert("Please enter Description");
			document.frmEnquiry.txtDesc.focus();
			return (false);	
		}
		x=document.frmEnquiry.txtDesc.value;
		if (x.length>300)
		{
			alert("Please enter Description less than 300 characters");
			document.frmEnquiry.txtDesc.focus();
			return (false);	
		
		}
		
		ampmsfn(document.frmEnquiry.hdToday);
		document.frmEnquiry.mode.value = 1		 //For Sale
		document.frmEnquiry.action = "addProp.asp" //For Selling
		document.frmEnquiry.submit 
}
