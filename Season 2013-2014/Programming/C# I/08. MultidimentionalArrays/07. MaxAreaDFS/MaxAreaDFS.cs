using System;

class MaxAreaDFS
{
    static int lenght = 0;
    //all possible directions
    static int[,] direction = new int[,] { { 1, 0 }, { 0, -1 }, { 0, 1 }, { -1, 0 } };

    static void DFS(int[,] matrix, int row, int col)
    {
        int value = matrix[row, col];
        //marked as visited
        matrix[row, col] = 0;

        lenght++;

        for (int i = 0; i < 4; i++)
        {
            int _row = row + direction[i, 0];
            int _col = col + direction[i, 1];

            if (IsTheCellAvaible(matrix, _row, _col) &&
                matrix[_row, _col] == value)
            {
                DFS(matrix, _row, _col);
            }
        }
    }

    private static bool IsTheCellAvaible(int[,] matrix, int row, int col)
    {
        return row < matrix.GetLength(0) && row >= 0 && col < matrix.GetLength(1) && col >= 0;
    }

    static void Main(string[] args)
    {
        int[,] matrix = new int[,]
        {
            {1, 3, 2, 2, 2, 4},
            {3, 3, 3, 2, 4, 4},
            {4, 3, 1, 2, 3, 3},
            {4, 3, 1, 3, 3, 1},
            {4, 3, 3, 3, 1, 1}
        };

        PrintTheMatrix(matrix);

        int bestLenght = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row,col] != 0)
                {
                    DFS(matrix, row, col);
                }

                if (lenght > bestLenght)
                {
                    bestLenght = lenght;
                }

                lenght = 0;
            }
        }

        Console.WriteLine("\nBest lenght - > {0}", bestLenght);
    }

    static void PrintTheMatrix(int[,] matrix)
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

//Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size.