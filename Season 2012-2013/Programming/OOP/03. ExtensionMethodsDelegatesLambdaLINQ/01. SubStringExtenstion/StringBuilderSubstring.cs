using System;
using System.Text;

public static class StringBuilderSubstring
{
    public static StringBuilder Substring(this StringBuilder text, int index, int length)
    {
        StringBuilder stringBuilder = new StringBuilder();

        if (index < 0)
        {
            throw new IndexOutOfRangeException("Index cannot be smaller than 0");
        }

        if (index + length >= text.Length)
        {
            throw new IndexOutOfRangeException("Index out of range");
        }

        for (int j = index; j < index + length; j++)
        {
            stringBuilder.Append(text[j]);
        }

        return stringBuilder;
    }
}

//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder
//    and has the same functionality as Substring in the class String.
