using System;

class ExchangeValues
{
    static void Main(string[] args)
    {
        Console.Write("Enter value for a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("\nBEFORE");
        Console.WriteLine("a = {0}, b = {1}\n", a, b);

        int tempValueA = a;
        int tempValueB = b;

        a = tempValueB;
        b = tempValueA;

        Console.WriteLine("AFTER");
        Console.WriteLine("a = {0}, b = {1}\n", a, b);
    }
}

//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.