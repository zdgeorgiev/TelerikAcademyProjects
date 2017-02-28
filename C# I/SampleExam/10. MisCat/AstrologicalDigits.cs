using System;
using System.Text;
using System.Numerics;

class AstrologicalDigits
{
    static void Main()
    {
        string[] numberInput = Console.ReadLine().Split('.', '-');
        StringBuilder finalNumber = new StringBuilder();

        for (int i = 0; i < numberInput.Length; i++)
        {
            finalNumber.Append(numberInput[i]);
        }

        FindAstrologicalDigits(BigInteger.Parse(finalNumber.ToString()));
    }

    static void FindAstrologicalDigits(BigInteger number)
    {
        BigInteger result = 0;

        if (number < 9)
        {
            Console.WriteLine(number);
        }
        else
        {
            while (number > 0)
            {
                BigInteger remainder = number % 10;
                number /= 10;
                result += remainder;
            }

            if (result > 9)
            {
                FindAstrologicalDigits(result);
            }
            else
            {
                Console.WriteLine(result);
                return;
            }
        }
    }
}