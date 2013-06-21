using System;

class Lines
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[8, 8];
        int roww = 0;

        for (int i = 0; i < 8; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            for (int col = 0; col < 8; col++)
            {
                if (((currentNumber >> 7 - col) & 1) != 0)
                {
                    matrix[roww, col] = 1;
                }
            }

            roww++;
        }

        int count = 0;
        int longestLine = 0;

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                int currentLine = 0;

                while (col < 8 && matrix[row, col] == 1)
                {
                    currentLine++;
                    col++;
                }

                if (currentLine == longestLine)
                {
                    count++;
                }
                if (currentLine > longestLine)
                {
                    longestLine = currentLine;
                    count = 1;
                }
            }
        }

        for (int col = 0; col < 8; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                int currentLine = 0;

                while (row < 8 && matrix[row, col] == 1)
                {
                    currentLine++;
                    row++;
                }

                if (currentLine == longestLine)
                {
                    count++;
                }
                if (currentLine > longestLine)
                {
                    longestLine = currentLine;
                    count = 1;
                }
            }
        }

        if (longestLine == 1)
        {
            count /= 2;
        }

        Console.WriteLine(longestLine);
        Console.WriteLine(count);

        //PrintMatrix(matrix);
    }

    private static void PrintMatrix(int[,] matrix)
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