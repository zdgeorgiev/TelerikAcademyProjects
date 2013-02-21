using System;

class CheckIfDigitIs7
{
static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int mask = 7 << 3;
        Console.WriteLine((a & mask) != 0 ? "True" : "False");
    }
}