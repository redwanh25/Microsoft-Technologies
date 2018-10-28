
var x = 12; 

function add() {
    alert("what the hell\n" + x);
    alert(x);
}

          // global variable 

function func1() {
    //window.x = 11;       // global variable 
    alert(x);
}
function func2() {
    var b = x * 2;
    alert(b);
}
