using System;
using System.Linq;

class Poker
{
    static void Main(string[] args)
    {
        int[] myHand = new int[]
        {
            GetNumber(Console.ReadLine()),
            GetNumber(Console.ReadLine()),
            GetNumber(Console.ReadLine()),
            GetNumber(Console.ReadLine()),
            GetNumber(Console.ReadLine())
        };

        Array.Sort(myHand);

        Console.WriteLine(CheckForHand(myHand));
    }

    private static string CheckForHand(int[] myHand)
    {
        string message = string.Empty;

        if (myHand[0] == myHand[1] &&
           myHand[0] == myHand[2] &&
           myHand[0] == myHand[3] &&
           myHand[0] == myHand[4])
        {
            message = "Impossible";
            return message;
        }

        for (int i = 0; i < myHand.Length - 3; i++)
        {
            if (myHand[i] == myHand[i + 1] &&
                myHand[i] == myHand[i + 2] &&
                myHand[i] == myHand[i + 3])
            {
                message = "Four of a Kind";
                return message;
            }
        }

        for (int i = 0; i < myHand.Length - 4; i++)
        {
            if (myHand[i] == myHand[i + 1] &&
                myHand[i] == myHand[i + 2] &&
                myHand[i + 3] == myHand[i + 4])
            {
                message = "Full House";
                return message;
            }
            else if(myHand[i] == myHand[i + 1] &&
                    myHand[i + 2] == myHand[i + 3] &&
                    myHand[i + 2] == myHand[i + 4])
            {
                message = "Full House";
                return message;
            }
        }

        if (myHand[0] == myHand[1] - 1 &&
            myHand[1] == myHand[2] - 1 &&
            myHand[2] == myHand[3] - 1 &&
            myHand[3] == myHand[4] - 1)
        {
            message = "Straight";
            return message;
        }

        if (myHand[0] == 2 &&
            myHand[1] == 3 &&
            myHand[2] == 4 &&
            myHand[3] == 5 &&
            myHand[4] == 14)
        {
            message = "Straight";
            return message;
        }

        for (int i = 0; i < myHand.Length - 2; i++)
        {
            if (myHand[i] == myHand[i + 1] &&
                myHand[i] == myHand[i + 2])
            {
                message = "Three of a Kind";
                return message;
            }
        }

        for (int i = 0; i < myHand.Length - 1; i++)
        {
            if (myHand[i] == myHand[i + 1])
            {
                int cardNumber = myHand[i];

                for (int j = i; j < myHand.Length - 1; j++)
                {
                    if (myHand[j] == myHand[j + 1] &&
                        myHand[j] != myHand[i])
                    {
                        message = "Two Pairs";
                        return message;
                    }
                }
            }
        }

        for (int i = 0; i < myHand.Length - 1; i++)
        {
            if (myHand[i] == myHand[i + 1])
            {
                message = "One Pair";
                return message;
            }
        }

        message = "Nothing";
        return message;
    }


    static int GetNumber(string input)
    {
        switch (input)
        {
            case "2": return 2; break;
            case "3": return 3; break;
            case "4": return 4; break;
            case "5": return 5; break;
            case "6": return 6; break;
            case "7": return 7; break;
            case "8": return 8; break;
            case "9": return 9; break;
            case "10": return 10; break;
            case "J": return 11; break;
            case "Q": return 12; break;
            case "K": return 13; break;
            case "A": return 14; break;
            default:
                throw new ArgumentException("Invalid card.");
        }
    }
}