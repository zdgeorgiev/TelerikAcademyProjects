using System;

class SumWithPrecision
{
    static void Main()
    {
        decimal sum = 1;
        decimal oldSum = -1;

        for (decimal i = 2; i <= 9950; i++)
        {
            if (i % 2 == 0)
            {
                sum = sum + (1 / i);
            }
            else
            {
                sum = sum - (1 / i);
            }

            if ((sum - oldSum) == 0.001M)
            {
                break;
            }
            else
            {
                oldSum = sum;
            }

        }

        Console.WriteLine(sum);
    }
}