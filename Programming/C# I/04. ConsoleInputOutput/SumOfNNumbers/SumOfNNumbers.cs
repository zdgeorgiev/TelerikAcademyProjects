using System;

class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}

//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

