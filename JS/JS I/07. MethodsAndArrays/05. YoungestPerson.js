persons = [
    { fn: "a", age: 18, gender: true },
    { fn: "b", age: 39, gender: true },
    { fn: "c", age: 55, gender: true },
    { fn: "d", age: 22, gender: true }
]

function find(persons) {
    return persons.sort(function (a, b) {
        return a.age - b.age;
    })[0];
}

console.log(find(persons));