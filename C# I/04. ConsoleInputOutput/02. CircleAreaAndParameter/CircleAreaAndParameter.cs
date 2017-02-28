using System;

class CircleAreaAndParameter
{
    static void Main(string[] args)
    {
        decimal radius = decimal.Parse(Console.ReadLine());
        decimal area = (decimal)Math.PI * (radius * radius);
        decimal perimeter = (decimal)Math.PI * radius;

        Console.WriteLine("Area: {0}", area);
        Console.WriteLine("Perimeter: {0}", 2 * perimeter);
    }
}

//Write a program that reads the radius r of a circle and prints its perimeter and area.