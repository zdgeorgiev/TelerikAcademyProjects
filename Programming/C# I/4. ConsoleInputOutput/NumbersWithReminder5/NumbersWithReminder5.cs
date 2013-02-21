using System;

class NumbersWithReminder5
{
    static void Main()
    {
        Console.Write("Enter first number value : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter secound number value : ");
        int b = int.Parse(Console.ReadLine());
        int counter = 0;
        int i = 0;
        for (i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}


//Write a program that reads two positive integer numbers and prints how many numbers p exist between them
//such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
