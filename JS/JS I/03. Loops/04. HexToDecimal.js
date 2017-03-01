function solve(args) {

    const BASE = 16;
    let n = 0;

    for(let i = 0; i < args[0].length; i++) {
        let currentDigit = args[0][i],
            currentStep = 0;

        currentStep = Math.pow(BASE, args[0].length - i - 1);

        if(+currentDigit !== 0 && !+currentDigit) {
            switch(currentDigit) {
                case 'A': currentStep *= 10; break;
                case 'B': currentStep *= 11; break;
                case 'C': currentStep *= 12; break;
                case 'D': currentStep *= 13; break;
                case 'E': currentStep *= 14; break;
                case 'F': currentStep *= 15; break;
            }
        } else {
            currentStep *= +currentDigit;
        }

        n += currentStep;
    }

    console.log(n);
}