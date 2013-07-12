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
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(BigFactorial(i));
        }
    }
}

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented
//as array of digits by given integer number.