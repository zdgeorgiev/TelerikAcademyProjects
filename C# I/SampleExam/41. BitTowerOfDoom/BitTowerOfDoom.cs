using System;
using System.Text;

public class BitTowerOfDoom
{
    const int ROWS = 8;
    const int COLS = 8;
    const string END = "end";
    const string KILL = "kill";
    const string SELECT = "select";
    const string MOVE = "move";

    static int[,] doomField;
    static int startingWarriorsCount;
    static int survivedWarriorsCount;
    static int sumOfAllSurvivedWarriors;

    static void Main(string[] args)
    {
        doomField = new int[ROWS, COLS];

        CreateTheDoomField();
        ProcessAllCommands();
        CalculateTheNewTower();

        Console.WriteLine(startingWarriorsCount);
        Console.WriteLine(survivedWarriorsCount);
        Console.WriteLine(sumOfAllSurvivedWarriors);
    }

    public static void CreateTheDoomField()
    {
        for (int i = 0; i < doomField.GetLength(0); i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            for (int j = 0; j < doomField.GetLength(1); j++)
            {
                //Get the binart representation of the current number in reversed order
                doomField[i, doomField.GetLength(0) - 1 - j] = (currentNumber >> j) & 1;

                if (((currentNumber >> j) & 1) == 1)
                {
                    startingWarriorsCount++;
                }
            }

        }
    }

    private static void CalculateTheNewTower()
    {
        for (int row = 0; row < doomField.GetLength(0); row++)
        {
            StringBuilder rowNumber = new StringBuilder();

            for (int col = 0; col < doomField.GetLength(1); col++)
            {
                rowNumber.Append(doomField[row, col]);

                if (doomField[row, col] == 1)
                {
                    survivedWarriorsCount++;
                }
            }

            int convertedNumber = Convert.ToInt32(rowNumber.ToString(), 2);

            sumOfAllSurvivedWarriors += convertedNumber;
        }
    }

    public static void ProcessAllCommands()
    {
        string currentCommand = Console.ReadLine();

        while (currentCommand != END)
        {
            int targetRow = int.Parse(Console.ReadLine());
            int targetCol = int.Parse(Console.ReadLine());

            switch (currentCommand)
            {
                case SELECT: ExecuteSelectCommand(targetRow, targetCol); break;

                default:
                    throw new ArgumentException("Invalid Comamnd");
            }

            //Get the new commnad
            currentCommand = Console.ReadLine();
        }
    }

    private static void ExecuteSelectCommand(int row, int col)
    {
        if (doomField[row, col] == 0)
        {
            return;
        }

        //reset the bit of the selected warrior
        doomField[row, col] = 0;

        string nextCommand = Console.ReadLine();
        int targetRow = int.Parse(Console.ReadLine());
        int targetCol = int.Parse(Console.ReadLine());

        switch (nextCommand)
        {
            case KILL: ExecuteKillCommand(targetRow, targetCol); break;
            case MOVE: ExecuteMoveCommand(targetRow, targetCol); break;

            default:
                throw new ArgumentException("Invalid Comamnd");
        }
    }

    private static void ExecuteKillCommand(int row, int col)
    {
        if (doomField[row, col] == 1)
        {
            return;
        }

        if (col - 1 >= 0 && col + 1 < doomField.GetLength(1) &&
            doomField[row, col - 1] == 1 && doomField[row, col + 1] == 1)
        {
            return;
        }
        else if (col - 1 >= 0 && doomField[row, col - 1] == 1)
        {
            doomField[row, col - 1] = 0;
        }
        else if (col + 1 < doomField.GetLength(1) && doomField[row, col + 1] == 1)
        {
            doomField[row, col + 1] = 0;
        }
        else
        {
            doomField[row, col] = 1;
        }
    }

    private static void ExecuteMoveCommand(int row, int col)
    {
        if (doomField[row, col] == 1)
        {
            return;
        }

        if (col - 1 >= 0 && col + 1 < doomField.GetLength(1) &&
            doomField[row, col - 1] == 1 && doomField[row, col + 1] == 1)
        {
            return;
        }
        else if (col - 1 >= 0 && doomField[row, col - 1] == 1)
        {
            doomField[row, col] = 0;
        }
        else if (col + 1 < doomField.GetLength(1) && doomField[row, col + 1] == 1)
        {
            doomField[row, col] = 0;
        }
        else
        {
            doomField[row, col] = 1;
        }
    }

    public static void PrintTheField()
    {
        for (int row = 0; row < doomField.GetLength(0); row++)
        {
            for (int col = 0; col < doomField.GetLength(1); col++)
            {
                Console.Write(doomField[row, col]);
            }

            Console.WriteLine();
        }
    }
}