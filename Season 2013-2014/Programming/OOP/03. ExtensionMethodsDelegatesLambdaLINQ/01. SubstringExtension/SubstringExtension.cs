using System;
using System.Text;

public static class Extensions
{
    public static string Substring(this StringBuilder text, int start, int length)
    {
        StringBuilder substring = new StringBuilder();

        if (start < 0)
        {
            throw new IndexOutOfRangeException("Start index cannot be negative number.");
        }

        if (text.Length <= start + length || length <= 0)
        {
            throw new IndexOutOfRangeException("Invalid length.");
        }

        for (int i = 0; i < length; i++)
        {
            substring.Append(text[start + i]);
        }

        return substring.ToString();
    }
}

//Implement an extension method Substring(int index, int length) for the class 
//StringBuilder that returns new StringBuilder and has the same 
//functionality as Substring in the class String.