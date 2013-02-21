using System;

class GreatestFromFive
{
    static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());
        int number5 = int.Parse(Console.ReadLine());

        int max = Math.Max(number1, number2);
        int max2 = Math.Max(number3, number4);
        int max3 = Math.Max(max, max2);
        int MaxTotal = Math.Max(max3, number5);

        Console.WriteLine(MaxTotal);
    }
}


//Write a program that finds the greatest of given 5 variables.
