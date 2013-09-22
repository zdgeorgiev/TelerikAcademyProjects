using System;

public class GenericClassTest
{
    static void Main(string[] args)
    {
        GenericClass<int> firstGeneric = new GenericClass<int>(10);

        for (int i = 0; i < 15; i++)
        {
            firstGeneric.Add(i);
        }

        firstGeneric.RemoveAt(5);
        Console.WriteLine(firstGeneric);
        firstGeneric.InsertAt(11, 99);
        Console.WriteLine(firstGeneric);

        Console.WriteLine(firstGeneric.Lenght);

        firstGeneric.RemoveAt(0);
        Console.WriteLine(firstGeneric);
        firstGeneric.RemoveAt(6);
        Console.WriteLine(firstGeneric);

        Console.WriteLine(firstGeneric.Lenght);

        Console.WriteLine("Lowest element {0}", firstGeneric.Min());
        Console.WriteLine("Biggest element {0}", firstGeneric.Max());

        firstGeneric.Clear();
        Console.WriteLine(firstGeneric);
        Console.WriteLine();

        GenericClass<string> secondGeneric = new GenericClass<string>();

        for (int i = 0; i < 15; i++)
        {
            secondGeneric.Add("Po" + i);
        }

        secondGeneric.RemoveAt(5);
        Console.WriteLine(secondGeneric);
        secondGeneric.InsertAt(11, "P");
        Console.WriteLine(secondGeneric);

        Console.WriteLine(secondGeneric.Lenght);

        secondGeneric.RemoveAt(0);
        Console.WriteLine(secondGeneric);
        secondGeneric.RemoveAt(6);
        Console.WriteLine(secondGeneric);

        Console.WriteLine(secondGeneric.Lenght);

        Console.WriteLine("Min element {0}", secondGeneric.Min());
        Console.WriteLine("Biggest element {0}", secondGeneric.Max());

        secondGeneric.Clear();
        Console.WriteLine(secondGeneric);
    }
}