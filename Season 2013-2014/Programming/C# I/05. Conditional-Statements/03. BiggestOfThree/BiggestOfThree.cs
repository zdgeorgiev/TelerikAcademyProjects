using System;

class BiggestOfThree
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int biggestNumber = int.MinValue;

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            biggestNumber = firstNumber;
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            biggestNumber = secondNumber;
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            biggestNumber = thirdNumber;
        }

        Console.WriteLine(biggestNumber);
    }
}

//Write a program that finds the biggest of three integers using nested if statements.