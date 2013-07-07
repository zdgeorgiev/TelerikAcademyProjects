using System;

class CompareArrays
{
    static void Main(string[] args)
    {
        Console.Write("Enter the lenght of the first array: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the lenght of the second array: ");
        int k = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        int[] secondArray = new int[k];

        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("firstArray[{0}] = ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < secondArray.Length; j++)
        {
            Console.Write("secondArray[{0}] = ", j);
            secondArray[j] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Are the arrays equal - {0}", CompareTheArrays(firstArray, secondArray));
    }

    static bool CompareTheArrays(int[] firstArray, int[] secondArray)
    {
        if (firstArray.Length != secondArray.Length)
        {
            return false;
        }

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                return false;
            }   
        }

        return true;
    }
}

//Write a program that reads two arrays from the console and compares them element by element.