using System;

class QuadraticEquasion
{
    static void Main()
    {
        Console.Write(@"Enter value for ""a"" ");
        int a = int.Parse(Console.ReadLine());
        Console.Write(@"Enter value for ""b"" ");
        int b = int.Parse(Console.ReadLine());
        Console.Write(@"Enter value for ""c"" ");
        int c = int.Parse(Console.ReadLine());
         
        int d = b * b - 4 * (a * c);                         //discriminanta


        if (d > 0)
        {
            Console.WriteLine("Дискриминантата е {0}", d);
        }
        else
        {
            Console.WriteLine("Дискриминантата е отрицателна, следоваталено няма корени.");
        }

        double x1 = ((-b) + (Math.Sqrt(d))) / (2 * a);       //purviq koren
        if (x1 > 0)
        {
            Console.WriteLine("Първият корен е {0}", x1);
        }
        else
        {
            Console.WriteLine(@"Първият корен е отрицателен ""{0}"" ", x1);
        }
       
        
        double x2 = ((-b) - (Math.Sqrt(d))) / (2 * a);       //vtoriq koren
        if (x2 > 0)
        {
            Console.WriteLine("Вторият корен е {0}", x2);
        }
        else
        {
            Console.WriteLine(@"Вторият корен е отрицателен ""{0}"" ",x2);
        }
    }
}

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
