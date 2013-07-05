using System;

class GenericMultiMethods
{
    //works with IComparable objects
    static T Minimum<T>(T[] array)
        where T : IComparable
    {
        T minValue = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i].CompareTo(minValue) < 0)
            {
                minValue = array[i];
            }
        }

        return minValue;
    }

    //works with IComparable objects
    static T Maximum<T>(T[] array)
        where T : IComparable
    {
        T maxValue = array[0];
    
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i].CompareTo(maxValue) > 0)
            {
                maxValue = array[i];
            }
        }
    
        return maxValue;
    }
    
    static T Average<T>(T[] array)
    {
        dynamic result = 0;
    
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];
        }
    
        return result / array.Length;
    }
    
    static T Sum<T>(T[] array)
    {
        dynamic sum = 0;
    
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
    
        return sum;
    }
    
    static T Product<T>(T[] array)
    {
        dynamic result = 1;
    
        for (int i = 0; i < array.Length; i++)
        {
            result *= array[i];
        }
    
        return result;
    }

    static void Main(string[] args)
    {
        int[] array = new int[] { 6, 2, 7, 2, 2, 7, 2, 8, -1, 6, 2 };
        double[] arrayDouble = new double[] { 2.5, 5.2, 6.1, 6.6, 8.1, 1.9 };

        Console.WriteLine("Minimum :         {0}", Minimum(array));
        Console.WriteLine("MinimumDouble :   {0}", Minimum(arrayDouble));
        Console.WriteLine("Maximum :         {0}", Maximum(array));
        Console.WriteLine("MaximumDouble :   {0}", Maximum(arrayDouble));
        Console.WriteLine("Average :         {0}", Average(array));
        Console.WriteLine("AverageDouble :   {0}", Average(arrayDouble));
        Console.WriteLine("Sum :             {0}", Sum(array));
        Console.WriteLine("SumDouble :       {0}", Sum(arrayDouble));
        Console.WriteLine("Product :         {0}", Product(array));
        Console.WriteLine("ProductDouble :   {0}", Product(arrayDouble));
    }
}

//* Modify your last program and try to make it work for any number type,
//not just integer (e.g. decimal, float, byte, etc.). 
//Use generic method (read in Internet about generic methods in C#).