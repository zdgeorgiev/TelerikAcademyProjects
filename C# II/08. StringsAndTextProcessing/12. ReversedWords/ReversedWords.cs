using System;

class ReversedWords
{
    static void Main(string[] args)
    {
        string text = "C# is not C++, not PHP and not Delphi!";

        string[] words = text.Split(new char[] { ',', ' ', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        foreach (var word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}

//Write a program that reverses the words in given sentence.
//    Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".