using System;

class Program
{
    public static int ReadInt(int start, int end)
    {
        string inputValue; //string as input
        int number; //default number

        do
        {
            Console.WriteLine("Enter integer in range [{0}...{1}]", start, end);
            inputValue = Console.ReadLine();
        }
        while (!int.TryParse(inputValue, out number)); //convert string input to int number (string >> int)

        if (number < start || number > end)
        {
            throw new InvalidRangeException<int>("Input value was not in the permissible range.", start, end);
        }
        return number;
    }

    public static DateTime ReadDateTime(DateTime start, DateTime end)
    {
        string input;
        DateTime date;

        do
        {
            Console.WriteLine("Enter DateTime in range [{0}...{1}]", start, end);
            input = Console.ReadLine();
        }
        while (!DateTime.TryParse(input, out date));

        if (date < start || date > end)
        {
            throw new InvalidRangeException<DateTime>("DateTime was not in the permissible range.", start, end);
        }

        return date;
    }

    static void Main(string[] args)
    {
        try
        {
            ReadDateTime(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
            ReadInt(1, 100);
        }
        catch (InvalidRangeException<int> ex)
        {
            Console.WriteLine("{0}\nRange: [{1} - {2}]", ex, ex.Start, ex.End);
        }
        catch (InvalidRangeException<DateTime> ex)
        {
            Console.WriteLine("{0}\nRange: [{1} - {2}]", ex, ex.Start, ex.End);
        }
    }
}
