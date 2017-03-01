function solve(arr) {

    let n = arr.shift(),
        histogram = new Array(10000),
        occurs = -1,
        number;

    histogram.fill(0);

    for (const i of arr)
        histogram[+i]++;

    for (let i = 0; i < histogram.length; i++) {
        if(histogram[i] !== 0 && occurs < histogram[i]) {
            occurs = histogram[i];
            number = i;
        }
    }

    console.log(`${number} (${occurs} times)`);
}