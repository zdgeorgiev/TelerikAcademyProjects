using System;

class BiggestOfThree
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("The biggest number is {0}", a);
            }
            else if (a < c)
            {
                Console.WriteLine("The biggest number is {0}", c);
            }
        }
        else if (c > b)
        {
            if (c > a)
            {
                Console.WriteLine("The biggest number is {0}", c);
            }
            else if (c < a)
            {
                Console.WriteLine("The biggest number is {0}", a);
            }
        }
        else if (b > a)
        {
            if (b > c)
            {
                Console.WriteLine("The biggest number is {0}", b);
            }
            else if (b < c)
            {
                Console.WriteLine("The biggest number is {0}", c);
            }
        }
    }
} 


//Write a program that finds the biggest of three integers using nested if statements.
