var errStr;
var whitespace = " \t\n\r";

// Check whether string s is empty. or not
function isEmpty(s)
{ return ((s == null) || (s.length == 0)) }

//is whitespace
function isWhitespace (s)
{
	var i;
	if (isEmpty(s)) return true;

	for (i = 0; i < s.length; i++)
	{
	     // Check that current character isn't whitespace.
	     var c = s.charAt(i);
	     if (whitespace.indexOf(c) == -1) return false;
	}
	// All characters are whitespace.
	return true;
}

//Force the entry to keyin
function ForceEntry(val, str) {
     var strInput = new String(val.value);

     if (isWhitespace(strInput)) {
          errStr = errStr + str + "\n";
          return false;
     } else
          return true;

}

//Check for cbo values
function DefaultCheckText(val, val1, str) {
     if (val==val1) {
          errStr = errStr + str + "\n";
          return false;
     } else
          return true;
}

//Check for cbo values
function DefaultCheck(val, str) {
     if (val=='select') {
          errStr = errStr + str + "\n";
          return false;
     } else
          return true;
}

//Chk for the len
function LenCheck(val, len, str) {
  var strInput = new String(val.value);
     if (strInput.length>len) {
          errStr = errStr + str + "\n";
             return false;
     } else
          return true;

}

//Chk radio grp
function RadioCheck(val, str) {
  var flg=false;
	
  for (i = 0; i < val.length; i++)
  	if (val[i].checked) {flg = true;}
  	
     if (!flg) {
          errStr = errStr + str + "\n";
          return false;
     } else
          return true;
}

// pos of the Quote
function Quote(str)
{
var Pos;

Pos = str.indexOf('\'');
if(Pos!=-1)
  return true;
	
Pos = str.indexOf('\"');
if(Pos!=-1)
  return true;
		
return false
}

//Is num entry
function numEntry(val, str) {
if (isNaN(val)) {
    errStr = errStr + str + "\n";
    return false;
} else
    return true;
}


//validating EMail ID
function checkemail(val,str) {

		var at="@"
		var dot="."
		var lat=val.indexOf(at)
		var lstr=val.length
		var ldot=val.indexOf(dot)
		if (val.indexOf(at)==-1){
		   errStr = errStr + str + "\n";
		   return false
		}

		if (val.indexOf(at)==-1 || val.indexOf(at)==0 || val.indexOf(at)==lstr){
		   errStr = errStr + str + "\n";
		   return false
		}

		if (val.indexOf(dot)==-1 || val.indexOf(dot)==0 || val.indexOf(dot)==lstr){
		    errStr = errStr + str + "\n";
		    return false
		}

		 if (val.indexOf(at,(lat+1))!=-1){
		    errStr = errStr + str + "\n";
		    return false
		 }

		 if (val.substring(lat-1,lat)==dot || val.substring(lat+1,lat+2)==dot){
		    errStr = errStr + str + "\n";
		    return false
		 }

		 if (val.indexOf(dot,(lat+2))==-1){
		    errStr = errStr + str + "\n";
		    return false
		 }
		
		 if (val.indexOf(" ")!=-1){
		    errStr = errStr + str + "\n";
		    return false
		 }

 		 return true					
	}

function acceptDate(fld,obj)
{
var key;
var keychar;

if (window.event)
   key = window.event.keyCode;
else if (obj)
   key = obj.which;
else
   return true;
keychar = String.fromCharCode(key);

if ((key==null) || (key==0) || (key==8) ||
    (key==9) || (key==13) || (key==27) )
   return true;

else if ((("0123456789/").indexOf(keychar) > -1))
   return true;
else
   return false;
}


//To get the key
function getkey(e)
{
if (window.event)
   return window.event.keyCode;
else if (e)
   return e.which;
else
   return null;
}

//Fn to get chk for '
function chkKey(e)
{
var x;
	x=e.value;
	 for (var i=0; i < x.length; i++) 
	 {
		var c = x.charAt(i);
		if (c=="'") 
			return true;
	}
	return false;
}

function trim(s) {
  while (s.substring(0,1) == ' ') {
    s = s.substring(1,s.length);
  }
  while (s.substring(s.length-1,s.length) == ' ') {
    s = s.substring(0,s.length-1);
  }
  return s;
}


function trimSpace(x)
{
	var emptySpace = / /g;
	var trimAfter = x.replace(emptySpace,"");
	return(trimAfter);
}

//Validate the txt entry
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

function returnValue(inc)
{
var retVal="";
	if (inc=="1" ) retVal = "Manufacturer";
	if (inc=="2" ) retVal = "Exporter / Importer";
	if (inc=="3" ) retVal = "Dealer / Reseller";
	if (inc=="4" ) retVal = "Retailer";
	if (inc=="5" ) retVal = "Service Provider";
	if (inc=="6" ) retVal = "Freight Forwarder";	
return retVal;
}
     