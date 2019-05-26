// This code and the findDOM is used to detect browser
// and allow for generic code elsewhere in the javascript
// Taken from DHTML and CSS for the World Wide Web

var isDHTML = 0;
var isID = 0;
var isAll = 0;
var isLayers = 0;

if (document.getElementById) { isID = 1; isDHTML = 1;}
else { if (document.all) { isAll = 1; isDHTML = 1; }
else { browserVersion = parseInt(navigator.appVersion);
if ((navigator.appName.indexOf('Netscape') != -1) && 
   (browserVersion == 4)) {isLayers = 1; isDHTML = 1;}
}}

function findDOM(objectID,withStyle) {
  if (withStyle == 1) {
    if (isID) {
      if (document.getElementById(objectID)) {
        return (document.getElementById(objectID).style);
      }
    }
    else { if (isAll) { return (document.all[objectID].style); }
    else { if (isLayers) { return (document.layers[objectID]); }}}}
  else {
    if (isID) { return (document.getElementById(objectID)); }
  else { if (isAll) { return (document.all[objectID]); }
  else { if (isLayers) { return (document.layers[objectID]); }}}}
}


// javascript popup tech begin
// following 2 function is needed to have popup tech in client side
function findLivePageWidth() {
	if (window.innerWidth != null)
		return window.innerWidth;
	if (document.body.clientWidth != null)
		return document.body.clientWidth;
	return (null);
}
	
function popUp(evt,objectID){
	if (isDHTML) { // Makes sure this is a DHTML browser
		var livePageWidth = findLivePageWidth();
		//alert(livePageWidth);
		domStyle = findDOM(objectID,1);
		dom = findDOM(objectID,0);
		
		if ((domStyle != null) && (dom != null))
		{
			state = domStyle.visibility;
			if (dom.offsetWidth) elemWidth = dom.offsetWidth;
			else { if (dom.clip.width)	elemWidth = dom.clip.width; }
			if (state == "visible" || state == "show")  { domStyle.visibility = "hidden"; }
			else {
				if (evt.pageY) { //Calculates the position for Navigator 4 
					topVal = evt.pageY + 20;
					leftVal = evt.pageX - (elemWidth / 2) + 1; 
				}
				else { 
					if (evt.y) { // Calculates the position for IE4
						topVal = evt.y + 20 + document.body.scrollTop;					
						leftVal = evt.x - (elemWidth / 2) + document.body.scrollLeft + 1;
					}
				}
			/*If the element goes off the page to the left, this moves it back */
				if(leftVal < 2) { leftVal = 2; }
				else { 
					if ((leftVal + elemWidth) > livePageWidth) { leftVal = leftVal - (elemWidth / 2); }
				}
				//alert("document.body.offsetHeight :" + document.body.offsetHeight);			
				
				if (topVal >= (document.body.offsetHeight-100)) topVal=topVal-100;
				domStyle.top = topVal; // Positions the element from the top
				if (leftVal  < 50) 
					leftVal = leftVal + 100;
				else 
					domStyle.left = leftVal; // Positions the element from the left			
				domStyle.visibility = "visible"; // Makes the element visable 
			}
		}
	}
}
// javascript popup tech end

function popupWin(mylink, windowname)
{
	// get the browswer width and height
	if (parseInt(navigator.appVersion)>3) {
		if (navigator.appName=="Netscape") {
			winW = window.innerWidth+188-16;
			winH = window.innerHeight+190-16+30;
		}
		if (navigator.appName.indexOf("Microsoft")!=-1) {
			winW = document.body.offsetWidth+188-20;
			winH = document.body.offsetHeight+190-20+30;
		}
	}
   //alert(winW + " " + winH);
   var win = window.open(mylink, windowname, 'top='+((screen.height - winH) / 2)+',left='+(((screen.width - winW) / 2) - 10)+'+,toolbar=0 status=1,resizable=1,Width='+winW+',height='+winH+',scrollbars=1');
   win.focus();
 //return false;

}


// begion please wait tech		
function fDisplayWait(f){
  var ctlWithStyle = findDOM('pwait',1);
  if(f){
    ctlWithStyle.visibility = "visible";
  }else{
    ctlWithStyle.visibility = "hidden";
  }
}

function fBlinkIt() {
 if (!document.all) return;
 else {
   for(i=0;i<document.all.tags('blink').length;i++){
      s=document.all.tags('blink')[i];
      s.style.visibility=(s.style.visibility=='visible')?'hidden':'visible';
   }
 }
}
// end please wait tech

function popupSite(url,windowname)
{
	win=window.open( url, windowname, "status,resizable,width=900,height=600,left=25,top=75,scrollbars=yes" );
	win.focus();
}

// This following javacript function is to check or uncheck all checkboxes in the page
// Used when we need to select all checkboxes in a page

function toggleAllCheckboxes(invoker) {
    // Since ASP.NET checkboxes are really HTML input elements
    //  let's get all the inputs 
    var inputElements = document.getElementsByTagName('input');

    for (var i = 0; i < inputElements.length; i++) {
        var myElement = inputElements[i];

        // Filter through the input types looking for checkboxes
        if (myElement.type === "checkbox") {

            // Use the invoker (our calling element) as the reference 
            //  for our checkbox status
            myElement.checked = invoker.checked;
        }

    }
} 
