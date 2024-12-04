<SCRIPT TYPE="text/javascript" LANGUAGE="JavaScript">
// Create an instance of the XML HTTP Request object
var oXMLHTTP = new ActiveXObject( "Microsoft.XMLHTTP" );
var userid;	
function validate(flag) 
{

	// Prepare the XMLHTTP object for a HTTP POST to our validation ASP page
	
	var sURL;
	if (flag==1)
	{
		userid=document.frmSubs.txtEMail.value;
		sURL= "exists.asp?userid=" + userid + "&mailid=" + document.frmSubs.txtEMail.value;
	}
	else if (flag==2)
	{
		userid=document.frmSubs.txtEMail.value;
		sURL= "subscriber.asp?Process=Add&mailid=" + document.frmSubs.txtEMail.value;
	}
	else if (flag==3)
	{
		userid = document.frmLog.txtUserName.value;
		sURL= "chkLogin.asp?UserName=" + document.frmLog.txtUserName.value + "&Pwd=" + document.frmLog.txtPwd.value;
	}

	//alert("Login:" + sURL);
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
		if (flag==2 || flag==1)
		document.all.item("txtEMail").focus;
		if (flag==3)
		document.all.item("txtUserName").focus;
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
			alert("Sorry - the Mailid " + userid + " already exists.");
			document.frmSubs.txtEMail.value="";
			document.frmSubs.txtEMail.focus
		}
		if (oXMLHTTP.responseText == "Registered") 
		{
			alert("Welcome, Thank you for subscribing with us!!!.");
			document.frmSubs.txtEMail.value="";
			document.frmSubs.txtEMail.focus
			//alert("reg");
			return true;
		}
		if (oXMLHTTP.responseText == "LoginFailed") 
		{
			alert("Sorry - Login/Password is incorrect. Please try again!");
			document.frmLog.txtUserName.value="";
			document.frmLog.txtPwd.value="";
			document.frmLog.txtUserName.focus();
		}
		if (oXMLHTTP.responseText == "NotAct") 
		{
			alert("Sorry - Your account is not activated!");
			document.frmLog.txtUserName.value="";
			document.frmLog.txtPwd.value="";
			document.frmLog.txtUserName.focus();			
		}
		if (oXMLHTTP.responseText == "LoginYes") 
		{
			//alert(oXMLHTTP.responseText + location.href);
			//return true;
			location.href="Member.asp"
		}


		/*else
		{
			alert(oXMLHTTP.responseText);
		}*/
		
		break;
		
	}	
	document.body.style.cursor='auto';
}
</SCRIPT>
