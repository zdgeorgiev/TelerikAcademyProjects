using System;
using System.Text.RegularExpressions;

class AllEmailsFromText
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string pattern = @"([\w-\.]+)@((?:[\w]+\.)+)([a-zA-Z]{2,4})";

        MatchCollection emails = Regex.Matches(input, pattern);

        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }
    }
}
