function solve(maze) {

    const rows = +maze[0].split(' ')[0],
        cols = +maze[0].split(' ')[1];

    let matrix = [],
        visited = [],
        currentRow = [],
        row = +(rows / 2) | 0,
        col = +(cols / 2) | 0;

    for (i = 0; i < rows; i++) {
        currentRow = [];

        for (const j of maze[i + 1].split(' '))
            currentRow.push(j);

        visited.push(new Array(cols).fill(false));
        matrix.push(currentRow);
    }

    while (true) {

        let currentNumber = matrix[row][col],
            moved = false;

        for (let i = 0; i < 4; i++) {

            if ((+currentNumber & 1 << i) !== 0) {

                let nextRow = row,
                    nextCol = col;

                switch (i) {
                    case 0: nextRow--; break;
                    case 1: nextCol++; break;
                    case 2: nextRow++; break;
                    case 3: nextCol--; break;
                }

                if (nextRow >= rows || nextRow < 0 || nextCol >= cols || nextCol < 0) {
                    return `No rakiya, only JavaScript ${row} ${col}`;
                }

                if (visited[nextRow][nextCol]) {
                    continue;
                }

                visited[row][col] = true;
                row = nextRow;
                col = nextCol;
                moved = true;

                break;
            }
        }

        // Reached final state
        if (!moved) {
            return `No JavaScript, only rakiya ${row} ${col}`;
        }
    }
}

console.log(solve([
    '5 7',
    '9 5 3 11 9 5 3',
    '10 11 10 12 4 3 10',
    '10 10 12 7 13 6 10',
    '12 4 3 9 5 5 2',
    '13 5 4 6 13 5 6'
]));