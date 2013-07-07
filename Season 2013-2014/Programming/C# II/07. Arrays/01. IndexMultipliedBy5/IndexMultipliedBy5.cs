using System;
using System.Text;

class IndexMultipliedBy5
{
    static void Main(string[] args)
    {
        int[] array = new int[20];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
        }

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

        Console.WriteLine("Array - {0}", result.ToString());
    }
}

//Write a program that allocates array of 20 integers
//and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.