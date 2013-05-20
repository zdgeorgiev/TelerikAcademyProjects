using System;

class BitModifier
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter a position : ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter a value (0/1) : ");
        int value = int.Parse(Console.ReadLine());
        int newNumber = int.MinValue;
        int mask = int.MinValue;

        if (value == 0)
        {
            mask = ~(1 << position);
            newNumber = number & mask;
            Console.WriteLine(newNumber);
        }
        else
        {
            mask = 1 << position;
            newNumber = number | mask;
            Console.WriteLine(newNumber);
        }
    }
}

//We are given integer number n, value v (v=0 or 1) and a position p.
//Write a sequence of operators that modifies n to hold the value v 
//at the position p from the binary representation of n.
//    Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//    n = 5 (00000101), p=2, v=0  1 (00000001)