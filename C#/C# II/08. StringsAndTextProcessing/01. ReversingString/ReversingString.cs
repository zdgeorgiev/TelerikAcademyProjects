using System;
using System.Text;

class ReversingString
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < word.Length; i++)
        {
            result.Append(word[word.Length - 1 - i]);
        }

        Console.WriteLine(result.ToString());
    }
}

//Write a program that reads a string, reverses
//it and prints the result at the console.
//Example: "sample"  "elpmas".