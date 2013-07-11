using System;

class MatrixByN
{
    static void Main(string[] args)
    {
        Console.Write("Enter the value for matrix height/width : ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        Console.WriteLine("\nA)");
        FillFirstMatrix(matrix);
        PrintTheMatrix(matrix);
        
        Console.WriteLine("\nB)");
        FillSecondMatrix(matrix);
        PrintTheMatrix(matrix);
        
        Console.WriteLine("\nC)");
        FillThirdMatrix(matrix);
        PrintTheMatrix(matrix);

        //Creating another matrix because for my algorithm
        //the direction is changing when the next cell is
        //filled already with number other than 0(empty cell)
        //Will cause the problem because last matrix is filled
        int[,] secondMatrix = new int[n, n];

        Console.WriteLine("\nD)");
        FillFourthMatrix(secondMatrix);
        PrintTheMatrix(secondMatrix);
    }

    static void FillFourthMatrix(int[,] matrix)
    {
        int currentNumber = 1;
        string[] directions = new string[] { "down", "right", "up", "left" };

        string currentDirection = directions[0];
        int currentRow = 0;
        int currentCol = 0;

        while (currentNumber <= matrix.GetLength(0) * matrix.GetLength(0))
        {
            if (currentDirection == "down")
            {
                while (currentRow < matrix.GetLength(0) && currentNumber <= matrix.GetLength(0) * matrix.GetLength(0))
                {
                    matrix[currentRow, currentCol] = currentNumber;
                    currentNumber++;
                    currentRow++;

                    if (currentRow == matrix.GetLength(0) || matrix[currentRow, currentCol] != 0)
                    {
                        currentDirection = directions[1];
                        currentRow--;
                        currentCol++;
                        break;
                    }
                }
            }

            if (currentDirection == "right")
            {
                while (currentCol < matrix.GetLength(1) && currentNumber <= matrix.GetLength(0) * matrix.GetLength(0))
                {
                    matrix[currentRow, currentCol] = currentNumber;
                    currentNumber++;
                    currentCol++;

                    if (currentCol == matrix.GetLength(1) || matrix[currentRow, currentCol] != 0)
                    {
                        currentDirection = directions[2];
                        currentCol--;
                        currentRow--;
                        break;
                    }
                }
            }

            if (currentDirection == "up")
            {
                while (currentRow >= 0 && currentNumber <= matrix.GetLength(0) * matrix.GetLength(0))
                {
                    matrix[currentRow, currentCol] = currentNumber;
                    currentNumber++;
                    currentRow--;

                    if (currentRow == -1 || matrix[currentRow, currentCol] != 0)
                    {
                        currentDirection = directions[3];
                        currentRow++;
                        currentCol--;
                        break;
                    }
                }
            }

            if (currentDirection == "left")
            {
                while (currentCol >= 0 && currentNumber <= matrix.GetLength(0) * matrix.GetLength(0))
                {
                    matrix[currentRow, currentCol] = currentNumber;
                    currentNumber++;
                    currentCol--;

                    if (currentCol == -1 || currentCol == 0 || matrix[currentRow, currentCol] != 0)
                    {
                        currentDirection = directions[0];
                        currentCol++;
                        currentRow++;
                        break;
                    }
                }
            }
        }
    }

    static void FillThirdMatrix(int[,] matrix)
    {
        int currentNumber = 1;
        int currentRow = matrix.GetLength(0) - 1;
        int row = matrix.GetLength(0) - 1;

        //Fill the left side of the matrix
        for (int col = 0; col <= matrix.GetLength(1); col++)
        {
            col = 0;

            while (currentRow < matrix.GetLength(0))
            {
                matrix[currentRow, col] = currentNumber;
                currentNumber++;
                currentRow++;
                col++;
            }

            if (currentRow == matrix.GetLength(0))
            {
                row--;
                currentRow = row;
            }
        }

        int currentCol = 1;
        int coll = 1;

        //Fill the right side of the matrix
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            currentRow = 0;

            while (currentCol < matrix.GetLength(1))
            {
                matrix[currentRow, currentCol] = currentNumber;
                currentNumber++;
                currentCol++;
                currentRow++;
            }

            if (currentCol == matrix.GetLength(1))
            {
                coll++;
                currentCol = coll;
            }
        }
    }

    static void FillSecondMatrix(int[,] matrix)
    {
        int currentNumber = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = currentNumber;
                    currentNumber++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = currentNumber;
                    currentNumber++;
                }
            }
        }
    }

    static void FillFirstMatrix(int[,] matrix)
    {
        int currentNumber = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = currentNumber;
                currentNumber++;
            }
        }
    }

    static void PrintTheMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}
