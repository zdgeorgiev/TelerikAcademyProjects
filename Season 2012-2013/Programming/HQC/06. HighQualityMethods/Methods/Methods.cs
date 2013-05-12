using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("The sides of the triangle should be positive numbers.");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

            return area;
        }

        static string NumberToEnglishWord(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid Number!");
            }
        }

        static int FindMaxNumber(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("The array is null or empty.");
            }
            
            int max = int.MinValue;

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        static void PrintAsFloatNumber(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        static void PrintRightAlignedNumber(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        static void PrintNumberAsProcent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static bool CheckIsVerical(double x1, double x2, out bool isVertical)
        {
            isVertical = (x1 == x2);
            return isVertical;
        }

        public static bool CheckIsHorizontal(double y1, double y2, out bool isHorizontal)
        {
            isHorizontal = (y1 == y2);
            return isHorizontal;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToEnglishWord(5));

            Console.WriteLine(FindMaxNumber(5, -1, 3, 2, 14, 2, 3));

            PrintAsFloatNumber(1.3);
            PrintNumberAsProcent(0.75);
            PrintRightAlignedNumber(2.30);
            bool isVertical = false;
            bool isHorizontal = false;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine(CheckIsVerical(3, 3, out isVertical));
            Console.WriteLine(CheckIsHorizontal(-1, 2.5, out isHorizontal));
            Console.WriteLine("Vertical? " + isVertical);
            Console.WriteLine("Horizontal? " + isHorizontal);

            Student peter = new Student("Peter", "Ivanov", 16, "Sofia");
            Student stella = new Student("Stella", "Markova", 25, "Vidin");
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
