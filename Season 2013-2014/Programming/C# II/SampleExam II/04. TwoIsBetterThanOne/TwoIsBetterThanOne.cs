using System;
using System.Numerics;
using System.Linq;

class TwoIsBetterThanOne
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //TIME LIMIT ON THE FIRST TASK

        BigInteger firstNumber = BigInteger.Parse(numbers[0]);
        BigInteger secondNumber = BigInteger.Parse(numbers[1]);

        Console.WriteLine(CompleteFirstTask(firstNumber, secondNumber));

        string[] input = Console.ReadLine().Split(',');
        BigInteger[] array = new BigInteger[input.Length];

        int percentile = int.Parse(Console.ReadLine());

        for (int i = 0; i < input.Length; i++)
        {
            array[i] = BigInteger.Parse(input[i]);
        }

        Array.Sort(array);

        Console.WriteLine(array[(percentile * input.Length - 1) / 100]);
    }

    static BigInteger CompleteFirstTask(BigInteger firstNumber, BigInteger secondNumber)
    {
        BigInteger counter = 0;

        for (BigInteger i = firstNumber; i <= secondNumber; i++)
        {
            string normalRepresentation = i.ToString();
            string reversed = string.Empty;

            for (int j = 0; j < normalRepresentation.Length; j++)
            {
                reversed += normalRepresentation[normalRepresentation.Length - j - 1];
            }

            if (normalRepresentation != reversed)
            {
                continue;
            }
            else
            {
                bool isValid = true;

                for (int j = 0; j < normalRepresentation.Length; j++)
                {
                    if (normalRepresentation[j] != '3' &&
                        normalRepresentation[j] != '5')
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    counter++;
                }
            }
        }

        return counter;
    }
}