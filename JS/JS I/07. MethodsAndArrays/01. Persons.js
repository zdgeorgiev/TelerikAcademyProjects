function createPerson(fn, ln, age, gender) {
    return {
        fn: fn,
        ln: ln,
        age: age,
        gender
    };
}

function create10Persons() {
    arr = [];
    for (let i = 0; i < 10; i++) {
        arr.push(createPerson(i, i, i + 10, true));
    }
    return arr;
}

console.log(create10Persons());