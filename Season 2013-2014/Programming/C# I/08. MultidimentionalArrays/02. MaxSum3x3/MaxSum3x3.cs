using System;
using System.Text;

class MaxSum3x3
{
    static void Main(string[] args)
    {
        //Console.Write("Enter rows for the matrix : ");
        //int n = int.Parse(Console.ReadLine());
        //
        //Console.Write("Enter cols for the matrix : ");
        //int m = int.Parse(Console.ReadLine());
        //
        //int[,] matrix = new int[n, m];

        int[,] matrix = new int[,]
        {
            { 3, 5, 6, 8, 3, 2 },
            { 0, 1, 6, 9, 9, 9 },
            { 1, 5, 2, 9, 9, 9 },
            { 9, 1, 4, 9, 9, 9 }
        };

        int bestSum = int.MinValue;
        int currentSum = 0;
        //Find the coords for the middle number
        //from the best sequence to find others
        int numberRow = 0;
        int numberCol = 0;
        StringBuilder bestSumNumbers = new StringBuilder();

        for (int row = 1; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 1; col < matrix.GetLength(1) - 1; col++)
            {
                currentSum = matrix[row, col] + matrix[row, col - 1] + matrix[row, col + 1] +
                    matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row - 1, col + 1] +
                    matrix[row + 1, col - 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    numberRow = row;
                    numberCol = col;
                }
            }
        }

        bestSumNumbers.Append(matrix[numberRow, numberCol] + "," + matrix[numberRow, numberCol - 1] + ","
            + matrix[numberRow, numberCol + 1] + "," + matrix[numberRow - 1, numberCol - 1] + ","
            + matrix[numberRow - 1, numberCol] + "," + matrix[numberRow - 1, numberCol + 1] + ","
            + matrix[numberRow + 1, numberCol - 1] + ","  + matrix[numberRow + 1, numberCol] + ","
            + matrix[numberRow + 1, numberCol + 1]);

        Console.WriteLine("Best sum : {" + bestSumNumbers.ToString() + "} = " + bestSum);
    }
}

//Write a program that reads a rectangular matrix of size
//N x M and finds in it the square 3 x 3 that has maximal sum of its elements.