using System;

class AngryFemaleGPS
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        input = input.TrimStart(new char[] {'-'});

        long n = long.Parse(input);

        long oddSum = 0;
        long evenSum = 0;

        while (n > 0)
        {
            long currentDigit = n % 10;

            if (currentDigit % 2 == 0)
            {
                evenSum += currentDigit;
            }
            else
            {
                oddSum += currentDigit;
            }

            n /= 10;
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("straight {0}", oddSum);
        }
        else if (oddSum < evenSum)
        {
            Console.WriteLine("right {0}", evenSum);
        }
        else
        {
            Console.WriteLine("left {0}", oddSum);
        }
    }
}