using System;

class PointWithinCirlce
{
    static void Main(string[] args)
    {
        Console.Write("Enter X: ");
        decimal pointX = decimal.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        decimal pointY = decimal.Parse(Console.ReadLine());
        decimal centerX = 0m;
        decimal centerY = 5m;

        //In general, x and y must satisfy (x-center_x)^2 + (y - center_y)^2 < radius^2.
        decimal resultX = (pointX - centerX) * (pointX - centerX);
        decimal resultY = (pointY - centerY) * (pointY - centerY);

        decimal endResult = resultX + resultY;

        decimal radius = 5;

        bool isWithinCircle = endResult < radius * radius;

        Console.WriteLine(isWithinCircle);
    }
}

//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).