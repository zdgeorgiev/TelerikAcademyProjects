function solve(people) {

    let minAge = Number.MAX_SAFE_INTEGER,
        index;

    for(let i = 0; i < people.length; i++) {
        if(+people[i]['age'] < minAge) {
            minAge = +people[i]['age'];
            index = i;
        }
    }

    console.log(`${people[index]['firstname']} ${people[index]['lastname']}`);
}

const people = [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'John', lastname: 'Doe', age: 42 }
];

solve(people);