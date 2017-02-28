using System;

class NumberInRange
{
    static void ReadNumber(int start, int end)
    {
        for (int i = 0; i < 10; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < start || number > end)
            {
                throw new IndexOutOfRangeException(
                    string.Format("Sorry ({0}) isnt in range [{1}...{2}]", number, start, end));
            }
        }
    }

    static void Main(string[] args)
    {
        try
        {
            ReadNumber(start: 1, end: 100);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

//Write a method ReadNumber(int start, int end) that enters an integer 
//number in given range [start…end]. If an invalid number or non-number
//text is entered, the method should throw an exception. Using this 
//method write a program that enters 10 numbers:
//            a1, a2, … a10, such that 1 < a1 < … < a10 < 100