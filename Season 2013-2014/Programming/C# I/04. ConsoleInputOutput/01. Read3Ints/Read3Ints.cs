using System;

class Read3Ints
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers : ");
        int sum = 0;

        for (int i = 0; i < 3; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            sum += currentNumber;
        }

        Console.WriteLine("The sum is {0}",sum);
    }
}

//Write a program that reads 3 integer numbers from the console and prints their sum.