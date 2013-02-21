//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class Program
{
    static void Main()
    {
        int minNumb = 0;
        int n = int.Parse(Console.ReadLine());
        int[] myArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter value for myArr[{0}] = ", i);
            myArr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            minNumb = i;

            for (int j = i + 1; j < n; j++)
            {
                if (myArr[minNumb] > myArr[j])
                {
                    minNumb = j;
                }
            }

            if (minNumb != i)
            {
                int temp = 0;
                temp = myArr[i];
                myArr[i] = myArr[minNumb];
                myArr[minNumb] = temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}, ", myArr[i]);
        }
        Console.WriteLine();
    }
}


