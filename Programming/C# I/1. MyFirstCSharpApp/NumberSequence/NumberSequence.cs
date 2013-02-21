using System;
using System.Collections.Generic;

class NumberSequence
{
    static void Main()
    {
        for (int b = 2; b < 12; ++b)
        {
            if (b % 2 == 1)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("-" + b);
            }
        }
    }
}


