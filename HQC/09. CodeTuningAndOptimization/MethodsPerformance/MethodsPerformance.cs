using System;
using System.Diagnostics;

class MethodsPerformance
{
    static void DisplayExecutionTime(Action action)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        action();
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);
    }

    static void Main(string[] args)
    {
        float performanceValueFloat = 10000;
        double performanceValueDouble = 10000;
        decimal performanceValueDecimal = 10000;

        Console.Write("SquareRoot with Mat.Sqrt for FLOAT \t");
        DisplayExecutionTime(() => Math.Sqrt((double)performanceValueFloat));
        Console.Write("SquareRoot with Mat.Sqrt for DOUBLE \t");
        DisplayExecutionTime(() => Math.Sqrt(performanceValueDouble));
        Console.Write("SquareRoot with Mat.Sqrt for DECIMAL \t");
        DisplayExecutionTime(() => Math.Sqrt((double)performanceValueDecimal));

        Console.WriteLine();

        Console.Write("Logarithm with Mat.Log for FLOAT\t");
        DisplayExecutionTime(() => Math.Log((double)performanceValueFloat));
        Console.Write("Logarithm with Mat.Log for DOUBLE \t");
        DisplayExecutionTime(() => Math.Log(performanceValueDouble));
        Console.Write("Logarithm with Mat.Log for DECIMAL \t");
        DisplayExecutionTime(() => Math.Log((double)performanceValueDecimal));

        Console.WriteLine();

        Console.Write("Sinus with Mat.Sin for FLOAT\t\t");
        DisplayExecutionTime(() => Math.Sin((double)performanceValueFloat));
        Console.Write("Sinus with Mat.Sin for DOUBLE\t\t");
        DisplayExecutionTime(() => Math.Sin(performanceValueDouble));
        Console.Write("Sinus with Mat.Sin for DECIMAL\t\t");
        DisplayExecutionTime(() => Math.Sin((double)performanceValueDecimal));
    }
}