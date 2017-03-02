function solve(args) {

    const size = +args.shift(),
        arr = args[0].split(' ');

    let count = 0;

    for (let i = 1; i < size - 1; i++)
        if(+arr[i - 1] < +arr[i] && +arr[i] > arr[i + 1])
            return i;

    return -1;
}