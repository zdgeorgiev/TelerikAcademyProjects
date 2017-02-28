using System;

class GreaterNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number : ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");
        int secondNumber = int.Parse(Console.ReadLine());

        int biggestNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine(biggestNumber);
    }
}

//Write a program that gets two numbers from the console and
//prints the greater of them. Don’t use if statements.