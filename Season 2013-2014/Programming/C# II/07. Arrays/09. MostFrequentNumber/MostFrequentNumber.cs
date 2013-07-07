using System;
using System.Text;

class MostFrequentNumber
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

        Console.Write("\nArray : ");
        PrintTheArray(array);

        //Find the most frequent number
        int mostElement = int.MinValue;
        int mostElementCount = int.MinValue;

        for (int i = 0; i < array.Length - 1; i++)
        {
            int currentElement = array[i];
            int currentElementCount = 1;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (currentElement == array[j])
                {
                    currentElementCount++;
                }
            }

            if (currentElementCount > mostElementCount)
            {
                mostElement = currentElement;
                mostElementCount = currentElementCount;
            }
        }

        Console.WriteLine("Most frequent number = {0} ({1} times)", mostElement, mostElementCount);
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

//Write a program that finds the most frequent number in an array. Example:
//    {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)