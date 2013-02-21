using System;

class CalculateSquareAndFactorielFromula3
{
    static decimal CalculateFactoriel(int number)
    {
        decimal factoriel = 1M;
        for (int i = 1; i <= number; i++)
        {
            factoriel *= i;
        }

        return factoriel;
    }

    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x=");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1;

        for (int i = 1; i <= n; i++)
        {
            sum += CalculateFactoriel(i) / (decimal)Math.Pow(x, i);
        }

        Console.WriteLine(sum);
    }
}

//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
