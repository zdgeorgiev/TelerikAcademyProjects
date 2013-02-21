using System;
using System.Collections.Generic;

class OddOrEven
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(a%2==1 ?"Odd" : "Even");
    }
}
