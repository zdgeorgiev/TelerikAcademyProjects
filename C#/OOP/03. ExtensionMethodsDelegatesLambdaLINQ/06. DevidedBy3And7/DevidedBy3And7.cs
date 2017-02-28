using System;
using System.Collections.Generic;
using System.Linq;

class DevidedBy3And7
{
    static void Main(string[] args)
    {
        List<int> allNumbers = new List<int>()
        {
            66,
            23,
            21,
            76214,
            56,
            56456,
            1,
            745645,
            321321
        };

        Console.WriteLine("LAMBDA\n");

        var sortedLambda = allNumbers.FindAll(number => number % 21 == 0);

        foreach (int number in sortedLambda)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("LINQ\n");

        var sortedLinq =
            from number in allNumbers
            where number % 21 == 0
            select number;

        foreach (int number in sortedLambda)
        {
            Console.WriteLine(number);
        }
    }
}
