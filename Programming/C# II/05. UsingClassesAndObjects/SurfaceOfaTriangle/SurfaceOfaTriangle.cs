using System;

    class SurfaceOfaTriangle
    {
        private static void SideAndAltitude()
        {
            Console.Write("Enter value for the side: ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Enter value for the altitude: ");
            double altitude = double.Parse(Console.ReadLine());
            double s = (side * altitude) / 2;
            Console.WriteLine("The Surface is {0}", s);
        }
        
        private static void ThreeSides()
        {
            Console.Write("Enter the value for the first side: ");
            double firstSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for the second side: ");
            double secondSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for the third side: ");
            double thirdSide = double.Parse(Console.ReadLine());
            double s = (firstSide + secondSide + thirdSide) / 2;
            Console.WriteLine("The Surface is {0}", Math.Sqrt((s - firstSide)*(s - secondSide)*(s - thirdSide)));
        }

        private static void TwoSidesAndAngleBetweenThem()
        {
            Console.Write("Enter the value for the first side: ");
            double firstSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for the second side: ");
            double secondSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for Angle Between sides: ");
            double angle = int.Parse(Console.ReadLine());
            Console.WriteLine("The Surface is {0}", firstSide * secondSide * Math.Sin(Math.PI*angle / 180)/ 2);
        }

        static void Main()
        {
            Console.WriteLine("This program calculate the surface of a triangle.");
            Console.WriteLine("1. Side and Altitude");
            Console.WriteLine("2. Three Sides");
            Console.WriteLine("3. Two Sides and Angle between them");
            Console.WriteLine("Enter the method for calculate");
            int choise = int.Parse(Console.ReadLine());
        
            switch (choise)
            {
                case 1: SideAndAltitude(); break;
                case 2: ThreeSides(); break;
                case 3: TwoSidesAndAngleBetweenThem(); break;
                default: Console.WriteLine("Invalid Number!"); break;
            }
        }
    }

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
