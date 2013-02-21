using System;

class CircleAreaAndParameter
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        double pi = Math.PI;
        int S = (int)pi * r * r;
        int P = (int)(2 * (pi * r));
        Console.WriteLine("The area of the circle with radius {0} is {1}", r, S);
        Console.WriteLine("The perimeter of the circle with radius {0} is {1}", r, P);
    }
}

//Write a program that reads the radius r of a circle and prints its perimeter and area.
