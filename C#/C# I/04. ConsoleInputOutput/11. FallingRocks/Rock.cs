using System;
using System.Collections.Generic;
using System.Linq;

public class Rock
{
    public Field Field;
    public int X { get; set; }
    public int Y { get; set; }
    public string Symbol { get; set; }
    private int minesPerPeriod;

    public int MinesPerPeriod
    {
        get { return minesPerPeriod; }
        set
        {
            if (value <= 0 || value > Field.Width)
            {
                throw new ArgumentException
                    ("Sorry but max mines per row cannot be 0 or bigger than game field width");
            }
            minesPerPeriod = value;
        }
    }

    private readonly List<string> AllRockSymbols = new List<string>()
    {
        "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";"
    };

    public Rock(Field field, int minesPerPeriod, int x = 0, int y = 0, string symbol = "")
    {
        this.X = x;
        this.Y = y;
        this.Symbol = symbol;
        this.Field = field;
        this.MinesPerPeriod = minesPerPeriod;
    }

    public void AddOneLineRocks(List<Rock> allRocks)
    {
        Random randomGenerator = new Random();
        int numberOfMinesPerPeriod = this.MinesPerPeriod;
        int currentMines = randomGenerator.Next(1, numberOfMinesPerPeriod);

        for (int i = 0; i < currentMines; i++)
        {
            Rock currentRock = new Rock(Field, currentMines);
            currentRock.Y = randomGenerator.Next(0, this.Field.Width + 1);
            Console.SetCursorPosition(currentRock.Y, 0);
            currentRock.Symbol = AllRockSymbols[randomGenerator.Next(0, AllRockSymbols.Count)];
            Console.WriteLine(currentRock.Symbol);
            allRocks.Add(currentRock);
        }
    }

    public void UpdatePosition(List<Rock> rocks)
    {
        for (int i = 0; i < rocks.Count; i++)
        {
            if (rocks[i].X < Console.WindowHeight - 2)
            {
                rocks[i].X++;
            }
            else
            {
                var fallenRocks = rocks.Where(rock => rock.X == Console.WindowHeight - 2).ToArray();

                for (int j = 0; j < fallenRocks.Length; j++)
                {
                    rocks.Remove(fallenRocks[j]);
                }
            }
        }
    }
}