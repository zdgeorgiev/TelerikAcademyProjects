using System;

class IsNumbrPrime
{
    static void Main(string[] args)
    {
        bool isNumberValid = false;

        do
        {
            Console.Write("Please enter a number in range [1...100] : ");
            int number = int.Parse(Console.ReadLine());

            if (1 <= number && number <= 100)
            {
                isNumberValid = true;
                Console.WriteLine(IsPrime(number));
            }
            else
            {
                Console.WriteLine(
                    "Sorry but your number ({0}) isnt in range [1...100].Enter again!", number);
            }
        }
        while (!isNumberValid);
    }

    static bool IsPrime(int number)
    {
        bool isPrime = true;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        return isPrime;
    }
}

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.