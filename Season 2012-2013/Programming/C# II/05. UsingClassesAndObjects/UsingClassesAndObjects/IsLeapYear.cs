using System;

class IsLeapYear
{
    static bool CheckIsLeapYear(int year)
    {
        bool isLeap = false;
        int lastTwoDigits = year % 100;

        for (int i = 0; i <= 96; i+=4)
        {
            if (lastTwoDigits == i)
            {
                isLeap = true;
                break;
            }
        }   
        return isLeap;
    }

    static void Main()
    {
        //DateTime time = DateTime.Now;
        //Console.WriteLine(time);
        //int thisYear = time.Year;
        //Console.WriteLine("Is this year leap - {0}", CheckIsLeapYear(thisYear));
        //Console.WriteLine();

        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Is {0} leap ? : {1}", year, CheckIsLeapYear(year));
    }
}


//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
