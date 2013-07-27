using System;
using System.Globalization;

class DateParseAnother
{
    static void Main(string[] args)
    {
        string date = "25.03.2003 14:24:05";

        DateTime convertedDate = DateTime.ParseExact(date, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        convertedDate.AddHours(6.5);

        Console.WriteLine("{0} {1}", convertedDate, convertedDate.ToString("dddd", new CultureInfo("bg-BG")));
    }
}

//Write a program that reads a date and time given in the format:
//day.month.year hour:minute:second and prints the date and time
//after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.