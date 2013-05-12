using System;

namespace Abstraction
{
    public class Rectangle : Figure
    {
        private double height;
        private double width;

        public Rectangle()
        {
        }

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Height + this.Width);

            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Height * this.Width;

            return surface;
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentException("Height should be a positive number.");
                }
            }
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("Width should be a positive number.");
                }
            }
        }
    }
}