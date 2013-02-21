using System;

class NFactorielAndKFactorielDivide
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int factorialN = 1;
        do
        {
            factorialN *= a;
            a--;
        } while (a > 1);
        
        Console.WriteLine("N! = {0}",factorialN);

        int b = int.Parse(Console.ReadLine());
        int factorialK = 1;
        do
        {
            factorialK *= b;
            b--;
        } while (b > 1);

        Console.WriteLine("N! = {0}", factorialK);

        if (factorialN > factorialK && factorialK > 1)
        {
            Console.WriteLine("{0}", factorialN / factorialK);
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }
}

//Write a program that calculates N!/K! for given N and K (1<K<N).
