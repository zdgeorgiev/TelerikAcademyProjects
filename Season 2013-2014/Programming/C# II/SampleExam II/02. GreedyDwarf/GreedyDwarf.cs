using System;

class GreedyDwarf
{
    static void Main(string[] args)
    {
        string numbers = Console.ReadLine();

        var valley = numbers.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int numberOfPatterns = int.Parse(Console.ReadLine());
        int[] allCoins = new int[numberOfPatterns];

        for (int i = 0; i < numberOfPatterns; i++)
        {
            string[] patternNumbers = Console.ReadLine().Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            allCoins[i] = GetCoinsFromCurrentPattern(valley, patternNumbers);
        }

        Array.Sort(allCoins);
        Array.Reverse(allCoins);

        Console.WriteLine(allCoins[0]);
    }

    private static int GetCoinsFromCurrentPattern(string[] valley, string[] patternNumbers)
    {
        int coins = int.Parse(valley[0]);
        bool[] visited = new bool[valley.Length];

        visited[0] = true;

        int currentCell = 0;
        int nextCell = 0;

        while (true)
        {
            for (int j = 0; j < patternNumbers.Length; j++)
            {
                nextCell = currentCell + int.Parse(patternNumbers[j]);

                if (nextCell < 0 || nextCell >= valley.Length || visited[nextCell])
                {
                    return coins;
                }
                else
                {
                    coins += int.Parse(valley[nextCell]);
                    currentCell = nextCell;
                    visited[nextCell] = true;
                }
            }

        }
    }
}