using System;

class TrapezoidArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter trapezoid's side a : ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter trapezoid's side b : ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter trapezoid's height : ");
        double height = double.Parse(Console.ReadLine());

        double area = (sideA + sideB) * height / 2;

        Console.WriteLine(area);
    }
}

//Write an expression that calculates trapezoid's area by given sides a and b and height h.