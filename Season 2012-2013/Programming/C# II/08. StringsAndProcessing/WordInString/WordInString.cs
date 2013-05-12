using System;
using System.Text;

class WordInString
{
    static void Main()
    {
        string text = "We are living in a yellow submarine.We don't have anything else.Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 days.";
        string word = Console.ReadLine(); //in
        int startIndex = 0;
        int endIndex = 0;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < text.Length - word.Length - 2; i++)
        {
            if (text.Substring(i, word.Length + 2).ToLower() == " " + word + " "      // (space)word(space) or
                || text.Substring(i, word.Length + 2).ToLower() == " " + word + "."   // (space)word(.)
                || text.Substring(i, word.Length + 1).ToLower() == word + " ")       // Word(space) anyway its not a word!
            {
                i += word.Length;
                for (int j = i; j < text.Length; j++)
                {
                    if (text.Substring(j, 1) == ".")
                    {
                        endIndex = j + 1;
                        string sentance = text.Substring(startIndex, endIndex - startIndex).ToString();
                        sb.Append(sentance);
                        startIndex = endIndex;
                        i = j;
                        break;
                    }
                }
            }
            else if (text.Substring(i, 1) == ".")
            {
                startIndex = i + 1;
            }
        }
        Console.WriteLine(sb);
    }
}

//Write a program that extracts from a given text all sentences containing given word.
//              Example: The word is "in". The text is:
//We are living in a yellow submarine. We don't have anything else.
//Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//Result:
//We are living in a yellow submarine.
//We will move out of it in 5 days.