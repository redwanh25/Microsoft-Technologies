
let employee: {
    id: number;
    name: string;
};

employee = {
    id: 100,
    name: "Redwan Hossain"
}


function display(id: number, name: string) {
    console.log("Id = " + id + ", Name = " + name);
}

display(employee.id, employee.name);




console.log();