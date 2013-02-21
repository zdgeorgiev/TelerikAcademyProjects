using System;

class NumberInRange
{
    private static void PrintNumbers(int start, int end)
    {
        for (int i = 0; i < 10; i++)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < start || n > end)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Enter number in range [start...end]");
            Console.Write("start: ");

            int start = int.Parse(Console.ReadLine());

            Console.Write("end: ");

            int end = int.Parse(Console.ReadLine());


            PrintNumbers(start, end);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Your number is out of range!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Your number is too big!");
        }
    }
}

//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:
//			a1, a2, … a10, such that 1 < a1 < … < a10 < 100
