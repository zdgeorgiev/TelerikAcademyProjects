function solve(args) {

    const a = +args[0],
        b = +args[1],
        c = +args[2];

    let aa = 0, bb = 0, cc = 0;

    if(a >= b) {
        `${a > c ? aa = a : cc = c}`;
    } else if(b >= c) {
        `${b > a ? bb = b : aa = a}`;
    } else if(c >= a) {
        `${c > b ? cc = c : bb = b}`;
    }

    if(aa)
        console.log(`${aa} ${b > c ? b : c} ${b > c ? c : b}`)
    else if(bb)
        console.log(`${bb} ${a > c ? a : c} ${a > c ? c : a}`)
    else if(cc)
        console.log(`${cc} ${b > a ? b : a} ${b > a ? a : b}`)
}