using System;

class NumbersWithReminder5
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number : ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");
        int secondNumber = int.Parse(Console.ReadLine());

        //Get the lowest number from the user input
        int lowestNumber = Math.Min(firstNumber, secondNumber);
        //Get the biggest number from the user input
        int biggestNumber = Math.Max(firstNumber, secondNumber);

        int count = 0;

        for (int i = lowestNumber; i <= biggestNumber; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("All numbers in range [{0}...{1}] that reminder of 5 is 0 = {2}", 
            lowestNumber, biggestNumber, count);
    }
}

//Write a program that reads two positive integer
//numbers and prints how many numbers p exist between 
//them such that the reminder of the division by 5 is 0 
//(inclusive). Example: p(17,25) = 2.