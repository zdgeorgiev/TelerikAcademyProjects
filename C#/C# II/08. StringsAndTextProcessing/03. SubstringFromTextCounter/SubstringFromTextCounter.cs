using System;

class SubstringFromTextCounter
{
    static void Main(string[] args)
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string searchedWord = "in";
        int searchedWordCounter = 0;

        //Until find atleast the first letter of the searched string
        for (int i = 0; i < text.Length - (searchedWord.Length - 1); i++)
        {
            if (string.Compare(text.Substring(i, searchedWord.Length), searchedWord, true) == 0)
            {
                searchedWordCounter++;
                //Skip the searched words letters
                i += searchedWord.Length;
            }
        }

        //int index = -1;

        //index = text.IndexOf("in", index + 1);

        //while (index != -1)
        //{
        //    searchedWordCounter++;
        //    index = text.IndexOf("in", index + 1, StringComparison.OrdinalIgnoreCase);
        //}

        Console.WriteLine(searchedWordCounter);
    }
}

//Write a program that finds how many times a substring
//is contained in a given text (perform case insensitive search).