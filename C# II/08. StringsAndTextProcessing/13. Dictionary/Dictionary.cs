using System;

class Dictionary
{
    static void Main(string[] args)
    {
        ExplanationLibrary library = new ExplanationLibrary();

        string[] allWords = new string[] { ".NET", "CLR", "namespace" };

        foreach (var word in allWords)
        {
            Console.WriteLine("{0} - {1}", word, library.dictionary[word]);
        }
    }
}

//A dictionary is stored as a sequence of text lines 
//containing words and their explanations. Write a program 
//that enters a word and translates it by using the dictionary.