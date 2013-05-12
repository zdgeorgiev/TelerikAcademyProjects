using System;

class UpperCaseSubstring
{
    static void Main()
    {
        string text = @"We are living in a <upcase>yellow submarine</upcase>.We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(text);
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < text.Length - 9; i++)
        {
            if (text.Substring(i, 8) == "<upcase>")
            {
                i += 8;
                startIndex = i;
            }
            else if (text.Substring(i, 9) == "</upcase>") 
            {
                endIndex = i;

                string upperSubstring = text.Substring(startIndex, endIndex - startIndex).ToUpper();
                text = text.Replace(text.Substring(startIndex, endIndex - startIndex), upperSubstring);
                text = text.Remove(startIndex - 8, 8); //<upcase>I минус 8 и 8 напред за да изтрие пърия.
                text = text.Remove(endIndex - 8, 9);   //I</upcase> минус 8, защото като изтрихме пърия стринга е с 8 по малко
                                                       //и трябва да го върнем 8 назад и после 9 напред.
            }
        }

        Console.WriteLine(text);
    }
}

//We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.