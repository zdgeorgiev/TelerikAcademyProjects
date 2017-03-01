function solve(args) {

    let min = Number.MAX_SAFE_INTEGER,
        max = Number.MIN_SAFE_INTEGER,
        avg = 0,
        sum = 0,
        count = 0;

    for (const n of args) {

        if(+n < min)
            min = +n;
        if(+n > max)
            max = +n;

        sum += +n;
        count++;
    }

    avg = +sum;
    avg /= +count;

    console.log(`min=${min.toFixed(2)}`);
    console.log(`max=${max.toFixed(2)}`);
    console.log(`sum=${sum.toFixed(2)}`);
    console.log(`avg=${avg.toFixed(2)}`);
}