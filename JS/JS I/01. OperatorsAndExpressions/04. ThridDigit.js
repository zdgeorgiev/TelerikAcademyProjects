function solve(args) {

    if(args[0].lenght < 3)
        console.log('false 0');
    else {
        let digits = String(args).length;
        let thirdDigitIndex = digits - 3;
        let thridDigit = +(args[0].charAt(thirdDigitIndex));

        if(thridDigit === 7)
            console.log('true');
        else {
            console.log('false ' + thridDigit)
        }
    }
}