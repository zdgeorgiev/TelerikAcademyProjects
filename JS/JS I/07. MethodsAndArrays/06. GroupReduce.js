const persons = [
    { fn: "Aleksandra", age: 18, gender: true },
    { fn: "Boris", age: 39, gender: true },
    { fn: "Anna", age: 55, gender: true },
    { fn: "Valio", age: 22, gender: true }
]

function reducePersons(persons) {

    return persons.reduce(function (prev, curr) {
        if (prev.hasOwnProperty(curr.fn.charAt(0)))
            prev[curr.fn.charAt(0)].push(curr.fn);
        else
            prev[curr.fn.charAt(0)] = [curr.fn];

        return curr = prev;
    }, []);
}

console.log(reducePersons(persons));