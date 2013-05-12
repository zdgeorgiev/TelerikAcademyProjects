using System;

class BestStringSequence
{
    static void Main()
    {
        string[,] matrix = {
                              {"ha", "ha", "de", "ha", "de"},
                              {"oh", "ha", "mu", "de", "de"},
                              {"oh", "pa", "ha", "au", "de"},
                              {"oh", "pa", "pa", "ha", "de"},
                              {"oh", "az", "de", "hu", "de"},
                              {"oh", "pa", "ha", "au", "de"}
                          };
        

        int counter = 1;
        int bestCounter = int.MinValue;
        string element = "";

        //horizontal.
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    counter++;

                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        element = matrix[row, col];
                    }
                }
            }
            counter = 1;
        }

        //vertical.
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    counter++;

                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        element = matrix[row, col];
                    }
                }
            }
            counter = 1;
        }

        //diagonal from top left to bottom right.

        for (int col = 0, row = 0; col < matrix.GetLength(1) - 1 && row < matrix.GetLength(0) - 1; col++, row++)
        {
            if (matrix[row, col] == matrix[row + 1, col + 1])
            {
                counter++;

                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    element = matrix[row, col];
                }
            }
            else
            {
                counter = 1;
            }
        }
        counter = 1;

        //diagonal from top right to bottom left.

        for (int row = 0, col = matrix.GetLength(1) - 1; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
        {
            if (matrix[row, col] == matrix[row + 1, col - 1])
            {
                counter++;

                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    element = matrix[row, col];
                }
            }
            else
            {
                counter = 1;
            }
        }
        counter = 1;

        Console.WriteLine("{0}({1}times)", element, bestCounter);
    }
}

