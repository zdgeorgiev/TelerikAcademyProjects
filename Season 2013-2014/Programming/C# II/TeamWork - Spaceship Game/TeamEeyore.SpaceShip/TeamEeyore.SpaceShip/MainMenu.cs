using System;
using System.Linq;
using System.IO;
using System.Configuration;

namespace TeamEeyore.SpaceShip
{
    class MainMenu
    {
        struct Element
        {
            public int X { get; set; }
            public int Y { get; set; }
            public string TextValue { get; set; }
            public ConsoleColor Color { get; set; }
        }

        private static Element newGame;
        private static Element highScores;
        private static Element help;
        private static Element credits;
        private static Element exit;

        private static byte optionX = (byte)(Console.WindowWidth / 3 * 2);
        private static byte optionY = (byte)(Console.WindowHeight / 4);

        private static int selected = 0;

        public static void Main()
        {
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            PrintBox();
            Menu();
            OptionsPrint();
            Console.SetCursorPosition(5, optionY - 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Spaceship");
            string date = DateTime.Now.ToString();
            Console.SetCursorPosition(Console.WindowWidth - (date.Length + 2), Console.WindowHeight - 2);
            Console.WriteLine(DateTime.Now);
            OptionEngine();
        }

        public static void Menu()
        {
            #region Modifying element variables
            
            newGame.Color = ConsoleColor.DarkYellow;
            newGame.X = optionX;
            newGame.Y = optionY;
            newGame.TextValue = "New game";

            highScores.Color = ConsoleColor.DarkYellow;
            highScores.X = optionX;
            highScores.Y = optionY + 1;
            highScores.TextValue = "High scores";

            help.Color = ConsoleColor.DarkYellow;
            help.X = optionX;
            help.Y = optionY + 2;
            help.TextValue = "Help";

            credits.Color = ConsoleColor.DarkYellow;
            credits.X = optionX;
            credits.Y = optionY + 3;
            credits.TextValue = "Credits";

            exit.Color = ConsoleColor.DarkYellow;
            exit.X = optionX;
            exit.Y = optionY + 4;
            exit.TextValue = "Exit";

            #endregion
        }

        public static void Print(int x, int y, string textValue, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.WriteLine(textValue);
        }

        static void OptionsPrint()
        {
            Print(newGame.X, newGame.Y, newGame.TextValue, newGame.Color);
            Print(highScores.X, highScores.Y, highScores.TextValue, highScores.Color);
            Print(help.X, help.Y, help.TextValue, help.Color);
            Print(credits.X, credits.Y, credits.TextValue, credits.Color);
            Print(exit.X, exit.Y, exit.TextValue, exit.Color);
        }

        static void OptionEngine()
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            key = Console.ReadKey(true);

            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.DownArrow && selected != 5)
                {
                    selected += 1;
                }
                else if (key.Key == ConsoleKey.DownArrow && selected == 5)
                {
                    selected = 1;
                }

                if (key.Key == ConsoleKey.UpArrow && selected > 1)
                {
                    selected -= 1;
                }
                else if (key.Key == ConsoleKey.UpArrow && (selected == 1 || selected == 0))
                {
                    selected = 5;
                }

                switch (selected)
                {
                    case 1:
                        exit.Color = ConsoleColor.DarkYellow;
                        newGame.Color = ConsoleColor.Red;
                        highScores.Color = ConsoleColor.DarkYellow;
                        OptionsPrint();
                        break;
                    case 2:
                        newGame.Color = ConsoleColor.DarkYellow;
                        highScores.Color = ConsoleColor.Red;
                        help.Color = ConsoleColor.DarkYellow;
                        OptionsPrint();
                        break;
                    case 3:
                        highScores.Color = ConsoleColor.DarkYellow;
                        help.Color = ConsoleColor.Red;
                        credits.Color = ConsoleColor.DarkYellow;
                        OptionsPrint();
                        break;
                    case 4:
                        help.Color = ConsoleColor.DarkYellow;
                        credits.Color = ConsoleColor.Red;
                        exit.Color = ConsoleColor.DarkYellow;
                        OptionsPrint();
                        break;
                    case 5:
                        credits.Color = ConsoleColor.DarkYellow;
                        exit.Color = ConsoleColor.Red;
                        newGame.Color = ConsoleColor.DarkYellow;
                        OptionsPrint();
                        break;
                    default:
                        throw new ArgumentException("Invalid command");
                }

                key = Console.ReadKey(true);
            }

            switch (selected)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 30, Console.WindowHeight / 2);
                    Console.Write("Enter your name : ");

                    bool isNameValue = false;

                    do
                    {
                        string name = Console.ReadLine();

                        if (name.Length == 0 || name.Length > 10 ||
                            string.IsNullOrEmpty(name.Trim()))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 25, Console.WindowHeight / 2 + 2);
                            Console.Write("Invalid name! Name lenght should be in range 1-10 letter");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 30, Console.WindowHeight / 2);
                            Console.Write("Enter your name : ");
                            continue;
                        }

                        isNameValue = true;
                        ConfigurationManager.AppSettings["PlayerName"] = name;

                    } while (!isNameValue);
                    Engine.Start();
                    break;
                case 2:
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.SetCursorPosition(Console.WindowWidth / 2 - 10, 3);
                    Console.WriteLine("HIGH SCORES");
                    try
                    {
                        using (StreamReader reader = new StreamReader("../../HighScores.txt"))
                        {
                            string line = reader.ReadLine();

                            int currentLine = 5;

                            while (line != null)
                            {
                                Console.SetCursorPosition(Console.WindowWidth / 2 - 15, currentLine);
                                Console.WriteLine(line);
                                currentLine++;
                                line = reader.ReadLine();
                            }
                        }
                    }
                    catch (DirectoryNotFoundException ex)
                    {
                        Console.WriteLine("The specified directory for the file was not found.");
                        ShowMessage(ex);
                    }
                    catch (FileLoadException ex)
                    {
                        Console.WriteLine("The program couldn't load the file.");
                        ShowMessage(ex);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine("Access to the specified directory for the file was denied.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Unexpected error occured.");
                        ShowMessage(ex);
                    }

                    while (key.Key != ConsoleKey.B)
                    {
                        key = Console.ReadKey();
                        if (key.Key != ConsoleKey.B)
                        {
                            continue;
                        }
                    }
                    Console.Clear();
                    MainMenu.Main();
                    break;
                case 3:
                    Console.Clear();
                    HelpMenu.Help();
                    break;
                case 4:
                    Console.Clear();
                    Console.SetCursorPosition(10, 10);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("This game was created by Telerik Academy Team Eyeore. Year:2013.");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 9, 11);
                    Console.WriteLine("press b to go back");
                    string date = DateTime.Now.ToString();
                    Console.SetCursorPosition(Console.WindowWidth -  (date.Length + 2), Console.WindowHeight - 1);
                    Console.WriteLine(DateTime.Now);

                    while (key.Key != ConsoleKey.B)
                    {
                        key = Console.ReadKey();
                        if (key.Key != ConsoleKey.B)
                        {
                            continue;
                        }
                    }

                    Console.Clear();
                    MainMenu.Main();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentException("Invalid operation");
            }

        }

        static void PrintBox()
        {
            byte curY = (byte)(optionY - 2);
            byte curX = (byte)(optionX - 2);

            for (int i = 0; i < 9; i++)
            {
                Print(curX, curY, "#", ConsoleColor.Cyan);

                if (i == 0 || i == 8)
                {
                    byte tempX = curX;

                    for (int j = 0; j < 15; j++)
                    {
                        Print(curX, curY, "#", ConsoleColor.Cyan);
                        curX++;
                    }

                    curX = tempX;
                }

                curY++;
            }

            curX = (byte)(curX + 15);
            curY--;

            for (int i = 0; i < 9; i++)
            {
                Print(curX, curY, "#", ConsoleColor.Cyan);

                curY--;
            }
        }
        static void ShowMessage(Exception ex)
        {
            ConsoleKeyInfo mkey = new ConsoleKeyInfo();
            Console.WriteLine("Press E to show error stacktrace or B to go back.");
            mkey = Console.ReadKey();
            if (mkey.Key == ConsoleKey.E)
            {
                Console.WriteLine(ex.StackTrace);
            }
            else
            {
                Main();
            }
        }
    }
}
