using System;

class AllCardsFromDeck
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                Console.WriteLine((CardFace)i + " of " + (CardSuit)j);
            }
        }
    }
}

//Write a program that prints all possible cards from
//a standard deck of 52 cards (without jokers). The cards
//should be printed with their English names. Use nested for loops and switch-case.