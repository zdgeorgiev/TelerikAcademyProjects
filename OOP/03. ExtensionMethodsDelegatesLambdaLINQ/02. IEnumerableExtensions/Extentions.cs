using System;
using System.Collections.Generic;

public static class Extentions
{
    public static T Sum<T>(this IEnumerable<T> enumerable)
        where T : IComparable
    {
        dynamic sum = 0;

        foreach (var element in enumerable)
        {
            sum += element;
        }

        return sum;
    }

    public static T Product<T>(this IEnumerable<T> enumerable)
        where T : IComparable
    {
        dynamic sum = 1;

        foreach (var element in enumerable)
        {
            sum *= element;
        }

        return sum;
    }

    public static T Min<T>(this IEnumerable<T> enumerable)
        where T : IComparable
    {
        dynamic min = int.MaxValue;

        foreach (var element in enumerable)
        {
            if (element < min)
            {
                min = element;
            }
        }

        return min;
    }

    public static T Max<T>(this IEnumerable<T> enumerable)
        where T : IComparable
    {
        dynamic max = int.MinValue;

        foreach (var element in enumerable)
        {
            if (element > max)
            {
                max = element;
            }
        }

        return max;
    }

    public static T Average<T>(this IEnumerable<T> enumerable)
        where T : IComparable
    {
        dynamic average = 0;
        decimal counter = 0;

        foreach (var element in enumerable)
        {
            average += element;
            counter++;
        }

        return average / counter;
    }
}

//Implement a set of extension methods for IEnumerable<T> that implement
//the following group functions: sum, product, min, max, average.