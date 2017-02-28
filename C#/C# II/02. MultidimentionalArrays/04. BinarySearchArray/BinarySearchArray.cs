using System;

class BinarySearchArray
{
    static void Main(string[] args)
    {
        Console.Write("Enter the lenght of the array : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            int currentNumber = int.Parse(Console.ReadLine());

            array[i] = currentNumber;
        }

        Array.Sort(array);

        int searchedNumber = Array.BinarySearch(array, k);

        if (searchedNumber < -1)
        {
            Console.WriteLine("Largest number lower than or equal to {0} is {1}", k, array[~searchedNumber - 1]);
        }
        else if (~searchedNumber == 0)
        {
            Console.WriteLine("No such number");
        }
        else
        {
            Console.WriteLine("Largest number lower than or equal to {0} is {1}", k, array[searchedNumber]);
        }
    }
}

//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 