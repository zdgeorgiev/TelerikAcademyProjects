function solve(obj, prop) {
    console.log(obj.hasOwnProperty(prop));
}

solve({
    name: 'zz',
    age: 0
}, 'name');