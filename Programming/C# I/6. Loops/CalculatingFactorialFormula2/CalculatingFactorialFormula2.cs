using System;
using System.Collections.Generic;

class CalculatingFactorialFormula2
{
    static decimal CalculateFactoriel(int number)
    {
        decimal factoriel = 1M;
        for (int i = 1; i < number; i++)
        {
            factoriel *= i;
        }
        return factoriel;
    }
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k= ");
        int k = int.Parse(Console.ReadLine());
        if (k > n && n > 1)
        {
            Console.WriteLine((CalculateFactoriel(n) * CalculateFactoriel(k)) / CalculateFactoriel(k-n));
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }
}

//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
