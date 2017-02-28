using System;

class LastDigitInEnglish
{
    static string[] allNumbers = new string[]
        { "zero", "one", "two", "three", "fourt", "five", "six", "seven", "eight", "nine", "ten" };

    static string DigitInEnglish(int digit)
    {
        return allNumbers[digit];
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Last digit is {0}", DigitInEnglish(number % 10));
    }
}

//Write a method that returns the last digit of given integer as
//an English word. Examples: 512  "two", 1024  "four", 12309  "nine".