using System;

class RectangleArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter the width for the triangle. ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter the height for the triangle. ");
        double height = double.Parse(Console.ReadLine());

        double area = width * height / 2;
        Console.WriteLine(area);
    }
}

//Write an expression that calculates rectangle’s area by given width and height.