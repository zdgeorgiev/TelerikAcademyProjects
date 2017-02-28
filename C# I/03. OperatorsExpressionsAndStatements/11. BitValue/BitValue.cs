using System;

class BitValue
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter a position : ");
        int position = int.Parse(Console.ReadLine());

        int mask = (1 << position) & number;
        int bit = mask >> position;
        Console.WriteLine("Bit = {0}", bit);
    }
}

//Write an expression that extracts from a given integer i
//the value of a given bit number b. Example: i=5; b=2  value=1.