using System;

class Pillars
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[8, 8];
        int row = 0;

        for (int i = 0; i < 8; i++)
        {
            int n = int.Parse(Console.ReadLine());

            for (int col = 0; col < 8; col++)
            {
                if (((n >> 7 - col) & 1) != 0)
                {
                    matrix[row, col] = 1;
                }
            }

            row++;
        }

        int leftCount = 0;
        int rightCount = 0;
        int lineCol = 0;

        while (lineCol <= 7)
        {
            for (int col = 0; col < 8; col++)
            {
                for (int r = 0; r < 8; r++)
                {
                    if (col < lineCol && matrix[r, col] == 1)
                    {
                        leftCount++;
                    }
                    else if (col > lineCol && matrix[r, col] == 1)
                    {
                        rightCount++;
                    }
                }
            }

            if (leftCount == rightCount)
            {
                Console.WriteLine(7 - lineCol);
                Console.WriteLine(leftCount);
                return;
            }
            else
            {
                leftCount = 0;
                rightCount = 0;
                lineCol++;
            }
        }

        if (leftCount == 0 && rightCount == 0)
        {
            Console.WriteLine("No");
        }

        //PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}