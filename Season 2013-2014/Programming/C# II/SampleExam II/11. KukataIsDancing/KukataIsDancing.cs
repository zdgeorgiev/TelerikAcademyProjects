using System;

class KukataIsDancing
{
    static void Main(string[] args)
    {
        string[,] cube = new string[,]
        {
            { "RED" , "BLUE" , "RED"  },
            { "BLUE", "GREEN", "BLUE" },
            { "RED" , "BLUE" , "RED"  }
        };

        int numberOfPatterns = int.Parse(Console.ReadLine());

        string nextTurn = "Up";

        for (int i = 0; i < numberOfPatterns; i++)
        {
            string lastBlock = cube[1, 1];
            string pattern = Console.ReadLine();

            for (int j = 0; j < pattern.Length; j++)
            {
                string currentTurn = pattern[j].ToString();

                switch (currentTurn)
                {
                    case "L":break;
                    case "R": break;
                    case "W": break;
                    default:
                        break;
                }
            }

            Console.WriteLine(lastBlock);
        }
    }
}