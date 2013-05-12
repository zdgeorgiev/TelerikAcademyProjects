﻿/* Write a program that finds the maximal
 * sequence of equal elements in an array.
                Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
 */

using System;

class MaxSequenceInArray
{
    static void Main()
    {
        int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 8, 8, 8, 9, 0, 1 };
        int len = 1;
        int bestLen = 0;
        int bestLenElement = 0;
        for (int i = 0; i < myArray.Length-1; i++)
        {
            if (myArray[i] == myArray[i+1])
            {
                len++;
            }
            else
            {
                if (len > bestLen)
                {
                    bestLen = len;
                    bestLenElement = myArray[i];
                }
                len = 1;
            }
        }
        // Special case
        if (len > bestLen)
        {
            bestLen = len;
            bestLenElement = myArray[myArray.Length - 1];
        }
        Console.WriteLine("The longest sequence if form {0} elements of type \"{1}\" .", bestLen, bestLenElement);
    }
}