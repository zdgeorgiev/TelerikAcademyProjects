using System;
using System.Numerics;

class ExcelColumns
{
    static void Main()
    {
        BigInteger result = 0;
        int baseValue = 0;

        int n = int.Parse(Console.ReadLine());
        for (int i = n - 1; i >= 0; i--)
        {
            char a = char.Parse(Console.ReadLine());
            baseValue = (a - 64);
            BigInteger power = (BigInteger)Math.Pow(26, i);
            result += (BigInteger)baseValue * power;
        }

        Console.WriteLine(result);
    }
}