let num1: number = 1;

function letDeclaration() {
    let num2: number = 2;

    if (num2 > num1) {
        let num3: number = 3;
        num3++;
    }

    while (num1 < num2) {
        let num4: number = 4;
        num1++;
    }

    console.log(num1); //OK
    console.log(num2); //OK 
    //console.log(num3); //Compiler Error: Cannot find name 'num3'
    //console.log(num4); //Compiler Error: Cannot find name 'num4'
}

letDeclaration();

//======================================================

var num5: number = 1;

function varDeclaration(): void {
    var num6: number = 2;

    if (num6 > num5) {
        var num7: number = 3;
        num7++;
    }

    while (num5 < num6) {
        var num8: number = 4;
        num5++;
    }

    console.log(num5); //2
    console.log(num6); //2 
    console.log(num7); //4
    console.log(num8); //4
}

varDeclaration();

//========================================================
//console.log(num9); // Compiler Error: error TS2448: Block-scoped variable 'num' used before its declaration
let num9: number = 10;

console.log(num10); // OK, Output: undefined 
var num10: number = 10;

//========================================================

const playerCodes = {
    player1: 9,
    player2: 10,
    player3: 13,
    player4: 20
};
playerCodes.player2 = 11; // OK

//playerCodes = {     //Compiler Error: Cannot assign to playerCodes because it is a constant or read-only
//    player1: 50,    // Modified value
//    player2: 10,
//    player3: 13,
//    player4: 20
//};

console.log(playerCodes.player2);

console.log();


//https://www.tutorialsteacher.com/typescript/typescript-variable