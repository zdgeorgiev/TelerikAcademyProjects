using System;

class LongestStringSequenceInMatrix
{
    static void Main(string[] args)
    {
        //Console.Write("Enter height of the matrix : ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("Enter width of the matrix : ");
        //int m = int.Parse(Console.ReadLine());

        //string[,] matrix = new string[n, m];

        string[,] matrix = new string[,]
        {
            {"op", "op", "xx", "ha"},
            {"xx", "xx", "ha", "xx"},
            {"hi", "ha", "hi", "op"},
            {"ha", "xx", "hi", "op"}
        };

        string bestElement = string.Empty;
        int bestSequence = 1;

        //Horizontal
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int currentSequence = 1;
                string currentElement = matrix[row, col];

                while (col < matrix.GetLength(1) - 1 && matrix[row, col] == matrix[row, col + 1])
                {
                    currentSequence++;
                    col++;
                }

                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                    bestElement = currentElement;
                }
            }
        }

        //Vertical
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int currentSequence = 1;
                string currentElement = matrix[row, col];

                while (row < matrix.GetLength(0) - 1 && matrix[row, col] == matrix[row + 1, col])
                {
                    currentSequence++;
                    row++;
                }

                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                    bestElement = currentElement;
                }
            }
        }

        //Top-Bottom Left Diagonal
        for (int roww = 0; roww < matrix.GetLength(0) - 1; roww++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int currentSequence = 1;
                string currentElement = matrix[roww, col];

                while (roww < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1 &&
                    matrix[roww, col] == matrix[roww + 1, col + 1])
                {
                    currentSequence++;
                    roww++;
                    col++;
                }

                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                    bestElement = currentElement;
                }
            }
        }

        //Top-Bottom Right Diagonal
        for (int rowww = 0; rowww < matrix.GetLength(0) - 1; rowww++)
        {
            for (int col = matrix.GetLength(1) - 1; col > 0; col--)
            {
                int currentSequence = 1;
                string currentElement = matrix[rowww, col];

                while (rowww < matrix.GetLength(0) - 1 && col > 0 &&
                        matrix[rowww, col] == matrix[rowww + 1, col - 1])
                {
                    currentSequence++;
                    rowww++;
                    col--;
                }

                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                    bestElement = currentElement;
                }
            }
        }

        PrintTheMatrix(matrix);
        Console.WriteLine("\nBEST SEQUENCE - {0} ({1}times)", bestElement, bestSequence);
    }

    static void PrintTheMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

//We are given a matrix of strings of size N x M. Sequences in
//the matrix we define as sets of several neighbor elements located
//on the same line, column or diagonal. Write a program that finds the
//longest sequence of equal strings in the matrix.