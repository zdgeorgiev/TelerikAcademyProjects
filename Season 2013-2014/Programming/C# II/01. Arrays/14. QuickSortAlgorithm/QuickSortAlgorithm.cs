using System;

class QuickSortAlgorithm
{
    static void Quicksort(int[] elements, int left, int right)
    {
        int leftIndex = left;
        int rightIndex = right;
        int pivot = elements[(left + right) / 2];

        while (leftIndex <= rightIndex)
        {
            //Find the first bigger or equal number
            while (elements[leftIndex] < pivot)
            {
                leftIndex++;
            }

            //Find the first lower or equal number
            while (elements[rightIndex] > pivot)
            {
                rightIndex--;
            }

            if (leftIndex <= rightIndex)
            {
                // Swap the bigger with lower
                int tmp = elements[leftIndex];
                elements[leftIndex] = elements[rightIndex];
                elements[rightIndex] = tmp;

                leftIndex++;
                rightIndex--;
            }
        }

        // Recursive calls
        if (left < rightIndex)
        {
            Quicksort(elements, left, rightIndex);
        }

        if (leftIndex < right)
        {
            Quicksort(elements, leftIndex, right);
        }
    }

    static void Main(string[] args)
    {
        int[] array = new int[] { 3, 1, 61, 2, 6, 2, 7, 1, 10, 9, 6, 5, 3, 1, 3, 123, 2 };

        Quicksort(array, 0, array.Length - 1);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] +" ");
        }
    }
}

//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).