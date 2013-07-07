using System;
using System.Text;

class MaxSumOfKElements
{
    static void Main(string[] args)
    {
        Console.Write("Enter the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("\nK = ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        int maxSum = 0;

        StringBuilder result = new StringBuilder();

        result.Append("{ ");
        for (int j = 0; j < k; j++)
        {
            int currentNumber = array[array.Length - 1 - j];
            maxSum += currentNumber;
            result.Append(currentNumber + " + ");
        }
        result.Length -= 3;
        result.Append(" } = " + maxSum);

        Console.WriteLine("\nMax sum of K elements : {0}", result.ToString());
    }
}

//Write a program that reads two integer numbers N and K
//and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.