using System;

class Program
{
    static void Main(string[] args)
    {
        bool isValidNumber = false;
        bool isValidDateTime = false;
        
        do
        {
            try
            {
                Console.WriteLine("Enter a integer number in range [50 … 100]");
                ReadIntInput(50, 100);
                isValidNumber = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } while (!isValidNumber);

        do
        {
            try
            {
                Console.WriteLine("Enter a DateTime number in range [1.1.1980 … 31.12.2013]");
                ReadDateTimeInput(new DateTime(1980, 1, 1), new DateTime(2013,12,31));
                isValidDateTime = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } while (!isValidDateTime);
    }

    static void ReadIntInput(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());

        if (number < start || number > end)
        {
            throw new InvalidRangeException<int>
                ("Number doesnt goes in the fixed range", start, end);
        }
    }

    static void ReadDateTimeInput(DateTime start, DateTime end)
    {
        Console.WriteLine("Enter a date in format yyyy/mm/dd");
        string[] rawNumbers = Console.ReadLine().Split('/');

        DateTime date = new DateTime(int.Parse(rawNumbers[0]), int.Parse(rawNumbers[1]), int.Parse(rawNumbers[2]));

        if (date < start || date > end)
        {
            throw new InvalidRangeException<DateTime>
                ("Given date time isnt in the fixed range", 1, 2);
        }
    }
}