using System;

class MultiMethodsForArray
{
    static int Minimum(int[] array)
    {
        int minNumber = int.MaxValue;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < minNumber)
            {
                minNumber = array[i];
            }
        }

        return minNumber;
    }

    static int Maximum(int[] array)
    {
        int maxNumber = int.MinValue;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > maxNumber)
            {
                maxNumber = array[i];
            }
        }

        return maxNumber;
    }

    static double Average(int[] array)
    {
        double result = 0;

        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];
        }

        return result / array.Length;
    }

    static int Sum(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    static int Product(int[] array)
    {
        int result = 1;

        for (int i = 0; i < array.Length; i++)
        {
            result *= array[i];
        }

        return result;
    }

    static void Main(string[] args)
    {
        int[] array = new int[] { 6, 2, 7, 2, 2, 7, 2, 8, -1, 6, 2 };

        Console.WriteLine("Minimum : \t{0}" ,Minimum(array));
        Console.WriteLine("Maximum : \t{0}" ,Maximum(array));
        Console.WriteLine("Average : \t{0}" ,Average(array));
        Console.WriteLine("Sum :     \t{0}" ,Sum(array));
        Console.WriteLine("Product : \t{0}" ,Product(array));
    }
}

//Write methods to calculate minimum, maximum, average, 
//sum and product of given set of integer numbers. Use variable number of arguments.