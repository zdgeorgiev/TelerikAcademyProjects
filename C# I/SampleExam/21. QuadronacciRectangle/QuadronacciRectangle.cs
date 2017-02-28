using System;
using System.Text;
using System.Numerics;

class QuadronacciRectangle
{
    static void Main(string[] args)
    {
        BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger fourthNumber = BigInteger.Parse(Console.ReadLine());

        int height = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());

        BigInteger[] allNumbers = new BigInteger[width * height];

        allNumbers[0] = firstNumber;
        allNumbers[1] = secondNumber;
        allNumbers[2] = thirdNumber;
        allNumbers[3] = fourthNumber;

        for (int i = 4; i < width * height; i++)
        {
            BigInteger fiveNumber = firstNumber + secondNumber + thirdNumber + fourthNumber;
            allNumbers[i] = fiveNumber;

            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = fourthNumber;
            fourthNumber = fiveNumber;
        }

        StringBuilder result = new StringBuilder();
        int currentWidth = width;

        for (int j = 0; j < width * height; j++)
        {
            if (j < currentWidth)
            {
                result.Append(allNumbers[j]);
                result.Append(" ");
            }
            else
            {
                if (j == currentWidth)
                {
                    result.Length--;
                    result.AppendLine();
                }
                currentWidth += width;
                j--;
            }
        }

        result.Length--;

        Console.WriteLine(result.ToString());
    }
}