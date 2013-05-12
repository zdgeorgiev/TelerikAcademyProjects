using System;

class Triangle : Shape
{
    public Triangle(double width, double height)
        : base(width, height)
    {
    }

    public override double CalcSurface()
    {
        return base.Height * base.Width / 2;
    }
}