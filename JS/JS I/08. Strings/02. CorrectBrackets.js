function areBracketsCorrect(args) {
    let equas = args[0],
        brackets = {
            '(': 0,
            ')': 0,
        };

    for (const c of equas) {
        if (c === ')') {
            if (brackets['('] < 1)
                return 'Incorrect';

            brackets['(']--;
        } else {
            brackets[c]++;
        }
    }

    return brackets['('] === 0 && brackets[')'] === 0 ? 'Correct' : 'Incorrect';
}

console.log(areBracketsCorrect(['((a+b)/5-d)']));
console.log(areBracketsCorrect([')(a+b))']));