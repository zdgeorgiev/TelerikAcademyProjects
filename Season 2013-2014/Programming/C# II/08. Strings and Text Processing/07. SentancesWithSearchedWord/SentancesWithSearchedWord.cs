using System;
using System.Text;

class SentancesWithSearchedWord
{
    static void Main(string[] args)
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string[] allSentances = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < allSentances.Length; i++)
        {
            string[] allWords = allSentances[i].Split(' ');

            for (int j = 0; j < allWords.Length; j++)
            {
                if (allWords[j] == "in")
                {
                    result.AppendLine(allSentances[i].Trim() + ".");
                }
            }
        }

        Console.WriteLine(result);
    }
}