using System;

class BestFrequent
{
    static void Main()
    {
        int bestSequence = 0;
        int currentSequence = 1;
        int frequentNumb = int.MinValue;
        int n = int.Parse(Console.ReadLine());
        int[] myArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter value for myArr[{0}] = ", i);
            myArr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {

            for (int j = i + 1; j < n; j++)
            {
                if (myArr[i] == myArr[j])
                {
                    currentSequence++;
                }
            }

            if (bestSequence < currentSequence)
            {
                bestSequence = currentSequence;
                frequentNumb = i;
            }
            currentSequence = 1;
        }
            Console.Write("Best freguent number is {0}({1}times)", myArr[frequentNumb], bestSequence);
            Console.WriteLine();
    }
}

//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
