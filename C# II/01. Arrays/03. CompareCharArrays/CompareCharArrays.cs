using System;

class CompareCharArrays
{
    static void Main(string[] args)
    {
        Console.Write("Enter the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());

        char[] firstArray = new char[n];
        char[] secondArray = new char[n];

        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("firstArray[{0}] = ", i);
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        for (int j = 0; j < firstArray.Length; j++)
        {
            Console.Write("secondArray[{0}] = ", j);
            secondArray[j] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Are the arrays equal - {0}", CompareTheArrays(firstArray, secondArray));
    }

    static bool CompareTheArrays(char[] firstArray, char[] secondArray)
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