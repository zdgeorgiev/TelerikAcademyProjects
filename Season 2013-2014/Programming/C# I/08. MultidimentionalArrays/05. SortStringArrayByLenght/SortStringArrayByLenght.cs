using System;
using System.Text;

class SortStringArrayByLenght
{
    static void Main(string[] args)
    {
        //Console.Write("Enter the lenght of the array : ");
        //int n = int.Parse(Console.ReadLine());
        //string[] array = new string[n];

        string[] array = new string[]
        {
            "aaaaa", "aaa", "aaaaaaaa", "aaaaaaaaaaaaa", "aaaa", "aa", "a"
        };

        Console.Write("Not Sorted -> \t");
        PrintTheArray(array);

        for (int i = 0; i < array.Length - 1; i++)
        {
            int lowestStringLenght = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[lowestStringLenght].Length > array[j].Length)
                {
                    lowestStringLenght = j;
                }
            }

            if (lowestStringLenght != i)
            {
                string tempValue = array[i];
                array[i] = array[lowestStringLenght];
                array[lowestStringLenght] = tempValue;
            }
        }

        Console.Write("Sorted -> \t");
        PrintTheArray(array);
    }

    static void PrintTheArray(string[] array)
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

//You are given an array of strings. Write a method that sorts the array by the
//length of its elements (the number of characters composing them).