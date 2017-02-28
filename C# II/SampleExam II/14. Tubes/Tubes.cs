using System;

class Tubes
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int friends = int.Parse(Console.ReadLine());

        int[] tubes = new int[n];

        for (int i = 0; i < n; i++)
        {
            tubes[i] += int.Parse(Console.ReadLine());
        }
    }
}