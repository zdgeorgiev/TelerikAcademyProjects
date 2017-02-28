using System;

class StudentCables
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int cableSum = 0;
        int cableCount = 0;

        for (int i = 0; i < n; i++)
        {
            int currentCable = int.Parse(Console.ReadLine());
            string measures = Console.ReadLine();

            if (measures == "meters")
            {
                currentCable *= 100;
            }

            if (currentCable < 20)
            {
                continue;
            }

            cableCount++;
            cableSum += currentCable;
        }

        cableSum -= (cableCount - 1) * 3;
        int fullCables = 0;

        while (cableSum >= 504)
        {
            int currentCableLenght = 500 + 4;
            cableSum -= currentCableLenght;

            fullCables++;
        }

        Console.WriteLine(fullCables);
        Console.WriteLine(cableSum);
    }
}