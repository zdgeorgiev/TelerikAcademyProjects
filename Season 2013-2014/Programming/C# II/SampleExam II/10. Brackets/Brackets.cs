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
                text.Append(allWords[j].Trim());
            }
        }

        int tabCount = 0;
        bool isTabAvaible = true;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].ToString() == "{")
            {
                isTabAvaible = true;

                Console.WriteLine();

                PrintTabs(tabSymbol, tabCount);

                Console.WriteLine("{");

                if (text[i + 1].ToString() != "}")
                {
                    tabCount++;
                }
            }
            else if (text[i].ToString() == "}")
            {
                isTabAvaible = true;

                Console.WriteLine();

                PrintTabs(tabSymbol, tabCount);

                Console.WriteLine("}");
                tabCount--;
            }
            else
            {
                if (isTabAvaible)
                {
                    PrintTabs(tabSymbol, tabCount);
                }

                isTabAvaible = false;

                Console.Write(text[i]);
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