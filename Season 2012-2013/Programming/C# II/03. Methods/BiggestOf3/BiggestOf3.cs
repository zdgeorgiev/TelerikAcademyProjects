using System;

class BiggestOf3
{
    static int GetMax(int a, int b)
    {
        int biggest = a;

        if (a < b)
        {
            biggest = b;
            return b;
        }
        return a;
    }

    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k= ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("m= ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("The biggest number is {0}", GetMax(GetMax(n, k), m));
    }
}

//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

