using System;

class SequenceOfNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            sum += currentNumber;
        }

        Console.WriteLine(sum);
    }
}

//Write a program that gets a number n and after 
//that gets more n numbers and calculates and prints their sum. 