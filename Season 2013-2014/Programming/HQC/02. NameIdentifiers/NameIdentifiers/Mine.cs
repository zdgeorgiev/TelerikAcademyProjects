namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Mine
    {
        public static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] playField = DrawPlayField();
            char[,] bombField = CreateBombField();
            int personalScore = 0;
            bool hitBomb = false;
            List<Score> topScorers = new List<Score>(6);
            int row = 0;
            int col = 0;
            bool isNewGame = true;
            const int MAX_POINTS = 35;
            bool isWon = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Lets play minesweeper. Try your luck to find the fields with no bombs on them." +
                    " Command 'top' displays the scoreboard, 'restart' restart the game, 'exit' exit from the application!");
                    DisplayTheMatrix(playField);
                    isNewGame = false;
                }

                Console.Write("Enter row and col : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= playField.GetLength(0) && col <= playField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        GetRating(topScorers);
                        break;
                    case "restart":
                        playField = DrawPlayField();
                        bombField = CreateBombField();
                        DisplayTheMatrix(playField);
                        hitBomb = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Cya, later!");
                        break;
                    case "turn":
                        if (bombField[row, col] != '*')
                        {
                            if (bombField[row, col] == '-')
                            {
                                EnterSurroundingBombCount(playField, bombField, row, col);
                                personalScore++;
                            }

                            if (MAX_POINTS == personalScore)
                            {
                                isWon = true;
                            }
                            else
                            {
                                DisplayTheMatrix(playField);
                            }
                        }
                        else
                        {
                            hitBomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command!\n");
                        break;
                }

                if (hitBomb)
                {
                    DisplayTheMatrix(bombField);
                    Console.Write("\nHrrrrrr! Your scoure is {0} points. " + "Your nickname: ", personalScore);
                    string nickname = Console.ReadLine();
                    Score playerScore = new Score(nickname, personalScore);

                    if (topScorers.Count < 5)
                    {
                        topScorers.Add(playerScore);
                    }
                    else
                    {
                        for (int i = 0; i < topScorers.Count; i++)
                        {
                            if (topScorers[i].Points < playerScore.Points)
                            {
                                topScorers.Insert(i, playerScore);
                                topScorers.RemoveAt(topScorers.Count - 1);
                                break;
                            }
                        }
                    }

                    topScorers.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    topScorers.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    GetRating(topScorers);

                    playField = DrawPlayField();
                    bombField = CreateBombField();
                    personalScore = 0;
                    hitBomb = false;
                    isNewGame = true;
                }

                if (isWon)
                {
                    Console.WriteLine("\nCongratulations! You've opened 35 boxes without bomb.");
                    DisplayTheMatrix(bombField);
                    Console.WriteLine("Your nickname: ");
                    string nickname = Console.ReadLine();
                    Score score = new Score(nickname, personalScore);
                    topScorers.Add(score);
                    GetRating(topScorers);
                    playField = DrawPlayField();
                    bombField = CreateBombField();
                    personalScore = 0;
                    isWon = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Goodbye.");
            Console.Read();
        }

        private static void GetRating(List<Score> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty leader board!\n");
            }
        }

        private static void EnterSurroundingBombCount(char[,] playField, char[,] bombField, int col, int row)
        {
            char surroundingBombCount = GetSurroundingBombCount(bombField, col, row);
            bombField[col, row] = surroundingBombCount;
            playField[col, row] = surroundingBombCount;
        }

        private static void DisplayTheMatrix(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                Console.Write("{0} | ", currentRow);

                for (int curretnCol = 0; curretnCol < cols; curretnCol++)
                {
                    Console.Write(string.Format("{0} ", board[currentRow, curretnCol]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] DrawPlayField()
        {
            int rows = 5;
            int cols = 10;
            char[,] board = new char[rows, cols];

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int curretnCol = 0; curretnCol < cols; curretnCol++)
                {
                    board[currentRow, curretnCol] = '?';
                }
            }

            return board;
        }

        private static char[,] CreateBombField()
        {
            int rows = 5;
            int cols = 10;
            char[,] bombField = new char[rows, cols];
            List<int> bombMap = new List<int>();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    bombField[row, col] = '-';
                }
            }

            while (bombMap.Count < 15)
            {
                Random randomInteger = new Random();
                int randomLocation = randomInteger.Next(50);

                if (!bombMap.Contains(randomLocation))
                {
                    bombMap.Add(randomLocation);
                }
            }

            foreach (int bombLocation in bombMap)
            {
                int col = bombLocation / cols;
                int row = bombLocation % cols;

                if (row == 0 && bombLocation != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                bombField[col, row - 1] = '*';
            }

            return bombField;
        }

        private static void CalculatePoints(char[,] playField)
        {
            int cols = playField.GetLength(0);
            int rows = playField.GetLength(1);

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (playField[col, row] != '*')
                    {
                        char points = GetSurroundingBombCount(playField, col, row);
                        playField[col, row] = points;
                    }
                }
            }
        }

        private static char GetSurroundingBombCount(char[,] gameField, int row, int col)
        {
            int bombCount = 0;
            int rows = gameField.GetLength(0);
            int cols = gameField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (gameField[row - 1, col] == '*')
                {
                    bombCount++;
                }
            }

            if (row + 1 < rows)
            {
                if (gameField[row + 1, col] == '*')
                {
                    bombCount++;
                }
            }

            if (col - 1 >= 0)
            {
                if (gameField[row, col - 1] == '*')
                {
                    bombCount++;
                }
            }

            if (col + 1 < cols)
            {
                if (gameField[row, col + 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (gameField[row - 1, col - 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (gameField[row - 1, col + 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (gameField[row + 1, col - 1] == '*')
                {
                    bombCount++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (gameField[row + 1, col + 1] == '*')
                {
                    bombCount++;
                }
            }

            return char.Parse(bombCount.ToString());
        }
    }
}