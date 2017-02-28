using System;

class BatBoikoTower
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int leftDots = n - 1;
        int middleDots = 0;
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', leftDots));
            Console.Write("/");

            if (count == 1 || count == 3 || count == 6 ||
                count == 10 || count == 15 || count == 21
                || count == 28 || count == 36)
            {
                Console.Write(new string('-', middleDots));
            }
            else
            {
                Console.Write(new string('.', middleDots));
            }
            Console.Write("\\");
            Console.Write(new string('.', leftDots));
            Console.WriteLine();

            middleDots+=2;
            leftDots--;
            count++;
        }
    }
}