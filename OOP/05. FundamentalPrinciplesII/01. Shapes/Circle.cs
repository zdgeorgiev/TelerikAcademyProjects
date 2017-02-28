using System;

public class Circle : Shape
{
    public Circle(int radius)
        : base(radius, radius)
    {
    }

    public override double CalculateSurface()
    {
        return Math.Round(Math.PI * (this.Width * this.Width),2);
    }
}