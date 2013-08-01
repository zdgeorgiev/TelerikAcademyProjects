using System;

class Anacii
{
    static void Main(string[] args)
    {
        string firstLetter = Console.ReadLine();
        string secondLetter = Console.ReadLine();

        int firstLetterNumber = GetNumberOfLetter(firstLetter);
        int secondLetterNumber = GetNumberOfLetter(secondLetter);

        int lines = int.Parse(Console.ReadLine());

        int whiteSpaces = 0;
        int elementsCounter = 3;
        int[] allLetters = new int[lines * 2];

        allLetters[0] = firstLetterNumber;
        allLetters[1] = secondLetterNumber;

        for (int i = 2; i < allLetters.Length; i++)
        {
            int thirdLetterNumber = firstLetterNumber + secondLetterNumber;
            
            if (thirdLetterNumber > 26)
            {
                thirdLetterNumber %= 26;
            }

            firstLetterNumber = secondLetterNumber;
            secondLetterNumber = thirdLetterNumber;

            allLetters[i] = thirdLetterNumber;
        }

        if (lines == 1)
        {
            Console.WriteLine(firstLetter);
        }
        else
        {
            Console.WriteLine(firstLetter);
            Console.Write(secondLetter);

            for (int row = 2; row < lines + 1; row++)
            {
                whiteSpaces = row - 2;
            
                if (row == 2)
                {
                    Console.Write(new string(' ', whiteSpaces));
                    Console.Write(new string(GetLetterFromNumber(allLetters[2]), 1));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string(GetLetterFromNumber(allLetters[elementsCounter]), 1));
                    elementsCounter++;
                    Console.Write(new string(' ', whiteSpaces));
                    Console.Write(new string(GetLetterFromNumber(allLetters[elementsCounter]), 1));
                    elementsCounter++;
                    Console.WriteLine();
                }
            
        }
        }
    }

    static int GetNumberOfLetter(string letter)
    {
        int number = 0;
        switch (letter)
        {
            case "A": number = 1; break;
            case "B": number = 2; break;
            case "C": number = 3; break;
            case "D": number = 4; break;
            case "E": number = 5; break;
            case "F": number = 6; break;
            case "G": number = 7; break;
            case "H": number = 8; break;
            case "I": number = 9; break;
            case "J": number = 10; break;
            case "K": number = 11; break;
            case "L": number = 12; break;
            case "M": number = 13; break;
            case "N": number = 14; break;
            case "O": number = 15; break;
            case "P": number = 16; break;
            case "Q": number = 17; break;
            case "R": number = 18; break;
            case "S": number = 29; break;
            case "T": number = 20; break;
            case "U": number = 21; break;
            case "V": number = 22; break;
            case "W": number = 23; break;
            case "X": number = 24; break;
            case "Y": number = 25; break;
            case "Z": number = 26; break;
            default:
                throw new ArgumentException("Invalid letter!");
        }

        return number;
    }

    static char GetLetterFromNumber(int letterNumber)
    {
        char letter = '0';

        switch (letterNumber)
        {
            case 1:  letter = 'A'; break;
            case 2:  letter = 'B'; break;
            case 3:  letter = 'C'; break;
            case 4:  letter = 'D'; break;
            case 5:  letter = 'E'; break;
            case 6:  letter = 'F'; break;
            case 7:  letter = 'G'; break;
            case 8:  letter = 'H'; break;
            case 9:  letter = 'I'; break;
            case 10: letter = 'J';  break;
            case 11: letter = 'K';  break;
            case 12: letter = 'L';  break;
            case 13: letter = 'M';  break;
            case 14: letter = 'N';  break;
            case 15: letter = 'O';  break;
            case 16: letter = 'P';  break;
            case 17: letter = 'Q';  break;
            case 18: letter = 'R';  break;
            case 19: letter = 'S';  break;
            case 20: letter = 'T';  break;
            case 21: letter = 'U';  break;
            case 22: letter = 'V';  break;
            case 23: letter = 'W';  break;
            case 24: letter = 'X';  break;
            case 25: letter = 'Y';  break;
            case 26: letter = 'Z'; break;
            default:
                throw new ArgumentException("Invalid letter!");
        }

        return letter;
    }
}