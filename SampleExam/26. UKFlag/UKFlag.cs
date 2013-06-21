using System;

class UKFlag
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++)
        {
            int leftLine = 1;
            int middleLine = 1;
            int rightLine = 1;
            int leftHalf = i;
            int rightHalf = n / 2 - 1 - i;

            Console.Write(new string('.', leftHalf));
            Console.Write(new string('\\', leftLine));
            Console.Write(new string('.', rightHalf));
            Console.Write(new string('|', middleLine));
            Console.Write(new string('.', rightHalf));
            Console.Write(new string('/', rightLine));
            Console.Write(new string('.', leftHalf));
            Console.WriteLine();
        }

        Console.Write(new string('-', n / 2));
        Console.Write(new string('*', 1));
        Console.Write(new string('-', n / 2));
        Console.WriteLine();

        for (int i = 0; i < n / 2; i++)
        {
            int leftLine = 1;
            int middleLine = 1;
            int rightLine = 1;
            int leftHalf = n / 2 - 1 - i;
            int rightHalf = i;

            Console.Write(new string('.', leftHalf));
            Console.Write(new string('/', leftLine));
            Console.Write(new string('.', rightHalf));
            Console.Write(new string('|', middleLine));
            Console.Write(new string('.', rightHalf));
            Console.Write(new string('\\', rightLine));
            Console.Write(new string('.', leftHalf));
            Console.WriteLine();
        }
    }
}

//\...|.../
//.\..|../.
//..\.|./..
//...\|/...
//----*----
//.../|\...
//../.|.\..
//./..|..\.
///...|...\
///
//9