using System;
using System.Text;

class CharArrays
{
    static void Main(string[] args)
    {
        string[] allLetters = new string[]
        { 
          "a", "b", "c", "d", "e", "f", "g",
          "h", "i", "j", "k", "l", "m", "n",
          "o", "p", "q", "r", "s", "t",	"u",
          "v", "w", "x", "y", "z"
        };

        Console.Write("Enter any word : ");
        //Will use to lower to escape problems with casing
        string word = Console.ReadLine().ToLower();

        StringBuilder allLettersAsString = new StringBuilder();

        foreach (string letter in allLetters)
        {
            allLettersAsString.Append(letter);
        }

        StringBuilder lettersAsNumbers = new StringBuilder();

        for (int i = 0; i < word.Length; i++)
        {
            char currentLetter = word[i];

            lettersAsNumbers.Append(allLettersAsString.ToString().IndexOf(currentLetter));
        }

        Console.WriteLine("Indexes letter by letter : {0}", lettersAsNumbers.ToString());
    }
}

//Write a program that creates an array containing all letters from the alphabet 
//(A-Z). Read a word from the console and print the index of each of its letters in the array.