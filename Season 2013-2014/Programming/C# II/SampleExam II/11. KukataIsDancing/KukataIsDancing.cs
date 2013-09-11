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

        for (int i = 0; i < numberOfPatterns; i++)
        {
            string currentTurn = "U";

            int row = 1;
            int col = 1;

            string lastBlock = cube[row, col];
            string pattern = Console.ReadLine();

            for (int j = 0; j < pattern.Length; j++)
            {
                string nextTurn = pattern[j].ToString();

                switch (nextTurn)
                {
                    case "L":

                        switch (currentTurn)
                        {
                            case "L": currentTurn = "D"; break;
                            case "R": currentTurn = "U"; break;
                            case "U": currentTurn = "L"; break;
                            case "D": currentTurn = "R"; break;

                            default:
                                break;
                        }

                        break;
                    case "R":

                        switch (currentTurn)
                        {
                            case "L": currentTurn = "U"; break;
                            case "R": currentTurn = "D"; break;
                            case "U": currentTurn = "R"; break;
                            case "D": currentTurn = "L"; break;

                            default:
                                break;
                        }

                        break;
                    case "W":

                        if (currentTurn == "U")
                        {
                            row--;
                        }
                        else if (currentTurn == "D")
                        {
                            row++;
                        }
                        else if (currentTurn == "R")
                        {
                            col++;
                        }
                        else if (currentTurn == "L")
                        {
                            col--;
                        }

                        if (row < 0)
                        {
                            row = 2;
                        }
                        else if (row > 2)
                        {
                            row = 0;
                        }

                        if (col < 0)
                        {
                            col = 2;
                        }
                        else if (col > 2)
                        {
                            col = 0;
                        }

                        lastBlock = cube[row, col];

                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(lastBlock);
        }
    }
}