using System;
using System.IO;

class MaxSumFromMatrix
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("../../input.txt");

        using (StreamWriter writer = new StreamWriter("../../ouput.txt"))
        {
            using (reader)
            {
                int size = int.Parse(reader.ReadLine());
                int[,] matrix = new int[size, size];

                for (int row = 0; row < size; row++)
                {
                    //Array contains all numbers from the current row
                    string[] rowNumbers = reader.ReadLine().Split(' ');

                    for (int col = 0; col < size; col++)
                    {
                        matrix[row, col] = int.Parse(rowNumbers[col]);
                    }
                }

                int bestSum = int.MinValue;

                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        int currentSum = matrix[row, col]
                                    + matrix[row, col + 1]
                                    + matrix[row + 1, col]
                                    + matrix[row + 1, col + 1];

                        if (currentSum > bestSum)
                        {
                            bestSum = currentSum;
                        }
                    }
                }

                writer.WriteLine("Best sum 2x2 from the matrix is {0}", bestSum);
                Console.WriteLine("Finished.");
            }
        }
    }
}

//Write a program that reads a text file containing a square
//matrix of numbers and finds in the matrix an area of size 
//2 x 2 with a maximal sum of its elements. The first line 
//in the input file contains the size of matrix N. Each of
//the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file


//4
//2 3 3 4
//0 2 3 4		->	17
//3 7 1 2
//4 3 3 2