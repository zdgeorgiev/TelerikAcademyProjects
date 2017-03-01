function solve(args) {

    const a = +args[0],
        b = +args[1],
        c = +args[2],
        d = b * b - 4 * a * c,
        x1 = (( Math.sqrt(d) - b) / (2*a)).toFixed(2),
        x2 = ((-Math.sqrt(d) - b) / (2*a)).toFixed(2);

    if(d > 0) {
        +x1 > +x2 ?
            console.log(`x1=${x2}; x2=${x1}`) :
            console.log(`x1=${x1}; x2=${x2}`);
    } else if(d === 0) {
        console.log(`x1=x2=${x1}`);
    } else {
        console.log('no real roots');
    }
}