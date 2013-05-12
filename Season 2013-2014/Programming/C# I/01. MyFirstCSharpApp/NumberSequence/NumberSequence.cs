using System;

class NumberSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; ++i)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}