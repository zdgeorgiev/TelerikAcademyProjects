using System;

class QuadraticEquasion
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double D = b * b - 4 * a * c;

        if (D > 0)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("x1 = {0}", x1);
            Console.WriteLine("x2 = {0}", x2);
        }
        else if (D < 0)
        {
            Console.WriteLine("No real solution");
        }
        else if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("x = {0}", x);
        }
    }
}

//Write a program that reads the coefficients a, b and c of
//a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).