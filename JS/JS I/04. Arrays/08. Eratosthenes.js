function solve(x) {

    const n = +x[0];

    let arr = new Array(n + 1),
        currentN,
        sqrtN = Math.sqrt(n);

    for(let i = 2; i <= sqrtN; i++) {

        if(arr[i] === false)
            continue;

        currentN = 2 * i;

        while(currentN <= n)
        {
            arr[currentN] = false;
            currentN += i;
        }
    }
    
    for(let i = arr.length - 1; i >= 2; i--) {
        if(arr[i] === undefined)
            return i;
    }
}

console.log(solve(['20']));