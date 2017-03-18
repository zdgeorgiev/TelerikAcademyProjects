function solve(arr) {
    let result = +arr[1],
        i = 2;

    if (+arr[1] % 2 === 0)
        i++;

    for (; i < arr.length; i++) {

        if (+arr[i] % 2 !== 0) {
            result *= arr[i];
        } else {
            result += +arr[i];
            i++;
        }

        if (result > 1024)
            result %= 1024;
    }

    return result;
}

console.log(solve([
  '10',
  '1',
  '2',
  '3',
  '4',
  '5',
  '6',
  '7',
  '8',
  '9',
  '0'
]));

console.log(solve([
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9'
]));