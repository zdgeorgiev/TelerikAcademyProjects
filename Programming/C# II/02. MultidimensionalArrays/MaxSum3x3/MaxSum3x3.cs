using System;

class MaxSum3x3
{
    static void Main()
    {
        //int[,] matrix = {
        //                    {5, 7, 7, 9, 9, 9 },
        //                    {8, 6, 8, 9, 9, 9 },
        //                    {9, 1, 7, 9, 9, 9 },
        //                    {1, 7, 1, 8, 8, 1 }
        //
        //                };
        
        Console.WriteLine("Enter the size of the matrix [n, m]");

        Console.Write("n = ");
        string Nvalue = Console.ReadLine();
        int n = int.Parse(Nvalue);

        Console.Write("m = ");
        string Mvalue = Console.ReadLine();
        int m = int.Parse(Mvalue);

        int[,] matrix = new int[n, m];

        matrix = RandomMatrix(matrix, n, m);
        Console.WriteLine();
        PrintTheMatrix(matrix, n, m);
        Console.WriteLine();
        BestSum(matrix);
    }

    static void BestSum(int[,] matrix)
    {
        int bestSum = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }
        Console.WriteLine("Best Sum From the Matrix 3x3 is {0}",bestSum);
    }

    static void PrintTheMatrix(int[,] matrix, int n, int m)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static int[,] RandomMatrix(int[,] matrix , int n, int m)
    {
        Random number = new Random();

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = number.Next(40);
            }
        }
        return matrix;
    }
}

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3
//that has maximal sum of its elements