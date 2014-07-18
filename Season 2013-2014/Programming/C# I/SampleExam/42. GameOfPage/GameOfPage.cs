using System;

class GameOfPage
{
    const int ROWS = 16;
    const int COLS = 16;
    const string WhatIs = "what is";
    const string Buy = "buy";
    const string Paypal = "paypal";
    const decimal CookieFixedPrize = 1.79M;

    static int[,] pageField;

    static decimal totalPrice = 0;

    static void Main(string[] args)
    {
        pageField = new int[ROWS, COLS];

        ProcessInput();
        ExecuteCommands();
        Console.WriteLine("{0:F2}", totalPrice);
    }

    private static void ExecuteCommands()
    {
        string curreCommand = Console.ReadLine();

        while (curreCommand != Paypal)
        {
            int targetRow = int.Parse(Console.ReadLine());
            int targetCol = int.Parse(Console.ReadLine());

            switch (curreCommand)
            {
                case WhatIs:
                    string commandInput = ExecuteWhatIsCommand(targetRow, targetCol);

                    if (commandInput != string.Empty)
                    {
                        Console.WriteLine(commandInput);
                    }

                    break;
                case Buy: ExecuteBuyCommand(targetRow, targetCol); break;

                default:
                    throw new ArgumentException("Invalid command.");
            }

            curreCommand = Console.ReadLine();
        }
    }

    private static string ExecuteWhatIsCommand(int row, int col)
    {
        if (pageField[row, col] == 0)
        {
            return "smile";
        }

        string whatIs = string.Empty;
        int numberOfCrubs = 1;

        //Check top
        if (row > 0)
        {
            if (pageField[row - 1, col] == 1)
            {
                numberOfCrubs++;
            }

            //Check top-right if its possible
            if (row < pageField.GetLength(0) - 1)
            {
                if (pageField[row - 1, col + 1] == 1)
                {
                    numberOfCrubs++;
                }
            }

            //Check top-left if its possible
            if (row > 0 && col > 0)
            {
                if (pageField[row - 1, col - 1] == 1)
                {
                    numberOfCrubs++;
                }
            }
        }

        //Check bottom
        if (row < pageField.GetLength(0) - 1)
        {
            if (pageField[row + 1, col] == 1)
            {
                numberOfCrubs++;
            }

            //Check bottom-right if its possible
            if (col < pageField.GetLength(1) - 1)
            {
                if (pageField[row + 1, col + 1] == 1)
                {
                    numberOfCrubs++;
                }
            }

            //Check bottom-left if its possible
            if (col > 0 && row > 0)
            {
                if (pageField[row + 1, col - 1] == 1)
                {
                    numberOfCrubs++;
                }
            }
        }

        //Check left
        if (col > 0)
        {
            if (pageField[row, col - 1] == 1)
            {
                numberOfCrubs++;
            }
        }

        //Check right
        if (col < pageField.GetLength(1) - 1)
        {
            if (pageField[row, col + 1] == 1)
            {
                numberOfCrubs++;
            }
        }

        if (numberOfCrubs == 1)
        {
            whatIs = "cookie crumb";
        }
        else if (numberOfCrubs == 9)
        {
            whatIs = "cookie";
        }
        else
        {
            whatIs = "broken cookie";
        }

        return whatIs;
    }

    private static void DeleteTheCookieFromTheArea(int row, int col)
    {
        pageField[row, col] = 0;
        pageField[row - 1, col] = 0;
        pageField[row + 1, col] = 0;
        pageField[row, col + 1] = 0;
        pageField[row, col - 1] = 0;
        pageField[row - 1, col + 1] = 0;
        pageField[row - 1, col - 1] = 0;
        pageField[row + 1, col - 1] = 0;
        pageField[row + 1, col + 1] = 0;
    }

    private static void ExecuteBuyCommand(int row, int col)
    {
        switch (ExecuteWhatIsCommand(row, col))
        {
            case "cookie":
                totalPrice += CookieFixedPrize;
                DeleteTheCookieFromTheArea(row, col);
                break;
            case "broken cookie":
            case "cookie crumb":
                Console.WriteLine("page");
                break;

            default:
                throw new ArgumentException("Invalid quote");
        }
    }

    private static void ProcessInput()
    {
        for (int row = 0; row < pageField.GetLength(0); row++)
        {
            string currentLine = Console.ReadLine();

            for (int col = 0; col < pageField.GetLength(1); col++)
            {
                pageField[row, col] = int.Parse(currentLine[col].ToString());
            }
        }
    }
}