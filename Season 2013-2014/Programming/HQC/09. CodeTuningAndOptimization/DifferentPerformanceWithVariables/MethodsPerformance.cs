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

    static void Main()
    {
        Console.Write("Adding INT\t\t");
        DisplayExecutionTime(() => AddMethod.AddInt());
        Console.Write("Adding LONG\t\t");
        DisplayExecutionTime(() => AddMethod.AddLong());
        Console.Write("Adding FLOAT\t\t");
        DisplayExecutionTime(() => AddMethod.AddFloat());
        Console.Write("Adding DOUBLE\t\t");
        DisplayExecutionTime(() => AddMethod.AddDouble());
        Console.Write("Adding DECIMAL\t\t");
        DisplayExecutionTime(() => AddMethod.AddDecimal());

        Console.WriteLine();

        Console.Write("Subsctrating INT\t");
        DisplayExecutionTime(() => SubtractMethod.SubtractInt());
        Console.Write("Subsctrating LONG\t");
        DisplayExecutionTime(() => SubtractMethod.SubtractLong());
        Console.Write("Subsctrating FLOAT\t");
        DisplayExecutionTime(() => SubtractMethod.SubtractFloat());
        Console.Write("Subsctrating DOUBLE\t");
        DisplayExecutionTime(() => SubtractMethod.SubtractDouble());
        Console.Write("Subsctrating DECIMAL\t");
        DisplayExecutionTime(() => SubtractMethod.SubtractDecimal());

        Console.WriteLine();

        Console.Write("Multiply INT\t\t");
        DisplayExecutionTime(() => MultiplyMethod.MultiplyInt());
        Console.Write("Multiply LONG\t\t");
        DisplayExecutionTime(() => MultiplyMethod.MultiplyLong());
        Console.Write("Multiply FLOAT\t\t");
        DisplayExecutionTime(() => MultiplyMethod.MultiplyFloat());
        Console.Write("Multiply DOUBLE\t\t");
        DisplayExecutionTime(() => MultiplyMethod.MultiplyDouble());
        Console.Write("Multiply DECIMAL\t");
        DisplayExecutionTime(() => MultiplyMethod.MultiplyDecimal());

        Console.WriteLine();

        Console.Write("Divide INT\t\t");
        DisplayExecutionTime(() => DivideMethod.DivideInt());
        Console.Write("Divide LONG\t\t");
        DisplayExecutionTime(() => DivideMethod.DivideLong());
        Console.Write("Divide FLOAT\t\t");
        DisplayExecutionTime(() => DivideMethod.DivideFloat());
        Console.Write("Divide DOUBLE\t\t");
        DisplayExecutionTime(() => DivideMethod.DivideDouble());
        Console.Write("Divide DECIMAL\t\t");
        DisplayExecutionTime(() => DivideMethod.DivideDecimal());
    }
}