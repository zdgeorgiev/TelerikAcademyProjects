using System;
using System.Text;

class ReversedSentance
{
    static void Main()
    {
        //string input = Console.ReadLine();
        string input = "C# is not C++, not PHP and not Delphi!";
        char[] puncts = new char[]{' ', '.', '?', '!', ';', ',',':' };
        string[] words = input.Split(puncts, StringSplitOptions.RemoveEmptyEntries);
        string[] revWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            revWords[i] = words[words.Length - i - 1];
        }

        foreach (var item in revWords)
        {
            Console.Write(item + " ");
        }
    }
}

//Write a program that reverses the words in given sentence.
//	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
