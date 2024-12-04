
<!--
var urls = new Array(3); 
var imgArray = new Array(3); 
var counter = 1;
var url = "http://www.uaeproperty.com/a.htm"; 

//add your necessary URL's
/*urls[0] = "http://www.uaeproperty.com/a.htm";
urls[1] = "http://www.uaeproperty.com/b.htm";
urls[2] = "http://www.uaeproperty.com/c.htm";
urls[3] = "http://www.uaeproperty.com/c.htm";
urls[4] = "http://www.uaeproperty.com/c.htm";
*/

if(document.images) //pre-load all banner images
{
  for(i = 0; i < 5; i++)
  {
    imgArray[i] = new Image(488, 218);
    imgArray[i].src = "Images/Img" + (i+1) + ".jpg";
  }
}


function ReplaceImg() 
{
  if(counter > 4)
   counter = 0;

  document.banner.src = imgArray[counter].src; 

  //url = urls[counter]; 
  counter++; 
}


var timer = window.setInterval("ReplaceImg()",60000);
//document.write("<a href=\"#\" onClick=\"window.open(url,'AddWind');\">");
document.write("<img src=\"Images/Img1.jpg\" width=488 height=218 border=0 name=\"banner\">");//</a>");

//-->

/*
<!--
var today = new Date();
var number = today.getDay() + 1;
document.write('<img src="images/Img' + number + '.jpg">');
//-->
*/


