const persons = [
    { fn: "a", age: 18, gender: true },
    { fn: "b", age: 39, gender: true },
    { fn: "c", age: 13, gender: true },
    { fn: "d", age: 22, gender: true }
]

function averageAge(persons) {
    return persons.reduce(function (prev, curr) {
        return prev + curr.age;
    }, 0) / persons.length;
}

console.log(averageAge(persons));