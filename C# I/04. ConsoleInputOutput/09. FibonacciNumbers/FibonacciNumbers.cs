using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        decimal firstNumber = 0;
        decimal secondNumber = 1;
        decimal thirdNumber = 1;

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(firstNumber);
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = secondNumber + firstNumber;
        }
    }
}

//Write a program to print the first 100 members of the
//sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …