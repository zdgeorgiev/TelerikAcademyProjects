using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TeamEeyore.SpaceShip
{
    class Collisions
    {
        private static readonly string[,] explosion = new string[3,3]{ {"\\", " ", "/" },
                                                      {" ", "o", " "},
                                                      {"/", " ", "\\"} };
        public const int ExplosionX = 3;
        public const int ExplosionY = 3;

        public static void ShipCollision(int score, int level)
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.WindowHeight / 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("GAME OVER!");

            string playerName = System.Configuration.ConfigurationManager.AppSettings["PlayerName"];

            var lineCount = File.ReadLines("../../HighScores.txt").Count();

            using (StreamWriter writer = new StreamWriter("../../HighScores.txt", true))
            {
                writer.WriteLine("{0,2} {1,7} {2,4} {3,6}", lineCount - 1, playerName, level, score);
            }

            SortTheHighScores();
        }
  
        private static void SortTheHighScores()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader("../../HighScores.txt"))
            {
                string currentLine = reader.ReadLine();
                currentLine = reader.ReadLine();
                currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    string[] currentLineParameters = currentLine
                        .Split(new char[] { ' ', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    var removedLeadingNumber = currentLine.TrimStart(currentLine.Substring(0, 2).ToCharArray());

                    dic.Add(removedLeadingNumber, int.Parse(currentLineParameters[3]));

                    currentLine = reader.ReadLine();
                }
            }

            var sortedHighScore = dic.OrderByDescending(score => score.Value);

            using (StreamWriter writer = new StreamWriter("../../HighScores.txt", false))
            {
                writer.WriteLine("     Name   Level  Score");
                writer.WriteLine();

                for (int i = 0; i < sortedHighScore.ToArray().Length; i++)
                {
                    if (i == 15)
                    {
                        break;
                    }

                    string[] allElementsFromLine = sortedHighScore.ToArray()[i].Key
                        .Split(new char[] { ' ', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

                    writer.WriteLine("{0,2} {1,7} {2,4} {3,6}", i + 1,
                        allElementsFromLine[0], allElementsFromLine[1], allElementsFromLine[2]);
                }
            }
        }

        public static void ShotCollision()
        {
            Console.Clear();

            for (int i = 0; i < ExplosionX; i++)
            {
                Console.SetCursorPosition(Engine.explosionDrawX, Engine.explosionDrawY);

                for (int j = 0; j < ExplosionY; j++)
                {
                    Console.Write(explosion[i, j]);
                }

                Engine.explosionDrawY++;
            }
        }
    }
}
