using System;
using System.Numerics;

class BinaryDigit
{
    static void Main(string[] args)
    {
        int bit = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger[] numbers = new BigInteger[n];

        for (int i = 0; i < n; i++)
        {
            uint currentNumber = uint.Parse(Console.ReadLine());
            BigInteger representation = BigInteger.Parse(Convert.ToString(currentNumber, 2));
            numbers[i] = representation;
        }

        foreach (var number in numbers)
        {
            CountBits(bit, number);
        }
    }

    static void CountBits(int bit, BigInteger number)
    {
        int count = 0;

        while (number > 0)
        {
            if (number % 10 == bit)
            {
                count++;
            }
            number /= 10;
        }

        Console.WriteLine(count);
    }
}