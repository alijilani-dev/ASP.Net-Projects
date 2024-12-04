<SCRIPT TYPE="text/javascript" LANGUAGE="JavaScript">
// Create an instance of the XML HTTP Request object
var oXMLHTTP = new ActiveXObject( "Microsoft.XMLHTTP" );
var userid;	
function validate(flag) 
{
	userid = document.frmSubs.txtName.value;
	// Prepare the XMLHTTP object for a HTTP POST to our validation ASP page
	
	var sURL;
	if (flag==1)
	{
		sURL= "exists.asp?userid=" + userid + "&mailid=" + document.frmSubs.txtEMail.value;
	}
	else if (flag==2)
	{
		sURL= "subscriber.asp?Process=Add&userid=" + userid + "&mailid=" + document.frmSubs.txtEMail.value + "&mobile=" + document.frmSubs.txtMobile.value;
	}
	//alert(sURL);
	//location=sURL;
	//frmSubs.submit 
	document.body.style.cursor='wait';
	oXMLHTTP.open( "POST", sURL, false );
		
	// Define an event handler for processing
	oXMLHTTP.onreadystatechange = StateCheck;
		
	// Execute the request
	try 
	{
		oXMLHTTP.send();
	}
	catch (e) 
	{
		alert("Could not validate your User ID at this time." + e);		
		document.all.item("txtEMail").focus;
	}
}

function StateCheck() 
{
	switch (oXMLHTTP.readyState) 
	{
	case 2, 3:
	// user that you are checking to see if the UserID exists
	//	alert("Internal error occured");
		break;
	
	case 4:
		if (oXMLHTTP.responseText == "Exists") 
		{
			alert("Sorry - the User Name " + userid + " with the same Email Id already exists.");
			document.frmSubs.txtName.value="";
			document.frmSubs.txtEMail.value="";
			document.frmSubs.txtMobile.value="";
			document.frmSubs.txtName.focus
		}
		if (oXMLHTTP.responseText == "Registered") 
		{
			alert("Welcome " + userid + " Thank you for subscribing with us!!!.");
			document.frmSubs.txtName.value="";
			document.frmSubs.txtEMail.value="";
			document.frmSubs.txtMobile.value="";
			document.frmSubs.txtName.focus; 
		}
		/*else
		/{
			alert(oXMLHTTP.responseText);
		}*/
		
		break;
		
	}	
	document.body.style.cursor='auto';
}
</SCRIPT>
