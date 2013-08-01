using System;

class CardWars
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int firstPlayerTotalPoints = 0;
        int secondPlayerTotalPoints = 0;
        int firsPlayerGamesCounter = 0;
        int secondPlayerGamesCounter = 0;
        bool isFirstPlayerHasX = false;
        bool isSecondPlayerHasX = false;
        int firstPlayerFifty = 0;
        int secondPlayerFifty = 0;

        for (int i = 0; i < n; i++)
        {
            int firstPlayerCurrentPoints = 0;
            int secondPlayerCurrentPoints = 0;

            for (int j = 0; j < 3; j++)
            {
                string cardInput = Console.ReadLine();

                if (cardInput == "Z")
                {
                    firstPlayerCurrentPoints *= 2;
                }
                else if (cardInput == "Y")
                {
                    if (firstPlayerCurrentPoints - 200 < 0)
                    {
                        firstPlayerCurrentPoints = 0;
                    }
                    else
                    {
                        firstPlayerCurrentPoints -= 200;
                    }
                }
                else if (cardInput == "X")
                {
                    isFirstPlayerHasX = true;
                    firstPlayerFifty++;
                }
                else
                {
                    firstPlayerCurrentPoints += GetStrenght(cardInput);
                }
            }

            for (int z = 0; z < 3; z++)
            {
                string cardInput = Console.ReadLine();

                if (cardInput == "Z")
                {
                    secondPlayerCurrentPoints *= 2;
                }
                else if (cardInput == "Y")
                {
                    if (secondPlayerCurrentPoints - 200 < 0)
                    {
                        secondPlayerCurrentPoints = 0;
                    }
                    else
                    {
                        secondPlayerCurrentPoints -= 200;
                    }
                }
                else if (cardInput == "X")
                {
                    isSecondPlayerHasX = true;
                    secondPlayerFifty++;
                }
                else
                {
                    secondPlayerCurrentPoints += GetStrenght(cardInput);
                }
            }

            //if (isFirstPlayerHasX && isSecondPlayerHasX)
            //{
            //    firstPlayerTotalPoints += 50;
            //    secondPlayerTotalPoints += 50;
            //}
            //else
            //{
                if (firstPlayerCurrentPoints > secondPlayerCurrentPoints)
                {
                    firstPlayerTotalPoints += firstPlayerCurrentPoints;
                    firsPlayerGamesCounter++;
                }
                else if (firstPlayerCurrentPoints < secondPlayerCurrentPoints)
                {
                    secondPlayerTotalPoints += secondPlayerCurrentPoints;
                    secondPlayerGamesCounter++;
                }
            //}
        }

        if (isFirstPlayerHasX && isSecondPlayerHasX)
        {
            firstPlayerTotalPoints = firstPlayerTotalPoints + (firstPlayerFifty * 50);
            secondPlayerTotalPoints = secondPlayerTotalPoints + (secondPlayerFifty * 50);
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", (firstPlayerTotalPoints + secondPlayerTotalPoints) / 2);
        }
        else if (isFirstPlayerHasX)
        {
            firstPlayerTotalPoints = firstPlayerTotalPoints + (firstPlayerFifty * 50);
            Console.WriteLine("X card drawn! Player one wins the match!");
        }
        else if (isSecondPlayerHasX)
        {
            secondPlayerTotalPoints = secondPlayerTotalPoints + (secondPlayerFifty * 50);
            Console.WriteLine("X card drawn! Player two wins the match!");
        }
        else if (firstPlayerTotalPoints > secondPlayerTotalPoints)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", firstPlayerTotalPoints);
            Console.WriteLine("Games won: {0}", firsPlayerGamesCounter);
        }
        else if (firstPlayerTotalPoints < secondPlayerTotalPoints)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", secondPlayerTotalPoints);
            Console.WriteLine("Games won: {0}", secondPlayerGamesCounter);
        }
        else
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", (firstPlayerTotalPoints + secondPlayerTotalPoints) / 2);
        }
    }

    static int GetStrenght(string card)
    {
        int cardStrenght = 0;

        switch (card)
        {
            case "2": cardStrenght += 10; break;
            case "3": cardStrenght += 9; break;
            case "4": cardStrenght += 8; break;
            case "5": cardStrenght += 7; break;
            case "6": cardStrenght += 6; break;
            case "7": cardStrenght += 5; break;
            case "8": cardStrenght += 4; break;
            case "9": cardStrenght += 3; break;
            case "10": cardStrenght += 2; break;
            case "A": cardStrenght += 1; break;
            case "J": cardStrenght += 11; break;
            case "Q": cardStrenght += 12; break;
            case "K": cardStrenght += 13; break;
            default:
                break;
        }

        return cardStrenght;
    }
}