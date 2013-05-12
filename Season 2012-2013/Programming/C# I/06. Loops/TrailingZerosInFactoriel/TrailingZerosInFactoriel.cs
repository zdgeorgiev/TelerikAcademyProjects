using System;

class TrailingZerosInFactoriel
{
    static decimal Factorial(decimal number)
    {
        decimal sum = 1;
        for (int i = 1; i <= number; i++)
        {
            sum *= i;
        }
        return sum;
    }

    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal counter = 0;
        int zeroCounter = 0;

        counter = Factorial(n);
        //Console.WriteLine(counter);

        while (true)
        {
            if (counter % 10 == 0)
            {
                zeroCounter++;
                counter = counter / 10;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(zeroCounter);
    }
}

//N = 10  N! = 3628800  2
//	N = 20  N! = 2432902008176640000  4
