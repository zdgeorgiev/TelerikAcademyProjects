using System;

class BasicMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(j);
                j = n - 1 - j;
            }
            Console.WriteLine();
        }
    }
}

//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
