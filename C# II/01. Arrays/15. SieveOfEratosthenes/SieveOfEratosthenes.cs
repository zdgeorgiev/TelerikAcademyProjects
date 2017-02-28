using System;

class SieveOfEratosthenes
{
    static void PrintAllPrimes(int number)
    {
        //Default value: false
        bool[] primes = new bool[number];

        for (int i = 2; i < 10; i++)
        {
            for (int j = i + 1; j < number; j++)
            {
                //if find a not prime number and not marked as true
                if (j % i == 0 && primes[j] == false)
                {
                    primes[j] = true;
                }
            }
        }

        for (int i = 2; i < primes.Length; i++)
        {
            //all false values are primes
            if (!primes[i])
            {
                Console.WriteLine(i + " ");
            }
        }
    }

    static void Main(string[] args)
    {
        int n = 10000001;

        PrintAllPrimes(n);
    }
}

//Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).