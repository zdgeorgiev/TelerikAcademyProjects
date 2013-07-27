using System;
using System.Collections.Generic;

class SortedList
{
    static void Main(string[] args)
    {
        string[] allWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(allWords);
        Console.WriteLine("\nSorted words :");

        foreach (var word in allWords)
        {
            Console.WriteLine(word);
        }
    }
}

//Write a program that reads a list of words,
//separated by spaces and prints the list in an alphabetical order.