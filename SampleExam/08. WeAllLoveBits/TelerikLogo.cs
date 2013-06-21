using System;

class TelerikLogo
{
    static void Main(string[] args)
    {
        int X = int.Parse(Console.ReadLine());
        int width = ((X / 2) + 1 + (X / 2) + 1) + 2 * X - 3;
        int hornDots = X / 2;
        int middleDots = 2 * X - 3;

        int leftHornDots = X / 2 - 1;
        int leftRightDots = ((X / 2 - 1) - leftHornDots);

        int rightHornDots = X / 2 - 1;
        int rightLeftDots = ((X / 2 - 1) - rightHornDots);

        Console.Write(new string('.', hornDots));
        Console.Write("*");
        Console.Write(new string('.', middleDots));
        Console.Write("*");
        Console.Write(new string('.', hornDots));
        Console.WriteLine();

        for (int i = 0; i < X - 2; i++)
        {
            middleDots -= 2;
            int leftDots = i + 1;

            if (i <= X / 2 - 1)
            {
                Console.Write(new string('.', leftHornDots));
                Console.Write("*");
                Console.Write(new string('.', leftRightDots));

                leftHornDots--;
                leftRightDots++;
            }
            else
            {
                Console.Write(new string('.', hornDots));
            }

            Console.Write(new string('.', leftDots));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', leftDots));

            if (i <= X / 2 - 1)
            {
                Console.Write(new string('.', rightLeftDots));
                Console.Write("*");
                Console.Write(new string('.', rightHornDots));

                rightHornDots--;
                rightLeftDots++;
            }
            else
            {
                Console.Write(new string('.', hornDots));
            }

            Console.WriteLine();
        }

        Console.Write(new string('.', width / 2));
        Console.Write("*");
        Console.Write(new string('.', width / 2));
        Console.WriteLine();

        middleDots = 1;

        for (int i = 0; i < X - 1; i++)
        {
            int leftDots = X - 2 - i;

            Console.Write(new string('.', hornDots));
            Console.Write(new string('.', leftDots));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', leftDots));
            Console.Write(new string('.', hornDots));
            Console.WriteLine();
            middleDots += 2;
        }

        middleDots -= 4;

        for (int i = 0; i < X - 2; i++)
        {
            int leftDots = i + 1;

            Console.Write(new string('.', hornDots));
            Console.Write(new string('.', leftDots));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', leftDots));
            Console.Write(new string('.', hornDots));
            Console.WriteLine();
            middleDots -= 2;
        }

        Console.Write(new string('.', width / 2));
        Console.Write("*");
        Console.Write(new string('.', width / 2));
        Console.WriteLine();
    }
}

//..*.......*..
//.*.*.....*.*.
//*...*...*...*
//.....*.*.....
//......*......
//.....*.*.....
//....*...*....
//...*.....*...
//..*.......*..
//...*.....*...
//....*...*....
//.....*.*.....
//......*......
