using System;

class CalculateSquareAndFactorielFromula3
{
    static void Main(string[] args)
    {
        Console.Write("Enter N : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter X : ");
        int x = int.Parse(Console.ReadLine());

        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            result += Factorial(i) / Math.Pow(x, i);
        }

        Console.WriteLine("Result : {0}", result);
    }

    static int Factorial(int number)
    {
        if (number == 1)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}

//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN