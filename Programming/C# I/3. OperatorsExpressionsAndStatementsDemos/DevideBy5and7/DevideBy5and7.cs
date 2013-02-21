using System;

class DevideBy5and7
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(a%7==0 && a%5==0);
    }
}



//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.