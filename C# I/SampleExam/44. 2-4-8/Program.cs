using System;

class Program
{
    static void Main(string[] args)
    {
        ulong firstNumber = ulong.Parse(Console.ReadLine());
        ulong secondNumber = ulong.Parse(Console.ReadLine());
        ulong thirdNumber = ulong.Parse(Console.ReadLine());

        ulong r = 0;

        if (secondNumber == 2)
        {
           r = firstNumber % thirdNumber;
        }
        else if (secondNumber == 4)
        {
            r = firstNumber + thirdNumber;
        }
        else if (secondNumber == 8)
        {
            r = firstNumber * thirdNumber;
        }

        if (r % 4 == 0)
        {
            Console.WriteLine(r / 4);
        }
        else
        {
            Console.WriteLine(r % 4);
        }

        Console.WriteLine(r);
    }
}