using System;

class DevideBy5And7
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        if (number % 7 == 0 &&
            number % 5 == 0)
        {
            Console.WriteLine("Number can be devided by 5 and 7 without reminder.");
        }
        else
        {
            Console.WriteLine("Number cannot be devided by 5 and 7 without reminder.");
        }
    }
}

//Write a boolean expression that checks for given integer
//if it can be divided (without remainder) by 7 and 5 in the same time.