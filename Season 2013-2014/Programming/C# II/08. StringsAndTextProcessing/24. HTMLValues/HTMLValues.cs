using System;
using System.IO;
using System.Text.RegularExpressions;

class HTMLValues
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("../../html.txt");

        string pattern = @"(?<=^|>)[^><]+?(?=<|$)";

        using (reader)
        {
            MatchCollection values = Regex.Matches(reader.ReadToEnd(), pattern);

            foreach (var value in values)
            {
                if (!String.IsNullOrWhiteSpace(value.ToString()))
                {
                    Console.WriteLine(value); 
                }
            }
        }
    }
}

//Write a program that extracts from given HTML
//file its title (if available), and its body text without the HTML tags.