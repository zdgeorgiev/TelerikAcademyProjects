using System;

class FirstNNumbersOfFibonacciSequence
{
    static void Fibonacci(int number)
    {
        decimal firstNumber = 0;
        decimal secoundNumber = 1;
        decimal sum = 0;

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("{0}", sum);
            sum = firstNumber + secoundNumber;
            firstNumber = secoundNumber;
            secoundNumber = sum;
        }
    }

    static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());
        Fibonacci(userInput);
    }
}

//Write a program that reads a number N and calculates the sum of the first N members of the sequence of 
//Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
