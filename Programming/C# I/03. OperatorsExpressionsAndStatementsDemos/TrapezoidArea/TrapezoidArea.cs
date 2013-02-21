using System;

class TrapezoidArea
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        Console.WriteLine("The Area of the trapezoid is {0}", ((a+b)/2)*h);
    }
}

