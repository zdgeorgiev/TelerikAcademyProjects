using System;

class Numbers1toN
{
    static void Main(string[] args)
    {
        Console.Write("Print all numbers from 1 to ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

//Write a program that prints all the numbers from 1 to N.