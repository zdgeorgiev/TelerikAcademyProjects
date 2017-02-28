using System;

class DateParse
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first date: ");
        string firstDate = Console.ReadLine();
        Console.Write("Enter the second date: ");
        string secondDate = Console.ReadLine();
        string[] firstParameters = firstDate.Split('.');
        string[] secondParameters = secondDate.Split('.');

        DateTime firstConvertedDate = new DateTime(int.Parse(firstParameters[2]),
            int.Parse(firstParameters[1]), int.Parse(firstParameters[0]));
        DateTime secondConvertedDate = new DateTime(int.Parse(secondParameters[2]),
            int.Parse(secondParameters[1]), int.Parse(secondParameters[0]));

        if (DateTime.Compare(firstConvertedDate, secondConvertedDate) == 1)
        {
            Console.WriteLine("Distance: {0}", (firstConvertedDate - secondConvertedDate).Days);
        }
        else
        {
            Console.WriteLine("Distance: {0}", (secondConvertedDate - firstConvertedDate).Days);
        }
    }
}

//Write a program that reads two dates in the format:
//day.month.year and calculates the number of days between them. 