function solve(args) {

    let positiveCount = 0,
        negativeCount = 0,
        hasZero = false;

    for (let i = 0; i < 3; i += 1) {
        if(!+(args[i]))
            hasZero = true;
        else if(+(args[i]) > 0)
            positiveCount += 1;
        else
            negativeCount += 1;
    }

    if(hasZero)
        console.log('0');
    else if(positiveCount == 3 || positiveCount == 1)
        console.log('+')
    else
        console.log('-');
}