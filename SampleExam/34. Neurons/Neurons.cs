using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Neurons
{
    static void Main(string[] args)
    {
        long[] numbers = new long[10000];
        int countttt = 0;

        for (int i = 0; i < 10000; i++)
        {
            Int64 number = Int64.Parse(Console.ReadLine());
            numbers[i] = Math.Abs(number);

            if (number == -1)
            {
                break;
            }
            else
            {
                countttt++;
            }
        }
        int[,] matrix = new int[countttt, 32];

        //Get the map
        for (int row = 0; row < countttt; row++)
        {
            for (int col = 0; col < 32; col++)
            {
                if (((numbers[row] >> 31 - col) & 1) != 0)
                {
                    int nextCellCol = col + 1;

                    for (int j = nextCellCol; j < 32 - 1; j++)
                    {
                        if (((numbers[row] >> 31 - j) & 1) == 0)
                        {
                            matrix[row, j] = 1;
                        }
                    }
                }
            }
        }

        int index = 0;
        for (int i = 0; i < countttt; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                while (j < 32)
                {
                    if (matrix[i, j] == 0 && j != 31)
                    {
                        index = j;
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int c = index; c < 32; c++)
            {
                matrix[i, c] = 0;
            }
        }


        for (int q = 0; q < countttt; q++)
        {
            StringBuilder currentNumber = new StringBuilder();
            for (int d = 0; d < 32; d++)
            {
                currentNumber.Append(matrix[q, d]);
            }
            Console.WriteLine(Convert.ToInt64(currentNumber.ToString(), 2));

        }
        //PrintTheMatrix(matrix);
    }

    private static void PrintTheMatrix(int[,] matrix)
    {
        for (int row = 0; row < 14; row++)
        {
            for (int col = 0; col < 32; col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}