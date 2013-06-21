using System;
using System.Linq;

class OddNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long[] numbers = new long[n];
        
        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        
        for (int i = 0; i < numbers.Length; i++)
        {
            int count = 0;
        
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                }
            }
        
            if (count % 2 == 1)
            {
                Console.WriteLine(numbers[i]);
                break;
            }
        }
    }
}