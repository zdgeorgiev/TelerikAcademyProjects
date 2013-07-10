using System;

class WorkDays
{
    public static readonly DateTime[] Holidays = new DateTime[]
    {
        new DateTime(2013, 7, 21),
        new DateTime(2013, 7, 26),
        new DateTime(2013, 7, 29),
        new DateTime(2013, 8, 01),
        new DateTime(2013, 8, 04)
    };

    static void Main(string[] args)
    {
        DateTime today = DateTime.Today;

        int targetYear = 2013;//int.Parse(Console.ReadLine());
        int targetDay = 10;//int.Parse(Console.ReadLine());
        int targetMonth = 8;//int.Parse(Console.ReadLine());

        DateTime targetDate = new DateTime(targetYear, targetMonth, targetDay);
        int workDays = 0;

        for (int i = 0; i < (targetDate - today).Days; i++)
        {
            DateTime nextDay = DateTime.Today.AddDays(i);

            if (nextDay.DayOfWeek == DayOfWeek.Saturday ||
                nextDay.DayOfWeek == DayOfWeek.Sunday)
            {
                continue;
            }

            bool isHoliday = false;

            for (int j = 0; j < Holidays.Length; j++)
            {
                //Year doesnt matter.
                if (nextDay.Day == Holidays[j].Day
                    && nextDay.Month == Holidays[j].Month)
                {
                    isHoliday = true;
                    break;
                }
            }

            if (!isHoliday)
            {
                workDays++;
            }
        }

        Console.WriteLine("Working days between {0:M/d/yyyy} and {1:M/d/yyyy} are {2}", today, targetDate, workDays);
    }
}

//Write a method that calculates the number of workdays between 
//today and given date, passed as parameter. Consider that
//workdays are all days from Monday to Friday except a fixed
//list of public holidays specified preliminary as array.