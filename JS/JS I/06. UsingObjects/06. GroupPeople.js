function groupByAge(people) {

    let groupByAgeed = {};

    people.forEach(x => {
        if(groupByAgeed.hasOwnProperty(x['age'])) {
            groupByAgeed[x['age']].push(x);
        } else {
            groupByAgeed[x['age']] = [];
            groupByAgeed[x['age']].push(x);
        }
    });

    return groupByAgeed;
}

const people = [
  { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
  { firstname: 'Bay', lastname: 'Ivan', age: 81 },
  { firstname: 'John', lastname: 'Doe', age: 42 },
  { firstname: 'Pesho', lastname: 'Pesho', age: 22 },
  { firstname: 'Asdf', lastname: 'Xyz', age: 81 },
  { firstname: 'Gosho', lastname: 'Gosho', age: 22 }
];

console.log(groupByAge(people));