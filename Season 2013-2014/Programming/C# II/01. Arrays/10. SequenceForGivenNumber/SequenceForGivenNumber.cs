using System;
using System.Text;

class SequenceForGivenNumber
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

        Console.Write("\nEnter S : ");
        int s = int.Parse(Console.ReadLine());

        Console.Write("\nArray : ");
        PrintTheArray(array);


        Console.WriteLine(FindSequenceForS(array, s));
    }

    static string FindSequenceForS(int[] array, int s)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int currentSum = array[i];
            StringBuilder includedNumbers = new StringBuilder();
            includedNumbers.Append("{ " + array[i] + ", ");

            for (int j = i + 1; j < array.Length; j++)
            {
                currentSum += array[j];
                includedNumbers.Append(array[j] + ", ");

                if (currentSum == s)
                {
                    includedNumbers.Length -= 2;
                    includedNumbers.Append(" }");
                    Console.Write("Sequence for S = ");
                    return includedNumbers.ToString();
                }
            }
        }

        return string.Format("Sorry theres no sequence with sum of {0}", s);
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

//Write a program that finds in given array of integers a
//sequence of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}