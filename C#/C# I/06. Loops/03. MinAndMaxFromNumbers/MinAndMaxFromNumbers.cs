using System;

class MinAndMaxFromNumbers
{
    static void Main(string[] args)
    {
        Console.Write("How much numbers you wanna enter - ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(myArray);

        Console.WriteLine("Min number is {0}", myArray[0]);
        Console.WriteLine("Max number is {0}", myArray[myArray.Length - 1]);
    }
}

//Write a program that reads from the console a sequence of
//N integer numbers and returns the minimal and maximal of them.