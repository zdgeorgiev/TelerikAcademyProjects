using System;

class TicTacToe
{
    private static int firstPlayerWins, secondPlayerWins, draw;
    private static char nextTurn = 'X';

    static void Main(string[] args)
    {
        char[,] table = new char[3, 3];

        for (int i = 0; i < 3; i++)
        {
            string currentLine = Console.ReadLine();

            for (int j = 0; j < currentLine.Length; j++)
            {
                table[i, j] = currentLine[j];
            }
        }

        NextTurn(table, nextTurn);

        Console.WriteLine(firstPlayerWins);
        Console.WriteLine(draw);
        Console.WriteLine(secondPlayerWins);
    }

    static void NextTurn(char[,] table, char nextTurn)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (table[row,col] == '-')
                {
                    table[row, col] = nextTurn;

                    CheckForWinner(table);

                    nextTurn = ChangeNextTurn(nextTurn);

                    NextTurn(table, nextTurn);
                }
            }
        }
    }

    private static void CheckForWinner(char[,] table)
    {
        int firstPlayer = 0;
        int secondPlayer = 0;

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 1; col++)
            {
                if (table[row, col] == table[row, col + 1] &&
                    table[row, col] == table[row, col + 2])
                {
                    if (table[row, col] == 'X')
                    {
                        firstPlayer++;
                    }
                    else if (table[row,col] == 'O')
                    {
                        secondPlayer++;
                    }
                }
            }
        }

        for (int row = 0; row < 1; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (table[row, col] == table[row + 1, col] &&
                    table[row, col] == table[row + 2, col])
                {
                    if (table[row, col] == 'X')
                    {
                        firstPlayer++;
                    }
                    else if (table[0, 0] == 'O')
                    {
                        secondPlayer++;
                    }
                }
            }
        }

        if (table[0, 0] == table[1, 1] &&
            table[0, 0] == table[2, 2])
        {
            if (table[0, 0] == 'X')
            {
                firstPlayer++;
            }
            else if(table[0,0] == 'O')
            {
                secondPlayer++;
            }
        }

        if (table[0, 2] == table[1, 1] &&
            table[0, 2] == table[2, 0])
        {
            if (table[0, 2] == 'X')
            {
                firstPlayer++;
            }
            else if(table[0,0] == 'O')
            {
                secondPlayer++;
            }
        }

        bool isDraw = true;

        if (firstPlayer == 0 &&
            secondPlayer == 0)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (table[row,col] == '-')
                    {
                        isDraw = false;
                    }
                }
            }
        }

        if (isDraw)
        {
            draw++;
        }

        firstPlayerWins += firstPlayer;
        secondPlayerWins += secondPlayer;
    }

    private static char ChangeNextTurn(char currentTurn)
    {
        if (currentTurn == 'X')
        {
            return 'O';
        }
        else
        {
            return 'X';
        }
    }
}
