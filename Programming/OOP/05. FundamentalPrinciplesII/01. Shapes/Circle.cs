using System;

class Circle : Shape
{
    public Circle(double radios)
        : base(radios, radios) //width = radios, height = radios
    {
    }

    public override double CalcSurface()
    {
        return Math.PI * this.Width * this.Width; //because width is equal to radios
    }
}