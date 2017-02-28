using System;

class NullValues
{
    static void Main(string[] args)
    {
        int? nullableInt = null;
        double? nullableDouble = null;

        Console.WriteLine(nullableInt);
        Console.WriteLine(nullableDouble);

        nullableInt += 50; //Nothing happened
        nullableDouble += 50; //Nothing happened

        Console.WriteLine(nullableInt);
        Console.WriteLine(nullableDouble);
    }
}

//Create a program that assigns null values to
//an integer and to double variables. Try to print them
//on the console, try to add some values or the null literal to them and see the result.