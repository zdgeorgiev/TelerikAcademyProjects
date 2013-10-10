using System;
using System.Text;

class StringBuilderSubstringTest
{
    static void Main()
    {
        StringBuilder text = new StringBuilder();
        text.AppendLine("Yeah aha you know what it is.");
        var substring = text.Substring(5, 25);
        Console.WriteLine(substring);
    }
}