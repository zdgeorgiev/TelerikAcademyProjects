using System;

class ProgSevenlandNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] allNumbers = new int[1000];
        int index = 0;

        for (int i = 0; i < allNumbers.Length; i++)
        {
            if (n == 666)
            {
                Console.WriteLine(1000);
                return;
            }
            if (i < 100)
            {
                int secondDigit = i / 10 % 10;

                if (i % 10 == 7 ||
                    i % 10 == 8 ||
                    i % 10 == 9)
                {
                    continue;
                }
                else if (secondDigit == 7 ||
                        secondDigit == 8 ||
                        secondDigit == 9)
                {
                    continue;
                }
                else
                {
                    allNumbers[index] = i;
                    index++;
                }
            }
            else
            {
                int secondDigit = i / 10 % 10;

                if (i % 10 == 7 ||
                    i % 10 == 8 ||
                    i % 10 == 9)
                {
                    continue;
                }
                else if (secondDigit == 7 ||
                        secondDigit == 8 ||
                        secondDigit == 9)
                {
                    continue;
                }
                else
                {
                    allNumbers[index] = i;
                    index++;
                }
            }
        }

        int lastIndex = Array.IndexOf(allNumbers, n) + 1;
        Console.WriteLine(allNumbers[lastIndex]);
    }
}