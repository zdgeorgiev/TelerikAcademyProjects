function solve(args) {

    const x = +args[0],
     y = +args[1];

    const circleX = 1,
     circleY = 1,
     circleRadius = 1.5;

    const distance = Math.sqrt(
        (circleX - x) * (circleX - x) +
        (circleY - y) * (circleY - y)).toFixed(2);
        
    let circleInfo;

    if(distance <= circleRadius)
        circleInfo = 'inside circle';
    else
        circleInfo = 'outside circle';

    const rectangleX1 = -1,
     rectangleX2 = 5,
     rectangleY1 = 1,
     rectangleY2 = -1;

    let rectangleInfo;

    if(x >= rectangleX1 && x <= rectangleX2 &&
       y >= rectangleY2 && y <= rectangleY1)
        rectangleInfo = 'inside rectangle';
    else
        rectangleInfo = 'outside rectangle';

    console.log(`${circleInfo} ${rectangleInfo}`);
}