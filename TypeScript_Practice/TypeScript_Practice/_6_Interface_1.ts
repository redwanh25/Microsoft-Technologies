interface Employee {
    name: string;
    code: number;
}

let employee1 = <Employee>{};
employee1.name = "John"; // OK
employee1.code = 123; // OK
console.log(employee1.name); //Output: number




console.log();