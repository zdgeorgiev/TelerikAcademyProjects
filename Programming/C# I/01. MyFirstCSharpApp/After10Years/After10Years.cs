using System;

class After10Years
{
    static void Main(string[] args)
    {
        int yourYearsToday = int.Parse(Console.ReadLine());

        Console.WriteLine("You're {0} years old, after 10 years you will be {1} years old"
            , yourYearsToday, yourYearsToday + 10);
    }
}