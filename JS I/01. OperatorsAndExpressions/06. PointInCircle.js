function solve(args) {

    const x = +args[0];
    const y = +args[1];

    const circleX = 0;
    const circleY = 0;
    const circleRadius = 2;

    const distance = Math.sqrt(
        (circleX - x) * (circleX - x) +
        (circleY - y) * (circleY - y)).toFixed(2);
        
    const MAX_DIFF = 0.0001;

    if(distance - circleRadius <= MAX_DIFF)
        console.log('yes ' + distance);
    else
        console.log('no ' + distance);
}