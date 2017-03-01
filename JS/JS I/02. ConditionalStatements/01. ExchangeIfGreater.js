function solve(args) {

    let a = +args[0],
        b = +args[1];

    if(a > b)
        console.log(`${b} ${a}`);
    else
        console.log(`${a} ${b}`);
}