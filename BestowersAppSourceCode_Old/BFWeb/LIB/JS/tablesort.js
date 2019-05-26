var dom = (document.getElementsByTagName) ? true : false;
var ie5 = (document.getElementsByTagName && document.all) ? true : false;
var arrowUp, arrowDown;

if (ie5 || dom)
	initSortTable();

function initSortTable() {    
     //arrowUp = document.createElement("SPAN");
     //var tn = document.createTextNode("5");
     arrowUp = new Image(); 
     arrowUp.src = 'Lib/Images/asc.gif';
     //arrowUp.appendChild(tn);
     //arrowUp.className = "arrow";

     //arrowDown = document.createElement("SPAN");
     //var tn = document.createTextNode("6");
     arrowDown = new Image(); 
     arrowDown.src = 'Lib/Images/desc.gif';
     //arrowDown.appendChild(tn);
     //arrowDown.className = "arrow";
}



function sortTable(tableNode, nCol, bDesc, sType) {
	var tBody = tableNode.tBodies[0];
	var trs = tBody.rows;
	var a = new Array();
	
	for (var i=0; i<trs.length; i++) {
		a[i] = trs[i];
	}
	
	a.sort(compareByColumn(nCol,bDesc,sType));
	
	for (var i=0; i<a.length; i++) {
	
		//	following if clause is for fixing the sorting bug in client side			
	
		if (a[i].className == 'datacellerr')
		{
			//Do not change the class
			tBody.appendChild(a[i]);
		} else 
		{
			if ((i%2)==0) 
			{
				a[i].className='datacell';
			}
			else 
			{
				a[i].className='datacell2';
			}
			tBody.appendChild(a[i]);		
		}		
	}
}

function CaseInsensitiveString(s) {
	return String(s).toUpperCase();
}

function parseDate(s) {
	return Date.parse(s.replace(/\-/g, '/'));
}

/* alternative to number function
 * This one is slower but can handle non numerical characters in
 * the string allow strings like the follow (as well as a lot more)
 * to be used:
 *    "1,000,000"
 *    "1 000 000"
 *    "100cm"
 */

function toNumber(s) {
    return Number(s.replace(/[^0-9\.]/g, ""));
}

function compareByColumn(nCol, bDescending, sType) {
	var c = nCol;
	var d = bDescending;
	
	var fTypeCast = String;
	
	if (sType == "Number")
		fTypeCast = Number;
	else if (sType == "Date")
		fTypeCast = parseDate;
	else if (sType == "CaseInsensitiveString")
		fTypeCast = CaseInsensitiveString;

	return function (n1, n2) {
		if (fTypeCast(getInnerText(n1.cells[c])) < fTypeCast(getInnerText(n2.cells[c])))
			return d ? -1 : +1;
		if (fTypeCast(getInnerText(n1.cells[c])) > fTypeCast(getInnerText(n2.cells[c])))
			return d ? +1 : -1;
		return 0;
	};
}


function sortColumn(e) {

	var tmp, el, tHeadParent;
	var iText;

	if (ie5)
		tmp = e.srcElement;
	else if (dom)
		tmp = e.target;

	tHeadParent = getParent(tmp, "THEAD");
	el = getParent(tmp, "TD");
	var strVal = el.innerHTML;
	if (tHeadParent == null)
		return;
		
	if (el != null) {
		var p = el.parentNode;
		var i;
		
		if (el._descending)	// catch the null
			el._descending = false;
		else
			el._descending = true;
			
		if (strVal != "")	
		{
			if (strVal.lastIndexOf("descRe.gif") > 0)
			{
				el._descending = false;				
			}
		}
		
		if (tHeadParent.arrow != null) {
			if (tHeadParent.arrow.parentNode != el) {
				tHeadParent.arrow.parentNode._descending = null;	//reset sort order		
			}
			tHeadParent.arrow.parentNode.removeChild(tHeadParent.arrow);
		}
				
		if (el._descending)
			tHeadParent.arrow = arrowDown.cloneNode(true);
		else
			tHeadParent.arrow = arrowUp.cloneNode(true);

		el.appendChild(tHeadParent.arrow);

			

		// get the index of the td
		for (i=0; i<p.cells.length; i++) {
			if (p.cells[i] == el) break;
		}

		var table = getParent(el, "TABLE");
		// can't fail
		
		sortTable(table,i,el._descending, el.getAttribute("type"));
	}
}


function getInnerText(el) {
	if (ie5) return el.innerText;	//Not needed but it is faster
	
	var str = "";
	
	for (var i=0; i<el.childNodes.length; i++) {		
		switch (el.childNodes.item(i).nodeType) {
			case 1: //ELEMENT_NODE
				str += getInnerText(el.childNodes.item(i));
				break;
			case 3:	//TEXT_NODE
				str += el.childNodes.item(i).nodeValue;
				break;
		}
		
	}
	
	return str;
}

function getParent(el, pTagName) {
	if (el == null) return null;
	else if (el.nodeType == 1 && el.tagName.toLowerCase() == pTagName.toLowerCase())	// Gecko bug, supposed to be uppercase
		return el;
	else
		return getParent(el.parentNode, pTagName);
}
