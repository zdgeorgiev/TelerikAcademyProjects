using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> allShapes = new List<Shape>()
        {
            new Circle(5),
            new Rectangle(65,22),
            new Rectangle(1,55),
            new Triangle(500,500)
        };

        foreach (Shape shape in allShapes)
        {
            Console.WriteLine("{0}'s surface - {1}",
                shape.GetType().Name, shape.CalculateSurface());
        }
    }
}