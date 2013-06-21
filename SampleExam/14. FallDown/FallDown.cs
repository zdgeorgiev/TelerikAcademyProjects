using System;

class FallDown
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[8, 8];
        int currentRow = 0;

        //Get the map
        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int col = 0; col < 8; col++)
            {
                if (((number >> 7 - col) & 1) != 0)
                {
                    matrix[currentRow, col] = 1;
                }
            }

            currentRow++;
        }

        //Fall down
        for (int row = 6; row >= 0; row--)
        {
            for (int col = 0; col < 8; col++)
            {
                if (matrix[row, col] == 1)
                {
                    while (row + 1 <= 7 && matrix[row + 1, col] != 1)
                    {
                        matrix[row + 1, col] = 1;
                        matrix[row, col] = 0;
                        row++;
                    }
                }
            }
        }

        int[] newNumbers = new int[8];
        int matrixRow = 0;

        for (int i = 0; i < 8; i++)
        {
            //Get all the bits from the current line from the matrix as string
            string currentNumber = matrix[matrixRow, 0].ToString() + matrix[matrixRow, 1].ToString()
                + matrix[matrixRow, 2].ToString() + matrix[matrixRow, 3].ToString()
                + matrix[matrixRow, 4].ToString() + matrix[matrixRow, 5].ToString()
                + matrix[matrixRow, 6].ToString() + matrix[matrixRow, 7].ToString();

            newNumbers[i] = Convert.ToInt32(currentNumber, 2);

            matrixRow++;
        }

        foreach (var number in newNumbers)
        {
            Console.WriteLine(number);
        }

        //Print the matrix
        //PrintTheMatrix(matrix);
    }

    private static void PrintTheMatrix(int[,] matrix)
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