using System;
using System.Text;

class Brackets
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string tabSymbol = Console.ReadLine();

        StringBuilder text = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            string[] allWords =
                Console.ReadLine().Split(new char[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);


            for (int j = 0; j < allWords.Length; j++)
            {
                bool hasSpace = false;

                for (int k = 0; k < allWords[j].Length; k++)
                {
                    if (!hasSpace || allWords[j][k] != ' ')
                    {
                        text.Append(allWords[j][k]);
                        hasSpace = false;
                    }

                    if (allWords[j][k] == ' ')
                    {
                        hasSpace = true;
                    }
                }

                text.AppendLine();
            }
        }

        text.Length--;

        int tabCount = 0;

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];

            if (currentChar == '{')
            {
                PrintTabs(tabSymbol, tabCount);
                Console.WriteLine("{");
                tabCount++;
            }
            else if (currentChar == '}')
            {
                PrintTabs(tabSymbol, tabCount);
                Console.WriteLine("}");
            }
            else if (currentChar != '\r' && currentChar != '\n' && currentChar != ' ')
            {
                PrintTabs(tabSymbol, tabCount);

                while (i + 1 < text.Length && currentChar != '{' && currentChar != '}' &&
                       currentChar != '\r' && currentChar != '\n')
                {
                    Console.Write(currentChar);
                    i++;
                    currentChar = text[i];
                }
                i--;
                Console.WriteLine();
            }

            for (int j = i + 1; j < text.Length; j++)
            {
                if (text[j] == ' ')
                {
                    continue;
                }
                else if (text[j] == '}')
                {
                    tabCount--;
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }

    static void PrintTabs(string symbol, int numbersOfTabs)
    {
        string finalString = string.Empty;

        for (int i = 0; i < numbersOfTabs; i++)
        {
            finalString += symbol;
        }

        Console.Write(finalString);
    }
}