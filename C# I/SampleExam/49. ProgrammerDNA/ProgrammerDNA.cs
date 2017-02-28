using System;

class ProgrammerDNA
{
    static void Main(string[] args)
    {
        int numberOfRows = int.Parse(Console.ReadLine());

        string nextLetter = Console.ReadLine();
        int nextChar = char.Parse(nextLetter);

        int currentRow = 1;

        int leftDots = 3;
        int numberOfLetters = 1;

        bool decreasingDots = true;
        bool decreasingLetters = false;

        int nextLetterCount = 0;
        int nextCharIndex = 0;

        while (currentRow <= numberOfRows)
        {
            if ((currentRow - 1) % 7 == 0)
            {
                leftDots = 3;
                numberOfLetters = 1;
            }

            Console.Write(new string('.', leftDots));

            for (int i = 0; i < numberOfLetters; i++)
            {
                if (nextCharIndex + nextChar == 72)
                {
                    nextChar = 65;
                    nextCharIndex = 0;
                }

                Console.Write((char)(nextCharIndex + nextChar));
                nextLetterCount++;
                nextCharIndex++;
            }

            Console.Write(new string('.', leftDots));

            if (leftDots <= 3 && leftDots > 0 && decreasingDots)
            {
                leftDots--;
            }
            else
            {
                decreasingDots = false;
                leftDots++;

                if (leftDots == 3)
                {
                    decreasingDots = true;
                }
            }

            if (numberOfLetters <= 5 && numberOfLetters >= 1 && !decreasingLetters)
            {
                numberOfLetters += 2;
            }
            else
            {
                decreasingLetters = true;
                numberOfLetters -= 2;

                if (numberOfLetters == 1)
                {
                    decreasingLetters = false;
                }
            }

            currentRow++;
            Console.WriteLine();
        }
    }
}