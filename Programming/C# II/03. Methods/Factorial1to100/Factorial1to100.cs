using System;
using System.Numerics;

class Factorial1to100
{
    static BigInteger factorial(BigInteger number)
    {
        BigInteger factorial = 1;

        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
        }
        return factorial;
    }

    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine("Enter number!");
        Console.Write("number= ");
        BigInteger number = BigInteger.Parse(Console.ReadLine());

        Console.WriteLine("Factorial of {0} = {1}", number, factorial(number));
    }
}

//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
