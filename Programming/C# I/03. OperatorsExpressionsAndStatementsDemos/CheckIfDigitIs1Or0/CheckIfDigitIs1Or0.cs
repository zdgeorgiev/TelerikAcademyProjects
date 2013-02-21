using System;

class CheckIfDigitIs1Or0
{
    static void Main()
    {
        int Number = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        Console.WriteLine((mask & Number) != 0 ? 1 : 0);       // ? True : False
    }
}

//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
