using System;

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[]
        {
            new Triangle(10, 10),
            new Rectangle(10, 10),
            new Triangle(5, 4),
            new Triangle(3, 7),
            new Rectangle(8,1),
            new Circle(5),
            new Circle(4),
            new Circle(7)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("{0} surface = {1:F2}",
                shape.GetType(), shape.CalcSurface());
            Console.WriteLine();
        }
    }
}
