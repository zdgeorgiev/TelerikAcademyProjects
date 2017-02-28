using System;
using System.Linq;

namespace TeamEeyore.SpaceShip
{
    class HelpMenu
    {
        static byte curX = (byte)(Console.WindowWidth - 10);
        static byte curY = 0;
        static byte tempX = curX;
        static byte tempY = curY;

        public static void Help()
        {
            Page1();
            ChangePage();
        }

        static void Page1()
        {
            #region PrintShips
            for (int i = 0; i < 9; i++)
            {
                
                MainMenu.Print(curX, curY, "#", ConsoleColor.Green);
                if (i == 0 || i == 8)
                {
                    for (byte j = 0; j < 5; j++)
                    {
                        MainMenu.Print(curX, j, "#", ConsoleColor.Green);
                    }

                }
                curX++;
                if (i == 8)
                {
                    curY = 5;
                    curX = tempX;
                    for (int g = 0; g < 9; g++)
                    {
                        MainMenu.Print(curX, curY, "#", ConsoleColor.Green);
                        curX++;
                    }
                }
            }
            Console.WriteLine();
            MainMenu.Print(Console.WindowWidth - 7, 2, "|=0=|", ConsoleColor.Red);


            curX = 0;
            curY = (byte)(Console.WindowHeight - 7);
            for (int i = 0; i < 11; i++)
            {
                MainMenu.Print(curX, curY, "#", ConsoleColor.Green);
                if (i == 0 || i == 10)
                {
                    for (int j = curY; j < curY + 5; j++)
                    {
                        MainMenu.Print(curX, j, "#", ConsoleColor.Green);
                    }
                }
                curX++;
                if (i == 10)
                {
                    curX = 0;
                    for (int g = 0; g < 11; g++)
                    {
                        MainMenu.Print(curX, curY + 5, "#", ConsoleColor.Green);
                        curX++;
                    }
                }
            }

            MainMenu.Print(2, Console.WindowHeight - 4, "|==0==|", ConsoleColor.Red);
            #endregion

            MainMenu.Print(Console.WindowWidth - 36, 2, "This is your Spaceship -->", ConsoleColor.Cyan);
            MainMenu.Print(13, Console.WindowHeight - 4, "<-- These are your enemies", ConsoleColor.Cyan);

            MainMenu.Print(Console.WindowWidth - 15, Console.WindowHeight - 5, "--> Move Left", ConsoleColor.Cyan);
            MainMenu.Print(Console.WindowWidth - 15, Console.WindowHeight - 4, "<-- Move Right", ConsoleColor.Cyan);
            MainMenu.Print(Console.WindowWidth - 15, Console.WindowHeight - 3, " F  Shoot", ConsoleColor.Cyan);
            MainMenu.Print(0, 0, "\"SPACESHIP\" HELP CONTENT:", ConsoleColor.Cyan);
            MainMenu.Print(0, 1, "(press b to go back)", ConsoleColor.Cyan);
        }

        static void ChangePage()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            while (key.Key != ConsoleKey.B)
            {
                key = Console.ReadKey();
            }
            Console.Clear();
            MainMenu.Main();
            
        }

    }
}
