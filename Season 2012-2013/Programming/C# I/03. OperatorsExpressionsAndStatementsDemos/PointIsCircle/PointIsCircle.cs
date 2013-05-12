using System;

class PointIsCircle
{
    static void Main()
    {
        int centerx = 0;
        int centery = 5;
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        if ((x - centerx) * (x - centerx) - ((y - centery) * (y - centery)) <= centery * centery)
        {
            Console.WriteLine("The points is inside the circle");
        }
        else
        {
            Console.WriteLine("The point is outside the circle");
        }
    }
}

//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
