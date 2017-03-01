function solve(args) {

    let arr = new Array(+args[0]);

    for (let i = 0; i < arr.length; i++)
        arr[i] = i * 5;

    for (const i of arr)
        console.log(i);
}