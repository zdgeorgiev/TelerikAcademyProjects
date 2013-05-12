using System;

class BitPosition
{
    static void Main()
    {
        int v = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        Console.WriteLine((v&mask)!=0 ? "True" : "False");
    }
}

//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v
//has value of 1. Example: v=5; p=1  false