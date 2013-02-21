using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter the width value");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the hight value");
        int b = int.Parse(Console.ReadLine());
        int S = a * b;
        Console.WriteLine("The area of the rectangle is {0}", S);
    }
}

//Write an expression that calculates rectangle’s area by given width and height.
