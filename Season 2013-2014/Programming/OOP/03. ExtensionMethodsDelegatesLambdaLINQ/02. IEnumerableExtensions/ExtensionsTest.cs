using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

class ExtensionsTest
{
    static void Main(string[] args)
    {
        IEnumerable<int> numbers = new Collection<int>();

        var numbersAsCollection = numbers as Collection<int>;

        for (int i = 0; i < 50; i++)
        {
            numbersAsCollection.Add(550);
        }

        Console.WriteLine(numbersAsCollection.Sum());
    }
}