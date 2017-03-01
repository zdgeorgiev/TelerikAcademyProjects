function solve(args) {

    const n = +args[0];

    for (let i = 1; i <= n; i++) {
        let currentLine = '';
        for(let j = i; j < n + i; j++)
            currentLine += j + ' ';

        console.log(currentLine.trim());
    }
}