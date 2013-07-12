using System;

class SquareRoot
{
    static void Main(string[] args)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new IndexOutOfRangeException(
                    string.Format("Sorry ({0}) cannot be negative", number));
            }

            Console.WriteLine(Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}

//Write a program that reads an integer number and calculates
//and prints its square root. If the number is invalid or negative,
//print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.