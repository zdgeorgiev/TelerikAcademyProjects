using System;
using System.Text;

class BullsAndCows
{
    static void Main(string[] args)
    {
        int secretNumber = int.Parse(Console.ReadLine());

        int bull = int.Parse(Console.ReadLine());
        int cow = int.Parse(Console.ReadLine());

        int currentBulls = 0;
        int currentCows = 0;

        StringBuilder allNumbers = new StringBuilder();

        for (int i = 1000; i < 10000; i++)
        {
            char[] currentNumber = i.ToString().ToCharArray();
            char[] secretString = secretNumber.ToString().ToCharArray();

            if (i.ToString().Contains("0"))
            {
                continue;
            }

            //bulls
            for (int j = 0; j < 4; j++)
            {
                if (secretString[j] == currentNumber[j]
                    && secretString[j] != 0)
                {
                    secretString[j] = ' ';
                    currentNumber[j] = ' ';
                    currentBulls++;
                }
            }

            //Get the string of the remaining numbers
            StringBuilder remainingNumbers = new StringBuilder();
            for (int q = 0; q < secretString.Length; q++)
            {
                if (secretString[q] != ' ')
                {
                    remainingNumbers.Append(secretString[q]);
                }
            }

            //Get the string of the remaining numbers for currentNumber
            StringBuilder remainingNumbersInCurrentNumb = new StringBuilder();
            for (int q = 0; q < currentNumber.Length; q++)
            {
                if (secretString[q] != ' ')
                {
                    remainingNumbersInCurrentNumb.Append(currentNumber[q]);
                }
            }

            string finalNumber = remainingNumbers.ToString();
            string finalCurrNumber = remainingNumbersInCurrentNumb.ToString();

            //cows
            for (int k = 0; k < remainingNumbers.Length; k++)
            {
                if (finalNumber.Contains(finalCurrNumber[k].ToString()) && finalNumber[k] != ' ')
                {
                    currentCows++;
                    int index = finalNumber.IndexOf(finalCurrNumber[k]);
                    //Here calls the problem doesnt remove from the string..
                    finalNumber.Remove(index);
                    finalCurrNumber.Remove(k);
                }
            }


            if (currentBulls == bull && currentCows == cow)
            {
                allNumbers.Append(i);
                allNumbers.Append(" ");
            }

            currentBulls = 0;
            currentCows = 0;
        }

        if (allNumbers.Length == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            allNumbers.Length--;
            Console.WriteLine(allNumbers.ToString());
        }
    }
}