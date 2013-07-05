using System;
using System.Text;

class FirstBiggerThanTwoNeighbors
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
        int[] array = new int[] { 2, 2, 2, 2, 2, 1, 6, 8, 2, 14, 7, 2, 1, 1, 7, 32, 1 };

        int firstNumberIndex = -1;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (IsBiggerThanTwoNeighbors(array, i))
            {
                firstNumberIndex = i;
                break;
            }
        }

        Console.WriteLine("First number index bigger than two neighbors - {0}", firstNumberIndex);
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

//Write a method that returns the index of the first element in array
//that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.