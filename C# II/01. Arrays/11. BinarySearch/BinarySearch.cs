using System;
using System.Text;

class BinarySearch
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

        Console.Write("\nEnter the Key : ");
        int key = int.Parse(Console.ReadLine());

        //For binary search before you do you make
        //sure you sorted the array, anyway its impossible.
        Array.Sort(array);

        Console.Write("\nSorted Array : ");
        PrintTheArray(array);

        Console.WriteLine("The key exist at position {0} from the array", BinarySearchInArray(array, key));
    }

    static int BinarySearchInArray(int[] array, int key)
    {
        int min = 0;
        int max = array.Length - 1;

        while (max >= min)
        {
            int middle = (min + max) / 2;

            if (array[middle] < key)
            {
                min = middle + 1;
            }
            else if (array[middle] > key)
            {
                max = middle - 1;
            }
            else
            {
                return middle;
            }
        }

        //If the key doesnt exist in the array return
        //index -1 because the index is invalid
        return -1;
    }

    private static void PrintTheArray(int[] array)
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