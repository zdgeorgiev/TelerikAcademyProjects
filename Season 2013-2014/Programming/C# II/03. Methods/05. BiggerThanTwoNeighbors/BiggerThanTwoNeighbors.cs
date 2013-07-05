using System;
using System.Text;

class BiggerThanTwoNeighbors
{
    static bool IsBiggerThanTwoNeighbors(int[] array, int index)
    {
        bool isBigger = false;

        if (index == 0 || index == array.Length - 1)
        {
            throw new ArgumentException(string.Format(
                "Sorry but the number at index {0} doesnt have two neighbors.", index));
        }

        if (array[index] > array[index + 1] && array[index] > array[index - 1])
        {
            isBigger = true;
        }

        return isBigger;
    }

    static void Main(string[] args)
    {
        int[] array = new int[] { 2, 7, 1, 8, 2, 1, 6, 8, 2, 14, 7, 2, 1, 1, 7, 32, 1 };

        Console.Write("Enter a index : ");
        int index = int.Parse(Console.ReadLine());

        PrintTheArray(array);
        Console.WriteLine("\nIs number {0} at index {1} is bigger than two neighbors {2} and {3} - {4}",
            array[index], index, array[index - 1], array[index + 1], IsBiggerThanTwoNeighbors(array, index));
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

//Write a method that checks if the element at given position in given 
//array of integers is bigger than its two neighbors (when such exist).