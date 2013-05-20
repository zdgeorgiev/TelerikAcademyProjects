using System;

class BitPosition
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a position : ");
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int maskAndNumber = number & mask;
        int bit = maskAndNumber >> position;

        if (bit == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

//Write a boolean expression that returns if the bit at position p (counting from 0)
//in a given integer number v has value of 1. Example: v=5; p=1  false.