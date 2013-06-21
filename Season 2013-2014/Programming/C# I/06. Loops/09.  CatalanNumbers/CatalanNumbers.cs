using System;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to calculate his catalan number : ");
        int n = int.Parse(Console.ReadLine());

        double result = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));

        Console.WriteLine(result);
    }

    static double Factorial(int number)
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

//Write a program to calculate the Nth Catalan number by given N.