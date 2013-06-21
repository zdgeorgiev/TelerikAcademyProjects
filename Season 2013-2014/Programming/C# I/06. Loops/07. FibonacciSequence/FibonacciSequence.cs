using System;

class FibonacciSequence
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …");
        Console.Write("Enter a number : ");
        int n = int.Parse(Console.ReadLine());
        int firstNumber = 0;
        int secondNumber = 1;
        int thirdNumber = 1;
        int result = firstNumber + secondNumber + thirdNumber;

        for (int i = 3; i < n; i++)
        {
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = firstNumber + secondNumber;

            result += thirdNumber;
        }

        Console.WriteLine("Sum of the first {0} numbers from the fibonacci is : {1}", n, result);
    }
}

//Write a program that reads a number N and calculates the
//sum of the first N members of the sequence of 
//Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …