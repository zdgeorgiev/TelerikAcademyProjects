using System;
using System.Numerics;

class Tribonacci
{
    static void Main(string[] args)
    {
        BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdNumber = BigInteger.Parse(Console.ReadLine());
        short n = short.Parse(Console.ReadLine());
        BigInteger fourthNumber = 0;

        if (n == 1)
        {
            Console.WriteLine(firstNumber);
        }
        else if (n == 2)
        {
            Console.WriteLine(secondNumber);
        }
        else if (n == 3)
        {
            Console.WriteLine(thirdNumber);
        }
        else
        {
            for (short i = 3; i < n; i++)
            {
                fourthNumber = firstNumber + secondNumber + thirdNumber;

                BigInteger tempValue = thirdNumber;
                firstNumber = secondNumber;
                secondNumber = tempValue;
                thirdNumber = fourthNumber;
            }

            Console.WriteLine(fourthNumber);
        }
    }
}

// 2 3 4 9 21 34 64