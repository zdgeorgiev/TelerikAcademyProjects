using System;
using System.Numerics;

class KaspichanNumbers
{
    static string ConvertToDecimal(BigInteger number, string[] allNumbers)
    {
        if (number < 256)
        {
            return allNumbers[(int)number];
        }

        string total = string.Empty;

        while (number > 0)
        {
            total = total.Insert(0, ConvertToDecimal(number % 256, allNumbers));
            
            number /= 256;
        }

        return total;
    }

    static void Main(string[] args)
    {
        string[] allPossibleNumbers = new string[256];

        for (int i = 0; i < 26; i++)
        {
            allPossibleNumbers[i] = ((char)(i + 65)).ToString();
        }

        int counter = 26;

        for (int j = 65; j < 74; j++)
        {
            for (int i = 65; i < 91; i++)
            {
                allPossibleNumbers[counter] = (((char)(j)).ToString().ToLower() + ((char)(i)).ToString()).ToString();
                counter++;

                if (counter == 256)
                {
                    break;
                }
            }
        }

        BigInteger number = BigInteger.Parse(Console.ReadLine());

        Console.WriteLine(ConvertToDecimal(number, allPossibleNumbers));
    }
}