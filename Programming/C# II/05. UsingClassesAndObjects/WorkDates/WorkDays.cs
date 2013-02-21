using System;
 
class Program
{
    static readonly DateTime now = DateTime.Today;
    static DateTime furtherDate;
    static DateTime[,] festivals;

    static void Main(string[] args)
    {
        furtherDate = DateTime.Parse(Console.ReadLine());
        int days = (furtherDate - now).Days;
        WorkingDays(days);
    }
 
    private static void WorkingDays(int days)
    {
        String yearsFur = furtherDate.ToString().Substring(6, 4);
        String yearNow = now.ToString().Substring(6, 4);
        PopulateFestivals(int.Parse(yearsFur) - int.Parse(yearNow) + 1, yearNow);
        DateTime curr = new DateTime();
        for (int i = 0; i < days; i++)
        {
            curr.AddDays(1);
            if (curr.DayOfWeek == DayOfWeek.Saturday || curr.DayOfWeek == DayOfWeek.Sunday) days--;
            else
            {
                for (int j = 0; j < int.Parse(yearsFur) - int.Parse(yearNow) + 1; j++)
                {
                    for (int t = 0; t < 4; t++)
                    {
                        if (curr.CompareTo(festivals[j, t]) == 0)
                        {
                            days--;
                            break;
                        }
                    }
                }
            }
        }
        Console.WriteLine("Working days : {0}",days);
    }
 
    private static void PopulateFestivals(int p, string yearNow)
    {
        int atm = int.Parse(yearNow);
        festivals = new DateTime[p, 4];
        for (int i = 0; i < p; i++)
        {
            festivals[i, 0] = new DateTime(atm, 12, 24);
            festivals[i, 1] = new DateTime(atm, 12, 25);
            festivals[i, 2] = new DateTime(atm, 12, 31);
            festivals[i, 3] = new DateTime(atm, 1, 1);
            atm++;
        }
    }
}


//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
