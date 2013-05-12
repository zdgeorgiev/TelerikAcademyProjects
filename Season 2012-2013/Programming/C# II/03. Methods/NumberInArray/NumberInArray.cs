using System;

class NumberInArray
{
    static int NumbInArray(int[] array, int n)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == n)
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main()
    {
        int[] myArr = new int[] { 1, 2, 7, 1, 9, 2, 9, 1, 7, 1, 9, 7, 2, 1, 1, 77, 1 };

        foreach (var numb in myArr)
        {
            Console.Write(numb + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Enter number!");
        Console.Write("number= ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Number {0} appears {1} times in the array!", number, NumbInArray(myArr, number));
    }
}


//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.
