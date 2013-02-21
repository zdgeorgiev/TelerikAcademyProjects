using System;

class Read3Ints
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("The Sum is {0}", (a+b+c));
    }
}

//Write a program that reads 3 integer numbers from the console and prints their sum.