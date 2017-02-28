using System;
using System.Text;

class SelectionSortAlgorithm
{
    static void Main(string[] args)
    {
        Console.Write("Enter the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("array[{0}] = ", index);
            array[index] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Not sorted array :");
        PrintTheArray(array);

        //TODO : Selection Sort
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minValue = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    minValue = j;
                }
            }

            if (minValue != i)
            {
                int tempValue = array[i];
                array[i] = array[minValue];
                array[minValue] = tempValue;
            }
        }

        Console.WriteLine("\nSorted array :");
        PrintTheArray(array);
    }

    static void PrintTheArray(int[] array)
    {
        StringBuilder result = new StringBuilder();

        result.Append("{ ");

        for (int i = 0; i < array.Length; i++)
        {
            result.Append(array[i] + ", ");
        }
        result.Length -= 2;
        result.Append(" }");

        Console.WriteLine(result.ToString());
    }
}

//Sorting an array means to arrange its elements in increasing order.
//Write a program to sort an array. Use the "selection sort" algorithm
//Find the smallest element, move it at the first position, find the
//smallest from the rest, move it at the second position, etc.