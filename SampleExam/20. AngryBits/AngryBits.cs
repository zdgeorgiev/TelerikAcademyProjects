using System;

class AngryBits
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[8, 16];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (((number >> 15 - col) & 1) != 0)
                {
                    matrix[row, col] = 1;
                }
            }
        }

        //PrintMatrix(matrix);

        int totalResult = 0;
        int pigsHit = 0;
        int steps = 0;

        //Find the nearest bird
        for (int col = matrix.GetLength(1) / 2; col >= 0 ; col--)
        {
            pigsHit = 0;
            steps = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] == 1)
                {
                    int currentRow = row;
                    int currentCol = col;

                    //Up -> Right
                    while (currentRow - 1 >= 0 && currentCol + 1 < matrix.GetLength(1))
                    {
                        steps++;

                        if (matrix[currentRow - 1, currentCol + 1] == 0)
                        {
                            matrix[currentRow - 1, currentCol + 1] = 1;
                            matrix[currentRow, currentCol] = 0;
                            currentRow--;
                            currentCol++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    //Down -> Right
                    while (currentRow + 1 < matrix.GetLength(0) && currentCol + 1 < matrix.GetLength(1))
                    {
                        steps++;

                        if (matrix[currentRow + 1, currentCol + 1] == 0)
                        {
                            matrix[currentRow + 1, currentCol + 1] = 1;
                            matrix[currentRow, currentCol] = 0;
                            currentRow++;
                            currentCol++;

                            if (currentRow + 1 >= matrix.GetLength(0) ||
                                currentCol + 1 >= matrix.GetLength(1))
                            {
                                matrix[currentRow, currentCol] = 0;
                                break;
                            }
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = 0;

                            if (currentRow < matrix.GetLength(0) && currentCol + 1 < matrix.GetLength(1) &&
                                matrix[currentRow, currentCol + 1] == 1)
                            {
                                matrix[currentRow, currentCol + 1] = 0;
                                pigsHit++;
                            }
                            
                            if (currentRow < matrix.GetLength(0) && currentCol + 2 < matrix.GetLength(1) &&
                                matrix[currentRow, currentCol + 2] == 1)
                            {
                                matrix[currentRow, currentCol + 2] = 0;
                                pigsHit++;
                            }
                           
                            if (currentRow + 1 < matrix.GetLength(0) && currentCol < matrix.GetLength(1) &&
                                matrix[currentRow + 1, currentCol] == 1)
                            {
                                matrix[currentRow + 1, currentCol] = 0;
                                pigsHit++;
                            }
                           
                            if (currentRow + 1 < matrix.GetLength(0) && currentCol + 1 < matrix.GetLength(1) &&
                                matrix[currentRow + 1, currentCol + 1] == 1)
                            {
                                matrix[currentRow + 1, currentCol + 1] = 0;
                                pigsHit++;
                            }
                            
                            if (currentRow + 1 < matrix.GetLength(0) && currentCol + 2 < matrix.GetLength(1) &&
                                matrix[currentRow + 1, currentCol + 2] == 1)
                            {
                                matrix[currentRow + 1, currentCol + 2] = 0;
                                pigsHit++;
                            }
                            
                            if (currentRow + 2 < matrix.GetLength(0) && currentCol < matrix.GetLength(1) &&
                                matrix[currentRow + 2, currentCol] == 1)
                            {
                                matrix[currentRow + 2, currentCol] = 0;
                                pigsHit++;
                            }
                            
                            if (currentRow + 2 < matrix.GetLength(0) && currentCol + 1 < matrix.GetLength(1) &&
                                matrix[currentRow + 2, currentCol + 1] == 1)
                            {
                                matrix[currentRow + 2, currentCol + 1] = 0;
                                pigsHit++;
                            }
                            
                            if (currentRow + 2 < matrix.GetLength(0) && currentCol + 2 < matrix.GetLength(1) &&
                                matrix[currentRow + 2, currentCol + 2] == 1)
                            {
                                matrix[currentRow + 2, currentCol + 2] = 0;
                                pigsHit++;
                            }

                            break;
                        }
                    }

                    int currentResult = pigsHit * steps;
                    totalResult += currentResult;
                }
            }
        }

        //Calc the result
        CalcTheResult(matrix, totalResult);
        //PrintMatrix(matrix);
    }

    private static void CalcTheResult(int[,] matrix, int totalResult)
    {
        string isMatrixClean = " Yes";

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int coll = 0; coll < matrix.GetLength(1); coll++)
            {
                if (matrix[row, coll] == 1)
                {
                    isMatrixClean = " No";
                    break;
                }
            }
        }

        Console.WriteLine(totalResult.ToString() + isMatrixClean);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}