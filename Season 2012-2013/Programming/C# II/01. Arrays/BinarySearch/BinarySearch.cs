using System;

class BinarySearch
{
    static int BinSearch(int[] array, int key)
    {
        Array.Sort(array);
        int iMax = array.Length - 1;
        int iMin = 0;

        while (iMax >= iMin)
        {
            int MidPoint = (iMax + iMin) / 2;

            if (array[MidPoint] > key)
            {
                iMax = MidPoint - 1;
            }
            else if (array[MidPoint] < key)
            {
                iMin = MidPoint + 1;
            }
            else
            {
                return MidPoint;
            }
        }
        return -1;
    }

    static void Main()
    {
        //int n = int.Parse(Console.ReadLine());
        //int[] myArray = new int[n];
        //
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Enter value for myArray[{0}] = ", i);
        //    myArr[i] = int.Parse(Console.ReadLine());
        //}
        //int key = int.Parse(Console.ReadLine());


        int[] myArray = { 25, 15, 13, 58, 47, 665 };
        int key = 15;
        Console.WriteLine(BinSearch(myArray, key));
    }
}

//Write a program that finds the index of given element in a sorted array of integers
//by using the binary search algorithm (find it in Wikipedia).
