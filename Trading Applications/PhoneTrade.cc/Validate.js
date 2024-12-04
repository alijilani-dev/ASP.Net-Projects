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


