using System;
using System.Text;
using System.Linq;

class Indices
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] rawNumbers = Console.ReadLine().Split();

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(rawNumbers[i]);
        }

        FindTheSequence(numbers);
    }

    private static void FindTheSequence(int[] numbers)
    {
        StringBuilder result = new StringBuilder();
        bool[] visited = new bool[numbers.Length];
        int nextIndex = 0;
        result.Append(nextIndex + " ");

        while (true)
        {
            nextIndex = numbers[nextIndex];

            if (nextIndex < 0 || nextIndex >= numbers.Length)
            {
                result.Length--;
                Console.WriteLine(result.ToString());
                return;
            }
            else if (visited[nextIndex])
            {
                int index = result.ToString().IndexOf(" " + nextIndex + " ");

                result[index] = '(';
                result[result.Length - 1] = ')';
                Console.WriteLine(result.ToString());
                return;
            }
            else
            {
                visited[nextIndex] = true;
                result.Append(nextIndex);
                result.Append(" ");
            }
        }
    }
}