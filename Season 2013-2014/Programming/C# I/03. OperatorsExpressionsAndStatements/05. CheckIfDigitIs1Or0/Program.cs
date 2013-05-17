using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int maskAndnumber = number & mask;
        int bit = maskAndnumber >> 3;

        Console.WriteLine(bit);
    }
}

//Write a boolean expression for finding if the bit 3
//(counting from 0) of a given integer is 1 or 0.