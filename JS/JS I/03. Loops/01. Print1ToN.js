function solve(args) {

    const n = +args[0];
    let output = '';

    for (let i = 1; i <= n; i++)
        output += i + ' ';

    return output.trim();
}