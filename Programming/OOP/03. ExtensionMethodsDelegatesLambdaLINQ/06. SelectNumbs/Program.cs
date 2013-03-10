using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = new int[] { 42, 5, 8, 1, 189, 2, 151, 22, 77, 99, 21 };

        var devisibleNumbers = numbers.Where(x => x % 3 == 0).Where(x => x % 7 == 0);

        foreach (var numb in devisibleNumbers)
        {
            Console.WriteLine(numb);
        }

        Console.WriteLine("------");

        var devisibleNumbs =
            from numb in numbers
            where numb % 3 == 0 && numb % 7 == 0
            select numb;

        foreach (var numb in devisibleNumbs)
        {
            Console.WriteLine(numb);
        }
    }
}

//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
