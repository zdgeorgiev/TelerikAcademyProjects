using System;

class TrippleRotationOfDigits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int newNumber = 0;

        for (int i = 0; i < 3; i++)
        {
            int delitel = 0;

            if (n >= 1000000)
            {
                delitel = 1000000;
            }
            else if (n >= 100000)
            {
                delitel = 100000;
            }
            else if (n >= 10000)
            {
                delitel = 10000;
            }
            else if (n >= 1000)
            {
                delitel = 1000;
            }
            else if (n >= 100)
            {
                delitel = 100;
            }
            else if (n >= 10)
            {
                delitel = 10;
            }
            else
            {
                newNumber = n;
                break;
            }

            int lastNumber = n % 10;

            newNumber = lastNumber * delitel + n / 10;
            n = newNumber;
        }

        Console.WriteLine(newNumber);
    }
}