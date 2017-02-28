using System;

class Fire
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int leftDots = n / 2 - 1;
        int middleDots = 0;

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.Write(new string('.', leftDots));
            Console.Write("#");
            Console.Write(new string('.', middleDots));
            Console.Write("#");
            Console.Write(new string('.', leftDots));
            Console.WriteLine();

            leftDots--;
            middleDots += 2;
        }

        Console.Write("#");
        Console.Write(new string('.', n - 2));
        Console.Write("#");
        Console.WriteLine();
        Console.Write("#");
        Console.Write(new string('.', n - 2));
        Console.Write("#");
        Console.WriteLine();

        leftDots = 1;
        middleDots = n - 4;

        for (int i = 0; i < n / 4 - 1; i++)
        {
            Console.Write(new string('.', leftDots));
            Console.Write("#");
            Console.Write(new string('.', middleDots));
            Console.Write("#");
            Console.Write(new string('.', leftDots));
            Console.WriteLine();

            middleDots -= 2;
            leftDots++;
        }

        Console.WriteLine(new string('-', n));

        leftDots = 0;
        int leftLines = n / 2;
        int rightLines = n / 2;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', leftDots));
            Console.Write(new string('\\', leftLines));
            Console.Write(new string('/', rightLines));
            Console.Write(new string('.', leftDots));
            Console.WriteLine();

            leftDots++;
            leftLines--;
            rightLines--;
        }
    }
}