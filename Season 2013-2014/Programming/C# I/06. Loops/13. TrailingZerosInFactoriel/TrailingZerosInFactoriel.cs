using System;
using System.Numerics;

class TrailingZerosInFactoriel
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        number = Factorial(number);
        int counter = 0;
        
        while (number % 5 == 0)
        {
            counter++;
            number /= 10;
        }
        
        Console.WriteLine("{0} trailing zeros at the end.", counter);
    }

    static BigInteger Factorial(BigInteger number)
    {
        if (number == 1)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}

//* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
//    N = 10  N! = 3628800  2
//    N = 20  N! = 2432902008176640000  4
//    Does your program work for N = 50 000?
//    Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!