//validating EMail ID
function checkemail(str) {

		var at="@"
		var dot="."
		var lat=str.indexOf(at)
		var lstr=str.length
		var ldot=str.indexOf(dot)
		if (str.indexOf(at)==-1){
		   alert("Invalid E-mail ID")
		   return false
		}

		if (str.indexOf(at)==-1 || str.indexOf(at)==0 || str.indexOf(at)==lstr){
		   alert("Invalid E-mail ID")
		   return false
		}

		if (str.indexOf(dot)==-1 || str.indexOf(dot)==0 || str.indexOf(dot)==lstr){
		    alert("Invalid E-mail ID")
		    return false
		}

		 if (str.indexOf(at,(lat+1))!=-1){
		    alert("Invalid E-mail ID")
		    return false
		 }

		 if (str.substring(lat-1,lat)==dot || str.substring(lat+1,lat+2)==dot){
		    alert("Invalid E-mail ID")
		    return false
		 }

		 if (str.indexOf(dot,(lat+2))==-1){
		    alert("Invalid E-mail ID")
		    return false
		 }
		
		 if (str.indexOf(" ")!=-1){
		    alert("Invalid E-mail ID")
		    return false
		 }

 		 return true					
	}

//Get clients date and time
function ampmsfn(th)
{
var Hours;
var Mins;
var ampm;
var sec;
var dd;
var mm;

toDay = new Date();
	Hours = toDay.getHours();
	if (Hours >= 12) {
	ampm = " P.M.";
	}
	else {
	ampm = " A.M.";
	}

	if (Hours > 12) {
	Hours -= 12;
	}

	if (Hours == 0) {
	Hours = 12;
	}

	Mins = toDay.getMinutes();

	if (Mins < 10) {
	Mins = "0" + Mins;
	}
	
	sec=toDay.getSeconds();
	if (sec < 10) {
	sec = "0" + sec;
	}

	mm=toDay.getMonth();
	if (mm==0) mm="Jan" 
	if (mm==1) mm="Feb"
	if (mm==2) mm="Mar" 
	if (mm==3) mm="Apr"
	if (mm==4) mm="May" 
	if (mm==5) mm="Jun"
	if (mm==6) mm="Jul" 
	if (mm==7) mm="Aug"
	if (mm==8) mm="Sep" 
	if (mm==9) mm="Oct"
	if (mm==10) mm="Nov" 
	if (mm==11) mm="Dec"
	
	dd=toDay.getDay();
	if (dd==0) dd="Sun" 
	if (dd==1) dd="Mon"
	if (dd==2) dd="Tue" 
	if (dd==3) dd="Wed"
	if (dd==4) dd="Thu" 
	if (dd==5) dd="Fri"
	if (dd==6) dd="Sat"

	th.value = '' + dd + ", " + mm + " " + toDay.getDate()+ " "+toDay.getYear() + " " + Hours + ":" + Mins + ":" + sec + ampm + '';
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

//For getting Month and Date for storing CV
function cvFormat(th)
{
var dd;
var val;
var mm;

toDay = new Date();

	mm=toDay.getMonth();
	if (mm==0) mm="Jan" 
	if (mm==1) mm="Feb"
	if (mm==2) mm="Mar" 
	if (mm==3) mm="Apr"
	if (mm==4) mm="May" 
	if (mm==5) mm="Jun"
	if (mm==6) mm="Jul" 
	if (mm==7) mm="Aug"
	if (mm==8) mm="Sep" 
	if (mm==9) mm="Oct"
	if (mm==10) mm="Nov" 
	if (mm==11) mm="Dec"
	
	dd=toDay.getDate();
	val="CV" + mm + dd + toDay.getFullYear()+toDay.getHours()+ toDay.getMinutes()+ toDay.getSeconds()+"*";
	th.value=val;
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


	var errStr;
      var whitespace = " \t\n\r";

      // Check whether string s is empty.
      function isEmpty(s)
      { return ((s == null) || (s.length == 0)) }


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


      function ForceEntry(val, str) {
           var strInput = new String(val.value);

           if (isWhitespace(strInput)) {
                errStr = errStr + str + "\n";
                return false;
           } else
                return true;

      }

      function numEntry(val, str) {

           if (isNaN(x)) {
                errStr = errStr + str + "\n";
                return false;
           } else
                return true;

      }

      function DefaultCheck(val, str) {

           if (val=='select') {
                errStr = errStr + str + "\n";
                //	alert(errStr);
                return false;
           } else
                return true;

      }
      function LenCheck(val, len, str) {
		var strInput = new String(val.value);
           if (strInput.length>len) {
                errStr = errStr + str + "\n";
	               return false;
           } else
                return true;

      }

function Quote(str)// pos of the Quote
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


// To get the values for passed strings
function getAllInfo(p,Str)
{
	var ret="";
	var col=Str.split(", ");
	var loc=0;
	while (loc < col.length)
	{
		value = col[loc];
		if (p==1)
		{
			for (i=0;i<Network.length;i++)
			{	if (Network[i]==value)
					ret = ret + "\\ " + NetworkInfo[i];
			}
		}
		else if (p==2)
		{
			for (i=0;i<Ringtone.length;i++)
			{	if (Ringtone[i]==value)
					ret = ret + ", " + RingtoneInfo[i];
			}
		}
		loc+=1;
	}
	return ret.substring(1,ret.length);
	
}

