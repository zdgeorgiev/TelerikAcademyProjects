persons = [
    { fn: "a", age: 18, gender: true },
    { fn: "b", age: 19, gender: true },
    { fn: "c", age: 13, gender: true },
    { fn: "d", age: 22, gender: true }
]

function printUnderage(persons) {
    return persons
        .filter(p => p.age < 18)
        .forEach(x => console.log(x));
}

printUnderage(persons);