using System;

class SquareRoot
{
    static void CheckNumberHigherThanZero(int number)
    {
        if (number < 0)
        {
            throw new IndexOutOfRangeException();
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            CheckNumberHigherThanZero(n);
            double sqrt = Math.Sqrt(n);
            Console.WriteLine("Square of {0} = {1}", n, sqrt);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid Number!");
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid Number");
        }

        finally
        {
            Console.WriteLine("Good Bye!");
        }
    }
}

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally