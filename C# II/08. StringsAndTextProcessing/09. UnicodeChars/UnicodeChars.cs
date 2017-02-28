using System;

class UnicodeChars
{
    static void Main(string[] args)
    {
        string text = "Hi!";

        for (int i = 0; i < text.Length; i++)
        {
            Console.Write("\\u" + ((int)text[i]).ToString("X4"));
        }
        Console.WriteLine();
    }
}

//Write a program that converts a string to a sequence of
//C# Unicode character literals. Use format strings.