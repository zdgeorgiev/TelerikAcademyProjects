using System;

class CatalansNumbers
{
    static decimal Factorial(decimal number)
    {
        decimal sum = 1;
        for (int i = 1; i <= number; i++)
        {
            sum *= i;
        }
        return sum;
    }

    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal counter = 0;
        if (n >= 0)
        {
            counter = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
            Console.WriteLine(counter);
        }
    }
}

//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:

//Cn = 1/n+1 x (2n/n) = (2n)! / (n+1)!n! n=>0
