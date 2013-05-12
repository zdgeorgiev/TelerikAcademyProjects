using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[15];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }
        numbers[0] = 1;

        Console.WriteLine("Average - {0}",numbers.Average()); //7.06666666666..
        Console.WriteLine("Min value - {0}", numbers.Min()); //1
        Console.WriteLine("Max value - {0}", numbers.Max()); //14
        Console.WriteLine("Product - {0}", numbers.Product()); //Some big Number
    }
}
