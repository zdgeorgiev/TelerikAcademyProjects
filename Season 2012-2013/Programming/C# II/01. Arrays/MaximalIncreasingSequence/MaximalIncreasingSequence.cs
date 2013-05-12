/* Write a program that finds the maximal
 * increasing sequence in an array. Example: 
 * {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
 */

using System;

    class MaximalIncreasingSequence
    {
        static void Main()
        {
            int[] myArray = { 1, 2, 5, 2, 7, 9, 2, 1, 7, 2, 3, 4, 6, 8, 1, 2, 4, 7, 8, 9, 10, 11, 12, 13, 2 };
            int len = 1;
            int bestLen = 0;
            int endIndex = 0;

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i] < myArray[i + 1])
                {
                    len++;
                }
                else
                {
                    if (len > bestLen)
                    {
                        bestLen = len;
                        endIndex = i;
                    }
                    len = 1; 
                }
            }

            if (len > bestLen)
            {
                bestLen = len;
                endIndex = myArray.Length - 1;
            }

            len = 1;
            Console.WriteLine("The longest sequence of increasing elemints is:");
            Console.Write("{");
            for (int i = endIndex - bestLen + 1; i < endIndex; i++)
            {
                Console.Write("{0},", myArray[i]);
            }
            Console.Write("}");

        }
    }

