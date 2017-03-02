function solve(args) {

    const size = args.shift(),
        target = +args.pop();

    let count = 0;

    for(const n of args[0].split(' '))
        if(+n === target)
            count++;

    console.log(count);
}