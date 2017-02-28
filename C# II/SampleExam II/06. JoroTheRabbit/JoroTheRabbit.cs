using System;

class JoroTheRabbit
{
    static void Main(string[] args)
    {
        string[] patternNumbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] numbersArray = new int[patternNumbers.Length];

        for (int i = 0; i < patternNumbers.Length; i++)
        {
            numbersArray[i] = int.Parse(patternNumbers[i]);
        }

        int bestLenght = int.MinValue;

        for (int number = 0; number < numbersArray.Length; number++)
        {
            for (int step = 1; step < numbersArray.Length; step++)
            {
                int currentLen = 1;
                int currentNumberIndex = number;
                int nextNumberIndex = (number + step) % numbersArray.Length;

                while (numbersArray[currentNumberIndex] < numbersArray[nextNumberIndex])
                {
                    currentLen++;
                    currentNumberIndex = nextNumberIndex;
                    nextNumberIndex = (currentNumberIndex + step) % numbersArray.Length;
                }

                if (currentLen > bestLenght)
                {
                    bestLenght = currentLen;
                }
            }
        }

        Console.WriteLine(bestLenght);
    }
}


//1, -2, -3, 4, -5, 6, -7, -8

//          -3
//       -2    -4
//     1          -5
//       -8     6
//          -7