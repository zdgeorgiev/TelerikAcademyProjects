function solve(args) {

    let width = +args[0];
    let height = +args[1];

    let area = (width * height).toFixed(2);
    let perimeter = (2 * (width + height)).toFixed(2);

    console.log(area + ' ' + perimeter);
}