﻿using System;

namespace Abstraction
{
    public class Circle : Figure
    {
        private double radius;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;

            return surface;
        }

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius should be a positive number.");
                }
            }
        }
    }
}