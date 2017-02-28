using System;

class GenericMatrixTest
{
    static void Main()
    {
        GenericMatrix<int> firstMatrix = new GenericMatrix<int>(5, 5);

        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                firstMatrix[row, col] = row * col + 5 * col;
            }
        }

        Console.WriteLine(firstMatrix);
    }
}