using System;

class TwoArrayCompare
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("Enter element - [{0}] from the first array: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write("Enter element - [{0}] from the second array: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(firstArray);
        Array.Sort(secondArray);

        bool areEqual = true;

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                areEqual = false;
                break;
            }
        }
        Console.WriteLine("The two arrays are equal: {0}", areEqual);
    }
}

/* Write a program that reads
 * two arrays from the console
 * and compares them element by element.
 */