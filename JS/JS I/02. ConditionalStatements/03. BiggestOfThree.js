function solve(args) {

    const a = +args[0],
        b = +args[1],
        c = +args[2];

    if(a >= b) {
        return `${a > c ? a : c}`;
    } else if(b >= c) {
        return `${b > a ? b : a}`;
    } else if(c >= a) {
        return `${c > b ? c : b}`;
    }
}