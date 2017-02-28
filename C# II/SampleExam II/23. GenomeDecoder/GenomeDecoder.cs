using System;
using System.Text;

class GenomeDecoder
{
    static void Main(string[] args)
    {
        string[] rawNumbers = Console.ReadLine().Split();

        int lettersPerRow = int.Parse(rawNumbers[0]);
        int spacesAfterLetters = int.Parse(rawNumbers[1]);

        string genome = Console.ReadLine();

        StringBuilder encoded = new StringBuilder();

        for (int i = 0; i < genome.Length - 1; i++)
        {
            char currentLetter = genome[i];

            string letterIndex = string.Empty;

            while (char.IsDigit(currentLetter))
            {
                letterIndex += currentLetter;

                i++;

                currentLetter = genome[i];
            }

            char nextChar = genome[i];

            if (letterIndex == "")
            {
                letterIndex = "1";
            }
            encoded.Append(new string(nextChar, int.Parse(letterIndex)));

            if (i + 1 < genome.Length && !char.IsDigit(genome[i + 1]))
            {
                encoded.Append(genome[i + 1]);
                i++;
            }
        }

        StringBuilder result = ProcessTheEncode(lettersPerRow, spacesAfterLetters, encoded);

        result.Length--;

        Console.WriteLine(result.ToString());
    }

    private static StringBuilder ProcessTheEncode(int lettersPerRow, int spacesAfterLetters, StringBuilder encoded)
    {
        StringBuilder result = new StringBuilder();

        bool hasSpace = false;

        double allRows = (double)encoded.Length / (double)lettersPerRow;

        if (allRows > 9.0)
        {
            hasSpace = true;
        }

        int currentLetterFromEncode = 0;
        int currentRow = 1;

        while (true)
        {
            int counterPerWord = 0;

            if (currentLetterFromEncode > encoded.Length)
            {
                break;
            }

            int rows = int.Parse(allRows.ToString()[0] + new string('0', ((int)allRows).ToString().Length - 1));

            if (currentRow < rows && hasSpace)
            {
                result.Append(new string(' ', rows.ToString().Length - currentRow.ToString().Length));
            }

            result.Append(currentRow + " ");

            for (int i = 0; i < lettersPerRow; i++)
            {
                result.Append(encoded[currentLetterFromEncode]);
                currentLetterFromEncode++;
                counterPerWord++;

                if (currentLetterFromEncode == encoded.Length)
                {
                    result.Append(encoded[currentLetterFromEncode - 1]);
                    return result;
                }

                if (counterPerWord == spacesAfterLetters && currentLetterFromEncode % lettersPerRow != 0)
                {
                    result.Append(" ");
                    counterPerWord = 0;
                }
            }

            result.AppendLine();

            currentRow++;
        }

        return result;
    }
}