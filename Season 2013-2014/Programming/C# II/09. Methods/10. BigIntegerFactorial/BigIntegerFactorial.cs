using System;
//add using and also a reference
using System.Numerics;

class BigIntegerFactorial
{
    static BigInteger BigFactorial(int number)
    {
        if (number == 1)
        {
            return number;
        }
        else
        {
            return number * BigFactorial(number - 1);
        }
    }

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Factorial of {0} is {1}", number, BigFactorial(number));
    }
}

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented
//as array of digits by given integer number. 