using System;

class IntroMethod
{
    static string PrintIntro(string name)
    {
        return string.Format("Hello, {0}!", name);
    }
    static void Main(string[] args)
    {
        Console.Write("Enter your name : ");
        string name = Console.ReadLine();

        Console.WriteLine(PrintIntro(name));
    }
}

//Write a method that asks the user for his name and prints
//“Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.