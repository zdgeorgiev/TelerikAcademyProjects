using System;

class TwoNeighbors
{
    static bool BiggerThanTwoNeighbors(int[] array, int n)
    {
        bool check = false;

        if (n > array[0] && n < array.Length - 1)
        {
            if (array[n] > array[n + 1] && array[n] > array[n - 1])
            {
                check = true;
                return check;
            }
            else
            {
                check = true;
            }
        }
        else
        {
            Console.WriteLine("Doest exist two neighbors for that number!");
        }
        return check;
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

        Console.WriteLine("Is the number greater than his neighbors - {0}", BiggerThanTwoNeighbors(myArr, number));
    }
}


//Write a method that checks if the element at given position in given array
//of integers is bigger than its two neighbors (when such exist).
