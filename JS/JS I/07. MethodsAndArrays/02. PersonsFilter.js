const persons = [
    {fn: "a", age: 18, gender:true},
    {fn: "b", age: 19, gender:true},
    {fn: "c", age: 13, gender:true},
    {fn: "d", age: 22, gender:true}
]

function check(persons) {
    return persons.every(p => p.age >= 18);
}

console.log(check(persons));