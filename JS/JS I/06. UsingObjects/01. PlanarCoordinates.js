function solve(args) {

    let lines = [];

    for(let i = 0; i < args.length; i+=4)
        lines.push(
            getLineLen(createPoint(args[i]    , args[i + 1]),
                       createPoint(args[i + 2], args[i + 3])));

    lines.forEach(x => console.log(x));

    console.log(
           lines[0] + lines[1] > lines[2] &&
           lines[1] + lines[2] > lines[0] &&
           lines[0] + lines[2] > lines[1] ? 'Triangle can be built' : 'Triangle can not be built');
}

createPoint = function(x, y) {
    return {
        x: x,
        y: y
    };
}

getLineLen = function(p1, p2) {
    return Math.sqrt(Math.pow(p2.x - p1.x, 2) + Math.pow(p2.y - p1.y, 2)).toFixed(2); 
}

solve([
  '7', '7', '2', '2',
  '5', '6', '2', '2',
  '95', '-14.5', '0', '-0.123'
]);