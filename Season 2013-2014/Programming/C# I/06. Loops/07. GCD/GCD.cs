using System;

class GCD
{
    static int FindGCD(int a, int b)
    {
        int swap;

        while (b > 0)
        {
            swap = b;
            b = a % b;
            a = swap;
        }

        return a;
    }

    static void Main()
    {
        Console.Write("Enter first number : ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Greatest common divisor is {0}", FindGCD(firstNumber, secondNumber));
    }
}

//Write a program that calculates the greatest common divisor
//(GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).