using System;

class ForbiddenWords
{
    static readonly string[] forbiddenWords = new string[] { "PHP", "CLR", "Microsoft" };

    static void Main(string[] args)
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] allSentances = text.Split(new char[] { '.'}, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < allSentances.Length; i++)
        {
            string[] allWords = allSentances[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            for (int currentWord = 0; currentWord < allWords.Length; currentWord++)
            {
                for (int currentForbiddenWord = 0; currentForbiddenWord < forbiddenWords.Length; currentForbiddenWord++)
                {
                    if (String.Compare(allWords[currentWord], forbiddenWords[currentForbiddenWord], true) == 0)
                    {
                        text = text.Replace(forbiddenWords[currentForbiddenWord],
                            new string('*', forbiddenWords[currentForbiddenWord].Length));
                    }
                }
            }
        }

        Console.WriteLine(text);
    }
}

//We are given a string containing a list of forbidden
//words and a text containing some of these words.
//Write a program that replaces the forbidden words
//with asterisks.