using System;

class WhichDayIsToday
{
    static void TodayIs()
    {
        Console.WriteLine(DateTime.Today.DayOfWeek);
    }

    static void Main()
    {
        Console.Write("Today is ");
        TodayIs();
    }
}


//Write a program that prints to the console which day of the week is today. Use System.DateTime.
