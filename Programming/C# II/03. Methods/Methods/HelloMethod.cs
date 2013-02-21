using System;

class HelloMethod
{
    static void PrintName()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        string hello = "Hello, ";
        Console.WriteLine(hello + userName);
    }

    static void Main()
    {
        PrintName();
    }
}


//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
//Write a program to test this method.
