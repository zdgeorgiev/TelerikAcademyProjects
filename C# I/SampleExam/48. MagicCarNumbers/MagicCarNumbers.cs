using System;

class MagicCarNumbers
{
    static int count = 0;
    static int weight;
    static readonly int[] allCharWeight = new int[] { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
    
    static void Main(string[] args)
    {
        weight = int.Parse(Console.ReadLine());

        CountTheWeigthNumbers();

        Console.WriteLine(count);
    }

    private static void CountTheWeigthNumbers()
    {
        for (int i = 0; i < 10000; i++)
        {
            string currentNumber = i.ToString().PadLeft(4, '0');
            int currentNumberSum = 0;

            if ((currentNumber[0] == currentNumber[1] && currentNumber[0] == currentNumber[2]
                    && currentNumber[0] == currentNumber[3]) ||
                (currentNumber[1] == currentNumber[2] && currentNumber[1] == currentNumber[3]
                    && currentNumber[0] != currentNumber[3]) ||
                (currentNumber[0] == currentNumber[1] && currentNumber[0] == currentNumber[2]
                    && currentNumber[0] != currentNumber[3]) ||
                (currentNumber[0] == currentNumber[1] && currentNumber[2] == currentNumber[3]
                    && currentNumber[0] != currentNumber[3]) ||
                (currentNumber[0] == currentNumber[2] && currentNumber[1] == currentNumber[3]
                    && currentNumber[0] != currentNumber[1]) ||
                (currentNumber[0] == currentNumber[3] && currentNumber[1] == currentNumber[2]
                    && currentNumber[0] != currentNumber[1]))
            {
                for (int j = 0; j < currentNumber.Length; j++)
                {
                    currentNumberSum += int.Parse(currentNumber[j].ToString());
                }

                for (int k = 0; k < allCharWeight.Length; k++)
                {
                    for (int l = 0; l < allCharWeight.Length; l++)
                    {
                        int charSum = allCharWeight[k];
                        charSum += allCharWeight[l];

                        if (currentNumberSum + charSum + 40 == weight)
                        {
                            count++;
                        }
                    }
                }
            }
        }
    }
}