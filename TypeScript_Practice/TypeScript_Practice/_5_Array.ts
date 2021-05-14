//let fruits: string[] = ['Apple', 'Orange', 'Banana'];
let fruits: Array<string> = ['Apple', 'Orange', 'Banana'];

for (var index in fruits) {
    console.log(index);  // output: 0, 1, 2
}

for (var value of fruits) {
    console.log(value);  // output: Apple Orange Banana
}

console.log();