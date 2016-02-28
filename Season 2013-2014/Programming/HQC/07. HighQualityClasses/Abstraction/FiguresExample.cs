using System;
using System.Collections.Generic;

namespace Abstraction
{
    class FiguresExample
    {
        static void Main()
        {
            //Circle circle = new Circle(5);
            //Console.WriteLine("I am a circle. " +
            //    "My perimeter is {0:f2}. My surface is {1:f2}.",
            //    circle.CalcPerimeter(), circle.CalcSurface());
            //Rectangle rect = new Rectangle(2, 3);
            //Console.WriteLine("I am a rectangle. " +
            //    "My perimeter is {0:f2}. My surface is {1:f2}.",
            //    rect.CalcPerimeter(), rect.CalcSurface());

            List<Figure> figures = new List<Figure>()
            {
                new Rectangle(20, 65),
                new Circle(55),
                new Rectangle(22, 11),
                new Circle(8),
                new Circle(77),
            };

            foreach (Figure figure in figures)
            {
                Console.WriteLine("I'm " + figure.GetType().Name + " and my perimeter is - {0:f2}.", figure.CalcPerimeter());
                Console.WriteLine("I'm " + figure.GetType().Name + " and my surface is - {0:f2}.", figure.CalcSurface());
            }
        }
    }
}