using System;

class BinSearch
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("Enter element - [{0}] from the array: ", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(myArray);

        if (myArray[0] > k)
        {
            Console.Write("Theres no number lower or equal to k");
        }
        else
        {
            int index = Array.BinarySearch(myArray, k);
            if (index == k)
            {
                Console.WriteLine(myArray[index]);
            }
            if (index < 0)
            {
                Console.WriteLine(myArray[~index - 1]);
            }
            else if (index == 0)
            {
                Console.WriteLine(myArray[index]);
            }
            else
            {
                Console.WriteLine(myArray[index - 1]);
            }
        }
    }
}


//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
