using System;

class Miscat
{
    static void Main(string[] args)
    {
        int[] cats = new int[11];

        int jugde = int.Parse(Console.ReadLine());

        for (int i = 0; i < jugde; i++)
        {
            int vote = int.Parse(Console.ReadLine());
            cats[vote]++;
        }

        int max = 0;
        int index = 0;

        for (int i = 0; i < cats.Length; i++)
        {
            int currentValue = cats[i];

            if (currentValue > max)
            {
                max = currentValue;
                index = i;
            }
        }

        Console.WriteLine(index);
    }
}