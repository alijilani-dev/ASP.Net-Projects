
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
  for(i = 0; i < 3; i++)
  {
    imgArray[i] = new Image(570, 333);
    imgArray[i].src = "Images/box" + (i+1) + ".jpg";
  }
}


function ReplaceImg() 
{
  if(counter > 2)
   counter = 0;

  document.banner.src = imgArray[counter].src; 

  //url = urls[counter]; 
  counter++; 
}


var timer = window.setInterval("ReplaceImg()",60000);
//document.write("<a href=\"#\" onClick=\"window.open(url,'AddWind');\">");
document.write("<img src=\"Images/box1.jpg\" width=570 height=333 border=0 name=\"banner\">");//</a>");

//-->

/*
<!--
var today = new Date();
var number = today.getDay() + 1;
document.write('<img src="images/Img' + number + '.jpg">');
//-->
*/


