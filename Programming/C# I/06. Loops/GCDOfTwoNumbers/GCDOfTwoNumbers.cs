using System;

class myclass
{
    static void Main()
    {
        int i1, i2;

        Console.WriteLine("Enter 2 numbers to find GCD");
        i1 = int.Parse(Console.ReadLine());
        i2 = int.Parse(Console.ReadLine());

        int n1, n2;
        //Making sure n1 is greater than n2
        if (i1 > i2)
        {
            n1 = i1;
            n2 = i2;
        }
        else
        {
            n1 = i2;
            n2 = i1;
        }
        int result = gcd(n1, n2);
        Console.WriteLine("The GCD of {0} and {1} is {2}", i1, i2, result);
        Console.Read();
    }

    private static int gcd(int n1, int n2)
    {
        int rem = 5;
        while (n2 > 0)
        {
            rem = n1 % n2;
            if (rem == 0)
                return n2;
            n1 = n2;
            n2 = rem;

        }
        //gcd of any number with 0 is number itself.

        return n1;

    }
}