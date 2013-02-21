using System;

class GreaterNumberNoIfStatements
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine((a > b) ? a : b);
    }
}

//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
