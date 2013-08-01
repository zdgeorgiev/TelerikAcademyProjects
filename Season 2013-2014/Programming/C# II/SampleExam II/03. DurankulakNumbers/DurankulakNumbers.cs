using System;
using System.Linq;
using System.Numerics;

class DurankulakNumbers
{
    static string[] InitializeTheLetters()
    {
        // 55/100 dont work with Capital Letters like AA

        string[] allLetters = new string[168];

        for (int i = 0; i < 26; i++)
        {
            allLetters[i] = ((char)(65 + i)).ToString();
        }

        int currentPosition = 26;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (currentPosition == 168)
                {
                    return allLetters;
                }

                allLetters[currentPosition] = ((char)(65 + i)).ToString().ToLower()
                    + ((char)(65 + j)).ToString().ToUpper();

                currentPosition++;
            }
        }

        return allLetters;
    }

    static void Main(string[] args)
    {
        string[] allLetters = InitializeTheLetters();

        string number = Console.ReadLine();


        BigInteger finalNumber = 0;

        if (number.Length % 2 != 0)
        {
            finalNumber += allLetters.ToList().IndexOf(number[0].ToString())
                * (BigInteger)(Math.Pow((double)168, (double)(number.Length - 1) / 2));

            int index = (number.Length - 1) / 2;

            for (int i = 1; i < number.Length; i += 2)
            {
                finalNumber += allLetters.ToList().IndexOf(number.Substring(i, 2))
                    * (BigInteger)(Math.Pow((double)168, (double)index - 1));

                index--;
            }

            Console.WriteLine(finalNumber);
        }
        else
        {
            int index = number.Length / 2;

            for (int i = 0; i < number.Length; i += 2)
            {
                finalNumber += allLetters.ToList().IndexOf(number.Substring(i, 2))
                    * (BigInteger)(Math.Pow((double)168, (double)index - 1));

                index--;
            }

            Console.WriteLine(finalNumber);
        }
    }
}