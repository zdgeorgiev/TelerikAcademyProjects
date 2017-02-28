using System;
using System.Text;

public class MaxSequence
{
    public static void Main()
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

        int currentSum = 0;
        int bestSum = 0;
        StringBuilder bestSequenceBuild = new StringBuilder();
        string bestSequence = string.Empty;

        for (int i = 0; i < array.Length; i++)
        {
            currentSum += array[i];
            bestSequenceBuild.AppendFormat("{0}, ", array[i]);

            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestSequence = bestSequenceBuild.ToString();
            }

            if (currentSum < 0)
            {
                currentSum = 0;
                bestSequenceBuild.Clear();
            }
        }

        Console.WriteLine("The best sequence is: \" {0} \"", bestSequence);
        Console.WriteLine("The best sum is: {0} ", bestSum);
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

//Write a program that finds the sequence of maximal sum in given array. Example:
//    {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//    Can you do it with only one loop (with single scan through the elements of the array)?