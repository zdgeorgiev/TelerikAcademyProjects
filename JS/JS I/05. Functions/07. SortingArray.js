function solve(args) {

    let minIndex,
        temp,
        n = args.shift(),
        arr = args[0].split(' ');

    for(let i = 0; i < n - 1; i++) {
        minIndex = i;

        for(let j = i + 1; j < n; j++)
            if(+arr[minIndex] > +arr[j])
                minIndex = j;

        if(minIndex !== i) {
            temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }

    console.log(arr.join(' '));
}

solve(['6', '1 2 3 4 5 6'])