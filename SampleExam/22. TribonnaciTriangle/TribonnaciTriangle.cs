using System;
using System.Numerics;
using System.Text;

class TribonnaciTriangle
{
    static void Main(string[] args)
    {
        BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdNumber = BigInteger.Parse(Console.ReadLine());

        int height = int.Parse(Console.ReadLine());

        BigInteger[] allNumbers = new BigInteger[height * height];

        allNumbers[0] = firstNumber;
        allNumbers[1] = secondNumber;
        allNumbers[2] = thirdNumber;

        for (int i = 3; i < height * height; i++)
        {
            BigInteger fourthNumber = firstNumber + secondNumber + thirdNumber;
            allNumbers[i] = fourthNumber;

            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = fourthNumber;
        }

        StringBuilder result = new StringBuilder();
        int currentNumber = 0;

        for (int i = 0; i < height; i++)
        {
            int numbersPerRow = i + 1;

            for (int j = 0; j < numbersPerRow; j++)
            {
                result.Append(allNumbers[currentNumber]);
                result.Append(" ");
                currentNumber++;
            }
            result.Length--;
            result.AppendLine();
        }

        Console.WriteLine(result.ToString());
    }
}