using System;

class MatrixByN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int number = 1;

        // A)

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = number;
                number++;
            }
        }
        Console.WriteLine("A)");
        PrintMatrix(n, matrix);

        // B)

        number = 1;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
        }
        Console.WriteLine("B)");
        PrintMatrix(n, matrix);

        // C)
        number = 1;
        int currentRow = n - 1;
        int currentCol = 0;
        int startRow = currentRow;      // = 3;
        int startCol = currentCol;      // = 0;

        while (number <= n * n)
        {
            while (currentRow < n && currentCol < n)
            {
                matrix[currentRow, currentCol] = number;
                number++;
                currentRow++;
                currentCol++;
            }

            if (startRow == 0)
            {
                startCol++;
            }
            else
            {
                startRow--;
            }

            currentRow = startRow;
            currentCol = startCol;
        }

        Console.WriteLine("C)");
        PrintMatrix(n, matrix);

        number = 1;
        int ending = n;
        int start = 0;
        do
        {
            for (int i = start; i < ending; i++)
            {
                matrix[i, start] = number;
                number++;
            }
            for (int j = start + 1; j < ending; j++)
            {
                matrix[ending - 1, j] = number;
                number++;
            }
            for (int k = ending - 2; k >= start; k--)
            {
                matrix[k, ending - 1] = number;
                number++;
            }
            for (int p = ending - 2; p >= start + 1; p--)
            {
                matrix[start, p] = number;
                number++;
            }
            start++;
            ending--;
        }
        while (ending - start > 0);
        {
            Console.WriteLine("D)");
            PrintMatrix(n, matrix);
        }
    }

    static void PrintMatrix(int n, int[,] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

