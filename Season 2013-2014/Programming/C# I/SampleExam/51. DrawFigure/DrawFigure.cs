using System;

class SandTime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (3 <= n && n <= 101)
        {
            for (int i = 0; i < n / 2 + 1; i++)
            {
                int dots = i;
                int stars = n - 2 * dots;

                Console.Write(new string('.', dots));
                Console.Write(new string('*', stars));
                Console.Write(new string('.', dots));
                Console.WriteLine();
            }

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                int dots = i;
                int stars = n - 2 * dots;

                Console.Write(new string('.', dots));
                Console.Write(new string('*', stars));
                Console.Write(new string('.', dots));
                Console.WriteLine();
            }
        }
    }
}