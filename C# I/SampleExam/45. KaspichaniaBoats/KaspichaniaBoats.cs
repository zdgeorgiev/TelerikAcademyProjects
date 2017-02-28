using System;

class KaspichaniaBoats
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('.', n));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', n));
        Console.WriteLine();

        int leftDots = n - 1;
        int middleDots = 0;
        int stars = 1;

        for (int i = 1; i < n; i++)
        {
            Console.Write(new string('.', leftDots));
            Console.Write(new string('*', stars));
            Console.Write(new string('.', middleDots));
            Console.Write(new string('*', stars));
            Console.Write(new string('.', middleDots));
            Console.Write(new string('*', stars));
            Console.Write(new string('.', leftDots));
            Console.WriteLine();

            leftDots--;
            middleDots++;
        }

        Console.WriteLine(new string('*', n * 2 + 1));

        int height = 6 + ((n - 3) / 2) * 3;

        leftDots = 1;
        middleDots -= 1;

        for (int i = 0; i < height / 3 - 1; i++)
        {
            Console.Write(new string('.', leftDots));
            Console.Write(new string('*', stars));
            Console.Write(new string('.', middleDots));
            Console.Write(new string('*', stars));
            Console.Write(new string('.', middleDots));
            Console.Write(new string('*', stars));
            Console.Write(new string('.', leftDots));
            Console.WriteLine();

            leftDots++;
            middleDots--;
        }

        Console.Write(new string('.', ((n * 2 + 1) - n) / 2));
        Console.Write(new string('*', n));
        Console.Write(new string('.', ((n * 2 + 1) - n) / 2));
        Console.WriteLine();
    }
}