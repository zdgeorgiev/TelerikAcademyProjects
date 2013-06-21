using System;

class CalculateFactorialFormula2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter N and K where (1<N<K)");
        bool isValid = false;
        int n, k;

        do
        {
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            k = int.Parse(Console.ReadLine());

            if (n > k || n < 1 || k < 1)
            {
                Console.WriteLine("N cannot be smaller than K or 1\n");
            }
            else
            {
                isValid = true;
            }
        }
        while (!isValid);

        int formula = (Factorial(n) * Factorial(k)) / Factorial(k - n);

        Console.WriteLine("N!*K! / (K-N)! = {0}", formula);
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

//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).