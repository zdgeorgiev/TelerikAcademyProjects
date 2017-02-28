function solve(args) {

    const number = +args[0];

    if(number <= 1)
        return false;

    const sqrtOfNumber = Math.sqrt(number);

    for (let i = 2; i <= sqrtOfNumber; i += 1)
        if(number % i == 0)
            return false;

    return true;
}