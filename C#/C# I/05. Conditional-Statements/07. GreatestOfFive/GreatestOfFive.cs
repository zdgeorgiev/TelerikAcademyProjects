using System;

class GreatestOfFive
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());
        int fifthNumber = int.Parse(Console.ReadLine());

        int biggestNumber = Math.Max(Math.Max(Math.Max(Math.Max(firstNumber, secondNumber),
            thirdNumber), fourthNumber), fifthNumber);

        Console.WriteLine("\nBiggest number is {0}", biggestNumber);
    }
}

//Write a program that finds the greatest of given 5 variables.