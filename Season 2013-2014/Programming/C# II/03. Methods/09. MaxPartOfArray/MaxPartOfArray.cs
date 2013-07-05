using System;

class MaxPartOfArray
{
    static int MaxNumberIndex(int[] array, int startIndex)
    {
        int maxNumber = array[startIndex];
        int maxNumberIndex = startIndex;

        for (int i = startIndex + 1; i < array.Length; i++)
        {
            if (array[i] > maxNumber)
            {
                maxNumber = array[i];
                maxNumberIndex = i;
            }
        }

        return maxNumberIndex;
    }

    static void SelectionSort(ref int[] array, bool assending)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int maxNumberIndex = MaxNumberIndex(array, i);

            int tempValue = array[i];
            array[i] = array[maxNumberIndex];
            array[maxNumberIndex] = tempValue;
        }

        if (assending)
        {
            Array.Reverse(array);
        }
    }

    static void Main(string[] args)
    {
        int[] array = new int[] { 8, 3, 5, 7, 2, 1, 7, 2, -4, 6, 1, 1, 7, 1, };

        Console.WriteLine("BiggestNumber in the array is {0}", array[MaxNumberIndex(array, 0)]);

        Console.WriteLine("Descending : ");

        SelectionSort(ref array, false);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine("\nAscending : ");

        SelectionSort(ref array, true);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}

//Write a method that return the maximal element in a portion of array of 
//integers starting at given index. Using it write another method that
//sorts an array in ascending / descending order.