function solve(arr) {

    let max = Number.MIN_SAFE_INTEGER;

    for(const n of arr[0].split(" "))
         if(+n > max)
             max = n;

    return max;
}