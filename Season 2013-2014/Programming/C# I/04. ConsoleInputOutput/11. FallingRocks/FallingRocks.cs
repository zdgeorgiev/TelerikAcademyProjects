﻿using System;
using System.Collections.Generic;
using System.Threading;

class FallingRocks
{
    static void Main(string[] args)
    {
        Console.Write("Enter how much the game field width will be [10...30] : ");
        int gameFieldWidth = int.Parse(Console.ReadLine());
        Console.Write("Enter a symbol for your dwarf : ");
        string dwarfSymbol = Console.ReadLine();
        Console.Write("Enter how much mines you want max per row : ");
        int maxMinesPerRow = int.Parse(Console.ReadLine());
        int gameSpeed = 0;
        Console.Clear();


        Dwarf dwarf = new Dwarf(dwarfSymbol, new Field(gameFieldWidth));
        Rock rock = new Rock(new Field(gameFieldWidth), maxMinesPerRow);
        List<Rock> allRocks = new List<Rock>();

        DateTime startingTime = DateTime.Now;
        DateTime endingTime;
        int result = 0;
        //int gameSpeed = 300 - result / 10 - 10;
        bool isLose = false;

        RemoveScrollBars();

        do
        {
            Console.Clear();
            rock.AddOneLineRocks(allRocks);

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey();
                dwarf.Move(keyPressed);
            }

            dwarf.PrintTheDwarf();
            PrintTheResult(result, gameSpeed);
            rock.UpdatePosition(allRocks);

            foreach (Rock currentRock in allRocks)
            {
                Console.SetCursorPosition(currentRock.Y, currentRock.X);
                Console.WriteLine(currentRock.Symbol);

                if (currentRock.Y == dwarf.Y && currentRock.X == Console.WindowHeight - 2)
                {
                    isLose = true;
                    endingTime = DateTime.Now;
                    PrintTheResult(startingTime, endingTime, gameSpeed, result);
                    break;
                }
            }

            if (result / 10 <= 100)
            {
                gameSpeed = 300 - result / 10 - 10;
                Thread.Sleep(gameSpeed);
            }
            else
            {
                Thread.Sleep(100);
                gameSpeed = 100;
            }

            result += 20;
        }
        while (!isLose);
    }

    private static void PrintTheResult(DateTime totalPlaying, DateTime losingTime, int GameSpeed, int result)
    {
        Console.Clear();
        Console.WriteLine("GAME OVER!");
        Console.WriteLine("You've done it very well.\n You have survived for {0}", losingTime - totalPlaying);
        Console.WriteLine("Final score : {0}", result);
    }

    private static void PrintTheResult(int result, int gameSpeed)
    {
        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 - 5);
        Console.WriteLine("Result = {0}", result);
        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 - 6);
        Console.WriteLine("Gamespeed = {0}", gameSpeed);
    }

    private static void RemoveScrollBars()
    {
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }
}

//Implement the "Falling Rocks" game in the text console.
//A small dwarf stays at the bottom of the screen and can move
//left and right (by the arrows keys). A number of rocks of different
//sizes and forms constantly fall down and you need to avoid a crash.