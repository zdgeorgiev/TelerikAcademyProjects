using System;

class FairTree
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            int leftDots = n - 2 - i;
            int stars = 2 * i + 1;
            int rightDots = leftDots;
            
            Console.Write(new string('.', leftDots));
            Console.Write(new string('*', stars));
            Console.Write(new string('.', rightDots));
            Console.WriteLine();
        }

        Console.Write(new string('.', n - 2));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', n - 2));
        Console.WriteLine();
    }
}


//...*...
//..***..
//.*****.
//*******
//...*...

//5